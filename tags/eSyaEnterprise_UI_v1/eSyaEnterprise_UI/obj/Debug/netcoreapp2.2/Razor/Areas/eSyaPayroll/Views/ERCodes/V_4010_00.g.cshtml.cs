#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaPayroll\Views\ERCodes\V_4010_00.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a416faedfa2d274c84ae1765dc1ac40177846c55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_eSyaPayroll_Views_ERCodes_V_4010_00), @"mvc.1.0.view", @"/Areas/eSyaPayroll/Views/ERCodes/V_4010_00.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/eSyaPayroll/Views/ERCodes/V_4010_00.cshtml", typeof(AspNetCore.Areas_eSyaPayroll_Views_ERCodes_V_4010_00))]
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
#line 1 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaPayroll\Views\ERCodes\V_4010_00.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a416faedfa2d274c84ae1765dc1ac40177846c55", @"/Areas/eSyaPayroll/Views/ERCodes/V_4010_00.cshtml")]
    public class Areas_eSyaPayroll_Views_ERCodes_V_4010_00 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/eSyaPayroll/ERCodes.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaPayroll\Views\ERCodes\V_4010_00.cshtml"
  
    ViewData["Title"] = "V_4010_OO";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(176, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(195, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(201, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a416faedfa2d274c84ae1765dc1ac40177846c554187", async() => {
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
                BeginContext(252, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(257, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 14 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaPayroll\Views\ERCodes\V_4010_00.cshtml"
  
    var userFormRole = (eSyaEnterprise_UI.Models.DO_UserFormRole)ViewBag.UserFormRole;

#line default
#line hidden
            BeginContext(354, 46, true);
            WriteLiteral("<script>\r\n    var _userFormRole = JSON.parse(\'");
            EndContext();
            BeginContext(401, 38, false);
#line 18 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaPayroll\Views\ERCodes\V_4010_00.cshtml"
                               Write(Html.Raw(Json.Serialize(userFormRole)));

#line default
#line hidden
            EndContext();
            BeginContext(439, 55, true);
            WriteLiteral("\');\r\n\r\n     var localization = {\r\n         AddERCode: \'");
            EndContext();
            BeginContext(495, 22, false);
#line 21 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaPayroll\Views\ERCodes\V_4010_00.cshtml"
                Write(Localizer["AddERCode"]);

#line default
#line hidden
            EndContext();
            BeginContext(517, 22, true);
            WriteLiteral("\',\r\n         ERCode: \'");
            EndContext();
            BeginContext(540, 19, false);
#line 22 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaPayroll\Views\ERCodes\V_4010_00.cshtml"
             Write(Localizer["ERCode"]);

#line default
#line hidden
            EndContext();
            BeginContext(559, 27, true);
            WriteLiteral("\',\r\n         Description: \'");
            EndContext();
            BeginContext(587, 24, false);
#line 23 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaPayroll\Views\ERCodes\V_4010_00.cshtml"
                  Write(Localizer["Description"]);

#line default
#line hidden
            EndContext();
            BeginContext(611, 22, true);
            WriteLiteral("\',\r\n         Active: \'");
            EndContext();
            BeginContext(634, 19, false);
#line 24 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaPayroll\Views\ERCodes\V_4010_00.cshtml"
             Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(653, 23, true);
            WriteLiteral("\',\r\n         Actions: \'");
            EndContext();
            BeginContext(677, 20, false);
#line 25 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaPayroll\Views\ERCodes\V_4010_00.cshtml"
              Write(Localizer["Actions"]);

#line default
#line hidden
            EndContext();
            BeginContext(697, 20, true);
            WriteLiteral("\',\r\n         Edit: \'");
            EndContext();
            BeginContext(718, 17, false);
#line 26 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaPayroll\Views\ERCodes\V_4010_00.cshtml"
           Write(Localizer["Edit"]);

#line default
#line hidden
            EndContext();
            BeginContext(735, 20, true);
            WriteLiteral("\',\r\n         View: \'");
            EndContext();
            BeginContext(756, 17, false);
#line 27 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaPayroll\Views\ERCodes\V_4010_00.cshtml"
           Write(Localizer["View"]);

#line default
#line hidden
            EndContext();
            BeginContext(773, 20, true);
            WriteLiteral("\',\r\n         Save: \'");
            EndContext();
            BeginContext(794, 17, false);
#line 28 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaPayroll\Views\ERCodes\V_4010_00.cshtml"
           Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(811, 26, true);
            WriteLiteral("\',\r\n         EditERCode: \'");
            EndContext();
            BeginContext(838, 23, false);
#line 29 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaPayroll\Views\ERCodes\V_4010_00.cshtml"
                 Write(Localizer["EditERCode"]);

#line default
#line hidden
            EndContext();
            BeginContext(861, 22, true);
            WriteLiteral("\',\r\n         Update: \'");
            EndContext();
            BeginContext(884, 19, false);
#line 30 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaPayroll\Views\ERCodes\V_4010_00.cshtml"
             Write(Localizer["Update"]);

#line default
#line hidden
            EndContext();
            BeginContext(903, 26, true);
            WriteLiteral("\',\r\n         ViewERCode: \'");
            EndContext();
            BeginContext(930, 23, false);
#line 31 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaPayroll\Views\ERCodes\V_4010_00.cshtml"
                 Write(Localizer["ViewERCode"]);

#line default
#line hidden
            EndContext();
            BeginContext(953, 603, true);
            WriteLiteral(@"',
    };

</script>

<div class=""row"">
    <div class=""col-lg-12"">
        <table id=""jqgERCode""></table>
        <div id=""jqpERCode""></div>
    </div>
</div>



<div class=""modal fade in"" id=""PopupERCodes"" data-keyboard=""false"" data-backdrop=""static"">
    <div class=""modal-dialog modal-lg  "" role=""document"" style=""box-shadow:none;"">
        <div class=""modal-content "">
            <div class=""modal-header popupHeader"">
                <button type=""button"" class=""close ml-auto"" data-dismiss=""modal""> <i class=""fa fa-times""></i></button>
                <h4 class=""modal-title"">");
            EndContext();
            BeginContext(1557, 22, false);
#line 50 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaPayroll\Views\ERCodes\V_4010_00.cshtml"
                                   Write(Localizer["AddERCode"]);

#line default
#line hidden
            EndContext();
            BeginContext(1579, 202, true);
            WriteLiteral("</h4>\r\n            </div>\r\n            <div class=\"modal-body\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-lg-12 form-group\">\r\n                        <p class=\"subheading\">");
            EndContext();
            BeginContext(1782, 20, false);
#line 55 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaPayroll\Views\ERCodes\V_4010_00.cshtml"
                                         Write(Localizer["ERCodes"]);

#line default
#line hidden
            EndContext();
            BeginContext(1802, 255, true);
            WriteLiteral(" </p>\r\n                        <hr class=\"left\" />\r\n                    </div>\r\n\r\n                    <div class=\"col-lg-3 col-md-3 col-sm-3 col-xs-12\">\r\n                        <div class=\"form-group\">\r\n                            <label for=\"txtERCode\">");
            EndContext();
            BeginContext(2058, 19, false);
#line 61 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaPayroll\Views\ERCodes\V_4010_00.cshtml"
                                              Write(Localizer["ERCode"]);

#line default
#line hidden
            EndContext();
            BeginContext(2077, 421, true);
            WriteLiteral(@" </label>
                            <input class=""form-control"" type=""text"" maxlength=""9"" id=""txtERCode"" data-inputmask=""'mask': '9', 'repeat': 10, 'greedy' : false"" />

                        </div>
                    </div>

                    <div class=""col-lg-9 col-md-9 col-sm-9 col-xs-12"">
                        <div class=""form-group"">
                            <label for=""txtErCodeDescription"">");
            EndContext();
            BeginContext(2499, 26, false);
#line 69 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaPayroll\Views\ERCodes\V_4010_00.cshtml"
                                                         Write(Localizer["ERDescription"]);

#line default
#line hidden
            EndContext();
            BeginContext(2525, 679, true);
            WriteLiteral(@"</label>
                            <input id=""txtErCodeDescription"" class=""form-control"" maxlength=""50"" type=""text"" />

                        </div>
                    </div>

                    <div class=""col-lg-2 col-md-3 col-sm-3 col-xs-12"">
                        <div class=""form-group"">
                            <div class=""default-checkbox separate"">
                                <label class=""mdl-checkbox mdl-js-checkbox mdl-js-ripple-effect"" for=""chkActiveStatus"">
                                    <input type=""checkbox"" id=""chkActiveStatus"" class=""mdl-checkbox__input"">
                                    <span class=""mdl-checkbox__label"">");
            EndContext();
            BeginContext(3205, 19, false);
#line 80 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaPayroll\Views\ERCodes\V_4010_00.cshtml"
                                                                 Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(3224, 315, true);
            WriteLiteral(@"</span>
                                </label>
                            </div>

                        </div>
                    </div>

                </div>

                <div class=""col-lg-8 col-md-8 col-sm-12 padbot10"">
                    <div class=""form-group"">
                        ");
            EndContext();
            BeginContext(3540, 74, false);
#line 91 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaPayroll\Views\ERCodes\V_4010_00.cshtml"
                   Write(await Component.InvokeAsync("eSyaParameter", new { parameterType = "12" }));

#line default
#line hidden
            EndContext();
            BeginContext(3614, 381, true);
            WriteLiteral(@"
                    </div>
                </div>

            </div>

            <div class=""modal-footer"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <button class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent primary-button"" id=""btnSaveERCode"" onclick=""fnSaveERCode()"">");
            EndContext();
            BeginContext(3996, 17, false);
#line 100 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaPayroll\Views\ERCodes\V_4010_00.cshtml"
                                                                                                                                                                                  Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(4013, 191, true);
            WriteLiteral("  </button>\r\n\r\n                        <button class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect  cancel-button cancel-button\" data-dismiss=\"modal\" id=\"btnCancelERCode\">");
            EndContext();
            BeginContext(4205, 19, false);
#line 102 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaPayroll\Views\ERCodes\V_4010_00.cshtml"
                                                                                                                                                                           Write(Localizer["Cancel"]);

#line default
#line hidden
            EndContext();
            BeginContext(4224, 125, true);
            WriteLiteral("</button>\r\n\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
