#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientClinicalForms\FacilityStay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a0d19c9529938484fcbc8a73e22937dcf2a0fc0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_eSyaOutPatient_Views_PatientClinicalForms_FacilityStay), @"mvc.1.0.view", @"/Areas/eSyaOutPatient/Views/PatientClinicalForms/FacilityStay.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/eSyaOutPatient/Views/PatientClinicalForms/FacilityStay.cshtml", typeof(AspNetCore.Areas_eSyaOutPatient_Views_PatientClinicalForms_FacilityStay))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a0d19c9529938484fcbc8a73e22937dcf2a0fc0", @"/Areas/eSyaOutPatient/Views/PatientClinicalForms/FacilityStay.cshtml")]
    public class Areas_eSyaOutPatient_Views_PatientClinicalForms_FacilityStay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/material.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/eSyaOutPatient/outPatient.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/eSyaOutPatient/PatientClinicalForms/facilitystay.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/material.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientClinicalForms\FacilityStay.cshtml"
  
    ViewData["Title"] = "Facility Stay Form";
    if (ViewBag.IsApp == "Y")
    {
        Layout = "~/Views/Shared/_Layout_m.cshtml";

#line default
#line hidden
            BeginContext(144, 87, true);
            WriteLiteral("      <link href = \"~/css/eSyaOutPatient/jqgrid_outPatient.css\" rel = \"stylesheet\" />\r\n");
            EndContext();
#line 8 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientClinicalForms\FacilityStay.cshtml"
    }
    else
    {
        Layout = "~/Views/Shared/_Layout.cshtml";
    }

