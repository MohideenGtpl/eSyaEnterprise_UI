#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1004_00.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17e5cbef5496caf3ceb4fd6b225041d9161288e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_eSyaMaterial_Views_ItemControl_V_1004_00), @"mvc.1.0.view", @"/Areas/eSyaMaterial/Views/ItemControl/V_1004_00.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/eSyaMaterial/Views/ItemControl/V_1004_00.cshtml", typeof(AspNetCore.Areas_eSyaMaterial_Views_ItemControl_V_1004_00))]
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
#line 1 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1004_00.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17e5cbef5496caf3ceb4fd6b225041d9161288e7", @"/Areas/eSyaMaterial/Views/ItemControl/V_1004_00.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Areas/eSyaMaterial/Views/_ViewImports.cshtml")]
    public class Areas_eSyaMaterial_Views_ItemControl_V_1004_00 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jsTree.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/jsTree.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/eSyaMaterial/ItemGroupCategoryMapping.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1004_00.cshtml"
  
    ViewData["Title"] = @Localizer["ItemGroup&CategoryLink"];
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#line 7 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1004_00.cshtml"
  
    var userFormRole = (eSyaEnterprise_UI.Models.DO_UserFormRole)ViewBag.UserFormRole;

#line default
#line hidden
            BeginContext(292, 46, true);
            WriteLiteral("<script>\r\n    var _userFormRole = JSON.parse(\'");
            EndContext();
            BeginContext(339, 38, false);
#line 11 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1004_00.cshtml"
                               Write(Html.Raw(Json.Serialize(userFormRole)));

