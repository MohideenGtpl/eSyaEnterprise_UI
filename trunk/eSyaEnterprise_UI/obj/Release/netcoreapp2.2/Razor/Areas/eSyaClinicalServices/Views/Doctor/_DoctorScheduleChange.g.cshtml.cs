#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaClinicalServices\Views\Doctor\_DoctorScheduleChange.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8049ffacfc81ab692470a9900d362a64d37a6eac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_eSyaClinicalServices_Views_Doctor__DoctorScheduleChange), @"mvc.1.0.view", @"/Areas/eSyaClinicalServices/Views/Doctor/_DoctorScheduleChange.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/eSyaClinicalServices/Views/Doctor/_DoctorScheduleChange.cshtml", typeof(AspNetCore.Areas_eSyaClinicalServices_Views_Doctor__DoctorScheduleChange))]
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
#line 1 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaClinicalServices\Views\Doctor\_DoctorScheduleChange.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8049ffacfc81ab692470a9900d362a64d37a6eac", @"/Areas/eSyaClinicalServices/Views/Doctor/_DoctorScheduleChange.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Areas/eSyaClinicalServices/Views/_ViewImports.cshtml")]
    public class Areas_eSyaClinicalServices_Views_Doctor__DoctorScheduleChange : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(82, 201, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <input type=\"hidden\" id=\"hdvDoctorScheduleChangeDate\" value=\"\" />\r\n    <div class=\"col-lg-3 col-md-3 col-sm-4 col-xs-12\">\r\n        <div class=\"form-group\">\r\n            <label>");
            EndContext();
            BeginContext(284, 21, false);
#line 9 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaClinicalServices\Views\Doctor\_DoctorScheduleChange.cshtml"
              Write(Localizer["Location"]);

