#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3022_00.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "490d75fdf0fb92eb15c3f45be647a4816a3c5e13"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_eSyaOutPatient_Views_PatientRegistration_V_3022_00), @"mvc.1.0.view", @"/Areas/eSyaOutPatient/Views/PatientRegistration/V_3022_00.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/eSyaOutPatient/Views/PatientRegistration/V_3022_00.cshtml", typeof(AspNetCore.Areas_eSyaOutPatient_Views_PatientRegistration_V_3022_00))]
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
#line 1 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3022_00.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"490d75fdf0fb92eb15c3f45be647a4816a3c5e13", @"/Areas/eSyaOutPatient/Views/PatientRegistration/V_3022_00.cshtml")]
    public class Areas_eSyaOutPatient_Views_PatientRegistration_V_3022_00 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jsTree.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/jsTree.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/eSyaOutPatient/PatientRegistration/DoctorDesk.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3022_00.cshtml"
  
    ViewData["Title"] = @Localizer["DoctorDesk"];
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#line 7 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3022_00.cshtml"
  
    var userFormRole = (eSyaEnterprise_UI.Models.DO_UserFormRole)ViewBag.UserFormRole;

#line default
#line hidden
            BeginContext(280, 46, true);
            WriteLiteral("<script>\r\n    var _userFormRole = JSON.parse(\'");
            EndContext();
            BeginContext(327, 38, false);
#line 11 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3022_00.cshtml"
                               Write(Html.Raw(Json.Serialize(userFormRole)));

