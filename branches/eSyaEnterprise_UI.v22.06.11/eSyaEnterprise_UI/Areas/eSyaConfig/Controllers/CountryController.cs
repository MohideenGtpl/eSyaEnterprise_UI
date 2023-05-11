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
using System.IO;
using System.Drawing;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.Text.RegularExpressions;
using eSyaEnterprise_UI.Areas.Config.Data;
using eSyaEnterprise_UI.ActionFilter;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using eSyaEnterprise_UI.Areas.eSyaConfig.Models;

namespace eSyaEnterprise_UI.Areas.Config.Controllers
{
    [SessionTimeout]
    public class CountryController : Controller
    {
        private readonly IeSyaConfigAPIServices _eSyaConfigAPIServices;
        private IHostingEnvironment _env;
        private readonly ILogger<CountryController> _logger;

        public CountryController(IeSyaConfigAPIServices eSyaConfigAPIServices, IHostingEnvironment env, ILogger<CountryController> logger)
        {
            _eSyaConfigAPIServices = eSyaConfigAPIServices;
            _env = env;
            _logger = logger;
        }
        #region Country Codes
        /// <summary>
        /// Country codes
        /// </summary>
        /// <returns></returns>
        /// 

        [Area("eSyaConfig")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> V_72_00()
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
                var serviceResponse =await _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_CurrencyMaster>>("CurrencyMaster/GetActiveCurrencyList");

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
                    var serviceResponse =await _eSyaConfigAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Country/InsertIntoCountryCode", country);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

                else
                {
                    var serviceResponse =await _eSyaConfigAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Country/UpdateCountryCode", country);
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
                var serviceResponse =await _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_CountryCodes>>("Country/GetAllCountryCodes");
               
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
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("Country/ActiveOrDeActiveCountryCode" + parameter);
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

        #endregion Country Codes

        #region Country Statutory Details

        /// <summary>
        /// Country Statutory Details
        /// </summary>
        /// <returns> </returns>
        /// </summary>
        [Area("eSyaConfig")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> V_73_00()
        {
            try
            {
                
                var serviceResponse =await _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_CountryCodes>>("ConfigMasterData/GetISDCodes");
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
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync <List<DO_eSyaParameter>>("Country/GetStatutoryCodesParameterList" + parameter);
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
                var serviceResponse =await _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_CountryStatutoryDetails>>("Country/GetStatutoryCodesbyIsdcode" + parameter);
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
                var serviceResponse =await _eSyaConfigAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Country/InsertOrUpdateStatutoryCodes", obj);
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

                var parameter = "?status=" + status + "&Isd_code=" + Isd_code+ "&statutorycode=" +statutorycode;
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("Country/ActiveOrDeActiveStatutoryCode" + parameter);
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
        #endregion Country Statutory Details

        #region Tax Structure
        [Area("eSyaConfig")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> V_74_00()
        {
            try
            {
                var serviceResponse =await _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_CountryCodes>>("ConfigMasterData/GetISDCodes");
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        ViewBag.ISDCodeList = serviceResponse.Data.Select(b => new SelectListItem
                        {
                            Value = b.Isdcode.ToString(),
                            Text = b.Isdcode.ToString() + '-' + b.CountryName,
                        }).ToList();
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:TaxStructure");
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:TaxStructure");
                }
                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:TaxStructure");
                throw ex;
            }
        }

        /// <summary>
        ///Get Tax Codes List by ISD Code
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetTaxCodesListByISDCode(int ISDCode)
        {
            try
            {
                var parameter = "?ISDCode=" + ISDCode;
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_TaxStructure>>("ConfigMasterData/GetTaxCodesListByISDCode" + parameter);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetTaxCodesListByISDCode:For ISDCode {0}", ISDCode);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetTaxCodesListByISDCode:For ISDCode {0}", ISDCode);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetTaxCodesListByISDCode:For ISDCode {0}", ISDCode);
                throw ex;
                //return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        ///Get Tax Structure by Country Code for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetTaxStructureByISDCode(int ISDCode)
        {
            try
            {
                var parameter = "?ISDCode=" + ISDCode;
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_TaxStructure>>("TaxStructure/GetTaxStructureByISDCode" + parameter);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetTaxStructureByTaxCode:For ISDCode {0}", ISDCode);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetTaxStructureByTaxCode:For ISDCode {0}", ISDCode);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetTaxStructureByISDCode:For ISDCode {0}", ISDCode);
                throw ex;
                //return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        ///Get Tax Structure by Country Code And Tax Code for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetTaxStructureByTaxCode(int ISDCode, int TaxCode)
        {
            try
            {
                var parameter = "?ISDCode= " + ISDCode + "&TaxCode=" + TaxCode;
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_TaxStructure>>("TaxStructure/GetTaxStructureByTaxCode" + parameter);

                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetTaxStructureByTaxCode:For ISDCode {0} with TaxCode entered {1}", ISDCode, TaxCode);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetTaxStructureByTaxCode:For ISDCode {0} with TaxCode entered {1}", ISDCode, TaxCode);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetTaxStructureByTaxCode:For ISDCode {0} with TaxCode entered {1}", ISDCode, TaxCode);
                throw ex;
            }
        }

        /// <summary>
        /// Insert Tax Structure 
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateTaxStructure(DO_TaxStructure tax_Struc)
        {
            try
            {
                if (string.IsNullOrEmpty(tax_Struc.TaxShortCode))
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Enter Tax Short Code" });
                }
                else if (tax_Struc.TaxCode == 0)
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select Tax Description" });
                }
                else if (string.IsNullOrEmpty(tax_Struc.TaxDescription))
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select Tax Description" });
                }
                else
                {
                    tax_Struc.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                    tax_Struc.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                    tax_Struc.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);

                    var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("TaxStructure/InsertOrUpdateTaxStructure", tax_Struc);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertOrUpdateTaxStructure:params:" + JsonConvert.SerializeObject(tax_Struc));
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateTaxStructure:params:" + JsonConvert.SerializeObject(tax_Struc));
                return Json(new { Status = false, Message = ex.ToString() });
                //return Json(new { Status = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
            }
        }

        /// <summary>
        /// Activate or De Activate Tax Structure
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> ActiveOrDeActiveTaxStructure(bool status, int Isd_code, int Taxcode)
        {

            try
            {

                var parameter = "?status=" + status + "&Isd_code=" + Isd_code + "&Taxcode="+ Taxcode;
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("TaxStructure/ActiveOrDeActiveTaxStructure" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ActiveOrDeActiveTaxStructure:For Taxcode {0} ", Taxcode);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        #endregion Tax Structure Details

        #region Tax Code Rule
        [Area("eSyaConfig")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> V_75_00()
        {
            try
            {
               
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_CountryCodes>>("ConfigMasterData/GetISDCodes");

                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        ViewBag.ISDCodeList = serviceResponse.Data.Select(b => new SelectListItem
                        {
                            Value = b.Isdcode.ToString(),
                            Text = b.Isdcode.ToString() + '-' + b.CountryName,
                        }).ToList();
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:TaxCodeRule");
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:TaxCodeRule");
                }
                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:TaxCodeRule");
                throw ex;
            }
        }

        /// <summary>
        ///Get Tax Codes by ISD Codes
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetTaxCodeByISDCode(int ISDCode)
        {
            try
            {
                var parameter = "?ISDCode=" + ISDCode;
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_TaxStructure>>("ConfigMasterData/GetTaxCodeByISDCodes" + parameter);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetTaxCodeByISDCode:For ISDCode {0}", ISDCode);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetTaxCodeByISDCode:For ISDCode {0}", ISDCode);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetTaxCodeByISDCode:For ISDCode {0}", ISDCode);
                throw ex;
            }
        }

        /// <summary>
        ///Get Tax Rule Details by Country Code And Tax Code for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetTaxRuleByISDandTaxCode(int ISDCode, int TaxCode)
        {
            try
            {
                var parameter = "?ISDCode= " + ISDCode + "&TaxCode=" + TaxCode;
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_TaxRule>>("TaxRule/GetTaxRuleByISDandTaxCode" + parameter);

                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetTaxRuleByISDandTaxCode:For ISDCode {0} with TaxCode entered {1}", ISDCode, TaxCode);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetTaxRuleByISDandTaxCode:For ISDCode {0} with TaxCode entered {1}", ISDCode, TaxCode);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetTaxRuleByISDandTaxCode:For ISDCode {0} with TaxCode entered {1}", ISDCode, TaxCode);
                throw ex;
            }
        }

        /// <summary>
        /// Insert Tax Structure 
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertIntoTaxRule(DO_TaxRule tax_Rule)
        {
            try
            {
                if (string.IsNullOrEmpty(tax_Rule.TaxShortCode))
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Enter Tax Short Code" });
                }
                else if (string.IsNullOrEmpty(tax_Rule.TaxDescription))
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Enter Tax Description" });
                }
                else if (string.IsNullOrEmpty(tax_Rule.SplitCategoryPerc.ToString()))
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Enter Tax Percentage" });
                }
                else
                {
                    tax_Rule.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                    tax_Rule.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                    tax_Rule.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                    if (tax_Rule.SerialNumber == 0)
                    {
                        var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("TaxRule/InsertIntoTaxRule", tax_Rule);
                        if (serviceResponse.Status)
                            return Json(serviceResponse.Data);
                        else
                        {
                            _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertIntoTaxRule:params:" + JsonConvert.SerializeObject(tax_Rule));
                            return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                        }
                    }
                    else
                    {
                        var serviceResponse = _eSyaConfigAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("TaxRule/UpdateTaxRule", tax_Rule).Result;
                        if (serviceResponse.Status)
                            return Json(serviceResponse.Data);
                        else
                        {
                            _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertIntoTaxRule:params:" + JsonConvert.SerializeObject(tax_Rule));
                            return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertIntoTaxRule:params:" + JsonConvert.SerializeObject(tax_Rule));
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }
        /// <summary>
        /// Activate or De Activate TaxRule
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> ActiveOrDeActiveTaxRule(bool status, int Isd_code, int Taxcode, int serialNumber)
        {

            try
            {

                var parameter = "?status=" + status + "&Isd_code=" + Isd_code + "&Taxcode="+Taxcode + "&serialNumber="+serialNumber;
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("TaxRule/ActiveOrDeActiveTaxRule" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ActiveOrDeActiveTaxRule:For serialNumber {0} ", serialNumber);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        #endregion Tax Code Rule

        #region Tax Identification
        [Area("eSyaConfig")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> V_76_00()
        {
            try
            {
               
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_CountryCodes>>("ConfigMasterData/GetIndiaISDCodes");
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        ViewBag.ISDCodeList = serviceResponse.Data.Select(b => new SelectListItem
                        {
                            Value = b.Isdcode.ToString(),
                            Text = b.Isdcode.ToString() + '-' + b.CountryName,
                        }).ToList();
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:TaxIdentification");
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:TaxIdentification");
                }
                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:TaxIdentification");
                throw ex;
            }
        }

        /// <summary>
        ///Get Tax Identification by Country Code for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetTaxIdentificationByISDCode(int ISDCode)
        {
            try
            {
                var parameter = "?ISDCode=" + ISDCode;
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_TaxIdentification>>("TaxIdentification/GetTaxIdentificationByISDCode" + parameter);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetTaxIdentificationByISDCode:For ISDCode {0}", ISDCode);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetTaxIdentificationByISDCode:For ISDCode {0}", ISDCode);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetTaxIdentificationByISDCode:For ISDCode {0}", ISDCode);
                throw ex;
                //return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        ///Get Active Tax Codes by ISD Codes AND Split Applicable True Only
        /// </summary>
        //[HttpPost]
        //public async Task<JsonResult> GetTaxCode(int ISDCode)
        //{
        //    try
        //    {
        //        var parameter = "?ISDCode=" + ISDCode;
        //        var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<List<DO_TaxStructure>>("ConfigMasterData/GetTaxCode" + parameter);
        //        //return Json(serviceResponse.Data);
        //        if (serviceResponse.Status)
        //        {
        //            if (serviceResponse.Data != null)
        //            {
        //                return Json(serviceResponse.Data);
        //            }
        //            else
        //            {
        //                _logger.LogError(new Exception(serviceResponse.Message), "UD:GetTaxCode:For ISDCode {0}", ISDCode);
        //                return Json(new { Status = false, StatusCode = "500" });
        //            }
        //        }
        //        else
        //        {
        //            _logger.LogError(new Exception(serviceResponse.Message), "UD:GetTaxCode:For ISDCode {0}", ISDCode);
        //            return Json(new { Status = false, StatusCode = "500" });
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, "UD:GetTaxCode:For ISDCode {0}", ISDCode);
        //        throw ex;
        //        //return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
        //    }
        //}

        /// <summary>
        /// Insert Tax Identification 
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateTaxIdentification(DO_TaxIdentification tax_Ident)
        {
            try
            {
                if (string.IsNullOrEmpty(tax_Ident.TaxIdentificationId.ToString()) || tax_Ident.TaxIdentificationId == 0)
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Enter Tax Identification" });
                }
                if (string.IsNullOrEmpty(tax_Ident.TaxIdentificationDesc))
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Enter Tax Identification Description" });
                }
                //else if (string.IsNullOrEmpty(tax_Ident.TaxCode.ToString()) || tax_Ident.TaxCode == 0)
                //{
                //    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select Tax Description" });
                //}
                else
                {
                    tax_Ident.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                    tax_Ident.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                    tax_Ident.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                    if (tax_Ident.InsertStatus == 0)
                    {
                        var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("TaxIdentification/InsertIntoTaxIdentiFication", tax_Ident);
                        if (serviceResponse.Status)
                            return Json(serviceResponse.Data);
                        else
                        {
                            _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertOrUpdateTaxIdentification:params:" + JsonConvert.SerializeObject(tax_Ident));
                            return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                        }
                    }
                    else
                    {
                        var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("TaxIdentification/UpdateTaxIdentiFication", tax_Ident);
                        if (serviceResponse.Status)
                            return Json(serviceResponse.Data);
                        else
                        {
                            _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertOrUpdateTaxIdentification:params:" + JsonConvert.SerializeObject(tax_Ident));
                            return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateTaxIdentification:params:" + JsonConvert.SerializeObject(tax_Ident));
                return Json(new { Status = false, Message = ex.ToString() });
                //return Json(new { Status = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
            }
        }
        /// <summary>
        /// Activate or De Activate Tax Identification
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> ActiveOrDeActiveTaxIdentification(bool status, int Isd_code, int TaxIdentificationId)
        {

            try
            {

                var parameter = "?status=" + status + "&Isd_code=" + Isd_code + "&TaxIdentificationId="+ TaxIdentificationId;
                var serviceResponse = await _eSyaConfigAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("TaxIdentification/ActiveOrDeActiveTaxIdentification" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ActiveOrDeActiveTaxIdentification:For TaxIdentificationId {0} ", TaxIdentificationId);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        #endregion Tax Identification

    }
}

