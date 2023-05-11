using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eSyaEnterprise_UI.ActionFilter;
using eSyaEnterprise_UI.Areas.eSyaNatureCure.Data;
using eSyaEnterprise_UI.Areas.eSyaNatureCure.Models;
using eSyaEnterprise_UI.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace eSyaEnterprise_UI.Areas.eSyaNatureCure.Controllers
{
    [SessionTimeout]
    public class BedTransferController : Controller
    {
        private readonly IeSyaNatureCureAPIServices _eSyaNatureCureAPIServices;
        private readonly ILogger<BedTransferController> _logger;

        public BedTransferController(IeSyaNatureCureAPIServices eSyaNatureCureAPIServices, ILogger<BedTransferController> logger)
        {
            _eSyaNatureCureAPIServices = eSyaNatureCureAPIServices;
            _logger = logger;
        }

        [Area("eSyaNatureCure")]
        public async Task<IActionResult> V_ENC_06_00(long bookingKey, int guestId)
        {
            ViewBag.BookingKey = bookingKey;
            ViewBag.GuestId = guestId;

            var parameter = "?businessKey=" + AppSessionVariables.GetSessionBusinessKey(HttpContext);
            parameter += "&bookingKey=" + bookingKey;
            parameter += "&guestId=" + guestId;
            var serviceResponse = await _eSyaNatureCureAPIServices.HttpClientServices.GetAsync<DO_GuestCheckInDetails>("GuestCheckIn/GetGuestDetailById" + parameter);
            return View(serviceResponse.Data);
        }

    }
}