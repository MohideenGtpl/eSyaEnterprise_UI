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
    public class WardRoomController : Controller
    {
        private readonly IConfigureWardRoomAPIServices _ConfigureWardRoomAPIServices;
        private readonly ILogger<WardRoomController> _logger;
        public WardRoomController(IConfigureWardRoomAPIServices ConfigureWardRoomAPIServices, ILogger<WardRoomController> logger)
        {
            _ConfigureWardRoomAPIServices = ConfigureWardRoomAPIServices;
            _logger = logger;
        }
        #region Map Wards & Room
        /// <summary>
        /// Map Wards & Room
        /// </summary>
        /// <returns></returns>

        [Area("ConfigureWardRoom")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> EWR_04()
        {
            try
            {
                var _roomserviceresp= await _ConfigureWardRoomAPIServices.HttpClientServices.GetAsync<List<DO_RoomMaster>>("WardRoom/GetActiveRooms");
                var _wardserviceresp = await _ConfigureWardRoomAPIServices.HttpClientServices.GetAsync<List<DO_WardMaster>>("WardRoom/GetActiveWards");
                var _locserviceresp = await _ConfigureWardRoomAPIServices.HttpClientServices.GetAsync<List<DO_RoomLocation>>("WardRoom/GetActiveLocations");

                if (_roomserviceresp.Status && _wardserviceresp.Status && _locserviceresp.Status)
                {
                    ViewBag.Rooms = _roomserviceresp.Data.Select(b => new SelectListItem
                    {
                        Value = b.RoomId.ToString(),
                        Text = b.RoomDesc,
                    }).ToList();
                    ViewBag.Wards = _wardserviceresp.Data.Select(b => new SelectListItem
                    {
                        Value = b.WardId.ToString(),
                        Text = b.WardDesc,
                    }).ToList();
                    ViewBag.Locations = _locserviceresp.Data.Select(b => new SelectListItem
                    {
                        Value = b.LocationId.ToString(),
                        Text = b.LocationDesc,
                    }).ToList();
                    return View();
                }
                else
                {
                    _logger.LogError(new Exception(_roomserviceresp.Message), "UD:GetActiveRooms");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetActiveRooms");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        ///Get All Ward Room Location Link for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetLoadGridWardRoomLinksbyBusinessKey(int businesskey)
        {

            try
            {
                var serviceResponse = await _ConfigureWardRoomAPIServices.HttpClientServices.GetAsync<List<DO_WardRoomLink>>("WardRoom/GetLoadGridWardRoomLinksbyBusinessKey?businesskey=" + businesskey);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetLoadGridWardRoomLinksbyBusinessKey");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetLoadGridWardRoomLinksbyBusinessKey");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }

        }


        /// <summary>
        ///Get  Ward Room Location Link for Edit
        /// </summary>
        [HttpGet]
        public async Task<JsonResult> GetWardRoomLink(int businesskey, int roomId, int wardId, int locationId)
        {

            try
            {
                var parameter = "?businesskey=" + businesskey + "&roomId=" + roomId + "&wardId=" + wardId + "&locationId=" + locationId;

                var serviceResponse = await _ConfigureWardRoomAPIServices.HttpClientServices.GetAsync<DO_WardRoomLink>("WardRoom/GetWardRoomLink" + parameter);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetWardRoomLink");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetWardRoomLink");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }

        }
        /// <summary>
        /// Insert or Update Ward Room Location Link
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> AddOrUpdatetWardRoomLink( DO_WardRoomLink obj)
        {

            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                
                    var serviceResponse = await _ConfigureWardRoomAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("WardRoom/AddOrUpdatetWardRoomLink", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:AddOrUpdatetWardRoomLink:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        // <summary>
        // Activate or De Activate Ward Room Location Link
        // </summary>
        [HttpPost]
        public async Task<JsonResult> ActiveOrDeActiveWardRoomLink(DO_WardRoomLink obj)
        {

            try
            {

                var serviceResponse = await _ConfigureWardRoomAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("WardRoom/ActiveOrDeActiveWardRoomLink", obj);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ActiveOrDeActiveRoomLocation ", obj);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        #endregion
    }
}