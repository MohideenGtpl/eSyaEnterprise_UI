#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\ConfigureServices\Views\ServiceCodes\ESS_06_00.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9652e839365e985d9bc109703954206070c23d0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ConfigureServices_Views_ServiceCodes_ESS_06_00), @"mvc.1.0.view", @"/Areas/ConfigureServices/Views/ServiceCodes/ESS_06_00.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/ConfigureServices/Views/ServiceCodes/ESS_06_00.cshtml", typeof(AspNetCore.Areas_ConfigureServices_Views_ServiceCodes_ESS_06_00))]
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
#line 1 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\ConfigureServices\Views\ServiceCodes\ESS_06_00.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9652e839365e985d9bc109703954206070c23d0e", @"/Areas/ConfigureServices/Views/ServiceCodes/ESS_06_00.cshtml")]
    public class Areas_ConfigureServices_Views_ServiceCodes_ESS_06_00 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jsTree.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/jsTree.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/ConfigureServices/ServiceBusinessLinkServiceWise.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\ConfigureServices\Views\ServiceCodes\ESS_06_00.cshtml"
  
    ViewData["Title"] = "ESS_06_00";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#line 8 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\ConfigureServices\Views\ServiceCodes\ESS_06_00.cshtml"
  
    var userFormRole = (eSyaEnterprise_UI.Models.DO_UserFormRole)ViewBag.UserFormRole;

#line default
#line hidden
            BeginContext(321, 50, true);
            WriteLiteral("<script>\r\n        var _userFormRole = JSON.parse(\'");
            EndContext();
            BeginContext(372, 38, false);
#line 12 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\ConfigureServices\Views\ServiceCodes\ESS_06_00.cshtml"
                                   Write(Html.Raw(Json.Serialize(userFormRole)));

