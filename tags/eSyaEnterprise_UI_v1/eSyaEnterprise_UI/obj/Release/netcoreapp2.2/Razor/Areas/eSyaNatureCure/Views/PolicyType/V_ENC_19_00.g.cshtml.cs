#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\PolicyType\V_ENC_19_00.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6b6785aa1c99a84c39eb6516e4639bc3474522f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_eSyaNatureCure_Views_PolicyType_V_ENC_19_00), @"mvc.1.0.view", @"/Areas/eSyaNatureCure/Views/PolicyType/V_ENC_19_00.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/eSyaNatureCure/Views/PolicyType/V_ENC_19_00.cshtml", typeof(AspNetCore.Areas_eSyaNatureCure_Views_PolicyType_V_ENC_19_00))]
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
#line 1 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\PolicyType\V_ENC_19_00.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6b6785aa1c99a84c39eb6516e4639bc3474522f", @"/Areas/eSyaNatureCure/Views/PolicyType/V_ENC_19_00.cshtml")]
    public class Areas_eSyaNatureCure_Views_PolicyType_V_ENC_19_00 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/eSyaNatureCure/PolicyType.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(82, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\PolicyType\V_ENC_19_00.cshtml"
  
    ViewData["Title"] = "V_ENC_19_00";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(178, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6b6785aa1c99a84c39eb6516e4639bc3474522f3926", async() => {
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
            BeginContext(235, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 10 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\PolicyType\V_ENC_19_00.cshtml"
  
    var userFormRole = (eSyaEnterprise_UI.Models.DO_UserFormRole)ViewBag.UserFormRole;

#line default
#line hidden
            BeginContext(332, 46, true);
            WriteLiteral("<script>\r\n    var _userFormRole = JSON.parse(\'");
            EndContext();
            BeginContext(379, 38, false);
#line 14 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\PolicyType\V_ENC_19_00.cshtml"
                               Write(Html.Raw(Json.Serialize(userFormRole)));

#line default
#line hidden
            EndContext();
            BeginContext(417, 61, true);
            WriteLiteral("\');\r\n\r\n     var localization = {\r\n         PolicyStatement: \'");
            EndContext();
            BeginContext(479, 28, false);
#line 17 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\PolicyType\V_ENC_19_00.cshtml"
                      Write(Localizer["PolicyStatement"]);

#line default
#line hidden
            EndContext();
            BeginContext(507, 26, true);
            WriteLiteral("\',\r\n         PolicyType: \'");
            EndContext();
            BeginContext(534, 23, false);
#line 18 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\PolicyType\V_ENC_19_00.cshtml"
                 Write(Localizer["PolicyType"]);

#line default
#line hidden
            EndContext();
            BeginContext(557, 29, true);
            WriteLiteral("\',\r\n         AddPolicyType: \'");
            EndContext();
            BeginContext(587, 26, false);
#line 19 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\PolicyType\V_ENC_19_00.cshtml"
                    Write(Localizer["AddPolicyType"]);

#line default
#line hidden
            EndContext();
            BeginContext(613, 32, true);
            WriteLiteral("\',\r\n         UpdatePolicyType: \'");
            EndContext();
            BeginContext(646, 29, false);
#line 20 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\PolicyType\V_ENC_19_00.cshtml"
                       Write(Localizer["UpdatePolicyType"]);

#line default
#line hidden
            EndContext();
            BeginContext(675, 30, true);
            WriteLiteral("\',\r\n         ViewPolicyType: \'");
            EndContext();
            BeginContext(706, 27, false);
#line 21 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\PolicyType\V_ENC_19_00.cshtml"
                     Write(Localizer["ViewPolicyType"]);

#line default
#line hidden
            EndContext();
            BeginContext(733, 28, true);
            WriteLiteral("\',\r\n         SerialNumber: \'");
            EndContext();
            BeginContext(762, 25, false);
#line 22 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\PolicyType\V_ENC_19_00.cshtml"
                   Write(Localizer["SerialNumber"]);

#line default
#line hidden
            EndContext();
            BeginContext(787, 23, true);
            WriteLiteral("\',\r\n         Actions: \'");
            EndContext();
            BeginContext(811, 20, false);
#line 23 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\PolicyType\V_ENC_19_00.cshtml"
              Write(Localizer["Actions"]);

#line default
#line hidden
            EndContext();
            BeginContext(831, 22, true);
            WriteLiteral("\',\r\n         Active: \'");
            EndContext();
            BeginContext(854, 19, false);
#line 24 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\PolicyType\V_ENC_19_00.cshtml"
             Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(873, 20, true);
            WriteLiteral("\',\r\n         Edit: \'");
            EndContext();
            BeginContext(894, 17, false);
#line 25 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\PolicyType\V_ENC_19_00.cshtml"
           Write(Localizer["Edit"]);

#line default
#line hidden
            EndContext();
            BeginContext(911, 20, true);
            WriteLiteral("\',\r\n         View: \'");
            EndContext();
            BeginContext(932, 17, false);
#line 26 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\PolicyType\V_ENC_19_00.cshtml"
           Write(Localizer["View"]);

#line default
#line hidden
            EndContext();
            BeginContext(949, 20, true);
            WriteLiteral("\',\r\n         Save: \'");
            EndContext();
            BeginContext(970, 17, false);
#line 27 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\PolicyType\V_ENC_19_00.cshtml"
           Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(987, 22, true);
            WriteLiteral("\',\r\n         Update: \'");
            EndContext();
            BeginContext(1010, 19, false);
#line 28 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\PolicyType\V_ENC_19_00.cshtml"
             Write(Localizer["Update"]);

#line default
#line hidden
            EndContext();
            BeginContext(1029, 22, true);
            WriteLiteral("\',\r\n         Delete: \'");
            EndContext();
            BeginContext(1052, 19, false);
#line 29 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\PolicyType\V_ENC_19_00.cshtml"
             Write(Localizer["Delete"]);

#line default
#line hidden
            EndContext();
            BeginContext(1071, 24, true);
            WriteLiteral("\',\r\n         Activate: \'");
            EndContext();
            BeginContext(1096, 21, false);
#line 30 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\PolicyType\V_ENC_19_00.cshtml"
               Write(Localizer["Activate"]);

#line default
#line hidden
            EndContext();
            BeginContext(1117, 25, true);
            WriteLiteral("\',\r\n         DActivate: \'");
            EndContext();
            BeginContext(1143, 22, false);
#line 31 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\PolicyType\V_ENC_19_00.cshtml"
                Write(Localizer["DActivate"]);

#line default
#line hidden
            EndContext();
            BeginContext(1165, 249, true);
            WriteLiteral("\',\r\n    };\r\n\r\n</script>\r\n<style>\r\n    .bootstrap-select {\r\n        width: 100% !important;\r\n    }\r\n</style>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-lg-4 col-md-4 col-sm-6\">\r\n        <div class=\"form-group\">\r\n            <label class=\"lable-color\">");
            EndContext();
            BeginContext(1415, 23, false);
#line 44 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\PolicyType\V_ENC_19_00.cshtml"
                                  Write(Localizer["PolicyType"]);

#line default
#line hidden
            EndContext();
            BeginContext(1438, 205, true);
            WriteLiteral(" </label>\r\n            <select class=\"selectpicker\" data-live-search=\"true\" id=\"cboPolicyType\" title=\"\" onchange=\"fnGridLoadPolicyTypes()\" data-size=\"10\">\r\n                <option value=\"0\"> All</option>\r\n");
            EndContext();
#line 47 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\PolicyType\V_ENC_19_00.cshtml"
                 if (ViewBag.PolicyTypes != null)
                {
                    foreach (var ptype in ViewBag.PolicyTypes)
                    {

#line default
#line hidden
            BeginContext(1800, 31, true);
            WriteLiteral("                        <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1831, "\"", 1861, 1);
#line 51 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\PolicyType\V_ENC_19_00.cshtml"
WriteAttributeValue("", 1839, ptype.ApplicationCode, 1839, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1862, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1864, 14, false);
#line 51 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\PolicyType\V_ENC_19_00.cshtml"
                                                          Write(ptype.CodeDesc);

#line default
#line hidden
            EndContext();
            BeginContext(1878, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 52 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\PolicyType\V_ENC_19_00.cshtml"
                    }

                }

#line default
#line hidden
            BeginContext(1933, 681, true);
            WriteLiteral(@"            </select>
        </div>
    </div>
</div>

<div class=""row padbot10"">
    <div class=""col-lg-12 col-md-12 col-sm-12 PlicyTypecontainer"">
        <table id=""jqgPolicyType""></table>
        <div id=""jqpPolicyType""></div>
    </div>
</div>

<div class=""modal fade in"" id=""PopupPolicyType"" data-keyboard=""false"" data-backdrop=""static"">
    <div class=""modal-dialog modal-lg"" role=""document"" style=""box-shadow:none;"">
        <div class=""modal-content"">
            <div class=""modal-header popupHeader"">
                <button type=""button"" class=""close"" data-dismiss=""modal""> <i class=""fa fa-times""></i></button>
                <h4 class=""modal-title"">");
            EndContext();
            BeginContext(2615, 26, false);
#line 72 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\PolicyType\V_ENC_19_00.cshtml"
                                   Write(Localizer["AddPolicyType"]);

#line default
#line hidden
            EndContext();
            BeginContext(2641, 444, true);
            WriteLiteral(@" </h4>
            </div>
            <div class=""modal-body"">
                <div class=""row padbot4"">

                    <div class=""col-sm-12"">
                        <input type=""text"" class=""form-control"" id=""txtSerialNumber"" style=""display:none"">
                    </div>

                    <div class=""col-lg-12 col-md-12 col-sm-12"">
                        <div class=""form-group"">
                            <label>");
            EndContext();
            BeginContext(3086, 28, false);
#line 83 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\PolicyType\V_ENC_19_00.cshtml"
                              Write(Localizer["PolicyStatement"]);

#line default
#line hidden
            EndContext();
            BeginContext(3114, 675, true);
            WriteLiteral(@"</label>
                            <textarea id=""txtPolicyStatement"" rows=""4"" class=""form-control""></textarea>

                        </div>

                    </div>

                </div>
                <div class=""row padbot4"">
                    <div class=""col-lg-4 col-md-4 col-sm-12 col-xs-12"">
                        <div class=""default-checkbox separate"">
                            <label class=""mdl-checkbox mdl-js-checkbox mdl-js-ripple-effect"" for=""chkActiveStatus"">
                                <input type=""checkbox"" id=""chkActiveStatus"" class=""mdl-checkbox__input"">
                                <span class=""mdl-checkbox__label"">");
            EndContext();
            BeginContext(3790, 19, false);
#line 96 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\PolicyType\V_ENC_19_00.cshtml"
                                                             Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(3809, 536, true);
            WriteLiteral(@" </span>
                            </label>
                        </div>
                    </div>
                </div>
             
            </div>
            <div class=""modal-footer"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <button class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent primary-button"" id=""btnSavePolicyType"" onclick=""fnSavePolicyType();"">
                            <i class=""fa fa-save""></i> ");
            EndContext();
            BeginContext(4346, 17, false);
#line 107 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\PolicyType\V_ENC_19_00.cshtml"
                                                  Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(4363, 245, true);
            WriteLiteral("\r\n                        </button>\r\n                        <button class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect  cancel-button cancel-button\" data-dismiss=\"modal\" id=\"btnCancelPolicyType\"><i class=\"fa fa-times\"></i> ");
            EndContext();
            BeginContext(4609, 19, false);
#line 109 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\PolicyType\V_ENC_19_00.cshtml"
                                                                                                                                                                                                           Write(Localizer["Cancel"]);

#line default
#line hidden
            EndContext();
            BeginContext(4628, 204, true);
            WriteLiteral(" </button>\r\n                        <button class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect\" id=\"btndeActivePolicyType\" onclick=\"fnDeletePolicyType();\"><i class=\"fa fa-times\"></i> ");
            EndContext();
            BeginContext(4833, 23, false);
#line 110 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\PolicyType\V_ENC_19_00.cshtml"
                                                                                                                                                                                           Write(Localizer["DeActivate"]);

#line default
#line hidden
            EndContext();
            BeginContext(4856, 146, true);
            WriteLiteral(" </button>\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
