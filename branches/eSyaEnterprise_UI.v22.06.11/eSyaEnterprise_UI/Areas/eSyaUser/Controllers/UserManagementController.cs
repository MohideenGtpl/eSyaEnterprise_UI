﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using eSyaEnterprise_UI.Areas.eSyaUser.Data;
using eSyaEnterprise_UI.Areas.eSyaUser.Models;
using eSyaEnterprise_UI.Models;
using eSyaEnterprise_UI.Areas.Config.Models;
using eSyaEnterprise_UI.Utility;
using System.Text.RegularExpressions;
using eSyaEnterprise_UI.ActionFilter;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Newtonsoft.Json;
using eSyaEnterprise_UI.Extension;
using eSyaEnterprise_UI.DataServices;

namespace eSyaEnterprise_UI.Areas.eSyaUser.Controllers
{
    [SessionTimeout]
    public class UserManagementController : Controller
    {
        private readonly IeSyaUserManagementAPIServices _eSyaUMAPIServices;
        private readonly ISmsServices _smsServices;
        private readonly ILogger<UserManagementController> _logger;

        public UserManagementController(IeSyaUserManagementAPIServices eSyaUMAPIServices, ISmsServices smsServices, ILogger<UserManagementController> logger)
        {
            _eSyaUMAPIServices = eSyaUMAPIServices;
            _smsServices = smsServices;
            _logger = logger;
        }

