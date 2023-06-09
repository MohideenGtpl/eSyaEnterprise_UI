#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaServices\Views\ServiceManagement\_ServiceGroup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae1e22a550e439e94a214fa0ca5b938e53d1cf5d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_eSyaServices_Views_ServiceManagement__ServiceGroup), @"mvc.1.0.view", @"/Areas/eSyaServices/Views/ServiceManagement/_ServiceGroup.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/eSyaServices/Views/ServiceManagement/_ServiceGroup.cshtml", typeof(AspNetCore.Areas_eSyaServices_Views_ServiceManagement__ServiceGroup))]
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
#line 1 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaServices\Views\ServiceManagement\_ServiceGroup.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae1e22a550e439e94a214fa0ca5b938e53d1cf5d", @"/Areas/eSyaServices/Views/ServiceManagement/_ServiceGroup.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Areas/eSyaServices/Views/_ViewImports.cshtml")]
    public class Areas_eSyaServices_Views_ServiceManagement__ServiceGroup : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(80, 1460, true);
            WriteLiteral(@"

<style>


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

    #lblServiceGroup {
        cursor: pointer;
        padding: 2px 4px;
    }

        #lblServiceGroup:hover {
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
    <div class=""col-sm-4 col-md-4 col-lg-4"">

        <div id=""ServiceGroupTree"">
        </div>
