using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using eSyaEnterprise_UI.Models;
using eSyaEnterprise_UI.Areas.eSyaPatientPortal.Data;
using eSyaEnterprise_UI.Areas.eSyaPatientPortal.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using eSyaEnterprise_UI.ActionFilter;
using eSyaEnterprise_UI.Utility;

namespace eSyaEnterprise_UI.Areas.eSyaPatientPortal.Controllers
{
    public class PreRegistrationController : Controller
    {
        private readonly IeSyaPatientPortalAPIServices _eSyaPatientPortalAPIServices;
        private readonly ILogger<PreRegistrationController> _logger;
        public PreRegistrationController(IeSyaPatientPortalAPIServices eSyaPatientPortalAPIServices, ILogger<PreRegistrationController> logger)
        {
            _eSyaPatientPortalAPIServices = eSyaPatientPortalAPIServices;
            _logger = logger;
        }

        [Area("eSyaPatientPortal")]
        public async Task<IActionResult> Index()
        {
            try
            {
                List<int> l_ac = new List<int>();
                l_ac.Add(PatientCodeTypeValues.MotherTongue);
                l_ac.Add(PatientCodeTypeValues.SpeakingLanguage);
                l_ac.Add(PatientCodeTypeValues.RefferedBy);
                l_ac.Add(PatientCodeTypeValues.Complaints);
               
                var response = await _eSyaPatientPortalAPIServices.HttpClientServices.PostAsJsonAsync<List<DO_ApplicationCodes>>("CommonData/GetApplicationCodesByCodeTypeList", l_ac);
                

                if (response.Status)
                {
                    if (response.Data != null)
                    {
                        List<DO_ApplicationCodes> app_codes = response.Data;

                        ViewBag.MotherTongueList = app_codes.Where(w => w.CodeType == PatientCodeTypeValues.MotherTongue).Select(b => new SelectListItem
                        {
                            Value = b.ApplicationCode.ToString(),
                            Text = b.CodeDesc,
                        }).ToList();

                        ViewBag.RefferedByList = app_codes.Where(w => w.CodeType == PatientCodeTypeValues.RefferedBy).Select(b => new SelectListItem
                        {
                            Value = b.ApplicationCode.ToString(),
                            Text = b.CodeDesc,
                        }).ToList();

                        ViewBag.SpeakingLanguageList = app_codes.Where(w => w.CodeType == PatientCodeTypeValues.SpeakingLanguage).Select(b => new SelectListItem
                        {
                            Value = b.ApplicationCode.ToString(),
                            Text = b.CodeDesc,
                        }).ToList();

                        ViewBag.ComplaintsList = app_codes.Where(w => w.CodeType == PatientCodeTypeValues.Complaints).Select(b => new SelectListItem
                        {
                            Value = b.ApplicationCode.ToString(),
                            Text = b.CodeDesc,
                        }).ToList();

                      
                    }
                    else
                    {
                        _logger.LogError(new Exception(response.Message), "UD:Index");
                    }
                }
                else
                {
                    _logger.LogError(new Exception(response.Message), "UD:Index");
                }
                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:Index");
                throw ex;
            }
        }


        /// <summary>
        /// Insert into Patient PreRegistration.
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertPatientPreRegistration(DO_PatientPreRegistration obj)
        {
            try
            {
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.BusinessKey = AppSessionVariables.GetSessionBusinessKey(HttpContext);
                obj.Prdate = DateTime.Now;
                var serviceResponse = await _eSyaPatientPortalAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("PatientPreRegistration/InsertPatientPreRegistration", obj);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertPatientPreRegistration:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertPatientPreRegistration:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }
    }
}