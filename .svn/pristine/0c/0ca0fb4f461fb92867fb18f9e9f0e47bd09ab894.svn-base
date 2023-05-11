using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eSyaEnterprise_UI.Areas.PatientManagement.Data;
using eSyaEnterprise_UI.Areas.PatientManagement.Models;
using eSyaEnterprise_UI.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace eSyaEnterprise_UI.Areas.PatientManagement.Controllers
{
    public class SuspendOpBillController : Controller
    {
        private readonly IPatientManagementAPIServices _patientManagementAPIServices;
        private readonly ILogger<SuspendOpBillController> _logger;

        public SuspendOpBillController(IPatientManagementAPIServices patientManagementAPIServices, ILogger<SuspendOpBillController> logger)
        {
            _patientManagementAPIServices = patientManagementAPIServices;
            _logger = logger;
        }

        [HttpPost]
        public async Task<JsonResult> CreateSuspendOpBill(DO_PatientBillHeader obj)
        {
            try
            {
                obj.BusinessKey = AppSessionVariables.GetSessionBusinessKey(HttpContext);
                obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

                var serviceResponse = await _patientManagementAPIServices.HttpClientServices.PostAsJsonAsync<DO_ResponseParameter>("SuspendOpBill/SuspendOpBill", obj);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new { Status = false, serviceResponse.Data.Warning, serviceResponse.Data.WarningMessage, serviceResponse.Data.Message });
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:SuspendOpBill:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ResponseParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:SuspendOpBill:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Warning = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
            }
        }

        public async Task<IActionResult> GetSuspendOpBillListForConfirmation(DateTime billFromDate, DateTime billTillDate)
        {
            try
            {
                var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
                parameter += "&billFromDate=" + billFromDate;
                parameter += "&billTillDate=" + billTillDate;

                var serviceResponse = await _patientManagementAPIServices.HttpClientServices.GetAsync<List<DO_OpBillDetail>>("SuspendOpBill/GetSuspendOpBillListForConfirmation" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetSuspendOpBillListForConfirmation");
                    return Json(new DO_ResponseParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetSuspendOpBillListForConfirmation");
                throw ex;
            }
        }

        public async Task<IActionResult> GetSuspendOpBillHeader(long suspendBillKey)
        {
            try
            {
                var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
                parameter += "&suspendBillKey=" + suspendBillKey;

                var serviceResponse = await _patientManagementAPIServices.HttpClientServices.GetAsync<DO_PatientBillHeader>("SuspendOpBill/GetSuspendOpBillHeader" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetSuspendOpBillHeader");
                    return Json(new DO_ResponseParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetSuspendOpBillHeader");
                throw ex;
            }
        }


        public async Task<IActionResult> GetSuspendOpBillDetails(long suspendBillKey)
        {
            try
            {
                var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
                parameter += "&suspendBillKey=" + suspendBillKey;

                var serviceResponse = await _patientManagementAPIServices.HttpClientServices.GetAsync<List<DO_PatientBillDetails>>("SuspendOpBill/GetSuspendOpBillDetails" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetSuspendOpBillDetails");
                    return Json(new DO_ResponseParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetSuspendOpBillDetails");
                throw ex;
            }
        }

    }
}