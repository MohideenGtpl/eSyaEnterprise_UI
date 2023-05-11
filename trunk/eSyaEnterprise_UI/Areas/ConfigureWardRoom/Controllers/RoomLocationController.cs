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
    public class RoomLocationController : Controller
    {
        private readonly IConfigureWardRoomAPIServices _ConfigureWardRoomAPIServices;
        private readonly ILogger<RoomLocationController> _logger;
        public RoomLocationController(IConfigureWardRoomAPIServices ConfigureWardRoomAPIServices, ILogger<RoomLocationController> logger)
        {
            _ConfigureWardRoomAPIServices = ConfigureWardRoomAPIServices;
            _logger = logger;
        }

        #region Room Master
        /// <summary>
        /// Room locations
        /// </summary>
        /// <returns></returns>

        [Area("ConfigureWardRoom")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> EWR_03()
        {
            try
            {
                var serviceResponse = await _ConfigureWardRoomAPIServices.HttpClientServices.GetAsync<List<DO_RoomLocation>>("RoomLocation/GetActiveStores");
                if (serviceResponse.Status)
                {
                    ViewBag.Stores = serviceResponse.Data.Select(b => new SelectListItem
                    {
                        Value = b.StoreCode.ToString(),
                        Text = b.StoreDesc,
                    }).ToList();

                    return View();
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetActiveStores");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetActiveStores");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        ///Get All Room Location by Business Key for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetRoomLocationbyBusinessKey(int businessKey)
        {

            try
            {
                var serviceResponse = await _ConfigureWardRoomAPIServices.HttpClientServices.GetAsync<List<DO_RoomLocation>>("RoomLocation/GetRoomLocationbyBusinessKey?businessKey=" + businessKey);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetRoomLocationbyBusinessKey");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetRoomLocationbyBusinessKey");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }

        }

        /// <summary>
        /// Insert or Update Room Location
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateRoomLocation(bool isInsert, DO_RoomLocation obj)
        {

            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                if (isInsert)
                {
                    var serviceResponse = await _ConfigureWardRoomAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("RoomLocation/InsertIntoRoomLocation", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
                else
                {
                    var serviceResponse = await _ConfigureWardRoomAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("RoomLocation/UpdateRoomLocation", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateRoomLocation:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Activate or De Activate Room Location
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> ActiveOrDeActiveRoomLocation(bool status, int businessKey, int locationId)
        {

            try
            {

                var parameter = "?status=" + status + "&businessKey=" + businessKey + "&locationId=" + locationId;
                var serviceResponse = await _ConfigureWardRoomAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("RoomLocation/ActiveOrDeActiveRoomLocation" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ActiveOrDeActiveRoomLocation:For locationId {0} ", locationId);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        #endregion
    }
}