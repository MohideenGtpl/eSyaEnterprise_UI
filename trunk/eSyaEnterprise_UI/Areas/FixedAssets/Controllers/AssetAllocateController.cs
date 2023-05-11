using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc.Rendering;
using eSyaEnterprise_UI.Utility;
using eSyaEnterprise_UI.Areas.Config.Models;
using eSyaEnterprise_UI.Areas.FixedAssets.Models;
using eSyaEnterprise_UI.Areas.FixedAssets.Data;
using eSyaEnterprise_UI.Models;
using eSyaEnterprise_UI.ActionFilter;

namespace eSyaEnterprise_UI.Areas.FixedAssets.Controllers
{
    [SessionTimeout]
    public class AssetAllocateController : Controller
    {

        private readonly IFixedAssetsAPIServices _FixedAssetsAPIServices;
        public AssetAllocateController(IFixedAssetsAPIServices FixedAssetsAPIServices)
        {
            _FixedAssetsAPIServices = FixedAssetsAPIServices;
        }

        /// <summary>
        /// Asset Allocation
        /// </summary>
        /// <returns></returns>

        [Area("FixedAssets")]
        public IActionResult V_2013_00()
        {
            var response = _FixedAssetsAPIServices.HttpClientServices.GetAsync<List<DO_DepartmentLocation>>("CommonData/GetDepartmentCodes?businessKey="+ AppSessionVariables.GetSessionBusinessKey(HttpContext)).Result;
            if (response.Status)
            {
                ViewBag.DepartmentCodes = response.Data.Select(a => new SelectListItem
                {
                    Text = a.DepartmentDesc,
                    Value = a.DepartmentID.ToString()
                });
            }
            else
                ViewBag.DepartmentCodes = "";

            ViewBag.formName = "Asset Allocation";
            return View();
        }

        /// <summary>
        /// Create Asset Register Detail data based on header data
        /// </summary>
        public JsonResult GetAssetRegisterToAllocate()
        {
            var response = _FixedAssetsAPIServices.HttpClientServices.GetAsync<List<DO_AssetRegisterDetail>>("AssetRegister/GetAssetRegisterToAllocate?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext)).Result;
            return Json(response.Data);
        }

        /// <summary>
        /// Create Asset Register Detail data based on header data
        /// </summary>
        public JsonResult GetLocationList(int departmentId)
        {
            var response = _FixedAssetsAPIServices.HttpClientServices.GetAsync<List<DO_DepartmentLocation>>("CommonData/GetLocationList?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext) + "&departmentId=" + departmentId).Result;
            return Json(response.Data);
        }
    }
}