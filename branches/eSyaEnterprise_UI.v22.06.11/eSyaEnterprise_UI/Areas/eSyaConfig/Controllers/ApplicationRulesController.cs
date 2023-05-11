﻿using System;
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
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace eSyaEnterprise_UI.Areas.Config.Controllers
{
    [SessionTimeout]
    public class ApplicationRulesController : Controller
    {
        private readonly IeSyaConfigAPIServices _eSyaConfigAPIServices;
        private readonly ILogger<ApplicationRulesController> _logger;
        public ApplicationRulesController(IeSyaConfigAPIServices eSyaConfigAPIServices, ILogger<ApplicationRulesController> logger)
        {
            _eSyaConfigAPIServices = eSyaConfigAPIServices;
            _logger = logger;
        }
        [Area("eSyaConfig")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult V_17_00()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }

        }

        public async Task<JsonResult> GetProcessMaster()
        {
            try
            {
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_ProcessMaster>>("ProcessMaster/GetProcessMaster");
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetProcessMaster");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetProcessMaster");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        public async Task<JsonResult> GetProcessRule()
        {
            try
            {
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_ProcessRule>>("ProcessMaster/GetProcessRule");
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetProcessRule");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetProcessRule");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Insert Process Rule
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertProcessMaster(DO_ProcessMaster obj)
        {

            try
            {
                obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                var serviceResponse =await _eSyaConfigAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("ProcessMaster/InsertIntoProcessMaster", obj);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertProcessMaster:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }


        /// <summary>
        /// Update Process Rule
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> UpdateProcessMaster(DO_ProcessMaster obj)
        {

            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

                var serviceResponse =await _eSyaConfigAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("ProcessMaster/UpdateProcessMaster", obj);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:UpdateProcessMaster:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Insert Process Rule
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertApplicationRule(DO_ProcessRule obj)
        {

            try
            {
                obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

                var serviceResponse =await _eSyaConfigAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("ProcessMaster/InsertIntoProcessRule", obj);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertApplicationRule:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }


        /// <summary>
        /// Update Process Rule
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> UpdateApplicationRule(DO_ProcessRule obj)
        {

            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

                var serviceResponse =await _eSyaConfigAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("ProcessMaster/UpdateProcessRule", obj);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:UpdateApplicationRule:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }


        //#region Application Rules
        ///// <summary>
        ///// Process Rule
        ///// </summary>
        ///// 
        //[Area("eSyaConfig")]
        //public IActionResult V_20_01()
        //{
        //    ViewBag.formName = "Application Rules";
        //    try
        //    {
        //        var serviceResponse = _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_ProcessMaster>>("ProcessMaster/GetActiveProcessMaster").Result;
        //        ViewBag.ProcessControl = serviceResponse.Data;
        //        return View();
        //    }
        //    catch (Exception ex)
        //    {
        //        return Json(new { Status = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
        //    }

        //}
        ///// <summary>
        /////Get Application Rules by ProcessId
        ///// </summary>
        //[HttpPost]
        //public JsonResult GetApplicationRulesByProcessId(int ProcessId)
        //{

        //    try
        //    {
        //        var serviceResponse = _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_ProcessRule>>("ProcessMaster/GetProcessRuleByProcessId?ProcessId=" + ProcessId).Result;
        //        return Json(serviceResponse.Data);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
        //    }

        //}



        //#endregion

        //#region Process Rules
        ///// <summary>
        ///// Process Rule
        ///// </summary>
        ///// <returns></returns>
        //[Area("eSyaConfig")]
        //public IActionResult V_21_00()
        //{
        //    ViewBag.formName = "Process Rules";
        //    return View();
        //}

        ///// <summary>
        ///// Getting Process Rule List for Grid
        ///// </summary>

        //[HttpPost]
        //public JsonResult GetProcessRules()
        //{
        //    try
        //    {
        //        var serviceResponse = _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_ProcessMaster>>("ProcessMaster/GetProcessMaster").Result;
        //        return Json(serviceResponse.Data);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
        //    }
        //}



        //#endregion



        #region eSya Parameters
        /// <summary>
        /// Parameters
        /// </summary>
        /// 
        [ServiceFilter(typeof(ViewBagActionFilter))]
        [Area("eSyaConfig")]
        public IActionResult V_20_00()
        {
            ViewBag.formName = "Parameters";
            return View();
        }

        /// <summary>
        ///Get Parameters Information By Parameter Type
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetParametersInformationByParameterType(string parameterType)
        {
            try
            {
                var serviceResponse =await _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_Parameters>>("Parameters/GetParametersInformationByParameterType?parameterType=" + parameterType);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetParametersInformationByParameterType:For parameterType {0}", parameterType);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetParametersInformationByParameterType:For parameterType {0} ", parameterType);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Insert Into / Update Parameter
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateParameters(DO_Parameters pa_rm)
        {
            try
            {
                pa_rm.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                pa_rm.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                pa_rm.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext).ToString();
                if (pa_rm.ParameterId == 0)
                {
                    var serviceResponse =await _eSyaConfigAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Parameters/InsertIntoParameters", pa_rm);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
                else
                {
                    var serviceResponse =await _eSyaConfigAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Parameters/UpdateParameters", pa_rm);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateParameters:params:" + JsonConvert.SerializeObject(pa_rm));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        ///Get Parameter Header Information
        /// </summary>
        [HttpGet]
        public async Task<JsonResult> GetParametersHeaderInformation()
        {
            try
            {
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_Parameters>>("Parameters/GetParametersHeaderInformation");
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetParametersHeaderInformation");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetParametersHeaderInformation");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Insert Into Parameter Header
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertIntoParameterHeader(DO_Parameters pa_rh)
        {
            try
            {
                pa_rh.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                pa_rh.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                pa_rh.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext).ToString();

                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Parameters/InsertIntoParameterHeader", pa_rh);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertIntoParameterHeader:params:" + JsonConvert.SerializeObject(pa_rh));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Update Parameter Header
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> UpdateParameterHeader(DO_Parameters pa_rh)
        {
            try
            {
                pa_rh.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                pa_rh.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                pa_rh.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext).ToString();

                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Parameters/UpdateParameterHeader", pa_rh);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:UpdateParameterHeader:params:" + JsonConvert.SerializeObject(pa_rh));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }


        /// <summary>
        ///Active Or De Active Parameter Header
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> ActiveOrDeActiveParameterHeader(bool status, int parm_type)
        {

            try
            {

                var parameter = "?status=" + status + "&parm_type=" + parm_type;
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("Parameters/ActiveOrDeActiveParameterHeader" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ActiveOrDeActiveParameterHeader:For parm_type {0} ", parm_type);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        #endregion

        #region Application Rule-Segment Based
        [Area("eSyaConfig")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> V_21_00()
        {
            try
            {

                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_BusinessLocation>>("ConfigMasterData/GetBusinessKey");
                if (serviceResponse.Status)
                {
                    ViewBag.Businesskey = serviceResponse.Data.Select(b => new SelectListItem
                    {
                        Value = b.BusinessKey.ToString(),
                        Text = b.LocationDescription,
                    }).ToList();

                    return View();
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetBusinessKey");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetBusinessKey");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        [HttpPost]
        public async Task<JsonResult> GetProcessRulebySegmentwise()
        {
            try
            {
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_ProcessRule>>("ProcessMaster/GetProcessRulebySegmentwise");
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetProcessRule by Segment");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetProcessRule");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        [HttpPost]
        public async Task<JsonResult> GetProcessRulebyBusinessKey(int BusinessKey)
        {
            try
            {
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_ProcessRule>>("ProcessMaster/GetProcessRulebyBusinessKey?BusinessKey=" + BusinessKey);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetProcessRulebyBusinessKey by Segment");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetProcessRulebyBusinessKey");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        /// <summary>
        /// Update Application Rule by segment
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertorUpdateProcessRulebySegment(DO_ProcessRulebySegment obj)
        {

            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormID= AppSessionVariables.GetSessionFormInternalID(HttpContext).ToString();
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("ProcessMaster/InsertorUpdateProcessRulebySegment", obj);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:UpdateApplicationRule:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        #endregion

    }
}