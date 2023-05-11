using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Text.RegularExpressions;
using eSyaEnterprise_UI.Areas.eSyaPayroll.Data;
using eSyaEnterprise_UI.Areas.eSyaPayroll.Models;
using eSyaEnterprise_UI.Utility;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using eSyaEnterprise_UI.ActionFilter;

namespace eSyaEnterprise_UI.Areas.eSyaPayroll.Controllers
{
    [SessionTimeout]
    public class ERCodesController : Controller
    {
        private readonly IeSyaPayrollAPIServices _eSyaPayrollAPIServices;
        private readonly ILogger<EmployeeController> _logger;

        public ERCodesController(IeSyaPayrollAPIServices eSyaPayrollAPIServices, ILogger<EmployeeController> logger)
        {
            _eSyaPayrollAPIServices = eSyaPayrollAPIServices;
            _logger = logger;
        }
        #region ER Codes
        [Area("eSyaPayroll")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult V_4010_00()
        {
            return View();
        }
       
        /// <summary>
        ///Get All ER Codes for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetAllERCodes()
        {
            try
            {
                var serviceResponse = await _eSyaPayrollAPIServices.HttpClientServices.GetAsync<List<DO_ERCodes>>("ERCodes/GetAllERCodes");

                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetAllERCodes");
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetAllERCodes");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetAllERCodes");
                throw ex;
            }
        }


        /// <summary>
        ///Get ER Code by ER Code
        /// </summary>
        public async Task<JsonResult> GetERCodebyERCode(int ERcode)
        {
            try
            {
                var parameter = "?ERcode=" + ERcode;
                var serviceResponse = await _eSyaPayrollAPIServices.HttpClientServices.GetAsync<DO_ERCodes>("ERCodes/GetERCodebyERCode" + parameter);
                return Json(serviceResponse.Data);
            }
            catch (Exception ex)
            {
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }


        /// <summary>
        /// Insert or Update ER Codes
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateERCodes(bool isInsert, DO_ERCodes obj)
        {
            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                if (isInsert)
                {
                    var serviceResponse = await _eSyaPayrollAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("ERCodes/InsertIntoERCodes", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
                else
                {
                    var serviceResponse = await _eSyaPayrollAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("ERCodes/UpdateERCodes", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateERCodes:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        #endregion ER Codes

        #region ER Rules
        [Area("eSyaPayroll")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> V_4011_00()
        {
            try
            {

                var serviceResponse = await _eSyaPayrollAPIServices.HttpClientServices.GetAsync<List<DO_ERCode>>("ERCodes/GetActiveERCodes");

                if (serviceResponse.Status)
                {
                    ViewBag.ERCodes = serviceResponse.Data.ToList(); 
                    return View();
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetActiveERCodes");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetActiveERCodes");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        ///Get ER Rules by ER Code for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetERRulesbyERCode(int ERCode)
        {
            try
            {
                var parameter = "?ERCode=" + ERCode;
                var serviceResponse = await _eSyaPayrollAPIServices.HttpClientServices.GetAsync<List<DO_ERRules>>("ERCodes/GetERRulesbyERCode" + parameter);

                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetERRulesbyERCode");
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetERRulesbyERCode");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetERRulesbyERCode");
                throw ex;
            }
        }

        /// <summary>
        /// Insert or Update ER Codes
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateERRules(DO_ERRules obj)
        {
            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                var serviceResponse = await _eSyaPayrollAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("ERCodes/InsertOrUpdateERRules", obj);
                if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                
               
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateERRules:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        #endregion ER Rules

        #region ER Rates
        [Area("eSyaPayroll")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> V_4012_00()
        {
            try
            {

                var serviceResponse = await _eSyaPayrollAPIServices.HttpClientServices.GetAsync<List<DO_ERCode>>("ERCodes/GetActiveERCodes");

                if (serviceResponse.Status)
                {
                    ViewBag.ERCodes = serviceResponse.Data.ToList();
                    return View();
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetActiveERCodes");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetActiveERCodes");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        ///Get ER Rates by ER Code for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetERRatesbyERCode(int ERCode)
        {
            try
            {
                var parameter = "?ERCode=" + ERCode;
                var serviceResponse = await _eSyaPayrollAPIServices.HttpClientServices.GetAsync<List<DO_ERRates>>("ERCodes/GetERRatesbyERCode" + parameter);

                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetERRatesbyERCode");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetERRatesbyERCode");
                throw ex;
            }
        }

        /// <summary>
        /// Insert or Update ER Rates
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateERRates(DO_ERRates obj)
        {
            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                var serviceResponse = await _eSyaPayrollAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("ERCodes/InsertOrUpdateERRates", obj);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });


            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateERRates:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        #endregion ER Rates
    }
}