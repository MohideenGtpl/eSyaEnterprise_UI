using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using eSyaEnterprise_UI.ActionFilter;
using eSyaEnterprise_UI.Areas.eSyaNursingStation.Data;
using eSyaEnterprise_UI.Areas.eSyaNursingStation.Models;
using eSyaEnterprise_UI.Utility;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace eSyaEnterprise_UI.Areas.eSyaNursingStation.Controllers
{
    public class PatientConsentRecordingController : Controller
    {
        private readonly IeSyaNursingStationAPIServices _eSyaNursingStationAPIServices;
        private readonly ILogger<PatientConsentRecordingController> _logger;

        private readonly IHostingEnvironment _hostingEnvironment;

        public PatientConsentRecordingController(IeSyaNursingStationAPIServices eSyaNursingStationAPIServices, ILogger<PatientConsentRecordingController> logger, IHostingEnvironment hostingEnvironment)
        {
            _eSyaNursingStationAPIServices = eSyaNursingStationAPIServices;
            _logger = logger;
            _hostingEnvironment = hostingEnvironment;
        }

        [Area("eSyaNursingStation")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult V_6001_00()
        {
            return View();
        }

        [Area("eSyaNursingStation")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> V_6001_CV(int UHID, int ipNumber)
        {
            var serviceResponse = _eSyaNursingStationAPIServices.HttpClientServices.GetAsync<List<DO_ApplicationCodes>>("CommonData/GetApplicationCodesByCodeType?codeType=" + CodeTypeValues.PatientConsentRecordingType).Result;
            if (serviceResponse.Data != null)
            {
                ViewBag.ConsentTypeList = serviceResponse.Data.Select(a => new SelectListItem
                {
                    Text = a.CodeDesc,
                    Value = a.ApplicationCode.ToString()
                });
            }
            else
            {
                _logger.LogError(new Exception(serviceResponse.Message), "UD:GetApplicationCodesByCodeType");
            }

            List<DO_PatientConsentRecording> videolist = await GetPatientConsentVideo(UHID, ipNumber);
            ViewBag.UHID = UHID;
            ViewBag.IPNumber = ipNumber;

            return View(videolist);
        }

        public async Task<List<DO_PatientConsentRecording>> GetPatientConsentVideo(int UHID, int ipNumber)
        {
            try
            {
                var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
                parameter += "&UHID=" + UHID.ToString();
                parameter += "&ipNumber=" + ipNumber.ToString();
                var serviceResponse = await _eSyaNursingStationAPIServices.HttpClientServices.GetAsync<List<DO_PatientConsentRecording>>("PatientConsentRecording/GePatientConsentRecording" + parameter);
                if (serviceResponse.Status)
                {
                    return serviceResponse.Data;
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), string.Format("UD:GetPatientConsentVideo"));
                    return new List<DO_PatientConsentRecording>();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, string.Format("UD:GetPatientConsentVideo"));
                return new List<DO_PatientConsentRecording>();
            }
        }

        [HttpPost]
        public async Task<IActionResult> UploadVideoDocument(DO_PatientConsentRecording obj, List<IFormFile> files)
        {
            long size = files.Sum(f => f.Length);
            var pathString = "";
            var filePaths = new List<string>();
            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    // full path to file in temp location
                    var filePath1 = Path.GetTempFileName(); //we are using Temp file name just for the example. Add your own file path.
                    filePaths.Add(System.DateTime.Now.ToString("ddmmyyyyhhmiss"));

                    string fileRootPath = _hostingEnvironment.WebRootPath;

                  //  fileRootPath = @"http:\\103.227.97.123\eSyaProfileImage";

                    var dir_path = @"UHID_" + obj.UHID.ToString() + @"\IP_" + obj.IPNumber.ToString();
                    var destinationDirectory = new DirectoryInfo(Path.Combine(fileRootPath, "PatientConsentRecording", dir_path));
                    if (!destinationDirectory.Exists)
                        destinationDirectory.Create();

                    //var basePath = Path.Combine(fileRootPath, "PatientConsentRecording", dir_path);
                    //bool basePathExists = System.IO.Directory.Exists(basePath);
                    //if (!basePathExists) Directory.CreateDirectory(basePath);

                    pathString = dir_path + @"\" + System.DateTime.Now.ToString("ddmmyyyyhhmmss");
                    var index_point = formFile.FileName.IndexOf(".");
                    pathString += formFile.FileName.Substring(index_point);

                    var filePath = Path.Combine(fileRootPath, "PatientConsentRecording", pathString);
                    //    System.IO.File.Delete(filePath);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await formFile.CopyToAsync(stream);
                    }

                    long fileSize = formFile.Length;
                    long Size = fileSize / 1000;

                    obj.BusinessKey = AppSessionVariables.GetSessionBusinessKey(HttpContext);
                    obj.FileName = formFile.FileName;
                    obj.FilePath = pathString;
                    obj.FileSize = Convert.ToInt32(Size);
                    obj.ActiveStatus = true;
                    obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                    obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                    obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);

                    var serviceResponse = await _eSyaNursingStationAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("PatientConsentRecording/InsertIntoPatientConsentRecording", obj);
                    if (serviceResponse.Status)
                    {

                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:UploadVideoDocument:params:" + JsonConvert.SerializeObject(obj));
                    }
                }
            }
            return RedirectToAction("V_6001_CV", "PatientConsentRecording", new { area = "eSyaNursingStation", UHID = obj.UHID, ipNumber = obj.IPNumber });
        }

        [HttpPost]
        public async Task<IActionResult> UploadVideoDocument_1(DO_PatientConsentRecording obj,List<IFormFile> files)
        {
            long size = files.Sum(f => f.Length);
            var pathString = "";
            var filePaths = new List<string>();
            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    // full path to file in temp location
                    var filePath1 = Path.GetTempFileName(); //we are using Temp file name just for the example. Add your own file path.
                    filePaths.Add(System.DateTime.Now.ToString("ddmmyyyyhhmiss"));

                    string fileRootPath = _hostingEnvironment.WebRootPath;

                    fileRootPath = "http://103.227.97.123/eSyaProfileImage";

                    var dir_path = @"UHID_"+obj.UHID.ToString()+@"\IP_"+obj.IPNumber.ToString();
                    var destinationDirectory = new DirectoryInfo(Path.Combine(fileRootPath, "PatientConsentRecording", dir_path));
                    if (!destinationDirectory.Exists)
                        destinationDirectory.Create();

                    pathString = dir_path + @"\" + System.DateTime.Now.ToString("ddmmyyyyhhmmss");
                    var index_point = formFile.FileName.IndexOf(".");
                    pathString += formFile.FileName.Substring(index_point);

                    var  filePath = Path.Combine(fileRootPath, "PatientConsentRecording", pathString);
                    //    System.IO.File.Delete(filePath);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await formFile.CopyToAsync(stream);
                    }

                    long fileSize = formFile.Length;
                    long Size = fileSize / 1000;

                    obj.BusinessKey = AppSessionVariables.GetSessionBusinessKey(HttpContext);
                    obj.FileName = formFile.FileName;
                    obj.FilePath = pathString;
                    obj.FileSize = Convert.ToInt32(Size);
                    obj.ActiveStatus = true;
                    obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                    obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                    obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);

                    var serviceResponse = await _eSyaNursingStationAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("PatientConsentRecording/InsertIntoPatientConsentRecording", obj);
                    if (serviceResponse.Status)
                    {
                       
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:UploadVideoDocument:params:" + JsonConvert.SerializeObject(obj));
                    }
                }
            }
            return RedirectToAction("V_6001_CV", "PatientConsentRecording", new { area = "eSyaNursingStation", UHID = obj.UHID, ipNumber = obj.IPNumber }); 
        }

        [HttpPost]
        public async Task<JsonResult> DeletePatientConsentRecording(DO_PatientConsentRecording obj)
        {
            try
            {
                obj.BusinessKey = AppSessionVariables.GetSessionBusinessKey(HttpContext);
                obj.ActiveStatus = true;
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);

                var serviceResponse = await _eSyaNursingStationAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("PatientConsentRecording/DeletePatientConsentRecording", obj);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data.Status)
                        return Json(new { Status = true, serviceResponse.Data.Message });
                    else
                        return Json(new { Status = false, serviceResponse.Data.Message });
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:DeletePatientConsentRecording:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:DeletePatientConsentRecording:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Warning = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
            }
        }
    }

    public class VideoFiles
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> FileSize { get; set; }
        public string FilePath { get; set; }
    }
}