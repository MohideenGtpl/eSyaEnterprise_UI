using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using eSyaEnterprise_UI.Areas.Facilities.Data;
using eSyaEnterprise_UI.Areas.Facilities.Models;
using eSyaEnterprise_UI.Utility;
using eSyaEnterprise_UI.ActionFilter;

namespace eSyaEnterprise_UI.Areas.Facilities.Controllers
{
    [SessionTimeout]
    public class ClinicServiceController : Controller
    {
        private readonly IFacilityAPIServices _facilityAPIServices;
        private readonly ILogger<ClinicServiceController> _logger;

        public ClinicServiceController(IFacilityAPIServices facilityAPIServices, ILogger<ClinicServiceController> logger)
        {
            _facilityAPIServices = facilityAPIServices;
            _logger = logger;
        }

        #region ClinicServiceLink

        /// <summary>
        /// Clinic Service Link
        /// </summary>
        /// <returns></returns>

        [Area("Facilities")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> EFM_08_00()
        {
            var serviceResponse = await _facilityAPIServices.HttpClientServices.GetAsync<List<DO_BusinessLocation>>("CommonMethod/GetBusinessKey");
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
                _logger.LogError(new Exception(serviceResponse.Message), "UD:EFM_08:GetBusinessKey");
            }
            var serviceResponse1 = await _facilityAPIServices.HttpClientServices.GetAsync<List<DO_ApplicationCode>>("CommonMethod/GetApplicationCodesByCodeType?codetype=61");
            if (serviceResponse1.Status)
            {
                if (serviceResponse1.Data != null)
                {
                    ViewBag.ClinicType = serviceResponse1.Data.Select(r => new SelectListItem
                    {
                        Value = r.ApplicationCode.ToString(),
                        Text = r.CodeDesc,
                    }).ToList();
                }
            }
            else
            {
                _logger.LogError(new Exception(serviceResponse1.Message), "UD:V_1517_00:GetApplicationCodesByCodeType: CodeType {0} 61");
            }
            var serviceResponse2 = await _facilityAPIServices.HttpClientServices.GetAsync<List<DO_ServiceCode>>("ClinicServices/GetServicesPerformedByDoctor");
            if (serviceResponse2.Status)
            {
                if (serviceResponse2.Data != null)
                {
                    ViewBag.Services = serviceResponse2.Data.Select(s => new SelectListItem
                    {
                        Value = s.ServiceId.ToString(),
                        Text = s.ServiceDesc,
                    }).ToList();
                }
            }
            else
            {
                _logger.LogError(new Exception(serviceResponse2.Message), "UD:V_1517_00:GetServicesPerformedByDoctor");
            }

            return View();

        }