#line default
#line hidden
            EndContext();
            BeginContext(377, 18, true);
            WriteLiteral("\');\r\n</script>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(412, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(418, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17e5cbef5496caf3ceb4fd6b225041d9161288e76411", async() => {
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
                BeginContext(456, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(462, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "17e5cbef5496caf3ceb4fd6b225041d9161288e77664", async() => {
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
                BeginContext(511, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(517, 69, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17e5cbef5496caf3ceb4fd6b225041d9161288e78996", async() => {
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
                BeginContext(586, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(591, 1477, true);
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
    <div class=""col-sm-4 col-md-4 col-lg-4"" id=""divItemGroupCategoryTree"">

        <div id=""ItemGroupCat");
            WriteLiteral(@"egoryTree"">
        </div>
    </div>

    <div class=""col-sm-1 col-md-1 col-lg-1"">
    </div>


    <div id=""dvItemGroupCate"" class=""col-lg-7 col-md-7 col-sm-7 f-right"" style=""display:none;"">

        <div class=""demo-card-square mdl-card mdl-shadow--2dp marbot15 fullwidth"" id=""pnlAddItemGroupCate"">
            <div class=""mdl-card__title mdl-card--expand padleft0 padtop0 h-60 d-block"">
                <h5 class=""mdl-card__title-text""> ");
            EndContext();
            BeginContext(2069, 35, false);
#line 84 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1004_00.cshtml"
                                             Write(Localizer["ItemGroup&CategoryLink"]);

#line default
#line hidden
            EndContext();
            BeginContext(2104, 311, true);
            WriteLiteral(@" </h5>
            </div>
            <div class=""mdl-card__supporting-text fullwidth"">
                <div class=""row "">
                    <div class=""col-sm-12 col-md-12 col-lg-12"">
                        <div class=""form-group"">
                            <label>
                                ");
            EndContext();
            BeginContext(2416, 22, false);
#line 91 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1004_00.cshtml"
                           Write(Localizer["ItemGroup"]);

#line default
#line hidden
            EndContext();
            BeginContext(2438, 225, true);
            WriteLiteral("\r\n                            </label>\r\n                            <div>\r\n                                <select class=\"selectpicker\" data-live-search=\"true\" id=\"cboitemgroup\" title=\"\">\r\n                                    ");
            EndContext();
            BeginContext(2663, 136, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17e5cbef5496caf3ceb4fd6b225041d9161288e713290", async() => {
                BeginContext(2681, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(2724, 28, false);
#line 96 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1004_00.cshtml"
                                   Write(Localizer["SelectItemGroup"]);

#line default
#line hidden
                EndContext();
                BeginContext(2752, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2799, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 98 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1004_00.cshtml"
                                     foreach (var group in ViewBag.ItemGroups)
                                    {

#line default
#line hidden
            BeginContext(2920, 40, true);
            WriteLiteral("                                        ");
            EndContext();
            BeginContext(2960, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17e5cbef5496caf3ceb4fd6b225041d9161288e715599", async() => {
                BeginContext(2996, 19, false);
#line 100 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1004_00.cshtml"
                                                                      Write(group.ItemGroupDesc);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 100 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1004_00.cshtml"
                                           WriteLiteral(group.ItemGroupId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3024, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 101 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1004_00.cshtml"
                                    }

#line default
#line hidden
            BeginContext(3065, 407, true);
            WriteLiteral(@"
                                </select>

                            </div>
                        </div>
                    </div>
                </div>
                <div class=""row "">
                    <div class=""col-sm-12 col-md-12 col-lg-12"">
                        <div class=""form-group"">
                            <label class=""lable-color"">
                                ");
            EndContext();
            BeginContext(3473, 25, false);
#line 113 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1004_00.cshtml"
                           Write(Localizer["ItemCategory"]);

#line default
#line hidden
            EndContext();
            BeginContext(3498, 262, true);
            WriteLiteral(@"
                            </label>
                            <div>
                                <select class=""selectpicker"" data-live-search=""true"" id=""cboitemcategory"" title="""" onchange=""fnloadSubCategoryCbo()"">
                                    ");
            EndContext();
            BeginContext(3760, 139, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17e5cbef5496caf3ceb4fd6b225041d9161288e719080", async() => {
                BeginContext(3778, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(3821, 31, false);
#line 118 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1004_00.cshtml"
                                   Write(Localizer["SelectItemCategory"]);

#line default
#line hidden
                EndContext();
                BeginContext(3852, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3899, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 120 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1004_00.cshtml"
                                     foreach (var cate in ViewBag.ItemCategories)
                                    {

#line default
#line hidden
            BeginContext(4023, 40, true);
            WriteLiteral("                                        ");
            EndContext();
            BeginContext(4063, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17e5cbef5496caf3ceb4fd6b225041d9161288e721397", async() => {
                BeginContext(4099, 21, false);
#line 122 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1004_00.cshtml"
                                                                      Write(cate.ItemCategoryDesc);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 122 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1004_00.cshtml"
                                           WriteLiteral(cate.ItemCategory);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4129, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 123 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1004_00.cshtml"
                                    }

#line default
#line hidden
            BeginContext(4170, 407, true);
            WriteLiteral(@"
                                </select>

                            </div>
                        </div>
                    </div>
                </div>
                <div class=""row "">
                    <div class=""col-sm-12 col-md-12 col-lg-12"">
                        <div class=""form-group"">
                            <label class=""lable-color"">
                                ");
            EndContext();
            BeginContext(4578, 28, false);
#line 135 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1004_00.cshtml"
                           Write(Localizer["ItemSubCategory"]);

#line default
#line hidden
            EndContext();
            BeginContext(4606, 243, true);
            WriteLiteral("\r\n                            </label>\r\n                            <div>\r\n                                <select class=\"selectpicker\" data-live-search=\"true\" id=\"cboitemsubcategory\" title=\"\" onchange=\"\">\r\n                                    ");
            EndContext();
            BeginContext(4849, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17e5cbef5496caf3ceb4fd6b225041d9161288e724870", async() => {
                BeginContext(4867, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(4869, 34, false);
#line 139 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1004_00.cshtml"
                                                  Write(Localizer["SelectItemSubCategory"]);

#line default
#line hidden
                EndContext();
                BeginContext(4903, 1, true);
                WriteLiteral(" ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4913, 569, true);
            WriteLiteral(@"
                                </select>

                            </div>
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
            BeginContext(5483, 19, false);
#line 151 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1004_00.cshtml"
                                                         Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(5502, 406, true);
            WriteLiteral(@"</span>
                        </label>
                    </div>
                </div>


                <hr />
                <div class=""mdl-card__actions text-center vertical-center pad0"">

                    <button type=""button"" class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect"" id=""btnIGCAdd"" onclick=""fnItemGroupCateSubCateMapping()""><i class=""fa fa-plus""></i> ");
            EndContext();
            BeginContext(5909, 17, false);
#line 160 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1004_00.cshtml"
                                                                                                                                                                                                  Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(5926, 163, true);
            WriteLiteral("</button>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<script>\r\n    var localization = {\r\n        SelectItemSubCategory: \'");
            EndContext();
            BeginContext(6090, 34, false);
#line 170 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1004_00.cshtml"
                           Write(Localizer["SelectItemSubCategory"]);

#line default
#line hidden
            EndContext();
            BeginContext(6124, 19, true);
            WriteLiteral("\',\r\n        Save: \'");
            EndContext();
            BeginContext(6144, 17, false);
#line 171 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1004_00.cshtml"
          Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(6161, 21, true);
            WriteLiteral("\',\r\n        Update: \'");
            EndContext();
            BeginContext(6183, 19, false);
#line 172 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaMaterial\Views\ItemControl\V_1004_00.cshtml"
            Write(Localizer["Update"]);

#line default
#line hidden
            EndContext();
            BeginContext(6202, 20, true);
            WriteLiteral("\',\r\n    }\r\n</script>");
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
