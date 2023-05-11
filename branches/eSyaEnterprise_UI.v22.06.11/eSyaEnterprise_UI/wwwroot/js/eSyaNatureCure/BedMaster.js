
$(document).ready(function () {
    fnGridLoadBedMaster();
});
var actiontype = "";
function fnGridLoadBedMaster() {
    
    var roomtype = $("#cboRoomTypeId").val();
    $("#jqgBedMaster").GridUnload();

    $("#jqgBedMaster").jqGrid({
        url: getBaseURL() + '/BedMaster/GetAllBedMastersbyRoomType?roomtype=' + roomtype,
        datatype: 'json',
        mtype: 'POST',
        contentType: 'application/json; charset=utf-8',
        ajaxGridOptions: { contentType: 'application/json; charset=utf-8' },
        colNames: [localization.RoomTypeId, localization.RoomTypeDesc, localization.RoomNumber, localization.BedNumber, localization.Gender, localization.ReservedStatus, localization.CheckedIn, localization.CheckedOut, localization.ReadyForOccupancy, localization.Active, localization.Actions],
        colModel: [
            { name: "RoomTypeId", width: 10, align: 'left', editable: true, editoptions: { maxlength: 10 }, resizable: false, hidden: true },
            { name: "RoomTypeDesc", width: 100, align: 'left', editable: true, editoptions: { maxlength: 15 }, resizable: false },
            { name: "RoomNumber", width: 40, align: 'left', editable: true, editoptions: { maxlength: 15 }, resizable: false },
            { name: "BedNumber", width: 40, align: 'left', editable: true, editoptions: { maxlength: 15 }, resizable: false },
            { name: "Gender", editable: true, align: 'left', width: 40, edittype: "select", resizable: false, formatter: 'select', editoptions: { value: "M: Male;F: Female;B: Both" } },
            { name: "ReservedStatus", width: 35, editable: true, align: 'center', edittype: "checkbox", formatter: 'checkbox', editoptions: { value: "true:false" } },
            { name: "CheckedIn", width: 35, editable: true, align: 'center', edittype: "checkbox", formatter: 'checkbox', editoptions: { value: "true:false" } },
            { name: "CheckedOut", width: 35, editable: true, align: 'center', edittype: "checkbox", formatter: 'checkbox', editoptions: { value: "true:false" } },
            { name: "ReadyForOccupancy", width: 50, editable: true, align: 'center', edittype: "checkbox", formatter: 'checkbox', editoptions: { value: "true:false" } },
            { name: "ActiveStatus", width: 35, editable: true, align: 'center', edittype: "checkbox", formatter: 'checkbox', editoptions: { value: "true:false" } },
            {
                name: 'edit', search: false, align: 'left', width: 100, sortable: false, resizable: false,
                formatter: function (cellValue, options, rowdata, action) {
                    return '<button class="btn-xs ui-button ui-widget ui-corner-all btn-jqgrid" title="Edit" id="jqgEdit" onclick="return fnEditBedMaster(event,\'edit\');"><i class="fas fa-pen"></i> ' + localization.Edit + '</button>' +
                        '<button class="btn-xs ui-button ui-widget ui-corner-all btn-jqgrid" title="View" id="jqgView" onclick="return fnEditBedMaster(event,\'view\');"><i class="far fa-eye"></i> ' + localization.View + '</button>' +
                        '<button class="btn-xs ui-button ui-widget ui-corner-all btn-jqgrid" title="Delete" id="jqgDelete" onclick="return fnEditBedMaster(event,\'delete\');"><i class="fas fa-trash"></i> ' + localization.Delete + '</button >'
                }
            },
        ],

        pager: "#jqpBedMaster",
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

    }).jqGrid('navGrid', '#jqpBedMaster', { add: false, edit: false, search: false, del: false, refresh: false, refreshtext: 'Reload' }).jqGrid('navButtonAdd', '#jqpBedMaster', {
        caption: '<span class="fa fa-sync"></span> Refresh', buttonicon: "none", id: "custRefresh", position: "first", onClickButton: fnGridRefreshBedMaster
        }).jqGrid('navButtonAdd', '#jqpBedMaster', {
        caption: '<span class="fa fa-plus" data-toggle="modal"></span> Add', buttonicon: 'none', id: 'jqgAdd', position: 'first', onClickButton: fnAddBedMaster
    });

    $(window).on("resize", function () {
        var $grid = $("#jqgBedMaster"),
            newWidth = $grid.closest(".BedMastercontainer").parent().width();
        $grid.jqGrid("setGridWidth", newWidth, true);
    });
    fnAddGridSerialNoHeading();
}

