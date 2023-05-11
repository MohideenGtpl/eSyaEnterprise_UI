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
    public class MembershipRegistrationController : Controller
    {
        private readonly IeSyaNatureCureAPIServices _eSyaNatureCureAPIServices;
        private readonly ILogger<MembershipRegistrationController> _logger;

        public MembershipRegistrationController(IeSyaNatureCureAPIServices eSyaNatureCureAPIServices, ILogger<MembershipRegistrationController> logger)
        {
            _eSyaNatureCureAPIServices = eSyaNatureCureAPIServices;
            _logger = logger;
        }

        #region MemberShip Header
        /// <summary>
        /// MemberShip Registration
        /// </summary>
        /// <returns></returns>

        [Area("eSyaNatureCure")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> V_ENC_22_00()
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
                        ViewBag.RoomTypes= rmt_response.Data;
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
        /// Get State List by isdCode.
        /// </summary>
        [HttpGet]
        public async Task<JsonResult> GetStateList(int isdCode)
        {
            try
            {
                var parameter = "?isdCode=" + isdCode;
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_Place>>("MembershipRegistration/GetStateList" + parameter);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetStateList:For isdCode ", isdCode);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetStateList:For isdCode ", isdCode);
                throw ex;
            }
        }
        /// <summary>
        /// Get City List by isdCode and stateCode.
        /// </summary>
        [HttpGet]
        public async Task<JsonResult> GetCityList(int isdCode, int? stateCode)
        {
            try
            {
                var parameter = "?isdCode=" + isdCode + "&stateCode=" + stateCode;
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_Place>>("MembershipRegistration/GetCityList" + parameter);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetCityList:For isdCode {0} with stateCode entered {1}", isdCode, stateCode);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetCityList:For isdCode {0} with stateCode entered {1}", isdCode, stateCode);
                throw ex;
            }
        }

        /// <summary>
        /// Get Membership by businesskey-memberId-couponId
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetMembershipHeaderByMemberId(DO_MembershipHeader objm)
        {
            try
            {
                var parameter = "?businesskey=" + objm.BusinessKey + "&memberId=" + objm.MemberId;
                var serviceResponse =await  _eSyaNatureCureAPIServices.HttpClientServices.PostAsJsonAsync<DO_MembershipHeader>("MembershipRegistration/GetMembershipHeaderByMemberId", objm);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetMembershipByMemberId", objm);
                    return Json(new { serviceResponse.Data });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetMembershipByMemberId");
                throw ex;
            }
        }

        /// <summary>
        /// Insert Into MemberShip
        /// </summary>
        [HttpPost]
        public JsonResult InsertIntoMembershipHeader(DO_MembershipHeader obj)
        {
            try
            {
                obj.BusinessKey = AppSessionVariables.GetSessionBusinessKey(HttpContext);
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);

                var Insertresponse = _eSyaNatureCureAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameterwithMemberId>("MembershipRegistration/InsertIntoMembershipHeader", obj).Result;
                return Json(Insertresponse.Data);

            }
            catch (Exception ex)
            {
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Update MemberShip
        /// </summary>
        [HttpPost]
        public JsonResult UpdateMembershipHeader(DO_MembershipHeader obj)
        {
            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);

                var response = _eSyaNatureCureAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameterwithMemberId>("MembershipRegistration/UpdateMembershipHeader", obj).Result;
                return Json(response.Data);

            }
            catch (Exception ex)
            {
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Get MemberShip List
        /// </summary>
        [HttpGet]
        public JsonResult GetMembershipHeaderByNamePrefix(string memberNamePrefix)
        {
            try
            {
                var response = _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_MembershipHeader>>("MembershipRegistration/GetMembershipHeaderByNamePrefix?memberNamePrefix=" + memberNamePrefix).Result;
                if (response.Status)
                {
                    return Json(response.Data);
                }
                else
                {
                    return Json(new DO_ReturnParameter()
                    {
                        Status = false,
                        StatusCode = response.StatusCode.ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Activate or De Activate MemberShip
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> ActiveOrDeActiveMembershipHeader(bool status, int businesskey, long memberId)
        {

            try
            {

                var parameter = "?status=" + status + "&businesskey=" + businesskey + "&memberId=" + memberId;
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("MembershipRegistration/ActiveOrDeActiveMembershipHeader" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ActiveOrDeActiveMembership:For memberId {0} ", memberId);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        #endregion

        #region MemberShip Type

        /// <summary>
        /// Getting Get Membership Types.
        /// UI Reffered - businesskey-memberId
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetMembershipTypes(int businesskey, long memberId)
        {
            try
            {
                var parameter = "?businesskey=" + businesskey + "&memberId=" + memberId;
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_MembershipType>>("MembershipRegistration/GetMembershipTypes"+parameter);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetMembershipTypes", parameter);
                    return Json(new { serviceResponse.Data });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetMembershipTypes");
                throw ex;
            }
        }

        /// <summary>
        /// Insert Or Update Into MemberShip Type
        /// </summary>
        [HttpPost]
        public JsonResult InsertOrUpdateIntoMembershipType(DO_MembershipType objmtype)
        {
            try
            {
                objmtype.BusinessKey = AppSessionVariables.GetSessionBusinessKey(HttpContext);
                objmtype.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                objmtype.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                objmtype.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);

                var Insertresponse = _eSyaNatureCureAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("MembershipRegistration/InsertOrUpdateIntoMembershipType", objmtype).Result;
                return Json(Insertresponse.Data);

            }
            catch (Exception ex)
            {
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }




        /// <summary>
        /// Active/De Active  Member Ship Type.
        /// UI Reffered - Member Ship Registration
        /// Params status-businesskey-memberId-couponId
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> ActiveOrDeActiveMembershipType(bool status, int businesskey, long memberId, string couponId)
        {

            try
            {

                var parameter = "?status=" + status + "&businesskey=" + businesskey + "&memberId=" + memberId + "&couponId=" + couponId;
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("MembershipRegistration/ActiveOrDeActiveMembershipType" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ActiveOrDeActiveMembershipType:For memberId {0} ", memberId);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        #endregion

        #region MemberShip Donation

        /// <summary>
        /// Getting Get Membership Donations.
        /// UI Reffered - businesskey-memberId
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetMembershipDonations(int businesskey, long memberId)
        {
            try
            {
                var parameter = "?businesskey=" + businesskey + "&memberId=" + memberId;
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_MembershipDonation>>("MembershipRegistration/GetMembershipDonations" + parameter);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetMembershipDonations", parameter);
                    return Json(new { serviceResponse.Data });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetMembershipDonations");
                throw ex;
            }
        }

        /// <summary>
        /// Insert Or Update Into MemberShip Donation
        /// </summary>
        [HttpPost]
        public JsonResult InsertOrUpdateIntoMembershipDonation(DO_MembershipDonation objdonation)
        {
            try
            {
                objdonation.BusinessKey = AppSessionVariables.GetSessionBusinessKey(HttpContext);
                objdonation.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                objdonation.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                objdonation.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);

                var Insertresponse = _eSyaNatureCureAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("MembershipRegistration/InsertOrUpdateIntoMembershipDonation", objdonation).Result;
                return Json(Insertresponse.Data);

            }
            catch (Exception ex)
            {
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }




        /// <summary>
        /// Active/De Active  Member Ship Donation.
        /// UI Reffered - Member Ship Registration
        /// Params status-businesskey-memberId-serialno
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> ActiveOrDeActiveMembershipDonation(bool status, int businesskey, long memberId, int serialno)
        {

            try
            {

                var parameter = "?status=" + status + "&businesskey=" + businesskey + "&memberId=" + memberId + "&serialno=" + serialno;
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("MembershipRegistration/ActiveOrDeActiveMembershipDonation" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ActiveOrDeActiveMembershipType:For memberId {0} ", memberId);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        #endregion
    }
}