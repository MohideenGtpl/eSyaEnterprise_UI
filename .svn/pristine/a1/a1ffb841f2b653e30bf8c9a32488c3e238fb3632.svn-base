using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using eSyaEnterprise_UI.ActionFilter;
using eSyaEnterprise_UI.Areas.ApprovalProcess.Data;
using eSyaEnterprise_UI.Areas.ApprovalProcess.Models;
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

namespace eSyaEnterprise_UI.Areas.ApprovalProcess.Controllers
{
    public class LevelsController : Controller
    {
        private readonly IApprovalAPIServices _approvalAPIServices;
        private readonly ILogger<LevelsController> _logger;

        public LevelsController(IApprovalAPIServices approvalAPIServices, ILogger<LevelsController> logger)
        {
            _approvalAPIServices = approvalAPIServices;
            _logger = logger;
        }

        #region Form Task Assignment

        [Area("ApprovalProcess")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> ESA_11_00()
        {
            try
            {
                List<int> l_ac = new List<int>();
                l_ac.Add(CodeTypeValues.TaskId);
                var formresponse = await _approvalAPIServices.HttpClientServices.GetAsync<List<DO_FormNames>>("FormApproval/GetAllActiveForms");
                var response = await _approvalAPIServices.HttpClientServices.PostAsJsonAsync<List<DO_ApplicationCodes>>("FormApproval/GetApplicationCodesByCodeTypeList", l_ac);
                if (response.Status && formresponse.Status)
                {
                    ViewBag.Forms = formresponse.Data;
                    if (response.Data != null)
                    {
                        List<DO_ApplicationCodes> app_codes = response.Data;
                        ViewBag.FormTasks = app_codes.Where(w => w.CodeType == CodeTypeValues.TaskId);
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
        ///Get Form Task Assignment for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetFormTaskAssignments()
        {

            try
            {
                var serviceResponse = await _approvalAPIServices.HttpClientServices.GetAsync<List<DO_FormTaskAssign>>("FormApproval/GetFormTaskAssignments");
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetFormTaskAssignments");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetFormTaskAssignments");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }

        }

        /// <summary>
        /// Insert or Update Form Task Assignment
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateFormTaskAssignment(bool isInsert, DO_FormTaskAssign obj)
        {

            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                if (isInsert)
                {
                    var serviceResponse = await _approvalAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("FormApproval/InsertFormTaskAssignment", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
                else
                {
                    var serviceResponse = await _approvalAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("FormApproval/UpdateFormTaskAssignment", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateFormTaskAssignment:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Activate or De Activate Form Task Assignment
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> ActiveOrDeActiveFormTaskAssignment(bool status, int formId, int taskId)
        {

            try
            {
                var parameter = "?status=" + status + "&formId=" + formId + "&taskId=" + taskId;
                var serviceResponse = await _approvalAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("FormApproval/ActiveOrDeActiveFormTaskAssignment" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetSubMenuById:params:" + JsonConvert.SerializeObject(new { formId }));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        #endregion

        #region Form Task Approval

        [Area("ApprovalProcess")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> ESA_12_00()
        {
            try
            {
                List<int> l_ac = new List<int>();
                l_ac.Add(CodeTypeValues.UserRole);
                var formresponse = await _approvalAPIServices.HttpClientServices.GetAsync<List<DO_FormNames>>("FormApproval/GetAllActiveForms");
                var response = await _approvalAPIServices.HttpClientServices.PostAsJsonAsync<List<DO_ApplicationCodes>>("FormApproval/GetApplicationCodesByCodeTypeList" , l_ac);
                if (response.Status && formresponse.Status)
                {
                    ViewBag.Forms = formresponse.Data;
                    if (response.Data != null)
                    {
                        List<DO_ApplicationCodes> app_codes = response.Data;
                        ViewBag.UserRoles = app_codes.Where(w => w.CodeType == CodeTypeValues.UserRole);
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
        ///Get Task List  for dropdown
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetFormTaskbyFormId(int formId)
        {

            try
            {
                var parameter = "?formId=" + formId;
                var serviceResponse = await _approvalAPIServices.HttpClientServices.GetAsync<List<DO_FormTaskAssign>>("FormApproval/GetFormTaskbyFormId" + parameter);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError("UD:GetFormTaskbyFormId:params:" + JsonConvert.SerializeObject(new { formId }));
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("UD:GetFormTaskbyFormId:params:" + JsonConvert.SerializeObject(new { formId }));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }

        }

        /// <summary>
        ///Get Form Task Assignment List  for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetFormTaskApprovalsbyBusinesskey(int businesskey)
        {

            try
            {
                var parameter = "?businesskey=" + businesskey;
                var serviceResponse = await _approvalAPIServices.HttpClientServices.GetAsync<List<DO_FormTaskApproval>>("FormApproval/GetFormTaskApprovalsbyBusinesskey" + parameter);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError("UD:GetFormTaskApprovalsbyBusinesskey:params:" + JsonConvert.SerializeObject(new { businesskey }));
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetFormTaskApprovalsbyBusinesskey:params:" + JsonConvert.SerializeObject(new { businesskey }));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }

        }
        /// <summary>
        /// Insert or Update Form Task Assignment
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateFormTaskApproval(bool isInsert, DO_FormTaskApproval obj)
        {

            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                if (isInsert)
                {
                    var serviceResponse = await _approvalAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("FormApproval/InsertFormTaskApproval", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
                else
                {
                    var serviceResponse = await _approvalAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("FormApproval/UpdateFormTaskApproval", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateFormTaskApproval:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Activate or De Activate Form Task Assignment
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> ActiveOrDeActiveFormTaskApproval(DO_FormTaskApproval objform)
        {

            try
            {
                var serviceResponse = await _approvalAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("FormApproval/ActiveOrDeActiveFormTaskApproval", objform);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ActiveOrDeActiveFormTaskApproval:params:" + JsonConvert.SerializeObject(new { objform }));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        #endregion
    }
}