﻿using System;
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
    public class ControlController : Controller
    {
        private readonly IConfigAPIServices _configAPIServices;
        private readonly ILogger<ControlController> _logger;

        public ControlController(IConfigAPIServices configAPIServices, ILogger<ControlController> logger)
        {
            _configAPIServices = configAPIServices;
            _logger = logger;
        }

        #region Calendar Definition
        [Area("Configure")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult ECA_08_00()
        {
            return View();

        }
        /// <summary>
        /// Getting Calendar Headers by Business key for Grid
        /// UI-Param--Business Key
        /// </summary>

        [HttpPost]
        public async Task<JsonResult> GetCalendarHeadersbyBusinessKey(int Businesskey)
        {
            try
            {
                var parameter = "?Businesskey=" + Businesskey;
                var serviceResponse = await _configAPIServices.HttpClientServices.GetAsync<List<DO_CalendarDefinition>>("Control/GetCalendarHeadersbyBusinessKey" + parameter);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetCalendarHeadersbyBusinessKey:For Businesskey {0}", Businesskey);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetFinancialYearbyBusinessKey:For Businesskey {0}", Businesskey);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Getting Calendar Header for Grid
        /// </summary>

        [HttpPost]
        public async Task<JsonResult> GetCalendarHeaders()
        {
            try
            {
                var serviceResponse = await _configAPIServices.HttpClientServices.GetAsync<List<DO_CalendarDefinition>>("Control/GetCalendarHeaders");
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetCalendarHeaders");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetCalendarHeaders");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Insert Calendar Header & Details
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertCalendarHeaderAndDetails([FromBody] DO_CalendarDefinition calendarheadar)
        {

            try
            {
                calendarheadar.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                calendarheadar.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                calendarheadar.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                var serviceResponse = await _configAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Control/InsertCalendarHeaderAndDetails", calendarheadar);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertCalendarHeaderAndDetails:params:" + JsonConvert.SerializeObject(calendarheadar));
                return Json(new { Status = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
            }
        }

        #endregion Calendar Definition

        #region Document Control

        [Area("Configure")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult ECA_09_00()
        {
            try
            {
                return View();

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ECA_09_00");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }


        }


        /// <summary>
        /// Getting Document Controls for Grid
        /// </summary>

        [HttpPost]
        public async Task<JsonResult> GetDocumentControlMaster()
        {
            try
            {
                var serviceResponse = await _configAPIServices.HttpClientServices.GetAsync<List<DO_DocumentControlMaster>>("Control/GetDocumentControlMaster");
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetDocumentControlMaster");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetDocumentControlMaster");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Insert or Update Document Control
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateDocumentControl(DO_DocumentControlMaster obj)
        {

            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                if (obj.Isadd == 1)
                {
                    var serviceResponse = await _configAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Control/InsertDocumentControlMaster", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

                else
                {
                    var serviceResponse = await _configAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Control/UpdateDocumentControlMaster", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateDocumentControl:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Activate or De Activate Document Control
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> ActiveOrDeActiveDocumentControl(bool status, int documentId)
        {

            try
            {

                var parameter = "?status=" + status + "&documentId=" + documentId;
                var serviceResponse = await _configAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("Control/ActiveOrDeActiveDocumentControlMaster" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ActiveOrDeActiveDocumentControl:For documentId {0} ", documentId);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        #endregion Document Control

        #region FORM LINK TO DOCUMENT
        [Area("Configure")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> ECA_10_00()
        {
            try
            {
                var forms_res = await _configAPIServices.HttpClientServices.GetAsync<List<DO_FormNames>>("Control/GetDocumentRequiredForms");
                var docs_res = await _configAPIServices.HttpClientServices.GetAsync<List<DO_DocumentControlMaster>>("Control/GetActiveDocuments");
                if (forms_res.Status)
                {
                    ViewBag.Forms = forms_res.Data.
                         Select(b => new SelectListItem
                         {
                             Value = b.FormID.ToString(),
                             Text = b.FormName,
                         }).ToList();
                }
                else
                {
                    _logger.LogError(new Exception(forms_res.Message), "UD:GetDocumentRequiredForms");

                }
                if (docs_res.Status)
                {
                    ViewBag.Documents = docs_res.Data.
                         Select(b => new SelectListItem
                         {
                             Value = b.DocumentId.ToString(),
                             Text = b.DocumentDesc,
                         }).ToList();
                }
                else
                {
                    _logger.LogError(new Exception(docs_res.Message), "UD:GetActiveDocuments");

                }
                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:V_20_00");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        ///Get Linked forms with documents for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetFormLinkedDocuments()
        {

            try
            {
                var serviceResponse = await _configAPIServices.HttpClientServices.GetAsync<List<DO_FormDocumentLink>>("Control/GetFormLinkedDocuments");
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetFormLinkedDocuments");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetFormLinkedDocuments");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }

        }

        /// <summary>
        /// Insert Form Link with documents
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertIntoFormDocumentLink(bool isInsert, DO_FormDocumentLink obj)
        {

            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

                var serviceResponse = await _configAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Control/InsertIntoFormDocumentLink", obj);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });


            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertIntoFormDocumentLink:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Activate or De Activate Room Type
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> DeleteFormLinkedDocument(int formId, int documentId)
        {

            try
            {

                var parameter = "?formId=" + formId + "&documentId=" + documentId;
                var serviceResponse = await _configAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("Control/DeleteFormLinkedDocument" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:DeleteFormLinkedDocument:For documentId {0} ", documentId);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        #endregion FORM LINK TO DOCUMENT

        #region Document Generation 

        [Area("Configure")]
        //[ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> ESA_04_00()
        {
            try
            {
                ViewBag.UserFormRole = new DO_UserFormRole { IsInsert = true, IsEdit = true, IsView = true, IsDelete = true };
                int businesskey = AppSessionVariables.GetSessionBusinessKey(HttpContext);
                var store_res = await _configAPIServices.HttpClientServices.GetAsync<List<DO_StoreMaster>>("Control/GetStoresByBusinessKey?businesskey=" + businesskey);
                var docs_res = await _configAPIServices.HttpClientServices.GetAsync<List<DO_DocumentControlMaster>>("Control/GetActiveDocuments");
                if (store_res.Status)
                {
                    ViewBag.Storecodes = store_res.Data.
                         Select(b => new SelectListItem
                         {
                             Value = b.StoreCode.ToString(),
                             Text = b.StoreDesc,
                         }).ToList();
                }
                else
                {
                    _logger.LogError(new Exception(store_res.Message), "UD:GetStoresByBusinessKey");

                }
                if (docs_res.Status)
                {
                    ViewBag.Documents = docs_res.Data.
                         Select(b => new SelectListItem
                         {
                             Value = b.DocumentId.ToString(),
                             Text = b.DocumentDesc,
                         }).ToList();
                }
                else
                {
                    _logger.LogError(new Exception(docs_res.Message), "UD:GetActiveDocuments");

                }
                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:V_21_00");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }


        /// <summary>
        /// Getting All Document Generations for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetDocumentGenerationsbyBusinessKey(int businesskey, string Transactionmode)
        {

            try
            {

                var parameter = "?businesskey=" + businesskey + "&Transactionmode=" + Transactionmode;
                var serviceResponse = await _configAPIServices.HttpClientServices.GetAsync<List<DO_DocumentGeneration>>("Control/GetDocumentGenerationsbyBusinessKey" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetDocumentGenerationsbyBusinessKey:For businesskey {0} ", businesskey);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Insert or Update Document Generations
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateDocumentGeneration(bool isInsert, DO_DocumentGeneration obj)
        {

            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

                if (isInsert)
                {
                    var serviceResponse = await _configAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Control/InsertIntoDocumentGeneration", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
                else
                {
                    var serviceResponse = await _configAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Control/UpdateDocumentGeneration", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateDocumentGeneration:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Activate or De Activate Room Type
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> ActiveOrDeActiveDocumentGeneration(DO_DocumentGeneration objgen)
        {

            try
            {

                var serviceResponse = await _configAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Control/ActiveOrDeActiveDocumentGeneration", objgen);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ActiveOrDeActiveDocumentGeneration:", objgen);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        #endregion Document Generation 

        
    }
}