#line default
#line hidden
            BeginContext(316, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(318, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1a0d19c9529938484fcbc8a73e22937dcf2a0fc05769", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(373, 3, true);
            WriteLiteral(" \r\n");
            EndContext();
            BeginContext(376, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1a0d19c9529938484fcbc8a73e22937dcf2a0fc07022", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(444, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(463, 12, true);
                WriteLiteral("\r\n    \r\n    ");
                EndContext();
                BeginContext(475, 80, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a0d19c9529938484fcbc8a73e22937dcf2a0fc08461", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(555, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(561, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a0d19c9529938484fcbc8a73e22937dcf2a0fc09714", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(605, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            BeginContext(612, 760, true);
            WriteLiteral(@"


<style>
    .lblCheck{
        display:flex;align-items:center;
    }
    label span{
        padding-left:5px;
    }
    /*.ui-jqgrid .ui-jqgrid-bdiv {
        overflow-x: auto;
    }*/
    
    .ui-jqgrid .ui-jqgrid-bdiv {
        /*position: relative;
        margin: 0;
        padding: 0;*/
        overflow: auto;
        text-align: left;
    }

    .ui-state-default ui-th-column-header ui-th-ltr {
        background: #555 !important;
        color: bisque !important;
    }

    .ui-jqgrid .ui-jqgrid-htable th {
        background: #555 !important;
        color: gold !important;
    }

    .jqg-first-row-header {
        visibility: collapse !important;
    }
</style>


<input type=""hidden"" id=""hdAppKey""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1372, "\"", 1395, 1);
#line 61 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientClinicalForms\FacilityStay.cshtml"
WriteAttributeValue("", 1380, ViewBag.AppKey, 1380, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1396, 37, true);
            WriteLiteral(" />\r\n<input type=\"hidden\" id=\"hdUHID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1433, "\"", 1454, 1);
#line 62 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientClinicalForms\FacilityStay.cshtml"
WriteAttributeValue("", 1441, ViewBag.UHID, 1441, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1455, 2000, true);
            WriteLiteral(@" />


<div class=""divFixedBar"">
    <div class=""row mr-0"">
        <div class=""col-xl-4 col-lg-6 col-md-6 col-sm-12 col-xs-12 d-flex align-items-center"">

            <div>
                <p><span class=""labelname""><i class=""fas fa-chevron-right c-lightgrey""></i> MRN:</span> <span id=""lblPatientID""></span>&nbsp;<span class=""labelname""> Patient Name:</span><span id=""lblPatientName""></span></p>
                <p><span class=""labelname""><i class=""fas fa-chevron-right c-lightgrey""></i> Surgery:</span><span id=""lblSurgery""></span>&nbsp;<span class=""labelname""> Date:</span><span id=""lblSurgeryDate""></span></p>
            </div>
        </div>
        <div class=""col-xl-4 col-lg-6 col-md-6 col-sm-12 col-xs-12 d-flex align-items-center"">

            <div>
                <p><span class=""labelname""><i class=""fas fa-chevron-right c-lightgrey""></i> Email:</span><span id=""lblEmail""></span>&nbsp;<span class=""labelname""> Tel:</span><span id=""lblTel""></span></p>
                <p><span class=""labelname""");
            WriteLiteral(@"><i class=""fas fa-chevron-right c-lightgrey""></i> Approach:</span><span id=""lblApproach""></span>&nbsp;<span class=""labelname""> Anesthesia:</span><span id=""lblAnesthesia""></span></p>

            </div>
        </div>
        <div class=""col-xl-2 col-lg-6 col-md-6 col-sm-12 col-xs-12 d-flex align-items-center"">

            <div>
                <p><span class=""labelname""><i class=""fas fa-chevron-right c-lightgrey""></i> Gender:</span><span id=""lblGender""></span>&nbsp;&nbsp;<span class=""labelname""> Age:</span><span id=""lblAge""></span></p>
                <p><span class=""labelname""><i class=""fas fa-chevron-right c-lightgrey""></i> Weight:</span><span id=""lblBMI""></span></p>
            </div>
        </div>

        <div id=""floatButtons"" class=""col-xl-2 col-lg-12 text-right p-0"">
            <button class=""mdl-button"" id=""btnSaveFacilityStay"" onclick=""fnSaveFacilityStay()""><i class=""far fa-save c-green""></i> <span class=""btntext"">Save</span></button>
");
            EndContext();
#line 93 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientClinicalForms\FacilityStay.cshtml"
             if (ViewBag.IsApp != "Y")
            {

#line default
#line hidden
            BeginContext(3691, 151, true);
            WriteLiteral("                <button class=\"mdl-button\" id=\"btnBackNS\" onclick=\"fnBack()\"><i class=\"fas fa-times\"></i> <span class=\"btntext\">Close</span></button>\r\n");
            EndContext();
#line 96 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientClinicalForms\FacilityStay.cshtml"
            }

#line default
#line hidden
            BeginContext(3857, 15131, true);
            WriteLiteral(@"

        </div>
    </div>
</div>

<div class=""row"" style=""margin-right: 0px !important;"">
    <div class=""col-lg-3 col-md-3 col-sm-3 sidebar"" id=""navbar-preoperative"">
        <div class=""sidebar-sticky"">
            <ul class=""nav flex-column"" id=""nav_menu"">
                <li><a href=""#"" id=""v-fs-tab"" data-bs-toggle=""pill"" data-bs-target=""#v-fs"" class=""nav-link active"" role=""tab"" aria-controls=""v-fs"" aria-selected=""true"">Facility Stay</a></li>
               </ul>
        </div>
    </div>
    <div class="""" id=""mainContent"">
        <div class=""tab-content"" id=""v-pills-tabContent"">

            <div class=""tab-pane fade show active"" id=""v-fs"" role=""tabpanel"" aria-labelledby=""v-po-tab"">
                <div class=""row"">
                    <div class=""col-12 p-0"">
                        <h6 class=""main-heading""><i class=""fa fa-bars mr-10""></i>Facility Stay</h6>
                    </div>
                </div>
                <div class=""row mr-0 divContent"" style=""margin-right:0px");
            WriteLiteral(@";"">
                    <div class=""col-lg-12 col-md-12 col-sm-12 pr-0 mb-2 divNursingCarePlan"">
                        <div id=""dvFacilityStayTemplate""></div>
                    </div>
                    <div class=""col-lg-12 col-md-12 col-sm-12 pr-0 mb-2 divNursingCarePlan"">
                        <div id=""dvFacilityStayDetailsTemplate""></div>
                    </div>
                </div>
            </div>


        </div>
    </div>
</div>

<div class=""modal fade in"" id=""PopupMedications"" data-keyboard=""false"" data-backdrop=""static"">
    <div class=""modal-dialog modal-lg"" role=""document"" style=""box-shadow:none;"">
        <div class=""modal-content"">
            <div class=""modal-header popupHeader"">
                <button type=""button"" class=""close ml-auto"" data-dismiss=""modal""> <i class=""fa fa-times""></i></button>
                <h4 class=""modal-title"">Medications</h4>
            </div>

            <div class=""modal-body"">
                <div class=""row"" hidden>
     ");
            WriteLiteral(@"               <div class=""col-sm-6"">
                        <div class=""form-group"">
                            <label>Date</label>
                            <input class=""form-control datepicker"" type=""text"" maxlength=""8"" id=""dpMedicationsDate"" />
                        </div>
                    </div>
                    <div class=""col-sm-6"">
                        <div class=""form-group"">
                            <label>Time</label>
                            <input class=""form-control timepicker"" type=""time"" maxlength=""8"" id=""tpMedicationsTime"" />
                        </div>
                    </div>
                </div>
                <div id=""dvMedications""></div>
            </div>
            <div class=""modal-footer"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <button class=""mdl-button ""
                                id=""btnSaveMedications"" onclick=""saveMedications()"">
                            <i c");
            WriteLiteral(@"lass=""fa fa-save""></i> Save
                        </button>
                        <button class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect  cancel-button cancel-button"" data-dismiss=""modal""><i class=""fa fa-times""></i> Cancel </button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""modal fade in"" id=""PopupInvestigations"" data-keyboard=""false"" data-backdrop=""static"">
    <div class=""modal-dialog modal-lg"" role=""document"" style=""box-shadow:none;"">
        <div class=""modal-content"">
            <div class=""modal-header popupHeader"">
                <button type=""button"" class=""close ml-auto"" data-dismiss=""modal""> <i class=""fa fa-times""></i></button>
                <h4 class=""modal-title"">Investigations</h4>
            </div>

            <div class=""modal-body"">
                <div class=""row"" hidden>
                    <div class=""col-sm-6"">
                        <div class=""form-group"">
    ");
            WriteLiteral(@"                        <label>Date</label>
                            <input class=""form-control datepicker"" type=""text"" maxlength=""8"" id=""dpInvestigationsDate"" />
                        </div>
                    </div>
                    <div class=""col-sm-6"">
                        <div class=""form-group"">
                            <label>Time</label>
                            <input class=""form-control timepicker"" type=""time"" maxlength=""8"" id=""tpInvestigationsTime"" />
                        </div>
                    </div>
                </div>
                <div id=""dvInvestigations""></div>
            </div>
            <div class=""modal-footer"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <button class=""mdl-button ""
                                id=""btnSaveInvestigations"" onclick=""saveInvestigations()"">
                            <i class=""fa fa-save""></i> Save
                        </button>
              ");
            WriteLiteral(@"          <button class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect  cancel-button cancel-button"" data-dismiss=""modal""><i class=""fa fa-times""></i> Cancel </button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""modal fade in"" id=""PopupInterventions"" data-keyboard=""false"" data-backdrop=""static"">
    <div class=""modal-dialog modal-lg"" role=""document"" style=""box-shadow:none;"">
        <div class=""modal-content"">
            <div class=""modal-header popupHeader"">
                <button type=""button"" class=""close ml-auto"" data-dismiss=""modal""> <i class=""fa fa-times""></i></button>
                <h4 class=""modal-title"">Interventions</h4>
            </div>

            <div class=""modal-body"">
                <div class=""row"" hidden>
                    <div class=""col-sm-6"">
                        <div class=""form-group"">
                            <label>Date</label>
                            <input ");
            WriteLiteral(@"class=""form-control datepicker"" type=""text"" maxlength=""8"" id=""dpInterventionsDate"" />
                        </div>
                    </div>
                    <div class=""col-sm-6"">
                        <div class=""form-group"">
                            <label>Time</label>
                            <input class=""form-control timepicker"" type=""time"" maxlength=""8"" id=""tpInterventionsTime"" />
                        </div>
                    </div>
                </div>
                <div id=""dvInterventions""></div>
            </div>
            <div class=""modal-footer"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <button class=""mdl-button ""
                                id=""btnSaveInterventions"" onclick=""saveInterventions()"">
                            <i class=""fa fa-save""></i> Save
                        </button>
                        <button class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-ef");
            WriteLiteral(@"fect  cancel-button cancel-button"" data-dismiss=""modal""><i class=""fa fa-times""></i> Cancel </button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""modal fade in"" id=""PopupProgressNotes"" data-keyboard=""false"" data-backdrop=""static"">
    <div class=""modal-dialog modal-lg"" role=""document"" style=""box-shadow:none;"">
        <div class=""modal-content"">
            <div class=""modal-header popupHeader"">
                <button type=""button"" class=""close ml-auto"" data-dismiss=""modal""> <i class=""fa fa-times""></i></button>
                <h4 class=""modal-title"">Progress Notes</h4>
            </div>

            <div class=""modal-body"">
                <div class=""row"" hidden>
                    <div class=""col-sm-6"">
                        <div class=""form-group"">
                            <label>Date</label>
                            <input class=""form-control datepicker"" type=""text"" maxlength=""8"" id=""dpProgressNotesDate"" /");
            WriteLiteral(@">
                        </div>
                    </div>
                    <div class=""col-sm-6"">
                        <div class=""form-group"">
                            <label>Time</label>
                            <input class=""form-control timepicker"" type=""time"" maxlength=""8"" id=""tpProgressNotesTime"" />
                        </div>
                    </div>
                </div>
                <div id=""dvProgressNotes""></div>
            </div>
            <div class=""modal-footer"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <button class=""mdl-button ""
                                id=""btnSaveProgressNotes"" onclick=""saveProgressNotes()"">
                            <i class=""fa fa-save""></i> Save
                        </button>
                        <button class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect  cancel-button cancel-button"" data-dismiss=""modal""><i class=""fa fa-times""></i> ");
            WriteLiteral(@"Cancel </button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""modal fade in"" id=""PopupStaples"" data-keyboard=""false"" data-backdrop=""static"">
    <div class=""modal-dialog modal-lg"" role=""document"" style=""box-shadow:none;"">
        <div class=""modal-content"">
            <div class=""modal-header popupHeader"">
                <button type=""button"" class=""close ml-auto"" data-dismiss=""modal""> <i class=""fa fa-times""></i></button>
                <h4 class=""modal-title"">Staples</h4>
            </div>

            <div class=""modal-body"">
                <div class=""row"" hidden>
                    <div class=""col-sm-6"">
                        <div class=""form-group"">
                            <label>Date</label>
                            <input class=""form-control datepicker"" type=""text"" maxlength=""8"" id=""dpStaplesDate"" />
                        </div>
                    </div>
                    <div class=""col-sm-6");
            WriteLiteral(@""">
                        <div class=""form-group"">
                            <label>Time</label>
                            <input class=""form-control timepicker"" type=""time"" maxlength=""8"" id=""tpStaplesTime"" />
                        </div>
                    </div>
                </div>
                <div id=""dvStaples""></div>
            </div>
            <div class=""modal-footer"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <button class=""mdl-button ""
                                id=""btnSaveStaples"" onclick=""saveStaples()"">
                            <i class=""fa fa-save""></i> Save
                        </button>
                        <button class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect  cancel-button cancel-button"" data-dismiss=""modal""><i class=""fa fa-times""></i> Cancel </button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<");
            WriteLiteral(@"div class=""modal fade in"" id=""PopupConsultations"" data-keyboard=""false"" data-backdrop=""static"">
    <div class=""modal-dialog modal-lg"" role=""document"" style=""box-shadow:none;"">
        <div class=""modal-content"">
            <div class=""modal-header popupHeader"">
                <button type=""button"" class=""close ml-auto"" data-dismiss=""modal""> <i class=""fa fa-times""></i></button>
                <h4 class=""modal-title"">Consultations</h4>
            </div>

            <div class=""modal-body"">
                <div class=""row"" hidden>
                    <div class=""col-sm-6"">
                        <div class=""form-group"">
                            <label>Date</label>
                            <input class=""form-control datepicker"" type=""text"" maxlength=""8"" id=""dpConsultationsDate"" />
                        </div>
                    </div>
                    <div class=""col-sm-6"">
                        <div class=""form-group"">
                            <label>Time</label>
      ");
            WriteLiteral(@"                      <input class=""form-control timepicker"" type=""time"" maxlength=""8"" id=""tpConsultationsTime"" />
                        </div>
                    </div>
                </div>
                <div id=""dvConsultations""></div>
            </div>
            <div class=""modal-footer"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <button class=""mdl-button ""
                                id=""btnSaveConsultations"" onclick=""saveConsultations()"">
                            <i class=""fa fa-save""></i> Save
                        </button>
                        <button class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect  cancel-button cancel-button"" data-dismiss=""modal""><i class=""fa fa-times""></i> Cancel </button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
    

    <script>

        $("".nav li a"").click(function () {
            $("".na");
            WriteLiteral(@"v li a"").removeClass(""active"");
            $(this).addClass(""active"");
            $('.tab-pane').removeClass('show active');
            var v = $(this).attr('data-bs-target');
            //console.log(v);
            $(v).addClass('show active');
        });

        $(document).ready(function () {

        });

        function fnBack() {
            bootbox.confirm({
                message: ""Do you want to leave the form? Any unsaved data will be losted, Proceed?"",
                buttons: {
                    confirm: {
                        label: 'Yes',
                        className: 'btn-success'
                    },
                    cancel: {
                        label: 'No',
                        className: 'btn-danger'
                    }
                },
                callback: function (result) {
                    if (result) {
                       // history.back();
                        window.close();
                    }
         ");
            WriteLiteral(@"       }
            });
            
        }
         function fnsideBarSetup() {
      var docWidth = $(document).width();
    var marginLeft = $(""#navbar-preoperative"").outerWidth(true);
    var winH = $(window).outerHeight(true);
    var divHeight = Math.floor($("".divFixedBar"").outerHeight(true)) - 1;
    var maxH = ($(window).outerHeight(true) - ($(""section.header"").outerHeight(true) + $("".banner"").outerHeight(true) + $("".divFixedBar"").outerHeight(true)))
    const headerH = $('section.header').outerHeight(true);
    const headerBannerH = headerH + $('.banner').outerHeight(true);
    const headerBannerFixedBarH = headerBannerH + $('.divFixedBar').outerHeight(true);
    const tabContentH = headerBannerFixedBarH + $('.main-heading').height();
    
    var isapp = '");
            EndContext();
            BeginContext(18989, 13, false);
#line 419 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientClinicalForms\FacilityStay.cshtml"
            Write(ViewBag.IsApp);

#line default
#line hidden
            EndContext();
            BeginContext(19002, 3461, true);
            WriteLiteral(@"';
     
    if (isapp == ""Y"") {
        $(""#mainContent"").css({
            ""top"": $('.divFixedBar').innerHeight(),
            'max-height': winH - $('.divFixedBar').outerHeight(true),
            'margin-left': marginLeft,
            'overflow-y': 'auto',
            'width': '100%'
        });
        $("".sidebar"").css({
            'top': $('.divFixedBar').innerHeight(),
            'display': 'block',
        });
        $("".divContent"").css({
            'padding-top':'40px',
            'overflow-y': 'auto',
            'max-height': winH - $('.divFixedBar').outerHeight(true)
        })
        $(""#floatButtons"").css({
            'position': 'absolute',
            'top': $('.divFixedBar').height(),
            'right': '0px',
            'z-index': 3
        });
        $(""#floatButtons button"").css({
            'height': $('.main-heading').innerHeight()
        });
        $(""#floatButtons button svg"").css({
            ""font-size"": $(""#floatButtons button"").height() ");
            WriteLiteral(@"/ 2
        });
        $("".main-heading"").first().css({ 'position':'fixed','z-index':20,'width':'100%'});
    }
    else {
        $(""#mainContent"").css({
            'top': '0px',
            ""height"": $(window).height() - ($(""section.header"").outerHeight(true) + $("".banner"").outerHeight(true) + $("".divFixedBar"").outerHeight(true) + 20),
             'max-height': winH - $('.divFixedBar').outerHeight(true),
            'margin-left': marginLeft,
            'overflow-y': 'auto',
            'width': '100%', 'position': 'relative'
        });
        $("".sidebar"").css({
            'top': $(""section.header"").outerHeight(true) + $("".banner"").outerHeight(true) + $("".divFixedBar"").outerHeight(true),
            'display': 'block',
        });
        $("".divContent"").css({
            'overflow-y': 'auto',
            'max-height': maxH
        })
        $(""#floatButtons button"").css({
            'height': $("".divFixedBar"").outerHeight(true)
        });
        $(""#floatButtons button ");
            WriteLiteral(@"svg"").css({
            ""font-size"": $("".divFixedBar"").outerHeight(true) / 2
        });
    }



    $(""#navbar-preoperative"").on('click', 'a', function () {
        $("".nav-link"").removeClass(""active"");
        $(this).addClass(""active"");
        $('.tab-pane').removeClass('show active');
        var v = $(this).attr('data-bs-target');
        $(v).addClass('show active');

        var _wW = $(window).width();
        if (_wW < 1024) {
            $('.sidebar').addClass('hide');
            $('#mainContent').toggleClass('moveLeft').css('width', '100% ');
        }
        else {
            $('#mainContent').css('width', '100%');
        }

        $(""#mainContent"").scrollTop(0);
    });
    fnRefreshGridWidth();
        }
        $(window).resize(function () {
            fnsideBarSetup()
        });
        function fnRefreshGridWidth() {

            $(""#jqgDrugCharts"").jqGrid('setGridWidth', parseInt(($('#mainContent').width()))).trigger('reloadGrid');
            $(""#jq");
            WriteLiteral(@"gVitalCharts"").jqGrid('setGridWidth', parseInt(($('#mainContent').width()))).trigger('reloadGrid');
            $(""#jqgDoctorNotes"").jqGrid('setGridWidth', parseInt(($('#mainContent').width()))).trigger('reloadGrid');
            $('div[id^=""gbox""],.ui-jqgrid-hdiv,.ui-jqgrid-bdiv,.ui-jqgrid-btable,.ui-jqgrid-view,.ui-jqgrid-pager').css('max-width', '100%');
        }
    </script>
");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
