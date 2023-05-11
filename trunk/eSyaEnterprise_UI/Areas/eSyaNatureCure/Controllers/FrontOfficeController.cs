using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eSyaEnterprise_UI.Areas.eSyaNatureCure.Data;
using eSyaEnterprise_UI.Areas.eSyaNatureCure.Models;
using eSyaEnterprise_UI.Models;
using eSyaEnterprise_UI.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text;
using System.Text.RegularExpressions;
using eSyaEnterprise_UI.ActionFilter;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;


namespace eSyaEnterprise_UI.Areas.eSyaNatureCure.Controllers
{
    [SessionTimeout]
    public class FrontOfficeController : Controller
    {
        private readonly IeSyaNatureCureAPIServices _eSyaNatureCureAPIServices;
        private readonly ILogger<FrontOfficeController> _logger;

        public FrontOfficeController(IeSyaNatureCureAPIServices eSyaNatureCureAPIServices, ILogger<FrontOfficeController> logger)
        {
            _eSyaNatureCureAPIServices = eSyaNatureCureAPIServices;
            _logger = logger;
        }



        /// <summary>
        /// Index Dashboard 
        /// </summary>
        /// <returns></returns>
        [Area("eSyaNatureCure")]
        public async Task<IActionResult> V_ENC_01_00()
        {
            ViewBag.BusinessKey = AppSessionVariables.GetSessionBusinessKey(HttpContext);
            ViewBag.UserId = AppSessionVariables.GetSessionUserID(HttpContext);
            var roomtypeResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_RoomType>>("RoomType/GetActiveRoomTypes");
            if (roomtypeResponse.Status)
            {
                ViewBag.roomtypes = roomtypeResponse.Data;
            }
            return View();
        }

        /// <summary>
        /// Today Dashboard 
        /// </summary>
        /// <returns></returns>
        [Area("eSyaNatureCure")]
        public IActionResult V_ENC_02_00()
        {
            return View();
        }

        
        /// <summary>
        ///Get Today Dashboard
        /// </summary>
        [HttpGet]
        public async Task<JsonResult> GetTodayDashboard()
        {

            try
            {
                var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<DO_FrontOffice>("FrontOffice/GetTodayDashboard" + parameter);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetTodayDashboard");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetTodayDashboard");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }

        }


        /// <summary>
        ///Get Dashboard By Date
        /// </summary>
        [HttpGet]
        public async Task<JsonResult> GetDashboardByDate(DateTime fromDate, DateTime toDate)
        {

            try
            {
                var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
                parameter += "&fromDate=" + fromDate.ToString("dd-MMM-yyyy");
                parameter += "&toDate=" + toDate.ToString("dd-MMM-yyyy");
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_BookinDetails>>("FrontOffice/GetDashboardByDate" + parameter);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetDashboardByDate");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetDashboardByDate");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }

        }

        [HttpGet]
        public async Task<JsonResult> GetActiveRoomBedMaster(DateTime fromDate, DateTime toDate)
        {

            try
            {
                var parameter = "?fromDate=" + fromDate.ToString("dd-MMM-yyyy");
                parameter += "&toDate=" + toDate.ToString("dd-MMM-yyyy");
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_BedMaster>>("FrontOffice/GetActiveRoomBedMaster" + parameter);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetActiveRoomBedMaster");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetActiveRoomBedMaster");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }

        }

        #region GuestReScheduling 
        public async Task<JsonResult> GetGuestReschedulingByBookingKey(long bookingKey)
        {
            try
            {
                var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
                parameter += "&bookingKey=" + bookingKey;
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_Rescheduling>>("GuestCheckIn/GetGuestReschedulingByBookingKey" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetGuestReschedulingByBookingKey:params:bookingKey:{0}:guestId{1}", bookingKey);
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetGuestReschedulingByBookingKey:params:bookingKey:{0}:guestId{1}", bookingKey);
                throw ex;
            }
        }
        [HttpPost]
        public async Task<JsonResult> InsertGuestRescheduling(DO_Rescheduling obj)
        {
            try
            {
                obj.BusinessKey = AppSessionVariables.GetSessionBusinessKey(HttpContext);
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("GuestCheckIn/InsertGuestRescheduling", obj);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertGuestRescheduling:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Warning = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
            }
        }
        #endregion

        #region Guest Room Change
        [HttpGet]
        public async Task<JsonResult> GetActiveRoomNumbersbyRoomType(int roomtype)
        {
            try
            {
                var parameter = "?roomtype=" + roomtype;
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_BedMaster>>("RoomReservation/GetActiveRoomNumbersbyRoomType" + parameter);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetActiveRoomNumbersbyRoomType:For roomtype", roomtype);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetActiveRoomNumbersbyRoomType:For roomtype ", roomtype);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetActiveRoomNumbersbyRoomType:For roomtype ", roomtype);
                throw ex;
            }
        }
        [HttpGet]
        public async Task<JsonResult> GetActiveBedNumbersbyRoomNumber(int roomtype, string roomnumber)
        {
            try
            {
                var parameter = "?roomtype=" + roomtype + "&roomnumber=" + roomnumber;
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_BedMaster>>("RoomReservation/GetActiveBedNumbersbyRoomNumber" + parameter);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetActiveBedNumbersbyRoomNumber:For roomtype {0} with roomnumber entered {1}", roomtype, roomnumber);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetActiveBedNumbersbyRoomNumber:For roomtype {0} with roomnumber entered {1}", roomtype, roomnumber);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetActiveBedNumbersbyRoomNumber:For roomtype {0} with roomnumber entered {1}", roomtype, roomnumber);
                throw ex;
            }
        }

        public async Task<JsonResult> GetGuestRoomchangeByBookingKey(long bookingKey, int guestId)
        {
            try
            {
                var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
                parameter += "&bookingKey=" + bookingKey;
                parameter += "&guestId=" + guestId;
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_RoomChange>>("GuestCheckIn/GetGuestRoomchangeByBookingKey" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetGuestRoomchangeByBookingKey:params:bookingKey:{0}:guestId{1}", bookingKey);
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetGuestRoomchangeByBookingKey:params:bookingKey:{0}:guestId{1}", bookingKey);
                throw ex;
            }
        }
        [HttpPost]
        public async Task<JsonResult> InsertGuestRoomchange(DO_RoomChange obj)
        {
            try
            {
                obj.BusinessKey = AppSessionVariables.GetSessionBusinessKey(HttpContext);
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("GuestCheckIn/InsertGuestRoomchange", obj);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertGuestRoomchange:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Warning = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
            }
        }
        #endregion

        #region Guest Booking Cancellation Process
        [HttpPost]
        public async Task<JsonResult> GuestBookingCancellationProcess(DO_GuestCheckInDetails obj)
        {
            try
            {
                obj.BusinessKey = AppSessionVariables.GetSessionBusinessKey(HttpContext);
                obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("GuestCheckOut/GuestBookingCancellationProcess", obj);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data.Status)
                        return Json(new { Status = true, serviceResponse.Data.Warning, serviceResponse.Data.WarningMessage });
                    else
                        return Json(new { Status = false, serviceResponse.Data.Warning, serviceResponse.Data.WarningMessage, serviceResponse.Data.Message });
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GuestCheckOutProcess:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GuestCheckOutProcess:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Warning = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
            }
        }
        #endregion
    }
}