#line default
#line hidden
            EndContext();
            BeginContext(365, 16, true);
            WriteLiteral("\');\r\n</script>\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(398, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(404, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "490d75fdf0fb92eb15c3f45be647a4816a3c5e135907", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(442, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(448, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "490d75fdf0fb92eb15c3f45be647a4816a3c5e137160", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(497, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(503, 77, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "490d75fdf0fb92eb15c3f45be647a4816a3c5e138492", async() => {
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
                BeginContext(580, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(585, 65, true);
            WriteLiteral("\r\n\r\n    <div class=\"row\">\r\n        <input type=\"hidden\" id=\"hdUT\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 650, "\"", 669, 1);
#line 21 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3022_00.cshtml"
WriteAttributeValue("", 658, ViewBag.UT, 658, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(670, 106, true);
            WriteLiteral(" />\r\n        <div class=\"col-lg-2 col-md-4 col-sm-6 form-group\">\r\n            <label class=\"lable-color\"> ");
            EndContext();
            BeginContext(777, 21, false);
#line 23 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3022_00.cshtml"
                                   Write(Localizer["FromDate"]);

#line default
#line hidden
            EndContext();
            BeginContext(798, 263, true);
            WriteLiteral(@"</label>
            <input type=""date"" name=""fromdate"" value="""" class=""form-control"" id=""txtfromdate"" onchange=""fnLoadAppointmentDetail()"" />
        </div>
        <div class=""col-lg-2 col-md-4 col-sm-6 form-group"">
            <label class=""lable-color"">  ");
            EndContext();
            BeginContext(1062, 19, false);
#line 27 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3022_00.cshtml"
                                    Write(Localizer["ToDate"]);

#line default
#line hidden
            EndContext();
            BeginContext(1081, 284, true);
            WriteLiteral(@"</label>
            <input type=""date"" name=""todate"" value="""" class=""form-control"" id=""txttodate"" onchange=""fnLoadAppointmentDetail()"" />
        </div>
        <div class=""col-lg-2 col-md-2 col-sm-12"" id=""divVType"">
            <div class=""form-group"">
                <label> ");
            EndContext();
            BeginContext(1366, 22, false);
#line 32 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3022_00.cshtml"
                   Write(Localizer["VisitType"]);

#line default
#line hidden
            EndContext();
            BeginContext(1388, 193, true);
            WriteLiteral("</label>\r\n                <select class=\"selectpicker\" data-live-search=\"true\" id=\"cboVisitType\" title=\"\" onchange=\"fnLoadAppointmentDetail()\">\r\n                    <option value=\"A\" selected> ");
            EndContext();
            BeginContext(1582, 16, false);
#line 34 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3022_00.cshtml"
                                           Write(Localizer["All"]);

#line default
#line hidden
            EndContext();
            BeginContext(1598, 50, true);
            WriteLiteral("</option>\r\n                    <option value=\"N\"> ");
            EndContext();
            BeginContext(1649, 28, false);
#line 35 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3022_00.cshtml"
                                  Write(Localizer["NewConsultation"]);

#line default
#line hidden
            EndContext();
            BeginContext(1677, 50, true);
            WriteLiteral("</option>\r\n                    <option value=\"S\"> ");
            EndContext();
            BeginContext(1728, 29, false);
#line 36 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3022_00.cshtml"
                                  Write(Localizer["FollowUpSurgical"]);

#line default
#line hidden
            EndContext();
            BeginContext(1757, 50, true);
            WriteLiteral("</option>\r\n                    <option value=\"R\"> ");
            EndContext();
            BeginContext(1808, 30, false);
#line 37 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3022_00.cshtml"
                                  Write(Localizer["FollowUpNutrition"]);

#line default
#line hidden
            EndContext();
            BeginContext(1838, 194, true);
            WriteLiteral("</option>\r\n                </select>\r\n            </div>\r\n        </div>\r\n        <div class=\"col-lg-2 col-md-2 col-sm-12\" hidden>\r\n            <div class=\"form-group\">\r\n                <label> ");
            EndContext();
            BeginContext(2033, 30, false);
#line 43 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3022_00.cshtml"
                   Write(Localizer["AppointmentStatus"]);

#line default
#line hidden
            EndContext();
            BeginContext(2063, 183, true);
            WriteLiteral("</label>\r\n                <select class=\"selectpicker\" data-live-search=\"true\" id=\"cboAPStatus\" title=\"\" onchange=\"fnLoadAppointmentDetail()\">\r\n                    <option value=\"A\"> ");
            EndContext();
            BeginContext(2247, 16, false);
#line 45 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3022_00.cshtml"
                                  Write(Localizer["All"]);

#line default
#line hidden
            EndContext();
            BeginContext(2263, 51, true);
            WriteLiteral("</option>\r\n                    <option value=\"AP\"> ");
            EndContext();
            BeginContext(2315, 19, false);
#line 46 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3022_00.cshtml"
                                   Write(Localizer["Booked"]);

#line default
#line hidden
            EndContext();
            BeginContext(2334, 60, true);
            WriteLiteral("</option>\r\n                    <option value=\"RG\" selected> ");
            EndContext();
            BeginContext(2395, 23, false);
#line 47 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3022_00.cshtml"
                                            Write(Localizer["Registered"]);

#line default
#line hidden
            EndContext();
            BeginContext(2418, 51, true);
            WriteLiteral("</option>\r\n                    <option value=\"CN\"> ");
            EndContext();
            BeginContext(2470, 22, false);
#line 48 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3022_00.cshtml"
                                   Write(Localizer["Cancelled"]);

#line default
#line hidden
            EndContext();
            BeginContext(2492, 226, true);
            WriteLiteral("</option>\r\n                </select>\r\n            </div>\r\n        </div>\r\n\r\n\r\n        <div class=\"col-md-3 col-sm-4 col-lg-2 \" id=\"divSearch\">\r\n            <div class=\"form-group\">\r\n                <label id=\"lblSearchState\"> ");
            EndContext();
            BeginContext(2719, 35, false);
#line 56 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3022_00.cshtml"
                                       Write(Localizer["PatientName/MRN/Mobile"]);

#line default
#line hidden
            EndContext();
            BeginContext(2754, 509, true);
            WriteLiteral(@"</label>
                <input id=""txtSearchBox"" type=""text"" class=""form-control"" />
            </div>
        </div>
        <div class=""col-md-3 col-sm-8 col-lg-4 d-flex align-items-center"" id=""divAddPatient"">
            <div class=""form-group"">
                <button class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent primary-button""
                        id=""btnNewPatient"" onclick=""fnAddNewPatient()"">
                    <i class=""fa fa-save""></i> ");
            EndContext();
            BeginContext(3264, 26, false);
#line 64 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3022_00.cshtml"
                                          Write(Localizer["AddNewPatient"]);

#line default
#line hidden
            EndContext();
            BeginContext(3290, 323, true);
            WriteLiteral(@"
                </button>
                &nbsp;&nbsp;
                <button class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent primary-button""
                        id=""btnSearchPatient"" onclick=""fnSearchPatient()"" hidden>
                    <i class=""fa fa-search""></i> ");
            EndContext();
            BeginContext(3614, 26, false);
#line 69 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3022_00.cshtml"
                                            Write(Localizer["SearchPatient"]);

#line default
#line hidden
            EndContext();
            BeginContext(3640, 2778, true);
            WriteLiteral(@"
                </button>
            </div>
        </div>
        <div class=""col-md-3 col-sm-4 col-lg-2 "" id=""divSearch"">
            <div class=""form-group"">
                <label>Patient Search</label>
                <input id=""cboApptPatientSearch"" type=""text"" class=""form-control"">
            </div>
        </div>
    </div>
<div class=""row padbot10"">
    <div class=""col-lg-12 col-md-12 col-sm-12"">
        <table id=""jqgAppointmentDetail""></table>
        <div id=""jqpAppointmentDetail""></div>
    </div>
</div>
<div class=""modal fade in"" id=""PopupAddPatient"" data-keyboard=""false"" data-backdrop=""static"">
    <div class=""modal-dialog modal-lg"" role=""document"" style=""box-shadow:none;"">
        <div class=""modal-content"">
            <div class=""modal-header popupHeader"">
                <button type=""button"" class=""close ml-auto"" data-dismiss=""modal""> <i class=""fa fa-times""></i></button>
                <h4 class=""modal-title"">Add Patient</h4>
            </div>

            <di");
            WriteLiteral(@"v class=""modal-body"">
                <div class=""row"">
                    <div class=""col-lg-6 col-md-6 col-sm-6 form-group"">
                        <label>First Name</label>
                        <input type=""text"" name=""text"" id=""txtFirstName"" value="""" class=""form-control"" autocomplete=""on"" />
                    </div>
                    <div class=""col-lg-6 col-md-6 col-sm-6 form-group"" hidden>
                        <label>Middle Name</label>
                        <input type=""text"" name=""text"" id=""txtMiddleName"" value="""" class=""form-control"" autocomplete=""on"" />
                    </div>
                    <div class=""col-lg-6 col-md-6 col-sm-6 form-group"">
                        <label>Last Name</label>
                        <input type=""text"" name=""text"" id=""txtLastName"" value="""" class=""form-control"" autocomplete=""on"" />
                    </div>

                    <div class=""col-lg-3 col-md-3 col-sm-3 form-group"">
                        <label>Gender</label>
      ");
            WriteLiteral(@"                  <select class=""form-control"" id=""cboGender"">
                            <option>Choose gender</option>
                            <option value=""M"">Male</option>
                            <option value=""F"">Female</option>
                        </select>
                    </div>


                    <div class=""col-lg-3 col-md-3 col-sm-3 form-group"">
                        <label>Date of Birth</label>
                        <input type=""date"" name=""text"" id=""txtDateOfBirth"" value="""" class=""form-control"" />
                    </div>
                    <div class=""col-lg-6 col-md-6 col-sm-6 form-group"">
                        <label>Mobile Number</label>
                        ");
            EndContext();
            BeginContext(6419, 74, false);
#line 125 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3022_00.cshtml"
                   Write(await Component.InvokeAsync("IsdMobileInput", new { id = "MobileNumber" }));

#line default
#line hidden
            EndContext();
            BeginContext(6493, 2462, true);
            WriteLiteral(@"
                    </div>
                    <div class=""col-lg-6 col-md-6 col-sm-6 form-group"">
                        <label>Email ID</label>
                        <input type=""text"" name=""text"" id=""txtEmailID"" value="""" class=""form-control email"" autocomplete=""on"" />
                    </div>

                </div>
            </div>
            <div class=""modal-footer"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <button class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent primary-button""
                                id=""btnAddPatient"" onclick=""fnInsertInToPatientMaster()"">
                            <i class=""fa fa-save""></i> Save
                        </button>
                        <button class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect  cancel-button cancel-button"" data-dismiss=""modal""><i class=""fa fa-times""></i> Cancel </button>
                    <");
            WriteLiteral(@"/div>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""modal fade in"" id=""PopupSearchPatient"" data-keyboard=""false"" data-backdrop=""static"">
    <div class=""modal-dialog modal-lg"" role=""document"" style=""box-shadow:none;"">
        <div class=""modal-content"">
            <div class=""modal-header popupHeader"">
                <button type=""button"" class=""close ml-auto"" data-dismiss=""modal""> <i class=""fa fa-times""></i></button>
                <h4 class=""modal-title"">Patient Search</h4>
            </div>

            <div class=""modal-body"">

                <div class=""row "">                   
                    <div class=""col-lg-4 col-md-4 col-sm-4 form-group"">
                        <label>Patient Search</label>
                        <input id=""cboApptPatientSearch2"" type=""text"" class=""form-control"">
                    </div>
                </div>

            </div>
            <div class=""modal-footer"">
                <div class=""row"">
");
            WriteLiteral(@"                    <div class=""col-lg-12"">
                        <button class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect  cancel-button cancel-button"" data-dismiss=""modal""><i class=""fa fa-times""></i> Cancel </button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<script>
    var localization = {
        VisitNumber: '");
            EndContext();
            BeginContext(8956, 24, false);
#line 179 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3022_00.cshtml"
                 Write(Localizer["VisitNumber"]);

#line default
#line hidden
            EndContext();
            BeginContext(8980, 18, true);
            WriteLiteral("\',\r\n        MRN: \'");
            EndContext();
            BeginContext(8999, 16, false);
#line 180 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3022_00.cshtml"
         Write(Localizer["MRN"]);

#line default
#line hidden
            EndContext();
            BeginContext(9015, 26, true);
            WriteLiteral("\',\r\n        PatientName: \'");
            EndContext();
            BeginContext(9042, 24, false);
#line 181 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3022_00.cshtml"
                 Write(Localizer["PatientName"]);

#line default
#line hidden
            EndContext();
            BeginContext(9066, 21, true);
            WriteLiteral("\',\r\n        Mobile: \'");
            EndContext();
            BeginContext(9088, 19, false);
#line 182 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3022_00.cshtml"
            Write(Localizer["Mobile"]);

#line default
#line hidden
            EndContext();
            BeginContext(9107, 20, true);
            WriteLiteral("\',\r\n        Email: \'");
            EndContext();
            BeginContext(9128, 18, false);
#line 183 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3022_00.cshtml"
           Write(Localizer["Email"]);

#line default
#line hidden
            EndContext();
            BeginContext(9146, 30, true);
            WriteLiteral("\',\r\n        AppointmentDate: \'");
            EndContext();
            BeginContext(9177, 28, false);
#line 184 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3022_00.cshtml"
                     Write(Localizer["AppointmentDate"]);

#line default
#line hidden
            EndContext();
            BeginContext(9205, 30, true);
            WriteLiteral("\',\r\n        AppointmentTime: \'");
            EndContext();
            BeginContext(9236, 28, false);
#line 185 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3022_00.cshtml"
                     Write(Localizer["AppointmentTime"]);

#line default
#line hidden
            EndContext();
            BeginContext(9264, 21, true);
            WriteLiteral("\',\r\n        Status: \'");
            EndContext();
            BeginContext(9286, 19, false);
#line 186 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3022_00.cshtml"
            Write(Localizer["Status"]);

#line default
#line hidden
            EndContext();
            BeginContext(9305, 22, true);
            WriteLiteral("\',\r\n        Actions: \'");
            EndContext();
            BeginContext(9328, 20, false);
#line 187 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3022_00.cshtml"
             Write(Localizer["Actions"]);

#line default
#line hidden
            EndContext();
            BeginContext(9348, 24, true);
            WriteLiteral("\',\r\n        VisitType: \'");
            EndContext();
            BeginContext(9373, 22, false);
#line 188 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3022_00.cshtml"
               Write(Localizer["VisitType"]);

#line default
#line hidden
            EndContext();
            BeginContext(9395, 30, true);
            WriteLiteral("\',\r\n        NewConsultation: \'");
            EndContext();
            BeginContext(9426, 28, false);
#line 189 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3022_00.cshtml"
                     Write(Localizer["NewConsultation"]);

#line default
#line hidden
            EndContext();
            BeginContext(9454, 31, true);
            WriteLiteral("\',\r\n        FollowUpSurgical: \'");
            EndContext();
            BeginContext(9486, 29, false);
#line 190 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3022_00.cshtml"
                      Write(Localizer["FollowUpSurgical"]);

#line default
#line hidden
            EndContext();
            BeginContext(9515, 32, true);
            WriteLiteral("\',\r\n        FollowUpNutrition: \'");
            EndContext();
            BeginContext(9548, 30, false);
#line 191 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3022_00.cshtml"
                       Write(Localizer["FollowUpNutrition"]);

#line default
#line hidden
            EndContext();
            BeginContext(9578, 20, true);
            WriteLiteral("\',\r\n        Forms: \'");
            EndContext();
            BeginContext(9599, 18, false);
#line 192 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3022_00.cshtml"
           Write(Localizer["Forms"]);

#line default
#line hidden
            EndContext();
            BeginContext(9617, 25, true);
            WriteLiteral("\',\r\n        PatientEMR: \'");
            EndContext();
            BeginContext(9643, 23, false);
#line 193 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3022_00.cshtml"
                Write(Localizer["PatientEMR"]);

#line default
#line hidden
            EndContext();
            BeginContext(9666, 26, true);
            WriteLiteral("\',\r\n        CaseSummary: \'");
            EndContext();
            BeginContext(9693, 24, false);
#line 194 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3022_00.cshtml"
                 Write(Localizer["CaseSummary"]);

#line default
#line hidden
            EndContext();
            BeginContext(9717, 27, true);
            WriteLiteral("\',\r\n        PreOperative: \'");
            EndContext();
            BeginContext(9745, 25, false);
#line 195 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3022_00.cshtml"
                  Write(Localizer["PreOperative"]);

#line default
#line hidden
            EndContext();
            BeginContext(9770, 27, true);
            WriteLiteral("\',\r\n        FacilityStay: \'");
            EndContext();
            BeginContext(9798, 25, false);
#line 196 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3022_00.cshtml"
                  Write(Localizer["FacilityStay"]);

#line default
#line hidden
            EndContext();
            BeginContext(9823, 24, true);
            WriteLiteral("\',\r\n\r\n    }\r\n</script>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
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