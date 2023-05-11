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
    public class RoomMasterController : Controller
    {
        private readonly IConfigureWardRoomAPIServices _ConfigureWardRoomAPIServices;
        private readonly ILogger<RoomMasterController> _logger;
        public RoomMasterController(IConfigureWardRoomAPIServices ConfigureWardRoomAPIServices, ILogger<RoomMasterController> logger)
        {
            _ConfigureWardRoomAPIServices = ConfigureWardRoomAPIServices;
            _logger = logger;
        }

        #region Room Master
        /// <summary>
        /// Define Room
        /// </summary>
        /// <returns></returns>
        [Area("ConfigureWardRoom")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult EWR_02()
        {
            return View();
        }

        /// <summary>
        ///Get All Wards for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetAllRooms()
        {

            try
            {
                var serviceResponse = await _ConfigureWardRoomAPIServices.HttpClientServices.GetAsync<List<DO_RoomMaster>>("RoomMaster/GetAllRooms");
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetAllRooms");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetAllRooms");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }

        }

        /// <summary>
        /// Insert or Update Wards
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateRoomMaster(bool isInsert, DO_RoomMaster obj)
        {

            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                if (isInsert)
                {
                    var serviceResponse = await _ConfigureWardRoomAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("RoomMaster/InsertIntoRoomMaster", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
                else
                {
                    var serviceResponse = await _ConfigureWardRoomAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("RoomMaster/UpdateRoomMaster", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateRoomMaster:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Activate or De Activate Wards
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> ActiveOrDeActiveRoomMaster(bool status, int roomId)
        {

            try
            {

                var parameter = "?status=" + status + "&roomId=" + roomId;
                var serviceResponse = await _ConfigureWardRoomAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("RoomMaster/ActiveOrDeActiveRoomMaster" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ActiveOrDeActiveRoomMaster:For roomId {0} ", roomId);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        #endregion
    }
}