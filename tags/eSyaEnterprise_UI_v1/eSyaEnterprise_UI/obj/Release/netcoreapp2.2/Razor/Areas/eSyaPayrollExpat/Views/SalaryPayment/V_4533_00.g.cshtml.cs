#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaPayrollExpat\Views\SalaryPayment\V_4533_00.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36acce5e40a2d0fe021cbed58e76cd919c376c3e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_eSyaPayrollExpat_Views_SalaryPayment_V_4533_00), @"mvc.1.0.view", @"/Areas/eSyaPayrollExpat/Views/SalaryPayment/V_4533_00.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/eSyaPayrollExpat/Views/SalaryPayment/V_4533_00.cshtml", typeof(AspNetCore.Areas_eSyaPayrollExpat_Views_SalaryPayment_V_4533_00))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36acce5e40a2d0fe021cbed58e76cd919c376c3e", @"/Areas/eSyaPayrollExpat/Views/SalaryPayment/V_4533_00.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Areas/eSyaPayrollExpat/Views/_ViewImports.cshtml")]
    public class Areas_eSyaPayrollExpat_Views_SalaryPayment_V_4533_00 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaPayrollExpat\Views\SalaryPayment\V_4533_00.cshtml"
  
    ViewData["Title"] = "V_4532_00";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(196, 124, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-lg-5 col-md-5 col-sm-12 form-group\">\r\n        <label>Business Key</label>\r\n        ");
            EndContext();
            BeginContext(321, 51, false);
#line 13 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaPayrollExpat\Views\SalaryPayment\V_4533_00.cshtml"
   Write(await Component.InvokeAsync("UserBusinessLocation"));

