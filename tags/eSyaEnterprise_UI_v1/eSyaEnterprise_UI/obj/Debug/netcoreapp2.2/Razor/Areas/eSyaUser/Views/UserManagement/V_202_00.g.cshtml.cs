#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaUser\Views\UserManagement\V_202_00.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d45943063c9d210ea8d393c95e7038c64df6a68"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_eSyaUser_Views_UserManagement_V_202_00), @"mvc.1.0.view", @"/Areas/eSyaUser/Views/UserManagement/V_202_00.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/eSyaUser/Views/UserManagement/V_202_00.cshtml", typeof(AspNetCore.Areas_eSyaUser_Views_UserManagement_V_202_00))]
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
#line 1 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaUser\Views\UserManagement\V_202_00.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d45943063c9d210ea8d393c95e7038c64df6a68", @"/Areas/eSyaUser/Views/UserManagement/V_202_00.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Areas/eSyaUser/Views/_ViewImports.cshtml")]
    public class Areas_eSyaUser_Views_UserManagement_V_202_00 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/jsTree.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jsTree.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/eSyaUserManagement/UserCreation.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaUser\Views\UserManagement\V_202_00.cshtml"
  
    ViewData["Title"] = "User Creation";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#line 8 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaUser\Views\UserManagement\V_202_00.cshtml"
  
    var userFormRole = (eSyaEnterprise_UI.Models.DO_UserFormRole)ViewBag.UserFormRole;

#line default
#line hidden
            BeginContext(273, 46, true);
            WriteLiteral("<script>\r\n    var _userFormRole = JSON.parse(\'");
            EndContext();
            BeginContext(320, 38, false);
#line 12 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaUser\Views\UserManagement\V_202_00.cshtml"
                               Write(Html.Raw(Json.Serialize(userFormRole)));

#line default
#line hidden
            EndContext();
            BeginContext(358, 51, true);
            WriteLiteral("\');\r\n\r\n    var localization = {\r\n        LoginID: \'");
            EndContext();
            BeginContext(410, 20, false);
#line 15 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaUser\Views\UserManagement\V_202_00.cshtml"
             Write(Localizer["LoginID"]);

#line default
#line hidden
            EndContext();
            BeginContext(430, 31, true);
            WriteLiteral("\',\r\n        LoginDescription: \'");
            EndContext();
            BeginContext(462, 29, false);
#line 16 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaUser\Views\UserManagement\V_202_00.cshtml"
                      Write(Localizer["LoginDescription"]);

#line default
#line hidden
            EndContext();
            BeginContext(491, 27, true);
            WriteLiteral("\',\r\n        MobileNumber: \'");
            EndContext();
            BeginContext(519, 25, false);
#line 17 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaUser\Views\UserManagement\V_202_00.cshtml"
                  Write(Localizer["MobileNumber"]);

#line default
#line hidden
            EndContext();
            BeginContext(544, 31, true);
            WriteLiteral("\',\r\n        LastActivityDate: \'");
            EndContext();
            BeginContext(576, 29, false);
#line 18 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaUser\Views\UserManagement\V_202_00.cshtml"
                      Write(Localizer["LastActivityDate"]);

#line default
#line hidden
            EndContext();
            BeginContext(605, 21, true);
            WriteLiteral("\',\r\n        Active: \'");
            EndContext();
            BeginContext(627, 19, false);
#line 19 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaUser\Views\UserManagement\V_202_00.cshtml"
            Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(646, 22, true);
            WriteLiteral("\',\r\n        Actions: \'");
            EndContext();
            BeginContext(669, 20, false);
#line 20 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaUser\Views\UserManagement\V_202_00.cshtml"
             Write(Localizer["Actions"]);

#line default
#line hidden
            EndContext();
            BeginContext(689, 34, true);
            WriteLiteral("\',\r\n        LocationDescription: \'");
            EndContext();
            BeginContext(724, 32, false);
#line 21 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaUser\Views\UserManagement\V_202_00.cshtml"
                         Write(Localizer["LocationDescription"]);

#line default
#line hidden
            EndContext();
            BeginContext(756, 24, true);
            WriteLiteral("\',\r\n        UserGroup: \'");
            EndContext();
            BeginContext(781, 22, false);
#line 22 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaUser\Views\UserManagement\V_202_00.cshtml"
               Write(Localizer["UserGroup"]);

#line default
#line hidden
            EndContext();
            BeginContext(803, 23, true);
            WriteLiteral("\',\r\n        UserType: \'");
            EndContext();
            BeginContext(827, 21, false);
#line 23 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaUser\Views\UserManagement\V_202_00.cshtml"
              Write(Localizer["UserType"]);

#line default
#line hidden
            EndContext();
            BeginContext(848, 23, true);
            WriteLiteral("\',\r\n        AllowMFY: \'");
            EndContext();
            BeginContext(872, 21, false);
