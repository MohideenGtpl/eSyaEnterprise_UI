#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32e810de0f2a72016973f3975d3bb1e05265d0d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_eSyaOutPatient_Views_PatientRegistration_V_3021_00), @"mvc.1.0.view", @"/Areas/eSyaOutPatient/Views/PatientRegistration/V_3021_00.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/eSyaOutPatient/Views/PatientRegistration/V_3021_00.cshtml", typeof(AspNetCore.Areas_eSyaOutPatient_Views_PatientRegistration_V_3021_00))]
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
#line 1 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32e810de0f2a72016973f3975d3bb1e05265d0d0", @"/Areas/eSyaOutPatient/Views/PatientRegistration/V_3021_00.cshtml")]
    public class Areas_eSyaOutPatient_Views_PatientRegistration_V_3021_00 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jsTree.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/jsTree.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/eSyaOutPatient/PatientRegistration/Reception.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
  
    ViewData["Title"] = @Localizer["Reception"];
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#line 7 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
  
    var userFormRole = (eSyaEnterprise_UI.Models.DO_UserFormRole)ViewBag.UserFormRole;

#line default
#line hidden
            BeginContext(279, 46, true);
            WriteLiteral("<script>\r\n    var _userFormRole = JSON.parse(\'");
            EndContext();
            BeginContext(326, 38, false);
#line 11 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
                               Write(Html.Raw(Json.Serialize(userFormRole)));

