﻿var Isadd = 0;
var Postedimg;
var postedImgName = 0;
var imgName;
var imgPath;
var imgUrl;
var actiontype = "";

$(document).ready(function () {
    fnGridLoadCountryCode();
   
});

function fnGridLoadCountryCode() {
    $("#jqgCountryCode").jqGrid('GridUnload');
    $("#jqgCountryCode").jqGrid({
        url: getBaseURL() + '/Country/GetAllCountryCodes',
        mtype: 'Post',
        datatype: 'json',

        ajaxGridOptions: { contentType: 'application/json; charset=utf-8' },
        jsonReader: { repeatitems: false, root: "rows", page: "page", total: "total", records: "records" },
        colNames: [localization.ISDCode, localization.CountryCode, localization.CountryName, "", localization.CurrencyName, "", localization.Flag, "", "", "", "", "", "", "", "", localization.Active, localization.Actions],
        colModel: [
            { name: "Isdcode", width: 40, editable: true, align: 'left', hidden: false },
            { name: "CountryCode", width: 50, editable: false, hidden: false, align: 'left', resizable: true },
            { name: "CountryName", width: 70, editable: false, hidden: false, align: 'left', resizable: true },
            { name: "CurrencyCode", width: 70, editable: false, hidden: true, align: 'left', resizable: true },
            { name: "CurrencyName", width: 200, editable: false, hidden: false, align: 'left', resizable: true },
            { name: "ShowCountryFlag", width: 70, editable: true, edittype: 'image', formatter: getImage, hidden: true, editrules: { edithidden: true }, sortable: false },
            {
                name: 'CountryFlag',
                index: 'Isdcode',
                sortable: false,
                editable: true,
                edittype: 'file',
                hidden: false,
                editoptions: {
                    enctype: "multipart/form-data",

                    dataEvents: [{
                        type: 'change',
                        fn: function (e) {
                            var Filename = $('#ShowCountryFlag').attr('src').split('/').pop();
                            imgName = Filename;
                            var input = document.getElementById("CountryFlag");
                            var fReader = new FileReader();
                            fReader.readAsDataURL(input.files[0]);
                            fReader.onloadend = function (event) {
                                var img = document.getElementById("ShowCountryFlag");
                                img.src = event.target.result;
                            }
                        }
                    }]
                },
                width: 25,
                align: 'center',
                formatter: jgImageFormatter,
                search: false
            },

            { name: "MobileNumberPattern", width: 70, editable: false, hidden: true, align: 'left', resizable: true },
            { name: "Uidlabel", width: 70, editable: false, hidden: true, align: 'left', resizable: true },
            { name: "Uidpattern", width: 70, editable: false, hidden: true, align: 'left', resizable: true },
            { name: "Nationality", width: 70, editable: false, hidden: true, align: 'left', resizable: true },
            { name: "IsPoboxApplicable", editable: true, hidden: true, width: 45, align: 'center', resizable: false, edittype: "checkbox", formatter: 'checkbox', editoptions: { value: "true:false" } },
            { name: "PoboxPattern", width: 70, editable: false, hidden: true, align: 'left', resizable: true },
            { name: "IsPinapplicable", editable: true, hidden: true, width: 45, align: 'center', resizable: false, edittype: "checkbox", formatter: 'checkbox', editoptions: { value: "true:false" } },
            { name: "PincodePattern", width: 70, editable: false, hidden: true, align: 'left', resizable: true },
            { name: "ActiveStatus", width: 35, editable: false, align: 'center', edittype: "checkbox", formatter: 'checkbox', editoptions: { value: "true:false" }, formatoptions: { disabled: true } },
            {
                name: 'edit', search: false, align: 'left', width: 120, sortable: false, resizable: false,
                formatter: function (cellValue, options, rowdata, action) {
                    return '<button class="btn-xs ui-button ui-widget ui-corner-all btn-jqgrid" title="Edit" id="jqgEdit" onclick="return fnEditCountryCode(event,\'edit\')"><i class="fas fa-pen"></i>' +localization.Edit+'</button>' +
                        '<button class="btn-xs ui-button ui-widget ui-corner-all btn-jqgrid" title="View" id="jqgView" onclick="return fnEditCountryCode(event,\'view\')"><i class="far fa-file-alt"></i>' + localization.View +'</button>' +
                        '<button class="btn-xs ui-button ui-widget ui-corner-all btn-jqgrid" title = "Delete" id="jqgDelete" onclick = "return fnEditCountryCode(event,\'delete\')" > <i class="fas fa-trash"></i>' + localization.Delete +'</button >'

                }
            },
        ],
        rowNum: 10,
        rowList: [10, 20, 50, 100],
        rownumWidth:'55',
        loadonce: true,
        pager: "#jqpCountryCode",
        viewrecords: true,
        gridview: true,
        rownumbers: true,
        height: 'auto',
        align: "left",
        width: 'auto',
        autowidth: true,
        shrinkToFit: true,
        forceFit: true,
        scrollOffset: 0, caption:'Country Code',
        loadComplete: function (data) {
            SetGridControlByAction(); fnJqgridSmallScreen("jqgCountryCode");
        },
    }).jqGrid('navGrid', '#jqpCountryCode', { add: false, edit: false, search: false, del: false, refresh: false }).jqGrid('navButtonAdd', '#jqpCountryCode', {
        caption: '<span class="fa fa-sync"></span> Refresh', buttonicon: "none", id: "custRefresh", position: "first", onClickButton: fnGridRefreshCountryCode
    }).jqGrid('navButtonAdd', '#jqpCountryCode', {
        caption: '<span class="fa fa-plus" data-toggle="modal"></span> Add', buttonicon: 'none', id: 'jqgAdd', position: 'first', onClickButton: fnAddCountryCode
        });
    fnAddGridSerialNoHeading();
}