#line default
#line hidden
            EndContext();
            BeginContext(372, 997, true);
            WriteLiteral(@"
    </div>
</div>
<div class=""row"">
    <div class=""col-lg-2 col-md-2 col-sm-12 form-group"">
        <label>From Date</label>
        <input type=""text"" name=""name"" id=""dtFromDate"" value="""" class=""form-control datepicker"" />
    </div>
    <div class=""col-lg-2 col-md-2 col-sm-12 form-group"">
        <label>To Date</label>
        <input type=""text"" name=""name"" id=""dtToDate"" value="""" class=""form-control datepicker"" />
    </div>
    <div class=""col-lg-2 col-md-2 col-sm-6 form-group text-right"" style=""padding-top:10px"">
        <button class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent primary-button"" id=""btnPrint"" onclick=""fnViewSummaryReport()"">
            View Report
        </button>
    </div>
</div>

<div class=""row"" style=""display:none"">
    <div class=""col-lg-3 col-md-3 col-sm-6 form-group"">
        <label>Bank Name</label>
        <select class=""selectpicker"" id=""cboBanks"" onchange=""fnBank_onChange()""></select>
");
            EndContext();
            BeginContext(1641, 715, true);
            WriteLiteral(@"    </div>
    <div class=""col-lg-2 col-md-2 col-sm-6 form-group"">
        <label>Bank Currency</label>
        <select class=""selectpicker"" id=""cboBankCurrency""></select>
    </div>
    <div class=""col-lg-2 col-md-2 col-sm-12 form-group"">
        <label>Bank Date</label>
        <input type=""text"" name=""name"" id=""dtBankDate"" value="""" class=""form-control datepicker"" />
    </div>
    <div class=""col-lg-2 col-md-2 col-sm-6 form-group text-right"" style=""padding-top:10px"">
        <button class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent primary-button"" id=""btnPrint"" onclick=""fnViewReport()"">
            View Report
        </button>
    </div>
</div>

");
            EndContext();
            BeginContext(2555, 232, true);
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-lg-12 col-md-12 col-sm-12 col-xs-12\">\r\n        <div id=\"divPartialViewContainer\">\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    <table id=\'pgrid3\'></table>\r\n    <div id=\'ppager3\'></div>\r\n\r\n");
            EndContext();
            BeginContext(2825, 18903, true);
            WriteLiteral(@"</div>

<script>

    $(function () {
        // fnLoadSalaryGrid();
        fnBusinessLocation_onChange();
    })

    function fnBusinessLocation_onChange() {
        // fnRefreshGrid();
        var s = '<option selected>Select</option>';
        $.get(getBaseURL() + '/SalaryPayment/GetBankName', { businessKey: $('#cboBusinessLocation').val() },
            function (data) {
                for (var i = 0; i < data.length; i++) {
                    s += '<option value=' + data[i].BankCode + '>' +
                        data[i].BankName + '</option>';
                }
                $(""#cboBanks"").html(s);
                $(""#cboBanks"").selectpicker('refresh');
            });

    }

    function fnBank_onChange() {

        $.get(getBaseURL() + '/SalaryPayment/GetBankCurrency', { businessKey: $('#cboBusinessLocation').val(), bankCode: $('#cboBanks').val() },
            function (data) {
                var s = '<option>select</option>';
                for (var i = 0; i < ");
            WriteLiteral(@"data.length; i++) {
                    s += '<option value=' + data[i].CurrencyCode + '>' +
                        data[i].CurrencyCode + '</option>';
                }
                $(""#cboBankCurrency"").html(s);
                $(""#cboBankCurrency"").selectpicker('refresh');
            });
    }

    function fnRefreshGrid() {
        $(""#jqgSalary"").jqGrid(""setGridParam"", { datatype: ""json"" })
            .trigger(""reloadGrid"", [{ current: true }]);
    }


    function fnViewSummaryReport() {
        var URL = getReportBaseURL() + '/eSyaPayrollExpat/ReportViewer/BankAdviceSummary';

        $.ajax({
            url: URL,
            'async': true,
            data: { businessKey: $(""#cboBusinessLocation"").val(), fromDate: getDate($(""#dtFromDate"")), toDate: getDate($(""#dtToDate"")) },
            type: 'POST',
            success: function (content) {
                $('#divPartialViewContainer').html(content);
            },
            error: function (result) {
            ");
            WriteLiteral(@"    alert('Error, could not view!' + result);
            }
        });
        return true;
    }

    function fnViewReport() {
        var URL = getReportBaseURL() + '/eSyaPayrollExpat/ReportViewer/BankAdviceStatement';

        $.ajax({
            url: URL,
            'async': true,
            data: { businessKey: $(""#cboBusinessLocation"").val(), bankCode: $(""#cboBanks"").val(), bankCurrency: $(""#cboBankCurrency"").val(), bankDate: getDate($(""#dtBankDate"")) },
            type: 'POST',
            success: function (content) {
                $('#divPartialViewContainer').html(content);
            },
            error: function (result) {
                alert('Error, could not view!' + result);
            }
        });
        return true;
    }

    function fnLoadSalaryGrid() {
        $(""#jqgSalary"").jqGrid({
            url: getBaseURL() + '/SalaryPayment/GetBankStatement',
            datatype: ""json"",
            // contenttype: ""application/json; charset-utf-8"",
   ");
            WriteLiteral(@"         mtype: 'GET',
            postData: {
                businessKey: function () { return $(""#cboBusinessLocation"").val(); },
                orgBankCode: function () { return $(""#cboBanks"").val(); },
                bankDate: function () { return getDate($(""#dtBankDate"")); },
            },
            jsonReader: { repeatitems: false, root: ""rows"", page: ""page"", total: ""total"", records: ""records"" },
            colNames: ['EmployeeNumber', 'PayPeriod', 'SerialNumber', 'Employee Name', 'Account Holder Name', 'Beneficiary Address', 'Name of Bank', 'Branch Name', 'Branch Addresss', 'IFSC Code', 'Bank Account No', 'Amount In KSH '],
            colModel: [
                { name: ""EmployeeNumber"", width: '100', align: 'left', editable: false, hidden: true },
                { name: ""PayPeriod"", index: 'PayPeriod', width: '50', align: 'left', editable: false, sortable: true, },
                { name: ""SerialNumber"", index: 'SerialNumber', hidden: true },
                { name: ""EmployeeName""");
            WriteLiteral(@", index: 'EmployeeName', width: '200', align: 'left', editable: false, sortable: true, },
                { name: 'AccountHolderName', index: 'AccountHolderName', width: 120 },
                { name: 'BeneficiaryAddress', index: 'BeneficiaryAddress', width: 120 },
                { name: 'BankName', index: 'BankName', width: 120 },
                { name: 'BranchName', index: 'BranchName', width: 120 },
                { name: 'BankAddress', index: 'BankAddress', width: 120 },
                { name: 'IFSCCode', index: 'IFSCCode', width: 120 },
                { name: 'AccountNumber', index: 'AccountNumber', width: 120 },
                { name: 'LocalCurrencyAmount', index: 'LocalCurrencyAmount', width: 80, align: ""right"", sorttype: ""float"", formatter: ""number"" },
            ],
            rowNum: 100000,
            loadonce: true,
            height: 'auto',
            scroll: false,
            width: '150',
            autowidth: true,
            shrinkToFit: true,
            forceF");
            WriteLiteral(@"it: true,
            cellEdit: true,
            editurl: 'url',
            cellsubmit: 'clientArray',
            loadComplete: function () {

            },
        });
    }

    function fnExportToExcel() {
        JSONToCSVConvertor(JSON.stringify($('#jqgSalary').getGridParam('data')), 'RTGS - ' + $('#cboBanks option:selected').text(), true);
    }

    function JSONToCSVConvertor(JSONData, ReportTitle, ShowLabel) {

        //If JSONData is not an object then JSON.parse will parse the JSON string in an Object
        var arrData = typeof JSONData != 'object' ? JSON.parse(JSONData) : JSONData;

        var CSV = '';
        //Set Report title in first row or line

        CSV += ReportTitle + '\r\n\n';

        //This condition will generate the Label/Header
        if (ShowLabel) {
            var row = """";

            //This loop will extract the label from 1st index of on array
            for (var index in arrData[0]) {

                //Now convert each value to st");
            WriteLiteral(@"ring and comma-seprated
                if (index != ""EmployeeNumber"" && index != ""PayPeriod"" && index != ""SerialNumber"" && index != ""_id_"") {
                    if (index == ""EmployeeName"") {
                        index = ""Staff Name"";
                    }
                    if (index == ""AccountHolderName"") {
                        index = ""Account Holder"";
                    }
                    if (index == ""IFSCCode"") {
                        index = ""IFSC Code)"";
                    }
                    if (index == ""AccountNumber"") {
                        index = ""Bank Account No"";
                    }
                    if (index == ""LocalCurrencyAmount"") {
                        index = ""Amount In KSH "";
                    }
                    row += index + ',';
                }
            }

            row = row.slice(0, -1);

            //append Label row with line break
            CSV += row + '\r\n';
        }

        //1st loop is to extract eac");
            WriteLiteral(@"h row
        for (var i = 0; i < arrData.length; i++) {
            var row = """";

            //2nd loop will extract each column and convert it in string comma-seprated
            for (var index in arrData[i]) {
                if (index != ""EmployeeNumber"" && index != ""PayPeriod"" && index != ""SerialNumber"" && index != ""_id_"")
                    row += '""' + arrData[i][index] + '"",';
            }

            row.slice(0, row.length - 1);

            //add a line break after each row
            CSV += row + '\r\n';
        }

        if (CSV == '') {
            alert(""Invalid data"");
            return;
        }
        //Generate a file name
        var fileName = """";
        //this will remove the blank-spaces from the title and replace it with an underscore
        fileName += ReportTitle.replace(/ /g, ""_"");
        //Initialize file format you want csv or xls
        var uri = 'data:text/csv;charset=utf-8,' + escape(CSV);
        var link = document.createElement(""a"");");
            WriteLiteral(@"
        link.href = uri;
        link.style = ""visibility:hidden"";
        link.download = fileName + "".csv"";
        //this part will append the anchor tag and remove it after automatic click
        console.log(document.body);
        document.body.appendChild(link);
        link.click();
        document.body.removeChild(link);
    }


    //jQuery(document).ready(function () {

    //   var gData = {
    //        ""rows"": [
    //            {
    //                ""CategoryName"": ""Beverages"",
    //                ""ProductName"": ""Steeleye Stout"",
    //                ""Country"": ""UK"",
    //                ""Price"": ""1008.0000"",
    //                ""Quantity"": ""65""
    //            }, {
    //                ""CategoryName"": ""Beverages"",
    //                ""ProductName"": ""Laughing Lumberjack Lager"",
    //                ""Country"": ""USA"",
    //                ""Price"": ""140.0000"",
    //                ""Quantity"": ""10""
    //            },
    //        ]
    //    }

");
            WriteLiteral(@"    //    jQuery(""#pgrid3"").jqGrid('jqPivot',
    //        gData,
    //        // pivot options
    //        {
    //            xDimension: [
    //                {
    //                    dataName: 'CategoryName',
    //                    width: 90
    //                }, {
    //                    dataName: 'ProductName'
    //                }
    //            ],
    //            yDimension: [
    //                {
    //                    dataName: 'Country',
    //                    converter: function (value, xData, yData) {
    //                        return 'TotalCountry';
    //                    }
    //                }, {
    //                    dataName: 'Country'
    //                }
    //            ],
    //            aggregates: [
    //                {
    //                    member: 'Price',
    //                    aggregator: 'sum',
    //                    width: 50,
    //                    formatter: 'number',
    //          ");
            WriteLiteral(@"          align: 'right',
    //                    summaryType: 'sum'
    //                }
    //            ]
    //        },
    //        // grid options
    //        {
    //            width: 700,
    //            rowNum: 10,
    //            pager: ""#ppager3"",
    //            caption: ""Columns groups""
    //        });
    //});


    //var data = [{
    //    ""id"": 1,
    //    ""make"": ""toyota"",
    //    ""model"": ""corolla"",
    //    ""fuelusagecity"": ""17"",
    //    ""fuelusagehwy"": ""12"",
    //    ""fuelmeasure"": 'Litre',
    //    ""salesaboveavg"": false,
    //    ""totalnumberofsales"": 120000.0000,
    //    ""highsalestext"": null,
    //    ""salesdate"": ""2010-12-01"",
    //    ""groupheaderorder"": ""1"",
    //    ""childorder"": ""1""
    //}, {
    //    ""id"": 2,
    //    ""make"": ""toyota"",
    //    ""model"": ""corolla"",
    //    ""fuelusagecity"": ""10"",
    //    ""fuelusagehwy"": ""14"",
    //    ""salesaboveavg"": false,
    //    ""fuelmeasure"": 'Litre',
    //    ");
            WriteLiteral(@"""totalnumberofsales"": 100000.0000,
    //    ""highsalestext"": ""HIGH"",
    //    ""salesdate"": ""2010-12-15"",
    //    ""groupheaderorder"": ""1"",
    //    ""childorder"": ""1""
    //}, {
    //    ""id"": 3,
    //    ""make"": ""toyota"",
    //    ""model"": ""belta"",
    //    ""fuelusagecity"": ""15"",
    //    ""fuelusagehwy"": ""10"",
    //    ""salesaboveavg"": true,
    //    ""fuelmeasure"": 'Litre',
    //    ""totalnumberofsales"": 200000.0000,
    //    ""highsalestext"": null,
    //    ""salesdate"": ""2011-01-10"",
    //    ""groupheaderorder"": ""1"",
    //    ""childorder"": ""2""
    //}, {
    //    ""id"": 4,
    //    ""make"": ""toyota"",
    //    ""model"": ""camry"",
    //    ""fuelusagecity"": ""13"",
    //    ""fuelusagehwy"": ""10"",
    //    ""fuelmeasure"": 'Litre',
    //    ""salesaboveavg"": false,
    //    ""totalnumberofsales"": 300000.0000,
    //    ""highsalestext"": ""HIGH"",
    //    ""salesdate"": ""2011-04-23"",
    //    ""groupheaderorder"": ""1"",
    //    ""childorder"": ""3""
    //}, {
    //    ""id"": ");
            WriteLiteral(@"5,
    //    ""make"": ""nissan"",
    //    ""model"": ""skyline"",
    //    ""fuelusagecity"": ""14"",
    //    ""fuelusagehwy"": ""9"",
    //    ""fuelmeasure"": 'Litre',
    //    ""salesaboveavg"": true,
    //    ""totalnumberofsales"": 500000.0000,
    //    ""highsalestext"": ""HIGH"",
    //    ""salesdate"": ""2010-09-10"",
    //    ""groupheaderorder"": ""2"",
    //    ""childorder"": ""1""
    //}, {
    //    ""id"": 6,
    //    ""make"": ""nissan"",
    //    ""model"": ""zx300"",
    //    ""fuelusagecity"": ""10"",
    //    ""fuelusagehwy"": ""8"",
    //    ""fuelmeasure"": 'Litre',
    //    ""salesaboveavg"": false,
    //    ""totalnumberofsales"": 400000.0000,
    //    ""highsalestext"": null,
    //    ""salesdate"": ""2012-01-06"",
    //    ""groupheaderorder"": ""2"",
    //    ""childorder"": ""2""
    //}];

    ///* convert the salesdate in  */
    //var i, item, dateParts;
    //for (i = 0; i < data.length; i++) {
    //    item = data[i];
    //    if (typeof item.salesdate === ""string"") {
    //        dateParts =");
            WriteLiteral(@" item.salesdate.split(""-"");
    //        item.salesYear = dateParts[0];
    //        item.salesMonth = dateParts[1];
    //        item.salesDay = dateParts[2];
    //        item.salesDateFormatted = dateParts[0];
    //    }
    //}

    //var myIntTemplate = {
    //    formatter: ""currency"",
    //    align: ""right"", sorttype: ""number"",
    //    searchoptions: { sopt: [""eq"", ""ne"", ""lt"", ""le"", ""gt"", ""ge""] },
    //    formatoptions: { defaultValue: """" }
    //},
    //    $grid = $(""#list483"");

    //$grid.jqGrid(""jqPivot"", data, {
    //    frozenStaticCols: true,
    //    //skipSortByX: true,
    //    useColSpanStyle: true,
    //    //defaultFormatting: false,
    //    compareVectorsByX: function (x1, x2) {
    //        // x1 = [""toyota"", ""corolla"", ""Litre"", ""1"", ""1""],
    //        // x2 = [""toyota"", ""belta"", ""Litre"", ""1"", ""2""]
    //        var groupheaderorder1 = parseInt(x1[3], 10), childorder1 = parseInt(x1[4], 10),
    //            groupheaderorder2 = parseInt(x2[");
            WriteLiteral(@"3], 10), childorder2 = parseInt(x2[4], 10);
    //        if (groupheaderorder1 !== groupheaderorder2) {
    //            return { index: 0, result: groupheaderorder1 - groupheaderorder2 };
    //        }
    //        if (childorder1 !== childorder2) {
    //            return { index: 1, result: childorder1 - childorder2 };
    //        }
    //        return {
    //            index: -1,
    //            result: 0
    //        };
    //    },
    //    xDimension: [
    //        { /*x0*/ dataName: ""make"", width: 100, label: ""Make"",
    //            sorttype: function (cellValue, item) {
    //                return parseInt(item.x3, 10);
    //            }
    //        },
    //        { /*x1*/ dataName: ""model"", width: 100, label: ""Model"", align: ""center"", skipGrouping: true },
    //        { /*x2*/ dataName: ""fuelmeasure"", width: 103, label: ""Units"", skipGrouping: true },
    //        { /*x3*/ dataName: ""groupheaderorder"", additionalProperty: true },
    //        { /*x4*");
            WriteLiteral(@"/ dataName: ""childorder"", additionalProperty: true }
    //    ],
    //    yDimension: [
    //        { dataName: ""salesdate"", sortorder: ""desc"" }//,
    //        //{ dataName: ""salesYear"", sorttype: ""integer"" },
    //        //{ dataName: ""salesMonth"", sorttype: ""integer"" }
    //    ],
    //    aggregates: [{
    //        member: ""totalnumberofsales"",
    //        template: myIntTemplate,
    //        formatter: function (cellvalue, options, rowObject) {
    //            if (cellvalue === undefined) {
    //                return '';
    //            } else {
    //                var x = options.rowData.pivotInfos[options.colModel.name].rows[0].highsalestext;
    //                return x === ""HIGH"" ? x : cellvalue;
    //            }
    //        },
    //        cellattr: function (rowId, cellValue, rawObject, cm, rdata) {
    //            if (rawObject != null) {
    //                var items = rawObject.pivotInfos[cm.name];
    //                if (items != null &&");
            WriteLiteral(@" items.rows != null && items.rows.length > 0) {
    //                    var isHigh = true, i;
    //                    for (i = 0; i < items.rows.length; i++) {
    //                        if (items.rows[i].highsalestext !== ""HIGH"") {
    //                            isHigh = false;
    //                            break;
    //                        }
    //                    }
    //                    if (isHigh) {
    //                        return ""class='high-marker'"";
    //                    }
    //                }
    //            }
    //        },
    //        aggregator: ""max""
    //    }]
    //},
    //    // grid options
    //    {
    //        iconSet: ""fontAwesome"",
    //        cmTemplate: { autoResizable: true, width: 75 },
    //        shrinkToFit: true,
    //        useUnformattedDataForCellAttr: false,
    //        autoResizing: { compact: true },
    //        groupingView: {
    //            groupField: [""x0""],
    //            groupCol");
            WriteLiteral(@"umnShow: [false],
    //            groupText: [""<span class='group-text'>{0}</span>""]
    //        },
    //        width: 10000,
    //        toolbar: [true, ""top""],
    //        pager: true,
    //        rowNum: 20,
    //        sortname: ['x1'],
    //        caption: ""<b>Car sales statistics</b>"",
    //        rowList: [5, 10, 20, 100, ""10000:All""]
    //    });

    //$('<div className=""clsRangeDiv""><input type=""button"" id=""btnHide"" value=""Hide"" /><input type=""button"" id=""btnShow"" value=""Show"" /></div>').appendTo(""#t_list483"");

    //function getYColumnName(yValue) {
    //    var yIndex = $grid.jqGrid(""getGridParam"", ""pivotOptions"").yIndex,
    //        length = yIndex.getIndexLength(), i, item;
    //    for (i = 0; i < length; i++) {
    //        item = yIndex.getItem(i);
    //        // item is array with different y-values.
    //        // We use yDimension with one element ""salesdate"", thus every item is array
    //        // with one element item[0], which we can ");
            WriteLiteral(@"test to find ""salesdate""
    //        if (yValue === item[0]) {
    //            return ""y"" + i;
    //        }
    //    }
    //}
    //var columnsToHideOrShow = [getYColumnName('2011-04-23'), getYColumnName('2010-12-15')];

    //$('#btnHide').click(function () {
    //    $grid.jqGrid('hideCol', columnsToHideOrShow);
    //});

    //$('#btnShow').click(function () {
    //    $grid.jqGrid('showCol', columnsToHideOrShow);
    //});

</script>
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
