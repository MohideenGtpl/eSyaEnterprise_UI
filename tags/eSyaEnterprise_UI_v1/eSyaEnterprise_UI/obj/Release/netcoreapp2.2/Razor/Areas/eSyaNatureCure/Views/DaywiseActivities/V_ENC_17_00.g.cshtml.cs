#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\DaywiseActivities\V_ENC_17_00.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06c5933dc502dfcf81aac2639807a9f8c9428ac2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_eSyaNatureCure_Views_DaywiseActivities_V_ENC_17_00), @"mvc.1.0.view", @"/Areas/eSyaNatureCure/Views/DaywiseActivities/V_ENC_17_00.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/eSyaNatureCure/Views/DaywiseActivities/V_ENC_17_00.cshtml", typeof(AspNetCore.Areas_eSyaNatureCure_Views_DaywiseActivities_V_ENC_17_00))]
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
#line 2 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\DaywiseActivities\V_ENC_17_00.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06c5933dc502dfcf81aac2639807a9f8c9428ac2", @"/Areas/eSyaNatureCure/Views/DaywiseActivities/V_ENC_17_00.cshtml")]
    public class Areas_eSyaNatureCure_Views_DaywiseActivities_V_ENC_17_00 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/eSyaNatureCure/DaywiseActivities.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(84, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\DaywiseActivities\V_ENC_17_00.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(174, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06c5933dc502dfcf81aac2639807a9f8c9428ac24091", async() => {
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
            BeginContext(238, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 11 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\DaywiseActivities\V_ENC_17_00.cshtml"
  
    var userFormRole = (eSyaEnterprise_UI.Models.DO_UserFormRole)ViewBag.UserFormRole;

#line default
#line hidden
            BeginContext(335, 46, true);
            WriteLiteral("<script>\r\n    var _userFormRole = JSON.parse(\'");
            EndContext();
            BeginContext(382, 38, false);
#line 15 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\DaywiseActivities\V_ENC_17_00.cshtml"
                               Write(Html.Raw(Json.Serialize(userFormRole)));

#line default
#line hidden
            EndContext();
            BeginContext(420, 64, true);
            WriteLiteral("\');\r\n\r\n     var localization = {\r\n         AddDaywiseActivity: \'");
            EndContext();
            BeginContext(485, 31, false);
#line 18 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\DaywiseActivities\V_ENC_17_00.cshtml"
                         Write(Localizer["AddDaywiseActivity"]);

#line default
#line hidden
            EndContext();
            BeginContext(516, 23, true);
            WriteLiteral("\',\r\n         Package: \'");
            EndContext();
            BeginContext(540, 20, false);
#line 19 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\DaywiseActivities\V_ENC_17_00.cshtml"
              Write(Localizer["Package"]);

#line default
#line hidden
            EndContext();
            BeginContext(560, 21, true);
            WriteLiteral("\',\r\n         DayId: \'");
            EndContext();
            BeginContext(582, 18, false);
#line 20 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\DaywiseActivities\V_ENC_17_00.cshtml"
            Write(Localizer["DayId"]);

#line default
#line hidden
            EndContext();
            BeginContext(600, 23, true);
            WriteLiteral("\',\r\n         Activity:\'");
            EndContext();
            BeginContext(624, 21, false);
#line 21 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\DaywiseActivities\V_ENC_17_00.cshtml"
              Write(Localizer["Activity"]);

#line default
#line hidden
            EndContext();
            BeginContext(645, 24, true);
            WriteLiteral("\',\r\n         FromTime: \'");
            EndContext();
            BeginContext(670, 21, false);
#line 22 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\DaywiseActivities\V_ENC_17_00.cshtml"
               Write(Localizer["FromTime"]);

#line default
#line hidden
            EndContext();
            BeginContext(691, 22, true);
            WriteLiteral("\',\r\n         ToTime: \'");
            EndContext();
            BeginContext(714, 19, false);
#line 23 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\DaywiseActivities\V_ENC_17_00.cshtml"
             Write(Localizer["ToTime"]);

#line default
#line hidden
            EndContext();
            BeginContext(733, 25, true);
            WriteLiteral("\',\r\n         PackageId: \'");
            EndContext();
            BeginContext(759, 22, false);
#line 24 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\DaywiseActivities\V_ENC_17_00.cshtml"
                Write(Localizer["PackageId"]);

#line default
#line hidden
            EndContext();
            BeginContext(781, 21, true);
            WriteLiteral("\',\r\n         DayId: \'");
            EndContext();
            BeginContext(803, 18, false);
#line 25 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\DaywiseActivities\V_ENC_17_00.cshtml"
            Write(Localizer["DayId"]);

#line default
#line hidden
            EndContext();
            BeginContext(821, 34, true);
            WriteLiteral("\',\r\n         PackageDescription: \'");
            EndContext();
            BeginContext(856, 31, false);
#line 26 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\DaywiseActivities\V_ENC_17_00.cshtml"
                         Write(Localizer["PackageDescription"]);

#line default
#line hidden
            EndContext();
            BeginContext(887, 22, true);
            WriteLiteral("\',\r\n         Active: \'");
            EndContext();
            BeginContext(910, 19, false);
#line 27 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\DaywiseActivities\V_ENC_17_00.cshtml"
             Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(929, 26, true);
            WriteLiteral("\',\r\n         ActivityId: \'");
            EndContext();
            BeginContext(956, 23, false);
#line 28 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\DaywiseActivities\V_ENC_17_00.cshtml"
                 Write(Localizer["ActivityId"]);

#line default
#line hidden
            EndContext();
            BeginContext(979, 35, true);
            WriteLiteral("\',\r\n         ActivityDescription: \'");
            EndContext();
            BeginContext(1015, 32, false);
#line 29 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\DaywiseActivities\V_ENC_17_00.cshtml"
                          Write(Localizer["ActivityDescription"]);

#line default
#line hidden
            EndContext();
            BeginContext(1047, 24, true);
            WriteLiteral("\',\r\n         FromTime: \'");
            EndContext();
            BeginContext(1072, 21, false);
#line 30 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\DaywiseActivities\V_ENC_17_00.cshtml"
               Write(Localizer["FromTime"]);

#line default
#line hidden
            EndContext();
            BeginContext(1093, 22, true);
            WriteLiteral("\',\r\n         ToTime: \'");
            EndContext();
            BeginContext(1116, 19, false);
#line 31 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\DaywiseActivities\V_ENC_17_00.cshtml"
             Write(Localizer["ToTime"]);

#line default
#line hidden
            EndContext();
            BeginContext(1135, 23, true);
            WriteLiteral("\',\r\n         Actions: \'");
            EndContext();
            BeginContext(1159, 20, false);
#line 32 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\DaywiseActivities\V_ENC_17_00.cshtml"
              Write(Localizer["Actions"]);

#line default
#line hidden
            EndContext();
            BeginContext(1179, 20, true);
            WriteLiteral("\',\r\n         Edit: \'");
            EndContext();
            BeginContext(1200, 17, false);
#line 33 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\DaywiseActivities\V_ENC_17_00.cshtml"
           Write(Localizer["Edit"]);

#line default
#line hidden
            EndContext();
            BeginContext(1217, 20, true);
            WriteLiteral("\',\r\n         View: \'");
            EndContext();
            BeginContext(1238, 17, false);
#line 34 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\DaywiseActivities\V_ENC_17_00.cshtml"
           Write(Localizer["View"]);

#line default
#line hidden
            EndContext();
            BeginContext(1255, 20, true);
            WriteLiteral("\',\r\n         Save: \'");
            EndContext();
            BeginContext(1276, 17, false);
#line 35 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\DaywiseActivities\V_ENC_17_00.cshtml"
           Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(1293, 22, true);
            WriteLiteral("\',\r\n         Update: \'");
            EndContext();
            BeginContext(1316, 19, false);
#line 36 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\DaywiseActivities\V_ENC_17_00.cshtml"
             Write(Localizer["Update"]);

#line default
#line hidden
            EndContext();
            BeginContext(1335, 22, true);
            WriteLiteral("\',\r\n         Delete: \'");
            EndContext();
            BeginContext(1358, 19, false);
#line 37 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\DaywiseActivities\V_ENC_17_00.cshtml"
             Write(Localizer["Delete"]);

#line default
#line hidden
            EndContext();
            BeginContext(1377, 24, true);
            WriteLiteral("\',\r\n         Activate: \'");
            EndContext();
            BeginContext(1402, 21, false);
#line 38 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\DaywiseActivities\V_ENC_17_00.cshtml"
               Write(Localizer["Activate"]);

#line default
#line hidden
            EndContext();
            BeginContext(1423, 25, true);
            WriteLiteral("\',\r\n         DActivate: \'");
            EndContext();
            BeginContext(1449, 22, false);
#line 39 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\DaywiseActivities\V_ENC_17_00.cshtml"
                Write(Localizer["DActivate"]);

#line default
#line hidden
            EndContext();
            BeginContext(1471, 34, true);
            WriteLiteral("\',\r\n         AddDaywiseActivity: \'");
            EndContext();
            BeginContext(1506, 31, false);
#line 40 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\DaywiseActivities\V_ENC_17_00.cshtml"
                         Write(Localizer["AddDaywiseActivity"]);

#line default
#line hidden
            EndContext();
            BeginContext(1537, 37, true);
            WriteLiteral("\',\r\n         UpdateDaywiseActivity: \'");
            EndContext();
            BeginContext(1575, 34, false);
#line 41 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\DaywiseActivities\V_ENC_17_00.cshtml"
                            Write(Localizer["UpdateDaywiseActivity"]);

#line default
#line hidden
            EndContext();
            BeginContext(1609, 35, true);
            WriteLiteral("\',\r\n         ViewDaywiseActivity: \'");
            EndContext();
            BeginContext(1645, 32, false);
#line 42 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\DaywiseActivities\V_ENC_17_00.cshtml"
                          Write(Localizer["ViewDaywiseActivity"]);

#line default
#line hidden
            EndContext();
            BeginContext(1677, 249, true);
            WriteLiteral("\',\r\n    };\r\n\r\n</script>\r\n<style>\r\n    .bootstrap-select {\r\n        width: 100% !important;\r\n    }\r\n</style>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-lg-4 col-md-4 col-sm-6\">\r\n        <div class=\"form-group\">\r\n            <label class=\"lable-color\">");
            EndContext();
            BeginContext(1927, 20, false);
#line 55 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\DaywiseActivities\V_ENC_17_00.cshtml"
                                  Write(Localizer["Package"]);

#line default
#line hidden
            EndContext();
            BeginContext(1947, 210, true);
            WriteLiteral(" </label>\r\n            <select class=\"selectpicker\" data-live-search=\"true\" id=\"cboPackageId\" title=\"\" onchange=\"fnGridLoadDaywiseActivities()\" data-size=\"10\">\r\n                <option value=\"0\"> All</option>\r\n");
            EndContext();
#line 58 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\DaywiseActivities\V_ENC_17_00.cshtml"
                 if (ViewBag.package != null)
                {
                    foreach (var pkg in ViewBag.package)
                    {

#line default
#line hidden
            BeginContext(2304, 23, true);
            WriteLiteral("                <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2327, "\"", 2349, 1);
#line 62 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\DaywiseActivities\V_ENC_17_00.cshtml"
WriteAttributeValue("", 2335, pkg.PackageId, 2335, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2350, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2352, 15, false);
#line 62 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\DaywiseActivities\V_ENC_17_00.cshtml"
                                          Write(pkg.PackageDesc);

#line default
#line hidden
            EndContext();
            BeginContext(2367, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 63 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\DaywiseActivities\V_ENC_17_00.cshtml"
                    }

                }

#line default
#line hidden
            BeginContext(2422, 721, true);
            WriteLiteral(@"            </select>
        </div>
    </div>
</div>

<div class=""row padbot10"">
    <div class=""col-lg-12 col-md-12 col-sm-12 DaywiseActivitiescontainer"">
        <table id=""jqgDaywiseActivities""></table>
        <div id=""jqpDaywiseActivities""></div>
    </div>
</div>

<div class=""modal fade in"" id=""PopupDaywiseActivities"" data-keyboard=""false"" data-backdrop=""static"">
    <div class=""modal-dialog modal-md  "" role=""document"" style=""box-shadow:none;"">
        <div class=""modal-content "">
            <div class=""modal-header popupHeader"">
                <button type=""button"" class=""close ml-auto"" data-dismiss=""modal""> <i class=""fa fa-times""></i></button>
                <h4 class=""modal-title"">");
            EndContext();
            BeginContext(3144, 31, false);
#line 83 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\DaywiseActivities\V_ENC_17_00.cshtml"
                                   Write(Localizer["AddDaywiseActivity"]);

#line default
#line hidden
            EndContext();
            BeginContext(3175, 470, true);
            WriteLiteral(@"</h4>
            </div>

            <div class=""modal-body"">

                <div class=""row padbot4"">

                    <div class=""col-sm-12"">
                        <input type=""text"" class=""form-control"" id=""txtActivityId"" style=""display:none"">
                    </div>

                    <div class=""col-lg-6  col-md-6 col-sm-12 col-xs-12"">
                        <div class=""form-group"">
                            <label for=""txtDayId""> ");
            EndContext();
            BeginContext(3646, 18, false);
#line 96 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\DaywiseActivities\V_ENC_17_00.cshtml"
                                              Write(Localizer["DayId"]);

#line default
#line hidden
            EndContext();
            BeginContext(3664, 451, true);
            WriteLiteral(@"</label>
                            <input id=""txtDayId"" class=""form-control"" maxlength=""9"" type=""text"" data-inputmask=""'mask': '9', 'repeat': 10, 'greedy' : false"" />

                        </div>
                    </div>
                    <div class=""col-lg-6  col-md-6 col-sm-12 col-xs-12"">
                        <div class=""form-group"">
                            <div>
                                <label class=""lable-color"">");
            EndContext();
            BeginContext(4116, 21, false);
#line 104 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\DaywiseActivities\V_ENC_17_00.cshtml"
                                                      Write(Localizer["Activity"]);

#line default
#line hidden
            EndContext();
            BeginContext(4137, 211, true);
            WriteLiteral(" </label>\r\n                                <select class=\"selectpicker\" data-live-search=\"true\" id=\"cboActivity\" title=\"\" data-size=\"10\">\r\n                                    <option value=\"0\"> Select</option>\r\n");
            EndContext();
#line 107 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\DaywiseActivities\V_ENC_17_00.cshtml"
                                     if (ViewBag.activity != null)
                                     {
                                       foreach (var pkg in ViewBag.activity)
                                       {

#line default
#line hidden
            BeginContext(4576, 43, true);
            WriteLiteral("                                    <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4619, "\"", 4642, 1);
#line 111 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\DaywiseActivities\V_ENC_17_00.cshtml"
WriteAttributeValue("", 4627, pkg.ActivityId, 4627, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4643, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(4645, 16, false);
#line 111 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\DaywiseActivities\V_ENC_17_00.cshtml"
                                                               Write(pkg.ActivityDesc);

#line default
#line hidden
            EndContext();
            BeginContext(4661, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 112 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\DaywiseActivities\V_ENC_17_00.cshtml"
                                       }

                                      }

#line default
#line hidden
            BeginContext(4757, 302, true);
            WriteLiteral(@"                                </select>
                            </div>
                        </div>
                    </div>

                    <div class=""col-lg-6  col-md-6 col-sm-12 col-xs-12"">
                        <div class=""form-group"">
                            <label>  ");
            EndContext();
            BeginContext(5060, 21, false);
#line 122 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\DaywiseActivities\V_ENC_17_00.cshtml"
                                Write(Localizer["FromTime"]);

#line default
#line hidden
            EndContext();
            BeginContext(5081, 341, true);
            WriteLiteral(@"</label>
                            <input id=""txtFromTime"" class=""form-control"" type=""time"" autocomplete=""off"" />

                        </div>
                    </div>
                    <div class=""col-lg-6  col-md-6 col-sm-12 col-xs-12"">
                        <div class=""form-group"">
                            <label>  ");
            EndContext();
            BeginContext(5423, 19, false);
#line 129 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\DaywiseActivities\V_ENC_17_00.cshtml"
                                Write(Localizer["ToTime"]);

#line default
#line hidden
            EndContext();
            BeginContext(5442, 599, true);
            WriteLiteral(@"</label>
                            <input id=""txtToTime"" class=""form-control"" type=""time"" autocomplete=""off"" />

                        </div>
                    </div>

                    <div class=""col-lg-3  col-md-3 col-sm-12 col-xs-12"">
                        <div class=""default-checkbox"">
                            <label class=""mdl-checkbox mdl-js-checkbox mdl-js-ripple-effect"" for=""chkActiveStatus"">
                                <input type=""checkbox"" id=""chkActiveStatus"" class=""mdl-checkbox__input"">
                                <span class=""mdl-checkbox__label"">");
            EndContext();
            BeginContext(6042, 19, false);
#line 139 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\DaywiseActivities\V_ENC_17_00.cshtml"
                                                             Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(6061, 534, true);
            WriteLiteral(@"</span>
                            </label>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""modal-footer"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <button class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent primary-button"" id=""btnSaveDaywiseActivities"" onclick=""fnSaveDaywiseActivities();"">
                            <i class=""fa fa-save""></i> ");
            EndContext();
            BeginContext(6596, 17, false);
#line 149 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\DaywiseActivities\V_ENC_17_00.cshtml"
                                                  Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(6613, 252, true);
            WriteLiteral("\r\n                        </button>\r\n                        <button class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect  cancel-button cancel-button\" data-dismiss=\"modal\" id=\"btnCancelDaywiseActivities\"><i class=\"fa fa-times\"></i> ");
            EndContext();
            BeginContext(6866, 19, false);
#line 151 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\DaywiseActivities\V_ENC_17_00.cshtml"
                                                                                                                                                                                                                  Write(Localizer["Cancel"]);

#line default
#line hidden
            EndContext();
            BeginContext(6885, 218, true);
            WriteLiteral(" </button>\r\n                        <button class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect\" id=\"btndeActiveDaywiseActivities\" onclick=\"fnDeleteDaywiseActivities();\"><i class=\"fa fa-times\"></i> ");
            EndContext();
            BeginContext(7104, 23, false);
#line 152 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\DaywiseActivities\V_ENC_17_00.cshtml"
                                                                                                                                                                                                         Write(Localizer["DeActivate"]);

#line default
#line hidden
            EndContext();
            BeginContext(7127, 142, true);
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
