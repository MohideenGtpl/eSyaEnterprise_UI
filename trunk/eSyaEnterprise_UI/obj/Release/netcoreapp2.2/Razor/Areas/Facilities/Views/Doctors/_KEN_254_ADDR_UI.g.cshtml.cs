#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Facilities\Views\Doctors\_KEN_254_ADDR_UI.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29012ac1b9269e2d17526f284e15053669bd9418"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Facilities_Views_Doctors__KEN_254_ADDR_UI), @"mvc.1.0.view", @"/Areas/Facilities/Views/Doctors/_KEN_254_ADDR_UI.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Facilities/Views/Doctors/_KEN_254_ADDR_UI.cshtml", typeof(AspNetCore.Areas_Facilities_Views_Doctors__KEN_254_ADDR_UI))]
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
#line 2 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Facilities\Views\Doctors\_KEN_254_ADDR_UI.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29012ac1b9269e2d17526f284e15053669bd9418", @"/Areas/Facilities/Views/Doctors/_KEN_254_ADDR_UI.cshtml")]
    public class Areas_Facilities_Views_Doctors__KEN_254_ADDR_UI : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(136, 1030, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-6 col-md-6 col-sm-12"">
        <div class=""form-group"">
            <label>Address 1</label>
            <textarea id=""txtAddress1"" rows=""1"" class=""form-control""></textarea>
        </div>
    </div>
    <div class=""col-lg-6 col-md-6 col-sm-12"">
        <div class=""form-group"">
            <label>Address 2</label>
            <textarea id=""txtAddress2"" rows=""1"" class=""form-control""></textarea>
        </div>
    </div>
</div>

<div class=""row"">
    <div class=""col-lg-3 col-md-6 col-sm-6 form-group d-flex justify-content-end flex-column"">
        <label for=""txtPostalCode"">Postal Code</label>
        <input type=""text"" name=""postalcode"" value="""" id=""txtPostalCode"" class=""form-control"" />
    </div>
    <div class=""col-lg-3 col-md-6 col-sm-6 form-group d-flex justify-content-end flex-column"">
        <label for=""cboTownCity"">Town/City</label>
        <select class=""w-100 selectpicker"" id=""cboTownCity"" data-size=""8"" data-live-search=""true"">
      ");
            WriteLiteral("      ");
            EndContext();
            BeginContext(1166, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29012ac1b9269e2d17526f284e15053669bd94184659", async() => {
                BeginContext(1184, 6, true);
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
            BeginContext(1199, 286, true);
            WriteLiteral(@"
        </select>
    </div>
    <div class=""col-lg-3 col-md-6 col-sm-6 form-group d-flex justify-content-end flex-column"">
        <label for=""cboCounty"">County</label>
        <select class=""w-100 selectpicker"" id=""cboCounty"" data-size=""8"" data-live-search=""true"">
            ");
            EndContext();
            BeginContext(1485, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29012ac1b9269e2d17526f284e15053669bd94186332", async() => {
                BeginContext(1503, 6, true);
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
            BeginContext(1518, 362, true);
            WriteLiteral(@"
        </select>
    </div>
</div>
<div class=""row form-group"">
    <div class=""col-lg-12 col-md-12 col-sm-12 text-center"">
        <hr />
        <button type=""button"" class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent btn-back mr-10 c-white"" onclick=""fnCloseDoctorProfile()""><i class=""fas fa-chevron-left""></i> ");
            EndContext();
            BeginContext(1881, 17, false);
#line 42 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Facilities\Views\Doctors\_KEN_254_ADDR_UI.cshtml"
                                                                                                                                                                                                                 Write(Localizer["Back"]);

#line default
#line hidden
            EndContext();
            BeginContext(1898, 191, true);
            WriteLiteral("</button>\r\n        <button class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent primary-button mr-10\" id=\"btnSaveKENAddress\"><i class=\"far fa-save\"></i> ");
            EndContext();
            BeginContext(2090, 17, false);
#line 43 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Facilities\Views\Doctors\_KEN_254_ADDR_UI.cshtml"
                                                                                                                                                                               Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(2107, 191, true);
            WriteLiteral("</button>\r\n        <button class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect  cancel-button cancel-button\" id=\"btnClearKENAddress\" onclick=\"\"><i class=\"fa fa-redo\"></i> ");
            EndContext();
            BeginContext(2299, 18, false);
#line 44 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Facilities\Views\Doctors\_KEN_254_ADDR_UI.cshtml"
                                                                                                                                                                               Write(Localizer["Clear"]);

#line default
#line hidden
            EndContext();
            BeginContext(2317, 29, true);
            WriteLiteral("</button>\r\n    </div>\r\n</div>");
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
