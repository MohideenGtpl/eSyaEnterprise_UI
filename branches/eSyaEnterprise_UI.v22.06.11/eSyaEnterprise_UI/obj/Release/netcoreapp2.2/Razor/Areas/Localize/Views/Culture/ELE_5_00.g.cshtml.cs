#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_5_00.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cef39b7c94c8adc85c9431fe4bb6bee31ea89e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Localize_Views_Culture_ELE_5_00), @"mvc.1.0.view", @"/Areas/Localize/Views/Culture/ELE_5_00.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Localize/Views/Culture/ELE_5_00.cshtml", typeof(AspNetCore.Areas_Localize_Views_Culture_ELE_5_00))]
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
#line 1 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_5_00.cshtml"
using Microsoft.AspNetCore.Builder;

#line default
#line hidden
#line 2 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_5_00.cshtml"
using Microsoft.AspNetCore.Http.Features;

#line default
#line hidden
#line 3 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_5_00.cshtml"
using Microsoft.AspNetCore.Localization;

#line default
#line hidden
#line 4 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_5_00.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#line 5 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_5_00.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cef39b7c94c8adc85c9431fe4bb6bee31ea89e6", @"/Areas/Localize/Views/Culture/ELE_5_00.cshtml")]
    public class Areas_Localize_Views_Culture_ELE_5_00 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Localize/CultureKeys.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 10 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_5_00.cshtml"
  
    var requestCulture = Context.Features.Get<IRequestCultureFeature>();
    var cultureItems = LocOptions.Value.SupportedUICultures
        .Select(c => new SelectListItem { Value = c.Name, Text = c.DisplayName })
        .ToList();