function fnAddBedMaster() {

    fnClearFields();
    var id = $("#cboRoomTypeId").val();
    if (id === 0 || id === "0") {
        toastr.warning("Please select any Room Type to add");
        return;
    }
    else {
        _isInsert = true;
        fnClearFields();
        $('#PopupBedMaster').modal('show');
        $("#chkActiveStatus").parent().addClass("is-checked");
        $("#chkReservedStatus").parent().removeClass("is-checked");
        $("#chkCheckedIn").parent().removeClass("is-checked");
        $("#chkCheckedOut").parent().removeClass("is-checked");
        $("#chkReadyForOccupancy").parent().removeClass("is-checked");
        $('#PopupBedMaster').find('.modal-title').text(localization.AddBedMaster);
        $("#btnSaveBedMaster").html('<i class="fa fa-save"></i>' + localization.Save);
        $("#chkActiveStatus").prop('disabled', true);
        $("#btnSaveBedMaster").show();
        $("#btndeActiveBedMaster").hide();
        //$('#txtRoomTypeId').val('');
    }
    
}

function fnEditBedMaster(e, actiontype) {
    var rowid = $(e.target).parents("tr.jqgrow").attr('id');
    var rowData = $('#jqgBedMaster').jqGrid('getRowData', rowid);

    $('#cboRoomTypeId').val(rowData.RoomTypeId);
    $('#cboRoomTypeId').selectpicker('refresh');
    $('#PopupBedMaster').modal('show');
    $('#txtRoomNumber').val(rowData.RoomNumber);
    $('#txtRoomNumber').attr('readonly', true);
    $('#txtBedNumber').val(rowData.BedNumber);
    $('#txtBedNumber').attr('readonly', true);
    $('#cboGender').val(rowData.Gender);
    $('#cboGender').selectpicker('refresh');

    if (rowData.ReservedStatus == 'true') {
        $("#chkReservedStatus").parent().addClass("is-checked");
    }
    else {
        $("#chkReservedStatus").parent().removeClass("is-checked");
    }
    if (rowData.CheckedIn == 'true') {
        $("#chkCheckedIn").parent().addClass("is-checked");
    }
    else {
        $("#chkCheckedIn").parent().removeClass("is-checked");
    }
    if (rowData.CheckedOut == 'true') {
        $("#chkCheckedOut").parent().addClass("is-checked");
    }
    else {
        $("#chkCheckedOut").parent().removeClass("is-checked");
    }
    if (rowData.ReadyForOccupancy == 'true') {
        $("#chkReadyForOccupancy").parent().addClass("is-checked");
    }
    else {
        $("#chkReadyForOccupancy").parent().removeClass("is-checked");
    }

    if (rowData.ActiveStatus == 'true') {
        $("#chkActiveStatus").parent().addClass("is-checked");
    }
    else {
        $("#chkActiveStatus").parent().removeClass("is-checked");
    }
    $("#btnSaveBedMaster").attr("disabled", false);

    _isInsert = false;

    if (actiontype.trim() == "edit") {
        $('#PopupBedMaster').find('.modal-title').text(localization.UpdateBedMaster);
        $("#btnSaveBedMaster").html('<i class="fa fa-sync"></i>' + localization.Update);
        $("#btndeActiveBedMaster").hide();
        $("#chkActiveStatus").prop('disabled', true);
        $("#chkReservedStatus").prop('disabled', false);
        $("#chkCheckedIn").prop('disabled', false);
        $("#chkCheckedOut").prop('disabled', false);
        $("#chkReadyForOccupancy").prop('disabled', false);
        $("#btnSaveBedMaster").attr("disabled", false);
    }

    if (actiontype.trim() == "view") {
        $('#PopupBedMaster').find('.modal-title').text(localization.ViewBedMaster);
        $("#btnSaveBedMaster").attr("disabled", false);
        $("input,textarea").attr('readonly', true);
        $("select").next().attr('disabled', true);
        $("#btnSaveBedMaster").hide();
        $("#btndeActiveBedMaster").hide();
        $("#chkActiveStatus").prop('disabled', true);
        $("#chkReservedStatus").prop('disabled', true);
        $("#chkCheckedIn").prop('disabled', true);
        $("#chkCheckedOut").prop('disabled', true);
        $("#chkReadyForOccupancy").prop('disabled', true);

        $("#PopupBedMaster").on('hidden.bs.modal', function () {
            $("#btnSaveBedMaster").show();
            $("input,textarea").attr('readonly', false);
            $("select").next().attr('disabled', false);
        });
    }
    if (actiontype.trim() == "delete") {
        $('#PopupBedMaster').find('.modal-title').text("Activate/De Activate Bed Master");
        $("#btnSaveBedMaster").attr("disabled", false);
        $("input,textarea").attr('readonly', true);
        $("select").next().attr('disabled', true);
        $("#btnSaveBedMaster").hide();

        if (rowData.ActiveStatus == 'true') {
            $("#btndeActiveBedMaster").html(localization.DActivate);
        }
        else {
            $("#btndeActiveBedMaster").html(localization.Activate);
        }

        $("#btndeActiveBedMaster").show();
        $("#chkActiveStatus").prop('disabled', true);
        $("#chkReservedStatus").prop('disabled', true);
        $("#chkCheckedIn").prop('disabled', true);
        $("#chkCheckedOut").prop('disabled', true);
        $("#chkReadyForOccupancy").prop('disabled', true);
        $("#PopupBedMaster").on('hidden.bs.modal', function () {
            $("#btnSaveBedMaster").show();
            $("input,textarea").attr('readonly', false);
            $("select").next().attr('disabled', false);
        });
    }
}

