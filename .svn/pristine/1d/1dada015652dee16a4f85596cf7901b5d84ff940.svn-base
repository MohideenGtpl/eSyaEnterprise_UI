using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eSyaEnterprise_UI.ActionFilter;
using Microsoft.AspNetCore.Mvc;
using eSyaEnterprise_UI.Models;
using eSyaEnterprise_UI.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using eSyaEnterprise_UI.Areas.Pharmacy.Data;
using eSyaEnterprise_UI.Areas.Pharmacy.Models;

namespace eSyaEnterprise_UI.Areas.Pharmacy.Controllers
{
    [SessionTimeout]
    public class DrugVendorController : Controller
    {
        private readonly IPharmacyAPIServices _pharmacyAPIServices;
        private readonly ILogger<DrugVendorController> _logger;

        public DrugVendorController(IPharmacyAPIServices pharmacyAPIServices, ILogger<DrugVendorController> logger)
        {
            _pharmacyAPIServices = pharmacyAPIServices;
            _logger = logger;
        }
        #region Vendor Drug Link
        [Area("Pharmacy")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> ECP_08_00()
        {
            try
            {
                var bk_serviceResponse = await _pharmacyAPIServices.HttpClientServices.GetAsync<List<DO_DrugVendorLink>>("CommonData/GetVendorList");
                var dc_serviceResponse = await _pharmacyAPIServices.HttpClientServices.GetAsync<List<DO_DrugBrand>>("CommonData/GetDrugList");
                if (bk_serviceResponse.Status && dc_serviceResponse.Status)
                {
                    if (bk_serviceResponse.Data != null && dc_serviceResponse.Data != null)
                    {
                        ViewBag.VendorList = bk_serviceResponse.Data.Select(b => new SelectListItem
                        {
                            Value = b.VendorCode.ToString(),
                            Text = b.VendorName.ToString(),
                        }).ToList();

                        ViewBag.DrugList = dc_serviceResponse.Data.Select(b => new SelectListItem
                        {
                            Value = b.DrugCode.ToString(),
                            Text = b.DrugBrand,
                        }).ToList();
                    }
                    else
                    {
                        _logger.LogError(new Exception(bk_serviceResponse.Message), "UD:VendorDrugLink");
                    }
                }
                else
                {
                    _logger.LogError(new Exception(bk_serviceResponse.Message), "UD:VendorDrugLink");
                }
                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:VendorDrugLink");
                throw ex;
            }
        }

        /// <summary>
        ///Get Drug Vendor Link List
        /// </summary>
        [HttpGet]
        public async Task<JsonResult> GetDrugVendorLink(int VendorCode)
        {
            try
            {
                var parameter = "?VendorCode=" + VendorCode;
                var serviceResponse = await _pharmacyAPIServices.HttpClientServices.GetAsync<List<DO_DrugVendorLink>>("DrugBrand/GetDrugVendorLink" + parameter);

                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetDrugVendorLink:For VendorCode {0}", VendorCode);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetDrugVendorLink:For VendorCode {0}", VendorCode);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetDrugVendorLink:For VendorCode {0}", VendorCode);
                throw ex;
            }
        }

        /// <summary>
        /// Insert Into Item Reorder Level
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateVendorDrugLink(DO_DrugVendorLink obj)
        {
            try
            {
                if (string.IsNullOrEmpty(obj.DrugCode.ToString()) || obj.DrugCode == 0)
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select Drug" });
                }
                else if (string.IsNullOrEmpty(obj.VendorCode.ToString()))
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select Vendor" });
                }
                else if (string.IsNullOrEmpty(obj.BusinessShare.ToString()) || obj.BusinessShare == 0)
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Enter Business Share" });
                }
                else if (string.IsNullOrEmpty(obj.MinimumSupplyQty.ToString()) || obj.MinimumSupplyQty == 0)
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Enter Minimum Supply Quantity" });
                }
                else if (string.IsNullOrEmpty(obj.RateType.ToString()))
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select Rate Type" });
                }
                else if (obj.RateType.ToString() == "PO" && (string.IsNullOrEmpty(obj.Rate.ToString()) || obj.Rate == 0))
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Enter Rate" });
                }
                else
                {
                    obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                    obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                    obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext).ToString();
                    obj.ActiveStatus = true;
                    if (string.IsNullOrEmpty(obj.Rate.ToString()))
                        obj.Rate = 0;
                    var serviceResponse = await _pharmacyAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("DrugBrand/InsertOrUpdateVendorDrugLink", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertOrUpdateVendorDrugLink:params:" + JsonConvert.SerializeObject(obj));
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateVendorDrugLink:params:" + JsonConvert.SerializeObject(obj));
                throw ex;
            }
        }
        #endregion
    }
}