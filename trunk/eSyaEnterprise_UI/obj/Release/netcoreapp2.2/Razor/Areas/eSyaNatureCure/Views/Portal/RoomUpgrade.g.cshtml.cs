#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\Portal\RoomUpgrade.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90a5c0f904bd23b7e6058638bfe1a3038c5ebdd0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_eSyaNatureCure_Views_Portal_RoomUpgrade), @"mvc.1.0.view", @"/Areas/eSyaNatureCure/Views/Portal/RoomUpgrade.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/eSyaNatureCure/Views/Portal/RoomUpgrade.cshtml", typeof(AspNetCore.Areas_eSyaNatureCure_Views_Portal_RoomUpgrade))]
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
#line 1 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\Portal\RoomUpgrade.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90a5c0f904bd23b7e6058638bfe1a3038c5ebdd0", @"/Areas/eSyaNatureCure/Views/Portal/RoomUpgrade.cshtml")]
    public class Areas_eSyaNatureCure_Views_Portal_RoomUpgrade : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(82, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\Portal\RoomUpgrade.cshtml"
  
    ViewData["Title"] = "RoomUpgrade";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(178, 55, true);
            WriteLiteral("<script>\r\n    var localization = {\r\n         Actions: \'");
            EndContext();
            BeginContext(234, 20, false);
#line 11 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\Portal\RoomUpgrade.cshtml"
              Write(Localizer["Actions"]);

#line default
#line hidden
            EndContext();
            BeginContext(254, 19, true);
            WriteLiteral("\',\r\n        Edit: \'");
            EndContext();
            BeginContext(274, 17, false);
#line 12 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\Portal\RoomUpgrade.cshtml"
          Write(Localizer["Edit"]);

#line default
#line hidden
            EndContext();
            BeginContext(291, 19, true);
            WriteLiteral("\',\r\n        View: \'");
            EndContext();
            BeginContext(311, 17, false);
#line 13 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\Portal\RoomUpgrade.cshtml"
          Write(Localizer["View"]);

#line default
#line hidden
            EndContext();
            BeginContext(328, 21, true);
            WriteLiteral("\',\r\n        Update: \'");
            EndContext();
            BeginContext(350, 19, false);
#line 14 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\Portal\RoomUpgrade.cshtml"
            Write(Localizer["Update"]);

#line default
#line hidden
            EndContext();
            BeginContext(369, 31, true);
            WriteLiteral("\',\r\n        UpdateRoomUpgrade:\'");
            EndContext();
            BeginContext(401, 30, false);
#line 15 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\Portal\RoomUpgrade.cshtml"
                      Write(Localizer["UpdateRoomUpgrade"]);

#line default
#line hidden
            EndContext();
            BeginContext(431, 29, true);
            WriteLiteral("\',\r\n        ViewRoomUpgrade:\'");
            EndContext();
            BeginContext(461, 28, false);
#line 16 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\Portal\RoomUpgrade.cshtml"
                    Write(Localizer["ViewRoomUpgrade"]);

#line default
#line hidden
            EndContext();
            BeginContext(489, 6652, true);
            WriteLiteral(@"'
    }
    </script>
    <div class=""row"">
        <div class=""col-lg-12 col-md-12 col-12"">
            <table id=""jqgRoomUpgrade""></table>
            <div id=""jqpRoomUpgrade""></div>
        </div>
    </div>
        <div class=""modal fade in"" id=""PopupRoomUpgrade"" data-keyboard=""false"" data-backdrop=""static"">
            <div class=""modal-dialog modal-md"" role=""document"" style=""box-shadow:none;"">
                <div class=""modal-content "">
                    <div class=""modal-header popupHeader"">
                        <button type=""button"" class=""close ml-auto"" data-dismiss=""modal""> <i class=""fa fa-times""></i></button>
                        <h4 class=""modal-title"">Add Room Upgrade</h4>
                    </div>

                    <div class=""modal-body"">
                        <div class=""row"">
                            <div class=""col-lg-6 col-md-6 col-sm-12 form-group"">
                                <label>Member Type</label>
                                <select clas");
            WriteLiteral(@"s="" selectpicker w-100"" name=""membertype"" id=""cboMemberType"">
                                    <option value=""select"">Select </option>
                                </select>
                            </div>
                            <div class=""col-lg-6 col-md-6 col-sm-12 form-group"">
                                <label>Room Type</label>
                                <select class="" selectpicker w-100"" name=""roomtype"" id=""cboRoomType"">
                                    <option value=""select"">Select </option>
                                </select>
                            </div>
                            <div class=""col-lg-6  col-md-6 col-sm-12 col-xs-12 d-flex align-items-center"">
                                <label class=""mdl-checkbox mdl-js-checkbox mdl-js-ripple-effect"" for=""chkUpgradeAllowed"">
                                    <input type=""checkbox"" id=""chkUpgradeAllowed"" class=""mdl-checkbox__input"">
                                        <span class=""mdl-checkb");
            WriteLiteral(@"ox__label"">Upgrade Allowed</span>
                        </label>
                    </div>
                            </div>

                        </div>
                        <div class=""modal-footer"">
                            <div class=""row"">
                                <div class=""col-lg-12"">
                                    <button class=""mdl-button  primary-button"" id=""btnSaveRoomUpgrade""><i class=""fa fa-save""></i> Save </button>
                                    <button class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect  cancel-button cancel-button"" data-dismiss=""modal"" id=""btnCancelCodeType""><i class=""fa fa-times""></i> Cancel </button>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <script>
                $(function () {
                    fnLoadGridRoomUpgrade();
                });
    function fn");
            WriteLiteral(@"LoadGridRoomUpgrade() {
                    $(""#jqgRoomUpgrade"").jqGrid('GridUnload');
                $(""#jqgRoomUpgrade"").jqGrid({
                    data: [{RoomType: 'Deluxe', ConsumptionDays: '1.5 Days', Actions: '' }],
                datatype: ""local"",
                colNames: [""Room Type"", ""Consumption Days"", ""Action""],
                colModel: [
                {name: ""RoomType"", width: 150, editable: true, align: 'left', hidden: false },
                {name: ""ConsumptionDays"", width: 150, editable: true, align: 'left', hidden: false },
                {
                    name: 'Actions', search: false, align: 'left', width: 120, sortable: false, resizable: false,
                    formatter: function (cellValue, options, rowdata, action) {
                        return '<button class=""btn-xs ui-button ui-widget ui-corner-all btn-jqgrid"" title=""Edit"" id=""jqgEdit"" onclick=""return fnEditRoomUpgrade(event,\'edit\')""> <i class=""fas fa-pen""></i> ' + localization.Edit + '</button>' +");
            WriteLiteral(@"
                            '<button class=""btn-xs ui-button ui-widget ui-corner-all btn-jqgrid"" title=""View"" id=""jqgView"" onclick=""return fnEditRoomUpgrade(event,\'view\')""><i class=""far fa-eye""></i> ' + localization.View + '</button>'
                    }
                }
            ],
            pager: ""#jqpRoomUpgrade"",
            rowNum: 10000,
            loadonce: false,
            viewrecords: true,
            gridview: true,
            rownumbers: true,
            rownumWidth: '55',
            height: 'auto',
            width: 'auto',
            autowidth: true,
            shrinkToFit: true,
            forceFit: true,
            loadComplete: function () {
                    //fnPanelSetup();
                },
        }).jqGrid('navGrid', '#jqpRoomUpgrade', {add: false, edit: false, search: false, del: false, refresh: false }).jqGrid('navButtonAdd', '#jqpRoomUpgrade', {
                    caption: '<span class=""fa fa-sync""></span> Refresh', buttonicon: ""none"", i");
            WriteLiteral(@"d: ""custRefresh"", position: ""first"", onClickButton: fnGridRefreshRoomUpgrade
        }).jqGrid('navButtonAdd', '#jqpRoomUpgrade', {
                    caption: '<span class=""fa fa-plus"" data-toggle=""modal""></span> Add', buttonicon: 'none', id: 'jqgAdd', position: 'first', onClickButton: fnAddRoomUpgrade
            });
        }
    function fnAddRoomUpgrade() {
                    $(""#PopupRoomUpgrade"").modal(""show"");
                }
    function fnGridRefreshRoomUpgrade() {

                }
    function fnEditRoomUpgrade(e, actiontype) {
            var rowid = $(e.target).parents(""tr.jqgrow"").attr('id');
            var rowData = $('#jqgRoomUpgrade').jqGrid('getRowData', rowid);
            $('#PopupRoomUpgrade').modal('show');
            if (actiontype.trim() == ""edit"") {
                $('#PopupRoomUpgrade').find('.modal-title').text(localization.UpdateRoomUpgrade);
                $(""#btnSaveRoomUpgrade"").html('<i class=""fa fa-sync""></i> '+localization.Update);
                $");
            WriteLiteral(@"(""#btnSaveRoomUpgrade"").show();
                $(""#cboMemberType,#cboRoomType,#chkUpgradeAllowed"").attr('disabled', false);      
                $(""#chkActiveStatus"").prop('disabled', true);
        }
        if (actiontype.trim() == ""view"") {
            $('#PopupRoomUpgrade').find('.modal-title').text(localization.ViewRoomUpgrade);
            $(""#cboMemberType,#cboRoomType,#chkUpgradeAllowed"").attr('disabled', true);  
            $(""#btnSaveRoomUpgrade"").hide();
        }
    }
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
