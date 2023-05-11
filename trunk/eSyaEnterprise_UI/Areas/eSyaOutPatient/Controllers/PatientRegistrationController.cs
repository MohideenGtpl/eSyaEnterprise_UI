using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eSyaEnterprise_UI.ActionFilter;
using eSyaEnterprise_UI.Areas.eSyaOutPatient.Data;
using eSyaEnterprise_UI.Areas.eSyaOutPatient.Models;
using eSyaEnterprise_UI.Models;
using eSyaEnterprise_UI.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace eSyaEnterprise_UI.Areas.eSyaOutPatient.Controllers
{
    [SessionTimeout]
    public class PatientRegistrationController : Controller
    {
        private readonly IeSyaOutPatientAPIServices _eSyaOutPatientAPIServices;
        private readonly ILogger<AppointmentSchedularController> _logger;

        public PatientRegistrationController(IeSyaOutPatientAPIServices eSyaOutPatientAPIServices, ILogger<AppointmentSchedularController> logger)
        {
            _eSyaOutPatientAPIServices = eSyaOutPatientAPIServices;
            _logger = logger;
        }


        [Area("eSyaOutPatient")]
        public IActionResult V_3021_00()
        {
            return View();
        }
        [Area("eSyaOutPatient")]
        public IActionResult V_3022_00()
        {
            ViewBag.UT = AppSessionVariables.GetSessionUserType(HttpContext);
            return View();
        }
        [Area("eSyaOutPatient")]
        public IActionResult V_3023_00()
        {
            return View();
        }
        public async Task<IActionResult> GetAppointmentDetailByDate( DateTime startDate, DateTime endDate, string vType, string status)
        {
            try
            {
                var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
                parameter += "&startDate=" + startDate.ToString("dd-MMM-yyyy");
                parameter += "&endDate=" + endDate.ToString("dd-MMM-yyyy");
                parameter += "&vType=" + vType.ToString();
                parameter += "&status=" + status.ToString();
                var serviceResponse = await _eSyaOutPatientAPIServices.HttpClientServices.GetAsync<List<DO_PatientAppointmentDetail>>("PatientRegistration/GetAppointmentDetailByDate" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetAppointmentDetailByDate:params:businessKey:{0},startDate:{1},endDate:{2},status:{3}" + AppSessionVariables.GetSessionBusinessKey(HttpContext),startDate,endDate,status);
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetAppointmentDetailByDate:params:businessKey:{0},startDate:{1},endDate:{2},status:{3}" + AppSessionVariables.GetSessionBusinessKey(HttpContext), startDate, endDate, status);
                throw ex;
            }
           

        }

        public async Task<IActionResult> GetPatientByUHID(int uhid)
        {
            try
            {
                var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
                parameter += "&uhid=" + uhid.ToString();
                var serviceResponse = await _eSyaOutPatientAPIServices.HttpClientServices.GetAsync<List<DO_PatientAppointmentDetail>>("PatientRegistration/GetPatientByUHID" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetPatientByUHID:params:businessKey:{0},uhid:{1}" + AppSessionVariables.GetSessionBusinessKey(HttpContext), uhid);
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetPatientByUHID:params:businessKey:{0},uhid:{1}" + AppSessionVariables.GetSessionBusinessKey(HttpContext), uhid);
                throw ex;
            }
        }

        public async Task<IActionResult> GetAppointmentDetailByUHID(int uhid)
        {
            try
            {
                var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
                parameter += "&uhid=" + uhid.ToString();
                var serviceResponse = await _eSyaOutPatientAPIServices.HttpClientServices.GetAsync<List<DO_PatientAppointmentDetail>>("PatientRegistration/GetAppointmentDetailByUHID" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetAppointmentDetailByUHID:params:businessKey:{0},uhid:{1}" + AppSessionVariables.GetSessionBusinessKey(HttpContext), uhid);
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetAppointmentDetailByUHID:params:businessKey:{0},uhid:{1}" + AppSessionVariables.GetSessionBusinessKey(HttpContext), uhid);
                throw ex;
            }


        }

        [HttpPost]
        public async Task<JsonResult> InsertInToPatientMaster(DO_PatientData obj)
        {
            try
            {
                obj.BusinessKey = AppSessionVariables.GetSessionBusinessKey(HttpContext);
                obj.ActiveStatus = true;
                obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

                var serviceResponse = await _eSyaOutPatientAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("OPRegistration/InsertInToPatientMaster", obj);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data.Status)
                        return Json(new { Status = true });
                    else
                        return Json(new { Status = false, serviceResponse.Data.Message });
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertInToPatientMaster:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertInToPatientMaster:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Warning = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
            }
        }
        [HttpPost]
        public async Task<JsonResult> AddDummyVisit(DO_PatientAppointmentDetail obj)
        {
            try
            {
                obj.BusinessKey = AppSessionVariables.GetSessionBusinessKey(HttpContext);
                var serviceResponse = await _eSyaOutPatientAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("PatientRegistration/AddDummyVisit", obj);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data.Status)
                        return Json(new { Status = true, serviceResponse.Data.Message });
                    else
                        return Json(new { Status = false, serviceResponse.Data.Message });
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:AddDummyVisit:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:AddDummyVisit:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Warning = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
            }
        }

        [HttpPost]
        public async Task<JsonResult> UpdateVisitType(DO_PatientAppointmentDetail obj)
        {
            try
            {
                obj.BusinessKey = AppSessionVariables.GetSessionBusinessKey(HttpContext);
                obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                var serviceResponse = await _eSyaOutPatientAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("PatientRegistration/UpdateVisitType", obj);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data.Status)
                        return Json(new { Status = true, serviceResponse.Data.Message });
                    else
                        return Json(new { Status = false, serviceResponse.Data.Message });
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:UpdateVisitType:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:UpdateVisitType:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Warning = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
            }
        }

        [HttpPost]
        public async Task<JsonResult> UpdateAppointmentToCompleted(DO_PatientAppointmentDetail obj)
        {
            try
            {
                obj.BusinessKey = AppSessionVariables.GetSessionBusinessKey(HttpContext);
                obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                var serviceResponse = await _eSyaOutPatientAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("PatientRegistration/UpdateAppointmentToCompleted", obj);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data.Status)
                        return Json(new { Status = true, serviceResponse.Data.Message });
                    else
                        return Json(new { Status = false, serviceResponse.Data.Message });
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:UpdateAppointmentToCompleted:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:UpdateAppointmentToCompleted:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Warning = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
            }
        }

        [HttpPost]
        public async Task<JsonResult> InsertPatientReceipt(DO_PatientReceiptDetail obj)
        {
            try
            {
                obj.BusinessKey = AppSessionVariables.GetSessionBusinessKey(HttpContext);
                obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                var serviceResponse = await _eSyaOutPatientAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("PatientRegistration/InsertPatientReceipt", obj);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data.Status)
                        return Json(new { Status = true, serviceResponse.Data.Message });
                    else
                        return Json(new { Status = false, serviceResponse.Data.Message });
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertPatientReceipt:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertPatientReceipt:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Warning = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
            }
        }

        public async Task<JsonResult> GetPaymentReason()
        {
            try
            {
                var serviceResponse = await _eSyaOutPatientAPIServices.HttpClientServices.GetAsync<List<DO_AppCodes>>("CommonMaster/GetApplicationCode?codeType=" + eSyaEnterprise_UI.Areas.eSyaOutPatient.Data.CodeTypeValues.PaymentReason.ToString());
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetPaymentReason:params:codeType:{0}" + eSyaEnterprise_UI.Areas.eSyaOutPatient.Data.CodeTypeValues.PaymentReason);
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetPaymentReason:params:codeType:{0}" + eSyaEnterprise_UI.Areas.eSyaOutPatient.Data.CodeTypeValues.PaymentReason);
                throw ex;
            }
        }
        public async Task<IActionResult> GetPaymentDetail(int appKey)
        {
            try
            {
                var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
                parameter += "&appKey=" + appKey.ToString();
                var serviceResponse = await _eSyaOutPatientAPIServices.HttpClientServices.GetAsync<DO_PatientReceiptDetail>("PatientRegistration/GetPaymentDetail" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetPaymentDetail:params:businessKey:{0},appKey:{1}" + AppSessionVariables.GetSessionBusinessKey(HttpContext), appKey);
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetPaymentDetail:params:businessKey:{0},appKey:{1}" + AppSessionVariables.GetSessionBusinessKey(HttpContext), appKey);
                throw ex;
            }


        }

        public async Task<IActionResult> GetPatientList()
        {
            try
            {
                var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
                var serviceResponse = await _eSyaOutPatientAPIServices.HttpClientServices.GetAsync<List<DO_PatientData>>("PatientRegistration/GetPatientList" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetPatientList:params:businessKey:{0}" + AppSessionVariables.GetSessionBusinessKey(HttpContext));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetPatientList:params:businessKey:{0}" + AppSessionVariables.GetSessionBusinessKey(HttpContext));
                throw ex;
            }


        }
        [HttpPost]
        public async Task<JsonResult> UpdatePatientData(DO_PatientData obj)
        {
            try
            {
                obj.BusinessKey = AppSessionVariables.GetSessionBusinessKey(HttpContext);
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                var serviceResponse = await _eSyaOutPatientAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("PatientRegistration/UpdatePatientData", obj);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data.Status)
                        return Json(new { Status = true, serviceResponse.Data.Message });
                    else
                        return Json(new { Status = false, serviceResponse.Data.Message });
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:UpdatePatientData:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:UpdatePatientData:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Warning = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
            }
        }
    }
}