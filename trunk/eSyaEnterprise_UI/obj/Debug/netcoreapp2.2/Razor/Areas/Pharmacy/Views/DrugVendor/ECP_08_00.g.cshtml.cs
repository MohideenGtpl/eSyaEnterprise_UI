#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Pharmacy\Views\DrugVendor\ECP_08_00.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb8e041c53e701ecba7e1cd21ee25f3545dfdc7d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Pharmacy_Views_DrugVendor_ECP_08_00), @"mvc.1.0.view", @"/Areas/Pharmacy/Views/DrugVendor/ECP_08_00.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Pharmacy/Views/DrugVendor/ECP_08_00.cshtml", typeof(AspNetCore.Areas_Pharmacy_Views_DrugVendor_ECP_08_00))]
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
#line 1 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Pharmacy\Views\DrugVendor\ECP_08_00.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb8e041c53e701ecba7e1cd21ee25f3545dfdc7d", @"/Areas/Pharmacy/Views/DrugVendor/ECP_08_00.cshtml")]
    public class Areas_Pharmacy_Views_DrugVendor_ECP_08_00 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Pharmacy/VendorDrugLink.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("selectpicker"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-live-search", new global::Microsoft.AspNetCore.Html.HtmlString("false"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("cboVendor"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Select"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-size", new global::Microsoft.AspNetCore.Html.HtmlString("8"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onchange", new global::Microsoft.AspNetCore.Html.HtmlString("fnLoadDrugListByVendor()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-live-search", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("cboDrugBrand"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "PO", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "RC", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(134, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Pharmacy\Views\DrugVendor\ECP_08_00.cshtml"
  
    ViewData["Title"] = "ECP_08_00";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#line 9 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Pharmacy\Views\DrugVendor\ECP_08_00.cshtml"
  
    var userFormRole = (eSyaEnterprise_UI.Models.DO_UserFormRole)ViewBag.UserFormRole;


#line default
#line hidden
            BeginContext(325, 46, true);
            WriteLiteral("<script>\r\n    var _userFormRole = JSON.parse(\'");
            EndContext();
            BeginContext(372, 38, false);
#line 14 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Pharmacy\Views\DrugVendor\ECP_08_00.cshtml"
                               Write(Html.Raw(Json.Serialize(userFormRole)));

#line default
#line hidden
            EndContext();
            BeginContext(410, 52, true);
            WriteLiteral("\');\r\n\r\n    var localization = {\r\n        DrugCode: \'");
            EndContext();
            BeginContext(463, 21, false);
#line 17 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Pharmacy\Views\DrugVendor\ECP_08_00.cshtml"
              Write(Localizer["DrugCode"]);

#line default
#line hidden
            EndContext();
            BeginContext(484, 24, true);
            WriteLiteral("\',\r\n        DrugBrand: \'");
            EndContext();
            BeginContext(509, 22, false);
#line 18 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Pharmacy\Views\DrugVendor\ECP_08_00.cshtml"
               Write(Localizer["DrugBrand"]);

#line default
#line hidden
            EndContext();
            BeginContext(531, 28, true);
            WriteLiteral("\',\r\n        BusinessShare: \'");
            EndContext();
            BeginContext(560, 26, false);
#line 19 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Pharmacy\Views\DrugVendor\ECP_08_00.cshtml"
                   Write(Localizer["BusinessShare"]);

#line default
#line hidden
            EndContext();
            BeginContext(586, 36, true);
            WriteLiteral("\',\r\n        MinimumSupplyQuantity: \'");
            EndContext();
            BeginContext(623, 34, false);
#line 20 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Pharmacy\Views\DrugVendor\ECP_08_00.cshtml"
                           Write(Localizer["MinimumSupplyQuantity"]);

#line default
#line hidden
            EndContext();
            BeginContext(657, 27, true);
            WriteLiteral("\',\r\n        RateTypeCode: \'");
            EndContext();
            BeginContext(685, 25, false);
#line 21 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Pharmacy\Views\DrugVendor\ECP_08_00.cshtml"
                  Write(Localizer["RateTypeCode"]);

#line default
#line hidden
            EndContext();
            BeginContext(710, 23, true);
            WriteLiteral("\',\r\n        RateType: \'");
            EndContext();
            BeginContext(734, 21, false);
#line 22 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Pharmacy\Views\DrugVendor\ECP_08_00.cshtml"
              Write(Localizer["RateType"]);

#line default
#line hidden
            EndContext();
            BeginContext(755, 19, true);
            WriteLiteral("\',\r\n        Rate: \'");
            EndContext();
            BeginContext(775, 17, false);
#line 23 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Pharmacy\Views\DrugVendor\ECP_08_00.cshtml"
          Write(Localizer["Rate"]);

#line default
#line hidden
            EndContext();
            BeginContext(792, 21, true);
            WriteLiteral("\',\r\n        Active: \'");
            EndContext();
            BeginContext(814, 19, false);
#line 24 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Pharmacy\Views\DrugVendor\ECP_08_00.cshtml"
            Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(833, 22, true);
            WriteLiteral("\',\r\n        Actions: \'");
            EndContext();
            BeginContext(856, 20, false);
#line 25 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Pharmacy\Views\DrugVendor\ECP_08_00.cshtml"
             Write(Localizer["Actions"]);

#line default
#line hidden
            EndContext();
            BeginContext(876, 19, true);
            WriteLiteral("\',\r\n        Save: \'");
            EndContext();
            BeginContext(896, 17, false);
#line 26 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Pharmacy\Views\DrugVendor\ECP_08_00.cshtml"
          Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(913, 21, true);
            WriteLiteral("\',\r\n        Update: \'");
            EndContext();
            BeginContext(935, 19, false);
#line 27 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Pharmacy\Views\DrugVendor\ECP_08_00.cshtml"
            Write(Localizer["Update"]);

#line default
#line hidden
            EndContext();
            BeginContext(954, 19, true);
            WriteLiteral("\',\r\n        View: \'");
            EndContext();
            BeginContext(974, 17, false);
#line 28 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Pharmacy\Views\DrugVendor\ECP_08_00.cshtml"
          Write(Localizer["View"]);

#line default
#line hidden
            EndContext();
            BeginContext(991, 19, true);
            WriteLiteral("\',\r\n        Wait: \'");
            EndContext();
            BeginContext(1011, 17, false);
#line 29 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Pharmacy\Views\DrugVendor\ECP_08_00.cshtml"
          Write(Localizer["Wait"]);

#line default
#line hidden
            EndContext();
            BeginContext(1028, 26, true);
            WriteLiteral("\'\r\n    };\r\n\r\n</script>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1071, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1077, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb8e041c53e701ecba7e1cd21ee25f3545dfdc7d13986", async() => {
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
                BeginContext(1132, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(1137, 143, true);
            WriteLiteral("\r\n<section id=\"divVendorDrugLinkGrid\">\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-3 col-md-3 col-sm-4 form-group\">\r\n            <label>");
            EndContext();
            BeginContext(1281, 23, false);
#line 41 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Pharmacy\Views\DrugVendor\ECP_08_00.cshtml"
              Write(Localizer["VendorCode"]);

#line default
#line hidden
            EndContext();
            BeginContext(1304, 22, true);
            WriteLiteral("</label>\r\n            ");
            EndContext();
            BeginContext(1326, 240, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb8e041c53e701ecba7e1cd21ee25f3545dfdc7d15923", async() => {
                BeginContext(1492, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1510, 33, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb8e041c53e701ecba7e1cd21ee25f3545dfdc7d16326", async() => {
                    BeginContext(1528, 6, true);
                    WriteLiteral("Select");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1543, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
#line 42 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Pharmacy\Views\DrugVendor\ECP_08_00.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.VendorList;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1566, 333, true);
            WriteLiteral(@"
        </div>

    </div>
    <div class=""row"">
        <div class=""col-lg-12 col-md-12 col-sm-12"">
            <table id=""jqgVendorDrugLink""></table>
            <div id=""jqpVendorDrugLink""></div>
        </div>
    </div>
</section>

<section id=""divVendorDrugLinkForm"" style=""display:none;"">
    <div class=""row"">
");
            EndContext();
            BeginContext(2341, 134, true);
            WriteLiteral("\r\n        <div class=\"col-lg-4 col-md-4 col-sm-6\">\r\n            <div class=\"form-group\">\r\n                <label class=\"lable-color\"> ");
            EndContext();
            BeginContext(2476, 22, false);
#line 69 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Pharmacy\Views\DrugVendor\ECP_08_00.cshtml"
                                       Write(Localizer["DrugBrand"]);

#line default
#line hidden
            EndContext();
            BeginContext(2498, 26, true);
            WriteLiteral("</label>\r\n                ");
            EndContext();
            BeginContext(2524, 198, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb8e041c53e701ecba7e1cd21ee25f3545dfdc7d20579", async() => {
                BeginContext(2640, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(2662, 33, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb8e041c53e701ecba7e1cd21ee25f3545dfdc7d20986", async() => {
                    BeginContext(2680, 6, true);
                    WriteLiteral("Select");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2695, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
#line 70 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Pharmacy\Views\DrugVendor\ECP_08_00.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.DrugList;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2722, 120, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"col-lg-2 col-md-3 col-sm-3 form-group\">\r\n            <label>");
            EndContext();
            BeginContext(2843, 26, false);
#line 77 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Pharmacy\Views\DrugVendor\ECP_08_00.cshtml"
              Write(Localizer["BusinessShare"]);

#line default
#line hidden
            EndContext();
            BeginContext(2869, 227, true);
            WriteLiteral("</label>\r\n            <input id=\"txtBusinessShare\" name=\"BusinessShare\" class=\"form-control perctDecimalFormat\" maxlength=\"10\" />\r\n        </div>\r\n        <div class=\"col-lg-2 col-md-3 col-sm-3 form-group\">\r\n            <label>");
            EndContext();
            BeginContext(3097, 34, false);
#line 81 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Pharmacy\Views\DrugVendor\ECP_08_00.cshtml"
              Write(Localizer["MinimumSupplyQuantity"]);

#line default
#line hidden
            EndContext();
            BeginContext(3131, 132, true);
            WriteLiteral("</label>\r\n            <input id=\"txtMinimumSupplyQty\" name=\"MinimumSupplyQty\" class=\"form-control decimalFormat\" maxlength=\"10\" />\r\n");
            EndContext();
            BeginContext(3361, 96, true);
            WriteLiteral("        </div>\r\n        <div class=\"col-lg-2 col-md-3 col-sm-3 form-group\">\r\n            <label>");
            EndContext();
            BeginContext(3458, 21, false);
#line 86 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Pharmacy\Views\DrugVendor\ECP_08_00.cshtml"
              Write(Localizer["RateType"]);

#line default
#line hidden
            EndContext();
            BeginContext(3479, 165, true);
            WriteLiteral("</label>\r\n            <select class=\"form-control selectpicker\" data-live-search=\"true\" id=\"cboRateType\" title=\"Select\" onchange=\"fnSetRateType()\">\r\n                ");
            EndContext();
            BeginContext(3644, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb8e041c53e701ecba7e1cd21ee25f3545dfdc7d26100", async() => {
                BeginContext(3662, 6, true);
                WriteLiteral("Select");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3677, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(3695, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb8e041c53e701ecba7e1cd21ee25f3545dfdc7d27494", async() => {
                BeginContext(3714, 14, true);
                WriteLiteral("Purchase Order");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3737, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(3755, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb8e041c53e701ecba7e1cd21ee25f3545dfdc7d28899", async() => {
                BeginContext(3774, 13, true);
                WriteLiteral("Rate Contarct");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3796, 121, true);
            WriteLiteral("\r\n            </select>\r\n        </div>\r\n        <div class=\"col-lg-2 col-md-3 col-sm-3 form-group\">\r\n            <label>");
            EndContext();
            BeginContext(3918, 17, false);
#line 94 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Pharmacy\Views\DrugVendor\ECP_08_00.cshtml"
              Write(Localizer["Rate"]);

#line default
#line hidden
            EndContext();
            BeginContext(3935, 108, true);
            WriteLiteral("</label>\r\n            <input id=\"txtRate\" name=\"Rate\" class=\"form-control decimalFormat\" maxlength=\"14\" />\r\n");
            EndContext();
            BeginContext(4124, 322, true);
            WriteLiteral(@"        </div>

        <div class=""col-lg-12 col-md-12 col-sm-12 text-center"">
            <hr />
            <button type=""button"" class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent btn-back mr-10 c-white"" onclick=""fnCloseVendorDrugLink()""><i class=""fas fa-chevron-left""></i> ");
            EndContext();
            BeginContext(4447, 17, false);
#line 101 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Pharmacy\Views\DrugVendor\ECP_08_00.cshtml"
                                                                                                                                                                                                                      Write(Localizer["Back"]);

#line default
#line hidden
            EndContext();
            BeginContext(4464, 263, true);
            WriteLiteral(@"</button>
            <button type=""button"" class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent primary-button mr-10"" id=""btnSaveVendorDrugLink"" onclick=""fnSaveVendorDrugLink()"">
                <i class=""fa fa-save""></i> ");
            EndContext();
            BeginContext(4728, 17, false);
#line 103 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Pharmacy\Views\DrugVendor\ECP_08_00.cshtml"
                                      Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(4745, 223, true);
            WriteLiteral("\r\n            </button>\r\n            <button type=\"button\" class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect  cancel-button\" id=\"btnCancel\" onclick=\"fnCloseVendorDrugLink()\"><i class=\"fa fa-redo\"></i> ");
            EndContext();
            BeginContext(4969, 19, false);
#line 105 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Pharmacy\Views\DrugVendor\ECP_08_00.cshtml"
                                                                                                                                                                                                 Write(Localizer["Cancel"]);

#line default
#line hidden
            EndContext();
            BeginContext(4988, 59, true);
            WriteLiteral("</button>\r\n\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n\r\n\r\n");
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
