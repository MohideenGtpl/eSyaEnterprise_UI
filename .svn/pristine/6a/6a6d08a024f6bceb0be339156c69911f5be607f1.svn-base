using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eSyaEnterprise_UI.Areas.eSyaNatureCure.Data;
using eSyaEnterprise_UI.Areas.eSyaNatureCure.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace eSyaEnterprise_UI.Areas.eSyaNatureCure.Controllers
{
    public class ReportsController : Controller
    {
        private readonly IeSyaNatureCureAPIServices _eSyaNatureCureAPIServices;
        private readonly ILogger<ReportsController> _logger;

        public ReportsController(IeSyaNatureCureAPIServices eSyaNatureCureAPIServices, ILogger<ReportsController> logger)
        {
            _eSyaNatureCureAPIServices = eSyaNatureCureAPIServices;
            _logger = logger;
        }

        [Area("eSyaNatureCure")]
        public IActionResult V_ENC_50_00()
        {
            return View();
        }

        [Area("eSyaNatureCure")]
        public async Task<IActionResult> V_ENC_51_00()
        {
            var roomtypeResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<List<DO_RoomType>>("RoomType/GetActiveRoomTypes");
            ViewBag.RoomTypes = new List<DO_RoomType>();
            if (roomtypeResponse.Status)
            {
                ViewBag.RoomTypes = roomtypeResponse.Data;
            }

            return View();
        }
    }
}