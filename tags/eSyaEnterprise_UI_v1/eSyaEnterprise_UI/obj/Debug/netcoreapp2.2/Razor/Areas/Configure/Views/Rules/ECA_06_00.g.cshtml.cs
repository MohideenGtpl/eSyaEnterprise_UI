#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Rules\ECA_06_00.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b8d910405d74e3888146fd5a7a4ce6968d0af80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Configure_Views_Rules_ECA_06_00), @"mvc.1.0.view", @"/Areas/Configure/Views/Rules/ECA_06_00.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Configure/Views/Rules/ECA_06_00.cshtml", typeof(AspNetCore.Areas_Configure_Views_Rules_ECA_06_00))]
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
#line 1 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Rules\ECA_06_00.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b8d910405d74e3888146fd5a7a4ce6968d0af80", @"/Areas/Configure/Views/Rules/ECA_06_00.cshtml")]
    public class Areas_Configure_Views_Rules_ECA_06_00 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(80, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Rules\ECA_06_00.cshtml"
  
    ViewData["Title"] = "Process Rule";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#line 8 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Rules\ECA_06_00.cshtml"
  
    var userFormRole = (eSyaEnterprise_UI.Models.DO_UserFormRole)ViewBag.UserFormRole;

#line default
#line hidden
            BeginContext(272, 46, true);
            WriteLiteral("<script>\r\n    var _userFormRole = JSON.parse(\'");
            EndContext();
            BeginContext(319, 38, false);
#line 12 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Rules\ECA_06_00.cshtml"
                               Write(Html.Raw(Json.Serialize(userFormRole)));

#line default
#line hidden
            EndContext();
            BeginContext(357, 54, true);
            WriteLiteral("\');\r\n\r\n     var localization = {\r\n        ProcessId: \'");
            EndContext();
            BeginContext(412, 22, false);
#line 15 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Rules\ECA_06_00.cshtml"
               Write(Localizer["ProcessId"]);

#line default
#line hidden
            EndContext();
            BeginContext(434, 33, true);
            WriteLiteral("\',\r\n        ProcessDescription: \'");
            EndContext();
            BeginContext(468, 31, false);
#line 16 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Rules\ECA_06_00.cshtml"
                        Write(Localizer["ProcessDescription"]);

#line default
#line hidden
            EndContext();
            BeginContext(499, 32, true);
            WriteLiteral("\',\r\n        IsSegmentSpecific: \'");
            EndContext();
            BeginContext(532, 30, false);
#line 17 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Rules\ECA_06_00.cshtml"
                       Write(Localizer["IsSegmentSpecific"]);

#line default
#line hidden
            EndContext();
            BeginContext(562, 28, true);
            WriteLiteral("\',\r\n        SystemControl: \'");
            EndContext();
            BeginContext(591, 26, false);
#line 18 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Rules\ECA_06_00.cshtml"
                   Write(Localizer["SystemControl"]);

#line default
#line hidden
            EndContext();
            BeginContext(617, 29, true);
            WriteLiteral("\',\r\n        ProcessControl: \'");
            EndContext();
            BeginContext(647, 27, false);
#line 19 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Rules\ECA_06_00.cshtml"
                    Write(Localizer["ProcessControl"]);

#line default
#line hidden
            EndContext();
            BeginContext(674, 28, true);
            WriteLiteral("\',\r\n        ProcessStatus: \'");
            EndContext();
            BeginContext(703, 26, false);
#line 20 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Rules\ECA_06_00.cshtml"
                   Write(Localizer["ProcessStatus"]);

#line default
#line hidden
            EndContext();
            BeginContext(729, 21, true);
            WriteLiteral("\',\r\n        Active: \'");
            EndContext();
            BeginContext(751, 19, false);
#line 21 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Rules\ECA_06_00.cshtml"
            Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(770, 22, true);
            WriteLiteral("\',\r\n        Actions: \'");
            EndContext();
            BeginContext(793, 20, false);
#line 22 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Rules\ECA_06_00.cshtml"
             Write(Localizer["Actions"]);

#line default
#line hidden
            EndContext();
            BeginContext(813, 19, true);
            WriteLiteral("\',\r\n        Edit: \'");
            EndContext();
            BeginContext(833, 17, false);
#line 23 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Rules\ECA_06_00.cshtml"
          Write(Localizer["Edit"]);

#line default
#line hidden
            EndContext();
            BeginContext(850, 19, true);
            WriteLiteral("\',\r\n        View: \'");
            EndContext();
            BeginContext(870, 17, false);
#line 24 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Rules\ECA_06_00.cshtml"
          Write(Localizer["View"]);

#line default
#line hidden
            EndContext();
            BeginContext(887, 21, true);
            WriteLiteral("\',\r\n        RuleId: \'");
            EndContext();
            BeginContext(909, 19, false);
#line 25 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Rules\ECA_06_00.cshtml"
            Write(Localizer["RuleId"]);

#line default
#line hidden
            EndContext();
            BeginContext(928, 30, true);
            WriteLiteral("\',\r\n        RuleDescription: \'");
            EndContext();
            BeginContext(959, 28, false);
#line 26 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Rules\ECA_06_00.cshtml"
                     Write(Localizer["RuleDescription"]);

#line default
#line hidden
            EndContext();
            BeginContext(987, 25, true);
            WriteLiteral("\',\r\n        RuleStatus: \'");
            EndContext();
            BeginContext(1013, 23, false);
#line 27 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Rules\ECA_06_00.cshtml"
                Write(Localizer["RuleStatus"]);

#line default
#line hidden
            EndContext();
            BeginContext(1036, 26, true);
            WriteLiteral("\',\r\n        EditProcess: \'");
            EndContext();
            BeginContext(1063, 24, false);
#line 28 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Rules\ECA_06_00.cshtml"
                 Write(Localizer["EditProcess"]);

#line default
#line hidden
            EndContext();
            BeginContext(1087, 25, true);
            WriteLiteral("\',\r\n        AddProcess: \'");
            EndContext();
            BeginContext(1113, 23, false);
#line 29 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Rules\ECA_06_00.cshtml"
                Write(Localizer["AddProcess"]);

#line default
#line hidden
            EndContext();
            BeginContext(1136, 31, true);
            WriteLiteral("\',\r\n        EditProcessRule : \'");
            EndContext();
            BeginContext(1168, 28, false);
#line 30 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Rules\ECA_06_00.cshtml"
                      Write(Localizer["EditProcessRule"]);

#line default
#line hidden
            EndContext();
            BeginContext(1196, 30, true);
            WriteLiteral("\',\r\n        AddProcessRule : \'");
            EndContext();
            BeginContext(1227, 27, false);
#line 31 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Rules\ECA_06_00.cshtml"
                     Write(Localizer["AddProcessRule"]);

#line default
#line hidden
            EndContext();
            BeginContext(1254, 22066, true);
            WriteLiteral(@"',

    };
</script>
<div class=""processcontainer"">
    <div class=""row"">
        <div class=""col-sm-12 col-md-12 col-lg-12"">
            <table id=""gvProcessRule""></table>
            <div id=""pgProcessRule""></div>
        </div>
    </div>
</div>

<style>
    .ui-widget-content {
        border-left: 1px solid rgba(0,0,0,0.1) !important;
        border-right: 1px solid rgba(0,0,0,0.1) !important;
        border-right-style: solid;
        border-top: 1px solid #eaeaea !important;
        border-bottom: 1px solid #eaeaea !important;
    }
</style>

<script>
    var data = new Array();
    $(document).ready(function () {
        var newrowid;
        var newrowids;
        var grid = $(""#gvProcessRule"");
        callingJQGrid();
        fnGridProcessRule();

        function callingJQGrid() {
            grid.jqGrid({
                url: getBaseURL() + ""/Rules/GetProcessMaster"",
                datatype: ""json"",
                contenttype: ""application/json; charset-utf-8");
            WriteLiteral(@""",
                mtype: 'GET',
                jsonReader: { repeatitems: false, root: ""rows"", page: ""page"", total: ""total"", records: ""records"" },
                colNames: [localization.ProcessId, localization.ProcessDescription, localization.IsSegmentSpecific, localization.SystemControl, localization.ProcessControl, localization.ProcessStatus],
                colModel: [
                    {
                        name: ""ProcessId"", editable: true, width: ""80px"", formatter: 'integer', editoptions: {
                            dataInit: function (element) {
                                $(element).keypress(function (e) {
                                    if (e.which != 8 && e.which != 0 && (e.which < 48 || e.which > 57)) {
                                        return false;
                                    }
                                });
                            }
                        }
                    },
                    { name: ""ProcessDesc"", editable: true");
            WriteLiteral(@", width: ""300px"" },
                    { name: ""IsSegmentSpecific"", editable: true, width: ""70px"", align: 'center', edittype: ""checkbox"", formatter: 'checkbox', editoptions: { value: ""true:false"" } },
                    { name: ""SystemControl"", editable: true, width: ""70px"", align: 'center', edittype: ""checkbox"", formatter: 'checkbox', editoptions: { value: ""true:false"" } },
                    { name: ""ProcessControl"", editable: true, width: ""70px"", edittype: ""select"", formatter: 'select', editoptions: { value: ""A: All;S: Specific"" } },
                    { name: ""ActiveStatus"", editable: true, width: ""70px"", edittype: ""select"", formatter: 'select', editoptions: { value: ""true: Active;false: InActive"" } }
                ],
                rowNum: 10,
                loadonce: true,
                rowList: [10, 20, 50, 100],
                rownumWidth: 55,
                pager: ""#pgProcessRule"",
                viewrecords: true,
                gridview: true,
                rownumbers: ");
            WriteLiteral(@"true,
                height: 'auto',
                width: $(document).width() - 400,
                autowidth: true,
                loadonce: true,
                //caption: 'Process',
                onSelectRow: function (rowid) {
                    subRowId = rowid;

                    if (newrowid != undefined) {
                        $(""#gvProcessRule #"" + newrowid + "":first"").css({ background: '' });
                    }

                    //$(""#gvProcessRule #"" + rowid + "":first"").css({ background: '#F9D953 url(""images/ui-bg_flat_55_fbec88_40x100.png"") 50% 50% repeat-x', color: '#000' });
                    newrowid = rowid;
                },
                loadComplete: function (data) {
                    $(""#gvProcessRule .jqgrid-rownum:odd"").css({ 'background': ""#e4edf5"" });
                    $(""#gvProcessRule .jqgrow:odd"").css({ background: '#e4edf5' });
                    $(""#pgProcessRule .ui-pg-div:first"").css({ 'border-left': ""none"" });
                 ");
            WriteLiteral(@"   $(""#gvProcessRule .jqgrow"").hover(function () {
                        if (!$(this).hasClass('ui-state-highlight')) {
                            $(this).css({ 'background': ""rgb(139, 157, 239)"", color: 'white' })
                        }
                    }, function () {
                        if (!$(this).hasClass('ui-state-highlight')) {
                            $(this).css({ 'background': """", color: '' })
                        }

                    });
                    SetGridControlByAction(""gvProcessRule"");
                    $(""#gvProcessRule"").setGridParam({ datatype: 'json', page: 1 }).trigger('reloadGrid');
                    fnAddGridSerialNoHeading();
                },
                subGrid: true,
                subGridRowExpanded: function (subId, rowId) {
                    //setTimeout(function () { $(""#gview_gvProcessRule_3_t .jqgrid-rownum:odd"").css({ 'background': ""#e4edf5"" }); }, 200);
                    var selArray = new Array();
               ");
            WriteLiteral(@"     var subRowId;
                    function returnData() {

                        var proId = grid.getRowData(rowId).ProcessId;
                        for (var i = 0; i < data.length; i++) {
                            if (data[i].ProcessId == proId) {
                                selArray.push(data[i]);
                            }
                        }
                        return selArray;
                    }
                    var subData = {
                        page: 1,
                        rows: returnData(),
                        records: selArray.length,
                    };
                    var subGridTableId;
                    var subGridDivId;
                    var subGridWidth = grid.width() - 51;
                    subGridTableId = subId + ""_t"";
                    subGridIdGlobal = subGridTableId;
                    subGridDivId = subId + ""_d"";
                    $(""#"" + subId).html(""<table id='"" + subGridTableId + ""'></table><div id");
            WriteLiteral(@"='"" + subGridDivId + ""'></div>"");
                    $(""#"" + subGridTableId).jqGrid({

                        colNames: [""Process Id"", localization.RuleId, localization.RuleDescription, ""Notes"", localization.RuleStatus],
                        colModel: [
                            { name: ""ProcessId"", hidden: true },
                            {
                                name: ""RuleId"", hidden: false, editable: true, width: ""30px"", align: 'right', formatter: 'integer', editoptions: {
                                    dataInit: function (element) {
                                        $(element).keypress(function (e) {
                                            if (e.which != 8 && e.which != 0 && (e.which < 48 || e.which > 57)) {
                                                return false;
                                            }
                                        });
                                    }
                                }
                           ");
            WriteLiteral(@" },
                            { name: ""RuleDesc"", editable: true, width: ""250px"" },
                            { name: ""Notes"", editable: true, width: ""250px"" },
                            { name: ""ActiveStatus"", editable: true, width: ""60px"", edittype: ""select"", formatter: 'select', editoptions: { value: ""true: Active;false: InActive"" } }
                        ],
                        pager: ""#"" + subGridDivId,
                        rowNum: 20,
                        rowList: [20, 40],
                        viewrecords: true,
                        recordtext: ""Showing records {0} to {1} of {2}"",
                        gridview: true,
                        rownumbers: true,
                        datatype: 'local',
                        height: 'auto',
                        width: subGridWidth,
                        onSelectRow: function (rowids) {
                            subRowId = rowids;

                            if (newrowids != undefined) {
             ");
            WriteLiteral(@"                   $(""#"" + subGridTableId + "" #"" + newrowids).css({ background: '' });
                            }

                            $(""#"" + subGridTableId + "" #"" + rowids).css({ background: '#F9D953 url(""images/ui-bg_flat_55_fbec88_40x100.png"") 50% 50% repeat-x', color: '#000' });
                            newrowids = rowids;
                        },
                        loadComplete: function () {

                            setTimeout(function () {
                                $(""#jqgh_"" + subGridTableId + ""_RuleId"").css({ 'text-align': 'right' });
                                $(""#"" + subGridTableId + "" .jqgrid-rownum:odd"").css({ 'background': ""#e4edf5"" });
                                $(""#"" + subGridTableId + "" .jqgrow:odd"").css({ background: '#e4edf5' });
                                $(""#"" + subGridDivId + "" .ui-pg-div:first"").css({ 'border-left': ""none"" });
                                $(""#"" + subGridTableId + "" .jqgrow"").hover(function () {
            ");
            WriteLiteral(@"                        if (!$(this).hasClass('ui-state-highlight')) {
                                        $(this).css({ 'background': ""rgb(139, 157, 239)"", color: 'white' })
                                    }
                                }, function () {
                                    if (!$(this).hasClass('ui-state-highlight')) {
                                        $(this).css({ 'background': """", color: '' })
                                    }

                                })
                            }, 100);
                            fnAddGridSerialNoHeading();
                        },
                        // caption: 'Process Rule',
                    }).jqGrid('navGrid', '#' + subGridDivId, { del: false, search: false, addtext: 'Add', edittext: 'Edit', refresh: false },
                        {
                            editCaption: localization.EditProcessRule,
                            url: getBaseURL() + '/Rules/UpdateApplicationRule',
        ");
            WriteLiteral(@"                    closeAfterEdit: true,
                            reloadAfterSubmit: true,
                            beforeShowForm: function (formid) {
                                $(""#RuleId"").prop(""disabled"", true);
                                $(""#RuleDesc"").width(""300px"");
                                $(""#Notes"").width(""90%"");
                                $(""#editmodgvProcessRule_"" + rowId + ""_t"").css({
                                    'width': Math.round($(""#"" + subGridTableId).width() / 1.7) + ""px"",
                                    'height': 'auto'
                                });
                                $(""#FrmGrid_gvProcessRule_"" + rowId + ""_t"").css({
                                    'width': Math.round(grid.width() / 1.7) + ""px"",
                                    'height': 'auto'
                                });
                            },
                            beforeSubmit: function (postdata, formid) {

                          ");
            WriteLiteral(@"      postdata.ProcessId = grid.getRowData(rowId).ProcessId;
                                postdata.RuleId = $(""#"" + subGridTableId).getRowData(subRowId).RuleId;
                                console.log(postdata, grid.getRowData(rowId).ProcessId);
                                var message = fnValidateRule(postdata);
                                if (message != '') {
                                    return [false, message]
                                }
                                else {
                                    return [true, '']
                                }
                            },
                            afterSubmit: function (response, postdata) {
                                if (response.responseJSON.Status === true) {
                                    fnGridProcessRule();
                                    setTimeout(function () {
                                        $(""#gvProcessRule"").collapseSubGridRow(rowId);
                       ");
            WriteLiteral(@"                 $(""#gvProcessRule"").expandSubGridRow(rowId);
                                    }, 1000);
                                    return [true, '']
                                }
                                else {
                                    return [false, response.responseJSON.Message]
                                }
                            }
                        },
                        {
                            addCaption: localization.AddProcessRule,
                            url: getBaseURL() + '/Rules/InsertApplicationRule',
                            closeAfterAdd: true,
                            reloadAfterSubmit: true,
                            beforeShowForm: function (formid) {
                                console.log($(""#"" + subGridTableId).width());
                                $(""#RuleId"").prop(""disabled"", false);
                                $(""#RuleDesc"").width(""300px"");
                                $(""#Notes"").wi");
            WriteLiteral(@"dth(""90%"");
                                $(""#editmodgvProcessRule_"" + rowId + ""_t"").css({
                                    'width': Math.round($(""#"" + subGridTableId).width() / 1.7) + ""px"",
                                    'height': 'auto'
                                });
                                $(""#FrmGrid_gvProcessRule_"" + rowId + ""_t"").css({
                                    'width': Math.round(grid.width() / 1.7) + ""px"",
                                    'height': 'auto'
                                });
                            },
                            beforeSubmit: function (postdata, formid) {
                                postdata.ProcessId = grid.getRowData(rowId).ProcessId;
                                //console.log(postdata, grid.getRowData(rowId).ProcessId);
                                var message = fnValidateRule(postdata);
                                if (message != '') {
                                    return [false, message]
  ");
            WriteLiteral(@"                              }
                                else {
                                    return [true, '']
                                }
                            },
                            afterSubmit: function (response, postdata) {
                                if (response.responseJSON.Status === true) {
                                    fnGridProcessRule();
                                    setTimeout(function () {
                                        $(""#gvProcessRule"").collapseSubGridRow(rowId);
                                        $(""#gvProcessRule"").expandSubGridRow(rowId);
                                    }, 1000);

                                    return [true, '']
                                }
                                else {
                                    return [false, response.responseJSON.Message]
                                }
                            }
                        });
                    $(""#"" ");
            WriteLiteral(@"+ subGridTableId)[0].addJSONData(subData);
                    SetSubGridControlByAction(subGridTableId);
                }

            }).jqGrid('navGrid', ""#pgProcessRule"", { del: false, search: false, addtext: 'Add', edittext: 'Edit', refreshtext: 'Reload' },
                {
                    editCaption: localization.EditProcess,
                    url: getBaseURL() + '/Rules/UpdateProcessMaster',
                    closeAfterEdit: true,
                    reloadAfterSubmit: true,
                    beforeShowForm: function (formid) {
                        $(""#ProcessId"").prop(""disabled"", true);
                        $(""#ProcessDesc"").width(""300px"");
                        $(""#editmodgvProcessRule"").css({
                            'width': Math.round(grid.width() / 2) + ""px"",
                            'height': 'auto'
                        });
                        $(""#FrmGrid_gvProcessRule"").css({
                            'width': Math.round(grid.width() / 2) + ");
            WriteLiteral(@"""px"",
                            'height': 'auto'
                        });
                    },
                    beforeSubmit: function (postdata, formid) {

                        var message = fnValidateProcess(postdata);
                        if (message != '') {
                            return [false, message]
                        }
                        else {
                            $('#gvProcessRule').trigger('reloadGrid');
                            return [true, '']
                        }
                    },
                    afterSubmit: function (response, postdata) {
                        console.log(response.responseJSON);
                        if (response.responseJSON.Status === true) {
                            $('#gvProcessRule').trigger('reloadGrid');
                            return [true, ''];
                        }
                        else {
                            return [false, response.responseJSON.Message]
    ");
            WriteLiteral(@"                    }
                    }
                },
                {
                    addCaption: localization.AddProcess,
                    url: getBaseURL() + '/Rules/InsertProcessMaster',
                    closeAfterAdd: true,
                    reloadAfterSubmit: true,
                    beforeShowForm: function () {
                        $(""#ProcessId"").prop(""disabled"", false);
                        $(""#ProcessDesc"").width(""300px"");
                        $(""#editmodgvProcessRule"").css({
                            'width': Math.round(grid.width() / 2) + ""px"",
                            'height': 'auto'
                        });
                        $(""#FrmGrid_gvProcessRule"").css({
                            'width': Math.round(grid.width() / 2) + ""px"",
                            'height': 'auto'
                        });
                    },
                    beforeSubmit: function (postdata, formid) {
                        //console.log(po");
            WriteLiteral(@"stdata);
                        var message = fnValidateProcess(postdata);
                        if (message != '') {
                            return [false, message]
                        }
                        else {
                            return [true, '']
                        }
                    },
                    afterSubmit: function (response, postdata) {

                        if (response.responseJSON.Status === true) {
                            $('#gvProcessRule').trigger('reloadGrid');
                            return [true, ''];
                        }
                        else {
                            return [false, response.responseJSON.Message]
                        }
                    }
                });
        }

        function fnGridProcessRule() {
            $.ajax({
                url: getBaseURL() + ""/Rules/GetProcessRule"",
                type: 'post',
                datatype: 'json',
                async: f");
            WriteLiteral(@"alse,
                success: function (result) {
                    //console.log(result);
                    data = result;
                },
                error: function (error) { alert(error.status) }
            });
        }


        function fnValidateProcess(rowData) {
            var val = '';
            var dataArray = $(""#gvProcessRule"").getRowData();

            for (var i = 0; i < dataArray.length; i++) {
                if (dataArray[i].ProcessDesc === rowData.ProcessDesc && dataArray[i].ProcessId != rowData.ProcessId) {
                    val = 'Choose another process description';
                    break;
                }
            }
            if (IsStringNullorEmpty(rowData.ProcessId)) {
                val = ""Process ID cannot be empty"";
            }
            else if (IsStringNullorEmpty(rowData.ProcessDesc)) {
                val = ""Process Description cannot be empty"";
            }

            return val;
        }

        function fnV");
            WriteLiteral(@"alidateRule(rowData) {
            var val = '';

            var dataArray = $(""#"" + subGridIdGlobal).getRowData();

            for (var i = 0; i < dataArray.length; i++) {
                if (dataArray[i].RuleDesc === rowData.RuleDesc && dataArray[i].RuleId != rowData.RuleId) {
                    val = 'Choose another rule description';
                    break;
                }
            }
            if (IsStringNullorEmpty(rowData.RuleId)) {
                val = ""Rule ID cannot be empty"";
            }
            else if (IsStringNullorEmpty(rowData.RuleDesc)) {
                val = ""Rule Description cannot be empty"";
            }

            return val;
        }
    });

    function SetGridControlByAction(jqg) {
        $('#add_' + jqg).removeClass('ui-state-disabled');
        $('#edit_' + jqg).removeClass('ui-state-disabled');


        if (_userFormRole.IsInsert === false) {
            $('#add_' + jqg).addClass('ui-state-disabled');
        }
        if (_u");
            WriteLiteral(@"serFormRole.IsEdit === false) {
            $('#edit_' + jqg).addClass('ui-state-disabled');
        }


    }

    function SetSubGridControlByAction(jqg) {
        $('#add_' + jqg).removeClass('ui-state-disabled');
        $('#edit_' + jqg).removeClass('ui-state-disabled');

        if (_userFormRole.IsInsert === false) {
            $('#add_' + jqg).addClass('ui-state-disabled');
        }
        if (_userFormRole.IsEdit === false) {
            $('#edit_' + jqg).addClass('ui-state-disabled');
        }
    }
</script>







");
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
