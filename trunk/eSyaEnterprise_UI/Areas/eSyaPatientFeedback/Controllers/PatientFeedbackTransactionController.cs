using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eSyaEnterprise_UI.ActionFilter;
using eSyaEnterprise_UI.Areas.eSyaPatientFeedback.Data;
using eSyaEnterprise_UI.Areas.eSyaPatientFeedback.Models;
using eSyaEnterprise_UI.Models;
using eSyaEnterprise_UI.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace eSyaEnterprise_UI.Areas.eSyaPatientFeedback.Controllers
{
    [SessionTimeout]
    public class PatientFeedbackTransactionController : Controller
    {
        private readonly IeSyaPatientFeedbackAPIServices _eSyaPatientFeedbackAPIServices;
        private readonly ILogger<PatientFeedbackTransactionController> _logger;

        public PatientFeedbackTransactionController(IeSyaPatientFeedbackAPIServices eSyaPatientFeedbackAPIServices, ILogger<PatientFeedbackTransactionController> logger)
        {
            _eSyaPatientFeedbackAPIServices = eSyaPatientFeedbackAPIServices;
            _logger = logger;
        }

        [Area("eSyaPatientFeedback")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> InPatient()
        {
            try
            {
                int businesskey= AppSessionVariables.GetSessionBusinessKey(HttpContext);
                var f_res = await _eSyaPatientFeedbackAPIServices.HttpClientServices.GetAsync<List<DO_Floor>>("PatientFeedbackTransaction/GetFloorsbyCodeType?codetype=" + CodeTypeValues.Floors);
                var sp_res = await _eSyaPatientFeedbackAPIServices.HttpClientServices.GetAsync<List<DO_Specialty>>("PatientFeedbackTransaction/GetSpecialtiesByBusinessKey?businesskey="+ businesskey);
                var doc_res = await _eSyaPatientFeedbackAPIServices.HttpClientServices.GetAsync<List<DO_Doctor>>("PatientFeedbackTransaction/GetDoctorsByBusinessKey?businesskey="+ businesskey);

                var parameter = "?feedBackType=" + "IP" + " &langauge=" + "EN";
                var q_master = await _eSyaPatientFeedbackAPIServices.HttpClientServices.GetAsync<List<DO_QuestionnaireMaster>>("FeedbackQuestionnaire/GetQuestionnaireMaster" + parameter);
                if (f_res.Status)
                {
                    ViewBag.Floors = f_res.Data.
                         Select(b => new SelectListItem
                         {
                             Value = b.FloorId.ToString(),
                             Text = b.FloorName,
                         }).ToList();
                }
                else
                {
                    _logger.LogError(new Exception(f_res.Message), "UD:GetFloorsbyCodeType:For codetype {0}", CodeTypeValues.Floors);

                }
                if (sp_res.Status)
                {

                    ViewBag.Specialties = sp_res.Data.
                    Select(b => new SelectListItem
                    {
                        Value = b.SpecialtyId.ToString(),
                        Text = b.SpecialtyName,
                    }).ToList();
                }
                else
                {
                    _logger.LogError(new Exception(sp_res.Message), "UD:GetSpecialtiesByBusinessKey:For businesskey {0}", businesskey);
                }
                if (doc_res.Status)
                {

                    ViewBag.Doctors = doc_res.Data.
                    Select(b => new SelectListItem
                    {
                        Value = b.DoctorId.ToString(),
                        Text = b.DoctorName,
                    }).ToList();
                }
                else
                {
                    _logger.LogError(new Exception(sp_res.Message), "UD:GetDoctorsByBusinessKey:For businesskey {0}", businesskey);
                }

                if (q_master.Status)
                {
                    ViewBag.questionarymaster = q_master.Data;
                        
                }

                else
                {
                    _logger.LogError(new Exception(sp_res.Message), "UD:GetQuestionnaireMaster:For feedbacktype {0}", parameter);
                }

                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetFloorsbyCodeType:For codetype {0}", CodeTypeValues.Floors);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Insert In Patient Feedback Questionnaire
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertIntoInPatientFeedbackQuestionnaire(DO_PatientFeedback obj)
        {

            try
            {
                obj.BusinessKey = AppSessionVariables.GetSessionBusinessKey(HttpContext);
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                obj.FinancialYear = (short)System.DateTime.Now.Year;


                var serviceResponse = await _eSyaPatientFeedbackAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("PatientFeedbackTransaction/InsertIntoPatientFeedbackQuestionnaire", obj);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });


            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertIntoPatientFeedbackQuestionnaire:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }


        [Area("eSyaPatientFeedback")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> OutPatient()
        {
            try
            {
                int businesskey = AppSessionVariables.GetSessionBusinessKey(HttpContext);
                var f_res = await _eSyaPatientFeedbackAPIServices.HttpClientServices.GetAsync<List<DO_Floor>>("PatientFeedbackTransaction/GetFloorsbyCodeType?codetype=" + CodeTypeValues.Floors);
                var sp_res = await _eSyaPatientFeedbackAPIServices.HttpClientServices.GetAsync<List<DO_Specialty>>("PatientFeedbackTransaction/GetSpecialtiesByBusinessKey?businesskey=" + businesskey);
                var doc_res = await _eSyaPatientFeedbackAPIServices.HttpClientServices.GetAsync<List<DO_Doctor>>("PatientFeedbackTransaction/GetDoctorsByBusinessKey?businesskey=" + businesskey);

                var parameter = "?feedBackType=" + "OP" + " &langauge=" + "EN";
                var q_master = await _eSyaPatientFeedbackAPIServices.HttpClientServices.GetAsync<List<DO_QuestionnaireMaster>>("FeedbackQuestionnaire/GetQuestionnaireMaster" + parameter);
                if (f_res.Status)
                {
                    ViewBag.Floors = f_res.Data.
                         Select(b => new SelectListItem
                         {
                             Value = b.FloorId.ToString(),
                             Text = b.FloorName,
                         }).ToList();
                }
                else
                {
                    _logger.LogError(new Exception(f_res.Message), "UD:GetFloorsbyCodeType:For codetype {0}", CodeTypeValues.Floors);

                }
                if (sp_res.Status)
                {

                    ViewBag.Specialties = sp_res.Data.
                    Select(b => new SelectListItem
                    {
                        Value = b.SpecialtyId.ToString(),
                        Text = b.SpecialtyName,
                    }).ToList();
                }
                else
                {
                    _logger.LogError(new Exception(sp_res.Message), "UD:GetSpecialtiesByBusinessKey:For businesskey {0}", businesskey);
                }
                if (doc_res.Status)
                {

                    ViewBag.Doctors = doc_res.Data.
                    Select(b => new SelectListItem
                    {
                        Value = b.DoctorId.ToString(),
                        Text = b.DoctorName,
                    }).ToList();
                }
                else
                {
                    _logger.LogError(new Exception(sp_res.Message), "UD:GetDoctorsByBusinessKey:For businesskey {0}", businesskey);
                }

                if (q_master.Status)
                {
                    ViewBag.questionarymaster = q_master.Data;

                }

                else
                {
                    _logger.LogError(new Exception(sp_res.Message), "UD:GetQuestionnaireMaster:For feedbacktype {0}", parameter);
                }

                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetFloorsbyCodeType:For codetype {0}", CodeTypeValues.Floors);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }


        /// <summary>
        /// Insert Out Patient Feedback Questionnaire
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertIntoOutPatientFeedbackQuestionnaire(DO_PatientFeedback obj)
        {

            try
            {
                obj.BusinessKey = AppSessionVariables.GetSessionBusinessKey(HttpContext);
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                obj.FinancialYear = (short)System.DateTime.Now.Year;


                var serviceResponse = await _eSyaPatientFeedbackAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("PatientFeedbackTransaction/InsertIntoPatientFeedbackQuestionnaire", obj);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });


            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertIntoOutPatientFeedbackQuestionnaire:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        [Area("eSyaPatientFeedback")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult FeedbackHeader()
        {
            try
            {
                return View();

              
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:FeedbackHeader");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }


        [HttpPost]
        public async Task<JsonResult> GetPatientFeedbackHeader(string feedbacktype, DateTime fromdate, DateTime todate)
        {

            try
            {

                var parameter = "?feedbacktype=" + feedbacktype ;
                parameter += "&fromdate=" + fromdate.ToString("dd-MMM-yyyy");
                parameter += "&todate=" + todate.ToString("dd-MMM-yyyy");

                var serviceResponse = await _eSyaPatientFeedbackAPIServices.HttpClientServices.GetAsync <List<DO_PatientFeedback>>("PatientFeedbackTransaction/GetPatientFeedbackHeader" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetPatientFeedbackHeader:For feedbacktype {0} ", feedbacktype);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }


        [Area("eSyaPatientFeedback")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult>  FeedbackDetails(int businesskey, long fbdocumentkey, string feedbacktype)
        {
            try
            {
                var f_res = await _eSyaPatientFeedbackAPIServices.HttpClientServices.GetAsync<List<DO_Floor>>("PatientFeedbackTransaction/GetFloorsbyCodeType?codetype=" + CodeTypeValues.Floors);
                var sp_res = await _eSyaPatientFeedbackAPIServices.HttpClientServices.GetAsync<List<DO_Specialty>>("PatientFeedbackTransaction/GetSpecialtiesByBusinessKey?businesskey=" + businesskey);
                var doc_res = await _eSyaPatientFeedbackAPIServices.HttpClientServices.GetAsync<List<DO_Doctor>>("PatientFeedbackTransaction/GetDoctorsByBusinessKey?businesskey=" + businesskey);

                var parameter = "?businesskey=" + businesskey + " &fbdocumentkey=" + fbdocumentkey + " &feedbacktype=" + feedbacktype;

                var q_master = await _eSyaPatientFeedbackAPIServices.HttpClientServices.GetAsync<DO_PatientFeedback>("PatientFeedbackTransaction/GetPatientFeedbackDetails" + parameter);
                if (f_res.Status)
                {
                    ViewBag.Floors = f_res.Data.
                         Select(b => new SelectListItem
                         {
                             Value = b.FloorId.ToString(),
                             Text = b.FloorName,
                         }).ToList();
                }
                else
                {
                    _logger.LogError(new Exception(f_res.Message), "UD:GetFloorsbyCodeType:For codetype {0}", CodeTypeValues.Floors);

                }
                if (sp_res.Status)
                {

                    ViewBag.Specialties = sp_res.Data.
                    Select(b => new SelectListItem
                    {
                        Value = b.SpecialtyId.ToString(),
                        Text = b.SpecialtyName,
                    }).ToList();
                }
                else
                {
                    _logger.LogError(new Exception(sp_res.Message), "UD:GetSpecialtiesByBusinessKey:For businesskey {0}", businesskey);
                }
                if (doc_res.Status)
                {

                    ViewBag.Doctors = doc_res.Data.
                    Select(b => new SelectListItem
                    {
                        Value = b.DoctorId.ToString(),
                        Text = b.DoctorName,
                    }).ToList();
                }
                else
                {
                    _logger.LogError(new Exception(sp_res.Message), "UD:GetDoctorsByBusinessKey:For businesskey {0}", businesskey);
                }

                if (q_master.Status)
                {
                    ViewBag.questionarymaster = q_master.Data;

                }

                else
                {
                    _logger.LogError(new Exception(sp_res.Message), "UD:GetQuestionnaireMaster:For feedbacktype {0}", parameter);
                }

                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetFloorsbyCodeType:For codetype {0}", CodeTypeValues.Floors);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
    }
}