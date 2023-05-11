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
    public class VoucherController : Controller
    {
        private readonly IDocumentControlAPIServices _documentControlAPIServices;
        private readonly ILogger<VoucherController> _logger;

        public VoucherController(IDocumentControlAPIServices documentControlAPIServices, ILogger<VoucherController> logger)
        {
            _documentControlAPIServices = documentControlAPIServices;
            _logger = logger;
        }

        #region Voucher Generation 

        [Area("DocumentControl")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> ESA_06_00()
        {
            try
            {
                var payment_res = await _documentControlAPIServices.HttpClientServices.GetAsync<List<DO_PaymentMode>>("DocumentControl/GetActivePaymentModes");
                var voucher_res = await _documentControlAPIServices.HttpClientServices.GetAsync<List<DO_PaymentVoucher>>("DocumentControl/GetActiveVouchers");

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
                _logger.LogError(ex, "UD:ESA_08_00");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }


        /// <summary>
        /// Getting All  Voucher Generations for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetVoucherGenerationsbyBusinesskey(int businesskey)
        {

            try
            {

                var parameter = "?businesskey=" + businesskey;
                var serviceResponse = await _documentControlAPIServices.HttpClientServices.GetAsync<List<DO_VoucherGeneration>>("DocumentControl/GetVoucherGenerationsbyBusinesskey" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetVoucherGenerationsbyBusinesskey:For businesskey {0} ", businesskey);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Insert or Update Voucher Generation
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateVoucherGeneration(bool isInsert, DO_VoucherGeneration obj)
        {

            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);

                if (isInsert)
                {
                    var serviceResponse = await _documentControlAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("DocumentControl/InsertIntoVoucherGeneration", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
                else
                {
                    var serviceResponse = await _documentControlAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("DocumentControl/UpdateVoucherGeneration", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateVoucherGeneration:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Activate or De Activate Voucher Generation
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> ActiveOrDeActiveVoucherGeneration(DO_VoucherGeneration objdel)
        {

            try
            {

                var serviceResponse = await _documentControlAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("DocumentControl/ActiveOrDeActiveVoucherGeneration", objdel);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ActiveOrDeActiveVoucherGeneration:", objdel);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        #endregion Voucher Generation 
    }
}