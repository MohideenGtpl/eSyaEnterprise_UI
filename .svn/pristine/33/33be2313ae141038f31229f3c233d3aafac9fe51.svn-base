using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using eSyaEnterprise_UI.ActionFilter;
using eSyaEnterprise_UI.Areas.PatientManagement.Data;
using eSyaEnterprise_UI.Areas.PatientManagement.Models;
using eSyaEnterprise_UI.Models;
using eSyaEnterprise_UI.Utility;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace eSyaEnterprise_UI.Areas.PatientManagement.Controllers
{
    [SessionTimeout]
    public class ClinicalFormsController : Controller
    {
        private readonly IPatientManagementAPIServices _patientManagementAPIServices;
        private readonly ILogger<PatientInfoController> _logger;

        private readonly IHostingEnvironment _hostingEnvironment;

        public ClinicalFormsController(IPatientManagementAPIServices patientManagementAPIServices, ILogger<PatientInfoController> logger, IHostingEnvironment hostingEnvironment)
        {
            _patientManagementAPIServices = patientManagementAPIServices;
            _logger = logger;
            _hostingEnvironment = hostingEnvironment;
        }


        [Area("PatientManagement")]
        public IActionResult Triage(long UHID, long vNumber)
        {
            ViewBag.UHID = UHID;
            ViewBag.vNumber = vNumber;
            return View();
        }
        [Area("PatientManagement")]
        public IActionResult PatientEMR(long UHID, long vNumber)
        {
            ViewBag.UHID = UHID;
            ViewBag.vNumber = vNumber;
            return View();
        }       
        [Area("PatientManagement")]
        public IActionResult _PatientInfo()
        {
            return View();
        }
        [Area("PatientManagement")]
        public IActionResult _ChronicCondition()
        {
            return View();
        }
        [Area("PatientManagement")]
        public IActionResult _Allergy()
        {
            return View();
        }
        [Area("PatientManagement")]
        public IActionResult _Medication()
        {
            return View();
        }
        [Area("PatientManagement")]
        public IActionResult _VitalSigns()
        {
            return View();
        }
        [Area("PatientManagement")]
        public IActionResult _Diagnosis()
        {
            return View();
        }
        [Area("PatientManagement")]
        public IActionResult _Examination()
        {
            return View();
        }
        [Area("PatientManagement")]
        public IActionResult _InvestigationOrder()
        {
            return View();
        }
        [Area("PatientManagement")]
        public IActionResult _SickLeave()
        {
            return View();
        }
        [Area("PatientManagement")]
        public IActionResult _DocumentUpload()
        {
            return View();
        }
        [Area("PatientManagement")]
        public IActionResult _Services()
        {
            return View();
        }
        [HttpGet]
        public async Task<JsonResult> GetClinicalInformation(long UHID, long vNumber, string clType)
        {
            try
            {
                var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
                parameter += "&UHID=" + UHID.ToString();
                parameter += "&vNumber=" + vNumber.ToString();
                parameter += "&clType=" + clType.ToString();

                var serviceResponse = await _patientManagementAPIServices.HttpClientServices.GetAsync<List<DO_ClinicalInformation>>("ClinicalForms/GetClinicalInformation" + parameter);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), string.Format("UD:GetClinicalInformation:params: businessKey:{0},UHID:{1},vnumber:{2}",
                        AppSessionVariables.GetSessionBusinessKey(HttpContext).ToString(), UHID, vNumber));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, string.Format("UD:GetClinicalInformation:params: businessKey:{0},UHID:{1},vnumber:{2}",
                        AppSessionVariables.GetSessionBusinessKey(HttpContext).ToString(), UHID, vNumber));
                throw ex;
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetPatientByUHID(long uhid)
        {
            try
            {
                var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
                parameter += "&uhid=" + uhid.ToString();
                var serviceResponse = await _patientManagementAPIServices.HttpClientServices.GetAsync<List<DO_PatientAppointmentDetail>>("ClinicalForms/GetPatientByUHID" + parameter);
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

        [HttpPost]
        public async Task<JsonResult> InsertIntoClinicalInformation(DO_ClinicalInformation obj)
        {
            try
            {
                obj.BusinessKey = AppSessionVariables.GetSessionBusinessKey(HttpContext);
                obj.ActiveStatus = true;
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);

                obj.TransactionDate = System.DateTime.Now;

                var serviceResponse = await _patientManagementAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("ClinicalForms/InsertIntoClinicalInformation", obj);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data.Status)
                        return Json(new { Status = true, serviceResponse.Data.Message });
                    else
                        return Json(new { Status = false, serviceResponse.Data.Message });
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertIntoClinicalInformation:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertIntoClinicalInformation:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Warning = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
            }
        }

        [HttpPost]
        public async Task<IActionResult> UploadFiles(IList<IFormFile> fileData)
        {
            // Checking no of files injected in Request object  
            if (Request.Form.Files.Count > 0)
            {
                try
                {
                    var p_vals = Request.Form.ToDictionary(x => x.Key, x => x.Value.ToString());

                    long size = Request.Form.Files.Sum(f => f.Length);
                    var pathString = "";
                    var filePaths = new List<string>();
                    var files = Request.Form.Files;
                    foreach (var formFile in files)
                    {
                        string fileRootPath = _hostingEnvironment.WebRootPath;
                        //string fileRootPath = @"http:\\localhost:56125\";

                        var dir_path = @"UHID_" + p_vals["UHID"] ;

                        var basePath = Path.Combine(fileRootPath, "ClinicalFormsAttachments", dir_path);
                        bool basePathExists = System.IO.Directory.Exists(basePath);
                        if (!basePathExists) Directory.CreateDirectory(basePath);

                        pathString = dir_path + @"\" + System.DateTime.Now.ToString("ddMMyyyyhhmmss");
                        var index_point = formFile.FileName.IndexOf(".");
                        pathString += formFile.FileName.Substring(index_point);

                        var filePath = Path.Combine(fileRootPath, "ClinicalFormsAttachments", pathString);
                        //    System.IO.File.Delete(filePath);

                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            await formFile.CopyToAsync(stream);
                        }
                    }

                    return Json(pathString);
                }
                catch (Exception ex)
                {
                    return Json("Error occurred. Error details: " + ex.Message);
                }
            }
            else
            {
                return Json("No files selected.");
            }


        }

        [HttpGet]
        public async Task<JsonResult> GetInformationValueView(int UHID, int vNumber, string clType)
        {
            try
            {
                var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
                parameter += "&UHID=" + UHID.ToString();
                parameter += "&vNumber=" + vNumber.ToString();
                parameter += "&clType=" + clType.ToString();

                var serviceResponse = await _patientManagementAPIServices.HttpClientServices.GetAsync<List<DO_ClinicalInformation>>("ClinicalForms/GetInformationValueView" + parameter);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), string.Format("UD:GetClinicalInformationValueView:params: businessKey:{0},UHID:{1},vnumber:{2}",
                        AppSessionVariables.GetSessionBusinessKey(HttpContext).ToString(), UHID, vNumber));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, string.Format("UD:GetClinicalInformationValueView:params: businessKey:{0},UHID:{1},vnumber:{2}",
                        AppSessionVariables.GetSessionBusinessKey(HttpContext).ToString(), UHID, vNumber));
                throw ex;
            }
        }

        [HttpPost]
        public async Task<JsonResult> InsertPatientClinicalInformation(DO_ClinicalInformation obj)
        {
            try
            {
                obj.BusinessKey = AppSessionVariables.GetSessionBusinessKey(HttpContext);
                obj.ActiveStatus = true;
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);

                obj.TransactionDate = System.DateTime.Now;

                var serviceResponse = await _patientManagementAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("ClinicalForms/InsertPatientClinicalInformation", obj);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data.Status)
                        return Json(new { Status = true, serviceResponse.Data.Message });
                    else
                        return Json(new { Status = false, serviceResponse.Data.Message });
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertPatientClinicalInformation:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertPatientClinicalInformation:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Warning = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
            }
        }

        [HttpPost]
        public async Task<JsonResult> UpdatePatientClinicalInformation(DO_ClinicalInformation obj)
        {
            try
            {
                obj.BusinessKey = AppSessionVariables.GetSessionBusinessKey(HttpContext);
                obj.ActiveStatus = true;
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);

                var serviceResponse = await _patientManagementAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("PreOperative/UpdatePatientClinicalInformation", obj);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data.Status)
                        return Json(new { Status = true, serviceResponse.Data.Message });
                    else
                        return Json(new { Status = false, serviceResponse.Data.Message });
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:UpdatePatientClinicalInformation:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:UpdatePatientClinicalInformation:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Warning = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
            }
        }

        [HttpGet]
        public async Task<JsonResult> GetClinicalInformationValueByTransaction(long UHID, long vNumber, int transactionID)
        {
            try
            {
                var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
                parameter += "&UHID=" + UHID.ToString();
                parameter += "&vNumber=" + vNumber.ToString();
                parameter += "&transactionID=" + transactionID.ToString();

                var serviceResponse = await _patientManagementAPIServices.HttpClientServices.GetAsync<List<DO_ClinicalInformation>>("ClinicalForms/GetClinicalInformationValueByTransaction" + parameter);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), string.Format("UD:GetClinicalInformationValueByTransaction:params: businessKey:{0},UHID:{1},vNumber:{2},transactionID:{3}",
                        AppSessionVariables.GetSessionBusinessKey(HttpContext).ToString(), UHID, vNumber, transactionID));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, string.Format("UD:GetClinicalInformationValueByTransaction:params: businessKey:{0},UHID:{1},vNumber:{2},transactionID:{3}",
                        AppSessionVariables.GetSessionBusinessKey(HttpContext).ToString(), UHID, vNumber, transactionID));
                throw ex;
            }
        }

        [HttpPost]
        public async Task<JsonResult> DeletePatientClinicalInformation(DO_ClinicalInformation obj)
        {
            try
            {
                obj.BusinessKey = AppSessionVariables.GetSessionBusinessKey(HttpContext);
                obj.ActiveStatus = false;
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);

                var serviceResponse = await _patientManagementAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("ClinicalForms/DeletePatientClinicalInformation", obj);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data.Status)
                        return Json(new { Status = true, serviceResponse.Data.Message });
                    else
                        return Json(new { Status = false, serviceResponse.Data.Message });
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:DeletePatientClinicalInformation:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:DeletePatientClinicalInformation:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Warning = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
            }
        }


    }
}