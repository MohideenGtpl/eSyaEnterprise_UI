using System;
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
using Microsoft.AspNetCore.Mvc.Rendering;

namespace eSyaEnterprise_UI.Areas.Configure.Controllers
{
    [SessionTimeout]
    public class ApplicationCodesController : Controller
    {
        private readonly IConfigAPIServices _configAPIServices;
        private readonly ILogger<ApplicationCodesController> _logger;

        public ApplicationCodesController(IConfigAPIServices configAPIServices, ILogger<ApplicationCodesController> logger)
        {
            _configAPIServices = configAPIServices;
            _logger = logger;
        }

        #region Code Type
        /// <summary>
        /// Code Type
        /// </summary>
        /// <returns></returns>

        [Area("Configure")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult ECA_03_00()
        {
           
            return View();
        }
        /// <summary>
        ///Get Code Types for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetCodeTypes()
        {

            try
            {
                var serviceResponse = await _configAPIServices.HttpClientServices.GetAsync<List<DO_CodeTypes>>("CodeTypes/GetCodeTypes");
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetCodeTypes");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetCodeTypes");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }

        }

        /// <summary>
        /// Insert or Update Code Types
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateCodeTypes(bool isInsert, DO_CodeTypes ct_type)
        {

            try
            {
                ct_type.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                ct_type.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                ct_type.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                if (isInsert)
                {
                    var serviceResponse = await _configAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("CodeTypes/InsertIntoCodeType", ct_type);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
                else
                {
                    var serviceResponse = await _configAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("CodeTypes/UpdateCodeType", ct_type);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateCodeTypes:params:" + JsonConvert.SerializeObject(ct_type));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Activate or De Activate Code Types
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> ActiveOrDeActiveCodeTypes(bool status, int code_type)
        {

            try
            {

                var parameter = "?status=" + status + "&code_type=" + code_type;
                var serviceResponse = await _configAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("CodeTypes/ActiveOrDeActiveCodeTypes" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ActiveOrDeActiveCodeTypes:For codeType {0} ", code_type);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        #endregion

        #region Application Codes -System defined
        /// <summary>
        /// Application Codes
        /// </summary>
        /// <returns></returns>

        [Area("Configure")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> ECA_04_00()
        {
            try
            {
                var serviceResponse = await _configAPIServices.HttpClientServices.GetAsync<List<DO_CodeTypes>>("CodeTypes/GetActiveCodeTypes");
                if (serviceResponse.Status)
                {
                    ViewBag.CodeTypeList = serviceResponse.Data.Select(b => new SelectListItem
                    {
                        Value = b.CodeType.ToString(),
                        Text = b.CodeTypeDesc,
                    }).ToList();

                    return View();
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:ActiveCodeTypes");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ActiveCodeTypes");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        ///Get Application Codes by code Type for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetApplicationCodesByCodeType(int codeType)
        {

            try
            {
                var parameter = "?codeType=" + codeType;
                var serviceResponse = await _configAPIServices.HttpClientServices.GetAsync<List<DO_ApplicationCodes>>("ApplicationCodes/GetApplicationCodesByCodeType" + parameter);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetApplicationCodesByCodeType:For codeType {0}", codeType);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetApplicationCodesByCodeType:For codeType {0} ", codeType);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }

        }
        /// <summary>
        /// Insert or Update Application Codes 
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrAudateApplicationCodes(DO_ApplicationCodes app_codes)
        {

            try
            {
                app_codes.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                app_codes.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                app_codes.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

                if (app_codes.ApplicationCode == 0)
                {
                    var serviceResponse = await _configAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("ApplicationCodes/InsertIntoApplicationCodes", app_codes);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

                else
                {
                    var serviceResponse = await _configAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("ApplicationCodes/UpdateApplicationCodes", app_codes);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrAudateApplicationCodes:params:" + JsonConvert.SerializeObject(app_codes));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Activate or De Activate Application Codes
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> ActiveOrDeActiveApplicationCode(bool status, int app_code)
        {

            try
            {

                var parameter = "?status=" + status + "&app_code=" + app_code;
                var serviceResponse = await _configAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("ApplicationCodes/ActiveOrDeActiveCodeTypes" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ActiveOrDeActiveApplicationCode:For codeType {0} ", app_code);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        #endregion

        #region Application codes-User defined
        /// <summary>
        /// Application Codes
        /// </summary>
        /// <returns></returns>

        [Area("Configure")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> ESA_01_00()
        {
            try
            {
                var serviceResponse = await _configAPIServices.HttpClientServices.GetAsync<List<DO_CodeTypes>>("CodeTypes/GetUserDefinedCodeTypesList");
                if (serviceResponse.Status)
                {
                    ViewBag.CodeTypeList = serviceResponse.Data.Select(b => new SelectListItem
                    {
                        Value = b.CodeType.ToString(),
                        Text = b.CodeTypeDesc,
                    }).ToList();

                    return View();
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetUserDefinedCodeTypesList");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetUserDefinedCodeTypesList");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        #endregion
    }
}