        [Area("eSyaUser")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> V_201_00()
        {
            try
            {

                List<int> l_ac = new List<int>();
                l_ac.Add(CodeTypeValues.UserGroup);
                l_ac.Add(CodeTypeValues.UserType);

                var response = await _eSyaUMAPIServices.HttpClientServices.PostAsJsonAsync<List<DO_ApplicationCodes>>("CommonData/GetApplicationCodesByCodeTypeList", l_ac);
                if (response.Status)
                {
                    if (response.Data != null)
                    {
                        List<DO_ApplicationCodes> app_codes = response.Data;
                        ViewBag.UGappcodes = app_codes.Where(w => w.CodeType == CodeTypeValues.UserGroup);
                        ViewBag.UTappcodes = app_codes.Where(w => w.CodeType == CodeTypeValues.UserType);
                        return View();
                    }
                    else
                    {
                        _logger.LogError(new Exception(response.Message), "UD:GetApplicationCodesByCodeTypeList");
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(response.Message), "UD:GetApplicationCodesByCodeTypeList");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetApplicationCodesByCodeTypeList");
                throw ex;
            }
        }

        [Area("eSyaUser")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> V_202_00()
        {
            try
            {
                List<int> l_ac = new List<int>();
                l_ac.Add(CodeTypeValues.UserGroup);
                l_ac.Add(CodeTypeValues.UserType);

                var response = await _eSyaUMAPIServices.HttpClientServices.PostAsJsonAsync<List<DO_ApplicationCodes>>("CommonData/GetApplicationCodesByCodeTypeList", l_ac);

                var serviceResponse = await _eSyaUMAPIServices.HttpClientServices.GetAsync<List<DO_CountryCodes>>("CommonData/GetISDCodes");

                ViewBag.UserAuthentication = 0;
                if (response.Status && serviceResponse.Status)
                {
                    if (response.Data != null && serviceResponse.Data != null)
                    {
                        List<DO_ApplicationCodes> app_codes = response.Data;

                        ViewBag.UserGroupList = app_codes.Where(w => w.CodeType == CodeTypeValues.UserGroup).Select(b => new SelectListItem
                        {
                            Value = b.ApplicationCode.ToString(),
                            Text = b.CodeDesc,
                        }).ToList();

                        ViewBag.UserTypeList = app_codes.Where(w => w.CodeType == CodeTypeValues.UserType).Select(b => new SelectListItem
                        {
                            Value = b.ApplicationCode.ToString(),
                            Text = b.CodeDesc,
                        }).ToList();

                        ViewBag.ISDCodeList = serviceResponse.Data.Select(b => new SelectListItem
                        {
                            Value = b.Isdcode.ToString(),
                            Text = b.Isdcode.ToString() + '-' + b.CountryName,
                        }).ToList();

                        // return View();
                    }
                    else
                    {
                        _logger.LogError(new Exception(response.Message), "UD:UserMaster");
                        // return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(response.Message), "UD:UserMaster");
                    //return Json(new { Status = false, StatusCode = "500" });
                }
                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:UserMaster");
                throw ex;
            }
        }

        [Area("eSyaUser")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> V_204_00()
        {
            try
            {
                //ViewBag.UserFormRoles = new DO_UserFormRole { IsInsert = true, IsEdit = true, IsDelete = true };
                List<int> l_ac = new List<int>();
                l_ac.Add(CodeTypeValues.UserGroup);
                l_ac.Add(CodeTypeValues.UserType);

                var response = await _eSyaUMAPIServices.HttpClientServices.PostAsJsonAsync<List<DO_ApplicationCodes>>("CommonData/GetApplicationCodesByCodeTypeList", l_ac);

                var serviceResponse = await _eSyaUMAPIServices.HttpClientServices.GetAsync<List<DO_CountryCodes>>("CommonData/GetISDCodes");
                ViewBag.UserAuthentication = 1;
                if (response.Status && serviceResponse.Status)
                {
                    if (response.Data != null && serviceResponse.Data != null)
                    {
                        List<DO_ApplicationCodes> app_codes = response.Data;

                        ViewBag.UserGroupList = app_codes.Where(w => w.CodeType == CodeTypeValues.UserGroup).Select(b => new SelectListItem
                        {
                            Value = b.ApplicationCode.ToString(),
                            Text = b.CodeDesc,
                        }).ToList();

                        ViewBag.UserTypeList = app_codes.Where(w => w.CodeType == CodeTypeValues.UserType).Select(b => new SelectListItem
                        {
                            Value = b.ApplicationCode.ToString(),
                            Text = b.CodeDesc,
                        }).ToList();

                        ViewBag.ISDCodeList = serviceResponse.Data.Select(b => new SelectListItem
                        {
                            Value = b.Isdcode.ToString(),
                            Text = b.Isdcode.ToString() + '-' + b.CountryName,
                        }).ToList();

                        // return View();
                    }
                    else
                    {
                        _logger.LogError(new Exception(response.Message), "UD:UserMaster");
                        // return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(response.Message), "UD:UserMaster");
                    //return Json(new { Status = false, StatusCode = "500" });
                }
                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:UserMaster");
                throw ex;
            }
        }

        [Area("eSyaUser")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult V_205_00()
        {
            return View();
        }

        // [Area("eSyaUser")]
        public IActionResult _UserPrivilege()
        {
            ViewBag.formName = "User Group";
            return View();
        }

        public IActionResult _userMenu()
        {
            ViewBag.formName = "User Menu";
            return View();
        }

        //[Area("eSyaUser")]
        //public IActionResult _UserCreation(short UserID)
        //{
        //    List<int> l_ac = new List<int>();
        //    l_ac.Add(CodeTypeValues.UserGroup);
        //    l_ac.Add(CodeTypeValues.UserType);

        //    var response = _eSyaUMAPIServices.HttpClientServices.PostAsJsonAsync<List<DO_ApplicationCodes>>("CommonData/GetApplicationCodesByCodeTypeList", l_ac).Result;
        //    List<DO_ApplicationCodes> app_codes = response.Data;

        //    ViewBag.UserGroupList = app_codes.Where(w => w.CodeType == CodeTypeValues.UserGroup).Select(b => new SelectListItem
        //    {
        //        Value = b.ApplicationCode.ToString(),
        //        Text = b.CodeDesc,
        //    }).ToList();

        //    ViewBag.UserTypeList = app_codes.Where(w => w.CodeType == CodeTypeValues.UserType).Select(b => new SelectListItem
        //    {
        //        Value = b.ApplicationCode.ToString(),
        //        Text = b.CodeDesc,
        //    }).ToList();

        //    ViewBag.UserID = UserID;

        //    ViewBag.formName = "User Creation";
        //    return View();
        //}

        #region User Group

        string _MenuJSONFilePath = @"wwwroot\json\menuitem.json";

        /// <summary>
        /// Get Configuration Menu List for js tree
        /// </summary>
        [Produces("application/json")]
        [HttpPost]
        public IActionResult GetConfigureMenulist()
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

                    icon = "/images/jsTree/checkedstate.jpg",
                    state = new stateObject { opened = true, selected = false }
                };
                jsTree.Add(jsObj1);

                var serviceResponse = _eSyaUMAPIServices.HttpClientServices.GetAsync<DO_ConfigureMenu>("CommonData/GetConfigureMenulist").Result;
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
                                GroupIndex = m.MenuIndex.ToString(),
                                parent = "MM",
                            };
                            jsTree.Add(jsObj);

                            var sb = GetMenuFormItems(m.MainMenuId, 0, configureMenu.l_SubMenu, configureMenu.l_FormMenu);
                            l_menu.AddRange(sb);


                        }


                        //Add Sub Menu
                        var menu = l_menu.OrderBy(o => o.MenuIndex);
                        foreach (var s in menu)
                        {
                            if (!s.IsForm)
                            {
                                jsTreeObject jsObj = new jsTreeObject
                                {
                                    id = "SM" + s.MenuItemId.ToString(),
                                    text = s.MenuItemName,
                                    GroupIndex = s.MenuIndex.ToString(),
                                    parent = s.ParentID == 0 ? "MM" + s.MainMenuId.ToString() : "SM" + s.ParentID.ToString()
                                };
                                jsTree.Add(jsObj);

                            }
                            else
                            {
                                jsTreeObject jsObj = new jsTreeObject
                                {
                                    //id = "FM" + s.ParentID.ToString() + "_" + s.FormId.ToString(),
                                    id = "FM" + s.ParentID.ToString() + "_" + s.MenuKey.ToString(),
                                    text = s.MenuItemName,
                                    GroupIndex = s.MenuIndex.ToString(),
                                    parent = s.ParentID == 0 ? "MM" + s.MainMenuId.ToString() : "SM" + s.ParentID.ToString()
                                };
                                jsTree.Add(jsObj);
                            }
                        }


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
                o.MenuKey = f.MenuKey;
                l_menu.Add(o);
            }
            l_menu.AddRange(sb2);

            foreach (var s in sb2)
                l_menu.AddRange(GetMenuFormItems(mainMenuID, s.MenuItemId, l_SubMenu, l_FormMenu));

            return l_menu;
        }

        /// <summary>
        /// Get User Group Menu keys for js tree
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetMenuKeysbyUserGroupAndUserType(int uG, int uT)
        {
            try
            {
                var parameter = "?uG=" + uG + "&uT=" + uT;
                var serviceResponse = await _eSyaUMAPIServices.HttpClientServices.GetAsync<List<int>>("UserCreation/GetMenuKeysbyUserGroupAndUserType" + parameter);

                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetMenuKeysbyUserGroupAndUserType:For UserGroup {0} with UserType entered {1}", uG, uT);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetMenuKeysbyUserGroupAndUserType:For UserGroup {0} with UserType entered {1}", uG, uT);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetMenuKeysbyUserGroupAndUserType:For UserGroup {0} with UserType entered {1}", uG, uT);
                throw ex;
            }
        }

        /// <summary>
        /// Insert into User Group
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertMenukeysIntoUserGroup(DO_UserGroup selectedkeys)
        {
            try
            {
                selectedkeys.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                selectedkeys.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                selectedkeys.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                var serviceResponse = await _eSyaUMAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("UserCreation/InsertMenukeysIntoUserGroup", selectedkeys);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertMenukeysIntoUserGroup:params:" + JsonConvert.SerializeObject(selectedkeys));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertMenukeysIntoUserGroup:params:" + JsonConvert.SerializeObject(selectedkeys));
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }

        #endregion User Group

        #region User Creation

        /// <summary>
        ///Get User Master for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetUserMaster()
        {
            try
            {
                var serviceResponse = await _eSyaUMAPIServices.HttpClientServices.GetAsync<List<DO_UserMaster>>("UserCreation/GetUserMaster");
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetCurrencyNamebyIsdCode");
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetCurrencyNamebyIsdCode");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetCurrencyNamebyIsdCode");
                throw ex;
            }
        }

