#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\UserCreation\ELE_06_00.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6f6d7c4ac7c3de6dd765b2938ec0facf9d9bcd7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Localize_Views_UserCreation_ELE_06_00), @"mvc.1.0.view", @"/Areas/Localize/Views/UserCreation/ELE_06_00.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Localize/Views/UserCreation/ELE_06_00.cshtml", typeof(AspNetCore.Areas_Localize_Views_UserCreation_ELE_06_00))]
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
#line 1 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\UserCreation\ELE_06_00.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6f6d7c4ac7c3de6dd765b2938ec0facf9d9bcd7", @"/Areas/Localize/Views/UserCreation/ELE_06_00.cshtml")]
    public class Areas_Localize_Views_UserCreation_ELE_06_00 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Localize/UserCreation.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\UserCreation\ELE_06_00.cshtml"
  
    ViewData["Title"] = "ELE_06_00";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(176, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(195, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(201, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6f6d7c4ac7c3de6dd765b2938ec0facf9d9bcd74207", async() => {
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
                BeginContext(254, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(259, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 14 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\UserCreation\ELE_06_00.cshtml"
  
    var userFormRole = (eSyaEnterprise_UI.Models.DO_UserFormRole)ViewBag.UserFormRole;

#line default
#line hidden
            BeginContext(356, 46, true);
            WriteLiteral("<script>\r\n    var _userFormRole = JSON.parse(\'");
            EndContext();
            BeginContext(403, 38, false);
#line 18 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\UserCreation\ELE_06_00.cshtml"
                               Write(Html.Raw(Json.Serialize(userFormRole)));

#line default
#line hidden
            EndContext();
            BeginContext(441, 53, true);
            WriteLiteral("\');\r\n\r\n     var localization = {\r\n         LoginId: \'");
            EndContext();
            BeginContext(495, 20, false);
#line 21 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\UserCreation\ELE_06_00.cshtml"
              Write(Localizer["LoginId"]);

#line default
#line hidden
            EndContext();
            BeginContext(515, 32, true);
            WriteLiteral("\',\r\n         LoginDescription: \'");
            EndContext();
            BeginContext(548, 29, false);
#line 22 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\UserCreation\ELE_06_00.cshtml"
                       Write(Localizer["LoginDescription"]);

#line default
#line hidden
            EndContext();
            BeginContext(577, 22, true);
            WriteLiteral("\',\r\n         UserId: \'");
            EndContext();
            BeginContext(600, 19, false);
#line 23 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\UserCreation\ELE_06_00.cshtml"
             Write(Localizer["UserId"]);

#line default
#line hidden
            EndContext();
            BeginContext(619, 23, true);
            WriteLiteral("\',\r\n         LoginID: \'");
            EndContext();
            BeginContext(643, 20, false);
#line 24 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\UserCreation\ELE_06_00.cshtml"
              Write(Localizer["LoginID"]);

#line default
#line hidden
            EndContext();
            BeginContext(663, 23, true);
            WriteLiteral("\',\r\n         Password:\'");
            EndContext();
            BeginContext(687, 21, false);
#line 25 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\UserCreation\ELE_06_00.cshtml"
              Write(Localizer["Password"]);

#line default
#line hidden
            EndContext();
            BeginContext(708, 20, true);
            WriteLiteral("\',\r\n         Edit: \'");
            EndContext();
            BeginContext(729, 17, false);
#line 26 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\UserCreation\ELE_06_00.cshtml"
           Write(Localizer["Edit"]);

#line default
#line hidden
            EndContext();
            BeginContext(746, 22, true);
            WriteLiteral("\',\r\n         Active: \'");
            EndContext();
            BeginContext(769, 19, false);
#line 27 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\UserCreation\ELE_06_00.cshtml"
             Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(788, 23, true);
            WriteLiteral("\',\r\n         Actions: \'");
            EndContext();
            BeginContext(812, 20, false);
#line 28 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\UserCreation\ELE_06_00.cshtml"
              Write(Localizer["Actions"]);

#line default
#line hidden
            EndContext();
            BeginContext(832, 20, true);
            WriteLiteral("\',\r\n         View: \'");
            EndContext();
            BeginContext(853, 17, false);
#line 29 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\UserCreation\ELE_06_00.cshtml"
           Write(Localizer["View"]);

#line default
#line hidden
            EndContext();
            BeginContext(870, 20, true);
            WriteLiteral("\',\r\n         Save: \'");
            EndContext();
            BeginContext(891, 17, false);
#line 30 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\UserCreation\ELE_06_00.cshtml"
           Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(908, 22, true);
            WriteLiteral("\',\r\n         Update: \'");
            EndContext();
            BeginContext(931, 19, false);
#line 31 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\UserCreation\ELE_06_00.cshtml"
             Write(Localizer["Update"]);

#line default
#line hidden
            EndContext();
            BeginContext(950, 22, true);
            WriteLiteral("\',\r\n         Delete: \'");
            EndContext();
            BeginContext(973, 19, false);
#line 32 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\UserCreation\ELE_06_00.cshtml"
             Write(Localizer["Delete"]);

#line default
#line hidden
            EndContext();
            BeginContext(992, 24, true);
            WriteLiteral("\',\r\n         Activate: \'");
            EndContext();
            BeginContext(1017, 21, false);
#line 33 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\UserCreation\ELE_06_00.cshtml"
               Write(Localizer["Activate"]);

#line default
#line hidden
            EndContext();
            BeginContext(1038, 26, true);
            WriteLiteral("\',\r\n         Deactivate: \'");
            EndContext();
            BeginContext(1065, 23, false);
#line 34 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\UserCreation\ELE_06_00.cshtml"
                 Write(Localizer["DeActivate"]);

#line default
#line hidden
            EndContext();
            BeginContext(1088, 23, true);
            WriteLiteral("\',\r\n         Adduser: \'");
            EndContext();
            BeginContext(1112, 20, false);
#line 35 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\UserCreation\ELE_06_00.cshtml"
              Write(Localizer["Adduser"]);

#line default
#line hidden
            EndContext();
            BeginContext(1132, 26, true);
            WriteLiteral("\',\r\n         UpdateUser: \'");
            EndContext();
            BeginContext(1159, 23, false);
#line 36 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\UserCreation\ELE_06_00.cshtml"
                 Write(Localizer["UpdateUser"]);

#line default
#line hidden
            EndContext();
            BeginContext(1182, 24, true);
            WriteLiteral("\',\r\n         ViewUser: \'");
            EndContext();
            BeginContext(1207, 21, false);
#line 37 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\UserCreation\ELE_06_00.cshtml"
               Write(Localizer["ViewUser"]);

#line default
#line hidden
            EndContext();
            BeginContext(1228, 634, true);
            WriteLiteral(@"',
    };
</script>

<div class=""row"">
    <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
        <table id=""jqgUser""></table>
        <div id=""jqpUser""></div>
    </div>
</div>

<div class=""modal fade"" id=""PopupUser"" data-keyboard=""false"" data-backdrop=""static"">
    <div class=""modal-dialog modal-md"" role=""document"" style=""box-shadow:none;"">
        <div class=""modal-content"">

            <div class=""modal-header popupHeader"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" onclick=""fnClearFields()""> <i class=""fa fa-times""></i></button>
                <h4 class=""modal-title"">");
            EndContext();
            BeginContext(1863, 20, false);
#line 54 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\UserCreation\ELE_06_00.cshtml"
                                   Write(Localizer["Adduser"]);

#line default
#line hidden
            EndContext();
            BeginContext(1883, 420, true);
            WriteLiteral(@"</h4>
            </div>


            <div class=""modal-body"">
                <div class=""row padbot4"">
                    <div class=""col-sm-12"">
                        <input type=""text"" class=""form-control"" id=""txtUserId"" style=""display:none"">
                    </div>

                    <div class=""col-lg-12"">
                        <div class=""form-group"">
                            <label> ");
            EndContext();
            BeginContext(2304, 20, false);
#line 66 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\UserCreation\ELE_06_00.cshtml"
                               Write(Localizer["LoginID"]);

#line default
#line hidden
            EndContext();
            BeginContext(2324, 323, true);
            WriteLiteral(@" </label>
                            <input type=""text"" id=""txtLoginId"" name=""LoginID""  class=""form-control"" maxlength=""20"" />
                        </div>
                    </div>

                    <div class=""col-lg-12"">
                        <div class=""form-group"">
                            <label> ");
            EndContext();
            BeginContext(2648, 29, false);
#line 73 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\UserCreation\ELE_06_00.cshtml"
                               Write(Localizer["LoginDescription"]);

#line default
#line hidden
            EndContext();
            BeginContext(2677, 349, true);
            WriteLiteral(@" </label>
                            <input type=""text"" id=""txtLoginDescription"" name=""LoginDescription"" value="""" class=""form-control"" maxlength=""50"" />
                        </div>
                    </div>

                    <div class=""col-lg-12"">
                        <div class=""form-group"">
                            <label> ");
            EndContext();
            BeginContext(3027, 21, false);
#line 80 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\UserCreation\ELE_06_00.cshtml"
                               Write(Localizer["Password"]);

#line default
#line hidden
            EndContext();
            BeginContext(3048, 633, true);
            WriteLiteral(@" </label>
                            <input type=""password"" id=""txtPassword"" name=""Password"" value="""" class=""form-control"" maxlength=""2000"" />
                        </div>
                    </div>

                    <div class=""col-lg-4 col-md-4 col-sm-12 col-xs-12"">
                        <div class=""default-checkbox single"">
                            <label class=""mdl-checkbox mdl-js-checkbox mdl-js-ripple-effect"" for=""chkActiveStatus"">
                                <input type=""checkbox"" id=""chkActiveStatus"" class=""mdl-checkbox__input"">
                                <span class=""mdl-checkbox__label"">");
            EndContext();
            BeginContext(3682, 19, false);
#line 89 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\UserCreation\ELE_06_00.cshtml"
                                                             Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(3701, 453, true);
            WriteLiteral(@"</span>
                            </label>
                        </div>
                    </div>
                </div>
            </div>

            <div class=""modal-footer"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <button type=""button"" class=""mdl-button  primary-button"" id=""btnSaveUser"" onclick=""fnSaveUser()"">
                            <i class=""fa fa-save""></i>   ");
            EndContext();
            BeginContext(4155, 17, false);
#line 100 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\UserCreation\ELE_06_00.cshtml"
                                                    Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(4172, 232, true);
            WriteLiteral("\r\n                        </button>\r\n                        <button type=\"button\" class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect\" id=\"btnDeactivateUser\" onclick=\"fnDeleteUser()\"><i class=\"fas fa-ban\"></i>  ");
            EndContext();
            BeginContext(4405, 23, false);
#line 102 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\UserCreation\ELE_06_00.cshtml"
                                                                                                                                                                                              Write(Localizer["Deactivate"]);

#line default
#line hidden
            EndContext();
            BeginContext(4428, 243, true);
            WriteLiteral(" </button>\r\n\r\n                        <button type=\"button\" class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect  cancel-button\" data-dismiss=\"modal\" id=\"btncancelUser\" onclick=\"fnClearFields()\"><i class=\"fa fa-times\"></i>  ");
            EndContext();
            BeginContext(4672, 19, false);
#line 104 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Localize\Views\UserCreation\ELE_06_00.cshtml"
                                                                                                                                                                                                                                Write(Localizer["Cancel"]);

#line default
#line hidden
            EndContext();
            BeginContext(4691, 122, true);
            WriteLiteral(" </button>\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
