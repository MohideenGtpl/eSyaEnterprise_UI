#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaUser\Views\UserManagement\_userMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1de015576deeef1b373a406590d20758a9ea89b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_eSyaUser_Views_UserManagement__userMenu), @"mvc.1.0.view", @"/Areas/eSyaUser/Views/UserManagement/_userMenu.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/eSyaUser/Views/UserManagement/_userMenu.cshtml", typeof(AspNetCore.Areas_eSyaUser_Views_UserManagement__userMenu))]
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
#line 4 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaUser\Views\UserManagement\_userMenu.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1de015576deeef1b373a406590d20758a9ea89b6", @"/Areas/eSyaUser/Views/UserManagement/_userMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Areas/eSyaUser/Views/_ViewImports.cshtml")]
    public class Areas_eSyaUser_Views_UserManagement__userMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(120, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(168, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(204, 259, true);
            WriteLiteral(@"<style>
    #PopupUserAction .modal-dialog {
        margin: 70px auto !important;
        width: 300px !important;
    }
</style>

<div class=""row"">
    <div class=""col-lg-4 col-md-4 col-sm-12"">
        <div class=""form-group"">
            <label> ");
            EndContext();
            BeginContext(464, 23, false);
#line 17 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaUser\Views\UserManagement\_userMenu.cshtml"
               Write(Localizer["SearchForm"]);

#line default
#line hidden
            EndContext();
            BeginContext(487, 574, true);
            WriteLiteral(@" </label>
            <input type=""text"" id=""txtSearch"" name=""Search"" value="""" class=""form-control"" />
        </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-lg-4 col-md-4 col-sm-6"">
        <div id=""jstUserGroup""></div>
    </div>
    <div id=""dvForm"" class=""col-lg-4 col-md-4 col-sm-6"">

        <div class=""demo-card-square mdl-card mdl-shadow--2dp marbot15 fullwidth"" id=""pnlAddForms"">
            <div class=""mdl-card__title mdl-card--expand padleft0 padtop0 d-block"">
                <h5 class=""mdl-card__title-text"" id=""UserActionTitle""> ");
            EndContext();
            BeginContext(1062, 23, false);
#line 30 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaUser\Views\UserManagement\_userMenu.cshtml"
                                                                  Write(Localizer["UserAction"]);

#line default
#line hidden
            EndContext();
            BeginContext(1085, 497, true);
            WriteLiteral(@" </h5>
            </div>
            <div class=""mdl-card__supporting-text fullwidth"">
                <div class=""col-lg-6 col-md-6 col-sm-12 pad0"">
                    <div class=""default-checkbox separate"">
                        <label class=""mdl-checkbox mdl-js-checkbox mdl-js-ripple-effect"" for=""chkFormName"">
                            <input type=""checkbox"" id=""chkFormName"" class=""mdl-checkbox__input"">
                            <span class=""mdl-checkbox__label lblFormName"">");
            EndContext();
            BeginContext(1583, 21, false);
#line 37 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaUser\Views\UserManagement\_userMenu.cshtml"
                                                                     Write(Localizer["FormName"]);

#line default
#line hidden
            EndContext();
            BeginContext(1604, 711, true);
            WriteLiteral(@"</span>
                        </label>
                    </div>
                </div>
                <div id=""dvFormAction"">

                    <div class=""col-lg-12 col-md-12 col-sm-12 pad0 padbot10"">
                        <table id=""jqgFormAction""></table>
                        <div id=""jqpFormAction""></div>
                    </div>
                    <hr />
                    <div class=""mdl-card__actions text-center pad0 form-group"">
                        <button type=""button"" class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent primary-button  mr-10"" id=""btnSaveFormAction"" onclick=""fnSaveFormAction();""> <i class=""fa fa-save""></i> ");
            EndContext();
            BeginContext(2316, 17, false);
#line 49 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaUser\Views\UserManagement\_userMenu.cshtml"
                                                                                                                                                                                                                                            Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(2333, 231, true);
            WriteLiteral("</button>\r\n                        <button type=\"button\" class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect  cancel-button\" id=\"btnCancelFormAction\" onclick=\"fnCancelFormAction();\"> <i class=\"fa fa-times\"></i> ");
            EndContext();
            BeginContext(2565, 19, false);
#line 50 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaUser\Views\UserManagement\_userMenu.cshtml"
                                                                                                                                                                                                                       Write(Localizer["Cancel"]);

#line default
#line hidden
            EndContext();
            BeginContext(2584, 128, true);
            WriteLiteral(" </button>\r\n\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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