function jgImageFormatter(cellValue, options, rowObject) {
    var imageHtml = "<img id='countryflagimg' src='" + cellValue + "' originalValue='" + cellValue + "' />"
    return imageHtml;
}


function getImage(cellValue, options, rowObject) {
    var imageHtml = "<img id='img" + options.rowId + "' src='" + rowObject.CountryFlag + "' originalValue='" + rowObject.CountryFlag + "'  />"
    return imageHtml;
}

function fnAddCountryCode() {
    $('#divstatutorycode').hide();
    fnClearFields();
    Isadd = 1;
    $('#PopupCountryCode').modal('show');
    $('#PopupCountryCode').modal({ backdrop: 'static', keyboard: false });
    $('#PopupCountryCode').find('.modal-title').text(localization.AddCountry);
    $("#chkActiveStatus").parent().addClass("is-checked");
    $("#chkActiveStatus").prop('disabled', true);
    $("#btnSaveCountryCode").html('<i class="fa fa-save"></i>' + localization.Save);
    $("#btnCancelCountryCode").html('<i class="fa fa-times"></i>' + localization.Cancel);
    $("#btnSaveCountryCode").show();
    $("#btnDeactivateCountryCode").hide();
}

function fnEditCountryCode(e,actiontype) {

    var rowid = $(e.target).parents("tr.jqgrow").attr('id');
    var rowData = $('#jqgCountryCode').jqGrid('getRowData', rowid);
    Isadd = 0;
    $('#txtIsdcode').val(rowData.Isdcode);
    $("#txtIsdcode").attr('disabled', true);
    $('#txtCountrycode').val(rowData.CountryCode);
    imgUrl = $('#img' + rowid).attr('src');
    var IMGurl = imgUrl;
    var IMGname = IMGurl.split('/').pop().split('?')[0].split('#')[0];

    $("#btnSaveCountryCode").html('<i class="fa fa-sync"></i>' + localization.Update);
    $("#btnCancelCountryCode").html('<i class="fa fa-times"></i>'+localization.Cancel);
    $('#cboflagImage').val(IMGname).trigger('change');
    $('#cboflagImage').selectpicker('refresh');
    $('#txtCountryName').val(rowData.CountryName);
    $('#cboCurrencycode').val(rowData.CurrencyCode);
    $('#cboCurrencycode').selectpicker('refresh');
    $('#txtMobileNumberPattern').val(rowData.MobileNumberPattern);
    $('#txtUIDlabel').val(rowData.Uidlabel);
    $('#txtUIDPattern').val(rowData.Uidpattern);
    $('#txtNationality').val(rowData.Nationality);
    if (rowData.ActiveStatus == 'true') {
        $("#chkActiveStatus").parent().addClass("is-checked");
    }
    else {
        $("#chkActiveStatus").parent().removeClass("is-checked");
    }
    if (rowData.IsPoboxApplicable == 'true') {
        $("#chkIsPOBoxAppllicable").parent().addClass("is-checked");
    }
    else {
        $("#chkIsPOBoxAppllicable").parent().removeClass("is-checked");
    }

    $('#txtPOBoxPattern').val(rowData.PoboxPattern);
    if (rowData.IsPinapplicable == 'true') {
        $("#chkIsPinApplicable").parent().addClass("is-checked");
    }
    else {
        $("#chkIsPinApplicable").parent().removeClass("is-checked");
    }
    $('#txtPincodePattern').val(rowData.PincodePattern);
    $('#PopupCountryCode').modal('show');
    $("#btnSaveCountryCode").attr('disabled', false);
    $('#divstatutorycode').show();
    if (actiontype.trim() == "edit") {
        $("#chkActiveStatus").prop('disabled', true);
        $('#PopupCountryCode').find('.modal-title').text(localization.UpdateCountry);
        $("#btnSaveCountryCode").html(localization.Update);
        $("#btnDeactivateCountryCode").hide();
        $("#btnSaveCountryCode").show();
    }
    if (actiontype.trim() == "view") {
        $('#PopupCountryCode').find('.modal-title').text(localization.ViewCountry);
        $('#divstatutorycode').show();
        $("#chkActiveStatus").prop('disabled', true);
        $("input,textarea").attr('readonly', true);
        $("select").next().attr('disabled', true);
        $("input[id*=chk]").attr('disabled', true);
        $("#btnSaveCountryCode,#btnDeactivateCountryCode").hide();
        $("#PopupCountryCode").on('hidden.bs.modal', function () {
            $("#btnSaveCountryCode").show();
            $("input,textarea").attr('readonly', false);
            $("select").next().attr('disabled', false);
            $("input[id*=chk]").attr('disabled', false);

        })
    }

    if (actiontype.trim() == "delete") {
        $('#PopupCountryCode').find('.modal-title').text("Active/De Active Country Codes");
        if (rowData.ActiveStatus == 'true') {
            $("#btnDeactivateCountryCode").html(localization.DeActivate);
        }
        else {
            $("#btnDeactivateCountryCode").html(localization.Activate);
        }
        $("#btnDeactivateCountryCode").show();
        $('#divstatutorycode').show();
        $("#chkActiveStatus").prop('disabled', true);
        $("input,textarea").attr('readonly', true);
        $("select").next().attr('disabled', true);
        $("input[id*=chk]").attr('disabled', true);
        $("#btnSaveCountryCode").hide();
        $("#PopupCountryCode").on('hidden.bs.modal', function () {
            $("#btnSaveCountryCode").show();
            $("input,textarea").attr('readonly', false);
            $("select").next().attr('disabled', false);
            $("input[id*=chk]").attr('disabled', false);

        })
    }
}

