using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eSyaEnterprise_UI.ActionFilter;
using eSyaEnterprise_UI.Areas.eSyaNursingStation.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace eSyaEnterprise_UI.Areas.eSyaNursingStation.Controllers
{
    public class DoctorAssessmentController : Controller
    {
        private readonly IeSyaNursingStationAPIServices _eSyaNursingStationAPIServices;
        private readonly ILogger<DoctorAssessmentController> _logger;

        private readonly IHostingEnvironment _hostingEnvironment;

        public DoctorAssessmentController(IeSyaNursingStationAPIServices eSyaNursingStationAPIServices, ILogger<DoctorAssessmentController> logger, IHostingEnvironment hostingEnvironment)
        {
            _eSyaNursingStationAPIServices = eSyaNursingStationAPIServices;
            _logger = logger;
            _hostingEnvironment = hostingEnvironment;
        }

        [Area("eSyaNursingStation")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult V_6002_00()
        {
            return View();
        }

        [Area("eSyaNursingStation")]
        public IActionResult V_6002_DA(int UHID, int ipNumber)
        {
            ViewBag.UHID = UHID;
            ViewBag.IpNumber = ipNumber;
            return View();
        }
    }
}