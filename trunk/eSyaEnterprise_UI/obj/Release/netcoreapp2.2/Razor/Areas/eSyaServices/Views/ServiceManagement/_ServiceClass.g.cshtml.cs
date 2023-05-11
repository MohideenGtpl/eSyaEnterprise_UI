#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaServices\Views\ServiceManagement\_ServiceClass.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3dcfda419280794ccb2c691be2f2e4a5d6205ea9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_eSyaServices_Views_ServiceManagement__ServiceClass), @"mvc.1.0.view", @"/Areas/eSyaServices/Views/ServiceManagement/_ServiceClass.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/eSyaServices/Views/ServiceManagement/_ServiceClass.cshtml", typeof(AspNetCore.Areas_eSyaServices_Views_ServiceManagement__ServiceClass))]
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
#line 1 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaServices\Views\ServiceManagement\_ServiceClass.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dcfda419280794ccb2c691be2f2e4a5d6205ea9", @"/Areas/eSyaServices/Views/ServiceManagement/_ServiceClass.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Areas/eSyaServices/Views/_ViewImports.cshtml")]
    public class Areas_eSyaServices_Views_ServiceManagement__ServiceClass : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(80, 1518, true);
            WriteLiteral(@"
<style>

    .disable-Param {
        pointer-events: none;
    }

    .w-120 {
        width: 120px !important
    }

    .mdl-card__title {
        max-height: 45px !important;
        display: block !important;
        padding-left: 0px !important;
        padding-top: 0px !important;
    }

    .mdl-card {
        min-height: auto !important
    }



    hr {
        border-color: #f1f1f1 !important;
    }

    #pnlAddMainMenu, #pnlAddSubMenu {
        width: 100%;
    }

    #lblServiceClass {
        cursor: pointer;
        padding: 2px 4px;
    }

        #lblServiceClass:hover {
            background: #e7f4f9;
            box-shadow: inset 0 0 1px #cccccc;
        }

    .bootstrap-select:not([class*=col-]):not([class*=form-control]):not(.input-group-btn) {
        width: 100% !important
    }

    hr {
        margin-bottom: 8px;
        margin-top: 8px;
    }
</style>

