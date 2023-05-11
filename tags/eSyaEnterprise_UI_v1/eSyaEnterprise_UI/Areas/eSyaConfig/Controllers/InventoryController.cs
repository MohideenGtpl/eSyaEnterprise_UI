﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using eSyaEnterprise_UI.Areas.Config.Models;
using eSyaEnterprise_UI.Models;
using eSyaEnterprise_UI.Utility;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using eSyaEnterprise_UI.Areas.Config.Data;
using eSyaEnterprise_UI.ActionFilter;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

namespace eSyaEnterprise_UI.Areas.Config.Controllers
{
    [SessionTimeout]
    public class InventoryController : Controller
    {
        private readonly IeSyaConfigAPIServices _eSyaConfigAPIServices;
        private readonly ILogger<InventoryController> _logger;

        public InventoryController(IeSyaConfigAPIServices eSyaConfigAPIServices, ILogger<InventoryController> logger)
        {
            _eSyaConfigAPIServices = eSyaConfigAPIServices;
            _logger = logger;
        }
        

        #region Store Master
        //Store Master
        [Area("eSyaConfig")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult V_41_00()
        {
            return View();
        }
        /// <summary>
        /// Get Store Codes List for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetStoreCodes()
        {
            try
            {
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_StoreMaster>>("StoreMaster/GetStoreCodes");
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetStoreCodes");
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetStoreCodes");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetStoreCodes");
                throw ex;
            }
        }

        /// <summary>
        /// Get Store parameter
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetStoreParameterList(int StoreCode)
        {
            try
            {
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<DO_StoreMaster>("StoreMaster/GetStoreParameterList?StoreCode=" + StoreCode);

                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetStoreParameterList:For StoreCode {0}", StoreCode);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetStoreParameterList:For StoreCode {0}", StoreCode);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetStoreParameterList:For StoreCode {0}", StoreCode);
                throw ex;
            }
        }

        /// <summary>
        /// Insert or Update Store Codes
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateStoreCodes(DO_StoreMaster storecodes)
        {
            try
            {
                if (string.IsNullOrEmpty(storecodes.StoreType))
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select Store Type" });
                }
                else if (string.IsNullOrEmpty(storecodes.StoreDesc))
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Enter Store Description" });
                }
                else
                {
                    storecodes.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                    storecodes.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                    storecodes.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);

