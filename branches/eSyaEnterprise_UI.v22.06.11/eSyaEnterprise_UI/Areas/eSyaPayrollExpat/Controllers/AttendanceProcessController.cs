using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eSyaEnterprise_UI.Areas.eSyaPayrollExpat.Data;
using eSyaEnterprise_UI.Areas.eSyaPayrollExpat.Models;
using eSyaEnterprise_UI.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using eSyaEnterprise_UI.Models;
using Newtonsoft.Json;
using eSyaEnterprise_UI.ActionFilter;

namespace eSyaEnterprise_UI.Areas.eSyaPayrollExpat.Controllers
{
    [SessionTimeout]
    public class AttendanceProcessController : Controller
    {
        private readonly IeSyaPayrollExpatAPIServices _eSyaPayrollExpatAPIServices;
        private readonly ILogger<AttendanceProcessController> _logger;

        public AttendanceProcessController(IeSyaPayrollExpatAPIServices eSyaPayrollExpatAPIServices, ILogger<AttendanceProcessController> logger)
        {
            _eSyaPayrollExpatAPIServices = eSyaPayrollExpatAPIServices;
            _logger = logger;
        }
        [Area("eSyaPayrollExpat")]
        public IActionResult V_4521_00()
        {
           return View();
        }
        
        /// <summary>
        ///Get Pay Period for Drp down
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetPayPeriodbyBusinessKey(int Businesskey)
        {
            try
            {
                var parameter = "?Businesskey=" + Businesskey;
                var serviceResponse = await _eSyaPayrollExpatAPIServices.HttpClientServices.GetAsync<List<DO_PayPeriod>>("AttendanceProcess/GetPayPeriodbyBusinessKey" + parameter);

                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetPayPeriodbyBusinessKey:params:" + JsonConvert.SerializeObject(new { Businesskey }));

                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetPayPeriodbyBusinessKey:params:" + JsonConvert.SerializeObject(new { Businesskey }));
                throw ex;
            }
        }
        /// <summary>
        ///Get All Attandance Process for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetAttendanceProcessbyBusinessKey(int Businesskey,int Payperiod)
        {
            try
            {
                var parameter = "?Businesskey=" + Businesskey + "&Payperiod=" + Payperiod;
                var serviceResponse = await _eSyaPayrollExpatAPIServices.HttpClientServices.GetAsync<List<DO_AttendanceProcess>>("AttendanceProcess/GetAttendanceProcessbyBusinessKey" + parameter);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetAttendanceProcessbyBusinessKey:params:" + JsonConvert.SerializeObject(new { Businesskey }));

                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetEmployeesbyBusinessKey:params:" + JsonConvert.SerializeObject(new { Businesskey }));
                throw ex;
            }
        }

        /// <summary>
        /// Insert or Update Attandance Process
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateAttandanceProcess(List<DO_AttendanceProcess> obj)
        {
            try
            {
                obj.All(c =>
                {
                    c.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                    c.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                    c.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                    return true;
                });

                var serviceResponse = await _eSyaPayrollExpatAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("AttendanceProcess/InsertOrUpdateAttendanceProcess", obj);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateAttandanceProcess:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
            }
        }
        #region Arrear details
        [Area("eSyaPayrollExpat")]
        public IActionResult V_4522_00()
        {
            return View();
        }

        /// <summary>
        ///Get Employees for Drp down
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetEmployeesbyBusinessKey(int Businesskey)
        {
            try
            {
                var parameter = "?Businesskey=" + Businesskey;
                var serviceResponse = await _eSyaPayrollExpatAPIServices.HttpClientServices.GetAsync<List<DO_EmployeeMaster>>("VariableEntry/GetEmployeesbyBusinessKey" + parameter);

                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetEmployeesbyBusinessKey:params:" + JsonConvert.SerializeObject(new { Businesskey }));

                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetEmployeesbyBusinessKey:params:" + JsonConvert.SerializeObject(new { Businesskey }));
                throw ex;
            }
        }

        /// <summary>
        ///Get Paid To for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetPaidToEmployees(int Businesskey, int Payperiod, int employeeNumber)
        {
            try
            {
                var parameter = "?Businesskey=" + Businesskey + "&Payperiod=" + Payperiod + "&employeeNumber=" + employeeNumber;
                var serviceResponse = await _eSyaPayrollExpatAPIServices.HttpClientServices.GetAsync<List<DO_Arreardays>>("AttendanceProcess/GetPaidToEmployees" + parameter);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetPaidToEmployees:params:" + JsonConvert.SerializeObject(new { Businesskey, Payperiod, employeeNumber }));

                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetPaidToEmployees:params:" + JsonConvert.SerializeObject(new { Businesskey, Payperiod, employeeNumber }));
                throw ex;
            }
        }

        /// <summary>
        ///Get Paid To for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetArreardays(int Businesskey, int Payperiod, int employeeNumber)
        {
            try
            {
                var parameter = "?Businesskey=" + Businesskey + "&Payperiod=" + Payperiod + "&employeeNumber=" + employeeNumber;
                var serviceResponse = await _eSyaPayrollExpatAPIServices.HttpClientServices.GetAsync<List<DO_Arreardays>>("AttendanceProcess/GetArreardays" + parameter);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetArreardays:params:" + JsonConvert.SerializeObject(new { Businesskey, Payperiod, employeeNumber }));

                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetArreardays:params:" + JsonConvert.SerializeObject(new { Businesskey, Payperiod, employeeNumber }));
                throw ex;
            }
        }

        /// <summary>
        /// Insert or Update Arrear Details
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateArreardays(List<DO_Arreardays> obj)
        {
            try
            {
                obj.All(c =>
                {
                    c.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                    c.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                    c.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                    return true;
                });

                var serviceResponse = await _eSyaPayrollExpatAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("AttendanceProcess/InsertOrUpdateArreardays", obj);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateArreardays:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
            }
        }
        #endregion Arrear details
    }
}