#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Controller\ELE_3_00.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52871214c3e8f62aa6b68b66c6c01aac7185da18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Localize_Views_Controller_ELE_3_00), @"mvc.1.0.view", @"/Areas/Localize/Views/Controller/ELE_3_00.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Localize/Views/Controller/ELE_3_00.cshtml", typeof(AspNetCore.Areas_Localize_Views_Controller_ELE_3_00))]
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
#line 2 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Controller\ELE_3_00.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52871214c3e8f62aa6b68b66c6c01aac7185da18", @"/Areas/Localize/Views/Controller/ELE_3_00.cshtml")]
    public class Areas_Localize_Views_Controller_ELE_3_00 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Localize/LanguageController.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "All", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(136, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 7 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Controller\ELE_3_00.cshtml"
  
    ViewData["Title"] = "ELE_3_00";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            DefineSection("scripts", async() => {
                BeginContext(248, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(254, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52871214c3e8f62aa6b68b66c6c01aac7185da184802", async() => {
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
                BeginContext(313, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
#line 14 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Controller\ELE_3_00.cshtml"
  
    var userFormRole = (eSyaEnterprise_UI.Models.DO_UserFormRole)ViewBag.UserFormRole;

#line default
#line hidden
            BeginContext(413, 46, true);
            WriteLiteral("<script>\r\n    var _userFormRole = JSON.parse(\'");
            EndContext();
            BeginContext(460, 38, false);
#line 18 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Controller\ELE_3_00.cshtml"
                               Write(Html.Raw(Json.Serialize(userFormRole)));

#line default
#line hidden
            EndContext();
            BeginContext(498, 58, true);
            WriteLiteral("\');\r\n\r\n     var localization = {\r\n         ResourceName: \'");
            EndContext();
            BeginContext(557, 25, false);
#line 21 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Controller\ELE_3_00.cshtml"
                   Write(Localizer["ResourceName"]);

#line default
#line hidden
            EndContext();
            BeginContext(582, 19, true);
            WriteLiteral("\',\r\n         Key: \'");
            EndContext();
            BeginContext(602, 16, false);
#line 22 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Controller\ELE_3_00.cshtml"
          Write(Localizer["Key"]);

#line default
#line hidden
            EndContext();
            BeginContext(618, 21, true);
            WriteLiteral("\',\r\n         Value: \'");
            EndContext();
            BeginContext(640, 18, false);
#line 23 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Controller\ELE_3_00.cshtml"
            Write(Localizer["Value"]);

#line default
#line hidden
            EndContext();
            BeginContext(658, 22, true);
            WriteLiteral("\',\r\n         Active: \'");
            EndContext();
            BeginContext(681, 19, false);
#line 24 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Controller\ELE_3_00.cshtml"
             Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(700, 23, true);
            WriteLiteral("\',\r\n         Actions: \'");
            EndContext();
            BeginContext(724, 20, false);
#line 25 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Controller\ELE_3_00.cshtml"
              Write(Localizer["Actions"]);

#line default
#line hidden
            EndContext();
            BeginContext(744, 20, true);
            WriteLiteral("\',\r\n         Edit: \'");
            EndContext();
            BeginContext(765, 17, false);
#line 26 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Controller\ELE_3_00.cshtml"
           Write(Localizer["Edit"]);

#line default
#line hidden
            EndContext();
            BeginContext(782, 20, true);
            WriteLiteral("\',\r\n         View: \'");
            EndContext();
            BeginContext(803, 17, false);
#line 27 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Controller\ELE_3_00.cshtml"
           Write(Localizer["View"]);

#line default
#line hidden
            EndContext();
            BeginContext(820, 20, true);
            WriteLiteral("\',\r\n         Save: \'");
            EndContext();
            BeginContext(841, 17, false);
#line 28 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Controller\ELE_3_00.cshtml"
           Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(858, 22, true);
            WriteLiteral("\',\r\n         Cancel: \'");
            EndContext();
            BeginContext(881, 19, false);
#line 29 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Controller\ELE_3_00.cshtml"
             Write(Localizer["Cancel"]);

#line default
#line hidden
            EndContext();
            BeginContext(900, 37, true);
            WriteLiteral("\',\r\n         AddLanguageController: \'");
            EndContext();
            BeginContext(938, 34, false);
#line 30 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Controller\ELE_3_00.cshtml"
                            Write(Localizer["AddLanguageController"]);

#line default
#line hidden
            EndContext();
            BeginContext(972, 40, true);
            WriteLiteral("\',\r\n         UpdateLanguageController: \'");
            EndContext();
            BeginContext(1013, 37, false);
#line 31 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Controller\ELE_3_00.cshtml"
                               Write(Localizer["UpdateLanguageController"]);

#line default
#line hidden
            EndContext();
            BeginContext(1050, 21, true);
            WriteLiteral("\',\r\n         Update:\'");
            EndContext();
            BeginContext(1072, 19, false);
#line 32 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Controller\ELE_3_00.cshtml"
            Write(Localizer["Update"]);

#line default
#line hidden
            EndContext();
            BeginContext(1091, 38, true);
            WriteLiteral("\',\r\n         ViewLanguageController: \'");
            EndContext();
            BeginContext(1130, 35, false);
#line 33 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Controller\ELE_3_00.cshtml"
                             Write(Localizer["ViewLanguageController"]);

#line default
#line hidden
            EndContext();
            BeginContext(1165, 22, true);
            WriteLiteral("\',\r\n         Delete: \'");
            EndContext();
            BeginContext(1188, 19, false);
#line 34 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Controller\ELE_3_00.cshtml"
             Write(Localizer["Delete"]);

#line default
#line hidden
            EndContext();
            BeginContext(1207, 26, true);
            WriteLiteral("\',\r\n         DeActivate: \'");
            EndContext();
            BeginContext(1234, 23, false);
#line 35 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Controller\ELE_3_00.cshtml"
                 Write(Localizer["DeActivate"]);

#line default
#line hidden
            EndContext();
            BeginContext(1257, 24, true);
            WriteLiteral("\',\r\n         Activate: \'");
            EndContext();
            BeginContext(1282, 21, false);
#line 36 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Controller\ELE_3_00.cshtml"
               Write(Localizer["Activate"]);

#line default
#line hidden
            EndContext();
            BeginContext(1303, 163, true);
            WriteLiteral("\',\r\n    };\r\n</script>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-lg-4 col-md-4 col-sm-6\">\r\n        <div class=\"form-group\">\r\n            <label class=\"lable-color\">");
            EndContext();
            BeginContext(1467, 25, false);
#line 43 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Controller\ELE_3_00.cshtml"
                                  Write(Localizer["ResourceName"]);

#line default
#line hidden
            EndContext();
            BeginContext(1492, 177, true);
            WriteLiteral(" </label>\r\n            <select class=\"selectpicker\" data-live-search=\"true\" id=\"cboResource\" title=\"\" onchange=\"fnGridLoadLanguageController()\" data-size=\"10\">\r\n                ");
            EndContext();
            BeginContext(1669, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52871214c3e8f62aa6b68b66c6c01aac7185da1814577", async() => {
                BeginContext(1689, 4, true);
                WriteLiteral(" All");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1702, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 46 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Controller\ELE_3_00.cshtml"
                 if (ViewBag.Controllers != null)
                {
                    foreach (var ctrlname in ViewBag.Controllers)
                    {

#line default
#line hidden
            BeginContext(1864, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1888, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52871214c3e8f62aa6b68b66c6c01aac7185da1816415", async() => {
                BeginContext(1915, 8, false);
#line 50 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Controller\ELE_3_00.cshtml"
                                             Write(ctrlname);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 50 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Controller\ELE_3_00.cshtml"
                           WriteLiteral(ctrlname);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1932, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 51 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Controller\ELE_3_00.cshtml"
                    }

                }

#line default
#line hidden
            BeginContext(1978, 708, true);
            WriteLiteral(@"            </select>
        </div>
    </div>
</div>
<div class=""row padbot10"">
    <div class=""col-lg-12 col-md-12 col-sm-12"">
        <table id=""jqgLanguageController""></table>
        <div id=""jqpLanguageController""></div>
    </div>
</div>


<div class=""modal fullscreen fade in"" id=""PopupLanguageController"" data-keyboard=""false"" data-backdrop=""static"">
    <div class=""modal-dialog modal-lg  "" role=""document"" style=""box-shadow:none;"">
        <div class=""modal-content "">
            <div class=""modal-header popupHeader"">
                <button type=""button"" class=""close ml-auto"" data-dismiss=""modal""> <i class=""fa fa-times""></i></button>
                <h4 class=""modal-title"">");
            EndContext();
            BeginContext(2687, 34, false);
#line 71 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Controller\ELE_3_00.cshtml"
                                   Write(Localizer["AddLanguageController"]);

#line default
#line hidden
            EndContext();
            BeginContext(2721, 436, true);
            WriteLiteral(@" </h4>
            </div>

            <div class=""modal-body"">

                <div class=""row padbot4"">

                    <div class=""form-group"">
                        <input id=""txtResourceId"" class=""form-control"" maxlength=""10"" type=""text"" style=""display:none"" />
                    </div>
                    <div class=""col-lg-3 col-md-4 col-sm-6 form-group"">
                        <label class=""lable-color"">");
            EndContext();
            BeginContext(3158, 25, false);
#line 82 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Controller\ELE_3_00.cshtml"
                                              Write(Localizer["ResourceName"]);

#line default
#line hidden
            EndContext();
            BeginContext(3183, 164, true);
            WriteLiteral(" </label>\r\n                        <select class=\"selectpicker\" data-live-search=\"false\" id=\"cboPopupResource\" title=\"\" data-size=\"5\">\r\n                            ");
            EndContext();
            BeginContext(3347, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52871214c3e8f62aa6b68b66c6c01aac7185da1821030", async() => {
                BeginContext(3366, 27, false);
#line 84 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Controller\ELE_3_00.cshtml"
                                         Write(Localizer["SelectResource"]);

#line default
#line hidden
                EndContext();
                BeginContext(3393, 1, true);
                WriteLiteral(" ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3403, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 85 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Controller\ELE_3_00.cshtml"
                             if (ViewBag.Controllers != null)
                            {
                                foreach (var ctrlname in ViewBag.Controllers)
                                {

#line default
#line hidden
            BeginContext(3613, 36, true);
            WriteLiteral("                                    ");
            EndContext();
            BeginContext(3649, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52871214c3e8f62aa6b68b66c6c01aac7185da1823260", async() => {
                BeginContext(3676, 8, false);
#line 89 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Controller\ELE_3_00.cshtml"
                                                         Write(ctrlname);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 89 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Controller\ELE_3_00.cshtml"
                                       WriteLiteral(ctrlname);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3693, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 90 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Controller\ELE_3_00.cshtml"
                                }

                            }

#line default
#line hidden
            BeginContext(3763, 226, true);
            WriteLiteral("                        </select>\r\n                    </div>\r\n                    <div class=\"col-lg-12 col-md-12 col-sm-12\">\r\n                        <div class=\"form-group\">\r\n                            <label for=\"txtKey\">");
            EndContext();
            BeginContext(3990, 16, false);
#line 97 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Controller\ELE_3_00.cshtml"
                                           Write(Localizer["Key"]);

#line default
#line hidden
            EndContext();
            BeginContext(4006, 404, true);
            WriteLiteral(@"</label>
                            <textarea id=""txtKey"" class=""form-control"" rows=""4"" maxlength=""250"" onkeypress=""return AvoidSpace(event)""></textarea>
                        </div>
                    </div>

                    <div class=""col-lg-12 col-md-12 col-sm-12"">
                        <div class=""form-group"">
                            <label class=""lable-color"" for=""txtValue"">");
            EndContext();
            BeginContext(4411, 18, false);
#line 104 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Controller\ELE_3_00.cshtml"
                                                                 Write(Localizer["Value"]);

#line default
#line hidden
            EndContext();
            BeginContext(4429, 606, true);
            WriteLiteral(@"</label>
                            <textarea id=""txtValue"" rows=""4"" class=""form-control"" maxlength=""500""></textarea>
                        </div>
                    </div>
                    <div class=""col-lg-2  col-md-3 col-sm-6 col-xs-12"">
                        <div class=""default-checkbox single"">
                            <label class=""mdl-checkbox mdl-js-checkbox mdl-js-ripple-effect"" for=""chkActiveStatus"">
                                <input type=""checkbox"" id=""chkActiveStatus"" class=""mdl-checkbox__input"">
                                <span class=""mdl-checkbox__label"">");
            EndContext();
            BeginContext(5036, 19, false);
#line 112 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Controller\ELE_3_00.cshtml"
                                                             Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(5055, 508, true);
            WriteLiteral(@"</span>
                            </label>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""modal-footer"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <button class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent primary-button"" id=""btnSaveLanguageController"" onclick=""fnSaveLanguageController()"">
                            ");
            EndContext();
            BeginContext(5564, 17, false);
#line 122 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Controller\ELE_3_00.cshtml"
                       Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(5581, 260, true);
            WriteLiteral(@"
                        </button>
                        <button type=""button"" class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect"" id=""btnDeactivateLanguageController"" onclick=""fnDeleteLanguageController()""><i class=""fas fa-ban""></i>  ");
            EndContext();
            BeginContext(5842, 23, false);
#line 124 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Controller\ELE_3_00.cshtml"
                                                                                                                                                                                                                          Write(Localizer["DeActivate"]);

#line default
#line hidden
            EndContext();
            BeginContext(5865, 228, true);
            WriteLiteral(" </button>\r\n                        <button class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect  cancel-button cancel-button\" data-dismiss=\"modal\" id=\"#\" onclick=\"fnClearFields()\"><i class=\"fa fa-times\"></i> ");
            EndContext();
            BeginContext(6094, 19, false);
#line 125 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\Controller\ELE_3_00.cshtml"
                                                                                                                                                                                                                   Write(Localizer["Cancel"]);

#line default
#line hidden
            EndContext();
            BeginContext(6113, 123, true);
            WriteLiteral("  </button>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