#line default
#line hidden
            EndContext();
            BeginContext(305, 10, true);
            WriteLiteral("</label>\r\n");
            EndContext();
            BeginContext(527, 303, true);
            WriteLiteral(@"            <select class=""selectpicker"" data-live-search=""true"" title="""" id=""cboDoctorScheduleChangeLocation""  onchange=""fnLoadScheduleChangeSpecialty()""></select>
        </div>
    </div>
    <div class=""col-lg-3 col-md-3 col-sm-4 col-xs-12"">
        <div class=""form-group"">
            <label>");
            EndContext();
            BeginContext(831, 22, false);
#line 16 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaClinicalServices\Views\Doctor\_DoctorScheduleChange.cshtml"
              Write(Localizer["Specialty"]);

#line default
#line hidden
            EndContext();
            BeginContext(853, 310, true);
            WriteLiteral(@"</label>
            <select class=""selectpicker"" data-live-search=""true"" title="""" id=""cboDoctorScheduleChangeSpecialty"" onchange=""fnLoadScheduleChangeClinic()""></select>
        </div>
    </div>
    <div class=""col-lg-3 col-md-3 col-sm-4 col-xs-12"">
        <div class=""form-group"">
            <label>");
            EndContext();
            BeginContext(1164, 19, false);
#line 22 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaClinicalServices\Views\Doctor\_DoctorScheduleChange.cshtml"
              Write(Localizer["Clinic"]);

#line default
#line hidden
            EndContext();
            BeginContext(1183, 317, true);
            WriteLiteral(@"</label>
            <select class=""selectpicker"" data-live-search=""true"" title="""" id=""cboDoctorScheduleChangeClinic"" onchange=""fnLoadScheduleChangeConsultationType()""></select>
        </div>
    </div>
    <div class=""col-lg-3 col-md-3 col-sm-4 col-xs-12"">
        <div class=""form-group"">
            <label>");
            EndContext();
            BeginContext(1501, 29, false);
#line 28 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaClinicalServices\Views\Doctor\_DoctorScheduleChange.cshtml"
              Write(Localizer["ConsultationType"]);

#line default
#line hidden
            EndContext();
            BeginContext(1530, 277, true);
            WriteLiteral(@"</label>
            <select class=""selectpicker"" data-live-search=""true"" title="""" id=""cboDoctorScheduleChangeConsultationType""></select>
        </div>
    </div>
    <div class=""col-lg-3 col-md-3 col-sm-4 col-xs-12"">
        <div class=""form-group"">
            <label>");
            EndContext();
            BeginContext(1808, 25, false);
#line 34 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaClinicalServices\Views\Doctor\_DoctorScheduleChange.cshtml"
              Write(Localizer["ScheduleDate"]);

#line default
#line hidden
            EndContext();
            BeginContext(1833, 287, true);
            WriteLiteral(@"</label>
            <input id=""dtDoctorScheduleChangeDate"" class=""mdl-textfield__input"" type=""text"" autocomplete=""off"" onkeydown=""return false"" />
        </div>
    </div>
    <div class=""col-lg-2 col-md-2 col-sm-3 col-xs-12"">
        <div class=""form-group"">
            <label>");
            EndContext();
            BeginContext(2121, 21, false);
#line 40 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaClinicalServices\Views\Doctor\_DoctorScheduleChange.cshtml"
              Write(Localizer["FromTime"]);

#line default
#line hidden
            EndContext();
            BeginContext(2142, 284, true);
            WriteLiteral(@"</label>
            <input id=""txtDoctorScheduleChangeFromTime"" class=""form-control"" type=""time"" autocomplete=""off"" data-time-format=""H:i:s"" />
        </div>
    </div>
    <div class=""col-lg-2 col-md-2 col-sm-3 col-xs-12"">
        <div class=""form-group"">
            <label>");
            EndContext();
            BeginContext(2427, 19, false);
#line 46 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaClinicalServices\Views\Doctor\_DoctorScheduleChange.cshtml"
              Write(Localizer["ToTime"]);

#line default
#line hidden
            EndContext();
            BeginContext(2446, 538, true);
            WriteLiteral(@"</label>
            <input id=""txtDoctorScheduleChangeToTime"" class=""form-control"" type=""time"" autocomplete=""off"" data-time-format=""H:i:s"" />
        </div>
    </div>
    <div class=""col-lg-3 col-md-3 col-sm-3 col-xs-12"">
        <div class=""default-checkbox"">
            <label class=""mdl-checkbox mdl-js-checkbox mdl-js-ripple-effect"" for=""chkDoctorScheduleChangeActive"">
                <input type=""checkbox"" id=""chkDoctorScheduleChangeActive"" class=""mdl-checkbox__input"">
                <span class=""mdl-checkbox__label"">");
            EndContext();
            BeginContext(2985, 19, false);
#line 54 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaClinicalServices\Views\Doctor\_DoctorScheduleChange.cshtml"
                                             Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(3004, 389, true);
            WriteLiteral(@"</span>
            </label>
        </div>
    </div>
</div>

<div class=""row form-group"">
    <div class=""col-lg-12 col-md-12 col-sm-12 text-center"">
        <hr />
        <button type=""button"" class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent btn-back mr-10 c-white"" onclick=""fnCloseDoctorMaster()""><i class=""fas fa-chevron-left""></i> ");
            EndContext();
            BeginContext(3394, 17, false);
#line 63 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaClinicalServices\Views\Doctor\_DoctorScheduleChange.cshtml"
                                                                                                                                                                                                                Write(Localizer["Back"]);

#line default
#line hidden
            EndContext();
            BeginContext(3411, 255, true);
            WriteLiteral("</button>\r\n        <button type=\"button\" class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent primary-button mr-10\" id=\"btnSaveDoctorScheduleChange\" onclick=\"fnSaveDoctorScheduleChange()\"><i class=\"far fa-save\"></i>  ");
            EndContext();
            BeginContext(3667, 17, false);
#line 64 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaClinicalServices\Views\Doctor\_DoctorScheduleChange.cshtml"
                                                                                                                                                                                                                                               Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(3684, 234, true);
            WriteLiteral("</button>\r\n        <button type=\"button\" class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect  cancel-button\" id=\"btnClearDoctorScheduleChange\" onclick=\"fnClearDoctorScheduleChangeSave()\"><i class=\"fa fa-redo\"></i> ");
            EndContext();
            BeginContext(3919, 18, false);
#line 65 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaClinicalServices\Views\Doctor\_DoctorScheduleChange.cshtml"
                                                                                                                                                                                                                          Write(Localizer["Clear"]);

#line default
#line hidden
            EndContext();
            BeginContext(3937, 740, true);
            WriteLiteral(@"</button>
    </div>
</div>

<!--End Text Filed Doctor Scheduler Change -->
<!-- Doctor Scheduler Change Grid-->
<div class=""row form-group"">
    <div class=""col-lg-12"">
        <table id=""jqgDocScheduleChange""></table>
        <div id=""jqpDocScheduleChange""></div>
    </div>
</div>

<script>
    $(function () {

        $(""#dtDoctorScheduleChangeDate"").datepicker({
            dateFormat: _cnfDateFormat,
            minDate: new Date(),
            onSelect: function (date) {
                var startDate = $(this).datepicker('getDate');
                var minDate = $(this).datepicker('getDate');
                startDate.setDate(startDate.getDate() + 30);

            }
        });

    });
</script>");
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