function fnSaveCountryCode() {

    if (validateCountryCode() === false) {
        return;
    }
    if (Isadd === 1) {
        var country = {
            Isdcode: $('#txtIsdcode').val(),
            CountryCode: $("#txtCountrycode").val(),
            CountryName: $("#txtCountryName").val(),
            imgName: $("#cboflagImage").val(),
            CurrencyCode: $("#cboCurrencycode").val(),
            MobileNumberPattern: $("#txtMobileNumberPattern").val().trim(),
            Uidlabel: $("#txtUIDlabel").val(),
            Uidpattern: $("#txtUIDPattern").val(),
            Nationality: $("#txtNationality").val(),
            IsPoboxApplicable: $("#chkIsPinApplicable").parent().hasClass("is-checked"),
            PoboxPattern: $("#txtPOBoxPattern").val(),
            IsPinapplicable: $("#chkIsPOBoxAppllicable").parent().hasClass("is-checked"),
            PincodePattern: $("#txtPincodePattern").val(),
            ActiveStatus: $("#chkActiveStatus").parent().hasClass("is-checked"),
            Isadd: 1
        };
    }

    if (Isadd === 0) {
        var country = {
            Isdcode: $('#txtIsdcode').val(),
            CountryCode: $("#txtCountrycode").val(),
            CountryName: $("#txtCountryName").val(),
            imgName: $("#cboflagImage").val(),
            CurrencyCode: $("#cboCurrencycode").val(),
            MobileNumberPattern: $("#txtMobileNumberPattern").val().trim(),
            Uidlabel: $("#txtUIDlabel").val(),
            Uidpattern: $("#txtUIDPattern").val(),
            Nationality: $("#txtNationality").val(),
            IsPoboxApplicable: $("#chkIsPinApplicable").parent().hasClass("is-checked"),
            PoboxPattern: $("#txtPOBoxPattern").val(),
            IsPinapplicable: $("#chkIsPOBoxAppllicable").parent().hasClass("is-checked"),
            PincodePattern: $("#txtPincodePattern").val(),
            ActiveStatus: $("#chkActiveStatus").parent().hasClass("is-checked"),
            Isadd: 0
        };
    }
    $("#btnSaveCountryCode").attr('disabled', true);
    $.ajax({
        url: getBaseURL() + '/Country/InsertOrUpdateCountryCodes',
        type: 'POST',
        datatype: 'json',
        data: { country },
        success: function (response) {
            if (response.Status === true) {
                toastr.success(response.Message);
           $("#btnSaveCountryCode").html('<i class="fa fa-spinner fa-spin"></i> wait');
           $("#btnSaveCountryCode").attr('disabled', false);
           $('#PopupCountryCode').modal('hide');
                fnClearFields();
                fnGridLoadCountryCode();
                return true;
            }
            else {
                toastr.error(response.Message);
 $("#btnSaveCountryCode").attr('disabled', false);
                return false;
           
            }

        }
    });
}

