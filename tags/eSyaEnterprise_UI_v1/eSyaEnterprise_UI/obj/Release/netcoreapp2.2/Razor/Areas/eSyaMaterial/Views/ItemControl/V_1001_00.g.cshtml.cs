#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1001_00.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68ab8eeeb69eae1e3d9362d1ae002baff5d3ee14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_eSyaMaterial_Views_ItemControl_V_1001_00), @"mvc.1.0.view", @"/Areas/eSyaMaterial/Views/ItemControl/V_1001_00.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/eSyaMaterial/Views/ItemControl/V_1001_00.cshtml", typeof(AspNetCore.Areas_eSyaMaterial_Views_ItemControl_V_1001_00))]
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
#line 1 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1001_00.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68ab8eeeb69eae1e3d9362d1ae002baff5d3ee14", @"/Areas/eSyaMaterial/Views/ItemControl/V_1001_00.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Areas/eSyaMaterial/Views/_ViewImports.cshtml")]
    public class Areas_eSyaMaterial_Views_ItemControl_V_1001_00 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jsTree.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/jsTree.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/eSyaMaterial/ItemGroup.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1001_00.cshtml"
  
    ViewData["Title"] = @Localizer["ItemGroup"];
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#line 7 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1001_00.cshtml"
  
    var userFormRole = (eSyaEnterprise_UI.Models.DO_UserFormRole)ViewBag.UserFormRole;

#line default
#line hidden
            BeginContext(280, 46, true);
            WriteLiteral("<script>\r\n    var _userFormRole = JSON.parse(\'");
            EndContext();
            BeginContext(327, 38, false);
#line 11 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1001_00.cshtml"
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68ab8eeeb69eae1e3d9362d1ae002baff5d3ee145956", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "68ab8eeeb69eae1e3d9362d1ae002baff5d3ee147209", async() => {
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
                BeginContext(503, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68ab8eeeb69eae1e3d9362d1ae002baff5d3ee148541", async() => {
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
                BeginContext(557, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(562, 1419, true);
            WriteLiteral(@"

<style>


    .w-120 {
        width: 120px !important
    }

    .mdl-card__title {
        max-height: 45px !important;
        display: block !important;
        padding-left: 0px !important;
        padding-top: 0px !important;
    }

    .mdl-card {
        min-height: auto !important
    }
     
    hr {
        border-color: #f1f1f1 !important;
    }

    #pnlAddMainMenu, #pnlAddSubMenu {
        width: 100%;
    }

    #lblItemGroup {
        cursor: pointer;
        padding: 2px 4px;
    }

        #lblItemGroup:hover {
            background: #e7f4f9;
            box-shadow: inset 0 0 1px #cccccc;
        }

    .bootstrap-select:not([class*=col-]):not([class*=form-control]):not(.input-group-btn) {
        width: 100% !important
    }

    hr {
        margin-bottom: 8px;
        margin-top: 8px;
    }
</style>

<div class=""row row-bottom-pad"">
    <div class=""col-sm-4 col-md-4 col-lg-4"">

        <div id=""ItemGroupTree"">
        </div>
    </di");
            WriteLiteral(@"v>
    <div class=""col-sm-1 col-md-1 col-lg-1""></div>
    <div id=""dvItemGroup"" class=""col-lg-7 col-md-7 col-sm-7 f-right"" style=""display:none;"">

        <div class=""demo-card-square mdl-card mdl-shadow--2dp marbot15 fullwidth"" id=""pnlAddItemGroup"">
            <div class=""mdl-card__title mdl-card--expand padleft0 padtop0 h-60 d-block"">
                <h5 class=""mdl-card__title-text"">");
            EndContext();
            BeginContext(1982, 25, false);
#line 77 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1001_00.cshtml"
                                            Write(Localizer["AddItemGroup"]);

#line default
#line hidden
            EndContext();
            BeginContext(2007, 276, true);
            WriteLiteral(@" </h5>
            </div>
            <div class=""mdl-card__supporting-text fullwidth"">
                <div class=""row"">
                    <div class=""col-sm-12 col-md-12 col-lg-12"">
                        <div class=""form-group"">
                            <label>");
            EndContext();
            BeginContext(2284, 33, false);
#line 83 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1001_00.cshtml"
                              Write(Localizer["ItemGroupDescription"]);

#line default
#line hidden
            EndContext();
            BeginContext(2317, 605, true);
            WriteLiteral(@"</label>
                            <input type=""text"" maxlength=""50"" class=""form-control"" id=""txtItemGroupDesc"" />
                        </div>
                    </div>
                </div>
                <div class=""row "">
                    <div class=""col-lg-12"" style=""margin-bottom: 15px;"">
                        <label class=""mdl-checkbox mdl-js-checkbox"" for=""chkActiveStatus"">
                            <input type=""checkbox"" id=""chkActiveStatus""
                                   class=""mdl-checkbox__input"">
                            <span class=""mdl-checkbox__label"">");
            EndContext();
            BeginContext(2923, 19, false);
#line 93 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1001_00.cshtml"
                                                         Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(2942, 354, true);
            WriteLiteral(@"</span>
</label>
                    </div>

                </div>
                <hr />
                <div class=""mdl-card__actions text-center pad0"">
                    <button type=""button"" class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect"" id=""btnIGAdd"" onclick=""fnAddOrUpdateItemGroup()""><i class=""fa fa-save""></i> ");
            EndContext();
            BeginContext(3297, 17, false);
#line 100 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1001_00.cshtml"
                                                                                                                                                                                          Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(3314, 145, true);
            WriteLiteral("</button>\r\n</div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n</div>\r\n<script>\r\n    var localization = {       \r\n        AddItemGroup: \'");
            EndContext();
            BeginContext(3460, 25, false);
#line 110 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1001_00.cshtml"
                  Write(Localizer["AddItemGroup"]);

#line default
#line hidden
            EndContext();
            BeginContext(3485, 19, true);
            WriteLiteral("\',\r\n        Save: \'");
            EndContext();
            BeginContext(3505, 17, false);
#line 111 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1001_00.cshtml"
          Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(3522, 28, true);
            WriteLiteral("\',\r\n        ViewItemGroup: \'");
            EndContext();
            BeginContext(3551, 26, false);
#line 112 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1001_00.cshtml"
                   Write(Localizer["ViewItemGroup"]);

#line default
#line hidden
            EndContext();
            BeginContext(3577, 28, true);
            WriteLiteral("\',\r\n        EditItemGroup: \'");
            EndContext();
            BeginContext(3606, 26, false);
#line 113 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1001_00.cshtml"
                   Write(Localizer["EditItemGroup"]);

#line default
#line hidden
            EndContext();
            BeginContext(3632, 21, true);
            WriteLiteral("\',\r\n        Update: \'");
            EndContext();
            BeginContext(3654, 19, false);
#line 114 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1001_00.cshtml"
            Write(Localizer["Update"]);

#line default
#line hidden
            EndContext();
            BeginContext(3673, 36, true);
            WriteLiteral("\',        \r\n    }\r\n</script>\r\n\r\n\r\n\r\n");
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
