#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\DepartmentCodes\V_222_00.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3404f9086f58316a8cb22b02f9896e6f4eb6ef00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_eSyaConfig_Views_DepartmentCodes_V_222_00), @"mvc.1.0.view", @"/Areas/eSyaConfig/Views/DepartmentCodes/V_222_00.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/eSyaConfig/Views/DepartmentCodes/V_222_00.cshtml", typeof(AspNetCore.Areas_eSyaConfig_Views_DepartmentCodes_V_222_00))]
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
#line 1 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\DepartmentCodes\V_222_00.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3404f9086f58316a8cb22b02f9896e6f4eb6ef00", @"/Areas/eSyaConfig/Views/DepartmentCodes/V_222_00.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Areas/eSyaConfig/Views/_ViewImports.cshtml")]
    public class Areas_eSyaConfig_Views_DepartmentCodes_V_222_00 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Config/DepartmentCodes.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\DepartmentCodes\V_222_00.cshtml"
  
    ViewData["Title"] = "V_222_00";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            DefineSection("scripts", async() => {
                BeginContext(190, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(196, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3404f9086f58316a8cb22b02f9896e6f4eb6ef004219", async() => {
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
                BeginContext(250, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
#line 11 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\DepartmentCodes\V_222_00.cshtml"
  
    var userFormRole = (eSyaEnterprise_UI.Models.DO_UserFormRole)ViewBag.UserFormRole;

#line default
#line hidden
            BeginContext(350, 46, true);
            WriteLiteral("<script>\r\n    var _userFormRole = JSON.parse(\'");
            EndContext();
            BeginContext(397, 38, false);
#line 15 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\DepartmentCodes\V_222_00.cshtml"
                               Write(Html.Raw(Json.Serialize(userFormRole)));

#line default
#line hidden
            EndContext();
            BeginContext(435, 59, true);
            WriteLiteral("\');\r\n\r\n    var localization = {\r\n        DepartmentCodes: \'");
            EndContext();
            BeginContext(495, 28, false);
#line 18 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\DepartmentCodes\V_222_00.cshtml"
                     Write(Localizer["DepartmentCodes"]);

#line default
#line hidden
            EndContext();
            BeginContext(523, 36, true);
            WriteLiteral("\',\r\n        DepartmentDescription: \'");
            EndContext();
            BeginContext(560, 34, false);
#line 19 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\DepartmentCodes\V_222_00.cshtml"
                           Write(Localizer["DepartmentDescription"]);

#line default
#line hidden
            EndContext();
            BeginContext(594, 41, true);
            WriteLiteral("\',\r\n        DepartmentShortDescription: \'");
            EndContext();
            BeginContext(636, 39, false);
#line 20 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\DepartmentCodes\V_222_00.cshtml"
                                Write(Localizer["DepartmentShortDescription"]);

#line default
#line hidden
            EndContext();
            BeginContext(675, 21, true);
            WriteLiteral("\',\r\n        Active: \'");
            EndContext();
            BeginContext(697, 19, false);
#line 21 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\DepartmentCodes\V_222_00.cshtml"
            Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(716, 19, true);
            WriteLiteral("\',\r\n        Save: \'");
            EndContext();
            BeginContext(736, 17, false);
#line 22 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\DepartmentCodes\V_222_00.cshtml"
          Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(753, 21, true);
            WriteLiteral("\',\r\n        Cancel: \'");
            EndContext();
            BeginContext(775, 19, false);
#line 23 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\DepartmentCodes\V_222_00.cshtml"
            Write(Localizer["Cancel"]);

#line default
#line hidden
            EndContext();
            BeginContext(794, 27, true);
            WriteLiteral("\',\r\n        DepartmentID: \'");
            EndContext();
            BeginContext(822, 25, false);
#line 24 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\DepartmentCodes\V_222_00.cshtml"
                  Write(Localizer["DepartmentID"]);

#line default
#line hidden
            EndContext();
            BeginContext(847, 21, true);
            WriteLiteral("\',\r\n        Status: \'");
            EndContext();
            BeginContext(869, 19, false);
#line 25 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\DepartmentCodes\V_222_00.cshtml"
            Write(Localizer["Status"]);

#line default
#line hidden
            EndContext();
            BeginContext(888, 22, true);
            WriteLiteral("\',\r\n        Actions: \'");
            EndContext();
            BeginContext(911, 20, false);
#line 26 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\DepartmentCodes\V_222_00.cshtml"
             Write(Localizer["Actions"]);

#line default
#line hidden
            EndContext();
            BeginContext(931, 32, true);
            WriteLiteral("\',\r\n        AddDepartmentCode: \'");
            EndContext();
            BeginContext(964, 30, false);
#line 27 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\DepartmentCodes\V_222_00.cshtml"
                       Write(Localizer["AddDepartmentCode"]);

#line default
#line hidden
            EndContext();
            BeginContext(994, 35, true);
            WriteLiteral("\',\r\n        UpdateDepartmentCode: \'");
            EndContext();
            BeginContext(1030, 33, false);
#line 28 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\DepartmentCodes\V_222_00.cshtml"
                          Write(Localizer["UpdateDepartmentCode"]);

#line default
#line hidden
            EndContext();
            BeginContext(1063, 33, true);
            WriteLiteral("\',\r\n        ViewDepartmentCode: \'");
            EndContext();
            BeginContext(1097, 31, false);
#line 29 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\DepartmentCodes\V_222_00.cshtml"
                        Write(Localizer["ViewDepartmentCode"]);

#line default
#line hidden
            EndContext();
            BeginContext(1128, 21, true);
            WriteLiteral("\',\r\n        Update: \'");
            EndContext();
            BeginContext(1150, 19, false);
#line 30 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\DepartmentCodes\V_222_00.cshtml"
            Write(Localizer["Update"]);

#line default
#line hidden
            EndContext();
            BeginContext(1169, 25, true);
            WriteLiteral("\',\r\n        DeActivate: \'");
            EndContext();
            BeginContext(1195, 23, false);
#line 31 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\DepartmentCodes\V_222_00.cshtml"
                Write(Localizer["DeActivate"]);

#line default
#line hidden
            EndContext();
            BeginContext(1218, 23, true);
            WriteLiteral("\',\r\n        Activate: \'");
            EndContext();
            BeginContext(1242, 21, false);
#line 32 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\DepartmentCodes\V_222_00.cshtml"
              Write(Localizer["Activate"]);

#line default
#line hidden
            EndContext();
            BeginContext(1263, 21, true);
            WriteLiteral("\',\r\n        Delete: \'");
            EndContext();
            BeginContext(1285, 19, false);
#line 33 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\DepartmentCodes\V_222_00.cshtml"
            Write(Localizer["Delete"]);

#line default
#line hidden
            EndContext();
            BeginContext(1304, 19, true);
            WriteLiteral("\',\r\n        Edit: \'");
            EndContext();
            BeginContext(1324, 17, false);
#line 34 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\DepartmentCodes\V_222_00.cshtml"
          Write(Localizer["Edit"]);

#line default
#line hidden
            EndContext();
            BeginContext(1341, 19, true);
            WriteLiteral("\',\r\n        View: \'");
            EndContext();
            BeginContext(1361, 17, false);
#line 35 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\DepartmentCodes\V_222_00.cshtml"
          Write(Localizer["View"]);

#line default
#line hidden
            EndContext();
            BeginContext(1378, 664, true);
            WriteLiteral(@"',
    };
</script>

<div class=""row"">
    <div class=""col-lg-12 col-md-12 col-sm-12 form-group"">
        <table id=""jqgDepartmentCodes""></table>
        <div id=""jqpDepartmentCodes""></div>
    </div>
</div>
<div class=""modal fade"" id=""PopupDepartmentCodes"" data-keyboard=""false"" data-backdrop=""static"">
    <div class=""modal-dialog modal-md"" role=""document"" style=""box-shadow:none;"">
        <div class=""modal-content"">
            <div class=""modal-header popupHeader"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" onclick=""fnClearFields()""> <i class=""fa fa-times""></i></button>
                <h4 class=""modal-title"">");
            EndContext();
            BeginContext(2043, 28, false);
#line 50 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\DepartmentCodes\V_222_00.cshtml"
                                   Write(Localizer["DepartmentCodes"]);

#line default
#line hidden
            EndContext();
            BeginContext(2071, 423, true);
            WriteLiteral(@"</h4>
            </div>


            <div class=""modal-body"">
                <div class=""row padbot4"">
                    <div class=""col-sm-12"">
                        <input type=""text"" class=""form-control"" id=""txtDepartmentID"" style=""display:none"">
                    </div>
                    <div class=""col-lg-12"">
                        <div class=""form-group"">
                            <label>");
            EndContext();
            BeginContext(2495, 34, false);
#line 61 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\DepartmentCodes\V_222_00.cshtml"
                              Write(Localizer["DepartmentDescription"]);

#line default
#line hidden
            EndContext();
            BeginContext(2529, 337, true);
            WriteLiteral(@" </label>
                            <input id=""txtDepartmentDescription"" class=""form-control"" type=""text"" autocomplete=""off"" maxlength=""15"" />
                        </div>
                    </div>
                    <div class=""col-lg-12"">
                        <div class=""form-group"">
                            <label>");
            EndContext();
            BeginContext(2867, 39, false);
#line 67 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\DepartmentCodes\V_222_00.cshtml"
                              Write(Localizer["DepartmentShortDescription"]);

#line default
#line hidden
            EndContext();
            BeginContext(2906, 626, true);
            WriteLiteral(@" </label>
                            <input id=""txtDeptShortDescription"" class=""form-control"" type=""text"" autocomplete=""off"" maxlength=""6"" />
                        </div>
                    </div>

                    <div class=""col-lg-3  col-md-3 col-sm-12 col-xs-12"">
                        <div class=""default-checkbox"">
                            <label class=""mdl-checkbox mdl-js-checkbox mdl-js-ripple-effect"" for=""chkActiveStatus"">
                                <input type=""checkbox"" id=""chkActiveStatus"" class=""mdl-checkbox__input"">
                                <span class=""mdl-checkbox__label"">");
            EndContext();
            BeginContext(3533, 19, false);
#line 76 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\DepartmentCodes\V_222_00.cshtml"
                                                             Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(3552, 514, true);
            WriteLiteral(@"</span>
                            </label>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""modal-footer"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <button type=""button"" class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent primary-button"" id=""btnSaveDepartmentCode"" onclick=""fnSaveDepartmentCode()"">
                            ");
            EndContext();
            BeginContext(4067, 17, false);
#line 86 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\DepartmentCodes\V_222_00.cshtml"
                       Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(4084, 253, true);
            WriteLiteral("\r\n                        </button>\r\n                        <button type=\"button\" class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect\" id=\"btnDeactivateDepartmentCode\" onclick=\"fnDeleteDepartmentCodes()\"><i class=\"fas fa-ban\"></i>  ");
            EndContext();
            BeginContext(4338, 23, false);
#line 88 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\DepartmentCodes\V_222_00.cshtml"
                                                                                                                                                                                                                   Write(Localizer["DeActivate"]);

#line default
#line hidden
            EndContext();
            BeginContext(4361, 201, true);
            WriteLiteral(" </button>\r\n                        <button type=\"button\" class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect  cancel-button\" id=\"btnCancelDepartmentCode\" onclick=\"fnClearFields()\">");
            EndContext();
            BeginContext(4563, 19, false);
#line 89 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\DepartmentCodes\V_222_00.cshtml"
                                                                                                                                                                                        Write(Localizer["Cancel"]);

#line default
#line hidden
            EndContext();
            BeginContext(4582, 125, true);
            WriteLiteral("  </button>\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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