");
            WriteLiteral(@"    </div>
    <div class=""col-sm-1 col-md-1 col-lg-1""></div>
    <div class=""col-lg-5 col-md-5 col-sm-5 f-right"">
        <div id=""dvServiceGroup"" style=""display:none;"">

            <div class=""demo-card-square mdl-card mdl-shadow--2dp marbot15 fullwidth"" id=""pnlAddServiceGroup"">
                <div class=""mdl-card__title mdl-card--expand padleft0 padtop0 h-60 d-block"">
                    <h5 class=""mdl-card__title-text"">");
            EndContext();
            BeginContext(1541, 28, false);
#line 65 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaServices\Views\ServiceManagement\_ServiceGroup.cshtml"
                                                Write(Localizer["AddServiceGroup"]);

#line default
#line hidden
            EndContext();
            BeginContext(1569, 338, true);
            WriteLiteral(@" </h5>
                </div>
                <div class=""mdl-card__supporting-text fullwidth"">
                    <div class=""row"">
                        <div class=""col-sm-12 col-md-12 col-lg-12"">
                            <div class=""form-group"">
                                <label>
                                    ");
            EndContext();
            BeginContext(1908, 36, false);
#line 72 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaServices\Views\ServiceManagement\_ServiceGroup.cshtml"
                               Write(Localizer["ServiceGroupDescription"]);

#line default
#line hidden
            EndContext();
            BeginContext(1944, 682, true);
            WriteLiteral(@"
                                </label>
                                <input type=""text"" maxlength=""50"" class=""form-control"" id=""txtServiceGroupDesc"" />
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
            BeginContext(2627, 19, false);
#line 83 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaServices\Views\ServiceManagement\_ServiceGroup.cshtml"
                                                             Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(2646, 405, true);
            WriteLiteral(@"</span>
                            </label>
                        </div>

                    </div>
                    <hr />
                    <div class=""mdl-card__actions text-center pad0"">
                        <button type=""button"" class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect"" id=""btnSGAdd"" onclick=""fnAddOrUpdateServiceGroup()""><i class=""fa fa-plus""></i> ");
            EndContext();
            BeginContext(3052, 17, false);
#line 90 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaServices\Views\ServiceManagement\_ServiceGroup.cshtml"
                                                                                                                                                                                                 Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(3069, 219, true);
            WriteLiteral("</button>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-lg-2 col-md-2 col-sm-2 col-xs-12 hide-in-smallscreen \">\r\n        <div>\r\n            <h5>");
            EndContext();
            BeginContext(3289, 19, false);
#line 98 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaServices\Views\ServiceManagement\_ServiceGroup.cshtml"
           Write(Localizer["Action"]);

#line default
#line hidden
            EndContext();
            BeginContext(3308, 285, true);
            WriteLiteral(@"</h5>
        </div>
        <div class=""row"">
            <div class=""col-lg-12 btn_pdnTop collapse"">
                <button class=""mdl-button mdl-js-button mdl-button--raised cancel-button btn_wdth"" onclick=""fnDeleteNode()"">
                    <i class=""fa fa-times""></i>     ");
            EndContext();
            BeginContext(3594, 23, false);
#line 103 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaServices\Views\ServiceManagement\_ServiceGroup.cshtml"
                                               Write(Localizer["DeleteNode"]);

#line default
#line hidden
            EndContext();
            BeginContext(3617, 300, true);
            WriteLiteral(@"
                </button>
            </div>
            <div class=""col-lg-12 btn_pdnTop"">
                <button class=""mdl-button mdl-js-button mdl-button--raised primary-button btn_wdth"" id=""btnMoveUp"" onclick=""fnMoveItemUpDown('U')"">
                    <i class=""fas fa-arrow-up""></i>   ");
            EndContext();
            BeginContext(3918, 19, false);
#line 108 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaServices\Views\ServiceManagement\_ServiceGroup.cshtml"
                                                 Write(Localizer["MoveUp"]);

#line default
#line hidden
            EndContext();
            BeginContext(3937, 304, true);
            WriteLiteral(@"
                </button>
            </div>
            <div class=""col-lg-12 btn_pdnTop"">
                <button class=""mdl-button mdl-js-button mdl-button--raised primary-button btn_wdth"" id=""btnMoveDown"" onclick=""fnMoveItemUpDown('D')"">
                    <i class=""fas fa-arrow-down""></i>   ");
            EndContext();
            BeginContext(4242, 21, false);
#line 113 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaServices\Views\ServiceManagement\_ServiceGroup.cshtml"
                                                   Write(Localizer["MoveDown"]);

#line default
#line hidden
            EndContext();
            BeginContext(4263, 293, true);
            WriteLiteral(@"
                </button>
            </div>
            <div class=""col-lg-12 btn_pdnTop"">
                <button class=""mdl-button mdl-js-button mdl-button--raised primary-button btn_wdth"" id=""btnExpandAll"" onclick=""fnExpandAll()"">
                    <i class=""fas fa-expand""></i>   ");
            EndContext();
            BeginContext(4557, 22, false);
#line 118 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaServices\Views\ServiceManagement\_ServiceGroup.cshtml"
                                               Write(Localizer["ExpandAll"]);

#line default
#line hidden
            EndContext();
            BeginContext(4579, 299, true);
            WriteLiteral(@"
                </button>
            </div>
            <div class=""col-lg-12 btn_pdnTop"">
                <button class=""mdl-button mdl-js-button mdl-button--raised primary-button btn_wdth"" id=""btnCollapseAll"" onclick=""fnCollapseAll()"">
                    <i class=""fas fa-compress""></i>   ");
            EndContext();
            BeginContext(4879, 24, false);
#line 123 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaServices\Views\ServiceManagement\_ServiceGroup.cshtml"
                                                 Write(Localizer["CollapseAll"]);

#line default
#line hidden
            EndContext();
            BeginContext(4903, 153, true);
            WriteLiteral("\r\n                </button>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n<script>\r\n    var localization = {\r\n        AddServiceGroup: \'");
            EndContext();
            BeginContext(5057, 28, false);
#line 134 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaServices\Views\ServiceManagement\_ServiceGroup.cshtml"
                     Write(Localizer["AddServiceGroup"]);

#line default
#line hidden
            EndContext();
            BeginContext(5085, 19, true);
            WriteLiteral("\',\r\n        Save: \'");
            EndContext();
            BeginContext(5105, 17, false);
#line 135 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaServices\Views\ServiceManagement\_ServiceGroup.cshtml"
          Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(5122, 31, true);
            WriteLiteral("\',\r\n        ViewServiceGroup: \'");
            EndContext();
            BeginContext(5154, 29, false);
#line 136 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaServices\Views\ServiceManagement\_ServiceGroup.cshtml"
                      Write(Localizer["ViewServiceGroup"]);

#line default
#line hidden
            EndContext();
            BeginContext(5183, 31, true);
            WriteLiteral("\',\r\n        EditServiceGroup: \'");
            EndContext();
            BeginContext(5215, 29, false);
#line 137 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaServices\Views\ServiceManagement\_ServiceGroup.cshtml"
                      Write(Localizer["EditServiceGroup"]);

#line default
#line hidden
            EndContext();
            BeginContext(5244, 21, true);
            WriteLiteral("\',\r\n        Update: \'");
            EndContext();
            BeginContext(5266, 19, false);
#line 138 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaServices\Views\ServiceManagement\_ServiceGroup.cshtml"
            Write(Localizer["Update"]);

#line default
#line hidden
            EndContext();
            BeginContext(5285, 34, true);
            WriteLiteral("\',\r\n        Doyouwanttomovenode: \'");
            EndContext();
            BeginContext(5320, 32, false);
#line 139 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaServices\Views\ServiceManagement\_ServiceGroup.cshtml"
                         Write(Localizer["Doyouwanttomovenode"]);

#line default
#line hidden
            EndContext();
            BeginContext(5352, 20, true);
            WriteLiteral("\',\r\n    }\r\n</script>");
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
