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
    public class DrugAttributesController : Controller
    {
        private readonly IPharmacyAPIServices _pharmacyAPIServices;
        private readonly ILogger<DrugAttributesController> _logger;

        public DrugAttributesController(IPharmacyAPIServices pharmacyAPIServices, ILogger<DrugAttributesController> logger)
        {
            _pharmacyAPIServices = pharmacyAPIServices;
            _logger = logger;
        }

        #region Drug Re-order Level
        [Area("Pharmacy")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> ECP_06_00()
        {
            try
            {
                var bk_serviceResponse = await _pharmacyAPIServices.HttpClientServices.GetAsync<List<DO_BusinessLocation>>("CommonData/GetBusinessKey");

                if (bk_serviceResponse.Status)
                {
                    if (bk_serviceResponse.Data != null)
                    {
                        ViewBag.BusinessKeyList = bk_serviceResponse.Data.Select(b => new SelectListItem
                        {
                            Value = b.BusinessKey.ToString(),
                            Text = b.LocationDescription.ToString(),
                        }).ToList();
                    }
                    else
                    {
                        _logger.LogError(new Exception(bk_serviceResponse.Message), "UD:DrugReorderLevel");
                    }
                }
                else
                {
                    _logger.LogError(new Exception(bk_serviceResponse.Message), "UD:DrugReorderLevel");
                }
                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:DrugReorderLevel");
                throw ex;
            }
        }

        /// <summary>
        ///Get Store List by Business Key
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetStoreListByBusinessKey(int BusinessKey)
        {
            try
            {
                var parameter = "?BusinessKey=" + BusinessKey;
                var serviceResponse = await _pharmacyAPIServices.HttpClientServices.GetAsync<List<DO_StoreMaster>>("CommonData/GetStoreListByBusinessKey" + parameter);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetStoreListByBusinessKey:For BusinessKey {0}", BusinessKey);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetStoreListByBusinessKey:For BusinessKey {0}", BusinessKey);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetStoreListByBusinessKey:For BusinessKey {0}", BusinessKey);
                throw ex;
            }
        }

        /// <summary>
        ///Get Item Reorder Level
        /// </summary>
        [HttpGet]
        public async Task<JsonResult> GetDrugReorderLevel(int BusinessKey, int StoreCode)
        {
            try
            {
                var parameter = "?BusinessKey=" + BusinessKey + "&StoreCode=" + StoreCode;
                var serviceResponse = await _pharmacyAPIServices.HttpClientServices.GetAsync<List<DO_DrugReorderLevel>>("DrugBrand/GetDrugReorderLevel" + parameter);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetDrugReorderLevel:For BusinessKey {0} and with StoreCode {1}", BusinessKey, StoreCode);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetDrugReorderLevel:For BusinessKey {0} and with StoreCode {1}", BusinessKey, StoreCode);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetDrugReorderLevel:For BusinessKey {0} and with StoreCode {1}", BusinessKey, StoreCode);
                throw ex;
            }
        }

        /// <summary>
        /// Insert Into Item Reorder Level
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateDrugReorderLevel(List<DO_DrugReorderLevel> bu_bd)
        {
            try
            {
                bu_bd.All(c =>
                {
                    c.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                    c.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                    c.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext).ToString();
                    return true;
                });

                foreach (var sd in bu_bd.Where(w => !String.IsNullOrEmpty(w.DrugBrand)))
                {
                    if (sd.BusinessKey == 0 || string.IsNullOrEmpty(sd.BusinessKey.ToString()))
                    {
                        return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select Business Location" });
                    }
                    else if (sd.StoreCode == 0 || string.IsNullOrEmpty(sd.StoreCode.ToString()))
                    {
                        return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select Store" });
                    }
                    else if (sd.SafetyStockLevel != 0 && sd.MinimumStockLevel != 0 && sd.MaximumStockLevel != 0 && sd.ReorderLevel != 0)
                    {
                        if (sd.SafetyStockLevel > sd.MinimumStockLevel)
                        {
                            return Json(new DO_ReturnParameter() { Status = false, Message = "Safety Stock Should Not Be Greater Than Minimum Stock for " + sd.DrugBrand });
                        }
                        else if (sd.MinimumStockLevel > sd.ReorderLevel)
                        {
                            return Json(new DO_ReturnParameter() { Status = false, Message = "Minimum Stock Should Not Be Greater Than ROL Stock for " + sd.DrugBrand });
                        }
                        else if (sd.ReorderLevel > sd.MaximumStockLevel)
                        {
                            return Json(new DO_ReturnParameter() { Status = false, Message = "Reorder Level Stock Should Not Be Greater Than Maximum Stock for " + sd.DrugBrand });
                        }
                    }
                }

                var serviceResponse = await _pharmacyAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("DrugBrand/InsertOrUpdateDrugReorderLevel", bu_bd);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertOrUpdateDrugReorderLevel:params:" + JsonConvert.SerializeObject(bu_bd));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateDrugReorderLevel:params:" + JsonConvert.SerializeObject(bu_bd));
                throw ex;
            }
        }
        #endregion

        #region Drug Bin Info
        [Area("Pharmacy")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> ECP_07_00()
        {
            try
            {
                var bk_serviceResponse = await _pharmacyAPIServices.HttpClientServices.GetAsync<List<DO_BusinessLocation>>("CommonData/GetBusinessKey");

                if (bk_serviceResponse.Status)
                {
                    if (bk_serviceResponse.Data != null)
                    {
                        ViewBag.BusinessKeyList = bk_serviceResponse.Data.Select(b => new SelectListItem
                        {
                            Value = b.BusinessKey.ToString(),
                            Text = b.LocationDescription.ToString(),
                        }).ToList();
                    }
                    else
                    {
                        _logger.LogError(new Exception(bk_serviceResponse.Message), "UD:DrugBinInfo");
                    }
                }
                else
                {
                    _logger.LogError(new Exception(bk_serviceResponse.Message), "UD:DrugBinInfo");
                }
                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:DrugBinInfo");
                throw ex;
            }
        }

        /// <summary>
        ///Get Item Reorder Level
        /// </summary>
        [HttpGet]
        public async Task<JsonResult> GetDrugBinInfo(int BusinessKey, int StoreCode)
        {
            try
            {
                var parameter = "?BusinessKey=" + BusinessKey + "&StoreCode=" + StoreCode;
                var serviceResponse = await _pharmacyAPIServices.HttpClientServices.GetAsync<List<DO_DrugBinInfo>>("DrugBrand/GetDrugBinInfo" + parameter);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetDrugBinInfo:For BusinessKey {0} and with StoreCode {1}", BusinessKey, StoreCode);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetDrugBinInfo:For BusinessKey {0} and with StoreCode {1}", BusinessKey, StoreCode);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetDrugBinInfo:For BusinessKey {0} and with StoreCode {1}", BusinessKey, StoreCode);
                throw ex;
            }
        }

        /// <summary>
        /// Insert Into Item Reorder Level
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateDrugBinInfo(List<DO_DrugBinInfo> dr_bi)
        {
            try
            {
                dr_bi.All(c =>
                {
                    c.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                    c.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                    c.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext).ToString();
                    return true;
                });

                foreach (var sd in dr_bi.Where(w => !String.IsNullOrEmpty(w.BinInfo)))
                {
                    if (sd.BusinessKey == 0 || string.IsNullOrEmpty(sd.BusinessKey.ToString()))
                    {
                        return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select Business Location" });
                    }
                    else if (sd.StoreCode == 0 || string.IsNullOrEmpty(sd.StoreCode.ToString()))
                    {
                        return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select Store" });
                    }
                }

                var serviceResponse = await _pharmacyAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("DrugBrand/InsertOrUpdateDrugBinInfo", dr_bi);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertOrUpdateDrugBinInfo:params:" + JsonConvert.SerializeObject(dr_bi));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateDrugBinInfo:params:" + JsonConvert.SerializeObject(dr_bi));
                throw ex;
            }
        }
        #endregion
    }
}