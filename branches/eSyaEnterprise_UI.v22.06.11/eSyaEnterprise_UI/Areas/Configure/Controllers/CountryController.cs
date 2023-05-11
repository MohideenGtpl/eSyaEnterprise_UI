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
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace eSyaEnterprise_UI.Areas.Configure.Controllers
{
    [SessionTimeout]
    public class CountryController : Controller
    {
        private readonly IConfigAPIServices _configAPIServices;
        private IHostingEnvironment _env;
        private readonly ILogger<CountryController> _logger;

        public CountryController(IConfigAPIServices configAPIServices, IHostingEnvironment env, ILogger<CountryController> logger)
        {
            _configAPIServices = configAPIServices;
            _env = env;
            _logger = logger;
        }

        #region Country Info
        /// <summary>
        /// Country Information
        /// </summary>
        /// <returns></returns>
        /// 

        [Area("Configure")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> ECA_16_00()
        {
            try
            {
                var domainname = this.Request.PathBase;
                var ImagePath = Path.Combine(_env.WebRootPath, "Uploads/CountryFlagICons");
                DirectoryInfo dir = new DirectoryInfo(ImagePath);
                FileInfo[] files = dir.GetFiles();

                var localdname = domainname + "Uploads/CountryFlagICons";
                var serverdname = domainname + "/Uploads/CountryFlagICons";

                List<IMGCountryFlag> ImageList = new List<IMGCountryFlag>();
                foreach (var item in files)
                {
                    IMGCountryFlag obj = new IMGCountryFlag()
                    {
                        Name = item.Name,
                        localDomainwithPath = localdname,
                        ServerDomainwithPath = serverdname,
                        DomainName = domainname
                    };
                    ImageList.Add(obj);

                }
                ViewBag.Images = ImageList;
                /// Getting Currency List
                var serviceResponse = await _configAPIServices.HttpClientServices.GetAsync<List<DO_CurrencyMaster>>("CurrencyMaster/GetActiveCurrencyList");

                if (serviceResponse.Status)
                {
                    ViewBag.currencyList = serviceResponse.Data;
                    return View();

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetActiveCurrencyList");
                    return Json(new { Status = false, StatusCode = "500" });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetActiveCurrencyList");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }

        }

        /// <summary>
        /// Insert or Update Country Codes
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateCountryCodes(DO_CountryCodes country)
        {
            try
            {
                string filePath = "Uploads/CountryFlagICons/" + country.imgName;
                country.CountryFlag = filePath;
                country.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                country.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                country.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                if (country.Isadd == 1)
                {
                    var serviceResponse = await _configAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Country/InsertIntoCountryCode", country);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

                else
                {
                    var serviceResponse = await _configAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Country/UpdateCountryCode", country);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateCountryCodes:params:" + JsonConvert.SerializeObject(country));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        /// <summary>
        ///Get All Country Codes for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetAllCountryCodes()
        {

            try
            {
                var domainname = this.Request.PathBase;
                var serviceResponse = await _configAPIServices.HttpClientServices.GetAsync<List<DO_CountryCodes>>("Country/GetAllCountryCodes");

                if (serviceResponse.Status)
                {
                    var data = serviceResponse.Data;
                    List<DO_CountryCodes> countries = new List<DO_CountryCodes>();
                    //for server hosting
                    foreach (var item in data)
                    {
                        DO_CountryCodes country = new DO_CountryCodes()
                        {
                            Isdcode = item.Isdcode,
                            CountryCode = item.CountryCode,
                            CountryName = item.CountryName,
                            CountryFlag = domainname + item.CountryFlag,
                            CurrencyCode = item.CurrencyCode,
                            MobileNumberPattern = item.MobileNumberPattern,
                            Uidlabel = item.Uidlabel,
                            Uidpattern = item.Uidpattern,
                            Nationality = item.Nationality,
                            IsPoboxApplicable = item.IsPoboxApplicable,
                            PoboxPattern = item.PoboxPattern,
                            IsPinapplicable = item.IsPinapplicable,
                            PincodePattern = item.PincodePattern,
                            ActiveStatus = item.ActiveStatus,
                            postedfile = item.postedfile,
                            imgName = item.imgName,
                            CurrencyName = item.CurrencyName
                        };
                        countries.Add(country);
                    }
                    return Json(countries);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetAllCountryCodes");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetAllCountryCodes");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Activate or De Activate Country Codes
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> ActiveOrDeActiveCountryCode(bool status, int Isd_code)
        {

            try
            {

                var parameter = "?status=" + status + "&Isd_code=" + Isd_code;
                var serviceResponse = await _configAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("Country/ActiveOrDeActiveCountryCode" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ActiveOrDeActiveCountryCode:For codeType {0} ", Isd_code);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        #endregion Country Info

        #region Statutory Details-Country  wise

        /// <summary>
        /// Country Statutory Details
        /// </summary>
        /// <returns> </returns>
        /// </summary>
        [Area("Configure")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> ECA_17_00()
        {
            try
            {
                var serviceResponse = await _configAPIServices.HttpClientServices.GetAsync<List<DO_CountryCodes>>("ConfigMasterData/GetISDCodes");
                if (serviceResponse.Status)
                {
                    ViewBag.Isdcodes = serviceResponse.Data;
                    return View();

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetISDCodes");
                    return Json(new { Status = false, StatusCode = "500" });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetISDCodes");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }

        }

        /// <summary>
        ///Get Statutory Parameter List by ISD Code & Statutory Code
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetStatutoryCodesParameterList(int IsdCode, int StatutoryCode)
        {
            try
            {
                var parameter = "?IsdCode=" + IsdCode + "&StatutoryCode=" + StatutoryCode;
                var serviceResponse = await _configAPIServices.HttpClientServices.GetAsync<List<DO_eSyaParameter>>("Country/GetStatutoryCodesParameterList" + parameter);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetStatutoryCodesParameterList:For IsdCode {0} with StatutoryCode entered {1}", IsdCode, StatutoryCode);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetStatutoryCodesParameterList:For IsdCode {0} with StatutoryCode entered {1}", IsdCode, StatutoryCode);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetStatutoryCodesParameterList:For IsdCode {0} with StatutoryCode entered {1}", IsdCode, StatutoryCode);
                throw ex;
            }
        }

        /// <summary>
        /// Get Country Statutory Details by ISD Code for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetStatutoryCodesbyIsdcode(int Isdcode)
        {
            try
            {
                var parameter = "?Isdcode=" + Isdcode;
                var serviceResponse = await _configAPIServices.HttpClientServices.GetAsync<List<DO_CountryStatutoryDetails>>("Country/GetStatutoryCodesbyIsdcode" + parameter);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetStatutoryCodesbyIsdcode:For ISDCode {0}", Isdcode);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetStatutoryCodesbyIsdcode:For ISDCode {0}", Isdcode);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Insert or Update Country Statutory Details
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateStatutoryCodes(DO_CountryStatutoryDetails obj)
        {

            try
            {
                if (obj.Isdcode == 0)
                {
                    return Json(new { Status = false, Message = "Please Select ISD Code" });
                }
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                var serviceResponse = await _configAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Country/InsertOrUpdateStatutoryCodes", obj);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateStatutoryCodes:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Activate or De Activate StatutoryCodes
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> ActiveOrDeActiveStatutoryCode(bool status, int Isd_code, int statutorycode)
        {

            try
            {

                var parameter = "?status=" + status + "&Isd_code=" + Isd_code + "&statutorycode=" + statutorycode;
                var serviceResponse = await _configAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("Country/ActiveOrDeActiveStatutoryCode" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ActiveOrDeActiveStatutoryCode:For statutorycode {0} ", statutorycode);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        #endregion Statutory Details-Country  wise
    }
}