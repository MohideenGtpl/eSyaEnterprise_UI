using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using eSyaEnterprise_UI.ActionFilter;
using eSyaEnterprise_UI.Areas.eSyaPayroll.Data;
using eSyaEnterprise_UI.Areas.eSyaPayroll.Models;
using eSyaEnterprise_UI.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace eSyaEnterprise_UI.Areas.eSyaPayroll.Controllers
{
    [SessionTimeout]
    public class PayPeriodController : Controller
    {
        private readonly IeSyaPayrollAPIServices _eSyaPayrollAPIServices;
        private readonly ILogger<PayPeriodController> _logger;

        public PayPeriodController(IeSyaPayrollAPIServices eSyaPayrollAPIServices, ILogger<PayPeriodController> logger)
        {
            _eSyaPayrollAPIServices = eSyaPayrollAPIServices;
            _logger = logger;
        }
        [Area("eSyaPayroll")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult V_4020_00()
        {
            return View();
        }

        /// <summary>
        ///Get Pay Periods by Business Key for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetPayPeriods()
        {
            try
            {
                var parameter = "?Businesskey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
                var serviceResponse = await _eSyaPayrollAPIServices.HttpClientServices.GetAsync<List<DO_PayPeriod>>("PayPeriod/GetAllPayPeriodsbyBusinessKey" + parameter);
                if (serviceResponse.Status)
                {
                    foreach (var obj in serviceResponse.Data)
                    {

                        if (obj.PayPeriod != 0)
                        {
                            string stryear = obj.PayPeriod.ToString().Substring(0, 4);
                            string strmonth = obj.PayPeriod.ToString().Substring(obj.PayPeriod.ToString().Length - 2);
                            int year = Convert.ToInt32(stryear);
                            int month = Convert.ToInt32(strmonth);
                            DateTime payperiod = new DateTime(year, month, 01);
                            obj.PayPeriodDate = payperiod;
                        }
                    }
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetAllPayPeriodsbyBusinessKey:For BusinessKey {0}", parameter);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetAllPayPeriodsbyBusinessKey");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
               
            }
        }

        /// <summary>
        /// Insert or Update PayPeriod
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateIntoPayPeriod(bool isInsert, DO_PayPeriod obj)
        {
            try
            {
                if (obj.PayPeriodDate != null)
                {
                    int day = obj.PayPeriodDate.Day;
                    int month = obj.PayPeriodDate.Month;
                    int year = obj.PayPeriodDate.Year;
                    if (month >= 1 && month < 10)
                    {
                        string strmonth = "0" + month.ToString();
                        obj.PayPeriod = Convert.ToInt32(year.ToString() + strmonth);
                    }
                    else
                    {
                        obj.PayPeriod = Convert.ToInt32(year.ToString() + month.ToString());
                    }

                }

                obj.BusinessKey= AppSessionVariables.GetSessionBusinessKey(HttpContext);
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                if (isInsert)
                {
                    var serviceResponse = await _eSyaPayrollAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("PayPeriod/InsertIntoPayPeriod", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
                else
                {
                    var serviceResponse = await _eSyaPayrollAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("PayPeriod/UpdateIntoPayPeriod", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateIntoPayPeriod:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
    }
}