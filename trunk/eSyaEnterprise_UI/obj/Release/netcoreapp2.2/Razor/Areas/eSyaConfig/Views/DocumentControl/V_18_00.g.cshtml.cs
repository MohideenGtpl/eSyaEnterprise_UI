#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaConfig\Views\DocumentControl\V_18_00.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd0e62ed884a9a8f75ddaa253003a1b1414f2119"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_eSyaConfig_Views_DocumentControl_V_18_00), @"mvc.1.0.view", @"/Areas/eSyaConfig/Views/DocumentControl/V_18_00.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/eSyaConfig/Views/DocumentControl/V_18_00.cshtml", typeof(AspNetCore.Areas_eSyaConfig_Views_DocumentControl_V_18_00))]
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
#line 1 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaConfig\Views\DocumentControl\V_18_00.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd0e62ed884a9a8f75ddaa253003a1b1414f2119", @"/Areas/eSyaConfig/Views/DocumentControl/V_18_00.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Areas/eSyaConfig/Views/_ViewImports.cshtml")]
    public class Areas_eSyaConfig_Views_DocumentControl_V_18_00 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Config/CalendarDefinition.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(82, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaConfig\Views\DocumentControl\V_18_00.cshtml"
  
    ViewData["Title"] = "V_26_00";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(174, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(193, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(199, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd0e62ed884a9a8f75ddaa253003a1b1414f21194357", async() => {
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
                BeginContext(256, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
#line 13 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaConfig\Views\DocumentControl\V_18_00.cshtml"
  
    var userFormRole = (eSyaEnterprise_UI.Models.DO_UserFormRole)ViewBag.UserFormRole;

#line default
#line hidden
            BeginContext(356, 46, true);
            WriteLiteral("<script>\r\n    var _userFormRole = JSON.parse(\'");
            EndContext();
            BeginContext(403, 38, false);
#line 17 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaConfig\Views\DocumentControl\V_18_00.cshtml"
                               Write(Html.Raw(Json.Serialize(userFormRole)));

#line default
#line hidden
            EndContext();
            BeginContext(441, 59, true);
            WriteLiteral("\');\r\n\r\n     var localization = {\r\n         FinancialYear: \'");
            EndContext();
            BeginContext(501, 26, false);
#line 20 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaConfig\Views\DocumentControl\V_18_00.cshtml"
                    Write(Localizer["FinancialYear"]);

#line default
#line hidden
            EndContext();
            BeginContext(527, 24, true);
            WriteLiteral("\',\r\n         FromDate: \'");
            EndContext();
            BeginContext(552, 21, false);
#line 21 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaConfig\Views\DocumentControl\V_18_00.cshtml"
               Write(Localizer["FromDate"]);

#line default
#line hidden
            EndContext();
            BeginContext(573, 24, true);
            WriteLiteral("\',\r\n         TillDate: \'");
            EndContext();
            BeginContext(598, 21, false);
#line 22 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaConfig\Views\DocumentControl\V_18_00.cshtml"
               Write(Localizer["TillDate"]);

#line default
#line hidden
            EndContext();
            BeginContext(619, 22, true);
            WriteLiteral("\',\r\n         Active: \'");
            EndContext();
            BeginContext(642, 19, false);
#line 23 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaConfig\Views\DocumentControl\V_18_00.cshtml"
             Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(661, 37, true);
            WriteLiteral("\',\r\n         AddCalendarDefinition: \'");
            EndContext();
            BeginContext(699, 34, false);
#line 24 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaConfig\Views\DocumentControl\V_18_00.cshtml"
                            Write(Localizer["AddCalendarDefinition"]);

#line default
#line hidden
            EndContext();
            BeginContext(733, 38, true);
            WriteLiteral("\',\r\n         ViewCalendarDefinition: \'");
            EndContext();
            BeginContext(772, 35, false);
#line 25 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaConfig\Views\DocumentControl\V_18_00.cshtml"
                             Write(Localizer["ViewCalendarDefinition"]);

#line default
#line hidden
            EndContext();
            BeginContext(807, 20, true);
            WriteLiteral("\',\r\n         Save: \'");
            EndContext();
            BeginContext(828, 17, false);
#line 26 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaConfig\Views\DocumentControl\V_18_00.cshtml"
           Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(845, 22, true);
            WriteLiteral("\',\r\n         Cancel: \'");
            EndContext();
            BeginContext(868, 19, false);
#line 27 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaConfig\Views\DocumentControl\V_18_00.cshtml"
             Write(Localizer["Cancel"]);

#line default
#line hidden
            EndContext();
            BeginContext(887, 143, true);
            WriteLiteral("\',\r\n    };\r\n</script>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-lg-3 col-md-4 col-sm-6\">\r\n        <div class=\"form-group\">\r\n            <label>");
            EndContext();
            BeginContext(1031, 29, false);
#line 34 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaConfig\Views\DocumentControl\V_18_00.cshtml"
              Write(Localizer["BusinessLocation"]);

#line default
#line hidden
            EndContext();
            BeginContext(1060, 22, true);
            WriteLiteral("</label>\r\n            ");
            EndContext();
            BeginContext(1083, 51, false);
#line 35 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaConfig\Views\DocumentControl\V_18_00.cshtml"
       Write(await Component.InvokeAsync("UserBusinessLocation"));

#line default
#line hidden
            EndContext();
            BeginContext(1134, 678, true);
            WriteLiteral(@"
        </div>
    </div>
</div>

<div class=""row padbot10"">
    <div class=""col-lg-12 col-md-12 col-sm-12"">
        <table id=""jqgCalendarDefinition""></table>
        <div id=""jqpCalendarDefinition""></div>
    </div>
</div>


<div class=""modal fade in"" id=""PopupCalendarDefinition"" data-keyboard=""false"" data-backdrop=""static"">
    <div class=""modal-dialog modal-md  "" role=""document"" style=""box-shadow:none;"">
        <div class=""modal-content "">
            <div class=""modal-header popupHeader"">
                <button type=""button"" class=""close ml-auto"" data-dismiss=""modal""> <i class=""fa fa-times""></i></button>
                <h4 class=""modal-title"">");
            EndContext();
            BeginContext(1813, 34, false);
#line 53 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaConfig\Views\DocumentControl\V_18_00.cshtml"
                                   Write(Localizer["AddCalendarDefinition"]);

#line default
#line hidden
            EndContext();
            BeginContext(1847, 505, true);
            WriteLiteral(@"</h4>
            </div>

            <div class=""modal-body"">
                <div class=""row"">
                    <div class=""col-sm-12"">
                        <input type=""text"" class=""form-control"" id=""txtCodeType"" style=""display:none"">
                    </div>
                </div>
                <div class=""row padbot4"">

                    <div class=""col-lg-6 col-md-6 col-sm-6 col-xs-12"">
                        <div class=""form-group"">
                            <label>");
            EndContext();
            BeginContext(2353, 26, false);
#line 66 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaConfig\Views\DocumentControl\V_18_00.cshtml"
                              Write(Localizer["Financialyear"]);

#line default
#line hidden
            EndContext();
            BeginContext(2379, 400, true);
            WriteLiteral(@"</label>
                            <input class=""form-control"" type=""text"" maxlength=""4"" id=""txtfinancialyear"" data-inputmask=""'mask': '9', 'repeat': 10, 'greedy' : false"" />

                        </div>
                    </div>

                    <div class=""col-lg-6 col-md-6 col-sm-6 col-xs-12"">
                        <div class=""form-group"">
                            <label>");
            EndContext();
            BeginContext(2780, 21, false);
#line 74 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaConfig\Views\DocumentControl\V_18_00.cshtml"
                              Write(Localizer["FromDate"]);

#line default
#line hidden
            EndContext();
            BeginContext(2801, 342, true);
            WriteLiteral(@"</label>
                            <input id=""txtCalDefFRMDate"" class=""form-control"" type=""date"" autocomplete=""off"" />

                        </div>
                    </div>
                    <div class=""col-lg-6 col-md-6 col-sm-6 col-xs-12"">
                        <div class=""form-group"">
                            <label>");
            EndContext();
            BeginContext(3144, 21, false);
#line 81 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaConfig\Views\DocumentControl\V_18_00.cshtml"
                              Write(Localizer["TillDate"]);

#line default
#line hidden
            EndContext();
            BeginContext(3165, 610, true);
            WriteLiteral(@"</label>
                            <input id=""txtCalDefTillDate"" class=""form-control"" type=""date"" autocomplete=""off"" disabled />
                        </div>
                    </div>
                    <div class=""col-lg-6 col-md-6 col-sm-6 col-xs-12"">
                        <div class=""default-checkbox"">
                            <label class=""mdl-checkbox mdl-js-checkbox mdl-js-ripple-effect"" for=""chkActiveStatus"">
                                <input type=""checkbox"" id=""chkActiveStatus"" class=""mdl-checkbox__input"">
                                <span class=""mdl-checkbox__label"">");
            EndContext();
            BeginContext(3776, 19, false);
#line 89 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaConfig\Views\DocumentControl\V_18_00.cshtml"
                                                             Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(3795, 537, true);
            WriteLiteral(@"</span>
                            </label>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""modal-footer"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <button class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent primary-button"" id=""btnSaveCalendarDefinition"" onclick=""fnSaveCalendarDefinition()"">
                            <i class=""fa fa-save""></i>   ");
            EndContext();
            BeginContext(4333, 17, false);
#line 99 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaConfig\Views\DocumentControl\V_18_00.cshtml"
                                                    Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(4350, 227, true);
            WriteLiteral("\r\n                        </button>\r\n                        <button class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect  cancel-button cancel-button\" data-dismiss=\"modal\" id=\"#\"><i class=\"fa fa-times\"></i> ");
            EndContext();
            BeginContext(4578, 19, false);
#line 101 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaConfig\Views\DocumentControl\V_18_00.cshtml"
                                                                                                                                                                                         Write(Localizer["Cancel"]);

#line default
#line hidden
            EndContext();
            BeginContext(4597, 119, true);
            WriteLiteral("</button>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
