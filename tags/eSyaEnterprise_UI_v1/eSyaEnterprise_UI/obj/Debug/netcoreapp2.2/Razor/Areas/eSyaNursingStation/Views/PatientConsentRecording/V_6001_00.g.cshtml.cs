#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNursingStation\Views\PatientConsentRecording\V_6001_00.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc219fdcf4f0344d7a7e5f0e8a2aadee19c14f95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_eSyaNursingStation_Views_PatientConsentRecording_V_6001_00), @"mvc.1.0.view", @"/Areas/eSyaNursingStation/Views/PatientConsentRecording/V_6001_00.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/eSyaNursingStation/Views/PatientConsentRecording/V_6001_00.cshtml", typeof(AspNetCore.Areas_eSyaNursingStation_Views_PatientConsentRecording_V_6001_00))]
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
#line 1 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNursingStation\Views\PatientConsentRecording\V_6001_00.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc219fdcf4f0344d7a7e5f0e8a2aadee19c14f95", @"/Areas/eSyaNursingStation/Views/PatientConsentRecording/V_6001_00.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Areas/eSyaNursingStation/Views/_ViewImports.cshtml")]
    public class Areas_eSyaNursingStation_Views_PatientConsentRecording_V_6001_00 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 5 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNursingStation\Views\PatientConsentRecording\V_6001_00.cshtml"
  
    ViewData["Title"] = "V_6001_00";

