#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaCustomer\Views\Customer\_StatutoryDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b258dc2743f60c19f7e9cfa77c3ef55512e3b61e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_eSyaCustomer_Views_Customer__StatutoryDetails), @"mvc.1.0.view", @"/Areas/eSyaCustomer/Views/Customer/_StatutoryDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/eSyaCustomer/Views/Customer/_StatutoryDetails.cshtml", typeof(AspNetCore.Areas_eSyaCustomer_Views_Customer__StatutoryDetails))]
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
#line 1 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaCustomer\Views\Customer\_StatutoryDetails.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b258dc2743f60c19f7e9cfa77c3ef55512e3b61e", @"/Areas/eSyaCustomer/Views/Customer/_StatutoryDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Areas/eSyaCustomer/Views/_ViewImports.cshtml")]
    public class Areas_eSyaCustomer_Views_Customer__StatutoryDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(82, 109, true);
            WriteLiteral("\r\n<div class=\"row padtop15\">\r\n    <div class=\"col-lg-12 col-md-12 col-sm-12\">\r\n        <p class=\"subheading\">");
            EndContext();
            BeginContext(192, 29, false);
#line 7 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaCustomer\Views\Customer\_StatutoryDetails.cshtml"
                         Write(Localizer["CustomerLocation"]);

#line default
#line hidden
            EndContext();
            BeginContext(221, 239, true);
            WriteLiteral(" </p>\r\n        <hr class=\"left\" />\r\n        <table id=\"jqgLocationDetails\"></table>\r\n        <div id=\"jqpLocationDetails\"></div>\r\n\r\n    </div>\r\n</div>\r\n<div class=\"row padtop15\">\r\n    <div class=\"col-lg-12\">\r\n        <p class=\"subheading\">");
            EndContext();
            BeginContext(461, 21, false);
#line 16 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaCustomer\Views\Customer\_StatutoryDetails.cshtml"
                         Write(Localizer["Location"]);

#line default
#line hidden
            EndContext();
            BeginContext(482, 35, true);
            WriteLiteral("  <span id=\"lbllocationId\"></span> ");
            EndContext();
            BeginContext(518, 29, false);
#line 16 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaCustomer\Views\Customer\_StatutoryDetails.cshtml"
                                                                                  Write(Localizer["StatutoryDetails"]);

#line default
#line hidden
            EndContext();
            BeginContext(547, 490, true);
            WriteLiteral(@"   </p>
        <hr class=""left"" />
    </div>

    <div class=""col-lg-12 padbot10"">
        <table id=""jqgStatutoryDetails""></table>
        <div id=""jqpStatutoryDetails""></div>
    </div>
    <div class=""col-lg-12 col-md-12 col-sm-12 text-center"">
        <hr />
        <button type=""button"" class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent btn-back mr-10 c-white"" onclick=""fnCloseCustomerDetails()""><i class=""fas fa-chevron-left""></i>");
            EndContext();
            BeginContext(1038, 17, false);
#line 26 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaCustomer\Views\Customer\_StatutoryDetails.cshtml"
                                                                                                                                                                                                                  Write(Localizer["Back"]);

#line default
#line hidden
            EndContext();
            BeginContext(1055, 261, true);
            WriteLiteral(@" </button>

        <button type=""button"" class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent primary-button mr-10"" id=""btnSaveStatutoryDetail"" onclick=""fnSaveStatutorydetails()"">
            <i class=""fa fa-save""></i> ");
            EndContext();
            BeginContext(1317, 17, false);
#line 29 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaCustomer\Views\Customer\_StatutoryDetails.cshtml"
                                  Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(1334, 247, true);
            WriteLiteral("  \r\n        </button>\r\n        <button type=\"button\" class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect  cancel-button\" id=\"btnCancelStatutoryDetail\" onclick=\"fnGridRefreshCustomerStatutoryDetails()\"><i class=\"fa fa-redo\"></i>");
            EndContext();
            BeginContext(1582, 18, false);
#line 31 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaCustomer\Views\Customer\_StatutoryDetails.cshtml"
                                                                                                                                                                                                                           Write(Localizer["Clear"]);

#line default
#line hidden
            EndContext();
            BeginContext(1600, 32, true);
            WriteLiteral(" </button>\r\n\r\n    </div>\r\n</div>");
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
