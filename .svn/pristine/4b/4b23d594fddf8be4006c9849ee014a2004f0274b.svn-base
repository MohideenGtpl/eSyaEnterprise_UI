$(function () {
    fnGridLoadFormTaskApproval();
});

var _isInsert = true;

function fnBusinessLocation_onChange() {

    fnGridLoadFormTaskApproval();
}
function fnGridLoadFormTaskApproval() {

    $("#jqgFormTaskApproval").GridUnload();

    $("#jqgFormTaskApproval").jqGrid({
        url: getBaseURL() + '/Levels/GetFormTaskApprovalsbyBusinesskey?businesskey=' + $("#cboBusinessLocation").val(),
        datatype: 'json',
        mtype: 'POST',
        contentType: 'application/json; charset=utf-8',
        ajaxGridOptions: { contentType: 'application/json; charset=utf-8' },
        colNames: [localization.BusinessKey, localization.FormId, localization.TaskId, localization.UserRole, localization.FormName, localization.TaskName, localization.UserRole, localization.ApprovalLevelStage, localization.ApproverPriority, localization.ApprovalRangeFrom, localization.ApprovalRangeTo, localization.Active, localization.Actions],
        colModel: [
            { name: "BusinessKey", width: 30, align: 'left', editable: true, editoptions: { maxlength: 15 }, resizable: false, hidden: true },
            { name: "FormId", width: 30, align: 'left', editable: true, editoptions: { maxlength: 15 }, resizable: false, hidden: true },
            { name: "TaskId", width: 30, align: 'left', editable: true, editoptions: { maxlength: 15 }, resizable: false, hidden: true },
            { name: "UserRole", width: 30, align: 'left', editable: true, editoptions: { maxlength: 15 }, resizable: false, hidden: true },
            { name: "FormName", width: 80, align: 'left', editable: true, editoptions: { maxlength: 6 }, resizable: false, hidden: false },
            { name: "TaskName", width: 80, align: 'left', editable: true, editoptions: { maxlength: 6 }, resizable: false, hidden: false },
            { name: "UserRoleName", width: 80, align: 'left', editable: true, editoptions: { maxlength: 6 }, resizable: false, hidden: false },
            { name: "ApprovalLevelStage", width: 50, align: 'left', editable: true, editoptions: { maxlength: 15 }, resizable: false },
            { name: "ApproverPriority", width: 50, align: 'left', editable: true, editoptions: { maxlength: 15 }, resizable: false },
            { name: "ApprovalRangeFrom", width: 50, align: 'left', editable: true, editoptions: { maxlength: 15 }, resizable: false },
            { name: "ApprovalRangeTo", width: 50, align: 'left', editable: true, editoptions: { maxlength: 15 }, resizable: false },
            { name: "ActiveStatus", width: 35, editable: true, align: 'center', edittype: "checkbox", formatter: 'checkbox', editoptions: { value: "true:false" } },
            {
                name: 'edit', search: false, align: 'left', width: 100, sortable: false, resizable: false,
                formatter: function (cellValue, options, rowdata, action) {
                    return '<button class="btn-xs ui-button ui-widget ui-corner-all btn-jqgrid" title="Edit" id="jqgEdit" onclick="return fnEditFormTaskApproval(event,\'edit\');"><i class="fas fa-pen"></i> ' + localization.Edit + '</button>' +
                        '<button class="btn-xs ui-button ui-widget ui-corner-all btn-jqgrid" title="View" id="jqgView" onclick="return fnEditFormTaskApproval(event,\'view\');"><i class="far fa-eye"></i>' + localization.View + '</button>'
                        + '<button class="btn-xs ui-button ui-widget ui-corner-all btn-jqgrid" title="Delete" id="jqgDelete" onclick="return fnEditFormTaskApproval(event,\'delete\');"><i class="fas fa-trash"></i>' + localization.Delete + '</button>'
                }
            },
        ],
        pager: "#jqpFormTaskApproval",
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
        forceFit: true, caption:'Form Task Approval',
        loadComplete: function (data) {
            SetGridControlByAction(); fnJqgridSmallScreen("jqpFormTaskApproval");
        },
    }).jqGrid('navGrid', '#jqpFormTaskApproval', { add: false, edit: false, search: false, del: false, refresh: false, refreshtext: 'Reload' }).jqGrid('navButtonAdd', '#jqpFormTaskApproval', {
        caption: '<span class="fa fa-sync"></span> Refresh', buttonicon: "none", id: "custRefresh", position: "first", onClickButton: fnGridRefreshFormTaskApproval
        }).jqGrid('navButtonAdd', '#jqpFormTaskApproval', {
        caption: '<span class="fa fa-plus" data-toggle="modal"></span> Add', buttonicon: 'none', id: 'jqgAdd', position: 'first', onClickButton: fnAddFormTaskApproval
    });

    $(window).on("resize", function () {
        var $grid = $("#jqgFormTaskApproval"),
            newWidth = $grid.closest(".ui-jqgrid").parent().width();
        $grid.jqGrid("setGridWidth", newWidth, true);
    });
    fnAddGridSerialNoHeading();
}

