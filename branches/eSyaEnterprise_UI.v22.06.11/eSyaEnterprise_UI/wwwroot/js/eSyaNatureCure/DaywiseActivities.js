
$(document).ready(function () {
    fnGridLoadDaywiseActivities();
});
var actiontype = "";
function fnGridLoadDaywiseActivities() {

    var packageId = $("#cboPackageId").val();
    $("#jqgDaywiseActivities").GridUnload();

    $("#jqgDaywiseActivities").jqGrid({
        url: getBaseURL() + '/DaywiseActivities/GetAllDaywiseActivitiesbyPackageId?packageId=' + packageId,
        datatype: 'json',
        mtype: 'POST',
        contentType: 'application/json; charset=utf-8',
        ajaxGridOptions: { contentType: 'application/json; charset=utf-8' },
        colNames: [localization.PackageId, localization.PackageDescription, localization.DayId, localization.ActivityId, localization.ActivityDescription, localization.FromTime, localization.ToTime, localization.Active, localization.Actions],
        colModel: [
            { name: "PackageId", width: 10, align: 'left', editable: true, editoptions: { maxlength: 10 }, resizable: false, hidden: true },
            { name: "PackageDesc", width: 100, align: 'left', editable: true, editoptions: { maxlength: 15 }, resizable: false },
            { name: "DayId", width: 40, align: 'left', editable: true, editoptions: { maxlength: 15 }, resizable: false },
            { name: "ActivityId", width: 10, align: 'left', editable: true, editoptions: { maxlength: 10 }, resizable: false, hidden: true },
            { name: "ActivityDesc", width: 100, align: 'left', editable: true, editoptions: { maxlength: 15 }, resizable: false },
            { name: 'FromTime', index: 'Tid', width: 70, editable: true, formatoptions: { srcformat: 'ISO8601Long', newformat: 'ShortTime' }, editrules: { time: true } },
            { name: 'ToTime', index: 'Tid', width: 70, editable: true, formatoptions: { srcformat: 'ISO8601Long', newformat: 'ShortTime' }, editrules: { time: true } },
            { name: "ActiveStatus", width: 35, editable: true, align: 'center', edittype: "checkbox", formatter: 'checkbox', editoptions: { value: "true:false" } },
            {
                name: 'edit', search: false, align: 'left', width: 100, sortable: false, resizable: false,
                formatter: function (cellValue, options, rowdata, action) {
                    return '<button class="btn-xs ui-button ui-widget ui-corner-all btn-jqgrid" title="Edit" id="jqgEdit" onclick="return fnEditDaywiseActivity(event,\'edit\');"><i class="fas fa-pen"></i> ' + localization.Edit + '</button>' +
                        '<button class="btn-xs ui-button ui-widget ui-corner-all btn-jqgrid" title="View" id="jqgView" onclick="return fnEditDaywiseActivity(event,\'view\');"><i class="far fa-eye"></i> ' + localization.View + '</button>' +
                        '<button class="btn-xs ui-button ui-widget ui-corner-all btn-jqgrid" title="Delete" id="jqgDelete" onclick="return fnEditDaywiseActivity(event,\'delete\');"><i class="fas fa-trash"></i> ' + localization.Delete + '</button >'
                }
            },
        ],

        pager: "#jqpDaywiseActivities",
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

    }).jqGrid('navGrid', '#jqpDaywiseActivities', { add: false, edit: false, search: false, del: false, refresh: false, refreshtext: 'Reload' }).jqGrid('navButtonAdd', '#jqpDaywiseActivities', {
        caption: '<span class="fa fa-sync"></span> Refresh', buttonicon: "none", id: "custRefresh", position: "first", onClickButton: fnGridRefreshDaywiseActivities
        }).jqGrid('navButtonAdd', '#jqpDaywiseActivities', {
            caption: '<span class="fa fa-plus" data-toggle="modal"></span> Add', buttonicon: 'none', id: 'jqgAdd', position: 'first', onClickButton: fnAddDaywiseActivity
    });

    $(window).on("resize", function () {
        var $grid = $("#jqgDaywiseActivities"),
            newWidth = $grid.closest(".DaywiseActivitiescontainer").parent().width();
        $grid.jqGrid("setGridWidth", newWidth, true);
    });
    fnAddGridSerialNoHeading();
}

