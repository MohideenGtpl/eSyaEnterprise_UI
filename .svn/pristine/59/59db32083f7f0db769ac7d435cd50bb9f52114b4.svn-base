using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eSyaEnterprise_UI.ActionFilter;
using eSyaEnterprise_UI.Areas.eSyaServices.Data;
using eSyaEnterprise_UI.Areas.eSyaServices.Models;
using eSyaEnterprise_UI.Models;
using eSyaEnterprise_UI.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace eSyaEnterprise_UI.Areas.eSyaServices.Controllers
{
    [SessionTimeout]
    public class ServiceRatesController : Controller
    {
        private readonly IeSyaServicesAPIServices _eSyaServicesAPIServices;
        private readonly ILogger<ServiceRatesController> _logger;
        public ServiceRatesController(IeSyaServicesAPIServices eSyaServicesAPIServices, ILogger<ServiceRatesController> logger)
        {
            _eSyaServicesAPIServices = eSyaServicesAPIServices;
            _logger = logger;
        }
        

        #region ServiceBaseRate
        /// <summary>
        /// Service Base Rate
        /// </summary>
        /// <returns></returns>

        [Area("eSyaServices")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> V_1514_00()
        {
            ViewBag.UserFormRoles = new DO_UserFormRole { IsInsert = true, IsEdit = true, IsDelete = true };
            var serviceResponse = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_BusinessLocation>>("CommonMethod/GetBusinessKey");
            if (serviceResponse.Status)
            {
                if (serviceResponse.Data != null)
                {
                    ViewBag.BusinessKey = serviceResponse.Data.Select(b => new SelectListItem
                    {
                        Value = b.BusinessKey.ToString(),
                        Text = b.LocationDescription,
                    }).ToList();
                }
            }
            else
            {
                _logger.LogError(new Exception(serviceResponse.Message), "UD:V_1514_00:GetBusinessKey");
            }
            var serviceResponse1 = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_ApplicationCode>>("CommonMethod/GetApplicationCodesByCodeType?codetype=62");
            if (serviceResponse1.Status)
            {
                if (serviceResponse1.Data != null)
                {
                    ViewBag.RateType = serviceResponse1.Data.Select(r => new SelectListItem
                    {
                        Value = r.ApplicationCode.ToString(),
                        Text = r.CodeDesc,
                    }).ToList();
                }
            }
            else
            {
                _logger.LogError(new Exception(serviceResponse1.Message), "UD:V_1514_00:GetApplicationCodesByCodeType: CodeType {0} 62");
            }
            var serviceResponse2 = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_CurrencyCode>>("CommonMethod/GetCurrencyCodes");
            if (serviceResponse2.Status)
            {
                if (serviceResponse2.Data != null)
                {
                    ViewBag.CurrencyCode = serviceResponse2.Data.Select(c => new SelectListItem
                    {
                        Value = c.CurrencyCode.ToString(),
                        Text = c.CurrencyName,
                    }).ToList();
                }
            }
            else
            {
                _logger.LogError(new Exception(serviceResponse2.Message), "UD:V_1514_00:GetCurrencyCodes");
            }

            return View();

        }

        /// <summary>
        /// Add Service Base Rate
        /// </summary>
        /// <returns></returns>

        [Area("eSyaServices")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> V_1520_00()
        {
            ViewBag.UserFormRoles = new DO_UserFormRole { IsInsert = true, IsEdit = true, IsDelete = true };
            var serviceResponse = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_BusinessLocation>>("CommonMethod/GetBusinessKey");
            if (serviceResponse.Status)
            {
                if (serviceResponse.Data != null)
                {
                    ViewBag.BusinessKey = serviceResponse.Data.Select(b => new SelectListItem
                    {
                        Value = b.BusinessKey.ToString(),
                        Text = b.LocationDescription,
                    }).ToList();
                }
            }
            else
            {
                _logger.LogError(new Exception(serviceResponse.Message), "UD:V_1520_00:GetBusinessKey");
            }
            var serviceResponse1 = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_ApplicationCode>>("CommonMethod/GetApplicationCodesByCodeType?codetype=62");
            if (serviceResponse1.Status)
            {
                if (serviceResponse1.Data != null)
                {
                    ViewBag.RateType = serviceResponse1.Data.Select(r => new SelectListItem
                    {
                        Value = r.ApplicationCode.ToString(),
                        Text = r.CodeDesc,
                    }).ToList();
                }
            }
            else
            {
                _logger.LogError(new Exception(serviceResponse1.Message), "UD:V_1520_00:GetApplicationCodesByCodeType: CodeType {0} 62");
            }
            var serviceResponse2 = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_CurrencyCode>>("CommonMethod/GetCurrencyCodes");
            if (serviceResponse2.Status)
            {
                if (serviceResponse2.Data != null)
                {
                    ViewBag.CurrencyCode = serviceResponse2.Data.Select(c => new SelectListItem
                    {
                        Value = c.CurrencyCode.ToString(),
                        Text = c.CurrencyName,
                    }).ToList();
                }
            }
            else
            {
                _logger.LogError(new Exception(serviceResponse2.Message), "UD:V_1520_00:GetCurrencyCodes");
            }

            return View();

        }

        public async Task<ActionResult> GetServiceBaseRateByBKeyRateTypeCurrCode(int businessKey, int ratetype,string currencycode)
        {
            try
            {
                var serviceResponse = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_ServiceBaseRate>>("ServiceRates/GetServiceBaseRateByBKeyRateTypeCurrCode?businessKey=" + businessKey + "&ratetype=" + ratetype + "&currencycode=" + currencycode);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        var ServiceBaseRate_list = serviceResponse.Data;
                        return Json(ServiceBaseRate_list);
                    }
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetServiceGetServiceBaseRateByBKeyRateType:For BusinessKey {0} , RateType {1}, CurrencyCode {2}", businessKey,ratetype,currencycode);
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }


            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetServiceGetServiceBaseRateByBKeyRateType:For BusinessKey {0} , RateType {1}, CurrencyCode {2}", businessKey,ratetype,currencycode);
                return Json(new DO_ReturnParameter() { Status = false, Message = ex.Message });
            }
        }
        public async Task<ActionResult> GetServiceBaseRateByBKeyRateTypeCurrCodeForAdd(int businessKey, int ratetype, string currencycode)
        {
            try
            {
                var serviceResponse = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_ServiceBaseRate>>("ServiceRates/GetServiceBaseRateByBKeyRateTypeCurrCodeForAdd?businessKey=" + businessKey + "&ratetype=" + ratetype + "&currencycode=" + currencycode);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        var ServiceBaseRate_list = serviceResponse.Data;
                        return Json(ServiceBaseRate_list);
                    }
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetServiceGetServiceBaseRateByBKeyRateTypeForAdd:For BusinessKey {0} , RateType {1}, CurrencyCode {2}", businessKey, ratetype, currencycode);
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }


            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetServiceGetServiceBaseRateByBKeyRateTypeForAdd:For BusinessKey {0} , RateType {1}, CurrencyCode {2}", businessKey, ratetype, currencycode);
                return Json(new DO_ReturnParameter() { Status = false, Message = ex.Message });
            }
        }
        public async Task<ActionResult> AddOrUpdateServiceBaseRate(List<DO_ServiceBaseRate> obj)
        {
            try
            {
                foreach (var ser_br in obj)
                {
                    ser_br.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                    ser_br.CreatedOn = DateTime.Now;
                    ser_br.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                    ser_br.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                }


                var serviceResponse = await _eSyaServicesAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("ServiceRates/AddOrUpdateServiceBaseRate", obj);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Data.Message), "UD:AddOrUpdateServiceBaseRate:params:" + JsonConvert.SerializeObject(obj));
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Data.Message });
                    }

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:AddOrUpdateServiceBaseRate:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:AddOrUpdateServiceBaseRate:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }
        public async Task<ActionResult> AddServiceBaseRate(List<DO_ServiceBaseRate> obj)
        {
            try
            {
                foreach (var ser_br in obj)
                {
                    ser_br.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                    ser_br.CreatedOn = DateTime.Now;
                    ser_br.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                    ser_br.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                }


                var serviceResponse = await _eSyaServicesAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("ServiceRates/AddServiceBaseRate", obj);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Data.Message), "UD:AddServiceBaseRate:params:" + JsonConvert.SerializeObject(obj));
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Data.Message });
                    }

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:AddServiceBaseRate:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:AddServiceBaseRate:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }
        #endregion

        #region ServiceRatePlan
        /// <summary>
        /// Service Rate Plan
        /// </summary>
        /// <returns></returns>

        [Area("eSyaServices")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> V_1516_00()
        {
            ViewBag.UserFormRoles = new DO_UserFormRole { IsInsert = true, IsEdit = true, IsDelete = true };
            var serviceResponse = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_BusinessLocation>>("CommonMethod/GetBusinessKey");
            if (serviceResponse.Status)
            {
                if (serviceResponse.Data != null)
                {
                    ViewBag.BusinessKey = serviceResponse.Data.Select(b => new SelectListItem
                    {
                        Value = b.BusinessKey.ToString(),
                        Text = b.LocationDescription,
                    }).ToList();
                }
            }
            else
            {
                _logger.LogError(new Exception(serviceResponse.Message), "UD:V_1516_00:GetBusinessKey");
            }
            var serviceResponse1 = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_ApplicationCode>>("CommonMethod/GetApplicationCodesByCodeType?codetype=62");
            if (serviceResponse1.Status)
            {
                if (serviceResponse1.Data != null)
                {
                    ViewBag.RateType = serviceResponse1.Data.Select(r => new SelectListItem
                    {
                        Value = r.ApplicationCode.ToString(),
                        Text = r.CodeDesc,
                    }).ToList();
                }
            }
            else
            {
                _logger.LogError(new Exception(serviceResponse1.Message), "UD:V_1516_00:GetApplicationCodesByCodeType: CodeType {0} 62");
            }


            return View();

        }

        public async Task<ActionResult> GetServiceRatePlansByBKey(int businessKey)
        {
            try
            {
                var serviceResponse = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_ServiceRatePlan>>("ServiceRates/GetServiceRatePlansByBKey?businessKey=" + businessKey);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        var ServiceRatePlan_list = serviceResponse.Data;
                        return Json(ServiceRatePlan_list);
                    }
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetServiceRatePlansByBKey:For BusinessKey {0} ", businessKey);
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }


            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetServiceRatePlansByBKey:For BusinessKey {0} ", businessKey);
                return Json(new DO_ReturnParameter() { Status = false, Message = ex.Message });
            }
        }
        public async Task<ActionResult> AddOrUpdateServiceRatePlan(DO_ServiceRatePlan obj)
        {
            try
            {
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                obj.CreatedOn = DateTime.Now;
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

                var serviceResponse = await _eSyaServicesAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("ServiceRates/AddOrUpdateServiceRatePlan", obj);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Data.Message), "UD:AddOrUpdateServiceRatePlan:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Data.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:AddOrUpdateServiceRatePlan:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }
        public async Task<ActionResult> GetServiceRatePlanByBKeyRType(int businessKey, int ratetype)
        {
            try
            {
                var serviceResponse = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<DO_ServiceRatePlan>("ServiceRates/GetServiceRatePlanByBKeyRType?businessKey=" + businessKey + "&ratetype=" + ratetype);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        var data = serviceResponse.Data;
                        return Json(data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetServiceRatePlanByBKeyRType:For BusinessKey {0}, RateType {1} ", businessKey,ratetype);
                        return Json(new { Status = false, Message = serviceResponse.Message });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetServiceRatePlanByBKeyRType:For BusinessKey {0}, RateType {1} ", businessKey, ratetype);
                    return Json(new { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetServiceRatePlanByBKeyRType:For BusinessKey {0}, RateType {1} ", businessKey, ratetype);
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }
        #endregion

        #region ServiceSpecialtyRate
        /// <summary>
        /// Service Specialty Rate
        /// </summary>
        /// <returns></returns>

        [Area("eSyaServices")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> V_1521_00()
        {
            ViewBag.UserFormRoles = new DO_UserFormRole { IsInsert = true, IsEdit = true, IsDelete = true };
            var serviceResponse = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_BusinessLocation>>("CommonMethod/GetBusinessKey");
            if (serviceResponse.Status)
            {
                if (serviceResponse.Data != null)
                {
                    ViewBag.BusinessKey = serviceResponse.Data.Select(b => new SelectListItem
                    {
                        Value = b.BusinessKey.ToString(),
                        Text = b.LocationDescription,
                    }).ToList();
                }
            }
            else
            {
                _logger.LogError(new Exception(serviceResponse.Message), "UD:V_1521_00:GetBusinessKey");
            }
            var serviceResponse1 = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_ApplicationCode>>("CommonMethod/GetApplicationCodesByCodeType?codetype=62");
            if (serviceResponse1.Status)
            {
                if (serviceResponse1.Data != null)
                {
                    ViewBag.RateType = serviceResponse1.Data.Select(r => new SelectListItem
                    {
                        Value = r.ApplicationCode.ToString(),
                        Text = r.CodeDesc,
                    }).ToList();
                }
            }
            else
            {
                _logger.LogError(new Exception(serviceResponse1.Message), "UD:V_1521_00:GetApplicationCodesByCodeType: CodeType {0} 62");
            }
            var serviceResponse2 = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_CurrencyCode>>("CommonMethod/GetCurrencyCodes");
            if (serviceResponse2.Status)
            {
                if (serviceResponse2.Data != null)
                {
                    ViewBag.CurrencyCode = serviceResponse2.Data.Select(c => new SelectListItem
                    {
                        Value = c.CurrencyCode.ToString(),
                        Text = c.CurrencyName,
                    }).ToList();
                }
            }
            else
            {
                _logger.LogError(new Exception(serviceResponse2.Message), "UD:V_1521_00:GetCurrencyCodes");
            }
            var serviceResponse3 = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_Specialty>>("CommonMethod/GetSpecialties");
            if (serviceResponse3.Status)
            {
                if (serviceResponse3.Data != null)
                {
                    ViewBag.Specialties = serviceResponse3.Data.Select(c => new SelectListItem
                    {
                        Value = c.SpecialtyId.ToString(),
                        Text = c.SpecialtyDesc,
                    }).ToList();               
                }
            }
            else
            {
                _logger.LogError(new Exception(serviceResponse3.Message), "UD:V_1521_00:GetSpecialties");
                return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse3.Message });
            }
            return View();

        }

        /// <summary>
        /// Add Service Specialty Rate
        /// </summary>
        /// <returns></returns>

        [Area("eSyaServices")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> V_1522_00()
        {
            ViewBag.UserFormRoles = new DO_UserFormRole { IsInsert = true, IsEdit = true, IsDelete = true };
            var serviceResponse = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_BusinessLocation>>("CommonMethod/GetBusinessKey");
            if (serviceResponse.Status)
            {
                if (serviceResponse.Data != null)
                {
                    ViewBag.BusinessKey = serviceResponse.Data.Select(b => new SelectListItem
                    {
                        Value = b.BusinessKey.ToString(),
                        Text = b.LocationDescription,
                    }).ToList();
                }
            }
            else
            {
                _logger.LogError(new Exception(serviceResponse.Message), "UD:V_1522_00:GetBusinessKey");
            }
            var serviceResponse1 = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_ApplicationCode>>("CommonMethod/GetApplicationCodesByCodeType?codetype=62");
            if (serviceResponse1.Status)
            {
                if (serviceResponse1.Data != null)
                {
                    ViewBag.RateType = serviceResponse1.Data.Select(r => new SelectListItem
                    {
                        Value = r.ApplicationCode.ToString(),
                        Text = r.CodeDesc,
                    }).ToList();
                }
            }
            else
            {
                _logger.LogError(new Exception(serviceResponse1.Message), "UD:V_1522_00:GetApplicationCodesByCodeType: CodeType {0} 62");
            }
            var serviceResponse2 = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_CurrencyCode>>("CommonMethod/GetCurrencyCodes");
            if (serviceResponse2.Status)
            {
                if (serviceResponse2.Data != null)
                {
                    ViewBag.CurrencyCode = serviceResponse2.Data.Select(c => new SelectListItem
                    {
                        Value = c.CurrencyCode.ToString(),
                        Text = c.CurrencyName,
                    }).ToList();
                }
            }
            else
            {
                _logger.LogError(new Exception(serviceResponse2.Message), "UD:V_1522_00:GetCurrencyCodes");
            }
            var serviceResponse3 = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_Specialty>>("CommonMethod/GetSpecialties");
            if (serviceResponse3.Status)
            {
                if (serviceResponse3.Data != null)
                {
                    ViewBag.Specialties = serviceResponse3.Data.Select(c => new SelectListItem
                    {
                        Value = c.SpecialtyId.ToString(),
                        Text = c.SpecialtyDesc,
                    }).ToList();
                }
            }
            else
            {
                _logger.LogError(new Exception(serviceResponse3.Message), "UD:V_1522_00:GetSpecialties");
                return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse3.Message });
            }
            return View();

        }

        public async Task<ActionResult> GetServiceSpecialtyRateByBKeyRateTypeCurrCode(int businessKey, int ratetype, string currencycode,int specialtyId)
        {
            try
            {
                var serviceResponse = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_ServiceSpecialtyRate>>("ServiceRates/GetServiceSpecialtyRateByBKeyRateTypeCurrCode?businessKey=" + businessKey + "&ratetype=" + ratetype + "&currencycode=" + currencycode + "&specialtyId=" + specialtyId);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        var ServiceSpecialtyRate_list = serviceResponse.Data;
                        return Json(ServiceSpecialtyRate_list);
                    }
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetServiceGetServiceSpecialtyRateByBKeyRateType:For BusinessKey {0} , RateType {1}, CurrencyCode {2}, SpecialtyId {3}", businessKey, ratetype, currencycode,specialtyId);
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }


            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetServiceGetServiceSpecialtyRateByBKeyRateType:For BusinessKey {0} , RateType {1}, CurrencyCode {2}, SpecialtyId {3}", businessKey, ratetype, currencycode,specialtyId);
                return Json(new DO_ReturnParameter() { Status = false, Message = ex.Message });
            }
        }
        public async Task<ActionResult> GetServiceSpecialtyRateByBKeyRateTypeCurrCodeForAdd(int businessKey, int ratetype, string currencycode, int specialtyId)
        {
            try
            {
                var serviceResponse = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_ServiceSpecialtyRate>>("ServiceRates/GetServiceSpecialtyRateByBKeyRateTypeCurrCodeForAdd?businessKey=" + businessKey + "&ratetype=" + ratetype + "&currencycode=" + currencycode + "&specialtyId=" + specialtyId);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        var ServiceSpecialtyRate_list = serviceResponse.Data;
                        return Json(ServiceSpecialtyRate_list);
                    }
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetServiceGetServiceSpecialtyRateByBKeyRateTypeForAdd:For BusinessKey {0} , RateType {1}, CurrencyCode {2}, SpecialtyId {3}", businessKey, ratetype, currencycode,specialtyId);
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }


            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetServiceGetServiceSpecialtyRateByBKeyRateTypeForAdd:For BusinessKey {0} , RateType {1}, CurrencyCode {2}, SpecialtyId {3}", businessKey, ratetype, currencycode,specialtyId);
                return Json(new DO_ReturnParameter() { Status = false, Message = ex.Message });
            }
        }
        public async Task<ActionResult> AddOrUpdateServiceSpecialtyRate(List<DO_ServiceSpecialtyRate> obj)
        {
            try
            {
                foreach (var ser_spr in obj)
                {
                    ser_spr.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                    ser_spr.CreatedOn = DateTime.Now;
                    ser_spr.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                    ser_spr.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                }


                var serviceResponse = await _eSyaServicesAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("ServiceRates/AddOrUpdateServiceSpecialtyRate", obj);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Data.Message), "UD:AddOrUpdateServiceSpecialtyRate:params:" + JsonConvert.SerializeObject(obj));
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Data.Message });
                    }

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:AddOrUpdateServiceSpecialtyRate:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:AddOrUpdateServiceSpecialtyRate:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }
        public async Task<ActionResult> AddServiceSpecialtyRate(List<DO_ServiceSpecialtyRate> obj)
        {
            try
            {
                foreach (var ser_spr in obj)
                {
                    ser_spr.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                    ser_spr.CreatedOn = DateTime.Now;
                    ser_spr.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                    ser_spr.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                }


                var serviceResponse = await _eSyaServicesAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("ServiceRates/AddServiceSpecialtyRate", obj);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Data.Message), "UD:AddServiceSpecialtyRate:params:" + JsonConvert.SerializeObject(obj));
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Data.Message });
                    }

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:AddServiceSpecialtyRate:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:AddServiceSpecialtyRate:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }
        #endregion

        #region ServiceDoctorRate
        /// <summary>
        /// Service Doctor Rate
        /// </summary>
        /// <returns></returns>

        [Area("eSyaServices")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> V_1523_00()
        {
            ViewBag.UserFormRoles = new DO_UserFormRole { IsInsert = true, IsEdit = true, IsDelete = true };
            var serviceResponse = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_BusinessLocation>>("CommonMethod/GetBusinessKey");
            if (serviceResponse.Status)
            {
                if (serviceResponse.Data != null)
                {
                    ViewBag.BusinessKey = serviceResponse.Data.Select(b => new SelectListItem
                    {
                        Value = b.BusinessKey.ToString(),
                        Text = b.LocationDescription,
                    }).ToList();
                }
            }
            else
            {
                _logger.LogError(new Exception(serviceResponse.Message), "UD:V_1523_00:GetBusinessKey");
            }
            var serviceResponse1 = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_ApplicationCode>>("CommonMethod/GetApplicationCodesByCodeType?codetype=62");
            if (serviceResponse1.Status)
            {
                if (serviceResponse1.Data != null)
                {
                    ViewBag.RateType = serviceResponse1.Data.Select(r => new SelectListItem
                    {
                        Value = r.ApplicationCode.ToString(),
                        Text = r.CodeDesc,
                    }).ToList();
                }
            }
            else
            {
                _logger.LogError(new Exception(serviceResponse1.Message), "UD:V_1523_00:GetApplicationCodesByCodeType: CodeType {0} 62");
            }
            var serviceResponse2 = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_CurrencyCode>>("CommonMethod/GetCurrencyCodes");
            if (serviceResponse2.Status)
            {
                if (serviceResponse2.Data != null)
                {
                    ViewBag.CurrencyCode = serviceResponse2.Data.Select(c => new SelectListItem
                    {
                        Value = c.CurrencyCode.ToString(),
                        Text = c.CurrencyName,
                    }).ToList();
                }
            }
            else
            {
                _logger.LogError(new Exception(serviceResponse2.Message), "UD:V_1523_00:GetCurrencyCodes");
            }
            var serviceResponse3 = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_DoctorMaster>>("CommonMethod/GetDoctors");
            if (serviceResponse3.Status)
            {
                if (serviceResponse3.Data != null)
                {
                    ViewBag.Doctors = serviceResponse3.Data.Select(d => new SelectListItem
                    {
                        Value = d.DoctorId.ToString(),
                        Text = d.DoctorName,
                    }).ToList();
                }
            }
            else
            {
                _logger.LogError(new Exception(serviceResponse3.Message), "UD:V_1523_00:GetDoctors");
                return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse3.Message });
            }
            return View();

        }

        /// <summary>
        /// Add Service Doctor Rate
        /// </summary>
        /// <returns></returns>

        [Area("eSyaServices")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> V_1524_00()
        {
            ViewBag.UserFormRoles = new DO_UserFormRole { IsInsert = true, IsEdit = true, IsDelete = true };
            var serviceResponse = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_BusinessLocation>>("CommonMethod/GetBusinessKey");
            if (serviceResponse.Status)
            {
                if (serviceResponse.Data != null)
                {
                    ViewBag.BusinessKey = serviceResponse.Data.Select(b => new SelectListItem
                    {
                        Value = b.BusinessKey.ToString(),
                        Text = b.LocationDescription,
                    }).ToList();
                }
            }
            else
            {
                _logger.LogError(new Exception(serviceResponse.Message), "UD:V_1524_00:GetBusinessKey");
            }
            var serviceResponse1 = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_ApplicationCode>>("CommonMethod/GetApplicationCodesByCodeType?codetype=62");
            if (serviceResponse1.Status)
            {
                if (serviceResponse1.Data != null)
                {
                    ViewBag.RateType = serviceResponse1.Data.Select(r => new SelectListItem
                    {
                        Value = r.ApplicationCode.ToString(),
                        Text = r.CodeDesc,
                    }).ToList();
                }
            }
            else
            {
                _logger.LogError(new Exception(serviceResponse1.Message), "UD:V_1524_00:GetApplicationCodesByCodeType: CodeType {0} 62");
            }
            var serviceResponse2 = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_CurrencyCode>>("CommonMethod/GetCurrencyCodes");
            if (serviceResponse2.Status)
            {
                if (serviceResponse2.Data != null)
                {
                    ViewBag.CurrencyCode = serviceResponse2.Data.Select(c => new SelectListItem
                    {
                        Value = c.CurrencyCode.ToString(),
                        Text = c.CurrencyName,
                    }).ToList();
                }
            }
            else
            {
                _logger.LogError(new Exception(serviceResponse2.Message), "UD:V_1524_00:GetCurrencyCodes");
            }
            var serviceResponse3 = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_DoctorMaster>>("CommonMethod/GetDoctors");
            if (serviceResponse3.Status)
            {
                if (serviceResponse3.Data != null)
                {
                    ViewBag.Doctors = serviceResponse3.Data.Select(d => new SelectListItem
                    {
                        Value = d.DoctorId.ToString(),
                        Text = d.DoctorName,
                    }).ToList();
                }
            }
            else
            {
                _logger.LogError(new Exception(serviceResponse3.Message), "UD:V_1524_00:GetDoctors");
                return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse3.Message });
            }
            return View();

        }

        public async Task<ActionResult> GetServiceDoctorRateByBKeyRateTypeCurrCode(int businessKey, int ratetype, string currencycode, int doctorId)
        {
            try
            {
                var serviceResponse = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_ServiceDoctorRate>>("ServiceRates/GetServiceDoctorRateByBKeyRateTypeCurrCode?businessKey=" + businessKey + "&ratetype=" + ratetype + "&currencycode=" + currencycode + "&doctorId=" + doctorId);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        var ServiceDoctorRate_list = serviceResponse.Data;
                        return Json(ServiceDoctorRate_list);
                    }
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetServiceGetServiceDoctorRateByBKeyRateType:For BusinessKey {0} , RateType {1}, CurrencyCode {2}, DoctorId {3}", businessKey, ratetype, currencycode, doctorId);
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }


            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetServiceGetServiceDoctorRateByBKeyRateType:For BusinessKey {0} , RateType {1}, CurrencyCode {2}, DoctorId {3}", businessKey, ratetype, currencycode, doctorId);
                return Json(new DO_ReturnParameter() { Status = false, Message = ex.Message });
            }
        }
        public async Task<ActionResult> GetServiceDoctorRateByBKeyRateTypeCurrCodeForAdd(int businessKey, int ratetype, string currencycode, int doctorId)
        {
            try
            {
                var serviceResponse = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_ServiceDoctorRate>>("ServiceRates/GetServiceDoctorRateByBKeyRateTypeCurrCodeForAdd?businessKey=" + businessKey + "&ratetype=" + ratetype + "&currencycode=" + currencycode + "&doctorId=" + doctorId);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        var ServiceDoctorRate_list = serviceResponse.Data;
                        return Json(ServiceDoctorRate_list);
                    }
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetServiceGetServiceDoctorRateByBKeyRateTypeForAdd:For BusinessKey {0} , RateType {1}, CurrencyCode {2}, DoctorId {3}", businessKey, ratetype, currencycode, doctorId);
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }


            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetServiceGetServiceDoctorRateByBKeyRateTypeForAdd:For BusinessKey {0} , RateType {1}, CurrencyCode {2}, DoctorId {3}", businessKey, ratetype, currencycode, doctorId);
                return Json(new DO_ReturnParameter() { Status = false, Message = ex.Message });
            }
        }
        public async Task<ActionResult> AddOrUpdateServiceDoctorRate(List<DO_ServiceDoctorRate> obj)
        {
            try
            {
                foreach (var ser_dr in obj)
                {
                    ser_dr.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                    ser_dr.CreatedOn = DateTime.Now;
                    ser_dr.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                    ser_dr.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                }


                var serviceResponse = await _eSyaServicesAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("ServiceRates/AddOrUpdateServiceDoctorRate", obj);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Data.Message), "UD:AddOrUpdateServiceDoctorRate:params:" + JsonConvert.SerializeObject(obj));
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Data.Message });
                    }

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:AddOrUpdateServiceDoctorRate:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:AddOrUpdateServiceDoctorRate:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }
        public async Task<ActionResult> AddServiceDoctorRate(List<DO_ServiceDoctorRate> obj)
        {
            try
            {
                foreach (var ser_spr in obj)
                {
                    ser_spr.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                    ser_spr.CreatedOn = DateTime.Now;
                    ser_spr.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                    ser_spr.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                }


                var serviceResponse = await _eSyaServicesAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("ServiceRates/AddServiceDoctorRate", obj);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Data.Message), "UD:AddServiceDoctorRate:params:" + JsonConvert.SerializeObject(obj));
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Data.Message });
                    }

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:AddServiceDoctorRate:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:AddServiceDoctorRate:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }
        #endregion
    }
}