using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace eSyaEnterprise_UI.Areas.eSyaNatureCure.Controllers
{
    public class PortalController : Controller
    {
        [Area("eSyaNatureCure")]
        public IActionResult MemberRegistration()
        {
            return View();
        }
        [Area("eSyaNatureCure")]
        public IActionResult MemberInfo()
        {
            return View();
        }
        [Area("eSyaNatureCure")]
        public IActionResult RoomUpgrade()
        {
            return View();
        }
        [Area("eSyaNatureCure")]
        public IActionResult PersonUpgrade()
        {
            return View();
        }
    }
}