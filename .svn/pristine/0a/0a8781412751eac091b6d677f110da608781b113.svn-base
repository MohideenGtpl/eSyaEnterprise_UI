using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eSyaEnterprise_UI.Areas.eSyaNatureCure.Data;
using eSyaEnterprise_UI.Areas.eSyaNatureCure.Models;
using eSyaEnterprise_UI.Models;
using eSyaEnterprise_UI.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text;
using System.Text.RegularExpressions;
using eSyaEnterprise_UI.ActionFilter;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;


namespace eSyaEnterprise_UI.Areas.eSyaNatureCure.Controllers
{
    public class FrontOfficeController : Controller
    {
        private readonly IeSyaNatureCureAPIServices _eSyaNatureCureAPIServices;
        private readonly ILogger<FrontOfficeController> _logger;

        public FrontOfficeController(IeSyaNatureCureAPIServices eSyaNatureCureAPIServices, ILogger<FrontOfficeController> logger)
        {
            _eSyaNatureCureAPIServices = eSyaNatureCureAPIServices;
            _logger = logger;
        }



        /// <summary>
        /// Index Dashboard 
        /// </summary>
        /// <returns></returns>
        [Area("eSyaNatureCure")]
        public IActionResult V_ENC_01_00()
        {
            return View();
        }

        /// <summary>
        /// Today Dashboard 
        /// </summary>
        /// <returns></returns>
        [Area("eSyaNatureCure")]
        public IActionResult V_ENC_02_00()
        {
            return View();
        }

        
        /// <summary>
        ///Get Today Dashboard
        /// </summary>
        [HttpGet]
        public async Task<JsonResult> GetTodayDashboard()
        {

            try
            {
                var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<DO_FrontOffice>("FrontOffice/GetTodayDashboard" + parameter);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetTodayDashboard");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetTodayDashboard");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }

        }


        /// <summary>
        ///Get Dashboard By Date
        /// </summary>
        [HttpGet]
        public async Task<JsonResult> GetDashboardByDate(DateTime fromDate, DateTime toDate)
        {

            try
            {
                var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
                parameter += "&fromDate=" + fromDate.ToString("dd-MMM-yyyy");
                parameter += "&toDate=" + toDate.ToString("dd-MMM-yyyy");
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_BookinDetails>>("FrontOffice/GetDashboardByDate" + parameter);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetDashboardByDate");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetDashboardByDate");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }

        }

    }
}