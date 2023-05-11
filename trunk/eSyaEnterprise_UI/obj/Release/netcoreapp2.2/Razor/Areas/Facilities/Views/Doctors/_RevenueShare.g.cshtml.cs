#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Facilities\Views\Doctors\_RevenueShare.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "559d8589122585a0d48d1bbaaf913ecfc545fb52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Facilities_Views_Doctors__RevenueShare), @"mvc.1.0.view", @"/Areas/Facilities/Views/Doctors/_RevenueShare.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Facilities/Views/Doctors/_RevenueShare.cshtml", typeof(AspNetCore.Areas_Facilities_Views_Doctors__RevenueShare))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"559d8589122585a0d48d1bbaaf913ecfc545fb52", @"/Areas/Facilities/Views/Doctors/_RevenueShare.cshtml")]
    public class Areas_Facilities_Views_Doctors__RevenueShare : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(124, 5103, true);
            WriteLiteral(@"<div class=""row"">
    <div class=""col-lg-12 col-md-12 col-12"">
        <table id=""jqgRevenueShare""></table>
        <div id=""jqpRevenueShare""></div>
    </div>
</div>
<script>
    $(document).ready(function () {
        fnGridLoadRevenueShare();
        $.contextMenu({
            // define which elements trigger this menu
            selector: ""#btnRevenueShare"",
            trigger: 'left',
            // define the elements of the menu
            items: {
                jqgEdit: { name: localization.Edit, icon: ""edit"", callback: function (key, opt) { fnEditRevenueShare(event, 'edit') } },
                jqgView: { name: localization.View, icon: ""view"", callback: function (key, opt) { fnEditRevenueShare(event, 'view') } },
                jqgDelete: { name: localization.Delete, icon: ""delete"", callback: function (key, opt) { fnEditRevenueShare(event, 'delete') } },
            }
            // there's more, have a look at the demos and docs...
        });
        $("".context-menu-ico");
            WriteLiteral(@"n-edit"").html(""<span class='icon-contextMenu'><i class='fa fa-pen'></i>"" + localization.Edit + "" </span>"");
        $("".context-menu-icon-view"").html(""<span class='icon-contextMenu'><i class='fa fa-eye'></i>"" + localization.View + "" </span>"");
        $("".context-menu-icon-delete"").html(""<span class='icon-contextMenu'><i class='fa fa-trash'></i>"" + localization.Delete + "" </span>"");
    });

    function fnGridLoadRevenueShare() {
        $('#jqgRevenueShare').jqGrid('GridUnload');
        $(""#jqgRevenueShare"").jqGrid({
           // url: ,
            //datatype: 'json',
          //  mtype: 'Post',
            ajaxGridOptions: { contentType: 'application/json; charset=utf-8' },
            jsonReader: { repeatitems: false, root: ""rows"", page: ""page"", total: ""total"", records: ""records"" },
            colNames: [localization.RateType, localization.ServiceRule, localization.DoctorPercentage, localization.HCPPercentage, localization.EFFFrom, localization.Till, localization.Active, localization.Acti");
            WriteLiteral(@"ons],
            colModel: [
                { name: ""RateType"", width: 85, editable: true, align: 'left', editoptions: { maxlength: 8 } },
                { name: ""ServiceRule"", width: 128, editable: true, align: 'left', editoptions: { maxlength: 5 } },
                { name: ""DoctorPercentage"", width: 158, editable: true, align: 'left', editoptions: { maxlength: 5} },
                { name: ""HCPPercentage"", width: 158, editable: true, align: 'left', editoptions: { maxlength: 5} },
                { name: ""EFFFrom"", width: 158, editable: true, align: 'left', editoptions: { maxlength: 5} },
                { name: ""Till"", width: 108, editable: true, align: 'left', editoptions: { maxlength: 150 } },
                { name: ""ActiveStatus"", editable: true, width: 48, align: 'center', resizable: false, edittype: ""checkbox"", formatter: 'checkbox', editoptions: { value: ""true:false"" }, formatoptions: { disabled: true } },
                {
                    name: 'action', search: false, align: 'left");
            WriteLiteral(@"', width: 120, sortable: false, resizable: false,
                    formatter: function (cellValue, options, rowdata, action) {
                        return '<button class=""mr-1 btn btn-outline"" id=""btnRevenueShare""><i class=""fa fa-ellipsis-v""></i></button>'
                    }
                },
            ],
            pager: ""#jqpRevenueShare"",
            rowNum: 10,
            rowList: [10, 20, 50, 100],
            rownumWidth: 55,
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
            scrollOffset: 0,
            caption: 'SMS Trigger Event',
            loadComplete: function (data) {
                SetGridControlByAction();
                fnJqgridSmallScreen(""jqgRevenueShare"");
            },
        }).jqGrid('navGrid', '#j");
            WriteLiteral(@"qpRevenueShare', {
            add: false, edit: false, search: false, del: false, refresh: false
        }).jqGrid('navButtonAdd', '#jqpRevenueShare', {
            caption: '<span class=""fa fa-sync""></span> Refresh', buttonicon: ""none"", id: ""custRefresh"", position: ""first"", onClickButton: fnGridRefreshRevenueShare
        }).jqGrid('navButtonAdd', '#jqpRevenueShare', {
            caption: '<span class=""fa fa-plus"" data-toggle=""modal""></span> Add', buttonicon: 'none', id: 'jqgAdd', position: 'first', onClickButton: fnAddRevenueShare
        });
        fnAddGridSerialNoHeading();
    }
    function fnAddRevenueShare() {
        PopupConsulationRates
        $(""#PopupRevenueShare"").modal('show');
        $('.modal-title').text(localization.AddRevenueShare);
    }
    function fnEditRevenueShare() {
        $(""#PopupRevenueShare"").modal('show');
        $('.modal-title').text(localization.EditRevenueShare);
    }
    function fnGridRefreshRevenueShare() {

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