function validateCountryCode() {

    if (IsStringNullorEmpty($("#txtIsdcode").val())) {
        toastr.warning("Please Enter ISD Code");
        return false;
    }
    if (IsStringNullorEmpty($("#txtCountrycode").val())) {
        toastr.warning("Please Enter Country Code");
        return false;
    }
    
    if ($("#cboflagImage").val() === '0' || $("#cboflagImage").val() === null) {
        toastr.warning("Please Select Country Flag");
        return false;
    }
    if (IsStringNullorEmpty($("#txtCountryName").val())) {
        toastr.warning("Please Enter Country Name");
        return false;
    }
   
    if ($("#cboCurrencycode").val() === "0" || $("#cboCurrencycode").val() === '0') {
        toastr.warning("Please Select Currency");
        return false;
    }

}

function fnGridRefreshCountryCode() {
   $("#jqgCountryCode").setGridParam({ datatype: 'json', page: 1 }).trigger('reloadGrid');
}

function fnViewCountryCode(e) {
    var rowid = $(e.target).parents("tr.jqgrow").attr('id');
    var rowData = $('#jqgCountryCode').jqGrid('getRowData', rowid);
    Isadd = 0;
    $('#txtIsdcode').val(rowData.Isdcode);
    $("#txtIsdcode").attr('disabled', true);
    $('#txtCountrycode').val(rowData.CountryCode);
    imgUrl = $('#img' + rowid).attr('src');
    var IMGurl = imgUrl;
    var IMGname = IMGurl.split('/').pop().split('?')[0].split('#')[0];


    $('#cboflagImage').val(IMGname).trigger('change');
    $('#cboflagImage').selectpicker('refresh');
    $('#txtCountryName').val(rowData.CountryName);
    $('#cboCurrencycode').val(rowData.CurrencyCode);
    $('#cboCurrencycode').selectpicker('refresh');
    $('#txtMobileNumberPattern').val(rowData.MobileNumberPattern);
    $('#txtUIDlabel').val(rowData.Uidlabel);
    $('#txtUIDPattern').val(rowData.Uidpattern);
    $('#txtNationality').val(rowData.Nationality);
    $('#cboActiveStatus').val(rowData.ActiveStatus);
    $('#cboActiveStatus').selectpicker('refresh');
    if (rowData.IsPoboxApplicable == 'true') {
        $("#chkIsPOBoxAppllicable").parent().addClass("is-checked");
    }
    else {
        $("#chkIsPOBoxAppllicable").parent().removeClass("is-checked");
    }

    $('#txtPOBoxPattern').val(rowData.PoboxPattern);
    if (rowData.IsPinapplicable == 'true') {
        $("#chkIsPinApplicable").parent().addClass("is-checked");
    }
    else {
        $("#chkIsPinApplicable").parent().removeClass("is-checked");
    }
    $('#txtPincodePattern').val(rowData.PincodePattern);
    $('#PopupCountryCode').modal('show');
    
}

