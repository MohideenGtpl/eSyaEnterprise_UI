#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Inventory\ESF_46_00.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc7d18470007a58b02ee1f150b81a61dfa288b6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_eSyaConfig_Views_Inventory_ESF_46_00), @"mvc.1.0.view", @"/Areas/eSyaConfig/Views/Inventory/ESF_46_00.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/eSyaConfig/Views/Inventory/ESF_46_00.cshtml", typeof(AspNetCore.Areas_eSyaConfig_Views_Inventory_ESF_46_00))]
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
#line 1 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Inventory\ESF_46_00.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc7d18470007a58b02ee1f150b81a61dfa288b6a", @"/Areas/eSyaConfig/Views/Inventory/ESF_46_00.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Areas/eSyaConfig/Views/_ViewImports.cshtml")]
    public class Areas_eSyaConfig_Views_Inventory_ESF_46_00 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/jsTree.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jsTree.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/listswap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.listswap.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Inventory\ESF_46_00.cshtml"
  
    ViewData["Title"] = "ESF_46_00";

#line default
#line hidden
#line 8 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Inventory\ESF_46_00.cshtml"
  
    var userFormRole = (eSyaEnterprise_UI.Models.DO_UserFormRole)ViewBag.UserFormRole;

#line default
#line hidden
            BeginContext(224, 46, true);
            WriteLiteral("<script>\r\n    var _userFormRole = JSON.parse(\'");
            EndContext();
            BeginContext(271, 38, false);
#line 12 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Inventory\ESF_46_00.cshtml"
                               Write(Html.Raw(Json.Serialize(userFormRole)));

