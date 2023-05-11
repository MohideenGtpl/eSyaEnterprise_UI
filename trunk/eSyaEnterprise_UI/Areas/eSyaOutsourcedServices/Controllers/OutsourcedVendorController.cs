using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eSyaEnterprise_UI.ActionFilter;
using eSyaEnterprise_UI.Areas.eSyaOutsourcedServices.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using eSyaEnterprise_UI.Areas.eSyaOutsourcedServices.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using eSyaEnterprise_UI.Models;
using eSyaEnterprise_UI.Utility;
using Newtonsoft.Json;

namespace eSyaEnterprise_UI.Areas.eSyaOutsourcedServices.Controllers
{
    [SessionTimeout]
    public class OutSourcedVendorController : Controller
    {
        private readonly IeSyaOutSourcedAPIService _eSyaOutSourcedAPIService;
        private readonly ILogger<OutSourcedVendorController> _logger;
        public OutSourcedVendorController(IeSyaOutSourcedAPIService eSyaOutSourcedAPIService, ILogger<OutSourcedVendorController> logger)
        {
            _eSyaOutSourcedAPIService = eSyaOutSourcedAPIService;
            _logger = logger;
        }
        [Area("eSyaOutsourcedServices")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> V_3500_00()
        {
            try
            {
                var serviceResponse = await _eSyaOutSourcedAPIService.HttpClientServices.GetAsync<List<DO_BusinessLocation>>("OutSourcedVendor/GetBusinessKey");
                if (serviceResponse.Status)
                {
                    ViewBag.BusinessLocation = serviceResponse.Data.Select(b => new SelectListItem
                    {
                        Value = b.BusinessKey.ToString(),
                        Text = b.LocationDescription,
                    }).ToList();
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetBusinessKey");
                    throw new Exception("Internal Error");
                }
                var serviceGroupResponse = await _eSyaOutSourcedAPIService.HttpClientServices.GetAsync<List<DO_OutSourcedCommonData>>("OutSourcedVendor/GetServiceGroup");
                if (serviceGroupResponse.Status)
                {
                    ViewBag.ServiceGroup = serviceGroupResponse.Data.Select(b => new SelectListItem
                    {
                        Value = b.GroupId.ToString(),
                        Text = b.GroupDesc,
                    }).ToList();

                    return View();
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetServiceGroup");
                    throw new Exception("Internal Error");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetBusinessKey");
                throw ex;
            }
        }

        /// <summary>
        ///Get Service Class by Service Group ID for Drop Down
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetServiceClassbyGroupId(int GroupId)
        {
            try
            {
                var parameter = "?GroupId=" + GroupId;
                var serviceResponse = await _eSyaOutSourcedAPIService.HttpClientServices.GetAsync<List<DO_OutSourcedCommonData>>("OutSourcedVendor/GetServiceClassbyGroupId" + parameter);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetServiceClassbyGroupId:For GroupId {0}", GroupId);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetServiceClassbyGroupId:For GroupId {0}", GroupId);
                throw ex;
            }
        }
        /// <summary>
        ///Get Get Service  by Class  ID for Drop Down
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetServicebyClassId(int ClassId)
        {
            try
            {
                var parameter = "?ClassId=" + ClassId;
                var serviceResponse = await _eSyaOutSourcedAPIService.HttpClientServices.GetAsync<List<DO_OutSourcedCommonData>>("OutSourcedVendor/GetServicebyClassId" + parameter);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetServicebyClassId:For ClassId {0}", ClassId);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetServicebyClassId:For ClassId {0}", ClassId);
                throw ex;
            }
        }

        /// <summary>
        ///Get Out Sourced Service for Tree View
        /// </summary>
        [Produces("application/json")]
        [HttpGet]
        public async Task<JsonResult> GetServicebyBusinessKeyforTreeView(int BusinessKey)
        {
            try
            {
                List<jsTreeObject> jsTree = new List<jsTreeObject>();

                jsTreeObject jsObj = new jsTreeObject
                {
                    id = "MM",
                    parent = "#",
                    text = "OutSourced Service",
                    state = new stateObject { opened = true, selected = false }
                };
                jsTree.Add(jsObj);
                var parameter = "?BusinessKey=" + BusinessKey;
                var serviceResponse = await _eSyaOutSourcedAPIService.HttpClientServices.GetAsync<List<DO_OutSourcedService>>("OutSourcedVendor/GetServicebyBusinessKeyforTreeView" + parameter);
                if (serviceResponse.Status)
                {
                    var Outsourcedservice = serviceResponse.Data;
                    if (Outsourcedservice != null)
                    {
                        foreach (var f in Outsourcedservice.OrderBy(o => o.ServiceId))
                        {
                            jsObj = new jsTreeObject
                            {
                                id = "FM" + f.ServiceId.ToString() + "_" + f.ServiceId.ToString(),
                                text = f.ServiceName,
                                GroupIndex = f.ServiceId.ToString() + "_" + f.ActiveStatus.ToString() + "_" + f.ServiceId.ToString(),
                                parent = "MM",
                                state = new stateObject { opened = true, selected = false }
                            };
                            jsTree.Add(jsObj);
                        }
                    }
                    return Json(jsTree);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetServicebyBusinessKeyforTreeView:For BusinessKey {0}", BusinessKey);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetServicebyBusinessKeyforTreeView:For BusinessKey {0}", BusinessKey);
                throw ex;
            }
        }
        /// <summary>
        ///Get Business Entity Info
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetOutSourcedServiceInfo(int Businesskey ,int ServiceId)
        {
            try
            {
                var parameter = "?Businesskey=" + Businesskey + "&ServiceId=" + ServiceId;
                var serviceResponse = await _eSyaOutSourcedAPIService.HttpClientServices.GetAsync<DO_OutSourcedService>("OutSourcedVendor/GetOutSourcedServiceInfo" + parameter);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetOutSourcedServiceInfo:For Businesskey {0} with ServiceId entered {1}", Businesskey, ServiceId);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetOutSourcedServiceInfo:For Businesskey {0} with ServiceId entered {1}", Businesskey, ServiceId);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetOutSourcedServiceInfo:For Businesskey {0} with ServiceId entered {1}", Businesskey, ServiceId);
                throw ex;
            }
        }
        /// <summary>
        /// Insert or Update Out Sourced Service
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateOutSourcedService(DO_OutSourcedService obj)
        {
            try
            {
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                var serviceResponse = await _eSyaOutSourcedAPIService.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("OutSourcedVendor/InsertOrUpdateOutSourcedService", obj);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertOrUpdateOutSourcedService:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateOutSourcedService:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }

        [Area("eSyaOutsourcedServices")]
        public IActionResult V_3501_00()
        {
            return View();
        }
    }
}