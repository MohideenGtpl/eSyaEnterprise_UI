#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\ApplicationCodes\ESA_01_00.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96a0b22b61d091452796720fd45648f6f626f314"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Configure_Views_ApplicationCodes_ESA_01_00), @"mvc.1.0.view", @"/Areas/Configure/Views/ApplicationCodes/ESA_01_00.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Configure/Views/ApplicationCodes/ESA_01_00.cshtml", typeof(AspNetCore.Areas_Configure_Views_ApplicationCodes_ESA_01_00))]
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
#line 1 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\ApplicationCodes\ESA_01_00.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96a0b22b61d091452796720fd45648f6f626f314", @"/Areas/Configure/Views/ApplicationCodes/ESA_01_00.cshtml")]
    public class Areas_Configure_Views_ApplicationCodes_ESA_01_00 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Config/ApplicationCodes.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("selectpicker"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-live-search", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("cboCodeType"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-size", new global::Microsoft.AspNetCore.Html.HtmlString("8"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onchange", new global::Microsoft.AspNetCore.Html.HtmlString("fnGridLoadApplicationCodes()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(80, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(136, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\ApplicationCodes\ESA_01_00.cshtml"
  
    ViewData["Title"] = "ESA_01_00";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(230, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 11 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\ApplicationCodes\ESA_01_00.cshtml"
  
    var userFormRole = (eSyaEnterprise_UI.Models.DO_UserFormRole)ViewBag.UserFormRole;

#line default
#line hidden
            BeginContext(327, 46, true);
            WriteLiteral("<script>\r\n    var _userFormRole = JSON.parse(\'");
            EndContext();
            BeginContext(374, 38, false);
#line 15 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\ApplicationCodes\ESA_01_00.cshtml"
                               Write(Html.Raw(Json.Serialize(userFormRole)));

#line default
#line hidden
            EndContext();
            BeginContext(412, 61, true);
            WriteLiteral("\');\r\n\r\n      var localization = {\r\n        ApplicationCode: \'");
            EndContext();
            BeginContext(474, 28, false);
#line 18 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\ApplicationCodes\ESA_01_00.cshtml"
                     Write(Localizer["ApplicationCode"]);

#line default
#line hidden
            EndContext();
            BeginContext(502, 23, true);
            WriteLiteral("\',\r\n        CodeType: \'");
            EndContext();
            BeginContext(526, 21, false);
#line 19 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\ApplicationCodes\ESA_01_00.cshtml"
              Write(Localizer["CodeType"]);

#line default
#line hidden
            EndContext();
            BeginContext(547, 26, true);
            WriteLiteral("\',\r\n        Description: \'");
            EndContext();
            BeginContext(574, 24, false);
#line 20 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\ApplicationCodes\ESA_01_00.cshtml"
                 Write(Localizer["Description"]);

#line default
#line hidden
            EndContext();
            BeginContext(598, 24, true);
            WriteLiteral("\',\r\n        ShortCode: \'");
            EndContext();
            BeginContext(623, 22, false);
#line 21 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\ApplicationCodes\ESA_01_00.cshtml"
               Write(Localizer["ShortCode"]);

#line default
#line hidden
            EndContext();
            BeginContext(645, 28, true);
            WriteLiteral("\',\r\n        DefaultStatus: \'");
            EndContext();
            BeginContext(674, 26, false);
#line 22 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\ApplicationCodes\ESA_01_00.cshtml"
                   Write(Localizer["DefaultStatus"]);

#line default
#line hidden
            EndContext();
            BeginContext(700, 21, true);
            WriteLiteral("\',\r\n        Active: \'");
            EndContext();
            BeginContext(722, 19, false);
#line 23 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\ApplicationCodes\ESA_01_00.cshtml"
            Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(741, 22, true);
            WriteLiteral("\',\r\n        Actions: \'");
            EndContext();
            BeginContext(764, 20, false);
#line 24 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\ApplicationCodes\ESA_01_00.cshtml"
             Write(Localizer["Actions"]);

#line default
#line hidden
            EndContext();
            BeginContext(784, 19, true);
            WriteLiteral("\',\r\n        Edit: \'");
            EndContext();
            BeginContext(804, 17, false);
#line 25 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\ApplicationCodes\ESA_01_00.cshtml"
          Write(Localizer["Edit"]);

#line default
#line hidden
            EndContext();
            BeginContext(821, 19, true);
            WriteLiteral("\',\r\n        View: \'");
            EndContext();
            BeginContext(841, 17, false);
#line 26 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\ApplicationCodes\ESA_01_00.cshtml"
          Write(Localizer["View"]);

#line default
#line hidden
            EndContext();
            BeginContext(858, 19, true);
            WriteLiteral("\',\r\n        Save: \'");
            EndContext();
            BeginContext(878, 17, false);
#line 27 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\ApplicationCodes\ESA_01_00.cshtml"
          Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(895, 21, true);
            WriteLiteral("\',\r\n        Cancel: \'");
            EndContext();
            BeginContext(917, 19, false);
#line 28 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\ApplicationCodes\ESA_01_00.cshtml"
            Write(Localizer["Cancel"]);

#line default
#line hidden
            EndContext();
            BeginContext(936, 33, true);
            WriteLiteral("\',\r\n        AddApplicationCode: \'");
            EndContext();
            BeginContext(970, 31, false);
#line 29 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\ApplicationCodes\ESA_01_00.cshtml"
                        Write(Localizer["AddApplicationCode"]);

#line default
#line hidden
            EndContext();
            BeginContext(1001, 36, true);
            WriteLiteral("\',\r\n        UpdateApplicationCode: \'");
            EndContext();
            BeginContext(1038, 34, false);
#line 30 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\ApplicationCodes\ESA_01_00.cshtml"
                           Write(Localizer["UpdateApplicationCode"]);

#line default
#line hidden
            EndContext();
            BeginContext(1072, 21, true);
            WriteLiteral("\',\r\n        Update: \'");
            EndContext();
            BeginContext(1094, 19, false);
#line 31 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\ApplicationCodes\ESA_01_00.cshtml"
            Write(Localizer["Update"]);

#line default
#line hidden
            EndContext();
            BeginContext(1113, 34, true);
            WriteLiteral("\',\r\n        ViewApplicationCode: \'");
            EndContext();
            BeginContext(1148, 32, false);
#line 32 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\ApplicationCodes\ESA_01_00.cshtml"
                         Write(Localizer["ViewApplicationCode"]);

#line default
#line hidden
            EndContext();
            BeginContext(1180, 21, true);
            WriteLiteral("\',\r\n        Delete: \'");
            EndContext();
            BeginContext(1202, 19, false);
#line 33 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\ApplicationCodes\ESA_01_00.cshtml"
            Write(Localizer["Delete"]);

#line default
#line hidden
            EndContext();
            BeginContext(1221, 23, true);
            WriteLiteral("\',\r\n        Activate: \'");
            EndContext();
            BeginContext(1245, 21, false);
#line 34 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\ApplicationCodes\ESA_01_00.cshtml"
              Write(Localizer["Activate"]);

#line default
#line hidden
            EndContext();
            BeginContext(1266, 24, true);
            WriteLiteral("\',\r\n        DActivate: \'");
            EndContext();
            BeginContext(1291, 22, false);
#line 35 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\ApplicationCodes\ESA_01_00.cshtml"
               Write(Localizer["DActivate"]);

#line default
#line hidden
            EndContext();
            BeginContext(1313, 23, true);
            WriteLiteral("\',\r\n    };\r\n</script>\r\n");
            EndContext();
            BeginContext(1336, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96a0b22b61d091452796720fd45648f6f626f31414595", async() => {
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
            BeginContext(1391, 321, true);
            WriteLiteral(@"
<style>
    .bootstrap-select {
        width: 100% !important;
    }

    #jqgh_jgvApplicationCodes_DefaultStatus {
        text-align: center;
    }
</style>

<div class=""row"">
    <div class=""col-lg-3 col-md-5 col-sm-6 col-xs-12"">
        <div class=""form-group"">
            <label class=""lable-color"">");
            EndContext();
            BeginContext(1713, 21, false);
#line 52 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\ApplicationCodes\ESA_01_00.cshtml"
                                  Write(Localizer["CodeType"]);

#line default
#line hidden
            EndContext();
            BeginContext(1734, 46, true);
            WriteLiteral(" </label>\r\n            <div>\r\n                ");
            EndContext();
            BeginContext(1780, 300, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96a0b22b61d091452796720fd45648f6f626f31416557", async() => {
                BeginContext(1997, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(2055, 16, true);
                WriteLiteral("                ");
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
#line 55 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\ApplicationCodes\ESA_01_00.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.CodeTypeList;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2080, 310, true);
            WriteLiteral(@"
            </div>
        </div>
    </div>
    <div class=""col-lg-9 col-md-7 col-sm-6 form-group text-right d-flex justify-content-end align-self-end"">
        <button type=""button"" class=""mdl-button  primary-button"" id=""btnExportToExcel"" onclick=""fnExportToExcel()""><i class=""fas fa-file-export""></i> ");
            EndContext();
            BeginContext(2391, 26, false);
#line 63 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\ApplicationCodes\ESA_01_00.cshtml"
                                                                                                                                                 Write(Localizer["ExportToExcel"]);

#line default
#line hidden
            EndContext();
            BeginContext(2417, 668, true);
            WriteLiteral(@"  </button>
    </div>
</div>

<div class=""row"">
    <div class=""col-lg-12 col-md-12 col-sm-12"">
        <table id=""jqgApplicationCodes""></table>
        <div id=""jpgApplicationCodes""></div>
    </div>
</div>

<div class=""modal fade"" id=""PopupApplicationCodes"" data-keyboard=""false"" data-backdrop=""static"">
    <div class=""modal-dialog modal-md"" role=""document"" style=""box-shadow:none;"">
        <div class=""modal-content"">
            <div class=""modal-header popupHeader"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" onclick=""fnClearFields()""> <i class=""fa fa-times""></i></button>
                <h4 class=""modal-title"">");
            EndContext();
            BeginContext(3086, 29, false);
#line 79 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\ApplicationCodes\ESA_01_00.cshtml"
                                   Write(Localizer["ApplicationCodes"]);

#line default
#line hidden
            EndContext();
            BeginContext(3115, 427, true);
            WriteLiteral(@"</h4>
            </div>


            <div class=""modal-body"">
                <div class=""row padbot4"">
                    <div class=""col-sm-12"">
                        <input type=""text"" class=""form-control"" id=""txtApplicationCode"" style=""display:none"">
                    </div>
                    <div class=""col-lg-12"">
                        <div class=""form-group"">
                            <label> ");
            EndContext();
            BeginContext(3543, 24, false);
#line 90 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\ApplicationCodes\ESA_01_00.cshtml"
                               Write(Localizer["Description"]);

#line default
#line hidden
            EndContext();
            BeginContext(3567, 344, true);
            WriteLiteral(@"</label>
                            <input id=""txtApplicationCodeDescription"" class=""form-control"" type=""text"" autocomplete=""off"" maxlength=""50"" />

                        </div>
                    </div>
                    <div class=""col-lg-12"">
                        <div class=""form-group"">
                            <label> ");
            EndContext();
            BeginContext(3912, 22, false);
#line 97 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\ApplicationCodes\ESA_01_00.cshtml"
                               Write(Localizer["ShortCode"]);

#line default
#line hidden
            EndContext();
            BeginContext(3934, 645, true);
            WriteLiteral(@"</label>
                            <input id=""txtShortCode"" class=""form-control"" type=""text"" autocomplete=""off"" maxlength=""15"" />

                        </div>
                    </div>
                    <div class=""col-lg-4 col-md-4 col-sm-12 col-xs-12"">
                        <div class=""default-checkbox single"">
                            <label class=""mdl-checkbox mdl-js-checkbox mdl-js-ripple-effect"" for=""chkApplicationDefaultStatus"">
                                <input type=""checkbox"" id=""chkApplicationDefaultStatus"" class=""mdl-checkbox__input"">
                                <span class=""mdl-checkbox__label"">");
            EndContext();
            BeginContext(4580, 26, false);
#line 106 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\ApplicationCodes\ESA_01_00.cshtml"
                                                             Write(Localizer["DefaultStatus"]);

#line default
#line hidden
            EndContext();
            BeginContext(4606, 532, true);
            WriteLiteral(@"</span>
                            </label>
                        </div>
                    </div>
                    <div class=""col-lg-4 col-md-4 col-sm-12 col-xs-12"">
                        <div class=""default-checkbox single"">
                            <label class=""mdl-checkbox mdl-js-checkbox mdl-js-ripple-effect"" for=""chkActiveStatus"">
                                <input type=""checkbox"" id=""chkActiveStatus"" class=""mdl-checkbox__input"">
                                <span class=""mdl-checkbox__label"">");
            EndContext();
            BeginContext(5139, 19, false);
#line 114 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\ApplicationCodes\ESA_01_00.cshtml"
                                                             Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(5158, 473, true);
            WriteLiteral(@"</span>
                            </label>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""modal-footer"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <button type=""button"" class=""mdl-button  primary-button"" id=""btnSaveApplicationCode"" onclick=""fnSaveApplicationCode()"">
                            <i class=""fa fa-save""></i>   ");
            EndContext();
            BeginContext(5632, 17, false);
#line 124 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\ApplicationCodes\ESA_01_00.cshtml"
                                                    Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(5649, 255, true);
            WriteLiteral("\r\n                        </button>\r\n                        <button type=\"button\" class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect\" id=\"btnDeactivateApplicationCode\" onclick=\"fnDeleteApplicationCodes()\"><i class=\"fas fa-ban\"></i>  ");
            EndContext();
            BeginContext(5905, 23, false);
#line 126 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\ApplicationCodes\ESA_01_00.cshtml"
                                                                                                                                                                                                                     Write(Localizer["Deactivate"]);

#line default
#line hidden
            EndContext();
            BeginContext(5928, 224, true);
            WriteLiteral(" </button>\r\n\r\n                        <button type=\"button\" class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect  cancel-button\" data-dismiss=\"modal\" onclick=\"fnClearFields()\"><i class=\"fa fa-times\"></i>  ");
            EndContext();
            BeginContext(6153, 19, false);
#line 128 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\ApplicationCodes\ESA_01_00.cshtml"
                                                                                                                                                                                                             Write(Localizer["Cancel"]);

#line default
#line hidden
            EndContext();
            BeginContext(6172, 142, true);
            WriteLiteral(" </button>\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
