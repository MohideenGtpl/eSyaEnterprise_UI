using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace eSyaEnterprise_UI.Areas.Config.Resources
{
    public class localizationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}