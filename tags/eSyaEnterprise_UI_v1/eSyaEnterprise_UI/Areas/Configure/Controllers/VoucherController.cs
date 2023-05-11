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
    public class VoucherController : Controller
    {
        private readonly IConfigAPIServices _configAPIServices;
        private readonly ILogger<VoucherController> _logger;

        public VoucherController(IConfigAPIServices configAPIServices, ILogger<VoucherController> logger)
        {
            _configAPIServices = configAPIServices;
            _logger = logger;
        }

        #region Mode of Payment 

        [Area("Configure")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> ECA_11_00()
        {
            try
            {
                var pmode_res = await _configAPIServices.HttpClientServices.GetAsync<List<DO_ApplicationCodes>>("Voucher/GetApplicationCodesByCodeType?codeType=" + CodeTypeValues.PaymentMode);
                var pcat_res = await _configAPIServices.HttpClientServices.GetAsync<List<DO_ApplicationCodes>>("Voucher/GetApplicationCodesByCodeType?codeType=" + CodeTypeValues.PaymentCategory);

                if (pmode_res.Status)
                {
                    ViewBag.Mode = pmode_res.Data.
                         Select(b => new SelectListItem
                         {
                             Value = b.ApplicationCode.ToString(),
                             Text = b.CodeDesc,
                         }).ToList();
                }
                else
                {
                    _logger.LogError(new Exception(pmode_res.Message), "UD:GetApplicationCodesByCodeType");

                }
                if (pcat_res.Status)
                {
                    ViewBag.Category = pcat_res.Data.
                         Select(b => new SelectListItem
                         {
                             Value = b.ApplicationCode.ToString(),
                             Text = b.CodeDesc,
                         }).ToList();
                }
                else
                {
                    _logger.LogError(new Exception(pcat_res.Message), "UD:GetApplicationCodesByCodeType");

                }
                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ESA_05_00");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        ///Get Payment Mode List for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetPaymentModes()
        {

            try
            {
                var serviceResponse = await _configAPIServices.HttpClientServices.GetAsync<List<DO_PaymentMode>>("Voucher/GetPaymentModes");
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetPaymentModes");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetPaymentModes");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }

        }

        /// <summary>
        /// Insert Into Payment Mode
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdatePaymentMode(DO_PaymentMode obj)
        {

            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

                var serviceResponse = await _configAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Voucher/InsertOrUpdatePaymentMode", obj);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });


            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdatePaymentMode:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Activate or De Activate Payment Mode
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> ActiveOrDeActivePaymentMode(DO_PaymentMode obj)
        {

            try
            {
                var serviceResponse = await _configAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Voucher/ActiveOrDeActivePaymentMode", obj);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ActiveOrDeActivePaymentMode");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        #endregion Payment Mode

        #region Transaction Type

        [Area("Configure")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult ECA_12_00()
        {
            try
            {
                return View();

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ESA_06_00");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }


        }


        /// <summary>
        /// Getting Payment Voucher for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetPaymentVouchers()
        {
            try
            {
                var serviceResponse = await _configAPIServices.HttpClientServices.GetAsync<List<DO_PaymentVoucher>>("Voucher/GetPaymentVouchers");
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetPaymentVouchers");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetPaymentVouchers");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Insert or Update Payment Voucher
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdatePaymentVoucher(bool isInsert, DO_PaymentVoucher obj)
        {

            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                if (isInsert)
                {
                    var serviceResponse = await _configAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Voucher/InsertIntoPaymentVoucher", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

                else
                {
                    var serviceResponse = await _configAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Voucher/UpdatePaymentVoucher", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdatePaymentVoucher:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Activate or De Activate Document Control
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> ActiveOrDeActivePaymentVoucher(bool status, int voucherId)
        {

            try
            {

                var parameter = "?status=" + status + "&voucherId=" + voucherId;
                var serviceResponse = await _configAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("Voucher/ActiveOrDeActivePaymentVoucher" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ActiveOrDeActivePaymentVoucher:For voucherId {0} ", voucherId);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        #endregion Voucher

        #region Mapping

        [Area("Configure")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> ECA_13_00()
        {
            try
            {
                var payment_res = await _configAPIServices.HttpClientServices.GetAsync<List<DO_PaymentMode>>("Voucher/GetActivePaymentModes");
                var voucher_res = await _configAPIServices.HttpClientServices.GetAsync<List<DO_PaymentVoucher>>("Voucher/GetActiveVouchers");

                if (payment_res.Status)
                {
                    ViewBag.Payments = payment_res.Data.
                         Select(b => new SelectListItem
                         {
                             Value = b.PaymentId.ToString(),
                             Text = b.PaymentMode,
                         }).ToList();
                }
                else
                {
                    _logger.LogError(new Exception(payment_res.Message), "UD:GetActivePaymentModes");

                }
                if (voucher_res.Status)
                {
                    ViewBag.Vouchers = voucher_res.Data.
                         Select(b => new SelectListItem
                         {
                             Value = b.VoucherId.ToString(),
                             Text = b.VoucherDesc,
                         }).ToList();
                }
                else
                {
                    _logger.LogError(new Exception(voucher_res.Message), "UD:GetActiveVouchers");

                }
                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ESA_07_00");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        ///Get Payment Voucher Link List for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetPaymentLinkedVouchers()
        {

            try
            {
                var serviceResponse = await _configAPIServices.HttpClientServices.GetAsync<List<DO_PaymentVoucherLink>>("Voucher/GetPaymentLinkedVouchers");
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetPaymentLinkedVouchers");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetPaymentLinkedVouchers");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }

        }

        /// <summary>
        /// Insert Into Payment Voucher Link
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdatePaymentVoucherLink(DO_PaymentVoucherLink obj)
        {

            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

                var serviceResponse = await _configAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Voucher/InsertIntoPaymentVoucherLink", obj);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });


            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertIntoPaymentVoucherLink:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Delete Payment Voucher Link
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> DeletePaymentLinkedVoucher(int voucherId, int paymentId)
        {

            try
            {
                var parameter = "?voucherId=" + voucherId + "&paymentId=" + paymentId;
                var serviceResponse = await _configAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("Voucher/DeletePaymentLinkedVoucher" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:DeletePaymentLinkedVoucher");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        #endregion Payment Mode
    }
}