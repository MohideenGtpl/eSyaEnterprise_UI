#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Views\UserProfile\ResetPassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57d4d25bdd4c575f3bf346995833e88c60ef6a1d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserProfile_ResetPassword), @"mvc.1.0.view", @"/Views/UserProfile/ResetPassword.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserProfile/ResetPassword.cshtml", typeof(AspNetCore.Views_UserProfile_ResetPassword))]
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
#line 1 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Views\_ViewImports.cshtml"
using eSyaEnterprise_UI;

#line default
#line hidden
#line 2 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Views\_ViewImports.cshtml"
using eSyaEnterprise_UI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57d4d25bdd4c575f3bf346995833e88c60ef6a1d", @"/Views/UserProfile/ResetPassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"110a014d2bbd077c913f923d324696e29a0b05f7", @"/Views/_ViewImports.cshtml")]
    public class Views_UserProfile_ResetPassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Views\UserProfile\ResetPassword.cshtml"
  
    ViewData["Title"] = "ResetPassword";

#line default
#line hidden
            BeginContext(51, 3277, true);
            WriteLiteral(@"
<style>

    .pass_show {
        position: relative
    }

        .pass_show .ptxt {
            position: absolute;
            top: 50%;
            right: 10px;
            z-index: 1;
            color: #fada28;
            margin-top: -10px;
            cursor: pointer;
            transition: .3s ease all;
        }

            .pass_show .ptxt:hover {
                color: #333333;
            }
</style>


<div class=""row"">
    <div class=""col-sm-4"">

        <label>Current Password</label>
        <div class=""form-group pass_show"">
            <input type=""password"" id=""txtCurrentPassword"" value="""" class=""form-control"" placeholder=""Current Password"">
        </div>
        <label>New Password</label>
        <div class=""form-group pass_show"">
            <input type=""password"" id=""txtNewPassword"" class=""form-control"" placeholder=""New Password"">
        </div>
        <label>Confirm Password</label>
        <div class=""form-group pass_show"">
            <input ");
            WriteLiteral(@"type=""password"" id=""txtConfirmPassword"" class=""form-control"" placeholder=""Confirm Password"">
        </div>

    </div>
</div>
    <div class=""col-sm-4"" style=""text-align:center"">
        <button type=""button"" class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect m-r-15"" id=""btnSave"" onclick=""fnSave()""> Update </button>
        <button type=""button"" class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect"" id=""btnClear"" onclick=""fnClear()""> Clear</button>
    </div>

    <script>
        $(document).ready(function () {
            $('.pass_show').append('<span class=""ptxt"">Show</span>');
        });


        $(document).on('click', '.pass_show .ptxt', function () {

            $(this).text($(this).text() == ""Show"" ? ""Hide"" : ""Show"");

            $(this).prev().attr('type', function (index, attr) { return attr == 'password' ? 'text' : 'password'; });

        });


        function fnSave() {
            $(""#btnSave"").attr(""disabled"", true);
      ");
            WriteLiteral(@"      $.ajax({
                url: getBaseURL() + '/UserProfile/ResetUserPassword',
                type: 'POST',
                datatype: 'json',
                data: {
                    currentPassword: $(""#txtCurrentPassword"").val(),
                    newPassword: $(""#txtNewPassword"").val(),
                    confirmPassword: $(""#txtConfirmPassword"").val()
                },
                async: false,
                success: function (response) {

                    if (response.Status == true) {
                        toastr.success(""Updated"");
                        fnClear();
                    }
                    else {
                        toastr.error(response.Message);
                    }
                    $(""#btnSave"").attr(""disabled"", false);
                },
                error: function (error) {
                    toastr.error(error.statusText);
                    $(""#btnSave"").attr(""disabled"", false);
                }
            });
 ");
            WriteLiteral("       }\r\n\r\n        function fnClear() {\r\n            $(\"#txtCurrentPassword\").val(\"\");\r\n            $(\"#txtNewPassword\").val(\"\")\r\n            $(\"#txtConfirmPassword\").val(\"\")\r\n        }\r\n\r\n    </script>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
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