﻿using System;
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
    public class ConfigureDrugController : Controller
    {
        private readonly IPharmacyAPIServices _pharmacyAPIServices;
        private readonly ILogger<ConfigureDrugController> _logger;

        public ConfigureDrugController(IPharmacyAPIServices pharmacyAPIServices, ILogger<ConfigureDrugController> logger)
        {
            _pharmacyAPIServices = pharmacyAPIServices;
            _logger = logger;
        }

        #region Drug Manufacturers
        [Area("Pharmacy")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> ECP_01_00()
        {
            try
            {
                var serviceResponse = await _pharmacyAPIServices.HttpClientServices.GetAsync<List<DO_CountryCodes>>("CommonData/GetISDCodes");
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        ViewBag.ISDCodeList = serviceResponse.Data.Select(b => new SelectListItem
                        {
                            Value = b.Isdcode.ToString(),
                            Text = b.Isdcode.ToString() + " - " + b.CountryName
                        }).ToList();
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:DrugManufacturers");
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:DrugManufacturers");
                }
                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:DrugManufacturers");
                throw ex;
            }
        }

        /// <summary>
        ///Get Manufacturer Information 
        /// </summary>
        [HttpGet]
        public async Task<JsonResult> GetManufacturerListByNamePrefix(string manufacturerNamePrefix)
        {
            try
            {
                var serviceResponse = await _pharmacyAPIServices.HttpClientServices.GetAsync<List<DO_DrugManufacturer>>("DrugManufacturer/GetManufacturerListByNamePrefix?manufacturerNamePrefix=" + manufacturerNamePrefix);
                return Json(serviceResponse.Data);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetManufacturerListByNamePrefix:For Prefix {0}", manufacturerNamePrefix);
                throw ex;
            }
        }

        /// <summary>
        /// Insert or Update Manufacturer
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateManufacturer(DO_DrugManufacturer drugManufacturer)
        {
            try
            {
                if (string.IsNullOrEmpty(drugManufacturer.ManufacturerName))
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Enter Manufacturer Name" });
                }
                else if (string.IsNullOrEmpty(drugManufacturer.ManfShortName))
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Enter Manufacturer Short Name" });
                }
                else if (string.IsNullOrEmpty(drugManufacturer.OriginCode))
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select Origin" });
                }
                else if (drugManufacturer.OriginCode == "MK" && string.IsNullOrEmpty(drugManufacturer.MarketedBy))
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select Marketed By" });
                }
                else if (string.IsNullOrEmpty(drugManufacturer.ISDCode.ToString()) || drugManufacturer.ISDCode == 0)
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select ISD Code" });
                }
                else
                {
                    drugManufacturer.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                    drugManufacturer.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                    drugManufacturer.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);

                    var serviceResponse = await _pharmacyAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("DrugManufacturer/InsertOrUpdateManufacturer", drugManufacturer);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertOrUpdateManufacturer:params:" + JsonConvert.SerializeObject(drugManufacturer));
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateManufacturer:params:" + JsonConvert.SerializeObject(drugManufacturer));
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }
        #endregion

        #region Drug Categories
        [Area("Pharmacy")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> ECP_02_00()
        {
            try
            {
                //int dc_ctype = CodeTypeValues.DrugClassification;
                //var pu_serviceResponse = await _eSyaPharmaAPIServices.HttpClientServices.GetAsync<List<DO_ApplicationCodes>>("CommonData/GetApplicationCodesByCodeType?codeType=" + dc_ctype);

                List<int> l_ac = new List<int>();
                l_ac.Add(CodeTypeValues.DrugClassification);
                l_ac.Add(CodeTypeValues.PharmacyGroup);

                var response = await _pharmacyAPIServices.HttpClientServices.PostAsJsonAsync<List<DO_ApplicationCodes>>("CommonData/GetApplicationCodesByCodeTypeList", l_ac);

                if (response.Status)
                {
                    if (response.Data != null)
                    {
                        List<DO_ApplicationCodes> app_codes = response.Data;

                        ViewBag.DrugClassList = app_codes.Where(w => w.CodeType == CodeTypeValues.DrugClassification).Select(b => new SelectListItem
                        {
                            Value = b.ApplicationCode.ToString(),
                            Text = b.CodeDesc,
                        }).ToList();

                        ViewBag.PharmacyGroupList = app_codes.Where(w => w.CodeType == CodeTypeValues.PharmacyGroup).Select(b => new SelectListItem
                        {
                            Value = b.ApplicationCode.ToString(),
                            Text = b.CodeDesc,
                        }).ToList();
                    }
                    else
                    {
                        _logger.LogError(new Exception(response.Message), "UD:DrugCategory");
                    }
                }
                else
                {
                    _logger.LogError(new Exception(response.Message), "UD:DrugCategory");
                }
                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:DrugCategory");
                throw ex;
            }
        }

        /// <summary>
        ///Get Drug Category Information 
        /// </summary>
        [HttpGet]
        public async Task<JsonResult> GetDrugCategoryListByNamePrefix(string drugCategoryPrefix)
        {
            try
            {
                var serviceResponse = await _pharmacyAPIServices.HttpClientServices.GetAsync<List<DO_DrugCategory>>("DrugCategory/GetDrugCategoryListByNamePrefix?drugCategoryPrefix=" + drugCategoryPrefix);
                return Json(serviceResponse.Data);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetDrugCategoryListByNamePrefix:For Prefix {0}", drugCategoryPrefix);
                throw ex;
            }
        }

        /// <summary>
        /// Insert or Update Drug Category
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateDrugCategory(DO_DrugCategory drugCategory)
        {
            try
            {
                if (string.IsNullOrEmpty(drugCategory.GenericDesc))
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Enter Generic" });
                }
                else if (string.IsNullOrEmpty(drugCategory.DrugClassId.ToString()) || drugCategory.DrugClassId == 0)
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select Drug Class Id" });
                }
                else if (string.IsNullOrEmpty(drugCategory.PharmacyGroup.ToString()) || drugCategory.PharmacyGroup == 0)
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select Pharmacy Group" });
                }
                else
                {
                    drugCategory.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                    drugCategory.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                    drugCategory.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);

                    var serviceResponse = await _pharmacyAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("DrugCategory/InsertOrUpdateDrugCategory", drugCategory);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertOrUpdateDrugCategory:params:" + JsonConvert.SerializeObject(drugCategory));
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateDrugCategory:params:" + JsonConvert.SerializeObject(drugCategory));
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }
        #endregion

        #region Drug Formulation
        [Area("Pharmacy")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> ECP_03_00()
        {
            try
            {
                var pu_serviceResponse = await _pharmacyAPIServices.HttpClientServices.GetAsync<List<DO_DrugCategory>>("DrugCategory/GetDrugCategory");

                List<int> l_ac = new List<int>();
                l_ac.Add(CodeTypeValues.Dosage);
                l_ac.Add(CodeTypeValues.DrugForm);

                var response = await _pharmacyAPIServices.HttpClientServices.PostAsJsonAsync<List<DO_ApplicationCodes>>("CommonData/GetApplicationCodesByCodeTypeList", l_ac);

                if (pu_serviceResponse.Status && response.Status)
                {
                    if (pu_serviceResponse.Data != null && response.Data != null)
                    {
                        List<DO_ApplicationCodes> app_codes = response.Data;

                        ViewBag.DrugCategoryList = pu_serviceResponse.Data.Select(b => new SelectListItem
                        {
                            Value = b.GenericId.ToString(),
                            Text = b.GenericDesc,
                        }).ToList();

                        ViewBag.DosageList = app_codes.Where(w => w.CodeType == CodeTypeValues.Dosage).Select(b => new SelectListItem
                        {
                            Value = b.ApplicationCode.ToString(),
                            Text = b.CodeDesc,
                        }).ToList();

                        ViewBag.DrugFormList = app_codes.Where(w => w.CodeType == CodeTypeValues.DrugForm).Select(b => new SelectListItem
                        {
                            Value = b.ApplicationCode.ToString(),
                            Text = b.CodeDesc,
                        }).ToList();
                    }
                    else
                    {
                        _logger.LogError(new Exception(pu_serviceResponse.Message), "UD:DrugFormulation");
                    }
                }
                else
                {
                    _logger.LogError(new Exception(pu_serviceResponse.Message), "UD:DrugFormulation");
                }
                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:DrugFormulation");
                throw ex;
            }
        }

        /// <summary>
        ///Get Generic Details
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> GetGenericDetails(int drugCategory)
        {
            try
            {
                var parameter = "?drugCategory=" + drugCategory;
                var serviceResponse = await _pharmacyAPIServices.HttpClientServices.GetAsync<DO_DrugCategory>("CommonData/GetGenericDetails" + parameter);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetGenericDetails:For drugCategory {0}", drugCategory);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetGenericDetails:For drugCategory {0}", drugCategory);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetGenericDetails:For drugCategory {0}", drugCategory);
                throw ex;
            }
        }

        /// <summary>
        ///Get Drug Category Information 
        /// </summary>
        [HttpGet]
        public async Task<JsonResult> GetDrugFormulationListByNamePrefix(string drugFormulationPrefix)
        {
            try
            {
                var serviceResponse = await _pharmacyAPIServices.HttpClientServices.GetAsync<List<DO_DrugFormulation>>("DrugFormulation/GetDrugFormulationListByNamePrefix?drugFormulationPrefix=" + drugFormulationPrefix);
                return Json(serviceResponse.Data);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetDrugFormulationListByNamePrefix:For Prefix {0}", drugFormulationPrefix);
                throw ex;
            }
        }

        /// <summary>
        /// Insert or Update Drug Category
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateDrugFormulation(DO_DrugFormulation obj)
        {
            try
            {
                if (obj.GenericId == 0 || string.IsNullOrEmpty(obj.GenericId.ToString()))
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select Generics" });
                }
                else if (string.IsNullOrEmpty(obj.DrugFormulation))
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Enter Drug Frmulation" });
                }
                else if (string.IsNullOrEmpty(obj.Dosage.ToString()) || obj.Dosage == 0)
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select Dosage" });
                }
                else if (string.IsNullOrEmpty(obj.DrugForm.ToString()) || obj.DrugForm == 0)
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select Drug Form" });
                }
                else
                {
                    obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                    obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                    obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);

                    var serviceResponse = await _pharmacyAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("DrugFormulation/InsertOrUpdateDrugFormulation", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertOrUpdateDrugFormulation:params:" + JsonConvert.SerializeObject(obj));
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateDrugFormulation:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }
        #endregion
    }
}