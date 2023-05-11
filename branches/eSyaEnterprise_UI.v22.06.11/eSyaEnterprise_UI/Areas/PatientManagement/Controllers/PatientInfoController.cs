using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eSyaEnterprise_UI.Areas.PatientManagement.Data;
using eSyaEnterprise_UI.Areas.PatientManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace eSyaEnterprise_UI.Areas.PatientManagement.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class PatientInfoController : ControllerBase
    {
        private readonly IPatientManagementAPIServices _patientManagementAPIServices;
        private readonly ILogger<PatientInfoController> _logger;

        public PatientInfoController(IPatientManagementAPIServices patientManagementAPIServices, ILogger<PatientInfoController> logger)
        {
            _patientManagementAPIServices = patientManagementAPIServices;
            _logger = logger;
        }

        public async Task<IActionResult> GetPatientProfileByUHID(long uhid)
        {
            try
            {
                var parameter = "?uhid=" + uhid;
                var serviceResponse = await _patientManagementAPIServices.HttpClientServices.GetAsync<DO_PatientProfile>("PatientInfo/GetPatientProfileByUHID" + parameter);
                if (serviceResponse.Status)
                    return Ok(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetPatientProfileByUHID:params:uhid:{0}" + uhid.ToString());
                    return Ok(new DO_ResponseParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetPatientProfileByUHID:params:uhid:{0}" + uhid.ToString());
                throw ex;
            }
        }
    }
}