#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Facilities\Views\Doctors\_DoctorLeave.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75c0abb87b17c4eff412f54b3ac43d8fca79bf13"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Facilities_Views_Doctors__DoctorLeave), @"mvc.1.0.view", @"/Areas/Facilities/Views/Doctors/_DoctorLeave.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Facilities/Views/Doctors/_DoctorLeave.cshtml", typeof(AspNetCore.Areas_Facilities_Views_Doctors__DoctorLeave))]
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
#line 1 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Facilities\Views\Doctors\_DoctorLeave.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75c0abb87b17c4eff412f54b3ac43d8fca79bf13", @"/Areas/Facilities/Views/Doctors/_DoctorLeave.cshtml")]
    public class Areas_Facilities_Views_Doctors__DoctorLeave : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(136, 285, true);
            WriteLiteral(@"
<div class=""row"">
    <input type=""hidden"" id=""hdvDoctorLeaveFromDate"" value="""" />
    <div class=""col-lg-3 col-md-3 col-sm-3 col-xs-12"">
        <div class=""mdl-textfield mdl-js-textfield mdl-textfield--floating-label text-input-filed fullwidth is-upgraded"">
            <label>");
            EndContext();
            BeginContext(422, 24, false);
#line 10 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Facilities\Views\Doctors\_DoctorLeave.cshtml"
              Write(Localizer["OnLeaveFrom"]);

#line default
#line hidden
            EndContext();
            BeginContext(446, 432, true);
            WriteLiteral(@"</label>
            <input id=""txtOnLeaveFromDoctor"" class=""mdl-textfield__input "" type=""text"" autocomplete=""off"" onkeydown=""return false"" />
            <label class=""mdl-textfield__label"">   </label>
        </div>
    </div>
    <div class=""col-lg-3 col-md-3 col-sm-3 col-xs-12"">
        <div class=""mdl-textfield mdl-js-textfield mdl-textfield--floating-label text-input-filed fullwidth is-upgraded"">
            <label>");
            EndContext();
            BeginContext(879, 24, false);
#line 17 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Facilities\Views\Doctors\_DoctorLeave.cshtml"
              Write(Localizer["OnLeaveTill"]);

#line default
#line hidden
            EndContext();
            BeginContext(903, 393, true);
            WriteLiteral(@"</label>
            <input id=""txtOnLeaveTillDoctor"" class=""mdl-textfield__input datepicker"" type=""text"" autocomplete=""off"" onkeydown=""return false"" />
            <label class=""mdl-textfield__label"">   </label>
        </div>
    </div>
    <div class=""col-lg-3 col-md-3 col-sm-3 col-xs-12"">
        <div class=""form-group"" style=""margin-bottom: 0px !important;padding-top: 20px;"">

");
            EndContext();
            BeginContext(1577, 307, true);
            WriteLiteral(@"            <div class=""default-checkbox"">
                <label class=""mdl-checkbox mdl-js-checkbox mdl-js-ripple-effect"" for=""chkDoctorLeaveActive"">
                    <input type=""checkbox"" id=""chkDoctorLeaveActive"" class=""mdl-checkbox__input"">
                    <span class=""mdl-checkbox__label"">");
            EndContext();
            BeginContext(1885, 19, false);
#line 33 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Facilities\Views\Doctors\_DoctorLeave.cshtml"
                                                 Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(1904, 411, true);
            WriteLiteral(@"</span>
                </label>
            </div>
        </div>
    </div>
</div>
<div class=""row form-group"">
    <div class=""col-lg-12 col-md-12 col-sm-12 text-center"">
        <hr />
        <button type=""button"" class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent btn-back mr-10 c-white"" onclick=""fnCloseDoctorMaster()""><i class=""fas fa-chevron-left""></i> ");
            EndContext();
            BeginContext(2316, 17, false);
#line 42 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Facilities\Views\Doctors\_DoctorLeave.cshtml"
                                                                                                                                                                                                                Write(Localizer["Back"]);

#line default
#line hidden
            EndContext();
            BeginContext(2333, 237, true);
            WriteLiteral("</button>\r\n        <button type=\"button\" class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent primary-button mr-10\" id=\"btnSaveDoctorLeave\" onclick=\"fnSaveDoctorLeave()\"><i class=\"far fa-save\"></i>  ");
            EndContext();
            BeginContext(2571, 17, false);
#line 43 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Facilities\Views\Doctors\_DoctorLeave.cshtml"
                                                                                                                                                                                                                             Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(2588, 212, true);
            WriteLiteral("</button>\r\n        <button type=\"button\" class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect  cancel-button\" id=\"btnClearDoctorLeave\" onclick=\"fnClearDoctorLeave()\"><i class=\"fa fa-redo\"></i> ");
            EndContext();
            BeginContext(2801, 18, false);
#line 44 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Facilities\Views\Doctors\_DoctorLeave.cshtml"
                                                                                                                                                                                                    Write(Localizer["Clear"]);

#line default
#line hidden
            EndContext();
            BeginContext(2819, 891, true);
            WriteLiteral(@"</button>
    </div>
</div>
<!--End Text Filed Add Leave For Doctor -->
<!--On Leave From Doctor Grid-->
<div class="" row"">
    <div class=""col-lg-12"">
        <table id=""jqgDoctorLeave""></table>
        <div id=""jqpDoctorLeave""></div>
    </div>
</div>


<script>
    $(function () {

        $(""#txtOnLeaveFromDoctor"").datepicker({
            dateFormat: _cnfDateFormat,
            //minDate: new Date(),
            onSelect: function (date) {
                var dpToDate = $('#txtOnLeaveTillDoctor');
                var startDate = $(this).datepicker('getDate');
                var minDate = $(this).datepicker('getDate');
                dpToDate.datepicker('setDate', minDate);
                startDate.setDate(startDate.getDate() + 30);
                dpToDate.datepicker('option', 'minDate', minDate);
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
