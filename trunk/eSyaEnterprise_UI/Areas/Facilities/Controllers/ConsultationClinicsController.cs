﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using eSyaEnterprise_UI.Areas.Facilities.Data;
using eSyaEnterprise_UI.Areas.Facilities.Models;
using eSyaEnterprise_UI.Utility;
using eSyaEnterprise_UI.ActionFilter;
namespace eSyaEnterprise_UI.Areas.Facilities.Controllers
{
    [SessionTimeout]
    public class ConsultationClinicsController : Controller
    {
        private readonly IFacilityAPIServices _facilityAPIServices;
        private readonly ILogger<ConsultationClinicsController> _logger;

        public ConsultationClinicsController(IFacilityAPIServices facilityAPIServices, ILogger<ConsultationClinicsController> logger)
        {
            _facilityAPIServices = facilityAPIServices;
            _logger = logger;
        }

        #region Clinics & Consultation Types
        [Area("Facilities")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult EFM_05_00()
        {
            try
            {

                var serviceResponse = _facilityAPIServices.HttpClientServices.GetAsync<List<DO_BusinessLocation>>("CommonData/GetBusinessKey").Result;
                if (serviceResponse.Data != null)
                {
                    ViewBag.BusinessLocation = serviceResponse.Data.Select(a => new SelectListItem
                    {
                        Text = a.LocationDescription,
                        Value = a.BusinessKey.ToString()
                    });
                    return View();
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetBusinessLocation");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetBusinessLocation");
                throw ex;
            }
        }

        
        [Produces("application/json")]
        [HttpGet]
        public async Task<JsonResult> GetClinicConsultantTreeList(int businessKey)
        {
            try
            {
                List<jsTreeObject> ClinicConsultantTree = new List<jsTreeObject>();
                jsTreeObject jsObj = new jsTreeObject
                {
                    id = "CL0",
                    parent = "#",
                    text = "Clinics",
                    //icon = "/images/jsTree/foldergroupicon.png",
                    state = new stateObject { opened = true, selected = false, checkbox_disabled = true, disabled = true }
                };
                ClinicConsultantTree.Add(jsObj);

                var clinicResponse = await _facilityAPIServices.HttpClientServices.GetAsync<List<DO_OPClinic>>("Clinic/GetClinicConsultantIdList?businessKey=" + businessKey);
                if (clinicResponse.Status)
                {
                    if (clinicResponse.Data != null)
                    {
                        List<DO_OPClinic> clinic_list = clinicResponse.Data.Select(x => new DO_OPClinic { ConsultationId = x.ConsultationId, ConsultationDesc = x.ConsultationDesc }).GroupBy(y => y.ConsultationId, (key, grp) => grp.FirstOrDefault()).ToList();
                        foreach (DO_OPClinic cl in clinic_list)
                        {
                            jsObj = new jsTreeObject
                            {
                                id = cl.ConsultationId.ToString(),
                                text = cl.ConsultationDesc.ToString(),
                                //icon = "/images/jsTree/openfolder.png",
                                parent = "CL0",
                                state = new stateObject { opened = true, selected = false, checkbox_disabled = true, disabled = true },
                            };
                            ClinicConsultantTree.Add(jsObj);
                        }

                        var conusltant_list = clinicResponse.Data;
                        foreach (var co in conusltant_list.Where(w => conusltant_list.Any(f => f.ClinicId == w.ClinicId)))
                        {
                            jsObj = new jsTreeObject
                            {
                                text = co.ClinicDesc,
                                parent = co.ConsultationId.ToString()
                            };
                            if (co.BusinessKey > 0)
                            {
                                jsObj.id = co.ConsultationId.ToString() + "_" + "Y" + "_" + co.ClinicId;
                                //jsObj.icon = "/images/jsTree/checkedstate.jpg";
                                if (co.ActiveStatus)
                                    jsObj.state = new stateObject { opened = true, selected = true, Checked = true };
                                else
                                    jsObj.state = new stateObject { opened = true, selected = false, Checked = false };
                            }
                            else
                            {
                                jsObj.id = co.ConsultationId.ToString() + "_" + "N" + "_" + co.ClinicId;
                                //jsObj.icon = "/images/jsTree/fileIcon.png";
                                jsObj.state = new stateObject { opened = true, selected = false, Checked = false };
                            }

                            ClinicConsultantTree.Add(jsObj);
                        }
                    }

                    return Json(ClinicConsultantTree);
                }
                else
                {
                    _logger.LogError(new Exception(clinicResponse.Message), "UD:GetClinicConsultantTreeList");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Insert / Update OP Clinic
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertUpdateOPClinicLink(List<DO_OPClinic> op_cl)
        {
            try
            {
                op_cl.All(c =>
                {
                    c.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                    c.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                    c.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                    return true;
                });

                var Insertresponse = await _facilityAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Clinic/InsertUpdateOPClinicLink", op_cl);
                if (Insertresponse.Status)
                    return Json(Insertresponse.Data);
                else
                {
                    _logger.LogError(new Exception(Insertresponse.Message), "UD:InsertUpdateOPClinicLink:params:" + JsonConvert.SerializeObject(op_cl));
                    return Json(new DO_ReturnParameter() { Status = false, Message = Insertresponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertUpdateOPClinicLink:params:" + JsonConvert.SerializeObject(op_cl));
                return Json(new { Status = false, Message = ex.ToString() });
            }
        }
        #endregion
    }
}