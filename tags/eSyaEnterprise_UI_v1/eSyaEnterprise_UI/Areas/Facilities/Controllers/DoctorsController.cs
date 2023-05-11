﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;
using eSyaEnterprise_UI.Areas.Facilities.Data;
using eSyaEnterprise_UI.Areas.Facilities.Models;
using eSyaEnterprise_UI.Utility;
using eSyaEnterprise_UI.ActionFilter;
using eSyaEnterprise_UI.Extension;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;
namespace eSyaEnterprise_UI.Areas.Facilities.Controllers
{
    public class DoctorsController : Controller
    {
        private readonly IFacilityAPIServices _facilityAPIServices;
        private readonly ILogger<DoctorsController> _logger;
        private readonly IHostingEnvironment _appEnvironment;
        public DoctorsController(IFacilityAPIServices facilityAPIServices, ILogger<DoctorsController> logger, IHostingEnvironment hostingEnvironment)
        {
            _facilityAPIServices = facilityAPIServices;
            _logger = logger;
            _appEnvironment = hostingEnvironment;
        }

        #region Manage Doctors
        [Area("Facilities")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult EFM_06_00()
        {

            List<int> l_ac = new List<int>();
            l_ac.Add(Areas.eSyaClinicalServices.Data.CodeTypeValues.DoctorClass);
            l_ac.Add(Areas.eSyaClinicalServices.Data.CodeTypeValues.DoctorCategory);
            var response = _facilityAPIServices.HttpClientServices.PostAsJsonAsync<List<DO_ApplicationCodes>>("CommonData/GetApplicationCodesByCodeTypeList", l_ac).Result;
            if (response.Status)
            {
                List<DO_ApplicationCodes> ac = response.Data.Where(x => x.CodeType == Areas.eSyaClinicalServices.Data.CodeTypeValues.DoctorClass).ToList();
                //ViewBag.doctorClassList = ac;
                ViewBag.doctorClassList = ac.Select(a => new SelectListItem
                {
                    Text = a.CodeDesc,
                    Value = a.ApplicationCode.ToString()
                });

                ac = response.Data.Where(x => x.CodeType == Areas.eSyaClinicalServices.Data.CodeTypeValues.DoctorCategory).ToList();
                //ViewBag.doctorCategoryList = ac;
                ViewBag.doctorCategoryList = ac.Select(a => new SelectListItem
                {
                    Text = a.CodeDesc,
                    Value = a.ApplicationCode.ToString()
                });
            }
            else
            {
                ViewBag.doctorClass = null;
                ViewBag.doctorCategory = null;
            }

            var responseISDCodes = _facilityAPIServices.HttpClientServices.GetAsync<List<DO_CountryCodes>>("CommonData/GetISDCodes").Result;
            if (responseISDCodes.Status)
                ViewBag.ISDCodesList = responseISDCodes.Data.Select(x => new SelectListItem
                {
                    Text = x.Isdcode.ToString() + "-" + x.CountryName,
                    Value = x.Isdcode.ToString()
                });
            else
                ViewBag.ISDCodesList = null;

            var responseBusinessList = _facilityAPIServices.HttpClientServices.GetAsync<List<DO_BusinessLocation>>("CommonData/GetBusinessKey").Result;
            ViewBag.BusinessKeyList = responseBusinessList.Data.Select(a => new SelectListItem
            {
                Text = a.LocationDescription,
                Value = a.BusinessKey.ToString()
            });

            ViewBag.formName = "Doctor Master";
            return View();
        }

        /// <summary>
        /// Insert Doctor Master
        /// </summary>
        [HttpPost]
        public JsonResult InsertDoctorMaster(DO_DoctorMaster obj)
        {
            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);

                var Insertresponse = _facilityAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("DoctorMaster/InsertIntoDoctorMaster", obj).Result;
                return Json(Insertresponse.Data);

            }
            catch (Exception ex)
            {
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Update Doctor Master
        /// </summary>
        [HttpPost]
        public JsonResult UpdateDoctorMaster(DO_DoctorMaster obj)
        {
            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

                var response = _facilityAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("DoctorMaster/UpdateDoctorMaster", obj).Result;
                return Json(response.Data);

            }
            catch (Exception ex)
            {
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Get Doctor Master List
        /// </summary>
        [HttpGet]
        public JsonResult GetDoctorMasterList(string doctorNamePrefix)
        {
            try
            {
                var response = _facilityAPIServices.HttpClientServices.GetAsync<List<DO_DoctorMaster>>("DoctorMaster/GetDoctorMasterListForPrefix?doctorNamePrefix=" + doctorNamePrefix).Result;
                if (response.Status)
                {
                    return Json(response.Data);
                }
                else
                {
                    return Json(new DO_ReturnParameter()
                    {
                        Status = false,
                        StatusCode = response.StatusCode.ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Get Doctor Master List
        /// </summary>
        [HttpPost]
        public JsonResult GetDoctorMaster(int doctorId)
        {
            try
            {
                var response = _facilityAPIServices.HttpClientServices.GetAsync<DO_DoctorMaster>("DoctorMaster/GetDoctorMaster?doctorId=" + doctorId).Result;
                if (response.Status)
                {
                    return Json(response.Data);
                }
                else
                {
                    return Json(new DO_ReturnParameter()
                    {
                        Status = false,
                        StatusCode = response.StatusCode.ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Get Doctor Master List
        /// </summary>
        [HttpPost]
        public JsonResult GetDoctorBusinessList(int doctorId)
        {
            try
            {
                var response = _facilityAPIServices.HttpClientServices.GetAsync<List<DO_BusinessLocation>>("DoctorMaster/GetDoctorBusinessKey?doctorId=" + doctorId).Result;
                if (response.Status)
                {
                    return Json(response.Data);
                }
                else
                {
                    return Json(new DO_ReturnParameter()
                    {
                        Status = false,
                        StatusCode = response.StatusCode.ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Activate or De Activate Doctor
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> ActiveOrDeActiveDoctor(bool status, int doctorId)
        {

            try
            {

                var parameter = "?status=" + status + "&doctorId=" + doctorId;
                var serviceResponse = await _facilityAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("DoctorMaster/ActiveOrDeActiveDoctor" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ActiveOrDeActiveDoctor:For doctorId {0} ", doctorId);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// GetBusiness key by Doctor Id for dropdown
        /// </summary>
        [HttpPost]
        public JsonResult GetDoctorLocationbyDoctorId(int doctorId)
        {
            try
            {
                var response = _facilityAPIServices.HttpClientServices.GetAsync<List<DO_BusinessLocation>>("DoctorMaster/GetDoctorLocationbyDoctorId?doctorId=" + doctorId).Result;
                if (response.Status)
                {
                    return Json(response.Data);
                }
                else
                {
                    return Json(new DO_ReturnParameter()
                    {
                        Status = false,
                        StatusCode = response.StatusCode.ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }


        /// <summary>
        /// Doctor Codes Partial View
        /// </summary>
        [Area("eSyaClinicalServices")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult _DoctorCodes()
        {
            return View();
        }


        /// <summary>
        /// Doctor Schedule Partial View
        /// </summary>
        [Area("eSyaClinicalServices")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult _DoctorSchedule()
        {
            return View();
        }

        /// <summary>
        /// Get Specialty List
        /// </summary>
        [HttpPost]
        public JsonResult GetSpecialtyListByBKeyDoctorId(int businessKey, int doctorId)
        {
            try
            {
                var response = _facilityAPIServices.HttpClientServices.GetAsync<List<DO_SpecialtyDoctorLink>>("DoctorMaster/GetSpecialtyListByBKeyDoctorId?businessKey=" + businessKey + "&doctorId=" + doctorId).Result;
                if (response.Status)
                {
                    return Json(response.Data);
                }
                else
                {
                    return Json(new DO_ReturnParameter()
                    {
                        Status = false,
                        StatusCode = response.StatusCode.ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Get Specialty List
        /// </summary>
        [HttpPost]
        public JsonResult GetDoctorClinicLinkList(int businessKey, int doctorId, int specialtyId)
        {
            try
            {
                var response = _facilityAPIServices.HttpClientServices.GetAsync<List<DO_DoctorClinic>>("Clinic/GetDoctorClinicLinkList?businessKey=" + businessKey + "&specialtyId=" + specialtyId + "&doctorId=" + doctorId).Result;
                if (response.Status)
                {
                    //return Json(response.Data.Select(x => new DO_OPClinic { ClinicId = x.ClinicId, ClinicDesc = x.ClinicDesc }).GroupBy(y => y.ClinicId, (key, grp) => grp.FirstOrDefault()).ToList());
                    return Json(response.Data.Where(x => x.ActiveStatus).ToList());
                }
                else
                {
                    return Json(new DO_ReturnParameter()
                    {
                        Status = false,
                        StatusCode = response.StatusCode.ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Insert Doctor Schedule
        /// </summary>
        [HttpPost]
        public JsonResult InsertDoctorSchedule(DO_DoctorSchedule obj)
        {
            try
            {
                obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);

                var Insertresponse = _facilityAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("DoctorSchedule/InsertIntoDoctorSchedule", obj).Result;
                if (Insertresponse.Status)
                {
                    return Json(Insertresponse.Data);
                }
                else
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = Insertresponse.Message });
                }

            }
            catch (Exception ex)
            {
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Update Doctor Schedule
        /// </summary>
        [HttpPost]
        public JsonResult UpdateDoctorSchedule(DO_DoctorSchedule obj)
        {
            try
            {
                obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);

                var Insertresponse = _facilityAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("DoctorSchedule/UpdateDoctorSchedule", obj).Result;
                if (Insertresponse.Status)
                {
                    return Json(Insertresponse.Data);
                }
                else
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = Insertresponse.Message });
                }

            }
            catch (Exception ex)
            {
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Get Doctor Schedule List
        /// </summary>
        [HttpPost]
        public JsonResult GetDoctorScheduleList(int businessKey, int clinicId, int specialtyId, int doctorId, int consultationType)
        {
            try
            {
                var response = _facilityAPIServices.HttpClientServices.GetAsync<List<DO_DoctorSchedule>>("DoctorSchedule/GetDoctorScheduleList?businessKey=" + businessKey + "&clinicId=" + clinicId + "&specialtyId=" + specialtyId + "&doctorId=" + doctorId + "&consultationType=" + consultationType).Result;
                if (response.Status)
                {
                    return Json(response.Data);
                }
                else
                {
                    return Json(new DO_ReturnParameter()
                    {
                        Status = false,
                        StatusCode = response.StatusCode.ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Get Doctor Schedule List
        /// </summary>
        [HttpPost]
        public JsonResult GetDoctorScheduleListAll(int businessKey, int doctorId)
        {
            try
            {
                var response = _facilityAPIServices.HttpClientServices.GetAsync<List<DO_DoctorSchedule>>("DoctorSchedule/GetDoctorScheduleListAll?businessKey=" + businessKey + "&doctorId=" + doctorId).Result;
                if (response.Status)
                {
                    return Json(response.Data);
                }
                else
                {
                    return Json(new DO_ReturnParameter()
                    {
                        Status = false,
                        StatusCode = response.StatusCode.ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Get Doctor Schedule Data
        /// </summary>
        [HttpPost]
        public JsonResult GetDoctorSchedule(int businessKey, int clinicId, int specialtyId, int doctorId, int consultationType, int serialNo)
        {
            try
            {
                var response = _facilityAPIServices.HttpClientServices.GetAsync<DO_DoctorSchedule>("DoctorSchedule/GetDoctorSchedule?businessKey=" + businessKey + "&clinicId=" + clinicId + "&specialtyId=" + specialtyId + "&doctorId=" + doctorId + "&consultationType=" + consultationType + "&serialNo=" + serialNo).Result;
                if (response.Status)
                {
                    return Json(response.Data);
                }
                else
                {
                    return Json(new DO_ReturnParameter()
                    {
                        Status = false,
                        StatusCode = response.StatusCode.ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        [Area("eSyaClinicalServices")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult _DoctorScheduleChange()
        {
            return View();
        }

        /// <summary>
        /// Insert Doctor Schedule
        /// </summary>
        [HttpPost]
        public JsonResult InsertDoctorScheduleChange(DO_DoctorSchedule obj)
        {
            try
            {
                obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);

                var Insertresponse = _facilityAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("DoctorSchedule/InsertIntoDoctorScheduleChange", obj).Result;
                if (Insertresponse.Status)
                {
                    return Json(Insertresponse.Data);
                }
                else
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = Insertresponse.Message });
                }

            }
            catch (Exception ex)
            {
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Update Doctor Schedule
        /// </summary>
        [HttpPost]
        public JsonResult UpdateDoctorScheduleChange(DO_DoctorSchedule obj)
        {
            try
            {
                obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);

                var Insertresponse = _facilityAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("DoctorSchedule/UpdateDoctorScheduleChange", obj).Result;
                if (Insertresponse.Status)
                {
                    return Json(Insertresponse.Data);
                }
                else
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = Insertresponse.Message });
                }

            }
            catch (Exception ex)
            {
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Get Doctor Schedule List
        /// </summary>
        [HttpPost]
        public JsonResult GetDoctorScheduleChangeListAll(int businessKey, int doctorId)
        {
            try
            {
                var response = _facilityAPIServices.HttpClientServices.GetAsync<List<DO_DoctorSchedule>>("DoctorSchedule/GetDoctorScheduleChangeListAll?businessKey=" + businessKey + "&doctorId=" + doctorId).Result;
                if (response.Status)
                {
                    return Json(response.Data.Where(x => x.ScheduleChangeDate > System.DateTime.Now).ToList());
                }
                else
                {
                    return Json(new DO_ReturnParameter()
                    {
                        Status = false,
                        StatusCode = response.StatusCode.ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Get Doctor Schedule Data
        /// </summary>
        [HttpPost]
        public JsonResult GetDoctorScheduleChange(int businessKey, int clinicId, int specialtyId, int doctorId, int consultationType, DateTime scheduleChangeDate)
        {
            try
            {

                var response = _facilityAPIServices.HttpClientServices.GetAsync<DO_DoctorSchedule>("DoctorSchedule/GetDoctorScheduleChange?businessKey=" + businessKey + "&clinicId=" + clinicId + "&specialtyId=" + specialtyId + "&doctorId=" + doctorId + "&consultationType=" + consultationType + "&scheduleChangeDate=" + scheduleChangeDate.ToJsonDateFormat()).Result;
                if (response.Status)
                {
                    return Json(response.Data);
                }
                else
                {
                    return Json(new DO_ReturnParameter()
                    {
                        Status = false,
                        StatusCode = response.StatusCode.ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        [Area("eSyaClinicalServices")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult _DoctorLeave()
        {
            return View();
        }

        /// <summary>
        /// Insert Doctor Leave
        /// </summary>
        [HttpPost]
        public JsonResult InsertDoctorLeave(DO_DoctorLeave obj)
        {
            try
            {
                obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);

                var Insertresponse = _facilityAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("DoctorLeave/InsertIntoDoctorLeave", obj).Result;
                if (Insertresponse.Status)
                {
                    return Json(Insertresponse.Data);
                }
                else
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = Insertresponse.Message });
                }

            }
            catch (Exception ex)
            {
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Update Doctor Leave
        /// </summary>
        [HttpPost]
        public JsonResult UpdateDoctorLeave(DO_DoctorLeave obj)
        {
            try
            {
                obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);

                var Insertresponse = _facilityAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("DoctorLeave/UpdateDoctorLeave", obj).Result;
                if (Insertresponse.Status)
                {
                    return Json(Insertresponse.Data);
                }
                else
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = Insertresponse.Message });
                }

            }
            catch (Exception ex)
            {
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Get Doctor Leave List
        /// </summary>
        [HttpPost]
        public JsonResult GetDoctorLeaveListAll(int doctorId)
        {
            try
            {
                var response = _facilityAPIServices.HttpClientServices.GetAsync<List<DO_DoctorLeave>>("DoctorLeave/GetDoctorLeaveListAll?doctorId=" + doctorId).Result;
                if (response.Status)
                {
                    return Json(response.Data);
                }
                else
                {
                    return Json(new DO_ReturnParameter()
                    {
                        Status = false,
                        StatusCode = response.StatusCode.ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Get Doctor Leave List
        /// </summary>
        [HttpPost]
        public JsonResult GetDoctorLeaveData(int doctorId, DateTime leaveFromDate)
        {
            try
            {
                var response = _facilityAPIServices.HttpClientServices.GetAsync<DO_DoctorLeave>("DoctorLeave/GetDoctorLeaveData?doctorId=" + doctorId + "&leaveFromDate=" + leaveFromDate.ToJsonDateFormat()).Result;
                if (response.Status)
                {
                    return Json(response.Data);
                }
                else
                {
                    return Json(new DO_ReturnParameter()
                    {
                        Status = false,
                        StatusCode = response.StatusCode.ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        [Area("eSyaClinicalServices")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult _BusinessLink()
        {

            return View();
        }

        /// <summary>
        /// Get Business Location List
        /// </summary>
        [HttpPost]
        public JsonResult GetBusinessLocationDoctorList(int doctorId)
        {
            try
            {
                var response = _facilityAPIServices.HttpClientServices.GetAsync<List<DO_BusinessLocation>>("DoctorMaster/GetBusinessLocationDoctorList?doctorId=" + doctorId).Result;
                if (response.Status)
                {
                    return Json(response.Data);
                }
                else
                {
                    return Json(new DO_ReturnParameter()
                    {
                        Status = false,
                        StatusCode = response.StatusCode.ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Insert Doctor Business Link
        /// </summary>
        [HttpPost]
        public JsonResult InsertIntoBusinessDoctorLink(List<DO_DoctorMaster> obj)
        {
            try
            {
                obj.All(c =>
                {
                    c.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                    c.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                    c.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                    return true;
                });

                var Insertresponse = _facilityAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("DoctorMaster/InsertIntoBusinessDoctorLink", obj).Result;
                return Json(Insertresponse.Data);

            }
            catch (Exception ex)
            {
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        [Area("eSyaClinicalServices")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult _SpecialtyLink()
        {


            return View();
        }

        /// <summary>
        /// Get Business Location List
        /// </summary>
        [HttpPost]
        public JsonResult GetSpecialtyListByDoctorId(int doctorId)
        {
            try
            {
                var response = _facilityAPIServices.HttpClientServices.GetAsync<List<DO_SpecialtyDoctorLink>>("DoctorMaster/GetSpecialtyListByDoctorId?doctorId=" + doctorId).Result;
                if (response.Status)
                {
                    return Json(response.Data);
                }
                else
                {
                    return Json(new DO_ReturnParameter()
                    {
                        Status = false,
                        StatusCode = response.StatusCode.ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Insert Specialty Link
        /// </summary>
        [HttpPost]
        public JsonResult InsertDoctorSpecialtyLink(DO_SpecialtyDoctorLink obj)
        {
            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);

                var Insertresponse = _facilityAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("DoctorMaster/InsertDoctorSpecialtyLink", obj).Result;
                return Json(Insertresponse.Data);

            }
            catch (Exception ex)
            {
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Insert Specialty Link
        /// </summary>
        [HttpPost]
        public JsonResult UpdateDoctorSpecialtyLink(DO_SpecialtyDoctorLink obj)
        {
            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);

                var Insertresponse = _facilityAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("DoctorMaster/UpdateDoctorSpecialtyLink", obj).Result;
                return Json(Insertresponse.Data);

            }
            catch (Exception ex)
            {
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Doctor Specialty Link
        /// </summary>
        [Area("eSyaClinicalServices")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult V_1552_00()
        {
            var response = _facilityAPIServices.HttpClientServices.GetAsync<List<DO_BusinessLocation>>("CommonData/GetBusinessKey").Result;
            ViewBag.BusinessKeyList = response.Data.Select(a => new SelectListItem
            {
                Text = a.LocationDescription,
                Value = a.BusinessKey.ToString()
            });

            return View();
        }

        /// <summary>
        ///Get Specialty Codes for Tree View
        /// </summary>
        [Produces("application/json")]
        public IActionResult GetDoctorMasterTree(int businessKey)
        {

            try
            {
                var response = _facilityAPIServices.HttpClientServices.GetAsync<List<DO_DoctorMaster>>("DoctorMaster/GetDoctorMasterBusinessList?businessKey=" + businessKey).Result;
                //List <DO_SpecialtyDoctorLink> data = response.Data.Where(x => x.ActiveStatus).ToList();

                List<jsTreeObject> DoctorTree = new List<jsTreeObject>();

                jsTreeObject obj;
                obj = new jsTreeObject
                {
                    id = "H0",
                    parent = "#",
                    text = "Doctor Names",
                    state = new stateObject { opened = true, selected = false }
                };

                //SpecialtyTree.Add(obj);

                if (response.Data != null)
                {
                    //List<DO_DoctorMaster> sCodes = response.Data.Select(x => new DO_DoctorMaster { DoctorID = x.DoctorID, DoctorName = x.DoctorName }).GroupBy(y => y.DoctorID, (key, grp) => grp.FirstOrDefault()).ToList();

                    foreach (DO_DoctorMaster lst in response.Data)
                    {
                        obj = new jsTreeObject
                        {
                            id = lst.DoctorId.ToString(),
                            parent = "#",
                            text = lst.DoctorName
                        };
                        //var cl = response.Data.Where(w => w.SpecialtyID == lst.SpecialtyID && w.BusinessKey == AppSessionVariables.GetSessionBusinessKey(HttpContext) && w.ClinicID != 0).FirstOrDefault();
                        if (lst.ActiveStatus)
                            obj.state = new stateObject { opened = false, selected = true };
                        else
                            obj.state = new stateObject { opened = false, selected = false };

                        DoctorTree.Add(obj);


                    }
                }
                return Json(DoctorTree);
            }
            catch (Exception ex)
            {
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }

        }

        /// <summary>
        /// Insert Doctor Business Link
        /// </summary>
        [HttpPost]
        public JsonResult InsertUpdateDoctorBusinessLink(List<DO_DoctorMaster> obj)
        {
            try
            {
                obj.All(c =>
                {
                    c.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                    c.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                    c.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                    return true;
                });

                var Insertresponse = _facilityAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("DoctorMaster/InsertIntoDoctorBusinessLink", obj).Result;
                return Json(Insertresponse.Data);

            }
            catch (Exception ex)
            {
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        [Area("eSyaClinicalServices")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult _ClinicDoctorLink()
        {
            return View();
        }

        /// <summary>
        /// Doctor Scheduler
        /// </summary>
        [Area("eSyaClinicalServices")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult V_1553_00()
        {
            var response = _facilityAPIServices.HttpClientServices.GetAsync<List<DO_BusinessLocation>>("CommonData/GetBusinessKey").Result;
            ViewBag.BusinessKeyList = response.Data.Select(a => new SelectListItem
            {
                Text = a.LocationDescription,
                Value = a.BusinessKey.ToString()
            });

            return View();
        }

        /// <summary>
        /// Get Specialty List From Specialty Business Link
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetSpecialtyListForBusinessKey(int businessKey)
        {
            try
            {
                var serviceResponse = await _facilityAPIServices.HttpClientServices.GetAsync<List<DO_SpecialtyBusinessLink>>("Specialty/GetSpecialtyListForBusinessKey?businessKey=" + businessKey);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetSpecialtyListForBusinessKey");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetSpecialtyListForBusinessKey");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        [HttpPost]
        public async Task<JsonResult> GetClinicConsultantIdList(int businessKey)
        {
            try
            {
                var serviceResponse = await _facilityAPIServices.HttpClientServices.GetAsync<List<DO_OPClinic>>("Clinic/GetClinicConsultantIdList?businessKey=" + businessKey);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data.Where(x => x.ActiveStatus).ToList());
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetClinicConsultantIdList");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetClinicConsultantIdList");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        [HttpPost]
        public async Task<JsonResult> GetDoctorClinicLinkListbyClinicConsultation(int businessKey, int clinicId, int consultationId)
        {
            try
            {
                var serviceResponse = await _facilityAPIServices.HttpClientServices.GetAsync<List<DO_DoctorClinic>>("Clinic/GetDoctorClinicLinkListbyClinicConsultation?businessKey=" + businessKey + "&clinicId=" + clinicId + "&consultationId=" + consultationId);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data.ToList());
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetDoctorClinicLinkListbyClinicConsultation");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetDoctorClinicLinkListbyClinicConsultation");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Insert Doctor Schedule
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertIntoDoctorScheduler(DO_DoctorSchedule obj)
        {
            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);

                var serviceResponse = await _facilityAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("DoctorSchedule/InsertIntoDoctorScheduler", obj);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertIntoDoctorScheduler:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertIntoDoctorScheduler:params:" + JsonConvert.SerializeObject(obj));
                throw ex;
            }
        }

        /// <summary>
        /// Update Doctor Schedule
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> UpdateDoctorScheduler(DO_DoctorSchedule obj)
        {
            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);

                var serviceResponse = await _facilityAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("DoctorSchedule/UpdateDoctorScheduler", obj);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:UpdateDoctorScheduler:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:UpdateDoctorScheduler:params:" + JsonConvert.SerializeObject(obj));
                throw ex;
            }
        }

        /// <summary>
        /// Get Doctor Schedule List
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetDoctorSchedulerListAll(int businessKey, int clinicId, int consultationId, DateTime scheduleFromDate, DateTime scheduleToDate)
        {
            try
            {
                var serviceResponse = await _facilityAPIServices.HttpClientServices.GetAsync<List<DO_DoctorSchedule>>("DoctorSchedule/GetDoctorSchedulerListAll?businessKey=" + businessKey + "&clinicId=" + clinicId + "&consultationId=" + consultationId + "&scheduleFromDate=" + scheduleFromDate.ToJsonDateFormat() + "&scheduleToDate=" + scheduleToDate.ToJsonDateFormat());
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data.ToList());
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetDoctorSchedulerListAll");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetDoctorSchedulerListAll");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Activate or De Activate Doctor Schedule
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> ActiveOrDeActiveDoctorScheduler(bool status, int businesskey, int consultationId, int clinicId, int specialtyId, int doctorId, int serialNo)
        {

            try
            {

                var parameter = "?status=" + status + "&businesskey=" + businesskey + "&consultationId=" + consultationId + "&clinicId=" + clinicId
                    + "&specialtyId=" + specialtyId + "&doctorId=" + doctorId + "&serialNo=" + serialNo;
                var serviceResponse = await _facilityAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("DoctorSchedule/ActiveOrDeActiveDoctorScheduler" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ActiveOrDeActiveDoctorScheduler:For doctorId {0} ", doctorId);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        #endregion

        #region Doctor Pannel
        [Area("Facilities")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult EFM_07_00()
        {

            ViewBag.formName = "Doctor Details";
            return View();
        }
        /// <summary>
        /// Get Doctor details From About Doctor by doctorId
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetDoctordetailsbydoctorId(int doctorId)
        {
            try
            {
                var serviceResponse = await _facilityAPIServices.HttpClientServices.GetAsync<Do_DoctorDetails>("DoctorMaster/GetDoctordetailsbydoctorId?doctorId=" + doctorId);
                if (serviceResponse.Status)
                {
                    var domainname = this.Request.PathBase;
                    if (serviceResponse.Data != null)
                    {
                        if (serviceResponse.Data.ProfileImagePath != null)
                        {
                            string filename = null;
                            // using the method
                            filename = Path.GetFileName(serviceResponse.Data.ProfileImagePath);
                            serviceResponse.Data.FileName = filename;

                            serviceResponse.Data.ProfileImagePath = domainname + serviceResponse.Data.ProfileImagePath;


                        }
                    }
                    else
                    {
                        return Json(serviceResponse.Data);
                    }

                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetDoctordetailsbydoctorId");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetDoctordetailsbydoctorId");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Insert Or Update Doctor Details
        /// </summary>
        //[AutoValidateAntiforgeryToken()]
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateIntoDoctordetails(Do_DoctorDetails obj)
        {
            try
            {
                if (obj.Imagefile != null && (obj.Imagefile.Length > 0))
                {
                    var file = obj.Imagefile;
                    //There is an error here
                    var uploads = Path.Combine(_appEnvironment.WebRootPath, "Uploads\\DoctorImages");
                    if (file.Length > 0)
                    {
                        //var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(file.FileName);
                        var fileName = Path.GetFileName(file.FileName);
                        using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                        {
                            await file.CopyToAsync(fileStream);
                            string filePath = "\\Uploads\\DoctorImages\\" + fileName;
                            obj.ProfileImagePath = filePath;
                        }

                    }
                }
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);

                var serviceResponse = await _facilityAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("DoctorMaster/InsertOrUpdateIntoDoctordetails", obj);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertOrUpdateIntoDoctordetails:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateIntoDoctordetails:params:" + JsonConvert.SerializeObject(obj));
                throw ex;
            }
        }
        #endregion
    }
}