#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Inventory\Views\Grouping\ECI_08_00.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acd07282fcbb2f8c876ddbd997137eb10f037d52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Inventory_Views_Grouping_ECI_08_00), @"mvc.1.0.view", @"/Areas/Inventory/Views/Grouping/ECI_08_00.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Inventory/Views/Grouping/ECI_08_00.cshtml", typeof(AspNetCore.Areas_Inventory_Views_Grouping_ECI_08_00))]
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
#line 1 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Inventory\Views\Grouping\ECI_08_00.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acd07282fcbb2f8c876ddbd997137eb10f037d52", @"/Areas/Inventory/Views/Grouping/ECI_08_00.cshtml")]
    public class Areas_Inventory_Views_Grouping_ECI_08_00 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jsTree.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/jsTree.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Inventory/ItemGroupCategoryMapping.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Inventory\Views\Grouping\ECI_08_00.cshtml"
  
    ViewData["Title"] = "ECI_08_00";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#line 8 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Inventory\Views\Grouping\ECI_08_00.cshtml"
  
    var userFormRole = (eSyaEnterprise_UI.Models.DO_UserFormRole)ViewBag.UserFormRole;

#line default
#line hidden
            BeginContext(321, 46, true);
            WriteLiteral("<script>\r\n    var _userFormRole = JSON.parse(\'");
            EndContext();
            BeginContext(368, 38, false);
#line 12 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Inventory\Views\Grouping\ECI_08_00.cshtml"
                               Write(Html.Raw(Json.Serialize(userFormRole)));

