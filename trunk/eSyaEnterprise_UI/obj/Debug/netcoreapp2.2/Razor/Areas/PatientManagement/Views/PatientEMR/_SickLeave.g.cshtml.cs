#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\PatientManagement\Views\PatientEMR\_SickLeave.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f28e5be881760605b4ccbc9ce55f2b22828a6c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_PatientManagement_Views_PatientEMR__SickLeave), @"mvc.1.0.view", @"/Areas/PatientManagement/Views/PatientEMR/_SickLeave.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/PatientManagement/Views/PatientEMR/_SickLeave.cshtml", typeof(AspNetCore.Areas_PatientManagement_Views_PatientEMR__SickLeave))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f28e5be881760605b4ccbc9ce55f2b22828a6c4", @"/Areas/PatientManagement/Views/PatientEMR/_SickLeave.cshtml")]
    public class Areas_PatientManagement_Views_PatientEMR__SickLeave : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(120, 2466, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-12 col-md-12 col-12"">
        <div class=""card"">
            <div class=""card-body"">
                <table id=""jqgSickLeave""></table>
                <div id=""jqpSickLeave""></div>
            </div>
        </div>
    </div>
</div>

<script>
    $(function () {
        fnGridSickLeave();
    });

    function fnGridSickLeave() {
        $(""#jqgSickLeave"").jqGrid({
            //  url: getBaseURL() + '' +,
            mtype: 'Post',
            datatype: 'json',
            ajaxGridOptions: { contentType: 'application/json; charset=utf-8' },
            jsonReader: { repeatitems: false, root: ""rows"", page: ""page"", total: ""total"", records: ""records"" },
            colNames: [""Action"",""Prepared On"",""Prepared by""],
            colModel: [
                { name: ""Action"", width: 50, editable: true, align: 'left', hidden: false },
                { name: ""PreparedOn"", width: 50, editable: true, align: 'left', hidden: false },
                { ");
            WriteLiteral(@"name: ""PreparedBy"", width: 70, editable: false, hidden: false, align: 'left', resizable: true },
             ],
            pager: ""#jqpSickLeave"",
            rowNum: 10000,
            rownumWidth: '55',
            pgtext: null,
            pgbuttons: null,
            loadonce: true,
            viewrecords: true,
            gridview: true,
            rownumbers: true,
            height: 'auto',
            align: ""left"",
            width: 'auto',
            autowidth: true,
            shrinkToFit: true,
            forceFit: true,
            scrollOffset: 0, caption: 'SickLeave',
            loadComplete: function (data) {
                SetGridControlByAction();
                fnJqgridSmallScreen(""jqpSickLeave"");
            },
            onSelectRow: function (rowid, status, e) {
            },
        }).jqGrid('navGrid', '#jqpSickLeave', { add: false, edit: false, search: false, del: false, refresh: false }).jqGrid('navButtonAdd', '#jqpSickLeave', {
            cap");
            WriteLiteral(@"tion: '<span class=""fa fa-sync""></span> Refresh', buttonicon: ""none"", id: ""custSickLeaveRefresh"", position: ""first"", onClickButton: ''
        }).jqGrid('navButtonAdd', '#jqpSickLeave', {
            caption: '<span class=""fa fa-plus"" data-toggle=""modal""></span> Add', buttonicon: 'none', id: 'jqgSickLeaveAdd', position: 'first', onClickButton: ''
        });
        fnAddGridSerialNoHeading();
    }
</script>");
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