function fnAddFormTaskApproval() {
    if (IsStringNullorEmpty($("#cboBusinessLocation").val()) || $("#cboBusinessLocation").val() === "0") {
        toastr.warning("Please select Business key to Add");
        return;
    }
    else {
        $('#PopupFormTaskApproval').modal('show');
        $('#PopupFormTaskApproval').modal({ backdrop: 'static', keyboard: false });
        $('#PopupFormTaskApproval').find('.modal-title').text(localization.AddFormTaskApproval);
        $("#chkActiveStatus").parent().addClass("is-checked");
        fnClearFields();
        $("#chkActiveStatus").prop('disabled', true);
        $("#btnSaveFormTaskApproval").html('<i class="fa fa-save"></i>' + localization.Save);
        $("#btnSaveFormTaskApproval").show();
        $("#btndeActiveFormTaskApproval").hide();
        _isInsert = true;

    }
}

function fnEditFormTaskApproval(e, actiontype) {

    var rowid = $(e.target).parents("tr.jqgrow").attr('id');
    var rowData = $('#jqgFormTaskApproval').jqGrid('getRowData', rowid);

    _isInsert = false;

    $('#PopupFormTaskApproval').modal('show');
    $('#cboForm').val(rowData.FormId).selectpicker('refresh');
    $('#cboUserRole').val(rowData.UserRole).selectpicker('refresh');
    fnBindFormTask();
    $('#cboTask').val(rowData.TaskId).selectpicker('refresh');
    $('#txtApprovalLevelStage').val(rowData.ApprovalLevelStage);
    $('#txtApproverPriority').val(rowData.ApproverPriority);
    $('#txtApprovalRangeFrom').val(rowData.ApprovalRangeFrom);
    $('#txtApprovalRangeTo').val(rowData.ApprovalRangeTo);
    if (rowData.ActiveStatus == 'true') {
        $("#chkActiveStatus").parent().addClass("is-checked");
    }
    else {
        $("#chkActiveStatus").parent().removeClass("is-checked");
    }
    $("#btnSaveFormTaskApproval").attr("disabled", false);


    if (actiontype.trim() == "edit") {
        $('#PopupFormTaskApproval').find('.modal-title').text(localization.EditFormTaskApproval);
        $("#btnSaveFormTaskApproval").html('<i class="fa fa-sync"></i>' + localization.Update);
        $("#btndeActiveFormTaskApproval").hide();
        $("#chkActiveStatus").prop('disabled', false);
        $("#btnSaveFormTaskApproval").attr("disabled", false);
        $("#cboForm").next().attr('disabled', true);
        $('#cboForm').selectpicker('refresh');
        $("#cboTask").next().attr('disabled', true);
        $('#cboTask').selectpicker('refresh');
        $("#cboUserRole").next().attr('disabled', true);
        $('#cboUserRole').selectpicker('refresh');
        $("#txtApprovalLevelStage").attr('readonly', true);
        $("#txtApproverPriority").attr('readonly', true);
        $("#chkActiveStatus").prop('disabled', true);
    }

    if (actiontype.trim() == "view") {
        $('#PopupFormTaskApproval').find('.modal-title').text(localization.ViewFormTaskApproval);
        $("#btnSaveFormTaskApproval").attr("disabled", false);
        $("input,textarea").attr('readonly', true);
        $("select").next().attr('disabled', true);
        $("#btnSaveFormTaskApproval").hide();
        $("#btndeActiveFormTaskApproval").hide();
        $("#chkActiveStatus").prop('disabled', true);
        $("#PopupFormTaskApproval").on('hidden.bs.modal', function () {
            $("#btnSaveFormTaskApproval").show();
            $("input,textarea").attr('readonly', false);
            $("select").next().attr('disabled', false);
        });
    }
    if (actiontype.trim() == "delete") {
        $('#PopupFormTaskApproval').find('.modal-title').text("Activate/De Activate Form Task Approval");
        $("#btnSaveFormTaskApproval").attr("disabled", false);
        $("input,textarea").attr('readonly', true);
        $("select").next().attr('disabled', true);
        $("#btnSaveFormTaskApproval").hide();

        if (rowData.ActiveStatus == 'true') {
            $("#btndeActiveFormTaskApproval").html(localization.DActivate);
        }
        else {
            $("#btndeActiveFormTaskApproval").html(localization.Activate);
        }

        $("#btndeActiveFormTaskApproval").show();
        $("#chkActiveStatus").prop('disabled', true);
        $("#PopupFormTaskApproval").on('hidden.bs.modal', function () {
            $("#btnSaveFormTaskApproval").show();
            $("input,textarea").attr('readonly', false);
            $("select").next().attr('disabled', false);
        });
    }
}

