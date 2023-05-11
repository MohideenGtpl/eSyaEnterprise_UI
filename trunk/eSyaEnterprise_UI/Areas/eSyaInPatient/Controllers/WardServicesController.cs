﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eSyaEnterprise_UI.ActionFilter;
using eSyaEnterprise_UI.Areas.eSyaInPatient.Data;
using eSyaEnterprise_UI.Areas.eSyaInPatient.Models;
using eSyaEnterprise_UI.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace eSyaEnterprise_UI.Areas.eSyaInPatient.Controllers
{
    [SessionTimeout]
    public class WardServicesController : Controller
    {
        private readonly IeSyaInPatientAPIServices _eSyaInPatientAPIServices;
        private readonly ILogger<WardServicesController> _logger;
        public WardServicesController(IeSyaInPatientAPIServices eSyaInPatientAPIServices, ILogger<WardServicesController> logger)
        {
            _eSyaInPatientAPIServices = eSyaInPatientAPIServices;
            _logger = logger;
        }

        /// <summary>
        /// Ward Master
        /// </summary>
        /// <returns></returns>

        [Area("eSyaInPatient")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult V_2501_00()
        {
            return View();
        }

        /// <summary>
        /// Room Master
        /// </summary>
        /// <returns></returns>

        [Area("eSyaInPatient")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult V_2502_00()
        {
            return View();
        }

        /// <summary>
        /// Ward Room – Business Link
        /// </summary>
        /// <returns></returns>

        [Area("eSyaInPatient")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult V_2503_00()
        {
            try
            {
                var serviceResponse = _eSyaInPatientAPIServices.HttpClientServices.GetAsync<List<DO_BusinessLocation>>("CommonData/GetBusinessKey").Result;
                if (serviceResponse.Data != null)
                {
                    ViewBag.BusinessLocation = serviceResponse.Data.Select(a => new SelectListItem
                    {
                        Text = a.SegmentDesc +'-'+ a.LocationDescription,
                        Value = a.BusinessKey.ToString()
                    });
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetBusinessLocation");
                }

                var serviceResponseWard = _eSyaInPatientAPIServices.HttpClientServices.GetAsync<List<DO_WardMaster>>("WardServices/GetActiveWardMasterList").Result;
                if (serviceResponseWard.Data != null)
                {
                    ViewBag.Ward = serviceResponseWard.Data.Select(a => new SelectListItem
                    {
                        Text = a.WardDesc,
                        Value = a.WardId.ToString()
                    });
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetActiveWardMasterList");
                }

                var serviceResponseRoom = _eSyaInPatientAPIServices.HttpClientServices.GetAsync<List<DO_RoomMaster>>("WardServices/GetActiveRoomMasterList").Result;
                if (serviceResponseRoom.Data != null)
                {
                    ViewBag.Room = serviceResponseRoom.Data.Select(a => new SelectListItem
                    {
                        Text = a.RoomDesc,
                        Value = a.RoomId.ToString()
                    });
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetActiveRoomMasterList");
                }
                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:V_2503_00");
                throw ex;
            }
        }

        /// <summary>
        /// Bed Master
        /// </summary>
        /// <returns></returns>

        [Area("eSyaInPatient")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult V_2504_00()
        {
            try
            {
                var serviceResponse = _eSyaInPatientAPIServices.HttpClientServices.GetAsync<List<DO_BusinessLocation>>("CommonData/GetBusinessKey").Result;
                if (serviceResponse.Data != null)
                {
                    ViewBag.BusinessLocation = serviceResponse.Data.Select(a => new SelectListItem
                    {
                        Text = a.SegmentDesc + '-' + a.LocationDescription,
                        Value = a.BusinessKey.ToString()
                    });
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetBusinessLocation");
                }

                var serviceResponselc = _eSyaInPatientAPIServices.HttpClientServices.GetAsync<List<DO_ApplicationCodes>>("CommonData/GetApplicationCodesByCodeType?codeType=" + eSyaInPatient.Data.CodeTypeValues.FloorId).Result;
                if (serviceResponselc.Data != null)
                {
                    ViewBag.LocationId = serviceResponselc.Data.Select(a => new SelectListItem
                    {
                        Text = a.CodeDesc,
                        Value = a.ApplicationCode.ToString()
                    });
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetApplicationCodesByCodeType");
                }

                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetBusinessLocation");
                throw ex;
            }
        }

        /// <summary>
        /// Room Bed Tariff
        /// </summary>
        /// <returns></returns>

        [Area("eSyaInPatient")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult V_2505_00()
        {
            try
            {
                var serviceResponse = _eSyaInPatientAPIServices.HttpClientServices.GetAsync<List<DO_BusinessLocation>>("CommonData/GetBusinessKey").Result;
                if (serviceResponse.Data != null)
                {
                    ViewBag.BusinessLocation = serviceResponse.Data.Select(a => new SelectListItem
                    {
                        Text = a.SegmentDesc + '-' + a.LocationDescription,
                        Value = a.BusinessKey.ToString()
                    });
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetBusinessLocation");
                }

                var serviceResponseRateType = _eSyaInPatientAPIServices.HttpClientServices.GetAsync<List<DO_ApplicationCodes>>("CommonData/GetApplicationCodesByCodeType?codeType=" + eSyaInPatient.Data.CodeTypeValues.RateType).Result;
                if (serviceResponseRateType.Data != null)
                {
                    ViewBag.RateType = serviceResponseRateType.Data.Select(a => new SelectListItem
                    {
                        Text = a.CodeDesc,
                        Value = a.ApplicationCode.ToString()
                    });
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetApplicationCodesByCodeType");
                }

                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:V_2505_00");
                throw ex;
            }
        }

        #region Ward Master

        [Produces("application/json")]
        [HttpGet]
        public async Task<ActionResult> GetWardMasterList()
        {
            try
            {
                List<jsTreeObject> treeView = new List<jsTreeObject>();

                jsTreeObject jsObj = new jsTreeObject();
                jsObj.id = "WM";
                jsObj.parent = "#";
                jsObj.text = "Wards";
                jsObj.icon = "/images/jsTree/foldergroupicon.png";
                jsObj.state = new stateObject { opened = true, selected = false };
                treeView.Add(jsObj);

                var serviceResponse = await _eSyaInPatientAPIServices.HttpClientServices.GetAsync<List<DO_WardMaster>>("WardServices/GetWardMasterList");
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        var st_list = serviceResponse.Data;
                        foreach (var ig in st_list)
                        {
                            jsObj = new jsTreeObject();
                            jsObj.id = ig.WardId.ToString();
                            jsObj.text = ig.WardDesc;
                            jsObj.icon = "/images/jsTree/openfolder.png";
                            jsObj.parent = "WM";
                            treeView.Add(jsObj);
                        }
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetWardMasterList");
                }

                return Json(treeView);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetWardMasterList");
                return Json(new DO_ReturnParameter() { Status = false, Message = ex.Message });
            }
        }

        public async Task<ActionResult> GetWardMasterByID(int wardId)
        {
            try
            {
                var serviceResponse = await _eSyaInPatientAPIServices.HttpClientServices.GetAsync<DO_WardMaster>("WardServices/GetWardMasterById?wardId=" + wardId);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        var data = serviceResponse.Data;
                        return Json(data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetWardMasterByID:For WardId {0}", wardId);
                        return Json(new { Status = false, Message = serviceResponse.Message });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetWardMasterByID:For WardId {0}", wardId);
                    return Json(new { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetWardMasterByID:For WardId {0}", wardId);
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }

        public async Task<ActionResult> InsertIntoWardMaster(DO_WardMaster obj)
        {
            try
            {
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

                var serviceResponse = await _eSyaInPatientAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("WardServices/InsertIntoWardMaster", obj);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Data.Message), "UD:InsertIntoWardMaster:params:" + JsonConvert.SerializeObject(obj));
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Data.Message });
                    }

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertIntoWardMaster:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertIntoWardMaster:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = ex.ToString() });
            }
        }

        public async Task<ActionResult> UpdateWardMaster(DO_WardMaster obj)
        {
            try
            {
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

                var serviceResponse = await _eSyaInPatientAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("WardServices/UpdateWardMaster", obj);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Data.Message), "UD:UpdateWardMaster:params:" + JsonConvert.SerializeObject(obj));
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Data.Message });
                    }

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:UpdateWardMaster:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:UpdateWardMaster:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = ex.ToString() });
            }
        }

        #endregion Ward Master

        #region Room Master

        [Produces("application/json")]
        [HttpGet]
        public async Task<ActionResult> GetRoomMasterList()
        {
            try
            {
                List<jsTreeObject> treeView = new List<jsTreeObject>();

                jsTreeObject jsObj = new jsTreeObject();
                jsObj.id = "RM";
                jsObj.parent = "#";
                jsObj.text = "Rooms";
                jsObj.icon = "/images/jsTree/foldergroupicon.png";
                jsObj.state = new stateObject { opened = true, selected = false };
                treeView.Add(jsObj);

                var serviceResponse = await _eSyaInPatientAPIServices.HttpClientServices.GetAsync<List<DO_RoomMaster>>("WardServices/GetRoomMasterList");
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        var st_list = serviceResponse.Data;
                        foreach (var ig in st_list)
                        {
                            jsObj = new jsTreeObject();
                            jsObj.id = ig.RoomId.ToString();
                            jsObj.text = ig.RoomDesc;
                            jsObj.icon = "/images/jsTree/openfolder.png";
                            jsObj.parent = "RM";
                            treeView.Add(jsObj);
                        }
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetRoomMasterList");
                }

                return Json(treeView);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetRoomMasterList");
                return Json(new DO_ReturnParameter() { Status = false, Message = ex.Message });
            }
        }

        public async Task<ActionResult> GetRoomMasterById(int roomId)
        {
            try
            {
                var serviceResponse = await _eSyaInPatientAPIServices.HttpClientServices.GetAsync<DO_RoomMaster>("WardServices/GetRoomMasterById?roomId=" + roomId);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        var data = serviceResponse.Data;
                        return Json(data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetRoomMasterById:For RoomId {0}", roomId);
                        return Json(new { Status = false, Message = serviceResponse.Message });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetRoomMasterById:For RoomId {0}", roomId);
                    return Json(new { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetRoomMasterById:For RoomId {0}", roomId);
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }

        public async Task<ActionResult> InsertIntoRoomMaster(DO_RoomMaster obj)
        {
            try
            {
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

                var serviceResponse = await _eSyaInPatientAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("WardServices/InsertIntoRoomMaster", obj);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Data.Message), "UD:InsertIntoRoomMaster:params:" + JsonConvert.SerializeObject(obj));
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Data.Message });
                    }

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertIntoRoomMaster:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertIntoRoomMaster:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = ex.ToString() });
            }
        }

        public async Task<ActionResult> UpdateRoomMaster(DO_RoomMaster obj)
        {
            try
            {
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

                var serviceResponse = await _eSyaInPatientAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("WardServices/UpdateRoomMaster", obj);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Data.Message), "UD:UpdateRoomMaster:params:" + JsonConvert.SerializeObject(obj));
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Data.Message });
                    }

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:UpdateRoomMaster:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:UpdateRoomMaster:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = ex.ToString() });
            }
        }

        #endregion Room Master

        #region Ward Room Business Link

        public async Task<ActionResult> InsertIntoWardRoomBusinessLink(DO_WardRoomBusinessLink obj)
        {
            try
            {
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

                var serviceResponse = await _eSyaInPatientAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("WardServices/InsertIntoWardRoomBusinessLink", obj);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Data.Message), "UD:InsertIntoWardRoomBusinessLink:params:" + JsonConvert.SerializeObject(obj));
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Data.Message });
                    }

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertIntoWardRoomBusinessLink:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertIntoWardRoomBusinessLink:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = ex.ToString() });
            }
        }

        public async Task<ActionResult> UpdateWardRoomBusinessLink(DO_WardRoomBusinessLink obj)
        {
            try
            {
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

                var serviceResponse = await _eSyaInPatientAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("WardServices/UpdateWardRoomBusinessLink", obj);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Data.Message), "UD:UpdateWardRoomBusinessLink:params:" + JsonConvert.SerializeObject(obj));
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Data.Message });
                    }

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:UpdateWardRoomBusinessLink:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:UpdateWardRoomBusinessLink:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = ex.ToString() });
            }
        }

        [Produces("application/json")]
        [HttpGet]
        public async Task<ActionResult> GetActiveWardMasterList()
        {
            try
            {
                List<jsTreeObject> treeView = new List<jsTreeObject>();

                jsTreeObject jsObj = new jsTreeObject();
                jsObj.id = "WM";
                jsObj.parent = "#";
                jsObj.text = "Wards";
                jsObj.icon = "/images/jsTree/foldergroupicon.png";
                jsObj.state = new stateObject { opened = true, selected = false };
                treeView.Add(jsObj);

                var serviceResponse = await _eSyaInPatientAPIServices.HttpClientServices.GetAsync<List<DO_WardMaster>>("WardServices/GetActiveWardMasterList");
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        var st_list = serviceResponse.Data;
                        foreach (var ig in st_list)
                        {
                            jsObj = new jsTreeObject();
                            jsObj.id = ig.WardId.ToString();
                            jsObj.text = ig.WardDesc;
                            jsObj.icon = "/images/jsTree/openfolder.png";
                            jsObj.parent = "WM";
                            treeView.Add(jsObj);
                        }
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetActiveWardMasterList");
                }

                return Json(treeView);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetActiveWardMasterList");
                return Json(new DO_ReturnParameter() { Status = false, Message = ex.Message });
            }
        }

        public async Task<ActionResult> GetWardRoomBusinessByBkWrRmId(int businessKey, int wardId, int roomId)
        {
            try
            {
                var serviceResponse = await _eSyaInPatientAPIServices.HttpClientServices.GetAsync<DO_WardRoomBusinessLink>("WardServices/GetWardRoomBusinessByBkWrRmId?businessKey=" + businessKey + "&wardId="+ wardId + "&roomId=" + roomId);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        var data = serviceResponse.Data;
                        return Json(data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetWardRoomBusinessByBkWrRmId:For BusinessKey {0}, WardId {1} and RoomId {2}", businessKey, wardId, roomId);
                        return Json(new { Status = false, Message = serviceResponse.Message });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetWardRoomBusinessByBkWrRmId:For BusinessKey {0}, WardId {1} and RoomId {2}", businessKey, wardId, roomId);
                    return Json(new { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetWardRoomBusinessByBkWrRmId:For BusinessKey {0}, WardId {1} and RoomId {2}", businessKey, wardId, roomId);
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }

        #endregion Ward Room Business Link

        #region Bed Master

        public async Task<ActionResult> InsertIntoBedMaster(DO_BedMaster wr_bm)
        {
            try
            {
                wr_bm.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                wr_bm.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                wr_bm.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

                var serviceResponse = await _eSyaInPatientAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("WardServices/InsertIntoBedMaster", wr_bm);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Data.Message), "UD:InsertIntoBedMaster:params:" + JsonConvert.SerializeObject(wr_bm));
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Data.Message });
                    }

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertIntoBedMaster:params:" + JsonConvert.SerializeObject(wr_bm));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertIntoBedMaster:params:" + JsonConvert.SerializeObject(wr_bm));
                return Json(new DO_ReturnParameter() { Status = false, Message = ex.ToString() });
            }
        }

        public async Task<ActionResult> UpdateBedMaster(DO_BedMaster wr_bm)
        {
            try
            {
                wr_bm.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                wr_bm.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                wr_bm.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

                var serviceResponse = await _eSyaInPatientAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("WardServices/UpdateBedMaster", wr_bm);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Data.Message), "UD:UpdateBedMaster:params:" + JsonConvert.SerializeObject(wr_bm));
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Data.Message });
                    }

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:UpdateBedMaster:params:" + JsonConvert.SerializeObject(wr_bm));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:UpdateBedMaster:params:" + JsonConvert.SerializeObject(wr_bm));
                return Json(new DO_ReturnParameter() { Status = false, Message = ex.ToString() });
            }
        }
        
        public async Task<ActionResult> GetWardListByBusinessId(int businessKey)
        {
            try
            {
                var serviceResponse = await _eSyaInPatientAPIServices.HttpClientServices.GetAsync<List<DO_WardRoomBusinessLink>>("WardServices/GetWardListByBusinessId?businessKey=" + businessKey);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        var data = serviceResponse.Data;
                        return Json(data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetWardListByBusinessId:For BusinessKey {0}", businessKey);
                        return Json(new { Status = false, Message = serviceResponse.Message });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetWardListByBusinessId:For BusinessKey {0}", businessKey);
                    return Json(new { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetWardListByBusinessId:For BusinessKey {0}", businessKey);
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }
        
        public async Task<ActionResult> GetRoomListByBkWardId(int businessKey, int wardId)
        {
            try
            {
                var serviceResponse = await _eSyaInPatientAPIServices.HttpClientServices.GetAsync<List<DO_WardRoomBusinessLink>>("WardServices/GetRoomListByBkWardId?businessKey=" + businessKey + "&wardId=" + wardId);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        var data = serviceResponse.Data;
                        return Json(data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetRoomListByBkWardId:For BusinessKey {0},WardId {1}", businessKey, wardId);
                        return Json(new { Status = false, Message = serviceResponse.Message });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetRoomListByBkWardId:For BusinessKey {0},WardId {1}", businessKey, wardId);
                    return Json(new { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetRoomListByBkWardId:For BusinessKey {0},WardId {1}", businessKey, wardId);
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }

        public async Task<ActionResult> GetStoreList(int businessKey)
        {
            try
            {
                var serviceResponse = await _eSyaInPatientAPIServices.HttpClientServices.GetAsync<List<DO_StoreMaster>>("CommonData/GetStoreList?businessKey=" + businessKey);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        var data = serviceResponse.Data;
                        return Json(data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetStoreList:For BusinessKey {0}", businessKey);
                        return Json(new { Status = false, Message = serviceResponse.Message });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetStoreList:For BusinessKey {0}", businessKey);
                    return Json(new { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetStoreList:For BusinessKey {0}", businessKey);
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }

        [HttpPost]
        public async Task<ActionResult> GetBedMasterByBkRmId(int businessKey, int roomId)
        {
            try
            {
                var serviceResponse = await _eSyaInPatientAPIServices.HttpClientServices.GetAsync<List<DO_BedMaster>>("WardServices/GetBedMasterByBkRmId?businessKey=" + businessKey + "&roomId=" + roomId + "&codeTypeLocation=" + eSyaInPatient.Data.CodeTypeValues.FloorId);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        var data = serviceResponse.Data;
                        return Json(data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetBedMasterByBkRmId:For BusinessKey {0} and RoomId {1}", businessKey, roomId);
                        return Json(new { Status = false, Message = serviceResponse.Message });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetBedMasterByBkRmId:For BusinessKey {0} and RoomId {1}", businessKey, roomId);
                    return Json(new { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetBedMasterByBkRmId:For BusinessKey {0} and RoomId {1}", businessKey, roomId);
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }

        #endregion Bed Master

        #region Ward Rate Tariff

        public async Task<ActionResult> InsertIntoWardRateLink(DO_WardRateLink obj)
        {
            try
            {
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

                var serviceResponse = await _eSyaInPatientAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("WardServices/InsertIntoWardRateLink", obj);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Data.Message), "UD:InsertIntoWardRateLink:params:" + JsonConvert.SerializeObject(obj));
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Data.Message });
                    }

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertIntoWardRateLink:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertIntoWardRateLink:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = ex.ToString() });
            }
        }

        public async Task<ActionResult> UpdateWardRateLink(DO_WardRateLink obj)
        {
            try
            {
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

                var serviceResponse = await _eSyaInPatientAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("WardServices/UpdateWardRateLink", obj);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Data.Message), "UD:UpdateWardRateLink:params:" + JsonConvert.SerializeObject(obj));
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Data.Message });
                    }

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:UpdateWardRateLink:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:UpdateWardRateLink:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = ex.ToString() });
            }
        }

        public async Task<ActionResult> InsertOrUpdateWardRateLink(List<DO_WardRateLink> wr_rl)
        {
            try
            {
                wr_rl.All(c =>
                {
                    c.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                    c.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                    c.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                    return true;
                });

                var serviceResponse = await _eSyaInPatientAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("WardServices/InsertOrUpdateWardRateLink", wr_rl);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Data.Message), "UD:InsertOrUpdateWardRateLink:params:" + JsonConvert.SerializeObject(wr_rl));
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Data.Message });
                    }

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertOrUpdateWardRateLink:params:" + JsonConvert.SerializeObject(wr_rl));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateWardRateLink:params:" + JsonConvert.SerializeObject(wr_rl));
                return Json(new DO_ReturnParameter() { Status = false, Message = ex.ToString() });
            }
        }

        [HttpPost]
        public async Task<ActionResult> GetWardEffectiveRateByBkRateType(int businessKey, int rateType)
        {
            try
            {
                var serviceResponse = await _eSyaInPatientAPIServices.HttpClientServices.GetAsync< List<DO_WardRateLink>>("WardServices/GetWardEffectiveRateByBkRateType?businessKey=" + businessKey + "&rateType=" + rateType);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        var data = serviceResponse.Data;
                        return Json(data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetWardRateByBkRateType:For BusinessKey {0} and RateType {1}", businessKey, rateType);
                        return Json(new { Status = false, Message = serviceResponse.Message });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetWardRateByBkRateType:For BusinessKey {0} and RateType {1}", businessKey, rateType);
                    return Json(new { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetWardRateByBkRateType:For BusinessKey {0} and RateType {1}", businessKey, rateType);
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }

        [HttpPost]
        public async Task<ActionResult> GetWardPreviousRateByBkRateType(int businessKey, int rateType)
        {
            try
            {
                var serviceResponse = await _eSyaInPatientAPIServices.HttpClientServices.GetAsync<List<DO_WardRateLink>>("WardServices/GetWardPreviousRateByBkRateType?businessKey=" + businessKey + "&rateType=" + rateType);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        var data = serviceResponse.Data;
                        return Json(data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetWardRateByBkRateType:For BusinessKey {0} and RateType {1}", businessKey, rateType);
                        return Json(new { Status = false, Message = serviceResponse.Message });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetWardRateByBkRateType:For BusinessKey {0} and RateType {1}", businessKey, rateType);
                    return Json(new { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetWardRateByBkRateType:For BusinessKey {0} and RateType {1}", businessKey, rateType);
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }


        #endregion Ward Rate Tariff
    }
}