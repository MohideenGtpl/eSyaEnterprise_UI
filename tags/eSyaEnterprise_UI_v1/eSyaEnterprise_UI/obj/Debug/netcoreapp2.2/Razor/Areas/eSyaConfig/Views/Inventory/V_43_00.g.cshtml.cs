#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Inventory\V_43_00.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c57145b8cd03ec6cbc434ab918b47da143de5fae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_eSyaConfig_Views_Inventory_V_43_00), @"mvc.1.0.view", @"/Areas/eSyaConfig/Views/Inventory/V_43_00.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/eSyaConfig/Views/Inventory/V_43_00.cshtml", typeof(AspNetCore.Areas_eSyaConfig_Views_Inventory_V_43_00))]
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
#line 1 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Inventory\V_43_00.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c57145b8cd03ec6cbc434ab918b47da143de5fae", @"/Areas/eSyaConfig/Views/Inventory/V_43_00.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Areas/eSyaConfig/Views/_ViewImports.cshtml")]
    public class Areas_eSyaConfig_Views_Inventory_V_43_00 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Config/UnitofMeasure.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Inventory\V_43_00.cshtml"
  
    ViewData["Title"] = "Unit of Measure";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(182, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c57145b8cd03ec6cbc434ab918b47da143de5fae4085", async() => {
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
            BeginContext(234, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 11 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Inventory\V_43_00.cshtml"
  
    var userFormRole = (eSyaEnterprise_UI.Models.DO_UserFormRole)ViewBag.UserFormRole;

#line default
#line hidden
            BeginContext(333, 46, true);
            WriteLiteral("<script>\r\n    var _userFormRole = JSON.parse(\'");
            EndContext();
            BeginContext(380, 38, false);
#line 15 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Inventory\V_43_00.cshtml"
                               Write(Html.Raw(Json.Serialize(userFormRole)));

#line default
#line hidden
            EndContext();
            BeginContext(418, 60, true);
            WriteLiteral("\');\r\n\r\n     var localization = {\r\n         UnitofPurchase: \'");
            EndContext();
            BeginContext(479, 27, false);
#line 18 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Inventory\V_43_00.cshtml"
                     Write(Localizer["UnitofPurchase"]);

#line default
#line hidden
            EndContext();
            BeginContext(506, 27, true);
            WriteLiteral("\',\r\n         Description: \'");
            EndContext();
            BeginContext(534, 24, false);
#line 19 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Inventory\V_43_00.cshtml"
                  Write(Localizer["Description"]);

#line default
#line hidden
            EndContext();
            BeginContext(558, 24, true);
            WriteLiteral("\',\r\n         UOMStock: \'");
            EndContext();
            BeginContext(583, 21, false);
#line 20 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Inventory\V_43_00.cshtml"
               Write(Localizer["UOMStock"]);

#line default
#line hidden
            EndContext();
            BeginContext(604, 26, true);
            WriteLiteral("\',\r\n         ConvFactor: \'");
            EndContext();
            BeginContext(631, 29, false);
#line 21 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Inventory\V_43_00.cshtml"
                 Write(Localizer["ConversionFactor"]);

#line default
#line hidden
            EndContext();
            BeginContext(660, 22, true);
            WriteLiteral("\',\r\n         Active: \'");
            EndContext();
            BeginContext(683, 19, false);
#line 22 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Inventory\V_43_00.cshtml"
             Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(702, 23, true);
            WriteLiteral("\',\r\n         Actions: \'");
            EndContext();
            BeginContext(726, 20, false);
#line 23 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Inventory\V_43_00.cshtml"
              Write(Localizer["Actions"]);

#line default
#line hidden
            EndContext();
            BeginContext(746, 20, true);
            WriteLiteral("\',\r\n         Edit: \'");
            EndContext();
            BeginContext(767, 17, false);
#line 24 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Inventory\V_43_00.cshtml"
           Write(Localizer["Edit"]);

#line default
#line hidden
            EndContext();
            BeginContext(784, 20, true);
            WriteLiteral("\',\r\n         View: \'");
            EndContext();
            BeginContext(805, 17, false);
#line 25 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Inventory\V_43_00.cshtml"
           Write(Localizer["View"]);

#line default
#line hidden
            EndContext();
            BeginContext(822, 29, true);
            WriteLiteral("\',\r\n         UnitofMeasure: \'");
            EndContext();
            BeginContext(852, 26, false);
#line 26 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Inventory\V_43_00.cshtml"
                    Write(Localizer["UnitofMeasure"]);

#line default
#line hidden
            EndContext();
            BeginContext(878, 32, true);
            WriteLiteral("\',\r\n         AddUnitofMeasure: \'");
            EndContext();
            BeginContext(911, 29, false);
#line 27 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Inventory\V_43_00.cshtml"
                       Write(Localizer["AddUnitofMeasure"]);

#line default
#line hidden
            EndContext();
            BeginContext(940, 20, true);
            WriteLiteral("\',\r\n         Save: \'");
            EndContext();
            BeginContext(961, 17, false);
#line 28 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Inventory\V_43_00.cshtml"
           Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(978, 33, true);
            WriteLiteral("\',\r\n         EditUnitofMeasure: \'");
            EndContext();
            BeginContext(1012, 30, false);
#line 29 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Inventory\V_43_00.cshtml"
                        Write(Localizer["EditUnitofMeasure"]);

#line default
#line hidden
            EndContext();
            BeginContext(1042, 22, true);
            WriteLiteral("\',\r\n         Update: \'");
            EndContext();
            BeginContext(1065, 19, false);
#line 30 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Inventory\V_43_00.cshtml"
             Write(Localizer["Update"]);

#line default
#line hidden
            EndContext();
            BeginContext(1084, 33, true);
            WriteLiteral("\',\r\n         ViewUnitofMeasure: \'");
            EndContext();
            BeginContext(1118, 30, false);
#line 31 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Inventory\V_43_00.cshtml"
                        Write(Localizer["ViewUnitofMeasure"]);

#line default
#line hidden
            EndContext();
            BeginContext(1148, 22, true);
            WriteLiteral("\',\r\n         Delete: \'");
            EndContext();
            BeginContext(1171, 19, false);
#line 32 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Inventory\V_43_00.cshtml"
             Write(Localizer["Delete"]);

#line default
#line hidden
            EndContext();
            BeginContext(1190, 26, true);
            WriteLiteral("\',\r\n         DeActivate: \'");
            EndContext();
            BeginContext(1217, 23, false);
#line 33 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Inventory\V_43_00.cshtml"
                 Write(Localizer["DeActivate"]);

#line default
#line hidden
            EndContext();
            BeginContext(1240, 24, true);
            WriteLiteral("\',\r\n         Activate: \'");
            EndContext();
            BeginContext(1265, 21, false);
#line 34 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Inventory\V_43_00.cshtml"
               Write(Localizer["Activate"]);

#line default
#line hidden
            EndContext();
            BeginContext(1286, 613, true);
            WriteLiteral(@"',
    };
</script>

<div class=""row padbot10"">
    <div class=""col-lg-12 col-md-12 col-sm-12"">
        <table id=""jqgUnitofMeasure""></table>
        <div id=""jqpUnitofMeasure""></div>
    </div>
</div>

<div class=""modal fade"" id=""PopupUnitofMeasure"">
    <div class=""modal-dialog modal-lg"" role=""document"" style=""box-shadow:none;"">
        <div class=""modal-content"">
            <div class=""modal-header popupHeader"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" onclick=""fnClearFields()""> <i class=""fa fa-times""></i></button>
                <h4 class=""modal-title"">");
            EndContext();
            BeginContext(1900, 26, false);
#line 50 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Inventory\V_43_00.cshtml"
                                   Write(Localizer["UnitofMeasure"]);

#line default
#line hidden
            EndContext();
            BeginContext(1926, 441, true);
            WriteLiteral(@" </h4>
            </div>

            <div class=""modal-body"">
                <div class=""row padbot4"">
                    <div class=""col-sm-12"">
                        <input type=""text"" class=""form-control"" id=""txtUnitofMeasure"" style=""display:none"">
                    </div>
                    <div class=""col-lg-3 col-md-3 col-sm-12"">
                        <div class=""form-group"">
                            <label>");
            EndContext();
            BeginContext(2368, 27, false);
#line 60 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Inventory\V_43_00.cshtml"
                              Write(Localizer["UnitofPurchase"]);

#line default
#line hidden
            EndContext();
            BeginContext(2395, 344, true);
            WriteLiteral(@" </label>
                            <input id=""txtUOMPurchase"" class=""form-control"" type=""text"" autocomplete=""off"" maxlength=""4"" />
                        </div>
                    </div>
                    <div class=""col-lg-9 col-md-9 col-sm-12"">
                        <div class=""form-group"">
                            <label>");
            EndContext();
            BeginContext(2740, 24, false);
#line 66 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Inventory\V_43_00.cshtml"
                              Write(Localizer["Description"]);

#line default
#line hidden
            EndContext();
            BeginContext(2764, 349, true);
            WriteLiteral(@" </label>
                            <input id=""txtUOMPurchaseDesc"" class=""form-control"" type=""text"" autocomplete=""off"" maxlength=""50"" />
                        </div>
                    </div>
                    <div class=""col-lg-3 col-md-3 col-sm-12"">
                        <div class=""form-group"">
                            <label>");
            EndContext();
            BeginContext(3114, 21, false);
#line 72 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Inventory\V_43_00.cshtml"
                              Write(Localizer["UOMStock"]);

#line default
#line hidden
            EndContext();
            BeginContext(3135, 342, true);
            WriteLiteral(@"  </label>
                            <input id=""txtUOMStack"" class=""form-control"" type=""text"" autocomplete=""off"" maxlength=""4"" />
                        </div>
                    </div>
                    <div class=""col-lg-9 col-md-9 col-sm-12"">
                        <div class=""form-group"">
                            <label>");
            EndContext();
            BeginContext(3478, 24, false);
#line 78 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Inventory\V_43_00.cshtml"
                              Write(Localizer["Description"]);

#line default
#line hidden
            EndContext();
            BeginContext(3502, 347, true);
            WriteLiteral(@"  </label>
                            <input id=""txtUOMStackDesc"" class=""form-control"" type=""text"" autocomplete=""off"" maxlength=""50"" />
                        </div>
                    </div>
                    <div class=""col-lg-3 col-md-3 col-sm-12"">
                        <div class=""form-group"">
                            <label>");
            EndContext();
            BeginContext(3850, 29, false);
#line 84 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Inventory\V_43_00.cshtml"
                              Write(Localizer["ConversionFactor"]);

#line default
#line hidden
            EndContext();
            BeginContext(3879, 618, true);
            WriteLiteral(@" </label>
                            <input id=""txtConversionFactor"" class=""form-control"" type=""text"" autocomplete=""off"" maxlength=""7"" />
                        </div>
                    </div>
                    <div class=""col-lg-3 col-md-3 col-sm-6 col-xs-12"">
                        <div class=""default-checkbox"">
                            <label class=""mdl-checkbox mdl-js-checkbox mdl-js-ripple-effect"" for=""chkActiveStatus"">
                                <input type=""checkbox"" id=""chkActiveStatus"" class=""mdl-checkbox__input"">
                                <span class=""mdl-checkbox__label"">");
            EndContext();
            BeginContext(4498, 19, false);
#line 92 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Inventory\V_43_00.cshtml"
                                                             Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(4517, 542, true);
            WriteLiteral(@" </span>
                            </label>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""modal-footer"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <button type=""button"" class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent primary-button"" id=""btnSaveUnitofMeasure"" onclick=""fnSaveUnitofMeasure()"">
                            <i class=""fa fa-save""></i>   ");
            EndContext();
            BeginContext(5060, 17, false);
#line 102 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Inventory\V_43_00.cshtml"
                                                    Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(5077, 250, true);
            WriteLiteral("\r\n                        </button>\r\n                        <button type=\"button\" class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect\" id=\"btnDeactivateUnitofMeasure\" onclick=\"fnDeleteUnitofMeasure()\"><i class=\"fas fa-ban\"></i>  ");
            EndContext();
            BeginContext(5328, 23, false);
#line 104 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Inventory\V_43_00.cshtml"
                                                                                                                                                                                                                Write(Localizer["DeActivate"]);

#line default
#line hidden
            EndContext();
            BeginContext(5351, 221, true);
            WriteLiteral(" </button>\r\n                        <button type=\"button\" class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect  cancel-button\" data-dismiss=\"modal\" onclick=\"fnClearFields()\"><i class=\"fa fa-times\"></i> ");
            EndContext();
            BeginContext(5573, 19, false);
#line 105 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Inventory\V_43_00.cshtml"
                                                                                                                                                                                                            Write(Localizer["Cancel"]);

#line default
#line hidden
            EndContext();
            BeginContext(5592, 276, true);
            WriteLiteral(@" </button>

                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<script>

    $(document).ready(function () {
        $(""#txtConversionFactor"").inputmask({ regex: ""^[0-9]{1,7}(\\.\\d{1,2})?$"" });
    });
</script>");
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