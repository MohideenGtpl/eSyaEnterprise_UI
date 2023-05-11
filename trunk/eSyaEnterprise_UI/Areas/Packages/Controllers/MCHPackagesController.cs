using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eSyaEnterprise_UI.ActionFilter;
using eSyaEnterprise_UI.Areas.Packages.Data;
using eSyaEnterprise_UI.Areas.Packages.Models;
using eSyaEnterprise_UI.Models;
using eSyaEnterprise_UI.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace eSyaEnterprise_UI.Areas.Packages.Controllers
{
    [SessionTimeout]
    public class MCHPackagesController : Controller
    {
        private readonly IeSyaPackagesAPIServices _eSyaPackagesAPIServices;
        private readonly ILogger<MCHPackagesController> _logger;
        public MCHPackagesController(IeSyaPackagesAPIServices eSyaPackagesAPIServices, ILogger<MCHPackagesController> logger)
        {
            _eSyaPackagesAPIServices = eSyaPackagesAPIServices;
            _logger = logger;
        }

        [Area("Packages")]
        public async Task<IActionResult> EPK_01_00()
        {
            ViewBag.UserFormRoles = new DO_UserFormRole { IsInsert = true, IsEdit = true, IsDelete = true };
            
            var serviceResponse = await _eSyaPackagesAPIServices.HttpClientServices.GetAsync<List<DO_BusinessLocation>>("PackageMaster/GetBusinessKey");
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
                _logger.LogError(new Exception(serviceResponse.Message), "UD:EPK_01_00:GetBusinessKey");
            }
            var serviceResponse1 = await _eSyaPackagesAPIServices.HttpClientServices.GetAsync<List<DO_ApplicationCode>>("PackageMaster/GetPatientTypes");
            if (serviceResponse1.Status)
            {
                if (serviceResponse1.Data != null)
                {
                    ViewBag.PatientType = serviceResponse1.Data.Select(r => new SelectListItem
                    {
                        Value = r.ApplicationCode.ToString(),
                        Text = r.CodeDesc,
                    }).ToList();
                }
            }
            else
            {
                _logger.LogError(new Exception(serviceResponse1.Message), "UD:EPK_01_00:GetPatientTypes");
            }
            var serviceResponse2 = await _eSyaPackagesAPIServices.HttpClientServices.GetAsync<List<DO_CurrencyCode>>("PackageMaster/GetCurrencyCodes");
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
                _logger.LogError(new Exception(serviceResponse2.Message), "UD:EPK_01_00:GetCurrencyCodes");
            }
            var serviceResponse3 = await _eSyaPackagesAPIServices.HttpClientServices.GetAsync<List<DO_Customer>>("PackageMaster/GetCustomers");
            if (serviceResponse3.Status)
            {
                if (serviceResponse3.Data != null)
                {
                    ViewBag.Customers = serviceResponse3.Data.Select(c => new SelectListItem
                    {
                        Value = c.CustomerId.ToString(),
                        Text = c.CustomerName,
                    }).ToList();
                }
            }
            else
            {
                _logger.LogError(new Exception(serviceResponse3.Message), "UD:EPK_01_00:GetCustomers");
            }
            var serviceResponse4 = await _eSyaPackagesAPIServices.HttpClientServices.GetAsync<List<DO_ApplicationCode>>("PackageMaster/GetPackages");
            if (serviceResponse4.Status)
            {
                if (serviceResponse4.Data != null)
                {
                    ViewBag.Packages = serviceResponse4.Data.Select(c => new SelectListItem
                    {
                        Value = c.ApplicationCode.ToString(),
                        Text = c.CodeDesc,
                    }).ToList();
                }
            }
            else
            {
                _logger.LogError(new Exception(serviceResponse4.Message), "UD:EPK_01_00:GetPackages");
            }

            

            return View();

        }

        public async Task<IActionResult> GetPackageMaster(int businessKey, int customerId, string currencyCode)
        {
            try
            {
                var parameter = "?businessKey=" + businessKey;
                parameter += "&customerId=" + customerId.ToString();
                parameter += "&currencyCode=" + currencyCode.ToString();
                var serviceResponse = await _eSyaPackagesAPIServices.HttpClientServices.GetAsync<List<DO_PackageMaster>>("PackageMaster/GetPackageMaster" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetPackageMaster:params: businessKey:{0},cumstomerId:{1},currencyCode:{2}" ,businessKey , customerId , currencyCode );
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetPackageMaster:params: businessKey:{0},cumstomerId:{1},currencyCode:{2}", businessKey, customerId, currencyCode);
                throw ex;
            }


        }

        public async Task<IActionResult> GetPackageServices(int businessKey,string currencyCode)
        {
            try
            {
                var parameter = "?businessKey=" + businessKey;
                parameter += "&currencyCode=" + currencyCode;
                var serviceResponse = await _eSyaPackagesAPIServices.HttpClientServices.GetAsync<List<DO_PackageService>>("PackageMaster/GetPackageServices" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetPackageServices:params: businessKey:{0},currencyCode:{1}", businessKey,currencyCode);
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
               _logger.LogError(new Exception(ex.Message), "UD:GetPackageServices:params: businessKey:{0},currencyCode:{1}", businessKey,currencyCode);
                throw ex;
            }
        }

        [HttpPost]
        public async Task<JsonResult> AddOrUpdatePackageMaster(DO_PackageMaster obj)
        {
            try
            {
                
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

                var serviceResponse = await _eSyaPackagesAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("PackageMaster/AddOrUpdatePackageMaster", obj);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data.Status)
                        return Json(new { Status = true, key = serviceResponse.Data.Key, serviceResponse.Data.Warning, serviceResponse.Data.WarningMessage });
                    else
                        return Json(new { Status = false, serviceResponse.Data.Warning, serviceResponse.Data.WarningMessage, serviceResponse.Data.Message });
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:AddOrUpdatePackageMaster:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:AddOrUpdatePackageMaster:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Warning = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
            }
        }


    }
}