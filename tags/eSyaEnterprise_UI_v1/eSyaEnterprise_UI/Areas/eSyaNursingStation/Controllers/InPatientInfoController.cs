using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eSyaEnterprise_UI.Areas.eSyaNursingStation.Data;
using eSyaEnterprise_UI.Areas.eSyaNursingStation.Models;
using eSyaEnterprise_UI.Utility;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace eSyaEnterprise_UI.Areas.eSyaNursingStation.Controllers
{
    public class InPatientInfoController : Controller
    {
        private readonly IeSyaNursingStationAPIServices _eSyaNursingStationAPIServices;
        private readonly ILogger<InPatientInfoController> _logger;

        private readonly IHostingEnvironment _hostingEnvironment;

        public InPatientInfoController(IeSyaNursingStationAPIServices eSyaNursingStationAPIServices, ILogger<InPatientInfoController> logger, IHostingEnvironment hostingEnvironment)
        {
            _eSyaNursingStationAPIServices = eSyaNursingStationAPIServices;
            _logger = logger;
            _hostingEnvironment = hostingEnvironment;
        }

        public async Task<JsonResult> GetInPatientDetails()
        {
            try
            {
                var serviceResponse = await _eSyaNursingStationAPIServices.HttpClientServices.GetAsync<List<DO_InPatientDetail>>("InPatientInfo/GetInPatientDetails");
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), string.Format("UD:GetInPatientDetails"));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, string.Format("UD:GetInPatientDetails"));
                throw ex;
            }
        }

        public async Task<JsonResult> GetInPatientDetailsByIPNumber(int ipNumber)
        {
            try
            {
                var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
                parameter += "&ipNumber=" + ipNumber.ToString();

                var serviceResponse = await _eSyaNursingStationAPIServices.HttpClientServices.GetAsync<DO_InPatientDetail>("InPatientInfo/GetInPatientDetailsByIPNumber?" + parameter);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), string.Format("UD:GetInPatientDetails"));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, string.Format("UD:GetInPatientDetails"));
                throw ex;
            }
        }

    }
}