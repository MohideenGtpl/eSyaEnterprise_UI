#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaVendor\Views\Vendor\_StatutoryDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8600d91d3d1846ebf3342b741e05d667a9b6f0ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_eSyaVendor_Views_Vendor__StatutoryDetails), @"mvc.1.0.view", @"/Areas/eSyaVendor/Views/Vendor/_StatutoryDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/eSyaVendor/Views/Vendor/_StatutoryDetails.cshtml", typeof(AspNetCore.Areas_eSyaVendor_Views_Vendor__StatutoryDetails))]
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
#line 1 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaVendor\Views\Vendor\_StatutoryDetails.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8600d91d3d1846ebf3342b741e05d667a9b6f0ed", @"/Areas/eSyaVendor/Views/Vendor/_StatutoryDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Areas/eSyaVendor/Views/_ViewImports.cshtml")]
    public class Areas_eSyaVendor_Views_Vendor__StatutoryDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(206, 118, true);
            WriteLiteral("\r\n<div class=\"row padbot10 padtop15\">\r\n    <div class=\"col-lg-12 col-md-12 col-sm-12\">\r\n        <p class=\"subheading\">");
            EndContext();
            BeginContext(325, 27, false);
#line 11 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaVendor\Views\Vendor\_StatutoryDetails.cshtml"
                         Write(Localizer["VendorLocation"]);

#line default
#line hidden
            EndContext();
            BeginContext(352, 368, true);
            WriteLiteral(@" </p>
        <hr class=""left"" />
        <table id=""jqgLocationDetails""></table>
        <div id=""jqpLocationDetails""></div>

    </div>
</div>
<div class=""row"" id=""divstatutorydetailsform"" style=""margin-bottom:30px;margin-top:30px ;display:none"">

    <div class=""col-lg-4 col-md-4 col-sm-6 col-xs-12"">
        <div class=""form-group"">
            <label>");
            EndContext();
            BeginContext(721, 33, false);
#line 22 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaVendor\Views\Vendor\_StatutoryDetails.cshtml"
              Write(Localizer["StatutoryDescription"]);

#line default
#line hidden
            EndContext();
            BeginContext(754, 520, true);
            WriteLiteral(@" </label>
            <input id=""txtstatdetailsDesc"" class=""form-control"" type=""text"" autocomplete=""off"" maxlength=""50"" />

        </div>
    </div>

    <div class=""col-lg-2 col-md-2 col-sm-2 col-xs-12"">
        <div class=""default-checkbox padtop20 form-group"">
            <label class=""mdl-checkbox mdl-js-checkbox mdl-js-ripple-effect"" for=""chkstatutorystatus"">
                <input type=""checkbox"" id=""chkstatutorystatus"" class=""mdl-checkbox__input"">
                <span class=""mdl-checkbox__label"">");
            EndContext();
            BeginContext(1275, 19, false);
#line 32 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaVendor\Views\Vendor\_StatutoryDetails.cshtml"
                                             Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(1294, 404, true);
            WriteLiteral(@" </span>
            </label>
        </div>
    </div>
</div>
<div class=""row martop10"">
    <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center"">
        <hr />
        <button type=""button"" class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent primary-button"" id=""btnsavestatutory"" onclick=""fnSaveStatutorydetails()"" style=""margin-right:10px;"">");
            EndContext();
            BeginContext(1699, 17, false);
#line 40 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaVendor\Views\Vendor\_StatutoryDetails.cshtml"
                                                                                                                                                                                                                        Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(1716, 167, true);
            WriteLiteral("  </button>\r\n        <button type=\"button\" class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect  cancel-button\" onclick=\"fnClearStatutoryDetails()\">");
            EndContext();
            BeginContext(1884, 18, false);
#line 41 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaVendor\Views\Vendor\_StatutoryDetails.cshtml"
                                                                                                                                                     Write(Localizer["Clear"]);

#line default
#line hidden
            EndContext();
            BeginContext(1902, 124, true);
            WriteLiteral("  </button>\r\n    </div>\r\n</div>\r\n\r\n\r\n<div class=\"row padtop20\">\r\n    <div class=\"col-lg-12\">\r\n        <p class=\"subheading\">");
            EndContext();
            BeginContext(2027, 21, false);
#line 48 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaVendor\Views\Vendor\_StatutoryDetails.cshtml"
                         Write(Localizer["Location"]);

#line default
#line hidden
            EndContext();
            BeginContext(2048, 34, true);
            WriteLiteral("  <span id=\"lbllocationId\"></span>");
            EndContext();
            BeginContext(2083, 29, false);
#line 48 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaVendor\Views\Vendor\_StatutoryDetails.cshtml"
                                                                                 Write(Localizer["StatutoryDetails"]);

#line default
#line hidden
            EndContext();
            BeginContext(2112, 166, true);
            WriteLiteral("   </p>\r\n    </div>\r\n\r\n    <div class=\"col-lg-12\">\r\n        <table id=\"jqgStatutoryDetails\"></table>\r\n        <div id=\"jqpStatutoryDetails\"></div>\r\n    </div>\r\n</div>");
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
