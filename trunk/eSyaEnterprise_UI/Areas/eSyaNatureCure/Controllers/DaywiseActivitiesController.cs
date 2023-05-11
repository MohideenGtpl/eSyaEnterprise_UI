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
    public class DaywiseActivitiesController : Controller
    {
        private readonly IeSyaNatureCureAPIServices _eSyaNatureCureAPIServices;
        private readonly ILogger<DaywiseActivitiesController> _logger;

        public DaywiseActivitiesController(IeSyaNatureCureAPIServices eSyaNatureCureAPIServices, ILogger<DaywiseActivitiesController> logger)
        {
            _eSyaNatureCureAPIServices = eSyaNatureCureAPIServices;
            _logger = logger;
        }
        #region Day wise Activities
        /// <summary>
        /// Day wise Activities
        /// </summary>
        /// <returns></returns>

        [Area("eSyaNatureCure")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> V_ENC_17_00()
        {
            try
            {

                var packageResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_PackageMaster>>("PackageMaster/GetActivePackageMasters");

                var activityResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_Activities>>("Activities/GetActiveActivities");

                if (packageResponse.Status && activityResponse.Status)
                {
                    ViewBag.package = packageResponse.Data;
                    ViewBag.activity = activityResponse.Data;
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
        ///Get Day wise Activities by Package Id for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetAllDaywiseActivitiesbyPackageId(int packageId)
        {

            try
            {
                var parameter = "?packageId=" + packageId;
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_DaywiseActivities>>("DaywiseActivities/GetAllDaywiseActivitiesbyPackageId" + parameter);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetAllDaywiseActivitiesbyPackageId");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetAllDaywiseActivitiesbyPackageId");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }

        }

        /// <summary>
        /// Insert or Update Day wise Activities
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateDaywiseActivities(bool isInsert, DO_DaywiseActivities obj)
        {

            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                if (isInsert)
                {
                    var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("DaywiseActivities/InsertDaywiseActivities", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
                else
                {
                    var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("DaywiseActivities/UpdateDaywiseActivities", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateDaywiseActivities:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Activate or De Activate Day wise Activities
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> ActiveOrDeActiveDayWiseActivities(DO_DaywiseActivities objday)
        {

            try
            {

                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("DaywiseActivities/ActiveOrDeActiveDayWiseActivities", objday);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ActiveOrDeActiveDayWiseActivities:params:" + JsonConvert.SerializeObject(objday));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        #endregion Day wise Activities
    }
}