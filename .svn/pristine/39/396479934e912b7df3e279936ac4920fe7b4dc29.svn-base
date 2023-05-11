using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eSyaEnterprise_UI.ActionFilter;
using eSyaEnterprise_UI.Areas.eSyaCustomer.Data;
using eSyaEnterprise_UI.Areas.eSyaCustomer.Models;
using eSyaEnterprise_UI.Models;
using eSyaEnterprise_UI.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace eSyaEnterprise_UI.Areas.eSyaCustomer.Controllers
{
    [SessionTimeout]
    public class CustomerAttributesController : Controller
    {
        private readonly IeSyaCustomerAPIServices _eSyaCustomerAPIServices;
        private readonly ILogger<CustomerController> _logger;
        public CustomerAttributesController(IeSyaCustomerAPIServices eSyaCustomerAPIServices, ILogger<CustomerController> logger)
        {
            _eSyaCustomerAPIServices = eSyaCustomerAPIServices;
            _logger = logger;
        }

        #region Patient Types

        [Area("eSyaCustomer")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> V_273_00()
        {
            try
            {
                var PatientCatresp = await _eSyaCustomerAPIServices.HttpClientServices.GetAsync<List<DO_ApplicationCodes>>("CommonData/GetApplicationCodesByCodeType?codeType=" + CodeTypeValues.PatientCategory);
                var RateTyperesp = await _eSyaCustomerAPIServices.HttpClientServices.GetAsync<List<DO_ApplicationCodes>>("CommonData/GetApplicationCodesByCodeType?codeType=" + CodeTypeValues.RateType);

                if (PatientCatresp.Status)
                {
                    ViewBag.PatientCategory = PatientCatresp.Data.
                         Select(b => new SelectListItem
                         {
                             Value = b.ApplicationCode.ToString(),
                             Text = b.CodeDesc,
                         }).ToList();
                }
                else
                {
                    _logger.LogError(new Exception(PatientCatresp.Message), "UD:GetApplicationCodesByCodeType:For PatientCategory {0}", CodeTypeValues.PatientCategory);

                }
                if (RateTyperesp.Status)
                {

                    ViewBag.RateType = RateTyperesp.Data.
                    Select(b => new SelectListItem
                    {
                        Value = b.ApplicationCode.ToString(),
                        Text = b.CodeDesc,
                    }).ToList();
                }
                 else
                {
                    _logger.LogError(new Exception(PatientCatresp.Message), "UD:GetApplicationCodesByCodeType:For RateType {0}", CodeTypeValues.RateType);
                }
                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetApplicationCodesByCodeType:For RateType {0}", CodeTypeValues.RateType);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        ///Get Patient Types for Tree View
        /// </summary>
        [Produces("application/json")]
        [HttpGet]
        public async Task<JsonResult> GetAllPatientTypesforTreeView()
        {
            try
            {
                List<jsTreeObject> jsTree = new List<jsTreeObject>();

                jsTreeObject jsObj = new jsTreeObject
                {
                    id = "MM",
                    parent = "#",
                    text = "Patient Types",
                    state = new stateObject { opened = true, selected = false }
                };
                jsTree.Add(jsObj);
                var parameter = "?CodeType=" + 71;
                var serviceResponse = await _eSyaCustomerAPIServices.HttpClientServices.GetAsync<DO_CustomerAttributes>("CustomerAttributes/GetAllPatientTypesforTreeView" + parameter);
                if (serviceResponse.Status)
                {
                    var PatientTypes = serviceResponse.Data;
                    if (PatientTypes != null)
                    {
                        foreach (var f in PatientTypes.l_PatientType.OrderBy(o => o.PatientTypeId))
                        {
                            jsObj = new jsTreeObject
                            {
                                id = "MM" + f.PatientTypeId.ToString(),
                                text = f.Description,
                                GroupIndex = f.PatientTypeId.ToString(),
                                parent = "MM",
                                state = new stateObject { opened = true, selected = false }
                            };
                            jsTree.Add(jsObj);
                        }

                        foreach (var f in PatientTypes.l_PatienTypeCategory.OrderBy(o => o.PatientTypeId))
                        {
                            jsObj = new jsTreeObject
                            {
                                id = "SM" + f.PatientTypeId.ToString() + "_" + f.PatientCategoryId.ToString(),
                                text = f.Description,
                                GroupIndex = f.PatientTypeId.ToString(),
                                parent = "MM" + f.PatientTypeId.ToString(),
                                state = new stateObject { opened = true, selected = false }
                            };
                            jsTree.Add(jsObj);
                        }
                    }
                    return Json(jsTree);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetAllPatientTypesforTreeView");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetAllPatientTypesforTreeView");
                throw ex;
            }
        }

        /// <summary>
        ///Get Patient Category Info
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetPatientCategoryInfo(int PatientTypeId, int PatientCategoryId)
        {
            try
            {
                var parameter = "?PatientTypeId=" + PatientTypeId + "&PatientCategoryId=" + PatientCategoryId;
                var serviceResponse = await _eSyaCustomerAPIServices.HttpClientServices.GetAsync<DO_PatientTypeCategory>("CustomerAttributes/GetPatientCategoryInfo" + parameter);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetPatientCategoryInfo:For PatientTypeId {0} with PatientCategoryId entered {1}", PatientTypeId, PatientCategoryId);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetPatientCategoryInfo:For PatientTypeId {0} with PatientCategoryId entered {1}", PatientTypeId, PatientCategoryId);
                throw ex;
            }
        }

        /// <summary>
        ///Get Patient Specialty  by PatientTypeId and  PatientCategoryId for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetSpecialtyByPatientTypeAndCategory(int PatientTypeId, int PatientCategoryId)
        {
            try
            {
                var serviceResponse = await _eSyaCustomerAPIServices.HttpClientServices.GetAsync<List<DO_SpecialtyMaster>>("CustomerAttributes/GetSpecialtyMaster");
                List<DO_SpecialtyMaster> specialtyMaster = serviceResponse.Data;
                var parameter = "?PatientTypeId=" + PatientTypeId + "&PatientCategoryId=" + PatientCategoryId;
                var serviceResp = await _eSyaCustomerAPIServices.HttpClientServices.GetAsync<List<DO_PatientTypeSpecialty>>("CustomerAttributes/GetSpecialtyByPatientTypeAndCategory" + parameter);
                List<DO_PatientTypeSpecialty> specialtydata = serviceResp.Data;

                if (serviceResponse.Status && serviceResp.Status)
                {
                    foreach (var obj in specialtyMaster)
                    {
                        if (PatientCategoryId != 0)
                        {
                            if (specialtydata.Count > 0)
                            {
                                var isSpecialty = specialtydata
                                      .Where(c => c.PatientTypeId == PatientTypeId && c.PatientCategoryId==PatientCategoryId && c.SpecialtyId == obj.SpecialtyId).FirstOrDefault();

                                if (isSpecialty != null)
                                {
                                    obj.ActiveStatus = true;
                                }
                                else
                                {
                                    obj.ActiveStatus = false;
                                }

                            }
                        }
                    }
                    return Json(specialtyMaster);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetSpecialtyByPatientTypeAndCategory:For PatientTypeId {0} with PatientCategoryId entered {1}", PatientTypeId, PatientCategoryId);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }

            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetSpecialtyByPatientTypeAndCategory:For PatientTypeId {0} with PatientCategoryId entered {1}", PatientTypeId, PatientCategoryId);
                throw ex;
            }

        }

        /// <summary>
        ///Get Patient Rate Type  by PatientTypeId and  PatientCategoryId for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetPatientRateTypeByPatientTypeAndCategory(int PatientTypeId, int PatientCategoryId)
        {
            try
            {
                var parameter = "?PatientTypeId=" + PatientTypeId + "&PatientCategoryId=" + PatientCategoryId;
                var serviceResponse = await _eSyaCustomerAPIServices.HttpClientServices.GetAsync<List<DO_PatientRateType>>("CustomerAttributes/GetPatientRateTypeByPatientTypeAndCategory" + parameter);

                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetPatientRateTypeByPatientTypeAndCategory:For PatientTypeId {0} with PatientCategoryId entered {1}", PatientTypeId, PatientCategoryId);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }

            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetPatientRateTypeByPatientTypeAndCategory:For PatientTypeId {0} with PatientCategoryId entered {1}", PatientTypeId, PatientCategoryId);
                throw ex;
            }

        }

        /// <summary>
        ///Get Patient Category Document Type  by PatientType Id and  PatientCategory Id for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetPatientCategoryDocumentTypeByPatientTypeAndCategory(int PatientTypeId, int PatientCategoryId)
        {
            try
            {
                var parameter = "?PatientTypeId=" + PatientTypeId + "&PatientCategoryId=" + PatientCategoryId;
                var serviceResponse = await _eSyaCustomerAPIServices.HttpClientServices.GetAsync<List<DO_PatientCategoryDocumentType>>("CustomerAttributes/GetPatientCategoryDocumentTypeByPatientTypeAndCategory" + parameter);

                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetPatientCategoryDocumentTypeByPatientTypeAndCategory:For PatientTypeId {0} with PatientCategoryId entered {1}", PatientTypeId, PatientCategoryId);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }

            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetPatientCategoryDocumentTypeByPatientTypeAndCategory:For PatientTypeId {0} with PatientCategoryId entered {1}", PatientTypeId, PatientCategoryId);
                throw ex;
            }

        }

        /// <summary>
        /// Insert or Update Patient Category
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdatePatientCategory(DO_PatientTypeCategory obj)
        {
            try
            {
                if (string.IsNullOrEmpty(obj.PatientCategoryId.ToString()) || obj.PatientCategoryId == 0)
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select Patient Category" });
                }
                else if (string.IsNullOrEmpty(obj.ServiceWiseRateType))
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select Service Wise Rate Type" });
                }
               
                else
                {
                    obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                    obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                    obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                    if (obj.IsInsert)
                    {
                        var serviceResponse = await _eSyaCustomerAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("CustomerAttributes/InsertPatientCategory", obj);
                        if (serviceResponse.Status)
                            return Json(serviceResponse.Data);
                        else
                        {
                            _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertPatientCategory:params:" + JsonConvert.SerializeObject(obj));
                            return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                        }
                    }
                    else
                    {
                        var serviceResponse = await _eSyaCustomerAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("CustomerAttributes/UpdatePatientCategory", obj);
                        if (serviceResponse.Status)
                            return Json(serviceResponse.Data);
                        else
                        {
                            _logger.LogError(new Exception(serviceResponse.Message), "UD:UpdatePatientCategory:params:" + JsonConvert.SerializeObject(obj));
                            return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                        }
                    }
                    
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdatePatientCategory:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }

        #endregion Patient Types

        #region Patient Category Discount Service
        [Area("eSyaCustomer")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult V_274_00()
        {
            try
            {
                var serviceResponsePc = _eSyaCustomerAPIServices.HttpClientServices.GetAsync<List<DO_ApplicationCodes>>("CommonData/GetApplicationCodesByCodeType?codeType=" + CodeTypeValues.PatientCategory).Result;
                if (serviceResponsePc.Data != null)
                {
                    ViewBag.PatientCategory = serviceResponsePc.Data.Select(a => new SelectListItem
                    {
                        Text = a.CodeDesc,
                        Value = a.ApplicationCode.ToString()
                    });
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponsePc.Message), "UD:GetApplicationCodesByCodeType");
                }

                var serviceResponseSg = _eSyaCustomerAPIServices.HttpClientServices.GetAsync<List<DO_ServiceGroup>>("CommonData/GetServiceGroup").Result;
                if (serviceResponseSg.Data != null)
                {
                    ViewBag.ServiceGroup = serviceResponseSg.Data.Select(a => new SelectListItem
                    {
                        Text = a.ServiceGroupDesc,
                        Value = a.ServiceGroupId.ToString()
                    });
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponseSg.Message), "UD:GetServiceGroup");
                }
                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:V_274_00");
                throw ex;
            }
        }

        /// <summary>
        ///Get Patient Category Discount Service Class Wise By Business Key , Patient Category , Service For and Service Group
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetPatientCatDiscClassByBkPtCatSfSg(int businessKey, int patientCategory, string serviceFor, int serviceGroupId)
        {
            try
            {
                var serviceResponse = await _eSyaCustomerAPIServices.HttpClientServices.GetAsync<List<DO_PatientCategoryDiscount>>("PatientCategoryDiscount/GetPatientCatDiscClassByBkPtCatSfSg?businessKey=" +
                    businessKey + "&patientCategory=" + patientCategory + "&serviceFor=" + serviceFor + "&serviceGroupId=" + serviceGroupId);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetPatientCatDiscClassByBkPtCatSfSg:For BusinessKey {0} , PatientCategory {1},ServiceFor {2},ServiceGroupId {3}", businessKey, patientCategory, serviceFor, serviceGroupId);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetPatientCatDiscClassByBkPtCatSfSg:For BusinessKey {0} , PatientCategory {1},ServiceFor {2},ServiceGroupId {3}", businessKey, patientCategory, serviceFor, serviceGroupId);
                throw ex;
            }
        }

        /// <summary>
        /// Insert Into Patient Category Discount Service Class
        /// </summary>

        public async Task<ActionResult> InsertOrUpdatePatientCatDiscClass(List<DO_PatientCategoryDiscount> pc_dc)
        {
            try
            {
                pc_dc.All(c =>
                {
                    c.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                    c.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                    //c.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                    return true;
                });

                var serviceResponse = await _eSyaCustomerAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("PatientCategoryDiscount/InsertOrUpdatePatientCatDiscClass", pc_dc);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Data.Message), "UD:InsertOrUpdatePatientCatDiscClass:params:" + JsonConvert.SerializeObject(pc_dc));
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Data.Message });
                    }

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertOrUpdatePatientCatDiscClass:params:" + JsonConvert.SerializeObject(pc_dc));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdatePatientCatDiscClass:params:" + JsonConvert.SerializeObject(pc_dc));
                return Json(new DO_ReturnParameter() { Status = false, Message = ex.ToString() });
            }
        }

        /// <summary>
        ///Get Service Class
        /// </summary>
        public async Task<JsonResult> GetServiceClassBySrGroupId(int serviceGroupId)
        {
            try
            {
                var serviceResponse = await _eSyaCustomerAPIServices.HttpClientServices.GetAsync<List<DO_ServiceClass>>("CommonData/GetServiceClassBySrGroupId?serviceGroupId=" + serviceGroupId);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetServiceClassBySrGroupId:For ServiceGroup {0}", serviceGroupId);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetServiceClassBySrGroupId:For ServiceGroup {0}", serviceGroupId);
                throw ex;
            }
        }

        /// <summary>
        ///Get Patient Category Discount Service Code Wise By Business Key , Patient Category , Service For and Service Group
        /// </summary>
        public async Task<JsonResult> GetPatientCatDiscServiceByBkPtCatSfSc(int businessKey, int patientCategory, string serviceFor, int serviceGroupId)
        {
            try
            {
                var serviceResponse = await _eSyaCustomerAPIServices.HttpClientServices.GetAsync<List<DO_PatientCategoryDiscount>>("PatientCategoryDiscount/GetPatientCatDiscServiceByBkPtCatSfSg?businessKey=" +
                    businessKey + "&patientCategory=" + patientCategory + "&serviceFor=" + serviceFor + "&serviceGroupId=" + serviceGroupId);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetPatientCatDiscServiceByBkPtCatSfSg:For BusinessKey {0} , PatientCategory {1},ServiceFor {2},ServiceGroupId {3}", businessKey, patientCategory, serviceFor, serviceGroupId);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetPatientCatDiscServiceByBkPtCatSfSg:For BusinessKey {0} , PatientCategory {1},ServiceFor {2},ServiceGroupId {3}", businessKey, patientCategory, serviceFor, serviceGroupId);
                throw ex;
            }
        }

        /// <summary>
        /// Insert Into Patient Category Discount Service Code
        /// </summary>

        public async Task<ActionResult> InsertOrUpdatePatientCatDiscService(List<DO_PatientCategoryDiscount> pc_ds)
        {
            try
            {
                pc_ds.All(c =>
                {
                    c.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                    c.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                    //c.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                    return true;
                });

                var serviceResponse = await _eSyaCustomerAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("PatientCategoryDiscount/InsertOrUpdatePatientCatDiscService", pc_ds);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Data.Message), "UD:InsertOrUpdatePatientCatDiscService:params:" + JsonConvert.SerializeObject(pc_ds));
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Data.Message });
                    }

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertOrUpdatePatientCatDiscService:params:" + JsonConvert.SerializeObject(pc_ds));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdatePatientCatDiscService:params:" + JsonConvert.SerializeObject(pc_ds));
                return Json(new DO_ReturnParameter() { Status = false, Message = ex.ToString() });
            }
        }
        #endregion Patient Category Discount Service
    }
}