#line default
#line hidden
            BeginContext(129, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 9 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNursingStation\Views\PatientConsentRecording\V_6001_00.cshtml"
  
    var userFormRole = (eSyaEnterprise_UI.Models.DO_UserFormRole)ViewBag.UserFormRole;

#line default
#line hidden
            BeginContext(226, 48, true);
            WriteLiteral("\r\n<script>\r\n    var _userFormRole = JSON.parse(\'");
            EndContext();
            BeginContext(275, 38, false);
#line 14 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNursingStation\Views\PatientConsentRecording\V_6001_00.cshtml"
                               Write(Html.Raw(Json.Serialize(userFormRole)));

#line default
#line hidden
            EndContext();
            BeginContext(313, 60, true);
            WriteLiteral("\');\r\n\r\n     var localization = {\r\n         HospitalNumber: \'");
            EndContext();
            BeginContext(374, 28, false);
#line 17 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNursingStation\Views\PatientConsentRecording\V_6001_00.cshtml"
                     Write(Localizer["Hospital Number"]);

#line default
#line hidden
            EndContext();
            BeginContext(402, 24, true);
            WriteLiteral("\',\r\n         IPNumber: \'");
            EndContext();
            BeginContext(427, 22, false);
#line 18 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNursingStation\Views\PatientConsentRecording\V_6001_00.cshtml"
               Write(Localizer["IP Number"]);

#line default
#line hidden
            EndContext();
            BeginContext(449, 27, true);
            WriteLiteral("\',\r\n         PatientName: \'");
            EndContext();
            BeginContext(477, 25, false);
#line 19 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNursingStation\Views\PatientConsentRecording\V_6001_00.cshtml"
                  Write(Localizer["Patient Name"]);

#line default
#line hidden
            EndContext();
            BeginContext(502, 19, true);
            WriteLiteral("\',\r\n         Sex: \'");
            EndContext();
            BeginContext(522, 16, false);
#line 20 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNursingStation\Views\PatientConsentRecording\V_6001_00.cshtml"
          Write(Localizer["Sex"]);

#line default
#line hidden
            EndContext();
            BeginContext(538, 19, true);
            WriteLiteral("\',\r\n         Age: \'");
            EndContext();
            BeginContext(558, 16, false);
#line 21 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNursingStation\Views\PatientConsentRecording\V_6001_00.cshtml"
          Write(Localizer["Age"]);

#line default
#line hidden
            EndContext();
            BeginContext(574, 31, true);
            WriteLiteral("\',\r\n         DateOfAdmission: \'");
            EndContext();
            BeginContext(606, 30, false);
#line 22 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNursingStation\Views\PatientConsentRecording\V_6001_00.cshtml"
                      Write(Localizer["Date Of Admission"]);

#line default
#line hidden
            EndContext();
            BeginContext(636, 26, true);
            WriteLiteral("\',\r\n         DoctorName: \'");
            EndContext();
            BeginContext(663, 24, false);
#line 23 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNursingStation\Views\PatientConsentRecording\V_6001_00.cshtml"
                 Write(Localizer["Doctor Name"]);

#line default
#line hidden
            EndContext();
            BeginContext(687, 29, true);
            WriteLiteral("\',\r\n         SpecialtyDesc: \'");
            EndContext();
            BeginContext(717, 22, false);
#line 24 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNursingStation\Views\PatientConsentRecording\V_6001_00.cshtml"
                    Write(Localizer["Specialty"]);

#line default
#line hidden
            EndContext();
            BeginContext(739, 24, true);
            WriteLiteral("\',\r\n         RoomType: \'");
            EndContext();
            BeginContext(764, 22, false);
#line 25 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNursingStation\Views\PatientConsentRecording\V_6001_00.cshtml"
               Write(Localizer["Room Type"]);

#line default
#line hidden
            EndContext();
            BeginContext(786, 25, true);
            WriteLiteral("\',\r\n         BedNumber: \'");
            EndContext();
            BeginContext(812, 23, false);
#line 26 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNursingStation\Views\PatientConsentRecording\V_6001_00.cshtml"
                Write(Localizer["Bed Number"]);

#line default
#line hidden
            EndContext();
            BeginContext(835, 23, true);
            WriteLiteral("\',\r\n         Actions: \'");
            EndContext();
            BeginContext(859, 20, false);
#line 27 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNursingStation\Views\PatientConsentRecording\V_6001_00.cshtml"
              Write(Localizer["Actions"]);

#line default
#line hidden
            EndContext();
            BeginContext(879, 3259, true);
            WriteLiteral(@"',
    };

</script>

<div class=""row"">
    <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12 InPatientcontainer"">
        <table id=""jqgInPatient""></table>
        <div id=""jqpInPatient""></div>
    </div>
</div>

<script>
    $(document).ready(function () {
        fnloadInPatient();
    });
    var actiontype = """";
    function fnloadInPatient() {

        $(""#jqgInPatient"").GridUnload();

        $(""#jqgInPatient"").jqGrid({
            url: getBaseURL() + '/NurseAssessment/GetInPatientDetails',
            datatype: 'json',
            mtype: 'POST',
            contentType: 'application/json; charset=utf-8',
            ajaxGridOptions: { contentType: 'application/json; charset=utf-8' },
            colNames: [localization.HospitalNumber, localization.IPNumber, localization.PatientName, localization.Sex, localization.Age, localization.DateOfAdmission, localization.DoctorName, localization.RoomType, localization.BedNumber, localization.Actions],
            colModel: [
      ");
            WriteLiteral(@"          { name: ""HospitalNumber"", width:50 , align: 'left', resizable: false },
                { name: ""IPNumber"", width: 50, align: 'left', resizable: false },
                { name: ""PatientName"", editable: true, align: 'left', width: 95 },
                { name: ""Sex"", align: 'left', width: 28 },
                { name: ""Age"", align: 'left', width:30 },
                {
                    name: 'EffectiveDateOfAdmission', index: 'EffectiveDateOfAdmission', width: 55, sorttype: ""date"", formatter: ""date"", formatoptions:
                        { newformat: _cnfjqgDateFormat }
                },
                { name: ""DoctorName"", align: 'left', width: 120 },
                { name: ""RoomTypeDesc"", align: 'left', width: 100 },
                { name: ""BedNumber"", editable: true, align: 'left', width: 65 },
                {
                    name: 'edit', search: false, align: 'left', width: 125, sortable: false, resizable: false,
                    formatter: function (cellValue, op");
            WriteLiteral(@"tions, rowdata, action) {
                        return '<button class=""btn-xs ui-button ui-widget ui-corner-all btn-jqgrid f-11"" id=""jqgInPatient"", onclick=""return fnRedirectToConsentRecording(event)""><i class=""fas fa-user-nurse""></i> Consent Recording </button>';
                    }
                }
            ],
            pager: ""#jqpInPatient"",
            rowNum: 10000,
            rownumWidth: '55',
            loadonce: true,
            viewrecords: true,
            gridview: true,
            rownumbers: true,
            height: 'auto',
            scroll: false,
            width: 'auto',
            autowidth: true,
            shrinkToFit: true,
            forceFit: true,
            loadComplete: function (data) {
                var $grid = $(""#jqpInPatient""),
                    newWidth = $grid.closest("".InPatientcontainer"").parent().width();
                $grid.jqGrid(""setGridWidth"", newWidth, true);
            },

        });
    }

    function fnRedi");
            WriteLiteral("rectToConsentRecording(e) {\r\n        var rowid = $(e.target).parents(\"tr.jqgrow\").attr(\'id\');\r\n        var rowData = $(\'#jqgInPatient\').jqGrid(\'getRowData\', rowid);\r\n\r\n        var url = \'");
            EndContext();
            BeginContext(4140, 111, false);
#line 101 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNursingStation\Views\PatientConsentRecording\V_6001_00.cshtml"
               Write(Html.Raw( Url.Action("V_6001_CV", "PatientConsentRecording", new { UHID = "_UHID_", ipNumber = "_ipNumber_" })));

#line default
#line hidden
            EndContext();
            BeginContext(4252, 147, true);
            WriteLiteral("\';\r\n        window.location.href = url.replace(\'_UHID_\', rowData.HospitalNumber).replace(\'_ipNumber_\', rowData.IPNumber);\r\n    }\r\n\r\n</script>\r\n\r\n\r\n");
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
