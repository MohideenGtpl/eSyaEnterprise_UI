#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\Parameters\ECA_05_00.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63454bed22c8665089cca96abef13c3da9f4ef7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Configure_Views_Parameters_ECA_05_00), @"mvc.1.0.view", @"/Areas/Configure/Views/Parameters/ECA_05_00.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Configure/Views/Parameters/ECA_05_00.cshtml", typeof(AspNetCore.Areas_Configure_Views_Parameters_ECA_05_00))]
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
#line 1 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\Parameters\ECA_05_00.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63454bed22c8665089cca96abef13c3da9f4ef7e", @"/Areas/Configure/Views/Parameters/ECA_05_00.cshtml")]
    public class Areas_Configure_Views_Parameters_ECA_05_00 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Config/Parameters.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(80, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\Parameters\ECA_05_00.cshtml"
  
    ViewData["Title"] = "ECA_05_00";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(174, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 9 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\Parameters\ECA_05_00.cshtml"
  
    var userFormRole = (eSyaEnterprise_UI.Models.DO_UserFormRole)ViewBag.UserFormRole;

#line default
#line hidden
            BeginContext(271, 46, true);
            WriteLiteral("<script>\r\n    var _userFormRole = JSON.parse(\'");
            EndContext();
            BeginContext(318, 38, false);
#line 13 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\Parameters\ECA_05_00.cshtml"
                               Write(Html.Raw(Json.Serialize(userFormRole)));

#line default
#line hidden
            EndContext();
            BeginContext(356, 61, true);
            WriteLiteral("\');\r\n\r\n      var localization = {\r\n          ParameterType: \'");
            EndContext();
            BeginContext(418, 26, false);
#line 16 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\Parameters\ECA_05_00.cshtml"
                     Write(Localizer["ParameterType"]);

#line default
#line hidden
            EndContext();
            BeginContext(444, 41, true);
            WriteLiteral("\',\r\n          ParameterTypeDescription: \'");
            EndContext();
            BeginContext(486, 37, false);
#line 17 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\Parameters\ECA_05_00.cshtml"
                                Write(Localizer["ParameterTypeDescription"]);

#line default
#line hidden
            EndContext();
            BeginContext(523, 23, true);
            WriteLiteral("\',\r\n          Active: \'");
            EndContext();
            BeginContext(547, 19, false);
#line 18 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\Parameters\ECA_05_00.cshtml"
              Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(566, 24, true);
            WriteLiteral("\',\r\n          Actions: \'");
            EndContext();
            BeginContext(591, 20, false);
#line 19 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\Parameters\ECA_05_00.cshtml"
               Write(Localizer["Actions"]);

#line default
#line hidden
            EndContext();
            BeginContext(611, 33, true);
            WriteLiteral("\',\r\n          AddParameterType: \'");
            EndContext();
            BeginContext(645, 29, false);
#line 20 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\Parameters\ECA_05_00.cshtml"
                        Write(Localizer["AddParameterType"]);

#line default
#line hidden
            EndContext();
            BeginContext(674, 21, true);
            WriteLiteral("\',\r\n          Save: \'");
            EndContext();
            BeginContext(696, 17, false);
#line 21 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\Parameters\ECA_05_00.cshtml"
            Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(713, 36, true);
            WriteLiteral("\',\r\n          UpdateParameterType: \'");
            EndContext();
            BeginContext(750, 32, false);
#line 22 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\Parameters\ECA_05_00.cshtml"
                           Write(Localizer["UpdateParameterType"]);

#line default
#line hidden
            EndContext();
            BeginContext(782, 23, true);
            WriteLiteral("\',\r\n          Update: \'");
            EndContext();
            BeginContext(806, 19, false);
#line 23 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\Parameters\ECA_05_00.cshtml"
              Write(Localizer["Update"]);

#line default
#line hidden
            EndContext();
            BeginContext(825, 34, true);
            WriteLiteral("\',\r\n          ViewParameterType: \'");
            EndContext();
            BeginContext(860, 30, false);
#line 24 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\Parameters\ECA_05_00.cshtml"
                         Write(Localizer["ViewParameterType"]);

#line default
#line hidden
            EndContext();
            BeginContext(890, 30, true);
            WriteLiteral("\',\r\n          AddParameters: \'");
            EndContext();
            BeginContext(921, 26, false);
#line 25 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\Parameters\ECA_05_00.cshtml"
                     Write(Localizer["AddParameters"]);

#line default
#line hidden
            EndContext();
            BeginContext(947, 23, true);
            WriteLiteral("\',\r\n          Cancel: \'");
            EndContext();
            BeginContext(971, 19, false);
#line 26 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\Parameters\ECA_05_00.cshtml"
              Write(Localizer["Cancel"]);

#line default
#line hidden
            EndContext();
            BeginContext(990, 28, true);
            WriteLiteral("\',\r\n          ParameterID: \'");
            EndContext();
            BeginContext(1019, 24, false);
#line 27 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\Parameters\ECA_05_00.cshtml"
                   Write(Localizer["ParameterID"]);

#line default
#line hidden
            EndContext();
            BeginContext(1043, 37, true);
            WriteLiteral("\',\r\n          ParameterDescription: \'");
            EndContext();
            BeginContext(1081, 33, false);
#line 28 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\Parameters\ECA_05_00.cshtml"
                            Write(Localizer["ParameterDescription"]);

#line default
#line hidden
            EndContext();
            BeginContext(1114, 26, true);
            WriteLiteral("\',\r\n          ValueType: \'");
            EndContext();
            BeginContext(1141, 22, false);
#line 29 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\Parameters\ECA_05_00.cshtml"
                 Write(Localizer["ValueType"]);

#line default
#line hidden
            EndContext();
            BeginContext(1163, 27, true);
            WriteLiteral("\',\r\n          Deactivate: \'");
            EndContext();
            BeginContext(1191, 23, false);
#line 30 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\Parameters\ECA_05_00.cshtml"
                  Write(Localizer["Deactivate"]);

#line default
#line hidden
            EndContext();
            BeginContext(1214, 25, true);
            WriteLiteral("\',\r\n          Activate: \'");
            EndContext();
            BeginContext(1240, 21, false);
#line 31 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\Parameters\ECA_05_00.cshtml"
                Write(Localizer["Activate"]);

#line default
#line hidden
            EndContext();
            BeginContext(1261, 23, true);
            WriteLiteral("\',\r\n          Delete: \'");
            EndContext();
            BeginContext(1285, 19, false);
#line 32 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\Parameters\ECA_05_00.cshtml"
              Write(Localizer["Delete"]);

#line default
#line hidden
            EndContext();
            BeginContext(1304, 21, true);
            WriteLiteral("\',\r\n          Edit: \'");
            EndContext();
            BeginContext(1326, 17, false);
#line 33 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\Parameters\ECA_05_00.cshtml"
            Write(Localizer["Edit"]);

#line default
#line hidden
            EndContext();
            BeginContext(1343, 21, true);
            WriteLiteral("\',\r\n          View: \'");
            EndContext();
            BeginContext(1365, 17, false);
#line 34 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\Parameters\ECA_05_00.cshtml"
            Write(Localizer["View"]);

#line default
#line hidden
            EndContext();
            BeginContext(1382, 25, true);
            WriteLiteral("\',\r\n    };\r\n</script>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1424, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1430, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63454bed22c8665089cca96abef13c3da9f4ef7e12795", async() => {
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
                BeginContext(1479, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(1484, 697, true);
            WriteLiteral(@"
<div class=""row padbot10"">
    <div class=""col-lg-12 col-md-12 col-sm-12"">
        <div class=""ParametersContainer"">
            <table id=""jqgParametersHeader""></table>
            <div id=""jqpParametersHeader""></div>
        </div>
    </div>
</div>

<div class=""modal fade in"" id=""PopupParametersHeader"" data-keyboard=""false"" data-backdrop=""static"">
    <div class=""modal-dialog modal-md"" role=""document"" style=""box-shadow:none;"">
        <div class=""modal-content "">
            <div class=""modal-header popupHeader"">
                <button type=""button"" class=""close ml-auto"" data-dismiss=""modal""> <i class=""fa fa-times""></i></button>
                <h4 class=""modal-title"">");
            EndContext();
            BeginContext(2182, 29, false);
#line 56 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\Parameters\ECA_05_00.cshtml"
                                   Write(Localizer["AddParameterType"]);

#line default
#line hidden
            EndContext();
            BeginContext(2211, 318, true);
            WriteLiteral(@"</h4>
            </div>
            <div class=""modal-body"">
                <div class=""row padbot4"">
                    <div class=""col-lg-4 col-md-4 col-sm-12 lblright"">
                        <div class=""form-group lblright"">
                            <label for=""txtParameterTypeId"" class=""text-right"">");
            EndContext();
            BeginContext(2530, 28, false);
#line 62 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\Parameters\ECA_05_00.cshtml"
                                                                          Write(Localizer["ParameterTypeID"]);

#line default
#line hidden
            EndContext();
            BeginContext(2558, 379, true);
            WriteLiteral(@" </label>
                            <input id=""txtParameterTypeId"" class=""form-control integerFormat"" maxlength=""5"" type=""text"" />
                        </div>
                    </div>
                    <div class=""col-lg-12 col-md-12 col-sm-12"">
                        <div class=""form-group"">
                            <label for=""txtParameterTypeDescription"">");
            EndContext();
            BeginContext(2938, 37, false);
#line 68 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\Parameters\ECA_05_00.cshtml"
                                                                Write(Localizer["ParameterTypeDescription"]);

#line default
#line hidden
            EndContext();
            BeginContext(2975, 621, true);
            WriteLiteral(@" </label>
                            <input id=""txtParameterTypeDescription"" class=""form-control"" maxlength=""50"" type=""text"" />
                        </div>
                    </div>
                    <div class=""col-lg-4  col-md-4 col-sm-12 col-xs-12"">
                        <div class=""default-checkbox single"">
                            <label class=""mdl-checkbox mdl-js-checkbox mdl-js-ripple-effect"" for=""chkPTActiveStatus"">
                                <input type=""checkbox"" id=""chkPTActiveStatus"" class=""mdl-checkbox__input"">
                                <span class=""mdl-checkbox__label"">");
            EndContext();
            BeginContext(3597, 19, false);
#line 76 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\Parameters\ECA_05_00.cshtml"
                                                             Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(3616, 501, true);
            WriteLiteral(@" </span>
                            </label>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""modal-footer"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <button class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent primary-button"" id=""btnSaveParametersType"" onclick=""fnSaveParameterType();"">
                            ");
            EndContext();
            BeginContext(4118, 17, false);
#line 86 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\Parameters\ECA_05_00.cshtml"
                       Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(4135, 312, true);
            WriteLiteral(@"
                        </button>

                        <button type=""button"" class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect"" id=""btnDeactivateParametersType"" onclick=""fnDeleteParameterType();"">
                            <i class=""fas fa-ban""></i>
                            ");
            EndContext();
            BeginContext(4448, 23, false);
#line 91 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\Parameters\ECA_05_00.cshtml"
                       Write(Localizer["Deactivate"]);

#line default
#line hidden
            EndContext();
            BeginContext(4471, 270, true);
            WriteLiteral(@"
                        </button>

                        <button class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect  cancel-button cancel-button"" data-dismiss=""modal"" id=""#"" onclick=""fnClearParameterTypeFields()"">
                            ");
            EndContext();
            BeginContext(4742, 19, false);
#line 95 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\Parameters\ECA_05_00.cshtml"
                       Write(Localizer["Cancel"]);

#line default
#line hidden
            EndContext();
            BeginContext(4761, 578, true);
            WriteLiteral(@"
                        </button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""modal fullscreen fade in"" id=""PopupParameterDetail"" data-keyboard=""false"" data-backdrop=""static"">
    <div class=""modal-dialog modal-lg"" role=""document"" style=""box-shadow:none;"">
        <input type=""text"" id=""txtParameterType"" style=""display:none"" />
        <div class=""modal-content"">
            <!-- Modal Header -->
            <div class=""modal-header popupHeader"">
                <h4 class=""modal-title"">");
            EndContext();
            BeginContext(5340, 23, false);
#line 110 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\Parameters\ECA_05_00.cshtml"
                                   Write(Localizer["Parameters"]);

#line default
#line hidden
            EndContext();
            BeginContext(5363, 362, true);
            WriteLiteral(@"  </h4>
                <button type=""button"" class=""close ml-auto"" data-dismiss=""modal""> <i class=""fa fa-times""></i></button>
            </div>
            <!-- Modal body -->
            <div class=""modal-body"">
                <div class=""row"">
                    <div class=""col-lg-6 col-md-6 col-sm-6 col-xs-12 form-group"">
                        ");
            EndContext();
            BeginContext(5726, 26, false);
#line 117 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\Parameters\ECA_05_00.cshtml"
                   Write(Localizer["ParameterType"]);

#line default
#line hidden
            EndContext();
            BeginContext(5752, 613, true);
            WriteLiteral(@"  :  <span id=""lblParameterType"" class=""fixedText""></span>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-lg-12 form-group"">
                        <table id=""jqgParameters""></table>
                        <div id=""jqpParameters""></div>
                    </div>
                </div>
                <div class=""row padbot4"" id=""divParameters"">
                    <div class=""col-lg-12 col-md-12 col-sm-12 collapse"">
                        <div class=""form-group"">
                            <label for=""txtParameterId"">");
            EndContext();
            BeginContext(6366, 24, false);
#line 129 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\Parameters\ECA_05_00.cshtml"
                                                   Write(Localizer["ParameterID"]);

#line default
#line hidden
            EndContext();
            BeginContext(6390, 355, true);
            WriteLiteral(@" </label>
                            <input id=""txtParameterId"" class=""form-control"" maxlength=""10"" type=""text"" />
                        </div>
                    </div>
                    <div class=""col-lg-9 col-md-9 col-sm-9"">
                        <div class=""form-group"">
                            <label for=""txtParameterDescription"">");
            EndContext();
            BeginContext(6746, 33, false);
#line 135 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\Parameters\ECA_05_00.cshtml"
                                                            Write(Localizer["ParameterDescription"]);

#line default
#line hidden
            EndContext();
            BeginContext(6779, 355, true);
            WriteLiteral(@" </label>
                            <input id=""txtParameterDescription"" class=""form-control"" maxlength=""50"" type=""text"" />
                        </div>
                    </div>
                    <div class=""col-lg-3 col-md-3 col-sm-12"">
                        <div class=""form-group"">
                            <label class=""lable-color"">");
            EndContext();
            BeginContext(7135, 22, false);
#line 141 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\Parameters\ECA_05_00.cshtml"
                                                  Write(Localizer["ValueType"]);

#line default
#line hidden
            EndContext();
            BeginContext(7157, 1101, true);
            WriteLiteral(@" </label>
                            <div>
                                <select class=""selectpicker"" data-live-search=""false"" id=""cboParameterValueType"" title="""">
                                    <option value=""A"">Amount</option>
                                    <option value=""B"">Boolean</option>
                                    <option value=""D"">Description</option>
                                    <option value=""P"">Percentage</option>
                                    <option value=""V"">Value</option>
                                </select>
                            </div>
                        </div>
                    </div>

                    <div class=""col-lg-4  col-md-4 col-sm-12 col-xs-12"">
                        <div class=""default-checkbox single"">
                            <label class=""mdl-checkbox mdl-js-checkbox mdl-js-ripple-effect"" for=""chkActiveStatus"">
                                <input type=""checkbox"" id=""chkActiveStatus"" class=""mdl-checkbox");
            WriteLiteral("__input\">\r\n                                <span class=\"mdl-checkbox__label\">");
            EndContext();
            BeginContext(8259, 19, false);
#line 158 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\Parameters\ECA_05_00.cshtml"
                                                             Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(8278, 516, true);
            WriteLiteral(@" </span>
                            </label>
                        </div>
                    </div>

                </div>
            </div>
            <div class=""modal-footer"">
                <div class=""row"">
                    <div class=""col-lg-12 text-center"">

                        <button class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent primary-button mr-10"" id=""btnSaveParameters"" onclick=""fnSaveParameters();"">
                            ");
            EndContext();
            BeginContext(8795, 17, false);
#line 170 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\Parameters\ECA_05_00.cshtml"
                       Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(8812, 255, true);
            WriteLiteral("\r\n                        </button>\r\n                        <button class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect  cancel-button cancel-button\" data-dismiss=\"modal\" id=\"#\" onclick=\"fnClearFields()\">\r\n                            ");
            EndContext();
            BeginContext(9068, 19, false);
#line 173 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\Parameters\ECA_05_00.cshtml"
                       Write(Localizer["Cancel"]);

#line default
#line hidden
            EndContext();
            BeginContext(9087, 153, true);
            WriteLiteral("\r\n                        </button>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n");
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