﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using eSyaEnterprise_UI.ActionFilter;
using eSyaEnterprise_UI.Areas.Localize.Data;
using eSyaEnterprise_UI.Areas.Localize.Models;
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
namespace eSyaEnterprise_UI.Areas.Localize.Controllers
{
    [SessionTimeout]
    public class MasterController : Controller
    {
        private readonly ILocalizeAPIServices _localizeAPIServices;
        private readonly ILogger<MasterController> _logger;

        public MasterController(ILocalizeAPIServices localizeAPIServices, ILogger<MasterController> logger)
        {
            _localizeAPIServices = localizeAPIServices;
            _logger = logger;
        }

        #region Localization Table Mapping
        /// <summary>
        /// Localization Master
        /// </summary>
        /// <returns></returns>
        /// 
        [Area("Localize")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult ELE_1_00()
        {
            return View();
        }

        /// <summary>
        /// Getting Localization Master Table List for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetLocalizationTableMaster()
        {
            try
            {
                var serviceResponse = await _localizeAPIServices.HttpClientServices.GetAsync<List<DO_LocalizationMaster>>("Localization/GetLocalizationTableMaster");
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetLocalizationTableMaster");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetLocalizationTableMaster");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Insert or Update Localization Master
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateLocalizationTableMaster(DO_LocalizationMaster obj)
        {

            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);

                var serviceResponse = await _localizeAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Localization/InsertOrUpdateLocalizationTableMaster", obj);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateLocalizationTableMaster:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
            }
        }
        /// <summary>
        /// Activate or De Activate Localization Table Master
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> ActiveOrDeActiveLocalizationTableMaster(bool status, int Tablecode)
        {

            try
            {

                var parameter = "?status=" + status + "&Tablecode=" + Tablecode;
                var serviceResponse = await _localizeAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("Localization/ActiveOrDeActiveLocalizationTableMaster" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ActiveOrDeActiveLocalizationTableMaster:For Tablecode {0} ", Tablecode);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        #endregion

        #region Language Mapping
        /// <summary>
        /// Localization Language Mapping
        /// </summary>
        /// 
        [Area("Localize")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> ELE_2_00()
        {

            try
            {
                var servicetableResponse = await _localizeAPIServices.HttpClientServices.GetAsync<List<DO_LocalizationMaster>>("Localization/GetLocalizationMaster");

                if (servicetableResponse.Status)
                {

                    ViewBag.TableList = servicetableResponse.Data;
                    return View();

                }
                else
                {

                    _logger.LogError(new Exception(servicetableResponse.Message), "UD:GetLocalizationMaster");
                    return Json(new { Status = false, StatusCode = "500" });
                }



            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetLocalizationMaster");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Insert or Update Localization Language Mapping
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateLocalizationLanguageMapping(List<DO_LocalizationLanguageMapping> l_obj)
        {

            try
            {
                l_obj.All(c =>
                {
                    c.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                    c.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                    c.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                    return true;
                });
                var serviceResponse = await _localizeAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Localization/InsertOrUpdateLocalizationLanguageMapping", l_obj);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateLocalizationLanguageMapping:params:" + JsonConvert.SerializeObject(l_obj));
                return Json(new { Status = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
            }
        }

        /// <summary>
        /// Get Localization Language Mapping Grid
        /// </summary>
        [HttpGet]
        public async Task<JsonResult> GetLocalizationLanguageMapping(string languageCode, int tableCode)
        {
            try
            {
                if (tableCode > 0)
                {
                    var parameter = "?languageCode=" + languageCode + "&tableCode=" + tableCode.ToString();
                    var serviceResponse = await _localizeAPIServices.HttpClientServices.GetAsync<List<DO_LocalizationLanguageMapping>>("Localization/GetLocalizationLanguageMapping" + parameter);
                    return Json(serviceResponse.Data);
                }
                else
                    return Json(null);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetLocalizationLanguageMapping:For languageCode {0} with tableCode entered {1}", languageCode, tableCode);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        #endregion Language Mapping
    }
}