using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace eSyaEnterprise_UI.Areas.eSyaOutPatient.Controllers
{
    public class EmergencyController : Controller
    {
        [Area("eSyaOutPatient")]
        public IActionResult V_3001_00()
        {
            return View();
        }
         
        [Area("eSyaOutPatient")]
        public IActionResult V_3002_00()
        {
            return View();
        }
         
    }
}