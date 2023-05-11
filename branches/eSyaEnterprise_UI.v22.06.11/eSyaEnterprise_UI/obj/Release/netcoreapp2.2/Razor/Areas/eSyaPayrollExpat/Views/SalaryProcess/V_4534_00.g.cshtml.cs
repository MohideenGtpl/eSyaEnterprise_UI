#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaPayrollExpat\Views\SalaryProcess\V_4534_00.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "603010195c12f5a3a6888e06c4e578329c292c90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_eSyaPayrollExpat_Views_SalaryProcess_V_4534_00), @"mvc.1.0.view", @"/Areas/eSyaPayrollExpat/Views/SalaryProcess/V_4534_00.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/eSyaPayrollExpat/Views/SalaryProcess/V_4534_00.cshtml", typeof(AspNetCore.Areas_eSyaPayrollExpat_Views_SalaryProcess_V_4534_00))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"603010195c12f5a3a6888e06c4e578329c292c90", @"/Areas/eSyaPayrollExpat/Views/SalaryProcess/V_4534_00.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Areas/eSyaPayrollExpat/Views/_ViewImports.cshtml")]
    public class Areas_eSyaPayrollExpat_Views_SalaryProcess_V_4534_00 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaPayrollExpat\Views\SalaryProcess\V_4534_00.cshtml"
  
    ViewData["Title"] = "Salary Register";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(100, 222, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-lg-6 col-md-6 col-sm-12\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-7 col-md-7 col-sm-12 form-group\">\r\n                <label>Business Key</label>\r\n                ");
            EndContext();
            BeginContext(323, 51, false);
#line 12 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaPayrollExpat\Views\SalaryProcess\V_4534_00.cshtml"
           Write(await Component.InvokeAsync("UserBusinessLocation"));

