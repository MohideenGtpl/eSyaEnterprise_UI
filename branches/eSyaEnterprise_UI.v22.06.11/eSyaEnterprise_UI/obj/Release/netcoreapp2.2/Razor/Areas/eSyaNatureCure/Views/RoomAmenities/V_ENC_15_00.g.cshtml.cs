#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomAmenities\V_ENC_15_00.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "256fdbf141d06cc43d3febce3ad2226c87214ba0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_eSyaNatureCure_Views_RoomAmenities_V_ENC_15_00), @"mvc.1.0.view", @"/Areas/eSyaNatureCure/Views/RoomAmenities/V_ENC_15_00.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/eSyaNatureCure/Views/RoomAmenities/V_ENC_15_00.cshtml", typeof(AspNetCore.Areas_eSyaNatureCure_Views_RoomAmenities_V_ENC_15_00))]
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
#line 2 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomAmenities\V_ENC_15_00.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"256fdbf141d06cc43d3febce3ad2226c87214ba0", @"/Areas/eSyaNatureCure/Views/RoomAmenities/V_ENC_15_00.cshtml")]
    public class Areas_eSyaNatureCure_Views_RoomAmenities_V_ENC_15_00 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/eSyaNatureCure/RoomAmenities.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 6 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomAmenities\V_ENC_15_00.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(174, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "256fdbf141d06cc43d3febce3ad2226c87214ba04051", async() => {
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
            BeginContext(234, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 11 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomAmenities\V_ENC_15_00.cshtml"
  
    var userFormRole = (eSyaEnterprise_UI.Models.DO_UserFormRole)ViewBag.UserFormRoles;

#line default
#line hidden
            BeginContext(332, 46, true);
            WriteLiteral("<script>\r\n    var _userFormRole = JSON.parse(\'");
            EndContext();
            BeginContext(379, 38, false);
#line 15 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomAmenities\V_ENC_15_00.cshtml"
                               Write(Html.Raw(Json.Serialize(userFormRole)));

#line default
#line hidden
            EndContext();
            BeginContext(417, 56, true);
            WriteLiteral("\');\r\n\r\n     var localization = {\r\n         RoomTypeId: \'");
            EndContext();
            BeginContext(474, 23, false);
#line 18 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomAmenities\V_ENC_15_00.cshtml"
                 Write(Localizer["RoomTypeId"]);

#line default
#line hidden
            EndContext();
            BeginContext(497, 27, true);
            WriteLiteral("\',\r\n         RoomTypeDesc:\'");
            EndContext();
            BeginContext(525, 32, false);
#line 19 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomAmenities\V_ENC_15_00.cshtml"
                  Write(Localizer["RoomTypeDescription"]);

#line default
#line hidden
            EndContext();
            BeginContext(557, 28, true);
            WriteLiteral("\',\r\n         SerialNumber: \'");
            EndContext();
            BeginContext(586, 25, false);
#line 20 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomAmenities\V_ENC_15_00.cshtml"
                   Write(Localizer["SerialNumber"]);

#line default
#line hidden
            EndContext();
            BeginContext(611, 28, true);
            WriteLiteral("\',\r\n         OptionValues: \'");
            EndContext();
            BeginContext(640, 25, false);
#line 21 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomAmenities\V_ENC_15_00.cshtml"
                   Write(Localizer["OptionValues"]);

#line default
#line hidden
            EndContext();
            BeginContext(665, 26, true);
            WriteLiteral("\',\r\n         OptionDesc: \'");
            EndContext();
            BeginContext(692, 30, false);
#line 22 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomAmenities\V_ENC_15_00.cshtml"
                 Write(Localizer["OptionDescription"]);

#line default
#line hidden
            EndContext();
            BeginContext(722, 22, true);
            WriteLiteral("\',\r\n         Active: \'");
            EndContext();
            BeginContext(745, 19, false);
#line 23 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomAmenities\V_ENC_15_00.cshtml"
             Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(764, 32, true);
            WriteLiteral("\',\r\n         AddRoomAmenities: \'");
            EndContext();
            BeginContext(797, 29, false);
#line 24 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomAmenities\V_ENC_15_00.cshtml"
                       Write(Localizer["AddRoomAmenities"]);

#line default
#line hidden
            EndContext();
            BeginContext(826, 35, true);
            WriteLiteral("\',\r\n         UpdateRoomAmenities: \'");
            EndContext();
            BeginContext(862, 32, false);
#line 25 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomAmenities\V_ENC_15_00.cshtml"
                          Write(Localizer["UpdateRoomAmenities"]);

#line default
#line hidden
            EndContext();
            BeginContext(894, 33, true);
            WriteLiteral("\',\r\n         ViewRoomAmenities: \'");
            EndContext();
            BeginContext(928, 30, false);
#line 26 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomAmenities\V_ENC_15_00.cshtml"
                        Write(Localizer["ViewRoomAmenities"]);

#line default
#line hidden
            EndContext();
            BeginContext(958, 23, true);
            WriteLiteral("\',\r\n         Actions: \'");
            EndContext();
            BeginContext(982, 20, false);
#line 27 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomAmenities\V_ENC_15_00.cshtml"
              Write(Localizer["Actions"]);

#line default
#line hidden
            EndContext();
            BeginContext(1002, 20, true);
            WriteLiteral("\',\r\n         Edit: \'");
            EndContext();
            BeginContext(1023, 17, false);
#line 28 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomAmenities\V_ENC_15_00.cshtml"
           Write(Localizer["Edit"]);

#line default
#line hidden
            EndContext();
            BeginContext(1040, 20, true);
            WriteLiteral("\',\r\n         View: \'");
            EndContext();
            BeginContext(1061, 17, false);
#line 29 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomAmenities\V_ENC_15_00.cshtml"
           Write(Localizer["View"]);

#line default
#line hidden
            EndContext();
            BeginContext(1078, 20, true);
            WriteLiteral("\',\r\n         Save: \'");
            EndContext();
            BeginContext(1099, 17, false);
#line 30 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomAmenities\V_ENC_15_00.cshtml"
           Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(1116, 22, true);
            WriteLiteral("\',\r\n         Update: \'");
            EndContext();
            BeginContext(1139, 19, false);
#line 31 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomAmenities\V_ENC_15_00.cshtml"
             Write(Localizer["Update"]);

#line default
#line hidden
            EndContext();
            BeginContext(1158, 22, true);
            WriteLiteral("\',\r\n         Delete: \'");
            EndContext();
            BeginContext(1181, 19, false);
#line 32 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomAmenities\V_ENC_15_00.cshtml"
             Write(Localizer["Delete"]);

#line default
#line hidden
            EndContext();
            BeginContext(1200, 24, true);
            WriteLiteral("\',\r\n         Activate: \'");
            EndContext();
            BeginContext(1225, 21, false);
#line 33 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomAmenities\V_ENC_15_00.cshtml"
               Write(Localizer["Activate"]);

#line default
#line hidden
            EndContext();
            BeginContext(1246, 25, true);
            WriteLiteral("\',\r\n         DActivate: \'");
            EndContext();
            BeginContext(1272, 22, false);
#line 34 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomAmenities\V_ENC_15_00.cshtml"
                Write(Localizer["DActivate"]);

#line default
#line hidden
            EndContext();
            BeginContext(1294, 26, true);
            WriteLiteral("\',\r\n         OptionType: \'");
            EndContext();
            BeginContext(1321, 23, false);
#line 35 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomAmenities\V_ENC_15_00.cshtml"
                 Write(Localizer["OptionType"]);

#line default
#line hidden
            EndContext();
            BeginContext(1344, 249, true);
            WriteLiteral("\',\r\n    };\r\n\r\n</script>\r\n<style>\r\n    .bootstrap-select {\r\n        width: 100% !important;\r\n    }\r\n</style>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-lg-4 col-md-4 col-sm-6\">\r\n        <div class=\"form-group\">\r\n            <label class=\"lable-color\">");
            EndContext();
            BeginContext(1594, 21, false);
#line 48 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomAmenities\V_ENC_15_00.cshtml"
                                  Write(Localizer["RoomType"]);

#line default
#line hidden
            EndContext();
            BeginContext(1615, 203, true);
            WriteLiteral(" </label>\r\n            <select class=\"selectpicker\" data-live-search=\"true\" id=\"cboRoomTypeId\" title=\"\" onchange=\"fnGridRoomAminities()\" data-size=\"10\">\r\n                <option value=\"0\"> All</option>\r\n");
            EndContext();
#line 51 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomAmenities\V_ENC_15_00.cshtml"
                 if (ViewBag.RoomTypes != null)
                {
                    foreach (var roomtype in ViewBag.RoomTypes)
                    {

#line default
#line hidden
            BeginContext(1974, 31, true);
            WriteLiteral("                        <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2005, "\"", 2033, 1);
#line 55 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomAmenities\V_ENC_15_00.cshtml"
WriteAttributeValue("", 2013, roomtype.RoomTypeId, 2013, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2034, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2036, 21, false);
#line 55 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomAmenities\V_ENC_15_00.cshtml"
                                                        Write(roomtype.RoomTypeDesc);

#line default
#line hidden
            EndContext();
            BeginContext(2057, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 56 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomAmenities\V_ENC_15_00.cshtml"
                    }

                }

#line default
#line hidden
            BeginContext(2112, 694, true);
            WriteLiteral(@"            </select>
        </div>
    </div>
</div>

<div class=""row padbot10"">
    <div class=""col-lg-12 col-md-12 col-sm-12 RoomAmenitiescontainer"">
        <table id=""jqgRoomAmenities""></table>
        <div id=""jqpRoomAmenities""></div>
    </div>
</div>

<div class=""modal fade in"" id=""PopupRoomAmenities"" data-keyboard=""false"" data-backdrop=""static"">
    <div class=""modal-dialog modal-lg"" role=""document"" style=""box-shadow:none;"">
        <div class=""modal-content"">
            <div class=""modal-header popupHeader"">
                <button type=""button"" class=""close"" data-dismiss=""modal""> <i class=""fa fa-times""></i></button>
                <h4 class=""modal-title"">");
            EndContext();
            BeginContext(2807, 26, false);
#line 76 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomAmenities\V_ENC_15_00.cshtml"
                                   Write(Localizer["RoomAmenities"]);

#line default
#line hidden
            EndContext();
            BeginContext(2833, 115, true);
            WriteLiteral(" </h4>\r\n            </div>\r\n            <div class=\"modal-body\">\r\n                <div class=\"row padbot4\">\r\n\r\n\r\n\r\n");
            EndContext();
            BeginContext(3371, 218, true);
            WriteLiteral("                    <div class=\"col-lg-6  col-md-6 col-sm-12 col-xs-12\">\r\n                        <div class=\"form-group\">\r\n                            <div>\r\n                                <label class=\"lable-color\">");
            EndContext();
            BeginContext(3590, 23, false);
#line 92 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomAmenities\V_ENC_15_00.cshtml"
                                                      Write(Localizer["OptionType"]);

#line default
#line hidden
            EndContext();
            BeginContext(3613, 1091, true);
            WriteLiteral(@" </label>
                                <select class=""selectpicker"" data-live-search=""false"" id=""cboOptionType"" title="""" onchange=""fnHideshowImageDiv(this);"">
                                    <option value=""0"">Select</option>
                                    <option value=""Amenities"">Amenities</option>
                                    <option value=""IMG"">IMG</option>
                                    <option value=""Inclusions"">Inclusions</option>
                                    <option value=""Refundpolicy"">Refund Policy</option>
                                    <option value=""CancellationPolicy"">Cancellation Policy</option>
                                    <option value=""TXT"">TXT</option>
                                    
                                </select>
                            </div>
                        </div>
                    </div>

                    <div class=""col-lg-6  col-md-6 col-sm-12 col-xs-12"">
                        <div class=""form");
            WriteLiteral("-group\">\r\n                            <label for=\"txtSerialNumber\">");
            EndContext();
            BeginContext(4705, 25, false);
#line 109 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomAmenities\V_ENC_15_00.cshtml"
                                                    Write(Localizer["SerialNumber"]);

#line default
#line hidden
            EndContext();
            BeginContext(4730, 414, true);
            WriteLiteral(@" </label>
                            <input id=""txtSerialNumber"" class=""form-control"" maxlength=""9"" type=""text"" data-inputmask=""'mask': '9', 'repeat': 10, 'greedy' : false"" />
                        </div>
                    </div>

                    <div class=""col-lg-4 col-md-4 col-sm-12 col-xs-12"" id=""divimage"">
                        <div class=""form-group"">
                            <label> ");
            EndContext();
            BeginContext(5145, 18, false);
#line 116 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomAmenities\V_ENC_15_00.cshtml"
                               Write(Localizer["Photo"]);

#line default
#line hidden
            EndContext();
            BeginContext(5163, 762, true);
            WriteLiteral(@" <span class=""lblInfo""> (Only Jpg & png format)</span></label>
                            <div class=""imagedig"" style=""border:thin; padding-bottom:5px;"" id=""imgPhoto"">
                                <img id=""imgPhotoimageblah"" src="""">
                                <input class=""mdl-textfield__input fullwidth FileUpload"" id=""Photoimage"" type=""file"" name=""file"" onchange=""readPhotoimage(this);"" accept='image/*' enctype=""multipart/form-data"" style=""border-bottom:none !important"" />
                            </div>
                        </div>
                    </div>


                    <div class=""col-lg-12"" id=""divOptionValue"">
                        <div class=""form-group"">
                            <label for=""txtOptionValue"">");
            EndContext();
            BeginContext(5926, 24, false);
#line 127 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomAmenities\V_ENC_15_00.cshtml"
                                                   Write(Localizer["OptionValue"]);

#line default
#line hidden
            EndContext();
            BeginContext(5950, 348, true);
            WriteLiteral(@" </label>
                            <input id=""txtOptionValue"" class=""form-control"" type=""text"" autocomplete=""off"" maxlength=""500"" />
                        </div>
                    </div>
                    <div class=""col-lg-12"">
                        <div class=""form-group"">
                            <label for=""txtOptionDesc"">");
            EndContext();
            BeginContext(6299, 30, false);
#line 133 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomAmenities\V_ENC_15_00.cshtml"
                                                  Write(Localizer["OptionDescription"]);

#line default
#line hidden
            EndContext();
            BeginContext(6329, 628, true);
            WriteLiteral(@" </label>
                            <input id=""txtOptionDesc"" class=""form-control"" type=""text"" autocomplete=""off"" maxlength=""500"" />
                        </div>
                    </div>


                    <div class=""col-lg-4 col-md-4 col-sm-12 col-xs-12"">
                        <div class=""default-checkbox separate"">
                            <label class=""mdl-checkbox mdl-js-checkbox mdl-js-ripple-effect"" for=""chkActiveStatus"">
                                <input type=""checkbox"" id=""chkActiveStatus"" class=""mdl-checkbox__input"">
                                <span class=""mdl-checkbox__label"">");
            EndContext();
            BeginContext(6958, 19, false);
#line 143 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomAmenities\V_ENC_15_00.cshtml"
                                                             Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(6977, 529, true);
            WriteLiteral(@" </span>
                            </label>
                        </div>
                    </div>

                </div>
            </div>
            <div class=""modal-footer"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <button class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent primary-button"" id=""btnSaveRoomAmenities"" onclick=""fnSaveRoomAminities();"">
                            <i class=""fa fa-save""></i> ");
            EndContext();
            BeginContext(7507, 17, false);
#line 154 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomAmenities\V_ENC_15_00.cshtml"
                                                  Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(7524, 248, true);
            WriteLiteral("\r\n                        </button>\r\n                        <button class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect  cancel-button cancel-button\" data-dismiss=\"modal\" id=\"btnCancelRoomAmenities\"><i class=\"fa fa-times\"></i> ");
            EndContext();
            BeginContext(7773, 19, false);
#line 156 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomAmenities\V_ENC_15_00.cshtml"
                                                                                                                                                                                                              Write(Localizer["Cancel"]);

#line default
#line hidden
            EndContext();
            BeginContext(7792, 210, true);
            WriteLiteral(" </button>\r\n                        <button class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect\" id=\"btndeActiveRoomAmenities\" onclick=\"fnDeleteRoomAminities();\"><i class=\"fa fa-times\"></i> ");
            EndContext();
            BeginContext(8003, 23, false);
#line 157 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\RoomAmenities\V_ENC_15_00.cshtml"
                                                                                                                                                                                                 Write(Localizer["DeActivate"]);

#line default
#line hidden
            EndContext();
            BeginContext(8026, 998, true);
            WriteLiteral(@" </button>

                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<script>
    var sizeLimit = 1024 * 2;

    function readPhotoimage(input) {
        if (input.files && input.files[0]) {

            var sizeInMb = input.files[0].size / 1024;

            if (!(input.files[0].type.match(/image.*/))) {
                toastr.warning(""Invalid format file uploaded"");
                input.value = null;
                return;
            }
            if (sizeInMb > sizeLimit) {
                toastr.warning(""User Photo file size should be smaller than 2 MB"");
                input.value = null;
                return;
            }

            var reader = new FileReader();
            reader.onload = function (e) {
                document.getElementById('imgPhotoimageblah').src = e.target.result;
            }
            reader.readAsDataURL(input.files[0]);
        }
    }

</script>





");
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
