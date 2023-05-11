using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eSyaEnterprise_UI.ActionFilter;
using eSyaEnterprise_UI.Areas.eSyaClinicalServices.Models;
using eSyaEnterprise_UI.Areas.eSyaClinicalServices.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Rendering;
using eSyaEnterprise_UI.Utility;
using Newtonsoft.Json;

namespace eSyaEnterprise_UI.Areas.eSyaClinicalServices.Controllers
{
    [SessionTimeout]
    public class ClinicDoctorLinkController : Controller
    {
        private readonly IeSyaClinicalAPIServices _eSyaClinicalAPIServices;
        private readonly ILogger<ClinicsController> _logger;

        public ClinicDoctorLinkController(IeSyaClinicalAPIServices eSyaClinicalAPIServices, ILogger<ClinicsController> logger)
        {
            _eSyaClinicalAPIServices = eSyaClinicalAPIServices;
            _logger = logger;
        }

        [Area("eSyaClinicalServices")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult V_312_00()
        {
            try
            {
                var serviceResponse = _eSyaClinicalAPIServices.HttpClientServices.GetAsync<List<DO_BusinessLocation>>("CommonData/GetBusinessKey").Result;
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

        /// <summary>
        /// Get Specialty List By Business Key
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetSpecialtyListForBusinessKey(int businessKey)
        {
            try
            {
                var response = await _eSyaClinicalAPIServices.HttpClientServices.GetAsync<List<DO_SpecialtyClinicLink>>("Specialty/GetSpecialtyListForBusinessKey?businessKey=" + businessKey);
                if (response.Status)
                {
                    return Json(response.Data);
                }
                else
                {
                    _logger.LogError(new Exception(response.Message), "UD:GetSpecialtyListForBusinessKey");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetSpecialtyListForBusinessKey:For BusinessKey {0}", businessKey);
                throw ex;
            }
        }

        /// <summary>
        ///Get Doctor Code for Tree View
        /// </summary>
        [Produces("application/json")]
        [HttpGet]
        public async Task<JsonResult> GetSpecialtyDoctorLinkTree(int businessKey, int specialtyId)
        {
            try
            {
                var response = await _eSyaClinicalAPIServices.HttpClientServices.GetAsync<List<DO_SpecialtyDoctorLink>>("Specialty/GetDoctorListByBKeySpecialtyId?businessKey=" + businessKey + "&specialtyId=" + specialtyId);
                if (response.Status)
                {
                    List<jsTreeObject> DoctorTree = new List<jsTreeObject>();

                    jsTreeObject obj;
                    //obj = new jsTreeObject
                    //{
                    //    id = "H0",
                    //    parent = "#",
                    //    text = "Doctor Names",
                    //    icon = "/images/jsTree/foldergroupicon.png",
                    //    state = new stateObject { opened = true, selected = false }
                    //};

                    //DoctorTree.Add(obj);

                    if (response.Data != null)
                    {
                        foreach (DO_SpecialtyDoctorLink lst in response.Data)
                        {
                            obj = new jsTreeObject
                            {
                                id = "DR" + lst.DoctorID.ToString(),
                                parent = "#",
                                text = lst.DoctorName,
                                icon = "/images/jsTree/fileIcon.png"
                            };

                            DoctorTree.Add(obj);
                        }
                    }
                    return Json(DoctorTree);
                }
                else
                {
                    _logger.LogError(new Exception(response.Message), "UD:GetSpecialtyDoctorLinkTree:For BusinessKey {0} with specialtyId entered {1}", businessKey, specialtyId);
                    return Json(new { Status = false, StatusCode = "500" });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetSpecialtyDoctorLinkTree:For BusinessKey {0} with specialtyId entered {1}", businessKey, specialtyId);
                throw ex;
            }
        }

        //[Produces("application/json")]
        //[HttpGet]
        //public async Task<JsonResult> GetClinicConsultantTreeList(int businessKey, int specialtyId, int doctorId)
        //{
        //    try
        //    {
        //        List<jsTreeObject> ClinicConsultantTree = new List<jsTreeObject>();

        //        jsTreeObject jsObj = new jsTreeObject
        //        {
        //            id = "CL0",
        //            parent = "#",
        //            text = "Clinics",
        //            //icon = "/images/jsTree/foldergroupicon.png",
        //            state = new stateObject { opened = true, selected = false, checkbox_disabled = true, disabled = true }
        //        };
        //        ClinicConsultantTree.Add(jsObj);

        //        var clinicResponse = await _eSyaClinicalAPIServices.HttpClientServices.GetAsync<List<DO_DoctorClinic>>("Clinic/GetDoctorClinicLinkList?businessKey=" + businessKey + "&specialtyId=" + specialtyId + "&doctorId=" + doctorId);
        //        if (clinicResponse.Status)
        //        {
        //            if (clinicResponse.Data != null)
        //            {
        //                List<DO_OPClinic> clinic_list = clinicResponse.Data.Select(x => new DO_OPClinic { ClinicId = x.ClinicId, ClinicDesc = x.ClinicDesc }).GroupBy(y => y.ClinicId, (key, grp) => grp.FirstOrDefault()).ToList();
        //                foreach (DO_OPClinic cl in clinic_list)
        //                {
        //                    jsObj = new jsTreeObject
        //                    {
        //                        id = cl.ClinicId.ToString(),
        //                        text = cl.ClinicDesc.ToString(),
        //                        //icon = "/images/jsTree/openfolder.png",
        //                        parent = "CL0",
        //                        state = new stateObject { opened = true, selected = false, checkbox_disabled = true, disabled = true },
        //                    };
        //                    ClinicConsultantTree.Add(jsObj);
        //                }

        //                var conusltant_list = clinicResponse.Data;
        //                foreach (var co in conusltant_list.Where(w => conusltant_list.Any(f => f.ClinicId == w.ClinicId)))
        //                {
        //                    jsObj = new jsTreeObject
        //                    {
        //                        text = co.ConsultationDesc,
        //                        parent = co.ClinicId.ToString()
        //                    };
        //                    if (co.BusinessKey > 0)
        //                    {
        //                        jsObj.id = co.ClinicId.ToString() + "_" + "Y" + "_" + co.ConsultationId;
        //                        //jsObj.icon = "/images/jsTree/checkedstate.jpg";
        //                        if (co.ActiveStatus)
        //                            jsObj.state = new stateObject { opened = true, selected = true, Checked = true };
        //                        else
        //                            jsObj.state = new stateObject { opened = true, selected = false, Checked = false };
        //                    }
        //                    else
        //                    {
        //                        jsObj.id = co.ClinicId.ToString() + "_" + "N" + "_" + co.ConsultationId;
        //                        //jsObj.icon = "/images/jsTree/fileIcon.png";
        //                        jsObj.state = new stateObject { opened = true, selected = false, Checked = false };
        //                    }

        //                    ClinicConsultantTree.Add(jsObj);
        //                }
        //            }

        //            return Json(ClinicConsultantTree);
        //        }
        //        else
        //        {
        //            _logger.LogError(new Exception(clinicResponse.Message), "UD:GetClinicConsultantTreeList:For BusinessId {0} , SpecialtyId {1} and DoctorId entered {2}", businessKey, specialtyId,doctorId);
        //            return Json(new { Status = false, StatusCode = "500" });
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, "UD:GetClinicConsultantTreeList:For BusinessId {0} , SpecialtyId {1} and DoctorId entered {2}", businessKey, specialtyId, doctorId);
        //        throw ex;
        //    }
        //}


        [Produces("application/json")]
        [HttpGet]
        public async Task<JsonResult> GetClinicConsultantTreeList(int businessKey, int specialtyId, int doctorId)
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

                var clinicResponse = await _eSyaClinicalAPIServices.HttpClientServices.GetAsync<List<DO_DoctorClinic>>("Clinic/GetDoctorClinicLinkList?businessKey=" + businessKey + "&specialtyId=" + specialtyId + "&doctorId=" + doctorId);
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
                        foreach (var co in conusltant_list.Where(w => conusltant_list.Any(f => f.ConsultationId == w.ConsultationId)))
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
                    _logger.LogError(new Exception(clinicResponse.Message), "UD:GetClinicConsultantTreeList:For BusinessId {0} , SpecialtyId {1} and DoctorId entered {2}", businessKey, specialtyId, doctorId);
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetClinicConsultantTreeList:For BusinessId {0} , SpecialtyId {1} and DoctorId entered {2}", businessKey, specialtyId, doctorId);
                throw ex;
            }
        }



        /// <summary>
        /// Insert / Update Doctor Clinic
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertUpdateDoctorClinicLink(List<DO_DoctorClinic> do_cl)
        {
            try
            {
                do_cl.All(c =>
                {
                    c.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                    c.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                    c.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                    return true;
                });

                var Insertresponse = await _eSyaClinicalAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Clinic/InsertUpdateDoctorClinicLink", do_cl);
                if (Insertresponse.Status)
                    return Json(Insertresponse.Data);
                else
                {
                    _logger.LogError(new Exception(Insertresponse.Message), "UD:InsertUpdateDoctorClinicLink:params:" + JsonConvert.SerializeObject(do_cl));
                    return Json(new DO_ReturnParameter() { Status = false, Message = Insertresponse.Message });
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertUpdateDoctorClinicLink:params:" + JsonConvert.SerializeObject(do_cl));
                throw ex;
            }
        }
    }
}