#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Stores\Views\Business\ECI_03_00.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7bad5e3b014c6465097a29e84c00dfb4cd44d16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Stores_Views_Business_ECI_03_00), @"mvc.1.0.view", @"/Areas/Stores/Views/Business/ECI_03_00.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Stores/Views/Business/ECI_03_00.cshtml", typeof(AspNetCore.Areas_Stores_Views_Business_ECI_03_00))]
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
#line 7 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Stores\Views\Business\ECI_03_00.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7bad5e3b014c6465097a29e84c00dfb4cd44d16", @"/Areas/Stores/Views/Business/ECI_03_00.cshtml")]
    public class Areas_Stores_Views_Business_ECI_03_00 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/jsTree.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jsTree.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Store/StoreBusinessLink.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Stores\Views\Business\ECI_03_00.cshtml"
  
    ViewData["Title"] = "ECI_03_00";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(94, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(142, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 10 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Stores\Views\Business\ECI_03_00.cshtml"
  
    ViewData["Title"] = "Store Business Link";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#line 14 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Stores\Views\Business\ECI_03_00.cshtml"
  
    var userFormRole = (eSyaEnterprise_UI.Models.DO_UserFormRole)ViewBag.UserFormRole;

#line default
#line hidden
            BeginContext(375, 46, true);
            WriteLiteral("<script>\r\n    var _userFormRole = JSON.parse(\'");
            EndContext();
            BeginContext(422, 38, false);
#line 18 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Stores\Views\Business\ECI_03_00.cshtml"
                               Write(Html.Raw(Json.Serialize(userFormRole)));

#line default
#line hidden
            EndContext();
            BeginContext(460, 64, true);
            WriteLiteral("\');\r\n\r\n    var localization = {\r\n        AddStoreBusinessLink: \'");
            EndContext();
            BeginContext(525, 33, false);
#line 21 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Stores\Views\Business\ECI_03_00.cshtml"
                          Write(Localizer["AddStoreBusinessLink"]);

#line default
#line hidden
            EndContext();
            BeginContext(558, 32, true);
            WriteLiteral("\',\r\n        StoreBusinessLink: \'");
            EndContext();
            BeginContext(591, 30, false);
#line 22 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Stores\Views\Business\ECI_03_00.cshtml"
                       Write(Localizer["StoreBusinessLink"]);

#line default
#line hidden
            EndContext();
            BeginContext(621, 36, true);
            WriteLiteral("\',\r\n        EditStoreBusinessLink: \'");
            EndContext();
            BeginContext(658, 34, false);
#line 23 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Stores\Views\Business\ECI_03_00.cshtml"
                           Write(Localizer["EditStoreBusinessLink"]);

#line default
#line hidden
            EndContext();
            BeginContext(692, 19, true);
            WriteLiteral("\',\r\n        Save: \'");
            EndContext();
            BeginContext(712, 17, false);
#line 24 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Stores\Views\Business\ECI_03_00.cshtml"
          Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(729, 21, true);
            WriteLiteral("\',\r\n        Update: \'");
            EndContext();
            BeginContext(751, 19, false);
#line 25 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Stores\Views\Business\ECI_03_00.cshtml"
            Write(Localizer["Update"]);

#line default
#line hidden
            EndContext();
            BeginContext(770, 36, true);
            WriteLiteral("\',\r\n        ViewStoreBusinessLink: \'");
            EndContext();
            BeginContext(807, 34, false);
#line 26 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Stores\Views\Business\ECI_03_00.cshtml"
                           Write(Localizer["ViewStoreBusinessLink"]);

#line default
#line hidden
            EndContext();
            BeginContext(841, 25, true);
            WriteLiteral("\',\r\n    };\r\n\r\n</script>\r\n");
            EndContext();
            BeginContext(866, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e7bad5e3b014c6465097a29e84c00dfb4cd44d168837", async() => {
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
            BeginContext(915, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(934, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(940, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7bad5e3b014c6465097a29e84c00dfb4cd44d1610267", async() => {
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
                BeginContext(978, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(984, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7bad5e3b014c6465097a29e84c00dfb4cd44d1611521", async() => {
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
                BeginContext(1039, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(1044, 132, true);
            WriteLiteral("\r\n\r\n<div class=\"row padbot10\">\r\n    <div class=\"col-lg-4 col-md-4 col-sm-6\">\r\n        <div class=\"form-group\">\r\n            <label> ");
            EndContext();
            BeginContext(1177, 29, false);
#line 40 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Stores\Views\Business\ECI_03_00.cshtml"
               Write(Localizer["BusinessLocation"]);

#line default
#line hidden
            EndContext();
            BeginContext(1206, 48, true);
            WriteLiteral(" </label>\r\n            <div>\r\n\r\n                ");
            EndContext();
            BeginContext(1255, 51, false);
#line 43 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Stores\Views\Business\ECI_03_00.cshtml"
           Write(await Component.InvokeAsync("UserBusinessLocation"));

#line default
#line hidden
            EndContext();
            BeginContext(1306, 910, true);
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-lg-4 col-md-4 col-sm-6"">
        <div id=""jstStoreBusinessLink""></div>
    </div>
    <div class=""col-lg-6 col-md-6 col-sm-6"">
        <div class=""demo-card-square mdl-card mdl-shadow--2dp"" id=""pnlMainMenu"" style=""width: 100%; display:none"">
            <div id=""pnlMainModuleHeading"" class=""mdl-card__title mdl-card--expand padleft0 padtop0 h-60 d-block"">
                <h5 class=""mdl-card__title-text"">Add Store Business Link</h5>
            </div>
            <div class=""mdl-card__supporting-text fullwidth pad0"">

                <div class=""row padbot4 mar0"">
                    <input type=""text"" id=""txtStoreCode"" style=""display:none"" />
                    <div class=""col-lg-12 col-md-12 col-sm-12"">
                        <div class=""form-group"">
                            <label> ");
            EndContext();
            BeginContext(2217, 29, false);
#line 63 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Stores\Views\Business\ECI_03_00.cshtml"
                               Write(Localizer["StoreDescription"]);

#line default
#line hidden
            EndContext();
            BeginContext(2246, 232, true);
            WriteLiteral(" </label>\r\n                            <input id=\"txtStoreDescription\" class=\"form-control\" type=\"text\" autocomplete=\"off\" maxlength=\"10\" pattern=\"^[a-zA-Z _]+$\" />\r\n                        </div>\r\n                    </div>\r\n\r\n\r\n\r\n");
            EndContext();
            BeginContext(5134, 574, true);
            WriteLiteral(@"

                </div>

            </div>

            <div class=""row"">
                <div class=""col-lg-12 col-md-12 col-sm-12"">

                    <table id=""jqgBusinessLink""></table>
                    <div id=""jqpBusinessLink""></div>

                </div>
            </div>

            <div class=""mdl-card__actions mdl-card--border"" style=""text-align: center;"">
                <button class=""mdl-button mdl-js-button mdl-button--raised primary-button"" id=""btnAddStoreBusinessLink"" onclick=""fnSaveStoreBusinessLink()"">
                    ");
            EndContext();
            BeginContext(5709, 17, false);
#line 129 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Stores\Views\Business\ECI_03_00.cshtml"
               Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(5726, 216, true);
            WriteLiteral("\r\n                </button>\r\n\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n    <div class=\"col-lg-2 col-md-2 col-sm-6\">\r\n        <div>\r\n            <h5>Action</h5>\r\n        </div>\r\n        <div class=\"row\">\r\n");
            EndContext();
            BeginContext(6297, 246, true);
            WriteLiteral("\r\n            <div class=\"col-lg-12 btn_pdnTop\">\r\n                <button class=\"mdl-button mdl-js-button mdl-button--raised primary-button btn_wdth\" id=\"btnExpandAll\" onclick=\"fnExpandAll()\">\r\n                    <i class=\"fas fa-expand\"></i>   ");
            EndContext();
            BeginContext(6544, 22, false);
#line 150 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Stores\Views\Business\ECI_03_00.cshtml"
                                               Write(Localizer["ExpandAll"]);

#line default
#line hidden
            EndContext();
            BeginContext(6566, 299, true);
            WriteLiteral(@"
                </button>
            </div>
            <div class=""col-lg-12 btn_pdnTop"">
                <button class=""mdl-button mdl-js-button mdl-button--raised primary-button btn_wdth"" id=""btnCollapseAll"" onclick=""fnCollapseAll()"">
                    <i class=""fas fa-compress""></i>   ");
            EndContext();
            BeginContext(6866, 24, false);
#line 155 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Stores\Views\Business\ECI_03_00.cshtml"
                                                 Write(Localizer["CollapseAll"]);

#line default
#line hidden
            EndContext();
            BeginContext(6890, 91, true);
            WriteLiteral("\r\n                </button>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
