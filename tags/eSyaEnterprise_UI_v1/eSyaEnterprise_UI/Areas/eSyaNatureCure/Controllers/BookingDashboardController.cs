using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace eSyaEnterprise_UI.Areas.eSyaNatureCure.Controllers
{
    public class BookingDashboardController : Controller
    {
        [Area("eSyaNatureCure")]
        public IActionResult Index()
        {
            return View();
        }

        [Area("eSyaNatureCure")]
        public IActionResult TodaysView()
        {
            return View();
        }

        [Area("eSyaNatureCure")]
        public IActionResult UserInfo()
        {
            return View();
        }
    }
}