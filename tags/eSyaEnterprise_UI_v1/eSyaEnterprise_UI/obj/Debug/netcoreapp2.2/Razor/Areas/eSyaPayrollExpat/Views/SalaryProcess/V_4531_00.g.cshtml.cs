#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaPayrollExpat\Views\SalaryProcess\V_4531_00.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db1d912954e1be2eb66b0eecc881c7219664e66c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_eSyaPayrollExpat_Views_SalaryProcess_V_4531_00), @"mvc.1.0.view", @"/Areas/eSyaPayrollExpat/Views/SalaryProcess/V_4531_00.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/eSyaPayrollExpat/Views/SalaryProcess/V_4531_00.cshtml", typeof(AspNetCore.Areas_eSyaPayrollExpat_Views_SalaryProcess_V_4531_00))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db1d912954e1be2eb66b0eecc881c7219664e66c", @"/Areas/eSyaPayrollExpat/Views/SalaryProcess/V_4531_00.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Areas/eSyaPayrollExpat/Views/_ViewImports.cshtml")]
    public class Areas_eSyaPayrollExpat_Views_SalaryProcess_V_4531_00 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaPayrollExpat\Views\SalaryProcess\V_4531_00.cshtml"
  
    ViewData["Title"] = "Salary Process";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(99, 3, true);
            WriteLiteral(" \r\n");
            EndContext();
            BeginContext(204, 220, true);
            WriteLiteral("<div class=\"row\" >\r\n    <div class=\"col-lg-6 col-md-6 col-sm-6\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-7 col-md-7 col-sm-12 form-group\">\r\n                <label>Business Key</label>\r\n                ");
            EndContext();
            BeginContext(425, 51, false);
#line 15 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaPayrollExpat\Views\SalaryProcess\V_4531_00.cshtml"
           Write(await Component.InvokeAsync("UserBusinessLocation"));

