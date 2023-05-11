﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eSyaEnterprise_UI.Areas.eSyaPayrollExpat.Data;
using eSyaEnterprise_UI.Areas.eSyaPayrollExpat.Models;
using eSyaEnterprise_UI.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using eSyaEnterprise_UI.Models;
using eSyaEnterprise_UI.ActionFilter;

namespace eSyaEnterprise_UI.Areas.eSyaPayrollExpat.Controllers
{
    [SessionTimeout]
    public class SalaryProcessController : Controller
    {
        private readonly IeSyaPayrollExpatAPIServices _eSyaPayrollExpatAPIServices;
        private readonly ILogger<SalaryProcessController> _logger;

        public SalaryProcessController(IeSyaPayrollExpatAPIServices eSyaPayrollExpatAPIServices, ILogger<SalaryProcessController> logger)
        {
            _eSyaPayrollExpatAPIServices = eSyaPayrollExpatAPIServices;
            _logger = logger;
        }

        [Area("eSyaPayrollExpat")]
        public IActionResult V_4531_00()
        {
            return View();
        }

        public async Task<JsonResult> GetCurrencyExchangeRate(int businessKey, int payPeriod)
        {
            try
            {
                var parameter = "?businessKey=" + businessKey;
                parameter += "&payPeriod=" + payPeriod;
                var serviceResponse = await _eSyaPayrollExpatAPIServices.HttpClientServices.GetAsync<List<DO_Currency>>("PayrollProcess/GetCurrencyExchangeRate"+ parameter);

                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetCurrencyExchangeRate");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetCurrencyExchangeRate");
                throw ex;
            }
        }

        public async Task<JsonResult> GetEmployeeForPayrollProcess(int businessKey, int payPeriod, string payrollProcessStatus)
        {
            try
            {
                var parameter = "?businessKey=" + businessKey;
                parameter += "&payPeriod=" + payPeriod;

                string URL = "PayrollProcess/GetEmployeeForPayrollProcess";
                if (payrollProcessStatus == "P")
                    URL = "PayrollProcess/GetEmployeeForPayrollProcess_Redo";
                if (payrollProcessStatus == "A")
                    URL = "PayrollProcess/GetAllSalaryEmployeeForPayPeriod";

                var serviceResponse = await _eSyaPayrollExpatAPIServices.HttpClientServices.GetAsync<List<DO_PayrollProcess>>(URL + parameter);

                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetEmployeeForPayrollProcess");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetEmployeeForPayrollProcess");
                throw ex;
            }
        }

       

        [HttpPost]
        public JsonResult InsertIntoPayrollProcess(List<DO_PayrollProcess> obj)
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

                var serviceResponse = _eSyaPayrollExpatAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("PayrollProcess/InsertIntoPayrollProcess", obj).Result;
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertIntoPayrollProcess:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertIntoPayrollProcess:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        public async Task<JsonResult> GetPayrollProcessedEmployee(int businessKey, int payPeriod)
        {
            try
            {
                var parameter = "?businessKey=" + businessKey;
                parameter += "&payPeriod=" + payPeriod;

                var serviceResponse = await _eSyaPayrollExpatAPIServices.HttpClientServices.GetAsync<List<DO_PayrollProcess>>("PayrollProcess/GetPayrollProcessedEmployee" + parameter);

                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetPayrollProcessedEmployee");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetPayrollProcessedEmployee");
                throw ex;
            }
        }

        [Area("eSyaPayrollExpat")]
        public IActionResult V_4534_00()
        {
            return View();
        }

        public async Task<JsonResult> GetSalaryRegister(int businessKey, int payPeriod)
        {
            try
            {
                var parameter = "?businessKey=" + businessKey;
                parameter += "&payPeriod=" + payPeriod;

                var serviceResponse = await _eSyaPayrollExpatAPIServices.HttpClientServices.GetAsync<List<DO_PayrollProcess>>("PayrollProcess/GetSalaryRegister" + parameter);

                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetSalaryRegister");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetSalaryRegister");
                throw ex;
            }
        }

    }
}