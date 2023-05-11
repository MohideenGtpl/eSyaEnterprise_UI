using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eSyaEnterprise_UI.Areas.PatientManagement.Models;
using eSyaEnterprise_UI.Areas.PatientManagement.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using eSyaEnterprise_UI.ActionFilter;

namespace eSyaEnterprise_UI.Areas.PatientManagement.Controllers
{
    [SessionTimeout]
    public class PaymentModeController : Controller
    {
        private readonly IPatientManagementAPIServices _patientManagementAPIServices;
        private readonly ILogger<PaymentModeController> _logger;

        public PaymentModeController(IPatientManagementAPIServices patientManagementAPIServices, ILogger<PaymentModeController> logger)
        {
            _patientManagementAPIServices = patientManagementAPIServices;
            _logger = logger;
        }

        [Area("PatientManagement")]
        public IActionResult _PaymentDetail()
        {
            return View();
        }
        [Area("PatientManagement")]
        public IActionResult Billing()
        {
            return View();
        }

        public async Task<JsonResult> GetPaymentMode()
        {
            try
            {
                var serviceResponse = await _patientManagementAPIServices.HttpClientServices.GetAsync<List<DO_PaymentMode>>("ReceiptMaster/GetPaymentMode");
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {

                    return Json(new List<DO_PaymentMode>());
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetPaymentMode");
                throw ex;
            }
        }

        public async Task<JsonResult> GetPaymentModeCategoryById(int paymentModeId)
        {
            try
            {
                var parameter = "?paymentModeId=" + paymentModeId;
                var serviceResponse = await _patientManagementAPIServices.HttpClientServices.GetAsync<List<DO_PaymentModeCategory>>("ReceiptMaster/GetPaymentModeCategoryById"+ parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {

                    return Json(new List<DO_PaymentMode>());
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetPaymentModeCategoryById?paymentModeId="+ paymentModeId);
                throw ex;
            }
        }

    }
}