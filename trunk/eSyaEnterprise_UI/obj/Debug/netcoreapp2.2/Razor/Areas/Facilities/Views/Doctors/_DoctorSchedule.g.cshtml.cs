#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Facilities\Views\Doctors\_DoctorSchedule.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "beb21848b6f430118c987819d7ad3058aff88c0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Facilities_Views_Doctors__DoctorSchedule), @"mvc.1.0.view", @"/Areas/Facilities/Views/Doctors/_DoctorSchedule.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Facilities/Views/Doctors/_DoctorSchedule.cshtml", typeof(AspNetCore.Areas_Facilities_Views_Doctors__DoctorSchedule))]
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
#line 1 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Facilities\Views\Doctors\_DoctorSchedule.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"beb21848b6f430118c987819d7ad3058aff88c0e", @"/Areas/Facilities/Views/Doctors/_DoctorSchedule.cshtml")]
    public class Areas_Facilities_Views_Doctors__DoctorSchedule : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Sunday", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Monday", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Tuesday", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Wednesday", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Thursday", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Friday", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Saturday", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(136, 220, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <input type=\"hidden\" id=\"hdvDoctorScheduleSerialNo\" value=\"\" />\r\n    <div class=\"col-lg-3 col-md-3 col-sm-4 col-xs-12\">\r\n        <div class=\"form-group\">\r\n            <label class=\"lable-color\"> ");
            EndContext();
            BeginContext(357, 21, false);
#line 10 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Facilities\Views\Doctors\_DoctorSchedule.cshtml"
                                   Write(Localizer["Location"]);

