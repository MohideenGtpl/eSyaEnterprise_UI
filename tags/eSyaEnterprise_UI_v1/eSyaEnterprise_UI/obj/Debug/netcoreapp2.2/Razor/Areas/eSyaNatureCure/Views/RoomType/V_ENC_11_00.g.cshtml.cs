#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomType\V_ENC_11_00.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "285dbab48a98acc4b2bbf0b92a160dae2fa0a6e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_eSyaNatureCure_Views_RoomType_V_ENC_11_00), @"mvc.1.0.view", @"/Areas/eSyaNatureCure/Views/RoomType/V_ENC_11_00.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/eSyaNatureCure/Views/RoomType/V_ENC_11_00.cshtml", typeof(AspNetCore.Areas_eSyaNatureCure_Views_RoomType_V_ENC_11_00))]
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
#line 1 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomType\V_ENC_11_00.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"285dbab48a98acc4b2bbf0b92a160dae2fa0a6e5", @"/Areas/eSyaNatureCure/Views/RoomType/V_ENC_11_00.cshtml")]
    public class Areas_eSyaNatureCure_Views_RoomType_V_ENC_11_00 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/eSyaNatureCure/RoomType.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomType\V_ENC_11_00.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(172, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "285dbab48a98acc4b2bbf0b92a160dae2fa0a6e53960", async() => {
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
            BeginContext(227, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 10 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomType\V_ENC_11_00.cshtml"
  
    var userFormRole = (eSyaEnterprise_UI.Models.DO_UserFormRole)ViewBag.UserFormRole;

#line default
#line hidden
            BeginContext(324, 46, true);
            WriteLiteral("<script>\r\n    var _userFormRole = JSON.parse(\'");
            EndContext();
            BeginContext(371, 38, false);
#line 14 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomType\V_ENC_11_00.cshtml"
                               Write(Html.Raw(Json.Serialize(userFormRole)));

#line default
#line hidden
            EndContext();
            BeginContext(409, 56, true);
            WriteLiteral("\');\r\n\r\n     var localization = {\r\n         RoomTypeId: \'");
            EndContext();
            BeginContext(466, 23, false);
#line 17 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomType\V_ENC_11_00.cshtml"
                 Write(Localizer["RoomTypeId"]);

#line default
#line hidden
            EndContext();
            BeginContext(489, 27, true);
            WriteLiteral("\',\r\n         Description: \'");
            EndContext();
            BeginContext(517, 24, false);
#line 18 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomType\V_ENC_11_00.cshtml"
                  Write(Localizer["Description"]);

#line default
#line hidden
            EndContext();
            BeginContext(541, 23, true);
            WriteLiteral("\',\r\n         BedType: \'");
            EndContext();
            BeginContext(565, 20, false);
#line 19 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomType\V_ENC_11_00.cshtml"
              Write(Localizer["BedType"]);

#line default
#line hidden
            EndContext();
            BeginContext(585, 22, true);
            WriteLiteral("\',\r\n         SqFeet: \'");
            EndContext();
            BeginContext(608, 19, false);
#line 20 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomType\V_ENC_11_00.cshtml"
             Write(Localizer["SqFeet"]);

#line default
#line hidden
            EndContext();
            BeginContext(627, 28, true);
            WriteLiteral("\',\r\n         MaxOccupancy: \'");
            EndContext();
            BeginContext(656, 25, false);
#line 21 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomType\V_ENC_11_00.cshtml"
                   Write(Localizer["MaxOccupancy"]);

#line default
#line hidden
            EndContext();
            BeginContext(681, 29, true);
            WriteLiteral("\',\r\n         SharingStatus: \'");
            EndContext();
            BeginContext(711, 26, false);
#line 22 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomType\V_ENC_11_00.cshtml"
                    Write(Localizer["SharingStatus"]);

#line default
#line hidden
            EndContext();
            BeginContext(737, 22, true);
            WriteLiteral("\',\r\n         Active: \'");
            EndContext();
            BeginContext(760, 19, false);
#line 23 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomType\V_ENC_11_00.cshtml"
             Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(779, 24, true);
            WriteLiteral("\',\r\n         RoomType: \'");
            EndContext();
            BeginContext(804, 21, false);
#line 24 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomType\V_ENC_11_00.cshtml"
               Write(Localizer["RoomType"]);

#line default
#line hidden
            EndContext();
            BeginContext(825, 27, true);
            WriteLiteral("\',\r\n         AddRoomType: \'");
            EndContext();
            BeginContext(853, 24, false);
#line 25 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomType\V_ENC_11_00.cshtml"
                  Write(Localizer["AddRoomType"]);

#line default
#line hidden
            EndContext();
            BeginContext(877, 30, true);
            WriteLiteral("\',\r\n         UpdateRoomType: \'");
            EndContext();
            BeginContext(908, 27, false);
#line 26 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomType\V_ENC_11_00.cshtml"
                     Write(Localizer["UpdateRoomType"]);

#line default
#line hidden
            EndContext();
            BeginContext(935, 28, true);
            WriteLiteral("\',\r\n         ViewRoomType: \'");
            EndContext();
            BeginContext(964, 25, false);
#line 27 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomType\V_ENC_11_00.cshtml"
                   Write(Localizer["ViewRoomType"]);

#line default
#line hidden
            EndContext();
            BeginContext(989, 23, true);
            WriteLiteral("\',\r\n         Actions: \'");
            EndContext();
            BeginContext(1013, 20, false);
#line 28 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomType\V_ENC_11_00.cshtml"
              Write(Localizer["Actions"]);

#line default
#line hidden
            EndContext();
            BeginContext(1033, 20, true);
            WriteLiteral("\',\r\n         Edit: \'");
            EndContext();
            BeginContext(1054, 17, false);
#line 29 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomType\V_ENC_11_00.cshtml"
           Write(Localizer["Edit"]);

#line default
#line hidden
            EndContext();
            BeginContext(1071, 20, true);
            WriteLiteral("\',\r\n         View: \'");
            EndContext();
            BeginContext(1092, 17, false);
#line 30 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomType\V_ENC_11_00.cshtml"
           Write(Localizer["View"]);

#line default
#line hidden
            EndContext();
            BeginContext(1109, 20, true);
            WriteLiteral("\',\r\n         Save: \'");
            EndContext();
            BeginContext(1130, 17, false);
#line 31 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomType\V_ENC_11_00.cshtml"
           Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(1147, 22, true);
            WriteLiteral("\',\r\n         Update: \'");
            EndContext();
            BeginContext(1170, 19, false);
#line 32 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomType\V_ENC_11_00.cshtml"
             Write(Localizer["Update"]);

#line default
#line hidden
            EndContext();
            BeginContext(1189, 22, true);
            WriteLiteral("\',\r\n         Delete: \'");
            EndContext();
            BeginContext(1212, 19, false);
#line 33 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomType\V_ENC_11_00.cshtml"
             Write(Localizer["Delete"]);

#line default
#line hidden
            EndContext();
            BeginContext(1231, 24, true);
            WriteLiteral("\',\r\n         Activate: \'");
            EndContext();
            BeginContext(1256, 21, false);
#line 34 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomType\V_ENC_11_00.cshtml"
               Write(Localizer["Activate"]);

#line default
#line hidden
            EndContext();
            BeginContext(1277, 25, true);
            WriteLiteral("\',\r\n         DActivate: \'");
            EndContext();
            BeginContext(1303, 22, false);
#line 35 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomType\V_ENC_11_00.cshtml"
                Write(Localizer["DActivate"]);

#line default
#line hidden
            EndContext();
            BeginContext(1325, 642, true);
            WriteLiteral(@"',
    };

</script>


<div class=""row padbot10"">
    <div class=""col-lg-12 col-md-12 col-sm-12 RoomTypecontainer"">
        <table id=""jqgRoomType""></table>
        <div id=""jqpRoomType""></div>
    </div>
</div>

<div class=""modal fade in"" id=""PopupRoomType"" data-keyboard=""false"" data-backdrop=""static"">
    <div class=""modal-dialog modal-lg"" role=""document"" style=""box-shadow:none;"">
        <div class=""modal-content"">
            <div class=""modal-header popupHeader"">
                <button type=""button"" class=""close"" data-dismiss=""modal""> <i class=""fa fa-times""></i></button>
                <h4 class=""modal-title"">");
            EndContext();
            BeginContext(1968, 21, false);
#line 53 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomType\V_ENC_11_00.cshtml"
                                   Write(Localizer["RoomType"]);

#line default
#line hidden
            EndContext();
            BeginContext(1989, 440, true);
            WriteLiteral(@" </h4>
            </div>
            <div class=""modal-body"">
                <div class=""row padbot4"">
                    <div class=""col-sm-12"">
                        <input type=""text"" class=""form-control"" id=""txtRoomTypeId"" style=""display:none"">
                    </div>
                    <div class=""col-lg-12"">
                        <div class=""form-group"">
                            <label for=""txtRoomTypedesc"">");
            EndContext();
            BeginContext(2430, 32, false);
#line 62 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomType\V_ENC_11_00.cshtml"
                                                    Write(Localizer["RoomTypeDescription"]);

#line default
#line hidden
            EndContext();
            BeginContext(2462, 407, true);
            WriteLiteral(@" </label>
                            <input id=""txtRoomTypedesc"" class=""form-control"" type=""text"" autocomplete=""off"" maxlength=""150"" />
                        </div>
                    </div>

                    <div class=""col-lg-3 col-md-6 col-sm-6"">
                        <div class=""form-group"">
                            <div>
                                <label class=""lable-color"">");
            EndContext();
            BeginContext(2870, 20, false);
#line 70 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomType\V_ENC_11_00.cshtml"
                                                      Write(Localizer["BedType"]);

#line default
#line hidden
            EndContext();
            BeginContext(2890, 178, true);
            WriteLiteral(" </label>\r\n                                <select class=\"selectpicker\" data-live-search=\"false\" id=\"cboBedType\" title=\"\">\r\n                                    <option value=\"T\">");
            EndContext();
            BeginContext(3069, 20, false);
#line 72 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomType\V_ENC_11_00.cshtml"
                                                 Write(Localizer["TwinBed"]);

#line default
#line hidden
            EndContext();
            BeginContext(3089, 65, true);
            WriteLiteral("</option>\r\n                                    <option value=\"S\">");
            EndContext();
            BeginContext(3155, 22, false);
#line 73 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomType\V_ENC_11_00.cshtml"
                                                 Write(Localizer["SingleBed"]);

#line default
#line hidden
            EndContext();
            BeginContext(3177, 328, true);
            WriteLiteral(@"</option>
                                </select>
                            </div>
                        </div>
                    </div>

                    <div class=""col-lg-6  col-md-6 col-sm-12 col-xs-12"">
                        <div class=""form-group"">
                            <label for=""txtSqFeet""> ");
            EndContext();
            BeginContext(3506, 19, false);
#line 81 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomType\V_ENC_11_00.cshtml"
                                               Write(Localizer["SqFeet"]);

#line default
#line hidden
            EndContext();
            BeginContext(3525, 358, true);
            WriteLiteral(@"</label>
                            <input id=""txtSqFeet"" class=""form-control"" maxlength=""15"" type=""text"" />

                        </div>
                    </div>

                    <div class=""col-lg-3  col-md-3 col-sm-12 col-xs-12"">
                        <div class=""form-group"">
                            <label for=""txtMaxOccupancy""> ");
            EndContext();
            BeginContext(3884, 25, false);
#line 89 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomType\V_ENC_11_00.cshtml"
                                                     Write(Localizer["MaxOccupancy"]);

#line default
#line hidden
            EndContext();
            BeginContext(3909, 669, true);
            WriteLiteral(@"</label>
                            <input class=""form-control"" type=""text"" maxlength=""8"" id=""txtMaxOccupancy"" data-inputmask=""'mask': '9', 'repeat': 10, 'greedy' : false"" />

                        </div>
                    </div>
                    <div class=""col-lg-3 col-md-4 col-sm-12 col-xs-12"">
                        <div class=""default-checkbox separate"">
                            <label class=""mdl-checkbox mdl-js-checkbox mdl-js-ripple-effect"" for=""chkSharingStatus"">
                                <input type=""checkbox"" id=""chkSharingStatus"" class=""mdl-checkbox__input"">
                                <span class=""mdl-checkbox__label"">");
            EndContext();
            BeginContext(4579, 26, false);
#line 98 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomType\V_ENC_11_00.cshtml"
                                                             Write(Localizer["SharingStatus"]);

#line default
#line hidden
            EndContext();
            BeginContext(4605, 537, true);
            WriteLiteral(@" </span>
                            </label>
                        </div>
                    </div>

                    <div class=""col-lg-3 col-md-4 col-sm-12 col-xs-12"">
                        <div class=""default-checkbox separate"">
                            <label class=""mdl-checkbox mdl-js-checkbox mdl-js-ripple-effect"" for=""chkActiveStatus"">
                                <input type=""checkbox"" id=""chkActiveStatus"" class=""mdl-checkbox__input"">
                                <span class=""mdl-checkbox__label"">");
            EndContext();
            BeginContext(5143, 19, false);
#line 107 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomType\V_ENC_11_00.cshtml"
                                                             Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(5162, 517, true);
            WriteLiteral(@" </span>
                            </label>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""modal-footer"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <button class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent primary-button"" id=""btnSaveRoomType"" onclick=""fnSaveRoomType();"">
                            <i class=""fa fa-save""></i> ");
            EndContext();
            BeginContext(5680, 17, false);
#line 117 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomType\V_ENC_11_00.cshtml"
                                                  Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(5697, 243, true);
            WriteLiteral("\r\n                        </button>\r\n                        <button class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect  cancel-button cancel-button\" data-dismiss=\"modal\" id=\"btnCancelRoomType\"><i class=\"fa fa-times\"></i> ");
            EndContext();
            BeginContext(5941, 19, false);
#line 119 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomType\V_ENC_11_00.cshtml"
                                                                                                                                                                                                         Write(Localizer["Cancel"]);

#line default
#line hidden
            EndContext();
            BeginContext(5960, 200, true);
            WriteLiteral(" </button>\r\n                        <button class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect\" id=\"btndeActiveRoomType\" onclick=\"fnDeleteRoomType();\"><i class=\"fa fa-times\"></i> ");
            EndContext();
            BeginContext(6161, 23, false);
#line 120 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomType\V_ENC_11_00.cshtml"
                                                                                                                                                                                       Write(Localizer["DeActivate"]);

#line default
#line hidden
            EndContext();
            BeginContext(6184, 126, true);
            WriteLiteral(" </button>\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