#line default
#line hidden
            EndContext();
            BeginContext(410, 16, true);
            WriteLiteral("\');\r\n</script>\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(443, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(449, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9652e839365e985d9bc109703954206070c23d0e5861", async() => {
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
                BeginContext(487, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(493, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9652e839365e985d9bc109703954206070c23d0e7114", async() => {
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
                BeginContext(542, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(548, 80, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9652e839365e985d9bc109703954206070c23d0e8446", async() => {
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
                BeginContext(628, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(633, 1536, true);
            WriteLiteral(@"

<style>
    .disable-Param {
        pointer-events: none;
    }

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

    #lblServiceCode {
        cursor: pointer;
        padding: 2px 4px;
    }

        #lblServiceCode:hover {
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
    <div class=""col-sm-4 col-md-4 col-lg-4"">");
            WriteLiteral(@"

        <div id=""ServiceBusinessLocationTree"">
        </div>
    </div>
    <div class=""col-sm-1 col-md-1 col-lg-1""></div>
    <div class=""col-lg-5 col-md-5 col-sm-5 f-right"">
        <div id=""dvServiceBusinessLink"" style=""display:none;"">

            <div class=""demo-card-square mdl-card mdl-shadow--2dp marbot15 fullwidth"" id=""pnlAddServiceBusinessLink"">
                <div class=""mdl-card__title mdl-card--expand padleft0 padtop0 d-block"">
                    <h5 class=""mdl-card__title-text"">");
            EndContext();
            BeginContext(2170, 44, false);
#line 83 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\ConfigureServices\Views\ServiceCodes\ESS_06_00.cshtml"
                                                Write(Localizer["ServiceBusinessLink-ServiceWise"]);

#line default
#line hidden
            EndContext();
            BeginContext(2214, 337, true);
            WriteLiteral(@"</h5>
                </div>
                <div class=""mdl-card__supporting-text fullwidth"">
                    <div class=""row"">

                        <div class=""col-sm-12 col-md-6 col-lg-6"">
                            <div class=""form-group"">
                                <label>
                                    ");
            EndContext();
            BeginContext(2552, 31, false);
#line 91 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\ConfigureServices\Views\ServiceCodes\ESS_06_00.cshtml"
                               Write(Localizer["ServiceDescription"]);

#line default
#line hidden
            EndContext();
            BeginContext(2583, 881, true);
            WriteLiteral(@"
                                </label>
                                <input type=""text"" maxlength=""75"" class=""form-control"" id=""txtServiceDesc"" disabled />
                            </div>
                        </div>

                    </div>
                    <div class=""row"">
                        <div class=""col-sm-12 col-md-12 col-lg-12"">

                            <table id=""jqgServiceBusinessLink""></table>
                            <div id=""jqpServiceBusinessLink""></div>
                            <hr />
                        </div>
                    </div>

                    <div class=""mdl-card__actions text-center pad0"">
                        <button type=""button"" class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect"" id=""btnSave"" onclick=""fnUpdateServiceBusinessLink()""><i class=""fa fa-sync""></i> ");
            EndContext();
            BeginContext(3465, 19, false);
#line 108 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\ConfigureServices\Views\ServiceCodes\ESS_06_00.cshtml"
                                                                                                                                                                                                  Write(Localizer["Update"]);

#line default
#line hidden
            EndContext();
            BeginContext(3484, 220, true);
            WriteLiteral("</button>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"col-lg-2 col-md-2 col-sm-2 col-xs-12 hide-in-smallscreen\">\r\n        <div>\r\n            <h5>");
            EndContext();
            BeginContext(3705, 19, false);
#line 117 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\ConfigureServices\Views\ServiceCodes\ESS_06_00.cshtml"
           Write(Localizer["Action"]);

#line default
#line hidden
            EndContext();
            BeginContext(3724, 285, true);
            WriteLiteral(@"</h5>
        </div>
        <div class=""row"">
            <div class=""col-lg-12 btn_pdnTop collapse"">
                <button class=""mdl-button mdl-js-button mdl-button--raised cancel-button btn_wdth"" onclick=""fnDeleteNode()"">
                    <i class=""fa fa-times""></i>     ");
            EndContext();
            BeginContext(4010, 23, false);
#line 122 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\ConfigureServices\Views\ServiceCodes\ESS_06_00.cshtml"
                                               Write(Localizer["DeleteNode"]);

#line default
#line hidden
            EndContext();
            BeginContext(4033, 309, true);
            WriteLiteral(@"
                </button>
            </div>
            <div class=""col-lg-12 btn_pdnTop collapse"">
                <button class=""mdl-button mdl-js-button mdl-button--raised primary-button btn_wdth"" id=""btnMoveUp"" onclick=""fnMoveItemUpDown('U')"">
                    <i class=""fas fa-arrow-up""></i>   ");
            EndContext();
            BeginContext(4343, 19, false);
#line 127 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\ConfigureServices\Views\ServiceCodes\ESS_06_00.cshtml"
                                                 Write(Localizer["MoveUp"]);

#line default
#line hidden
            EndContext();
            BeginContext(4362, 313, true);
            WriteLiteral(@"
                </button>
            </div>
            <div class=""col-lg-12 btn_pdnTop collapse"">
                <button class=""mdl-button mdl-js-button mdl-button--raised primary-button btn_wdth"" id=""btnMoveDown"" onclick=""fnMoveItemUpDown('D')"">
                    <i class=""fas fa-arrow-down""></i>   ");
            EndContext();
            BeginContext(4676, 21, false);
#line 132 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\ConfigureServices\Views\ServiceCodes\ESS_06_00.cshtml"
                                                   Write(Localizer["MoveDown"]);

#line default
#line hidden
            EndContext();
            BeginContext(4697, 293, true);
            WriteLiteral(@"
                </button>
            </div>
            <div class=""col-lg-12 btn_pdnTop"">
                <button class=""mdl-button mdl-js-button mdl-button--raised primary-button btn_wdth"" id=""btnExpandAll"" onclick=""fnExpandAll()"">
                    <i class=""fas fa-expand""></i>   ");
            EndContext();
            BeginContext(4991, 22, false);
#line 137 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\ConfigureServices\Views\ServiceCodes\ESS_06_00.cshtml"
                                               Write(Localizer["ExpandAll"]);

#line default
#line hidden
            EndContext();
            BeginContext(5013, 299, true);
            WriteLiteral(@"
                </button>
            </div>
            <div class=""col-lg-12 btn_pdnTop"">
                <button class=""mdl-button mdl-js-button mdl-button--raised primary-button btn_wdth"" id=""btnCollapseAll"" onclick=""fnCollapseAll()"">
                    <i class=""fas fa-compress""></i>   ");
            EndContext();
            BeginContext(5313, 24, false);
#line 142 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\ConfigureServices\Views\ServiceCodes\ESS_06_00.cshtml"
                                                 Write(Localizer["CollapseAll"]);

#line default
#line hidden
            EndContext();
            BeginContext(5337, 146, true);
            WriteLiteral("\r\n                </button>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n<script>\r\n    var localization = {\r\n        AddService: \'");
            EndContext();
            BeginContext(5484, 23, false);
#line 152 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\ConfigureServices\Views\ServiceCodes\ESS_06_00.cshtml"
                Write(Localizer["AddService"]);

#line default
#line hidden
            EndContext();
            BeginContext(5507, 19, true);
            WriteLiteral("\',\r\n        Save: \'");
            EndContext();
            BeginContext(5527, 17, false);
#line 153 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\ConfigureServices\Views\ServiceCodes\ESS_06_00.cshtml"
          Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(5544, 26, true);
            WriteLiteral("\',\r\n        ViewService: \'");
            EndContext();
            BeginContext(5571, 24, false);
#line 154 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\ConfigureServices\Views\ServiceCodes\ESS_06_00.cshtml"
                 Write(Localizer["ViewService"]);

#line default
#line hidden
            EndContext();
            BeginContext(5595, 26, true);
            WriteLiteral("\',\r\n        EditService: \'");
            EndContext();
            BeginContext(5622, 24, false);
#line 155 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\ConfigureServices\Views\ServiceCodes\ESS_06_00.cshtml"
                 Write(Localizer["EditService"]);

#line default
#line hidden
            EndContext();
            BeginContext(5646, 21, true);
            WriteLiteral("\',\r\n        Update: \'");
            EndContext();
            BeginContext(5668, 19, false);
#line 156 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\ConfigureServices\Views\ServiceCodes\ESS_06_00.cshtml"
            Write(Localizer["Update"]);

#line default
#line hidden
            EndContext();
            BeginContext(5687, 49, true);
            WriteLiteral("\',\r\n        ViewServiceBusinessLinkServiceWise: \'");
            EndContext();
            BeginContext(5737, 48, false);
#line 157 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\ConfigureServices\Views\ServiceCodes\ESS_06_00.cshtml"
                                        Write(Localizer["ViewServiceBusinessLink-ServiceWise"]);

#line default
#line hidden
            EndContext();
            BeginContext(5785, 49, true);
            WriteLiteral("\',\r\n        EditServiceBusinessLinkServiceWise: \'");
            EndContext();
            BeginContext(5835, 48, false);
#line 158 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\ConfigureServices\Views\ServiceCodes\ESS_06_00.cshtml"
                                        Write(Localizer["EditServiceBusinessLink-ServiceWise"]);

#line default
#line hidden
            EndContext();
            BeginContext(5883, 25, true);
            WriteLiteral("\'\r\n    }\r\n</script>\r\n\r\n\r\n");
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
