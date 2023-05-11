﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using eSyaEnterprise_UI.ActionFilter;
using eSyaEnterprise_UI.Areas.Inventory.Data;
using eSyaEnterprise_UI.Areas.Inventory.Models;
using eSyaEnterprise_UI.DataServices;
using eSyaEnterprise_UI.Models;
using eSyaEnterprise_UI.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;
using eSyaEnterprise_UI.Extension;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace eSyaEnterprise_UI.Areas.Inventory.Controllers
{
    public class SKUController : Controller
    {
        private readonly IInventoryAPIServices _inventoryAPIServices;
        private readonly ILogger<SKUController> _logger;

        public SKUController(IInventoryAPIServices inventoryAPIServices, ILogger<SKUController> logger)
        {
            _inventoryAPIServices = inventoryAPIServices;
            _logger = logger;
        }


        #region Item Creation

        /// <summary>
        /// Item Creation
        /// </summary>
        /// <returns></returns>
        [Area("Inventory")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> ECI_09_00()
        {
            try
            {
                int pu_ctype = CodeTypeValues.PackUnit;
                var pu_serviceResponse = await _inventoryAPIServices.HttpClientServices.GetAsync<List<DO_ApplicationCodes>>("Common/GetApplicationCodesByCodeType?codeType=" + pu_ctype);
                var Um_serviceResponse = await _inventoryAPIServices.HttpClientServices.GetAsync<List<DO_UnitofMeasure>>("Common/GetUnitofMeasure");
                var Ig_serviceResponse = await _inventoryAPIServices.HttpClientServices.GetAsync<List<DO_ItemGroup>>("Common/GetItemGroup");
                var Im_serviceResponse = await _inventoryAPIServices.HttpClientServices.GetAsync<List<DO_ItemCodes>>("ItemCodes/GetItemList");

                if (pu_serviceResponse.Status && Um_serviceResponse.Status && Ig_serviceResponse.Status && Im_serviceResponse.Status)
                {
                    if (pu_serviceResponse.Data != null && Um_serviceResponse.Data != null && Ig_serviceResponse.Data != null && Im_serviceResponse.Data != null)
                    {
                        ViewBag.PackUnitList = pu_serviceResponse.Data.Select(b => new SelectListItem
                        {
                            Value = b.ApplicationCode.ToString(),
                            Text = b.CodeDesc,
                        }).ToList();

                        ViewBag.UOMList = Um_serviceResponse.Data.Select(b => new SelectListItem
                        {
                            Value = b.UnitOfMeasure.ToString(),
                            Text = b.Uompdesc,
                        }).ToList();

                        ViewBag.ItemGroupList = Ig_serviceResponse.Data.Select(b => new SelectListItem
                        {
                            Value = b.ItemGroupId.ToString(),
                            Text = b.ItemGroupDesc,
                        }).ToList();

                        ViewBag.ItemList = Im_serviceResponse.Data.Select(b => new SelectListItem
                        {
                            Value = b.ItemCode.ToString(),
                            Text = b.ItemDescription,
                        }).ToList();
                    }
                    else
                    {
                        _logger.LogError(new Exception(pu_serviceResponse.Message), "UD:ItemMaster");
                    }
                }
                else
                {
                    _logger.LogError(new Exception(pu_serviceResponse.Message), "UD:ItemMaster");
                }
                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD: ItemMaster");
                throw ex;
            }
        }

        /// <summary>
        ///Get Item Category
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetItemCategory(int ItemGroup)
        {
            try
            {
                var parameter = "?ItemGroup=" + ItemGroup;
                var serviceResponse = await _inventoryAPIServices.HttpClientServices.GetAsync<List<DO_ItemCategory>>("Common/GetItemCategory" + parameter);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetItemCategory:For ItemGroup {0}", ItemGroup);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetItemCategory:For ItemGroup {0}", ItemGroup);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetItemCategory:For ItemGroup {0}", ItemGroup);
                throw ex;
                //return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        ///Get Item Category
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> GetItemSubCategory(int ItemCategory)
        {
            try
            {
                var parameter = "?ItemCategory=" + ItemCategory;
                var serviceResponse = await _inventoryAPIServices.HttpClientServices.GetAsync<List<DO_ItemSubCategory>>("Common/GetItemSubCategory" + parameter);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetItemSubCategory:For ItemCategory {0}", ItemCategory);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetItemSubCategory:For ItemCategory {0}", ItemCategory);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetItemSubCategory:For ItemCategory {0}", ItemCategory);
                throw ex;
                //return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        ///Get Item Master List
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> GetItemMaster(int ItemGroup, int ItemCategory, int ItemSubCategory)
        {
            try
            {
                var parameter = "?ItemGroup=" + ItemGroup + "&ItemCategory=" + ItemCategory + "&ItemSubCategory=" + ItemSubCategory;
                var serviceResponse = await _inventoryAPIServices.HttpClientServices.GetAsync<List<DO_ItemCodes>>("ItemCodes/GetItemMaster" + parameter);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetItemMaster:For ItemGroup {0} ItemCategory {1} With ItemSubCategory entered {2}", ItemGroup, ItemCategory, ItemSubCategory);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetItemMaster:For ItemGroup {0} ItemCategory {1} With ItemSubCategory entered {2}", ItemGroup, ItemCategory, ItemSubCategory);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetItemMaster:For ItemGroup {0} ItemCategory {1} With ItemSubCategory entered {2}", ItemGroup, ItemCategory, ItemSubCategory);
                throw ex;
            }
        }

        /// <summary>
        ///Get Item Codes Details
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> GetItemDetails(int ItemCode)
        {
            try
            {
                var parameter = "?ItemCode=" + ItemCode;
                var serviceResponse = await _inventoryAPIServices.HttpClientServices.GetAsync<List<DO_ItemCodes>>("ItemCodes/GetItemDetails" + parameter);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetItemDetails:For ItemCode {0}", ItemCode);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetItemDetails:For ItemCode {0}", ItemCode);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetItemDetails:For ItemCode {0}", ItemCode);
                throw ex;
            }
        }

        /// <summary>
        /// Get Item parameter
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> GetItemParameterList(int ItemCode)
        {
            try
            {
                var serviceResponse = await _inventoryAPIServices.HttpClientServices.GetAsync<DO_ItemCodes>("ItemCodes/GetItemParameterList?ItemCode=" + ItemCode);

                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetItemParameterList:For ItemCode {0}", ItemCode);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetItemParameterList:For ItemCode {0}", ItemCode);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetItemParameterList:For ItemCode {0}", ItemCode);
                throw ex;
            }
        }

        /// <summary>
        /// Insert or Update Item Codes
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateItemCodes(DO_ItemCodes ItemCodes)
        {
            try
            {
                if (string.IsNullOrEmpty(ItemCodes.ItemGroup.ToString()) || ItemCodes.ItemGroup == 0)
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select Item Group" });
                }
                else if (string.IsNullOrEmpty(ItemCodes.ItemClass.ToString()))
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select Item Class" });
                }
                else if (string.IsNullOrEmpty(ItemCodes.ItemDescription))
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Enter Item Description" });
                }
                else if (string.IsNullOrEmpty(ItemCodes.UnitOfMeasure.ToString()) || ItemCodes.UnitOfMeasure == 0)
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select Unit of Measure" });
                }
                else if (string.IsNullOrEmpty(ItemCodes.PackUnit.ToString()) || ItemCodes.PackUnit == 0)
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select Pack Unit" });
                }
                else if (string.IsNullOrEmpty(ItemCodes.InventoryClass.ToString()))
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select Inventory Class" });
                }
                else if (string.IsNullOrEmpty(ItemCodes.ItemClass.ToString()))
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select Item Class" });
                }
                else if (string.IsNullOrEmpty(ItemCodes.ItemSource.ToString()))
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select Item Source" });
                }
                else if (string.IsNullOrEmpty(ItemCodes.ItemCriticality.ToString()))
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select Item Criticality" });
                }
                else if (string.IsNullOrEmpty(ItemCodes.PackSize.ToString()) || ItemCodes.PackSize == 0)
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Enter Pack Size" });
                }
                else
                {
                    ItemCodes.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                    ItemCodes.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                    ItemCodes.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

                    if (ItemCodes.ItemCode == 0)
                    {
                        var serviceResponse = await _inventoryAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("ItemCodes/InsertItemCodes", ItemCodes);
                        if (serviceResponse.Status)
                            return Json(serviceResponse.Data);
                        else
                        {
                            _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertOrUpdateItemCodes:params:" + JsonConvert.SerializeObject(ItemCodes));
                            return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                        }
                    }
                    else
                    {
                        var serviceResponse = _inventoryAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("ItemCodes/UpdateItemCodes", ItemCodes).Result;
                        if (serviceResponse.Status)
                            return Json(serviceResponse.Data);
                        else
                        {
                            _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertOrUpdateItemCodes:params:" + JsonConvert.SerializeObject(ItemCodes));
                            return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateItemCodes:params:" + JsonConvert.SerializeObject(ItemCodes));
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }

        #endregion Item Creation

        #region Item Custodian

        [Area("Inventory")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> ECI_10_00()
        {
            try
            {

                var bk_serviceResponse = await _inventoryAPIServices.HttpClientServices.GetAsync<List<DO_BusinessLocation>>("Common/GetBusinessKey");
                var as_serviceResponse = await _inventoryAPIServices.HttpClientServices.GetAsync<List<DO_StoreMaster>>("Common/GetAccountingStore");

                if (bk_serviceResponse.Status && as_serviceResponse.Status)
                {
                    if (bk_serviceResponse.Data != null && as_serviceResponse.Data != null)
                    {
                        ViewBag.businessKey = bk_serviceResponse.Data;
                        ViewBag.accountingstore = as_serviceResponse.Data;
                    }
                    else
                    {
                        _logger.LogError(new Exception(bk_serviceResponse.Message), "UD:ItemBusinessLink");
                    }
                }
                else
                {
                    _logger.LogError(new Exception(bk_serviceResponse.Message), "UD:ItemBusinessLink");
                }
                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ItemBusinessLink");
                throw ex;
            }
        }

        /// <summary>
        ///Get Custodian Store
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetCustodianStoreList()
        {
            try
            {
                var serviceResponse = await _inventoryAPIServices.HttpClientServices.GetAsync<List<DO_StoreMaster>>("Common/GetCustodianStore");
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetCustodianStoreList");
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetCustodianStoreList");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetCustodianStoreList");
                throw ex;
            }
        }


        /// <summary>
        ///Get Custodian Store
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetCustodianStoreListbyAccountingStore(int Businesskey, int Itemcode, int accountingcode)
        {
            try
            {
                var serviceResp = await _inventoryAPIServices.HttpClientServices.GetAsync<List<DO_StoreMaster>>("Common/GetCustodianStore");
                List<DO_StoreMaster> allstores = serviceResp.Data;
                var parameter = "?Businesskey=" + Businesskey + "&Itemcode=" + Itemcode + "&accountingcode=" + accountingcode;
                var serviceResponse = await _inventoryAPIServices.HttpClientServices.GetAsync<List<DO_StoreMaster>>("ItemCodes/GetCustodianStoreListbyAccountingStore" + parameter);
                List<DO_StoreMaster> linkedstores = serviceResponse.Data;

                if (serviceResponse.Status && serviceResp.Status)
                {
                    foreach (var s in allstores)
                    {
                        if (linkedstores.Count > 0)
                        {

                            var isstore = linkedstores
                                  .Where(c => c.CustodianStore == s.CustodianStore).FirstOrDefault();

                            if (isstore != null)
                            {
                                s.ActiveStatus = true;
                            }
                            else
                            {
                                s.ActiveStatus = false;
                            }
                        }


                    }
                    return Json(allstores);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetCustodianStoreListbyAccountingStore:For Businesskey {0} and Itemcode entered {1} with accountingcode entered {2}", Businesskey, Itemcode, accountingcode);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }

            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetCustodianStoreListbyAccountingStore");
                throw ex;
            }
        }

        /// <summary>
        /// Insert or Update Custodian Store
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateItemCodetoCustodianStore(List<DO_ItemCodeLinkCustodianStore> obj)
        {

            try
            {
                obj.All(c =>
                {
                    c.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                    c.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                    c.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                    return true;
                });

                var serviceResponse = await _inventoryAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("ItemCodes/InsertOrUpdateItemCodetoCustodianStore", obj);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateItemCodetoCustodianStore:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
            }
        }
        /// <summary>
        ///Get Business Item Custodian Link
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> GetCustodianStore(int BusinessKey, int ItemCode)
        {
            try
            {
                var parameter = "?BusinessKey=" + BusinessKey + "&ItemCode=" + ItemCode;
                var serviceResponse = await _inventoryAPIServices.HttpClientServices.GetAsync<List<DO_ItemBusinessLink>>("ItemCodes/GetCustodianStore" + parameter);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetCustodianStore:For BusinessKey {0} with ItemCode entered {1}", BusinessKey, ItemCode);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetCustodianStore:For BusinessKey {0} with ItemCode entered {1}", BusinessKey, ItemCode);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetCustodianStore:For BusinessKey {0} with ItemCode entered {1}", BusinessKey, ItemCode);
                throw ex;
            }
        }

        /// <summary>
        ///Get Item List for Tree View
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetItemTree()
        {
            try
            {
                List<jsTreeObject> jsTree = new List<jsTreeObject>();

                jsTreeObject jsObj = new jsTreeObject
                {
                    id = "IG",
                    parent = "#",
                    text = "Item Group",
                    state = new stateObject { opened = true, selected = false }
                };
                jsTree.Add(jsObj);

                var serviceResponse = await _inventoryAPIServices.HttpClientServices.GetAsync<DO_ItemConfigurartion>("ItemCodes/GetItemTree");
                var ItemConfig = serviceResponse.Data;
                if (ItemConfig != null)
                {
                    foreach (var f in ItemConfig.l_ItemGroup.OrderBy(o => o.ItemGroupId))
                    {
                        jsObj = new jsTreeObject
                        {
                            id = "IG" + f.ItemGroupId.ToString(),
                            text = f.ItemGroupDesc,
                            GroupIndex = f.ItemGroupId.ToString(),
                            parent = "IG",
                            state = new stateObject { opened = true, selected = false }
                        };
                        jsTree.Add(jsObj);
                    }

                    foreach (var f in ItemConfig.l_ItemCategory.OrderBy(o => o.ItemCategory))
                    {
                        jsObj = new jsTreeObject
                        {
                            id = "IC" + f.ItemGroupId.ToString() + "_" + f.ItemCategory.ToString(),
                            text = f.ItemCategoryDesc,
                            GroupIndex = f.ItemGroupId.ToString(),
                            parent = "IG" + f.ItemGroupId.ToString(),
                            state = new stateObject { opened = true, selected = false }
                        };
                        jsTree.Add(jsObj);
                    }

                    foreach (var f in ItemConfig.l_ItemSubCategory.OrderBy(o => o.ItemSubCategory))
                    {
                        jsObj = new jsTreeObject
                        {
                            id = "IS" + f.ItemGroupId.ToString() + "_" + f.ItemCategory.ToString() + "_" + f.ItemSubCategory.ToString(),
                            text = f.ItemSubCategoryDesc,
                            GroupIndex = f.ItemGroupId.ToString(),
                            parent = "IC" + f.ItemGroupId.ToString() + "_" + f.ItemCategory.ToString(),
                            state = new stateObject { opened = true, selected = false }
                        };
                        jsTree.Add(jsObj);
                    }

                    foreach (var f in ItemConfig.l_ItemCodes.OrderBy(o => o.ItemCode))
                    {
                        if (f.ItemSubCategory == 0)
                        {
                            jsObj = new jsTreeObject
                            {
                                id = "IT" + f.ItemGroup.ToString() + "_" + f.ItemCategory.ToString() + "_" + f.ItemCode.ToString(),
                                text = f.ItemDescription,
                                GroupIndex = f.ItemGroup.ToString(),
                                parent = "IC" + f.ItemGroup.ToString() + "_" + f.ItemCategory.ToString(),
                                state = new stateObject { opened = true, selected = false }
                            };
                            jsTree.Add(jsObj);
                        }
                        else
                        {
                            jsObj = new jsTreeObject
                            {

                                id = "IT" + f.ItemGroup.ToString() + "_" + f.ItemCategory.ToString() + "_" + f.ItemSubCategory.ToString() + "_" + f.ItemCode.ToString(),
                                text = f.ItemDescription,
                                GroupIndex = f.ItemGroup.ToString(),
                                parent = "IS" + f.ItemGroup.ToString() + "_" + f.ItemCategory.ToString() + "_" + f.ItemSubCategory.ToString(),
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
                _logger.LogError(ex, "UD:GetItemTree");
                throw ex;
            }

        }

        public async Task<IActionResult> GetAccountingStoreForItem(int businesskey, int itemcode, string accountingType)
        {
            try
            {
                var parameter = "?businesskey=" + businesskey + "&itemcode=" + itemcode + "&accountingType=" + accountingType;
                var serviceResponse = await _inventoryAPIServices.HttpClientServices.GetAsync<List<DO_ItemAccountingStore>>("ItemCodes/GetAccountingStoreForItem" + parameter);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetAccountingStoreForItem:For businesskey {0} with itemcode entered {1}", businesskey, itemcode);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetAccountingStoreForItem:For businesskey {0} with itemcode entered {1}", businesskey, itemcode);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetAccountingStoreForItem:For businesskey {0} with itemcode entered {1}", businesskey, itemcode);
                throw ex;
            }
        }

        public async Task<JsonResult> InsertAccountingStoreForItem(List<DO_ItemAccountingStore> obj)
        {

            try
            {
                obj.All(c =>
                {
                    c.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                    c.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                    c.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                    return true;
                });

                var serviceResponse = await _inventoryAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("ItemCodes/InsertAccountingStoreForItem", obj);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertAccountingStoreForItem:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
            }
        }




        #endregion Item Custodian

        #region Item Where Used
        [Area("Inventory")]
        public IActionResult ECI_11_00()
        {
            ViewBag.formName = "Item Where Used";
            return View();
        }
        #endregion

        #region Item Bin Details
        [Area("Inventory")]
        public IActionResult ECI_12_00()
        {
            ViewBag.formName = "Item BIN Details";
            return View();
        }
        #endregion


        #region Item Reorder Level
        [Area("Inventory")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> V_1014_00()
        {
            try
            {
                var bk_serviceResponse = await _inventoryAPIServices.HttpClientServices.GetAsync<List<DO_BusinessLocation>>("Common/GetBusinessKey");

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
                        _logger.LogError(new Exception(bk_serviceResponse.Message), "UD:ItemReorderLevel");
                    }
                }
                else
                {
                    _logger.LogError(new Exception(bk_serviceResponse.Message), "UD:ItemReorderLevel");
                }
                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ItemReorderLevel");
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
                var serviceResponse = await _inventoryAPIServices.HttpClientServices.GetAsync<List<DO_StoreMaster>>("Common/GetStoreListByBusinessKey" + parameter);
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
        public async Task<JsonResult> GetItemReorderLevel(int BusinessKey, int StoreCode)
        {
            try
            {
                var parameter = "?BusinessKey=" + BusinessKey + "&StoreCode=" + StoreCode;
                var serviceResponse = await _inventoryAPIServices.HttpClientServices.GetAsync<List<DO_ItemReorderLevel>>("ItemCodes/GetItemReorderLevel" + parameter);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetItemReorderLevel:For BusinessKey {0} and with StoreCode {1}", BusinessKey, StoreCode);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetItemReorderLevel:For BusinessKey {0} and with StoreCode {1}", BusinessKey, StoreCode);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetItemReorderLevel:For BusinessKey {0} and with StoreCode {1}", BusinessKey, StoreCode);
                throw ex;
            }
        }

        /// <summary>
        /// Insert Into Item Reorder Level
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateItemReorderLevel(List<DO_ItemReorderLevel> bu_bd)
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

                foreach (var sd in bu_bd.Where(w => !String.IsNullOrEmpty(w.ItemDescription)))
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
                            return Json(new DO_ReturnParameter() { Status = false, Message = "Safety Stock Should Not Be Greater Than Minimum Stock for " + sd.ItemDescription });
                        }
                        else if (sd.MinimumStockLevel > sd.ReorderLevel)
                        {
                            return Json(new DO_ReturnParameter() { Status = false, Message = "Minimum Stock Should Not Be Greater Than ROL Stock for " + sd.ItemDescription });
                        }
                        else if (sd.ReorderLevel > sd.MaximumStockLevel)
                        {
                            return Json(new DO_ReturnParameter() { Status = false, Message = "Reorder Level Stock Should Not Be Greater Than Maximum Stock for " + sd.ItemDescription });
                        }
                    }
                }

                var serviceResponse = await _inventoryAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("ItemCodes/InsertOrUpdateItemReorderLevel", bu_bd);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertOrUpdateItemReorderLevel:params:" + JsonConvert.SerializeObject(bu_bd));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateItemReorderLevel:params:" + JsonConvert.SerializeObject(bu_bd));
                throw ex;
            }
        }
        #endregion Item Reorder Level
    }
}