#line default
#line hidden
            EndContext();
            BeginContext(378, 10, true);
            WriteLiteral("</label>\r\n");
            EndContext();
            BeginContext(580, 304, true);
            WriteLiteral(@"            <select class=""selectpicker"" data-live-search=""true"" title="""" id=""cboDoctorLocation"" onchange=""fnLoadScheduleSpecialty()""></select>
        </div>
    </div>
    <div class=""col-lg-3 col-md-3 col-sm-4 col-xs-12"">
        <div class=""form-group"">

            <label class=""lable-color"">");
            EndContext();
            BeginContext(885, 22, false);
#line 18 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Facilities\Views\Doctors\_DoctorSchedule.cshtml"
                                  Write(Localizer["Specialty"]);

#line default
#line hidden
            EndContext();
            BeginContext(907, 301, true);
            WriteLiteral(@"</label>
            <select class=""selectpicker input"" title="""" id=""cboDoctorScheduleSpecialty"" onchange=""fnLoadScheduleClinic()""></select>
        </div>
    </div>
    <div class=""col-lg-3 col-md-3 col-sm-4 col-xs-12"">
        <div class=""form-group"">
            <label class=""lable-color""> ");
            EndContext();
            BeginContext(1209, 19, false);
#line 24 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Facilities\Views\Doctors\_DoctorSchedule.cshtml"
                                   Write(Localizer["Clinic"]);

#line default
#line hidden
            EndContext();
            BeginContext(1228, 300, true);
            WriteLiteral(@"</label>
            <select class=""selectpicker input"" title="""" id=""cboDoctorClinic"" onchange=""fnLoadScheduleConsultationType()""></select>
        </div>
    </div>
    <div class=""col-lg-3 col-md-3 col-sm-4 col-xs-12"">
        <div class=""form-group"">
            <label class=""lable-color""> ");
            EndContext();
            BeginContext(1529, 29, false);
#line 30 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Facilities\Views\Doctors\_DoctorSchedule.cshtml"
                                   Write(Localizer["ConsultationType"]);

#line default
#line hidden
            EndContext();
            BeginContext(1558, 271, true);
            WriteLiteral(@"</label>
            <select class=""selectpicker input"" title="""" id=""cboScheduleConsultationType""></select>
        </div>
    </div>

    <div class=""col-lg-3 col-md-3 col-sm-4 col-xs-12"">
        <div class=""form-group"">

            <label class=""lable-color"">");
            EndContext();
            BeginContext(1830, 25, false);
#line 38 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Facilities\Views\Doctors\_DoctorSchedule.cshtml"
                                  Write(Localizer["Dayoftheweek"]);

#line default
#line hidden
            EndContext();
            BeginContext(1855, 100, true);
            WriteLiteral("</label>\r\n            <select class=\"selectpicker\" id=\"cboDoctorScheduleWeekDays\">\r\n                ");
            EndContext();
            BeginContext(1955, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "beb21848b6f430118c987819d7ad3058aff88c0e9339", async() => {
                BeginContext(1973, 10, true);
                WriteLiteral("Choose day");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1992, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(2010, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "beb21848b6f430118c987819d7ad3058aff88c0e10737", async() => {
                BeginContext(2033, 6, true);
                WriteLiteral("Sunday");
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
            BeginContext(2048, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(2066, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "beb21848b6f430118c987819d7ad3058aff88c0e12131", async() => {
                BeginContext(2089, 6, true);
                WriteLiteral("Monday");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2104, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(2122, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "beb21848b6f430118c987819d7ad3058aff88c0e13525", async() => {
                BeginContext(2146, 7, true);
                WriteLiteral("Tuesday");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2162, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(2180, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "beb21848b6f430118c987819d7ad3058aff88c0e14920", async() => {
                BeginContext(2206, 9, true);
                WriteLiteral("Wednesday");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2224, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(2242, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "beb21848b6f430118c987819d7ad3058aff88c0e16317", async() => {
                BeginContext(2267, 8, true);
                WriteLiteral("Thursday");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2284, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(2302, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "beb21848b6f430118c987819d7ad3058aff88c0e17713", async() => {
                BeginContext(2325, 6, true);
                WriteLiteral("Friday");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2340, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(2358, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "beb21848b6f430118c987819d7ad3058aff88c0e19107", async() => {
                BeginContext(2383, 8, true);
                WriteLiteral("Saturday");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2400, 164, true);
            WriteLiteral("\r\n            </select>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-lg-2 col-md-2 col-sm-2 col-xs-12\">\r\n        <div class=\"form-group\">\r\n            <label>  ");
            EndContext();
            BeginContext(2565, 21, false);
#line 53 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Facilities\Views\Doctors\_DoctorSchedule.cshtml"
                Write(Localizer["FromTime"]);

#line default
#line hidden
            EndContext();
            BeginContext(2586, 243, true);
            WriteLiteral("</label>\r\n            <input id=\"txtFromTime\" class=\"form-control\" type=\"time\" autocomplete=\"off\" />\r\n\r\n        </div>\r\n    </div>\r\n    <div class=\"col-lg-2 col-md-2 col-sm-2 col-xs-12\">\r\n        <div class=\"form-group\">\r\n            <label>  ");
            EndContext();
            BeginContext(2830, 19, false);
#line 60 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Facilities\Views\Doctors\_DoctorSchedule.cshtml"
                Write(Localizer["ToTime"]);

#line default
#line hidden
            EndContext();
            BeginContext(2849, 252, true);
            WriteLiteral("</label>\r\n            <input id=\"txtToTime\" class=\"form-control\" type=\"time\" autocomplete=\"off\" />\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-lg-3 col-md-3 col-sm-3 col-xs-12\">\r\n        <label class=\"lable-color\">");
            EndContext();
            BeginContext(3102, 26, false);
#line 70 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Facilities\Views\Doctors\_DoctorSchedule.cshtml"
                              Write(Localizer["PatientsPerHr"]);

#line default
#line hidden
            EndContext();
            BeginContext(3128, 234, true);
            WriteLiteral("</label>\r\n        <input id=\"txtPatientsPerHr\" class=\"form-control integerFormat\" type=\"text\" maxlength=\"3\" autocomplete=\"off\" />\r\n    </div>\r\n    <div class=\"col-lg-3 col-md-3 col-sm-3 col-xs-12\">\r\n        <label class=\"lable-color\">");
            EndContext();
            BeginContext(3363, 27, false);
#line 74 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Facilities\Views\Doctors\_DoctorSchedule.cshtml"
                              Write(Localizer["TimeSlotInMins"]);

#line default
#line hidden
            EndContext();
            BeginContext(3390, 349, true);
            WriteLiteral(@"</label>
        <input id=""txtTimeSlotInMins"" class=""form-control integerFormat"" type=""text"" maxlength=""3"" autocomplete=""off"" />
    </div>
    <div class=""col-lg-1 col-md-1 col-sm-3 col-xs-12 form-group form-check"">
        <input type=""checkbox"" id=""chkWeek1"" class=""form-check-input"">
        <label class=""form-check-label"" for=""chkWeek1"">");
            EndContext();
            BeginContext(3740, 18, false);
#line 79 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Facilities\Views\Doctors\_DoctorSchedule.cshtml"
                                                  Write(Localizer["Week1"]);

#line default
#line hidden
            EndContext();
            BeginContext(3758, 165, true);
            WriteLiteral("</label>\r\n    </div>\r\n\r\n    <div class=\"col-lg-1 col-md-1 col-sm-3 col-xs-12\">\r\n        <label class=\"\" for=\"chkWeek2\"><input type=\"checkbox\" id=\"chkWeek2\" class=\"\">");
            EndContext();
            BeginContext(3924, 18, false);
#line 83 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Facilities\Views\Doctors\_DoctorSchedule.cshtml"
                                                                                Write(Localizer["Week2"]);

#line default
#line hidden
            EndContext();
            BeginContext(3942, 298, true);
            WriteLiteral(@"</label>
    </div>

    <div class=""col-lg-1 col-md-1 col-sm-3 col-xs-12"">
        <div class=""default-checkbox"">
            <label class="""" for=""chkWeek3"">
                <input type=""checkbox"" id=""chkWeek3"" class=""mdl-checkbox__input"">
                <span class=""mdl-checkbox__label"">");
            EndContext();
            BeginContext(4241, 18, false);
#line 90 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Facilities\Views\Doctors\_DoctorSchedule.cshtml"
                                             Write(Localizer["Week3"]);

#line default
#line hidden
            EndContext();
            BeginContext(4259, 335, true);
            WriteLiteral(@"</span>
            </label>
        </div>
    </div>

    <div class=""col-lg-1 col-md-1 col-sm-3 col-xs-12"">
        <div class=""default-checkbox"">
            <label class="""" for=""chkWeek4"">
                <input type=""checkbox"" id=""chkWeek4"" class=""mdl-checkbox__input"">
                <span class=""mdl-checkbox__label"">");
            EndContext();
            BeginContext(4595, 18, false);
#line 99 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Facilities\Views\Doctors\_DoctorSchedule.cshtml"
                                             Write(Localizer["Week4"]);

#line default
#line hidden
            EndContext();
            BeginContext(4613, 333, true);
            WriteLiteral(@"</span>
            </label>
        </div>
    </div>
    <div class=""col-lg-2 col-md-2 col-sm-3 col-xs-12"">
        <div class=""default-checkbox"">
            <label class="""" for=""chkWeek5"">
                <input type=""checkbox"" id=""chkWeek5"" class=""mdl-checkbox__input"">
                <span class=""mdl-checkbox__label"">");
            EndContext();
            BeginContext(4947, 18, false);
#line 107 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Facilities\Views\Doctors\_DoctorSchedule.cshtml"
                                             Write(Localizer["Week5"]);

#line default
#line hidden
            EndContext();
            BeginContext(4965, 402, true);
            WriteLiteral(@"</span>
            </label>
        </div>
    </div>

    <div class=""col-lg-2 col-md-2 col-sm-3 col-xs-12"">
        <div class=""default-checkbox"">
            <label class=""mdl-checkbox mdl-js-checkbox mdl-js-ripple-effect"" for=""chkScheduleActive"">
                <input type=""checkbox"" id=""chkScheduleActive"" class=""mdl-checkbox__input"">
                <span class=""mdl-checkbox__label"">");
            EndContext();
            BeginContext(5368, 19, false);
#line 116 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Facilities\Views\Doctors\_DoctorSchedule.cshtml"
                                             Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(5387, 394, true);
            WriteLiteral(@"</span>
            </label>
        </div>
    </div>

</div>


<div class=""row  form-group"">
    <div class=""col-lg-12 col-md-12 col-sm-12 text-center"">
        <hr />
        <button type=""button"" class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent btn-back mr-10 c-white"" onclick=""fnCloseDoctorMaster()""><i class=""fas fa-chevron-left""></i> ");
            EndContext();
            BeginContext(5782, 17, false);
#line 127 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Facilities\Views\Doctors\_DoctorSchedule.cshtml"
                                                                                                                                                                                                                Write(Localizer["Back"]);

#line default
#line hidden
            EndContext();
            BeginContext(5799, 243, true);
            WriteLiteral("</button>\r\n        <button type=\"button\" class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent primary-button mr-10\" id=\"btnSaveDoctorSchedule\" onclick=\"fnSaveDoctorSchedule()\"><i class=\"far fa-save\"></i>  ");
            EndContext();
            BeginContext(6043, 17, false);
#line 128 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Facilities\Views\Doctors\_DoctorSchedule.cshtml"
                                                                                                                                                                                                                                   Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(6060, 218, true);
            WriteLiteral("</button>\r\n        <button type=\"button\" class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect  cancel-button\" id=\"btnClearDoctorSchedule\" onclick=\"fnClearDoctorSchedule()\"><i class=\"fa fa-redo\"></i> ");
            EndContext();
            BeginContext(6279, 18, false);
#line 129 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Facilities\Views\Doctors\_DoctorSchedule.cshtml"
                                                                                                                                                                                                          Write(Localizer["Clear"]);

#line default
#line hidden
            EndContext();
            BeginContext(6297, 207, true);
            WriteLiteral("</button>\r\n    </div>\r\n</div>\r\n\r\n\r\n<div class=\" row form-group\">\r\n    <div class=\"col-lg-12\">\r\n        <table id=\"jqgDoctorSchedule\"></table>\r\n        <div id=\"jqpDoctorSchedule\"></div>\r\n    </div>\r\n</div>\r\n");
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
