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
    public class HolidayMasterController : Controller
    {
        private readonly IConfigAPIServices _configAPIServices;
        private readonly ILogger<HolidayMasterController> _logger;

        public HolidayMasterController(IConfigAPIServices configAPIServices, ILogger<HolidayMasterController> logger)
        {
            _configAPIServices = configAPIServices;
            _logger = logger;
        }

        [Area("Configure")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult ECA_22_00()
        {
            try
            {
                return View();

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ECA_22_00");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }


        }

        [HttpPost]
        public async Task<JsonResult> GetHolidayMasterByBusinessKey(int businesskey)
        {

            try
            {
                var parameter = "?businesskey=" + businesskey;
                var serviceresponce = await _configAPIServices.HttpClientServices.GetAsync<List<DO_HolidayMaster>>("HolidayMaster/GetHolidayByBusinessKey" + parameter);

                if(serviceresponce.Status)
                {
                    return Json(serviceresponce.Data);
                }
                else
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceresponce.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetDocumentControlNormalModebyBusinessKey:For businesskey {0} ", businesskey);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }


        }

        [HttpPost]
        public async Task <JsonResult> InsertAndUpdateHolidayMaster(bool isInsert, DO_HolidayMaster obj)
        {
            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

                if(isInsert)
                {
                    var serviceResponse = await _configAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("HolidayMaster/InsertIntoHolidayMaster", obj);

                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

                }
                else
                {
                    var serviceResponse = await _configAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("HolidayMaster/UpdateHolidayMaster",  obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

                }


            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "UD:InsertAndUpdateHolidayMaster:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }

        }
      [HttpPost]
      public async Task <JsonResult> ActiveOrDeActiveHolidayMaster(DO_HolidayMaster objgen)
     {
            try
            {
                var serviceResponse = await _configAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("HolidayMaster/ActiveOrDeActiveHolidayMaster", objgen);

                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                   return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });


            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "UD: ActiveOrDeActiveHolidayMaster:", objgen);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }


        }



    }
}