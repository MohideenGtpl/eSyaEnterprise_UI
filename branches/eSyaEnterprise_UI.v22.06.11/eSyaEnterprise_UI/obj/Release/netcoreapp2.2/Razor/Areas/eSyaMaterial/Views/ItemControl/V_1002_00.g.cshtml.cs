#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1002_00.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0c1d8bb06925ab491a9de2fdfbfa5f9265c5b93"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_eSyaMaterial_Views_ItemControl_V_1002_00), @"mvc.1.0.view", @"/Areas/eSyaMaterial/Views/ItemControl/V_1002_00.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/eSyaMaterial/Views/ItemControl/V_1002_00.cshtml", typeof(AspNetCore.Areas_eSyaMaterial_Views_ItemControl_V_1002_00))]
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
#line 1 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1002_00.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0c1d8bb06925ab491a9de2fdfbfa5f9265c5b93", @"/Areas/eSyaMaterial/Views/ItemControl/V_1002_00.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Areas/eSyaMaterial/Views/_ViewImports.cshtml")]
    public class Areas_eSyaMaterial_Views_ItemControl_V_1002_00 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jsTree.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/jsTree.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/eSyaMaterial/ItemCategory.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1002_00.cshtml"
  
    ViewData["Title"] = @Localizer["ItemCategory"];
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#line 7 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1002_00.cshtml"
  
    var userFormRole = (eSyaEnterprise_UI.Models.DO_UserFormRole)ViewBag.UserFormRole;

#line default
#line hidden
            BeginContext(282, 46, true);
            WriteLiteral("<script>\r\n    var _userFormRole = JSON.parse(\'");
            EndContext();
            BeginContext(329, 38, false);
#line 11 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1002_00.cshtml"
                               Write(Html.Raw(Json.Serialize(userFormRole)));

#line default
#line hidden
            EndContext();
            BeginContext(367, 18, true);
            WriteLiteral("\');\r\n</script>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(402, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(410, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0c1d8bb06925ab491a9de2fdfbfa5f9265c5b935970", async() => {
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
                BeginContext(448, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(454, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e0c1d8bb06925ab491a9de2fdfbfa5f9265c5b937223", async() => {
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
                BeginContext(503, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(509, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0c1d8bb06925ab491a9de2fdfbfa5f9265c5b938555", async() => {
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
                BeginContext(566, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(571, 1477, true);
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
    <div class=""col-sm-4 col-md-4 col-lg-4"" id=""divItemCategoryTree"">

        <div id=""ItemCategoryTree""");
            WriteLiteral(@">
        </div>
    </div>
    <div class=""col-sm-1 col-md-1 col-lg-1""></div>
    <div class=""col-lg-7 col-md-7 col-sm-7 f-right"">
        <div id=""dvItemCategory"" style=""display:none;"">
            <div class=""demo-card-square mdl-card mdl-shadow--2dp marbot15 fullwidth"" id=""pnlAddItemCategory"">
                <div class=""mdl-card__title mdl-card--expand padleft0 padtop0 h-60 d-block"">
                    <h5 class=""mdl-card__title-text"">");
            EndContext();
            BeginContext(2049, 28, false);
#line 81 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1002_00.cshtml"
                                                Write(Localizer["AddItemCategory"]);

#line default
#line hidden
            EndContext();
            BeginContext(2077, 322, true);
            WriteLiteral(@"</h5>
</div>
                <div class=""mdl-card__supporting-text fullwidth"">
                    <div class=""row "">
                        <div class=""col-sm-12 col-md-12 col-lg-12"">
                            <div class=""form-group"">
                                <label>
                                    ");
            EndContext();
            BeginContext(2400, 36, false);
#line 88 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1002_00.cshtml"
                               Write(Localizer["ItemCategoryDescription"]);

#line default
#line hidden
            EndContext();
            BeginContext(2436, 439, true);
            WriteLiteral(@"</label>
                                    <input type=""text"" maxlength=""50"" class=""form-control"" id=""txtItemCategoryDesc"" />

</div>

                        </div>
                    </div>
                    <div class=""row "">
                        <div class=""col-sm-6 col-md-6 col-lg-6"">
                            <div class=""form-group"">
                                <label>
                                    ");
            EndContext();
            BeginContext(2876, 25, false);
#line 99 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1002_00.cshtml"
                               Write(Localizer["BudgetAmount"]);

#line default
#line hidden
            EndContext();
            BeginContext(2901, 377, true);
            WriteLiteral(@"</label>
                                    <input type=""number"" min=""0"" class=""form-control currencyFormat"" id=""txtBudgetAmount"" />

</div>
                        </div>

                        <div class=""col-sm-6 col-md-6 col-lg-6"">
                            <div class=""form-group"">
                                <label>
                                    ");
            EndContext();
            BeginContext(3279, 30, false);
#line 108 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1002_00.cshtml"
                               Write(Localizer["CommittmentAmount"]);

#line default
#line hidden
            EndContext();
            BeginContext(3309, 634, true);
            WriteLiteral(@"</label>
                                    <input type=""number"" disabled=""disabled"" class=""form-control"" id=""txtCommittmentAmount"" />

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
            BeginContext(3944, 19, false);
#line 119 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1002_00.cshtml"
                                                             Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(3963, 397, true);
            WriteLiteral(@"</span>
</label>
                        </div>
                    </div>


                    <hr />
                    <div class=""mdl-card__actions text-center vertical-center pad0"">

                        <button type=""button"" class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect"" id=""btnICAdd"" onclick=""fnAddOrUpdateItemCategory()""><i class=""fa fa-save""></i> ");
            EndContext();
            BeginContext(4361, 17, false);
#line 128 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1002_00.cshtml"
                                                                                                                                                                                                 Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(4378, 187, true);
            WriteLiteral("</button>\r\n\r\n</div>\r\n\r\n\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n    </div>\r\n\r\n\r\n</div>\r\n<script>\r\n    var localization = {\r\n        \r\n        AddItemCategory: \'");
            EndContext();
            BeginContext(4566, 28, false);
#line 146 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1002_00.cshtml"
                     Write(Localizer["AddItemCategory"]);

#line default
#line hidden
            EndContext();
            BeginContext(4594, 19, true);
            WriteLiteral("\',\r\n        Save: \'");
            EndContext();
            BeginContext(4614, 17, false);
#line 147 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1002_00.cshtml"
          Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(4631, 31, true);
            WriteLiteral("\',\r\n        ViewItemCategory: \'");
            EndContext();
            BeginContext(4663, 29, false);
#line 148 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1002_00.cshtml"
                      Write(Localizer["ViewItemCategory"]);

#line default
#line hidden
            EndContext();
            BeginContext(4692, 31, true);
            WriteLiteral("\',\r\n        EditItemCategory: \'");
            EndContext();
            BeginContext(4724, 29, false);
#line 149 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1002_00.cshtml"
                      Write(Localizer["EditItemCategory"]);

#line default
#line hidden
            EndContext();
            BeginContext(4753, 28, true);
            WriteLiteral("\',       \r\n        Update: \'");
            EndContext();
            BeginContext(4782, 19, false);
#line 150 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1002_00.cshtml"
            Write(Localizer["Update"]);

#line default
#line hidden
            EndContext();
            BeginContext(4801, 22, true);
            WriteLiteral("\',\r\n\r\n    }\r\n</script>");
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