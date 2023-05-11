using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eSyaEnterprise_UI.ActionFilter;
using Microsoft.AspNetCore.Mvc;

namespace eSyaEnterprise_UI.Areas.Pharmacy.Controllers
{
    [SessionTimeout]
    public class RulesController : Controller
    {
        [Area("Pharmacy")]
        public IActionResult ECP_10_00()
        {
            return View();
        }
    }
}