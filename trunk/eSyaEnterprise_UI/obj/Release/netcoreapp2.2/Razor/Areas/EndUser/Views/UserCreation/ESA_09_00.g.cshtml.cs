#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\EndUser\Views\UserCreation\ESA_09_00.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d7a1c177a06eb011060655c962ea34f7d20e89b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_EndUser_Views_UserCreation_ESA_09_00), @"mvc.1.0.view", @"/Areas/EndUser/Views/UserCreation/ESA_09_00.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/EndUser/Views/UserCreation/ESA_09_00.cshtml", typeof(AspNetCore.Areas_EndUser_Views_UserCreation_ESA_09_00))]
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
#line 1 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\EndUser\Views\UserCreation\ESA_09_00.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d7a1c177a06eb011060655c962ea34f7d20e89b", @"/Areas/EndUser/Views/UserCreation/ESA_09_00.cshtml")]
    public class Areas_EndUser_Views_UserCreation_ESA_09_00 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/jsTree.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/jquery.contextMenu.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jsTree.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/EndUser/UserCreation.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.contextMenu.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(134, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\EndUser\Views\UserCreation\ESA_09_00.cshtml"
  
    ViewData["Title"] = "ESA_09_00";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#line 9 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\EndUser\Views\UserCreation\ESA_09_00.cshtml"
  
    var userFormRole = (eSyaEnterprise_UI.Models.DO_UserFormRole)ViewBag.UserFormRole;

#line default
#line hidden
            BeginContext(323, 48, true);
            WriteLiteral("\r\n<script>\r\n    var _userFormRole = JSON.parse(\'");
            EndContext();
            BeginContext(372, 38, false);
#line 14 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\EndUser\Views\UserCreation\ESA_09_00.cshtml"
                               Write(Html.Raw(Json.Serialize(userFormRole)));

#line default
#line hidden
            EndContext();
            BeginContext(410, 51, true);
            WriteLiteral("\');\r\n\r\n    var localization = {\r\n        LoginID: \'");
            EndContext();
            BeginContext(462, 20, false);
#line 17 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\EndUser\Views\UserCreation\ESA_09_00.cshtml"
             Write(Localizer["LoginID"]);

#line default
#line hidden
            EndContext();
            BeginContext(482, 31, true);
            WriteLiteral("\',\r\n        LoginDescription: \'");
            EndContext();
            BeginContext(514, 29, false);
#line 18 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\EndUser\Views\UserCreation\ESA_09_00.cshtml"
                      Write(Localizer["LoginDescription"]);

#line default
#line hidden
            EndContext();
            BeginContext(543, 27, true);
            WriteLiteral("\',\r\n        MobileNumber: \'");
            EndContext();
            BeginContext(571, 25, false);
#line 19 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\EndUser\Views\UserCreation\ESA_09_00.cshtml"
                  Write(Localizer["MobileNumber"]);

#line default
#line hidden
            EndContext();
            BeginContext(596, 31, true);
            WriteLiteral("\',\r\n        LastActivityDate: \'");
            EndContext();
            BeginContext(628, 29, false);
#line 20 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\EndUser\Views\UserCreation\ESA_09_00.cshtml"
                      Write(Localizer["LastActivityDate"]);

#line default
#line hidden
            EndContext();
            BeginContext(657, 21, true);
            WriteLiteral("\',\r\n        Active: \'");
            EndContext();
            BeginContext(679, 19, false);
#line 21 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\EndUser\Views\UserCreation\ESA_09_00.cshtml"
            Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(698, 22, true);
            WriteLiteral("\',\r\n        Actions: \'");
            EndContext();
            BeginContext(721, 20, false);
#line 22 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\EndUser\Views\UserCreation\ESA_09_00.cshtml"
             Write(Localizer["Actions"]);

#line default
#line hidden
            EndContext();
            BeginContext(741, 34, true);
            WriteLiteral("\',\r\n        LocationDescription: \'");
            EndContext();
            BeginContext(776, 32, false);
#line 23 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\EndUser\Views\UserCreation\ESA_09_00.cshtml"
                         Write(Localizer["LocationDescription"]);

#line default
#line hidden
            EndContext();
            BeginContext(808, 24, true);
            WriteLiteral("\',\r\n        UserGroup: \'");
            EndContext();
            BeginContext(833, 22, false);
#line 24 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\EndUser\Views\UserCreation\ESA_09_00.cshtml"
               Write(Localizer["UserGroup"]);

#line default
#line hidden
            EndContext();
            BeginContext(855, 23, true);
            WriteLiteral("\',\r\n        UserType: \'");
            EndContext();
            BeginContext(879, 21, false);
#line 25 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\EndUser\Views\UserCreation\ESA_09_00.cshtml"
              Write(Localizer["UserType"]);

#line default
#line hidden
            EndContext();
            BeginContext(900, 23, true);
            WriteLiteral("\',\r\n        AllowMFY: \'");
            EndContext();
            BeginContext(924, 21, false);
#line 26 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\EndUser\Views\UserCreation\ESA_09_00.cshtml"
              Write(Localizer["AllowMFY"]);

#line default
#line hidden
            EndContext();
            BeginContext(945, 21, true);
            WriteLiteral("\',\r\n        Action: \'");
            EndContext();
            BeginContext(967, 19, false);
#line 27 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\EndUser\Views\UserCreation\ESA_09_00.cshtml"
            Write(Localizer["Action"]);

#line default
#line hidden
            EndContext();
            BeginContext(986, 21, true);
            WriteLiteral("\',\r\n        //Edit: \'");
            EndContext();
            BeginContext(1008, 17, false);
#line 28 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\EndUser\Views\UserCreation\ESA_09_00.cshtml"
            Write(Localizer["Edit"]);

#line default
#line hidden
            EndContext();
            BeginContext(1025, 19, true);
            WriteLiteral("\',\r\n        Edit: \'");
            EndContext();
            BeginContext(1045, 25, false);
#line 29 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\EndUser\Views\UserCreation\ESA_09_00.cshtml"
          Write(Localizer["Authenticate"]);

#line default
#line hidden
            EndContext();
            BeginContext(1070, 19, true);
            WriteLiteral("\',\r\n        View: \'");
            EndContext();
            BeginContext(1090, 17, false);
#line 30 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\EndUser\Views\UserCreation\ESA_09_00.cshtml"
          Write(Localizer["View"]);

#line default
#line hidden
            EndContext();
            BeginContext(1107, 23, true);
            WriteLiteral("\',\r\n        MenuLink: \'");
            EndContext();
            BeginContext(1131, 21, false);
#line 31 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\EndUser\Views\UserCreation\ESA_09_00.cshtml"
              Write(Localizer["MenuLink"]);

#line default
#line hidden
            EndContext();
            BeginContext(1152, 34, true);
            WriteLiteral("\',\r\n        EditBusinessSegment: \'");
            EndContext();
            BeginContext(1187, 32, false);
#line 32 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\EndUser\Views\UserCreation\ESA_09_00.cshtml"
                         Write(Localizer["EditBusinessSegment"]);

#line default
#line hidden
            EndContext();
            BeginContext(1219, 34, true);
            WriteLiteral("\',\r\n        ViewBusinessSegment: \'");
            EndContext();
            BeginContext(1254, 32, false);
#line 33 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\EndUser\Views\UserCreation\ESA_09_00.cshtml"
                         Write(Localizer["ViewBusinessSegment"]);

#line default
#line hidden
            EndContext();
            BeginContext(1286, 27, true);
            WriteLiteral("\',\r\n    };\r\n\r\n</script>\r\n\r\n");
            EndContext();
            BeginContext(1313, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8d7a1c177a06eb011060655c962ea34f7d20e89b13400", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1362, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1364, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8d7a1c177a06eb011060655c962ea34f7d20e89b14655", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1429, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1450, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1456, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d7a1c177a06eb011060655c962ea34f7d20e89b16093", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1494, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1500, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d7a1c177a06eb011060655c962ea34f7d20e89b17349", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1552, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1558, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d7a1c177a06eb011060655c962ea34f7d20e89b18605", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1612, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            BeginContext(1619, 341, true);
            WriteLiteral(@"<section id=""divUserCreationGrid"">
    <div class=""row padbot10"">
        <div class=""col-xl-12 col-lg-12 col-md-12 col-sm-12 col-xs-12"">
            <table id=""jqgUserCreation""></table>
            <div id=""jqpUserCreation""></div>
        </div>
    </div>
</section>

<section id=""divUserCreationForm"" style=""display:none;"">
    ");
            EndContext();
            BeginContext(1961, 40, false);
#line 57 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\EndUser\Views\UserCreation\ESA_09_00.cshtml"
Write(await Html.PartialAsync("_UserCreation"));

#line default
#line hidden
            EndContext();
            BeginContext(2001, 20, true);
            WriteLiteral("\r\n</section>\r\n\r\n\r\n\r\n");
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
