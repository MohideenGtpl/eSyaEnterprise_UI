using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using eSyaEnterprise_UI.ActionFilter;
using eSyaEnterprise_UI.Areas.Config.Data;
using eSyaEnterprise_UI.Areas.Config.Models;
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

namespace eSyaEnterprise_UI.Areas.eSyaConfig.Controllers
{
    [SessionTimeout]
    public class FormsMenuController : Controller
    {
        private readonly IeSyaConfigAPIServices _eSyaConfigAPIServices;
        private readonly ILogger<FormsMenuController> _logger;

        public FormsMenuController(IeSyaConfigAPIServices eSyaConfigAPIServices, ILogger<FormsMenuController> logger)
        {
            _eSyaConfigAPIServices = eSyaConfigAPIServices;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        #region Forms

        [Area("eSyaConfig")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult V_1_00()
        {
            //ViewBag.UserFormRoles = new DO_UserFormRole { IsInsert = false, IsEdit = true, IsDelete = true };
            var serviceResponse = _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_AreaController>>("Forms/GetAreaController").Result;
            if (serviceResponse.Status)
            {
                ViewBag.AreaController = serviceResponse.Data;
            }
            else
            {
                _logger.LogError(new Exception(serviceResponse.Message), "UD:V_1_00");
            }
            return View();
        }

        public JsonResult GetAreaController()
        {
            try
            {
                var serviceResponse = _eSyaConfigAPIServices.HttpClientServices.GetAsync<DO_AreaController>("Forms/GetAreaController").Result;
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

                var serviceResponse1 = _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_Forms>>("Forms/GetFormDetails").Result;
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

                var serviceResponse = _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_Forms>>("Forms/GetInternalFormDetails").Result;
                if (serviceResponse.Status)
                {
                    var fn_list = serviceResponse.Data;
                    foreach (var fn in fn_list.Where(w => fn_list.Any(f => f.FormID == w.FormID)))
                    {
                        jsObj = new jsTreeObject
                        {
                            id = fn.FormID.ToString() + "-" + fn.InternalFormNumber.ToString(),
                            text = fn.InternalFormNumber + "-" + fn.FormName,
                            icon = "/images/jsTree/fileIcon.png",
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
                var serviceResponse = _eSyaConfigAPIServices.HttpClientServices.GetAsync<DO_Forms>("Forms/GetFormDetailsByID?formID=" + formID).Result;
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
                var serviceResponse = _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_Forms>>("Forms/GetInternalFormByFormID?formID=" + formID).Result;
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

                    var serviceResponse = _eSyaConfigAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Forms/InsertUpdateIntoFormMaster", obj).Result;
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
                var serviceResponse = _eSyaConfigAPIServices.HttpClientServices.GetAsync<DO_Forms>("Forms/GetNextInternalFormByID?formID=" + formID).Result;
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

                    var serviceResponse = _eSyaConfigAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Forms/InsertIntoInternalForm", obj).Result;

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
                var serviceResponse = _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_FormAction>>("Forms/GetFormActionByID?formID=" + formID).Result;
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

                    var serviceResponse = _eSyaConfigAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Forms/InsertIntoFormAction", obj).Result;
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
                var serviceResponse = _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_FormParameter>>("Forms/GetFormParameterByID?formID=" + formID).Result;
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

                    var serviceResponse = _eSyaConfigAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Forms/InsertIntoFormParameter", obj).Result;
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
                var serviceResponse = _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_FormSubParameter>>("Forms/GetFormSubParameterByID?formID=" + formID+ "&parameterId=" + parameterId).Result;
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

                    var serviceResponse = _eSyaConfigAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Forms/InsertIntoFormSubParameter", obj).Result;
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

        #endregion


        #region Configure Menu

        string _MenuJSONFilePath = @"wwwroot\json\menuitem.json";


        /// <summary>
        /// Configure Menu
        /// </summary>
        /// <returns></returns>
        /// 
        [Area("eSyaConfig")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult V_2_00()
        {
            var serviceResponse = _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_Forms>>("Forms/GetFormDetails").Result;
            if (serviceResponse.Status)
            {
                var fm_list = serviceResponse.Data;
                ViewBag.FormList = fm_list;
            }
            else
            {
                _logger.LogError(new Exception(serviceResponse.Message), "UD:V_2_00");
            }


            return View();
        }

        [Produces("application/json")]
        [HttpGet]
        public IActionResult GetConfigureMenuTreeView()
        {
            try
            {

                List<jsTreeObject> jsTree = new List<jsTreeObject>();

                var eSyaMenuData = JsonStream.Read<MenuItem>(_MenuJSONFilePath);
                if (eSyaMenuData == null)
                    eSyaMenuData = new MenuItem() { MenuName = "eSya Menu" };

                jsTreeObject jsObj1 = new jsTreeObject
                {
                    id = "MM",
                    parent = "#",
                    text = eSyaMenuData.MenuName,
                    icon = "/images/jsTree/foldergroupicon.png",
                    state = new stateObject { opened = true, selected = false }
                };
                jsTree.Add(jsObj1);

                var serviceResponse = _eSyaConfigAPIServices.HttpClientServices.GetAsync<DO_ConfigureMenu>("eSyaConfigureMenu/GetConfigureMenuMaster").Result;
                if (serviceResponse.Status)
                {
                    var configureMenu = serviceResponse.Data;

                    if (configureMenu != null)
                    {
                        List<DO_SubMenu> l_menu = new List<DO_SubMenu>();
                        //Add Main Menu
                        foreach (var m in configureMenu.l_MainMenu.OrderBy(o => o.MenuIndex))
                        {
                            jsTreeObject jsObj = new jsTreeObject
                            {
                                id = "MM" + m.MainMenuId.ToString(),
                                text = m.MainMenu,
                                icon = m.ActiveStatus ? "/images/jsTree/openfolder.png" : "/images/jsTree/inactive.png",
                                GroupIndex = m.MenuIndex.ToString(),
                                parent = "MM",
                            };
                            jsTree.Add(jsObj);

                            var sb = GetMenuFormItems(m.MainMenuId, 0, configureMenu.l_SubMenu, configureMenu.l_FormMenu);
                            l_menu.AddRange(sb);

                            //var sb1 = configureMenu.l_SubMenu.Where(w => w.MainMenuId == m.MainMenuId && w.ParentID == 0).OrderBy(o => o.MenuIndex).ToList();
                            //var fm1 = configureMenu.l_FormMenu.Where(w => w.MainMenuId == m.MainMenuId && w.MenuItemId == 0).OrderBy(o => o.FormIndex);
                            //foreach (var f in fm1)
                            //{
                            //    DO_SubMenu o = new DO_SubMenu();
                            //    o.FormId = f.FormId;
                            //    o.MenuItemName = f.FormNameClient;
                            //    o.ActiveStatus = f.ActiveStatus;
                            //    o.MenuIndex = f.FormIndex;
                            //    o.ParentID = 0;
                            //    o.MenuItemId = f.MenuItemId;
                            //    o.MainMenuId = f.MainMenuId;
                            //    o.IsForm = true;
                            //    sb1.Add(o);
                            //}
                            //l_menu.AddRange(sb1);

                            //foreach(var s in sb1)
                            //{
                            //    var sb2 = configureMenu.l_SubMenu.Where(w => w.MainMenuId == m.MainMenuId && w.ParentID != 0  && w.ParentID == s.MenuItemId).OrderBy(o => o.MenuIndex).ToList();
                            //    var fm2 = configureMenu.l_FormMenu.Where(w => w.MainMenuId == m.MainMenuId && w.MenuItemId != 0 && w.MenuItemId == s.MenuItemId).OrderBy(o => o.FormIndex);
                            //    foreach (var f in fm2)
                            //    {
                            //        DO_SubMenu o = new DO_SubMenu();
                            //        o.FormId = f.FormId;
                            //        o.MenuItemName = f.FormNameClient;
                            //        o.ActiveStatus = f.ActiveStatus;
                            //        o.MenuIndex = f.FormIndex;
                            //        o.ParentID = f.MenuItemId;
                            //        o.MenuItemId = f.MenuItemId;
                            //        o.MainMenuId = f.MainMenuId;
                            //        o.IsForm = true;
                            //        sb2.Add(o);
                            //    }
                            //    l_menu.AddRange(sb2);
                            //}


                        }


                        //Add Sub Menu
                        //foreach (var s in configureMenu.l_SubMenu.OrderBy(o => o.MenuIndex))
                        var menu = l_menu.OrderBy(o => o.MenuIndex);
                        foreach (var s in menu)
                        {
                            if (!s.IsForm)
                            {
                                jsTreeObject jsObj = new jsTreeObject
                                {
                                    id = "SM" + s.MenuItemId.ToString(),
                                    text = s.MenuItemName,
                                    //icon = "/images/jsTree/openfolder.png",
                                    icon = s.ActiveStatus ? "/images/jsTree/openfolder.png" : "/images/jsTree/inactive.png",
                                    GroupIndex = s.MenuIndex.ToString(),
                                    parent = s.ParentID == 0 ? "MM" + s.MainMenuId.ToString() : "SM" + s.ParentID.ToString()
                                };
                                jsTree.Add(jsObj);

                            }
                            else
                            {
                                jsTreeObject jsObj = new jsTreeObject
                                {
                                    id = "FM" + s.ParentID.ToString() + "_" + s.FormId.ToString(),
                                    text = s.MenuItemName,
                                    //icon = "/images/jsTree/fileIcon.png",
                                    icon = s.ActiveStatus ? "/images/jsTree/fileIcon.png" : "/images/jsTree/inactive.png",
                                    GroupIndex = s.MenuIndex.ToString(),
                                    //parent = "MM" + s.MainMenuId.ToString()
                                    parent = s.ParentID == 0 ? "MM" + s.MainMenuId.ToString() : "SM" + s.ParentID.ToString()
                                };
                                jsTree.Add(jsObj);
                            }
                        }

                        //Add Form
                        //foreach (var f in configureMenu.l_FormMenu.Where(w => w.MenuItemId != 0).OrderBy(o => o.FormIndex))
                        //{
                        //    jsObj = new jsTreeObject
                        //    {
                        //        id = "FM" + f.MenuItemId.ToString() + "_" + f.FormId.ToString(),
                        //        text = f.FormNameClient,
                        //        //icon = "/images/jsTree/fileIcon.png",
                        //        icon = f.ActiveStatus ? "/images/jsTree/fileIcon.png" : "/images/jsTree/inactive.png",
                        //        GroupIndex = f.FormIndex.ToString(),
                        //        parent = f.MenuItemId == 0 ? "MM" + f.MainMenuId.ToString() : "SM" + f.MenuItemId.ToString()
                        //    };
                        //    jsTree.Add(jsObj);
                        //}

                    }

                    return Json(jsTree);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetConfigureMenuTreeView");
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetConfigureMenuTreeView");
                throw ex;
            }
        }

        public List<DO_SubMenu> GetMenuFormItems(int mainMenuID, int menuItemID, List<DO_SubMenu> l_SubMenu, List<DO_FormMenu> l_FormMenu)
        {
            List<DO_SubMenu> l_menu = new List<DO_SubMenu>();
            var sb2 = l_SubMenu.Where(w => w.MainMenuId == mainMenuID && w.ParentID == menuItemID).OrderBy(o => o.MenuIndex).ToList();
            var fm2 = l_FormMenu.Where(w => w.MainMenuId == mainMenuID && w.MenuItemId == menuItemID).OrderBy(o => o.FormIndex);
            foreach (var f in fm2)
            {
                DO_SubMenu o = new DO_SubMenu();
                o.FormId = f.FormId;
                o.MenuItemName = f.FormNameClient;
                o.ActiveStatus = f.ActiveStatus;
                o.MenuIndex = f.FormIndex;
                o.ParentID = f.MenuItemId;
                o.MenuItemId = f.MenuItemId;
                o.MainMenuId = f.MainMenuId;
                o.IsForm = true;
                l_menu.Add(o);
            }
            l_menu.AddRange(sb2);

            foreach(var s in sb2)
                l_menu.AddRange(GetMenuFormItems(mainMenuID, s.MenuItemId, l_SubMenu, l_FormMenu));

            return l_menu;
        }

        public JsonResult GeteSyaMenuItem()
        {
            try
            {
                var eSyaMenuData = JsonStream.Read<MenuItem>(_MenuJSONFilePath);
                return Json(eSyaMenuData);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GeteSyaMenuItem");
                throw ex;
            }
        }


        public JsonResult UpdateeSyaMenuItem(MenuItem obj)
        {
            try
            {
                JsonStream.Write<MenuItem>(obj, _MenuJSONFilePath);
                return Json(new DO_ReturnParameter() { Status = true });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:UpdateeSyaMenuItem:Params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false });
            }
        }


        #region MainMenu

        public JsonResult GetMainMenuByID(int mainMenuId)
        {
            try
            {
                var serviceResponse = _eSyaConfigAPIServices.HttpClientServices.GetAsync<DO_MainMenu>("eSyaConfigureMenu/GetMainMenuById?mainMenuId=" + mainMenuId).Result;
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetMainMenuByID:params:" + JsonConvert.SerializeObject(new { mainMenuId }));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetMainMenuByID:Params:" + JsonConvert.SerializeObject(new { mainMenuId }));
                throw ex;
            }
        }

        [HttpPost]
        public JsonResult InsertIntoMainMenu(DO_MainMenu obj)
        {
            try
            {
                obj.UserId = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalId = AppSessionVariables.GetIPAddress(HttpContext);

                var serviceResponse = _eSyaConfigAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("eSyaConfigureMenu/InsertIntoMainMenu", obj).Result;
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertIntoMainMenu:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertIntoMainMenu:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        [HttpPost]
        public JsonResult UpdateMainMenuIndex(int mainMenuID, bool isMoveUp, bool isMoveDown)
        {
            try
            {
                var serviceResponse = _eSyaConfigAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("eSyaConfigureMenu/UpdateMainMenuIndex?mainMenuId=" + mainMenuID + "&isMoveUp=" + isMoveUp + "&isMoveDown=" + isMoveDown).Result;
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:UpdateMainMenuIndex:params:" + JsonConvert.SerializeObject(new { mainMenuID, isMoveUp, isMoveDown }));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:UpdateMainMenuIndex:params:" + JsonConvert.SerializeObject(new { mainMenuID, isMoveUp, isMoveDown }));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        [HttpPost]
        public JsonResult DeleteMainMenuByID(int mainMenuID)
        {
            try
            {
                var serviceResponse = _eSyaConfigAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("eSyaConfigureMenu/DeleteMainMenuByID?mainMenuId=" + mainMenuID).Result;
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:DeleteMainMenuByID:params:" + JsonConvert.SerializeObject(new { mainMenuID }));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:DeleteMainMenuByID:params:" + JsonConvert.SerializeObject(new { mainMenuID }));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        #endregion MainMenu


        #region SubMenu
        public JsonResult GetSubMenuById(int menuItemID)
        {
            try
            {
                var serviceResponse = _eSyaConfigAPIServices.HttpClientServices.GetAsync<DO_SubMenu>("eSyaConfigureMenu/GetSubMenuById?menuItemId=" + menuItemID).Result;
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetSubMenuById:params:" + JsonConvert.SerializeObject(new { menuItemID }));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetSubMenuById:params:" + JsonConvert.SerializeObject(new { menuItemID }));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        [HttpPost]
        public JsonResult InsertIntoSubMenu(DO_SubMenu obj)
        {
            try
            {
                obj.UserId = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalId = AppSessionVariables.GetIPAddress(HttpContext);

                var serviceResponse = _eSyaConfigAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("eSyaConfigureMenu/InsertIntoSubMenu", obj).Result;
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertIntoSubMenu:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertIntoSubMenu:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        [HttpPost]
        public JsonResult UpdateSubMenusIndex(int menuItemID, bool isMoveUp, bool isMoveDown)
        {
            try
            {
                var serviceResponse = _eSyaConfigAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("eSyaConfigureMenu/UpdateSubMenusIndex?menuItemId=" + menuItemID + "&isMoveUp=" + isMoveUp + "&isMoveDown=" + isMoveDown).Result;
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:UpdateSubMenusIndex:params:" + JsonConvert.SerializeObject(new { menuItemID, isMoveUp, isMoveDown }));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:UpdateSubMenusIndex:params:" + JsonConvert.SerializeObject(new { menuItemID, isMoveUp, isMoveDown }));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        [HttpPost]
        public JsonResult DeleteSubMenuByID(int menuItemID)
        {
            try
            {

                var serviceResponse = _eSyaConfigAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("eSyaConfigureMenu/DeleteSubMenuByID?menuItemID=" + menuItemID).Result;
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:DeleteSubMenuByID:params:" + JsonConvert.SerializeObject(new { menuItemID }));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:DeleteSubMenuByID:params:" + JsonConvert.SerializeObject(new { menuItemID }));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        #endregion SubMenu

        #region Forms
        public JsonResult GetFormDetailsByID(int mainMenuID, int menuItemID, int formID)
        {
            try
            {
                var serviceResponse = _eSyaConfigAPIServices.HttpClientServices.GetAsync<DO_FormMenu>("eSyaConfigureMenu/GetFormDetailById?mainMenuID=" + mainMenuID + "&menuItemId=" + menuItemID + "&formId=" + formID).Result;
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetFormDetailsByID:params:" + JsonConvert.SerializeObject(new { mainMenuID, menuItemID, formID }));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetFormDetailsByID:params:" + JsonConvert.SerializeObject(new { mainMenuID, menuItemID, formID }));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        [HttpPost]
        public JsonResult InsertIntoFormMenu(DO_FormMenu obj)
        {
            try
            {
                obj.UserId = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalId = AppSessionVariables.GetIPAddress(HttpContext);

                var serviceResponse = _eSyaConfigAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("eSyaConfigureMenu/InsertIntoFormMenu", obj).Result;
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertIntoFormMenu:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertIntoFormMenu:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        [HttpPost]
        public JsonResult UpdateFormsIndex(int mainMenuID, int menuItemID, int formID, bool isMoveUp, bool isMoveDown)
        {
            try
            {
                var serviceResponse = _eSyaConfigAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("eSyaConfigureMenu/UpdateFormsIndex?mainMenuID=" + mainMenuID + "&menuItemId=" + menuItemID + "&formId=" + formID + "&isMoveUp=" + isMoveUp + "&isMoveDown=" + isMoveDown).Result;
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:UpdateFormsIndex:params:" + JsonConvert.SerializeObject(new { mainMenuID, menuItemID, formID, isMoveUp, isMoveDown }));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:UpdateFormsIndex:params:" + JsonConvert.SerializeObject(new { mainMenuID, menuItemID, formID, isMoveUp, isMoveDown }));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        [HttpPost]
        public JsonResult DeleteFormMenuByID(int mainMenuID, int menuItemID, int formID)
        {
            try
            {
                var serviceResponse = _eSyaConfigAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("eSyaConfigureMenu/DeleteFormMenuByID?mainMenuID=" + mainMenuID + "&menuItemID=" + menuItemID + "&formID=" + formID).Result;
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:DeleteFormMenuByID:params:" + JsonConvert.SerializeObject(new { mainMenuID, menuItemID, formID }));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:DeleteFormMenuByID:params:" + JsonConvert.SerializeObject(new { mainMenuID, menuItemID, formID }));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        #endregion Forms

        #endregion Configure Menu


        #region Form Module
        /// <summary>
        /// Configure Menu
        /// </summary>
        /// <returns></returns>

        [Area("eSyaConfig")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> V_3_00()
        {
            try
            {

                var parameter = "?codeType=" + 1;
                var modulesericeResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_ApplicationCodes>>("ConfigMasterData/GetApplicationCodesByCodeType" + parameter);


                int codeType = 2;
                var assignsericeResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_ApplicationCodes>>("ConfigMasterData/GetApplicationCodesByCodeType?codeType=" + codeType);

                if (modulesericeResponse.Status && assignsericeResponse.Status)
                {
                    var module_list = modulesericeResponse.Data;
                    ViewBag.ModuleList = module_list;
                    var assign_list = assignsericeResponse.Data;
                    ViewBag.AssignList = assign_list;
                    return View();

                }
                else
                {
                    _logger.LogError(new Exception(assignsericeResponse.Message), "UD:GetApplicationCodesByCodeType:For codeType {0}", codeType);
                    return Json(new { Status = false, StatusCode = "500" });
                }



            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetApplicationCodesByCodeType");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        ///Get Forms list for dropdown
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetForms()
        {

            try
            {
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_Forms>>("Forms/GetForms");
                if (serviceResponse.Status)
                {

                    return Json(serviceResponse.Data);

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetForms");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetForms");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }

        }
        /// <summary>
        /// Get All Form Modules for Treeview
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetFormsModuleforTreeView()
        {
            try
            {
                List<jsTreeObject> jsTree = new List<jsTreeObject>();

                jsTreeObject jsObj = new jsTreeObject
                {
                    id = "MM",
                    parent = "#",
                    text = "eSya Tracker",
                    state = new stateObject { opened = true, selected = false }
                };
                jsTree.Add(jsObj);

                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<DO_FormModuleConfiguration>("Forms/GetFormModules");
                var formModule = serviceResponse.Data;
                if (formModule != null)
                {
                    foreach (var f in formModule.l_Module.OrderBy(o => o.ApplicationCode))
                    {
                        jsObj = new jsTreeObject
                        {
                            id = "MM" + f.ApplicationCode.ToString(),
                            text = f.CodeDesc,
                            GroupIndex = f.ApplicationCode.ToString(),
                            parent = "MM",
                            state = new stateObject { opened = true, selected = false }
                        };
                        jsTree.Add(jsObj);
                    }

                    foreach (var f in formModule.l_Form.OrderBy(o => o.FormId))
                    {
                        jsObj = new jsTreeObject
                        {
                            id = "SM" + f.ModuleId.ToString() + "." + f.FormId.ToString(),
                            text = f.FormName,
                            GroupIndex = f.ModuleId.ToString(),
                            parent = "MM" + f.ModuleId.ToString(),
                            state = new stateObject { opened = true, selected = false }
                        };
                        jsTree.Add(jsObj);
                    }
                }
                return Json(jsTree);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetFormModules");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }

        }
        /// <summary>
        /// Get Form Module by FormId
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetFormModulebyFormId(int formId)
        {

            try
            {
                var parameter = "?formId=" + formId;
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<DO_FormModule>("Forms/GetFormModulebyFormId" + parameter);
                if (serviceResponse.Status)
                {

                    return Json(serviceResponse.Data);

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetFormModulebyFormId:For formId {0}", formId);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetFormModulebyFormId:For formId {0}", formId);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }

        }

        /// <summary>
        ///Insert Or Update Form Module
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateFormModule(DO_FormModule obj)
        {
            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                if (obj.Isadd == 1)
                {
                    var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Forms/InsertIntoFormModule", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
                else
                {
                    var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Forms/UpdateFormModule", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertIntoFormModule:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        #endregion Form Module
    }
}