using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using eSyaEnterprise_UI.ActionFilter;
using eSyaEnterprise_UI.Areas.eSyaOutPatient.Data;
using eSyaEnterprise_UI.Areas.eSyaOutPatient.Models;
using eSyaEnterprise_UI.Models;
using eSyaEnterprise_UI.Utility;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace eSyaEnterprise_UI.Areas.eSyaOutPatient.Controllers
{
    [SessionTimeout]
    public class PatientClinicalFormsController : Controller
    {
        private readonly IeSyaOutPatientAPIServices _eSyaOutPatientAPIServices;
        private readonly ILogger<PatientClinicalFormsController> _logger;

        private readonly IHostingEnvironment _hostingEnvironment;

        public PatientClinicalFormsController(IeSyaOutPatientAPIServices eSyaOutPatientAPIServices, ILogger<PatientClinicalFormsController> logger, IHostingEnvironment hostingEnvironment)
        {
            _eSyaOutPatientAPIServices = eSyaOutPatientAPIServices;
            _logger = logger;
            _hostingEnvironment = hostingEnvironment;
        }



        [Area("eSyaOutPatient")]
        public IActionResult PreOperative(int UHID, int AppKey, string IsApp)
        {
            int userType = AppSessionVariables.GetSessionUserType(HttpContext);
            ViewBag.UHID = UHID;
            ViewBag.AppKey = AppKey;
            ViewBag.IsApp = IsApp;
            return View();
        }

        [Area("eSyaOutPatient")]
        public IActionResult FacilityStay(int UHID, int AppKey, string IsApp)
        {
            ViewBag.UHID = UHID;
            ViewBag.AppKey = AppKey;
            ViewBag.IsApp = IsApp;
            return View();
        }
        [Area("eSyaOutPatient")]
        public IActionResult SurgicalFollowup(int UHID, int AppKey, string IsApp)
        {
            ViewBag.UHID = UHID;
            ViewBag.AppKey = AppKey;
            ViewBag.IsApp = IsApp;
            return View();
        }
        [Area("eSyaOutPatient")]
        public IActionResult NutritionFollowup(int UHID, int AppKey, string IsApp)
        {
            ViewBag.UHID = UHID;
            ViewBag.AppKey = AppKey;
            ViewBag.IsApp = IsApp;
            return View();
        }
        [Area("eSyaOutPatient")]
        public IActionResult PatientEMR(int UHID, string IsApp)
        {
            //ViewBag.UserFormRoles = new DO_UserFormRole { IsSurgeon = false, IsNutrition=true};
            ViewBag.UT = AppSessionVariables.GetSessionUserType(HttpContext);
            ViewBag.UHID = UHID;
            ViewBag.IsApp = IsApp;
            return View();
        }
        [Area("eSyaOutPatient")]
        public IActionResult PatientForm(int UHID, string fType, string IsApp)
        {
            ViewBag.UHID = UHID;
            ViewBag.fType = fType;
            ViewBag.IsApp = IsApp;
            return View();
        }
        [Area("eSyaOutPatient")]
        public IActionResult PatientForms(int UHID, string IsApp)
        {
            ViewBag.UT = AppSessionVariables.GetSessionUserType(HttpContext);
            ViewBag.UHID = UHID;
            ViewBag.IsApp = IsApp;
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> InsertIntoPreOperativeInformation(DO_PreOperativeInformation obj)
        {
            try
            {
                obj.BusinessKey = AppSessionVariables.GetSessionBusinessKey(HttpContext);
                obj.ActiveStatus = true;
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);

                obj.TransactionDate = System.DateTime.Now; 

                var serviceResponse = await _eSyaOutPatientAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("PreOperative/InsertIntoPreOperativeInformation", obj);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data.Status)
                        return Json(new { Status = true, serviceResponse.Data.Message });
                    else
                        return Json(new { Status = false, serviceResponse.Data.Message });
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertIntoPreOperativeInformation:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertIntoPreOperativeInformation:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Warning = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
            }
        }

        [HttpPost]
        public async Task<JsonResult> InsertPatientClinicalInformation(DO_PreOperativeInformation obj)
        {
            try
            {
                obj.BusinessKey = AppSessionVariables.GetSessionBusinessKey(HttpContext);
                obj.ActiveStatus = true;
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);

                obj.TransactionDate = System.DateTime.Now;

                var serviceResponse = await _eSyaOutPatientAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("PreOperative/InsertPatientClinicalInformation", obj);
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
        public async Task<JsonResult> UpdatePatientClinicalInformation(DO_PreOperativeInformation obj)
        {
            try
            {
                obj.BusinessKey = AppSessionVariables.GetSessionBusinessKey(HttpContext);
                obj.ActiveStatus = true;
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);

                var serviceResponse = await _eSyaOutPatientAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("PreOperative/UpdatePatientClinicalInformation", obj);
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

        [HttpPost]
        public async Task<JsonResult> DeletePatientClinicalInformation(DO_PreOperativeInformation obj)
        {
            try
            {
                obj.BusinessKey = AppSessionVariables.GetSessionBusinessKey(HttpContext);
                obj.ActiveStatus = false;
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);

                var serviceResponse = await _eSyaOutPatientAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("PreOperative/DeletePatientClinicalInformation", obj);
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

        [HttpGet]
        public async Task<JsonResult> GetPreOperativeInformationValueByTransaction(int UHID, int vNumber, int transactionID)
        {
            try
            {
                var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
                parameter += "&UHID=" + UHID.ToString();
                parameter += "&vNumber=" + vNumber.ToString();
                parameter += "&transactionID=" + transactionID.ToString();

                var serviceResponse = await _eSyaOutPatientAPIServices.HttpClientServices.GetAsync<List<DO_PreOperativeInformation>>("PreOperative/GetPreOperativeInformationValueByTransaction" + parameter);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), string.Format("UD:GetPreOperativeInformationValueByTransaction:params: businessKey:{0},UHID:{1},visitnumber:{2},transactionID:{3}",
                        AppSessionVariables.GetSessionBusinessKey(HttpContext).ToString(), UHID, vNumber, transactionID));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, string.Format("UD:GetPreOperativeInformationValueByTransaction:params: businessKey:{0},UHID:{1},visitnumber:{2},transactionID:{3}",
                        AppSessionVariables.GetSessionBusinessKey(HttpContext).ToString(), UHID, vNumber, transactionID));
                throw ex;
            }
        }

        [HttpGet]
        public async Task<JsonResult> GetPreOperativeInformation(int UHID, int vNumber, string clType)
        {
            try
            {
                var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
                parameter += "&UHID=" + UHID.ToString();
                parameter += "&vNumber=" + vNumber.ToString();
                parameter += "&clType=" + clType.ToString();

                var serviceResponse = await _eSyaOutPatientAPIServices.HttpClientServices.GetAsync<List<DO_PreOperativeInformation>>("PreOperative/GetPreOperativeInformation" + parameter);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), string.Format("UD:GetPreOperativeInformation:params: businessKey:{0},UHID:{1},vnumber:{2}",
                        AppSessionVariables.GetSessionBusinessKey(HttpContext).ToString(), UHID, vNumber));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, string.Format("UD:GetPreOperativeInformation:params: businessKey:{0},UHID:{1},vnumber:{2}",
                        AppSessionVariables.GetSessionBusinessKey(HttpContext).ToString(), UHID, vNumber));
                throw ex;
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

                var serviceResponse = await _eSyaOutPatientAPIServices.HttpClientServices.GetAsync<List<DO_PreOperativeInformation>>("PreOperative/GetInformationValueView" + parameter);
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

        [HttpGet]
        public async Task<JsonResult> GetClinicalInformationValueByTransaction(int UHID, int vNumber, int transactionID)
        {
            try
            {
                var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
                parameter += "&UHID=" + UHID.ToString();
                parameter += "&vNumber=" + vNumber.ToString();
                parameter += "&transactionID=" + transactionID.ToString();

                var serviceResponse = await _eSyaOutPatientAPIServices.HttpClientServices.GetAsync<List<DO_PreOperativeInformation>>("PreOperative/GetClinicalInformationValueByTransaction" + parameter);
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

                        var dir_path = @"UHID_" + p_vals["UHID"] + @"\V_" + p_vals["Visit"];

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
        public async Task<JsonResult> GetFormDetailByType(int UHID, string fType)
        {
            try
            {
                var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
                parameter += "&UHID=" + UHID.ToString();
                parameter += "&fType=" + fType.ToString();

                var serviceResponse = await _eSyaOutPatientAPIServices.HttpClientServices.GetAsync<List<DO_PreOperativeInformation>>("PreOperative/GetFormDetailByType" + parameter);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), string.Format("UD:GetFormDetailByType:params: businessKey:{0},UHID:{1},fType:{2}",
                        AppSessionVariables.GetSessionBusinessKey(HttpContext).ToString(), UHID, fType));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, string.Format("UD:GetFormDetailByType:params: businessKey:{0},UHID:{1},fType:{2}",
                        AppSessionVariables.GetSessionBusinessKey(HttpContext).ToString(), UHID, fType));
                throw ex;
            }
        }

        [HttpGet]
        public async Task<JsonResult> GetSurgeries(int UHID)
        {
            try
            {
                var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
                parameter += "&UHID=" + UHID.ToString();

                var serviceResponse = await _eSyaOutPatientAPIServices.HttpClientServices.GetAsync<List<DO_PreOperativeInformation>>("PreOperative/GetSurgeries" + parameter);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), string.Format("UD:GetSurgeries:params: businessKey:{0},UHID:{1}",
                        AppSessionVariables.GetSessionBusinessKey(HttpContext).ToString(), UHID));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, string.Format("UD:GetSurgeries:params: businessKey:{0},UHID:{1}",
                        AppSessionVariables.GetSessionBusinessKey(HttpContext).ToString(), UHID));
                throw ex;
            }
        }

    }
}