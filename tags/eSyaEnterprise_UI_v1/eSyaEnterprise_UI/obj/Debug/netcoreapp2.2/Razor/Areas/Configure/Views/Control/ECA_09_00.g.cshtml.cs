#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Control\ECA_09_00.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f280b6d3aef3e93cba70de41d1eed975f1e1fd6b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Configure_Views_Control_ECA_09_00), @"mvc.1.0.view", @"/Areas/Configure/Views/Control/ECA_09_00.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Configure/Views/Control/ECA_09_00.cshtml", typeof(AspNetCore.Areas_Configure_Views_Control_ECA_09_00))]
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
#line 1 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Control\ECA_09_00.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f280b6d3aef3e93cba70de41d1eed975f1e1fd6b", @"/Areas/Configure/Views/Control/ECA_09_00.cshtml")]
    public class Areas_Configure_Views_Control_ECA_09_00 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Config/DocumentControl.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(82, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 6 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Control\ECA_09_00.cshtml"
  
    ViewData["Title"] = "ECA_09_00";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(178, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(203, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(209, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f280b6d3aef3e93cba70de41d1eed975f1e1fd6b4176", async() => {
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
                BeginContext(263, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(268, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 16 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Control\ECA_09_00.cshtml"
  
    var userFormRole = (eSyaEnterprise_UI.Models.DO_UserFormRole)ViewBag.UserFormRole;

#line default
#line hidden
            BeginContext(365, 46, true);
            WriteLiteral("<script>\r\n    var _userFormRole = JSON.parse(\'");
            EndContext();
            BeginContext(412, 38, false);
#line 20 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Control\ECA_09_00.cshtml"
                               Write(Html.Raw(Json.Serialize(userFormRole)));

#line default
#line hidden
            EndContext();
            BeginContext(450, 57, true);
            WriteLiteral("\');\r\n\r\n      var localization = {\r\n          ShortDesc: \'");
            EndContext();
            BeginContext(508, 29, false);
#line 23 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Control\ECA_09_00.cshtml"
                 Write(Localizer["ShortDescription"]);

#line default
#line hidden
            EndContext();
            BeginContext(537, 36, true);
            WriteLiteral("\',\r\n          DocumentDescription: \'");
            EndContext();
            BeginContext(574, 32, false);
#line 24 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Control\ECA_09_00.cshtml"
                           Write(Localizer["DocumentDescription"]);

#line default
#line hidden
            EndContext();
            BeginContext(606, 27, true);
            WriteLiteral("\',\r\n          DocumentId: \'");
            EndContext();
            BeginContext(634, 23, false);
#line 25 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Control\ECA_09_00.cshtml"
                  Write(Localizer["DocumentId"]);

#line default
#line hidden
            EndContext();
            BeginContext(657, 27, true);
            WriteLiteral("\',\r\n          SchemeName: \'");
            EndContext();
            BeginContext(685, 23, false);
#line 26 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Control\ECA_09_00.cshtml"
                  Write(Localizer["SchemeName"]);

#line default
#line hidden
            EndContext();
            BeginContext(708, 27, true);
            WriteLiteral("\',\r\n          UsageStatus:\'");
            EndContext();
            BeginContext(736, 24, false);
#line 27 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Control\ECA_09_00.cshtml"
                  Write(Localizer["UsageStatus"]);

#line default
#line hidden
            EndContext();
            BeginContext(760, 23, true);
            WriteLiteral("\',\r\n          Active: \'");
            EndContext();
            BeginContext(784, 19, false);
#line 28 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Control\ECA_09_00.cshtml"
              Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(803, 24, true);
            WriteLiteral("\',\r\n          Actions: \'");
            EndContext();
            BeginContext(828, 20, false);
#line 29 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Control\ECA_09_00.cshtml"
               Write(Localizer["Actions"]);

#line default
#line hidden
            EndContext();
            BeginContext(848, 21, true);
            WriteLiteral("\',\r\n          Edit: \'");
            EndContext();
            BeginContext(870, 17, false);
#line 30 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Control\ECA_09_00.cshtml"
            Write(Localizer["Edit"]);

#line default
#line hidden
            EndContext();
            BeginContext(887, 21, true);
            WriteLiteral("\',\r\n          View: \'");
            EndContext();
            BeginContext(909, 17, false);
#line 31 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Control\ECA_09_00.cshtml"
            Write(Localizer["View"]);

#line default
#line hidden
            EndContext();
            BeginContext(926, 29, true);
            WriteLiteral("\',\r\n          DocumentType: \'");
            EndContext();
            BeginContext(956, 25, false);
#line 32 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Control\ECA_09_00.cshtml"
                    Write(Localizer["DocumentType"]);

#line default
#line hidden
            EndContext();
            BeginContext(981, 29, true);
            WriteLiteral("\',\r\n          DocumentCode: \'");
            EndContext();
            BeginContext(1011, 25, false);
#line 33 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Control\ECA_09_00.cshtml"
                    Write(Localizer["DocumentCode"]);

#line default
#line hidden
            EndContext();
            BeginContext(1036, 33, true);
            WriteLiteral("\',\r\n          DocumentCategory: \'");
            EndContext();
            BeginContext(1070, 29, false);
#line 34 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Control\ECA_09_00.cshtml"
                        Write(Localizer["DocumentCategory"]);

#line default
#line hidden
            EndContext();
            BeginContext(1099, 42, true);
            WriteLiteral("\',\r\n          IsFinancialYearApplicable: \'");
            EndContext();
            BeginContext(1142, 38, false);
#line 35 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Control\ECA_09_00.cshtml"
                                 Write(Localizer["IsFinancialYearApplicable"]);

#line default
#line hidden
            EndContext();
            BeginContext(1180, 38, true);
            WriteLiteral("\',\r\n          IsStoreLinkApplicable: \'");
            EndContext();
            BeginContext(1219, 34, false);
#line 36 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Control\ECA_09_00.cshtml"
                             Write(Localizer["IsStoreLinkApplicable"]);

#line default
#line hidden
            EndContext();
            BeginContext(1253, 44, true);
            WriteLiteral("\',\r\n          IsTransactionModeApplicable: \'");
            EndContext();
            BeginContext(1298, 40, false);
#line 37 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Control\ECA_09_00.cshtml"
                                   Write(Localizer["IsTransactionModeApplicable"]);

#line default
#line hidden
            EndContext();
            BeginContext(1338, 42, true);
            WriteLiteral("\',\r\n          IsCustomerGroupApplicable: \'");
            EndContext();
            BeginContext(1381, 38, false);
#line 38 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Control\ECA_09_00.cshtml"
                                 Write(Localizer["IsCustomerGroupApplicable"]);

#line default
#line hidden
            EndContext();
            BeginContext(1419, 34, true);
            WriteLiteral("\',\r\n          IsLinkToDashboard: \'");
            EndContext();
            BeginContext(1454, 30, false);
#line 39 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Control\ECA_09_00.cshtml"
                         Write(Localizer["IsLinkToDashboard"]);

#line default
#line hidden
            EndContext();
            BeginContext(1484, 35, true);
            WriteLiteral("\',\r\n          AddDocumentControl: \'");
            EndContext();
            BeginContext(1520, 31, false);
#line 40 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Control\ECA_09_00.cshtml"
                          Write(Localizer["AddDocumentControl"]);

#line default
#line hidden
            EndContext();
            BeginContext(1551, 21, true);
            WriteLiteral("\',\r\n          Save: \'");
            EndContext();
            BeginContext(1573, 17, false);
#line 41 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Control\ECA_09_00.cshtml"
            Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(1590, 38, true);
            WriteLiteral("\',\r\n          UpdateDocumentControl: \'");
            EndContext();
            BeginContext(1629, 34, false);
#line 42 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Control\ECA_09_00.cshtml"
                             Write(Localizer["UpdateDocumentControl"]);

#line default
#line hidden
            EndContext();
            BeginContext(1663, 23, true);
            WriteLiteral("\',\r\n          Update: \'");
            EndContext();
            BeginContext(1687, 19, false);
#line 43 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Control\ECA_09_00.cshtml"
              Write(Localizer["Update"]);

#line default
#line hidden
            EndContext();
            BeginContext(1706, 36, true);
            WriteLiteral("\',\r\n          ViewDocumentControl: \'");
            EndContext();
            BeginContext(1743, 32, false);
#line 44 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Control\ECA_09_00.cshtml"
                           Write(Localizer["ViewDocumentControl"]);

#line default
#line hidden
            EndContext();
            BeginContext(1775, 27, true);
            WriteLiteral("\',\r\n          DeActivate: \'");
            EndContext();
            BeginContext(1803, 23, false);
#line 45 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Control\ECA_09_00.cshtml"
                  Write(Localizer["DeActivate"]);

#line default
#line hidden
            EndContext();
            BeginContext(1826, 25, true);
            WriteLiteral("\',\r\n          Activate: \'");
            EndContext();
            BeginContext(1852, 21, false);
#line 46 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Control\ECA_09_00.cshtml"
                Write(Localizer["Activate"]);

#line default
#line hidden
            EndContext();
            BeginContext(1873, 23, true);
            WriteLiteral("\',\r\n          Delete: \'");
            EndContext();
            BeginContext(1897, 19, false);
#line 47 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Control\ECA_09_00.cshtml"
              Write(Localizer["Delete"]);

#line default
#line hidden
            EndContext();
            BeginContext(1916, 854, true);
            WriteLiteral(@"',
    };
</script>
<style>
    #gbox_jqvDocContManagement th.ui-th-column div {
        white-space: normal !important;
        height: auto !important;
        padding: 2px;
    }
</style>

<!--Document Grid-->
<div class=""row"">
    <div class=""col-lg-12"">
        <table id=""jqvDocContManagement""></table>
        <div id=""jqpDocContManagement""></div>
    </div>
</div>


<!--Document PopUp-->
<div class=""modal fade in"" id=""PopupDocContrManagement"" data-keyboard=""false"" data-backdrop=""static"">
    <div class=""modal-dialog modal-lg "" role=""document"" style=""box-shadow:none;"">
        <div class=""modal-content "">
            <div class=""modal-header popupHeader"">
                <button type=""button"" class=""close ml-auto"" data-dismiss=""modal""> <i class=""fa fa-times""></i></button>
                <h4 class=""modal-title"">");
            EndContext();
            BeginContext(2771, 31, false);
#line 73 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Control\ECA_09_00.cshtml"
                                   Write(Localizer["AddDocumentControl"]);

#line default
#line hidden
            EndContext();
            BeginContext(2802, 257, true);
            WriteLiteral(@"</h4>
            </div>
            <div class=""modal-body"">
                <div class=""row"">
                    <div class=""col-lg-3 col-md-3 col-sm-3 col-xs-12"">
                        <div class=""form-group"">
                            <label>");
            EndContext();
            BeginContext(3060, 23, false);
#line 79 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Control\ECA_09_00.cshtml"
                              Write(Localizer["DocumentID"]);

#line default
#line hidden
            EndContext();
            BeginContext(3083, 418, true);
            WriteLiteral(@"</label>
                            <input id=""txtDocumentId"" class=""form-control"" type=""text"" autocomplete=""off"" maxlength=""9"" data-inputmask=""'mask': '9', 'repeat': 10, 'greedy' : false"" />

                        </div>
                    </div>


                    <div class=""col-lg-3 col-md-3 col-sm-3 col-xs-12"">
                        <div class=""form-group"">
                            <label>");
            EndContext();
            BeginContext(3502, 25, false);
#line 88 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Control\ECA_09_00.cshtml"
                              Write(Localizer["DocumentType"]);

#line default
#line hidden
            EndContext();
            BeginContext(3527, 358, true);
            WriteLiteral(@" </label>
                            <input id=""txtDocumentType"" class=""form-control"" type=""text"" autocomplete=""off"" maxlength=""1"" />

                        </div>
                    </div>

                    <div class=""col-lg-3 col-md-3 col-sm-3 col-xs-12"">
                        <div class=""form-group"">
                            <label>");
            EndContext();
            BeginContext(3886, 29, false);
#line 96 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Control\ECA_09_00.cshtml"
                              Write(Localizer["ShortDescription"]);

#line default
#line hidden
            EndContext();
            BeginContext(3915, 355, true);
            WriteLiteral(@" </label>
                            <input id=""txtShortDesc"" class=""form-control"" type=""text"" autocomplete=""off"" maxlength=""4"" />

                        </div>
                    </div>

                    <div class=""col-lg-3 col-md-3 col-sm-3 col-xs-12"">
                        <div class=""form-group"">
                            <label>");
            EndContext();
            BeginContext(4271, 23, false);
#line 104 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Control\ECA_09_00.cshtml"
                              Write(Localizer["SchemeName"]);

#line default
#line hidden
            EndContext();
            BeginContext(4294, 425, true);
            WriteLiteral(@" </label>
                            <input id=""txtSchemeName"" class=""form-control"" type=""text"" autocomplete=""off"" maxlength=""10"" />

                        </div>
                    </div>



                </div>
                <div class=""row"">

                    <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
                        <div class=""form-group"">
                            <label>");
            EndContext();
            BeginContext(4720, 32, false);
#line 117 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Control\ECA_09_00.cshtml"
                              Write(Localizer["DocumentDescription"]);

#line default
#line hidden
            EndContext();
            BeginContext(4752, 701, true);
            WriteLiteral(@" </label>
                            <input id=""txtDocumentDesc"" class=""form-control"" type=""text"" autocomplete=""off"" maxlength=""50"" />

                        </div>
                    </div>


                </div>
                <div class=""row"">
                    <div class=""col-lg-4 col-md-6 col-sm-6 col-xs-12"">
                        <div class=""default-checkbox checkbox-group"">
                            <label class=""mdl-checkbox mdl-js-checkbox mdl-js-ripple-effect"" for=""chkIsFinancialYear"">
                                <input type=""checkbox"" id=""chkIsFinancialYear"" class=""mdl-checkbox__input"">
                                <span class=""mdl-checkbox__label"">");
            EndContext();
            BeginContext(5454, 38, false);
#line 130 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Control\ECA_09_00.cshtml"
                                                             Write(Localizer["IsFinancialYearApplicable"]);

#line default
#line hidden
            EndContext();
            BeginContext(5492, 537, true);
            WriteLiteral(@"</span>
                            </label>
                        </div>
                    </div>
                    <div class=""col-lg-4 col-md-6 col-sm-6 col-xs-12"">
                        <div class=""default-checkbox checkbox-group"">
                            <label class=""mdl-checkbox mdl-js-checkbox mdl-js-ripple-effect"" for=""chkIsStoreLink"">
                                <input type=""checkbox"" id=""chkIsStoreLink"" class=""mdl-checkbox__input"">
                                <span class=""mdl-checkbox__label"">");
            EndContext();
            BeginContext(6030, 34, false);
#line 138 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Control\ECA_09_00.cshtml"
                                                             Write(Localizer["IsStoreLinkApplicable"]);

#line default
#line hidden
            EndContext();
            BeginContext(6064, 549, true);
            WriteLiteral(@"</span>
                            </label>
                        </div>
                    </div>
                    <div class=""col-lg-4 col-md-6 col-sm-6 col-xs-12"">
                        <div class=""default-checkbox checkbox-group"">
                            <label class=""mdl-checkbox mdl-js-checkbox mdl-js-ripple-effect"" for=""chkIsTransactionMode"">
                                <input type=""checkbox"" id=""chkIsTransactionMode"" class=""mdl-checkbox__input"">
                                <span class=""mdl-checkbox__label"">");
            EndContext();
            BeginContext(6614, 40, false);
#line 146 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Control\ECA_09_00.cshtml"
                                                             Write(Localizer["IsTransactionModeApplicable"]);

#line default
#line hidden
            EndContext();
            BeginContext(6654, 545, true);
            WriteLiteral(@"</span>
                            </label>
                        </div>
                    </div>
                    <div class=""col-lg-4 col-md-6 col-sm-6 col-xs-12"">
                        <div class=""default-checkbox checkbox-group"">
                            <label class=""mdl-checkbox mdl-js-checkbox mdl-js-ripple-effect"" for=""chkIsCustomerGroup"">
                                <input type=""checkbox"" id=""chkIsCustomerGroup"" class=""mdl-checkbox__input"">
                                <span class=""mdl-checkbox__label"">");
            EndContext();
            BeginContext(7200, 38, false);
#line 154 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Control\ECA_09_00.cshtml"
                                                             Write(Localizer["IsCustomerGroupApplicable"]);

#line default
#line hidden
            EndContext();
            BeginContext(7238, 539, true);
            WriteLiteral(@"</span>
                            </label>
                        </div>
                    </div>

                    <div class=""col-lg-4 col-md-6 col-sm-6 col-xs-12"">
                        <div class=""default-checkbox checkbox-group"">
                            <label class=""mdl-checkbox mdl-js-checkbox mdl-js-ripple-effect"" for=""chkUsageStatus"">
                                <input type=""checkbox"" id=""chkUsageStatus"" class=""mdl-checkbox__input"">
                                <span class=""mdl-checkbox__label"">");
            EndContext();
            BeginContext(7778, 24, false);
#line 163 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Control\ECA_09_00.cshtml"
                                                             Write(Localizer["UsageStatus"]);

#line default
#line hidden
            EndContext();
            BeginContext(7802, 542, true);
            WriteLiteral(@" </span>
                            </label>
                        </div>
                    </div>

                    <div class=""col-lg-3 col-sm-6 col-md-6 col-xs-12"">
                        <div class=""default-checkbox checkbox-group"">
                            <label class=""mdl-checkbox mdl-js-checkbox mdl-js-ripple-effect"" for=""chkActiveStatus"">
                                <input type=""checkbox"" id=""chkActiveStatus"" class=""mdl-checkbox__input"">
                                <span class=""mdl-checkbox__label"">");
            EndContext();
            BeginContext(8345, 19, false);
#line 172 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Control\ECA_09_00.cshtml"
                                                             Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(8364, 433, true);
            WriteLiteral(@" </span>
                            </label>
                        </div>
                    </div>
                </div>
            </div>

            <div class=""modal-footer"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <button class=""mdl-button  primary-button"" id=""btnsaveDocContrManagement"" onclick=""fnSaveDocumentControl()""><i class=""fa fa-save""></i> ");
            EndContext();
            BeginContext(8798, 17, false);
#line 182 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Control\ECA_09_00.cshtml"
                                                                                                                                                          Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(8815, 231, true);
            WriteLiteral("   </button>\r\n                        <button type=\"button\" class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect\" id=\"btnDeactivateDocumentControl\" onclick=\"fnDeleteDocumentControl()\"><i class=\"fas fa-ban\"></i>  ");
            EndContext();
            BeginContext(9047, 23, false);
#line 183 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Control\ECA_09_00.cshtml"
                                                                                                                                                                                                                    Write(Localizer["DeActivate"]);

#line default
#line hidden
            EndContext();
            BeginContext(9070, 203, true);
            WriteLiteral(" </button>\r\n                        <button class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect  cancel-button cancel-button\" data-dismiss=\"modal\" id=\"#\"> <i class=\"fa fa-times\"></i> ");
            EndContext();
            BeginContext(9274, 19, false);
#line 184 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Configure\Views\Control\ECA_09_00.cshtml"
                                                                                                                                                                                          Write(Localizer["Cancel"]);

#line default
#line hidden
            EndContext();
            BeginContext(9293, 138, true);
            WriteLiteral(" </button>\r\n\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
