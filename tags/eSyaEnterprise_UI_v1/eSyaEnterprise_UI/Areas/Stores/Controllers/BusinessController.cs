﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using eSyaEnterprise_UI.ActionFilter;
using eSyaEnterprise_UI.Areas.Stores.Data;
using eSyaEnterprise_UI.Areas.Stores.Models;
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

namespace eSyaEnterprise_UI.Areas.Stores.Controllers
{
    public class BusinessController : Controller
    {
        private readonly IStoreAPIServices _storeAPIServices;
        private readonly ILogger<BusinessController> _logger;

        public BusinessController(IStoreAPIServices storeAPIServices, ILogger<BusinessController> logger)
        {
            _storeAPIServices = storeAPIServices;
            _logger = logger;
        }
        #region Store Business Link
        [Area("Stores")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult ECI_03_00()
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
                var serviceResponse = await _storeAPIServices.HttpClientServices.GetAsync<List<DO_StoreMaster>>("StoreMaster/GetStoreList" + parameter);
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
        ///Get Accounting Type
        /// </summary>
        [HttpPost]
        public JsonResult GetAllAccountingType()
        {
            try
            {
                var _actypes = GetAllStoreClass();
                return Json(_actypes);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetAllAccountingType");
                throw ex;
            }
        }

        [HttpPost]
        public async Task<JsonResult> GetStoreBusinessLinkInfo(int BusinessKey, int StoreCode)
        {
            try
            {
                var _actypes = GetAllStoreClass();

                var parameter = "?BusinessKey=" + BusinessKey + "&StoreCode=" + StoreCode;
                var serviceResponse = await _storeAPIServices.HttpClientServices.GetAsync<List<DO_StoreBusinessLink>>("StoreMaster/GetStoreBusinessLinkInfo" + parameter);

                List<DO_StoreBusinessLink> Storelinkdata = serviceResponse.Data;

                if (serviceResponse.Status)
                {
                    foreach (var obj in _actypes)
                    {
                       
                            if (Storelinkdata.Count > 0)
                            {
                                var is_linked = Storelinkdata
                                      .Where(x => x.StoreClass == obj.StoreClass).FirstOrDefault();

                                if (is_linked != null)
                                {
                                    obj.ActiveStatus = true;
                                }
                                else
                                {
                                    obj.ActiveStatus = false;
                                }

                            }
                        
                    }
                    return Json(_actypes);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetStoreBusinessLinkInfo:For BusinessKey {0} with StoreCode entered {1}", BusinessKey, StoreCode);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetStoreBusinessLinkInfo:For BusinessKey {0} with StoreCode entered {1} ", BusinessKey, StoreCode);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }


        //<summary>
        //Insert or Update Store Business Link
        // </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateStoreBusinessLink(List<DO_StoreBusinessLink> obj)
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

                var serviceResponse = await _storeAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("StoreMaster/InsertOrUpdateStoreBusinessLink", obj);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertOrUpdateStoreBusinessLink:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }

            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertUpdateStoreBusinessLink:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Message = ex.ToString() });

            }

        }

        private static List<DO_AccountingType> GetAllStoreClass()
        {
            List<DO_AccountingType> objlist = new List<DO_AccountingType>();
            objlist.Add(new DO_AccountingType()
            {
                StoreClass = "A",
                StoreClassDescription = "Is Accounting",
                ActiveStatus = false
            });
            objlist.Add(new DO_AccountingType()
            {
                StoreClass = "C",
                StoreClassDescription = "IS Custodian",
                ActiveStatus = false
            });
            objlist.Add(new DO_AccountingType()
            {
                StoreClass = "M",
                StoreClassDescription = "IS Consumption",
                ActiveStatus = false
            });
            objlist.Add(new DO_AccountingType()
            {
                StoreClass = "S",
                StoreClassDescription = "IS Point of Sales",
                ActiveStatus = false
            });
            return objlist;
        }
        #endregion Store Business Link

        /// <summary>
        ///Get Store Business Link Info
        /// </summary>
        //[HttpPost]
        //public async Task<JsonResult> GetStoreBusinessLinkInfo(int BusinessKey, int StoreCode)
        //{
        //    try
        //    {
        //        var parameter = "?BusinessKey=" + BusinessKey + "&StoreCode=" + StoreCode;
        //        var serviceResponse = await _storeAPIServices.HttpClientServices.GetAsync<DO_StoreBusinessLink>("StoreMaster/GetStoreBusinessLinkInfo" + parameter);
        //        if (serviceResponse.Status)
        //        {
        //            if (serviceResponse.Data != null)
        //            {
        //                return Json(serviceResponse.Data);
        //            }
        //            else
        //            {
        //                _logger.LogError(new Exception(serviceResponse.Message), "UD:GetStoreBusinessLinkInfo:For BusinessKey {0} with StoreCode entered {1}", BusinessKey, StoreCode);
        //                return Json(new { Status = false, StatusCode = "500" });
        //            }
        //        }
        //        else
        //        {
        //            _logger.LogError(new Exception(serviceResponse.Message), "UD:GetStoreBusinessLinkInfo:For BusinessKey {0} with StoreCode entered {1}", BusinessKey, StoreCode);
        //            return Json(new { Status = false, StatusCode = "500" });
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, "UD:GetStoreBusinessLinkInfo:For BusinessKey {0} with StoreCode entered {1}", BusinessKey, StoreCode);
        //        throw ex;
        //    }
        //}

        /// <summary>
        /// Insert or Update Store Business Link
        /// </summary>
        //[HttpPost]
        //public async Task<JsonResult> InsertUpdateStoreBusinessLink(DO_StoreBusinessLink strbuss)
        //{
        //    try
        //    {
        //        if (string.IsNullOrEmpty(strbuss.BusinessKey.ToString()) || strbuss.BusinessKey == 0)
        //        {
        //            return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select Business Location First" });
        //        }
        //        else if (string.IsNullOrEmpty(strbuss.StoreCode.ToString()) || strbuss.StoreCode == 0)
        //        {
        //            return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select Store" });
        //        }
        //        else
        //        {
        //            strbuss.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
        //            strbuss.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
        //            strbuss.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

        //            var serviceResponse = await _storeAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("StoreMaster/InsertUpdateStoreBusinessLink", strbuss);
        //            if (serviceResponse.Status)
        //                return Json(serviceResponse.Data);
        //            else
        //            {
        //                _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertUpdateStoreBusinessLink:params:" + JsonConvert.SerializeObject(strbuss));
        //                return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, "UD:InsertUpdateStoreBusinessLink:params:" + JsonConvert.SerializeObject(strbuss));
        //        return Json(new { Status = false, Message = ex.ToString() });
        //    }
        //}


    }
}