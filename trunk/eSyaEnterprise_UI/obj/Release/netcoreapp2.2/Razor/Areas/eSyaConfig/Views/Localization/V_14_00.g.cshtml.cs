#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Localization\V_14_00.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "598aa739fb8b9d353e19225fdecec128e536bebb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_eSyaConfig_Views_Localization_V_14_00), @"mvc.1.0.view", @"/Areas/eSyaConfig/Views/Localization/V_14_00.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/eSyaConfig/Views/Localization/V_14_00.cshtml", typeof(AspNetCore.Areas_eSyaConfig_Views_Localization_V_14_00))]
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
#line 1 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Localization\V_14_00.cshtml"
using Microsoft.AspNetCore.Builder;

#line default
#line hidden
#line 2 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Localization\V_14_00.cshtml"
using Microsoft.AspNetCore.Http.Features;

#line default
#line hidden
#line 3 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Localization\V_14_00.cshtml"
using Microsoft.AspNetCore.Localization;

#line default
#line hidden
#line 4 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Localization\V_14_00.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#line 5 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Localization\V_14_00.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"598aa739fb8b9d353e19225fdecec128e536bebb", @"/Areas/eSyaConfig/Views/Localization/V_14_00.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Areas/eSyaConfig/Views/_ViewImports.cshtml")]
    public class Areas_eSyaConfig_Views_Localization_V_14_00 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Config/CultureKeys.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(205, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(298, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 10 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Localization\V_14_00.cshtml"
  
    var requestCulture = Context.Features.Get<IRequestCultureFeature>();
    var cultureItems = LocOptions.Value.SupportedUICultures
        .Select(c => new SelectListItem { Value = c.Name, Text = c.DisplayName })
        .ToList();

#line default
#line hidden
            BeginContext(545, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 18 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Localization\V_14_00.cshtml"
  
    ViewData["Title"] = "V_14_00";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(639, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(658, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(664, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "598aa739fb8b9d353e19225fdecec128e536bebb5767", async() => {
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
                BeginContext(714, 100, true);
                WriteLiteral("\r\n    <script src=\"https://cdnjs.cloudflare.com/ajax/libs/xlsx/0.7.7/xlsx.core.min.js\"></script>\r\n\r\n");
                EndContext();
            }
            );
            BeginContext(817, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 29 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Localization\V_14_00.cshtml"
  
    var userFormRole = (eSyaEnterprise_UI.Models.DO_UserFormRole)ViewBag.UserFormRole;

#line default
#line hidden
            BeginContext(914, 46, true);
            WriteLiteral("<script>\r\n    var _userFormRole = JSON.parse(\'");
            EndContext();
            BeginContext(961, 38, false);
#line 33 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Localization\V_14_00.cshtml"
                               Write(Html.Raw(Json.Serialize(userFormRole)));

#line default
#line hidden
            EndContext();
            BeginContext(999, 49, true);
            WriteLiteral("\');\r\n\r\n     var localization = {\r\n         Key: \'");
            EndContext();
            BeginContext(1049, 16, false);
#line 36 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Localization\V_14_00.cshtml"
          Write(Localizer["Key"]);

#line default
#line hidden
            EndContext();
            BeginContext(1065, 21, true);
            WriteLiteral("\',\r\n         Value: \'");
            EndContext();
            BeginContext(1087, 18, false);
#line 37 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Localization\V_14_00.cshtml"
            Write(Localizer["Value"]);

#line default
#line hidden
            EndContext();
            BeginContext(1105, 28, true);
            WriteLiteral("\',\r\n         CultureValue: \'");
            EndContext();
            BeginContext(1134, 25, false);
#line 38 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Localization\V_14_00.cshtml"
                   Write(Localizer["CultureValue"]);

#line default
#line hidden
            EndContext();
            BeginContext(1159, 182, true);
            WriteLiteral("\',\r\n       \r\n    };\r\n</script>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-lg-4 col-md-6 col-sm-6 itemblur\">\r\n        <div class=\"form-group\">\r\n            <label class=\"lable-color\"> ");
            EndContext();
            BeginContext(1342, 21, false);
#line 46 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Localization\V_14_00.cshtml"
                                   Write(Localizer["Language"]);

#line default
#line hidden
            EndContext();
            BeginContext(1363, 140, true);
            WriteLiteral("</label>\r\n            <select class=\"selectpicker\" data-live-search=\"false\" id=\"cboCulture\" title=\"\" onchange=\"fnLoadCultureKeysGrid()\">\r\n\r\n");
            EndContext();
#line 49 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Localization\V_14_00.cshtml"
                 if (cultureItems != null)
                {
                    foreach (var cul in cultureItems)
                    {

#line default
#line hidden
            BeginContext(1644, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1668, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "598aa739fb8b9d353e19225fdecec128e536bebb10495", async() => {
                BeginContext(1694, 8, false);
#line 53 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Localization\V_14_00.cshtml"
                                            Write(cul.Text);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 53 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Localization\V_14_00.cshtml"
                          WriteLiteral(cul.Value);

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
            BeginContext(1711, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 54 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Localization\V_14_00.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(1755, 358, true);
            WriteLiteral(@"            </select>
        </div>
    </div>
    <div class=""col-lg-2 col-md-6 col-sm-6 form-group d-flex align-self-end"">
        <button type=""button"" class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent primary-button mr-10"" id=""btnExportToExcel"" onclick=""fnExportToExcel()""><i class=""fas fa-file-export""></i> ");
            EndContext();
            BeginContext(2114, 26, false);
#line 60 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Localization\V_14_00.cshtml"
                                                                                                                                                                                                                               Write(Localizer["ExportToExcel"]);

#line default
#line hidden
            EndContext();
            BeginContext(2140, 186, true);
            WriteLiteral("  </button>\r\n    </div>\r\n    <div class=\"col-lg-2 form-group d-flex align-self-end\"></div>\r\n        <div class=\"col-lg-2 col-md-6 col-sm-6 form-group-half f-right \">\r\n            <label>");
            EndContext();
            BeginContext(2327, 24, false);
#line 64 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Localization\V_14_00.cshtml"
              Write(Localizer["UploadExcel"]);

#line default
#line hidden
            EndContext();
            BeginContext(2351, 488, true);
            WriteLiteral(@" </label>
            <input type=""file"" accept="".csv, application/vnd.openxmlformats-officedocument.spreadsheetml.sheet, application/vnd.ms-excel"" id=""flnExcel"" />
        </div>
        <div class=""col-lg-2 col-md-6 col-sm-6 form-group d-flex align-self-end text-right justify-content-end"">
            <button type=""button"" class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent primary-button"" id=""btnImport""><i class=""fas fa-file-import""></i> ");
            EndContext();
            BeginContext(2840, 19, false);
#line 68 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Localization\V_14_00.cshtml"
                                                                                                                                                                                          Write(Localizer["Import"]);

#line default
#line hidden
            EndContext();
            BeginContext(2859, 538, true);
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
            BeginContext(3398, 17, false);
#line 79 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Localization\V_14_00.cshtml"
                                                                                                                                                                                                                   Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(3415, 29, true);
            WriteLiteral("  </button>\r\n    </div>\r\n\r\n\r\n");
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
