#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaFixedAssets\Views\FixedAssets\V_2001_00.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34581a983851be685a7b5388d2a617fc2a40ce04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_eSyaFixedAssets_Views_FixedAssets_V_2001_00), @"mvc.1.0.view", @"/Areas/eSyaFixedAssets/Views/FixedAssets/V_2001_00.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/eSyaFixedAssets/Views/FixedAssets/V_2001_00.cshtml", typeof(AspNetCore.Areas_eSyaFixedAssets_Views_FixedAssets_V_2001_00))]
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
#line 1 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaFixedAssets\Views\FixedAssets\V_2001_00.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34581a983851be685a7b5388d2a617fc2a40ce04", @"/Areas/eSyaFixedAssets/Views/FixedAssets/V_2001_00.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44ef6ad91415ccde4286eb92868bf285fd165d6b", @"/Areas/eSyaFixedAssets/Views/_ViewImports.cshtml")]
    public class Areas_eSyaFixedAssets_Views_FixedAssets_V_2001_00 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/jsTree.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jsTree.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaFixedAssets\Views\FixedAssets\V_2001_00.cshtml"
  
    ViewData["Title"] = "V_2001_00";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#line 9 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaFixedAssets\Views\FixedAssets\V_2001_00.cshtml"
  
    var userFormRole = (eSyaEnterprise_UI.Models.DO_UserFormRole)ViewBag.UserFormRole;

#line default
#line hidden
            BeginContext(271, 48, true);
            WriteLiteral("\r\n<script>\r\n    var _userFormRole = JSON.parse(\'");
            EndContext();
            BeginContext(320, 38, false);
#line 14 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaFixedAssets\Views\FixedAssets\V_2001_00.cshtml"
                               Write(Html.Raw(Json.Serialize(userFormRole)));

#line default
#line hidden
            EndContext();
            BeginContext(358, 49, true);
            WriteLiteral("\');\r\n\r\n     var localization = {\r\n         Add: \'");
            EndContext();
            BeginContext(408, 16, false);
#line 17 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaFixedAssets\Views\FixedAssets\V_2001_00.cshtml"
          Write(Localizer["Add"]);

#line default
#line hidden
            EndContext();
            BeginContext(424, 22, true);
            WriteLiteral("\',\r\n         Update: \'");
            EndContext();
            BeginContext(447, 19, false);
#line 18 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaFixedAssets\Views\FixedAssets\V_2001_00.cshtml"
             Write(Localizer["Update"]);

#line default
#line hidden
            EndContext();
            BeginContext(466, 20, true);
            WriteLiteral("\',\r\n         Save: \'");
            EndContext();
            BeginContext(487, 17, false);
#line 19 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaFixedAssets\Views\FixedAssets\V_2001_00.cshtml"
           Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(504, 22, true);
            WriteLiteral("\',\r\n         Delete: \'");
            EndContext();
            BeginContext(527, 19, false);
#line 20 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaFixedAssets\Views\FixedAssets\V_2001_00.cshtml"
             Write(Localizer["Delete"]);

#line default
#line hidden
            EndContext();
            BeginContext(546, 29, true);
            WriteLiteral("\',\r\n         AddAssetGroup: \'");
            EndContext();
            BeginContext(576, 26, false);
#line 21 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaFixedAssets\Views\FixedAssets\V_2001_00.cshtml"
                    Write(Localizer["AddAssetGroup"]);

#line default
#line hidden
            EndContext();
            BeginContext(602, 30, true);
            WriteLiteral("\',\r\n         ViewAssetGroup: \'");
            EndContext();
            BeginContext(633, 27, false);
#line 22 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaFixedAssets\Views\FixedAssets\V_2001_00.cshtml"
                     Write(Localizer["ViewAssetGroup"]);

#line default
#line hidden
            EndContext();
            BeginContext(660, 30, true);
            WriteLiteral("\',\r\n         EditAssetGroup: \'");
            EndContext();
            BeginContext(691, 27, false);
