using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using eSyaEnterprise_UI.ActionFilter;
using eSyaEnterprise_UI.Areas.TokenSystem.Data;
using eSyaEnterprise_UI.Areas.TokenSystem.Models;
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

namespace eSyaEnterprise_UI.Areas.TokenSystem.Controllers
{
    public class ConfigureController : Controller
    {
        private readonly ITokenSystemAPIServices _TokenSystemAPIServices;
        private readonly ILogger<ConfigureController> _logger;

        public ConfigureController(ITokenSystemAPIServices TokenSystemAPIServices, ILogger<ConfigureController> logger)
        {
            _TokenSystemAPIServices = TokenSystemAPIServices;
            _logger = logger;
        }
        #region Token Configure
        /// <summary>
        ///  Token Configure
        /// </summary>
        /// <returns></returns>

        [Area("TokenSystem")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult ETM_01_00()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ETM_01_00");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        /// <summary>
        /// Getting All TokenS for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetAllConfigureTokens()
        {
            try
            {
                var serviceResponse = await _TokenSystemAPIServices.HttpClientServices.GetAsync<List<DO_TokenConfiguration>>("Configure/GetAllConfigureTokens");
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetAllConfigureTokens");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Insert or Update Token
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateToken(bool isInsert, DO_TokenConfiguration obj)
        {

            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                if (isInsert)
                {
                    var serviceResponse = await _TokenSystemAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Configure/InsertIntoToken", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
                else
                {
                    var serviceResponse = await _TokenSystemAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Configure/UpdateToken", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateToken:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Activate or De Activate Token
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> ActiveOrDeActiveToken(bool status, string tokentype)
        {

            try
            {
                var parameter = "?status=" + status + "&tokentype="+ tokentype;
                var serviceResponse = await _TokenSystemAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("Configure/ActiveOrDeActiveToken"+ parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ActiveOrDeActiveToken:For tokentype {0} {1} ",status, tokentype);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        #endregion

       
    }
}