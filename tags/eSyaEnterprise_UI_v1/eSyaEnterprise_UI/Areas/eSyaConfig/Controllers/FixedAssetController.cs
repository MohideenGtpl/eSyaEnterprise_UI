using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace eSyaEnterprise_UI.Areas.Config.Controllers
{
    public class FixedAssetController : Controller
    {
        #region AssetGroup
        [Area("eSyaConfig")]
        public IActionResult V_100_00()
        {
            ViewBag.formName = "Asset Group";
            return View();
        }

        #endregion AssetGroup
        #region Depreciation Method
        [Area("eSyaConfig")]
        public IActionResult V_101_00()
        {
            ViewBag.formName = "Depreciation Method";
            return View();
        }

        #endregion Depreciation Method
    }
}