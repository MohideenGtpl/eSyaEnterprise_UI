#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\Reports\V_6051_00.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7983a6e6d56986955d5a83607d4efc6874485f03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_eSyaOutPatient_Views_Reports_V_6051_00), @"mvc.1.0.view", @"/Areas/eSyaOutPatient/Views/Reports/V_6051_00.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/eSyaOutPatient/Views/Reports/V_6051_00.cshtml", typeof(AspNetCore.Areas_eSyaOutPatient_Views_Reports_V_6051_00))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7983a6e6d56986955d5a83607d4efc6874485f03", @"/Areas/eSyaOutPatient/Views/Reports/V_6051_00.cshtml")]
    public class Areas_eSyaOutPatient_Views_Reports_V_6051_00 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\Reports\V_6051_00.cshtml"
  
    ViewData["Title"] = "FacilityStay";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(97, 55, true);
            WriteLiteral("\r\n\r\n<div>\r\n    <input type=\"hidden\" id=\"hdfBusinessKey\"");
            EndContext();
            BeginWriteAttribute("value", " value=", 152, "", 179, 1);
#line 9 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaOutPatient\Views\Reports\V_6051_00.cshtml"
WriteAttributeValue("", 159, ViewBag.BusinessKey, 159, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(179, 2171, true);
            WriteLiteral(@" />
    <div class=""row"">

        <div class=""col-lg-2 col-md-4 col-sm-4"" style=""padding-top:8px;"">
            <label>From Date</label>  <input type=""date"" id=""dtFromDate"" class=""form-control"" />
        </div>
        <div class=""col-lg-2 col-md-4 col-sm-4"" style=""padding-top:8px;"">
            <label>To Date</label> <input type=""date"" id=""dtToDate"" class=""form-control"" />
        </div>
        <div class=""col-lg-2 col-md-4 col-sm-4"" style=""position:relative; top:25px;"">
            <button type=""submit"" class=""btn btn-primary"" onclick=""btnViewReport();""><i class=""glyphicon glyphicon-eye-open""></i> Submit</button>
        </div>

        <div class=""col-lg-2""></div>
    </div>
</div>
<div class=""clearfix""></div>
<div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
    <div id=""divPartialViewContainer"">
    </div>
</div>
<script>

    $(document).ready(function () {


    });

    function btnViewReport() {
        var fromDate = $(""#dtFromDate"").val();
        var toDate = $");
            WriteLiteral(@"(""#dtToDate"").val();
        var businessKey = $(""#hdfBusinessKey"").val();

        var URL = getReportBaseURL() + '/eSyaClinic/ReportViewer/FacilityStay';


        if (fromDate == null || fromDate == """") {
            toastr.warning(""Please select From Date"");
            return false;
        }
        else if (toDate == null || toDate == """") {
            toastr.warning(""Please select To Date"");
            return false;
        }
        else if (toDate < fromDate) {
            toastr.warning(""To Date can not be less than From Date"");
            return false;
        }
        else {
            $.ajax({
                url: URL,
                'async': false,
                data: { businesskey: businessKey, fromdate: fromDate, todate: toDate },
                type: 'POST',
                success: function (content) {
                    $('#divPartialViewContainer').html(content);
                },
                error: function (result) {
                    alert('E");
            WriteLiteral("rror, could not view!\');\r\n                }\r\n            });\r\n\r\n            return true;\r\n        }\r\n    }\r\n</script>\r\n\r\n\r\n");
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
