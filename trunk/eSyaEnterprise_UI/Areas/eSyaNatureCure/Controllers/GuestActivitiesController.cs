﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace eSyaEnterprise_UI.Areas.eSyaNatureCure.Controllers
{
    public class GuestActivitiesController : Controller
    {
        
        [Area("eSyaNatureCure")]
        public IActionResult V_ENC_08_00()
        {
            return View();
        }
        
        
    }
}