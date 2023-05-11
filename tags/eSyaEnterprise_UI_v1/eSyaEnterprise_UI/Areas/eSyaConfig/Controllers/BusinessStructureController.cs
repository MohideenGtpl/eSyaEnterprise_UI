using System;
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
using eSyaEnterprise_UI.Areas.eSyaConfig.Models;

namespace eSyaEnterprise_UI.Areas.Config.Controllers
{
    [SessionTimeout]
    public class BusinessStructureController : Controller
    {
        private readonly IeSyaConfigAPIServices _eSyaConfigAPIServices;
        private readonly ILogger<BusinessStructureController> _logger;

        public BusinessStructureController(IeSyaConfigAPIServices eSyaConfigAPIServices, ILogger<BusinessStructureController> logger)
        {
            _eSyaConfigAPIServices = eSyaConfigAPIServices;
            _logger = logger;
        }

        #region Business Entity
        /// <summary>
        /// Business Entity
        /// </summary>
        /// <returns></returns>
       
        [Area("eSyaConfig")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult V_101_00()
        {
            
            return View();
        }

        
        /// <summary>
        ///Get Business Entities for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetBusinessEntities()
        {
            try
            {
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_BusinessEntity>>("BusinessStructure/GetBusinessEntities");
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetBusinessEntities");
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetBusinessEntities");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetBusinessEntities");
                throw ex;
            }

        }

