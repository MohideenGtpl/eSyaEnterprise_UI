﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eSyaEnterprise_UI.Areas.eSyaNatureCure.Models;
using eSyaEnterprise_UI.Models;
using eSyaEnterprise_UI.Areas.eSyaNatureCure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using eSyaEnterprise_UI.Utility;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using eSyaEnterprise_UI.DataServices;
using eSyaEnterprise_UI.ActionFilter;

namespace eSyaEnterprise_UI.Areas.eSyaNatureCure.Controllers
{
    [SessionTimeout]
    public class CheckInGuestController : Controller
    {
        private readonly IeSyaNatureCureAPIServices _eSyaNatureCureAPIServices;
        private readonly ISmsServices _smsServices;
        private readonly ILogger<CheckInGuestController> _logger;
        private readonly IHostingEnvironment _appEnvironment;
        private readonly IRazorpayClientServices _razorpayClientServices;

        public CheckInGuestController(IeSyaNatureCureAPIServices eSyaNatureCureAPIServices, ISmsServices smsServices, ILogger<CheckInGuestController> logger, 
            IHostingEnvironment hostingEnvironment, IRazorpayClientServices razorpayClientServices)
        {
            _eSyaNatureCureAPIServices = eSyaNatureCureAPIServices;
            _smsServices = smsServices;
            _logger = logger;
            _appEnvironment = hostingEnvironment;
            _razorpayClientServices = razorpayClientServices;
        }

