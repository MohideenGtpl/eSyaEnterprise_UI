using System;
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
    public class CultureController : Controller
    {
        private readonly ILocalizeAPIServices _localizeAPIServices;
        private readonly ILogger<CultureController> _logger;

        public CultureController(ILocalizeAPIServices localizeAPIServices, ILogger<CultureController> logger)
        {
            _localizeAPIServices = localizeAPIServices;
            _logger = logger;
        }
        #region Language Culture
        [Area("Localize")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> ELE_4_00()
        {
            try
            {
                var serviceResponse = await _localizeAPIServices.HttpClientServices.GetAsync<List<DO_LanguageController>>("Localization/GetResources");
                if (serviceResponse.Status)
                {
                    ViewBag.Resources = serviceResponse.Data;
                    return View();
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetResources");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetResources");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }

        }
        /// <summary>
        /// Get Language Culture Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetLanguageCulture(string Culture, string Resource)
        {
            try
            {

                var parameter = "?Resource=" + Resource + "&Culture=" + Culture;
                var serviceResponse = await _localizeAPIServices.HttpClientServices.GetAsync<List<DO_LanguageCulture>>("Localization/GetLanguageCulture" + parameter);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetLanguageCulture:For Culture {0} with Resource entered {1}", Culture, Resource);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetLanguageCulture:For Culture {0} with Resource entered {1}", Culture, Resource);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Insert or Update Resource Culture
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateLanguageCulture(List<DO_LanguageCulture> obj)
        {

            try
            {
                obj.All(c =>
                {
                    c.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                    c.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                    c.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                    return true;
                });

                var serviceResponse = await _localizeAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Localization/InsertOrUpdateLanguageCulture", obj);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateLanguageCulture:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
            }
        }
        #endregion

        #region Culture Keys
        [Area("Localize")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult ELE_5_00()
        {
            return View();
        }
        /// <summary>
        /// Get Language Culturekeys for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetDistinictCultureKeys(string Culture)
        {
            try
            {

                var parameter = "?Culture=" + Culture;
                var serviceResponse = await _localizeAPIServices.HttpClientServices.GetAsync<List<DO_LanguageCulture>>("Localization/GetDistinictCultureKeys" + parameter);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetDistinictCultureKeys:For Culture", Culture);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetDistinictCultureKeys:For BusinessKey", Culture);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Insert or Update Culture Keys
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateCultureKeys(List<DO_LanguageCulture> obj)
        {

            try
            {
                obj.All(c =>
                {
                    c.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                    c.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                    c.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                    return true;
                });

                var serviceResponse = await _localizeAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Localization/InsertOrUpdateCultureKeys", obj);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateCultureKeys:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        #endregion Culture Keys
    }
}