﻿$(function () {
    fnGridLoadFormTaskAssignment();
});

var _isInsert = true;

function fnGridLoadFormTaskAssignment() {

    $("#jqgFormTaskAssignment").GridUnload();

    $("#jqgFormTaskAssignment").jqGrid({
        url: getBaseURL() + '/Levels/GetFormTaskAssignments',
        datatype: 'json',
        mtype: 'POST',
        contentType: 'application/json; charset=utf-8',
        ajaxGridOptions: { contentType: 'application/json; charset=utf-8' },
        colNames: [localization.FormId, localization.TaskId, localization.FormName, localization.TaskName, localization.AutoReassignTimeline, localization.Active, localization.Actions],
        colModel: [
            { name: "FormId", width: 50, align: 'left', editable: true, editoptions: { maxlength: 15 }, resizable: false, hidden: true },
            { name: "TaskId", width: 50, align: 'left', editable: true, editoptions: { maxlength: 15 }, resizable: false, hidden: true },
            { name: "FormName", width: 100, align: 'left', editable: true, editoptions: { maxlength: 6 }, resizable: false, hidden: false },
            { name: "TaskName", width: 180, align: 'left', editable: true, editoptions: { maxlength: 6 }, resizable: false, hidden: false },
            { name: "AutoReassignTimeline", width: 35, editable: true, align: 'center', edittype: "checkbox", formatter: 'checkbox', editoptions: { value: "true:false" } },
            { name: "ActiveStatus", width: 35, editable: true, align: 'center', edittype: "checkbox", formatter: 'checkbox', editoptions: { value: "true:false" } },
            {
                name: 'edit', search: false, align: 'left', width: 70, sortable: false, resizable: false,
                formatter: function (cellValue, options, rowdata, action) {
                    return '<button class="btn-xs ui-button ui-widget ui-corner-all btn-jqgrid" title="Edit" id="jqgEdit" onclick="return fnEditFormTaskAssignment(event,\'edit\');"><i class="fas fa-pen"></i> ' + localization.Edit + '</button>' +
                        '<button class="btn-xs ui-button ui-widget ui-corner-all btn-jqgrid" title="View" id="jqgView" onclick="return fnEditFormTaskAssignment(event,\'view\');"><i class="far fa-eye"></i>' + localization.View + '</button>'
                        + '<button class="btn-xs ui-button ui-widget ui-corner-all btn-jqgrid" title="Delete" id="jqgDelete" onclick="return fnEditFormTaskAssignment(event,\'delete\');"><i class="fas fa-trash"></i>' + localization.Delete + '</button>'
                }
            },
        ],
        pager: "#jqpFormTaskAssignment",
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
        forceFit: true, caption:'Form Task Assignment',
        loadComplete: function (data) {
            SetGridControlByAction();
            fnJqgridSmallScreen("jqgFormTaskAssignment");
        },
    }).jqGrid('navGrid', '#jqpFormTaskAssignment', { add: false, edit: false, search: false, del: false, refresh: false, refreshtext: 'Reload' }).jqGrid('navButtonAdd', '#jqpFormTaskAssignment', {
        caption: '<span class="fa fa-sync"></span> Refresh', buttonicon: "none", id: "custRefresh", position: "first", onClickButton: fnGridRefreshFormTaskAssignment
    }).jqGrid('navButtonAdd', '#jqpFormTaskAssignment', {
        caption: '<span class="fa fa-plus" data-toggle="modal"></span> Add', buttonicon: 'none', id: 'jqgAdd', position: 'first', onClickButton: fnAddFormTaskAssignment
    });

    $(window).on("resize", function () {
        var $grid = $("#jqgFormTaskAssignment"),
            newWidth = $grid.closest(".ui-jqgrid").parent().width();
        $grid.jqGrid("setGridWidth", newWidth, true);
    });
    fnAddGridSerialNoHeading();
}