#line default
#line hidden
            EndContext();
            BeginContext(309, 1089, true);
            WriteLiteral(@"');
</script>

<div class=""row row-bottom-pad"">
    <div class=""col-sm-12 col-md-4 col-lg-4"">
        <div id=""jtrForms"">
        </div>
    </div>

    <div id=""dvStoreFormLink"" class=""col-lg-8 col-md-8 col-sm-12"" style=""display:none"">
        <div class=""demo-card-square mdl-card mdl-shadow--2dp fullwidth"" id=""pnlAddForms"">
            <div class=""mdl-card__title mdl-card--expand padleft0 padtop0 d-block"">
                <h5 class=""mdl-card__title-text""> Stores Linking</h5>
            </div>
            <div class=""mdl-card__supporting-text fullwidth"">
                <div class=""col-lg-12 col-md-12 col-sm-12 pad0"">
                    <table id=""jqgFormStoreLink""></table>
                    <div id=""pgFormStoreLink""></div>
                </div>
                <div style=""text-align:center;padding:5px"">
                    <button class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent primary-button"" id=""btnSaveFormStoreLink"" onclick=""fnSaveFormSt");
            WriteLiteral("oreLink();\">\r\n                        <i class=\"fa fa-save\"></i> ");
            EndContext();
            BeginContext(1399, 17, false);
#line 33 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Inventory\ESF_46_00.cshtml"
                                              Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(1416, 119, true);
            WriteLiteral("\r\n                    </button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1552, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1558, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dc7d18470007a58b02ee1f150b81a61dfa288b6a8214", async() => {
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
                BeginContext(1607, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1613, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc7d18470007a58b02ee1f150b81a61dfa288b6a9548", async() => {
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
                BeginContext(1651, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(1659, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dc7d18470007a58b02ee1f150b81a61dfa288b6a10807", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1710, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1716, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc7d18470007a58b02ee1f150b81a61dfa288b6a12142", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1763, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            BeginContext(1770, 2131, true);
            WriteLiteral(@"
<script>
    $(function () {
        fnLoadFormsTree();
    });

    var prevSelectedID = 'FM';
    var _selectedFormId = 0;

    function fnLoadFormsTree() {

        $.ajax({
            url: getBaseURL() + '/Inventory/GetFormForStorelinking',
            type: 'POST',
            datatype: 'json',
            contentType: 'application/json; charset=utf-8',
            async: false,
            success: function (result) {
                $(""#jtrForms"").jstree({ core: { data: result, multiple: false } });
            },
            error: function (error) {
                toastr.error(error.statusText)
            }
        });

        $(""#jtrForms"").on('loaded.jstree', function () {
            $(""#jtrForms"").jstree()._open_to(prevSelectedID);
            $('#jtrForms').jstree().select_node(prevSelectedID);
        });

        $('#jtrForms').on(""changed.jstree"", function (e, data) {
            if (data.node != undefined) {
                prevSelectedID = data.node.id;");
            WriteLiteral(@"

                var parentNode = $(""#jtrForms"").jstree(true).get_parent(data.node.id);

                var formID = prevSelectedID;
                if (parentNode == ""FM"") {
                    $(""#dvStoreFormLink"").show();
                    fnLoadFormSubParameterGrid(formID);
                    fnPanelSetup();
                }
            }

        });

        $('#jtrForms').on(""close_node.jstree"", function (node) {
            var closingNode = node.handleObj.handler.arguments[1].node;
            $('#jtrForms').jstree().deselect_node(closingNode.children);
        });
    }

    function fnLoadFormSubParameterGrid(formID) {

        _selectedFormId = formID;
         $(""#jqgFormStoreLink"").GridUnload();
        // debugger;
         $(""#jqgFormStoreLink"").jqGrid({
             url: getBaseURL() + '/Inventory/GetStoreFormLinked',
            datatype: ""json"",
            mtype: 'POST',
            rownumbers: true,
            postData: {
                formId: functi");
            WriteLiteral("on () { return formID; },\r\n            },\r\n             colNames: [ \"Store Code\", \"");
            EndContext();
            BeginContext(3902, 18, false);
#line 116 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Inventory\ESF_46_00.cshtml"
                                   Write(Localizer["Store"]);

#line default
#line hidden
            EndContext();
            BeginContext(3920, 4, true);
            WriteLiteral("\", \"");
            EndContext();
            BeginContext(3925, 25, false);
#line 116 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Inventory\ESF_46_00.cshtml"
                                                          Write(Localizer["ActiveStatus"]);

#line default
#line hidden
            EndContext();
            BeginContext(3950, 3087, true);
            WriteLiteral(@"""],
             colModel: [

                 { name: 'StoreCode', key: true, index: 'StoreCode', width: 0, sortable: false, hidden: true },
                 { name: 'StoreDesc', index: 'StoreDesc', width: 300, sortable: false },
                 { name: 'ActiveStatus', index: 'ActiveStatus', width: 75, align: 'center', sortable: false, formatter: 'checkbox', editable: true, edittype: ""checkbox"" }
            ],
            caption: """",
            height: 'auto',
            width: '400',
            rowNum:100,
            viewrecords: true,
            gridview: true,
            loadonce:true,
            autowidth: true,
            shrinkToFit: true,
            forceFit: true,
            cellEdit: true,
             onSelectRow: function (id) {
                if (id) { $('#jqgFormStoreLink').jqGrid('editRow', id, true); }
            },
            loadComplete: function () {
                var ids = $('#jqgFormStoreLink').jqGrid('getDataIDs');
                var i = 0;
   ");
            WriteLiteral(@"             for (i = 0; i < ids.length; i++) {
                    if (ids[i])
                        $('#jqgFormStoreLink').jqGrid('editRow', ids[i]);
                }
              
            }
         });
        
    }
    function fnPanelSetup() {
        var winHeight = $(window).height();
        var navbarHeight = $('.navbar').height();
        var bannerHeight = $('.banner').height();
        var cardTitleHeight = $('.mdl-card__title').height();
        var panelHeight = (winHeight - (navbarHeight + bannerHeight + cardTitleHeight));
        $("".mdl-card__supporting-text"").css('height', panelHeight - 32);
    }

    function fnSaveFormStoreLink() {
        var $grid = $(""#jqgFormStoreLink"")
        var l_FormStoreCodes = [];
        var ids = jQuery(""#jqgFormStoreLink"").jqGrid('getDataIDs');
        for (var i = 0; i < ids.length; i++) {
            var rowId = ids[i];
            var rowData = jQuery('#jqgFormStoreLink').jqGrid('getRowData', rowId);
            if (rowD");
            WriteLiteral(@"ata.ActiveStatus == ""Yes"") {
                l_FormStoreCodes.push({ FormId: _selectedFormId, StoreCode: rowData.StoreCode })
            }
        }

        $(""#btnSaveFormStoreLink"").attr(""disabled"", true);
        $.ajax({
            url: getBaseURL() + '/Inventory/InsertIntoFormStoreLink',
            type: 'POST',
            datatype: 'json',
            data: { l_obj : l_FormStoreCodes },
            async: false,
            success: function (response) {
                if (response.Status == true) {
                    toastr.success(""Updated"");
                    $('#dvStoreFormLink').hide();
                }
                else {
                    toastr.error(response.Message);
                }
                $(""#btnSaveFormStoreLink"").attr(""disabled"", false);
            },
            error: function (error) {
                toastr.error(error.statusText);
                $(""#btnSaveFormStoreLink"").attr(""disabled"", false);
            }
        });

    }
");
            WriteLiteral("\r\n\r\n</script>\r\n");
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