var _isInsert = true;
function fnSaveBedMaster() {

    if (IsStringNullorEmpty($("#txtRoomNumber").val())) {
        toastr.warning("Please Enter Room Number");
        return;
    }
    if (IsStringNullorEmpty($("#txtBedNumber").val())) {
        toastr.warning("Please Enter Bed Number");
        return;
    }
    bed_master = {
        RoomTypeId: $("#cboRoomTypeId").val(),
        RoomNumber: $("#txtRoomNumber").val(),
        BedNumber: $("#txtBedNumber").val(),
        Gender: $("#cboGender").val(),
        ReservedStatus: $("#chkReservedStatus").parent().hasClass("is-checked"),
        CheckedIn: $("#chkCheckedIn").parent().hasClass("is-checked"),
        CheckedOut: $("#chkCheckedOut").parent().hasClass("is-checked"),
        ReadyForOccupancy: $("#chkReadyForOccupancy").parent().hasClass("is-checked"),
        ActiveStatus: $("#chkActiveStatus").parent().hasClass("is-checked")
    };

    $("#btnSaveBedMaster").attr("disabled", true);

    $.ajax({
        url: getBaseURL() + '/BedMaster/InsertOrUpdateBedMaster',
        type: 'POST',
        datatype: 'json',
        data: { isInsert: _isInsert, obj: bed_master },
        success: function (response) {
            if (response.Status) {
                toastr.success(response.Message);
                $("#btnSaveBedMaster").html('<i class="fa fa-spinner fa-spin"></i> wait');
                $("#PopupBedMaster").modal('hide');
                fnClearFields();
                fnGridRefreshBedMaster();
            }
            else {
                toastr.error(response.Message);
                $("#btnSaveBedMaster").attr("disabled", false);
            }
        },
        error: function (error) {
            toastr.error(error.statusText);
            $("#btnSaveBedMaster").attr("disabled", false);
        }
    });
}