#line default
#line hidden
            EndContext();
            BeginContext(406, 18, true);
            WriteLiteral("\');\r\n</script>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(441, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(447, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acd07282fcbb2f8c876ddbd997137eb10f037d526234", async() => {
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
                BeginContext(485, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(491, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "acd07282fcbb2f8c876ddbd997137eb10f037d527487", async() => {
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
                BeginContext(540, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(546, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acd07282fcbb2f8c876ddbd997137eb10f037d528819", async() => {
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
                BeginContext(612, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(617, 1477, true);
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
            BeginContext(2095, 35, false);
#line 85 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Inventory\Views\Grouping\ECI_08_00.cshtml"
                                             Write(Localizer["ItemGroup&CategoryLink"]);

#line default
#line hidden
            EndContext();
            BeginContext(2130, 311, true);
            WriteLiteral(@" </h5>
            </div>
            <div class=""mdl-card__supporting-text fullwidth"">
                <div class=""row "">
                    <div class=""col-sm-12 col-md-12 col-lg-12"">
                        <div class=""form-group"">
                            <label>
                                ");
            EndContext();
            BeginContext(2442, 22, false);
#line 92 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Inventory\Views\Grouping\ECI_08_00.cshtml"
                           Write(Localizer["ItemGroup"]);

#line default
#line hidden
            EndContext();
            BeginContext(2464, 225, true);
            WriteLiteral("\r\n                            </label>\r\n                            <div>\r\n                                <select class=\"selectpicker\" data-live-search=\"true\" id=\"cboitemgroup\" title=\"\">\r\n                                    ");
            EndContext();
            BeginContext(2689, 136, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acd07282fcbb2f8c876ddbd997137eb10f037d5213141", async() => {
                BeginContext(2707, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(2750, 28, false);
#line 97 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Inventory\Views\Grouping\ECI_08_00.cshtml"
                                   Write(Localizer["SelectItemGroup"]);

#line default
#line hidden
                EndContext();
                BeginContext(2778, 38, true);
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
            BeginContext(2825, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 99 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Inventory\Views\Grouping\ECI_08_00.cshtml"
                                     foreach (var group in ViewBag.ItemGroups)
                                    {

#line default
#line hidden
            BeginContext(2946, 40, true);
            WriteLiteral("                                        ");
            EndContext();
            BeginContext(2986, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acd07282fcbb2f8c876ddbd997137eb10f037d5215478", async() => {
                BeginContext(3022, 19, false);
#line 101 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Inventory\Views\Grouping\ECI_08_00.cshtml"
                                                                      Write(group.ItemGroupDesc);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 101 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Inventory\Views\Grouping\ECI_08_00.cshtml"
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
            BeginContext(3050, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 102 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Inventory\Views\Grouping\ECI_08_00.cshtml"
                                    }

#line default
#line hidden
            BeginContext(3091, 407, true);
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
            BeginContext(3499, 25, false);
#line 114 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Inventory\Views\Grouping\ECI_08_00.cshtml"
                           Write(Localizer["ItemCategory"]);

#line default
#line hidden
            EndContext();
            BeginContext(3524, 262, true);
            WriteLiteral(@"
                            </label>
                            <div>
                                <select class=""selectpicker"" data-live-search=""true"" id=""cboitemcategory"" title="""" onchange=""fnloadSubCategoryCbo()"">
                                    ");
            EndContext();
            BeginContext(3786, 139, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acd07282fcbb2f8c876ddbd997137eb10f037d5219015", async() => {
                BeginContext(3804, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(3847, 31, false);
#line 119 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Inventory\Views\Grouping\ECI_08_00.cshtml"
                                   Write(Localizer["SelectItemCategory"]);

#line default
#line hidden
                EndContext();
                BeginContext(3878, 38, true);
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
            BeginContext(3925, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 121 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Inventory\Views\Grouping\ECI_08_00.cshtml"
                                     foreach (var cate in ViewBag.ItemCategories)
                                    {

#line default
#line hidden
            BeginContext(4049, 40, true);
            WriteLiteral("                                        ");
            EndContext();
            BeginContext(4089, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acd07282fcbb2f8c876ddbd997137eb10f037d5221360", async() => {
                BeginContext(4125, 21, false);
#line 123 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Inventory\Views\Grouping\ECI_08_00.cshtml"
                                                                      Write(cate.ItemCategoryDesc);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 123 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Inventory\Views\Grouping\ECI_08_00.cshtml"
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
            BeginContext(4155, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 124 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Inventory\Views\Grouping\ECI_08_00.cshtml"
                                    }

#line default
#line hidden
            BeginContext(4196, 407, true);
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
            BeginContext(4604, 28, false);
#line 136 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Inventory\Views\Grouping\ECI_08_00.cshtml"
                           Write(Localizer["ItemSubCategory"]);

#line default
#line hidden
            EndContext();
            BeginContext(4632, 243, true);
            WriteLiteral("\r\n                            </label>\r\n                            <div>\r\n                                <select class=\"selectpicker\" data-live-search=\"true\" id=\"cboitemsubcategory\" title=\"\" onchange=\"\">\r\n                                    ");
            EndContext();
            BeginContext(4875, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acd07282fcbb2f8c876ddbd997137eb10f037d5224889", async() => {
                BeginContext(4893, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(4895, 34, false);
#line 140 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Inventory\Views\Grouping\ECI_08_00.cshtml"
                                                  Write(Localizer["SelectItemSubCategory"]);

#line default
#line hidden
                EndContext();
                BeginContext(4929, 1, true);
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
            BeginContext(4939, 569, true);
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
            BeginContext(5509, 19, false);
#line 152 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Inventory\Views\Grouping\ECI_08_00.cshtml"
                                                         Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(5528, 406, true);
            WriteLiteral(@"</span>
                        </label>
                    </div>
                </div>


                <hr />
                <div class=""mdl-card__actions text-center vertical-center pad0"">

                    <button type=""button"" class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect"" id=""btnIGCAdd"" onclick=""fnItemGroupCateSubCateMapping()""><i class=""fa fa-plus""></i> ");
            EndContext();
            BeginContext(5935, 17, false);
#line 161 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Inventory\Views\Grouping\ECI_08_00.cshtml"
                                                                                                                                                                                                  Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(5952, 163, true);
            WriteLiteral("</button>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<script>\r\n    var localization = {\r\n        SelectItemSubCategory: \'");
            EndContext();
            BeginContext(6116, 34, false);
#line 171 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Inventory\Views\Grouping\ECI_08_00.cshtml"
                           Write(Localizer["SelectItemSubCategory"]);

#line default
#line hidden
            EndContext();
            BeginContext(6150, 19, true);
            WriteLiteral("\',\r\n        Save: \'");
            EndContext();
            BeginContext(6170, 17, false);
#line 172 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Inventory\Views\Grouping\ECI_08_00.cshtml"
          Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(6187, 21, true);
            WriteLiteral("\',\r\n        Update: \'");
            EndContext();
            BeginContext(6209, 19, false);
#line 173 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Inventory\Views\Grouping\ECI_08_00.cshtml"
            Write(Localizer["Update"]);

#line default
#line hidden
            EndContext();
            BeginContext(6228, 20, true);
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
