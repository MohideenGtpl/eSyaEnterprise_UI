using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eSyaEnterprise_UI.ActionFilter;
using eSyaEnterprise_UI.Areas.DoctorScheduler.Data;
using eSyaEnterprise_UI.Areas.DoctorScheduler.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace eSyaEnterprise_UI.Areas.DoctorScheduler.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly IDoctorAppointmentAPIServices _doctorAppointmentAPIServices;
        private readonly ILogger<AppointmentController> _logger;

        public AppointmentController(IDoctorAppointmentAPIServices doctorAppointmentAPIServices, ILogger<AppointmentController> logger)
        {
            _doctorAppointmentAPIServices = doctorAppointmentAPIServices;
            _logger = logger;
        }

        [Area("DoctorScheduler")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult EDA_01_00()
        {
            return View();
        }
        public int GetWeekNumber(string dayofWeek)
        {
            if (dayofWeek.ToUpper() == "MONDAY")
                return 1;
            else if (dayofWeek.ToUpper() == "TUESDAY")
                return 2;
            else if (dayofWeek.ToUpper() == "WEDNESDAY")
                return 3;
            else if (dayofWeek.ToUpper() == "THURSDAY")
                return 4;
            else if (dayofWeek.ToUpper() == "FRIDAY")
                return 5;
            else if (dayofWeek.ToUpper() == "SATURDAY")
                return 6;
            else if (dayofWeek.ToUpper() == "SUNDAY")
                return 0;
            else
                return 0;
        }

        //    public async Task<JsonResult> GetReferredBy()
        //    {
        //        try
        //        {
        //            var serviceResponse = await _doctorAppointmentAPIServices.HttpClientServices.GetAsync<List<DO_AppCodes>>("CommonMaster/GetApplicationCode?codeType=" + eSyaEnterprise_UI.Areas.eSyaOutPatient.Data.CodeTypeValues.ReferredBy.ToString());
        //            if (serviceResponse.Status)
        //                return Json(serviceResponse.Data);
        //            else
        //            {
        //                _logger.LogError(new Exception(serviceResponse.Message), "UD:GetReferredBy:params:codeType:{0}" + eSyaEnterprise_UI.Areas.eSyaOutPatient.Data.CodeTypeValues.ReferredBy);
        //                return Json(new DO_ResponseParameter() { Status = false, Message = serviceResponse.Message });
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            _logger.LogError(ex, "UD:GetReferredBy:params:codeType:{0}" + eSyaEnterprise_UI.Areas.eSyaOutPatient.Data.CodeTypeValues.ReferredBy);
        //            throw ex;
        //        }
        //    }

        //    public async Task<JsonResult> GetClinicConsultationTypeByBKey()
        //    {
        //        try
        //        {
        //            var serviceResponse = await _doctorAppointmentAPIServices.HttpClientServices.GetAsync<List<DO_ClinicConsultationType>>("DoctorClinic/GetClinicConsultationTypeByBKey?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext));
        //            if (serviceResponse.Status)
        //                return Json(serviceResponse.Data);
        //            else
        //            {
        //                _logger.LogError(new Exception(serviceResponse.Message), "UD:GetClinicConsultationTypeByBKey:params:businessKey:{0}" + AppSessionVariables.GetSessionBusinessKey(HttpContext));
        //                return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            _logger.LogError(ex, "UD:GetClinicConsultationTypeByBKey:params:businessKey:{0}" + AppSessionVariables.GetSessionBusinessKey(HttpContext));
        //            throw ex;
        //        }
        //    }

        //    public async Task<JsonResult> GetSpecialtyListByBKey()
        //    {
        //        try
        //        {
        //            var serviceResponse = await _doctorAppointmentAPIServices.HttpClientServices.GetAsync<List<DO_Specialty>>("DoctorClinic/GetSpecialtyListByBKey?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext));
        //            if (serviceResponse.Status)
        //                return Json(serviceResponse.Data);
        //            else
        //            {
        //                _logger.LogError(new Exception(serviceResponse.Message), "UD:GetSpecialtyListByBKey:params:businessKey:{0}" + AppSessionVariables.GetSessionBusinessKey(HttpContext));
        //                return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            _logger.LogError(ex, "UD:GetSpecialtyListByBKey:params:businessKey:{0}" + AppSessionVariables.GetSessionBusinessKey(HttpContext));
        //            throw ex;
        //        }
        //    }

        //    public async Task<JsonResult> GetDoctorScheduleListByClinicTypeSpecialtyDate(int clinicType, int consultationType,
        //        int specialtyID, DateTime scheduleDate)
        //    {
        //        try
        //        {
        //            var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
        //            parameter += "&clinicType=" + clinicType.ToString();
        //            parameter += "&consultationType=" + consultationType.ToString();
        //            parameter += "&specialtyID=" + specialtyID.ToString();
        //            parameter += "&scheduleDate=" + scheduleDate.ToString("dd-MMM-yyyy");

        //            var serviceResponse = await _doctorAppointmentAPIServices.HttpClientServices.GetAsync<List<DO_DoctorClinicSchedule>>("DoctorClinic/GetDoctorScheduleListByClinicTypeSpecialtyDate" + parameter);
        //            if (serviceResponse.Status)
        //            {
        //                return Json(serviceResponse.Data);
        //            }
        //            else
        //            {
        //                _logger.LogError(new Exception(serviceResponse.Message), string.Format("UD:GetDoctorScheduleListByClinicTypeSpecialtyDate:params: businessKey:{0},clinicType:{1},consultationType:{2},specialtyID:{3},scheduleDate:{4}",
        //                    AppSessionVariables.GetSessionBusinessKey(HttpContext).ToString(), clinicType, consultationType, specialtyID, scheduleDate.ToString()));
        //                return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            _logger.LogError(ex, string.Format("UD:GetDoctorScheduleListByClinicTypeSpecialtyDate:params: businessKey:{0},clinicType:{1},consultationType:{2},specialtyID:{3},scheduleDate:{4}",
        //                    AppSessionVariables.GetSessionBusinessKey(HttpContext).ToString(), clinicType, consultationType, specialtyID, scheduleDate.ToString()));
        //            throw ex;
        //        }
        //    }

        //    public async Task<JsonResult> GetDoctorScheduleHours(int clinicType, int consultationType, int specialtyID, string doctorID, DateTime scheduleDate)
        //    {
        //        try
        //        {

        //            List<Resources> l_rs = new List<Resources>();
        //            TimeSpan sTime = new TimeSpan();
        //            TimeSpan eTime = new TimeSpan();

        //            foreach (string d in doctorID.Split(','))
        //            {

        //                if (d != null)
        //                {
        //                    var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
        //                    parameter += "&clinicType=" + clinicType.ToString();
        //                    parameter += "&consultationType=" + consultationType.ToString();
        //                    parameter += "&specialtyID=" + specialtyID.ToString();
        //                    parameter += "&doctorID=" + doctorID.ToString();
        //                    parameter += "&fromDate=" + scheduleDate.ToString("dd-MMM-yyyy");
        //                    parameter += "&toDate=" + scheduleDate.AddDays(4).ToString("dd-MMM-yyyy");

        //                    var serviceResponse = await _doctorAppointmentAPIServices.HttpClientServices.GetAsync<List<DO_DoctorClinicSchedule>>
        //                        ("DoctorClinic/GetDoctorScheduleListForDoctorDateRange" + parameter);
        //                    if (serviceResponse.Status)
        //                    {
        //                        List<BusinessHours> l_bh = new List<BusinessHours>();

        //                        Resources rs = new Resources();

        //                        foreach (var s in serviceResponse.Data)
        //                        {
        //                            rs.id = s.DoctorId.ToString();
        //                            rs.title = "Dr." + s.DoctorName;

        //                            if (sTime.Hours <= 0 || s.FromTime < sTime)
        //                                sTime = s.FromTime;
        //                            if (eTime.Hours <= 0 || s.ToTime > eTime)
        //                                eTime = s.ToTime;

        //                            BusinessHours bh = new BusinessHours();
        //                            string dayOfWeek = s.ScheduleDate.DayOfWeek.ToString();
        //                            List<int> wk = new List<int>();
        //                            wk.Add(GetWeekNumber(dayOfWeek));
        //                            bh.daysOfWeek = wk;
        //                            bh.startTime = s.FromTime.ToString("hh':'mm");
        //                            bh.endTime = s.ToTime.ToString("hh':'mm");
        //                            l_bh.Add(bh);

        //                        }

        //                        rs.businessHours = l_bh;

        //                        l_rs.Add(rs);
        //                    }
        //                }

        //                if (l_rs.Count() > 0)
        //                {
        //                    var minDate = sTime;
        //                    var maxDate = eTime;

        //                    //if (sTime >= new TimeSpan(8, 00, 00))
        //                    //    minDate = sTime.Subtract(TimeSpan.FromMinutes(30));

        //                    //if (eTime < new TimeSpan(23, 00, 00))
        //                    //    maxDate = eTime.Add(TimeSpan.FromMinutes(30));

        //                    return Json(new { Duration = "00:05", minDate, maxDate, businessHours = l_rs });
        //                }
        //                else
        //                    return Json(new { Duration = "00:05", minDate = "00:00:00", maxDate = "00:00:00", businessHours = l_rs });
        //            }

        //            return Json(new { Duration = "00:05", minDate = "00:00:00", maxDate = "00:00:00", businessHours = l_rs });
        //        }
        //        catch (Exception ex)
        //        {
        //            return Json(new { Status = false, Message = ex.ToString() });
        //        }

        //    }

        //    [HttpPost]
        //    public async Task<JsonResult> InsertIntoDoctorSlotBooking(DO_PatientAppointmentDetail obj)
        //    {
        //        try
        //        {
        //            obj.BusinessKey = AppSessionVariables.GetSessionBusinessKey(HttpContext);
        //            obj.ActiveStatus = true;
        //            obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);
        //            obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
        //            obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

        //            var serviceResponse = await _doctorAppointmentAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("AppointmentBooking/InsertIntoDoctorSlotBooking", obj);
        //            if (serviceResponse.Status)
        //            {
        //                if (serviceResponse.Data.Status)
        //                    return Json(new { Status = true, serviceResponse.Data.Warning, serviceResponse.Data.WarningMessage });
        //                else
        //                    return Json(new { Status = false, serviceResponse.Data.Warning, serviceResponse.Data.WarningMessage, serviceResponse.Data.Message });
        //            }
        //            else
        //            {
        //                _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertIntoDoctorSlotBooking:params:" + JsonConvert.SerializeObject(obj));
        //                return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
        //            }

        //        }
        //        catch (Exception ex)
        //        {
        //            _logger.LogError(ex, "UD:InsertIntoDoctorSlotBooking:params:" + JsonConvert.SerializeObject(obj));
        //            return Json(new { Status = false, Warning = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
        //        }
        //    }

        //    [HttpPost]
        //    public async Task<JsonResult> InsertIntoPatientAppointmentDetail(DO_PatientAppointmentDetail obj)
        //    {
        //        try
        //        {
        //            obj.BusinessKey = AppSessionVariables.GetSessionBusinessKey(HttpContext);
        //            obj.ActiveStatus = true;
        //            obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);
        //            obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
        //            obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

        //            var serviceResponse = await _doctorAppointmentAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("AppointmentBooking/InsertIntoPatientAppointmentDetail", obj);
        //            if (serviceResponse.Status)
        //            {
        //                if (serviceResponse.Data.Status)
        //                    return Json(new { Status = true, QTokenKey = serviceResponse.Data.Key });
        //                else
        //                    return Json(new { Status = false, serviceResponse.Data.Message });
        //            }
        //            else
        //            {
        //                _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertIntoPatientAppointmentDetail:params:" + JsonConvert.SerializeObject(obj));
        //                return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
        //            }

        //        }
        //        catch (Exception ex)
        //        {
        //            _logger.LogError(ex, "UD:InsertIntoPatientAppointmentDetail:params:" + JsonConvert.SerializeObject(obj));
        //            return Json(new { Status = false, Warning = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
        //        }
        //    }

        //    [HttpPost]
        //    public async Task<JsonResult> UpdatePatientAppointmentDetail(DO_PatientAppointmentDetail obj)
        //    {
        //        try
        //        {
        //            obj.BusinessKey = AppSessionVariables.GetSessionBusinessKey(HttpContext);
        //            obj.ActiveStatus = true;
        //            obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);
        //            obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
        //            obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

        //            var serviceResponse = await _doctorAppointmentAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("AppointmentBooking/UpdatePatientAppointmentDetail", obj);
        //            if (serviceResponse.Status)
        //            {
        //                if (serviceResponse.Data.Status)
        //                    return Json(new { Status = true });
        //                else
        //                    return Json(new { Status = false, serviceResponse.Data.Message });
        //            }
        //            else
        //            {
        //                _logger.LogError(new Exception(serviceResponse.Message), "UD:UpdatePatientAppointmentDetail:params:" + JsonConvert.SerializeObject(obj));
        //                return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
        //            }

        //        }
        //        catch (Exception ex)
        //        {
        //            _logger.LogError(ex, "UD:UpdatePatientAppointmentDetail:params:" + JsonConvert.SerializeObject(obj));
        //            return Json(new { Status = false, Warning = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
        //        }
        //    }


        //    [HttpPost]
        //    public async Task<JsonResult> UpdatePatientAppointmentCancellation(DO_PatientAppointmentDetail obj)
        //    {
        //        try
        //        {
        //            obj.BusinessKey = AppSessionVariables.GetSessionBusinessKey(HttpContext);
        //            obj.ActiveStatus = true;
        //            obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);
        //            obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
        //            obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

        //            var serviceResponse = await _doctorAppointmentAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("AppointmentBooking/UpdatePatientAppointmentCancellation", obj);
        //            if (serviceResponse.Status)
        //            {
        //                if (serviceResponse.Data.Status)
        //                    return Json(new { Status = true });
        //                else
        //                    return Json(new { Status = false, serviceResponse.Data.Message });
        //            }
        //            else
        //            {
        //                _logger.LogError(new Exception(serviceResponse.Message), "UD:UpdatePatientAppointmentCancellation:params:" + JsonConvert.SerializeObject(obj));
        //                return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
        //            }

        //        }
        //        catch (Exception ex)
        //        {
        //            _logger.LogError(ex, "UD:UpdatePatientAppointmentCancellation:params:" + JsonConvert.SerializeObject(obj));
        //            return Json(new { Status = false, Warning = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
        //        }
        //    }

        //    [HttpPost]
        //    public async Task<JsonResult> UpdatePatientAppointmentReschedule(DO_PatientAppointmentDetail obj)
        //    {
        //        try
        //        {
        //            obj.BusinessKey = AppSessionVariables.GetSessionBusinessKey(HttpContext);
        //            obj.ActiveStatus = true;
        //            obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);
        //            obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
        //            obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

        //            var serviceResponse = await _doctorAppointmentAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("AppointmentBooking/UpdatePatientAppointmentReschedule", obj);
        //            if (serviceResponse.Status)
        //            {
        //                if (serviceResponse.Data.Status)
        //                    return Json(new { Status = true, QTokenKey = serviceResponse.Data.Key });
        //                else
        //                    return Json(new { Status = false, serviceResponse.Data.Message });
        //            }
        //            else
        //            {
        //                _logger.LogError(new Exception(serviceResponse.Message), "UD:UpdatePatientAppointmentReschedule:params:" + JsonConvert.SerializeObject(obj));
        //                return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
        //            }

        //        }
        //        catch (Exception ex)
        //        {
        //            _logger.LogError(ex, "UD:UpdatePatientAppointmentReschedule:params:" + JsonConvert.SerializeObject(obj));
        //            return Json(new { Status = false, Warning = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
        //        }
        //    }

        //    [HttpPost]
        //    public async Task<JsonResult> UpdatePatientAppointmentToUnScheduleWorkOrder(DO_PatientAppointmentDetail obj)
        //    {
        //        try
        //        {
        //            obj.BusinessKey = AppSessionVariables.GetSessionBusinessKey(HttpContext);
        //            obj.ActiveStatus = true;
        //            obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);
        //            obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
        //            obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

        //            var serviceResponse = await _doctorAppointmentAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("AppointmentBooking/UpdatePatientAppointmentToUnScheduleWorkOrder", obj);
        //            if (serviceResponse.Status)
        //            {
        //                if (serviceResponse.Data.Status)
        //                    return Json(new { Status = true });
        //                else
        //                    return Json(new { Status = false, serviceResponse.Data.Message });
        //            }
        //            else
        //            {
        //                _logger.LogError(new Exception(serviceResponse.Message), "UD:UpdatePatientAppointmentToUnScheduleWorkOrder:params:" + JsonConvert.SerializeObject(obj));
        //                return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
        //            }

        //        }
        //        catch (Exception ex)
        //        {
        //            _logger.LogError(ex, "UD:UpdatePatientAppointmentToUnScheduleWorkOrder:params:" + JsonConvert.SerializeObject(obj));
        //            return Json(new { Status = false, Warning = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
        //        }
        //    }

        //    [HttpPost]
        //    public async Task<JsonResult> UpdateDoctorAppointmentToUnScheduleWorkOrder(DO_PatientAppointmentDetail obj)
        //    {
        //        try
        //        {
        //            obj.BusinessKey = AppSessionVariables.GetSessionBusinessKey(HttpContext);
        //            obj.ActiveStatus = true;
        //            obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);
        //            obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
        //            obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

        //            var serviceResponse = await _doctorAppointmentAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("AppointmentBooking/UpdateDoctorAppointmentToUnScheduleWorkOrder", obj);
        //            if (serviceResponse.Status)
        //            {
        //                if (serviceResponse.Data.Status)
        //                    return Json(new { Status = true });
        //                else
        //                    return Json(new { Status = false, serviceResponse.Data.Message });
        //            }
        //            else
        //            {
        //                _logger.LogError(new Exception(serviceResponse.Message), "UD:UpdateDoctorAppointmentToUnScheduleWorkOrder:params:" + JsonConvert.SerializeObject(obj));
        //                return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
        //            }

        //        }
        //        catch (Exception ex)
        //        {
        //            _logger.LogError(ex, "UD:UpdateDoctorAppointmentToUnScheduleWorkOrder:params:" + JsonConvert.SerializeObject(obj));
        //            return Json(new { Status = false, Warning = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
        //        }
        //    }


        //    [HttpGet]
        //    public async Task<JsonResult> GetDoctorUnScheduleWorkOrder(int specialtyId, int doctorId)
        //    {
        //        try
        //        {
        //            var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
        //            parameter += "&specialtyId=" + specialtyId.ToString();
        //            parameter += "&doctorId=" + doctorId.ToString();

        //            var serviceResponse = await _doctorAppointmentAPIServices.HttpClientServices.GetAsync<List<DO_PatientAppointmentDetail>>("AppointmentBooking/GetDoctorUnScheduleWorkOrder" + parameter);
        //            if (serviceResponse.Status)
        //            {
        //                return Json(serviceResponse.Data);
        //            }
        //            else
        //            {
        //                _logger.LogError(new Exception(serviceResponse.Message), string.Format("UD:GetDoctorUnScheduleWorkOrder:params:SpecialtyID:{0}:DoctorID:{1}", specialtyId, doctorId));
        //                return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
        //            }

        //        }
        //        catch (Exception ex)
        //        {
        //            _logger.LogError(ex, string.Format("UD:GetDoctorUnScheduleWorkOrder:params:SpecialtyID:{0}:DoctorID:{1}", specialtyId, doctorId));
        //            return Json(new { Status = false, Warning = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
        //        }
        //    }


        //    public async Task<JsonResult> GetPatientAppointmentByDoctorDate(int specialtyId,
        //        string doctorId, DateTime start, DateTime end)
        //    {
        //        try
        //        {
        //            List<FullCalendar> l_fc = new List<FullCalendar>();

        //            foreach (string d in doctorId.Split(','))
        //            {
        //                if (d != null)
        //                {
        //                    var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
        //                    parameter += "&specialtyId=" + specialtyId.ToString();
        //                    parameter += "&doctorId=" + d.ToString();
        //                    parameter += "&fromDate=" + start.ToString("yyyy-MM-ddTHH:mm:ss");
        //                    parameter += "&toDate=" + end.ToString("yyyy-MM-ddTHH:mm:ss");

        //                    var serviceResponse = await _doctorAppointmentAPIServices.HttpClientServices.GetAsync<List<DO_PatientAppointmentDetail>>("AppointmentBooking/GetPatientAppointmentByDoctorDate" + parameter);
        //                    if (serviceResponse.Status)
        //                    {

        //                        foreach (var s in serviceResponse.Data)
        //                        {
        //                            FullCalendar fc = new FullCalendar();
        //                            fc.id = Math.Round(s.AppointmentKey, 0).ToString();
        //                            fc.resourceId = d.ToString();
        //                            fc.title = Math.Round(s.AppointmentKey, 0).ToString() + " - " + s.PatientFirstName.ToString() + " " + s.PatientLastName;
        //                            fc.start = s.StartDate;
        //                            fc.end = s.EndDate;
        //                            if (s.AppointmentStatus == "AP")
        //                                fc.color = "#bfbfbf";
        //                            if (s.AppointmentStatus == "RG")
        //                                fc.color = "#ffff80";
        //                            if (s.AppointmentStatus == "CM")
        //                                fc.color = "#66ff66";

        //                            fc.status = s.AppointmentStatus;
        //                            l_fc.Add(fc);
        //                        }
        //                    }
        //                    else
        //                    {
        //                        _logger.LogError(new Exception(serviceResponse.Message), string.Format("UD:GetPatientAppointmentByDoctorDate:params:businessKey:{0}:specialtyId:{1}:doctorId{2}:start:{3}:end:{4}",
        //                            AppSessionVariables.GetSessionBusinessKey(HttpContext), specialtyId, doctorId, start, end));
        //                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
        //                    }
        //                }
        //            }

        //            return Json(l_fc);

        //        }
        //        catch (Exception ex)
        //        {
        //            _logger.LogError(ex, string.Format("UD:GetPatientAppointmentByDoctorDate:params:businessKey:{0}:specialtyId:{1}:doctorId{2}:start:{3}:end:{4}",
        //                           AppSessionVariables.GetSessionBusinessKey(HttpContext), specialtyId, doctorId, start, end));
        //            return Json(new { Status = false, Warning = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
        //        }

        //    }


        //    public async Task<JsonResult> GetPatientAppointmentDetailByAppkey(decimal appointmentKey)
        //    {
        //        try
        //        {

        //            var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext).ToString();
        //            parameter += "&appointmentKey=" + appointmentKey.ToString();

        //            var serviceResponse = await _doctorAppointmentAPIServices.HttpClientServices.GetAsync<DO_PatientAppointmentDetail>("AppointmentBooking/GetPatientAppointmentDetailByAppkey" + parameter);
        //            if (serviceResponse.Status)
        //            {
        //                return Json(serviceResponse.Data);
        //            }
        //            else
        //            {
        //                _logger.LogError(new Exception(serviceResponse.Message), string.Format("UD:GetPatientAppointmentDetailByAppkey:params:businessKey:{0}:appointmentKey:{1}", AppSessionVariables.GetSessionBusinessKey(HttpContext), appointmentKey));
        //                return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            _logger.LogError(ex, string.Format("UD:GetPatientAppointmentDetailByAppkey:params:businessKey:{0}:appointmentKey:{1}", AppSessionVariables.GetSessionBusinessKey(HttpContext), appointmentKey));
        //            return Json(new { Status = false, Warning = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
        //        }

        //    }


        //    [HttpPost]
        //    public async Task<JsonResult> SaveRegisterPatientAppointment(DO_PatientAppointmentDetail obj)
        //    {
        //        try
        //        {
        //            obj.BusinessKey = AppSessionVariables.GetSessionBusinessKey(HttpContext);
        //            obj.ActiveStatus = true;
        //            obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);
        //            obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
        //            obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

        //            var serviceResponse = await _doctorAppointmentAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("OPRegistration/InsertInToPatientOPRegistration", obj);
        //            if (serviceResponse.Status)
        //            {
        //                if (serviceResponse.Data.Status)
        //                    return Json(new { Status = true });
        //                else
        //                    return Json(new { Status = false, serviceResponse.Data.Message });
        //            }
        //            else
        //            {
        //                _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertInToPatientOPRegistration:params:" + JsonConvert.SerializeObject(obj));
        //                return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
        //            }

        //        }
        //        catch (Exception ex)
        //        {
        //            _logger.LogError(ex, "UD:InsertInToPatientOPRegistration:params:" + JsonConvert.SerializeObject(obj));
        //            return Json(new { Status = false, Warning = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
        //        }
        //    }

        //    public async Task<JsonResult> GetPatientSearch(string searchText)
        //    {
        //        try
        //        {
        //            string term = HttpContext.Request.Query["term"].ToString();
        //            var parameter = "?searchText=" + term;

        //            var serviceResponse = await _doctorAppointmentAPIServices.HttpClientServices.GetAsync<List<DO_PatientProfile>>("OPRegistration/GetPatientSearch" + parameter);
        //            if (serviceResponse.Status)
        //            {
        //                var d = serviceResponse.Data;
        //                d.ForEach(w => { w.value = w.FirstName + " " + w.LastName; w.label = w.FirstName + " " + w.LastName + " ( ph: " + w.MobileNumber + " )"; });
        //                return Json(d);
        //            }
        //            else
        //            {
        //                _logger.LogError(new Exception(serviceResponse.Message), string.Format("UD:GetPatientSearch:params:searchText:{0}", searchText));
        //                return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            _logger.LogError(ex, string.Format("UD:GetPatientSearch:params:searchText:{0}", searchText));
        //            return Json(new { Status = false, Warning = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
        //        }

        //    }

    }

    public class FullCalendar
    {
        public string id { get; set; }
        public string resourceId { get; set; }
        public string title { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }

        public string color { get; set; }
        public string status { get; set; }
    }

    public class Resources
    {
        public string id { get; set; }
        public string title { get; set; }
        public List<BusinessHours> businessHours { get; set; }
    }

    public class BusinessHours
    {
        public List<int> daysOfWeek { get; set; }
        public string startTime { get; set; }
        public string endTime { get; set; }
    }

}