function fnAddDaywiseActivity() {

    fnClearFields();
    $('#cboActivity').val('0');
    $('#cboActivity').selectpicker('refresh');
    $('#cboActivity').next().attr('disabled', false);

    var id = $("#cboPackageId").val();
    if (id === 0 || id === "0") {
        toastr.warning("Please select any Package to add");
        return;
    }
    else {
        _isInsert = true;
        fnClearFields();
        $('#PopupDaywiseActivities').modal('show');
        $("#chkActiveStatus").parent().addClass("is-checked");
        $('#PopupDaywiseActivities').find('.modal-title').text(localization.AddDaywiseActivity);
        $("#btnSaveDaywiseActivities").html('<i class="fa fa-save"></i>' + localization.Save);
        $("#chkActiveStatus").prop('disabled', true);
        $("#btnSaveDaywiseActivities").show();
        $("#btndeActiveDaywiseActivities").hide();
      
    }

}

function fnEditDaywiseActivity(e, actiontype) {
    var rowid = $(e.target).parents("tr.jqgrow").attr('id');
    var rowData = $('#jqgDaywiseActivities').jqGrid('getRowData', rowid);

    $('#cboPackageId').val(rowData.PackageId);
    $('#cboPackageId').selectpicker('refresh');
    $('#PopupDaywiseActivities').modal('show');
    $('#txtDayId').val(rowData.DayId);
    $('#txtDayId').attr('readonly', true);
    $('#cboActivity').val(rowData.ActivityId);
    $('#cboActivity').selectpicker('refresh');
    $('#cboActivity').next().attr('disabled', true);
    $('#txtFromTime').val(rowData.FromTime);
    $('#txtToTime').val(rowData.ToTime);
   
    if (rowData.ActiveStatus == 'true') {
        $("#chkActiveStatus").parent().addClass("is-checked");
    }
    else {
        $("#chkActiveStatus").parent().removeClass("is-checked");
    }
    $("#btnSaveDaywiseActivities").attr("disabled", false);

    _isInsert = false;

    if (actiontype.trim() == "edit") {
        $('#PopupDaywiseActivities').find('.modal-title').text(localization.UpdateDaywiseActivity);
        $("#btnSaveDaywiseActivities").html('<i class="fa fa-sync"></i>' + localization.Update);
        $("#btndeActiveDaywiseActivities").hide();
        $("#chkActiveStatus").prop('disabled', true);
        $("#btnSaveDaywiseActivities").attr("disabled", false);
    }

    if (actiontype.trim() == "view") {
        $('#PopupDaywiseActivities').find('.modal-title').text(localization.ViewDaywiseActivity);
        $("#btnSaveDaywiseActivities").attr("disabled", false);
        $("input,textarea").attr('readonly', true);
        $("select").next().attr('disabled', true);
        $("#btnSaveDaywiseActivities").hide();
        $("#btndeActiveDaywiseActivities").hide();
        $("#chkActiveStatus").prop('disabled', true);
        $("#chkReadyForOccupancy").prop('disabled', true);

        $("#PopupDaywiseActivities").on('hidden.bs.modal', function () {
            $("#btnSaveDaywiseActivities").show();
            $("input,textarea").attr('readonly', false);
            $("select").next().attr('disabled', false);
        });
    }
    if (actiontype.trim() == "delete") {
        $('#PopupDaywiseActivities').find('.modal-title').text("Activate/De Activate Day wise Activity");
        $("#btnSaveDaywiseActivities").attr("disabled", false);
        $("input,textarea").attr('readonly', true);
        $("select").next().attr('disabled', true);
        $("#btnSaveDaywiseActivities").hide();

        if (rowData.ActiveStatus == 'true') {
            $("#btndeActiveDaywiseActivities").html(localization.DActivate);
        }
        else {
            $("#btndeActiveDaywiseActivities").html(localization.Activate);
        }

        $("#btndeActiveDaywiseActivities").show();
        $("#chkActiveStatus").prop('disabled', true);
        $("#PopupDaywiseActivities").on('hidden.bs.modal', function () {
            $("#btnSaveDaywiseActivities").show();
            $("input,textarea").attr('readonly', false);
            $("select").next().attr('disabled', false);
        });
    }
}