#line default
#line hidden
            BeginContext(545, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 18 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_5_00.cshtml"
  
    ViewData["Title"] = "ELE_5_00";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(640, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(661, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(667, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cef39b7c94c8adc85c9431fe4bb6bee31ea89e65377", async() => {
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
                BeginContext(719, 100, true);
                WriteLiteral("\r\n    <script src=\"https://cdnjs.cloudflare.com/ajax/libs/xlsx/0.7.7/xlsx.core.min.js\"></script>\r\n\r\n");
                EndContext();
            }
            );
            BeginContext(822, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 30 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_5_00.cshtml"
  
    var userFormRole = (eSyaEnterprise_UI.Models.DO_UserFormRole)ViewBag.UserFormRole;

#line default
#line hidden
            BeginContext(919, 46, true);
            WriteLiteral("<script>\r\n    var _userFormRole = JSON.parse(\'");
            EndContext();
            BeginContext(966, 38, false);
#line 34 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_5_00.cshtml"
                               Write(Html.Raw(Json.Serialize(userFormRole)));

#line default
#line hidden
            EndContext();
            BeginContext(1004, 49, true);
            WriteLiteral("\');\r\n\r\n     var localization = {\r\n         Key: \'");
            EndContext();
            BeginContext(1054, 16, false);
#line 37 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_5_00.cshtml"
          Write(Localizer["Key"]);

#line default
#line hidden
            EndContext();
            BeginContext(1070, 21, true);
            WriteLiteral("\',\r\n         Value: \'");
            EndContext();
            BeginContext(1092, 18, false);
#line 38 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_5_00.cshtml"
            Write(Localizer["Value"]);

#line default
#line hidden
            EndContext();
            BeginContext(1110, 28, true);
            WriteLiteral("\',\r\n         CultureValue: \'");
            EndContext();
            BeginContext(1139, 25, false);
#line 39 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_5_00.cshtml"
                   Write(Localizer["CultureValue"]);

#line default
#line hidden
            EndContext();
            BeginContext(1164, 175, true);
            WriteLiteral("\',\r\n\r\n    };\r\n</script>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-lg-4 col-md-4 col-sm-6 itemblur\">\r\n        <div class=\"form-group\">\r\n            <label class=\"lable-color\"> ");
            EndContext();
            BeginContext(1340, 21, false);
#line 47 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_5_00.cshtml"
                                   Write(Localizer["Language"]);

#line default
#line hidden
            EndContext();
            BeginContext(1361, 140, true);
            WriteLiteral("</label>\r\n            <select class=\"selectpicker\" data-live-search=\"false\" id=\"cboCulture\" title=\"\" onchange=\"fnLoadCultureKeysGrid()\">\r\n\r\n");
            EndContext();
#line 50 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_5_00.cshtml"
                 if (cultureItems != null)
                {
                    foreach (var cul in cultureItems)
                    {

#line default
#line hidden
            BeginContext(1642, 31, true);
            WriteLiteral("                        <option");
            EndContext();
            BeginWriteAttribute("value", " value=", 1673, "", 1690, 1);
#line 54 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_5_00.cshtml"
WriteAttributeValue("", 1680, cul.Value, 1680, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1690, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1692, 8, false);
#line 54 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_5_00.cshtml"
                                            Write(cul.Text);

#line default
#line hidden
            EndContext();
            BeginContext(1700, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 55 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_5_00.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(1753, 358, true);
            WriteLiteral(@"            </select>
        </div>
    </div>
    <div class=""col-lg-2 col-md-2 col-sm-6 form-group d-flex align-self-end"">
        <button type=""button"" class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent primary-button mr-10"" id=""btnExportToExcel"" onclick=""fnExportToExcel()""><i class=""fas fa-file-export""></i> ");
            EndContext();
            BeginContext(2112, 26, false);
#line 61 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_5_00.cshtml"
                                                                                                                                                                                                                               Write(Localizer["ExportToExcel"]);

#line default
#line hidden
            EndContext();
            BeginContext(2138, 196, true);
            WriteLiteral("  </button>\r\n    </div>\r\n    <div class=\"col-lg-2 col-md-2 col-sm-6 form-group d-flex align-self-end\"></div>\r\n    <div class=\"col-lg-2 col-md-2 col-sm-6 form-group-half f-right \">\r\n        <label>");
            EndContext();
            BeginContext(2335, 24, false);
#line 65 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_5_00.cshtml"
          Write(Localizer["UploadExcel"]);

#line default
#line hidden
            EndContext();
            BeginContext(2359, 472, true);
            WriteLiteral(@" </label>
        <input type=""file"" accept="".csv, application/vnd.openxmlformats-officedocument.spreadsheetml.sheet, application/vnd.ms-excel"" id=""flnExcel"" />
    </div>
    <div class=""col-lg-2 col-md-2 col-sm-6 form-group d-flex align-self-end text-right justify-content-end"">
        <button type=""button"" class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent primary-button"" id=""btnImport""><i class=""fas fa-file-import""></i> ");
            EndContext();
            BeginContext(2832, 19, false);
#line 69 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_5_00.cshtml"
                                                                                                                                                                                      Write(Localizer["Import"]);

#line default
#line hidden
            EndContext();
            BeginContext(2851, 498, true);
            WriteLiteral(@"  </button>
    </div>
</div>
<div class=""row padbot10"">
    <div class=""col-lg-12 col-md-12 col-sm-12 itemblur"">
        <table id=""jqgCulturekeys""></table>
        <div id=""jqpCulturekeys""></div>
    </div>
</div>

<div class=""mdl-card__actions text-center pad0 itemblur"">
    <button type=""button"" class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent primary-button marbot15"" id=""btnSave"" onclick=""fnSaveCultureKeys()""><i class=""fa fa-save""></i> ");
            EndContext();
            BeginContext(3350, 17, false);
#line 80 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Localize\Views\Culture\ELE_5_00.cshtml"
                                                                                                                                                                                                               Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(3367, 23, true);
            WriteLiteral("  </button>\r\n</div>\r\n\r\n");
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