#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Facilities\Views\Doctors\_BusinessLink.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbefd2b1574a36d4ea067d33ecf169208b22b0fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Facilities_Views_Doctors__BusinessLink), @"mvc.1.0.view", @"/Areas/Facilities/Views/Doctors/_BusinessLink.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Facilities/Views/Doctors/_BusinessLink.cshtml", typeof(AspNetCore.Areas_Facilities_Views_Doctors__BusinessLink))]
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
#line 4 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Facilities\Views\Doctors\_BusinessLink.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbefd2b1574a36d4ea067d33ecf169208b22b0fa", @"/Areas/Facilities/Views/Doctors/_BusinessLink.cshtml")]
    public class Areas_Facilities_Views_Doctors__BusinessLink : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(120, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(168, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(258, 512, true);
            WriteLiteral(@"<div class=""row"">
    <div class=""col-lg-12 col-md-12 col-sm-12"">
        <table id=""jqgDoctorBusinessLink""> </table>
        <div id=""jqpDoctorBusinessLink""></div>
    </div>
</div>

<div class=""row  form-group"">
    <div class=""col-lg-12 col-md-12 col-sm-12 text-center"">
        <hr />
        <button type=""button"" class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent btn-back mr-10 c-white"" onclick=""fnCloseDoctorMaster()""><i class=""fas fa-chevron-left""></i> ");
            EndContext();
            BeginContext(771, 17, false);
#line 18 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Facilities\Views\Doctors\_BusinessLink.cshtml"
                                                                                                                                                                                                                Write(Localizer["Back"]);

#line default
#line hidden
            EndContext();
            BeginContext(788, 251, true);
            WriteLiteral("</button>\r\n        <button type=\"button\" class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent primary-button mr-10\" id=\"btnSaveDoctorBusinessLink\" onclick=\"fnSaveDoctorBusinessLink()\"><i class=\"far fa-save\"></i>  ");
            EndContext();
            BeginContext(1040, 17, false);
#line 19 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Facilities\Views\Doctors\_BusinessLink.cshtml"
                                                                                                                                                                                                                                           Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(1057, 236, true);
            WriteLiteral("</button>\r\n        <button type=\"button\" class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect  cancel-button\" id=\"btnClearDoctorBusinessLink\" onclick=\"fnGridRefreshDoctorBusinessLinkGrid()\"><i class=\"fa fa-redo\"></i> ");
            EndContext();
            BeginContext(1294, 18, false);
#line 20 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Facilities\Views\Doctors\_BusinessLink.cshtml"
                                                                                                                                                                                                                            Write(Localizer["Clear"]);

#line default
#line hidden
            EndContext();
            BeginContext(1312, 4692, true);
            WriteLiteral(@"</button>
    </div>
</div>

<script>

    function fnGridDoctorBusinessLink() {
        $(""#jqgDoctorBusinessLink"").jqGrid('GridUnload');
        $(""#jqgDoctorBusinessLink"").jqGrid(
            {
                url: getBaseURL() + '/Doctor/GetBusinessLocationDoctorList?doctorId=' + $('#txtDoctorId').val(),
                datatype: 'json',
                mtype: 'POST',
                //ajaxGridOptions: { contentType: 'application/json; charset=utf-8' },
                colNames: ['Business Key', localization.SegmentDescription, localization.BusinessLocation, localization.Select],
                colModel: [
                    { name: ""BusinessKey"", width: 70, editable: true, align: 'left', hidden: true },
                    { name: 'SegmentDesc', index: 'SegmentDesc', width: '270', resizable: false },
                    { name: 'LocationDescription', index: 'LocationDescription', width: '228', resizable: false },
                    {
                        name: 'ActiveStatus', in");
            WriteLiteral(@"dex: 'ActiveStatus', width: 70, resizable: false, align: 'center',
                        formatter: ""checkbox"", formatoptions: { disabled: false },
                        edittype: ""checkbox"", editoptions: { value: ""true:false"" }
                    },
                ],
                rowNum: 10,
                rowList: [10, 20, 50, 100],
                rownumWidth: '55',
                loadonce: true,
                pager: ""#jqpDoctorBusinessLink"",
                viewrecords: true,
                gridview: true,
                rownumbers: true,
                height: 'auto',
                width: 'auto',
                autowidth: true,
                shrinkToFit: true,
                forceFit: true,
                scroll: false,
                scrollOffset: 0,
                cellEdit: true,
                cellsubmit: 'clientArray',
                onSelectRow: function (id) {
                    if (id) { $('#jqpDoctorBusinessLink').jqGrid('editRow', id, true); }
");
            WriteLiteral(@"                },
                rowattr: function (item) {
                    if (_formEdit === false) {
                        return { ""class"": ""ui-state-disabled ui-jqgrid-disablePointerEvents"" };
                    }
                },
                beforeSelectRow: function (rowid, e) {
                    if ($(e.target).closest(""tr.jqgrow"").hasClass(""ui-state-disabled"")) {
                        return false;
                    }
                    return true;
                }
            }).jqGrid('navGrid', '#jqpDoctorBusinessLink', { add: false, edit: false, search: false, del: false, refresh: false });
    }



    function fnGridRefreshDoctorBusinessLinkGrid() {
        $(""#jqgDoctorBusinessLink"").setGridParam({ datatype: 'json', page: 1 }).trigger('reloadGrid')
    }

    function fnSaveDoctorBusinessLink() {
        if ($('#txtDoctorId').val() == '' || $('#txtDoctorId').val() == '0') {
            toastr.warning(""Please Select Doctor"");
            return;
 ");
            WriteLiteral(@"       }

        $(""#btnSaveDoctorBusinessLink"").attr('disabled', false);

        var obj = [];
        var rowData = $('#jqgDoctorBusinessLink').jqGrid('getRowData');

        for (var i = 0; i < rowData.length; i++) {
            var sp =
            {
                BusinessKey: rowData[i]['BusinessKey'],
                DoctorId: $('#txtDoctorId').val(),
                ActiveStatus: rowData[i]['ActiveStatus']
            };
            obj.push(sp);
        }

        $.ajax({
            url: getBaseURL() + '/Doctor/InsertUpdateDoctorBusinessLink',
            type: 'POST',
            datatype: 'json',
            data: { obj },
            success: function (response) {
                if (response != null) {
                    if (response.Status) {
                        toastr.success(response.Message);
                        fnGridDoctorBusinessLink();
                        $(""#btnSaveDoctorBusinessLink"").attr('disabled', false);
                    }
         ");
            WriteLiteral(@"           else {
                        toastr.error(response.Message);
                        $(""#btnSaveDoctorBusinessLink"").attr('disabled', false);
                    }
                }
                else {
                    toastr.error(response.Message);
                    $(""#btnSaveDoctorBusinessLink"").attr('disabled', false);
                }
            },
            error: function (error) {
                toastr.error(error.statusText);
                $(""#btnSaveDoctorBusinessLink"").attr(""disabled"", false);
            }
        });
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