var _isInsert = true;
function fnSaveDaywiseActivities() {

    if ($("#cboPackageId").val() === 0 || $("#cboPackageId").val() === "0") {
        toastr.warning("Please select any Package");
        return;
    }

    if (IsStringNullorEmpty($("#txtDayId").val())) {
        toastr.warning("Please Enter Day Id");
        return;
    }
    if (IsStringNullorEmpty($("#cboActivity").val())) {
        toastr.warning("Please select Activity");
        return;
    }
    if ($("#cboActivity").val() === 0 || $("#cboActivity").val() === "0") {
        toastr.warning("Please select any Activity");
        return;
    }
   
    objactivity = {
        PackageId: $("#cboPackageId").val(),
        DayId: $("#txtDayId").val(),
        ActivityId: $("#cboActivity").val(),
        FromTime: $("#txtFromTime").val(),
        ToTime: $("#txtToTime").val(),
        ActiveStatus: $("#chkActiveStatus").parent().hasClass("is-checked")
    };

    $("#btnSaveDaywiseActivities").attr("disabled", true);

    $.ajax({
        url: getBaseURL() + '/DaywiseActivities/InsertOrUpdateDaywiseActivities',
        type: 'POST',
        datatype: 'json',
        data: { isInsert: _isInsert, obj: objactivity },
        success: function (response) {
            if (response.Status) {
                toastr.success(response.Message);
                $("#btnSaveDaywiseActivities").html('<i class="fa fa-spinner fa-spin"></i> wait');
                $("#PopupDaywiseActivities").modal('hide');
                fnClearFields();
                fnGridRefreshDaywiseActivities();
            }
            else {
                toastr.error(response.Message);
                $("#btnSaveDaywiseActivities").attr("disabled", false);
            }
        },
        error: function (error) {
            toastr.error(error.statusText);
            $("#btnSaveDaywiseActivities").attr("disabled", false);
        }
    });
}

function fnGridRefreshDaywiseActivities() {
    $("#jqgDaywiseActivities").setGridParam({ datatype: 'json', page: 1 }).trigger('reloadGrid');
}

function fnClearFields() {

    $("#txtDayId").val('');
    $("#txtDayId").attr('readonly', false);
    $('#cboActivity').val('0').selectpicker('refresh');;
    $('#cboActivity').attr('readonly', false);
    $("#txtFromTime").val('');
    $("#txtFromTime").attr('readonly', false);
    $("#txtToTime").val('');
    $("#txtToTime").attr('readonly', false);
    $("#chkActiveStatus").prop('disabled', true);
    $("#btnSaveDaywiseActivities").attr("disabled", false);
    $("#btndeActiveDaywiseActivities").attr("disabled", false);
}

$("#btnCancelDaywiseActivities").click(function () {
    $("#jqgDaywiseActivities").jqGrid('resetSelection');
    $('#PopupDaywiseActivities').modal('hide');
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

function fnDeleteDaywiseActivities() {

    var a_status;
    //Activate or De Activate the status
    if ($("#chkActiveStatus").parent().hasClass("is-checked") === true) {
        a_status = false
    }
    else {
        a_status = true;
    }

    objday = {
        PackageId: $("#cboPackageId").val(),
        DayId: $("#txtDayId").val(),
        ActivityId: $("#cboActivity").val(),
        FromTime: $("#txtFromTime").val(),
        ToTime: $("#txtToTime").val(),
        ActiveStatus: $("#chkActiveStatus").parent().hasClass("is-checked"),
        Status: a_status
    };

    $("#btndeActiveDaywiseActivities").attr("disabled", true);
    $.ajax({
        url: getBaseURL() + '/DaywiseActivities/ActiveOrDeActiveDayWiseActivities',
        type: 'POST',
        datatype: 'json',
        data: { objday: objday },
        success: function (response) {
            if (response.Status) {
                toastr.success(response.Message);
                $("#btndeActiveDaywiseActivities").html('<i class="fa fa-spinner fa-spin"></i> wait');
                $("#PopupDaywiseActivities").modal('hide');
                fnClearFields();
                fnGridRefreshDaywiseActivities();
                $("#btndeActiveDaywiseActivities").attr("disabled", false);
            }
            else {
                toastr.error(response.Message);
                $("#btndeActiveDaywiseActivities").attr("disabled", false);
                $("#btndeActiveDaywiseActivities").html('De Activate');
            }
        },
        error: function (error) {
            toastr.error(error.statusText);
            $("#btndeActiveDaywiseActivities").attr("disabled", false);
            $("#btndeActiveDaywiseActivities").html('De Activate');
        }
    });
}