#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\PatientManagement\Views\ClinicalForms\_Allergy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78959130d5d328f2aa33465bc253fdada537392a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_PatientManagement_Views_ClinicalForms__Allergy), @"mvc.1.0.view", @"/Areas/PatientManagement/Views/ClinicalForms/_Allergy.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/PatientManagement/Views/ClinicalForms/_Allergy.cshtml", typeof(AspNetCore.Areas_PatientManagement_Views_ClinicalForms__Allergy))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78959130d5d328f2aa33465bc253fdada537392a", @"/Areas/PatientManagement/Views/ClinicalForms/_Allergy.cshtml")]
    public class Areas_PatientManagement_Views_ClinicalForms__Allergy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(120, 434, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-12 col-md-12 col-12"">
        <div class=""card"">
            <div class=""card-body"">
                <table id=""jqgAllergy""></table>
                <div id=""jqpAllergy""></div>
                <br />

            </div>
        </div>
    </div>
</div>
<button type=""button"" class=""mdl-button btn-float"" onclick=fnAddToGrid('ALLE','Allergy')><i class='fa fa-plus'></i></button>
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