#line 24 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaUser\Views\UserManagement\V_202_00.cshtml"
              Write(Localizer["AllowMFY"]);

#line default
#line hidden
            EndContext();
            BeginContext(893, 21, true);
            WriteLiteral("\',\r\n        Action: \'");
            EndContext();
            BeginContext(915, 19, false);
#line 25 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaUser\Views\UserManagement\V_202_00.cshtml"
            Write(Localizer["Action"]);

#line default
#line hidden
            EndContext();
            BeginContext(934, 19, true);
            WriteLiteral("\',\r\n        Edit: \'");
            EndContext();
            BeginContext(954, 17, false);
#line 26 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaUser\Views\UserManagement\V_202_00.cshtml"
          Write(Localizer["Edit"]);

#line default
#line hidden
            EndContext();
            BeginContext(971, 19, true);
            WriteLiteral("\',\r\n        View: \'");
            EndContext();
            BeginContext(991, 17, false);
#line 27 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaUser\Views\UserManagement\V_202_00.cshtml"
          Write(Localizer["View"]);

#line default
#line hidden
            EndContext();
            BeginContext(1008, 23, true);
            WriteLiteral("\',\r\n        MenuLink: \'");
            EndContext();
            BeginContext(1032, 21, false);
#line 28 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaUser\Views\UserManagement\V_202_00.cshtml"
              Write(Localizer["MenuLink"]);

#line default
#line hidden
            EndContext();
            BeginContext(1053, 34, true);
            WriteLiteral("\',\r\n        EditBusinessSegment: \'");
            EndContext();
            BeginContext(1088, 32, false);
#line 29 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaUser\Views\UserManagement\V_202_00.cshtml"
                         Write(Localizer["EditBusinessSegment"]);

#line default
#line hidden
            EndContext();
            BeginContext(1120, 34, true);
            WriteLiteral("\',\r\n        ViewBusinessSegment: \'");
            EndContext();
            BeginContext(1155, 32, false);
#line 30 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaUser\Views\UserManagement\V_202_00.cshtml"
                         Write(Localizer["ViewBusinessSegment"]);

#line default
#line hidden
            EndContext();
            BeginContext(1187, 33, true);
            WriteLiteral("\',\r\n        UserAuthentication: \'");
            EndContext();
            BeginContext(1221, 31, false);
#line 31 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaUser\Views\UserManagement\V_202_00.cshtml"
                        Write(Localizer["UserAuthentication"]);

#line default
#line hidden
            EndContext();
            BeginContext(1252, 21, true);
            WriteLiteral("\',\r\n        UserID: \'");
            EndContext();
            BeginContext(1274, 19, false);
#line 32 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaUser\Views\UserManagement\V_202_00.cshtml"
            Write(Localizer["UserID"]);

#line default
#line hidden
            EndContext();
            BeginContext(1293, 23, true);
            WriteLiteral("\',\r\n        IUStatus: \'");
            EndContext();
            BeginContext(1317, 21, false);
#line 33 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaUser\Views\UserManagement\V_202_00.cshtml"
              Write(Localizer["IUStatus"]);

#line default
#line hidden
            EndContext();
            BeginContext(1338, 26, true);
            WriteLiteral("\',\r\n        BusinessKey: \'");
            EndContext();
            BeginContext(1365, 24, false);
#line 34 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaUser\Views\UserManagement\V_202_00.cshtml"
                 Write(Localizer["BusinessKey"]);

#line default
#line hidden
            EndContext();
            BeginContext(1389, 23, true);
            WriteLiteral("\',\r\n        FormName: \'");
            EndContext();
            BeginContext(1413, 21, false);
#line 35 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaUser\Views\UserManagement\V_202_00.cshtml"
              Write(Localizer["FormName"]);

#line default
#line hidden
            EndContext();
            BeginContext(1434, 27, true);
            WriteLiteral("\',\r\n    };\r\n\r\n</script>\r\n\r\n");
            EndContext();
            BeginContext(1461, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8d45943063c9d210ea8d393c95e7038c64df6a6815080", async() => {
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
            BeginContext(1510, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1529, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1535, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d45943063c9d210ea8d393c95e7038c64df6a6816514", async() => {
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
                BeginContext(1573, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1579, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d45943063c9d210ea8d393c95e7038c64df6a6817770", async() => {
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
                BeginContext(1642, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(1647, 341, true);
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
            BeginContext(1989, 40, false);
#line 55 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaUser\Views\UserManagement\V_202_00.cshtml"
Write(await Html.PartialAsync("_UserCreation"));

#line default
#line hidden
            EndContext();
            BeginContext(2029, 16, true);
            WriteLiteral("\r\n</section>\r\n\r\n");
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
