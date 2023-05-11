using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using eSyaEnterprise_UI.ActionFilter;
using eSyaEnterprise_UI.Areas.eSyaNatureCure.Data;
using eSyaEnterprise_UI.Areas.eSyaNatureCure.Models;
using eSyaEnterprise_UI.Models;
using eSyaEnterprise_UI.Utility;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace eSyaEnterprise_UI.Areas.eSyaNatureCure.Controllers
{
    [SessionTimeout]
    public class VitalSignsController : Controller
    {
        private readonly IeSyaNatureCureAPIServices _eSyaNatureCureAPIServices;
        private readonly ILogger<ActivitiesController> _logger;

        private readonly IHostingEnvironment _hostingEnvironment;

        public VitalSignsController(IeSyaNatureCureAPIServices eSyaNatureCureAPIServices, ILogger<ActivitiesController> logger, IHostingEnvironment hostingEnvironment)
        {
            _eSyaNatureCureAPIServices = eSyaNatureCureAPIServices;
            _logger = logger;
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpGet]
        public async Task<JsonResult> GetClinicalInformation(long UHID, long ipNumber, string clType)
        {
            try
            {
                var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
                parameter += "&UHID=" + UHID.ToString();
                parameter += "&ipNumber=" + ipNumber.ToString();
                parameter += "&clType=" + clType.ToString();

                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_ClinicalInformation>>("ClinicalVitals/GetClinicalInformation" + parameter);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), string.Format("UD:GetClinicalInformation:params: businessKey:{0},UHID:{1},ipNumber:{2}",
                        AppSessionVariables.GetSessionBusinessKey(HttpContext).ToString(), UHID, ipNumber));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, string.Format("UD:GetClinicalInformation:params: businessKey:{0},UHID:{1},ipNumber:{2}",
                        AppSessionVariables.GetSessionBusinessKey(HttpContext).ToString(), UHID, ipNumber));
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

                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("ClinicalVitals/InsertIntoClinicalInformation", obj);
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
        public async Task<JsonResult> GetInformationValueView(int UHID, int ipNumber, string clType)
        {
            try
            {
                var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
                parameter += "&UHID=" + UHID.ToString();
                parameter += "&ipNumber=" + ipNumber.ToString();
                parameter += "&clType=" + clType.ToString();

                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_ClinicalInformation>>("ClinicalVitals/GetInformationValueView" + parameter);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), string.Format("UD:GetClinicalInformationValueView:params: businessKey:{0},UHID:{1},ipNumber:{2}",
                        AppSessionVariables.GetSessionBusinessKey(HttpContext).ToString(), UHID, ipNumber));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, string.Format("UD:GetClinicalInformationValueView:params: businessKey:{0},UHID:{1},ipNumber:{2}",
                        AppSessionVariables.GetSessionBusinessKey(HttpContext).ToString(), UHID, ipNumber));
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

                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("ClinicalVitals/InsertPatientClinicalInformation", obj);
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

                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("PreOperative/UpdatePatientClinicalInformation", obj);
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
        public async Task<JsonResult> GetClinicalInformationValueByTransaction(long UHID, long ipNumber, int transactionID)
        {
            try
            {
                var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
                parameter += "&UHID=" + UHID.ToString();
                parameter += "&ipNumber=" + ipNumber.ToString();
                parameter += "&transactionID=" + transactionID.ToString();

                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_ClinicalInformation>>("ClinicalVitals/GetClinicalInformationValueByTransaction" + parameter);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), string.Format("UD:GetClinicalInformationValueByTransaction:params: businessKey:{0},UHID:{1},ipNumber:{2},transactionID:{3}",
                        AppSessionVariables.GetSessionBusinessKey(HttpContext).ToString(), UHID, ipNumber, transactionID));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, string.Format("UD:GetClinicalInformationValueByTransaction:params: businessKey:{0},UHID:{1},ipNumber:{2},transactionID:{3}",
                        AppSessionVariables.GetSessionBusinessKey(HttpContext).ToString(), UHID, ipNumber, transactionID));
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

                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("ClinicalVitals/DeletePatientClinicalInformation", obj);
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