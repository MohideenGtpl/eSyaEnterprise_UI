#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaPayroll\Views\Employee\_CurrentJob.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5b1ec8a6939bcaae1ca834ff58c41ae1a4c9037"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_eSyaPayroll_Views_Employee__CurrentJob), @"mvc.1.0.view", @"/Areas/eSyaPayroll/Views/Employee/_CurrentJob.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/eSyaPayroll/Views/Employee/_CurrentJob.cshtml", typeof(AspNetCore.Areas_eSyaPayroll_Views_Employee__CurrentJob))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5b1ec8a6939bcaae1ca834ff58c41ae1a4c9037", @"/Areas/eSyaPayroll/Views/Employee/_CurrentJob.cshtml")]
    public class Areas_eSyaPayroll_Views_Employee__CurrentJob : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(120, 331, true);
            WriteLiteral(@"


<div class=""row padbot10"">
    <div class=""col-lg-12 col-md-12 col-sm-12"">
        <p class=""subheading"">Current Jobs</p>
        <hr class=""left"" />
    </div>
    <div class=""col-lg-12 col-md-12 col-sm-12"">
        <table id=""jqgCurrentJobs""></table>
        <div id=""jqpCurrentJobs""></div>
    </div>
</div>


");
            EndContext();
        }
        #pragma warning restore 1998
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
