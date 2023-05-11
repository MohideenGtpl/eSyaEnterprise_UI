﻿
$(document).ready(function () {
    fnGridLoadRoomType();
});
var actiontype = "";
function fnGridLoadRoomType() {

    $("#jqgRoomType").GridUnload();

    $("#jqgRoomType").jqGrid({
        url: getBaseURL() + '/RoomType/GetAllRoomTypes',
        datatype: 'json',
        mtype: 'POST',
        contentType: 'application/json; charset=utf-8',
        ajaxGridOptions: { contentType: 'application/json; charset=utf-8' },
        colNames: [localization.RoomTypeId, localization.Description, localization.BedType, localization.SqFeet,  localization.MaxOccupancy, localization.SharingStatus, localization.Active, localization.Actions],
        colModel: [
            { name: "RoomTypeId", width: 50, align: 'left', editable: true, editoptions: { maxlength: 10 }, resizable: false, hidden: true },
            { name: "RoomTypeDesc", width: 180, align: 'left', editable: true, editoptions: { maxlength: 150 }, resizable: false },
            { name: "BedType", editable: true, align: 'left', width: 50, edittype: "select", resizable: false, formatter: 'select', editoptions: { value: "T: Twin Bed;S: Single Bed" } },
            { name: "SqFeet", width: 50, align: 'left', editable: true, editoptions: { maxlength: 15 }, resizable: false, hidden: true },
            { name: "MaxOccupancy", width: 50, align: 'left', editable: true, editoptions: { maxlength: 10 }, resizable: false, hidden: false },
            { name: "SharingStatus", width: 35, editable: true, align: 'center', edittype: "checkbox", formatter: 'checkbox', editoptions: { value: "true:false" } },
            { name: "ActiveStatus", width: 35, editable: true, align: 'center', edittype: "checkbox", formatter: 'checkbox', editoptions: { value: "true:false" } },
            {
                name: 'edit', search: false, align: 'left', width: 88, sortable: false, resizable: false,
                formatter: function (cellValue, options, rowdata, action) {
                    return '<button class="btn-xs ui-button ui-widget ui-corner-all btn-jqgrid" title="Edit" id="jqgEdit" onclick="return fnEditRoomType(event,\'edit\');"><i class="fas fa-pen"></i> ' + localization.Edit + '</button>' +
                        '<button class="btn-xs ui-button ui-widget ui-corner-all btn-jqgrid" title="View" id="jqgView" onclick="return fnEditRoomType(event,\'view\');"><i class="far fa-eye"></i> ' + localization.View + '</button>'  +
                        '<button class="btn-xs ui-button ui-widget ui-corner-all btn-jqgrid" title="Delete" id="jqgDelete" onclick="return fnEditRoomType(event,\'delete\');"><i class="fas fa-trash"></i> ' + localization.Delete +'</button >'
                }
            },
        ],

        pager: "#jqpRoomType",
        rowNum: 10,
        rowList: [10, 20, 50, 100],
        rownumWidth: '55',
        loadonce: true,
        viewrecords: true,
        gridview: true,
        rownumbers: true,
        height: 'auto',
        scroll: false,
        width: 'auto',
        autowidth: true,
        shrinkToFit: true,
        forceFit: true,
        loadComplete: function (data) {
            SetGridControlByAction();
        },

    }).jqGrid('navGrid', '#jqpRoomType', { add: false, edit: false, search: false, del: false, refresh: false, refreshtext: 'Reload' }).jqGrid('navButtonAdd', '#jqpRoomType', {
        caption: '<span class="fa fa-sync"></span> Refresh', buttonicon: "none", id: "custRefresh", position: "first", onClickButton: fnGridRefreshRoomType
        }).jqGrid('navButtonAdd', '#jqpRoomType', {
            caption: '<span class="fa fa-plus" data-toggle="modal"></span> Add', buttonicon: 'none', id: 'jqgAdd', position: 'first', onClickButton: fnAddRoomType
    });

    $(window).on("resize", function () {
        var $grid = $("#jqgRoomType"),
            newWidth = $grid.closest(".RoomTypecontainer").parent().width();
        $grid.jqGrid("setGridWidth", newWidth, true);
    });
    fnAddGridSerialNoHeading();
}

