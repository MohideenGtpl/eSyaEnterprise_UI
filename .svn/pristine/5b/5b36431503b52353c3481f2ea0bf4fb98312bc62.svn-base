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
    public class ClinicsController : Controller
    {
        private readonly IeSyaClinicalAPIServices _eSyaClinicalAPIServices;
        private readonly ILogger<ClinicsController> _logger;

        public ClinicsController(IeSyaClinicalAPIServices eSyaClinicalAPIServices, ILogger<ClinicsController> logger)
        {
            _eSyaClinicalAPIServices = eSyaClinicalAPIServices;
            _logger = logger;
        }

        [Area("eSyaClinicalServices")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult V_311_00()
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

        //[Produces("application/json")]
        //[HttpGet]
        //public async Task<JsonResult> GetClinicConsultantTreeList(int businessKey)
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

        //        var clinicResponse = await _eSyaClinicalAPIServices.HttpClientServices.GetAsync<List<DO_OPClinic>>("Clinic/GetClinicConsultantIdList?businessKey=" + businessKey);
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
        //            _logger.LogError(new Exception(clinicResponse.Message), "UD:GetClinicConsultantTreeList");
        //            return Json(new { Status = false, StatusCode = "500" });
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
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

                var clinicResponse = await _eSyaClinicalAPIServices.HttpClientServices.GetAsync<List<DO_OPClinic>>("Clinic/GetClinicConsultantIdList?businessKey=" + businessKey);
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

                var Insertresponse = await _eSyaClinicalAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>("Clinic/InsertUpdateOPClinicLink", op_cl);
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

        [Area("eSyaClinicalServices")]
        [ServiceFilter(typeof(ViewBagActionFilter))]
        public IActionResult V_313_00()
        {
            try
            {
                var serviceResponseBLocation = _eSyaClinicalAPIServices.HttpClientServices.GetAsync<List<DO_BusinessLocation>>("CommonData/GetBusinessKey").Result;
                if (serviceResponseBLocation.Data != null)
                {
                    ViewBag.BusinessLocation = serviceResponseBLocation.Data.Select(a => new SelectListItem
                    {
                        Text = a.LocationDescription,
                        Value = a.BusinessKey.ToString()
                    });
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponseBLocation.Message), "UD:GetBusinessLocation");
                    return Json(new { Status = false, StatusCode = "500" });
                }

                var serviceResponse = _eSyaClinicalAPIServices.HttpClientServices.GetAsync<List<DO_ApplicationCodes>>("CommonData/GetApplicationCodesByCodeType?codeType=" + Areas.eSyaClinicalServices.Data.CodeTypeValues.FloorId).Result;
                if (serviceResponse.Data != null)
                {
                    ViewBag.Floor = serviceResponse.Data.Select(a => new SelectListItem
                    {
                        Text = a.CodeDesc,
                        Value = a.ApplicationCode.ToString()
                    });
                    return View();
                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetApplicationCodesByCodeType");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetApplicationCodesByCodeType");
                throw ex;
            }
        }

        /// <summary>
        ///Get Clinic Room Master
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> GetClinicRoomListByBKeyFloorId(int businessKey, int floorId)
        {
            try
            {
                var serviceResponse = await _eSyaClinicalAPIServices.HttpClientServices.GetAsync<List<DO_ClinicRoom>>("Clinic/GetClinicRoomListByBKeyFloorId?businessKey=" + businessKey + "&floorId=" + floorId);
                if (serviceResponse.Status)
                {
                    return Json(serviceResponse.Data);

                }
                else
                {
                    _logger.LogError(new Exception(serviceResponse.Message), "UD:GetClinicRoomListByBKeyFloorId");
                    return Json(new { Status = false, StatusCode = "500" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:GetClinicRoomListByBKeyFloorId");
                return Json(new DO_ReturnParameter() { Status = false, Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message });
            }
        }

        /// <summary>
        ///Insert Or Update Clinic Room Master
        /// </summary>
        [HttpPost]
        public async Task<JsonResult> InsertUpdateIntoClinicRoomMaster(DO_ClinicRoom postData)
        {
            try
            {
                postData.UserID = AppSessionVariables.GetSessionUserID(HttpContext);
                postData.TerminalID = AppSessionVariables.GetIPAddress(HttpContext);
                postData.FormId = AppSessionVariables.GetSessionFormInternalID(HttpContext);
                string URL = "Clinic/InsertIntoClinicRoomMaster";
                if(postData.UserOperation == "edit")
                    URL = "Clinic/UpdateClinicRoomMaster";

                var serviceResponse = await _eSyaClinicalAPIServices.HttpClientServices.PostAsJsonAsync<DO_ReturnParameter>(URL, postData);
                if (serviceResponse.Status)
                    return Json(serviceResponse.Data);
                else
                    return Json(new DO_ReturnParameter() { Status = false, Message = serviceResponse.Message });

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UD:InsertIntoClinicRoomMaster:params:" + JsonConvert.SerializeObject(postData));
                return Json(new { Status = false, Message = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.Message });
            }
        }

    }
}