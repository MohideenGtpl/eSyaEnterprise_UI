#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\SMS\Views\Engine\ESE_01_00.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9ea71aa687e6401f0ad0fb67e79364514d89154"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SMS_Views_Engine_ESE_01_00), @"mvc.1.0.view", @"/Areas/SMS/Views/Engine/ESE_01_00.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/SMS/Views/Engine/ESE_01_00.cshtml", typeof(AspNetCore.Areas_SMS_Views_Engine_ESE_01_00))]
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
#line 1 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\SMS\Views\Engine\ESE_01_00.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9ea71aa687e6401f0ad0fb67e79364514d89154", @"/Areas/SMS/Views/Engine/ESE_01_00.cshtml")]
    public class Areas_SMS_Views_Engine_ESE_01_00 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/jquery.contextMenu.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/SMS/SMSVariable.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.contextMenu.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\SMS\Views\Engine\ESE_01_00.cshtml"
  
    ViewData["Title"] = "ESE_01_00";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#line 8 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\SMS\Views\Engine\ESE_01_00.cshtml"
  
    var userFormRole = (eSyaEnterprise_UI.Models.DO_UserFormRole)ViewBag.UserFormRole;

#line default
#line hidden
            BeginContext(321, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e9ea71aa687e6401f0ad0fb67e79364514d891544885", async() => {
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
            BeginContext(386, 50, true);
            WriteLiteral("\r\n\r\n<script>\r\n    var _userFormRole = JSON.parse(\'");
            EndContext();
            BeginContext(437, 38, false);
#line 14 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\SMS\Views\Engine\ESE_01_00.cshtml"
                               Write(Html.Raw(Json.Serialize(userFormRole)));

#line default
#line hidden
            EndContext();
            BeginContext(475, 58, true);
            WriteLiteral("\');\r\n\r\n    var localization = {\r\n        AddSMSVariable: \'");
            EndContext();
            BeginContext(534, 27, false);
#line 17 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\SMS\Views\Engine\ESE_01_00.cshtml"
                    Write(Localizer["AddSMSVariable"]);

#line default
#line hidden
            EndContext();
            BeginContext(561, 26, true);
            WriteLiteral("\',\r\n        SMSVariable: \'");
            EndContext();
            BeginContext(588, 24, false);
#line 18 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\SMS\Views\Engine\ESE_01_00.cshtml"
                 Write(Localizer["SMSVariable"]);

#line default
#line hidden
            EndContext();
            BeginContext(612, 27, true);
            WriteLiteral("\',\r\n        SMSComponent: \'");
            EndContext();
            BeginContext(640, 25, false);
#line 19 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\SMS\Views\Engine\ESE_01_00.cshtml"
                  Write(Localizer["SMSComponent"]);

#line default
#line hidden
            EndContext();
            BeginContext(665, 22, true);
            WriteLiteral("\',\r\n        Actions: \'");
            EndContext();
            BeginContext(688, 20, false);
#line 20 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\SMS\Views\Engine\ESE_01_00.cshtml"
             Write(Localizer["Actions"]);

#line default
#line hidden
            EndContext();
            BeginContext(708, 29, true);
            WriteLiteral("\',\r\n        AddSMSVariable: \'");
            EndContext();
            BeginContext(738, 27, false);
#line 21 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\SMS\Views\Engine\ESE_01_00.cshtml"
                    Write(Localizer["AddSMSVariable"]);

#line default
#line hidden
            EndContext();
            BeginContext(765, 19, true);
            WriteLiteral("\',\r\n        Save: \'");
            EndContext();
            BeginContext(785, 17, false);
#line 22 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\SMS\Views\Engine\ESE_01_00.cshtml"
          Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(802, 21, true);
            WriteLiteral("\',\r\n        Cancel: \'");
            EndContext();
            BeginContext(824, 19, false);
#line 23 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\SMS\Views\Engine\ESE_01_00.cshtml"
            Write(Localizer["Cancel"]);

#line default
#line hidden
            EndContext();
            BeginContext(843, 30, true);
            WriteLiteral("\',\r\n        EditSMSVariable: \'");
            EndContext();
            BeginContext(874, 28, false);
#line 24 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\SMS\Views\Engine\ESE_01_00.cshtml"
                     Write(Localizer["EditSMSVariable"]);

#line default
#line hidden
            EndContext();
            BeginContext(902, 21, true);
            WriteLiteral("\',\r\n        Update: \'");
            EndContext();
            BeginContext(924, 19, false);
#line 25 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\SMS\Views\Engine\ESE_01_00.cshtml"
            Write(Localizer["Update"]);

#line default
#line hidden
            EndContext();
            BeginContext(943, 30, true);
            WriteLiteral("\',\r\n        ViewSMSVariable: \'");
            EndContext();
            BeginContext(974, 28, false);
#line 26 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\SMS\Views\Engine\ESE_01_00.cshtml"
                     Write(Localizer["ViewSMSVariable"]);

#line default
#line hidden
            EndContext();
            BeginContext(1002, 21, true);
            WriteLiteral("\',\r\n        Active: \'");
            EndContext();
            BeginContext(1024, 19, false);
#line 27 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\SMS\Views\Engine\ESE_01_00.cshtml"
            Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(1043, 19, true);
            WriteLiteral("\',\r\n        Edit: \'");
            EndContext();
            BeginContext(1063, 17, false);
#line 28 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\SMS\Views\Engine\ESE_01_00.cshtml"
          Write(Localizer["Edit"]);

#line default
#line hidden
            EndContext();
            BeginContext(1080, 19, true);
            WriteLiteral("\',\r\n        View: \'");
            EndContext();
            BeginContext(1100, 17, false);
#line 29 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\SMS\Views\Engine\ESE_01_00.cshtml"
          Write(Localizer["View"]);

#line default
#line hidden
            EndContext();
            BeginContext(1117, 22, true);
            WriteLiteral("\',\r\n         Delete: \'");
            EndContext();
            BeginContext(1140, 19, false);
#line 30 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\SMS\Views\Engine\ESE_01_00.cshtml"
             Write(Localizer["Delete"]);

#line default
#line hidden
            EndContext();
            BeginContext(1159, 26, true);
            WriteLiteral("\',\r\n         DeActivate: \'");
            EndContext();
            BeginContext(1186, 23, false);
#line 31 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\SMS\Views\Engine\ESE_01_00.cshtml"
                 Write(Localizer["DeActivate"]);

#line default
#line hidden
            EndContext();
            BeginContext(1209, 24, true);
            WriteLiteral("\',\r\n         Activate: \'");
            EndContext();
            BeginContext(1234, 21, false);
#line 32 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\SMS\Views\Engine\ESE_01_00.cshtml"
               Write(Localizer["Activate"]);

#line default
#line hidden
            EndContext();
            BeginContext(1255, 23, true);
            WriteLiteral("\',\r\n    };\r\n</script>\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1295, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1301, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9ea71aa687e6401f0ad0fb67e79364514d8915413166", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1348, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1354, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9ea71aa687e6401f0ad0fb67e79364514d8915414422", async() => {
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
                BeginContext(1408, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            BeginContext(1415, 577, true);
            WriteLiteral(@"<div class=""row padbot10"">
    <div class=""col-lg-12"">
        <div class=""SMSVariableContainer"">
            <table id=""jqgSMSVariable""></table>
            <div id=""jqpSMSVariable""></div>
        </div>
    </div>
</div>

<div class=""modal fade in"" id=""PopupSMSVariable"" data-keyboard=""false"" data-backdrop=""static"">
    <div class=""modal-dialog  modal-md"" role=""document"" style=""box-shadow:none;"">
        <div class=""modal-content "">
            <!-- Modal Header -->
            <div class=""modal-header popupHeader"">
                <h4 class=""modal-title"">");
            EndContext();
            BeginContext(1993, 27, false);
#line 54 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\SMS\Views\Engine\ESE_01_00.cshtml"
                                   Write(Localizer["AddSMSVariable"]);

#line default
#line hidden
            EndContext();
            BeginContext(2020, 390, true);
            WriteLiteral(@"</h4>
                <button type=""button"" class=""close ml-auto"" data-dismiss=""modal""> <i class=""fa fa-times""></i></button>
            </div>

            <div class=""modal-body"">
                <div class=""row"">
                    <div class=""col-lg-3 col-md-6 col-sm-6"">
                        <div class=""form-group"">
                            <label for=""txtSMSVariable"">");
            EndContext();
            BeginContext(2411, 24, false);
#line 62 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\SMS\Views\Engine\ESE_01_00.cshtml"
                                                   Write(Localizer["SMSVariable"]);

#line default
#line hidden
            EndContext();
            BeginContext(2435, 345, true);
            WriteLiteral(@"</label>
                            <input id=""txtSMSVariable"" class=""form-control"" maxlength=""6"" type=""text"" />
                        </div>
                    </div>
                    <div class=""col-lg-9 col-md-6 col-sm-6"">
                        <div class=""form-group"">
                            <label for=""txtSMSComponent"">");
            EndContext();
            BeginContext(2781, 25, false);
#line 68 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\SMS\Views\Engine\ESE_01_00.cshtml"
                                                    Write(Localizer["SMSComponent"]);

#line default
#line hidden
            EndContext();
            BeginContext(2806, 686, true);
            WriteLiteral(@"</label>
                            <input id=""txtSMSComponent"" class=""form-control"" maxlength=""50"" type=""text"" />
                        </div>
                    </div>
                    <div class=""col-lg-6 col-md-6 col-sm-6"">
                        <div class=""form-group"">
                            <div class=""default-checkbox padtop0 padbot15"">
                                <label class=""mdl-checkbox mdl-js-checkbox mdl-js-ripple-effect"" for=""chkActiveStatus"">
                                    <input type=""checkbox"" id=""chkActiveStatus"" checked=""checked"" class=""mdl-checkbox__input"">
                                    <span class=""mdl-checkbox__label"">");
            EndContext();
            BeginContext(3493, 19, false);
#line 77 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\SMS\Views\Engine\ESE_01_00.cshtml"
                                                                 Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(3512, 534, true);
            WriteLiteral(@"</span>
                                </label>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""modal-footer"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <button class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent primary-button"" id=""btnSaveSMSVariable"" onclick=""fnSaveSMSVariable()"">
                            ");
            EndContext();
            BeginContext(4047, 17, false);
#line 88 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\SMS\Views\Engine\ESE_01_00.cshtml"
                       Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(4064, 246, true);
            WriteLiteral("\r\n                        </button>\r\n                        <button type=\"button\" class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect\" id=\"btnDeactivateSMSVariable\" onclick=\"fnDeleteSMSVariable()\"><i class=\"fas fa-ban\"></i>  ");
            EndContext();
            BeginContext(4311, 23, false);
#line 90 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\SMS\Views\Engine\ESE_01_00.cshtml"
                                                                                                                                                                                                            Write(Localizer["DeActivate"]);

#line default
#line hidden
            EndContext();
            BeginContext(4334, 219, true);
            WriteLiteral(" </button>\r\n                        <button class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect  cancel-button cancel-button\" data-dismiss=\"modal\" id=\"btnCancelSMSVariable\" onclick=\"fnClearFields()\">");
            EndContext();
            BeginContext(4554, 19, false);
#line 91 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\SMS\Views\Engine\ESE_01_00.cshtml"
                                                                                                                                                                                                          Write(Localizer["Cancel"]);

#line default
#line hidden
            EndContext();
            BeginContext(4573, 118, true);
            WriteLiteral(" </button>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
