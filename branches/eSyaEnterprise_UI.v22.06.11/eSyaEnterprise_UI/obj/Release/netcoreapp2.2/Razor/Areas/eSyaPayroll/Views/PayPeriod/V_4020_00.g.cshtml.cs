#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaPayroll\Views\PayPeriod\V_4020_00.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c49a9fd60d9a0729a09ac6f5cf6508272a4783f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_eSyaPayroll_Views_PayPeriod_V_4020_00), @"mvc.1.0.view", @"/Areas/eSyaPayroll/Views/PayPeriod/V_4020_00.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/eSyaPayroll/Views/PayPeriod/V_4020_00.cshtml", typeof(AspNetCore.Areas_eSyaPayroll_Views_PayPeriod_V_4020_00))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c49a9fd60d9a0729a09ac6f5cf6508272a4783f", @"/Areas/eSyaPayroll/Views/PayPeriod/V_4020_00.cshtml")]
    public class Areas_eSyaPayroll_Views_PayPeriod_V_4020_00 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/eSyaPayroll/PayPeriod.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaPayroll\Views\PayPeriod\V_4020_00.cshtml"
  
    ViewData["Title"] = "V_4020_00";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(94, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(113, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(119, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c49a9fd60d9a0729a09ac6f5cf6508272a4783f3837", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(172, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(177, 4684, true);
            WriteLiteral(@"
<style>
    .ui-datepicker-calendar {
        display: none;
    }
</style>
<div class=""row"">
    <div class=""col-lg-12 col-md-12 col-sm-12"">
        <table id=""jqgPayPeriod""></table>
        <div id=""jqpPayPeriod""></div>
    </div>
</div>

<div class=""modal fade in"" id=""PopupPayPeriod"" data-keyboard=""false"" data-backdrop=""static"">
    <div class=""modal-dialog modal-lg"" role=""document"" style=""box-shadow:none;"">
        <div class=""modal-content"">
            <div class=""modal-header popupHeader"">
                <button type=""button"" class=""close ml-auto"" data-dismiss=""modal""> <i class=""fa fa-times""></i></button>
                <h4 class=""modal-title"">Add Pay Period</h4>
            </div>
            <div class=""modal-body"">
                <div class=""row"">
                    <div class=""col-lg-3 col-md-6 col-sm-6 form-group"">
                        <label>Pay Period</label>
                        <input type=""text"" name=""name"" value="""" id=""txtPayPeriod"" class=""form-control"" />");
            WriteLiteral(@"
                    </div>

                    <div class=""col-lg-3 col-md-6 col-sm-6 form-group lbl-right"">
                        <label>Working days</label>
                        <input type=""text"" value="""" id=""txtWorkingdays"" class=""form-control integerFormat"" />
                    </div>
                    <div class=""col-lg-3 col-md-6 col-sm-6 form-group"">
                        <label>Holidays</label>
                        <input type=""text"" name=""name"" value="""" id=""txtHolidays"" class=""form-control integerFormat"" />
                    </div>

                    <div class=""col-lg-3 col-md-6 col-sm-6 form-group lbl-right"">
                        <label>Weekly Offs</label>
                        <input type=""text"" value="""" id=""txtWeeklyoffs"" class=""form-control integerFormat"" />
                    </div>
                    <div class=""col-lg-3 col-md-4 col-sm-6 form-group"">
                        <div class=""default-checkbox"">
                            <label class=""md");
            WriteLiteral(@"l-checkbox mdl-js-checkbox mdl-js-ripple-effect"" for=""chkIsPayRollFreezed"">
                                <input type=""checkbox"" id=""chkIsPayRollFreezed"" class=""mdl-checkbox__input"">
                                <span class=""mdl-checkbox__label"">Is Payroll Freezed?</span>
                            </label>
                        </div>
                    </div>
                    <div class=""col-lg-3 col-md-4 col-sm-6 form-group"">
                        <div class=""default-checkbox"">
                            <label class=""mdl-checkbox mdl-js-checkbox mdl-js-ripple-effect"" for=""chkIsFinancePosted"">
                                <input type=""checkbox"" id=""chkIsFinancePosted"" class=""mdl-checkbox__input"">
                                <span class=""mdl-checkbox__label"">Is Finance Posted?</span>
                            </label>
                        </div>
                    </div>
                    <div class=""col-lg-3 col-md-4 col-sm-6 form-group"">
                       ");
            WriteLiteral(@" <div class=""default-checkbox"">
                            <label class=""mdl-checkbox mdl-js-checkbox mdl-js-ripple-effect"" for=""chkActiveStatus"">
                                <input type=""checkbox"" id=""chkActiveStatus"" class=""mdl-checkbox__input"">
                                <span class=""mdl-checkbox__label"">Active </span>
                            </label>
                        </div>
                    </div>


                </div>

            </div>
            <div class=""modal-footer"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <button class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent primary-button"" id=""btnSavePayPeriod"" onclick=""fnSavePayPeriod()"">
                            Save
                        </button>
                        <button class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect  cancel-button cancel-button"" data-dismiss=""modal"" id=");
            WriteLiteral(@"""btnCancelPayPeriod"" onclick=""fnClearPayPeriodFields()""> Cancel </button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<script>
    $(function () {
        $('#txtPayPeriod').datepicker({
            changeMonth: true,
            changeYear: true,
            showButtonPanel: true,
            dateFormat: 'MM yy',
            onClose: function (dateText, inst) {
                $(this).datepicker('setDate', new Date(inst.selectedYear, inst.selectedMonth, 1));
            }
        });
    });

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
