﻿using System;
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
    public class ServiceManagementController : Controller
    {
        private readonly IeSyaServicesAPIServices _eSyaServicesAPIServices;
        private readonly ILogger<ServiceManagementController> _logger;
        public ServiceManagementController(IeSyaServicesAPIServices eSyaServicesAPIServices, ILogger<ServiceManagementController> logger)
        {
            _eSyaServicesAPIServices = eSyaServicesAPIServices;
            _logger = logger;
        }

        /// <summary>
        /// Service Management
        /// </summary>
        /// <returns></returns>

        [Area("eSyaServices")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult V_1500_00()
        {
            //ViewBag.UserFormRoles = new DO_UserFormRole { IsInsert = true, IsEdit = true, IsDelete = true, IsView = true };
            return View();
        }


        #region ServiceType

        /// <summary>
        /// Service Type
        /// </summary>
        /// <returns></returns>

        [Area("eSyaServices")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult V_1501_00()
        {
            //ViewBag.UserFormRoles = new DO_UserFormRole { IsInsert = true, IsEdit = true, IsDelete = true, IsView = true };
            return View();
        }

        [Produces("application/json")]
        [HttpGet]
        public async Task<ActionResult> GetServiceTypes()
        {
            try
            {
                List<jsTreeObject> treeView = new List<jsTreeObject>();

                jsTreeObject jsObj = new jsTreeObject();
                jsObj.id = "ST";
                jsObj.parent = "#";
                jsObj.text = "Service Types";
                jsObj.icon = "/images/jsTree/foldergroupicon.png";
                jsObj.state = new stateObject { opened = true, selected = false };
                treeView.Add(jsObj);

                var serviceResponse = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_ServiceType>>("ServiceManagement/GetServiceTypes");
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        var st_list = serviceResponse.Data;
                        foreach (var it in st_list)
                        {
                            jsObj = new jsTreeObject();
                            jsObj.id = it.ServiceTypeId.ToString();
                            jsObj.text = it.ServiceTypeDesc;
                            jsObj.icon = "/images/jsTree/openfolder.png";
                            jsObj.parent = "ST";
                            treeView.Add(jsObj);
                        }
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetServiceTypes");
                }

                return Json(treeView);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetServiceTypes");
                return Json(new DO_ReturnParameter() { Status = false, Message = ex.Message });
            }
        }
        public async Task<ActionResult> GetServiceTypeByID(int ServiceTypeID)
        {
            try
            {
                var serviceResponse = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<DO_ServiceType>("ServiceManagement/GetServiceTypeByID?ServiceTypeID=" + ServiceTypeID);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        var data = serviceResponse.Data;
                        return Json(data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetServiceTypeByID:For ServiceTypeID {0}", ServiceTypeID);
                        return Json(new { Status = false, Message = serviceResponse.Message });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetServiceTypeByID:For ServiceTypeID {0}", ServiceTypeID);
                    return Json(new { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetServiceTypeByID:For ServiceTypeID {0}", ServiceTypeID);
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }
        public async Task<ActionResult> AddOrUpdateServiceType(DO_ServiceType obj)
        {
            try
            {
                //obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                obj.FormID = "V_1501_00";
                obj.CreatedOn = DateTime.Now;
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

                var serviceResponse = await _eSyaServicesAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("ServiceManagement/AddOrUpdateServiceType", obj);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Data.Message), "UD:AddOrUpdateServiceType:params:" + JsonConvert.SerializeObject(obj));
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Data.Message });
                    }

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:AddOrUpdateServiceType:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:AddOrUpdateServiceType:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = ex.ToString() });
            }
        }
        public async Task<ActionResult> UpdateServiceTypeIndex(int serviceTypeId, bool isMoveUp, bool isMoveDown)
        {
            try
            {
                var serviceResponse = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("ServiceManagement/UpdateServiceTypeIndex?serviceTypeId=" + serviceTypeId  + "&isMoveUp=" + isMoveUp + "&isMoveDown=" + isMoveDown);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Data.Message), "UD:UpdateServiceTypeIndex:For serviceTypeId {0},isMoveUp {1},isMoveDown {2} ", serviceTypeId, isMoveUp, isMoveDown);
                        return Json(new { Status = false, Message = serviceResponse.Data.Message });
                    }

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:UpdateServiceTypeIndex:For serviceTypeId {0},isMoveUp {1},isMoveDown {2} ", serviceTypeId, isMoveUp, isMoveDown);
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:UpdateServiceTypeIndex:For serviceTypeId {0},isMoveUp {1},isMoveDown {2} ", serviceTypeId, isMoveUp, isMoveDown);
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }
        public async Task<ActionResult> DeleteServiceType(int serviceTypeId)
        {
            try
            {
                var serviceResponse = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("ServiceManagement/DeleteServiceType?serviceTypeId=" + serviceTypeId);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Data.Message), "UD:DeleteServiceType:For serviceTypeId {0} ", serviceTypeId);
                        return Json(new { Status = false, Message = serviceResponse.Data.Message });
                    }

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:DeleteServiceType:For serviceTypeId {0}", serviceTypeId);
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:DeleteServiceType:For serviceTypeId {0} ", serviceTypeId);
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }
        #endregion

        #region ServiceGroup

        /// <summary>
        /// Service Group
        /// </summary>
        /// <returns></returns>

        [Area("eSyaServices")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult V_1502_00()
        {
            ViewBag.UserFormRoles = new DO_UserFormRole { IsInsert = true, IsEdit = true, IsDelete = true, IsView = true };
            return View();
        }

        public async Task<ActionResult> GetServiceGroups()
        {
            try
            {
                var serviceResponse = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_ServiceType>>("ServiceManagement/GetServiceTypes");
                var st_list = new List<DO_ServiceType>();
                if (serviceResponse.Status)
                {
                    st_list = serviceResponse.Data.FindAll(w => w.ActiveStatus == true);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetServiceGroups:GetServiceTypes");
                }

                var serviceResponse1 = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_ServiceGroup>>("ServiceManagement/GetServiceGroups");
                var sg_list = new List<DO_ServiceGroup>();
                if (serviceResponse1.Status)
                {
                    sg_list = serviceResponse1.Data;
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse1.Message), "UD:GetServiceGroups:GetServiceGroups");
                }


                List<jsTreeObject> treeView = new List<jsTreeObject>();
                jsTreeObject jsObj = new jsTreeObject();
                jsObj.id = "SG";
                jsObj.parent = "#";
                jsObj.text = "Service Groups";
                jsObj.icon = "/images/jsTree/foldergroupicon.png";
                jsObj.state = new stateObject { opened = true, selected = false };
                treeView.Add(jsObj);
                if (st_list != null)
                {
                    foreach (var st in st_list)
                    {
                        jsObj = new jsTreeObject();
                        jsObj.id = st.ServiceTypeId.ToString();
                        jsObj.text = st.ServiceTypeDesc;
                        jsObj.icon = "/images/jsTree/openfolder.png";
                        jsObj.parent = "SG";
                        jsObj.state = new stateObject { opened = false, selected = false };
                        treeView.Add(jsObj);
                        if (sg_list != null)
                        {
                            foreach (var sg in sg_list)
                            {
                                if (st.ServiceTypeId == sg.ServiceTypeId)
                                {
                                    jsObj = new jsTreeObject();
                                    jsObj.id = "G" + sg.ServiceGroupId.ToString();
                                    jsObj.text = sg.ServiceGroupDesc;
                                    jsObj.icon = "/images/jsTree/fileIcon.png";
                                    jsObj.parent = st.ServiceTypeId.ToString();
                                    treeView.Add(jsObj);
                                }
                            }
                        }
                    }
                }

                return Json(treeView);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetServiceGroups");
                return Json(new DO_ReturnParameter() { Status = false, Message = ex.ToString() });
            }




        }
        public async Task<ActionResult> GetServiceGroupsByTypeID(int servicetype)
        {
            try
            {
                var serviceResponse = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_ServiceGroup>>("ServiceManagement/GetServiceGroupsByTypeID?servicetype="+servicetype);
                var sg_list = new List<DO_ServiceGroup>();
                if (serviceResponse.Status)
                {
                    sg_list = serviceResponse.Data;
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetServiceGroupsByTypeID: typeID{0}",servicetype);
                }


               

                return Json(sg_list);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetServiceGroupsByTypeID: typeID{0}", servicetype);
                return Json(new DO_ReturnParameter() { Status = false, Message = ex.ToString() });
            }




        }
        public async Task<ActionResult> GetServiceGroupByID(int ServiceGroupID)
        {
            try
            {
                var serviceResponse = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<DO_ServiceGroup>("ServiceManagement/GetServiceGroupByID?ServiceGroupID=" + ServiceGroupID);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        var data = serviceResponse.Data;
                        return Json(data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetServiceGroupByID:For ServiceGroupID {0}", ServiceGroupID);
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                    }

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetServiceGroupByID:For ServiceGroupID {0}", ServiceGroupID);
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetServiceGroupByID:For ServiceGroupID {0}", ServiceGroupID);
                return Json(new DO_ReturnParameter() { Status = false, Message = ex.ToString() });
            }
        }
        public async Task<ActionResult> AddOrUpdateServiceGroup(DO_ServiceGroup obj)
        {
            try
            {
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                obj.CreatedOn = DateTime.Now;
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

                var serviceResponse = await _eSyaServicesAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("ServiceManagement/AddOrUpdateServiceGroup", obj);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Data.Message), "UD:AddOrUpdateServiceGroup:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Data.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:AddOrUpdateServiceGroup:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }
        public async Task<ActionResult> UpdateServiceGroupIndex(int serviceTypeId, int serviceGroupId, bool isMoveUp, bool isMoveDown)
        {
            try
            {
                var serviceResponse = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("ServiceManagement/UpdateServiceGroupIndex?serviceTypeId=" + serviceTypeId + "&serviceGroupId=" + serviceGroupId + "&isMoveUp=" + isMoveUp + "&isMoveDown=" + isMoveDown);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Data.Message), "UD:UpdateServiceGroupIndex:For serviceTypeId {0}, serviceGroupId {1},isMoveUp {2},isMoveDown {3} ", serviceTypeId, serviceGroupId, isMoveUp, isMoveDown);
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Data.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:UpdateServiceGroupIndex:For serviceTypeId {0}, serviceGroupId {1},isMoveUp {2},isMoveDown {3} ", serviceTypeId, serviceGroupId, isMoveUp, isMoveDown);
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }
        public async Task<ActionResult> DeleteServiceGroup(int serviceGroupId)
        {
            try
            {
                var serviceResponse = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("ServiceManagement/DeleteServiceGroup?serviceGroupId=" + serviceGroupId );
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Data.Message), "UD:DeleteServiceGroup:For serviceGroupId {0} ", serviceGroupId);
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Data.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:DeleteServiceGroup:For serviceGroupId {0} ",  serviceGroupId);
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }
        #endregion

        #region ServiceClass

        /// <summary>
        /// Service Class
        /// </summary>
        /// <returns></returns>

        [Area("eSyaServices")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult V_1503_00()
        {
           // ViewBag.UserFormRoles = new DO_UserFormRole { IsInsert = true, IsEdit = true, IsDelete = true, IsView = true };
            return View();
        }

        public async Task<ActionResult> GetServiceClasses()
        {
            try
            {
                var serviceResponse = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_ServiceType>>("ServiceManagement/GetServiceTypes");
                var st_list = new List<DO_ServiceType>();
                if (serviceResponse.Status)
                {
                    st_list = serviceResponse.Data.FindAll(w => w.ActiveStatus == true);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetServiceClasses:GetServiceTypes");
                }
                var serviceResponse1 = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_ServiceGroup>>("ServiceManagement/GetServiceGroups");
                var sg_list = new List<DO_ServiceGroup>();
                if (serviceResponse1.Status)
                {
                    sg_list = serviceResponse1.Data.FindAll(w => w.ActiveStatus == true);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse1.Message), "UD:GetServiceClasses:GetServiceGroups");
                }
                var sc_list = new List<DO_ServiceClass>();
                var serviceResponse2 = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_ServiceClass>>("ServiceManagement/GetServiceClasses");
                if (serviceResponse2.Status)
                {
                    sc_list = serviceResponse2.Data;
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse2.Message), "UD:GetServiceClasses:GetServiceClasses");
                }
                List<jsTreeObject> treeView = new List<jsTreeObject>();
                jsTreeObject jsObj = new jsTreeObject();
                jsObj.id = "SC";
                jsObj.parent = "#";
                jsObj.text = "Service Classes";
                jsObj.icon = "/images/jsTree/foldergroupicon.png";
                jsObj.state = new stateObject { opened = true, selected = false };
                treeView.Add(jsObj);
                if (st_list != null)
                {
                    foreach (var st in st_list)
                    {
                        jsObj = new jsTreeObject();
                        jsObj.id = "T" + st.ServiceTypeId.ToString();
                        jsObj.text = st.ServiceTypeDesc;
                        jsObj.icon = "/images/jsTree/openfolder.png";
                        jsObj.parent = "SC";
                        jsObj.state = new stateObject { opened = false, selected = false };
                        treeView.Add(jsObj);
                        if (sg_list != null)
                        {
                            foreach (var sg in sg_list)
                            {
                                if (st.ServiceTypeId == sg.ServiceTypeId)
                                {
                                    jsObj = new jsTreeObject();
                                    jsObj.id = sg.ServiceGroupId.ToString();
                                    jsObj.text = sg.ServiceGroupDesc;
                                    jsObj.icon = "/images/jsTree/openfolder.png";
                                    jsObj.parent = "T" + st.ServiceTypeId.ToString();
                                    jsObj.state = new stateObject { opened = false, selected = false };
                                    treeView.Add(jsObj);


                                    if (sc_list != null)
                                    {
                                        foreach (var sc in sc_list)
                                        {
                                            if (sg.ServiceGroupId == sc.ServiceGroupId)
                                            {
                                                if (sc.ServiceClassId == sc.ParentId)
                                                {
                                                    jsObj = new jsTreeObject();
                                                    jsObj.id = "C" + sc.ServiceClassId.ToString();
                                                    jsObj.text = sc.ServiceClassDesc;
                                                    jsObj.icon = "/images/jsTree/fileIcon.png";
                                                    jsObj.parent = sg.ServiceGroupId.ToString();
                                                    treeView.Add(jsObj);
                                                }
                                                else
                                                {
                                                    jsObj = new jsTreeObject();
                                                    jsObj.id = "C" + sc.ServiceClassId.ToString();
                                                    jsObj.text = sc.ServiceClassDesc;
                                                    jsObj.icon = "/images/jsTree/fileIcon.png";
                                                    jsObj.parent = "C" + sc.ParentId.ToString();
                                                    treeView.Add(jsObj);
                                                }

                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                return Json(treeView);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetServiceClasses");
                return Json(new DO_ReturnParameter() { Status = false, Message = ex.ToString() });
            }



        }
        public async Task<ActionResult> GetServiceClassesByGroupID(int servicegroup)
        {
            try
            {
                var sc_list = new List<DO_ServiceClass>();
                var serviceResponse = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_ServiceClass>>("ServiceManagement/GetServiceClassesByGroupID?servicegroup="+servicegroup);
                if (serviceResponse.Status)
                {
                    sc_list = serviceResponse.Data;
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetServiceClasses:GetServiceClassesByGroupID: GroupID{0}",servicegroup);
                }
                

                return Json(sc_list);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetServiceClassesByGroupID: GroupID{0}", servicegroup);
                return Json(new DO_ReturnParameter() { Status = false, Message = ex.ToString() });
            }



        }
        public async Task<ActionResult> GetServiceClassByID(int ServiceClassID)
        {
            try
            {
                var serviceResponse = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<DO_ServiceClass>("ServiceManagement/GetServiceClassByID?ServiceClassID=" + ServiceClassID);
                if (serviceResponse.Status)
                {
                    var data = serviceResponse.Data;
                    return Json(data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetServiceClassByID:For ServiceClassID {0}", ServiceClassID);
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetServiceClassByID:For ServiceClassID {0}", ServiceClassID);
                return Json(new DO_ReturnParameter() { Status = false, Message = ex.ToString() });
            }
        }
        public async Task<ActionResult> AddOrUpdateServiceClass(DO_ServiceClass obj)
        {
            try
            {
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                obj.CreatedOn = DateTime.Now;
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);


                var serviceResponse = await _eSyaServicesAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("ServiceManagement/AddOrUpdateServiceClass", obj);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Data.Message), "UD:AddOrUpdateServiceClass:params:" + JsonConvert.SerializeObject(obj));
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Data.Message });
                    }

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:AddOrUpdateServiceClass:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:AddOrUpdateServiceClass:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = ex.ToString() });
            }
        }
        public async Task<ActionResult> UpdateServiceClassIndex(int serviceGroupId, int serviceClassId, bool isMoveUp, bool isMoveDown)
        {
            try
            {
                var serviceResponse = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("ServiceManagement/UpdateServiceClassIndex?serviceGroupId=" + serviceGroupId + "&serviceClassId=" + serviceClassId + "&isMoveUp=" + isMoveUp + "&isMoveDown=" + isMoveDown);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Data.Message), "UD:UpdateServiceClassIndex:For serviceGroupId {0}, serviceClassId {1},isMoveUp {2},isMoveDown {3} ", serviceGroupId, serviceClassId, isMoveUp, isMoveDown);
                        return Json(new { Status = false, Message = serviceResponse.Data.Message });
                    }

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:UpdateServiceClassIndex:For serviceGroupId {0}, serviceClassId {1},isMoveUp {2},isMoveDown {3} ", serviceGroupId, serviceClassId, isMoveUp, isMoveDown);
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:UpdateServiceClassIndex:For serviceGroupId {0}, serviceClassId {1},isMoveUp {2},isMoveDown {3} ", serviceGroupId, serviceClassId, isMoveUp, isMoveDown);
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }
        public async Task<ActionResult> DeleteServiceClass(int serviceClassId)
        {
            try
            {
                var serviceResponse = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("ServiceManagement/DeleteServiceClass?serviceClassId=" + serviceClassId );
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Data.Message), "UD:DeleteServiceClass:For serviceClassId {0}", serviceClassId);
                        return Json(new { Status = false, Message = serviceResponse.Data.Message });
                    }

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:DeleteServiceClass:For serviceClassId {0}", serviceClassId);
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:DeleteServiceClass:For serviceClassId {0}",serviceClassId);
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }
        #endregion

        #region ServiceCode

        /// <summary>
        /// Service Code
        /// </summary>
        /// <returns></returns>

        [Area("eSyaServices")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult V_1510_00()
        {
            ViewBag.UserFormRoles = new DO_UserFormRole { IsInsert = true, IsEdit = true, IsDelete = true, IsView = true };
            return View();
        }

        public async Task<ActionResult> GetServiceCodes()
        {
            try
            {
                var serviceResponse = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_ServiceType>>("ServiceManagement/GetServiceTypes");
                var st_list = new List<DO_ServiceType>();
                if (serviceResponse.Status)
                {
                    st_list = serviceResponse.Data.FindAll(w => w.ActiveStatus == true);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetServiceCodes:GetServiceTypes");
                }
                var serviceResponse1 = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_ServiceGroup>>("ServiceManagement/GetServiceGroups");
                var sg_list = new List<DO_ServiceGroup>();
                if (serviceResponse1.Status)
                {
                    sg_list = serviceResponse1.Data.FindAll(w => w.ActiveStatus == true);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse1.Message), "UD:GetServiceCodes:GetServiceGroups");
                }
                var serviceResponse2 = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_ServiceClass>>("ServiceManagement/GetServiceClasses");
                var sc_list = new List<DO_ServiceClass>();
                if (serviceResponse2.Status)
                {
                    sc_list = serviceResponse2.Data.FindAll(w => w.ActiveStatus == true);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse2.Message), "UD:GetServiceCodes:GetServiceClasses");
                }
                var serviceResponse3 = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_ServiceCode>>("ServiceManagement/GetServiceCodes");
                var sm_list = new List<DO_ServiceCode>();
                if (serviceResponse3.Status)
                {
                    sm_list = serviceResponse3.Data.FindAll(w => w.ActiveStatus == true);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse3.Message), "UD:GetServiceCodes:GetServiceCodes");
                }

                List<jsTreeObject> treeView = new List<jsTreeObject>();
                jsTreeObject jsObj = new jsTreeObject();
                jsObj.id = "SM";
                jsObj.parent = "#";
                jsObj.text = "Services";
                jsObj.icon = "/images/jsTree/foldergroupicon.png";
                jsObj.state = new stateObject { opened = true, selected = false };
                treeView.Add(jsObj);
                if (st_list != null)
                {
                    foreach (var st in st_list)
                    {
                        jsObj = new jsTreeObject();
                        jsObj.id = "T" + st.ServiceTypeId.ToString();
                        jsObj.text = st.ServiceTypeDesc;
                        jsObj.icon = "/images/jsTree/openfolder.png";
                        jsObj.parent = "SM";
                        jsObj.state = new stateObject { opened = false, selected = false };
                        treeView.Add(jsObj);
                        if (sg_list != null)
                        {
                            foreach (var sg in sg_list)
                            {
                                if (st.ServiceTypeId == sg.ServiceTypeId)
                                {
                                    jsObj = new jsTreeObject();
                                    jsObj.id = "G" + sg.ServiceGroupId.ToString();
                                    jsObj.text = sg.ServiceGroupDesc;
                                    jsObj.icon = "/images/jsTree/openfolder.png";
                                    jsObj.parent = "T" + st.ServiceTypeId.ToString();
                                    jsObj.state = new stateObject { opened = false, selected = false };
                                    treeView.Add(jsObj);


                                    if (sc_list != null)
                                    {
                                        foreach (var sc in sc_list)
                                        {
                                            if (sg.ServiceGroupId == sc.ServiceGroupId)
                                            {
                                                if (sc.ServiceClassId == sc.ParentId)
                                                {
                                                    jsObj = new jsTreeObject();
                                                    jsObj.id = "C" + sc.ServiceClassId.ToString();
                                                    jsObj.text = sc.ServiceClassDesc;
                                                    jsObj.icon = "/images/jsTree/openfolder.png";
                                                    jsObj.parent = "G" + sg.ServiceGroupId.ToString();
                                                    treeView.Add(jsObj);
                                                }
                                                else
                                                {
                                                    jsObj = new jsTreeObject();
                                                    jsObj.id = "C" + sc.ServiceClassId.ToString();
                                                    jsObj.text = sc.ServiceClassDesc;
                                                    jsObj.icon = "/images/jsTree/openfolder.png";
                                                    jsObj.parent = "C" + sc.ParentId.ToString();
                                                    treeView.Add(jsObj);
                                                }
                                                if (sm_list != null)
                                                {
                                                    foreach (var sm in sm_list)
                                                    {
                                                        if (sc.ServiceClassId == sm.ServiceClassId)
                                                        {
                                                            jsObj = new jsTreeObject();
                                                            jsObj.id = sm.ServiceId.ToString();
                                                            jsObj.text = sm.ServiceDesc;
                                                            jsObj.icon = "/images/jsTree/fileIcon.png";
                                                            jsObj.parent = "C" + sc.ServiceClassId.ToString();
                                                            treeView.Add(jsObj);
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                return Json(treeView);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetServiceCodes");
                return Json(new DO_ReturnParameter() { Status = false, Message = ex.ToString() });
                throw ex;
            }



        }
        public async Task<ActionResult> GetServiceCodeByID(int ServiceID)
        {
            try
            {
                var serviceResponse = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<DO_ServiceCode>("ServiceManagement/GetServiceCodeByID?ServiceID=" + ServiceID);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        var data = serviceResponse.Data;
                        return Json(data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetServiceCodeByID:For ServiceID {0}", ServiceID);
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                    }

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetServiceCodeByID:For ServiceID {0}", ServiceID);
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetServiceCodeByID:For ServiceID {0}", ServiceID);
                return Json(new DO_ReturnParameter() { Status = false, Message = ex.ToString() });
            }
        }
        public async Task<ActionResult> AddOrUpdateServiceCode(DO_ServiceCode obj)
        {
            try
            {
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                obj.CreatedOn = DateTime.Now;
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

                var serviceResponse = await _eSyaServicesAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("ServiceManagement/AddOrUpdateServiceCode", obj);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Data.Message), "UD:AddOrUpdateServiceCode:params:" + JsonConvert.SerializeObject(obj));
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Data.Message });
                    }

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:AddOrUpdateServiceCode:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:AddOrUpdateServiceCode:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }
        #endregion

        #region ServiceCodePattern

        /// <summary>
        /// Service Code Pattern
        /// </summary>
        /// <returns></returns>

        [Area("eSyaServices")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> V_1504_00()
        {
            ViewBag.formName = "Service Code Pattern";
            // ViewBag.UserFormRoles = new DO_UserFormRole { IsInsert = true, IsEdit = true, IsDelete = true };
            var serviceResponse = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_ServiceClass>>("ServiceManagement/GetServiceClasses");
            if (serviceResponse.Status)
            {
                if (serviceResponse.Data != null)
                {
                    var sc_list = serviceResponse.Data.FindAll(w => w.ActiveStatus == true);
                    ViewBag.ServiceClasses = sc_list;
                }
            }
            else
            {
                _logger.LogError(new Exception(serviceResponse.Message), "UD:V_1504_00:GetServiceClasses");
            }
            return View();
        }

        public async Task<ActionResult> GetServiceCodePatterns()
        {
            try
            {
                var serviceResponse = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_ServiceCodePattern>>("ServiceManagement/GetServiceCodePatterns");
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        var Patterns_list = serviceResponse.Data;
                        return Json(Patterns_list);
                    }
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetServiceCodePatterns");
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

                
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetServiceCodePatterns");
                return Json(new DO_ReturnParameter() { Status = false, Message = ex.Message });
            }
        }
        public async Task<ActionResult> AddServiceCodePattern(DO_ServiceCodePattern obj)
        {
            try
            {
                //obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                obj.FormId = "V_1504_00";
                obj.CreatedOn = DateTime.Now;
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

                var serviceResponse = await _eSyaServicesAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("ServiceManagement/AddServiceCodePattern", obj);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Data.Message), "UD:AddServiceCodePattern:params:" + JsonConvert.SerializeObject(obj));
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Data.Message });
                    }

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:AddServiceCodePattern:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:AddServiceCodePattern:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = ex.ToString() });
            }
        }

        #endregion

        #region ServiceBusinessLink

        /// <summary>
        /// Service Business Locations
        /// </summary>
        /// <returns></returns>

        [Area("eSyaServices")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult V_1511_00()
        {
            // ViewBag.UserFormRoles = new DO_UserFormRole { IsInsert = true, IsEdit = true, IsView = true };
            return View();
        }

        /// <summary>
        /// Business Location Service Link
        /// </summary>
        /// <returns></returns>

        [Area("eSyaServices")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> V_1512_00()
        {
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
                _logger.LogError(new Exception(serviceResponse.Message), "UD:V_1511_00:GetBusinessKey");
            }
            return View();
        }


        /// <summary>
        /// Business Location Services
        /// </summary>
        /// <returns></returns>

        [Area("eSyaServices")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> V_1513_00()
        {
            // ViewBag.UserFormRoles = new DO_UserFormRole { IsInsert = true, IsEdit = true, IsDelete = true };
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
                _logger.LogError(new Exception(serviceResponse.Message), "UD:V_1513_00:GetBusinessKey");
            }
            return View();
        }

        public async Task<ActionResult> GetBusinessLocationServices(int businessKey)
        {
            try
            {
                var serviceResponse = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_ServiceBusinessLink>>("ServiceManagement/GetBusinessLocationServices?businessKey=" + businessKey);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        var ServiceBusinessLink_list = serviceResponse.Data;
                        return Json(ServiceBusinessLink_list);
                    }
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetBusinessLocationServices:For BusinessKey {0}", businessKey);
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }


            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetBusinessLocationServices:For BusinessKey {0}", businessKey);
                return Json(new DO_ReturnParameter() { Status = false, Message = ex.Message });
            }
        }
        public async Task<ActionResult> AddOrUpdateBusinessLocationServices(List<DO_ServiceBusinessLink> obj)
        {
            try
            {
                foreach (var ser_bl in obj)
                {
                    ser_bl.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                    ser_bl.CreatedOn = DateTime.Now;
                    ser_bl.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                    ser_bl.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                }
                

                var serviceResponse = await _eSyaServicesAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("ServiceManagement/AddOrUpdateBusinessLocationServices", obj);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Data.Message), "UD:AddOrUpdateBusinessLocationServices:params:" + JsonConvert.SerializeObject(obj));
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Data.Message });
                    }

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:AddOrUpdateBusinessLocationServices:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:AddOrUpdateBusinessLocationServices:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }
        public async Task<ActionResult> GetServiceBusinessLocations(int ServiceId)
        {
            try
            {
                var serviceResponse = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_ServiceBusinessLink>>("ServiceManagement/GetServiceBusinessLocations?ServiceId=" + ServiceId);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        var ServiceBusinessLink_list = serviceResponse.Data;
                        return Json(ServiceBusinessLink_list);
                    }
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetServiceBusinessLocations:For ServiceId {0}", ServiceId);
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }


            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetServiceBusinessLocations:For ServiceId {0}", ServiceId);
                return Json(new DO_ReturnParameter() { Status = false, Message = ex.Message });
            }
        }
        public async Task<ActionResult> UpdateServiceBusinessLocations(List<DO_ServiceBusinessLink> obj)
        {
            try
            {
                foreach (var ser_bl in obj)
                {
                    ser_bl.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                    ser_bl.CreatedOn = DateTime.Now;
                    ser_bl.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                    ser_bl.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                }


                var serviceResponse = await _eSyaServicesAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("ServiceManagement/UpdateServiceBusinessLocations", obj);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Data.Message), "UD:UpdateServiceBusinessLocations:params:" + JsonConvert.SerializeObject(obj));
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Data.Message });
                    }

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:UpdateServiceBusinessLocations:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:UpdateServiceBusinessLocations:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }
        public async Task<ActionResult> GetServiceBusinessLink(int businessKey)
        {
            try
            {
                var serviceResponse = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_ServiceType>>("ServiceManagement/GetServiceTypes");
                var st_list = new List<DO_ServiceType>();
                if (serviceResponse.Status)
                {
                    st_list = serviceResponse.Data.FindAll(w => w.ActiveStatus == true);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetServiceBusinessLink:GetServiceTypes");
                }
                var serviceResponse1 = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_ServiceGroup>>("ServiceManagement/GetServiceGroups");
                var sg_list = new List<DO_ServiceGroup>();
                if (serviceResponse.Status)
                {
                    sg_list = serviceResponse1.Data.FindAll(w => w.ActiveStatus == true);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetServiceBusinessLink:GetServiceGroups");
                }
                var serviceResponse2 = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_ServiceClass>>("ServiceManagement/GetServiceClasses");
                var sc_list = new List<DO_ServiceClass>();
                if (serviceResponse.Status)
                {
                    sc_list = serviceResponse2.Data.FindAll(w => w.ActiveStatus == true);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetServiceBusinessLink:GetServiceClasses");
                }
                var serviceResponse3 = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_ServiceCode>>("ServiceManagement/GetServiceBusinessLink?businessKey=" + businessKey);
                var sm_list = new List<DO_ServiceCode>();
                if (serviceResponse.Status)
                {
                    sm_list = serviceResponse3.Data.FindAll(w => w.ActiveStatus == true);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetServiceBusinessLink:GetServiceBusinessLink:For BusinessKey {0}", businessKey);
                }

                List<jsTreeObject> treeView = new List<jsTreeObject>();
                jsTreeObject jsObj = new jsTreeObject();
                jsObj.id = "SM";
                jsObj.parent = "#";
                jsObj.text = "Services";
                jsObj.icon = "/images/jsTree/foldergroupicon.png";
                jsObj.state = new stateObject { opened = true, selected = false, checkbox_disabled = false };
                treeView.Add(jsObj);
                if (st_list != null)
                {
                    foreach (var st in st_list)
                    {
                        jsObj = new jsTreeObject();
                        jsObj.id = "T" + st.ServiceTypeId.ToString();
                        jsObj.text = st.ServiceTypeDesc;
                        jsObj.icon = "/images/jsTree/openfolder.png";
                        jsObj.parent = "SM";
                        jsObj.state = new stateObject { opened = false, selected = false, checkbox_disabled = false };
                        treeView.Add(jsObj);
                        if (sg_list != null)
                        {
                            foreach (var sg in sg_list)
                            {
                                if (st.ServiceTypeId == sg.ServiceTypeId)
                                {
                                    jsObj = new jsTreeObject();
                                    jsObj.id = "G" + sg.ServiceGroupId.ToString();
                                    jsObj.text = sg.ServiceGroupDesc;
                                    jsObj.icon = "/images/jsTree/openfolder.png";
                                    jsObj.parent = "T" + st.ServiceTypeId.ToString();
                                    jsObj.state = new stateObject { opened = false, selected = false,checkbox_disabled = false };
                                    treeView.Add(jsObj);


                                    if (sc_list != null)
                                    {
                                        foreach (var sc in sc_list)
                                        {
                                            if (sg.ServiceGroupId == sc.ServiceGroupId)
                                            {
                                                if (sc.ServiceClassId == sc.ParentId)
                                                {
                                                    jsObj = new jsTreeObject();
                                                    jsObj.id = "C" + sc.ServiceClassId.ToString();
                                                    jsObj.text = sc.ServiceClassDesc;
                                                    jsObj.icon = "/images/jsTree/openfolder.png";
                                                    jsObj.parent = "G" + sg.ServiceGroupId.ToString();
                                                    jsObj.state = new stateObject { opened = false, selected = false, checkbox_disabled = false };
                                                    treeView.Add(jsObj);
                                                }
                                                else
                                                {
                                                    jsObj = new jsTreeObject();
                                                    jsObj.id = "C" + sc.ServiceClassId.ToString();
                                                    jsObj.text = sc.ServiceClassDesc;
                                                    jsObj.icon = "/images/jsTree/openfolder.png";
                                                    jsObj.parent = "C" + sc.ParentId.ToString();
                                                    jsObj.state = new stateObject { opened = false, selected = false, checkbox_disabled = false };
                                                    treeView.Add(jsObj);
                                                }
                                                if (sm_list != null)
                                                {
                                                    foreach (var sm in sm_list)
                                                    {
                                                        if (sc.ServiceClassId == sm.ServiceClassId)
                                                        {
                                                            jsObj = new jsTreeObject();
                                                            jsObj.id = "S" + sm.ServiceId.ToString();
                                                            jsObj.text = sm.ServiceDesc;
                                                            jsObj.icon = "/images/jsTree/fileIcon.png";
                                                            jsObj.parent = "C" + sc.ServiceClassId.ToString();
                                                            jsObj.state = new stateObject { opened = false, selected = sm.BusinessLinkStatus, checkbox_disabled = false };
                                                            treeView.Add(jsObj);
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                return Json(treeView);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetServiceCodes");
                return Json(new DO_ReturnParameter() { Status = false, Message = ex.ToString() });
                throw ex;
            }



        }

        #endregion

        #region ServiceMaster

        /// <summary>
        /// Service Master
        /// </summary>
        /// <returns></returns>

        [Area("eSyaServices")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> V_1515_00()
        {
            ViewBag.UserFormRoles = new DO_UserFormRole { IsInsert = true, IsEdit = true, IsDelete = true };
            var serviceResponse = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_ServiceType>>("ServiceManagement/GetServiceTypes");
            if (serviceResponse.Status)
            {
                if (serviceResponse.Data != null)
                {
                    var st_list = new List<DO_ServiceType>();
                    st_list = serviceResponse.Data.FindAll(w => w.ActiveStatus == true);
                    ViewBag.ServiceType = st_list.Select(t => new SelectListItem
                    {
                        Value = t.ServiceTypeId.ToString(),
                        Text = t.ServiceTypeDesc,
                    }).ToList();
                }
            }
            else
            {
                _logger.LogError(new Exception(serviceResponse.Message), "UD:V_1515_00:GetServiceTypes");
            }
            var serviceResponse1 = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_ServiceGroup>>("ServiceManagement/GetServiceGroups");
            if (serviceResponse1.Status)
            {
                if (serviceResponse1.Data != null)
                {
                    var sg_list = new List<DO_ServiceGroup>();
                    sg_list = serviceResponse1.Data.FindAll(w => w.ActiveStatus == true);
                    ViewBag.ServiceGroup = sg_list.Select(g => new SelectListItem
                    {
                        Value = g.ServiceGroupId.ToString(),
                        Text = g.ServiceGroupDesc,
                    }).ToList();
                }
            }
            else
            {
                _logger.LogError(new Exception(serviceResponse1.Message), "UD:V_1515_00:GetServiceGroups");
            }
            var serviceResponse2 = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_ServiceClass>>("ServiceManagement/GetServiceClasses");
            if (serviceResponse2.Status)
            {
                if (serviceResponse2.Data != null)
                {
                    var sc_list = new List<DO_ServiceClass>();
                    sc_list = serviceResponse2.Data.FindAll(w => w.ActiveStatus == true);
                    ViewBag.ServiceClass = sc_list.Select(c => new SelectListItem
                    {
                        Value = c.ServiceClassId.ToString(),
                        Text = c.ServiceClassDesc,
                    }).ToList();
                }
            }
            else
            {
                _logger.LogError(new Exception(serviceResponse1.Message), "UD:V_1515_00:GetServiceClasses");
            }


            return View();

        }

        public async Task<ActionResult> GetServiceMaster(int servicetype, int servicegroup, int serviceclass)
        {
            try
            {
                var param = "?servicetype=" + servicetype;
                param += "&servicegroup=" + servicegroup;
                param += "&serviceclass=" + serviceclass;
                var serviceResponse = await _eSyaServicesAPIServices.HttpClientServices.GetAsync<List<DO_ServiceCode>>("ServiceManagement/GetServiceMaster"+param);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        var ServiceMaster_list = serviceResponse.Data;
                        return Json(ServiceMaster_list);
                    }
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetServiceMaster");
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }


            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetServiceMaster");
                return Json(new DO_ReturnParameter() { Status = false, Message = ex.Message });
            }
        }
        #endregion


    }
}