        /// <summary>
        ///Get User Master Details
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetUserDetails(int UserID)
        {
            try
            {
                var parameter = "?UserID=" + UserID;
                var serviceResponse = await _eSyaUMAPIServices.HttpClientServices.GetAsync<DO_UserMaster>("UserCreation/GetUserDetails" + parameter);

                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        var data = serviceResponse.Data;

                        string userimageURI = string.Empty;
                        if (data.Photo.Length != 0)
                            userimageURI = ConvertByteArraytoImageURI(data.Photo);
                        data.userimage = userimageURI;

                        string DSimageURI = string.Empty;
                        if (data.DigitalSignature.Length != 0)
                            DSimageURI = ConvertByteArraytoImageURI(data.DigitalSignature);
                        data.DSimage = DSimageURI;

                        return Json(data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetUserDetails:For UserID {0}", UserID);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetUserDetails:For UserID {0}", UserID);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetUserDetails:For UserID {0}", UserID);
                throw ex;
            }
        }

        /// <summary>
        ///Get User Business Location for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetUserBusinessLocation(short UserID)
        {
            try
            {
                var serviceResponse = await _eSyaUMAPIServices.HttpClientServices.GetAsync<List<DO_UserBusinessLink>>("UserCreation/GetUserBusinessLocation?UserID=" + UserID + "&CodeTypeUG=" + CodeTypeValues.UserGroup + "&CodeTypeUT=" + CodeTypeValues.UserType);

                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetUserBusinessLocation:For UserID {0}", UserID);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetUserBusinessLocation:For UserID {0}", UserID);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetUserBusinessLocation:For UserID {0}", UserID);
                throw ex;
            }
        }

