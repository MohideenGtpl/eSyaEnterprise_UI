#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Facilities\Views\Doctors\_SpecialtyLink.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c52540874768af54e3a0205125ba081366861f27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Facilities_Views_Doctors__SpecialtyLink), @"mvc.1.0.view", @"/Areas/Facilities/Views/Doctors/_SpecialtyLink.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Facilities/Views/Doctors/_SpecialtyLink.cshtml", typeof(AspNetCore.Areas_Facilities_Views_Doctors__SpecialtyLink))]
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
#line 5 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Facilities\Views\Doctors\_SpecialtyLink.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c52540874768af54e3a0205125ba081366861f27", @"/Areas/Facilities/Views/Doctors/_SpecialtyLink.cshtml")]
    public class Areas_Facilities_Views_Doctors__SpecialtyLink : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(120, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(258, 65, true);
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-lg-4 col-md-4 col-sm-6\">\r\n");
            EndContext();
            BeginContext(634, 75, true);
            WriteLiteral("\r\n        <div class=\"form-group\">\r\n            <label class=\"lable-color\">");
            EndContext();
            BeginContext(710, 21, false);
#line 16 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Facilities\Views\Doctors\_SpecialtyLink.cshtml"
                                  Write(Localizer["Location"]);

#line default
#line hidden
            EndContext();
            BeginContext(731, 290, true);
            WriteLiteral(@"</label>
            <select class=""selectpicker"" dada-live-search=""true"" id=""cboLocation"" title="""" onchange=""fnLoadSpecialty()""></select>
        </div>

    </div>
    <div class=""col-lg-4 col-md-4 col-sm-6"">
        <div class=""form-group"">
            <label class=""lable-color"">");
            EndContext();
            BeginContext(1022, 22, false);
#line 23 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Facilities\Views\Doctors\_SpecialtyLink.cshtml"
                                  Write(Localizer["Specialty"]);

#line default
#line hidden
            EndContext();
            BeginContext(1044, 498, true);
            WriteLiteral(@"</label>
            <select class=""selectpicker"" dada-live-search=""true"" id=""cboSpecialty"" title=""""></select>
        </div>
    </div>
    <div class=""col-lg-2  col-md-3 col-sm-12 col-xs-12"">
        <div class=""default-checkbox"">
            <label class=""mdl-checkbox mdl-js-checkbox mdl-js-ripple-effect"" for=""chkSpecialtyActiveStatus"">
                <input type=""checkbox"" id=""chkSpecialtyActiveStatus"" class=""mdl-checkbox__input"">
                <span class=""mdl-checkbox__label"">");
            EndContext();
            BeginContext(1543, 19, false);
#line 31 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Facilities\Views\Doctors\_SpecialtyLink.cshtml"
                                             Write(Localizer["Active"]);

#line default
#line hidden
            EndContext();
            BeginContext(1562, 319, true);
            WriteLiteral(@"</span>
            </label>
        </div>
    </div>
    <div class=""col-lg-2 col-md-3 col-sm-6 padtop20 padbot20"">
        <button type=""button"" class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect"" id=""btnDoctorSpecialtySave"" onclick=""fnSaveDoctorSpecialtyLink()""><i class=""fa fa-plus""></i> ");
            EndContext();
            BeginContext(1882, 17, false);
#line 36 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Facilities\Views\Doctors\_SpecialtyLink.cshtml"
                                                                                                                                                                                               Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(1899, 545, true);
            WriteLiteral(@"</button>
    </div>
</div>
<div class=""row"">
    <div class=""col-lg-12 col-md-12 col-sm-12"">
        <table id=""jqgDoctorSpecialtyLink""> </table>
        <div id=""jqpDoctorSpecialtyLink""></div>
    </div>
</div>

<div class=""row  form-group"">
    <div class=""col-lg-12 col-md-12 col-sm-12 text-center"">
        <hr />
        <button type=""button"" class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent btn-back mr-10 c-white"" onclick=""fnCloseDoctorMaster()""><i class=""fas fa-chevron-left""></i> ");
            EndContext();
            BeginContext(2445, 17, false);
#line 49 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\Facilities\Views\Doctors\_SpecialtyLink.cshtml"
                                                                                                                                                                                                                Write(Localizer["Back"]);

#line default
#line hidden
            EndContext();
            BeginContext(2462, 10195, true);
            WriteLiteral(@"</button>

    </div>
</div>


<script>

    $(document).ready(function () {
        //fnGridDoctorSpecialtyLink();
        $('#cboLocation').selectpicker('refresh');
        $('#cboSpecialty').selectpicker('refresh');
    });

    function fnGridDoctorSpecialtyLink() {
        $(""#jqgDoctorSpecialtyLink"").jqGrid('GridUnload');
        $(""#jqgDoctorSpecialtyLink"").jqGrid(
            {
                url: getBaseURL() + '/Doctors/GetSpecialtyListByDoctorId?doctorId=' + $('#txtDoctorId').val(),
                datatype: 'json',
                mtype: 'POST',
                //ajaxGridOptions: { contentType: 'application/json; charset=utf-8' },
                colNames: ['BusinessKey', localization.BusinessLocation, 'SpecialtyID', localization.Specialty, localization.Active, localization.Actions],
                colModel: [
                    { name: ""BusinessKey"", width: 170, editable: true, align: 'left', hidden: true },
                    { name: ""LocationDesc"", width: 170, edita");
            WriteLiteral(@"ble: true, align: 'left', hidden: false },
                    { name: 'SpecialtyID', width: 170, resizable: false, hidden: true },
                    { name: 'SpecialtyDesc', width: 170, resizable: false },
                    {
                        name: 'ActiveStatus', index: 'ActiveStatus', width: 70, resizable: false, align: 'center', formatter: ""checkbox"", edittype: ""checkbox"", editoptions: { value: ""true:false"" }
                    },
                    {
                        name: 'delete', search: false, align: 'center', width: 100, sortable: false, resizable: false,
                        formatter: function (cellValue, options, rowdata, action) {
                            return '<button class=""btn-xs ui-button ui-widget ui-corner-all btn-jqgrid cancel-button"" id=""jqgDSPDelete"", onclick=""return fnDeleteSpecialty(event)""><i class=""far fa-trash-alt""></i> ' + localization.Delete + ' </button>'
                        }
                    },
                ],
                ");
            WriteLiteral(@"rowNum: 10,
                rowList: [10, 20, 50, 100],
                rownumWidth:55,
                loadonce: true,
                pager: ""#jqpDoctorSpecialtyLink"",
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
                loadComplete: function (data) {
                    SetDoctorSpecialtyGridControlByAction(""jqgDoctorSpecialtyLink"");
                }
            }).jqGrid('navGrid', '#jqpDoctorSpecialtyLink', { add: false, edit: false, search: false, del: false, refresh: false });
    }



    function fnGridRefreshDoctorSpecialtyLinkGrid() {
        $(""#jqgDoctorSpecialtyLink"").setGridParam({ datatype: 'json', page: 1 }).trigger('reloadGrid')
    }
    function fnDeleteSpecialty(e) {

     ");
            WriteLiteral(@"   var rowid = $(e.target).parents(""tr.jqgrow"").attr('id');
        var rowData = $('#jqgDoctorSpecialtyLink').jqGrid('getRowData', rowid);
        //alert(JSON.stringify(rowData));
        if (rowData != null) {

            var obj = {
                BusinessKey: rowData.BusinessKey,
                SpecialtyID: rowData.SpecialtyID,
                DoctorID: $('#txtDoctorId').val(),
                ActiveStatus: false
            }

            $.ajax({
                url: getBaseURL() + '/Doctors/UpdateDoctorSpecialtyLink',
                type: 'POST',
                datatype: 'json',
                data: { obj },
                success: function (response) {
                    if (response != null) {
                        if (response.Status) {
                            toastr.success(response.Message);
                            fnGridDoctorSpecialtyLink();

                        }
                        else {
                            toastr.error(response.Mess");
            WriteLiteral(@"age);

                        }
                    }
                    else {
                        toastr.error(response.Message);

                    }
                },
                error: function (error) {
                    toastr.error(error.statusText);

                }
            });
        }
    }

    function fnLoadSpecialty() {
        $('#cboSpecialty').selectpicker('refresh');
        $.ajax({
            url: getBaseURL() + '/Facilities/Specialty/GetSpecialtyListForBusinessKey?businessKey=' + $('#cboLocation').val(),
            type: 'POST',
            datatype: 'json',
            async: false,
            success: function (response) {
                var options = $(""#cboSpecialty"");
                $(""#cboSpecialty"").empty();
                $(""#cboSpecialty"").append($(""<option value='0'>Choose Specialty</option>""));
                    $.each(response, function () {
                        options.append($(""<option />"").val(this.SpecialtyID).");
            WriteLiteral(@"text(this.SpecialtyDesc));
                    });

                if ($('#cboSpecialty option').length == 2) {
                    $('#cboSpecialty').prop('selectedIndex', 1);
                    $('#cboSpecialty').selectpicker('refresh');
                } else {

                    $(""#cboSpecialty"").val($('#cboSpecialty option:first').val());
                    $('#cboSpecialty').selectpicker('refresh');
                }



                $('#chkSpecialtyActiveStatus').parent().addClass(""is-checked"");
            },
            error: function (error) {
                toastr.error(error.statusText);

            }
        });
    }

    function fnSaveDoctorSpecialtyLink() {
        if ($('#txtDoctorId').val() == '' || $('#txtDoctorId').val() == '0') {
            toastr.warning(""Please Select Doctor"");
            return;
        }
        if ($('#cboLocation').val() == '' || $('#cboLocation').val() == '0') {
            toastr.warning(""Please Select Location"");
      ");
            WriteLiteral(@"      $('#cboLocation').focus();
            return;
        }
        if ($('#cboSpecialty').val() == '' || $('#cboSpecialty').val() == '0') {
            toastr.warning(""Please Select Specialty"");
            $('#cboSpecialty').focus();
            return;
        }
        if ($('#chkSpecialtyActiveStatus').parent().hasClass(""is-checked"") == false) {
            toastr.warning(""Please Select Active Status"");
            $('#chkSpecialtyActiveStatus').focus();
            return;
        }
        //alert($('#chkSpecialtyActiveStatus').parent().hasClass(""is-checked""));

        $(""#btnDoctorSpecialtySave"").attr(""disabled"", true);

        var obj = {
            BusinessKey: $('#cboLocation').val(),
            SpecialtyID: $('#cboSpecialty').val(),
            DoctorID: $('#txtDoctorId').val(),
            ActiveStatus: $('#chkSpecialtyActiveStatus').parent().hasClass(""is-checked"")
        }

        $.ajax({
            url: getBaseURL() + '/Doctors/InsertDoctorSpecialtyLink',
  ");
            WriteLiteral(@"          type: 'POST',
            datatype: 'json',
            data: { obj },
            success: function (response) {
                if (response != null) {
                    if (response.Status) {
                        toastr.success(response.Message);
                        fnGridDoctorSpecialtyLink();
                        //$('#cboSpecialty').val('');
                        //$('#cboSpecialty').selectpicker('refresh');
                        $(""#btnDoctorSpecialtySave"").attr('disabled', false);
                    }
                    else {
                        toastr.error(response.Message);
                        $(""#btnDoctorSpecialtySave"").attr('disabled', false);
                    }
                }
                else {
                    toastr.error(response.Message);
                    $(""#btnDoctorSpecialtySave"").attr('disabled', false);
                }
            },
            error: function (error) {
                toastr.error(error.sta");
            WriteLiteral(@"tusText);
                $(""#btnDoctorSpecialtySave"").attr(""disabled"", false);
            }
        });
    }

    function SetDoctorSpecialtyGridControlByAction(jqg) {


        if (_formDelete === false) {
            var eleDisable = document.querySelectorAll('#jqgDSPDelete');
            for (var i = 0; i < eleDisable.length; i++) {
                eleDisable[i].disabled = true;
                eleDisable[i].className = ""ui-state-disabled"";
            }

        }
    }


    function fnBindDoctorLocationbyDoctorId() {
        $('#cboLocation').selectpicker('refresh');
                $.ajax({
                    type: ""Post"",
                    url: getBaseURL() + '/Doctors/GetDoctorLocationbyDoctorId?doctorId='+ $('#txtDoctorId').val(),
                    dataType: ""json"",
                    success: function (data) {
                        var opt = $(""#cboLocation"");
                        $(""#cboLocation"").empty();
                        $(""#cboLocation"").append(");
            WriteLiteral(@"$(""<option value='0'>Choose Location</option>""));
                            $.each(data, function () {
                                opt.append($(""<option />"").val(this.BusinessKey).text(this.LocationDescription));
                            });

                        if ($('#cboLocation option').length == 2) {
                            $('#cboLocation').prop('selectedIndex', 1);
                            $('#cboLocation').selectpicker('refresh');
                        } else {

                            $(""#cboLocation"").val($('#cboLocation option:first').val());
                            $('#cboLocation').selectpicker('refresh');
                        }

                         fnLoadSpecialty();

                    },

                    error: function (xhr, ajaxOptions, thrownError) {
                        alert('Failed to retrieve Doctor Location.');
                    }
                });


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
