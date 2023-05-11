using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace eSyaEnterprise_UI.Controllers
{
    public class TelehealthConsultationController : Controller
    {
        public IActionResult DoctorWaitingRoom()
        {
            return View();
        }
    }
}