function fnAddRoomType() {
    _isInsert = true;
    fnClearFields(); 
    $('#PopupRoomType').modal('show');
    $("#chkActiveStatus").parent().addClass("is-checked");
    $("#chkSharingStatus").parent().removeClass("is-checked");
    $('#PopupRoomType').find('.modal-title').text(localization.AddRoomType);
    $("#btnSaveRoomType").html('<i class="fa fa-save"></i>' + localization.Save);
    $("#chkActiveStatus").prop('disabled', true);
    $("#btnSaveRoomType").show();
    $("#btndeActiveRoomType").hide();
    $('#txtRoomTypeId').val('');
}

function fnEditRoomType(e, actiontype) {
    var rowid = $(e.target).parents("tr.jqgrow").attr('id');
    var rowData = $('#jqgRoomType').jqGrid('getRowData', rowid);

    $('#PopupRoomType').modal('show');
    $('#txtRoomTypeId').val(rowData.RoomTypeId);
    $('#txtRoomTypedesc').val(rowData.RoomTypeDesc);
    $('#cboBedType').val(rowData.BedType);
    $('#cboBedType').selectpicker('refresh');
    $('#txtSqFeet').val(rowData.SqFeet);
    $('#txtMaxOccupancy').val(rowData.MaxOccupancy);
    if (rowData.SharingStatus == 'true') {
        $("#chkSharingStatus").parent().addClass("is-checked");
    }
    else {
        $("#chkSharingStatus").parent().removeClass("is-checked");
    }
    if (rowData.ActiveStatus == 'true') {
        $("#chkActiveStatus").parent().addClass("is-checked");
    }
    else {
        $("#chkActiveStatus").parent().removeClass("is-checked");
    }
    $("#btnSaveRoomType").attr("disabled", false);

    _isInsert = false;

    if (actiontype.trim() == "edit") {
        $('#PopupRoomType').find('.modal-title').text(localization.UpdateRoomType);
        $("#btnSaveRoomType").html('<i class="fa fa-sync"></i>' + localization.Update);
        $("#btndeActiveRoomType").hide();
        $("#chkActiveStatus").prop('disabled', true);
        $("#chkSharingStatus").prop('disabled', false);
        $("#btnSaveRoomType").attr("disabled", false);
    }

    if (actiontype.trim() == "view") {
        $('#PopupRoomType').find('.modal-title').text(localization.ViewRoomType);
        $("#btnSaveRoomType").attr("disabled", false);
        $("input,textarea").attr('readonly', true);
        $("select").next().attr('disabled', true);
        $("#btnSaveRoomType").hide();
        $("#btndeActiveRoomType").hide();
        $("#chkActiveStatus").prop('disabled', true);
        $("#chkSharingStatus").prop('disabled', true);
        $("#PopupRoomType").on('hidden.bs.modal', function () {
            $("#btnSaveRoomType").show();
            $("input,textarea").attr('readonly', false);
            $("select").next().attr('disabled', false);
        });
    }
    if (actiontype.trim() == "delete") {
        $('#PopupRoomType').find('.modal-title').text("Activate/De Activate Room Type");
        $("#btnSaveRoomType").attr("disabled", false);
        $("input,textarea").attr('readonly', true);
        $("select").next().attr('disabled', true);
        $("#btnSaveRoomType").hide();

        if (rowData.ActiveStatus == 'true') {
            $("#btndeActiveRoomType").html(localization.DActivate);
        }
        else {
            $("#btndeActiveRoomType").html(localization.Activate);
        }

        $("#btndeActiveRoomType").show();
        $("#chkActiveStatus").prop('disabled', true);
        $("#chkSharingStatus").prop('disabled', true);
        $("#PopupRoomType").on('hidden.bs.modal', function () {
            $("#btnSaveRoomType").show();
            $("input,textarea").attr('readonly', false);
            $("select").next().attr('disabled', false);
        });
    }
}