#line default
#line hidden
            EndContext();
            BeginContext(476, 131, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-lg-5 col-md-5 col-sm-12 form-group\">\r\n                <label>Pay Period</label>\r\n");
            EndContext();
            BeginContext(744, 24064, true);
            WriteLiteral(@"                <select class=""selectpicker"" id=""cboPayperiod"" data-size=""8"" onchange=""fnPayPeriod_onChange()""></select>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-sm-4 col-4 form-group"" style=""background: #fff; border:medium;border-color: #d5cbcb;border-style: solid;border-width: thin; vertical-align: middle !important; display: inline !important;  padding: 10px;margin-left: 15px;"">
                <div class=""radio"" style=""margin:0px;height:20px"">
                    <label style=""font-size:14px !important;color:#797172 !important""><input type=""radio"" name=""rdoStatus"" value=""A"" checked onchange=""fnRefreshGrid()"" /> All </label>
                </div>
            </div>
            <div class=""col-sm-4 col-4 form-group"" style=""background: #ffcccc; vertical-align: middle !important; display: inline !important;  padding: 10px;"">
                <div class=""radio"" style=""margin:0px;height:20px"">
                    <label style=""font-size:14px !important;c");
            WriteLiteral(@"olor:#797172 !important""><input type=""radio"" name=""rdoStatus"" value=""U"" checked onchange=""fnRefreshGrid()"" /> Un-Processed </label>
                </div>
            </div>
            <div class=""col-sm-4 col-4 form-group"" style=""background: #ccffd9; vertical-align: middle !important; display: inline !important;  padding: 10px;margin-left: -15px;"">
                <div class=""radio"" style=""margin:0px;""><label style=""font-size:14px !important;color:#797172 !important""><input type=""radio"" name=""rdoStatus"" value=""P"" onchange=""fnRefreshGrid()"" /> Processed </label></div>
            </div>
        </div>
    </div>
    <div class=""col-lg-3 col-md-3 col-sm-12 form-group text-center"">
        <table id=""jqgExchangeRate""></table>
        <div id=""jqpExchangeRate""></div>
    </div>
    <div class=""col-lg-3 col-md-3 col-sm-6 form-group text-right padtop20"">
        <button class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent primary-button"" id=""btnSavePayrollProcess");
            WriteLiteral(@""" onclick=""fnSavePayrollProcess()"">
            Salary Process
        </button>
    </div>
    <hr />
    <div class=""col-lg-12 col-md-12 col-sm-12"">
         <table id=""jqgSalaryProcess""></table>
        <div id=""jqpSalaryProcess""></div>
    </div>
</div>


<style>
    .ui-datepicker-calendar {
        display: none;
    }
</style>

<script type=""text/javascript"">

    var _payPeriod = null;

    $(function () {

        _payPeriod = null;

        //$('#dtPayPeriod').datepicker({
        //    changeMonth: true,
        //    changeYear: true,
        //    showButtonPanel: true,
        //    dateFormat: 'MM yy',
        //    onClose: function (dateText, inst) {
        //        var month = $(""#ui-datepicker-div .ui-datepicker-month :selected"").val();
        //        var year = $(""#ui-datepicker-div .ui-datepicker-year :selected"").val();
        //        $(this).val($.datepicker.formatDate('MM yy', new Date(year, month, 1)));
        //        _payPeriod = year + """"");
            WriteLiteral(@" + padDigits(parseInt(month) + 1, 2);
        //        $(""#jqgSalaryProcess"").jqGrid(""setGridParam"", { datatype: ""json"" })
        //            .trigger(""reloadGrid"", [{ current: true }]);
        //    },
        //});

        fnBusinessLocation_onChange();


        fnLoadExchangeRate();

       // fnLoadEmployeeForProcess();
    });

    function fnBusinessLocation_onChange() {

        fnBindPayPeriod();
        // fnLoadEmployeeForProcess();
        //$(""#jqgSalaryProcess"").jqGrid(""setGridParam"", { datatype: ""json"" })
        //    .trigger(""reloadGrid"", [{ current: true }]);
    }

    function fnBindPayPeriod() {
        $('#cboPayperiod').selectpicker('refresh');
        $.ajax({
            url: getBaseURL() + '/VariableEntry/GetPayPeriodbyBusinessKey?Businesskey=' + $(""#cboBusinessLocation"").val(),
            datatype: 'json',
            type: 'POST',
            async: false,
            contentType: 'application/json; charset=utf-8',
            success: function");
            WriteLiteral(@" (result) {
                $('#cboPayperiod').empty();
                //$(""#cboPayperiod"").append($(""<option value='0'>Select</option>""));
                if (result !== null) {
                    for (var i = 0; i < result.length; i++) {

                        $(""#cboPayperiod"").append($(""<option></option>"").val(result[i][""PayPeriod""]).html(result[i][""PayPeriod""]));
                    }
                }
                $('#cboPayperiod').val($(""#cboPayperiod option:first"").val());
                $('#cboPayperiod').selectpicker('refresh');
                fnPayPeriod_onChange();
            }
        });
    }

    function fnPayPeriod_onChange() {
        _payPeriod = $('#cboPayperiod').val();
        //$(""#jqgSalaryProcess"").jqGrid(""setGridParam"", { datatype: ""json"" })
        //   .trigger(""reloadGrid"", [{ current: true }]);
        fnLoadEmployeeForProcess();
    }

    function fnLoadExchangeRate() {

        $(""#jqgExchangeRate"").jqGrid({
            url: getBaseURL() +");
            WriteLiteral(@" '/SalaryProcess/GetCurrencyExchangeRate',
            datatype: ""json"",
            contenttype: ""application/json; charset-utf-8"",
            mtype: 'GET',
            postData: {
                businessKey: function () { return $(""#cboBusinessLocation"").val(); },
                payPeriod: function () { return _payPeriod; },
            },
            jsonReader: { repeatitems: false, root: ""rows"", page: ""page"", total: ""total"", records: ""records"" },
            colNames: [""Currency"", ""Ex. Rate"",""""],
            colModel: [
                { name: ""CurrencyCode"", width: '150', align: 'left', editable: false, },
                { name: ""ExchangeRate"", editable: true, width: '250', align: 'right', sortable: true, },
                { name: 'empty', index: 'empty', width: 15, search: false, }
            ],
            rowNum: 20,
            loadonce: false,
            height: 'auto',
            scroll: true,
            width: '150',
            autowidth: true,
            shrinkToF");
            WriteLiteral(@"it: true,
            forceFit: false,
            cellEdit: true,
            editurl: 'url',
            cellsubmit: 'clientArray',
            onSelectRow: function (id) {
                if (id) { $('#jqgExchangeRate').jqGrid('editRow', id, true); }
            },
            afterSaveCell: function (rowid, cellname, value, iRow, iCol) {
                fnCalculatePayrollProcess();
            }
        });
    }

    $(document).on('focusout', '[role=""gridcell""] *', function () {
        $(""#jqgExchangeRate"").jqGrid('editCell', 0, 0, false);
    });

    

    function fnRefreshGrid()
    {
        //if ($(""input[type='radio'][name='rdoStatus']:checked"").val() == ""U"")
        //    $(""#btnSavePayrollProcess"").show();
        //else
        //    $(""#btnSavePayrollProcess"").hide();

        //$(""#jqgSalaryProcess"").jqGrid(""setGridParam"", { datatype: ""json"" })
        //    .trigger(""reloadGrid"", [{ current: true }]);

        fnLoadEmployeeForProcess();
    }

    function");
            WriteLiteral(@" fnLoadEmployeeForProcess() {
        $(""#jqgSalaryProcess"").GridUnload();
        $(""#jqgSalaryProcess"").jqGrid({
            url: getBaseURL() + '/SalaryProcess/GetEmployeeForPayrollProcess',
            datatype: ""json"",
            contenttype: ""application/json; charset-utf-8"",
            mtype: 'POST',
            postData: {
                businessKey: function () { return $(""#cboBusinessLocation"").val(); },
                payPeriod: function () { return _payPeriod; },
                payrollProcessStatus: function () { return $(""input[type='radio'][name='rdoStatus']:checked"").val(); },
            },
            jsonReader: { repeatitems: false, root: ""rows"", page: ""page"", total: ""total"", records: ""records"" },
            colNames: [""EmployeeNumber"", ""Employee Name"", 'Salary Curr.', 'Salary Amount', 'Att. Factor', 'Vacation Pay','Processed Amount', 'Ex. Rate', 'Amount (Local Currency)', 'Add Incentive Amount', 'Less Advance Amount', 'Net Salary Amount', 'NHIF Amount', 'NSSF Amount','St");
            WriteLiteral(@"atus',''],
            colModel: [
                { name: ""EmployeeNumber"", width: '100', align: 'left', editable: false, hidden: true },
                { name: ""EmployeeName"", index: 'EmployeeName', width: '200', align: 'left', editable: false, sortable: true, },
                { name: ""SalaryCurrency"", index: 'SalaryCurrency', width: '50', search: false,  align: 'left', editable: false, sortable: true, },
                {
                    name: 'SalaryAmount', index: 'SalaryAmount', width: 80, search: false, align: ""right"", sorttype: ""float"",
                    formatter: ""number"", formatoptions: { decimalPlaces: 0 }
                },
                {
                    name: 'AttendanceFactor', index: 'AttendanceFactor', width: 80, search: false, align: ""right"", 
                },
                {
                    name: 'IsVacationPay', index: 'IsVacationPay', width: 60, search: false, align: 'center', edittype: ""checkbox"",
                    formatter: 'checkbox', editoption");
            WriteLiteral(@"s: { value: ""true:false"" }
                },
                {
                    name: 'ProcessedAmount', index: 'ProcessedAmount', width: 80, search: false, align: ""right"", sorttype: ""float"",
                    formatter: ""number"", formatoptions: { decimalPlaces: 0 }
                },
                { name: 'ExchangeRate', index: 'ExchangeRate', width: 50, search: false, align: ""right"", },
                {
                    name: 'AmountInLocalCurrency', index: 'AmountInLocalCurrency', width: 80, search: false, align: ""right"", sorttype: ""float"",
                    formatter: ""number"", formatoptions: { decimalPlaces: 0 }
                },
                {
                    name: 'VariableIncentiveAmount', index: 'VariableIncentiveAmount', width: 70, search: false, align: ""right"", sorttype: ""float"",
                    formatter: ""number"", formatoptions: { decimalPlaces: 0 }
                },
                {
                    name: 'AdvanceAmount', index: 'AdvanceAmount', wid");
            WriteLiteral(@"th: 70, search: false, align: ""right"", sorttype: ""float"",
                    formatter: ""number"", formatoptions: { decimalPlaces: 0 }
                },
                {
                    name: 'NetSalaryAmount', index: 'NetSalaryAmount', width: 80, search: false, align: ""right"", sorttype: ""float"",
                    formatter: ""number"", formatoptions: { decimalPlaces: 0 }
                },
                {
                    name: 'NHIFAmount', index: 'NHIFAmount', width: 80, search: false, align: ""right"", sorttype: ""float"",
                    formatter: ""number"", hidden: true
                },
                {
                    name: 'NSSFAmount', index: 'NSSFAmount', width: 80, search: false, align: ""right"", sorttype: ""float"",
                    formatter: ""number"", hidden: true
                },
                { name: 'PayrollStatus', index: 'PayrollStatus', width: 80, search: false, hidden:true },
                { name: 'empty', index: 'empty', width: 15, search: false,  ");
            WriteLiteral(@"},
            ],
            rowNum: 1000,
          //  rowList: [10, 20, 50, 100],
          //  rowNum: 10,
            loadonce: true,
            height: 'auto',
            scroll: true,
           // width: '150',
            autowidth: true,
            shrinkToFit: true,
            forceFit: true,
            cellEdit: true,
            editurl: 'url',
            cellsubmit: 'clientArray',
            ignoreCase: true,
            footerrow: true,
            multiselect: true,
            //onSelectRow: function (id) {
            //    if (id) { $('#jqgSalaryProcess').jqGrid('editRow', id, true); }
            //},

            loadComplete: function () {

                fnCalculatePayrollProcess();

                var grid = $(""#jqgSalaryProcess"");
                var rowIds = grid.jqGrid('getDataIDs');

                for (i = 0; i < rowIds.length; i++) {
                    var rowId = rowIds[i];
                    rowData = $('#jqgSalaryProcess').jqGrid('ge");
            WriteLiteral(@"tRowData', rowIds[i]);
                    
                    if (rowData['PayrollStatus'] == 'S') {
                        $(""#jqgSalaryProcess "" + ""#"" + rowIds[i]).find(""td"").css(""background-color"", ""#ffcccc"");
                    }
                    else if (rowData['PayrollStatus'] == 'P') {
                        $(""#jqgSalaryProcess "" + ""#"" + rowIds[i]).find(""td"").css(""background-color"", ""#ccffd9"");
                    }
                }

                fnSalaryGrid_FooterTotal();
            },
            onSelectAll: function (aRowids, status) {
                //var selectedRowsIds = $('#jqgSalaryProcess').jqGrid('getGridParam', 'selarrrow');
                //var totalEmployee = 0;
                //var AmountInLocalCurrency = 0, VariableIncentiveAmount = 0, AdvanceAmount = 0, NetSalaryAmountSum = 0;

                //$.each(selectedRowsIds, function (index, selectedRowId) {
                //    totalEmployee += 1;
                //    AmountInLocalCurrency += parseInt");
            WriteLiteral(@"($('#jqgSalaryProcess').jqGrid('getCell', selectedRowId, 'AmountInLocalCurrency'));
                //    VariableIncentiveAmount += parseInt($('#jqgSalaryProcess').jqGrid('getCell', selectedRowId, 'VariableIncentiveAmount'));
                //    AdvanceAmount += parseInt($('#jqgSalaryProcess').jqGrid('getCell', selectedRowId, 'AdvanceAmount'));
                //    NetSalaryAmountSum += parseInt($('#jqgSalaryProcess').jqGrid('getCell', selectedRowId, 'NetSalaryAmount'));
                //});

                //$('#jqgSalaryProcess').jqGrid('footerData', 'set', { 'EmployeeName': 'Total No. of Emp. : ' + totalEmployee });

                //$('#jqgSalaryProcess').jqGrid('footerData', 'set', { 'AmountInLocalCurrency': AmountInLocalCurrency });
                //$('#jqgSalaryProcess').jqGrid('footerData', 'set', { 'VariableIncentiveAmount': VariableIncentiveAmount });
                //$('#jqgSalaryProcess').jqGrid('footerData', 'set', { 'AdvanceAmount': AdvanceAmount });
                //$('#jqg");
            WriteLiteral(@"SalaryProcess').jqGrid('footerData', 'set', { 'NetSalaryAmount': NetSalaryAmountSum });

                fnSalaryGrid_FooterTotal();

            },
            onSelectRow: function (rowId) {
                //var selectedRowsIds = $('#jqgSalaryProcess').jqGrid('getGridParam', 'selarrrow');
                //var totalEmployee = 0;
                //var AmountInLocalCurrency = 0, VariableIncentiveAmount = 0, AdvanceAmount = 0, NetSalaryAmountSum = 0;

                //$.each(selectedRowsIds, function (index, selectedRowId) {
                //    totalEmployee += 1;
                //    AmountInLocalCurrency += parseInt($('#jqgSalaryProcess').jqGrid('getCell', selectedRowId, 'AmountInLocalCurrency'));
                //    VariableIncentiveAmount += parseInt($('#jqgSalaryProcess').jqGrid('getCell', selectedRowId, 'VariableIncentiveAmount'));
                //    AdvanceAmount += parseInt($('#jqgSalaryProcess').jqGrid('getCell', selectedRowId, 'AdvanceAmount'));
                //    NetSalar");
            WriteLiteral(@"yAmountSum += parseInt($('#jqgSalaryProcess').jqGrid('getCell', selectedRowId, 'NetSalaryAmount'));
                //});

                //$('#jqgSalaryProcess').jqGrid('footerData', 'set', { 'EmployeeName': 'Total No. of Emp. : ' + totalEmployee });

                //$('#jqgSalaryProcess').jqGrid('footerData', 'set', { 'AmountInLocalCurrency': AmountInLocalCurrency });
                //$('#jqgSalaryProcess').jqGrid('footerData', 'set', { 'VariableIncentiveAmount': VariableIncentiveAmount });
                //$('#jqgSalaryProcess').jqGrid('footerData', 'set', { 'AdvanceAmount': AdvanceAmount });
                //$('#jqgSalaryProcess').jqGrid('footerData', 'set', { 'NetSalaryAmount': NetSalaryAmountSum });

                fnSalaryGrid_FooterTotal();

            }
        });

        jQuery(""#jqgSalaryProcess"").jqGrid('filterToolbar', { stringResult: true, searchOnEnter: false, defaultSearch: ""cn"" });
    }

    function fnSalaryGrid_FooterTotal() {
        var selectedRowsIds = $('#");
            WriteLiteral(@"jqgSalaryProcess').jqGrid('getGridParam', 'selarrrow');
        var totalEmployee = 0;
        var AmountInLocalCurrency = 0, VariableIncentiveAmount = 0, AdvanceAmount = 0, NetSalaryAmountSum = 0;

        $.each(selectedRowsIds, function (index, selectedRowId) {
            totalEmployee += 1;
            AmountInLocalCurrency += parseInt($('#jqgSalaryProcess').jqGrid('getCell', selectedRowId, 'AmountInLocalCurrency'));
            VariableIncentiveAmount += parseInt($('#jqgSalaryProcess').jqGrid('getCell', selectedRowId, 'VariableIncentiveAmount'));
            AdvanceAmount += parseInt($('#jqgSalaryProcess').jqGrid('getCell', selectedRowId, 'AdvanceAmount'));
            NetSalaryAmountSum += parseInt($('#jqgSalaryProcess').jqGrid('getCell', selectedRowId, 'NetSalaryAmount'));
        });

        $('#jqgSalaryProcess').jqGrid('footerData', 'set', { 'EmployeeName': 'Total No. of Emp. : ' + totalEmployee });

        $('#jqgSalaryProcess').jqGrid('footerData', 'set', { 'AmountInLocalCurrency'");
            WriteLiteral(@": AmountInLocalCurrency });
        $('#jqgSalaryProcess').jqGrid('footerData', 'set', { 'VariableIncentiveAmount': VariableIncentiveAmount });
        $('#jqgSalaryProcess').jqGrid('footerData', 'set', { 'AdvanceAmount': AdvanceAmount });
        $('#jqgSalaryProcess').jqGrid('footerData', 'set', { 'NetSalaryAmount': NetSalaryAmountSum });
    }

    function fnCalculatePayrollProcess() {
        var rowIds = $(""#jqgSalaryProcess"").getDataIDs();
        for (var i = 0; i < rowIds.length; i++) {

          //  if ($(""#jqgSalaryProcess"").jqGrid('getCell', rowIds[i], 'PayrollStatus') != ""P"") {
                var currency = $(""#jqgSalaryProcess"").jqGrid('getCell', rowIds[i], 'SalaryCurrency');
                var exchangeRate = getCurrencyExchangeRate(currency);
                var salaryAmount = parseFloat($(""#jqgSalaryProcess"").jqGrid('getCell', rowIds[i], 'SalaryAmount'));
                var attendanceFactor = parseFloat($(""#jqgSalaryProcess"").jqGrid('getCell', rowIds[i], 'AttendanceFactor'));");
            WriteLiteral(@"
                var processedAmount = salaryAmount * attendanceFactor;
                //if ($(""#jqgSalaryProcess"").jqGrid('getCell', rowIds[i], 'IsVacationPay') === ""true"")
                //    processedAmount = salaryAmount / 2;
                var amountInLocalCurrency = Math.round(processedAmount * exchangeRate);
                var variableIncentiveAmount = parseFloat($(""#jqgSalaryProcess"").jqGrid('getCell', rowIds[i], 'VariableIncentiveAmount'));
                var advanceAmount = parseFloat($(""#jqgSalaryProcess"").jqGrid('getCell', rowIds[i], 'AdvanceAmount'));
                var netSalaryAmount = amountInLocalCurrency + variableIncentiveAmount - advanceAmount;

                $(""#jqgSalaryProcess"").jqGrid('setCell', rowIds[i], 'ProcessedAmount', processedAmount);
                $(""#jqgSalaryProcess"").jqGrid('setCell', rowIds[i], 'ExchangeRate', exchangeRate);
                $(""#jqgSalaryProcess"").jqGrid('setCell', rowIds[i], 'AmountInLocalCurrency', amountInLocalCurrency);
          ");
            WriteLiteral(@"      $(""#jqgSalaryProcess"").jqGrid('setCell', rowIds[i], 'NetSalaryAmount', netSalaryAmount);
          //  }
        }
    }

    function getCurrencyExchangeRate(currency) {
        var rowIds = $(""#jqgExchangeRate"").getDataIDs();
        for (var i = 0; i < rowIds.length; i++) {
            if ($(""#jqgExchangeRate"").jqGrid('getCell', rowIds[i], 'CurrencyCode') === currency)
                return $(""#jqgExchangeRate"").jqGrid('getCell', rowIds[i], 'ExchangeRate');
        }
        return 1;
    }

    function fnSavePayrollProcess() {

        if (!IsValid())
            return;

        try {
            $(""#btnSavePayrollProcess"").attr('disabled', true);

            var l_cur = [];
            var cur_rowIds = $(""#jqgExchangeRate"").getDataIDs();
            for (var i = 0; i < cur_rowIds.length; i++) {
                l_cur.push({
                    CurrencyCode: $(""#jqgExchangeRate"").jqGrid('getCell', cur_rowIds[i], 'CurrencyCode'),
                    ExchangeRate: $(""#jqg");
            WriteLiteral(@"ExchangeRate"").jqGrid('getCell', cur_rowIds[i], 'ExchangeRate')
                });
            }

            var l_pr = [];
           // var ids = jQuery(""#jqgSalaryProcess"").jqGrid('getDataIDs');
            var ids = jQuery(""#jqgSalaryProcess"").jqGrid('getGridParam', 'selarrrow');
            for (var i = 0; i < ids.length; i++) {
              
                var rowId = ids[i];
                var rowData = jQuery('#jqgSalaryProcess').jqGrid('getRowData', rowId);
              
                l_pr.push({
                    BusinessKey: $(""#cboBusinessLocation"").val(),
                    PayPeriod: _payPeriod,
                    EmployeeNumber: rowData.EmployeeNumber,
                    EmployeeName: rowData.EmployeeName,
                    SalaryCurrency: rowData.SalaryCurrency,
                    SalaryAmount: rowData.SalaryAmount,
                    AttendanceFactor: rowData.AttendanceFactor,
                    ProcessedAmount: rowData.ProcessedAmount,
                 ");
            WriteLiteral(@"   IsVacationPay: rowData.IsVacationPay,
                    ExchangeRate: rowData.ExchangeRate,
                    AmountInLocalCurrency: rowData.AmountInLocalCurrency,
                    VariableIncentiveAmount: rowData.VariableIncentiveAmount,
                    AdvanceAmount: rowData.AdvanceAmount,
                    NetSalaryAmount: rowData.NetSalaryAmount,
                    NHIFAmount: rowData.NHIFAmount,
                    NSSFAmount: rowData.NSSFAmount,
                    l_Currency: l_cur,
                });
            }

            var URL = getBaseURL() + '/SalaryProcess/InsertIntoPayrollProcess';

            $.ajax({
                url: URL,
                type: 'POST',
                datatype: 'json',
                data: { obj: l_pr },
                async: false,
                success: function (response) {
                    if (response.Status) {
                        $(""#btnSavePayrollProcess"").attr('disabled', false);
                        toas");
            WriteLiteral(@"tr.success(""Payroll Processed Successfully"");

                        //$(""#jqgSalaryProcess"").jqGrid(""setGridParam"", { datatype: ""json"" })
                        //    .trigger(""reloadGrid"");

                        fnLoadEmployeeForProcess();

                       // $(""#jqgSalaryProcess"").jqGrid('resetSelection');

                        //$('#cb_jqgSalaryProcess')
                        //    .attr('checked', 'checked')
                        //    .trigger('click')
                            //.attr('checked', 'checked');
                    }
                    else {
                        toastr.error(response.Message);
                    }

                    $(""#btnSavePayrollProcess"").attr('disabled', false);
                },
                error: function (error) {
                    toastr.error(error.statusText);
                    $(""#btnSavePayrollProcess"").attr('disabled', false);
                }
            });
        }
        catch
        {");
            WriteLiteral(@"
            toastr.error(""error"");
            $(""#btnSavePayrollProcess"").attr('disabled', false);
        }
    }

    function IsValid() {
        if (IsStringNullorEmpty($(""#cboBusinessLocation"").val())) {
            toastr.warning(""Please select the Business location"");
            return false;
        }
        if (IsStringNullorEmpty(_payPeriod)) {
            toastr.warning(""Please select the Payperiod"");
            return false;
        }

        return true;
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
