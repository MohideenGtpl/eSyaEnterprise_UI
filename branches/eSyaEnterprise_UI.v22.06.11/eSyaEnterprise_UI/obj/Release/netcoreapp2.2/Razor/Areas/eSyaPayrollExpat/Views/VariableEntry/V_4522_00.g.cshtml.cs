#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaPayrollExpat\Views\VariableEntry\V_4522_00.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10e04679e33c2aa13c690217a0ec7475ece39554"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_eSyaPayrollExpat_Views_VariableEntry_V_4522_00), @"mvc.1.0.view", @"/Areas/eSyaPayrollExpat/Views/VariableEntry/V_4522_00.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/eSyaPayrollExpat/Views/VariableEntry/V_4522_00.cshtml", typeof(AspNetCore.Areas_eSyaPayrollExpat_Views_VariableEntry_V_4522_00))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10e04679e33c2aa13c690217a0ec7475ece39554", @"/Areas/eSyaPayrollExpat/Views/VariableEntry/V_4522_00.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Areas/eSyaPayrollExpat/Views/_ViewImports.cshtml")]
    public class Areas_eSyaPayrollExpat_Views_VariableEntry_V_4522_00 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/eSyaPayrollExpat/AdvanceSalary.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaPayrollExpat\Views\VariableEntry\V_4522_00.cshtml"
  
    ViewData["Title"] = "V_4522_00";
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
                BeginContext(119, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10e04679e33c2aa13c690217a0ec7475ece395544105", async() => {
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
                BeginContext(181, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(186, 125, true);
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-lg-4 col-md-4 col-sm-6 form-group\">\r\n        <label>Business Key</label>\r\n        ");
            EndContext();
            BeginContext(312, 51, false);
#line 15 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaPayrollExpat\Views\VariableEntry\V_4522_00.cshtml"
   Write(await Component.InvokeAsync("UserBusinessLocation"));

#line default
#line hidden
            EndContext();
            BeginContext(363, 3043, true);
            WriteLiteral(@"
    </div>

    <div class=""col-lg-3 col-md-3 col-sm-6 form-group"">
        <label>Pay Period</label>
        <select class=""selectpicker"" id=""cboPayperiod"" data-size=""8"" onchange="" fnGridLoadAdvanceSalary()"">

        </select>

    </div>

    <div class=""col-lg-12 col-md-12 col-sm-12 c_jqgAdvanceSalary"">
        <table id=""jqgAdvanceSalary""></table>
        <div id=""jqpAdvanceSalary""></div>
    </div>

</div>

<div class=""modal fade in"" id=""PopupAdvanceSalary"" data-keyboard=""false"" data-backdrop=""static"">
<div class=""modal-dialog modal-lg"" role=""document"" style=""box-shadow:none;"">
        <div class=""modal-content"">
            <div class=""modal-header popupHeader"">
                <button type=""button"" class=""close ml-auto"" data-dismiss=""modal""> <i class=""fa fa-times""></i></button>
                <h4 class=""modal-title"">Add Salary Advance Recovery</h4>
            </div>
            <div class=""modal-body"">

                <div class=""row"">
                    <div class=""co");
            WriteLiteral(@"l-lg-6 col-md-6 col-sm-9 form-group"">
                        <label class=""lable-color"">Employee  </label>
                        <select class=""selectpicker""  data-live-search=""true"" id=""cboEmployeenumber"" data-size=""8""></select>
                    </div>
                </div>

                <div class=""row"">

                    <div class=""col-lg-6 col-md-6 col-sm-9 form-group lbl-right"">
                        <label>Salary Advance Recovery (local currency)</label>
                        <input type=""text"" value="""" id=""txtAdvancesalary"" class=""form-control integerFormat"" maxlength=""20"" />
                    </div>

                    <div class=""col-lg-3 col-md-3 col-sm-6 form-group"">
                        <div class=""default-checkbox"">
                            <label class=""mdl-checkbox mdl-js-checkbox mdl-js-ripple-effect"" for=""chkActiveStatus"">
                                <input type=""checkbox"" id=""chkActiveStatus"" class=""mdl-checkbox__input"">
                       ");
            WriteLiteral(@"         <span class=""mdl-checkbox__label"">Active </span>
                            </label>
                        </div>
                    </div>

                </div>
               

                <div class=""modal-footer"">
                    <div class=""row"">
                        <div class=""col-lg-12"">
                            <button class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent primary-button"" id=""btnSaveAdvanceSalary"" onclick=""fnSaveAdvanceSalary()"">
                                Save
                            </button>
                            <button class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect  cancel-button cancel-button"" data-dismiss=""modal"" id=""btnCancelAdvanceSalary"" onclick=""fnClearAdvanceSalaryFields()""> Cancel </button>
                        </div>
                    </div>
                </div>
            </div>
    </div>
</div>

</div>

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
