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
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace eSyaEnterprise_UI.Areas.Config.Controllers
{
    [SessionTimeout]
    public class CurrencyController : Controller
    {
        private readonly IeSyaConfigAPIServices _eSyaConfigAPIServices;
        private readonly ILogger<CurrencyController> _logger;
        public CurrencyController(IeSyaConfigAPIServices eSyaConfigAPIServices, ILogger<CurrencyController> logger)
        {
            _eSyaConfigAPIServices = eSyaConfigAPIServices;
            _logger = logger;
        }

        #region Currency Master
        /// <summary>
        /// Currency Master
        /// </summary>
        /// <returns></returns>


        [Area("eSyaConfig")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult V_70_00()
        {
            return View();
        }

        /// <summary>
        ///Get Currency for Grid
        /// </summary>
        [HttpGet]
        public async Task<JsonResult> GetCurrencyMaster()
        {

            try
            {
                var serviceResponse =await _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_CurrencyMaster>>("CurrencyMaster/GetCurrencyMaster");
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                   
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetCurrencyMaster");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetCurrencyMaster");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }

        }

        /// <summary>
        /// Insert Currency Master
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertIntoCurrencyMaster(DO_CurrencyMaster currency)
        {

            try
            {
                currency.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                currency.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                currency.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                var serviceResponse =await _eSyaConfigAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("CurrencyMaster/InsertIntoCurrencyMaster", currency);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertIntoCurrencyMaster:params:" + JsonConvert.SerializeObject(currency));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Update Currency Master
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> UpdateCurrencyMaster(DO_CurrencyMaster currency)
        {

            try
            {
                currency.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                currency.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                currency.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                var serviceResponse =await _eSyaConfigAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("CurrencyMaster/UpdateCurrencyMaster", currency);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:UpdateCurrencyMaster:params:" + JsonConvert.SerializeObject(currency));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        /// <summary>
        /// Activate or De Activate Currency Master
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> ActiveOrDeActiveCurrencyMaster(bool status, string currency_code)
        {

            try
            {

                var parameter = "?status=" + status + "&currency_code=" + currency_code;
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("CurrencyMaster/ActiveOrDeActiveCurrencyMaster" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ActiveOrDeActiveCurrencyMaster:For currency_code {0} ", currency_code);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        [Area("eSyaConfig")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> V_71_00()
        {
          try
            {
                
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_CurrencyMaster>>("CurrencyMaster/GetActiveCurrencyList");
                if (serviceResponse.Status)
                {
                    ViewBag.currencies = serviceResponse.Data.Select(b => new SelectListItem
                    {
                        Value = b.CurrencyCode.ToString(),
                        Text = b.CurrencyName,
                    }).ToList();
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetActiveCurrencyList");
                    throw new Exception("Internal Error");
                }
               
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetActiveCurrencyList");
                throw ex;
            }
            return View();
        }

        /// <summary>
        ///Get Currency DenominationInfo By Currency Code for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetCurrencyDenominationInfoByCurrencyCode(string CurrencyCode)
        {
            try
            {
                var parameter = "?currencyCode=" + CurrencyCode;
                var serviceResponse =await _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_CurrencyDenominationInformation>>("CurrencyMaster/GetCurrencyDenominationInfoByCurrencyCode" + parameter);
                if (serviceResponse.Status)
                {
                   return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetCurrencyDenominationInfoByCurrencyCode:For CurrencyCode {0}", CurrencyCode);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetCurrencyDenominationInfoByCurrencyCode:For CurrencyCode {0}", CurrencyCode);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        ///Insert Or Update Currency DenominationInfo
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertUpdateCurrencyDenominationInformation(bool isInsert, DO_CurrencyDenominationInformation obj)
        {
            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                if (isInsert)
                {
                    var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("CurrencyMaster/InsertCurrencyDenominationInformation", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
                else
                {
                    var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("CurrencyMaster/UpdateCurrencyDenominationInformation", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertUpdateCurrencyDenominationInformation:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        /// <summary>
        ///Delete Currency DenominationInfo
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> DeleteCurrencyDenominationInformation(string currencyCode, decimal DenomId, string BnorCNId)
        {
            try
            {
                var parameter = "?currencyCode=" + currencyCode + "&DenomId=" + DenomId + "&BnorCNId=" + BnorCNId;
                var serviceResponse =await _eSyaConfigAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("CurrencyMaster/DeleteCurrencyDenominationInformation" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:DeleteCurrencyDenominationInformation:For currencyCode {0} with denomination entered {1} with BnorCNId entered {2}", currencyCode, DenomId, BnorCNId);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Activate or De Activate Currency Denomination
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> ActiveOrDeActiveCurrencyDenomination(bool status, string currencycode,int denomId)
        {

            try
            {

                var parameter = "?status=" + status + "&currencycode=" + currencycode + "&denomId=" + denomId;
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("CurrencyMaster/ActiveOrDeActiveCurrencyDenomination" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ActiveOrDeActiveCurrencyDenomination:For denomId {0} ", denomId);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        #endregion

        #region Currency Rate
        [Area("eSyaConfig")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public  IActionResult V_75_00()
        {
            
            return View();
          
        }

        /// <summary>
        ///Get GetCurrency by Businesskey
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetCurrencybyBusinesskey(int Businesskey)
        {
            try
            {
                var parameter = "?Businesskey=" + Businesskey;
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<DO_ExchangeRate>("CurrencyMaster/GetCurrencybyBusinesskey" + parameter);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetCurrencybyBusinesskey:For Businesskey {0}", Businesskey);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetCurrencybyBusinesskey:For Businesskey {0}", Businesskey);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        /// <summary>
        ///Get Currency ExchangeRate By Currency Code for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetCurrencyExchangeRate(string Currencycode,int Businesskey)
        {
            try
            {
                if (!String.IsNullOrEmpty(Currencycode))
                {
                    var parameter = "?Currencycode=" + Currencycode + "&Businesskey=" + Businesskey;
                    var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_ExchangeRate>>("CurrencyMaster/GetCurrencyExchangeRate" + parameter);
                    if (serviceResponse.Status)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetCurrencyExchangeRate:For Currencycode {0}", Currencycode, Businesskey);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    return Json(new { Status = false, StatusCode = "500" });
                }
               
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetCurrencyExchangeRate:For Currencycode {0}", Currencycode, Businesskey);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }


        /// <summary>
        ///Insert Or Update Currency Exchange Rate
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateCurrencyExchangeRate(DO_ExchangeRate obj)
        {
            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("CurrencyMaster/InsertOrUpdateCurrencyExchangeRate", obj);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateCurrencyExchangeRate:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
            }
        }

        #endregion


       
    }
}