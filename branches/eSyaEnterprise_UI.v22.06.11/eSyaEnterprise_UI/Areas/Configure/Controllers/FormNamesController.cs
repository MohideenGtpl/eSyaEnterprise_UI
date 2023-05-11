﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using eSyaEnterprise_UI.ActionFilter;
using eSyaEnterprise_UI.Areas.Configure.Data;
using eSyaEnterprise_UI.Areas.Configure.Models;
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

namespace eSyaEnterprise_UI.Areas.Configure.Controllers
{
    [SessionTimeout]
    public class FormNamesController : Controller
    {
        private readonly IConfigAPIServices _configAPIServices;
        private readonly ILogger<FormNamesController> _logger;

        public FormNamesController(IConfigAPIServices configAPIServices, ILogger<FormNamesController> logger)
        {
            _configAPIServices = configAPIServices;
            _logger = logger;
        }

        #region Forms
        [Area("Configure")]
        //[ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult ECA_01_00()
        {
            ViewBag.UserFormRole = new DO_UserFormRole {
                IsInsert = true,
                IsEdit = true,
                IsDelete = true,
                IsView = true
            };
            var serviceResponse = _configAPIServices.HttpClientServices.GetAsync<List<DO_AreaController>>("Forms/GetAreaController").Result;
            if (serviceResponse.Status)
            {
                ViewBag.AreaController = serviceResponse.Data;
            }
            else
            {
                _logger.LogError(new Exception(serviceResponse.Message), "UD:ECA_01_00");
            }
            return View();
        }

