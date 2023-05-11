using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using eSyaEnterprise_UI.ActionFilter;
using eSyaEnterprise_UI.Areas.Inventory.Data;
using eSyaEnterprise_UI.Areas.Inventory.Models;
using eSyaEnterprise_UI.DataServices;
using eSyaEnterprise_UI.Models;
using eSyaEnterprise_UI.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;
using eSyaEnterprise_UI.Extension;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace eSyaEnterprise_UI.Areas.Inventory.Controllers
{
    [SessionTimeout]
    public class HSNController : Controller
    {
        private readonly IInventoryAPIServices _inventoryAPIServices;
        private readonly ILogger<HSNController> _logger;

        public HSNController(IInventoryAPIServices inventoryAPIServices, ILogger<HSNController> logger)
        {
            _inventoryAPIServices = inventoryAPIServices;
            _logger = logger;
        }

        #region Item HSN Details
        [Area("Inventory")]
        public IActionResult ECI_13_00()
        {
            ViewBag.formName = "Item HSN Details";
            return View();
        }
        #endregion
    }
}