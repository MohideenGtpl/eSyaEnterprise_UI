using System;
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
using ClosedXML.Excel;
using System.Data;
using System.Text.RegularExpressions;
using System.Text;
using eSyaEnterprise_UI.DataServices;
using Microsoft.Extensions.Configuration;
namespace eSyaEnterprise_UI.Areas.Facilities.Controllers
{
    [SessionTimeout]
    public class DoctorsController : Controller
    {
        private readonly IeSyaGatewayServices _eSyaGatewayServices;
        private readonly IFacilityAPIServices _facilityAPIServices;
        private readonly ILogger<DoctorsController> _logger;
        private readonly IHostingEnvironment _appEnvironment;
        private readonly IConfiguration _configuration;
        public DoctorsController(IFacilityAPIServices facilityAPIServices, ILogger<DoctorsController> logger, IHostingEnvironment hostingEnvironment, IeSyaGatewayServices eSyaGatewayServices, IConfiguration configuration)
        {
            _facilityAPIServices = facilityAPIServices;
            _logger = logger;
            _appEnvironment = hostingEnvironment;
            _eSyaGatewayServices = eSyaGatewayServices;
            _configuration = configuration;
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
        public JsonResult InsertDoctorMaster(DO_DoctorMaster obj,string file)
        {
            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                if (file != null)
                {

                    string userbase64 = file;// load base 64 code to this variable from js 
                    Byte[] userbitmapData = new Byte[userbase64.Length];
                    userbitmapData = Convert.FromBase64String(FixBase64ForImage(userbase64));
                    if (userbitmapData.Length > 2 * 1024 * 1024)
                    {
                        return Json(new DO_ReturnParameter() { Status = false, Message = "User Photo file size should be smaller than 2 MB" });
                    }

                    obj.Photo = userbitmapData;
                }
                else
                {
                    byte[] emptyByte = { };
                    obj.Photo = emptyByte;
                }
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
        public JsonResult UpdateDoctorMaster(DO_DoctorMaster obj, string file)
        {
            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                if (file != null)
                {

                    string userbase64 = file;// load base 64 code to this variable from js 
                    Byte[] userbitmapData = new Byte[userbase64.Length];
                    userbitmapData = Convert.FromBase64String(FixBase64ForImage(userbase64));
                    if (userbitmapData.Length > 2 * 1024 * 1024)
                    {
                        return Json(new DO_ReturnParameter() { Status = false, Message = "User Photo file size should be smaller than 2 MB" });
                    }

                    obj.Photo = userbitmapData;
                }
                else
                {
                    byte[] emptyByte = { };
                    obj.Photo = emptyByte;
                }
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
                    //return Json(response.Data);
                    if (response.Data != null)
                    {
                        var data = response.Data;

                        string userimageURI = string.Empty;
                        if (data.Photo != null)
                            userimageURI = ConvertByteArraytoImageURI(data.Photo);
                        data.userimage = userimageURI;
                        return Json(data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(response.Message), "UD:GetDoctorMaster:For doctorId {0}", doctorId);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
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



        [Produces("application/json")]
        [HttpGet]
        public async Task<JsonResult> GetClinicConsultantTreeList(int businessKey, int specialtyId, int doctorId)
        {
            try
            {
                List<jsTreeObject> ClinicConsultantTree = new List<jsTreeObject>();

                jsTreeObject jsObj = new jsTreeObject
                {
                    id = "CL0",
                    parent = "#",
                    text = "Clinics",
                    //icon = "/images/jsTree/foldergroupicon.png",
                    state = new stateObject { opened = true, selected = false, checkbox_disabled = true, disabled = true }
                };
                ClinicConsultantTree.Add(jsObj);

                var clinicResponse = await _facilityAPIServices.HttpClientServices.GetAsync<List<DO_DoctorClinic>>("Clinic/GetDoctorClinicLinkList?businessKey=" + businessKey + "&specialtyId=" + specialtyId + "&doctorId=" + doctorId);
                if (clinicResponse.Status)
                {
                    if (clinicResponse.Data != null)
                    {
                        List<DO_OPClinic> clinic_list = clinicResponse.Data.Select(x => new DO_OPClinic { ConsultationId = x.ConsultationId, ConsultationDesc = x.ConsultationDesc }).GroupBy(y => y.ConsultationId, (key, grp) => grp.FirstOrDefault()).ToList();
                        foreach (DO_OPClinic cl in clinic_list)
                        {
                            jsObj = new jsTreeObject
                            {
                                id = cl.ConsultationId.ToString(),
                                text = cl.ConsultationDesc.ToString(),
                                //icon = "/images/jsTree/openfolder.png",
                                parent = "CL0",
                                state = new stateObject { opened = true, selected = false, checkbox_disabled = true, disabled = true },
                            };
                            ClinicConsultantTree.Add(jsObj);
                        }

                        var conusltant_list = clinicResponse.Data;
                        foreach (var co in conusltant_list.Where(w => conusltant_list.Any(f => f.ConsultationId == w.ConsultationId)))
                        {
                            jsObj = new jsTreeObject
                            {
                                text = co.ClinicDesc,
                                parent = co.ConsultationId.ToString()

                            };
                            if (co.BusinessKey > 0)
                            {
                                jsObj.id = co.ConsultationId.ToString() + "_" + "Y" + "_" + co.ClinicId;
                                //jsObj.icon = "/images/jsTree/checkedstate.jpg";
                                if (co.ActiveStatus)
                                    jsObj.state = new stateObject { opened = true, selected = true, Checked = true };
                                else
                                    jsObj.state = new stateObject { opened = true, selected = false, Checked = false };
                            }
                            else
                            {
                                jsObj.id = co.ConsultationId.ToString() + "_" + "N" + "_" + co.ClinicId;
                                //jsObj.icon = "/images/jsTree/fileIcon.png";
                                jsObj.state = new stateObject { opened = true, selected = false, Checked = false };
                            }

                            ClinicConsultantTree.Add(jsObj);
                        }
                    }

                    return Json(ClinicConsultantTree);
                }
                else
                {
                    _logger.LogError(new Exception(clinicResponse.Message), "UD:GetClinicConsultantTreeList:For BusinessId {0} , SpecialtyId {1} and DoctorId entered {2}", businessKey, specialtyId, doctorId);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetClinicConsultantTreeList:For BusinessId {0} , SpecialtyId {1} and DoctorId entered {2}", businessKey, specialtyId, doctorId);
                throw ex;
            }
        }



        /// <summary>
        /// Insert / Update Doctor Clinic
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertUpdateDoctorClinicLink(List<DO_DoctorClinic> do_cl)
        {
            try
            {
                do_cl.All(c =>
                {
                    c.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                    c.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                    c.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                    return true;
                });

                var Insertresponse = await _facilityAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Clinic/InsertUpdateDoctorClinicLink", do_cl);
                if (Insertresponse.Status)
                    return Json(Insertresponse.Data);
                else
                {
                    _logger.LogError(new Exception(Insertresponse.Message), "UD:InsertUpdateDoctorClinicLink:params:" + JsonConvert.SerializeObject(do_cl));
                    return Json(new DO_ReturnParameter() { Status = false, Message = Insertresponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertUpdateDoctorClinicLink:params:" + JsonConvert.SerializeObject(do_cl));
                throw ex;
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
        public static string FixBase64ForImage(string image)
        {

            var regex = new Regex(@"data:(?<mime>[\w/\-\.]+);(?<encoding>\w+),(?<data>.*)", RegexOptions.Compiled);
            var match = regex.Match(image);
            var mime = match.Groups["mime"].Value;
            var encoding = match.Groups["encoding"].Value;
            var data = match.Groups["data"].Value;
            return data;
        }

        public static string ConvertByteArraytoImageURI(Byte[] image)
        {

            StringBuilder ImageURI = new StringBuilder();
            ImageURI.Append("data:");
            string image_data = Convert.ToBase64String(image);
            string mime = "image/jpeg";
            string encoding = "base64";
            ImageURI.Append(mime);
            ImageURI.Append(";");
            ImageURI.Append(encoding);
            ImageURI.Append(",");
            ImageURI.Append(image_data);
            return Convert.ToString(ImageURI);
        }
        #endregion

        #region About Doctor
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
        /// Insert Or Update About Doctor Details
        /// </summary>
        //[AutoValidateAntiforgeryToken()]
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateIntoDoctordetails(Do_DoctorDetails obj)
        {
            try
            {
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

        #region Doctor day Schedule

        [Area("Facilities")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult EFM_08_00()
        {

            ViewBag.formName = "Doctor day Schedule";
            return View();
        }

        /// <summary>
        /// Get Specialites by Business Key
        /// </summary>
        [HttpPost]
        public JsonResult GetSpecialtiesByBusinessKey(int businessKey)
        {
            try
            {
                var response = _facilityAPIServices.HttpClientServices.GetAsync<List<DO_SpecialtyCodes>>("DoctorMaster/GetSpecialtiesByBusinessKey?businessKey=" + businessKey).Result;
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
        /// Get Clinic And Consultation List by Business Key and Specialty Id
        /// </summary>
        [HttpPost]
        public JsonResult GetClinicAndConsultationTypebySpecialty(int businessKey, int specialtyId)
        {
            try
            {
                var response = _facilityAPIServices.HttpClientServices.GetAsync<List<DO_DoctorClinic>>("DoctorMaster/GetClinicAndConsultationTypebySpecialty?businessKey=" + businessKey + "&specialtyId=" + specialtyId ).Result;
                if (response.Status)
                {
                    return Json(response.Data.Where(x=>x.ActiveStatus==true).ToList());
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
        /// Get Doctors by ClinicId, ConsultationType Business Key and Specialty Id
        /// </summary>
        [HttpPost]
        public JsonResult GetDoctorsbySpecialtyClinicAndConsultation(int businessKey, int specialtyId, int clinicId, int consultationId)
        {
            try
            {
                var response = _facilityAPIServices.HttpClientServices.GetAsync<List<DO_DoctorMaster>>("DoctorMaster/GetDoctorsbySpecialtyClinicAndConsultation?businessKey=" + businessKey + "&specialtyId=" + specialtyId
                    + "&clinicId=" + clinicId + "&consultationId=" + consultationId).Result;
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
        /// Get Doctor day Schedule by Search Criteria
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetDoctordaySchedulebySearchCriteria(int businessKey, int specialtyId, int clinicId, int consultationId, int doctorId, DateTime scheduleFromDate, DateTime scheduleToDate)
        {
            try
            {
                var serviceResponse = await _facilityAPIServices.HttpClientServices.GetAsync<List<DO_DoctordaySchedule>>("DoctorMaster/GetDoctordaySchedulebySearchCriteria?businessKey=" + businessKey + "&specialtyId=" + specialtyId + "&clinicId=" + clinicId + "&consultationId=" + consultationId + "&doctorId=" + doctorId + "&scheduleFromDate=" + scheduleFromDate.ToJsonDateFormat() + "&scheduleToDate=" + scheduleToDate.ToJsonDateFormat());
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data.ToList());
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetDoctordaySchedulebySearchCriteria");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetDoctordaySchedulebySearchCriteria");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }


        /// <summary>
        /// Insert Doctor day Schedule
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateDoctordaySchedule(bool isInsert, DO_DoctordaySchedule obj)
        {
            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);

                if (isInsert)
                {
                    var serviceResponse = await _facilityAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("DoctorMaster/InsertIntoDoctordaySchedule", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertIntoDoctordaySchedule:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

                else
                {
                    var serviceResponse = await _facilityAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("DoctorMaster/UpdateDoctordaySchedule", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                     _logger.LogError(new Exception(serviceResponse.Message), "UD:UpdateDoctordaySchedule:params:" + JsonConvert.SerializeObject(obj));
                     return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateDoctordaySchedule:params:" + JsonConvert.SerializeObject(obj));
                throw ex;
            }
        }

        /// <summary>
        /// Activate or De Activate Doctor day Schedule
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> ActiveOrDeActiveDoctordaySchedule(DO_DoctordaySchedule objdel)
        {

            try
            {

                var serviceResponse = await _facilityAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("DoctorMaster/ActiveOrDeActiveDoctordaySchedule", objdel);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ActiveOrDeActiveDoctordaySchedule:params:" + JsonConvert.SerializeObject(objdel));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        [HttpGet]
        public async Task<IActionResult> Export(int businessKey, int specialtyId, int clinicId, int consultationId, int doctorId, DateTime scheduleFromDate, DateTime scheduleToDate)
        {
            string contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            string fileName = "DoctordaySchedule.xlsx";

            string name = "DoctordaySchedule";
            DataTable dt = new DataTable(name);
            dt.Columns.AddRange(new DataColumn[9]
            {

                new DataColumn("Specialty"),
                new DataColumn("Clinic"),
                new DataColumn("Consultation"),
                new DataColumn("Doctor Name"),
                new DataColumn("Schedule Date"),
                new DataColumn("Schedule From Time"),
                new DataColumn("Schedule To Time"),
                new DataColumn("Number of Patients"),
                new DataColumn("Status")
            });


            var serviceResponse = await _facilityAPIServices.HttpClientServices.GetAsync<List<DO_DoctordaySchedule>>("DoctorMaster/GetDoctordaySchedulebySearchCriteria?businessKey=" + businessKey + "&specialtyId=" + specialtyId + "&clinicId=" + clinicId + "&consultationId=" + consultationId + "&doctorId=" + doctorId + "&scheduleFromDate=" + scheduleFromDate.ToJsonDateFormat() + "&scheduleToDate=" + scheduleToDate.ToJsonDateFormat());

            if (serviceResponse.Data != null)
            {
                foreach (var lang in serviceResponse.Data)
                {
                    dt.Rows.Add(lang.SpecialtyDesc, lang.ClinicDesc, lang.ConsultationDesc, lang.DoctorName, lang.ScheduleDate, lang.ScheduleFromTime, lang.ScheduleToTime, lang.NoOfPatients, lang.status);
                }

                using (XLWorkbook wb = new XLWorkbook())
                {
                    wb.Worksheets.Add(dt);
                    using (MemoryStream stream = new MemoryStream())
                    {
                        wb.SaveAs(stream);
                        var content = stream.ToArray();
                        return File(content, contentType, fileName);
                    }
                }
            }
            else
            {
                return Json(new DO_ReturnParameter() { Status = false, Message = "No date Exists" });
            }
        }

        [HttpPost]
        public async Task<JsonResult> Insert_ImpotedDoctorScheduleList(IFormFile postedFile,int BusinessKey)
        {
            try
            {
                List<DO_DoctordaySchedule> lst = new List<DO_DoctordaySchedule>();
                DO_DoctordaySchedule ds;
                var supportedTypes = new[] { ".xls", ".xlsx", "xls", "xlsx" };
                var fileextension = Path.GetExtension(postedFile.FileName);
                if (!supportedTypes.Contains(fileextension))
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "File Extension Is In Valid - Only Upload EXCEL File" });
                }
                string filename = Path.GetFileName(postedFile.FileName);
                var uploads = Path.Combine(_appEnvironment.WebRootPath, "Uploads\\ExcelUploads");
                var filepath = Path.Combine(Directory.GetCurrentDirectory(), uploads, filename);
                //Removing already Exits Excel file
                if (System.IO.File.Exists(filepath))
                {
                    System.IO.File.Delete(filepath);
                }
                //Creating New Excel file
                using (FileStream fs = System.IO.File.Create(filepath))
                {
                    postedFile.CopyTo(fs);
                }
                int rowno = 1;
                XLWorkbook workbook = XLWorkbook.OpenFromTemplate(filepath);
                var sheets = workbook.Worksheets.First();
                var rows = sheets.Rows().ToList();
                foreach (var row in rows)
                {
                    if (rowno != 1)
                    {
                        var checkEmpty = row.Cell(1).Value.ToString();
                        if (string.IsNullOrWhiteSpace(checkEmpty) || string.IsNullOrEmpty(checkEmpty))
                        {
                            break;
                        }
                        if (string.IsNullOrWhiteSpace(row.Cell(1).Value.ToString()) || string.IsNullOrEmpty(row.Cell(1).Value.ToString()))
                        {
                            return Json(new DO_ReturnParameter() { Status = false, Message = "Specialty should not be Empty" });
                        }
                        if (string.IsNullOrWhiteSpace(row.Cell(2).Value.ToString()) || string.IsNullOrEmpty(row.Cell(2).Value.ToString()))
                        {
                            return Json(new DO_ReturnParameter() { Status = false, Message = "Clinic should not be Empty" });
                        }
                        if (string.IsNullOrWhiteSpace(row.Cell(3).Value.ToString()) || string.IsNullOrEmpty(row.Cell(3).Value.ToString()))
                        {
                            return Json(new DO_ReturnParameter() { Status = false, Message =  "Consultation should not be Empty" });
                        }
                        if (string.IsNullOrWhiteSpace(row.Cell(4).Value.ToString()) || string.IsNullOrEmpty(row.Cell(4).Value.ToString()))
                        {
                            return Json(new DO_ReturnParameter() { Status = false, Message = "Doctor should not be Empty" });
                        }
                        if (string.IsNullOrWhiteSpace(row.Cell(5).Value.ToString()) || string.IsNullOrEmpty(row.Cell(5).Value.ToString()))
                        {
                            return Json(new DO_ReturnParameter() { Status = false, Message = "Schedule date should not be Empty" });
                        }
                        if (string.IsNullOrWhiteSpace(row.Cell(6).Value.ToString()) || string.IsNullOrEmpty(row.Cell(6).Value.ToString()))
                        {
                            return Json(new DO_ReturnParameter() { Status = false, Message = "Schedule from Time should not be Empty" });
                        }
                        if (string.IsNullOrWhiteSpace(row.Cell(7).Value.ToString()) || string.IsNullOrEmpty(row.Cell(7).Value.ToString()))
                        {
                            return Json(new DO_ReturnParameter() { Status = false, Message = "Schedule To Time should not be Empty" });
                        }
                        if (string.IsNullOrWhiteSpace(row.Cell(8).Value.ToString()) || string.IsNullOrEmpty(row.Cell(8).Value.ToString()))
                        {
                            return Json(new DO_ReturnParameter() { Status = false, Message = "Number of Patients should not be Empty" });
                        }
                        if (string.IsNullOrWhiteSpace(row.Cell(9).Value.ToString()) || string.IsNullOrEmpty(row.Cell(9).Value.ToString()))
                        {
                            return Json(new DO_ReturnParameter() { Status = false, Message = "Status should not be Empty" });
                        }
                        
                        ds = new DO_DoctordaySchedule();
                        ds.SpecialtyDesc = row.Cell(1).Value.ToString().Trim();
                        ds.ClinicDesc = row.Cell(2).Value.ToString().Trim();
                        ds.ConsultationDesc = row.Cell(3).Value.ToString().Trim();
                        ds.DoctorName = row.Cell(4).Value.ToString().Trim();
                        ds.ScheduleDate = Convert.ToDateTime(row.Cell(5).Value.ToString().Trim());
                        var fime = row.Cell(6).Value.ToString().Trim();
                        var Ttime = row.Cell(7).Value.ToString().Trim();
                        DateTime Fromtime = DateTime.Parse(fime);
                        DateTime Totime = DateTime.Parse(Ttime);
                        var ftime = Fromtime.ToString("HH:mm");
                        var ttime= Totime.ToString("HH:mm");
                        //ds.ScheduleFromTime = TimeSpan.Parse(ftime);
                        //ds.ScheduleToTime = TimeSpan.Parse(ttime);
                        ds.ScheduleFromTime = TimeSpan.Parse(ftime, System.Globalization.CultureInfo.CurrentCulture);
                        ds.ScheduleToTime = TimeSpan.Parse(ttime, System.Globalization.CultureInfo.CurrentCulture);
                        ds.NoOfPatients = Convert.ToInt32( row.Cell(8).Value.ToString().Trim());
                        ds.ActiveStatus =Convert.ToBoolean( row.Cell(9).Value.ToString().Trim());
                        lst.Add(ds);
                    }
                    else
                    {
                        rowno = 2;
                    }
                }
                if (lst.Count > 0)
                {
                    lst.All(x =>
                    {
                        x.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                        x.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                        x.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                        x.BusinessKey = BusinessKey;
                        return true;
                    });
                    
                    var serviceResponse = await _facilityAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("DoctorMaster/ImpotedDoctorScheduleList", lst);
                    if (serviceResponse.Status)
                    {
                        System.IO.File.Delete(filepath);
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                    }
                }
                else
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Excel does not contain valid data" });

                }

                //ViewBag.Data = lst;
            }
            catch (Exception ex)
            {
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message + " or valid Time and Date format should be: MM/DD/YYYY and Time format sholud not be greater than 24 hrs" });
                
            }
        }
        #endregion

        #region Referral Doctor
        [Area("Facilities")]
        public IActionResult EFM_10_00()
        {
            return View();
        }


        #endregion

        #region Doctor profile
        [Area("Facilities")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> EFM_12_00()
        {
            int Isdcode = _configuration.GetValue<int>("cnf:ISDCode");
            ViewBag.Isdcode = Isdcode;
            List<int> l_ac = new List<int>();
            l_ac.Add(Areas.eSyaClinicalServices.Data.CodeTypeValues.DoctorClass);
            l_ac.Add(Areas.eSyaClinicalServices.Data.CodeTypeValues.DoctorCategory);
            l_ac.Add(Areas.eSyaClinicalServices.Data.CodeTypeValues.PayoutType);
            l_ac.Add(Areas.eSyaClinicalServices.Data.CodeTypeValues.SeniorityLevel);
            var response = _facilityAPIServices.HttpClientServices.PostAsJsonAsync<List<DO_ApplicationCodes>>("CommonData/GetApplicationCodesByCodeTypeList", l_ac).Result;
            //for ISD CODE
            //var serviceResponse = await _eSyaGatewayServices.HttpClientServices.GetAsync<List<DO_ISDCodes>>("Common/GetISDCodes");
            //ViewBag.ISDCodes = serviceResponse.Data;
            //ViewBag.DomainName = this.Request.PathBase;
            //End
            if (response.Status)
            {
                List<DO_ApplicationCodes> ac = response.Data.Where(x => x.CodeType == Areas.eSyaClinicalServices.Data.CodeTypeValues.DoctorClass).ToList();
                ViewBag.doctorClassList = ac.Select(a => new SelectListItem
                {
                    Text = a.CodeDesc,
                    Value = a.ApplicationCode.ToString()
                });

                ac = response.Data.Where(x => x.CodeType == Areas.eSyaClinicalServices.Data.CodeTypeValues.DoctorCategory).ToList();
                ViewBag.doctorCategoryList = ac.Select(a => new SelectListItem
                {
                    Text = a.CodeDesc,
                    Value = a.ApplicationCode.ToString()
                });

                ac = response.Data.Where(x => x.CodeType == Areas.eSyaClinicalServices.Data.CodeTypeValues.PayoutType).ToList();
                ViewBag.payoutTypeList = ac.Select(a => new SelectListItem
                {
                    Text = a.CodeDesc,
                    Value = a.ApplicationCode.ToString()
                });
                ac = response.Data.Where(x => x.CodeType == Areas.eSyaClinicalServices.Data.CodeTypeValues.SeniorityLevel).ToList();
                ViewBag.seniorityLevelList = ac.Select(a => new SelectListItem
                {
                    Text = a.CodeDesc,
                    Value = a.ApplicationCode.ToString()
                });
            }
            else
            {
                ViewBag.doctorClass = null;
                ViewBag.doctorCategory = null;
                ViewBag.payoutTypeList = null;
                ViewBag.seniorityLevelList = null;
            }

            var bk_resp = await _facilityAPIServices.HttpClientServices.GetAsync<List<DO_BusinessLocation>>("CommonMethod/GetBusinessKey");
            if (bk_resp.Status)
            {
                if (bk_resp.Data != null)
                {
                    ViewBag.BusinessKey = bk_resp.Data.Select(b => new SelectListItem
                    {
                        Value = b.BusinessKey.ToString(),
                        Text = b.LocationDescription,
                    }).ToList();
                }
            }
            else
            {
                _logger.LogError(new Exception(bk_resp.Message), "UD:V_1518_00:GetBusinessKey");
            }

            var clinictype_resp = await _facilityAPIServices.HttpClientServices.GetAsync<List<DO_ApplicationCode>>("CommonMethod/GetApplicationCodesByCodeType?codetype=61");
            if (clinictype_resp.Status)
            {
                if (clinictype_resp.Data != null)
                {
                    ViewBag.ClinicType = clinictype_resp.Data.Select(r => new SelectListItem
                    {
                        Value = r.ApplicationCode.ToString(),
                        Text = r.CodeDesc,
                    }).ToList();
                }
            }
            else
            {
                _logger.LogError(new Exception(clinictype_resp.Message), "UD:V_1518_00:GetApplicationCodesByCodeType: CodeType {0} 61");
            }

            var cuurency_resp = await _facilityAPIServices.HttpClientServices.GetAsync<List<DO_CurrencyCode>>("CommonMethod/GetCurrencyCodes");
            if (cuurency_resp.Status)
            {
                if (cuurency_resp.Data != null)
                {
                    ViewBag.CurrencyCode = cuurency_resp.Data.Select(c => new SelectListItem
                    {
                        Value = c.CurrencyCode.ToString(),
                        Text = c.CurrencyName,
                    }).ToList();
                }
            }
            else
            {
                _logger.LogError(new Exception(cuurency_resp.Message), "UD:V_1518_00:GetCurrencyCodes");
            }

            var rate_resp = await _facilityAPIServices.HttpClientServices.GetAsync<List<DO_ApplicationCode>>("CommonMethod/GetApplicationCodesByCodeType?codetype=62");
            if (rate_resp.Status)
            {
                if (rate_resp.Data != null)
                {
                    ViewBag.RateType = rate_resp.Data.Select(r => new SelectListItem
                    {
                        Value = r.ApplicationCode.ToString(),
                        Text = r.CodeDesc,
                    }).ToList();
                }
            }
            else
            {
                _logger.LogError(new Exception(rate_resp.Message), "UD:V_1518_00:GetApplicationCodesByCodeType: CodeType {0} 62");
            }
            ViewBag.formName = "Doctor Master Profile";
            return View();
        }

        #endregion
        [Area("Facilities")]
        public IActionResult _DoctorProfile()
        {
            return View();
        }
        [Area("Facilities")]
        public IActionResult _AboutDoctor()
        {
            return View();
        }
        [Area("Facilities")]
        public IActionResult _PhotoAndSignature()
        {
            return View();
        }
        [Area("Facilities")]
        public IActionResult _StatutoryDetails()
        {
            return View();
        }
        [Area("Facilities")]
        public IActionResult _ConsultationRates()
        {
            return View();
        }
        [Area("Facilities")]
        public IActionResult _RevenueShare()
        {
            return View();
        }
        [Area("Facilities")]
        public IActionResult _DoctorBusinessLink()
        {
            return View();
        }
        [Area("Facilities")]
        public IActionResult _Address()
        {
            return View();
        }
        [Area("Facilities")]
        public IActionResult _IN_91_ADDR_UI()
        {
            return View();
        }
        [Area("Facilities")]
        public IActionResult _EG_20_ADDR_UI()
        {
            return View();
        }
        [Area("Facilities")]
        public IActionResult _KEN_254_ADDR_UI()
        {
            return View();
        }
        #region Doctor Profile Business Link
        /// <summary>
        /// Get Business Location List
        /// </summary>
        [HttpPost]
        public JsonResult GetDoctorBusinessLinkList(int doctorId)
        {
            try
            {
                var response = _facilityAPIServices.HttpClientServices.GetAsync<List<DO_DoctorBusinessLink>>("DoctorMaster/GetDoctorBusinessLinkList?doctorId=" + doctorId).Result;
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
        public JsonResult InsertIntoDoctorBusinessLink(List<DO_DoctorBusinessLink> obj)
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

                var Insertresponse = _facilityAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("DoctorMaster/InsertOrUpdateDoctorBusinessLink", obj).Result;
                return Json(Insertresponse.Data);

            }
            catch (Exception ex)
            {
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Get Business Location DDL
        /// </summary>
        [HttpPost]
        public JsonResult GetDoctorLinkWithBusinessLocation(int doctorId)
        {
            try
            {
                var response = _facilityAPIServices.HttpClientServices.GetAsync<List<DO_DoctorBusinessLink>>("DoctorMaster/GetDoctorLinkWithBusinessLocation?doctorId=" + doctorId).Result;
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
        #endregion

        #region Doctor Profile Image
        /// <summary>
        /// Get Doctor Master Image & Signature 
        /// </summary>
        [HttpPost]
        public JsonResult GetDoctorProfileImagebyDoctorId(int doctorId)
        {
            try
            {
                var response = _facilityAPIServices.HttpClientServices.GetAsync<DO_DoctorImage>("DoctorMaster/GetDoctorProfileImagebyDoctorId?doctorId=" + doctorId).Result;
                if (response.Status)
                {
                    //return Json(response.Data);
                    if (response.Data != null && response.Data!=null)
                    {
                        var resdata = response.Data;

                        string doctorimageURI = string.Empty;
                        string doctorsignURI = string.Empty;
                        if (resdata.DoctorProfileImage != null)
                            doctorimageURI = ConvertByteArraytoImageURI(resdata.DoctorProfileImage);
                        resdata.DoctorProfileTitle = doctorimageURI;

                        if (resdata.DoctorSignatureImage != null)
                            doctorsignURI = ConvertByteArraytoImageURI(resdata.DoctorSignatureImage);
                        resdata.DoctorSignatureTitle = doctorsignURI;
                        return Json(resdata);
                    }
                    else
                    {
                        _logger.LogError(new Exception(response.Message), "UD:GetDoctorProfileImagebyDoctorId:For doctorId {0}", doctorId);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
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
        /// Insert Doctor Master
        /// </summary>
        [HttpPost]
        public JsonResult InsertIntoDoctorProfileImage(DO_DoctorImage obj)
        {
            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                if (obj.DoctorProfileTitle != null && obj.DoctorSignatureTitle!=null)
                {

                    string doctorImagebase64 = obj.DoctorProfileTitle;// load base 64 code to this variable from js 
                    string doctorSignbase64 = obj.DoctorSignatureTitle;// load base 64 code to this variable from js 

                    Byte[] doctorImagebitmapData = new Byte[doctorImagebase64.Length];
                    Byte[] doctorSignbitmapData = new Byte[doctorSignbase64.Length];
                    doctorImagebitmapData = Convert.FromBase64String(FixBase64ForImage(doctorImagebase64));
                    doctorSignbitmapData = Convert.FromBase64String(FixBase64ForImage(doctorSignbase64));
                    if (doctorImagebitmapData.Length > 2 * 1024 * 1024)
                    {
                        return Json(new DO_ReturnParameter() { Status = false, Message = "Doctor Photo file size should be smaller than 2 MB" });
                    }
                    if (doctorSignbitmapData.Length > 2 * 1024 * 1024)
                    {
                        return Json(new DO_ReturnParameter() { Status = false, Message = "Doctor Signature file size should be smaller than 2 MB" });
                    }
                    obj.DoctorProfileImage = doctorImagebitmapData;
                    obj.DoctorSignatureImage = doctorSignbitmapData;
                }
                else
                {
                    byte[] emptyByte = { };
                    obj.DoctorProfileImage = emptyByte;
                    obj.DoctorSignatureImage = emptyByte;
                }
                var Insertresponse = _facilityAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("DoctorMaster/InsertIntoDoctorProfileImage", obj).Result;
                return Json(Insertresponse.Data);

            }
            catch (Exception ex)
            {
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        #endregion

        #region Doctor Statutory details
        /// <summary>
        ///Get Doctor Statutory details by IsdCode
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetDoctorStatutoryDetails(int doctorId, int isdCode)
        {
            try
            {
                var serviceResponse = await _facilityAPIServices.HttpClientServices.GetAsync<List<DO_DoctorStatutoryDetails>>("DoctorMaster/GetDoctorStatutoryDetails?doctorId=" + doctorId + "&isdCode=" + isdCode);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetDoctorStatutoryDetails:For doctorId {0} and ISDCode {1}", doctorId, isdCode);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetDoctorStatutoryDetails:For BusinessKey {0} and ISDCode {1}", doctorId, isdCode);
                throw ex;
            }
        }

        /// <summary>
        /// Insert Into Doctor Statutory details
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateDoctorStatutoryDetails(List<DO_DoctorStatutoryDetails> obj)
        {
            try
            {
                obj.All(c =>
                {
                    c.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                    c.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                    c.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext).ToString();
                    return true;
                });

                var serviceResponse = await _facilityAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("DoctorMaster/InsertOrUpdateDoctorStatutoryDetails", obj);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertOrUpdateDoctorStatutoryDetails:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateDoctorStatutoryDetails:params:" + JsonConvert.SerializeObject(obj));
                throw ex;
            }
        }

        /// <summary>
        /// Get ISD Code by Business key.
        /// </summary>
        [HttpGet]
        public async Task<JsonResult> GetISDCodesbyBusinessKey(int businessKey)
        {
            try
            {
                var serviceResponse = await _facilityAPIServices.HttpClientServices.GetAsync<List<DO_ISDCodes>>("DoctorMaster/GetISDCodesbyBusinessKey?businessKey="+ businessKey);
                
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data.Count > 0)
                    {
                        foreach(var i in serviceResponse.Data)
                        {

                            i.CountryName = "<div  style=\"float: left;\"><img src='" + this.Request.PathBase + '/' + i.CountryFlag + "'/></div>" + '(' + '+' + i.Isdcode + ')' + i.CountryName;

                            i.DomainName = this.Request.PathBase;
                        }
                        var res= serviceResponse.Data.GroupBy(x => x.Isdcode).Select(y => y.First()).Distinct();
                        return Json(res);

                    }
                    else
                    {
                        return Json(serviceResponse.Data);
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetISDCodesbyBusinessKey:For businessKey ", businessKey);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetISDCodesbyBusinessKey:For isdCode ", businessKey);
                throw ex;
            }
        }

        /// <summary>
        /// Get ISD Code by Doctor Id.
        /// </summary>
        [HttpGet]
        public async Task<JsonResult> GetISDCodesbyDoctorId(int doctorId)
        {
            try
            {
                var serviceResponse = await _facilityAPIServices.HttpClientServices.GetAsync<List<DO_ISDCodes>>("DoctorMaster/GetISDCodesbyDoctorId?doctorId=" + doctorId);

                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data.Count > 0)
                    {
                        foreach (var i in serviceResponse.Data)
                        {
                            i.CountryName = "<div  style=\"float: left;\"><img src='" + this.Request.PathBase +'/'+i.CountryFlag+ "'/></div>" + '(' + '+' + i.Isdcode + ')' + i.CountryName ;

                            i.DomainName = this.Request.PathBase;
                        }
                        return Json(serviceResponse.Data);

                    }
                    else
                    {
                        return Json(serviceResponse.Data);
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetISDCodesbyDoctorId:For DoctorId ", doctorId);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetISDCodesbyDoctorId:For DoctorId ", doctorId);
                throw ex;
            }
        }

        #endregion

        #region Doctor Profile Consultation Rates
        /// <summary>
        ///Get Doctor Profile Consultation
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetDoctorProfileConsultationRatebyDoctorId(int businessKey, int clinictype, string currencycode, int ratetype, int doctorId)
        {
            try
            {
                var parameter = "?businessKey=" + businessKey + "&clinictype=" + clinictype + "&currencycode=" + currencycode + "&ratetype=" + ratetype + "&doctorId=" + doctorId;

                var serviceResponse = await _facilityAPIServices.HttpClientServices.GetAsync<List<DO_DoctorProfileConsultationRate>>("DoctorMaster/GetDoctorProfileConsultationRatebyDoctorId"+ parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetDoctorProfileConsultationRatebyDoctorId");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetDoctorProfileConsultationRatebyDoctorId");
                throw ex;
            }
        }

        /// <summary>
        /// Insert Into Doctor Profile Consultation Rates
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> AddOrUpdateDoctorProfileConsultationRate(List<DO_DoctorProfileConsultationRate> obj)
        {
            try
            {
                obj.All(c =>
                {
                    c.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                    c.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                    c.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext).ToString();
                    return true;
                });

                var serviceResponse = await _facilityAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("DoctorMaster/AddOrUpdateDoctorProfileConsultationRate", obj);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:AddOrUpdateDoctorProfileConsultationRate:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:AddOrUpdateDoctorProfileConsultationRate:params:" + JsonConvert.SerializeObject(obj));
                throw ex;
            }
        }
        #endregion

        #region Doctor Profile Address
        /// <summary>
        /// Get State List by isdCode.
        /// </summary>
        [HttpGet]
        public async Task<JsonResult> GetStatesbyIsdCode(int Isdcode)
        {
            try
            {
                var parameter = "?Isdcode=" + Isdcode;
                var serviceResponse = await _facilityAPIServices.HttpClientServices.GetAsync<List<DO_DoctorProfileAddress>>("DoctorMaster/GetStatesbyIsdCode" + parameter);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetStatesbyIsdCode:For isdCode ", Isdcode);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetStatesbyIsdCode:For isdCode ", Isdcode);
                throw ex;
            }
        }
        /// <summary>
        /// Get City List by isdCode and stateCode.
        /// </summary>
        [HttpGet]
        public async Task<JsonResult> GetCitiesbyStateCode(int Isdcode, int statecode)
        {
            try
            {
                var parameter = "?Isdcode=" + Isdcode + "&statecode=" + statecode;
                var serviceResponse = await _facilityAPIServices.HttpClientServices.GetAsync<List<DO_DoctorProfileAddress>>("DoctorMaster/GetCitiesbyStateCode" + parameter);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetCitiesbyStateCode:For isdCode {0} with stateCode entered {1}", Isdcode, statecode);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetCitiesbyStateCode:For isdCode {0} with stateCode entered {1}", Isdcode, statecode);
                throw ex;
            }
        }


        [HttpGet]
        public async Task<JsonResult> GetZipDescriptionbyCityCode(int Isdcode, int statecode, int citycode)
        {
            try
            {
                var parameter = "?Isdcode=" + Isdcode + "&statecode=" + statecode + "&citycode=" + citycode;
                var serviceResponse = await _facilityAPIServices.HttpClientServices.GetAsync<List<DO_DoctorProfileAddress>>("DoctorMaster/GetZipDescriptionbyCityCode" + parameter);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetZipDescriptionbyCityCode:For isdCode {0} with stateCode entered {1}", Isdcode, statecode, citycode);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetZipDescriptionbyCityCode:For isdCode {0} with stateCode entered {1}", Isdcode, statecode, citycode);
                throw ex;
            }
        }


        /// <summary>
        /// Get Area  details and Zip Code by Serial Number
        /// UI Reffered - Doctor Profile Master
        [HttpGet]
        public async Task<JsonResult> GetZipCodeAndArea(int Isdcode, int statecode, int citycode, int zipserialno)
        {
            try
            {
                var parameter = "?Isdcode=" + Isdcode + "&statecode=" + statecode + "&citycode=" + citycode + "&zipserialno=" + zipserialno;
                var serviceResponse = await _facilityAPIServices.HttpClientServices.GetAsync<DO_DoctorProfileAddress>("DoctorMaster/GetZipCodeAndArea" + parameter);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetZipCodeAndArea:For isdCode {0} with stateCode entered {1}", Isdcode, statecode, citycode);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetZipCodeAndArea:For isdCode {0} with stateCode entered {1}", Isdcode, statecode, citycode);
                throw ex;
            }
        }
        /// <summary>
        /// Get Doctor Area details for select by default dropdown values based on  pincode Text box
        /// UI Reffered - Doctor Profile Master
        [HttpGet]
        public async Task<JsonResult> FillCoumbosbyZipCode(int Isdcode, string zipcode)
        {
            try
            {
                var parameter = "?Isdcode=" + Isdcode + "&zipcode=" + zipcode;
                var serviceResponse = await _facilityAPIServices.HttpClientServices.GetAsync<DO_DoctorProfileAddress>("DoctorMaster/FillCoumbosbyZipCode" + parameter);
                if (serviceResponse.Status)
                {

                    return Json(serviceResponse.Data);

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:FillCoumbosbyZipCode:For isdCode {0} with stateCode cityCode pincode entered {1} ", Isdcode, zipcode);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetAreaDetailsbyPincode:For isdCode {0} with  pincode entered {1} }", Isdcode, zipcode);
                throw ex;
            }
        }

        /// <summary>
        /// Get Business Address by businessKey.
        /// </summary>
        [HttpGet]
        public async Task<JsonResult> GetDoctorAddressDoctorId(int Isdcode, int doctorId)
        {
            try
            {
                var parameter = "?Isdcode=" + Isdcode + "&doctorId=" + doctorId;
                var serviceResponse = await _facilityAPIServices.HttpClientServices.GetAsync<DO_DoctorProfileAddress>("DoctorMaster/GetDoctorAddressDoctorId" + parameter);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetDoctorAddressDoctorId:For Isd Code ", Isdcode);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetDoctorAddressDoctorId:For Isd code ", Isdcode);
                throw ex;
            }
        }

        /// <summary>
        /// Insert or Update Business Address
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateIntoDoctorProfileAddress(DO_DoctorProfileAddress obj)
        {

            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);

                var serviceResponse = await _facilityAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("DoctorMaster/InsertOrUpdateIntoDoctorProfileAddress", obj);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateIntoDoctorProfileAddress:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        #endregion

        
    }


}