#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\Activities\V_ENC_16_00.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "058cfa790afb0489a1d72eeec3fd88d24b053086"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_eSyaNatureCure_Views_Activities_V_ENC_16_00), @"mvc.1.0.view", @"/Areas/eSyaNatureCure/Views/Activities/V_ENC_16_00.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/eSyaNatureCure/Views/Activities/V_ENC_16_00.cshtml", typeof(AspNetCore.Areas_eSyaNatureCure_Views_Activities_V_ENC_16_00))]
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
#line 1 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\Activities\V_ENC_16_00.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"058cfa790afb0489a1d72eeec3fd88d24b053086", @"/Areas/eSyaNatureCure/Views/Activities/V_ENC_16_00.cshtml")]
    public class Areas_eSyaNatureCure_Views_Activities_V_ENC_16_00 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/eSyaNatureCure/Activities.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\Activities\V_ENC_16_00.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(172, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "058cfa790afb0489a1d72eeec3fd88d24b0530863920", async() => {
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
            BeginContext(229, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 10 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\Activities\V_ENC_16_00.cshtml"
  
    var userFormRole = (eSyaEnterprise_UI.Models.DO_UserFormRole)ViewBag.UserFormRole;

#line default
#line hidden
            BeginContext(326, 46, true);
            WriteLiteral("<script>\r\n    var _userFormRole = JSON.parse(\'");
            EndContext();
            BeginContext(373, 38, false);
#line 14 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\Activities\V_ENC_16_00.cshtml"
                               Write(Html.Raw(Json.Serialize(userFormRole)));

#line default
#line hidden
            EndContext();
            BeginContext(411, 56, true);
            WriteLiteral("\');\r\n\r\n     var localization = {\r\n         ActivityId: \'");
            EndContext();
            BeginContext(468, 23, false);
#line 17 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\Activities\V_ENC_16_00.cshtml"
                 Write(Localizer["ActivityId"]);

#line default
#line hidden
            EndContext();
            BeginContext(491, 35, true);
            WriteLiteral("\',\r\n         ActivityDescription: \'");
            EndContext();
            BeginContext(527, 32, false);
#line 18 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\Activities\V_ENC_16_00.cshtml"
                          Write(Localizer["ActivityDescription"]);

#line default
#line hidden
            EndContext();
            BeginContext(559, 28, true);
            WriteLiteral("\',\r\n         ScheduleType: \'");
            EndContext();
            BeginContext(588, 25, false);
#line 19 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\Activities\V_ENC_16_00.cshtml"
                   Write(Localizer["ScheduleType"]);

#line default
#line hidden
            EndContext();
            BeginContext(613, 22, true);
            WriteLiteral("\',\r\n         Active: \'");
            EndContext();
            BeginContext(636, 19, false);
#line 20 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\Activities\V_ENC_16_00.cshtml"
             Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(655, 29, true);
            WriteLiteral("\',\r\n         AddActivities: \'");
            EndContext();
            BeginContext(685, 26, false);
#line 21 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\Activities\V_ENC_16_00.cshtml"
                    Write(Localizer["AddActivities"]);

#line default
#line hidden
            EndContext();
            BeginContext(711, 32, true);
            WriteLiteral("\',\r\n         UpdateActivities: \'");
            EndContext();
            BeginContext(744, 29, false);
#line 22 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\Activities\V_ENC_16_00.cshtml"
                       Write(Localizer["UpdateActivities"]);

#line default
#line hidden
            EndContext();
            BeginContext(773, 30, true);
            WriteLiteral("\',\r\n         ViewActivities: \'");
            EndContext();
            BeginContext(804, 27, false);
#line 23 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\Activities\V_ENC_16_00.cshtml"
                     Write(Localizer["ViewActivities"]);

#line default
#line hidden
            EndContext();
            BeginContext(831, 23, true);
            WriteLiteral("\',\r\n         Actions: \'");
            EndContext();
            BeginContext(855, 20, false);
#line 24 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\Activities\V_ENC_16_00.cshtml"
              Write(Localizer["Actions"]);

#line default
#line hidden
            EndContext();
            BeginContext(875, 20, true);
            WriteLiteral("\',\r\n         Edit: \'");
            EndContext();
            BeginContext(896, 17, false);
#line 25 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\Activities\V_ENC_16_00.cshtml"
           Write(Localizer["Edit"]);

#line default
#line hidden
            EndContext();
            BeginContext(913, 20, true);
            WriteLiteral("\',\r\n         View: \'");
            EndContext();
            BeginContext(934, 17, false);
#line 26 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\Activities\V_ENC_16_00.cshtml"
           Write(Localizer["View"]);

#line default
#line hidden
            EndContext();
            BeginContext(951, 20, true);
            WriteLiteral("\',\r\n         Save: \'");
            EndContext();
            BeginContext(972, 17, false);
#line 27 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\Activities\V_ENC_16_00.cshtml"
           Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(989, 22, true);
            WriteLiteral("\',\r\n         Update: \'");
            EndContext();
            BeginContext(1012, 19, false);
#line 28 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\Activities\V_ENC_16_00.cshtml"
             Write(Localizer["Update"]);

#line default
#line hidden
            EndContext();
            BeginContext(1031, 22, true);
            WriteLiteral("\',\r\n         Delete: \'");
            EndContext();
            BeginContext(1054, 19, false);
#line 29 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\Activities\V_ENC_16_00.cshtml"
             Write(Localizer["Delete"]);

#line default
#line hidden
            EndContext();
            BeginContext(1073, 24, true);
            WriteLiteral("\',\r\n         Activate: \'");
            EndContext();
            BeginContext(1098, 21, false);
#line 30 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\Activities\V_ENC_16_00.cshtml"
               Write(Localizer["Activate"]);

#line default
#line hidden
            EndContext();
            BeginContext(1119, 25, true);
            WriteLiteral("\',\r\n         DActivate: \'");
            EndContext();
            BeginContext(1145, 22, false);
#line 31 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\Activities\V_ENC_16_00.cshtml"
                Write(Localizer["DActivate"]);

#line default
#line hidden
            EndContext();
            BeginContext(1167, 661, true);
            WriteLiteral(@"',
    };

</script>


<div class=""row padbot10"">
    <div class=""col-lg-12 col-md-12 col-sm-12 Activitiescontainer"">
        <table id=""jqgActivities""></table>
        <div id=""jqpActivities""></div>
    </div>
</div>

<div class=""modal fade in"" id=""PopupActivities"" data-keyboard=""false"" data-backdrop=""static"">
    <div class=""modal-dialog modal-md  "" role=""document"" style=""box-shadow:none;"">
        <div class=""modal-content "">
            <div class=""modal-header popupHeader"">
                <button type=""button"" class=""close ml-auto"" data-dismiss=""modal""> <i class=""fa fa-times""></i></button>
                <h4 class=""modal-title"">");
            EndContext();
            BeginContext(1829, 24, false);
#line 49 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\Activities\V_ENC_16_00.cshtml"
                                   Write(Localizer["AddActivity"]);

#line default
#line hidden
            EndContext();
            BeginContext(1853, 464, true);
            WriteLiteral(@"</h4>
            </div>

            <div class=""modal-body"">
                
                <div class=""row padbot4"">

                    <div class=""col-sm-12"">
                        <input type=""text"" class=""form-control"" id=""txtActivityId"" style=""display:none"">
                    </div>

                    <div class=""col-lg-12"">
                        <div class=""form-group"">
                            <label for=""txtActivitydesc""> ");
            EndContext();
            BeginContext(2318, 32, false);
#line 62 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\Activities\V_ENC_16_00.cshtml"
                                                     Write(Localizer["ActivityDescription"]);

#line default
#line hidden
            EndContext();
            BeginContext(2350, 398, true);
            WriteLiteral(@"</label>
                            <input id=""txtActivitydesc"" class=""form-control"" maxlength=""50"" type=""text"" />

                        </div>
                    </div>
                    <div class=""col-lg-4  col-md-4 col-sm-12 col-xs-12"">
                        <div class=""form-group"">
                            <div>
                                <label class=""lable-color"">");
            EndContext();
            BeginContext(2749, 25, false);
#line 70 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\Activities\V_ENC_16_00.cshtml"
                                                      Write(Localizer["ScheduleType"]);

#line default
#line hidden
            EndContext();
            BeginContext(2774, 185, true);
            WriteLiteral(" </label>\r\n                                <select class=\"selectpicker\" data-live-search=\"false\" id=\"cboScheduleType\" title=\"\">\r\n\r\n                                    <option value=\"F\">");
            EndContext();
            BeginContext(2960, 18, false);
#line 73 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\Activities\V_ENC_16_00.cshtml"
                                                 Write(Localizer["Fixed"]);

#line default
#line hidden
            EndContext();
            BeginContext(2978, 65, true);
            WriteLiteral("</option>\r\n                                    <option value=\"C\">");
            EndContext();
            BeginContext(3044, 19, false);
#line 74 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\Activities\V_ENC_16_00.cshtml"
                                                 Write(Localizer["Change"]);

#line default
#line hidden
            EndContext();
            BeginContext(3063, 569, true);
            WriteLiteral(@"</option>
                                </select>
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-3  col-md-3 col-sm-12 col-xs-12"">
                        <div class=""default-checkbox"">
                            <label class=""mdl-checkbox mdl-js-checkbox mdl-js-ripple-effect"" for=""chkActiveStatus"">
                                <input type=""checkbox"" id=""chkActiveStatus"" class=""mdl-checkbox__input"">
                                <span class=""mdl-checkbox__label"">");
            EndContext();
            BeginContext(3633, 19, false);
#line 83 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\Activities\V_ENC_16_00.cshtml"
                                                             Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(3652, 520, true);
            WriteLiteral(@"</span>
                            </label>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""modal-footer"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <button class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent primary-button"" id=""btnSaveACtivities"" onclick=""fnSaveActivities();"">
                            <i class=""fa fa-save""></i> ");
            EndContext();
            BeginContext(4173, 17, false);
#line 93 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\Activities\V_ENC_16_00.cshtml"
                                                  Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(4190, 245, true);
            WriteLiteral("\r\n                        </button>\r\n                        <button class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect  cancel-button cancel-button\" data-dismiss=\"modal\" id=\"btnCancelActivities\"><i class=\"fa fa-times\"></i> ");
            EndContext();
            BeginContext(4436, 19, false);
#line 95 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\Activities\V_ENC_16_00.cshtml"
                                                                                                                                                                                                           Write(Localizer["Cancel"]);

#line default
#line hidden
            EndContext();
            BeginContext(4455, 204, true);
            WriteLiteral(" </button>\r\n                        <button class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect\" id=\"btndeActiveActivities\" onclick=\"fnDeleteActivities();\"><i class=\"fa fa-times\"></i> ");
            EndContext();
            BeginContext(4660, 23, false);
#line 96 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\Activities\V_ENC_16_00.cshtml"
                                                                                                                                                                                           Write(Localizer["DeActivate"]);

#line default
#line hidden
            EndContext();
            BeginContext(4683, 142, true);
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