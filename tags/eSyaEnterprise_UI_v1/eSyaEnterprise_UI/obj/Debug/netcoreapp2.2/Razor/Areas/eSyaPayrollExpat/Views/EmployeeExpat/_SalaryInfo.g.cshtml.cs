#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaPayrollExpat\Views\EmployeeExpat\_SalaryInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd84ccd21f393db7bb101e7e95ce3e764bacccfd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_eSyaPayrollExpat_Views_EmployeeExpat__SalaryInfo), @"mvc.1.0.view", @"/Areas/eSyaPayrollExpat/Views/EmployeeExpat/_SalaryInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/eSyaPayrollExpat/Views/EmployeeExpat/_SalaryInfo.cshtml", typeof(AspNetCore.Areas_eSyaPayrollExpat_Views_EmployeeExpat__SalaryInfo))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd84ccd21f393db7bb101e7e95ce3e764bacccfd", @"/Areas/eSyaPayrollExpat/Views/EmployeeExpat/_SalaryInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Areas/eSyaPayrollExpat/Views/_ViewImports.cshtml")]
    public class Areas_eSyaPayrollExpat_Views_EmployeeExpat__SalaryInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("selectpicker"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-live-search", new global::Microsoft.AspNetCore.Html.HtmlString("false"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("cboSalaryCurrency"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Select"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-size", new global::Microsoft.AspNetCore.Html.HtmlString("8"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(120, 533, true);
            WriteLiteral(@"

<style>
    label input[type=""checkbox""] {
        vertical-align: text-top;
    }
</style>

<div class=""row"">
    <div class=""col-lg-12"">
        <p class=""subheading""> Salary Info</p>
        <hr class=""left"" />
    </div>
    <div class=""col-lg-2 col-md-2 col-sm-4 form-group"">
        <label>Salary Amount</label>
        <input type=""text"" id=""txtsalary"" name=""salary"" class=""form-control"" />
    </div>
    <div class=""col-lg-2 col-md-2 col-sm-4 form-group"">
        <label>Salary Currency</label>
        ");
            EndContext();
            BeginContext(653, 350, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd84ccd21f393db7bb101e7e95ce3e764bacccfd5932", async() => {
                BeginContext(793, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(807, 33, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd84ccd21f393db7bb101e7e95ce3e764bacccfd6328", async() => {
                    BeginContext(825, 6, true);
                    WriteLiteral("Select");
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
                BeginContext(840, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(986, 8, true);
                WriteLiteral("        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
#line 22 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaPayrollExpat\Views\EmployeeExpat\_SalaryInfo.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.CurrencyList;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1003, 4545, true);
            WriteLiteral(@"
    </div>

    <div class=""col-lg-12 col-md-12 col-sm-12"">
        <p class=""subheading"">Breakup by Currency To Pay</p>
        <hr class=""left"" />
    </div>
    <div class=""col-lg-12 col-md-12 col-sm-12 c_jqgSalaryInfo"">
        <table id=""jqgSalaryInfo""></table>
        <div id=""jqpSalaryInfo""></div>
    </div>
</div>

<div class=""row"">
    <div class=""col-lg-4 col-md-4 col-sm-12 col-xs-12"">
        <div class=""default-checkbox"">
            <label class=""mdl-checkbox mdl-js-checkbox mdl-js-ripple-effect"" for=""chkBankChargeApplicable"">
                <input type=""checkbox"" id=""chkBankChargeApplicable"" class=""mdl-checkbox__input"">
                <span class=""mdl-checkbox__label"">Is Bank Charge Applicable ?</span>
            </label>
        </div>
        <div class=""default-checkbox"">
            <label class=""mdl-checkbox mdl-js-checkbox mdl-js-ripple-effect"" for=""chkIncentiveApplicable"">
                <input type=""checkbox"" id=""chkIncentiveApplicable"" class=""mdl-checkbox__in");
            WriteLiteral(@"put"">
                <span class=""mdl-checkbox__label"">Is Incentive Applicable ?</span>
            </label>
        </div>
        <div class=""default-checkbox"">
            <label class=""mdl-checkbox mdl-js-checkbox mdl-js-ripple-effect"" for=""chkNHIF"">
                <input type=""checkbox"" id=""chkNHIF"" class=""mdl-checkbox__input"">
                <span class=""mdl-checkbox__label"">Is NHIF Applicable ?</span>
            </label>
        </div>
        <div class=""default-checkbox"">
            <label class=""mdl-checkbox mdl-js-checkbox mdl-js-ripple-effect"" for=""chkNSSF"">
                <input type=""checkbox"" id=""chkNSSF"" class=""mdl-checkbox__input"">
                <span class=""mdl-checkbox__label"">Is NSSF Applicable ?</span>
            </label>
        </div>
    </div>
</div>

<div class=""row"">
     <div class=""col-lg-3 col-md-3 col-sm-6 form-group"" id=""divNHIF"" style=""display:none"">
        <label> Amount</label>
        <input type=""text"" id=""txtNHIFPercentage"" name=""Incentive ");
            WriteLiteral(@"Percentage"" class=""form-control"" value="""" />
    </div>
</div>

<div class=""row"">
     
    <div class=""col-lg-3 col-md-3 col-sm-6 form-group"" id=""divNSSF"" style=""display:none"">
        <label> Amount</label>
        <input type=""text"" id=""txtNSSFPercentage"" name=""Incentive Percentage"" class=""form-control"" value="""" />
    </div>
</div>
<div class=""row"">
    <div class=""col-lg-12 col-md-12 col-sm-12 text-center"">
      
        <button type=""button"" class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent btn-back mr-10 c-white"" onclick=""fnCloseEmployeeDetails()""><i class=""fas fa-chevron-left""></i> Back</button>
        <button type=""button"" class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent primary-button mr-10"" id=""btnSaveEmployeeDetails"" onclick=""fnSaveSalaryInfo()"">
            <i class=""fa fa-save""></i>   Save
        </button>
        <button type=""button"" class=""mdl-button mdl-js-button mdl-button--raised mdl-js-");
            WriteLiteral(@"ripple-effect  cancel-button"" id=""btnCancel"" onclick=""fnCloseEmployeeDetails()""><i class=""fa fa-redo""></i> Cancel</button>
    </div>
</div>

<script>



    $(document).ready(function () {
        $('input[id^=""chkIncentive""]').click(function () {

            if ($(this).prop('checked')) {
                $(""#divIncentivePercentage"").css('display', 'block');
            }
            else {
                $(""#divIncentivePercentage"").css('display', 'none');
            }
        });

        $('input[id^=""chkNHIF""]').click(function () {
            $('#txtNHIFPercentage').val('0');
            if ($(this).prop('checked')) {

                $(""#divNHIF"").css('display', 'block')
            }
            else {
                $(""#divNHIF"").css('display', 'none')
            }
        });

        $('input[id^=""chkNSSF""]').click(function () {
            $('#txtNSSFPercentage').val('0');
            if ($(this).prop('checked')) {

                $(""#divNSSF"").css('display'");
            WriteLiteral(@", 'block')
            }
            else {
                $(""#divNSSF"").css('display', 'none')
            }
        });

        $('input[id^=""chkCashPayment""]').click(function () {

            if ($(this).prop('checked')) {

                $(""#divCashPayment"").css('display', 'block')
            }
            else {
                $(""#divCashPayment"").css('display', 'none')
            }
        });

    });
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
