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

namespace eSyaEnterprise_UI.Areas.eSyaNatureCure.Controllers
{
    [SessionTimeout]
    public class PackagePriceController : Controller
    {
        private readonly IeSyaNatureCureAPIServices _eSyaNatureCureAPIServices;
        private readonly ILogger<PackagePriceController> _logger;

        public PackagePriceController(IeSyaNatureCureAPIServices eSyaNatureCureAPIServices, ILogger<PackagePriceController> logger)
        {
            _eSyaNatureCureAPIServices = eSyaNatureCureAPIServices;
            _logger = logger;
        }
        #region Package Price
        /// <summary>
        /// Package Price
        /// </summary>
        /// <returns></returns>

        [Area("eSyaNatureCure")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> V_ENC_14_00()
        {

            try
            {

                var packageResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_PackageMaster>>("PackageMaster/GetActivePackageMasters");

                var roomtypeResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_RoomType>>("RoomType/GetActiveRoomTypes");

                if (packageResponse.Status && roomtypeResponse.Status)
                {
                    ViewBag.package = packageResponse.Data;
                    ViewBag.roomtypes = roomtypeResponse.Data;
                    return View();

                }
                else
                {
                    _logger.LogError(new Exception(packageResponse.Message), "UD:GetActivePackageMasters");
                    _logger.LogError(new Exception(packageResponse.Message), "UD:GetActiveActivities");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {

                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }


        }

        /// <summary>
        ///Get Package Price by Package Id for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetAllPackagePricesbyPackageId(int packageId)
        {

            try
            {
                var parameter = "?packageId=" + packageId;
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_PackagePrice>>("PackagePrice/GetAllPackagePricesbyPackageId" + parameter);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetAllPackagePricesbyPackageId");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetAllPackagePricesbyPackageId");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }

        }

        /// <summary>
        /// Insert or Update Package Price
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdatePackagePrice(bool isInsert, DO_PackagePrice obj)
        {

            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                if (isInsert)
                {
                    var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("PackagePrice/InsertPackagePrice", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
                else
                {
                    var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("PackagePrice/UpdatePackagePrice", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdatePackagePrice:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Activate or De Activate PackagePrice
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> ActiveOrDeActivePackagePrice(DO_PackagePrice objprice)
        {

            try
            {

                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("PackagePrice/ActiveOrDeActivePackagePrice", objprice);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ActiveOrDeActivePackagePrice:params:" + JsonConvert.SerializeObject(objprice));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        #endregion Package Price
    }
}