<div class=""row row-bottom-pad"">
    <div class=""col-sm-4 col-md-4 col-lg-4""");
            WriteLiteral(@">

        <div id=""ServiceClassTree"">
        </div>
    </div>
    <div class=""col-sm-1 col-md-1 col-lg-1""></div>
    <div class=""col-lg-5 col-md-5 col-sm-5 f-right"">
        <div id=""dvServiceClass"" style=""display:none;"">

            <div class=""demo-card-square mdl-card mdl-shadow--2dp marbot15 fullwidth"" id=""pnlAddServiceClass"">
                <div class=""mdl-card__title mdl-card--expand padleft0 padtop0 h-60 d-block"">
                    <h5 class=""mdl-card__title-text"">");
            EndContext();
            BeginContext(1599, 28, false);
#line 67 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaServices\Views\ServiceManagement\_ServiceClass.cshtml"
                                                Write(Localizer["AddServiceClass"]);

#line default
#line hidden
            EndContext();
            BeginContext(1627, 338, true);
            WriteLiteral(@" </h5>
                </div>
                <div class=""mdl-card__supporting-text fullwidth"">
                    <div class=""row"">
                        <div class=""col-sm-12 col-md-12 col-lg-12"">
                            <div class=""form-group"">
                                <label>
                                    ");
            EndContext();
            BeginContext(1966, 36, false);
#line 74 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaServices\Views\ServiceManagement\_ServiceClass.cshtml"
                               Write(Localizer["ServiceClassDescription"]);

#line default
#line hidden
            EndContext();
            BeginContext(2002, 682, true);
            WriteLiteral(@"
                                </label>
                                <input type=""text"" maxlength=""50"" class=""form-control"" id=""txtServiceClassDesc"" />
                            </div>
                        </div>
                    </div>
                    <div class=""row "">
                        <div class=""col-lg-12"" style=""margin-bottom: 15px;"">
                            <label class=""mdl-checkbox mdl-js-checkbox"" for=""chkActiveStatus"">
                                <input type=""checkbox"" id=""chkActiveStatus""
                                       class=""mdl-checkbox__input"">
                                <span class=""mdl-checkbox__label"">");
            EndContext();
            BeginContext(2685, 19, false);
#line 85 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaServices\Views\ServiceManagement\_ServiceClass.cshtml"
                                                             Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(2704, 252, true);
            WriteLiteral("</span>\r\n                            </label>\r\n                        </div>\r\n\r\n                        <div id=\"dvParameters\" class=\"col-lg-12 col-md-12 col-sm-12\">\r\n                            <p class=\"subheading\">\r\n                                ");
            EndContext();
            BeginContext(2957, 28, false);
#line 91 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaServices\Views\ServiceManagement\_ServiceClass.cshtml"
                           Write(Localizer["ClassParameters"]);

#line default
#line hidden
            EndContext();
            BeginContext(2985, 113, true);
            WriteLiteral("\r\n                            </p>\r\n                            <hr class=\"left\" />\r\n                            ");
            EndContext();
            BeginContext(3099, 73, false);
#line 94 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaServices\Views\ServiceManagement\_ServiceClass.cshtml"
                       Write(await Component.InvokeAsync("eSyaParameter", new { parameterType = "6" }));

#line default
#line hidden
            EndContext();
            BeginContext(3172, 360, true);
            WriteLiteral(@"
                        </div>

                    </div>
                    <hr />
                    <div class=""mdl-card__actions text-center pad0"">
                        <button type=""button"" class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect"" id=""btnSCAdd"" onclick=""fnAddOrUpdateServiceClass()""><i class=""fa fa-plus""></i> ");
            EndContext();
            BeginContext(3533, 17, false);
#line 100 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaServices\Views\ServiceManagement\_ServiceClass.cshtml"
                                                                                                                                                                                                 Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(3550, 218, true);
            WriteLiteral("</button>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-lg-2 col-md-2 col-sm-2 col-xs-12 hide-in-smallscreen\">\r\n        <div>\r\n            <h5>");
            EndContext();
            BeginContext(3769, 19, false);
#line 108 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaServices\Views\ServiceManagement\_ServiceClass.cshtml"
           Write(Localizer["Action"]);

#line default
#line hidden
            EndContext();
            BeginContext(3788, 315, true);
            WriteLiteral(@"</h5>
        </div>
        <div class=""row"">
            <div class=""col-lg-12 btn_pdnTop collapse"">
                <button class=""mdl-button mdl-js-button mdl-button--raised cancel-button btn_wdth"" onclick=""fnDeleteNode()"">
                    <i class=""fa fa-times"" style=""color:#fff !important""></i>     ");
            EndContext();
            BeginContext(4104, 23, false);
#line 113 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaServices\Views\ServiceManagement\_ServiceClass.cshtml"
                                                                             Write(Localizer["DeleteNode"]);

#line default
#line hidden
            EndContext();
            BeginContext(4127, 330, true);
            WriteLiteral(@"
                </button>
            </div>
            <div class=""col-lg-12 btn_pdnTop"">
                <button class=""mdl-button mdl-js-button mdl-button--raised primary-button btn_wdth"" id=""btnMoveUp"" onclick=""fnMoveItemUpDown('U')"">
                    <i class=""fas fa-arrow-up"" style=""color:#fff !important""></i>   ");
            EndContext();
            BeginContext(4458, 19, false);
#line 118 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaServices\Views\ServiceManagement\_ServiceClass.cshtml"
                                                                               Write(Localizer["MoveUp"]);

#line default
#line hidden
            EndContext();
            BeginContext(4477, 334, true);
            WriteLiteral(@"
                </button>
            </div>
            <div class=""col-lg-12 btn_pdnTop"">
                <button class=""mdl-button mdl-js-button mdl-button--raised primary-button btn_wdth"" id=""btnMoveDown"" onclick=""fnMoveItemUpDown('D')"">
                    <i class=""fas fa-arrow-down"" style=""color:#fff !important""></i>   ");
            EndContext();
            BeginContext(4812, 21, false);
#line 123 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaServices\Views\ServiceManagement\_ServiceClass.cshtml"
                                                                                 Write(Localizer["MoveDown"]);

#line default
#line hidden
            EndContext();
            BeginContext(4833, 323, true);
            WriteLiteral(@"
                </button>
            </div>
            <div class=""col-lg-12 btn_pdnTop"">
                <button class=""mdl-button mdl-js-button mdl-button--raised primary-button btn_wdth"" id=""btnExpandAll"" onclick=""fnExpandAll()"">
                    <i class=""fas fa-expand"" style=""color:#fff !important""></i>   ");
            EndContext();
            BeginContext(5157, 22, false);
#line 128 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaServices\Views\ServiceManagement\_ServiceClass.cshtml"
                                                                             Write(Localizer["ExpandAll"]);

#line default
#line hidden
            EndContext();
            BeginContext(5179, 329, true);
            WriteLiteral(@"
                </button>
            </div>
            <div class=""col-lg-12 btn_pdnTop"">
                <button class=""mdl-button mdl-js-button mdl-button--raised primary-button btn_wdth"" id=""btnCollapseAll"" onclick=""fnCollapseAll()"">
                    <i class=""fas fa-compress"" style=""color:#fff !important""></i>   ");
            EndContext();
            BeginContext(5509, 24, false);
#line 133 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaServices\Views\ServiceManagement\_ServiceClass.cshtml"
                                                                               Write(Localizer["CollapseAll"]);

#line default
#line hidden
            EndContext();
            BeginContext(5533, 151, true);
            WriteLiteral("\r\n                </button>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n<script>\r\n    var localization = {\r\n        AddServiceClass: \'");
            EndContext();
            BeginContext(5685, 28, false);
#line 143 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaServices\Views\ServiceManagement\_ServiceClass.cshtml"
                     Write(Localizer["AddServiceClass"]);

#line default
#line hidden
            EndContext();
            BeginContext(5713, 19, true);
            WriteLiteral("\',\r\n        Save: \'");
            EndContext();
            BeginContext(5733, 17, false);
#line 144 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaServices\Views\ServiceManagement\_ServiceClass.cshtml"
          Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(5750, 31, true);
            WriteLiteral("\',\r\n        ViewServiceClass: \'");
            EndContext();
            BeginContext(5782, 29, false);
#line 145 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaServices\Views\ServiceManagement\_ServiceClass.cshtml"
                      Write(Localizer["ViewServiceClass"]);

#line default
#line hidden
            EndContext();
            BeginContext(5811, 31, true);
            WriteLiteral("\',\r\n        EditServiceClass: \'");
            EndContext();
            BeginContext(5843, 29, false);
#line 146 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaServices\Views\ServiceManagement\_ServiceClass.cshtml"
                      Write(Localizer["EditServiceClass"]);

#line default
#line hidden
            EndContext();
            BeginContext(5872, 21, true);
            WriteLiteral("\',\r\n        Update: \'");
            EndContext();
            BeginContext(5894, 19, false);
#line 147 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaServices\Views\ServiceManagement\_ServiceClass.cshtml"
            Write(Localizer["Update"]);

#line default
#line hidden
            EndContext();
            BeginContext(5913, 34, true);
            WriteLiteral("\',\r\n        Doyouwanttomovenode: \'");
            EndContext();
            BeginContext(5948, 32, false);
#line 148 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaServices\Views\ServiceManagement\_ServiceClass.cshtml"
                         Write(Localizer["Doyouwanttomovenode"]);

#line default
#line hidden
            EndContext();
            BeginContext(5980, 22, true);
            WriteLiteral("\',\r\n    }\r\n</script>\r\n");
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