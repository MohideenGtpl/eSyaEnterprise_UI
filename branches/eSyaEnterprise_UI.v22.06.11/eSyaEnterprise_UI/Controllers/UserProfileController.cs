using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using eSyaEnterprise_UI.Utility;
using eSyaEnterprise_UI.DataServices;
using Microsoft.Extensions.Logging;
using eSyaEnterprise_UI.Models;

namespace eSyaEnterprise_UI.Controllers
{
    public class UserProfileController : Controller
    {
        private readonly IeSyaGatewayServices _eSyaGatewayServices;
        private readonly ILogger<UserProfileController> _logger;

        public UserProfileController(
            IeSyaGatewayServices eSyaGatewayServices,
            ILogger<UserProfileController> logger)
        {
            _eSyaGatewayServices = eSyaGatewayServices;
            _logger = logger;
        }
        public IActionResult ResetPassword()
        {
            ViewBag.formName = "Reset Password";
            return View();
        }

        public async Task<JsonResult> ResetUserPassword(string currentPassword, string newPassword, string confirmPassword)
        {
            if (string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                return Json(new { Status = false, Message = "New Password & Confirm Password cannot be blank." });
            }
            if (newPassword != confirmPassword)
            {
                return Json(new { Status = false, Message = "New Password & Confirm Password are not same." });
            }
            var passswordpolicy = PasswordPolicy.IsValidPasswordPolicy(newPassword, 8, 1, false, false, false, false);
            if (!passswordpolicy.Status)
            {
                return Json(new { Status = false, passswordpolicy.Message });
            }
            try
            {
                var obj = new { UserID = AppSessionVariables.GetSessionUserID(HttpContext), Password = currentPassword, NewPassword = newPassword };
                var serviceResponse = await _eSyaGatewayServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("UserAccount/ResetUserPassword", obj);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);
                }
                else
                {
                    return Json(new { Status = false, Message = "Internal Error" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:ResetUserPassword:For UserID {0} ", AppSessionVariables.GetSessionUserID(HttpContext).ToString());
                throw ex;
            }
        }

    }
}