                    var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("StoreMaster/InsertOrUpdateStoreCodes", storecodes);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertOrUpdateStoreCodes:params:" + JsonConvert.SerializeObject(storecodes));
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateStoreCodes:params:" + JsonConvert.SerializeObject(storecodes));
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }
        /// <summary>
        /// Delete Store Codes
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> DeleteStoreCode(int StoreCode)
        {
            try
            {
                if (StoreCode == 0)
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select Store" });
                }
                else
                {
                    var parameter = "?StoreCode=" + StoreCode;
                    var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("StoreMaster/DeleteStoreCode" + parameter);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:DeleteStoreCode:For StoreCode {0}", StoreCode);
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:DeleteStoreCode:For StoreCode {0}", StoreCode);
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }

        /// <summary>
        /// Activate or De Activate Store Code
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> ActiveOrDeActiveStoreCode(bool status, string storetype,int storecode)
        {

            try
            {

                var parameter = "?status=" + status + "&storetype=" + storetype + "&storecode=" + storecode;
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("StoreMaster/ActiveOrDeActiveStoreCode" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ActiveOrDeActiveStoreCode:For storecode {0} ", storecode);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        #region Store_Form_Link

        //Store Master
        [Area("eSyaConfig")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult ESF_46_00()
        {
            return View();
        }

        public JsonResult GetFormForStorelinking()
        {
            try
            {
                List<jsTreeObject> treeView = new List<jsTreeObject>();

                jsTreeObject jsObj = new jsTreeObject
                {
                    id = "FM",
                    parent = "#",
                    text = "eSya Forms",
                    icon = "/images/jsTree/foldergroupicon.png",
                    state = new stateObject { opened = true, selected = false }
                };
                treeView.Add(jsObj);

                var serviceResponse1 = _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_Forms>>("StoreMaster/GetFormForStorelinking").Result;
                if (serviceResponse1.Status)
                {
                    foreach (var fm in serviceResponse1.Data)
                    {
                        jsObj = new jsTreeObject
                        {
                            id = fm.FormID.ToString(),
                            text = fm.FormCode.ToString() + '.' + fm.FormName,
                            icon = "/images/jsTree/openfolder.png",
                            parent = "FM"
                        };
                        treeView.Add(jsObj);
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse1.Message), "UD:GetFormList");
                }

                return Json(treeView);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetFormList");
                throw ex;
            }
        }


        public JsonResult GetFormForStorelinkin1g()
        {
            try
            {
                var serviceResponse = _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_StoreFormLink>>("StoreMaster/GetFormForStorelinking").Result;
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetFormForStorelinking");
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetFormForStorelinking");
                throw ex;
            }
        }

        public JsonResult GetStoreFormLinked(int formId)
        {
            try
            {
                var serviceResponse = _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_StoreMaster>>("StoreMaster/GetStoreFormLinked?formId=" + formId).Result;
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetStoreFormLinked:params:formId:"+ formId.ToString());
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetStoreFormLinked:params:formId:" + formId.ToString());
                throw ex;
            }
        }

        [HttpPost]
        public JsonResult InsertIntoFormStoreLink(List<DO_StoreFormLink> l_obj)
        {
            try
            {
                if (l_obj.Count == 0)
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "No Record" });
                }
                else
                {
                    l_obj.All(c =>
                    {
                        c.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                        c.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                        return true;
                    });

                    var serviceResponse = _eSyaConfigAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("StoreMaster/InsertIntoFormStoreLink", l_obj).Result;
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                    {
                        _logger.LogError(serviceResponse.Message, "UD:InsertIntoFormStoreLink:Params:" + JsonConvert.SerializeObject(l_obj));
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertIntoFormStoreLink:Params:" + JsonConvert.SerializeObject(l_obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        #endregion  Store_Form_Link

        #endregion Store Master

        #region Inventory Rules
        //Inventory Rules
        [Area("eSyaConfig")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult V_42_00()
        {
            
            return View();
        }

        /// <summary>
        /// Getting Inventory Rules for Grid
        /// </summary>

        [HttpPost]
        public async Task<JsonResult> GetInventoryRules()
        {
            try
            {
                var serviceResponse =await _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_InventoryRules>>("InventoryRules/GetInventoryRules");
                if (serviceResponse.Status)
                {
                    
                   return Json(serviceResponse.Data);
                   
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetInventoryRules");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetInventoryRules");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Insert or Update Inventory Rules
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateInventoryRules(DO_InventoryRules rule)
        {

            try
            {
                rule.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                rule.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                rule.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                if (rule.Isadd == 1)
                {

                    var serviceResponse =await _eSyaConfigAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("InventoryRules/InsertInventoryRule", rule);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

                else
                {
                    var serviceResponse =await _eSyaConfigAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("InventoryRules/UpdateInventoryRule", rule);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateInventoryRules:params:" + JsonConvert.SerializeObject(rule));
                return Json(new { Status = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
            }
        }
        /// <summary>
        /// Activate or De Activate Inventory Rules
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> ActiveOrDeActiveInventoryRules(bool status, string InventoryId)
        {

            try
            {

                var parameter = "?status=" + status + "&InventoryId=" + InventoryId ;
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("InventoryRules/ActiveOrDeActiveInventoryRules" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ActiveOrDeActiveInventoryRules:For InventoryId {0} ", InventoryId);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        #endregion Inventory Rules

        #region Unit of Measure
        //Unit of Measure
        [Area("eSyaConfig")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult V_43_00()
        {
            
            return View();
        }

        /// <summary>
        /// Getting Unit Measure List for Grid
        /// </summary>

        [HttpPost]
        public async Task<JsonResult> GetUnitofMeasurements()
        {
            try
            {
                var serviceResponse =await _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_UnitofMeasure>>("UnitofMeasure/GetUnitofMeasurements");
                if (serviceResponse.Status)
                {
                    
                   return Json(serviceResponse.Data);
                   
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetUnitofMeasurements");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetUnitofMeasurements");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Insert or Update Unite of Measure
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateUnitofMeasurement(DO_UnitofMeasure uoms)
        {

            try
            {
                uoms.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                uoms.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                uoms.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                var serviceResponse =await _eSyaConfigAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("UnitofMeasure/InsertOrUpdateUnitofMeasurement", uoms);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertIntoCurrencyMaster:params:" + JsonConvert.SerializeObject(uoms));
                return Json(new { Status = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
            }
        }

        /// <summary>
        ///Get Unit of Measure Purchase description by UOMP Code
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetUOMPDescriptionbyUOMP(string uomp)
        {
            try
            {
                var parameter = "?uomp=" + uomp;
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<DO_UnitofMeasure>("UnitofMeasure/GetUOMPDescriptionbyUOMP" + parameter);

                if (serviceResponse.Status)
                {
                   return Json(serviceResponse.Data);
                    
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetUOMPDescriptionbyUOMP:For uomp {0}", uomp);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetUOMPDescriptionbyUOMP:For uomp {0}", uomp);
                throw ex;
            }
        }

        /// <summary>
        ///Get Unit of Measure Stock description by UOMS Code
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetUOMSDescriptionbyUOMS(string uoms)
        {
            try
            {
                var parameter = "?uoms=" + uoms;
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<DO_UnitofMeasure>("UnitofMeasure/GetUOMSDescriptionbyUOMS" + parameter);

                if (serviceResponse.Status)
                {
                   return Json(serviceResponse.Data);
                   
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetUOMSDescriptionbyUOMS:For uoms {0}", uoms);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetUOMSDescriptionbyUOMS:For uoms {0}", uoms);
                throw ex;
            }
        }
        /// <summary>
        /// Activate or De Activate Unit of Measure
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> ActiveOrDeActiveUnitofMeasure(bool status, int unitId)
        {

            try
            {

                var parameter = "?status=" + status + "&unitId=" + unitId;
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("UnitofMeasure/ActiveOrDeActiveUnitofMeasure" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ActiveOrDeActiveUnitofMeasure:For unitId {0} ", unitId);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        #endregion Unit of Measure

        #region Store Business Link
        //Unit of Measure
        [Area("eSyaConfig")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public  IActionResult V_44_00()
        {
            
            return View();
         
        }

        /// <summary>
        /// Get Store List for js tree
        /// </summary>
        [Produces("application/json")]
        [HttpGet]
        public async Task<JsonResult> GetStoreList(int BusinessKey)
        {
            try
            {
                List<jsTreeObject> jsTree = new List<jsTreeObject>();

                jsTreeObject jsObj = new jsTreeObject
                {
                    id = "MM",
                    parent = "#",
                    text = "Stores",
                    state = new stateObject { opened = true, selected = false }
                };
                jsTree.Add(jsObj);
                var parameter = "?BusinessKey=" + BusinessKey;
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_StoreMaster>>("StoreMaster/GetStoreList" + parameter);
                var storeList = serviceResponse.Data;

                if (storeList != null)
                {
                    //Add Form
                    foreach (var f in storeList.OrderBy(o => o.StoreCode))
                    {
                        if (f.ActiveStatus)
                        {
                            jsObj = new jsTreeObject
                            {
                                id = "ST" + "T" + "_" + f.StoreCode.ToString(),
                                text = f.StoreDesc,
                                GroupIndex = f.StoreCode.ToString(),
                                parent = "MM",
                                icon = "/images/jsTree/checkedstate.jpg",
                                state = new stateObject { opened = true, selected = false }
                            };
                            jsTree.Add(jsObj);
                        }
                        else
                        {
                            jsObj = new jsTreeObject
                            {
                                id = "ST" + "F" + "_" + f.StoreCode.ToString(),
                                text = f.StoreDesc,
                                GroupIndex = f.StoreCode.ToString(),
                                parent = "MM",
                                state = new stateObject { opened = true, selected = false }
                            };
                            jsTree.Add(jsObj);
                        }
                    }
                }
                return Json(jsTree);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetStoreList");
                throw ex;
            }
        }

        /// <summary>
        ///Get Store Business Link Info
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetStoreBusinessLinkInfo(int BusinessKey, int StoreCode)
        {
            try
            {
                var parameter = "?BusinessKey=" + BusinessKey + "&StoreCode=" + StoreCode;
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<DO_StoreBusinessLink>("StoreMaster/GetStoreBusinessLinkInfo" + parameter);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetStoreBusinessLinkInfo:For BusinessKey {0} with StoreCode entered {1}", BusinessKey, StoreCode);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetStoreBusinessLinkInfo:For BusinessKey {0} with StoreCode entered {1}", BusinessKey, StoreCode);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetStoreBusinessLinkInfo:For BusinessKey {0} with StoreCode entered {1}", BusinessKey, StoreCode);
                throw ex;
            }
        }

        /// <summary>
        /// Insert or Update Store Business Link
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertUpdateStoreBusinessLink(DO_StoreBusinessLink strbuss)
        {
            try
            {
                if (string.IsNullOrEmpty(strbuss.BusinessKey.ToString()) || strbuss.BusinessKey == 0)
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select Business Location First" });
                }
                else if (string.IsNullOrEmpty(strbuss.StoreCode.ToString()) || strbuss.StoreCode == 0)
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select Store" });
                }
                else
                {
                    strbuss.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                    strbuss.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                    strbuss.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

                    var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("StoreMaster/InsertUpdateStoreBusinessLink", strbuss);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertUpdateStoreBusinessLink:params:" + JsonConvert.SerializeObject(strbuss));
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertUpdateStoreBusinessLink:params:" + JsonConvert.SerializeObject(strbuss));
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }
        #endregion Store Business Link

        #region Item Master
        //Unit of Measure
        [Area("eSyaConfig")]
        public IActionResult V_74_00()
        {
            ViewBag.formName = "Item Master";
            return View();
        }
        #endregion Item Master

        #region Item Business Link
        //Unit of Measure
        [Area("eSyaConfig")]
        public IActionResult V_75_00()
        {
            ViewBag.formName = "Item Business Link";
            return View();
        }
        #endregion Item Business Link


        #region Item Reorder Level
        //Unit of Measure
        [Area("eSyaConfig")]
        public IActionResult V_76_00()
        {
            ViewBag.formName = "Item Reorder Level";
            return View();
        }
        #endregion Item Master


        
    }
}