        /// <summary>
        /// Insert or Update User Master
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateUserMaster(DO_UserMaster userMaster, string file, string DSfile)
        {
            try
            {
                if (string.IsNullOrEmpty(userMaster.LoginID))
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Enter Login ID" });
                }
                else if (string.IsNullOrEmpty(userMaster.LoginDesc))
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Enter Login Description" });
                }
                else if (string.IsNullOrEmpty(userMaster.Password))
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Enter Password" });
                }
                else if (string.IsNullOrEmpty(userMaster.ISDCode.ToString()) || userMaster.ISDCode == 0)
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select ISD" });
                }
                else if (string.IsNullOrEmpty(userMaster.MobileNumber))
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Enter Mobile No" });
                }
                else if (string.IsNullOrEmpty(userMaster.eMailID))
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Enter Email Id" });
                }
                else
                {
                    userMaster.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                    userMaster.CreatedBy = AppSessionVariables.GetSessionUserID(HttpContext);
                    userMaster.TerminalId = AppSessionVariables.GetIPAddress(HttpContext);
                    if (file != null)
                    {

                        string userbase64 = file;// load base 64 code to this variable from js 
                        Byte[] userbitmapData = new Byte[userbase64.Length];
                        userbitmapData = Convert.FromBase64String(FixBase64ForImage(userbase64));
                        if (userbitmapData.Length > 2 * 1024 * 1024)
                        {
                            return Json(new DO_ReturnParameter() { Status = false, Message = "User Photo file size should be smaller than 2 MB" });
                        }

                        userMaster.Photo = userbitmapData;
                    }
                    else
                    {
                        byte[] emptyByte = { };
                        userMaster.Photo = emptyByte;
                    }
                    if (DSfile != null)
                    {

                        string DSbase64 = DSfile;// load base 64 code to this variable from js 
                        Byte[] DSbitmapData = new Byte[DSbase64.Length];
                        DSbitmapData = Convert.FromBase64String(FixBase64ForImage(DSbase64));
                        if (DSbitmapData.Length > 2 * 1024 * 1024)
                        {
                            return Json(new DO_ReturnParameter() { Status = false, Message = "Digital Signature file size should be smaller than 2 MB" });
                        }
                        userMaster.DigitalSignature = DSbitmapData;
                    }
                    else
                    {
                        byte[] emptyByte = { };
                        userMaster.DigitalSignature = emptyByte;
                    }
                    if (userMaster.Authenticated == 0)
                    {
                        if (userMaster.UserID == 0)
                        {
                            var serviceResponse = await _eSyaUMAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("UserCreation/InsertIntoUserMaster", userMaster);
                            if (serviceResponse.Status)
                                return Json(serviceResponse.Data);
                            else
                            {
                                _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertOrUpdateUserMaster:params:" + JsonConvert.SerializeObject(userMaster));
                                return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                            }
                        }
                        else
                        {
                            var serviceResponse = await _eSyaUMAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("UserCreation/UpdateUserMaster", userMaster);
                            if (serviceResponse.Status)
                                return Json(serviceResponse.Data);
                            else
                            {
                                _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertOrUpdateUserMaster:params:" + JsonConvert.SerializeObject(userMaster));
                                return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                            }
                        }
                    }
                    else
                    {
                        var serviceResponse = await _eSyaUMAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("UserCreation/UpdateUserMasteronAuthentication", userMaster);
                        if (serviceResponse.Status)
                        {
                            DO_SmsParameter smsParams = new DO_SmsParameter();
                            smsParams.TEventID = SMSTriggerEventValues.OnSaveClicked;
                            smsParams.FormID = AppSessionVariables.GetSessionFormID(HttpContext);
                            smsParams.UserID = userMaster.UserID;
                            smsParams.IsUserPasswordInclude = true;

                            _smsServices.SendSmsForForm(smsParams);
                            return Json(serviceResponse.Data);
                        }
                        else
                        {
                            _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertOrUpdateUserMaster:params:" + JsonConvert.SerializeObject(userMaster));
                            return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateUserMaster:params:" + JsonConvert.SerializeObject(userMaster));
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }

        public static string FixBase64ForImage(string image)
        {

            var regex = new Regex(@"data:(?<mime>[\w/\-\.]+);(?<encoding>\w+),(?<data>.*)", RegexOptions.Compiled);
            var match = regex.Match(image);
            var mime = match.Groups["mime"].Value;
            var encoding = match.Groups["encoding"].Value;
            var data = match.Groups["data"].Value;
            return data;
        }

        public static string ConvertByteArraytoImageURI(Byte[] image)
        {

            StringBuilder ImageURI = new StringBuilder();
            ImageURI.Append("data:");
            string image_data = Convert.ToBase64String(image);
            string mime = "image/jpeg";
            string encoding = "base64";
            ImageURI.Append(mime);
            ImageURI.Append(";");
            ImageURI.Append(encoding);
            ImageURI.Append(",");
            ImageURI.Append(image_data);
            return Convert.ToString(ImageURI);
        }

        /// <summary>
        /// Insert or Update User Business Link
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateUserBL(DO_UserBusinessLink UserBusinessLink)
        {
            try
            {
                if (string.IsNullOrEmpty(UserBusinessLink.UserID.ToString()) || UserBusinessLink.UserID == 0)
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select Login Id" });
                }
                else if (string.IsNullOrEmpty(UserBusinessLink.BusinessKey.ToString()) || UserBusinessLink.BusinessKey == 0)
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select Business Location" });
                }
                else if (string.IsNullOrEmpty(UserBusinessLink.UserGroup.ToString()) || UserBusinessLink.UserGroup == 0)
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select User Group" });
                }
                else if (string.IsNullOrEmpty(UserBusinessLink.UserType.ToString()) || UserBusinessLink.UserType == 0)
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select User Type" });
                }
                else
                {
                    UserBusinessLink.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                    UserBusinessLink.CreatedBy = AppSessionVariables.GetSessionUserID(HttpContext);
                    UserBusinessLink.TerminalId = AppSessionVariables.GetIPAddress(HttpContext);

                    if (UserBusinessLink.IUStatus == 0)
                    {
                        var serviceResponse = await _eSyaUMAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("UserCreation/InsertIntoUserBL", UserBusinessLink);
                        if (serviceResponse.Status)
                            return Json(serviceResponse.Data);
                        else
                        {
                            _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertOrUpdateUserBL:params:" + JsonConvert.SerializeObject(UserBusinessLink));
                            return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                        }
                    }
                    else
                    {
                        var serviceResponse = await _eSyaUMAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("UserCreation/UpdateUserBL", UserBusinessLink);
                        if (serviceResponse.Status)
                            return Json(serviceResponse.Data);
                        else
                        {
                            _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertOrUpdateUserBL:params:" + JsonConvert.SerializeObject(UserBusinessLink));
                            return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateUserBL:params:" + JsonConvert.SerializeObject(UserBusinessLink));
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }

        /// <summary>
        /// Get Menu List for js tree
        /// </summary>
        [Produces("application/json")]
        [HttpPost]
        public async Task<JsonResult> GetMenulist(int UserGroup, int UserType, short UserID, int BusinessKey)
        {
            try
            {
                List<jsTreeObject> jsTree = new List<jsTreeObject>();

                jsTreeObject jsObj = new jsTreeObject
                {
                    id = "MM",
                    parent = "#",
                    text = "eSya Enterprise",
                    state = new stateObject { opened = true, selected = false }
                };
                jsTree.Add(jsObj);
                var parameter = "?UserGroup=" + UserGroup + "&UserType=" + UserType + "&UserID=" + UserID + "&BusinessKey=" + BusinessKey;
                var serviceResponse = await _eSyaUMAPIServices.HttpClientServices.GetAsync<DO_ConfigureMenu>("UserCreation/GetMenulist" + parameter);

                if (serviceResponse.Status)
                {
                    var configureMenu = serviceResponse.Data;

                    if (configureMenu != null)
                    {
                        //Add Main Menu
                        foreach (var m in configureMenu.l_MainMenu.OrderBy(o => o.MenuIndex))
                        {
                            jsObj = new jsTreeObject
                            {
                                id = "MM" + m.MainMenuId.ToString(),
                                text = m.MainMenu,
                                GroupIndex = m.MenuIndex.ToString(),
                                parent = "MM",
                            };
                            jsTree.Add(jsObj);
                        }

                        //Add Sub Menu
                        foreach (var s in configureMenu.l_SubMenu.OrderBy(o => o.MenuIndex))
                        {
                            jsObj = new jsTreeObject
                            {
                                id = "SM" + s.MenuItemId.ToString(),
                                text = s.MenuItemName,
                                GroupIndex = s.MenuIndex.ToString(),
                                parent = "MM" + s.MainMenuId.ToString()//s.ParentID == 0 ? "MM" + s.MainMenuId.ToString() : "SM" + s.ParentID.ToString()
                            };
                            jsTree.Add(jsObj);
                        }

                        //Add Form
                        foreach (var f in configureMenu.l_FormMenu.OrderBy(o => o.FormIndex))
                        {
                            if (f.ActiveStatus)
                            {
                                jsObj = new jsTreeObject
                                {
                                    id = "FM" + f.MenuItemId.ToString() + "." + f.FormId.ToString() + ".1",
                                    text = f.FormNameClient,
                                    GroupIndex = f.FormIndex.ToString(),
                                    parent = f.MenuItemId == 0 ? "MM" + f.MainMenuId.ToString() : "SM" + f.MenuItemId.ToString(),

                                    icon = "/images/jsTree/checkedstate.jpg",
                                    state = new stateObject { opened = true, selected = false }
                                };
                                jsTree.Add(jsObj);
                            }
                            else
                            {
                                jsObj = new jsTreeObject
                                {
                                    id = "FM" + f.MenuItemId.ToString() + "." + f.FormId.ToString() + ".0",
                                    text = f.FormNameClient,
                                    GroupIndex = f.FormIndex.ToString(),
                                    parent = f.MenuItemId == 0 ? "MM" + f.MainMenuId.ToString() : "SM" + f.MenuItemId.ToString(),
                                    state = new stateObject { opened = true, selected = false }
                                };
                                jsTree.Add(jsObj);
                            }
                        }
                    }

                    return Json(jsTree);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetBusinessSegmentforTreeView:For UserGroup {0} UserType {1} UserID {2} with BusinessKey entered {3}", UserGroup, UserType, UserID, BusinessKey);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetBusinessSegmentforTreeView:For UserGroup {0} UserType {1} UserID {2} with BusinessKey entered {3}", UserGroup, UserType, UserID, BusinessKey);
                throw ex;
            }
        }

        /// <summary>
        ///Get User form Action Link
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetUserFormActionLink(int UserID, int BusinessKey, int MenuKey)
        {
            try
            {
                var serviceResponse = await _eSyaUMAPIServices.HttpClientServices.GetAsync<List<DO_UserFormAction>>("UserCreation/GetUserFormActionLink?UserID=" + UserID + "&BusinessKey=" + BusinessKey + "&MenuKey=" + MenuKey);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetUserFormActionLink:For UserID {0} BusinessKey {1} with MenuKey {2}", UserID, BusinessKey, MenuKey);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetUserFormActionLink:For UserID {0} BusinessKey {1} with MenuKey {2}", UserID, BusinessKey, MenuKey);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetUserFormActionLink:For UserID {0} BusinessKey {1} with MenuKey {2}", UserID, BusinessKey, MenuKey);
                throw ex;
            }
        }

        /// <summary>
        /// Insert or Update User Menu Link and User Form Action Link
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertIntoUserMenuAction(DO_UserMenuLink UserMenuLink)
        {
            try
            {
                if (string.IsNullOrEmpty(UserMenuLink.BusinessKey.ToString()) || UserMenuLink.BusinessKey == 0)
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select Business Location" });
                }
                else if (string.IsNullOrEmpty(UserMenuLink.UserID.ToString()) || UserMenuLink.UserID == 0)
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select Login Id" });
                }
                else if (string.IsNullOrEmpty(UserMenuLink.MenuKey.ToString()) || UserMenuLink.MenuKey == 0)
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select Menu" });
                }
                else
                {
                    UserMenuLink.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                    UserMenuLink.CreatedBy = AppSessionVariables.GetSessionUserID(HttpContext);
                    UserMenuLink.TerminalId = AppSessionVariables.GetIPAddress(HttpContext);

                    var serviceResponse = await _eSyaUMAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("UserCreation/InsertIntoUserMenuAction", UserMenuLink);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertIntoUserMenuAction:params:" + JsonConvert.SerializeObject(UserMenuLink));
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertIntoUserMenuAction:params:" + JsonConvert.SerializeObject(UserMenuLink));
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }

        /// <summary>
        /// Get User Menu keys for js tree
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetMenuKeysforUser(short UserID, int BusinessKey)
        {
            try
            {
                var parameter = "?UserID=" + UserID + "&BusinessKey=" + BusinessKey;
                var serviceResponse = await _eSyaUMAPIServices.HttpClientServices.GetAsync<List<int>>("UserCreation/GetMenuKeysforUser" + parameter);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetMenuKeysforUser:For UserID {0} with BusinessKey entered {1}", UserID, BusinessKey);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetMenuKeysforUser:For UserID {0} with BusinessKey entered {1}", UserID, BusinessKey);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetMenuKeysforUser:For UserID {0} with BusinessKey entered {1}", UserID, BusinessKey);
                throw ex;
                //return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        ///Get User Master for User Authentication Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetUserMasterForUserAuthentication()
        {
            try
            {
                var serviceResponse = await _eSyaUMAPIServices.HttpClientServices.GetAsync<List<DO_UserMaster>>("UserCreation/GetUserMasterForUserAuthentication");
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetUserMasterForUserAuthentication");
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetUserMasterForUserAuthentication");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetUserMasterForUserAuthentication");
                throw ex;
            }
        }

        #endregion User Creation

        #region User De-activation

        /// <summary>
        ///Get User Master for User Deativation Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetUserMasterForUserDeactivation()
        {
            try
            {
                var serviceResponse = await _eSyaUMAPIServices.HttpClientServices.GetAsync<List<DO_UserMaster>>("UserCreation/GetUserMasterForUserDeactivation");
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetUserMasterForUserDeactivation");
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetUserMasterForUserDeactivation");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetUserMasterForUserDeactivation");
                throw ex;
            }
        }

        /// <summary>
        /// Update User Master for User Deativation Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> UpdateUserForDeativation(DO_UserMaster userMaster)
        {
            try
            {
                if (string.IsNullOrEmpty(userMaster.LoginID))
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Enter Login ID" });
                }
                else
                {
                    userMaster.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                    userMaster.CreatedBy = AppSessionVariables.GetSessionUserID(HttpContext);
                    userMaster.TerminalId = AppSessionVariables.GetIPAddress(HttpContext);

                    var serviceResponse = await _eSyaUMAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("UserCreation/UpdateUserForDeativation", userMaster);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:UpdateUserForDeativation:params:" + JsonConvert.SerializeObject(userMaster));
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:UpdateUserForDeativation:params:" + JsonConvert.SerializeObject(userMaster));
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }

        #endregion User De-activation
    }
}