        public async Task<ActionResult> GetClinicServiceLinkByBKey(int businessKey)
        {
            try
            {
                var serviceResponse = await _facilityAPIServices.HttpClientServices.GetAsync<List<DO_ClinicServiceLink>>("ClinicServices/GetClinicServiceLinkByBKey?businessKey=" + businessKey);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        var ClinicServiceLink_list = serviceResponse.Data;
                        return Json(ClinicServiceLink_list);
                    }
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetClinicServiceLinkByBKey:For BusinessKey {0} ", businessKey);
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }


            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetClinicServiceLinkByBKey:For BusinessKey {0} ", businessKey);
                return Json(new DO_ReturnParameter() { Status = false, Message = ex.Message });
            }
        }
        public async Task<ActionResult> GetConsultationTypeByBKeyClinicType(int businessKey, int clinictype)
        {
            try
            {
                var serviceResponse = await _facilityAPIServices.HttpClientServices.GetAsync<List<DO_ApplicationCode>>("ClinicServices/GetConsultationTypeByBKeyClinicType?businessKey=" + businessKey + "&clinictype=" + clinictype);
                var ct_list = new List<DO_ApplicationCode>();
                if (serviceResponse.Status)
                {
                    ct_list = serviceResponse.Data;
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetConsultationTypeByBKeyClinicType: businessKey{0}, clinictype{1}", businessKey, clinictype);
                }




                return Json(ct_list);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetConsultationTypeByBKeyClinicType: businessKey{0}, clinictype{1}", businessKey, clinictype);
                return Json(new DO_ReturnParameter() { Status = false, Message = ex.ToString() });
            }




        }
        public async Task<ActionResult> AddClinicServiceLink(DO_ClinicServiceLink obj)
        {
            try
            {
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                obj.CreatedOn = DateTime.Now;
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

                var serviceResponse = await _facilityAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("ClinicServices/AddClinicServiceLink", obj);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Data.Message), "UD:AddClinicServiceLink:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Data.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:AddClinicServiceLink:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }
        #endregion

        #region Clinic Rate

        /// <summary>
        /// </summary>
        /// <returns></returns>

        [Area("Facilities")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> EFM_09_00()
        {
            var serviceResponse = await _facilityAPIServices.HttpClientServices.GetAsync<List<DO_BusinessLocation>>("CommonMethod/GetBusinessKey");
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
                _logger.LogError(new Exception(serviceResponse.Message), "UD:V_1518_00:GetBusinessKey");
            }
            var serviceResponse1 = await _facilityAPIServices.HttpClientServices.GetAsync<List<DO_ApplicationCode>>("CommonMethod/GetApplicationCodesByCodeType?codetype=61");
            if (serviceResponse1.Status)
            {
                if (serviceResponse1.Data != null)
                {
                    ViewBag.ClinicType = serviceResponse1.Data.Select(r => new SelectListItem
                    {
                        Value = r.ApplicationCode.ToString(),
                        Text = r.CodeDesc,
                    }).ToList();
                }
            }
            else
            {
                _logger.LogError(new Exception(serviceResponse1.Message), "UD:V_1518_00:GetApplicationCodesByCodeType: CodeType {0} 61");
            }
            var serviceResponse2 = await _facilityAPIServices.HttpClientServices.GetAsync<List<DO_CurrencyCode>>("CommonMethod/GetCurrencyCodes");
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
                _logger.LogError(new Exception(serviceResponse2.Message), "UD:V_1518_00:GetCurrencyCodes");
            }
            var serviceResponse3 = await _facilityAPIServices.HttpClientServices.GetAsync<List<DO_ApplicationCode>>("CommonMethod/GetApplicationCodesByCodeType?codetype=62");
            if (serviceResponse3.Status)
            {
                if (serviceResponse3.Data != null)
                {
                    ViewBag.RateType = serviceResponse3.Data.Select(r => new SelectListItem
                    {
                        Value = r.ApplicationCode.ToString(),
                        Text = r.CodeDesc,
                    }).ToList();
                }
            }
            else
            {
                _logger.LogError(new Exception(serviceResponse1.Message), "UD:V_1518_00:GetApplicationCodesByCodeType: CodeType {0} 62");
            }

            return View();

        }

        public async Task<ActionResult> GetClinicVisitRateByBKeyClinicTypeCurrCodeRateType(int businessKey, int clinictype, string currencycode, int ratetype)
        {
            try
            {
                var serviceResponse = await _facilityAPIServices.HttpClientServices.GetAsync<List<DO_ClinicVisitRate>>("ClinicServices/GetClinicVisitRateByBKeyClinicTypeCurrCodeRateType?businessKey=" + businessKey + "&clinictype=" + clinictype + "&currencycode=" + currencycode + "&ratetype=" + ratetype);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        var ClinicVisitRate_list = serviceResponse.Data;
                        return Json(ClinicVisitRate_list);
                    }
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetClinicVisitRateByBKeyClinicTypeCurrCode:For BusinessKey {0} , ClinicType {1}, CurrencyCode {2} , RateType {3}", businessKey, clinictype, currencycode, ratetype);
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }


            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetClinicVisitRateByBKeyClinicTypeCurrCode:For BusinessKey {0} , ClinicType {1}, CurrencyCode {2} , RateType {3}", businessKey, clinictype, currencycode, ratetype);
                return Json(new DO_ReturnParameter() { Status = false, Message = ex.Message });
            }
        }
        public async Task<ActionResult> AddOrUpdateClinicVisitRate(List<DO_ClinicVisitRate> obj)
        {
            try
            {
                foreach (var c_visitrate in obj)
                {
                    c_visitrate.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                    c_visitrate.CreatedOn = DateTime.Now;
                    c_visitrate.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                    c_visitrate.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                }


                var serviceResponse = await _facilityAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("ClinicServices/AddOrUpdateClinicVisitRate", obj);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Data.Message), "UD:AddOrUpdateClinicVisitRate:params:" + JsonConvert.SerializeObject(obj));
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Data.Message });
                    }

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:AddOrUpdateClinicVisitRate:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:AddOrUpdateClinicVisitRate:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }
        #endregion
    }
}