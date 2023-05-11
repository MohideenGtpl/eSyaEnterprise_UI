using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eSyaEnterprise_UI.ActionFilter;
using eSyaEnterprise_UI.Areas.ConfigureWardRoom.Data;
using eSyaEnterprise_UI.Areas.ConfigureWardRoom.Models;
using eSyaEnterprise_UI.Models;
using eSyaEnterprise_UI.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace eSyaEnterprise_UI.Areas.ConfigureWardRoom.Controllers
{
    [SessionTimeout]
    public class WardMasterController : Controller
    {
        private readonly IConfigureWardRoomAPIServices _ConfigureWardRoomAPIServices;
        private readonly ILogger<WardMasterController> _logger;
        public WardMasterController(IConfigureWardRoomAPIServices ConfigureWardRoomAPIServices, ILogger<WardMasterController> logger)
        {
            _ConfigureWardRoomAPIServices = ConfigureWardRoomAPIServices;
            _logger = logger;
        }

        #region wards Master
        /// <summary>
        /// Define wards
        /// </summary>
        /// <returns></returns>
        [Area("ConfigureWardRoom")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult EWR_01()
        {
            return View();
        }

        /// <summary>
        ///Get All Wards for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetAllWards()
        {

            try
            {
                var serviceResponse = await _ConfigureWardRoomAPIServices.HttpClientServices.GetAsync<List<DO_WardMaster>>("WardMaster/GetAllWards");
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetAllWards");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetAllWards");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }

        }

        /// <summary>
        /// Insert or Update Wards
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateWardMaster(bool isInsert, DO_WardMaster obj)
        {

            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                if (isInsert)
                {
                    var serviceResponse = await _ConfigureWardRoomAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("WardMaster/InsertIntoWardMaster", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
                else
                {
                    var serviceResponse = await _ConfigureWardRoomAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("WardMaster/UpdateWardMaster", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateWardMaster:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Activate or De Activate Wards
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> ActiveOrDeActiveWardMaster(bool status, int wardId)
        {

            try
            {

                var parameter = "?status=" + status + "&wardId=" + wardId;
                var serviceResponse = await _ConfigureWardRoomAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("WardMaster/ActiveOrDeActiveWardMaster" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ActiveOrDeActiveWardMaster:For wardId {0} ", wardId);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        #endregion
    }
}