#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\License\ECA_18_00.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f77af0c02d38314528ab8c95a980dbfce15439b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Configure_Views_License_ECA_18_00), @"mvc.1.0.view", @"/Areas/Configure/Views/License/ECA_18_00.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Configure/Views/License/ECA_18_00.cshtml", typeof(AspNetCore.Areas_Configure_Views_License_ECA_18_00))]
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
#line 1 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\License\ECA_18_00.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f77af0c02d38314528ab8c95a980dbfce15439b", @"/Areas/Configure/Views/License/ECA_18_00.cshtml")]
    public class Areas_Configure_Views_License_ECA_18_00 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/jsTree.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\License\ECA_18_00.cshtml"
  
    ViewData["Title"] = "Business Entity";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#line 9 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\License\ECA_18_00.cshtml"
  
    var userFormRole = (eSyaEnterprise_UI.Models.DO_UserFormRole)ViewBag.UserFormRole;

#line default
#line hidden
            BeginContext(277, 46, true);
            WriteLiteral("<script>\r\n    var _userFormRole = JSON.parse(\'");
            EndContext();
            BeginContext(324, 38, false);
#line 13 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\License\ECA_18_00.cshtml"
                               Write(Html.Raw(Json.Serialize(userFormRole)));

#line default
#line hidden
            EndContext();
            BeginContext(362, 61, true);
            WriteLiteral("\');\r\n\r\n    var localization = {\r\n        AddBusinessEntity: \'");
            EndContext();
            BeginContext(424, 30, false);
#line 16 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\License\ECA_18_00.cshtml"
                       Write(Localizer["AddBusinessEntity"]);

#line default
#line hidden
            EndContext();
            BeginContext(454, 29, true);
            WriteLiteral("\',\r\n        BusinessEntity: \'");
            EndContext();
            BeginContext(484, 27, false);
#line 17 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\License\ECA_18_00.cshtml"
                    Write(Localizer["BusinessEntity"]);

#line default
#line hidden
            EndContext();
            BeginContext(511, 33, true);
            WriteLiteral("\',\r\n        EditBusinessEntity: \'");
            EndContext();
            BeginContext(545, 31, false);
#line 18 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\License\ECA_18_00.cshtml"
                        Write(Localizer["EditBusinessEntity"]);

#line default
#line hidden
            EndContext();
            BeginContext(576, 33, true);
            WriteLiteral("\',\r\n        ViewBusinessEntity: \'");
            EndContext();
            BeginContext(610, 31, false);
#line 19 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\License\ECA_18_00.cshtml"
                        Write(Localizer["ViewBusinessEntity"]);

#line default
#line hidden
            EndContext();
            BeginContext(641, 19, true);
            WriteLiteral("\',\r\n        Save: \'");
            EndContext();
            BeginContext(661, 17, false);
#line 20 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\License\ECA_18_00.cshtml"
          Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(678, 21, true);
            WriteLiteral("\',\r\n        Update: \'");
            EndContext();
            BeginContext(700, 19, false);
#line 21 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\License\ECA_18_00.cshtml"
            Write(Localizer["Update"]);

