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
    public class FirstConsultationController : Controller
    {
        private readonly IeSyaNatureCureAPIServices _eSyaNatureCureAPIServices;
        private readonly ILogger<CheckInGuestController> _logger;

        public FirstConsultationController(IeSyaNatureCureAPIServices eSyaNatureCureAPIServices, ILogger<CheckInGuestController> logger)
        {
            _eSyaNatureCureAPIServices = eSyaNatureCureAPIServices;
            _logger = logger;
        }

        [Area("eSyaNatureCure")]
        public async Task<IActionResult> V_ENC_07_00()
        {
            return View();
        }

        public async Task<JsonResult> GetConsultaionList()
        {
            try
            {
                //var parameter = "?businessKey=111";
                var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_BookinDetails>>("FirstConsultation/GetConsultaionList" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetConsultaionList");
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetConsultaionList");
                throw ex;
            }
        }

        [HttpPost]
        public async Task<JsonResult> ConsultaionConfirmation(DO_GuestCheckInDetails obj)
        {
            try
            {

               // obj.BusinessKey =111;
                obj.BusinessKey = AppSessionVariables.GetSessionBusinessKey(HttpContext);
                obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("FirstConsultation/ConsultaionConfirmation", obj);

                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ConsultaionConfirmation:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Warning = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
            }
        }

        [Area("eSyaNatureCure")]
        public async Task<IActionResult> V_ENC_08_00(long bookingKey, int guestId, int uhid)
        {
            ViewBag.BookingKey = bookingKey;
            ViewBag.GuestId = guestId;
            ViewBag.UHID = uhid;
            //var parameter = "?businessKey=111";
            var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
            parameter += "&bookingKey=" + bookingKey;
            parameter += "&guestId=" + guestId;
            var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<DO_GuestCheckInDetails>("FirstConsultation/GetGuestDetails" + parameter);
            if (serviceResponse.Status)
            {
                if (serviceResponse.Data != null)
                {
                    if (serviceResponse.Data.ImageUrl != null)
                    {
                        var domainname = this.Request.PathBase;
                        string filename = null;
                        // using the method
                        filename = Path.GetFileName(serviceResponse.Data.ImageUrl);
                        serviceResponse.Data.FileName = filename;
                        serviceResponse.Data.ImageUrl = domainname + serviceResponse.Data.ImageUrl;
                    }
                }

                return View(serviceResponse.Data);
            }


            else
            {
                _logger.LogError(new Exception(serviceResponse.Message), "UD:GetGuestDetails:params: bookingKey{0} , guestId{1} ", bookingKey, guestId);
                return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
            }

            
        }

        public async Task<JsonResult> GetGuestActivities(long ipNumber)
        {
            try
            {
                //var parameter = "?businessKey=111";
                var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
                parameter += "&ipNumber=" + ipNumber;
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<DO_GuestActivities>("FirstConsultation/GetGuestActivities" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetGuestActivities:params: ipNumber{0}", ipNumber);
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetGuestActivities:params: ipNumber{0}", ipNumber);
                throw ex;
            }
        }
        [HttpPost]
        public async Task<JsonResult> AddOrUpdateGuestActivity(DO_GuestActivity obj)
        {
            try
            {

                // obj.BusinessKey =111;
                obj.BusinessKey = AppSessionVariables.GetSessionBusinessKey(HttpContext);
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                obj.CreatedBy = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.CreatedTerminal = AppSessionVariables.GetIPAddress(HttpContext);

                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("FirstConsultation/AddOrUpdateGuestActivity", obj);

                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ConsultaionConfirmation:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Warning = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
            }
        }

        public async Task<JsonResult> GetActivities()
        {
            try
            {
                
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_Activities>>("FirstConsultation/GetActivities");
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetActivities");
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetActivities");
                throw ex;
            }
        }
    }
}