function fnClearFields() {
   
    $("#txtIsdcode").val('');
    $("#txtIsdcode").attr('disabled', false);
    $("#txtCountrycode").val('');
    $("#cboflagImage").val('0').trigger('change');
    $('#cboflagImage').selectpicker('refresh');
    $("#txtCountryName").val('');
    $("#cboCurrencycode").val('0');
    $("#cboCurrencycode").selectpicker('refresh');
    $("#txtMobileNumberPattern").val('');
    $("#txtUIDlabel").val('');
    $("#txtUIDPattern").val('');
    $("#txtNationality").val('');
    $("#chkActiveStatus").prop('disabled', false);
    $("#chkIsPOBoxAppllicable").parent().removeClass("is-checked");
    $("#txtPOBoxPattern").val('');
    $("#chkIsPinApplicable").parent().removeClass("is-checked");
    $("#txtPincodePattern").val('');
    $("#btnSaveCountryCode").attr('disabled', false);
}
function fnDeleteCountryCodes() {

    var a_status;
    //Activate or De Activate the status
    if ($("#chkActiveStatus").parent().hasClass("is-checked") === true) {
        a_status = false
    }
    else {
        a_status = true;
    }
    $("#btnDeactivateCountryCode").attr("disabled", true);
    $.ajax({
        url: getBaseURL() + '/Country/ActiveOrDeActiveCountryCode?status=' + a_status + '&Isd_code=' + $('#txtIsdcode').val(),
        type: 'POST',
        success: function (response) {
            if (response.Status) {
                toastr.success(response.Message);
                $("#btnDeactivateCountryCode").html('<i class="fa fa-spinner fa-spin"></i> wait');
                $('#PopupCountryCode').modal('hide');
                fnClearFields();
                fnGridRefreshCountryCode();
                $("#btnDeactivateCountryCode").attr("disabled", false);
            }
            else {
                toastr.error(response.Message);
                $("#btnDeactivateCountryCode").attr("disabled", false);
                $("#btnDeactivateCountryCode").html(localization.DeActivate);
            }
        },
        error: function (error) {
            toastr.error(error.statusText);
            $("#btnDeactivateCountryCode").attr("disabled", false);
            $("#btnDeactivateCountryCode").html(localization.DeActivate);
        }
    });
}
function SetGridControlByAction() {
    $('#jqgAdd').removeClass('ui-state-disabled');
    var btn_editEnable = document.querySelectorAll('#jqgEdit');
    var btn_viewEnable = document.querySelectorAll('#jqgView');
    var btn_deleteEnable = document.querySelectorAll('#jqgDelete');
    for (var i = 0; i < btn_editEnable.length; i++) {
        btn_editEnable[i].disabled = false;
    }
    for (var j = 0; j < btn_viewEnable.length; j++) {
        btn_viewEnable[j].disabled = false;
    }
    for (var k = 0; k < btn_deleteEnable.length; k++) {
        btn_deleteEnable[k].disabled = false;
    }


    if (_userFormRole.IsInsert === false) {
        $('#jqgAdd').addClass('ui-state-disabled');
    }
    if (_userFormRole.IsEdit === false) {
        var btn_editDisable = document.querySelectorAll('#jqgEdit');
        for (var i = 0; i < btn_editDisable.length; i++) {
            btn_editDisable[i].disabled = true;
            btn_editDisable[i].className = "ui-state-disabled";
        }
    }
    if (_userFormRole.IsView === false) {
        var btn_viewDisable = document.querySelectorAll('#jqgView');
        for (var j = 0; j < btn_viewDisable.length; j++) {
            btn_viewDisable[j].disabled = true;
            btn_viewDisable[j].className = "ui-state-disabled";
        }
    }

    if (_userFormRole.IsDelete === false) {
        var btn_deleteDisable = document.querySelectorAll('#jqgDelete');
        for (var k = 0; k < btn_deleteDisable.length; k++) {
            btn_deleteDisable[k].disabled = true;
            btn_deleteDisable[k].className = "ui-state-disabled";
        }
    }
}







