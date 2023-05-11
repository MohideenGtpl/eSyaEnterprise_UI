using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using eSyaEnterprise_UI.ActionFilter;
using eSyaEnterprise_UI.Areas.DocumentControl.Data;
using eSyaEnterprise_UI.Areas.DocumentControl.Models;
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

namespace eSyaEnterprise_UI.Areas.DocumentControl.Controllers
{
    [SessionTimeout]
    public class StandardController : Controller
    {
        private readonly IDocumentControlAPIServices _documentControlAPIServices;
        private readonly ILogger<StandardController> _logger;

        public StandardController(IDocumentControlAPIServices documentControlAPIServices, ILogger<StandardController> logger)
        {
            _documentControlAPIServices = documentControlAPIServices;
            _logger = logger;
        }

        #region Normal
        /// <summary>
        /// Document Control-Normal
        /// </summary>
        /// <returns></returns>

        [Area("DocumentControl")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> ESA_04_00()
        {
            try
            {
                var serviveresponse = await _documentControlAPIServices.HttpClientServices.GetAsync<List<DO_DocumentControl>>("DocumentControl/GetActiveDocuments");
                if (serviveresponse.Status)
                {
                    ViewBag.Documents = serviveresponse.Data.
                         Select(b => new SelectListItem
                         {
                             Value = b.DocumentId.ToString(),
                             Text = b.DocumentDesc,
                         }).ToList();
                }
                else
                {
                    _logger.LogError(new Exception(serviveresponse.Message), "UD:GetActiveDocuments");

                }
                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ESA_04_00");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }

        }
        /// <summary>
        /// Getting All Document Control Normal Mode for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetDocumentControlNormalModebyBusinessKey(int businesskey)
        {

            try
            {

                var parameter = "?businesskey=" + businesskey;
                var serviceResponse = await _documentControlAPIServices.HttpClientServices.GetAsync<List<DO_DocumentControlNormalMode>>("DocumentControl/GetDocumentControlNormalModebyBusinessKey" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetDocumentControlNormalModebyBusinessKey:For businesskey {0} ", businesskey);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Insert or Update Control Normal Mode
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateDocumentControlNormalMode(bool isInsert, DO_DocumentControlNormalMode obj)
        {

            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

                if (isInsert)
                {
                    var serviceResponse = await _documentControlAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("DocumentControl/InsertDocumentControlNormalMode", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
                else
                {
                    var serviceResponse = await _documentControlAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("DocumentControl/UpdateDocumentControlNormalMode", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateDocumentControlNormalMode:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Activate or De Activate Control Normal Mode
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> ActiveOrDeActiveDocumentControlNormalMode(DO_DocumentControlNormalMode objgen)
        {

            try
            {

                var serviceResponse = await _documentControlAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("DocumentControl/ActiveOrDeActiveDocumentControlNormalMode", objgen);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ActiveOrDeActiveDocumentControlNormalMode:", objgen);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        #endregion
    }
}