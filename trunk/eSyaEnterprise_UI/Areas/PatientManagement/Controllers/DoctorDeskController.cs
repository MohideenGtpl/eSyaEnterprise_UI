using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eSyaEnterprise_UI.Areas.PatientManagement.Data;
using eSyaEnterprise_UI.Areas.PatientManagement.Models;
using eSyaEnterprise_UI.Models;
using eSyaEnterprise_UI.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace eSyaEnterprise_UI.Areas.PatientManagement.Controllers
{
    public class DoctorDeskController : Controller
    {
        private readonly IPatientManagementAPIServices _patientManagementAPIServices;
        private readonly ILogger<RegistrationController> _logger;

        public DoctorDeskController(IPatientManagementAPIServices patientManagementAPIServices, ILogger<RegistrationController> logger)
        {
            _patientManagementAPIServices = patientManagementAPIServices;
            _logger = logger;
        }

        [Area("PatientManagement")]
        public IActionResult DoctorDesk()
        {
            return View();
        }
        [Area("PatientManagement")]
        public IActionResult _TodaysAppointment()
        {
            return View();
        }

        [Area("PatientManagement")]
        public IActionResult _DoctorSchedule()
        {
            return View();
        }
        [Area("PatientManagement")]
        public IActionResult _DoctorLeave()
        {
            return View();
        }
        [Area("PatientManagement")]
        public IActionResult _SearchPatient()
        {
            return View();
        }
        [Area("PatientManagement")]
        public IActionResult _InPatient()
        {
            return View();
        }
        [Area("PatientManagement")]
        public IActionResult TriageList()
        {
            return View();
        }


        public async Task<IActionResult> GetAppointmentDetailByDate(int doctorId, DateTime startDate, DateTime endDate)
        {
            try
            {
                var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
                if(doctorId == -1)
                {
                    parameter += "&doctorId=-1";
                }
                else
                {
                    parameter += "&doctorId=" + AppSessionVariables.GetSessionDoctorID(HttpContext);
                }
                parameter += "&startDate=" + startDate.ToString("dd-MMM-yyyy");
                parameter += "&endDate=" + endDate.ToString("dd-MMM-yyyy");
                var serviceResponse = await _patientManagementAPIServices.HttpClientServices.GetAsync<List<DO_PatientAppointmentDetail>>("DoctorDesk/GetAppointmentDetailByDate" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetAppointmentDetailByDate:params:businessKey:{0},startDate:{1},endDate:{2}" + AppSessionVariables.GetSessionBusinessKey(HttpContext), startDate, endDate);
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetAppointmentDetailByDate:params:businessKey:{0},startDate:{1},endDate:{2}" + AppSessionVariables.GetSessionBusinessKey(HttpContext), startDate, endDate);
                throw ex;
            }


        }

        public async Task<IActionResult> GetAppointmentDetailByUHID(long uhid)
        {
            try
            {
                var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
                parameter += "&uhid=" + uhid;
                var serviceResponse = await _patientManagementAPIServices.HttpClientServices.GetAsync<List<DO_PatientAppointmentDetail>>("DoctorDesk/GetAppointmentDetailByUHID" + parameter);
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

        public JsonResult GetDoctorScheduleList(int businessKey, int doctorId)
        {
            try
            {
                var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
                    parameter += "&doctorId=" + AppSessionVariables.GetSessionDoctorID(HttpContext);
                var serviceResponse = _patientManagementAPIServices.HttpClientServices.GetAsync<List<DO_DoctorSchedule>>("DoctorDesk/GetDoctorScheduleList" + parameter).Result;
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetDoctorScheduleList:params:businessKey:{0},doctorId:{1}" + AppSessionVariables.GetSessionBusinessKey(HttpContext), AppSessionVariables.GetSessionDoctorID(HttpContext));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetDoctorScheduleList:params:businessKey:{0},doctorId:{1}" + AppSessionVariables.GetSessionBusinessKey(HttpContext), AppSessionVariables.GetSessionDoctorID(HttpContext));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        public JsonResult GetLastOPNumber(long uhid)
        {
            try
            {
                var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
                parameter += "&uhid=" + uhid;
                var serviceResponse = _patientManagementAPIServices.HttpClientServices.GetAsync<long>("DoctorDesk/GetLastOPNumber" + parameter).Result;
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetLastOPNumber:params:businessKey:{0},uhid:{1}" + AppSessionVariables.GetSessionBusinessKey(HttpContext), uhid);
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetLastOPNumber:params:businessKey:{0},uhid:{1}" + AppSessionVariables.GetSessionBusinessKey(HttpContext), uhid);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
    }
}