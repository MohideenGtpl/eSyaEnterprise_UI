using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace eSyaEnterprise_UI.Areas.Inventory.Controllers
{
    public class ItemVendorController : Controller
    {
        #region Item Vendor Link
        [Area("Inventory")]
        public IActionResult ECI_14_00()
        {
            ViewBag.formName = "Item Vendor Link";
            return View();
        }
        #endregion
    }
}