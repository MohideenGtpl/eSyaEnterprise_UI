#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\PatientManagement\Views\PaymentMode\Billing.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffaaaf3c1b95fe03f31c5a08a785ad27b62f94b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_PatientManagement_Views_PaymentMode_Billing), @"mvc.1.0.view", @"/Areas/PatientManagement/Views/PaymentMode/Billing.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/PatientManagement/Views/PaymentMode/Billing.cshtml", typeof(AspNetCore.Areas_PatientManagement_Views_PaymentMode_Billing))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffaaaf3c1b95fe03f31c5a08a785ad27b62f94b3", @"/Areas/PatientManagement/Views/PaymentMode/Billing.cshtml")]
    public class Areas_PatientManagement_Views_PaymentMode_Billing : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.repeater.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\PatientManagement\Views\PaymentMode\Billing.cshtml"
  
    ViewData["Title"] = "Billing";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(92, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(94, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffaaaf3c1b95fe03f31c5a08a785ad27b62f94b33738", async() => {
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
            BeginContext(141, 1810, true);
            WriteLiteral(@"
<style>
    .text-label {
        width: auto !important;
    }
</style>

<section class=""bg-white"">
    <div class=""row m-0 py-2"">
        <div class=""col-lg-3 col-md-4 col-sm-6"">
            <label>UHID</label>
            <input type=""text"" name=""name"" class=""form-control"" value="""" />
        </div>
        <div class=""col-lg-3 col-md-4 col-sm-6 d-flex align-items-end"">
            <button type=""button"" class=""btn btn-primary""> Search</button>
        </div>
    </div>
</section>
<section class="""">
    <div class=""row m-0"">
        <div class=""col-lg-3 col-md-6 col-sm-6 main-content-box d-flex align-items-center"">
            <span class=""box-icon""><i class=""fas fa-user-md fa-2x""></i></span>
            <p class=""m-0 pl-2 d-inline""><span class=""text-data"">FirstName LastName  </span></p>
        </div>
        <div class=""col-lg-3 col-md-6 col-sm-6 main-content-box"">
            <div class=""d-flex"">
                <span class=""box-icon""><i class=""fas fa-bed fa-2x""></i></span>
  ");
            WriteLiteral(@"              <div class=""pl-2 d-flex justify-content-around flex-column"">
                    <label class=""""><span class=""text-label"">Age:&nbsp;</span><span class=""text-data"">25</span></label>
                    <label class=""""><span class=""text-label"">Sex:&nbsp;</span><span class=""text-data"">Male</span></label>
                </div>
            </div>
        </div>
        <div class=""col-lg-3 col-md-6 col-sm-6 col-6 main-content-box"">
            <div class=""d-flex"">
                <span class=""box-icon""><i class=""far fa-building fa-2x""></i></span>
                <div class=""pl-2 d-flex justify-content-around flex-column"">
                    <label class=""""><span class=""text-label"">Visit Date:&nbsp;</span><span class=""text-data"">25/05/2022</span></label>
");
            EndContext();
            BeginContext(2090, 1877, true);
            WriteLiteral(@"                </div>
            </div>
        </div>


        <div class=""col-lg-3 col-md-6 col-sm-6 col-6 main-content-box"">
            <div class=""d-flex justify-content-evenly"">
                <span class=""box-icon""><i class=""far fa-calendar fa-2x""></i></span>
                <div class=""pl-2 d-flex justify-content-around flex-column"">
                    <label class=""""><span class=""text-label"">Doctor Name:&nbsp;</span><span class=""text-data"">Dr.Sachin</span></label>
                    <label class=""""><span class=""text-label"">Specialty:&nbsp;</span><span class=""text-data"">Cardiology</span></label>
                </div>
            </div>
        </div>
    </div>
</section>

<section class=""d-inline"">
    <div class=""row m-0"">
        <div class=""col-lg-9 col-md-8 col-sm-6 bg-white p-3"">
            <div class=""row pb-2"">
                <div class=""col-lg-12 col-md-12 col-sm-6"">
                    <p class=""subheading"">Service details</p>
                    <hr class=""le");
            WriteLiteral(@"ft"" />
                </div>
                <div class=""col-lg-3 col-md-4 col-sm-6 form-group"">
                    <label>Services</label>
                    <select class=""form-control"">
                        <option value=""value"">Choose</option>
                    </select>
                </div>

                <div class=""col-lg-12 col-md-12 col-sm-6"">
                    <table id=""jqgGuestServiceBilling""></table>
                    <div id=""jqpGuestServiceBilling""></div>
                </div>
            </div>
            <div class=""row pb-2"">
                <div class=""col-lg-12 col-md-12 col-sm-12"">
                    <p class=""subheading"">Payment details</p>
                    <hr class=""left"" />
                </div>
                <div class=""col-lg-12 col-md-12 col-sm-12"">
                    ");
            EndContext();
            BeginContext(3968, 81, false);
#line 89 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\PatientManagement\Views\PaymentMode\Billing.cshtml"
               Write(Html.Partial("~/Areas/PatientManagement/Views/PaymentMode/_PaymentDetail.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(4049, 7105, true);
            WriteLiteral(@"
                </div>
            </div>
            <div class=""row pb-2"">
                <div class=""col-lg-12 col-md-12 col-sm-12"">

                </div>
                </div>
            </div>
        <div class=""col-lg-3 col-md-4 col-sm-6 bg-white pb-2"">
            <div class=""total-box h-220 shadow-sm p-2"">
                 <h5 class=""total-cash-heading bg-light py-2""><i class=""fa fa-file-invoice""></i> Net Bill Amount</h5>
                <div class=""row m-0"">
                    <label class=""col-lg-6 pad-x-10 fontsize-12"">Total Bill Amount</label>
                    <div class=""col-lg-6 pad-x-10"">
                        <div class=""mdl-textfield mdl-js-textfield mdl-textfield--floating-label fullwidth"" style=""padding-top:0px !important; padding-bottom:10px !important"">
                            <input type=""text"" id=""txtTotalBillAmount"" class=""mdl-textfield__input   currencyFormat  text-right"" readonly style=""display:inline-block  "">
                        </div>
       ");
            WriteLiteral(@"             </div>
                </div>
                <div class=""row m-0"">
                    <label class=""col-lg-6 pad-x-10 fontsize-12"">Concession Amount</label>
                    <div class=""col-lg-6 pad-x-10"">
                        <div class=""mdl-textfield mdl-js-textfield mdl-textfield--floating-label fullwidth"" style=""padding-top:0px !important; padding-bottom:10px !important"">
                            <input type=""text"" id=""txtTotalConcessionAmount"" class=""mdl-textfield__input currencyFormat  text-right"" onkeypress=""return OnlyNumeric(event);"" onblur=""fnConcesssionAmount_onLeave()"">
                        </div>
                    </div>
                </div>
                <div class=""row m-0"">
                    <label class=""col-lg-6 pad-x-10 fontsize-12"">Net Bill Amount</label>
                    <div class=""col-lg-6 pad-x-10"">
                        <div class=""mdl-textfield mdl-js-textfield mdl-textfield--floating-label fullwidth"" style=""padding-top:0px !import");
            WriteLiteral(@"ant; padding-bottom:10px !important"">
                            <input type=""text"" id=""txtNetBillAmount"" class=""mdl-textfield__input currencyFormat  text-right"" readonly style=""display:inline-block  "">
                        </div>
                    </div>
                </div>
                <div class=""row m-0"">
                    <label class=""col-lg-6 pad-x-10 fontsize-12"">Collected Amount</label>
                    <div class=""col-lg-6 pad-x-10"">
                        <div class=""mdl-textfield mdl-js-textfield mdl-textfield--floating-label fullwidth"" style=""padding-top:0px !important; padding-bottom:10px !important"">
                            <input type=""text"" id=""txtTotalCollectedAmount"" class=""mdl-textfield__input currencyFormat  text-right"" readonly style=""display:inline-block  "">
                        </div>
                    </div>
                </div>
                <div class=""row m-0"">
                    <label class=""col-lg-6 pad-x-10 fontsize-12"">Narration</l");
            WriteLiteral(@"abel>
                    <div class=""col-lg-12 pad-x-10"">
                        <textarea rows=""1"" id=""txtNarration"" maxlength=""250"" class=""form-control""></textarea>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<section class=""d-inline"">
    <div class=""row m-0"">

    </div>
</section>
<script>
    $(function () {
        fnLoadGuestBillingServices();
    });
    function fnLoadGuestBillingServices() {
        $(""#jqgGuestServiceBilling"").jqGrid(""GridUnload"");
        $(""#jqgGuestServiceBilling"").jqGrid(
            {
                //url: getBaseURL() + '/CheckInGuest/GetGuestServiceBilling',
                datatype: ""json"",
                contenttype: ""application/json; charset-utf-8"",
                mtype: 'GET',
                postData: {
                    bookingKey: function () { return parseInt($('#hdBookingKey').val()) },
                },
                jsonReader: { repeatitems: false, root: ""rows"",");
            WriteLiteral(@" page: ""page"", total: ""total"", records: ""records"" },
                colNames: ['Service Code', 'Service Description', 'Service Provider', 'Quantity', 'Rate', 'Discount Amount'],
                colModel: [
                    { name: 'ServiceCode', index: 'ServiceCode', width: '100', hidden: true },
                    { name: 'ServiceName', index: 'ServiceName', width: '100' },
                    { name: 'ServiceProvider', index: 'ServiceProvider', width: '100' },
                    { name: 'Rate', index: 'rate', width: '100' },
                    { name: 'Quantity', index: 'Quantity', width: '80', align: ""right"", editable: false, formatter: 'integer', formatoptions: { decimalSeparator: ""."", decimalPlaces: 0, thousandsSeparator: ',' } },
                    { name: 'TotalAmount', index: 'TotalAmount', width: '150', align: ""right"", formatter: 'integer', formatoptions: { decimalSeparator: ""."", decimalPlaces: 2, thousandsSeparator: ',' } },
                ],
                rowNum: 10,
         ");
            WriteLiteral(@"       rownumWidth: 55,
                pager: ""#jqpGuestServiceBilling"",
                viewrecords: true,
                gridview: true,
                rownumbers: true,
                height: 'auto',
                width: 'auto',
                autowidth: true,
                shrinkToFit: true,
                forceFit: true,
                loadonce: true,
                //editurl: 'url',
                //cellsubmit: 'clientArray',
                //cellEdit: true,
                loadBeforeSend: function () {
                    $(""#jqgh_jqgGuestServiceBilling_Quantity,#jqgh_jqgGuestServiceBilling_Rate"").css('text-align', 'right');
                },
                loadComplete: function () {
                    fnAddGridSerialNoHeading();
                },
                gridComplete: function () {
                    CalculateTotalAmount();
                },
            }).jqGrid('navGrid', '#jqpGuestServiceBilling', {
                add: false, edit: false, search");
            WriteLiteral(@": false, del: false, refresh: false
            }).jqGrid('navButtonAdd', '#jqpGuestServiceBilling', {
                caption: '<span class=""fa fa-plus"" data-toggle=""modal"" data-whatever=""something"" style=""padding-right:5px;padding-top:2px;padding-right: 2px; vertical-align:text-top;margin-left:8px;""></span> Add', buttonicon: 'none', id: 'custAdd', position: 'first', onClickButton: fnAddService
            }).jqGrid('navButtonAdd', '#jqpGuestServiceBilling', {
                caption: '<span class=""fa fa-trash"" data-toggle=""modal""  data-whatever=""something"" style=""padding-right:5px;padding-top:2px;padding-right: 2px; vertical-align:text-top;margin-left:8px;""></span> Delete', buttonicon: 'none', id: 'custDelete', position: 'last', onClickButton: fnDeleteService
            });

        jQuery(""#jqgGuestServiceBilling"").trigger('reloadGrid');
    }
    function fnAddService() {

    }
    function fnDeleteService() {

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
