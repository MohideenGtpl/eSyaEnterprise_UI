#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\EndUser\Views\UserCreation\ESA_09_00.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dda60a54bcc1c664766917eda70ce820f63fb945"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dda60a54bcc1c664766917eda70ce820f63fb945", @"/Areas/EndUser/Views/UserCreation/ESA_09_00.cshtml")]
    public class Areas_EndUser_Views_UserCreation_ESA_09_00 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/jsTree.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jsTree.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/EndUser/UserCreation.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(323, 46, true);
            WriteLiteral("<script>\r\n    var _userFormRole = JSON.parse(\'");
            EndContext();
            BeginContext(370, 38, false);
#line 13 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\EndUser\Views\UserCreation\ESA_09_00.cshtml"
                               Write(Html.Raw(Json.Serialize(userFormRole)));

#line default
#line hidden
            EndContext();
            BeginContext(408, 51, true);
            WriteLiteral("\');\r\n\r\n    var localization = {\r\n        LoginID: \'");
            EndContext();
            BeginContext(460, 20, false);
#line 16 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\EndUser\Views\UserCreation\ESA_09_00.cshtml"
             Write(Localizer["LoginID"]);

#line default
#line hidden
            EndContext();
            BeginContext(480, 31, true);
            WriteLiteral("\',\r\n        LoginDescription: \'");
            EndContext();
            BeginContext(512, 29, false);
#line 17 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\EndUser\Views\UserCreation\ESA_09_00.cshtml"
                      Write(Localizer["LoginDescription"]);

#line default
#line hidden
            EndContext();
            BeginContext(541, 27, true);
            WriteLiteral("\',\r\n        MobileNumber: \'");
            EndContext();
            BeginContext(569, 25, false);
#line 18 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\EndUser\Views\UserCreation\ESA_09_00.cshtml"
                  Write(Localizer["MobileNumber"]);

#line default
#line hidden
            EndContext();
            BeginContext(594, 31, true);
            WriteLiteral("\',\r\n        LastActivityDate: \'");
            EndContext();
            BeginContext(626, 29, false);
#line 19 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\EndUser\Views\UserCreation\ESA_09_00.cshtml"
                      Write(Localizer["LastActivityDate"]);

#line default
#line hidden
            EndContext();
            BeginContext(655, 21, true);
            WriteLiteral("\',\r\n        Active: \'");
            EndContext();
            BeginContext(677, 19, false);
#line 20 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\EndUser\Views\UserCreation\ESA_09_00.cshtml"
            Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(696, 22, true);
            WriteLiteral("\',\r\n        Actions: \'");
            EndContext();
            BeginContext(719, 20, false);
#line 21 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\EndUser\Views\UserCreation\ESA_09_00.cshtml"
             Write(Localizer["Actions"]);

#line default
#line hidden
            EndContext();
            BeginContext(739, 34, true);
            WriteLiteral("\',\r\n        LocationDescription: \'");
            EndContext();
            BeginContext(774, 32, false);
#line 22 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\EndUser\Views\UserCreation\ESA_09_00.cshtml"
                         Write(Localizer["LocationDescription"]);

#line default
#line hidden
            EndContext();
            BeginContext(806, 24, true);
            WriteLiteral("\',\r\n        UserGroup: \'");
            EndContext();
            BeginContext(831, 22, false);
#line 23 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\EndUser\Views\UserCreation\ESA_09_00.cshtml"
               Write(Localizer["UserGroup"]);

#line default
#line hidden
            EndContext();
            BeginContext(853, 23, true);
            WriteLiteral("\',\r\n        UserType: \'");
            EndContext();
            BeginContext(877, 21, false);
#line 24 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\EndUser\Views\UserCreation\ESA_09_00.cshtml"
              Write(Localizer["UserType"]);

#line default
#line hidden
            EndContext();
            BeginContext(898, 23, true);
            WriteLiteral("\',\r\n        AllowMFY: \'");
            EndContext();
            BeginContext(922, 21, false);
#line 25 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\EndUser\Views\UserCreation\ESA_09_00.cshtml"
              Write(Localizer["AllowMFY"]);

#line default
#line hidden
            EndContext();
            BeginContext(943, 21, true);
            WriteLiteral("\',\r\n        Action: \'");
            EndContext();
            BeginContext(965, 19, false);
#line 26 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\EndUser\Views\UserCreation\ESA_09_00.cshtml"
            Write(Localizer["Action"]);

#line default
#line hidden
            EndContext();
            BeginContext(984, 21, true);
            WriteLiteral("\',\r\n        //Edit: \'");
            EndContext();
            BeginContext(1006, 17, false);
#line 27 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\EndUser\Views\UserCreation\ESA_09_00.cshtml"
            Write(Localizer["Edit"]);

#line default
#line hidden
            EndContext();
            BeginContext(1023, 19, true);
            WriteLiteral("\',\r\n        Edit: \'");
            EndContext();
            BeginContext(1043, 25, false);
#line 28 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\EndUser\Views\UserCreation\ESA_09_00.cshtml"
          Write(Localizer["Authenticate"]);

#line default
#line hidden
            EndContext();
            BeginContext(1068, 19, true);
            WriteLiteral("\',\r\n        View: \'");
            EndContext();
            BeginContext(1088, 17, false);
#line 29 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\EndUser\Views\UserCreation\ESA_09_00.cshtml"
          Write(Localizer["View"]);

#line default
#line hidden
            EndContext();
            BeginContext(1105, 23, true);
            WriteLiteral("\',\r\n        MenuLink: \'");
            EndContext();
            BeginContext(1129, 21, false);
#line 30 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\EndUser\Views\UserCreation\ESA_09_00.cshtml"
              Write(Localizer["MenuLink"]);

#line default
#line hidden
            EndContext();
            BeginContext(1150, 34, true);
            WriteLiteral("\',\r\n        EditBusinessSegment: \'");
            EndContext();
            BeginContext(1185, 32, false);
#line 31 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\EndUser\Views\UserCreation\ESA_09_00.cshtml"
                         Write(Localizer["EditBusinessSegment"]);

#line default
#line hidden
            EndContext();
            BeginContext(1217, 34, true);
            WriteLiteral("\',\r\n        ViewBusinessSegment: \'");
            EndContext();
            BeginContext(1252, 32, false);
#line 32 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\EndUser\Views\UserCreation\ESA_09_00.cshtml"
                         Write(Localizer["ViewBusinessSegment"]);

#line default
#line hidden
            EndContext();
            BeginContext(1284, 27, true);
            WriteLiteral("\',\r\n    };\r\n\r\n</script>\r\n\r\n");
            EndContext();
            BeginContext(1311, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dda60a54bcc1c664766917eda70ce820f63fb94512657", async() => {
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
            BeginContext(1360, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1379, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1385, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dda60a54bcc1c664766917eda70ce820f63fb94514091", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1423, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1429, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dda60a54bcc1c664766917eda70ce820f63fb94515347", async() => {
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
                BeginContext(1481, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(1486, 341, true);
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
            BeginContext(1828, 40, false);
#line 52 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\EndUser\Views\UserCreation\ESA_09_00.cshtml"
Write(await Html.PartialAsync("_UserCreation"));

#line default
#line hidden
            EndContext();
            BeginContext(1868, 20, true);
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
