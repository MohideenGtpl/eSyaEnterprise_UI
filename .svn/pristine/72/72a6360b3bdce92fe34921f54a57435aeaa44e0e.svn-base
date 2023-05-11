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
    public class DepartmentController : Controller
    {
        private readonly IeSyaNatureCureAPIServices _eSyaNatureCureAPIServices;
        private readonly ILogger<DepartmentController> _logger;

        public DepartmentController(IeSyaNatureCureAPIServices eSyaNatureCureAPIServices, ILogger<DepartmentController> logger)
        {
            _eSyaNatureCureAPIServices = eSyaNatureCureAPIServices;
            _logger = logger;
        }

        #region Department
        /// <summary>
        /// Department
        /// </summary>
        /// <returns></returns>

        [Area("eSyaNatureCure")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> V_ENC_24_00()
        {

            try
            {
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_Department>>("Department/GetActiveDepartments");
                var serviceuserResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_User>>("Department/GetActiveUsers");

                if (serviceResponse.Status && serviceuserResponse.Status)
                {
                    ViewBag.depts = serviceResponse.Data.Select(b => new SelectListItem
                    {
                        Value = b.DepartmentId.ToString(),
                        Text = b.DepartmentDesc,
                    }).ToList();

                    ViewBag.users = serviceuserResponse.Data.Select(b => new SelectListItem
                    {
                        Value = b.UserId.ToString(),
                        Text = b.LoginDesc,
                    }).ToList();
                    return View();
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetActiveUsers");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetActiveUsers");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        ///Get Department for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetAllDepartments()
        {

            try
            {
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_Department>>("Department/GetAllDepartments");
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetAllDepartments");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetAllDepartments");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }

        }

        /// <summary>
        /// Insert or Update Department
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateDepartment(bool isInsert, DO_Department obj)
        {

            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                if (isInsert)
                {
                    var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Department/InsertIntoDepartment", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
                else
                {
                    var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Department/UpdateDepartment", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateDepartment:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        /// Activate or De Activate Department
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> ActiveOrDeActiveDepartment(bool status, int deptId)
        {

            try
            {

                var parameter = "?status=" + status + "&deptId=" + deptId;
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<DO_ReturnParameter>("Department/ActiveOrDeActiveDepartment" + parameter);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ActiveOrDeActiveDepartment:For deptId {0} ", deptId);
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        #endregion Department


        #region User Department Link

        /// <summary>
        ///Users Linked Departments by Dept Id for Grid
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetAllUsersbyDepartmentLink(int deptId)
        {

            try
            {
                var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_DepartmentUserLink>>("Department/GetAllUsersbyDepartmentLink?deptId="+ deptId);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetAllUsersbyDepartmentLink");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetAllUsersbyDepartmentLink");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }

        }


        /// <summary>
        /// Insert or Update Department
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertOrUpdateUserDepartmentLink(DO_DepartmentUserLink obj)
        {

            try
            {
                obj.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                obj.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                obj.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                
                    var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Department/InsertOrUpdateUserDepartmentLink", obj);
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                
              
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertOrUpdateUserDepartmentLink:params:" + JsonConvert.SerializeObject(obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }
        #endregion
    }
}