        public JsonResult GetAreaController()
        {
            try
            {
                var serviceResponse = _configAPIServices.HttpClientServices.GetAsync<DO_AreaController>("Forms/GetAreaController").Result;
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetAreaController");
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetAreaController");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }


        public JsonResult GetFormList()
        {
            try
            {
                string baseURL = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}";
                List<jsTreeObject> treeView = new List<jsTreeObject>();

                jsTreeObject jsObj = new jsTreeObject
                {
                    id = "FM",
                    parent = "#",
                    text = "eSya Forms",
                    icon = baseURL+"/images/jsTree/foldergroupicon.png",
                    state = new stateObject { opened = true, selected = false }
                };
                treeView.Add(jsObj);

                var serviceResponse1 = _configAPIServices.HttpClientServices.GetAsync<List<DO_Forms>>("Forms/GetFormDetails").Result;
                if (serviceResponse1.Status)
                {
                    foreach (var fm in serviceResponse1.Data)
                    {
                        jsObj = new jsTreeObject
                        {
                            id = fm.FormID.ToString(),
                            text = fm.FormCode.ToString() + '.' + fm.FormName,
                            icon = baseURL+"/images/jsTree/openfolder.png",
                            parent = "FM"
                        };
                        treeView.Add(jsObj);
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse1.Message), "UD:GetFormList");
                }

                var serviceResponse = _configAPIServices.HttpClientServices.GetAsync<List<DO_Forms>>("Forms/GetInternalFormDetails").Result;
                if (serviceResponse.Status)
                {
                    var fn_list = serviceResponse.Data;
                    foreach (var fn in fn_list.Where(w => fn_list.Any(f => f.FormID == w.FormID)))
                    {
                        jsObj = new jsTreeObject
                        {
                            id = fn.FormID.ToString() + "-" + fn.InternalFormNumber.ToString(),
                            text = fn.InternalFormNumber + "-" + fn.FormName,
                            icon = baseURL+"/images/jsTree/fileIcon.png",
                            parent = fn.FormID.ToString()
                        };
                        treeView.Add(jsObj);
                    }


                    return Json(treeView);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetFormList");
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetFormList");
                throw ex;
            }
        }

        public JsonResult GetFormMasterByID(int formID)
        {
            try
            {
                var serviceResponse = _configAPIServices.HttpClientServices.GetAsync<DO_Forms>("Forms/GetFormDetailsByID?formID=" + formID).Result;
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetFormMasterByID:params:" + JsonConvert.SerializeObject(new { formID }));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetFormMasterByID:params:" + JsonConvert.SerializeObject(new { formID }));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        public JsonResult GetInternalFormByFormID(int formID)
        {
            try
            {
                var serviceResponse = _configAPIServices.HttpClientServices.GetAsync<List<DO_Forms>>("Forms/GetInternalFormByFormID?formID=" + formID).Result;
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetInternalFormByFormID:params:" + JsonConvert.SerializeObject(new { formID }));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetInternalFormByFormID:params:" + JsonConvert.SerializeObject(new { formID }));
                throw ex;
            }
        }

        [HttpPost]
        public JsonResult InsertUpdateIntoFormMaster(DO_Forms obj)
        {
            try
            {
                //if (obj.FormID <= 0)
                //{
                //    return Json(new DO_ReturnParameter() { Status = false, Message = "Form Id cannot be blank" });
                //}

                if (string.IsNullOrEmpty(obj.FormName))
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Form Name cannot be blank" });
                }
                else if (string.IsNullOrEmpty(obj.ControllerName))
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Controller Name cannot be blank" });
                }
                else if (obj.IsStoreLink && obj.l_FormParameter.Count() <= 0)
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "please select the store" });
                }
                else
                {
                    obj.ActiveStatus = true;
                    obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                    obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

                    var serviceResponse = _configAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Forms/InsertUpdateIntoFormMaster", obj).Result;
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertUpdateIntoFormMaster:params:" + JsonConvert.SerializeObject(obj));
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertUpdateIntoFormMaster:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }

        public JsonResult GetNextInternalFormByID(int formID)
        {
            try
            {
                var serviceResponse = _configAPIServices.HttpClientServices.GetAsync<DO_Forms>("Forms/GetNextInternalFormByID?formID=" + formID).Result;
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetNextInternalFormByID:params:" + JsonConvert.SerializeObject(new { formID }));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetNextInternalFormByID:params:" + JsonConvert.SerializeObject(new { formID }));
                throw ex;
            }
        }

        [HttpPost]
        public JsonResult InsertIntoInternalForm(DO_Forms obj)
        {
            try
            {
                if (obj.FormID == 0)
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "First add the form" });
                }
                else
                {
                    if (string.IsNullOrEmpty(obj.InternalFormNumber))
                    {
                        return Json(new DO_ReturnParameter() { Status = false, Message = "Internal Form Number cannot be blank" });
                    }
                    else if (string.IsNullOrEmpty(obj.FormDescription))
                    {
                        return Json(new DO_ReturnParameter() { Status = false, Message = "Form Description cannot be blank" });
                    }

                    obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                    obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

                    var serviceResponse = _configAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Forms/InsertIntoInternalForm", obj).Result;

                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertIntoInternalForm:params:" + JsonConvert.SerializeObject(obj));
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertIntoInternalForm:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        public JsonResult GetFormActionByID(int formID)
        {
            try
            {
                var serviceResponse = _configAPIServices.HttpClientServices.GetAsync<List<DO_FormAction>>("Forms/GetFormActionByID?formID=" + formID).Result;
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetFormActionByID:params:" + JsonConvert.SerializeObject(new { formID }));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetFormActionByID:Params:" + JsonConvert.SerializeObject(new { formID }));
                throw ex;
            }
        }

        [HttpPost]
        public JsonResult InsertIntoFormAction(DO_Forms obj)
        {
            try
            {
                if (obj.FormID == 0)
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "First add the form" });
                }
                else
                {
                    obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                    obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

                    var serviceResponse = _configAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Forms/InsertIntoFormAction", obj).Result;
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                    {
                        _logger.LogError(serviceResponse.Message, "UD:InsertIntoFormAction:Params:" + JsonConvert.SerializeObject(obj));
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertIntoFormAction:Params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        public JsonResult GetFormParameterByID(int formID)
        {
            try
            {
                var serviceResponse = _configAPIServices.HttpClientServices.GetAsync<List<DO_FormParameter>>("Forms/GetFormParameterByID?formID=" + formID).Result;
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetFormParameterByID:params:" + JsonConvert.SerializeObject(new { formID }));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetFormParameterByID:Params:" + JsonConvert.SerializeObject(new { formID }));
                throw ex;
            }
        }

        [HttpPost]
        public JsonResult InsertIntoFormParameter(DO_Forms obj)
        {
            try
            {
                if (obj.FormID == 0)
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "First add the form" });
                }
                else
                {
                    obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                    obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

                    var serviceResponse = _configAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Forms/InsertIntoFormParameter", obj).Result;
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                    {
                        _logger.LogError(serviceResponse.Message, "UD:InsertIntoFormParameter:Params:" + JsonConvert.SerializeObject(obj));
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertIntoFormParameter:Params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        public JsonResult GetFormSubParameterByID(int formID, int parameterId)
        {
            try
            {
                var serviceResponse = _configAPIServices.HttpClientServices.GetAsync<List<DO_FormSubParameter>>("Forms/GetFormSubParameterByID?formID=" + formID + "&parameterId=" + parameterId).Result;
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetFormSubParameterByID:params:" + JsonConvert.SerializeObject(new { formID }));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetFormSubParameterByID:Params:" + JsonConvert.SerializeObject(new { formID }));
                throw ex;
            }
        }

        [HttpPost]
        public JsonResult InsertIntoFormSubParameter(DO_Forms obj)
        {
            try
            {
                if (obj.FormID == 0)
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "First add the form" });
                }
                else
                {
                    obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                    obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

                    var serviceResponse = _configAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Forms/InsertIntoFormSubParameter", obj).Result;
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                    {
                        _logger.LogError(serviceResponse.Message, "UD:InsertIntoFormSubParameter:Params:" + JsonConvert.SerializeObject(obj));
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertIntoFormSubParameter:Params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        #endregion Forms
    }
}