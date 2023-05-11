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
using Newtonsoft.Json;

namespace eSyaEnterprise_UI.Areas.eSyaNursingStation.Controllers
{
    public class OperativeAnaesthesiaCareController : Controller
    {
        private readonly IeSyaNursingStationAPIServices _eSyaNursingStationAPIServices;
        private readonly ILogger<OperativeAnaesthesiaCareController> _logger;

        private readonly IHostingEnvironment _hostingEnvironment;

        public OperativeAnaesthesiaCareController(IeSyaNursingStationAPIServices eSyaNursingStationAPIServices, ILogger<OperativeAnaesthesiaCareController> logger, IHostingEnvironment hostingEnvironment)
        {
            _eSyaNursingStationAPIServices = eSyaNursingStationAPIServices;
            _logger = logger;
            _hostingEnvironment = hostingEnvironment;
        }


        [Area("eSyaNursingStation")]
        public IActionResult V_6004_00()
        {
            return View();
        }

        [Area("eSyaNursingStation")]
        public IActionResult V_6004_OT(int UHID, int ipNumber, int otTransactionKey)
        {
            ViewBag.UHID = UHID;
            ViewBag.IpNumber = ipNumber;
            ViewBag.TransactionID = otTransactionKey;
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> InsertIntoOperativeAnaesthesiaInformation(DO_OperativeAnaesthesiaInformation obj)
        {
            try
            {
                obj.BusinessKey = AppSessionVariables.GetSessionBusinessKey(HttpContext);
                obj.ActiveStatus = true;
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormID = AppSessionVariables.GetSessionFormInternalID(HttpContext);

                obj.TransactionDate = System.DateTime.Now; //obj.TransactionDate.Date.Add(obj.TransactionTime);

                var serviceResponse = await _eSyaNursingStationAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("OperativeAnaesthesia/InsertIntoOperativeAnaesthesiaInformation", obj);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data.Status)
                        return Json(new { Status = true, serviceResponse.Data.Message });
                    else
                        return Json(new { Status = false, serviceResponse.Data.Message });
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:InsertIntoOperativeAnaesthesiaInformation:params:" + JsonConvert.SerializeObject(obj));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertIntoOperativeAnaesthesiaInformation:params:" + JsonConvert.SerializeObject(obj));
                return Json(new { Status = false, Warning = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
            }
        }

        public async Task<JsonResult> GetOperativeAnaesthesiaInformationValueByTransaction(int UHID, int ipNumber, int transactionID)
        {
            try
            {
                var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
                parameter += "&UHID=" + UHID.ToString();
                parameter += "&ipnumber=" + ipNumber.ToString();
                parameter += "&transactionID=" + transactionID.ToString();

                var serviceResponse = await _eSyaNursingStationAPIServices.HttpClientServices.GetAsync<List<DO_OperativeAnaesthesiaInformation>>("OperativeAnaesthesia/GetOperativeAnaesthesiaInformationValueByTransaction" + parameter);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), string.Format("UD:GetOperativeAnaesthesiaInformationValueByTransaction:params: businessKey:{0},UHID:{1},ipnumber:{2},transactionID:{3}",
                        AppSessionVariables.GetSessionBusinessKey(HttpContext).ToString(), UHID, ipNumber, transactionID));
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, string.Format("UD:GetOperativeAnaesthesiaInformationValueByTransaction:params: businessKey:{0},UHID:{1},ipnumber:{2},transactionID:{3}",
                        AppSessionVariables.GetSessionBusinessKey(HttpContext).ToString(), UHID, ipNumber, transactionID));
                throw ex;
            }
        }


    }
}