#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\PatientManagement\Views\PatientEMR\_InvestigationOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49eef672887fbe829070077e93b9df7edc1e6bd1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_PatientManagement_Views_PatientEMR__InvestigationOrder), @"mvc.1.0.view", @"/Areas/PatientManagement/Views/PatientEMR/_InvestigationOrder.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/PatientManagement/Views/PatientEMR/_InvestigationOrder.cshtml", typeof(AspNetCore.Areas_PatientManagement_Views_PatientEMR__InvestigationOrder))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49eef672887fbe829070077e93b9df7edc1e6bd1", @"/Areas/PatientManagement/Views/PatientEMR/_InvestigationOrder.cshtml")]
    public class Areas_PatientManagement_Views_PatientEMR__InvestigationOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(120, 2496, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-12 col-md-12 col-12"">
        <div class=""card"">
            <div class=""card-body"">
                <table id=""jqgInvestigationOrder""></table>
                <div id=""jqpInvestigationOrder""></div>
            </div>
        </div>
    </div>
</div>

<script>
    $(function () {
        fnGridInvestigationOrder();
    });

    function fnGridInvestigationOrder() {
        $(""#jqgInvestigationOrder"").jqGrid({
            //  url: getBaseURL() + '' +,
            mtype: 'Post',
            datatype: 'json',
            ajaxGridOptions: { contentType: 'application/json; charset=utf-8' },
            jsonReader: { repeatitems: false, root: ""rows"", page: ""page"", total: ""total"", records: ""records"" },
            colNames: [""Prepared by"", ""InvestigationOrder""],
            colModel: [
                { name: ""PreparedBy"", width: 50, editable: true, align: 'left', hidden: false },
                { name: ""InvestigationOrder"", width: 70, editable: f");
            WriteLiteral(@"alse, hidden: false, align: 'left', resizable: true },
             ],
            pager: ""#jqpInvestigationOrder"",
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
            scrollOffset: 0, caption: 'InvestigationOrder',
            loadComplete: function (data) {
                SetGridControlByAction();
                fnJqgridSmallScreen(""jqpInvestigationOrder"");
            },
            onSelectRow: function (rowid, status, e) {
            },
        }).jqGrid('navGrid', '#jqpInvestigationOrder', { add: false, edit: false, search: false, del: false, refresh: false }).jqGrid('navButtonAdd', '#jqpInvestigationOrder', {
            ");
            WriteLiteral(@"caption: '<span class=""fa fa-sync""></span> Refresh', buttonicon: ""none"", id: ""custInvestigationOrderRefresh"", position: ""first"", onClickButton: ''
        }).jqGrid('navButtonAdd', '#jqpInvestigationOrder', {
            caption: '<span class=""fa fa-plus"" data-toggle=""modal""></span> Add', buttonicon: 'none', id: 'jqgInvestigationOrderAdd', position: 'first', onClickButton: ''
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