#line default
#line hidden
            EndContext();
            BeginContext(719, 25, true);
            WriteLiteral("\',\r\n    };\r\n</script>\r\n\r\n");
            EndContext();
            BeginContext(744, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6f77af0c02d38314528ab8c95a980dbfce15439b7875", async() => {
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
            BeginContext(793, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(812, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(818, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f77af0c02d38314528ab8c95a980dbfce15439b9305", async() => {
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
                BeginContext(856, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(861, 425, true);
            WriteLiteral(@"    <div class=""row"">
        <div class=""col-lg-4 col-md-4  col-10"" id=""divJstBusinessEntity"">
            <div id=""jstBusinessEntity"" class=""h50-smallscreen""></div>
        </div>
        <div class=""col-2 only-for-smallscreen"">
            <button class=""mdl-button mdl-js-button mdl-button--raised cancel-button btn_wdth"" id=""btnDeleteNode"" onclick=""fnDeleteNode()"">
                <i class=""fa fa-times""></i>     ");
            EndContext();
            BeginContext(1287, 23, false);
#line 35 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\License\ECA_18_00.cshtml"
                                           Write(Localizer["DeleteNode"]);

#line default
#line hidden
            EndContext();
            BeginContext(1310, 213, true);
            WriteLiteral("\r\n            </button>\r\n            <button class=\"mdl-button mdl-js-button mdl-button--raised primary-button btn_wdth\" id=\"btnExpandAll\" onclick=\"fnExpandAll()\">\r\n                <i class=\"fas fa-expand\"></i>   ");
            EndContext();
            BeginContext(1524, 22, false);
#line 38 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\License\ECA_18_00.cshtml"
                                           Write(Localizer["ExpandAll"]);

#line default
#line hidden
            EndContext();
            BeginContext(1546, 219, true);
            WriteLiteral("\r\n            </button>\r\n            <button class=\"mdl-button mdl-js-button mdl-button--raised primary-button btn_wdth\" id=\"btnCollapseAll\" onclick=\"fnCollapseAll()\">\r\n                <i class=\"fas fa-compress\"></i>   ");
            EndContext();
            BeginContext(1766, 24, false);
#line 41 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\License\ECA_18_00.cshtml"
                                             Write(Localizer["CollapseAll"]);

#line default
#line hidden
            EndContext();
            BeginContext(1790, 415, true);
            WriteLiteral(@"
            </button>
        </div>
            <div class=""col-lg-6 col-md-12 col-sm-12 div-menuform"">
                <div class=""demo-card-square mdl-card mdl-shadow--2dp"" id=""pnlMainMenu"" style=""width: 100%; display:none"">
                    <div id=""pnlMainModuleHeading"" class=""mdl-card__title mdl-card--expand padleft0 padtop0 h-52 d-block"">
                        <h5 class=""mdl-card__title-text"">");
            EndContext();
            BeginContext(2206, 30, false);
#line 47 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\License\ECA_18_00.cshtml"
                                                    Write(Localizer["AddBusinessEntity"]);

#line default
#line hidden
            EndContext();
            BeginContext(2236, 412, true);
            WriteLiteral(@" </h5>
                    </div>
                    <div class=""mdl-card__supporting-text fullwidth pad0"">
                        <div class=""row mar0"">
                            <input type=""text"" id=""txtBusinessEntityId"" style=""display:none"" />
                            <div class=""col-lg-12"">
                                <div class=""form-group"">
                                    <label> ");
            EndContext();
            BeginContext(2649, 32, false);
#line 54 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\License\ECA_18_00.cshtml"
                                       Write(Localizer["BusinessDescription"]);

#line default
#line hidden
            EndContext();
            BeginContext(2681, 490, true);
            WriteLiteral(@" </label>
                                    <input id=""txtEntityDescription"" class="" form-control"" maxlength=""75"" type=""text"" />
                                </div>
                            </div>

                        </div>
                        <div class=""row"" style=""margin:0px"">
                            <div class=""col-lg-4  col-md-12 col-sm-12 col-xs-12"">
                                <div class=""form-group"">
                                    <label> ");
            EndContext();
            BeginContext(3172, 29, false);
#line 63 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\License\ECA_18_00.cshtml"
                                       Write(Localizer["BusinessUnitType"]);

#line default
#line hidden
            EndContext();
            BeginContext(3201, 724, true);
            WriteLiteral(@" </label>
                                    <div>
                                        <select class=""selectpicker"" data-live-search=""false"" id=""cboUnitType"" onchange=""fnHideshowUnits()"">
                                            <option value=""S"">Single Segment</option>
                                            <option value=""M"">Multi Segment</option>
                                        </select>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-lg-4  col-md-6 col-sm-12 col-xs-12"">
                                <div class=""form-group"">
                                    <label> ");
            EndContext();
            BeginContext(3926, 26, false);
#line 74 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\License\ECA_18_00.cshtml"
                                       Write(Localizer["NumberofUnits"]);

#line default
#line hidden
            EndContext();
            BeginContext(3952, 386, true);
            WriteLiteral(@" </label>
                                    <input id=""txtNoofUnits"" class="" form-control"" maxlength=""8"" type=""text"" />
                                </div>
                            </div>

                            <div class=""col-lg-4  col-md-6 col-sm-12 col-xs-12"">
                                <div class=""form-group"">
                                    <label> ");
            EndContext();
            BeginContext(4339, 32, false);
#line 81 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\License\ECA_18_00.cshtml"
                                       Write(Localizer["NumberofActiveUnits"]);

#line default
#line hidden
            EndContext();
            BeginContext(4371, 702, true);
            WriteLiteral(@" </label>
                                    <input id=""txtNoActiveofUnits"" class="" form-control"" maxlength=""8"" type=""text"" readonly=""readonly"" />
                                </div>
                            </div>

                            <div class=""col-lg-4  col-md-6 col-sm-12 col-xs-12"">
                                <div class=""default-checkbox checkbox-group"">
                                    <label class=""mdl-checkbox mdl-js-checkbox mdl-js-ripple-effect"" for=""chkActiveStatus"">
                                        <input type=""checkbox"" id=""chkActiveStatus"" class=""mdl-checkbox__input"">
                                        <span class=""mdl-checkbox__label"">");
            EndContext();
            BeginContext(5074, 19, false);
#line 90 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\License\ECA_18_00.cshtml"
                                                                     Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(5093, 480, true);
            WriteLiteral(@"</span>
                                    </label>
                                </div>
                            </div>

                        </div>
                    </div>
                    <div class=""mdl-card__actions mdl-card--border"" style=""text-align: center;"">
                        <button class=""mdl-button mdl-js-button mdl-button--raised primary-button"" id=""btnSaveBusinessEntity"" onclick=""fnSaveBusinessEntity()"">
                            ");
            EndContext();
            BeginContext(5574, 17, false);
#line 99 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\License\ECA_18_00.cshtml"
                       Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(5591, 237, true);
            WriteLiteral("\r\n                        </button>\r\n\r\n                    </div>\r\n\r\n                </div>\r\n\r\n            </div>\r\n            <div class=\"col-lg-2 col-md-2 col-sm-6 hide-in-smallscreen\">\r\n                <div>\r\n                    <h5> ");
            EndContext();
            BeginContext(5829, 19, false);
#line 109 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\License\ECA_18_00.cshtml"
                    Write(Localizer["Action"]);

#line default
#line hidden
            EndContext();
            BeginContext(5848, 335, true);
            WriteLiteral(@"</h5>
                </div>
                <div class=""row"">
                    <div class=""col-lg-12 btn_pdnTop"">
                        <button class=""mdl-button mdl-js-button mdl-button--raised cancel-button btn_wdth"" id=""btnDeleteNode"" onclick=""fnDeleteNode()"">
                            <i class=""fa fa-times""></i>     ");
            EndContext();
            BeginContext(6184, 23, false);
#line 114 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\License\ECA_18_00.cshtml"
                                                       Write(Localizer["DeleteNode"]);

#line default
#line hidden
            EndContext();
            BeginContext(6207, 335, true);
            WriteLiteral(@"
                        </button>
                    </div>

                    <div class=""col-lg-12 btn_pdnTop"">
                        <button class=""mdl-button mdl-js-button mdl-button--raised primary-button btn_wdth"" id=""btnExpandAll"" onclick=""fnExpandAll()"">
                            <i class=""fas fa-expand""></i>   ");
            EndContext();
            BeginContext(6543, 22, false);
#line 120 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\License\ECA_18_00.cshtml"
                                                       Write(Localizer["ExpandAll"]);

#line default
#line hidden
            EndContext();
            BeginContext(6565, 339, true);
            WriteLiteral(@"
                        </button>
                    </div>
                    <div class=""col-lg-12 btn_pdnTop"">
                        <button class=""mdl-button mdl-js-button mdl-button--raised primary-button btn_wdth"" id=""btnCollapseAll"" onclick=""fnCollapseAll()"">
                            <i class=""fas fa-compress""></i>   ");
            EndContext();
            BeginContext(6905, 24, false);
#line 125 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Configure\Views\License\ECA_18_00.cshtml"
                                                         Write(Localizer["CollapseAll"]);

#line default
#line hidden
            EndContext();
            BeginContext(6929, 16579, true);
            WriteLiteral(@"
                        </button>
                    </div>

                </div>
            </div>
        </div>


        <script>
            var NodeID;
            var prevSelectedID;

            $(document).ready(function () {

                $(""#pnlMainMenu"").hide();
                LoadBusinessEntityTree();
                $(""#btnDeleteNode"").attr(""disabled"", _userFormRole.IsDelete === false);
                $(""#txtNoofUnits"").attr('readonly', true);
                $(""#txtNoofUnits"").inputmask({ regex: ""^[0-9]{1,7}(\\.\\d{1,2})?$"" });

            });
            function fnHideshowUnits() {
                var ddlunitval = $('#cboUnitType').val();
                if (ddlunitval === ""S"") {

                    $(""#txtNoofUnits"").attr('readonly', true);
                    $('#txtNoofUnits').val('1');
                }
                else {
                    $(""#txtNoofUnits"").attr('readonly', false);
                }
            }
            function Loa");
            WriteLiteral(@"dBusinessEntityTree() {
                $.ajax({
                    url: getBaseURL() + '/License/GetBusinessEntitiesforTreeView',
                    success: function (result) {
                        fnGetBusinessEntities_Success(result);
                    },
                    error: function (error) {
                        toastr.error(error.status);
                    }
                });
            }

            function fnGetBusinessEntities_Success(dataArray) {
                $(""#jstBusinessEntity"").jstree({
                    ""state"": { ""checkbox_disabled"": true },
                    ""checkbox"": {
                        ""keep_selected_style"": false
                    },
                    core: { 'data': dataArray, 'check_callback': true, 'multiple': true }

                });

                $(""#jstBusinessEntity"").on('loaded.jstree', function () {
                    $(""#jstBusinessEntity"").jstree('open_all');
                    $(""#jstBusinessEntity"").j");
            WriteLiteral(@"stree()._open_to(prevSelectedID);
                    $('#jstBusinessEntity').jstree().select_node(prevSelectedID);

                });

                $('#jstBusinessEntity').on(""changed.jstree"", function (e, data) {
                    if (data.node != undefined) {
                        if (prevSelectedID != data.node.id) {
                            prevSelectedID = data.node.id;

                            if (data.node.id == ""0"") {
                                fnClearFields();
                                $(""#pnlMainMenu"").hide();
                            }
                            else {

                                $('#View').remove();
                                $('#Edit').remove();
                                $('#Add').remove();

                                $(""#pnlMainMenu"").hide();

                                if (data.node.parent == ""#"") {
                                    $('#' + data.node.id + ""_anchor"").html($('#' + data.node.id + ""_");
            WriteLiteral(@"anchor"").html() + '<span id=""Add"" style=""padding-left:10px;padding-right:10px"">&nbsp;<i class=""fa fa-plus"" style=""color:#337ab7""aria-hidden=""true""></i></span>')

                                    $('#Add').on('click', function () {
                                        if (_userFormRole.IsInsert === false) {
                                            $('#pnlMainMenu').hide();
                                            toastr.warning(errorMsgCS[""E003""]);
                                            return;
                                        }

                                        $(""#pnlMainMenu"").show();
                                        $("".mdl-card__title-text"").text(localization.AddBusinessEntity);
                                        fnClearFields();
                                        $(""#btnSaveBusinessEntity"").show();
                                        $(""input,textarea"").attr('readonly', false);
                                        $(""input[type=checkbox");
            WriteLiteral(@"]"").attr('disabled', false);
                                        $(""#chkActiveStatus"").attr('disabled', true);
                                        $(""#txtNoActiveofUnits"").attr('readonly', true);
                                        $(""#txtNoofUnits"").attr('readonly', true);
                                        $('#txtNoofUnits').val('1');
                                        $(""#btnSaveBusinessEntity"").html('<i class=""fa fa-plus""></i> ' + localization.Save);
                                    });
                                }
                                else if (data.node.id.startsWith(""FM"")) {

                                    NodeID = 0;
                                    NodeID = data.node.id.substring(2).split(""_"")[1];

                                    $('#' + data.node.id + ""_anchor"").html($('#' + data.node.id + ""_anchor"").html() + '<span id=""View"" style=""padding-left:10px"">&nbsp;<i class=""fa fa-eye"" style=""color:#337ab7""aria-hidden=""true""></i></span>')
   ");
            WriteLiteral(@"                                 $('#' + data.node.id + ""_anchor"").html($('#' + data.node.id + ""_anchor"").html() + '<span id=""Edit"" style=""padding-left:10px"">&nbsp;<i class=""fa fa-pen"" style=""color:#337ab7""aria-hidden=""true""></i></span>')



                                    $('#View').on('click', function () {

                                        if (_userFormRole.IsView === false) {
                                            $('#pnlMainMenu').hide();
                                            toastr.warning(errorMsgCS[""E001""]);
                                            return;
                                        }

                                        $(""#pnlMainMenu"").show();
                                        $("".mdl-card__title-text"").text(localization.ViewBusinessEntity);
                                        $('#txtBusinessEntityId').val(NodeID);

                                        fnFillBusinessEntityInfo();

                                        $(""#bt");
            WriteLiteral(@"nSaveBusinessEntity"").hide();
                                        $(""input,textarea"").attr('readonly', true);
                                        $(""input[type=checkbox]"").attr('disabled', true);
                                        $(""#txtNoActiveofUnits"").attr('readonly', true);
                                        $(""#chkActiveStatus"").attr('disabled', true);
                                    });

                                    $('#Edit').on('click', function () {
                                        if (_userFormRole.IsEdit === false) {
                                            $('#pnlMainMenu').hide();
                                            toastr.warning(errorMsgCS[""E002""]);
                                            return;
                                        }

                                        $(""#pnlMainMenu"").show();
                                        $("".mdl-card__title-text"").text(localization.EditBusinessEntity);
                    ");
            WriteLiteral(@"                    $('#txtBusinessEntityId').val(NodeID);


                                        $(""#btnSaveBusinessEntity"").show();
                                        $(""input,textarea"").attr('readonly', false);
                                        $(""input[type=checkbox]"").attr('disabled', false);
                                        $(""#chkActiveStatus"").attr('disabled', true);
                                        fnFillBusinessEntityInfo();
                                        $(""#txtNoActiveofUnits"").attr('readonly', true);
                                        $(""#btnSaveBusinessEntity"").html('<i class=""fa fa-sync""></i> ' + localization.Update);
                                        //$(""#btnSaveBusinessEntity"").attr(""disabled"", _userFormRole.IsEdit === false);
                                    });
                                }
                                else {
                                    fnClearFields();
                                    $(""#");
            WriteLiteral(@"pnlMainMenu"").hide();
                                }
                            }
                        }
                    }
                });

                $('#jstBusinessEntity').on(""close_node.jstree"", function (node) {
                    var closingNode = node.handleObj.handler.arguments[1].node;
                    $('#jstBusinessEntity').jstree().deselect_node(closingNode.children);
                });
                fnTreeSize(""#divJstBusinessEntity"");
            };

            function fnFillBusinessEntityInfo() {
                if ($(""#txtBusinessEntityId"").val() != '' && $(""#txtBusinessEntityId"").val() != undefined) {
                    $.ajax({
                        async: false,
                        url: getBaseURL() + ""/License/GetBusinessEntityInfo?BusinessId="" + $(""#txtBusinessEntityId"").val(),
                        type: 'post',
                        datatype: 'json',
                        contentType: 'application/json; charset=utf-8',
    ");
            WriteLiteral(@"                    success: function (result) {
                            $('#txtEntityDescription').val(result.BusinessDesc);

                            if (result.BusinessUnitType === 'S') {
                                $(""#txtNoofUnits"").attr('readonly', true);
                            }
                            else {
                                $(""#txtNoofUnits"").attr('readonly', false);
                            }
                            $('#cboUnitType').val(result.BusinessUnitType);
                            $('#cboUnitType').selectpicker('refresh');
                            $('#txtNoofUnits').val(result.NoOfUnits);
                            $('#txtNoActiveofUnits').val(result.ActiveNoOfUnits);
                            $(""#txtNoActiveofUnits"").attr('readonly', true);
                            if (result.ActiveStatus == 1) {
                                $(""#chkActiveStatus"").parent().addClass(""is-checked"");
                            }
          ");
            WriteLiteral(@"                  else { $('#chkActiveStatus').parent().removeClass(""is-checked""); }
                        }
                    });
                }
            }

            function fnSaveBusinessEntity() {

                if (validationBusinessEntity() === false) {
                    return;
                }


                $(""#btnSaveBusinessEntity"").attr('disabled', true);
                var EntityID = $(""#txtBusinessEntityId"").val();
                var businessentity;
                if (EntityID == null || EntityID == """") {
                    businessentity = {
                        BusinessId: 0,
                        BusinessDesc: $(""#txtEntityDescription"").val(),
                        //IsMultiSegmentApplicable: $(""#chkIsMultiSegmentApplicable"").parent().hasClass(""is-checked""),
                        BusinessUnitType: $('#cboUnitType').val(),
                        NoOfUnits: $('#txtNoofUnits').val(),
                        ActiveStatus: $(""#chkActiveStat");
            WriteLiteral(@"us"").parent().hasClass(""is-checked""),
                        ActiveNoOfUnits: $('#txtNoActiveofUnits').val()
                    };

                }
                else {
                    businessentity = {
                        BusinessId: $(""#txtBusinessEntityId"").val(),
                        BusinessDesc: $(""#txtEntityDescription"").val(),
                        //IsMultiSegmentApplicable: $(""#chkIsMultiSegmentApplicable"").parent().hasClass(""is-checked""),
                        BusinessUnitType: $('#cboUnitType').val(),
                        NoOfUnits: $('#txtNoofUnits').val(),
                        ActiveStatus: $(""#chkActiveStatus"").parent().hasClass(""is-checked""),
                        ActiveNoOfUnits: $('#txtNoActiveofUnits').val()
                    };
                }
                $.ajax({
                    url: getBaseURL() + '/License/InsertOrUpdateBusinessEntity',
                    type: 'POST',
                    datatype: 'json',
                  ");
            WriteLiteral(@"  data: { businessentity },
                    success: function (response) {
                        if (response.Status) {
                            toastr.success(response.Message);
                            location.reload();

                            return true;
                        }
                        else {
                            toastr.error(response.Message);
                            $(""#btnSaveBusinessEntity"").attr('disabled', false);
                            return false;
                        }

                    },
                    error: function (error) {
                        toastr.error(error.statusText);
                        $(""#btnSaveBusinessEntity"").attr('disabled', false);
                    }
                });
            }

            function validationBusinessEntity() {

                if (IsStringNullorEmpty($(""#txtEntityDescription"").val())) {
                    toastr.warning(""Please Enter Entity Description""");
            WriteLiteral(@");
                    return false;
                }

                if ($('#cboUnitType').val() === ""M"") {
                    if (IsStringNullorEmpty($(""#txtNoofUnits"").val())) {
                        toastr.warning(""Please Enter Number of Units"");
                        return false;
                    }
                    if (Number($(""#txtNoofUnits"").val()) <= 1) {
                        toastr.warning(""Number of Units should be greater than one"");
                        return false;
                    }
                }
            }

            function fnClearFields() {

                $(""#txtBusinessEntityId"").val('');
                $(""#txtEntityDescription"").val('');
                $(""#chkIsMultiSegmentApplicable"").parent().removeClass(""is-checked"");
                $('#cboUnitType').val('S').selectpicker('refresh');
                $('#txtNoofUnits').val('');
                $('#txtNoActiveofUnits').val('0');
                $(""#chkActiveStatus"").parent().a");
            WriteLiteral(@"ddClass(""is-checked"");
                $(""#btnSaveBusinessEntity"").html('<i class=""fa fa-plus""></i> Add');
            }

            function validationBusinessEntityOnDelete() {

                if (IsStringNullorEmpty($(""#txtBusinessEntityId"").val())) {
                    toastr.warning(""Please Select Business Entity"");
                    return false;
                }

                if (IsStringNullorEmpty($(""#txtEntityDescription"").val())) {
                    toastr.warning(""Please Enter Entity Description"");
                    return false;
                }
            }

            function fnDeleteNode() {

                if (validationBusinessEntityOnDelete() === false) {
                    return;
                }
                $(""#btnDeleteNode"").attr('disabled', true);
                $.ajax({
                    url: getBaseURL() + '/License/DeleteBusinessEntity?BusinessEntityId=' + $(""#txtBusinessEntityId"").val(),
                    type: 'POST',
       ");
            WriteLiteral(@"             datatype: 'json',
                    success: function (response) {
                        if (response.Status) {
                            toastr.success(response.Message);
                            location.reload();

                            return true;
                        }
                        else {
                            toastr.error(response.Message);
                            return false;
                        }

                    },
                    error: function (error) {
                        toastr.error(error.statusText);
                    }
                });
            }

            function fnExpandAll() {
                $('#jstBusinessEntity').jstree('open_all');
            }
            function fnCollapseAll() {
                fnClearFields();
                $(""#pnlMainMenu"").hide();
                $('#jstBusinessEntity').jstree('close_all');
            }
            function fnTreeSize() {
           ");
            WriteLiteral("     $(\"#jstBusinessEntity\").css({\r\n                    \'height\': $(window).innerHeight() - 136,\r\n                    \'overflow\': \'auto\'\r\n                });\r\n            }\r\n        </script>\r\n\r\n");
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
