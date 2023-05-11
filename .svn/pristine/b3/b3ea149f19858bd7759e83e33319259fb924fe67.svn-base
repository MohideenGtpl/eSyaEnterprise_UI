using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using eSyaEnterprise_UI.ActionFilter;
using eSyaEnterprise_UI.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using eSyaEnterprise_UI.Areas.eSyaNatureCure.Data;
using eSyaEnterprise_UI.Models;
using eSyaEnterprise_UI.Areas.eSyaNatureCure.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace eSyaEnterprise_UI.Areas.eSyaNatureCure.Controllers
{
    [SessionTimeout]
    public class PackageAmenitiesController : Controller
    {
        private readonly IeSyaNatureCureAPIServices _eSyaNatureCureAPIServices;
        private readonly ILogger<PackageAmenitiesController> _logger;
        private readonly IHostingEnvironment _appEnvironment;

        public PackageAmenitiesController(IeSyaNatureCureAPIServices eSyaNatureCureAPIServices, ILogger<PackageAmenitiesController> logger, IHostingEnvironment hostingEnvironment)
        {
            _eSyaNatureCureAPIServices = eSyaNatureCureAPIServices;
            _logger = logger;
            _appEnvironment = hostingEnvironment;
        }
        #region Package Amenities
        /// <summary>
        /// Package Amenities
        /// </summary>
        /// <returns></returns>

        [Area("eSyaNatureCure")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> V_ENC_18_00()
        {

            try
            {
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_PackageMaster>>("PackageMaster/GetActivePackageMasters");
                if (serviceResponse.Status)
                {
                    ViewBag.Packages = serviceResponse.Data;
                    return View();

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetActivePackageMasters");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetActivePackageMasters");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }


        }
        /// <summary>
        ///Get Package Amenities by PackageId for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetAllPackageAmenitiesbyPackageId(int packageId)
        {

            try
            {
                var parameter = "?packageId=" + packageId;
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_PackageAmenities>>("PackageAmenities/GetAllPackageAmenitiesbyPackageId" + parameter);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetAllPackageAmenitiesbyPackageId");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetAllPackageAmenitiesbyPackageId");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }

        }

      
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdatePackageAmenities(DO_PackageAmenities obj)
        {

            try
            {
                if (obj.Imagefile == null && obj.OptionValues == null)
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please select Image or Enter Option Values" });
                }
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);

                if (obj.Imagefile != null && (obj.Imagefile.Length > 0))
                {
                    var file = obj.Imagefile;

                    var uploads = Path.Combine(_appEnvironment.WebRootPath, "Uploads/PackageAmenities");
                    if (file.Length > 0)
                    {

                        var fileName = Path.GetFileName(file.FileName);
                        using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                        {
                            await file.CopyToAsync(fileStream);
                            //string filePath = "Uploads/PackageAmenities/" + fileName;
                            //for server path
                            string filePath = "/Uploads/PackageAmenities/" + fileName;
                            obj.ProfileImagePath = filePath;
                        }

                    }
                    if (obj.isInsert)
                    {
                        obj.OptionValues = obj.ProfileImagePath;
                        var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("PackageAmenities/InsertPackageAmenities", obj);
                        if (serviceResponse.Status)
                            return Json(serviceResponse.Data);
                        else
                            return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                    }
                    else
                    {
                        obj.OptionValues = obj.ProfileImagePath;
                        var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("PackageAmenities/UpdatePackageAmenities", obj);
                        if (serviceResponse.Status)
                            return Json(serviceResponse.Data);
                        else
                            return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                    }
                }

                else
                {
                    if (obj.isInsert)
                    {
                        var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("PackageAmenities/InsertPackageAmenities", obj);
                        if (serviceResponse.Status)
                            return Json(serviceResponse.Data);
                        else
                            return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                    }
                    else
                    {
                        var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("PackageAmenities/UpdatePackageAmenities", obj);
                        if (serviceResponse.Status)
                            return Json(serviceResponse.Data);
                        else
                            return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                    }
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdatePackageAmenities:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Activate or De Activate Room Amenities
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> ActiveOrDeActivePackageAmenities(DO_PackageAmenities objamenities)
        {

            try
            {

                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("PackageAmenities/ActiveOrDeActivePackageAmenities", objamenities);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ActiveOrDeActivePackageAmenities:params:" + JsonConvert.SerializeObject(objamenities));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        [HttpGet]
        public async Task<JsonResult> GetPackageAmenitiesbyOptiontype(int packageId, string optionType, int serilalNo)
        {
            try
            {
                var parameter = "?packageId=" + packageId + "&optionType=" + optionType + "&serilalNo=" + serilalNo;
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<DO_PackageAmenities>("PackageAmenities/GetPackageAmenitiesbyOptiontype" + parameter);
                if (serviceResponse.Status)
                {
                    var domainname = this.Request.PathBase;
                    if (serviceResponse.Data != null)
                    {
                        if (serviceResponse.Data.OptionValues.Contains("PackageAmenities"))
                        {
                            serviceResponse.Data.ProfileImagePath = serviceResponse.Data.OptionValues;
                        }

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
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetPackageAmenitiesbyOptiontype");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetPackageAmenitiesbyOptiontype");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        #endregion Package Amenities
    }
}