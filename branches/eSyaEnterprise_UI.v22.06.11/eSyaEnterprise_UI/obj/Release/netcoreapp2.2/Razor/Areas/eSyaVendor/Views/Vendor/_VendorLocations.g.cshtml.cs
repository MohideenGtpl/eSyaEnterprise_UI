#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaVendor\Views\Vendor\_VendorLocations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2733c414d33b71d8c220be44b748a3064d37c9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_eSyaVendor_Views_Vendor__VendorLocations), @"mvc.1.0.view", @"/Areas/eSyaVendor/Views/Vendor/_VendorLocations.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/eSyaVendor/Views/Vendor/_VendorLocations.cshtml", typeof(AspNetCore.Areas_eSyaVendor_Views_Vendor__VendorLocations))]
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
#line 1 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaVendor\Views\Vendor\_VendorLocations.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2733c414d33b71d8c220be44b748a3064d37c9e", @"/Areas/eSyaVendor/Views/Vendor/_VendorLocations.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Areas/eSyaVendor/Views/_ViewImports.cshtml")]
    public class Areas_eSyaVendor_Views_Vendor__VendorLocations : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(206, 396, true);
            WriteLiteral(@"
<div class=""row padbot10 padtop15"">
    <div class=""col-lg-2 col-md-2 col-sm-6 col-xs-12"">
        <div class=""default-checkbox padtop20 form-group"">
            <label class=""mdl-checkbox mdl-js-checkbox mdl-js-ripple-effect"" for=""chkDefaulultloc"">
                <input type=""checkbox"" id=""chkDefaulultloc"" class=""mdl-checkbox__input"">
                <span class=""mdl-checkbox__label"">");
            EndContext();
            BeginContext(603, 28, false);
#line 14 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaVendor\Views\Vendor\_VendorLocations.cshtml"
                                             Write(Localizer["DefaultLocation"]);

#line default
#line hidden
            EndContext();
            BeginContext(631, 175, true);
            WriteLiteral(" </span>\r\n            </label>\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n    <div class=\"col-lg-6 col-md-6 col-sm-6 col-xs-12\">\r\n        <div class=\"form-group\">\r\n            <label>");
            EndContext();
            BeginContext(807, 26, false);
#line 23 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaVendor\Views\Vendor\_VendorLocations.cshtml"
              Write(Localizer["Contactperson"]);

#line default
#line hidden
            EndContext();
            BeginContext(833, 286, true);
            WriteLiteral(@" </label>
            <input id=""txtcontactperson"" class=""form-control"" type=""text"" autocomplete=""off"" maxlength=""75"" pattern=""^[a-zA-Z _]+$"" />

        </div>
    </div>
    <div class=""col-lg-4 col-md-4 col-sm-6 col-xs-12"">
        <div class=""form-group"">
            <label>");
            EndContext();
            BeginContext(1120, 31, false);
#line 30 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaVendor\Views\Vendor\_VendorLocations.cshtml"
              Write(Localizer["RegisteredMobileNo"]);

#line default
#line hidden
            EndContext();
            BeginContext(1151, 11, true);
            WriteLiteral(" </label>\r\n");
            EndContext();
            BeginContext(1811, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(1824, 74, false);
#line 42 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaVendor\Views\Vendor\_VendorLocations.cshtml"
       Write(await Component.InvokeAsync("IsdMobileInput", new { id = "VendorMobile" }));

#line default
#line hidden
            EndContext();
            BeginContext(1898, 139, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"col-lg-8 col-md-8 col-sm-8 col-xs-12\">\r\n        <div class=\"form-group\">\r\n            <label>");
            EndContext();
            BeginContext(2038, 20, false);
#line 47 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaVendor\Views\Vendor\_VendorLocations.cshtml"
              Write(Localizer["EmailID"]);

#line default
#line hidden
            EndContext();
            BeginContext(2058, 263, true);
            WriteLiteral(@" </label>
            <input id=""txtvendoremailid"" class=""form-control"" type=""email"" autocomplete=""off"" maxlength=""50"" />

        </div>
    </div>
    <div class=""col-lg-4 col-md-4 col-sm-6 col-xs-12"">
        <div class=""form-group"">
            <label>");
            EndContext();
            BeginContext(2322, 30, false);
#line 54 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaVendor\Views\Vendor\_VendorLocations.cshtml"
              Write(Localizer["AlternateMobileNo"]);

#line default
#line hidden
            EndContext();
            BeginContext(2352, 373, true);
            WriteLiteral(@" </label>

            <input id=""txtalternatemobileno"" class=""form-control"" type=""text"" autocomplete=""off"" maxlength=""15"" data-inputmask=""'mask': '9', 'repeat': 10, 'greedy' : false"" />
        </div>
    </div>

</div>
<div class=""row"">
    <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
        <div class=""form-group"">
            <label for=""sample5"">");
            EndContext();
            BeginContext(2726, 26, false);
#line 64 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaVendor\Views\Vendor\_VendorLocations.cshtml"
                            Write(Localizer["VendorAddress"]);

#line default
#line hidden
            EndContext();
            BeginContext(2752, 274, true);
            WriteLiteral(@" </label>
            <textarea class=""form-control"" type=""text"" rows=""2"" id=""txtaddress"" maxlength=""150""></textarea>
        </div>
    </div>
    <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
        <div class=""form-group"">
            <label for=""sample5"">");
            EndContext();
            BeginContext(3027, 27, false);
#line 70 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaVendor\Views\Vendor\_VendorLocations.cshtml"
                            Write(Localizer["VendorLocation"]);

#line default
#line hidden
            EndContext();
            BeginContext(3054, 503, true);
            WriteLiteral(@" </label>
            <input class=""form-control"" type=""text"" rows=""2"" id=""txtvendorlocation"" maxlength=""50"">
        </div>
    </div>
    <div class=""col-lg-2 col-md-2 col-sm-2 col-xs-12"">

        <div class=""default-checkbox padtop20 form-group"">
            <label class=""mdl-checkbox mdl-js-checkbox mdl-js-ripple-effect"" for=""chklocationstatus"">
                <input type=""checkbox"" id=""chklocationstatus"" class=""mdl-checkbox__input"">
                <span class=""mdl-checkbox__label"">");
            EndContext();
            BeginContext(3558, 19, false);
#line 79 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaVendor\Views\Vendor\_VendorLocations.cshtml"
                                             Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(3577, 368, true);
            WriteLiteral(@" </span>
            </label>
        </div>

    </div>
</div>
<div class=""row"">
    <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12 text-center"">
        <hr />
        <button type=""button"" class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent primary-button mr-10"" id=""btnlocationsave"" onclick=""fnSaveLocation()""> ");
            EndContext();
            BeginContext(3946, 17, false);
#line 88 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaVendor\Views\Vendor\_VendorLocations.cshtml"
                                                                                                                                                                                           Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(3963, 165, true);
            WriteLiteral(" </button>\r\n        <button type=\"button\" class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect  cancel-button\" onclick=\"fnClearLocationfields()\"> ");
            EndContext();
            BeginContext(4129, 18, false);
#line 89 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaVendor\Views\Vendor\_VendorLocations.cshtml"
                                                                                                                                                    Write(Localizer["Clear"]);

#line default
#line hidden
            EndContext();
            BeginContext(4147, 331, true);
            WriteLiteral(@" </button>
    </div>
</div>
<br />
<br />
<!-- Vendor Location Grid -->
<div class=""row"" style=""margin-bottom:10px;"">
    <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
        <table id=""jqgVendorLocation""></table>
        <div id=""jqpVendorLocation""></div>
    </div>
</div>
<!--End Vendor Location Grid -->
");
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