function fnAddFormTaskAssignment() {

    $('#PopupFormTaskAssignment').modal('show');
    $('#PopupFormTaskAssignment').modal({ backdrop: 'static', keyboard: false });
    $('#PopupFormTaskAssignment').find('.modal-title').text(localization.AddFormTaskAssignment);
    $("#chkActiveStatus").parent().addClass("is-checked");
    fnClearFields();
    $("#chkActiveStatus").prop('disabled', true);
    $("#chkAutoReassignTimeline").parent().removeClass("is-checked");
    $("#chkAutoReassignTimeline").prop('disabled', false);
    $("#btnSaveFormTaskAssignment").html('<i class="fa fa-save"></i>' + localization.Save);
    $("#btnSaveFormTaskAssignment").show();
    $("#btndeActiveFormTaskAssignment").hide();
    _isInsert = true;

}


function fnEditFormTaskAssignment(e, actiontype) {

    var rowid = $(e.target).parents("tr.jqgrow").attr('id');
    var rowData = $('#jqgFormTaskAssignment').jqGrid('getRowData', rowid);

    _isInsert = false;

    $('#PopupFormTaskAssignment').modal('show');
    $('#cboForm').val(rowData.FormId).selectpicker('refresh');
    $('#cboTask').val(rowData.TaskId).selectpicker('refresh');

    if (rowData.AutoReassignTimeline == 'true') {
        $("#chkAutoReassignTimeline").parent().addClass("is-checked");
    }
    else {
        $("#chkAutoReassignTimeline").parent().removeClass("is-checked");
    }

    if (rowData.ActiveStatus == 'true') {
        $("#chkActiveStatus").parent().addClass("is-checked");
    }
    else {
        $("#chkActiveStatus").parent().removeClass("is-checked");
    }
    $("#btnSaveFormTaskAssignment").attr("disabled", false);


    if (actiontype.trim() == "edit") {
        $('#PopupFormTaskAssignment').find('.modal-title').text(localization.ViewFormTaskAssignment);
        $("#btnSaveFormTaskAssignment").html('<i class="fa fa-sync"></i>' + localization.Update);
        $("#btndeActiveFormTaskAssignment").hide();
        $("#chkActiveStatus").prop('disabled', true);
        $("#chkAutoReassignTimeline").prop('disabled', false);
        $("#btnSaveFormTaskAssignment").attr("disabled", false);
        $("#cboForm").next().attr('disabled', true);
        $('#cboForm').selectpicker('refresh');
        $("#cboTask").next().attr('disabled', true);
        $('#cboTask').selectpicker('refresh');

    }

    if (actiontype.trim() == "view") {
        $('#PopupFormTaskAssignment').find('.modal-title').text(localization.ViewFormTaskAssignment);
        $("#btnSaveFormTaskAssignment").attr("disabled", false);
        $("input,textarea").attr('readonly', true);
        $("select").next().attr('disabled', true);
        $("#btnSaveFormTaskAssignment").hide();
        $("#btndeActiveFormTaskAssignment").hide();
        $("#chkActiveStatus").prop('disabled', true);
        $("#chkAutoReassignTimeline").prop('disabled', true);
        $("#PopupFormTaskAssignment").on('hidden.bs.modal', function () {
            $("#btnSaveFormTaskAssignment").show();
            $("input,textarea").attr('readonly', false);
            $("select").next().attr('disabled', false);
        });
    }
    if (actiontype.trim() == "delete") {
        $('#PopupFormTaskAssignment').find('.modal-title').text("Activate/De Activate Form Task Assignment");
        $("#btnSaveFormTaskAssignment").attr("disabled", false);
        $("input,textarea").attr('readonly', true);
        $("select").next().attr('disabled', true);
        $("#btnSaveFormTaskAssignment").hide();

        if (rowData.ActiveStatus == 'true') {
            $("#btndeActiveFormTaskAssignment").html(localization.DActivate);
        }
        else {
            $("#btndeActiveFormTaskAssignment").html(localization.Activate);
        }

        $("#btndeActiveFormTaskAssignment").show();
        $("#chkActiveStatus").prop('disabled', true);
        $("#PopupFormTaskAssignment").on('hidden.bs.modal', function () {
            $("#btnSaveFormTaskAssignment").show();
            $("input,textarea").attr('readonly', false);
            $("select").next().attr('disabled', false);
        });
    }
}