#line 23 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaFixedAssets\Views\FixedAssets\V_2001_00.cshtml"
                     Write(Localizer["EditAssetGroup"]);

#line default
#line hidden
            EndContext();
            BeginContext(718, 25, true);
            WriteLiteral("\',\r\n    };\r\n</script>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(766, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(774, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "34581a983851be685a7b5388d2a617fc2a40ce048760", async() => {
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
                BeginContext(823, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(829, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34581a983851be685a7b5388d2a617fc2a40ce0410092", async() => {
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
                BeginContext(867, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            BeginContext(874, 1975, true);
            WriteLiteral(@"
<style>
    .btn_wdth {
        width: 100%;
        margin-bottom: 0px;
        text-align: left;
        height: 35px !important;
    }



    h5 {
        margin-top: 0px;
        font-weight: 600;
        color: #555555;
        padding-left: 0px;
        margin-bottom: 10px;
        font-size: 20px;
    }

    #listbox_source_4_wrapper ul li, #listbox_destination_4_wrapper ul li {
        padding-left: 10px;
    }

    .listboxswap ul li.listbox_option:hover {
        background-color: aliceblue;
    }

    #pnlAddAction {
        margin-top: 15px;
    }

    .listboxswap .source_wrapper, .listboxswap .destination_wrapper {
        width: 41%;
    }

    .listboxswap .listbox_controls {
        width: 17%;
    }

    li.add button {
        width: 88px;
    }

    #listbox_destination_4_wrapper ul, #listbox_source_4_wrapper ul {
        overflow: auto !important;
    }

    .listboxswap .listbox_controls ul li, .listboxswap .listbox_controls ul li:hover {
            WriteLiteral(@"
        background-color: transparent;
        border: none;
        box-shadow: none;
    }

    li.add button {
        color: #fff;
        background: #55a4e9 !important;
    }

    .addactionbutton {
        position: absolute;
        right: 15px;
        top: 0px;
    }

    .mdl-card__title {
        padding: 0px !important;
    }

    .mdl-card__supporting-text {
        padding: 0px !important;
    }
</style>


<div class=""row"">
    <div class=""col-lg-4 col-md-6 col-sm-4 col-10"">
            <div id=""jstAssetGroupList""></div>
        </div>
  
    <div class=""col-lg-6 col-md-6 col-sm-6 col-xs-12 pad0 div-menuform"">

        <div class=""demo-card-square mdl-card mdl-shadow--2dp"" id=""pnlAssetGroup"" style=""width: 100%; display:none"">
            <div id=""pnlAssetGroupHeading"" class=""mdl-card__title mdl-card--expand padleft0 padtop0 h-60 d-block"">
                <h5 class=""mdl-card__title-text"">");
            EndContext();
            BeginContext(2850, 26, false);
#line 118 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaFixedAssets\Views\FixedAssets\V_2001_00.cshtml"
                                            Write(Localizer["AddAssetGroup"]);

#line default
#line hidden
            EndContext();
            BeginContext(2876, 357, true);
            WriteLiteral(@" </h5>
            </div>
            <div class=""mdl-card__supporting-text fullwidth"">
                <div class=""row  padbot10 mar0"">
                    <input type=""text"" id=""txtAssetGroupID"" style=""display:none"" />
                    <div class=""col-lg-12"">
                        <div class=""form-group "">
                            <label>");
            EndContext();
            BeginContext(3234, 34, false);
#line 125 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaFixedAssets\Views\FixedAssets\V_2001_00.cshtml"
                              Write(Localizer["AssetGroupDescription"]);

#line default
#line hidden
            EndContext();
            BeginContext(3268, 646, true);
            WriteLiteral(@" </label>
                            <input id=""txtAssetGroupDes"" class="" form-control"" maxlength=""250"" type=""text"" />
                        </div>
                    </div>
                </div>
                <div class=""row mar0"">
                    <div class=""col-lg-4"">

                        <div class=""default-checkbox separate"">
                            <label class=""mdl-checkbox mdl-js-checkbox mdl-js-ripple-effect"" for=""chkActiveStatus"">
                                <input type=""checkbox"" id=""chkActiveStatus"" class=""mdl-checkbox__input"">
                                <span class=""mdl-checkbox__label"">");
            EndContext();
            BeginContext(3915, 19, false);
#line 136 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaFixedAssets\Views\FixedAssets\V_2001_00.cshtml"
                                                             Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(3934, 406, true);
            WriteLiteral(@" </span>
                            </label>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""mdl-card__actions mdl-card--border"" style=""text-align: center;"">
                <button class=""mdl-button mdl-js-button mdl-button--raised primary-button"" id=""btnAssetGroupAdd"" onclick=""fnSaveAssetGroup()"">
                    ");
            EndContext();
            BeginContext(4341, 16, false);
#line 144 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaFixedAssets\Views\FixedAssets\V_2001_00.cshtml"
               Write(Localizer["Add"]);

#line default
#line hidden
            EndContext();
            BeginContext(4357, 190, true);
            WriteLiteral("\r\n                </button>\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n\r\n    <div class=\"col-lg-2 col-md-2 col-sm-2 col-xs-12 hide-in-smallscreen\">\r\n        <div>\r\n            <h5>");
            EndContext();
            BeginContext(4548, 20, false);
#line 154 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaFixedAssets\Views\FixedAssets\V_2001_00.cshtml"
           Write(Localizer["Actions"]);

#line default
#line hidden
            EndContext();
            BeginContext(4568, 324, true);
            WriteLiteral(@"</h5>
        </div>
        <div class=""row"">

            <div class=""col-lg-12 btn_pdnTop"">
                <button class=""mdl-button mdl-js-button mdl-button--raised primary-button btn_wdth"" id=""btnExpandAll"" onclick=""fnExpandAll()"">
                    <i class=""fas fa-expand"" style=""color:#fff !important""></i> ");
            EndContext();
            BeginContext(4893, 22, false);
#line 160 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaFixedAssets\Views\FixedAssets\V_2001_00.cshtml"
                                                                           Write(Localizer["ExpandAll"]);

#line default
#line hidden
            EndContext();
            BeginContext(4915, 326, true);
            WriteLiteral(@"
                </button>
            </div>
            <div class=""col-lg-12 btn_pdnTop"">
                <button class=""mdl-button mdl-js-button mdl-button--raised primary-button btn_wdth"" id=""btnCollapseAll"" onclick=""fnCollapseAll()"">
                    <i class=""fas fa-compress"" style=""color:#fff !important""></i>");
            EndContext();
            BeginContext(5242, 24, false);
#line 165 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaFixedAssets\Views\FixedAssets\V_2001_00.cshtml"
                                                                            Write(Localizer["CollapseAll"]);

#line default
#line hidden
            EndContext();
            BeginContext(5266, 14319, true);
            WriteLiteral(@"
                </button>
            </div>

        </div>
    </div>

</div>


<script>

    var prevSelectedID = '';
    var TypeList

    $(document).ready(function () {

        fnGetAssetGroupList();
        fnTreeSize();
    });
    function fnTreeSize() {
        $(""#jstAssetGroupList"").css({
            'height': $(window).innerHeight() - 136,
            'overflow': 'auto'
        });
    }

    function fnGetAssetGroupList() {
        $.ajax({
            url: getBaseURL() + '/FixedAssets/GetAssetGroupTreeView',
            type:'POST',
            success: function (result) {
                fnGetAssetGroup_Success(result);
            },
            error: function (error) {
                toastr.error(error.status);
            }
        });
    }

    function fnGetAssetGroup_Success(dataArray) {
        $(""#jstAssetGroupList"").jstree({ core: { 'data': dataArray, 'check_callback': true, 'multiple': false } });

        $(""#jstAssetGroupList"").on('lo");
            WriteLiteral(@"aded.jstree', function () {

            $(""#jstAssetGroupList"").jstree()._open_to(prevSelectedID);
            $('#jstAssetGroupList').jstree().select_node(prevSelectedID);
        });


        $('#jstAssetGroupList').on(""changed.jstree"", function (e, data) {
            if (data.node != undefined) {
                if (prevSelectedID != data.node.id) {
                    prevSelectedID = data.node.id;

                    if (data.node.id == ""0"") {
                        $('#btnDeleteNode').prop('disabled', true)
                    }
                    else {
                        $('#btnDeleteNode').prop('disabled', false)

                        $('#View').remove();
                        $('#Edit').remove();
                        $('#Add').remove();

                        $('#pnlAssetGroup').hide();

                        if (data.node.parent == ""#"") {

                            if (_userFormRole.IsInsert === false) {
                                $('#pnlAsse");
            WriteLiteral(@"tGroup').hide();
                                toastr.warning(errorMsgCS[""E003""]);
                                return;
                            }

                            $('#pnlAssetGroupHeading > h5').text(localization.AddAssetGroup);
                            $('#btnAssetGroupAdd').html('<i class=""fa fa-plus""></i>' + localization.Add);

                            $('#MM_anchor').html($('#MM_anchor').html() + '<span id=""Add"" style=""padding-left:10px;padding-right:10px"">&nbsp;<i class=""fa fa-plus"" style=""color:#337ab7""aria-hidden=""true""></i></span>')
                            $('#pnlAssetGroup').show();
                            fnClearControl();
                            $('#txtAssetGroupDes').attr('readonly', false);
                            $('#chkActiveStatus').prop('disabled', false);
                        }

                        else if (data.node.id.startsWith(""MM"")) {

                            $('#' + data.node.id + ""_anchor"").html($('#' + data.node.i");
            WriteLiteral(@"d + ""_anchor"").html() + '<span id=""View"" style=""padding-left:10px"">&nbsp;<i class=""fa fa-eye"" style=""color:#337ab7""aria-hidden=""true""></i></span>')
                            $('#' + data.node.id + ""_anchor"").html($('#' + data.node.id + ""_anchor"").html() + '<span id=""Edit"" style=""padding-left:10px"">&nbsp;<i class=""fa fa-pen"" style=""color:#337ab7""aria-hidden=""true""></i></span>')
                            $('#' + data.node.id + ""_anchor"").html($('#' + data.node.id + ""_anchor"").html() + '<span id=""Add"" style=""padding-left:10px;padding-right:10px"">&nbsp;<i class=""fa fa-plus"" style=""color:#337ab7""aria-hidden=""true""></i></span>')

                            $('#View').on('click', function () {

                                if (_userFormRole.IsView === false) {
                                    $('#pnlAssetGroup').hide();
                                    toastr.warning(errorMsgCS[""E001""]);
                                    return;
                                }

                         ");
            WriteLiteral(@"       $('#pnlAssetGroup').show();
                                $('#pnlAssetGroupHeading > h5').text(localization.ViewAssetGroup);
                                $('#btnAssetGroupAdd').hide();
                                fnFillAssetGroupDetail(data.node.id.substring(2));
                                $(""#txtAssetGroupDes"").prop(""readonly"", true);
                                $('#chkActiveStatus').prop('disabled', true);
                            });

                            $('#Edit').on('click', function () {
                                if (_userFormRole.IsEdit === false) {
                                    $('#pnlAssetGroup').hide();
                                    toastr.warning(errorMsgCS[""E002""]);
                                    return;
                                }
                                $('#pnlAssetGroup').show();
                                $('#pnlAssetGroupHeading > h5').text(localization.EditAssetGroup);
                              ");
            WriteLiteral(@"  $('#btnAssetGroupAdd').show();
                                $('#btnAssetGroupAdd').html('<i class=""fa fa-sync""></i>' + localization.Update);

                                fnFillAssetGroupDetail(data.node.id.substring(2));
                                $('#txtAssetGroupDes').attr('readonly', false);
                                $('#chkActiveStatus').prop('disabled', false);
                            });

                            $('#Add').on('click', function () {
                                if (_userFormRole.IsInsert === false) {
                                    $('#pnlAssetGroup').hide();
                                    toastr.warning(errorMsgCS[""E003""]);
                                    return;
                                }

                                $('#pnlAssetGroup').show();
                                $('#btnAssetGroupAdd').show();
                                $('#pnlAssetGroupHeading > h5').text(localization.AddAssetGroup);
            ");
            WriteLiteral(@"                    $('#btnAssetGroupAdd').html('<i class=""fa fa-plus""></i>'+ localization.Add);
                                fnClearControl();
                                $('#txtAssetGroupDes').attr('readonly', false);
                                $('#chkActiveStatus').prop('disabled', false);
                            });

                        }

                       //
                        else if (data.node.id.startsWith(""SM"")) {
                            //$('#' + data.node.id + ""_anchor"").html($('#' + data.node.id + ""_anchor"").html() + '<span id=""Edit"">&nbsp;<i class=""fa fa-pen"" style=""color:#337ab7""aria-hidden=""true""></i></span>')
                            $('#' + data.node.id + ""_anchor"").html($('#' + data.node.id + ""_anchor"").html() + '<span id=""View"" style=""padding-left:10px"">&nbsp;<i class=""fa fa-eye"" style=""color:#337ab7""aria-hidden=""true""></i></span>')
                            $('#' + data.node.id + ""_anchor"").html($('#' + data.node.id + ""_anchor"").html() + ");
            WriteLiteral(@"'<span id=""Edit"" style=""padding-left:10px"">&nbsp;<i class=""fa fa-pen"" style=""color:#337ab7""aria-hidden=""true""></i></span>')
                            $('#' + data.node.id + ""_anchor"").html($('#' + data.node.id + ""_anchor"").html() + '<span id=""Add"" style=""padding-left:10px;padding-right:10px"">&nbsp;<i class=""fa fa-plus"" style=""color:#337ab7""aria-hidden=""true""></i></span>')

                            $('#View').on('click', function () {
                                if (_userFormRole.IsView === false) {
                                    $('#pnlAssetGroup').hide();
                                    toastr.warning(errorMsgCS[""E001""]);
                                    return;
                                }
                                $('#pnlAssetGroup').show();
                                $('#pnlAssetGroupHeading > h5').text(localization.ViewAssetGroup);
                                $('#btnAssetGroupAdd').hide();
                                fnFillAssetGroupDetail(data.nod");
            WriteLiteral(@"e.id.substring(2));
                                $(""#txtAssetGroupDes"").prop(""readonly"", true);
                                $('#chkActiveStatus').prop('disabled', true);

                            });

                            $('#Edit').on('click', function () {
                                if (_userFormRole.IsEdit === false) {
                                    $('#pnlAssetGroup').hide();
                                    toastr.warning(errorMsgCS[""E002""]);
                                    return;
                                }
                                $('#pnlAssetGroup').show();
                                $('#pnlAssetGroupHeading > h5').text(localization.EditAssetGroup);
                                $('#btnAssetGroupAdd').show();
                                $('#btnAssetGroupAdd').html('<i class=""fa fa-sync""></i>' + localization.Update);

                                fnFillAssetGroupDetail(data.node.id.substring(2));
                           ");
            WriteLiteral(@"     $('#txtAssetGroupDes').attr('readonly', false);
                                $('#chkActiveStatus').prop('disabled', false);

                            });

                            $('#Add').on('click', function () {
                                if (_userFormRole.IsInsert === false) {
                                    $('#pnlAssetGroup').hide();
                                    toastr.warning(errorMsgCS[""E003""]);
                                    return;
                                }
                                $('#pnlAssetGroup').show();
                                $('#btnAssetGroupAdd').show();
                                $('#pnlAssetGroupHeading > h5').text(localization.AddAssetGroup);
                                $('#btnAssetGroupAdd').html('<i class=""fa fa-plus""></i>' + localization.Add);
                                fnClearControl();
                                $('#txtAssetGroupDes').attr('readonly', false);
                              ");
            WriteLiteral(@"  $('#chkActiveStatus').prop('disabled', false);
                            });
                        }
                        //
                    }
                }
            }
        });

        $('#jstAssetGroupList').on(""close_node.jstree"", function (node) {
            var closingNode = node.handleObj.handler.arguments[1].node;
            $('#jstAssetGroupList').jstree().deselect_node(closingNode.children);
        });

    };

    function fnFillAssetGroupDetail(AssetGroupId) {
        $.ajax({
            url: getBaseURL() + '/FixedAssets/GetAssetGroupbyId?AssetId=' + AssetGroupId,
            success: function (result) {

                if (result) {

                    $(""#txtAssetGroupID"").val(AssetGroupId);
                    $(""#txtAssetGroupDes"").val(result.AssetGroupDesc);
                    if (result.ActiveStatus === true)
                        $(""#chkActiveStatus"").parent().addClass(""is-checked"");
                    else
                        ");
            WriteLiteral(@"$(""#chkActiveStatus"").parent().removeClass(""is-checked"");
                }
                else {
                    toastr.error(""internal Error"");
                }

            }
        });
    }

    function fnSaveAssetGroup() {

        var selectedNode = $('#jstAssetGroupList').jstree().get_selected(true);
        if (selectedNode.length != 1) {
            toastr.warning('Please select any one node.');
            return;
        }
        if (IsStringNullorEmpty($(""#txtAssetGroupDes"").val())) {
            toastr.warning(""Please Enter Asset Group Description"");
                return;
            }

            selectedNode = selectedNode[0];
            prevSelectedID = selectedNode.id;
            var AssetGroupID = 0;
            var ParentID = 0;
        if (selectedNode.id.startsWith(""#"")) {
            ParentID = 0;
            AssetGroupID = 0;
        }
        if (selectedNode.id.startsWith(""MM"")) {
            ParentID = selectedNode.id.substring(2);
     ");
            WriteLiteral(@"   }
        if (selectedNode.id.startsWith(""SM"")) {
            ParentID = selectedNode.id.substring(2);
        }
        if (!IsStringNullorEmpty($(""#txtAssetGroupID"").val())) {
            AssetGroupID = $(""#txtAssetGroupID"").val();
        }

        $(""#btnAssetGroupAdd"").attr(""disabled"", true);
            $.ajax({
                url: getBaseURL() + '/FixedAssets/InsertOrUpdateAssetGroup',
                type: 'POST',
                datatype: 'json',
                data: {
                    AssetGroupId: AssetGroupID,
                    ParentId: ParentID,
                    AssetGroupDesc: $(""#txtAssetGroupDes"").val(),
                    ActiveStatus: $(""#chkActiveStatus"").parent().hasClass(""is-checked""),
                },
                async: false,
                success: function (response) {
                    if (response.Status === true) {
                        toastr.success(""Saved"");
                        fnClearControl();
                        $(""#j");
            WriteLiteral(@"stAssetGroupList"").jstree(""destroy"");
                        fnGetAssetGroupList();
                        $('#pnlAssetGroup').hide();

                    }
                    else {
                        toastr.error(response.Message);
                    }
                    $(""#btnAssetGroupAdd"").attr(""disabled"", false);
                },
                error: function (error) {
                    toastr.error(error.statusText);
                    $(""#btnAssetGroupAdd"").attr(""disabled"", false);
                }
            });

    }



    function fnExpandAll() {
       $(""#jstAssetGroupList"").jstree('open_all');
       fnTreeSize(""#jstAssetGroupList"");
    }

    function fnCollapseAll() {
       $(""#jstAssetGroupList"").jstree('close_all');
    }

    function fnClearControl() {
        $(""#txtAssetGroupDes"").val("""");
        $(""#txtAssetGroupID"").val("""");
        $(""#chkActiveStatus"").parent().addClass(""is-checked"");
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