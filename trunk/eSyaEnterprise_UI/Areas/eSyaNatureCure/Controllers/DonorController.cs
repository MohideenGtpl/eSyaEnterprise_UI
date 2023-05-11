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
using eSyaEnterprise_UI.DataServices;

namespace eSyaEnterprise_UI.Areas.eSyaNatureCure.Controllers
{
    [SessionTimeout]
    public class DonorController : Controller
    {
        private readonly IeSyaNatureCureAPIServices _eSyaNatureCureAPIServices;
        private readonly ILogger<DonorController> _logger;
        private readonly ISmsServices _smsServices;

        public DonorController(IeSyaNatureCureAPIServices eSyaNatureCureAPIServices, ISmsServices smsServices, ILogger<DonorController> logger)
        {        
           _eSyaNatureCureAPIServices = eSyaNatureCureAPIServices;
            _logger = logger;
            _smsServices = smsServices;

        }

        #region Donor Rules
        [Area("eSyaNatureCure")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> EDN_01()
        {

            try
            {
                var rmt_response = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_RoomType>>("RoomType/GetActiveRoomTypes");

                if (rmt_response.Status)
                {
                    ViewBag.RoomTypes = rmt_response.Data.Select(b => new SelectListItem
                    {
                        Value = b.RoomTypeId.ToString(),
                        Text = b.RoomTypeDesc,
                    }).ToList();
                    return View();
                }
                else
                {
                    _logger.LogError(new Exception(rmt_response.Message), "UD:GetActiveRoomTypes");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetActiveRoomTypes");
                throw ex;
            }


        }

        /// <summary>
        ///Get All Donor Rules for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetAllDonorRules()
        {

            try
            {
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_DonorRules>>("DonorMaster/GetAllDonorRules");
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetAllDonorRules");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetAllDonorRules");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }

        }

        /// <summary>
        /// Insert or Update Donor Rules
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateDonorRule(bool isInsert, DO_DonorRules obj)
        {

            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                if (isInsert)
                {
                    var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("DonorMaster/InsertIntoDonorRule", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
                else
                {
                    var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("DonorMaster/UpdateDonorRule", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateDonorRule:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Activate or De Activate Room Type
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> ActiveOrDeActiveDonorRule(bool status, int donortype)
        {

            try
            {

                var parameter = "?status=" + status + "&donortype=" + donortype;
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("DonorMaster/ActiveOrDeActiveDonorRule" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ActiveOrDeActiveDonorRule:For donortype {0} ", donortype);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        #endregion

        #region Donor Type Package Link
        [Area("eSyaNatureCure")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> EDN_02()
        {

            try
            {
                var pkg_response = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_PackageMaster>>("PackageMaster/GetActivePackageMasters");
                var drt_response = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_DonorRules>>("DonorMaster/GetActiveDonorRules");

                if (pkg_response.Status && drt_response.Status)
                {
                    ViewBag.Packages = pkg_response.Data.Select(b => new SelectListItem
                    {
                        Value = b.PackageId.ToString(),
                        Text = b.PackageDesc,
                    }).ToList();

                    ViewBag.DonorTypes = drt_response.Data.Select(b => new SelectListItem
                    {
                        Value = b.DonorType.ToString(),
                        Text = b.DonorTypeDesc,
                    }).ToList();

                    return View();
                }
                else
                {
                    _logger.LogError(new Exception(pkg_response.Message), "UD:GetActivePackageMasters");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetActivePackageMasters");
                throw ex;
            }


        }

        /// <summary>
        ///Get All Donor Rules for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetDonorLinkbyPackage(int packageId)
        {

            try
            {
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_DonorPackageLink>>("DonorMaster/GetDonorLinkbyPackage?packageId="+ packageId);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetDonorLinkbyPackage");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetDonorLinkbyPackage");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }

        }

        /// <summary>
        /// Insert or Update Donor Rules
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateDonorLinkwithPackage(DO_DonorPackageLink obj)
        {

            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
               
                    var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("DonorMaster/InsertOrUpdateDonorLinkwithPackage", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                
                
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateDonorLinkwithPackage:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        #endregion

        #region Donor Registration
        [Area("eSyaNatureCure")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> EDN_03()
        {

            try
            {
                //var rmt_response = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_RoomType>>("RoomType/GetActiveRoomTypes");
                var drt_response = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_DonorRules>>("DonorMaster/GetActiveDonorRules");

                //if (rmt_response.Status && drt_response.Status)

                    if (drt_response.Status)
                    {
                    //ViewBag.RoomTypes = rmt_response.Data.Select(b => new SelectListItem
                    //{
                    //    Value = b.RoomTypeId.ToString(),
                    //    Text = b.RoomTypeDesc,
                    //}).ToList();

                    ViewBag.DonorTypes = drt_response.Data.Select(b => new SelectListItem
                    {
                        Value = b.DonorType.ToString(),
                        Text = b.DonorTypeDesc,
                    }).ToList();

                    return View();
                }
                else
                {
                    _logger.LogError(new Exception(drt_response.Message), "UD:GetActiveDonorRules");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetActiveDonorRules");
                throw ex;
            }


        }

        /// <summary>
        ///Get Donor Registration for Grid by Business Key
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetDonorsListbyBusinesskey(int businesskey)
        {

            try
            {
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_DonorRegistration>>("DonorMaster/GetDonorsListbyBusinesskey?businesskey="+ businesskey);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetDonorsListbyBusinesskey");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetDonorsListbyBusinesskey");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }

        }

        /// <summary>
        /// Insert or Update Donor Registration
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateIntoDonorRegistration(bool isInsert, DO_DonorRegistration obj)
        {

            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);

                obj.Password = "123456";

                if (isInsert)
                {
                    var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("DonorMaster/InsertIntoDonorRegistration", obj);

                    // comment for SMS
                    if (serviceResponse.Status) { 
                        return Json(serviceResponse.Data);
                    }
                    else
                    {

                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                    }

                    //Uncomment for SMS
                    //if (serviceResponse.Status)
                    //{

                    //    DO_SmsParameter smsParams = new DO_SmsParameter();
                    //    smsParams.TEventID = SMSTriggerEventValues.OnSaveClicked;
                    //    smsParams.FormID = AppSessionVariables.GetSessionFormID(HttpContext);
                    //    obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                    //    smsParams.IsUserPasswordInclude = true;

                    //    _smsServices.SendSmsForForm(smsParams);
                    //    return Json(serviceResponse.Data);
                    //}
                    //else
                    //{

                    //    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                    //}
                }
                else
                {
                    var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("DonorMaster/UpdateIntoDonorRegistration", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateIntoDonorRegistration:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Activate or De Activate Donor Registration
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> ActiveOrDeActiveDonorRegistration(bool status, int businesskey, int donorId)
        {

            try
            {

                var parameter = "?status=" + status + "&businesskey=" + businesskey + "&donorId=" + donorId;
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("DonorMaster/ActiveOrDeActiveDonorRegistration" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ActiveOrDeActiveDonorRegistration:For donorId {0} ", donorId);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }


        [HttpGet]
        public async Task<JsonResult> GetStateList(int isdCode)
        {
            try
            {
                var parameter = "?isdCode=" + isdCode;
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_Place>>("DonorMaster/GetStateList" + parameter);
                if (serviceResponse.Status)
                {
                    if (serviceResponse.Data != null)
                    {
                        return Json(serviceResponse.Data);
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetStateList:For isdCode", isdCode);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
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
        [HttpGet]
        public async Task<JsonResult> GetCityList(int isdCode, int? stateCode)
        {
            try
            {
                if (stateCode > 0)
                {
                    var parameter = "?isdCode=" + isdCode + "&stateCode=" + stateCode;
                    var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_Place>>("DonorMaster/GetCityList" + parameter);
                    if (serviceResponse.Status)
                    {
                        if (serviceResponse.Data != null)
                        {
                            return Json(serviceResponse.Data);
                        }
                        else
                        {
                            _logger.LogError(new Exception(serviceResponse.Message), "UD:GetCityList:For isdCode {0} with stateCode entered {1}", isdCode, stateCode);
                            return Json(new { Status = false, StatusCode = "500" });
                        }
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetCityList:For isdCode {0} with stateCode entered {1}", isdCode, stateCode);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetCityList:For isdCode {0} with stateCode entered {1}", isdCode, stateCode);
                throw ex;
            }
        }
        [HttpGet]
        public async Task<JsonResult> GetAreaList(int isdCode, int? stateCode, int? cityCode)
        {
            try
            {
                if (stateCode > 0 && cityCode > 0)
                {
                    var parameter = "?isdCode=" + isdCode + "&stateCode=" + stateCode + "&cityCode=" + cityCode;
                    var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_AddressIN>>("DonorMaster/GetAreaList" + parameter);
                    if (serviceResponse.Status)
                    {
                        if (serviceResponse.Data != null)
                        {
                            return Json(serviceResponse.Data);
                        }
                        else
                        {
                            _logger.LogError(new Exception(serviceResponse.Message), "UD:GetAreaList:For isdCode {0} with stateCode cityCode entered {1} {2}", isdCode, stateCode, cityCode);
                            return Json(new { Status = false, StatusCode = "500" });
                        }
                    }
                    else
                    {
                        _logger.LogError(new Exception(serviceResponse.Message), "UD:GetAreaList:For isdCode {0} with stateCode cityCode pincode entered {1} {2}{3}", isdCode, stateCode, cityCode);
                        return Json(new { Status = false, StatusCode = "500" });
                    }
                }
                else
                {
                    return Json(new { Status = false });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetAreaList:For isdCode {0} with stateCode cityCode pincode entered {1} {2}", isdCode, stateCode, cityCode);
                throw ex;
            }
        }
        [HttpGet]
        public async Task<JsonResult> GetAreaDetailsbyPincode(int isdCode, string pincode)
        {
            try
            {
                var parameter = "?isdCode=" + isdCode + "&pincode=" + pincode;
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<DO_AddressIN>("DonorMaster/GetAreaDetailsbyPincode" + parameter);
                if (serviceResponse.Status)
                {

                    return Json(serviceResponse.Data);

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetAreaDetailsbyPincode:For isdCode {0} with stateCode cityCode pincode entered {1} ", isdCode, pincode);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetAreaDetailsbyPincode:For isdCode {0} with  pincode entered {1} }", isdCode, pincode);
                throw ex;
            }
        }
        /// <summary>
        /// Getting  Room Types  by Donor Type.
        /// UI Reffered - Donor Registered
        /// </summary>
        [HttpGet]
        public async Task<JsonResult> GetRoomTypebyDonorId(int donortype)
        {
            try
            {
                var parameter = "?donortype=" + donortype;
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_DonorRules>>("DonorMaster/GetRoomTypesbyDonorId" + parameter);
                if (serviceResponse.Status)
                {

                    return Json(serviceResponse.Data);

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetRoomTypebyDonorId:For donortype {0}  ", donortype);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetRoomTypebyDonorId:For donortype {0} }", donortype);
                throw ex;
            }
        }

        /// <summary>
        /// Get Discount & Number of persons by donorId & RoomTypeId
        /// </summary>
        [HttpGet]
        public async Task<JsonResult> GetDiscountbyDonorId(int donortype, int roomType)
        {
            try
            {
                var parameter = "?donortype=" + donortype + "&roomType=" + roomType;
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<DO_DonorRules>("DonorMaster/GetDiscountbyDonorId" + parameter);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetDiscountbyDoctorId:For donor type ", donortype);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetDiscountbyDoctorId:For donor type ", donortype);
                throw ex;
            }
        }
        #endregion

    }
}