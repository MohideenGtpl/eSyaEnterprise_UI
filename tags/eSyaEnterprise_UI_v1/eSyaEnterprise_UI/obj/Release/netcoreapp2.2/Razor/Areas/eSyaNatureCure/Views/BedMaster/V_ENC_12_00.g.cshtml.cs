#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\BedMaster\V_ENC_12_00.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8e13911f7236fb2b7cb8f97636b7f772d7d9f55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_eSyaNatureCure_Views_BedMaster_V_ENC_12_00), @"mvc.1.0.view", @"/Areas/eSyaNatureCure/Views/BedMaster/V_ENC_12_00.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/eSyaNatureCure/Views/BedMaster/V_ENC_12_00.cshtml", typeof(AspNetCore.Areas_eSyaNatureCure_Views_BedMaster_V_ENC_12_00))]
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
#line 2 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\BedMaster\V_ENC_12_00.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8e13911f7236fb2b7cb8f97636b7f772d7d9f55", @"/Areas/eSyaNatureCure/Views/BedMaster/V_ENC_12_00.cshtml")]
    public class Areas_eSyaNatureCure_Views_BedMaster_V_ENC_12_00 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/eSyaNatureCure/BedMaster.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 6 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\BedMaster\V_ENC_12_00.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(174, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8e13911f7236fb2b7cb8f97636b7f772d7d9f554011", async() => {
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
            BeginContext(230, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 11 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\BedMaster\V_ENC_12_00.cshtml"
  
    var userFormRole = (eSyaEnterprise_UI.Models.DO_UserFormRole)ViewBag.UserFormRole;

#line default
#line hidden
            BeginContext(327, 46, true);
            WriteLiteral("<script>\r\n    var _userFormRole = JSON.parse(\'");
            EndContext();
            BeginContext(374, 38, false);
#line 15 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\BedMaster\V_ENC_12_00.cshtml"
                               Write(Html.Raw(Json.Serialize(userFormRole)));

#line default
#line hidden
            EndContext();
            BeginContext(412, 56, true);
            WriteLiteral("\');\r\n\r\n     var localization = {\r\n         RoomTypeId: \'");
            EndContext();
            BeginContext(469, 23, false);
#line 18 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\BedMaster\V_ENC_12_00.cshtml"
                 Write(Localizer["RoomTypeId"]);

#line default
#line hidden
            EndContext();
            BeginContext(492, 26, true);
            WriteLiteral("\',\r\n         RoomNumber: \'");
            EndContext();
            BeginContext(519, 23, false);
#line 19 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\BedMaster\V_ENC_12_00.cshtml"
                 Write(Localizer["RoomNumber"]);

#line default
#line hidden
            EndContext();
            BeginContext(542, 25, true);
            WriteLiteral("\',\r\n         BedNumber: \'");
            EndContext();
            BeginContext(568, 22, false);
#line 20 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\BedMaster\V_ENC_12_00.cshtml"
                Write(Localizer["BedNumber"]);

#line default
#line hidden
            EndContext();
            BeginContext(590, 27, true);
            WriteLiteral("\',\r\n         RoomTypeDesc:\'");
            EndContext();
            BeginContext(618, 32, false);
#line 21 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\BedMaster\V_ENC_12_00.cshtml"
                  Write(Localizer["RoomTypeDescription"]);

#line default
#line hidden
            EndContext();
            BeginContext(650, 22, true);
            WriteLiteral("\',\r\n         Gender: \'");
            EndContext();
            BeginContext(673, 19, false);
#line 22 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\BedMaster\V_ENC_12_00.cshtml"
             Write(Localizer["Gender"]);

#line default
#line hidden
            EndContext();
            BeginContext(692, 30, true);
            WriteLiteral("\',\r\n         ReservedStatus: \'");
            EndContext();
            BeginContext(723, 27, false);
#line 23 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\BedMaster\V_ENC_12_00.cshtml"
                     Write(Localizer["ReservedStatus"]);

#line default
#line hidden
            EndContext();
            BeginContext(750, 25, true);
            WriteLiteral("\',\r\n         CheckedIn: \'");
            EndContext();
            BeginContext(776, 22, false);
#line 24 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\BedMaster\V_ENC_12_00.cshtml"
                Write(Localizer["CheckedIn"]);

#line default
#line hidden
            EndContext();
            BeginContext(798, 26, true);
            WriteLiteral("\',\r\n         CheckedOut: \'");
            EndContext();
            BeginContext(825, 23, false);
#line 25 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\BedMaster\V_ENC_12_00.cshtml"
                 Write(Localizer["CheckedOut"]);

#line default
#line hidden
            EndContext();
            BeginContext(848, 33, true);
            WriteLiteral("\',\r\n         ReadyForOccupancy: \'");
            EndContext();
            BeginContext(882, 30, false);
#line 26 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\BedMaster\V_ENC_12_00.cshtml"
                        Write(Localizer["ReadyForOccupancy"]);

#line default
#line hidden
            EndContext();
            BeginContext(912, 22, true);
            WriteLiteral("\',\r\n         Active: \'");
            EndContext();
            BeginContext(935, 19, false);
#line 27 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\BedMaster\V_ENC_12_00.cshtml"
             Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(954, 24, true);
            WriteLiteral("\',\r\n         RoomType: \'");
            EndContext();
            BeginContext(979, 21, false);
#line 28 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\BedMaster\V_ENC_12_00.cshtml"
               Write(Localizer["RoomType"]);

#line default
#line hidden
            EndContext();
            BeginContext(1000, 28, true);
            WriteLiteral("\',\r\n         AddBedMaster: \'");
            EndContext();
            BeginContext(1029, 25, false);
#line 29 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\BedMaster\V_ENC_12_00.cshtml"
                   Write(Localizer["AddBedMaster"]);

#line default
#line hidden
            EndContext();
            BeginContext(1054, 31, true);
            WriteLiteral("\',\r\n         UpdateBedMaster: \'");
            EndContext();
            BeginContext(1086, 28, false);
#line 30 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\BedMaster\V_ENC_12_00.cshtml"
                      Write(Localizer["UpdateBedMaster"]);

#line default
#line hidden
            EndContext();
            BeginContext(1114, 29, true);
            WriteLiteral("\',\r\n         ViewBedMaster: \'");
            EndContext();
            BeginContext(1144, 26, false);
#line 31 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\BedMaster\V_ENC_12_00.cshtml"
                    Write(Localizer["ViewBedMaster"]);

#line default
#line hidden
            EndContext();
            BeginContext(1170, 23, true);
            WriteLiteral("\',\r\n         Actions: \'");
            EndContext();
            BeginContext(1194, 20, false);
#line 32 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\BedMaster\V_ENC_12_00.cshtml"
              Write(Localizer["Actions"]);

#line default
#line hidden
            EndContext();
            BeginContext(1214, 20, true);
            WriteLiteral("\',\r\n         Edit: \'");
            EndContext();
            BeginContext(1235, 17, false);
#line 33 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\BedMaster\V_ENC_12_00.cshtml"
           Write(Localizer["Edit"]);

#line default
#line hidden
            EndContext();
            BeginContext(1252, 20, true);
            WriteLiteral("\',\r\n         View: \'");
            EndContext();
            BeginContext(1273, 17, false);
#line 34 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\BedMaster\V_ENC_12_00.cshtml"
           Write(Localizer["View"]);

#line default
#line hidden
            EndContext();
            BeginContext(1290, 20, true);
            WriteLiteral("\',\r\n         Save: \'");
            EndContext();
            BeginContext(1311, 17, false);
#line 35 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\BedMaster\V_ENC_12_00.cshtml"
           Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(1328, 22, true);
            WriteLiteral("\',\r\n         Update: \'");
            EndContext();
            BeginContext(1351, 19, false);
#line 36 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\BedMaster\V_ENC_12_00.cshtml"
             Write(Localizer["Update"]);

#line default
#line hidden
            EndContext();
            BeginContext(1370, 22, true);
            WriteLiteral("\',\r\n         Delete: \'");
            EndContext();
            BeginContext(1393, 19, false);
#line 37 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\BedMaster\V_ENC_12_00.cshtml"
             Write(Localizer["Delete"]);

#line default
#line hidden
            EndContext();
            BeginContext(1412, 24, true);
            WriteLiteral("\',\r\n         Activate: \'");
            EndContext();
            BeginContext(1437, 21, false);
#line 38 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\BedMaster\V_ENC_12_00.cshtml"
               Write(Localizer["Activate"]);

#line default
#line hidden
            EndContext();
            BeginContext(1458, 25, true);
            WriteLiteral("\',\r\n         DActivate: \'");
            EndContext();
            BeginContext(1484, 22, false);
#line 39 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\BedMaster\V_ENC_12_00.cshtml"
                Write(Localizer["DActivate"]);

#line default
#line hidden
            EndContext();
            BeginContext(1506, 256, true);
            WriteLiteral(@"',
    };

</script>
<style>
    .bootstrap-select {
        width: 100% !important;
    }

   
</style>

<div class=""row"">
    <div class=""col-lg-4 col-md-4 col-sm-6"">
        <div class=""form-group"">
            <label class=""lable-color"">");
            EndContext();
            BeginContext(1763, 21, false);
#line 54 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\BedMaster\V_ENC_12_00.cshtml"
                                  Write(Localizer["RoomType"]);

#line default
#line hidden
            EndContext();
            BeginContext(1784, 203, true);
            WriteLiteral(" </label>\r\n            <select class=\"selectpicker\" data-live-search=\"true\" id=\"cboRoomTypeId\" title=\"\" onchange=\"fnGridLoadBedMaster()\" data-size=\"10\">\r\n                <option value=\"0\"> All</option>\r\n");
            EndContext();
#line 57 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\BedMaster\V_ENC_12_00.cshtml"
                 if (ViewBag.RoomTypes != null)
                {
                    foreach (var roomtype in ViewBag.RoomTypes)
                    {

#line default
#line hidden
            BeginContext(2143, 31, true);
            WriteLiteral("                        <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2174, "\"", 2202, 1);
#line 61 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\BedMaster\V_ENC_12_00.cshtml"
WriteAttributeValue("", 2182, roomtype.RoomTypeId, 2182, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2203, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2205, 21, false);
#line 61 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\BedMaster\V_ENC_12_00.cshtml"
                                                        Write(roomtype.RoomTypeDesc);

#line default
#line hidden
            EndContext();
            BeginContext(2226, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 62 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\BedMaster\V_ENC_12_00.cshtml"
                    }

                }

#line default
#line hidden
            BeginContext(2281, 678, true);
            WriteLiteral(@"            </select>
        </div>
    </div>
</div>

<div class=""row padbot10"">
    <div class=""col-lg-12 col-md-12 col-sm-12 BedMastercontainer"">
        <table id=""jqgBedMaster""></table>
        <div id=""jqpBedMaster""></div>
    </div>
</div>

<div class=""modal fade in"" id=""PopupBedMaster"" data-keyboard=""false"" data-backdrop=""static"">
    <div class=""modal-dialog modal-lg"" role=""document"" style=""box-shadow:none;"">
        <div class=""modal-content"">
            <div class=""modal-header popupHeader"">
                <button type=""button"" class=""close"" data-dismiss=""modal""> <i class=""fa fa-times""></i></button>
                <h4 class=""modal-title"">");
            EndContext();
            BeginContext(2960, 22, false);
#line 82 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\BedMaster\V_ENC_12_00.cshtml"
                                   Write(Localizer["BedMaster"]);

#line default
#line hidden
            EndContext();
            BeginContext(2982, 111, true);
            WriteLiteral(" </h4>\r\n            </div>\r\n            <div class=\"modal-body\">\r\n                <div class=\"row padbot4\">\r\n\r\n");
            EndContext();
            BeginContext(3272, 181, true);
            WriteLiteral("\r\n                    <div class=\"col-lg-6  col-md-6 col-sm-12 col-xs-12\">\r\n                        <div class=\"form-group\">\r\n                            <label for=\"txtRoomNumber\">");
            EndContext();
            BeginContext(3454, 23, false);
#line 93 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\BedMaster\V_ENC_12_00.cshtml"
                                                  Write(Localizer["RoomNumber"]);

#line default
#line hidden
            EndContext();
            BeginContext(3477, 376, true);
            WriteLiteral(@" </label>
                            <input id=""txtRoomNumber"" class=""form-control"" type=""text"" autocomplete=""off"" maxlength=""15"" />
                        </div>
                    </div>

                    <div class=""col-lg-6  col-md-6 col-sm-12 col-xs-12"">
                        <div class=""form-group"">
                            <label for=""txtBedNumber"">");
            EndContext();
            BeginContext(3854, 22, false);
#line 100 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\BedMaster\V_ENC_12_00.cshtml"
                                                 Write(Localizer["BedNumber"]);

#line default
#line hidden
            EndContext();
            BeginContext(3876, 414, true);
            WriteLiteral(@" </label>
                            <input id=""txtBedNumber"" class=""form-control"" type=""text"" autocomplete=""off"" maxlength=""15"" />
                        </div>
                    </div>

                    <div class=""col-lg-4 col-md-4 col-sm-12 col-xs-12"">
                        <div class=""form-group"">
                            <div>
                                <label class=""lable-color"">");
            EndContext();
            BeginContext(4291, 19, false);
#line 108 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\BedMaster\V_ENC_12_00.cshtml"
                                                      Write(Localizer["Gender"]);

#line default
#line hidden
            EndContext();
            BeginContext(4310, 183, true);
            WriteLiteral(" </label>\r\n                                <select class=\"selectpicker\" data-live-search=\"false\" id=\"cboGender\" title=\"Select\">\r\n                                    <option value=\"M\">");
            EndContext();
            BeginContext(4494, 17, false);
#line 110 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\BedMaster\V_ENC_12_00.cshtml"
                                                 Write(Localizer["Male"]);

#line default
#line hidden
            EndContext();
            BeginContext(4511, 65, true);
            WriteLiteral("</option>\r\n                                    <option value=\"F\">");
            EndContext();
            BeginContext(4577, 19, false);
#line 111 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\BedMaster\V_ENC_12_00.cshtml"
                                                 Write(Localizer["Female"]);

#line default
#line hidden
            EndContext();
            BeginContext(4596, 65, true);
            WriteLiteral("</option>\r\n                                    <option value=\"B\">");
            EndContext();
            BeginContext(4662, 17, false);
#line 112 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\BedMaster\V_ENC_12_00.cshtml"
                                                 Write(Localizer["Both"]);

#line default
#line hidden
            EndContext();
            BeginContext(4679, 585, true);
            WriteLiteral(@"</option>
                                </select>
                            </div>
                        </div>
                    </div>


                    <div class=""col-lg-4 col-md-4 col-sm-12 col-xs-12"">
                        <div class=""default-checkbox separate"">
                            <label class=""mdl-checkbox mdl-js-checkbox mdl-js-ripple-effect"" for=""chkReservedStatus"">
                                <input type=""checkbox"" id=""chkReservedStatus"" class=""mdl-checkbox__input"">
                                <span class=""mdl-checkbox__label"">");
            EndContext();
            BeginContext(5265, 27, false);
#line 123 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\BedMaster\V_ENC_12_00.cshtml"
                                                             Write(Localizer["ReservedStatus"]);

#line default
#line hidden
            EndContext();
            BeginContext(5292, 531, true);
            WriteLiteral(@" </span>
                            </label>
                        </div>
                    </div>

                    <div class=""col-lg-4 col-md-4 col-sm-12 col-xs-12"">
                        <div class=""default-checkbox separate"">
                            <label class=""mdl-checkbox mdl-js-checkbox mdl-js-ripple-effect"" for=""chkCheckedIn"">
                                <input type=""checkbox"" id=""chkCheckedIn"" class=""mdl-checkbox__input"">
                                <span class=""mdl-checkbox__label"">");
            EndContext();
            BeginContext(5824, 22, false);
#line 132 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\BedMaster\V_ENC_12_00.cshtml"
                                                             Write(Localizer["CheckedIn"]);

#line default
#line hidden
            EndContext();
            BeginContext(5846, 533, true);
            WriteLiteral(@" </span>
                            </label>
                        </div>
                    </div>

                    <div class=""col-lg-4 col-md-4 col-sm-12 col-xs-12"">
                        <div class=""default-checkbox separate"">
                            <label class=""mdl-checkbox mdl-js-checkbox mdl-js-ripple-effect"" for=""chkCheckedOut"">
                                <input type=""checkbox"" id=""chkCheckedOut"" class=""mdl-checkbox__input"">
                                <span class=""mdl-checkbox__label"">");
            EndContext();
            BeginContext(6380, 23, false);
#line 141 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\BedMaster\V_ENC_12_00.cshtml"
                                                             Write(Localizer["CheckedOut"]);

#line default
#line hidden
            EndContext();
            BeginContext(6403, 547, true);
            WriteLiteral(@" </span>
                            </label>
                        </div>
                    </div>

                    <div class=""col-lg-4 col-md-4 col-sm-12 col-xs-12"">
                        <div class=""default-checkbox separate"">
                            <label class=""mdl-checkbox mdl-js-checkbox mdl-js-ripple-effect"" for=""chkReadyForOccupancy"">
                                <input type=""checkbox"" id=""chkReadyForOccupancy"" class=""mdl-checkbox__input"">
                                <span class=""mdl-checkbox__label"">");
            EndContext();
            BeginContext(6951, 30, false);
#line 150 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\BedMaster\V_ENC_12_00.cshtml"
                                                             Write(Localizer["ReadyForOccupancy"]);

#line default
#line hidden
            EndContext();
            BeginContext(6981, 537, true);
            WriteLiteral(@" </span>
                            </label>
                        </div>
                    </div>

                    <div class=""col-lg-4 col-md-4 col-sm-12 col-xs-12"">
                        <div class=""default-checkbox separate"">
                            <label class=""mdl-checkbox mdl-js-checkbox mdl-js-ripple-effect"" for=""chkActiveStatus"">
                                <input type=""checkbox"" id=""chkActiveStatus"" class=""mdl-checkbox__input"">
                                <span class=""mdl-checkbox__label"">");
            EndContext();
            BeginContext(7519, 19, false);
#line 159 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\BedMaster\V_ENC_12_00.cshtml"
                                                             Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(7538, 521, true);
            WriteLiteral(@" </span>
                            </label>
                        </div>
                    </div>

                </div>
            </div>
            <div class=""modal-footer"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <button class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent primary-button"" id=""btnSaveBedMaster"" onclick=""fnSaveBedMaster();"">
                            <i class=""fa fa-save""></i> ");
            EndContext();
            BeginContext(8060, 17, false);
#line 170 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\BedMaster\V_ENC_12_00.cshtml"
                                                  Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(8077, 244, true);
            WriteLiteral("\r\n                        </button>\r\n                        <button class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect  cancel-button cancel-button\" data-dismiss=\"modal\" id=\"btnCancelBedMaster\"><i class=\"fa fa-times\"></i> ");
            EndContext();
            BeginContext(8322, 19, false);
#line 172 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\BedMaster\V_ENC_12_00.cshtml"
                                                                                                                                                                                                          Write(Localizer["Cancel"]);

#line default
#line hidden
            EndContext();
            BeginContext(8341, 202, true);
            WriteLiteral(" </button>\r\n                        <button class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect\" id=\"btndeActiveBedMaster\" onclick=\"fnDeleteBedMaster();\"><i class=\"fa fa-times\"></i> ");
            EndContext();
            BeginContext(8544, 23, false);
#line 173 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\BedMaster\V_ENC_12_00.cshtml"
                                                                                                                                                                                         Write(Localizer["DeActivate"]);

#line default
#line hidden
            EndContext();
            BeginContext(8567, 142, true);
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
