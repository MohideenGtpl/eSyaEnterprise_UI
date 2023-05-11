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
    public class LaundryController : Controller
    {
        private readonly IeSyaNatureCureAPIServices _eSyaNatureCureAPIServices;
        private readonly ILogger<LaundryController> _logger;

        public LaundryController(IeSyaNatureCureAPIServices eSyaNatureCureAPIServices, ILogger<LaundryController> logger)
        {
            _eSyaNatureCureAPIServices = eSyaNatureCureAPIServices;
            _logger = logger;
        }

        [Area("eSyaNatureCure")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult V_ENC_27_00()
        {
            return View();
        }
        [HttpPost]
        public async Task<JsonResult> GetCheckInGuestDetailsByBookingKey()
        {
            try
            {
                var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_GuestCheckInDetails>>("Laundry/GetCheckInGuestDetailsByBookingKey" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetCheckInGuestDetailsByBookingKey:params:bookingKey:{0}", parameter);
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetCheckInGuestDetailsByBookingKey:params:GetCheckInGuestDetailsByBookingKey");
                throw ex;
            }
        }
        [HttpGet]
        public async Task<JsonResult> GetLaundryServiceList(string gender)
        {
            try
            {
                var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
                parameter += "&gender=" + gender;
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_ServiceRates>>("Laundry/GetLaundryServiceList" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetLaundryServiceList");
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetLaundryServiceList");
                throw ex;
            }
        }
        [HttpGet]
        public async Task<JsonResult> GetLaundryServiceRates(int serviceId)
        {
            try
            {
                var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
                parameter += "&serviceId=" + serviceId;
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<DO_ServiceRates>("Laundry/GetLaundryServiceRates" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetLaundryServiceRates");
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetLaundryServiceRates");
                throw ex;
            }
        }

        [HttpGet]
        public async Task<JsonResult> GetGuestLaundryServiceByBookingKey(long bookingKey)
        {
            try
            {
                var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
                parameter += "&bookingKey=" + bookingKey;
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_Service>>("Laundry/GetGuestLaundryServiceByBookingKey" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetGuestLaundryServiceByBookingKey");
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetGuestLaundryServiceByBookingKey");
                throw ex;
            }
        }
        
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateGuestLaundryService(bool isInsert, DO_Service obj)
        {

            try
            {
                obj.BusinessKey= AppSessionVariables.GetSessionBusinessKey(HttpContext);
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                if (isInsert)
                {
                    var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Laundry/InsertGuestLaundryService", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
                else
                {
                    var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Laundry/UpdateGuestLaundryService", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateGuestLaundryService:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        
        [HttpPost]
        public async Task<JsonResult> ActiveOrDeActiveGuestLaundryService(bool status,  long bookingKey, int SerialNumber)
        {

            try
            {
                var parameter = "?status=" + status;
                parameter += "&businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
                parameter += "&bookingKey=" + bookingKey;
                parameter += "&SerialNumber=" + SerialNumber;

                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("Laundry/ActiveOrDeActiveGuestLaundryService" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ActiveOrDeActiveGuestLaundryService:For bookingKey {0} ", bookingKey);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
    }
}