#line default
#line hidden
            EndContext();
            BeginContext(364, 16, true);
            WriteLiteral("\');\r\n</script>\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(397, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(403, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32e810de0f2a72016973f3975d3bb1e05265d0d05905", async() => {
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
                BeginContext(441, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(447, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "32e810de0f2a72016973f3975d3bb1e05265d0d07158", async() => {
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
                BeginContext(496, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(502, 76, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32e810de0f2a72016973f3975d3bb1e05265d0d08490", async() => {
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
                BeginContext(578, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(583, 426, true);
            WriteLiteral(@"<style>
    .bg_ap {
        background-color:gainsboro !important;
    }
    .bg_rg {
        background-color: lightyellow !important;
    }
    .bg_cm {
        background-color: greenyellow !important;
    }
    .bg_cn {
        background-color: orangered !important;
    }
</style>
    <div class=""row"">
        <div class=""col-lg-2 col-md-4 col-sm-6 form-group"">
            <label class=""lable-color""> ");
            EndContext();
            BeginContext(1010, 21, false);
#line 34 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
                                   Write(Localizer["FromDate"]);

#line default
#line hidden
            EndContext();
            BeginContext(1031, 263, true);
            WriteLiteral(@"</label>
            <input type=""date"" name=""fromdate"" value="""" class=""form-control"" id=""txtfromdate"" onchange=""fnLoadAppointmentDetail()"" />
        </div>
        <div class=""col-lg-2 col-md-4 col-sm-6 form-group"">
            <label class=""lable-color"">  ");
            EndContext();
            BeginContext(1295, 19, false);
#line 38 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
                                    Write(Localizer["ToDate"]);

#line default
#line hidden
            EndContext();
            BeginContext(1314, 270, true);
            WriteLiteral(@"</label>
            <input type=""date"" name=""todate"" value="""" class=""form-control"" id=""txttodate"" onchange=""fnLoadAppointmentDetail()"" />
        </div>
        <div class=""col-lg-2 col-md-2 col-sm-12"">
            <div class=""form-group"">
                <label> ");
            EndContext();
            BeginContext(1585, 22, false);
#line 43 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
                   Write(Localizer["VisitType"]);

#line default
#line hidden
            EndContext();
            BeginContext(1607, 193, true);
            WriteLiteral("</label>\r\n                <select class=\"selectpicker\" data-live-search=\"true\" id=\"cboVisitType\" title=\"\" onchange=\"fnLoadAppointmentDetail()\">\r\n                    <option value=\"A\" selected> ");
            EndContext();
            BeginContext(1801, 16, false);
#line 45 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
                                           Write(Localizer["All"]);

#line default
#line hidden
            EndContext();
            BeginContext(1817, 50, true);
            WriteLiteral("</option>\r\n                    <option value=\"N\"> ");
            EndContext();
            BeginContext(1868, 28, false);
#line 46 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
                                  Write(Localizer["NewConsultation"]);

#line default
#line hidden
            EndContext();
            BeginContext(1896, 50, true);
            WriteLiteral("</option>\r\n                    <option value=\"S\"> ");
            EndContext();
            BeginContext(1947, 29, false);
#line 47 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
                                  Write(Localizer["FollowUpSurgical"]);

#line default
#line hidden
            EndContext();
            BeginContext(1976, 50, true);
            WriteLiteral("</option>\r\n                    <option value=\"R\"> ");
            EndContext();
            BeginContext(2027, 30, false);
#line 48 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
                                  Write(Localizer["FollowUpNutrition"]);

#line default
#line hidden
            EndContext();
            BeginContext(2057, 194, true);
            WriteLiteral("</option>\r\n                </select>\r\n            </div>\r\n        </div>       \r\n        <div class=\"col-lg-2 col-md-2 col-sm-12\">\r\n            <div class=\"form-group\">\r\n                <label> ");
            EndContext();
            BeginContext(2252, 30, false);
#line 54 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
                   Write(Localizer["AppointmentStatus"]);

#line default
#line hidden
            EndContext();
            BeginContext(2282, 192, true);
            WriteLiteral("</label>\r\n                <select class=\"selectpicker\" data-live-search=\"true\" id=\"cboAPStatus\" title=\"\" onchange=\"fnLoadAppointmentDetail()\">\r\n                    <option value=\"A\" selected> ");
            EndContext();
            BeginContext(2475, 16, false);
#line 56 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
                                           Write(Localizer["All"]);

#line default
#line hidden
            EndContext();
            BeginContext(2491, 51, true);
            WriteLiteral("</option>\r\n                    <option value=\"AP\"> ");
            EndContext();
            BeginContext(2543, 19, false);
#line 57 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
                                   Write(Localizer["Booked"]);

#line default
#line hidden
            EndContext();
            BeginContext(2562, 51, true);
            WriteLiteral("</option>\r\n                    <option value=\"RG\"> ");
            EndContext();
            BeginContext(2614, 23, false);
#line 58 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
                                   Write(Localizer["Registered"]);

#line default
#line hidden
            EndContext();
            BeginContext(2637, 51, true);
            WriteLiteral("</option>\r\n                    <option value=\"CM\"> ");
            EndContext();
            BeginContext(2689, 22, false);
#line 59 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
                                   Write(Localizer["Completed"]);

#line default
#line hidden
            EndContext();
            BeginContext(2711, 51, true);
            WriteLiteral("</option>\r\n                    <option value=\"CN\"> ");
            EndContext();
            BeginContext(2763, 22, false);
#line 60 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
                                   Write(Localizer["Cancelled"]);

#line default
#line hidden
            EndContext();
            BeginContext(2785, 226, true);
            WriteLiteral("</option>\r\n                </select>\r\n            </div>\r\n        </div>\r\n\r\n\r\n        <div class=\"col-md-3 col-sm-4 col-lg-2 \" id=\"divSearch\">\r\n            <div class=\"form-group\">\r\n                <label id=\"lblSearchState\"> ");
            EndContext();
            BeginContext(3012, 35, false);
#line 68 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
                                       Write(Localizer["PatientName/MRN/Mobile"]);

#line default
#line hidden
            EndContext();
            BeginContext(3047, 968, true);
            WriteLiteral(@"</label>
                <input id=""txtSearchBox"" type=""text"" class=""form-control"" />
            </div>
        </div>


    </div>
<div class=""row padbot10"">
    <div class=""col-lg-12 col-md-12 col-sm-12"">
        <table id=""jqgAppointmentDetail""></table>
        <div id=""jqpAppointmentDetail""></div>
    </div>
</div>

<div class=""modal fade in"" id=""PopupEditApp"" data-keyboard=""false"" data-backdrop=""static"">
    <div class=""modal-dialog modal-lg"" role=""document"" style=""box-shadow:none;"">
        <div class=""modal-content"">
            <div class=""modal-header popupHeader"">
                <button type=""button"" class=""close ml-auto"" data-dismiss=""modal""> <i class=""fa fa-times""></i></button>
                <h4 class=""modal-title"">Change Visit Type</h4>
            </div>

            <div class=""modal-body"">
                <input type=""hidden"" id=""hdAppKey""/>
                <div class=""form-group"">
                    <label> ");
            EndContext();
            BeginContext(4016, 22, false);
#line 93 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
                       Write(Localizer["VisitType"]);

#line default
#line hidden
            EndContext();
            BeginContext(4038, 169, true);
            WriteLiteral("</label>\r\n                    <select class=\'selectpicker form-control\' data-container=\'body\'  id=\"cboVisitType_e\" title=\"\">\r\n                        <option value=\"N\"> ");
            EndContext();
            BeginContext(4208, 28, false);
#line 95 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
                                      Write(Localizer["NewConsultation"]);

#line default
#line hidden
            EndContext();
            BeginContext(4236, 54, true);
            WriteLiteral("</option>\r\n                        <option value=\"S\"> ");
            EndContext();
            BeginContext(4291, 29, false);
#line 96 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
                                      Write(Localizer["FollowUpSurgical"]);

#line default
#line hidden
            EndContext();
            BeginContext(4320, 54, true);
            WriteLiteral("</option>\r\n                        <option value=\"R\"> ");
            EndContext();
            BeginContext(4375, 30, false);
#line 97 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
                                      Write(Localizer["FollowUpNutrition"]);

#line default
#line hidden
            EndContext();
            BeginContext(4405, 1576, true);
            WriteLiteral(@"</option>
                    </select>
                </div>
            </div>
            <div class=""modal-footer"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <button class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent primary-button""
                                id=""btnUpdateVisitType"" onclick=""fnUpdateVisitType()"">
                            <i class=""fa fa-save""></i> Save
                        </button>
                        <button class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect  cancel-button cancel-button"" data-dismiss=""modal""><i class=""fa fa-times""></i> Cancel </button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""modal fade in"" id=""PopupPayment"" data-keyboard=""false"" data-backdrop=""static"">
    <div class=""modal-dialog modal-lg"" role=""document"" style=""box-shadow:none;"">
        <di");
            WriteLiteral(@"v class=""modal-content"">
            <div class=""modal-header popupHeader"">
                <button type=""button"" class=""close ml-auto"" data-dismiss=""modal""> <i class=""fa fa-times""></i></button>
                <h4 class=""modal-title"">Payments</h4>
            </div>

            <div class=""modal-body"">
                <input type=""hidden"" id=""hdappKey"" />
                <div class=""row"">
                    <div class='col-lg-4 col-md-6 col-sm-12'>
                        <div class=""form-group"">
                            <label> ");
            EndContext();
            BeginContext(5982, 20, false);
#line 128 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
                               Write(Localizer["Payment"]);

#line default
#line hidden
            EndContext();
            BeginContext(6002, 344, true);
            WriteLiteral(@"</label>
                            <input id='txtRAmount' class='form-control decimalNumber d-inline' style='width:80px' readonly>
                        </div>
                    </div>
                    <div class='col-lg-4 col-md-6 col-sm-12'>
                        <div class=""form-group"">
                            <label> ");
            EndContext();
            BeginContext(6347, 19, false);
#line 134 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
                               Write(Localizer["Refund"]);

#line default
#line hidden
            EndContext();
            BeginContext(6366, 344, true);
            WriteLiteral(@"</label>
                            <input id='txtPAmount' class='form-control decimalNumber d-inline' style='width:80px' readonly>
                        </div>
                    </div>
                    <div class='col-lg-4 col-md-6 col-sm-12'>
                        <div class=""form-group"">
                            <label> ");
            EndContext();
            BeginContext(6711, 23, false);
#line 140 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
                               Write(Localizer["NetPayment"]);

#line default
#line hidden
            EndContext();
            BeginContext(6734, 403, true);
            WriteLiteral(@"</label>
                            <input id='txtNAmount' class='form-control decimalNumber d-inline' style='width:80px' readonly>
                        </div>
                    </div>
                </div>
                <div class=""row"">
                    <div class='col-lg-4 col-md-6 col-sm-12'>
                        <div class=""form-group"">
                            <label> ");
            EndContext();
            BeginContext(7138, 24, false);
#line 148 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
                               Write(Localizer["PaymentType"]);

#line default
#line hidden
            EndContext();
            BeginContext(7162, 193, true);
            WriteLiteral("</label>\r\n                            <select class=\'selectpicker form-control\' data-container=\'body\' id=\"cboPaymentType\" title=\"\">\r\n                                <option value=\"R\" selected> ");
            EndContext();
            BeginContext(7356, 20, false);
#line 150 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
                                                       Write(Localizer["Payment"]);

#line default
#line hidden
            EndContext();
            BeginContext(7376, 62, true);
            WriteLiteral("</option>\r\n                                <option value=\"P\"> ");
            EndContext();
            BeginContext(7439, 19, false);
#line 151 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
                                              Write(Localizer["Refund"]);

#line default
#line hidden
            EndContext();
            BeginContext(7458, 259, true);
            WriteLiteral(@"</option>
                            </select>
                        </div>
                    </div>
                    <div class='col-lg-4 col-md-6 col-sm-12'>
                        <div class=""form-group"">
                            <label> ");
            EndContext();
            BeginContext(7718, 19, false);
#line 157 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
                               Write(Localizer["Amount"]);

#line default
#line hidden
            EndContext();
            BeginContext(7737, 394, true);
            WriteLiteral(@"</label>
                            <input id='txtAmount' class='form-control decimalNumber d-inline' style='width:80px'>
                        </div>
                    </div>
                </div>
                <div class=""row"">
                    <div class='col-lg-4 col-md-6 col-sm-12 '>
                        <div class=""form-group"">
                            <label> ");
            EndContext();
            BeginContext(8132, 26, false);
#line 165 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
                               Write(Localizer["PaymentReason"]);

#line default
#line hidden
            EndContext();
            BeginContext(8158, 1100, true);
            WriteLiteral(@"</label>
                            <select class='selectpicker form-control' data-container='body' id=""cboPaymentReason"" title=""""></select>
                        </div>
                    </div>
                </div>
            </div>
                <div class=""modal-footer"">
                    <div class=""row"">
                        <div class=""col-lg-12"">
                            <button class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent primary-button""
                                    id=""btnPayment"" onclick=""fnAddPayment()"">
                                <i class=""fa fa-save""></i> Save
                            </button>
                            <button class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect  cancel-button cancel-button"" data-dismiss=""modal""><i class=""fa fa-times""></i> Cancel </button>
                        </div>
                    </div>
                </div>
            </div>
    </di");
            WriteLiteral("v>\r\n</div>\r\n    \r\n<script>\r\n    var localization = {\r\n        VisitNumber: \'");
            EndContext();
            BeginContext(9259, 24, false);
#line 188 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
                 Write(Localizer["VisitNumber"]);

#line default
#line hidden
            EndContext();
            BeginContext(9283, 18, true);
            WriteLiteral("\',\r\n        MRN: \'");
            EndContext();
            BeginContext(9302, 16, false);
#line 189 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
         Write(Localizer["MRN"]);

#line default
#line hidden
            EndContext();
            BeginContext(9318, 26, true);
            WriteLiteral("\',\r\n        PatientName: \'");
            EndContext();
            BeginContext(9345, 24, false);
#line 190 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
                 Write(Localizer["PatientName"]);

#line default
#line hidden
            EndContext();
            BeginContext(9369, 21, true);
            WriteLiteral("\',\r\n        Mobile: \'");
            EndContext();
            BeginContext(9391, 19, false);
#line 191 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
            Write(Localizer["Mobile"]);

#line default
#line hidden
            EndContext();
            BeginContext(9410, 20, true);
            WriteLiteral("\',\r\n        Email: \'");
            EndContext();
            BeginContext(9431, 18, false);
#line 192 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
           Write(Localizer["Email"]);

#line default
#line hidden
            EndContext();
            BeginContext(9449, 30, true);
            WriteLiteral("\',\r\n        AppointmentDate: \'");
            EndContext();
            BeginContext(9480, 28, false);
#line 193 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
                     Write(Localizer["AppointmentDate"]);

#line default
#line hidden
            EndContext();
            BeginContext(9508, 30, true);
            WriteLiteral("\',\r\n        AppointmentTime: \'");
            EndContext();
            BeginContext(9539, 28, false);
#line 194 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
                     Write(Localizer["AppointmentTime"]);

#line default
#line hidden
            EndContext();
            BeginContext(9567, 21, true);
            WriteLiteral("\',\r\n        Status: \'");
            EndContext();
            BeginContext(9589, 19, false);
#line 195 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
            Write(Localizer["Status"]);

#line default
#line hidden
            EndContext();
            BeginContext(9608, 24, true);
            WriteLiteral("\',\r\n        CreatedBy: \'");
            EndContext();
            BeginContext(9633, 22, false);
#line 196 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
               Write(Localizer["CreatedBy"]);

#line default
#line hidden
            EndContext();
            BeginContext(9655, 22, true);
            WriteLiteral("\',\r\n        Actions: \'");
            EndContext();
            BeginContext(9678, 20, false);
#line 197 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
             Write(Localizer["Actions"]);

#line default
#line hidden
            EndContext();
            BeginContext(9698, 24, true);
            WriteLiteral("\',\r\n        VisitType: \'");
            EndContext();
            BeginContext(9723, 22, false);
#line 198 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
               Write(Localizer["VisitType"]);

#line default
#line hidden
            EndContext();
            BeginContext(9745, 30, true);
            WriteLiteral("\',\r\n        NewConsultation: \'");
            EndContext();
            BeginContext(9776, 28, false);
#line 199 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
                     Write(Localizer["NewConsultation"]);

#line default
#line hidden
            EndContext();
            BeginContext(9804, 31, true);
            WriteLiteral("\',\r\n        FollowUpSurgical: \'");
            EndContext();
            BeginContext(9836, 29, false);
#line 200 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
                      Write(Localizer["FollowUpSurgical"]);

#line default
#line hidden
            EndContext();
            BeginContext(9865, 32, true);
            WriteLiteral("\',\r\n        FollowUpNutrition: \'");
            EndContext();
            BeginContext(9898, 30, false);
#line 201 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
                       Write(Localizer["FollowUpNutrition"]);

#line default
#line hidden
            EndContext();
            BeginContext(9928, 26, true);
            WriteLiteral("\',\r\n        Mohandessin: \'");
            EndContext();
            BeginContext(9955, 24, false);
#line 202 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
                 Write(Localizer["Mohandessin"]);

#line default
#line hidden
            EndContext();
            BeginContext(9979, 20, true);
            WriteLiteral("\',\r\n        Zayed: \'");
            EndContext();
            BeginContext(10000, 18, false);
#line 203 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
           Write(Localizer["Zayed"]);

#line default
#line hidden
            EndContext();
            BeginContext(10018, 25, true);
            WriteLiteral("\',\r\n        TeleHealth: \'");
            EndContext();
            BeginContext(10044, 23, false);
#line 204 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
                Write(Localizer["TeleHealth"]);

#line default
#line hidden
            EndContext();
            BeginContext(10067, 21, true);
            WriteLiteral("\',\r\n        Clinic: \'");
            EndContext();
            BeginContext(10089, 19, false);
#line 205 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
            Write(Localizer["Clinic"]);

#line default
#line hidden
            EndContext();
            BeginContext(10108, 29, true);
            WriteLiteral("\',\r\n        RequestChannel: \'");
            EndContext();
            BeginContext(10138, 27, false);
#line 206 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
                    Write(Localizer["RequestChannel"]);

#line default
#line hidden
            EndContext();
            BeginContext(10165, 21, true);
            WriteLiteral("\',\r\n        Booked: \'");
            EndContext();
            BeginContext(10187, 19, false);
#line 207 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
            Write(Localizer["Booked"]);

#line default
#line hidden
            EndContext();
            BeginContext(10206, 25, true);
            WriteLiteral("\',\r\n        Registered: \'");
            EndContext();
            BeginContext(10232, 23, false);
#line 208 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
                Write(Localizer["Registered"]);

#line default
#line hidden
            EndContext();
            BeginContext(10255, 24, true);
            WriteLiteral("\',\r\n        Cancelled: \'");
            EndContext();
            BeginContext(10280, 22, false);
#line 209 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
               Write(Localizer["Cancelled"]);

#line default
#line hidden
            EndContext();
            BeginContext(10302, 24, true);
            WriteLiteral("\',\r\n        Completed: \'");
            EndContext();
            BeginContext(10327, 22, false);
#line 210 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
               Write(Localizer["Completed"]);

#line default
#line hidden
            EndContext();
            BeginContext(10349, 30, true);
            WriteLiteral("\',\r\n        PaymentReceived: \'");
            EndContext();
            BeginContext(10380, 28, false);
#line 211 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\PatientRegistration\V_3021_00.cshtml"
                     Write(Localizer["PaymentReceived"]);

#line default
#line hidden
            EndContext();
            BeginContext(10408, 22, true);
            WriteLiteral("\',\r\n    }\r\n</script>\r\n");
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