var _isInsert = true;
function fnSaveRoomType() {
   
    if (IsStringNullorEmpty($("#txtRoomTypedesc").val())) {
        toastr.warning("Please Enter Room Type Description");
        return;
    }
    if (IsStringNullorEmpty($("#txtMaxOccupancy").val())) {
        toastr.warning("Please Enter Max Occupancy");
        return;
    }
    rm_type = {
        RoomTypeId: $("#txtRoomTypeId").val() === '' ? 0 : $("#txtRoomTypeId").val(),
        RoomTypeDesc: $("#txtRoomTypedesc").val(),
        BedType: $("#cboBedType").val(),
        SqFeet: $("#txtSqFeet").val(),
        MaxOccupancy: $("#txtMaxOccupancy").val(),
        SharingStatus: $("#chkSharingStatus").parent().hasClass("is-checked"),
        ActiveStatus: $("#chkActiveStatus").parent().hasClass("is-checked")
    };

    $("#btnSaveRoomType").attr("disabled", true);

    $.ajax({
        url: getBaseURL() + '/RoomType/InsertOrUpdateRoomType',
        type: 'POST',
        datatype: 'json',
        data: { isInsert: _isInsert, obj: rm_type },
        success: function (response) {
            if (response.Status) {
                toastr.success(response.Message);
                $("#btnSaveRoomType").html('<i class="fa fa-spinner fa-spin"></i> wait');
                $("#PopupRoomType").modal('hide');
                fnClearFields();
                fnGridRefreshRoomType();
            }
            else {
                toastr.error(response.Message);
                $("#btnSaveRoomType").attr("disabled", false);
            }
        },
        error: function (error) {
            toastr.error(error.statusText);
            $("#btnSaveRoomType").attr("disabled", false);
        }
    });
}

function fnGridRefreshRoomType() {
    $("#jqgRoomType").setGridParam({ datatype: 'json', page: 1 }).trigger('reloadGrid');
}

function fnClearFields() {
    $("#txtRoomTypeId").val('');
    $("#txtRoomTypedesc").val('');
    $('#cboBedType').val("T");
    $('#cboBedType').selectpicker('refresh');
    $("#txtSqFeet").val('');
    $("#txtMaxOccupancy").val('');
    $('#chkSharingStatus').prop('disabled', false);
    $("#chkActiveStatus").prop('disabled', false);
    $("#btnSaveRoomType").attr("disabled", false);
    $("#btndeActiveRoomType").attr("disabled", false);
}

$("#btnCancelRoomType").click(function () {
    $("#jqgRoomType").jqGrid('resetSelection');
    $('#PopupRoomType').modal('hide');
    fnClearFields();
});

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

function fnDeleteRoomType() {

    var a_status;
    //Activate or De Activate the status
    if ($("#chkActiveStatus").parent().hasClass("is-checked") === true) {
        a_status = false
    }
    else {
        a_status = true;
    }
    $("#btndeActiveRoomType").attr("disabled", true);
    $.ajax({
        url: getBaseURL() + '/RoomType/ActiveOrDeActiveRoomType?status=' + a_status + '&roomTypeId=' + $("#txtRoomTypeId").val(),
        type: 'POST',
        success: function (response) {
            if (response.Status) {
                toastr.success(response.Message);
                $("#btndeActiveRoomType").html('<i class="fa fa-spinner fa-spin"></i> wait');
                $("#PopupRoomType").modal('hide');
                fnClearFields();
                fnGridRefreshRoomType();
                $("#btndeActiveRoomType").attr("disabled", false);
            }
            else {
                toastr.error(response.Message);
                $("#btndeActiveRoomType").attr("disabled", false);
                $("#btndeActiveRoomType").html('De Activate');
            }
        },
        error: function (error) {
            toastr.error(error.statusText);
            $("#btndeActiveRoomType").attr("disabled", false);
            $("#btndeActiveRoomType").html('De Activate');
        }
    });
}