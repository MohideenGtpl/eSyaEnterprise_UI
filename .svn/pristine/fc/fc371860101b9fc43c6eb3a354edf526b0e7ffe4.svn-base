using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using eSyaEnterprise_UI.ActionFilter;
using eSyaEnterprise_UI.Areas.Stores.Data;
using eSyaEnterprise_UI.Areas.Stores.Models;
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

namespace eSyaEnterprise_UI.Areas.Stores.Controllers
{
    [SessionTimeout]
    public class ManageStoresController : Controller
    {
        private readonly IStoreAPIServices _storeAPIServices;
        private readonly ILogger<ManageStoresController> _logger;

        public ManageStoresController(IStoreAPIServices storeAPIServices, ILogger<ManageStoresController> logger)
        {
            _storeAPIServices = storeAPIServices;
            _logger = logger;
        }
        #region Store Master
        //Store Master
        [Area("Stores")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult ECI_01_00()
        {

            return View();
        }
        /// <summary>
        /// Get Store Codes List for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetStoreCodes()
        {
            try
            {
                var serviceResponse = await _storeAPIServices.HttpClientServices.GetAsync<List<DO_StoreMaster>>("StoreMaster/GetStoreCodes");
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetStoreCodes");
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetStoreCodes");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetStoreCodes");
                throw ex;
            }
        }

        /// <summary>
        /// Get Store parameter
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetStoreParameterList(int StoreCode)
        {
            try
            {
                var serviceResponse = await _storeAPIServices.HttpClientServices.GetAsync<DO_StoreMaster>("StoreMaster/GetStoreParameterList?StoreCode=" + StoreCode);

                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetStoreParameterList:For StoreCode {0}", StoreCode);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetStoreParameterList:For StoreCode {0}", StoreCode);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetStoreParameterList:For StoreCode {0}", StoreCode);
                throw ex;
            }
        }

        /// <summary>
        /// Insert or Update Store Codes
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateStoreCodes(DO_StoreMaster storecodes)
        {
            try
            {
                if (string.IsNullOrEmpty(storecodes.StoreType))
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select Store Type" });
                }
                else if (string.IsNullOrEmpty(storecodes.StoreDesc))
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Enter Store Description" });
                }
                else
                {
                    storecodes.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                    storecodes.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                    storecodes.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);

                    var serviceResponse = await _storeAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("StoreMaster/InsertOrUpdateStoreCodes", storecodes);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertOrUpdateStoreCodes:params:" + JsonConvert.SerializeObject(storecodes));
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateStoreCodes:params:" + JsonConvert.SerializeObject(storecodes));
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }
        /// <summary>
        /// Delete Store Codes
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> DeleteStoreCode(int StoreCode)
        {
            try
            {
                if (StoreCode == 0)
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "Please Select Store" });
                }
                else
                {
                    var parameter = "?StoreCode=" + StoreCode;
                    var serviceResponse = await _storeAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("StoreMaster/DeleteStoreCode" + parameter);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:DeleteStoreCode:For StoreCode {0}", StoreCode);
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:DeleteStoreCode:For StoreCode {0}", StoreCode);
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }

        /// <summary>
        /// Activate or De Activate Store Code
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> ActiveOrDeActiveStoreCode(bool status, string storetype, int storecode)
        {

            try
            {

                var parameter = "?status=" + status + "&storetype=" + storetype + "&storecode=" + storecode;
                var serviceResponse = await _storeAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("StoreMaster/ActiveOrDeActiveStoreCode" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ActiveOrDeActiveStoreCode:For storecode {0} ", storecode);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        #endregion Store Master
    }
}