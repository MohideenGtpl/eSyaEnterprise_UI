using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using eSyaEnterprise_UI.Areas.Config.Data;
using eSyaEnterprise_UI.Areas.Config.Models;
//using eSyaEnterprise_UI.Areas.Config.Resources;
using eSyaEnterprise_UI.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using Newtonsoft.Json;

using System.Security.Claims;
using eSyaEnterprise_UI.DataServices;
using eSyaEnterprise_UI.Extension;
using eSyaEnterprise_UI.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace eSyaEnterprise_UI.Areas.Config.Controllers
{
    public class CommonController : Controller
    {
        private readonly IeSyaConfigAPIServices _eSyaConfigAPIServices;
        private readonly IStringLocalizer _localizer;
        public CommonController(IeSyaConfigAPIServices eSyaConfigAPIServices, IStringLocalizerFactory factory)
        {
            _eSyaConfigAPIServices = eSyaConfigAPIServices;
            //_localizer = localizer;

            //var type = typeof(CommonController);
            //var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
            //_localizer = factory.Create(type.FullName, assemblyName.Name);
            //string str = _localizer["Hello"];
        }


        [Area("eSyaConfig")]
        public IActionResult Index()
        {
            var area = ControllerContext.ActionDescriptor.RouteValues["area"];
            var actionName = ControllerContext.ActionDescriptor.ActionName;
            var controllerName = ControllerContext.ActionDescriptor.ControllerName;

            return View();
        }

        ESyaWebAPI _eSyaWebAPI = new ESyaWebAPI();
        public JsonResult GetApplicationCode()
        {
            List<int> l_ac = new List<int>();
            l_ac.Add(1);
            l_ac.Add(2);
            var serviceResponse = _eSyaConfigAPIServices.HttpClientServices.PostAsJsonAsync<List<DO_ApplicationCodes>>("ConfigMasterData/GetApplicationCodesByCodeType", l_ac).Result;
            return Json(serviceResponse.Data);

            // HttpResponseMessage response = _eSyaConfigAPIServices.GetHttpClient().PostAsJsonAsync("ConfigMasterData/GetApplicationCodesByCodeTypeList", l_ac).Result;
            // string data = response.Content.ReadAsStringAsync().Result;
            // List<DO_ApplicationCodes> utapp_codes = JsonConvert.DeserializeObject<List<DO_ApplicationCodes>>(data);
            //return Json(utapp_codes);
        }

        public JsonResult ChangeCultureFormat(string cultureFormat, DateTime dtDatePicker)
        {

            var rqf = Request.HttpContext.Features.Get<IRequestCultureFeature>();
            var culture = rqf.RequestCulture.Culture;

            //CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            //var cultureInfo = Thread.CurrentThread.CurrentCulture.Clone() as CultureInfo;

            culture.ClearCachedData();
            rqf.RequestCulture.UICulture.ClearCachedData();

            var cultureInfo = new RequestCulture(cultureFormat);
            //var dateformat = new DateTimeFormatInfo
            //{
            //    ShortDatePattern = "MM-dd-yyyy",
            //    LongDatePattern = "MM-dd-yyyy hh:mm:ss tt"
            //};
            //cultureInfo.Culture.DateTimeFormat = dateformat;
            //Thread.CurrentThread.CurrentCulture = cultureInfo.Culture;
            //Thread.CurrentThread.CurrentUICulture = cultureInfo.UICulture;

            //CultureInfo.DefaultThreadCurrentUICulture = cultureInfo.Culture;
            //CultureInfo.DefaultThreadCurrentCulture = cultureInfo.UICulture;

            CultureInfo newCulture = (CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            newCulture.DateTimeFormat.ShortDatePattern = "MM-dd-yyyy";
            newCulture.DateTimeFormat.DateSeparator = "-";
            Thread.CurrentThread.CurrentCulture = newCulture;

            Response.Cookies.Append(
      CookieRequestCultureProvider.DefaultCookieName,
      CookieRequestCultureProvider.MakeCookieValue(cultureInfo),
            new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );

            return Json(new { Status = true });
        }

        [Area("eSyaConfig")]
        public IActionResult PageView()
        {
            return View();
        }

    }

    public class JSTree
    {
        public bool _checked {get;set;}
    }



}