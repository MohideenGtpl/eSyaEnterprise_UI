#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaVendor\Views\Vendor\_BankDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c905265216ca35e0822007b9feb8b92c958700f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_eSyaVendor_Views_Vendor__BankDetails), @"mvc.1.0.view", @"/Areas/eSyaVendor/Views/Vendor/_BankDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/eSyaVendor/Views/Vendor/_BankDetails.cshtml", typeof(AspNetCore.Areas_eSyaVendor_Views_Vendor__BankDetails))]
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
#line 1 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaVendor\Views\Vendor\_BankDetails.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c905265216ca35e0822007b9feb8b92c958700f6", @"/Areas/eSyaVendor/Views/Vendor/_BankDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Areas/eSyaVendor/Views/_ViewImports.cshtml")]
    public class Areas_eSyaVendor_Views_Vendor__BankDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(82, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(206, 138, true);
            WriteLiteral("<div class=\"row padbot10 padtop15\">\r\n\r\n    <div class=\"col-lg-6 col-sm-6 col-md-6\">\r\n        <div class=\"form-group\">\r\n            <label>");
            EndContext();
            BeginContext(345, 28, false);
#line 12 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaVendor\Views\Vendor\_BankDetails.cshtml"
              Write(Localizer["BeneficiaryName"]);

#line default
#line hidden
            EndContext();
            BeginContext(373, 278, true);
            WriteLiteral(@" </label>
            <input id=""txtbeneficiaryname"" class=""form-control"" type=""text"" autocomplete=""off"" maxlength=""75"" pattern=""^[a-zA-Z _]+$"" />

        </div>
    </div>
    <div class=""col-lg-4 col-sm-6 col-md-4"">
        <div class=""form-group"">
            <label>");
            EndContext();
            BeginContext(652, 21, false);
#line 19 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaVendor\Views\Vendor\_BankDetails.cshtml"
              Write(Localizer["BankName"]);

#line default
#line hidden
            EndContext();
            BeginContext(673, 513, true);
            WriteLiteral(@" </label>
            <input id=""txtbankname"" class=""form-control"" type=""text"" autocomplete=""off"" maxlength=""50"" pattern=""^[a-zA-Z _]+$"" />

        </div>
    </div>
    <div class=""col-lg-2 col-sm-4 col-md-3"">
        <div class=""default-checkbox padtop20 form-group"">
            <label class=""mdl-checkbox mdl-js-checkbox mdl-js-ripple-effect"" for=""chkbanktatus"">
                <input type=""checkbox"" id=""chkbanktatus"" class=""mdl-checkbox__input"">
                <span class=""mdl-checkbox__label"">");
            EndContext();
            BeginContext(1187, 19, false);
#line 28 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaVendor\Views\Vendor\_BankDetails.cshtml"
                                             Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(1206, 159, true);
            WriteLiteral(" </span>\r\n            </label>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-lg-2 col-sm-4 col-md-3\">\r\n        <div class=\"form-group\">\r\n            <label>");
            EndContext();
            BeginContext(1366, 22, false);
#line 34 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaVendor\Views\Vendor\_BankDetails.cshtml"
              Write(Localizer["BankA/cNo"]);

#line default
#line hidden
            EndContext();
            BeginContext(1388, 247, true);
            WriteLiteral(".</label>\r\n            <input id=\"txtbankacno\" class=\"form-control\" type=\"text\" autocomplete=\"off\" maxlength=\"15\" />\r\n\r\n        </div>\r\n    </div>\r\n    <div class=\"col-lg-2 col-sm-4 col-md-3\">\r\n        <div class=\"form-group\">\r\n            <label>");
            EndContext();
            BeginContext(1636, 22, false);
#line 41 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaVendor\Views\Vendor\_BankDetails.cshtml"
              Write(Localizer["SwiftCode"]);

#line default
#line hidden
            EndContext();
            BeginContext(1658, 248, true);
            WriteLiteral(" </label>\r\n            <input id=\"txtswiftcode\" class=\"form-control\" type=\"text\" autocomplete=\"off\" maxlength=\"15\" />\r\n\r\n        </div>\r\n    </div>\r\n    <div class=\"col-lg-2 col-sm-4 col-md-3\">\r\n        <div class=\"form-group\">\r\n            <label>");
            EndContext();
            BeginContext(1907, 21, false);
#line 48 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaVendor\Views\Vendor\_BankDetails.cshtml"
              Write(Localizer["IFSCCode"]);

#line default
#line hidden
            EndContext();
            BeginContext(1928, 458, true);
            WriteLiteral(@" </label>
            <input id=""txtifsccode"" class=""form-control"" type=""text"" autocomplete=""off"" maxlength=""10"" />

        </div>
    </div>
</div>
<div class=""row padbot10"">
    <div class=""col-lg-12 col-md-12 col-sm-12 text-center"">
        <hr />
        <button type=""button"" class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent primary-button mr-10"" id=""btnSaveBankDetails"" onclick=""fnSaveBankDetails()"">");
            EndContext();
            BeginContext(2387, 17, false);
#line 57 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaVendor\Views\Vendor\_BankDetails.cshtml"
                                                                                                                                                                                                Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(2404, 161, true);
            WriteLiteral(" </button>\r\n        <button type=\"button\" class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect  cancel-button\" onclick=\"fnClearBankDetails()\">");
            EndContext();
            BeginContext(2566, 18, false);
#line 58 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaVendor\Views\Vendor\_BankDetails.cshtml"
                                                                                                                                                Write(Localizer["Clear"]);

#line default
#line hidden
            EndContext();
            BeginContext(2584, 254, true);
            WriteLiteral(" </button>\r\n    </div>\r\n</div>\r\n<div class=\"row\" style=\"margin-bottom:10px;\">\r\n    <div class=\"col-lg-12 col-md-12 col-sm-12 col-xs-12\">\r\n        <table id=\"jqgVendorBankDetails\"></table>\r\n        <div id=\"jqpVendorBankDetails\"></div>\r\n    </div>\r\n</div>");
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