        /// <summary>
        ///Get Business Entities for Tree View
        /// </summary>
        [Produces("application/json")]
        [HttpGet]
        public async Task<JsonResult> GetBusinessEntitiesforTreeView()
        {
            try
            {
                List<jsTreeObject> jsTree = new List<jsTreeObject>();

                jsTreeObject jsObj = new jsTreeObject
                {
                    id = "MM",
                    parent = "#",
                    text = "Business Entity",
                    state = new stateObject { opened = true, selected = false }
                };
                jsTree.Add(jsObj);

                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_BusinessEntity>>("BusinessStructure/GetBusinessEntities");
                if (serviceResponse.Status)
                {
                    var BusinessEntities = serviceResponse.Data;
                    if (BusinessEntities != null)
                    {
                        foreach (var f in BusinessEntities.OrderBy(o => o.BusinessId))
                        {
                            jsObj = new jsTreeObject
                            {
                                id = "FM" + f.BusinessId.ToString() + "_" + f.BusinessId.ToString(),
                                text = f.BusinessDesc,
                                //GroupIndex = f.BusinessId.ToString() + "_" + f.ActiveStatus.ToString() + "_" + f.IsMultiSegmentApplicable.ToString(),
                                GroupIndex = f.BusinessId.ToString() + "_" + f.ActiveStatus.ToString(),
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
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetBusinessEntitiesforTreeView");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetBusinessEntitiesforTreeView");
                throw ex;
                //return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        ///Get Business Entity Info
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetBusinessEntityInfo(int BusinessId)
        {
            try
            {
                var parameter = "?BusinessId=" + BusinessId;
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<DO_BusinessEntity>("BusinessStructure/GetBusinessEntityInfo" + parameter);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetBusinessEntityInfo:For BusinessId {0}", BusinessId);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetBusinessEntityInfo:For BusinessId {0}", BusinessId);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetBusinessEntityInfo:For BusinessId {0}", BusinessId);
                throw ex;
            }
        }

        /// <summary>
        /// Insert or Update Business Entity
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateBusinessEntity(DO_BusinessEntity businessentity)
        {
            try
            {
                if (businessentity.BusinessUnitType == 'S'.ToString())
                {
                    businessentity.NoOfUnits = 1;
                }
                if (string.IsNullOrEmpty(businessentity.BusinessDesc))
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Enter Entity Description" });
                }
                else
                {
                    businessentity.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                    businessentity.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                    businessentity.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                    if (businessentity.BusinessId == 0)
                    {
                        var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("BusinessStructure/InsertBusinessEntity", businessentity);
                        if (serviceResponse.Status)
                            return Json(serviceResponse.Data);
                        else
                        {
                            _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertOrUpdateBusinessEntity:params:" + JsonConvert.SerializeObject(businessentity));
                            return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                        }
                    }
                    else
                    {
                        var serviceResponse = _eSyaConfigAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("BusinessStructure/UpdateBusinessEntity", businessentity).Result;
                        if (serviceResponse.Status)
                            return Json(serviceResponse.Data);
                        else
                        {
                            _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertOrUpdateBusinessEntity:params:" + JsonConvert.SerializeObject(businessentity));
                            return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateBusinessEntity:params:" + JsonConvert.SerializeObject(businessentity));
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }

        /// <summary>
        ///DELETE Business Entity
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> DeleteBusinessEntity(int BusinessEntityId)
        {
            try
            {
                var parameter = "?BusinessEntityId=" + BusinessEntityId;
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("BusinessStructure/DeleteBusinessEntity" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:DeleteBusinessEntity:For BusinessEntityId {0}}", BusinessEntityId);
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:DeleteBusinessEntity:For BusinessEntityId {0}", BusinessEntityId);
                return Json(new { Status = false, Message = ex.ToString() });
                //return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        #endregion Business Entity

        #region Business Unit
        /// <summary>
        /// Business Unit
        /// </summary>
        /// <returns></returns>

        [Area("eSyaConfig")]
        //[ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> V_101_IN()
        {
            try
            {
                ViewBag.UserFormRole = new DO_UserFormRole { IsInsert = true, IsEdit = true, IsView = true, IsDelete = true };

                var Entities_Response = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_BusinessEntity>>("BusinessStructure/GetActiveBusinessEntities");
                var IsD_Response = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_CountryCodes>>("ConfigMasterData/GetISDCodes");
                var Tax_Response = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_TaxIdentification>>("Country/GetActiveTaxIdentification");
                var Currency_Response = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_CurrencyMaster>>("ConfigMasterData/GetActiveCurrencyCodes");

                if (Entities_Response.Status && IsD_Response.Status && Tax_Response.Status && Currency_Response.Status)
                {
                    ViewBag.Entities = Entities_Response.Data.Select(e => new SelectListItem
                    {
                        Value = e.BusinessId.ToString(),
                        Text = e.BusinessDesc,
                    }).ToList();

                    ViewBag.ISDCodes = IsD_Response.Data.Select(i => new SelectListItem
                    {
                        Value = i.Isdcode.ToString(),
                        Text = i.Isdcode.ToString()+"-"+ i.CountryName.ToString(),
                    }).ToList();

                    ViewBag.TaxIdentifications = Tax_Response.Data.Select(t => new SelectListItem
                    {
                        Value = t.TaxIdentificationId.ToString(),
                        Text = t.TaxIdentificationDesc,
                       
                    }).ToList();

                    ViewBag.CurrencyCodes = Currency_Response.Data.Select(c => new SelectListItem
                    {
                        Value = c.CurrencyCode.ToString(),
                        Text = c.CurrencyName,
                    }).ToList();

                    return View();
                }
                else
                {
                    _logger.LogError(new Exception(Entities_Response.Message), "UD:GetActiveBusinessEntities");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetActiveBusinessEntities");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        ///Get Business Units by Business Id for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetBusinessUnitsbyBusinessId(int BusinessId)
        {

            try
            {
                var parameter = "?BusinessId=" + BusinessId;
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_BusinessUnit>>("BusinessStructure/GetBusinessUnitsbyBusinessId" + parameter);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetBusinessUnitsbyBusinessId:For BusinessId {0}", BusinessId);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetBusinessUnitsbyBusinessId:For BusinessId {0} ", BusinessId);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }

        }
        /// <summary>
        /// Insert or Update Business Unit
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateBusinessUnit(DO_BusinessUnit obj)
        {

            try
            {
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

                if (obj.BusinessUnitId == 0)
                {
                    var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("BusinessStructure/InsertBusinessUnit", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

                else
                {
                    var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("BusinessStructure/UpdateBusinessUnit", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateBusinessUnit:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Activate or De Activate Business Unit
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> ActiveOrDeActiveBusinessUnit(bool status, int BusinessId, int BusinessUnitId)
        {

            try
            {

                var parameter = "?status=" + status + "&BusinessId=" + BusinessId + "&BusinessUnitId=" + BusinessUnitId;
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("BusinessStructure/ActiveOrDeActiveBusinessUnit" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ActiveOrDeActiveBusinessUnit:For BusinessUnitId {0} ", BusinessUnitId);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        ///Get Business Sub Units by Business Id for drop down
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetBusinessSubUnits(int BusinessId)
        {
            try
            {
                var parameter = "?BusinessId=" + BusinessId;
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_BusinessUnit>>("BusinessStructure/GetBusinessSubUnits"+ parameter);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetBusinessSubUnits:For BusinessId {0}", BusinessId);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetBusinessSubUnits:For BusinessId {0}", BusinessId);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetBusinessSubUnits:For BusinessId {0}", BusinessId);
                throw ex;
            }
        }
        #endregion  Business Unit

        #region Business Segment
        /// <summary>
        /// Business Segment
        /// </summary>
        /// <returns></returns>
        [Area("eSyaConfig")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> V_102_00()
        {
            try
            {
                var Isdresponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_CountryCodes>>("ConfigMasterData/GetISDCodes");
                if (Isdresponse.Status)
                {
                    if (Isdresponse.Data != null)
                    {
                     
                        ViewBag.ISDCodeList = Isdresponse.Data.Select(b => new SelectListItem
                        {
                            Value = b.Isdcode.ToString(),
                            Text = b.Isdcode.ToString() + '-' + b.CountryName,
                        }).ToList();
                    }
                    else
                    {
                        _logger.LogError(new Exception(Isdresponse.Message), "UD:BusinessSegment");
                    }
                }
                else
                {
                    _logger.LogError(new Exception(Isdresponse.Message), "UD:BusinessSegment");
                }
                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:BusinessSegment");
                throw ex;
            }
        }
         
        /// <summary>
        ///Get Business Segments by Business Id for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetBusinessSegmentByBusinessId(int BusinessId)
        {
            try
            {
                var parameter = "?BusinessId=" + BusinessId;
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_BusinessSegment>>("BusinessStructure/GetBusinessSegmentByBusinessId" + parameter);

                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetBusinessSegmentByBusinessId:For BusinessId {0}", BusinessId);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetBusinessSegmentByBusinessId:For BusinessId {0}", BusinessId);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetBusinessSegmentByBusinessId:For BusinessId {0}", BusinessId);
                throw ex;
                //return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        ///Get Business Segment for Tree View
        /// </summary>
        [Produces("application/json")]
        [HttpGet]
        public async Task<JsonResult> GetBusinessSegmentforTreeView()
        {
            try
            {
                List<jsTreeObject> jsTree = new List<jsTreeObject>();

                jsTreeObject jsObj = new jsTreeObject
                {
                    id = "MM",
                    parent = "#",
                    text = "Business Entity",
                    state = new stateObject { opened = true, selected = false }
                };
                jsTree.Add(jsObj);

                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<DO_BusinessConfiguration>("BusinessStructure/GetBusinessSegment");
                if (serviceResponse.Status)
                {
                    var BusinessSegment = serviceResponse.Data;
                    if (BusinessSegment != null)
                    {
                        foreach (var f in BusinessSegment.l_BusinessEntity.OrderBy(o => o.BusinessId))
                        {
                            jsObj = new jsTreeObject
                            {
                                id = "MM" + f.BusinessId.ToString(),
                                text = f.BusinessDesc,
                                GroupIndex = f.BusinessId.ToString(),
                                parent = "MM",
                                state = new stateObject { opened = true, selected = false }
                            };
                            jsTree.Add(jsObj);
                        }

                        foreach (var f in BusinessSegment.l_BusinessSegment.OrderBy(o => o.BusinessId))
                        {
                            jsObj = new jsTreeObject
                            {
                                id = "SM" + f.BusinessId.ToString() + "_" + f.SegmentId.ToString(),
                                text = f.SegmentDesc,
                                GroupIndex = f.BusinessId.ToString(),
                                parent = "MM" + f.BusinessId.ToString(),
                                state = new stateObject { opened = true, selected = false }
                            };
                            jsTree.Add(jsObj);
                        }
                    }
                    return Json(jsTree);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetBusinessSegmentforTreeView");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetBusinessSegmentforTreeView");
                throw ex;
                //return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        ///Get Business Segment Info
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetBusinessSegmentInfo(int BusinessId, int SegmentId)
        {
            try
            {
                var parameter = "?BusinessId=" + BusinessId + "&SegmentId=" + SegmentId;
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<DO_BusinessSegment>("BusinessStructure/GetBusinessSegmentInfo" + parameter);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetBusinessSegmentInfo:For BusinessId {0} with SegmentId entered {1}", BusinessId, SegmentId);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetBusinessSegmentInfo:For BusinessId {0} with SegmentId entered {1}", BusinessId, SegmentId);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetBusinessSegmentInfo:For BusinessId {0} with SegmentId entered {1}", BusinessId, SegmentId);
                throw ex;
                //return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Insert or Update Business Segment
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateBusinessSegment(DO_BusinessSegment BusinessSegment)
        {
            try
            {
                if (string.IsNullOrEmpty(BusinessSegment.BusinessId.ToString()) || BusinessSegment.BusinessId == 0)
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select Business Entity" });
                }
                else if (string.IsNullOrEmpty(BusinessSegment.SegmentDesc))
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Enter Segment Description" });
                }
                else if (string.IsNullOrEmpty(BusinessSegment.Isdcode.ToString()) || BusinessSegment.Isdcode == 0)
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select ISD Code" });
                }
                //else if (string.IsNullOrEmpty(BusinessSegment.OrgnDateFormat))
                //{
                //    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select Date Format" });
                //}
                else
                {
                    BusinessSegment.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                    BusinessSegment.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                    BusinessSegment.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                    if (BusinessSegment.SegmentId == 0)
                    {
                        var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("BusinessStructure/InsertBusinessSegment", BusinessSegment);
                        if (serviceResponse.Status)
                            return Json(serviceResponse.Data);
                        else
                        {
                            _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertOrUpdateBusinessSegment:params:" + JsonConvert.SerializeObject(BusinessSegment));
                            return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                        }
                    }
                    else
                    {
                        var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("BusinessStructure/UpdateBusinessSegment", BusinessSegment);
                        if (serviceResponse.Status)
                            return Json(serviceResponse.Data);
                        else
                        {
                            _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertOrUpdateBusinessSegment:params:" + JsonConvert.SerializeObject(BusinessSegment));
                            return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateBusinessSegment:params:" + JsonConvert.SerializeObject(BusinessSegment));
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }

        /// <summary>
        ///DELETE Business Segment
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> DeleteBusinessSegment(int BusinessId, int SegmentId)
        {
            try
            {
                if (string.IsNullOrEmpty(BusinessId.ToString()) || BusinessId == 0)
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select Business Entity" });
                }
                else if (string.IsNullOrEmpty(SegmentId.ToString()) || SegmentId == 0)
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Enter Segment Description" });
                }
                else
                {
                    var parameter = "?BusinessId=" + BusinessId + "&SegmentId=" + SegmentId;
                    var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("BusinessStructure/DeleteBusinessSegment" + parameter);

                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:DeleteBusinessSegment:For BusinessId {0} with SegmentId entered {1}", BusinessId, SegmentId);
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:DeleteBusinessSegment:For BusinessId {0} with SegmentId entered {1}", BusinessId, SegmentId);
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }
        /// <summary>
        ///Get Currency Name by IsdCode
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetCurrencyNamebyIsdCode(int IsdCode)
        {
            try
            {
                var parameter = "?IsdCode=" + IsdCode;
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<DO_CountryCodes>("Country/GetCurrencyNamebyIsdCode" + parameter);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetCurrencyNamebyIsdCode:For IsdCode {0}", IsdCode);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetCurrencyNamebyIsdCode:For ISDCode {0}", IsdCode);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetCurrencyNamebyIsdCode:For ISDCode {0}", IsdCode);
                throw ex;
            }
        }

        /// <summary>
        ///Check Allow Multi Segment
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> IsAllowMultiSegment(int BusinessId)
        {
            try
            {
                var parameter = "?BusinessId=" + BusinessId;
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<bool>("BusinessStructure/IsAllowMultiSegment" + parameter);

                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        //return Json(serviceResponse.Data);
                        return Json(new { Status = true, IsAllowMultiSegment = serviceResponse.Data });
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:IsAllowMultiSegment:For BusinessId {0}", BusinessId);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:IsAllowMultiSegment:For BusinessId {0}", BusinessId);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:IsAllowMultiSegment:For BusinessId {0}", BusinessId);
                throw ex;
            }
        }
        #endregion Business Segment

        #region Business Location
        /// <summary>
        /// Business Location
        /// </summary>
        /// <returns></returns>
        /// 
        [Area("eSyaConfig")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> V_103_00()
        {
            try
            {
                /// Tax Identification for Dropdown
                var Taxresponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_TaxIdentification>>("Country/GetActiveTaxIdentification");
                var serviceResponse =await _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_BusinessEntity>>("BusinessStructure/GetActiveBusinessEntities");

                if (serviceResponse.Status && Taxresponse.Status)
                {
                    if (serviceResponse.Data != null && Taxresponse.Data != null)
                    {
                        ViewBag.TaxList = Taxresponse.Data.Select(b => new SelectListItem
                        {
                            Value = b.TaxIdentificationId.ToString(),
                            Text = b.TaxIdentificationDesc,
                        }).ToList();

                        ViewBag.entity_list = serviceResponse.Data;
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:BusinessLocation");
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:BusinessLocation");
                }

                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:BusinessLocation");
                throw ex;
            }
        }

        /// <summary>
        ///Get Business Segment by Business Id for drop down
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetTaxIdentificationByBSeg(int BusinessId, int SegmentId)
        {
            try
            {
                var parameter = "?BusinessId=" + BusinessId + "&SegmentId=" + SegmentId;
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_TaxIdentification>>("Country/GetTaxIdentificationByBSeg" + parameter);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetTaxIdentificationByBSeg:For BusinessId {0} with SegmentId entered {1}", BusinessId, SegmentId);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetTaxIdentificationByBSeg:For BusinessId {0} with SegmentId entered {1}", BusinessId, SegmentId);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetTaxIdentificationByBSeg:For BusinessId {0} with SegmentId entered {1}", BusinessId, SegmentId);
                throw ex;
            }
        }

        /// <summary>
        ///Get Business Segment by Business Id for drop down
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetActiveBusinessSegmentbyBusinessId(int BusinessId)
        {
            try
            {
                var parameter = "?BusinessId=" + BusinessId;
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_BusinessSegment>>("BusinessStructure/GetActiveBusinessSegmentbyBusinessId" + parameter);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetActiveBusinessSegmentbyBusinessId:For BusinessId {0}", BusinessId);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetActiveBusinessSegmentbyBusinessId:For BusinessId {0}", BusinessId);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetActiveBusinessSegmentbyBusinessId:For BusinessId {0}", BusinessId);
                throw ex;
            }
        }
        /// <summary>
        ///Get Business Location by Business Id & SegmentId for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetBusinessLocationByBusinessIdandSegmentId(int BusinessId, int SegmentId)
        {
            try
            {
                var parameter = "?BusinessId=" + BusinessId + "&SegmentId=" + SegmentId;
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_BusinessLocation>>("BusinessStructure/GetBusinessLocationByBusinessIdandSegmentId" + parameter);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetBusinessLocationByBusinessIdandSegmentId:For BusinessId {0} with SegmentId entered {1}", BusinessId, SegmentId);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetBusinessLocationByBusinessIdandSegmentId:For BusinessId {0} with SegmentId entered {1}", BusinessId, SegmentId);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetBusinessLocationByBusinessIdandSegmentId:For BusinessId {0} with SegmentId entered {1}", BusinessId, SegmentId);
                throw ex;
            }
        }

        /// <summary>
        ///Get Business Entities for Tree View
        /// </summary>
        [Produces("application/json")]
        [HttpGet]
        public async Task<JsonResult> GetBusinessLocationforTreeView()
        {
            try
            {
                List<jsTreeObject> jsTree = new List<jsTreeObject>();

                jsTreeObject jsObj = new jsTreeObject
                {
                    id = "MM",
                    parent = "#",
                    text = "Business Entity",
                    state = new stateObject { opened = true, selected = false }
                };
                jsTree.Add(jsObj);

                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<DO_BusinessConfiguration>("BusinessStructure/GetBusinessLocation");

                if (serviceResponse.Status)
                {
                    var BusinessSegment = serviceResponse.Data;
                    if (BusinessSegment != null)
                    {
                        foreach (var f in BusinessSegment.l_BusinessEntity.OrderBy(o => o.BusinessId))
                        {
                            jsObj = new jsTreeObject
                            {
                                id = "MM" + f.BusinessId.ToString(),
                                text = f.BusinessDesc,
                                GroupIndex = f.BusinessId.ToString(),
                                parent = "MM",
                                state = new stateObject { opened = true, selected = false }
                            };
                            jsTree.Add(jsObj);
                        }

                        foreach (var f in BusinessSegment.l_BusinessSegment.OrderBy(o => o.BusinessId))
                        {
                            jsObj = new jsTreeObject
                            {
                                id = "SM" + f.BusinessId.ToString() + "_" + f.SegmentId.ToString(),
                                text = f.SegmentDesc,
                                GroupIndex = f.BusinessId.ToString(),
                                parent = "MM" + f.BusinessId.ToString(),
                                state = new stateObject { opened = true, selected = false }
                            };
                            jsTree.Add(jsObj);
                        }

                        foreach (var f in BusinessSegment.l_BusinessLocation.OrderBy(o => o.BusinessId))
                        {
                            jsObj = new jsTreeObject
                            {
                                id = "FM" + f.BusinessId.ToString() + "_" + f.SegmentId.ToString() + "_" + f.LocationId.ToString(),
                                text = f.LocationDescription,
                                GroupIndex = f.SegmentId.ToString(),
                                parent = "SM" + f.BusinessId.ToString() + "_" + f.SegmentId.ToString(),
                                state = new stateObject { opened = true, selected = false }
                            };
                            jsTree.Add(jsObj);
                        }
                    }
                    return Json(jsTree);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetBusinessSegmentforTreeView");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetBusinessSegmentforTreeView");
                throw ex;
            }
        }

        /// <summary>
        ///Get Business Location Info
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetBusinessLocationInfo(int BusinessId, int SegmentId, int LocationId)
        {
            try
            {
                var parameter = "?BusinessId=" + BusinessId + "&SegmentId=" + SegmentId + "&LocationId=" + LocationId;
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<DO_BusinessLocation>("BusinessStructure/GetBusinessLocationInfo" + parameter);
                //return Json(serviceResponse.Data);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetBusinessLocationInfo:For BusinessId {0} SegmentId {1} with LocationId {2}", BusinessId, SegmentId, LocationId);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetBusinessLocationInfo:For BusinessId {0} SegmentId {1} with LocationId {2}", BusinessId, SegmentId, LocationId);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetBusinessLocationInfo:For BusinessId {0} SegmentId {1} with LocationId {2}", BusinessId, SegmentId, LocationId);
                throw ex;
            }
        }

        /// <summary>
        ///Get Business Location Currency for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetBSCurrency(int BusinessId, int SegmentId, int LocationId)
        {
            try
            {
                string businessKey = BusinessId.ToString() + SegmentId.ToString() + LocationId.ToString();

                var parameter = "?BusinessKey=" + Convert.ToInt32(businessKey);
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_BusienssSegmentCurrency>>("BusinessStructure/GetBSCurrency" + parameter);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetBSCurrency:For BusinessId {0} SegmentId {1} with locationId entered {2}", BusinessId, SegmentId, LocationId);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetBSCurrency:For BusinessId {0} SegmentId {1} with locationId entered {2}", BusinessId, SegmentId, LocationId);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetBSCurrency:For BusinessId {0} SegmentId {1} with locationId entered {2}", BusinessId, SegmentId, LocationId);
                throw ex;
            }
        }

        /// <summary>
        /// Insert or Update Business Location
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateBusinessLocation(DO_BusinessLocation BusinessLocation)
        {
            try
            {
                if (string.IsNullOrEmpty(BusinessLocation.BusinessId.ToString()) || BusinessLocation.BusinessId == 0)
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select Business Entity" });
                }
                else if (string.IsNullOrEmpty(BusinessLocation.SegmentId.ToString()) || BusinessLocation.SegmentId == 0)
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select Business Segment" });
                }
                else if (string.IsNullOrEmpty(BusinessLocation.LocationDescription))
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Enter Segment Description" });
                }
                else if (string.IsNullOrEmpty(BusinessLocation.BusinessName))
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Enter Business Name" });
                }
                //else if (string.IsNullOrEmpty(BusinessLocation.TaxIdentification.ToString()) || BusinessLocation.TaxIdentification == 0)
                //{
                //    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select Tax Identification" });
                //}
                else if (string.IsNullOrEmpty(BusinessLocation.LicenseType))
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select License Type" });
                }
                else
                {
                    BusinessLocation.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                    BusinessLocation.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                    BusinessLocation.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                    if (BusinessLocation.LocationId == 0)
                    {
                        var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("BusinessStructure/InsertBusinessLocation", BusinessLocation);
                        if (serviceResponse.Status)
                            return Json(serviceResponse.Data);
                        else
                        {
                            _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertOrUpdateBusinessLocation:params:" + JsonConvert.SerializeObject(BusinessLocation));
                            return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                        }
                    }
                    else
                    {
                        var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("BusinessStructure/UpdateBusinessLocation", BusinessLocation);
                        if (serviceResponse.Status)
                            return Json(serviceResponse.Data);
                        else
                        {
                            _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertOrUpdateBusinessLocation:params:" + JsonConvert.SerializeObject(BusinessLocation));
                            return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateBusinessLocation:params:" + JsonConvert.SerializeObject(BusinessLocation));
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }

        /// <summary>
        ///DELETE Business Segment
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> DeleteBusinessLocation(int BusinessId, int SegmentId, int LocationId)
        {
            try
            {
                if (BusinessId == 0)
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select Business Entity" });
                }
                else if (SegmentId == 0)
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select Business Segment" });
                }
                else if (LocationId == 0)
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select Business Location" });
                }
                else
                {
                    var parameter = "?BusinessId=" + BusinessId + "&SegmentId=" + SegmentId + "&LocationId=" + LocationId;
                    var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("BusinessStructure/DeleteBusinessLocation" + parameter);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:DeleteBusinessLocation:For BusinessId {0} SegmentId {1} with LocationId {2}", BusinessId, SegmentId, LocationId);
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:DeleteBusinessLocation:For BusinessId {0} SegmentId {1} with LocationId {2}", BusinessId, SegmentId, LocationId);
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }

        /// <summary>
        ///Check Allow Multi Location
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> IsAllowMultiLocation(int BusinessId, int SegmentId)
        {
            try
            {
                var parameter = "?BusinessId=" + BusinessId + "&SegmentId=" + SegmentId;
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<bool>("BusinessStructure/IsAllowMultiLocation" + parameter);

                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        //return Json(serviceResponse.Data);
                        return Json(new { Status = true, IsAllowMultiLocation = serviceResponse.Data });
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:IsAllowMultiSegment:For BusinessId {0}", BusinessId);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:IsAllowMultiSegment:For BusinessId {0}", BusinessId);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:IsAllowMultiSegment:For BusinessId {0}", BusinessId);
                throw ex;
            }
        }
        /// <summary>
        ///Get Business Parameter 
        /// </summary>
        //[HttpPost]
        //public JsonResult GetBusinessParamter(int BusinessId, int SegmentId, int LocationId)
        //{
        //    try
        //    {
        //        int BusienssKey = Convert.ToInt32(BusinessId.ToString() + SegmentId.ToString() + LocationId.ToString());
        //        var parameter = "?BusienssKey=" + BusienssKey;
        //        var serviceResponse = _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_BusinessParameterLink>>("BusinessStructure/GetBusinessParamter" + parameter).Result;
        //        return Json(serviceResponse.Data);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
        //    }
        //}
        #endregion Business Location

        #region Business Stores
        [Area("eSyaConfig")]
        public IActionResult V_14_00()
        {
            ViewBag.formName = "Business Stores";

            ///Getting Store Codes
            var serviceResponse = _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_StoreMaster>>("StoreMaster/GetActiveStoreCodes").Result;
            ViewBag.StoreMaster = serviceResponse.Data;
            ///Getting Business Key
            var Bk_response = _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_BusinessLocation>>("ConfigMasterData/GetBusinessKey").Result;
            ViewBag.BusinessKeys = Bk_response.Data;
            return View();
        }

        /// <summary>
        /// Insert or Update Business Stores
        /// </summary>
        [HttpPost]
        public JsonResult InsertOrUpdateBusinessStores(DO_BusinessStores postData)
        {

            try
            {
                if (postData.BusinessKey == 0)
                {
                    return Json(new { Status = false, Message = "Please Select Location" });
                }
                postData.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                postData.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                var serviceResponse = _eSyaConfigAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("BusinessStructure/InsertOrUpdateBusinessStores", postData).Result;
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
            }
            catch (Exception ex)
            {
                return Json(new { Status = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
            }
        }
        /// <summary>
        /// Get Business Stores
        /// </summary>
        [HttpPost]
        public JsonResult GetBusinessStores([FromQuery] int Businesskey)
        {
            try
            {
                var parameter = "?Businesskey=" + Businesskey;
                var serviceResponse = _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_BusinessStores>>("BusinessStructure/GetBusinessStores" + parameter).Result;
                return Json(serviceResponse.Data);
            }
            catch (Exception ex)
            {
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        #endregion Business Stores

        #region Business Statutory Details
        [Area("eSyaConfig")]
        public IActionResult V_15_00()
        {
            ViewBag.formName = "Business Statutory Details";
            // Getting  Country Statutory Details
            var serviceResponse = _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_CountryStatutoryDetails>>("Country/GetActiveStatutoryCodes").Result;
            ViewBag.StatCodes = serviceResponse.Data;

            ///Getting  Business Keys
            var Bk_response = _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_BusinessLocation>>("ConfigMasterData/GetBusinessKey").Result;
            ViewBag.BusinessKeys = Bk_response.Data;
            return View();
        }

        /// <summary>
        /// Insert or Update Business Statutory Details
        /// </summary>
        [HttpPost]
        public JsonResult InsertOrUpdateBusinessStatutoryDetails(DO_BusinessStatutoryDetails postData)
        {

            try
            {
                if (postData.BusinessKey == 0)
                {
                    return Json(new { Status = false, Message = "Please Select Location" });
                }
                postData.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                postData.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                var serviceResponse = _eSyaConfigAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("BusinessStructure/InsertOrUpdateBusinessStatutoryDetails", postData).Result;
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
            }
            catch (Exception ex)
            {
                return Json(new { Status = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
            }
        }
        /// <summary>
        /// Get Business Statutory Details
        /// </summary>
        [HttpPost]
        public JsonResult GetBusinessStatutoryDetails(int Businesskey)
        {
            try
            {
                var parameter = "?Businesskey=" + Businesskey;
                var serviceResponse = _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_BusinessStatutoryDetails>>("BusinessStructure/GetBusinessStatutoryDetails" + parameter).Result;
                return Json(serviceResponse.Data);
            }
            catch (Exception ex)
            {
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        #endregion Business Statutory Details

        #region Business Subscription
        /// <summary>
        /// Business Subscription
        /// </summary>
        /// <returns></returns>
        /// 
        [Area("eSyaConfig")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> V_104_00()
        {
            try
            {
                ///Getting Business Key
                var Bk_response = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_BusinessLocation>>("ConfigMasterData/GetBusinessKey");

                if (Bk_response.Status)
                {
                    if (Bk_response.Data != null)
                    {
                        ViewBag.BusinessKeyList = Bk_response.Data.Select(b => new SelectListItem
                        {
                            Value = b.BusinessKey.ToString(),
                            Text = b.LocationDescription.ToString(),
                        }).ToList();
                    }
                    else
                    {
                        _logger.LogError(new Exception(Bk_response.Message), "UD:BusinessSubscription");
                    }
                }
                else
                {
                    _logger.LogError(new Exception(Bk_response.Message), "UD:BusinessSubscription");
                }
                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:BusinessSubscription");
                throw ex;
            }
        }

        /// <summary>
        ///Get Business Subscription by Business Key for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetBusinessSubscription(int BusinessKey)
        {
            try
            {
                var parameter = "?BusinessKey=" + BusinessKey;
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_BusinessSubscription>>("BusinessStructure/GetBusinessSubscription" + parameter);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetBusinessSubscription:For BusinessKey {0}", BusinessKey);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetBusinessSubscription:For BusinessKey {0}", BusinessKey);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetBusinessSubscription:For BusinessKey {0}", BusinessKey);
                throw ex;
            }
        }

        /// <summary>
        /// Insert or Update Business Subscription
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateBusinessSubscription(DO_BusinessSubscription busssubs)
        {
            try
            {
                if (string.IsNullOrEmpty(busssubs.BusinessKey.ToString()) || busssubs.BusinessKey == 0)
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select Business Key" });
                }
                else if (busssubs.SubscribedFrom > busssubs.SubscribedTill)
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Subscribed Till Date can't Less Than Subscribed From." });
                }

                else if (busssubs.SubscribedTill < System.DateTime.Now)
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Subscribed Till Date can't Less Than Current Date." });
                }
                else
                {
                    busssubs.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                    busssubs.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                    busssubs.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

                    var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("BusinessStructure/InsertOrUpdateBusinessSubscription", busssubs);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertOrUpdateBusinessSubscription:params:" + JsonConvert.SerializeObject(busssubs));
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateBusinessSubscription:params:" + JsonConvert.SerializeObject(busssubs));
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }
        #endregion  Business Subscription

        #region Business Statutory
        [Area("eSyaConfig")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> V_105_00()
        {
            try
            {
                ///Getting Business Key
                var Bk_response = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_BusinessLocation>>("ConfigMasterData/GetBusinessKey");

                if (Bk_response.Status)
                {
                    if (Bk_response.Data != null)
                    {
                        ViewBag.BusinessKeyList = Bk_response.Data.Select(b => new SelectListItem
                        {
                            Value = b.BusinessKey.ToString(),
                            Text = b.LocationDescription.ToString(),
                        }).ToList();
                    }
                    else
                    {
                        _logger.LogError(new Exception(Bk_response.Message), "UD:BusinessSubscription");
                    }
                }
                else
                {
                    _logger.LogError(new Exception(Bk_response.Message), "UD:BusinessSubscription");
                }
                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:BusinessSubscription");
                throw ex;
            }
        }

        /// <summary>
        ///Get ISD Codel By BusinessKey
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetISDCodeByBusinessKey(int BusinessKey)
        {
            try
            {
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<DO_BusinessStatutoryDetails>("ConfigMasterData/GetISDCodeByBusinessKey?BusinessKey=" + BusinessKey);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetISDCodeByBusinessKey:For BusinessKey {0}", BusinessKey);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetISDCodeByBusinessKey:For BusinessKey {0}", BusinessKey);
                throw ex;
            }
        }

        /// <summary>
        ///Get Business Statutory Detail By BusinessKey and IsdCode
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetStatutoryInformation(int BusinessKey, int isdCode)
        {
            try
            {
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_BusinessStatutoryDetails>>("BusinessStructure/GetStatutoryInformation?BusinessKey=" + BusinessKey + "&isdCode=" + isdCode);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetStatutoryInformation:For BusinessKey {0} and ISDCode {1}", BusinessKey, isdCode);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetStatutoryInformation:For BusinessKey {0} and ISDCode {1}", BusinessKey, isdCode);
                throw ex;
            }
        }

        /// <summary>
        /// Insert Into Business Statutory
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateBusinessStatutory(List<DO_BusinessStatutoryDetails> bu_bd)
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

                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("BusinessStructure/InsertOrUpdateBusinessStatutory", bu_bd);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertOrUpdateBusinessStatutory:params:" + JsonConvert.SerializeObject(bu_bd));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateBusinessStatutory:params:" + JsonConvert.SerializeObject(bu_bd));
                throw ex;
            }
        }

        #endregion Business Statutory Details

    }
}