using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eSyaEnterprise_UI.Areas.Config.Models;
using eSyaEnterprise_UI.Areas.eSyaNatureCure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace eSyaEnterprise_UI.Areas.eSyaNatureCure.Controllers
{
    public class CommonMasterController : Controller
    {
        private readonly IeSyaNatureCureAPIServices _eSyaNatureCureAPIServices;
        private readonly ILogger<CommonMasterController> _logger;

        public CommonMasterController(IeSyaNatureCureAPIServices eSyaNatureCureAPIServices, ILogger<CommonMasterController> logger)
        {
            _eSyaNatureCureAPIServices = eSyaNatureCureAPIServices;
            _logger = logger;
        }

        public async Task<JsonResult> GetPaymentMode()
        {
            try
            {
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_ApplicationCodes>>("CommonMaster/GetApplicationCodesByCodeType?codeType=" + CodeTypeValues.PaymentMode.ToString());
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                   
                    return Json(new DO_ApplicationCodes());
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetPaymentMode:params:codeType:{0}" + CodeTypeValues.PaymentMode.ToString());
                throw ex;
            }
        }
    }
}