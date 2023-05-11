using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using eSyaEnterprise_UI.ActionFilter;
using eSyaEnterprise_UI.Areas.Stores.Data;
using eSyaEnterprise_UI.Areas.Stores.Models;
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

namespace eSyaEnterprise_UI.Areas.Stores.Controllers
{
    [SessionTimeout]
    public class FormLinkController : Controller
    {
        private readonly IStoreAPIServices _storeAPIServices;
        private readonly ILogger<FormLinkController> _logger;

        public FormLinkController(IStoreAPIServices storeAPIServices, ILogger<FormLinkController> logger)
        {
            _storeAPIServices = storeAPIServices;
            _logger = logger;
        }
        #region Store_Form_Link

        [Area("Stores")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult ECI_02_00()
        {

            return View();
        }

        public JsonResult GetFormForStorelinking()
        {
            try
            {
                List<jsTreeObject> treeView = new List<jsTreeObject>();

                string baseURL = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}";

                jsTreeObject jsObj = new jsTreeObject
                {
                    id = "FM",
                    parent = "#",
                    text = "eSya Forms",
                    icon = baseURL + "/images/jsTree/foldergroupicon.png",
                    state = new stateObject { opened = true, selected = false }
                };
                treeView.Add(jsObj);

                var serviceResponse1 = _storeAPIServices.HttpClientServices.GetAsync<List<DO_Forms>>("StoreMaster/GetFormForStorelinking").Result;
                if (serviceResponse1.Status)
                {
                    foreach (var fm in serviceResponse1.Data)
                    {
                        jsObj = new jsTreeObject
                        {
                            id = fm.FormID.ToString(),
                            text = fm.FormCode.ToString() + '.' + fm.FormName,
                            icon = baseURL + "/images/jsTree/openfolder.png",
                            parent = "FM"
                        };
                        treeView.Add(jsObj);
                    }
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse1.Message), "UD:GetFormList");
                }

                return Json(treeView);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetFormList");
                throw ex;
            }
        }


        public JsonResult GetFormForStorelinkin1g()
        {
            try
            {
                var serviceResponse = _storeAPIServices.HttpClientServices.GetAsync<List<DO_StoreFormLink>>("StoreMaster/GetFormForStorelinking").Result;
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetFormForStorelinking");
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetFormForStorelinking");
                throw ex;
            }
        }

        public JsonResult GetStoreFormLinked(int formId)
        {
            try
            {
                var serviceResponse = _storeAPIServices.HttpClientServices.GetAsync<List<DO_StoreMaster>>("StoreMaster/GetStoreFormLinked?formId=" + formId).Result;
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetStoreFormLinked:params:formId:" + formId.ToString());
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetStoreFormLinked:params:formId:" + formId.ToString());
                throw ex;
            }
        }

        [HttpPost]
        public JsonResult InsertIntoFormStoreLink(List<DO_StoreFormLink> l_obj)
        {
            try
            {
                if (l_obj.Count == 0)
                {
                    return Json(new DO_ReturnParameter() { Status = false, Message = "No Record" });
                }
                else
                {
                    l_obj.All(c =>
                    {
                        c.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                        c.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                        return true;
                    });

                    var serviceResponse = _storeAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("StoreMaster/InsertIntoFormStoreLink", l_obj).Result;
                    if (serviceResponse.Status)
                        return Json(serviceResponse.Data);
                    else
                    {
                        _logger.LogError(serviceResponse.Message, "UD:InsertIntoFormStoreLink:Params:" + JsonConvert.SerializeObject(l_obj));
                        return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertIntoFormStoreLink:Params:" + JsonConvert.SerializeObject(l_obj));
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        #endregion  Store_Form_Link
    }
}