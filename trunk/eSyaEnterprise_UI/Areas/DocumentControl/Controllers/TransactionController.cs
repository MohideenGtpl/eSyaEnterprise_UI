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
    public class TransactionController : Controller
    {
        private readonly IDocumentControlAPIServices _documentControlAPIServices;
        private readonly ILogger<TransactionController> _logger;

        public TransactionController(IDocumentControlAPIServices documentControlAPIServices, ILogger<TransactionController> logger)
        {
            _documentControlAPIServices = documentControlAPIServices;
            _logger = logger;
        }
        #region Transaction
        /// <summary>
        /// Document Control-Transaction
        /// </summary>
        /// <returns></returns>

        [Area("DocumentControl")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> ESA_05_00()
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
        /// Getting All Document Generations for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetDocumentControlTransactionModebyBusinessKey(int businesskey)
        {

            try
            {

                var parameter = "?businesskey=" + businesskey;
                var serviceResponse = await _documentControlAPIServices.HttpClientServices.GetAsync<List<DO_DocumentControlTransaction>>("DocumentControl/GetDocumentControlTransactionModebyBusinessKey" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetDocumentControlTransactionModebyBusinessKey:For businesskey {0} ", businesskey);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Insert or Update Document Generations
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateDocumentControlTransactionMode(bool isInsert, DO_DocumentControlTransaction obj)
        {

            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

                if (isInsert)
                {
                    var serviceResponse = await _documentControlAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("DocumentControl/InsertDocumentControlTransactionMode", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
                else
                {
                    var serviceResponse = await _documentControlAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("DocumentControl/UpdateDocumentControlTransactionMode", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateDocumentControlTransactionMode:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Activate or De Activate Room Type
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> ActiveOrDeActiveDocumentControlTransactionMode(DO_DocumentControlTransaction objgen)
        {

            try
            {

                var serviceResponse = await _documentControlAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("DocumentControl/ActiveOrDeActiveDocumentControlTransactionMode", objgen);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ActiveOrDeActiveDocumentControlTransactionMode:", objgen);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        #endregion
    }
}