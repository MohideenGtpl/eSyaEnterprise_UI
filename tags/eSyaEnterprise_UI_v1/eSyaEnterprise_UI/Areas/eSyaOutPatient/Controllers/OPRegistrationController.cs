﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace eSyaEnterprise_UI.Areas.eSyaOutPatient.Controllers
{
    public class OPRegistrationController : Controller
    {
       

        [Area("eSyaOutPatient")]
        public IActionResult V_3020_00()
        {
            return View();
        }
    }
}