function fnGridRefreshFormTaskApproval() {
    $("#jqgFormTaskApproval").setGridParam({ datatype: 'json', page: 1 }).trigger('reloadGrid');
}

$("#btnCancelFormTaskApproval").click(function () {
    $("#jqgFormTaskApproval").jqGrid('resetSelection');
    $('#PopupFormTaskApproval').modal('hide');
    fnClearFields();
});

function fnClearFields() {
    $('#cboForm').val('0').selectpicker('refresh');
    $("#cboForm").next().attr('disabled', false);
    $('#cboTask').val('0').selectpicker('refresh');
    $("#cboTask").next().attr('disabled', false);
    $('#cboUserRole').val('0').selectpicker('refresh');
    $("#cboUserRole").next().attr('disabled', false);
    $("#chkActiveStatus").prop('disabled', false);
    $("#txtApprovalLevelStage").attr('readonly', false);
    $("#txtApproverPriority").attr('readonly', false);
    $("#btnSaveFormTaskApproval").attr("disabled", false);
    $('#txtApprovalLevelStage').val('');
    $('#txtApproverPriority').val('');
    $('#txtApprovalRangeFrom').val('');
    $('#txtApprovalRangeTo').val('');
}

function fnSaveFormTaskApproval() {
    if (IsStringNullorEmpty($("#cboBusinessLocation").val()) || $("#cboBusinessLocation").val() === "0") {
        toastr.warning("Please select Business key");
        return;
    }
    if (IsStringNullorEmpty($("#cboForm").val()) || $("#cboForm").val() === "0") {
        toastr.warning("Please select Form");
        return;
    }
    if (IsStringNullorEmpty($("#cboTask").val()) || $("#cboTask").val() === "0") {
        toastr.warning("Please select Task");
        return;
    }
    if (IsStringNullorEmpty($("#cboUserRole").val()) || $("#cboUserRole").val() === "0") {
        toastr.warning("Please select User Role");
        return;
    }
    if (IsStringNullorEmpty($("#txtApprovalLevelStage").val())) {
        toastr.warning("Please Enter Approval Level Stage");
        return;
    }
    if (IsStringNullorEmpty($("#txtApproverPriority").val())) {
        toastr.warning("Please Enter Approver Priority");
        return;
    }
    if (IsStringNullorEmpty($("#txtApprovalRangeFrom").val())) {
        toastr.warning("Please Enter Approval Range From");
        return;
    }
    if (IsStringNullorEmpty($("#txtApprovalRangeTo").val())) {
        toastr.warning("Please Enter Approval Range To");
        return;
    }
    obj_approval = {
        BusinessKey: $("#cboBusinessLocation").val(),
        FormId: $("#cboForm").val(),
        TaskId: $("#cboTask").val(),
        ApprovalLevelStage: $("#txtApprovalLevelStage").val(),
        ApproverPriority: $("#txtApproverPriority").val(),
        UserRole: $("#cboUserRole").val(),
        ApprovalRangeFrom: $("#txtApprovalRangeFrom").val(),
        ApprovalRangeTo: $("#txtApprovalRangeTo").val(),
        ActiveStatus: $("#chkActiveStatus").parent().hasClass("is-checked")
    };

    $("#btnSaveFormTaskApproval").attr("disabled", true);

    $.ajax({
        url: getBaseURL() + '/Levels/InsertOrUpdateFormTaskApproval',
        type: 'POST',
        datatype: 'json',
        data: { isInsert: _isInsert, obj: obj_approval },
        success: function (response) {
            if (response.Status) {

                toastr.success(response.Message);
                $("#btnSaveFormTaskApproval").html('<i class="fa fa-spinner fa-spin"></i> wait');
                $("#PopupFormTaskApproval").modal('hide');
                fnClearFields();
                fnGridRefreshFormTaskApproval();
            }
            else {
                toastr.error(response.Message);
                $("#btnSaveFormTaskApproval").attr("disabled", false);
            }
        },
        error: function (error) {
            toastr.error(error.statusText);
            $("#btnSaveFormTaskApproval").attr("disabled", false);
        }
    });
}

