using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eSyaEnterprise_UI.ActionFilter;
using eSyaEnterprise_UI.Areas.eSyaMCServices.Data;
using eSyaEnterprise_UI.Areas.eSyaMCServices.Models;
using eSyaEnterprise_UI.Models;
using eSyaEnterprise_UI.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
namespace eSyaEnterprise_UI.Areas.eSyaMCServices.Controllers
{
    public class SpecialtyUnitsController : Controller
    {
        private readonly IeSyaMCServicesAPIServices _eSyaMCServicesAPIServices;
        private readonly ILogger<SpecialtyUnitsController> _logger;
        public SpecialtyUnitsController(IeSyaMCServicesAPIServices eSyaMCServicesAPIServices, ILogger<SpecialtyUnitsController> logger)
        {
            _eSyaMCServicesAPIServices = eSyaMCServicesAPIServices;
            _logger = logger;
        }
        [Area("eSyaMCServices")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult V_1581_00()
        {
            ViewBag.formName = "Specialty Units";
            return View();
        }

        /// <summary>
        ///Get Specialty Unit By BusinessKey for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetSpecialtyUnitsbyBusinessKey(int Businesskey)
        {
            try
            {
                var parameter = "?Businesskey="+ Businesskey;
                var serviceResponse = await _eSyaMCServicesAPIServices.HttpClientServices.GetAsync<List<DO_SpecialtUnits>>("SpecialtyUnits/GetSpecialtyUnitsbyBusinessKey" + parameter);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetSpecialtyUnitsbyBusinessKey:For BusinessKey {0}", Businesskey);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetSpecialtyUnitsbyBusinessKey:For BusinessKey {0}", Businesskey);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        /// <summary>
        ///Insert Or Update Specialty Units
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateSpecialtyUnits(DO_SpecialtUnits obj)
        {
            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                var serviceResponse = await _eSyaMCServicesAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("SpecialtyUnits/InsertOrUpdateSpecialtyUnits", obj);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateSpecialtyUnits:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
            }
        }
    }
}