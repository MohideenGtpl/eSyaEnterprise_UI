using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using eSyaEnterprise_UI.ActionFilter;
using eSyaEnterprise_UI.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using eSyaEnterprise_UI.Areas.eSyaNatureCure.Data;
using eSyaEnterprise_UI.Models;
using eSyaEnterprise_UI.Areas.eSyaNatureCure.Models;


namespace eSyaEnterprise_UI.Areas.eSyaNatureCure.Controllers
{
    [SessionTimeout]
    public class MemberShipCardController : Controller
    {
        private readonly IeSyaNatureCureAPIServices _eSyaNatureCureAPIServices;
        private readonly ILogger<MemberShipCardController> _logger;

        public MemberShipCardController(IeSyaNatureCureAPIServices eSyaNatureCureAPIServices, ILogger<MemberShipCardController> logger)
        {
            _eSyaNatureCureAPIServices = eSyaNatureCureAPIServices;
            _logger = logger;
        }
        #region MemberShip Card

        [Area("eSyaNatureCure")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> V_ENC_23_00()
        {

            try
            {
                int patientTypeId = CodeTypeValues.patientTypeId;
                var response = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_ApplicationCodes>>("MembershipRegistration/GetMembershipTypebyPatientId?patientTypeId=" + patientTypeId);
                var rmt_response = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_RoomType>>("RoomType/GetActiveRoomTypes");

                if (response.Status && rmt_response.Status)
                {
                    if (response.Data != null)
                    {
                        ViewBag.MemberShipTypes = response.Data;
                        ViewBag.RoomTypes = rmt_response.Data;
                        return View();
                    }
                    else
                    {
                        _logger.LogError(new Exception(response.Message), "UD:GetApplicationCodesByCodeTypeList");
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    _logger.LogError(new Exception(response.Message), "UD:GetApplicationCodesByCodeTypeList");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetApplicationCodesByCodeTypeList");
                throw ex;
            }


        }



        /// <summary>
        /// Getting Get Membership Card.
        /// UI Reffered - Membership Card
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetMembershipCard()
        {
            try
            {
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_MemberShipCard>>("MemberShipCard/GetMembershipCard");
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetMembershipCard");
                    return Json(new { serviceResponse.Data });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetMembershipCard");
                throw ex;
            }
        }

        /// <summary>
        /// Insert Or Update Into MemberShip Card
        /// </summary>
        [HttpPost]
        public JsonResult InsertOrUpdateMembershipCard(DO_MemberShipCard obj)
        {
            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);

                var Insertresponse = _eSyaNatureCureAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("MemberShipCard/InsertOrUpdateMembershipCard", obj).Result;
                return Json(Insertresponse.Data);

            }
            catch (Exception ex)
            {
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }




        /// <summary>
        /// Active/De Active  Member Ship Card.
        /// UI Reffered - Member Ship Card
        /// Params status- membershiptype 
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> ActiveOrDeActiveMembershipCard(bool status, int membershiptype)
        {

            try
            {

                var parameter = "?status=" + status + "&membershiptype=" + membershiptype;
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("MemberShipCard/ActiveOrDeActiveMembershipCard" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ActiveOrDeActiveMembershipCard:For membershiptype {0} ", membershiptype);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        #endregion
    }
}