#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\ApprovalProcess\Views\Levels\ESA_11_00.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbb7b7681e97a30abf5c34aff5eef25d0fc8b3da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ApprovalProcess_Views_Levels_ESA_11_00), @"mvc.1.0.view", @"/Areas/ApprovalProcess/Views/Levels/ESA_11_00.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/ApprovalProcess/Views/Levels/ESA_11_00.cshtml", typeof(AspNetCore.Areas_ApprovalProcess_Views_Levels_ESA_11_00))]
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
#line 1 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\ApprovalProcess\Views\Levels\ESA_11_00.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbb7b7681e97a30abf5c34aff5eef25d0fc8b3da", @"/Areas/ApprovalProcess/Views/Levels/ESA_11_00.cshtml")]
    public class Areas_ApprovalProcess_Views_Levels_ESA_11_00 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/ApprovalProcess/FormTaskAssignment.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(134, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\ApprovalProcess\Views\Levels\ESA_11_00.cshtml"
  
    ViewData["Title"] = "ESA_11_00";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(228, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(247, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(255, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbb7b7681e97a30abf5c34aff5eef25d0fc8b3da4555", async() => {
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
                BeginContext(321, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(326, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 15 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\ApprovalProcess\Views\Levels\ESA_11_00.cshtml"
  
    var userFormRole = (eSyaEnterprise_UI.Models.DO_UserFormRole)ViewBag.UserFormRole;

#line default
#line hidden
            BeginContext(423, 47, true);
            WriteLiteral("<script>\r\n     var _userFormRole = JSON.parse(\'");
            EndContext();
            BeginContext(471, 38, false);
#line 19 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\ApprovalProcess\Views\Levels\ESA_11_00.cshtml"
                                Write(Html.Raw(Json.Serialize(userFormRole)));

#line default
#line hidden
            EndContext();
            BeginContext(509, 71, true);
            WriteLiteral("\');\r\n        var localization = {\r\n            AddFormTaskAssignment: \'");
            EndContext();
            BeginContext(581, 34, false);
#line 21 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\ApprovalProcess\Views\Levels\ESA_11_00.cshtml"
                               Write(Localizer["AddFormTaskAssignment"]);

#line default
#line hidden
            EndContext();
            BeginContext(615, 41, true);
            WriteLiteral("\',\r\n            EditFormTaskAssignment: \'");
            EndContext();
            BeginContext(657, 35, false);
#line 22 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\ApprovalProcess\Views\Levels\ESA_11_00.cshtml"
                                Write(Localizer["EditFormTaskAssignment"]);

#line default
#line hidden
            EndContext();
            BeginContext(692, 41, true);
            WriteLiteral("\',\r\n            ViewFormTaskAssignment: \'");
            EndContext();
            BeginContext(734, 35, false);
#line 23 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\ApprovalProcess\Views\Levels\ESA_11_00.cshtml"
                                Write(Localizer["ViewFormTaskAssignment"]);

#line default
#line hidden
            EndContext();
            BeginContext(769, 23, true);
            WriteLiteral("\',\r\n            Form: \'");
            EndContext();
            BeginContext(793, 17, false);
#line 24 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\ApprovalProcess\Views\Levels\ESA_11_00.cshtml"
              Write(Localizer["Form"]);

#line default
#line hidden
            EndContext();
            BeginContext(810, 25, true);
            WriteLiteral("\',\r\n            Select: \'");
            EndContext();
            BeginContext(836, 19, false);
#line 25 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\ApprovalProcess\Views\Levels\ESA_11_00.cshtml"
                Write(Localizer["Select"]);

#line default
#line hidden
            EndContext();
            BeginContext(855, 23, true);
            WriteLiteral("\',\r\n            Task: \'");
            EndContext();
            BeginContext(879, 17, false);
#line 26 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\ApprovalProcess\Views\Levels\ESA_11_00.cshtml"
              Write(Localizer["Task"]);

#line default
#line hidden
            EndContext();
            BeginContext(896, 39, true);
            WriteLiteral("\',\r\n            AutoReassignTimeline: \'");
            EndContext();
            BeginContext(936, 33, false);
#line 27 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\ApprovalProcess\Views\Levels\ESA_11_00.cshtml"
                              Write(Localizer["AutoReassignTimeline"]);

#line default
#line hidden
            EndContext();
            BeginContext(969, 25, true);
            WriteLiteral("\',\r\n            FormId: \'");
            EndContext();
            BeginContext(995, 19, false);
#line 28 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\ApprovalProcess\Views\Levels\ESA_11_00.cshtml"
                Write(Localizer["FormId"]);

#line default
#line hidden
            EndContext();
            BeginContext(1014, 25, true);
            WriteLiteral("\',\r\n            TaskId: \'");
            EndContext();
            BeginContext(1040, 19, false);
#line 29 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\ApprovalProcess\Views\Levels\ESA_11_00.cshtml"
                Write(Localizer["TaskId"]);

#line default
#line hidden
            EndContext();
            BeginContext(1059, 27, true);
            WriteLiteral("\',\r\n            FormName: \'");
            EndContext();
            BeginContext(1087, 21, false);
#line 30 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\ApprovalProcess\Views\Levels\ESA_11_00.cshtml"
                  Write(Localizer["FormName"]);

#line default
#line hidden
            EndContext();
            BeginContext(1108, 27, true);
            WriteLiteral("\',\r\n            TaskName: \'");
            EndContext();
            BeginContext(1136, 21, false);
#line 31 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\ApprovalProcess\Views\Levels\ESA_11_00.cshtml"
                  Write(Localizer["TaskName"]);

#line default
#line hidden
            EndContext();
            BeginContext(1157, 23, true);
            WriteLiteral("\',\r\n            Edit: \'");
            EndContext();
            BeginContext(1181, 17, false);
#line 32 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\ApprovalProcess\Views\Levels\ESA_11_00.cshtml"
              Write(Localizer["Edit"]);

#line default
#line hidden
            EndContext();
            BeginContext(1198, 25, true);
            WriteLiteral("\',\r\n            Active: \'");
            EndContext();
            BeginContext(1224, 19, false);
#line 33 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\ApprovalProcess\Views\Levels\ESA_11_00.cshtml"
                Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(1243, 26, true);
            WriteLiteral("\',\r\n            Actions: \'");
            EndContext();
            BeginContext(1270, 20, false);
#line 34 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\ApprovalProcess\Views\Levels\ESA_11_00.cshtml"
                 Write(Localizer["Actions"]);

#line default
#line hidden
            EndContext();
            BeginContext(1290, 23, true);
            WriteLiteral("\',\r\n            View: \'");
            EndContext();
            BeginContext(1314, 17, false);
#line 35 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\ApprovalProcess\Views\Levels\ESA_11_00.cshtml"
              Write(Localizer["View"]);

#line default
#line hidden
            EndContext();
            BeginContext(1331, 23, true);
            WriteLiteral("\',\r\n            Save: \'");
            EndContext();
            BeginContext(1355, 17, false);
#line 36 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\ApprovalProcess\Views\Levels\ESA_11_00.cshtml"
              Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(1372, 25, true);
            WriteLiteral("\',\r\n            Update: \'");
            EndContext();
            BeginContext(1398, 19, false);
#line 37 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\ApprovalProcess\Views\Levels\ESA_11_00.cshtml"
                Write(Localizer["Update"]);

#line default
#line hidden
            EndContext();
            BeginContext(1417, 25, true);
            WriteLiteral("\',\r\n            Delete: \'");
            EndContext();
            BeginContext(1443, 19, false);
#line 38 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\ApprovalProcess\Views\Levels\ESA_11_00.cshtml"
                Write(Localizer["Delete"]);

#line default
#line hidden
            EndContext();
            BeginContext(1462, 27, true);
            WriteLiteral("\',\r\n            Activate: \'");
            EndContext();
            BeginContext(1490, 21, false);
#line 39 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\ApprovalProcess\Views\Levels\ESA_11_00.cshtml"
                  Write(Localizer["Activate"]);

#line default
#line hidden
            EndContext();
            BeginContext(1511, 28, true);
            WriteLiteral("\',\r\n            DActivate: \'");
            EndContext();
            BeginContext(1540, 23, false);
#line 40 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\ApprovalProcess\Views\Levels\ESA_11_00.cshtml"
                   Write(Localizer["Deactivate"]);

#line default
#line hidden
            EndContext();
            BeginContext(1563, 622, true);
            WriteLiteral(@"',
        }
</script>

<div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
    <table id=""jqgFormTaskAssignment""></table>
    <div id=""jqpFormTaskAssignment""></div>
</div>


<div class=""modal fade in"" id=""PopupFormTaskAssignment"" data-keyboard=""false"" data-backdrop=""static"">
    <div class=""modal-dialog modal-md"" role=""document"" style=""box-shadow:none;"">
        <div class=""modal-content "">
            <div class=""modal-header popupHeader"">
                <button type=""button"" class=""close ml-auto"" data-dismiss=""modal""> <i class=""fa fa-times""></i></button>
                <h4 class=""modal-title"">");
            EndContext();
            BeginContext(2186, 34, false);
#line 55 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\ApprovalProcess\Views\Levels\ESA_11_00.cshtml"
                                   Write(Localizer["AddFormTaskAssignment"]);

#line default
#line hidden
            EndContext();
            BeginContext(2220, 260, true);
            WriteLiteral(@" </h4>
            </div>

            <div class=""modal-body"">
                <div class=""row"">

                    <div class=""col-lg-6 col-6"">
                        <div class=""form-group"">
                            <label class=""lable-color"">");
            EndContext();
            BeginContext(2481, 17, false);
#line 63 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\ApprovalProcess\Views\Levels\ESA_11_00.cshtml"
                                                  Write(Localizer["Form"]);

#line default
#line hidden
            EndContext();
            BeginContext(2498, 162, true);
            WriteLiteral(" </label>\r\n                            <select class=\"selectpicker\" data-live-search=\"true\" id=\"cboForm\" title=\"\" data-size=\"5\">\r\n                                ");
            EndContext();
            BeginContext(2660, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbb7b7681e97a30abf5c34aff5eef25d0fc8b3da17520", async() => {
                BeginContext(2678, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(2680, 19, false);
#line 65 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\ApprovalProcess\Views\Levels\ESA_11_00.cshtml"
                                              Write(Localizer["Select"]);

#line default
#line hidden
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
            BeginContext(2708, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 66 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\ApprovalProcess\Views\Levels\ESA_11_00.cshtml"
                                 if (ViewBag.Forms != null)
                                {
                                    foreach (var f in ViewBag.Forms)
                                    {

#line default
#line hidden
            BeginContext(2915, 40, true);
            WriteLiteral("                                        ");
            EndContext();
            BeginContext(2955, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbb7b7681e97a30abf5c34aff5eef25d0fc8b3da19756", async() => {
                BeginContext(2982, 10, false);
#line 70 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\ApprovalProcess\Views\Levels\ESA_11_00.cshtml"
                                                             Write(f.FormName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 70 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\ApprovalProcess\Views\Levels\ESA_11_00.cshtml"
                                           WriteLiteral(f.FormID);

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
            BeginContext(3001, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 71 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\ApprovalProcess\Views\Levels\ESA_11_00.cshtml"
                                    }

                                }

#line default
#line hidden
            BeginContext(3079, 256, true);
            WriteLiteral(@"                            </select>
                        </div>
                    </div>

                    <div class=""col-lg-6 col-6"">
                        <div class=""form-group"">
                            <label class=""lable-color"">");
            EndContext();
            BeginContext(3336, 17, false);
#line 80 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\ApprovalProcess\Views\Levels\ESA_11_00.cshtml"
                                                  Write(Localizer["Task"]);

#line default
#line hidden
            EndContext();
            BeginContext(3353, 162, true);
            WriteLiteral(" </label>\r\n                            <select class=\"selectpicker\" data-live-search=\"true\" id=\"cboTask\" title=\"\" data-size=\"3\">\r\n                                ");
            EndContext();
            BeginContext(3515, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbb7b7681e97a30abf5c34aff5eef25d0fc8b3da23079", async() => {
                BeginContext(3533, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(3535, 19, false);
#line 82 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\ApprovalProcess\Views\Levels\ESA_11_00.cshtml"
                                              Write(Localizer["Select"]);

#line default
#line hidden
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
            BeginContext(3563, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 83 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\ApprovalProcess\Views\Levels\ESA_11_00.cshtml"
                                 if (ViewBag.FormTasks != null)
                                {
                                    foreach (var t in ViewBag.FormTasks)
                                    {

#line default
#line hidden
            BeginContext(3778, 40, true);
            WriteLiteral("                                        ");
            EndContext();
            BeginContext(3818, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbb7b7681e97a30abf5c34aff5eef25d0fc8b3da25323", async() => {
                BeginContext(3854, 10, false);
#line 87 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\ApprovalProcess\Views\Levels\ESA_11_00.cshtml"
                                                                      Write(t.CodeDesc);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 87 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\ApprovalProcess\Views\Levels\ESA_11_00.cshtml"
                                           WriteLiteral(t.ApplicationCode);

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
            BeginContext(3873, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 88 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\ApprovalProcess\Views\Levels\ESA_11_00.cshtml"
                                    }

                                }

#line default
#line hidden
            BeginContext(3951, 495, true);
            WriteLiteral(@"                            </select>
                        </div>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-lg-6"">
                        <label class=""mdl-checkbox mdl-js-checkbox mdl-js-ripple-effect"" for=""chkAutoReassignTimeline"">
                            <input type=""checkbox"" id=""chkAutoReassignTimeline"" class=""mdl-checkbox__input"">
                            <span class=""mdl-checkbox__label"">");
            EndContext();
            BeginContext(4447, 33, false);
#line 99 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\ApprovalProcess\Views\Levels\ESA_11_00.cshtml"
                                                         Write(Localizer["AutoReassignTimeline"]);

#line default
#line hidden
            EndContext();
            BeginContext(4480, 483, true);
            WriteLiteral(@"</span>
                        </label>
                    </div>
                </div>
                <div class=""row"">

                    <div class=""col-lg-3  col-md-3 col-sm-12 col-xs-12"">
                        <label class=""mdl-checkbox mdl-js-checkbox mdl-js-ripple-effect"" for=""chkActiveStatus"">
                            <input type=""checkbox"" id=""chkActiveStatus"" class=""mdl-checkbox__input"">
                            <span class=""mdl-checkbox__label"">");
            EndContext();
            BeginContext(4964, 19, false);
#line 108 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\ApprovalProcess\Views\Levels\ESA_11_00.cshtml"
                                                         Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(4983, 499, true);
            WriteLiteral(@"</span>
                        </label>
                    </div>
                </div>
            </div>
            <div class=""modal-footer"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <button class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent primary-button"" id=""btnSaveFormTaskAssignment"" onclick=""fnSaveFormTaskAssignment()"">
                            <i class=""fa fa-save""></i> ");
            EndContext();
            BeginContext(5483, 17, false);
#line 117 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\ApprovalProcess\Views\Levels\ESA_11_00.cshtml"
                                                  Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(5500, 253, true);
            WriteLiteral("\r\n                        </button>\r\n                        <button class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect  cancel-button cancel-button\" data-dismiss=\"modal\" id=\"btnCancelFormTaskAssignment\"><i class=\"fa fa-times\"></i> ");
            EndContext();
            BeginContext(5754, 19, false);
#line 119 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\ApprovalProcess\Views\Levels\ESA_11_00.cshtml"
                                                                                                                                                                                                                   Write(Localizer["Cancel"]);

#line default
#line hidden
            EndContext();
            BeginContext(5773, 219, true);
            WriteLiteral("  </button>\r\n                        <button class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect\" id=\"btndeActiveFormTaskAssignment\" onclick=\"fnDeleteFormTaskAssignment()\"><i class=\"fa fa-times\"></i>");
            EndContext();
            BeginContext(5993, 23, false);
#line 120 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\ApprovalProcess\Views\Levels\ESA_11_00.cshtml"
                                                                                                                                                                                                         Write(Localizer["Deactivate"]);

#line default
#line hidden
            EndContext();
            BeginContext(6016, 148, true);
            WriteLiteral("   </button>\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