        [Area("eSyaNatureCure")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> V_ENC_04_00(long bookingKey, int guestId)
        {
            //ViewBag.UserFormRole = new DO_UserFormRole { IsInsert = true, IsEdit = true, IsView = true, IsDelete = true,IsAuthenticate=true };

            ViewBag.BookingKey = bookingKey;
            ViewBag.GuestId = guestId;

            var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
            parameter += "&bookingKey=" + bookingKey;
            parameter += "&guestId=" + guestId;
            var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<DO_GuestCheckInDetails>("GuestCheckIn/GetGuestDetailById" + parameter);
            var roomtypeResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_RoomType>>("RoomType/GetActiveRoomTypes");
            if (roomtypeResponse.Status)
            {
                ViewBag.roomtypes = roomtypeResponse.Data;
            }

            var domainname = this.Request.PathBase;
            if (serviceResponse.Data != null)
            {
                if (serviceResponse.Data.ImageUrl != null)
                {
                    string filename = null;
                    // using the method
                    filename = Path.GetFileName(serviceResponse.Data.ImageUrl);
                    serviceResponse.Data.FileName = filename;

                    serviceResponse.Data.ImageUrl = domainname + serviceResponse.Data.ImageUrl;


                }
            }

            return View(serviceResponse.Data);
        }

        public async Task<JsonResult> GetGuestDetailById(long bookingKey, int guestId)
        {
            try
            {
                var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
                parameter += "&bookingKey=" + bookingKey;
                parameter += "&guestId=" + guestId;
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<DO_GuestCheckInDetails>("GuestCheckIn/GetGuestDetailById" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetGuestDetails:params:bookingKey:{0}:guestId{1}", bookingKey, guestId);
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetGuestDetails:params:bookingKey:{0}:guestId{1}", bookingKey, guestId);
                throw ex;
            }
        }

        public async Task<JsonResult> GetCityList()
        {
            try
            {
                var parameter = "?isdCode=91";
                parameter += "&placeType=2";
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_CountryPlaces>>("CommonMaster/GetCountryPlaceList" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetCityList");
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetCityList");
                throw ex;
            }
        }

        public async Task<JsonResult> GetGuestDetailsByBookingKey(long bookingKey)
        {
            try
            {
                var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
                parameter += "&bookingKey=" + bookingKey;
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_GuestCheckInDetails>>("GuestCheckIn/GetGuestDetailsByBookingKey" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetGuestDetailsByBookingKey:params:bookingKey:{0}", bookingKey);
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetGuestDetails:params:GetGuestDetailsByBookingKey:{0}", bookingKey);
                throw ex;
            }
        }

        public async Task<IActionResult> GetPatientProfileByUHID(long uhid)
        {
            try
            {
                var parameter = "?uhid=" + uhid;
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<DO_PatientProfile>("PatientInfo/GetPatientProfileByUHID" + parameter);
                if (serviceResponse.Status)
                    return Ok(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetPatientProfileByUHID:params:uhid:{0}" + uhid.ToString());
                    return Ok(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetPatientProfileByUHID:params:uhid:{0}" + uhid.ToString());
                throw ex;
            }
        }

        [HttpPost]
        public async Task<JsonResult> CreateGuestCheckin(DO_GuestCheckInDetails obj)
        {
            try
            {
                if (obj.Imagefile != null && (obj.Imagefile.Length > 0))
                {
                    var file = obj.Imagefile;
                    //There is an error here
                    var uploads = Path.Combine(_appEnvironment.WebRootPath, "Uploads\\GuestImages");
                    if (file.Length > 0)
                    {
                        //var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(file.FileName);
                        var fileName = Path.GetFileName(file.FileName);
                        using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                        {
                            await file.CopyToAsync(fileStream);
                            string filePath = "\\Uploads\\GuestImages\\" + fileName;
                            obj.ImageUrl = filePath;
                        }

                    }
                }
                obj.BusinessKey = AppSessionVariables.GetSessionBusinessKey(HttpContext);
                obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("GuestCheckIn/CreateGuestCheckin", obj);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data.Status)
                    {
                        if (obj.CheckedOutDate > DateTime.Now)
                            SendSMSForGuestCheckIn(obj);
                        return Json(new { Status = true, serviceResponse.Data.Warning, serviceResponse.Data.WarningMessage });
                    }
                    else
                    {
                        //if (obj.CheckedOutDate > DateTime.Now)
                        //    SendSMSForGuestCheckIn(obj);
                        return Json(new { Status = false, serviceResponse.Data.Warning, serviceResponse.Data.WarningMessage, serviceResponse.Data.Message });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:CreateGuestCheckin:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:CreateGuestCheckin:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Warning = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
            }
        }



        [HttpPost]
        public async Task<JsonResult> UpdateGuestCheckin(DO_GuestCheckInDetails obj)
        {
            try
            {
                if (obj.Imagefile != null && (obj.Imagefile.Length > 0))
                {
                    var file = obj.Imagefile;
                    //There is an error here
                    var uploads = Path.Combine(_appEnvironment.WebRootPath, "Uploads\\GuestImages");
                    if (file.Length > 0)
                    {
                        //var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(file.FileName);
                        var fileName = Path.GetFileName(file.FileName);
                        using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                        {
                            await file.CopyToAsync(fileStream);
                            string filePath = "\\Uploads\\GuestImages\\" + fileName;
                            obj.ImageUrl = filePath;
                        }

                    }
                }
                obj.BusinessKey = AppSessionVariables.GetSessionBusinessKey(HttpContext);
                obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("GuestCheckIn/UpdateGuestCheckin", obj);

                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:UpdateGuestCheckin:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Warning = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
            }
        }

        public async Task<JsonResult> GetGuestPaymentReceiptDetails(long bookingKey)
        {
            try
            {
                var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
                parameter += "&bookingKey=" + bookingKey;
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_GuestPaymentReceiptDetails>>("GuestPayment/GetGuestPaymentReceiptDetails" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetGuestPaymentReceiptDetails:params:bookingKey:{0}", bookingKey);
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetGuestPaymentReceiptDetails:params:bookingKey:{0}", bookingKey);
                throw ex;
            }
        }

        [HttpPost]
        public async Task<JsonResult> InsertPatientReceipt(DO_GuestPaymentReceiptDetails obj)
        {
            try
            {
                obj.BusinessKey = AppSessionVariables.GetSessionBusinessKey(HttpContext);
                obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("GuestPayment/InsertPatientReceipt", obj);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data.Status)
                        return Json(new { Status = true, serviceResponse.Data.Warning, serviceResponse.Data.WarningMessage });
                    else
                        return Json(new { Status = false, serviceResponse.Data.Warning, serviceResponse.Data.WarningMessage, serviceResponse.Data.Message });
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertPatientReceipt:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertPatientReceipt:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Warning = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
            }
        }

        /// <summary>
        /// Insert or Update Document Upload
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateDocumentUpload(DO_GuestDocumentUpload obj)
        {

            try
            {
                if (obj.Imagefile != null && (obj.Imagefile.Length > 0))
                {
                    var file = obj.Imagefile;

                    var uploads = Path.Combine(_appEnvironment.WebRootPath, "Uploads\\DocumentUploads");
                    if (file.Length > 0)
                    {

                        var fileName = Path.GetFileName(file.FileName);
                        using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                        {
                            await file.CopyToAsync(fileStream);
                            string filePath = "\\Uploads\\DocumentUploads\\" + fileName;
                            obj.DocumentUrl = filePath;
                        }

                    }
                }

                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                obj.BusinessKey = AppSessionVariables.GetSessionBusinessKey(HttpContext);

                if (obj.isInsert)
                {
                    var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("GuestCheckIn/InsertGuestDocumentUpload", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
                else
                {
                    var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("GuestCheckIn/UpdateGuestDocumentUpload", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateDocumentUpload:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        [HttpGet]
        public async Task<JsonResult> GetGuestDocumentUploadDetailsByBookingKey(long bookingKey, int guestId)
        {

            try
            {
                int businessKey = AppSessionVariables.GetSessionBusinessKey(HttpContext);
                var parameter = "?businessKey=" + businessKey + "&bookingKey=" + bookingKey + "&guestId=" + guestId;

                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_GuestDocumentUpload>>("GuestCheckIn/GetGuestDocumentUploadDetailsByBookingKey" + parameter);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetGuestDocumentUploadDetailsByBookingKey");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetGuestDocumentUploadDetailsByBookingKey");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }

        }


        [HttpPost]
        public async Task<JsonResult> GetDocumentUploadbySerialNumber(int businessKey, long bookingKey, int guestId, int serialno)
        {
            try
            {
                var parameter = "?businessKey=" + businessKey + "&bookingKey=" + bookingKey + "&guestId=" + guestId + "&serialno=" + serialno;
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<DO_GuestDocumentUpload>("GuestCheckIn/GetDocumentUploadbySerialNumber" + parameter);
                if (serviceResponse.Status)
                {
                    var domainname = this.Request.PathBase;
                    if (serviceResponse.Data != null)
                    {
                        if (serviceResponse.Data.DocumentUrl != null)
                        {
                            string filename = null;
                            // using the method
                            filename = Path.GetFileName(serviceResponse.Data.DocumentUrl);
                            serviceResponse.Data.FileName = filename;

                            serviceResponse.Data.DocumentUrl = domainname + serviceResponse.Data.DocumentUrl;


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
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetDocumentUploadbySerialNumber");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetDocumentUploadbySerialNumber");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        [HttpGet]
        public async Task<IActionResult> DownloadDocument(int businessKey, long bookingKey, int guestId, int serialno)
        {

            var parameter = "?businessKey=" + businessKey + "&bookingKey=" + bookingKey + "&guestId=" + guestId + "&serialno=" + serialno;
            var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<DO_GuestDocumentUpload>("GuestCheckIn/GetDocumentUploadbySerialNumber" + parameter);
            if (serviceResponse.Status)
            {
                var domainname = this.Request.PathBase;
                if (serviceResponse.Data != null)
                {
                    if (serviceResponse.Data.DocumentUrl != null)
                    {
                        string filename = null;
                        // using the method
                        filename = Path.GetFileName(serviceResponse.Data.DocumentUrl);
                        serviceResponse.Data.FileName = filename;

                        //Build the File Path.
                        string path = Path.Combine(this._appEnvironment.WebRootPath, "Uploads/DocumentUploads/") + filename;

                        //Read the File data into Byte Array.
                        byte[] bytes = System.IO.File.ReadAllBytes(path);

                        //Send the File to Download.

                        return File(bytes, System.Net.Mime.MediaTypeNames.Application.Octet, serviceResponse.Data.FileName);

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
                _logger.LogError(new Exception(serviceResponse.Message), "UD:DownloadDocument");
                return Json(new { Status = false, StatusCode = "500" });
            }

        }


        [HttpPost]
        public async Task<IActionResult> DeleteDocument(int businessKey, long bookingKey, int guestId, int serialno)
        {

            var parameter = "?businessKey=" + businessKey + "&bookingKey=" + bookingKey + "&guestId=" + guestId + "&serialno=" + serialno;
            var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<DO_GuestDocumentUpload>("GuestCheckIn/DeleteDocument" + parameter);
            if (serviceResponse.Status)
            {
                var domainname = this.Request.PathBase;
                if (serviceResponse.Data != null)
                {
                    if (serviceResponse.Data.DocumentUrl != null)
                    {
                        string filename = null;
                        // using the method
                        filename = Path.GetFileName(serviceResponse.Data.DocumentUrl);
                        serviceResponse.Data.FileName = filename;

                        //Build the File Path.
                        string path = Path.Combine(this._appEnvironment.WebRootPath, "Uploads/DocumentUploads/") + filename;

                        if (System.IO.File.Exists(path))
                        {
                            System.IO.File.Delete(path);

                        }

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
                _logger.LogError(new Exception(serviceResponse.Message), "UD:DeleteDocument");
                return Json(new { Status = false, StatusCode = "500" });
            }

        }

        public async Task<JsonResult> GetServiceList()
        {
            try
            {
                var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_ServiceRates>>("ServiceRate/GetServiceList" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetServiceList");
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetServiceList");
                throw ex;
            }
        }

        public async Task<JsonResult> GetServiceRates(int serviceId)
        {
            try
            {
                var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
                parameter += "&serviceId=" + serviceId;
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<DO_ServiceRates>("ServiceRate/GetServiceRates" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetServiceRates");
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetServiceRates");
                throw ex;
            }
        }


        public async Task<JsonResult> GetGuestServiceBilling(long bookingKey)
        {
            try
            {
                var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
                parameter += "&bookingKey=" + bookingKey;
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_PatientBillDetails>>("GuestCheckOut/GetGuestServiceBilling" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetGuestServiceBilling:params:bookingKey:{0}", bookingKey);
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetGuestServiceBilling:params:bookingKey:{0}", bookingKey);
                throw ex;
            }
        }

        [HttpPost]
        public async Task<JsonResult> CreateGuestBill(DO_PatientBillHeader obj)
        {
            try
            {
                obj.BusinessKey = AppSessionVariables.GetSessionBusinessKey(HttpContext);
                obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("GuestCheckOut/CreateGuestBill", obj);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data.Status)
                        return Json(new { Status = true, serviceResponse.Data.Warning, serviceResponse.Data.WarningMessage });
                    else
                        return Json(new { Status = false, serviceResponse.Data.Warning, serviceResponse.Data.WarningMessage, serviceResponse.Data.Message });
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:CreateGuestBill:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:CreateGuestBill:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Warning = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
            }
        }

        public async Task<JsonResult> GetGuestBillingSummary(long bookingKey)
        {
            try
            {
                var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
                parameter += "&bookingKey=" + bookingKey;
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<DO_PatientBillHeader>("GuestCheckOut/GetGuestBillingSummary" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetGuestBillingSummary");
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetGuestBillingSummary");
                throw ex;
            }
        }


        [HttpPost]
        public async Task<JsonResult> GuestCheckOutProcess(DO_GuestCheckInDetails obj)
        {
            try
            {
                obj.BusinessKey = AppSessionVariables.GetSessionBusinessKey(HttpContext);
                obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("GuestCheckOut/GuestCheckOutProcess", obj);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data.Status)
                    {
                        if (obj.CheckedOutDate.Date == DateTime.Now.Date)
                            SendSMSForGuestCheckOut(obj);
                        return Json(new { Status = true, serviceResponse.Data.Warning, serviceResponse.Data.WarningMessage });
                    }
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


        public async Task<JsonResult> GetGuestCheckOutStatus(long bookingKey, int guestId)
        {
            try
            {
                var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
                parameter += "&bookingKey=" + bookingKey;
                parameter += "&guestId=" + guestId;
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("GuestCheckOut/GetGuestCheckOutStatus" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetGuestCheckOutStatus:params:bookingKey:{0}:guestId{1}", bookingKey, guestId);
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetGuestCheckOutStatus:params:bookingKey:{0}:guestId{1}", bookingKey, guestId);
                throw ex;
            }
        }

        #region Address
        [HttpGet]
        public async Task<JsonResult> GetStateList(int isdCode)
        {
            try
            {
                var parameter = "?isdCode=" + isdCode;
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_Place>>("GuestCheckIn/GetStateList" + parameter);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetStateList:For isdCode", isdCode);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetStateList:For isdCode ", isdCode);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetStateList:For isdCode ", isdCode);
                throw ex;
            }
        }
        [HttpGet]
        public async Task<JsonResult> GetCityList(int isdCode, int? stateCode)
        {
            try
            {
                if (stateCode > 0)
                {
                    var parameter = "?isdCode=" + isdCode + "&stateCode=" + stateCode;
                    var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_Place>>("GuestCheckIn/GetCityList" + parameter);
                    if (serviceResponse.Status)
                    {
                        if (serviceResponse.Data != null)
                        {
                            return Json(serviceResponse.Data);
                        }
                        else
                        {
                            _logger.LogError(new Exception(serviceResponse.Message), "UD:GetCityList:For isdCode {0} with stateCode entered {1}", isdCode, stateCode);
                            return Json(new { Status = false, StatusCode = "500" });
                        }
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetCityList:For isdCode {0} with stateCode entered {1}", isdCode, stateCode);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetCityList:For isdCode {0} with stateCode entered {1}", isdCode, stateCode);
                throw ex;
            }
        }
        [HttpGet]
        public async Task<JsonResult> GetAreaList(int isdCode, int? stateCode, int? cityCode)
        {
            try
            {
                if (stateCode > 0 && cityCode > 0)
                {
                    var parameter = "?isdCode=" + isdCode + "&stateCode=" + stateCode + "&cityCode=" + cityCode;
                    var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_AddressIN>>("GuestCheckIn/GetAreaList" + parameter);
                    if (serviceResponse.Status)
                    {
                        if (serviceResponse.Data != null)
                        {
                            return Json(serviceResponse.Data);
                        }
                        else
                        {
                            _logger.LogError(new Exception(serviceResponse.Message), "UD:GetAreaList:For isdCode {0} with stateCode cityCode entered {1} {2}", isdCode, stateCode, cityCode);
                            return Json(new { Status = false, StatusCode = "500" });
                        }
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetAreaList:For isdCode {0} with stateCode cityCode pincode entered {1} {2}{3}", isdCode, stateCode, cityCode);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    return Json(new { Status = false });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetAreaList:For isdCode {0} with stateCode cityCode pincode entered {1} {2}", isdCode, stateCode, cityCode);
                throw ex;
            }
        }
        [HttpGet]
        public async Task<JsonResult> GetAreaDetailsbyPincode(int isdCode, string pincode)
        {
            try
            {
                var parameter = "?isdCode=" + isdCode + "&pincode=" + pincode;
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<DO_AddressIN>("GuestCheckIn/GetAreaDetailsbyPincode" + parameter);
                if (serviceResponse.Status)
                {

                    return Json(serviceResponse.Data);

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetAreaDetailsbyPincode:For isdCode {0} with stateCode cityCode pincode entered {1} ", isdCode, pincode);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetAreaDetailsbyPincode:For isdCode {0} with  pincode entered {1} }", isdCode, pincode);
                throw ex;
            }
        }
        #endregion

        #region MyRegion
        [HttpPost]
        public async Task<JsonResult> FetchPaymentOrder(long bookingKey)
        {

            try
            {
                var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
                parameter += "&bookingKey=" + bookingKey;

                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<DO_GuestOnlinePaymentResponse>("GuestPayment/GetPaymentOrderResponseByBookingKey" + parameter);

                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:FetchPaymentOrder:For roomTypeId {0} ");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        public async Task<JsonResult> CheckOnlinePaymentAndMakePaymentReceipt(DO_GuestOnlinePaymentResponse obj)
        {

            try
            {
                obj.BusinessKey = AppSessionVariables.GetSessionBusinessKey(HttpContext);

               var pay_response =  await _razorpayClientServices.FetchOrder(obj.order_id);

                if (pay_response.status == "paid")
                {

                    var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("GuestPayment/CheckOnlinePaymentAndMakePaymentReceipt", obj);

                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
                else
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = pay_response.status  });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:FetchPaymentOrder:For roomTypeId {0} ");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        #endregion

        #region  
        public void SendSMSForGuestCheckIn(DO_GuestCheckInDetails obj)
        {
            try
            {
                DO_SmsParameter smsParams = new DO_SmsParameter
                {
                    MessageType = "NGC",
                    TEventID = SMSTriggerEventValues.OnSaveClicked,
                    FormID = 10014,//AppSessionVariables.GetSessionFormID(HttpContext);
                    MobileNumber = obj.MobileNumber,
                    Name = obj.FirstName + " " + obj.LastName
                };
                _smsServices.SendSmsForForm(smsParams);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:SendSMSForGuestCheckIn");
                //throw ex;
            }
        }

        public void SendSMSForGuestCheckOut(DO_GuestCheckInDetails obj)
        {
            try
            {
                DO_SmsParameter smsParams = new DO_SmsParameter
                {
                    MessageType = "NGC",
                    TEventID = SMSTriggerEventValues.OnGuestCheckOut,
                    FormID = 10014,//AppSessionVariables.GetSessionFormID(HttpContext);
                    MobileNumber = obj.MobileNumber,
                    Name = obj.FirstName + " " + obj.LastName
                };
                _smsServices.SendSmsForForm(smsParams);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:SendSMSForGuestCheckOut");
                //throw ex;
            }
        }

        #endregion

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

        #region Add on Service
        public async Task<JsonResult> GetGuestServiceByBookingKey(long bookingKey)
        {
            try
            {
                var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
                parameter += "&bookingKey=" + bookingKey;
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_Service>>("GuestCheckIn/GetGuestServiceByBookingKey" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetGuestServiceByBookingKey:params:bookingKey:{0}:bookingkey{1}", bookingKey);
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetGuestServiceByBookingKey:params:bookingKey:{0}:bookingkey{1}", bookingKey);
                throw ex;
            }
        }
        [HttpPost]
        public async Task<JsonResult> InsertGuestService(DO_Service obj)
        {
            try
            {
                obj.BusinessKey = AppSessionVariables.GetSessionBusinessKey(HttpContext);
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

                var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
                var servicetypeResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_ServiceRates>>("ServiceRate/GetServiceList" + parameter);
                if (servicetypeResponse.Status)
                {
                    if (servicetypeResponse.Data != null)
                    {
                        var servicetype = servicetypeResponse.Data.Where(x => x.ServiceId == obj.ServiceId).FirstOrDefault();
                        if (servicetype != null)
                        {
                            obj.ServiceTypeId = servicetype.ServiceTypeId;
                        }
                        else
                        {
                            obj.ServiceTypeId = 0;
                        }
                    }
                }
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("GuestCheckIn/InsertGuestService", obj);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertGuestService:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Warning = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
            }
        }
        #endregion

        [HttpPost]
        public async Task<JsonResult> UpdateGuestPersonalDetails(DO_GuestCheckInDetails obj)
        {
            try
            {
                obj.BusinessKey = AppSessionVariables.GetSessionBusinessKey(HttpContext);
                obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("GuestCheckIn/UpdateGuestPersonalDetails", obj);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:UpdateGuestPersonalDetails:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Warning = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
            }
        }
    }
}