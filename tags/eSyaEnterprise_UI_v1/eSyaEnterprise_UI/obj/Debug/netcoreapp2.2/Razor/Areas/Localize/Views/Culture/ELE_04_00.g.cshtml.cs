#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_04_00.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42c588c473acd8a083c9f8b8f0c7fe0b95bbbeba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Localize_Views_Culture_ELE_04_00), @"mvc.1.0.view", @"/Areas/Localize/Views/Culture/ELE_04_00.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Localize/Views/Culture/ELE_04_00.cshtml", typeof(AspNetCore.Areas_Localize_Views_Culture_ELE_04_00))]
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
#line 1 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_04_00.cshtml"
using Microsoft.AspNetCore.Builder;

#line default
#line hidden
#line 2 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_04_00.cshtml"
using Microsoft.AspNetCore.Http.Features;

#line default
#line hidden
#line 3 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_04_00.cshtml"
using Microsoft.AspNetCore.Localization;

#line default
#line hidden
#line 4 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_04_00.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#line 5 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_04_00.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42c588c473acd8a083c9f8b8f0c7fe0b95bbbeba", @"/Areas/Localize/Views/Culture/ELE_04_00.cshtml")]
    public class Areas_Localize_Views_Culture_ELE_04_00 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Localize/LanguageCulture.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(205, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(298, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 10 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_04_00.cshtml"
  
    var requestCulture = Context.Features.Get<IRequestCultureFeature>();
    var cultureItems = LocOptions.Value.SupportedUICultures
        .Select(c => new SelectListItem { Value = c.Name, Text = c.DisplayName })
        .ToList();

#line default
#line hidden
            BeginContext(545, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 17 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_04_00.cshtml"
  
    ViewData["Title"] = "ELE_4_00";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(638, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(657, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(663, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42c588c473acd8a083c9f8b8f0c7fe0b95bbbeba5547", async() => {
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
                BeginContext(719, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(724, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 26 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_04_00.cshtml"
  
    var userFormRole = (eSyaEnterprise_UI.Models.DO_UserFormRole)ViewBag.UserFormRole;

#line default
#line hidden
            BeginContext(821, 46, true);
            WriteLiteral("<script>\r\n    var _userFormRole = JSON.parse(\'");
            EndContext();
            BeginContext(868, 38, false);
#line 30 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_04_00.cshtml"
                               Write(Html.Raw(Json.Serialize(userFormRole)));

#line default
#line hidden
            EndContext();
            BeginContext(906, 48, true);
            WriteLiteral("\');\r\n\r\n     var localization = {\r\n         ID: \'");
            EndContext();
            BeginContext(955, 15, false);
#line 33 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_04_00.cshtml"
         Write(Localizer["ID"]);

#line default
#line hidden
            EndContext();
            BeginContext(970, 28, true);
            WriteLiteral("\',\r\n         ResourceName: \'");
            EndContext();
            BeginContext(999, 25, false);
#line 34 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_04_00.cshtml"
                   Write(Localizer["ResourceName"]);

#line default
#line hidden
            EndContext();
            BeginContext(1024, 19, true);
            WriteLiteral("\',\r\n         Key: \'");
            EndContext();
            BeginContext(1044, 16, false);
#line 35 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_04_00.cshtml"
          Write(Localizer["Key"]);

#line default
#line hidden
            EndContext();
            BeginContext(1060, 21, true);
            WriteLiteral("\',\r\n         Value: \'");
            EndContext();
            BeginContext(1082, 18, false);
#line 36 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_04_00.cshtml"
            Write(Localizer["Value"]);

#line default
#line hidden
            EndContext();
            BeginContext(1100, 28, true);
            WriteLiteral("\',\r\n         CultureValue: \'");
            EndContext();
            BeginContext(1129, 25, false);
#line 37 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_04_00.cshtml"
                   Write(Localizer["CultureValue"]);

#line default
#line hidden
            EndContext();
            BeginContext(1154, 176, true);
            WriteLiteral("\',\r\n    };\r\n</script>\r\n\r\n<div class=\"row \">\r\n    <div class=\"col-lg-3 col-md-4 col-sm-6 itemblur\">\r\n\r\n        <div class=\"form-group\">\r\n            <label class=\"lable-color\"> ");
            EndContext();
            BeginContext(1331, 21, false);
#line 45 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_04_00.cshtml"
                                   Write(Localizer["Language"]);

#line default
#line hidden
            EndContext();
            BeginContext(1352, 144, true);
            WriteLiteral("</label>\r\n            <select class=\"selectpicker\" data-live-search=\"false\" id=\"cboCulture\" title=\"\" onchange=\"fnLoadLanguageCultureGrid()\">\r\n\r\n");
            EndContext();
#line 48 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_04_00.cshtml"
                 if (cultureItems != null)
                {
                    foreach (var cul in cultureItems)
                    {

#line default
#line hidden
            BeginContext(1637, 31, true);
            WriteLiteral("                        <option");
            EndContext();
            BeginWriteAttribute("value", " value=", 1668, "", 1685, 1);
#line 52 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_04_00.cshtml"
WriteAttributeValue("", 1675, cul.Value, 1675, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1685, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1687, 8, false);
#line 52 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_04_00.cshtml"
                                            Write(cul.Text);

#line default
#line hidden
            EndContext();
            BeginContext(1695, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 53 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_04_00.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(1748, 184, true);
            WriteLiteral("            </select>\r\n        </div>\r\n\r\n\r\n    </div>\r\n    <div class=\"col-lg-3 col-md-4 col-sm-6 itemblur\">\r\n        <div class=\"form-group\">\r\n            <label class=\"lable-color\"> ");
            EndContext();
            BeginContext(1933, 25, false);
#line 62 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_04_00.cshtml"
                                   Write(Localizer["ResourceName"]);

#line default
#line hidden
            EndContext();
            BeginContext(1958, 205, true);
            WriteLiteral("</label>\r\n            <select class=\"selectpicker\" data-live-search=\"true\" data-size=\"8\" id=\"cboResouce\" title=\"\" onchange=\"fnLoadLanguageCultureGrid()\">\r\n                <option value=\"All\">All</option>\r\n");
            EndContext();
#line 65 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_04_00.cshtml"
                 if (ViewBag.Resources != null)
                {
                    foreach (var r in ViewBag.Resources)
                    {

#line default
#line hidden
            BeginContext(2312, 31, true);
            WriteLiteral("                        <option");
            EndContext();
            BeginWriteAttribute("value", " value=", 2343, "", 2365, 1);
#line 69 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_04_00.cshtml"
WriteAttributeValue("", 2350, r.ResourceName, 2350, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2365, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2367, 14, false);
#line 69 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_04_00.cshtml"
                                                 Write(r.ResourceName);

#line default
#line hidden
            EndContext();
            BeginContext(2381, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 70 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_04_00.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(2434, 553, true);
            WriteLiteral(@"            </select>
        </div>
    </div>


    <div class=""col-lg-3 col-md-4 col-sm-6"">
        <div class=""form-group"">
            <label for=""txtSearchBox"">Search by Key </label>
            <input id=""txtSearchBox"" class=""form-control"" type=""text"" />

        </div>
    </div>


    <div class=""col-lg-3 col-md-4 col-sm-12 vertical-center-end form-group"">
        <button class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent primary-button "" onclick=""fnShowSideBar()"" id=""btnShowSideBar"">");
            EndContext();
            BeginContext(2988, 24, false);
#line 87 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_04_00.cshtml"
                                                                                                                                                                     Write(Localizer["ResourceKey"]);

#line default
#line hidden
            EndContext();
            BeginContext(3012, 548, true);
            WriteLiteral(@" <i class=""fas fa-caret-right""></i></button>
    </div>
</div>
<div class=""row padbot10"">
    <div class=""col-lg-12 col-md-12 col-sm-12 mr-3 itemblur"">
        <table id=""jqgLanguageCulture""></table>
        <div id=""jqpLanguageCulture""></div>
    </div>
</div>

<div class=""mdl-card__actions text-center pad0 itemblur"">
    <button type=""button"" class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent primary-button marbot15"" id=""btnSave"" onclick=""fnSaveLanguageCulture()""><i class=""fa fa-save""></i> ");
            EndContext();
            BeginContext(3561, 17, false);
#line 98 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_04_00.cshtml"
                                                                                                                                                                                                                   Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(3578, 213, true);
            WriteLiteral("  </button>\r\n</div>\r\n\r\n<div id=\"divSideBar\" class=\"animated slideInLeft\">\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-12 col-md-12 col-sm-12\">\r\n            <div class=\"sideBar-heading\">\r\n                <p>");
            EndContext();
            BeginContext(3792, 30, false);
#line 105 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_04_00.cshtml"
              Write(Localizer["UpdateResourceKey"]);

#line default
#line hidden
            EndContext();
            BeginContext(3822, 110, true);
            WriteLiteral(" </p>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <label class=\"lable-color\">");
            EndContext();
            BeginContext(3933, 24, false);
#line 109 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_04_00.cshtml"
                                      Write(Localizer["ResourceKey"]);

#line default
#line hidden
            EndContext();
            BeginContext(3957, 249, true);
            WriteLiteral(" </label>\r\n\r\n                <select class=\"selectpicker\" data-live-search=\"true\" id=\"cboResoureckey\" title=\"\" onchange=\"fnGetvaluebyKey()\"></select>\r\n\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"txtValue\">");
            EndContext();
            BeginContext(4207, 18, false);
#line 115 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_04_00.cshtml"
                                 Write(Localizer["Value"]);

#line default
#line hidden
            EndContext();
            BeginContext(4225, 226, true);
            WriteLiteral(" </label>\r\n                <input id=\"txtValue\" class=\"form-control\" maxlength=\"250\" type=\"text\" readonly=\"readonly\" />\r\n\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"txtCultureValue\">");
            EndContext();
            BeginContext(4452, 25, false);
#line 120 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_04_00.cshtml"
                                        Write(Localizer["CultureValue"]);

#line default
#line hidden
            EndContext();
            BeginContext(4477, 390, true);
            WriteLiteral(@" </label>
                <input id=""txtCultureValue"" class=""form-control"" maxlength=""500"" type=""text"" />

            </div>
            <div class=""text-center"">
                <button class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent primary-button mr-10"" id=""btnsaveResourceCulture"" onclick=""fnSaveResourceCulture()"">
                    ");
            EndContext();
            BeginContext(4868, 17, false);
#line 126 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_04_00.cshtml"
               Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(4885, 184, true);
            WriteLiteral("\r\n                </button>\r\n                <button class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect  cancel-button cancel-button\" onclick=\"fnCloseSidebar()\">  ");
            EndContext();
            BeginContext(5070, 18, false);
#line 128 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_04_00.cshtml"
                                                                                                                                                      Write(Localizer["Close"]);

#line default
#line hidden
            EndContext();
            BeginContext(5088, 71, true);
            WriteLiteral("</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOptions<RequestLocalizationOptions> LocOptions { get; private set; }
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