function fnDeleteFormTaskApproval() {

    var a_status;
    //Activate or De Activate the status
    if ($("#chkActiveStatus").parent().hasClass("is-checked") === true) {
        a_status = false
    }
    else {
        a_status = true;
    }
    obj_del = {
        BusinessKey: $("#cboBusinessLocation").val(),
        FormId: $("#cboForm").val(),
        TaskId: $("#cboTask").val(),
        ApprovalLevelStage: $("#txtApprovalLevelStage").val(),
        ApproverPriority: $("#txtApproverPriority").val(),
        UserRole: $("#cboUserRole").val(),
        ApprovalRangeFrom: $("#txtApprovalRangeFrom").val(),
        ApprovalRangeTo: $("#txtApprovalRangeTo").val(),
        ActiveStatus: $("#chkActiveStatus").parent().hasClass("is-checked"),
        status: a_status
    };
    $("#btndeActiveFormTaskApproval").attr("disabled", true);
    $.ajax({
        url: getBaseURL() + '/Levels/ActiveOrDeActiveFormTaskApproval',
        type: 'POST',
        datatype: 'json',
        data: { objform: obj_del },
        success: function (response) {
            if (response.Status) {
                toastr.success(response.Message);
                $("#btndeActiveFormTaskApproval").html('<i class="fa fa-spinner fa-spin"></i> wait');
                $("#PopupFormTaskApproval").modal('hide');
                fnClearFields();
                fnGridRefreshFormTaskApproval();
                $("#btndeActiveFormTaskApproval").attr("disabled", false);
            }
            else {
                toastr.error(response.Message);
                $("#btndeActiveFormTaskApproval").attr("disabled", false);
                $("#btndeActiveFormTaskApproval").html('De Activate');
            }
        },
        error: function (error) {
            toastr.error(error.statusText);
            $("#btndeActiveFormTaskApproval").attr("disabled", false);
            $("#btndeActiveFormTaskApproval").html('De Activate');
        }
    });
}

function fncboForm_change() {
    fnBindFormTask();
}

function fnBindFormTask() {

    $("#cboTask").empty();

    $.ajax({
        url: getBaseURL() + '/Levels/GetFormTaskbyFormId?formId=' + $("#cboForm").val(),
        type: 'POST',
        dataType: 'json',
        contentType: 'application/json; charset=utf-8',
        error: function (xhr) {
            toastr.error('Error: ' + xhr.statusText);
        },
        success: function (response, data) {

            //refresh each time 
            $("#cboTask").empty();
            $("#cboTask").append($("<option value='0'> Select </option>"));
            for (var i = 0; i < response.length; i++) {

                $("#cboTask").append($("<option></option>").val(response[i]["TaskId"]).html(response[i]["TaskName"]));
            }
            $('#cboTask').selectpicker('refresh');

        },
        async: false,
        processData: false
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

