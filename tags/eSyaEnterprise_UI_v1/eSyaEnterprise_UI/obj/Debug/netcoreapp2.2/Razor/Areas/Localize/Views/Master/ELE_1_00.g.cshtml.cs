#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Master\ELE_1_00.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "507f77a6b8f5ebc2b58e47f8900c4c96ef914880"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Localize_Views_Master_ELE_1_00), @"mvc.1.0.view", @"/Areas/Localize/Views/Master/ELE_1_00.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Localize/Views/Master/ELE_1_00.cshtml", typeof(AspNetCore.Areas_Localize_Views_Master_ELE_1_00))]
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
#line 1 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Master\ELE_1_00.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"507f77a6b8f5ebc2b58e47f8900c4c96ef914880", @"/Areas/Localize/Views/Master/ELE_1_00.cshtml")]
    public class Areas_Localize_Views_Master_ELE_1_00 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Localize/LocalizationTableMapping.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(80, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 5 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Master\ELE_1_00.cshtml"
  
    ViewData["Title"] = "ELE_1_00";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(175, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(194, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(200, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "507f77a6b8f5ebc2b58e47f8900c4c96ef9148804057", async() => {
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
                BeginContext(265, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(270, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 15 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Master\ELE_1_00.cshtml"
  
    var userFormRole = (eSyaEnterprise_UI.Models.DO_UserFormRole)ViewBag.UserFormRole;

#line default
#line hidden
            BeginContext(369, 52, true);
            WriteLiteral("\r\n<script>\r\n        var _userFormRole = JSON.parse(\'");
            EndContext();
            BeginContext(422, 38, false);
#line 20 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Master\ELE_1_00.cshtml"
                                   Write(Html.Raw(Json.Serialize(userFormRole)));

#line default
#line hidden
            EndContext();
            BeginContext(460, 59, true);
            WriteLiteral("\');\r\n\r\n         var localization = {\r\n         TableCode: \'");
            EndContext();
            BeginContext(520, 22, false);
#line 23 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Master\ELE_1_00.cshtml"
                Write(Localizer["TableCode"]);

#line default
#line hidden
            EndContext();
            BeginContext(542, 26, true);
            WriteLiteral("\',\r\n         SchemaName: \'");
            EndContext();
            BeginContext(569, 23, false);
#line 24 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Master\ELE_1_00.cshtml"
                 Write(Localizer["SchemaName"]);

#line default
#line hidden
            EndContext();
            BeginContext(592, 32, true);
            WriteLiteral("\',\r\n         TableDescription: \'");
            EndContext();
            BeginContext(625, 29, false);
#line 25 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Master\ELE_1_00.cshtml"
                       Write(Localizer["TableDescription"]);

#line default
#line hidden
            EndContext();
            BeginContext(654, 22, true);
            WriteLiteral("\',\r\n         Active: \'");
            EndContext();
            BeginContext(677, 19, false);
#line 26 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Master\ELE_1_00.cshtml"
             Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(696, 23, true);
            WriteLiteral("\',\r\n         Actions: \'");
            EndContext();
            BeginContext(720, 20, false);
#line 27 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Master\ELE_1_00.cshtml"
              Write(Localizer["Actions"]);

#line default
#line hidden
            EndContext();
            BeginContext(740, 20, true);
            WriteLiteral("\',\r\n         Edit: \'");
            EndContext();
            BeginContext(761, 17, false);
#line 28 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Master\ELE_1_00.cshtml"
           Write(Localizer["Edit"]);

#line default
#line hidden
            EndContext();
            BeginContext(778, 20, true);
            WriteLiteral("\',\r\n         View: \'");
            EndContext();
            BeginContext(799, 17, false);
#line 29 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Master\ELE_1_00.cshtml"
           Write(Localizer["View"]);

#line default
#line hidden
            EndContext();
            BeginContext(816, 43, true);
            WriteLiteral("\',\r\n         AddLocalizationTableMapping: \'");
            EndContext();
            BeginContext(860, 40, false);
#line 30 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Master\ELE_1_00.cshtml"
                                  Write(Localizer["AddLocalizationTableMapping"]);

#line default
#line hidden
            EndContext();
            BeginContext(900, 20, true);
            WriteLiteral("\',\r\n         Save: \'");
            EndContext();
            BeginContext(921, 17, false);
#line 31 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Master\ELE_1_00.cshtml"
           Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(938, 44, true);
            WriteLiteral("\',\r\n         EditLocalizationTableMapping: \'");
            EndContext();
            BeginContext(983, 41, false);
#line 32 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Master\ELE_1_00.cshtml"
                                   Write(Localizer["EditLocalizationTableMapping"]);

#line default
#line hidden
            EndContext();
            BeginContext(1024, 22, true);
            WriteLiteral("\',\r\n         Update: \'");
            EndContext();
            BeginContext(1047, 19, false);
#line 33 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Master\ELE_1_00.cshtml"
             Write(Localizer["Update"]);

#line default
#line hidden
            EndContext();
            BeginContext(1066, 44, true);
            WriteLiteral("\',\r\n         ViewLocalizationTableMapping: \'");
            EndContext();
            BeginContext(1111, 41, false);
#line 34 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Master\ELE_1_00.cshtml"
                                   Write(Localizer["ViewLocalizationTableMapping"]);

#line default
#line hidden
            EndContext();
            BeginContext(1152, 22, true);
            WriteLiteral("\',\r\n         Delete: \'");
            EndContext();
            BeginContext(1175, 19, false);
#line 35 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Master\ELE_1_00.cshtml"
             Write(Localizer["Delete"]);

#line default
#line hidden
            EndContext();
            BeginContext(1194, 26, true);
            WriteLiteral("\',\r\n         DeActivate: \'");
            EndContext();
            BeginContext(1221, 23, false);
#line 36 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Master\ELE_1_00.cshtml"
                 Write(Localizer["DeActivate"]);

#line default
#line hidden
            EndContext();
            BeginContext(1244, 24, true);
            WriteLiteral("\',\r\n         Activate: \'");
            EndContext();
            BeginContext(1269, 21, false);
#line 37 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Master\ELE_1_00.cshtml"
               Write(Localizer["Activate"]);

#line default
#line hidden
            EndContext();
            BeginContext(1290, 652, true);
            WriteLiteral(@"',
    };


</script>

<div class=""row padbot10"">
    <div class=""col-lg-12 col-md-12 col-sm-12"">

        <table id=""jqgLocalizationTable""></table>
        <div id=""jqpLocalizationTable""></div>

    </div>
</div>

<div class=""modal fade"" id=""PopupLocalizationTable"" data-keyboard=""false"" data-backdrop=""static"">
    <div class=""modal-dialog modal-lg"" role=""document"" style=""box-shadow:none;"">
        <div class=""modal-content"">
            <div class=""modal-header popupHeader"">
                <button type=""button"" class=""close"" data-dismiss=""modal""> <i class=""fa fa-times""></i></button>
                <h4 class=""modal-title"">");
            EndContext();
            BeginContext(1943, 30, false);
#line 57 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Master\ELE_1_00.cshtml"
                                   Write(Localizer["LocalizationTable"]);

#line default
#line hidden
            EndContext();
            BeginContext(1973, 422, true);
            WriteLiteral(@" </h4>
            </div>
            <div class=""modal-body"">
                <div class=""row padbot4"">
                    <div class=""col-sm-12"">
                        <input type=""text"" class=""form-control"" id="""" style=""display:none"">
                    </div>
                    <div class=""col-lg-3 col-md-6 col-sm-6"">
                        <div class=""form-group"">
                            <label>");
            EndContext();
            BeginContext(2396, 22, false);
#line 66 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Master\ELE_1_00.cshtml"
                              Write(Localizer["TableCode"]);

#line default
#line hidden
            EndContext();
            BeginContext(2418, 364, true);
            WriteLiteral(@" </label>
                            <input id=""txtTableCode"" class=""form-control"" type=""text"" autocomplete=""off"" maxlength=""10"" pattern=""^[0-9 ]+$"" />

                        </div>
                    </div>
                    <div class=""col-lg-3 col-md-3 col-sm-6"">
                        <div class=""form-group"">
                            <label>");
            EndContext();
            BeginContext(2783, 23, false);
#line 73 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Master\ELE_1_00.cshtml"
                              Write(Localizer["SchemaName"]);

#line default
#line hidden
            EndContext();
            BeginContext(2806, 369, true);
            WriteLiteral(@" </label>
                            <input id=""txtSchemaName"" class=""form-control"" type=""text"" autocomplete=""off"" maxlength=""10"" pattern=""^[a-zA-Z _]+$"" />
                        </div>
                    </div>
                    <div class=""col-lg-6 col-md-12 col-sm-12"">
                        <div class=""form-group"">
                            <label>");
            EndContext();
            BeginContext(3176, 29, false);
#line 79 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Master\ELE_1_00.cshtml"
                              Write(Localizer["TableDescription"]);

#line default
#line hidden
            EndContext();
            BeginContext(3205, 622, true);
            WriteLiteral(@" </label>
                            <input id=""txtTableDesc"" class=""form-control"" type=""text"" autocomplete=""off"" maxlength=""50"" />
                        </div>
                    </div>
                    <div class=""col-lg-3 col-md-4 col-sm-12 col-xs-12"">
                        <div class=""default-checkbox separate"">
                            <label class=""mdl-checkbox mdl-js-checkbox mdl-js-ripple-effect"" for=""chkActiveStatus"">
                                <input type=""checkbox"" id=""chkActiveStatus"" class=""mdl-checkbox__input"">
                                <span class=""mdl-checkbox__label"">");
            EndContext();
            BeginContext(3828, 19, false);
#line 87 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Master\ELE_1_00.cshtml"
                                                             Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(3847, 511, true);
            WriteLiteral(@" </span>
                            </label>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""modal-footer"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <button type=""button"" class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent primary-button"" id=""btnSave"" onclick=""fnSaveLocalizationTableMapping()"">
                            ");
            EndContext();
            BeginContext(4359, 17, false);
#line 97 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Master\ELE_1_00.cshtml"
                       Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(4376, 272, true);
            WriteLiteral(@"
                        </button>
                        <button type=""button"" class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect"" id=""btnDeactivateLocalizationTableMapping"" onclick=""fnDeleteLocalizationTableMapping()""><i class=""fas fa-ban""></i>  ");
            EndContext();
            BeginContext(4649, 23, false);
#line 99 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Master\ELE_1_00.cshtml"
                                                                                                                                                                                                                                      Write(Localizer["DeActivate"]);

#line default
#line hidden
            EndContext();
            BeginContext(4672, 220, true);
            WriteLiteral(" </button>\r\n                        <button type=\"button\" class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect  cancel-button\" data-dismiss=\"modal\" onclick=\"fnClosePopUp()\"><i class=\"fa fa-times\"></i> ");
            EndContext();
            BeginContext(4893, 19, false);
#line 100 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Master\ELE_1_00.cshtml"
                                                                                                                                                                                                           Write(Localizer["Cancel"]);

#line default
#line hidden
            EndContext();
            BeginContext(4912, 130, true);
            WriteLiteral(" </button>\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n");
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