#line default
#line hidden
            EndContext();
            BeginContext(374, 131, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-lg-5 col-md-5 col-sm-12 form-group\">\r\n                <label>Pay Period</label>\r\n");
            EndContext();
            BeginContext(641, 805, true);
            WriteLiteral(@"                <select class=""selectpicker"" id=""cboPayperiod"" data-size=""8""></select>
            </div>
        </div>
    </div>
    <div class=""col-lg-2 col-md-2 col-sm-6 form-group text-center"" style=""padding-top:10px"">
        <button class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent primary-button"" id=""btnPrint"" onclick=""fnViewReport()"">
            View Report
        </button>
    </div>
    <div class=""col-lg-3 col-md-3 col-sm-6 form-group text-center"" style=""padding-top:10px"">
        <button class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent primary-button"" id=""btnPrint"" onclick=""fnViewReportWithBankDetails()"">
            View Report with Bank Details
        </button>
    </div>
</div>
");
            EndContext();
            BeginContext(1669, 9556, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
        <div id=""divPartialViewContainer"">
        </div>
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
        //        _payPeriod = year + """" + padDigits(parseInt(month) + 1, 2);
        //        $(""#jqgSalaryProcess"").jqGrid(""setGridParam"", { dat");
            WriteLiteral(@"atype: ""json"" })
        //            .trigger(""reloadGrid"", [{ current: true }]);
        //    },
        //});

        fnBusinessLocation_onChange();

    });

  

    function fnBusinessLocation_onChange() {
        fnBindPayPeriod();
    }

    function fnBindPayPeriod() {
        $('#cboPayperiod').selectpicker('refresh');
        $.ajax({
            url: getBaseURL() + '/VariableEntry/GetPayPeriodbyBusinessKey?Businesskey=' + $(""#cboBusinessLocation"").val(),
            datatype: 'json',
            type: 'POST',
            async: false,
            contentType: 'application/json; charset=utf-8',
            success: function (result) {
                $('#cboPayperiod').empty();
                //$(""#cboPayperiod"").append($(""<option value='0'>Select</option>""));
                if (result !== null) {
                    for (var i = 0; i < result.length; i++) {

                        $(""#cboPayperiod"").append($(""<option></option>"").val(result[i][""PayPeriod""]).html(re");
            WriteLiteral(@"sult[i][""PayPeriod""]));
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
        //    .trigger(""reloadGrid"", [{ current: true }]);
    }


    function fnViewReport() {
        var URL = getReportBaseURL() + '/eSyaPayrollExpat/ReportViewer/SalaryRegister';

        $.ajax({
            url: URL,
            'async': true,
            data: { businessKey: $(""#cboBusinessLocation"").val(), payPeriod: $('#cboPayperiod').val() },
            type: 'POST',
            success: function (content) {
                $('#divPartialViewContainer').html(content);
            },
            error: function (result) {
                ");
            WriteLiteral(@"alert('Error, could not view!' + result);
            }
        });
        return true;
    }

    function fnViewReportWithBankDetails() {
        var URL = getReportBaseURL() + '/eSyaPayrollExpat/ReportViewer/SalaryRegisterWithBankDetails';

        $.ajax({
            url: URL,
            'async': true,
            data: { businessKey: $(""#cboBusinessLocation"").val(), payPeriod: $('#cboPayperiod').val() },
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

    //$(function () {

    //    $(""#jqgSalaryProcess"").jqGrid({
    //        url: getBaseURL() + '/SalaryProcess/GetSalaryRegister',
    //        datatype: ""json"",
    //        contenttype: ""application/json; charset-utf-8"",
    //        mtype: 'GET',
    //        postData: {");
            WriteLiteral(@"
    //            businessKey: function () { return $(""#cboBusinessLocation"").val(); },
    //            payPeriod: function () { return _payPeriod; }
    //        },
    //        jsonReader: { repeatitems: false, root: ""rows"", page: ""page"", total: ""total"", records: ""records"" },
    //        colNames: [""EmployeeNumber"", ""Employee Name"", 'Salary Curr.', 'Salary Amount', 'Att. Factor', 'Vacation Pay', 'Processed Amount', 'Ex. Rate', 'Amount (Local Currency)', 'Add Incentive Amount', 'Less Advance Amount', 'Net Salary Amount', 'Cash Amount', 'Bank Amount',''],
    //        colModel: [
    //            { name: ""EmployeeNumber"", width: '100', align: 'left', editable: false, hidden: true },
    //            { name: ""EmployeeName"", index: 'EmployeeName', width: '200', align: 'left', editable: false, sortable: true, },
    //            { name: ""SalaryCurrency"", index: 'SalaryCurrency', width: '50', align: 'left', editable: false, sortable: true, },
    //            { name: 'SalaryAmount', index: '");
            WriteLiteral(@"SalaryAmount', width: 80, align: ""right"", sorttype: ""float"", formatter: ""number"", formatoptions: { decimalPlaces: 0 } },
    //            { name: 'AttendanceFactor', index: 'AttendanceFactor', width: 40, align: ""right"", sorttype: ""float"", formatter: ""number"", formatoptions: { decimalPlaces: 0 } },
    //            { name: 'IsVacationPay', index: 'IsVacationPay', width: 50, align: 'center', edittype: ""checkbox"", formatter: 'checkbox', editoptions: { value: ""true:false"" } },
    //            { name: 'ProcessedAmount', index: 'ProcessedAmount', width: 80, align: ""right"", sorttype: ""float"", formatter: ""number"", formatoptions: { decimalPlaces: 0 } },
    //            { name: 'ExchangeRate', index: 'ExchangeRate', width: 50, align: ""right"", },
    //            { name: 'AmountInLocalCurrency', index: 'AmountInLocalCurrency', width: 80, align: ""right"", sorttype: ""float"", formatter: ""number"", formatoptions: { decimalPlaces: 0 } },
    //            { name: 'VariableIncentiveAmount', index: 'VariableIncentiv");
            WriteLiteral(@"eAmount', width: 70, align: ""right"", sorttype: ""float"", formatter: ""number"", formatoptions: { decimalPlaces: 0 } },
    //            { name: 'AdvanceAmount', index: 'AdvanceAmount', width: 70, align: ""right"", sorttype: ""float"", formatter: ""number"", formatoptions: { decimalPlaces: 0 } },
    //            { name: 'NetSalaryAmount', index: 'NetSalaryAmount', width: 80, align: ""right"", sorttype: ""float"", formatter: ""number"", formatoptions: { decimalPlaces: 0 } },
    //            { name: 'CashAmount', index: 'CashAmount', width: 80, align: ""right"", sorttype: ""float"", formatter: ""number"", formatoptions: { decimalPlaces: 0 } },
    //            { name: 'BankAmount', index: 'BankAmount', width: 80, align: ""right"", sorttype: ""float"", formatter: ""number"", formatoptions: { decimalPlaces: 0 } },
    //            { name: 'Empty', width: 20 },
    //        ],
    //        rowNum: 100000,
    //        rowList: [10, 20, 50, 100],
    //        loadonce: true,
    //        viewrecords: true,
    //       ");
            WriteLiteral(@" gridview: true,
    //        rownumbers: true,
    //        height: 'auto',
    //        scroll: true,
    //        width: 'auto',
    //        autowidth: true,
    //        shrinkToFit: true,
    //        forceFit: true,
    //        footerrow: true,
    //        loadComplete: function () {
    //            var selectedRowsIds = $('#jqgSalaryProcess').jqGrid('getDataIDs');
    //            var totalEmployee = 0;
    //            var AmountInLocalCurrency = 0, VariableIncentiveAmount = 0, AdvanceAmount = 0, NetSalaryAmountSum = 0, CashAmount = 0, BankAmount = 0;

    //            $.each(selectedRowsIds, function (index, selectedRowId) {
    //                totalEmployee += 1;
    //                AmountInLocalCurrency += parseInt($('#jqgSalaryProcess').jqGrid('getCell', selectedRowId, 'AmountInLocalCurrency'));
    //                VariableIncentiveAmount += parseInt($('#jqgSalaryProcess').jqGrid('getCell', selectedRowId, 'VariableIncentiveAmount'));
    //                A");
            WriteLiteral(@"dvanceAmount += parseInt($('#jqgSalaryProcess').jqGrid('getCell', selectedRowId, 'AdvanceAmount'));
    //                NetSalaryAmountSum += parseInt($('#jqgSalaryProcess').jqGrid('getCell', selectedRowId, 'NetSalaryAmount'));
    //                CashAmount += parseInt($('#jqgSalaryProcess').jqGrid('getCell', selectedRowId, 'CashAmount'));
    //                BankAmount += parseInt($('#jqgSalaryProcess').jqGrid('getCell', selectedRowId, 'BankAmount'));
    //            });

    //            $('#jqgSalaryProcess').jqGrid('footerData', 'set', { 'EmployeeName': 'Total No. of Emp. : ' + totalEmployee });

    //            $('#jqgSalaryProcess').jqGrid('footerData', 'set', { 'AmountInLocalCurrency': AmountInLocalCurrency });
    //            $('#jqgSalaryProcess').jqGrid('footerData', 'set', { 'VariableIncentiveAmount': VariableIncentiveAmount });
    //            $('#jqgSalaryProcess').jqGrid('footerData', 'set', { 'AdvanceAmount': AdvanceAmount });
    //            $('#jqgSalaryProcess').");
            WriteLiteral(@"jqGrid('footerData', 'set', { 'NetSalaryAmount': NetSalaryAmountSum });
    //            $('#jqgSalaryProcess').jqGrid('footerData', 'set', { 'CashAmount': CashAmount });
    //            $('#jqgSalaryProcess').jqGrid('footerData', 'set', { 'BankAmount': BankAmount });
    //        },

    //    });

    //});




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