function fnGridRefreshFormTaskAssignment() {
    $("#jqgFormTaskAssignment").setGridParam({ datatype: 'json', page: 1 }).trigger('reloadGrid');
}

$("#btnCancelFormTaskAssignment").click(function () {
    $("#jqgFormTaskAssignment").jqGrid('resetSelection');
    $('#PopupFormTaskAssignment').modal('hide');
    fnClearFields();
});

function fnClearFields() {
    $('#cboForm').val('0').selectpicker('refresh');
    $("#cboForm").next().attr('disabled', false);
    $('#cboTask').val('0').selectpicker('refresh');
    $("#cboTask").next().attr('disabled', false);
    $("#chkAutoReassignTimeline").prop('disabled', false);
    $("#btnSaveFormTaskAssignment").attr("disabled", false);
}


function fnSaveFormTaskAssignment() {

    if (IsStringNullorEmpty($("#cboForm").val()) || $("#cboForm").val() === "0") {
        toastr.warning("Please select Form");
        return;
    }
    if (IsStringNullorEmpty($("#cboTask").val()) || $("#cboTask").val() === "0") {
        toastr.warning("Please select Task");
        return;
    }

    obj_task = {
        FormId: $("#cboForm").val(),
        TaskId: $("#cboTask").val(),
        AutoReassignTimeline: $("#chkAutoReassignTimeline").parent().hasClass("is-checked"),
        ActiveStatus: $("#chkActiveStatus").parent().hasClass("is-checked")
    };

    $("#btnSaveFormTaskAssignment").attr("disabled", true);

    $.ajax({
        url: getBaseURL() + '/Levels/InsertOrUpdateFormTaskAssignment',
        type: 'POST',
        datatype: 'json',
        data: { isInsert: _isInsert, obj: obj_task },
        success: function (response) {
            if (response.Status) {

                toastr.success(response.Message);
                $("#btnSaveFormTaskAssignment").html('<i class="fa fa-spinner fa-spin"></i> wait');
                $("#PopupFormTaskAssignment").modal('hide');
                fnClearFields();
                fnGridRefreshFormTaskAssignment();
            }
            else {
                toastr.error(response.Message);
                $("#btnSaveFormTaskAssignment").attr("disabled", false);
            }
        },
        error: function (error) {
            toastr.error(error.statusText);
            $("#btnSaveFormTaskAssignment").attr("disabled", false);
        }
    });
}

function fnDeleteFormTaskAssignment() {

    var a_status;
    //Activate or De Activate the status
    if ($("#chkActiveStatus").parent().hasClass("is-checked") === true) {
        a_status = false
    }
    else {
        a_status = true;
    }

    $("#btndeActiveFormTaskAssignment").attr("disabled", true);
    $.ajax({
        url: getBaseURL() + '/Levels/ActiveOrDeActiveFormTaskAssignment?status=' + a_status + '&formId=' + $("#cboForm").val() + '&taskId=' + $("#cboTask").val(),
        type: 'POST',
        success: function (response) {
            if (response.Status) {
                toastr.success(response.Message);
                $("#btndeActiveFormTaskAssignment").html('<i class="fa fa-spinner fa-spin"></i> wait');
                $("#PopupFormTaskAssignment").modal('hide');
                fnClearFields();
                fnGridRefreshFormTaskAssignment();
                $("#btndeActiveFormTaskAssignment").attr("disabled", false);
            }
            else {
                toastr.error(response.Message);
                $("#btndeActiveFormTaskAssignment").attr("disabled", false);
                $("#btndeActiveFormTaskAssignment").html('De Activate');
            }
        },
        error: function (error) {
            toastr.error(error.statusText);
            $("#btndeActiveFormTaskAssignment").attr("disabled", false);
            $("#btndeActiveFormTaskAssignment").html('De Activate');
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