function fnGridRefreshBedMaster() {
    $("#jqgBedMaster").setGridParam({ datatype: 'json', page: 1 }).trigger('reloadGrid');
}

function fnClearFields() {
   
    $("#txtRoomNumber").val('');
    $("#txtRoomNumber").attr('readonly', false);
    $('#txtBedNumber').val('');
    $('#txtBedNumber').attr('readonly', false);
    $('#cboGender').val('M').selectpicker('refresh');
    $('#chkReservedStatus').prop('disabled', false);
    $("#chkReservedStatus").parent().removeClass("is-checked");
    $('#chkCheckedIn').prop('disabled', false);
    $("#chkCheckedIn").parent().removeClass("is-checked");
    $('#chkCheckedOut').prop('disabled', false);
    $("#chkCheckedOut").parent().removeClass("is-checked");
    $('#chkReadyForOccupancy').prop('disabled', false);
    $("#chkReadyForOccupancy").parent().removeClass("is-checked");
    $("#chkActiveStatus").prop('disabled', true);
    $("#btnSaveBedMaster").attr("disabled", false);
    $("#btndeActiveBedMaster").attr("disabled", false);
}

$("#btnCancelBedMaster").click(function () {
    $("#jqgBedMaster").jqGrid('resetSelection');
    $('#PopupBedMaster').modal('hide');
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

function fnDeleteBedMaster() {

    var a_status;
    //Activate or De Activate the status
    if ($("#chkActiveStatus").parent().hasClass("is-checked") === true) {
        a_status = false
    }
    else {
        a_status = true;
    }

    bedmaster = {
        RoomTypeId: $("#cboRoomTypeId").val(),
        RoomNumber: $("#txtRoomNumber").val(),
        BedNumber: $("#txtBedNumber").val(),
        Gender: $("#cboGender").val(),
        ReservedStatus: $("#chkReservedStatus").parent().hasClass("is-checked"),
        CheckedIn: $("#chkCheckedIn").parent().hasClass("is-checked"),
        CheckedOut: $("#chkCheckedOut").parent().hasClass("is-checked"),
        ReadyForOccupancy: $("#chkReadyForOccupancy").parent().hasClass("is-checked"),
        ActiveStatus: $("#chkActiveStatus").parent().hasClass("is-checked"),
        Status:a_status
    };

    $("#btndeActiveBedMaster").attr("disabled", true);
    $.ajax({
        url: getBaseURL() + '/BedMaster/ActiveOrDeActiveBedMaster',
        type: 'POST',
        datatype: 'json',
        data: { objmaster: bedmaster },
        success: function (response) {
            if (response.Status) {
                toastr.success(response.Message);
                $("#btndeActiveBedMaster").html('<i class="fa fa-spinner fa-spin"></i> wait');
                $("#PopupBedMaster").modal('hide');
                fnClearFields();
                fnGridRefreshBedMaster();
                $("#btndeActiveBedMaster").attr("disabled", false);
            }
            else {
                toastr.error(response.Message);
                $("#btndeActiveBedMaster").attr("disabled", false);
                $("#btndeActiveBedMaster").html('De Activate');
            }
        },
        error: function (error) {
            toastr.error(error.statusText);
            $("#btndeActiveBedMaster").attr("disabled", false);
            $("#btndeActiveBedMaster").html('De Activate');
        }
    });
}