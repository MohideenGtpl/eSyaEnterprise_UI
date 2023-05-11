using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eSyaEnterprise_UI.Controllers
{
    [AllowAnonymous]
    public class KeepAliveController : Controller
    {
        //
        // GET: /KeepAlive
        [AllowAnonymous]
        public ActionResult Index()
        {
            return Content("Stay Connected!");
        }
    }
}