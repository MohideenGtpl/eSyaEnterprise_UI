
$(document).ready(function () {
    fnGridLoadUser();
});
var actiontype = "";
function fnGridLoadUser() {

    $("#jqgUser").jqGrid('GridUnload');
    $("#jqgUser").jqGrid({
        url: getBaseURL() + '/Localize/UserCreation/GetAllUsers',
        mtype: 'Post',
        datatype: 'json',
        ajaxGridOptions: { contentType: 'application/json; charset=utf-8' },
        jsonReader: { repeatitems: false, root: "rows", page: "page", total: "total", records: "records" },
        colNames: [localization.UserId, localization.LoginID, localization.LoginDescription, localization.Password, localization.Active, localization.Actions],
        colModel: [
            { name: "UserId", width: 50, editable: true, align: 'left', hidden: true },
            { name: "LoginId", width: 150, editable: true, align: 'left', hidden: false },
            { name: "LoginDesc", width: 200, editable: false, hidden: false, align: 'left', resizable: true },
            { name: "Password", width: 200, editable: false, hidden: true, align: 'left', resizable: true },
            { name: "ActiveStatus", width: 35, editable: false, align: 'center', edittype: "checkbox", formatter: 'checkbox', editoptions: { value: "true:false" }, formatoptions: { disabled: true } },
            {
                name: 'action', search: false, align: 'left', width: 100, sortable: false, resizable: false,
                formatter: function (cellValue, options, rowdata, action) {
                    return '<button class="btn-xs ui-button ui-widget ui-corner-all btn-jqgrid" title="Edit" id="jqgEdit", onclick="return fnEditUser(event,\'edit\')"><i class="fas fa-pen"></i> ' + localization.Edit + ' </button>' +
                        '<button class="btn-xs ui-button ui-widget ui-corner-all btn-jqgrid" title ="View" id = "jqgView", onclick = "return fnEditUser(event,\'view\')"><i class="far fa-eye"></i> ' + localization.View + ' </button>' +
                        '<button class="btn-xs ui-button ui-widget ui-corner-all btn-jqgrid" title = "Delete" id="jqgDelete" onclick = "return fnEditUser(event,\'delete\')" > <i class="fas fa-trash"></i>' + localization.Delete + '</button >'
                }
            },
        ],
        pager: "#jqpUser",
        rowNum: 10000,
        rownumWidth: '55',
        pgtext: null,
        pgbuttons: null,
        loadonce: true,
        viewrecords: true,
        gridview: true,
        rownumbers: true,
        height: 'auto',
        align: "left",
        width: 'auto',
        autowidth: true,
        shrinkToFit: true,
        forceFit: true,
        scrollOffset: 0,
        loadComplete: function (data) {
            SetGridControlByAction();
            fnJqgridSmallScreen("jqgUser");
        },
    }).jqGrid('navGrid', '#jqpUser', { add: false, edit: false, search: false, del: false, refresh: false }).jqGrid('navButtonAdd', '#jqpUser', {
        caption: '<span class="fa fa-sync"></span> Refresh', buttonicon: "none", id: "custRefresh", position: "first", onClickButton: fnGridRefreshUser
    }).jqGrid('navButtonAdd', '#jqpUser', {
        caption: '<span class="fa fa-plus" data-toggle="modal"></span> Add', buttonicon: 'none', id: 'jqgAdd', position: 'first', onClickButton: fnAddUser
    });
    fnAddGridSerialNoHeading();
}

function fnAddUser() {

    $('#PopupUser').modal('show');
    $('#PopupUser').modal({ backdrop: 'static', keyboard: false });
    $('#PopupUser').find('.modal-title').text(localization.Adduser);
    $("#chkActiveStatus").parent().addClass("is-checked");
    fnClearFields();
    $("#chkActiveStatus").prop('disabled', true);
    $("#btnSaveUser").html('<i class="fa fa-save"></i>' + localization.Save);
    $("#btnSaveUser").show();
    $("#btnDeactivateUser").hide();
}

function fnEditUser(e, actiontype) {
    var rowid = $(e.target).parents("tr.jqgrow").attr('id');
    var rowData = $('#jqgUser').jqGrid('getRowData', rowid);

    $('#PopupUser').modal('show');
    $('#txtUserId').val(rowData.UserId);
    $("#txtLoginId").val(rowData.LoginId);
    $("#txtLoginDescription").val(rowData.LoginDesc);
    $("#txtPassword").val(rowData.Password);
   
    if (rowData.ActiveStatus == 'true') {
        $("#chkActiveStatus").parent().addClass("is-checked");

    }
    else {
        $("#chkActiveStatus").parent().removeClass("is-checked");

    }
    $("#btnSaveUser").attr('disabled', false);
    if (actiontype.trim() == "edit") {
        $('#PopupUser').find('.modal-title').text(localization.UpdateUser);
        $("#chkActiveStatus").prop('disabled', true);
        $("#btnSaveUser").html('<i class="fa fa-sync"></i>' + localization.Update);
        $("#btnDeactivateUser").hide();
        $("input,textarea").attr('readonly', false);
        $("select").next().attr('disabled', false);
        $("#btnSaveUser").show();
    }
    if (actiontype.trim() == "view") {
        $('#PopupUser').find('.modal-title').text(localization.ViewUser);
        $("#chkActiveStatus").prop('disabled', true);
        $("#btnSaveUser,#btnDeactivateUser").hide();
        $("input,textarea").attr('readonly', true);
        $("select").next().attr('disabled', true);
    }
    if (actiontype.trim() == "delete") {
        $('#PopupUser').find('.modal-title').text("Active/De Active User");
        if (rowData.ActiveStatus == 'true') {
            $("#btnDeactivateUser").html(localization.Deactivate);
        }
        else {
            $("#btnDeactivateUser").html(localization.Activate);
        }
        $("#btnSaveUser").hide();
        $("#btnDeactivateUser").show();
        $("#chkActiveStatus").prop('disabled', true);
        $("#chkApplicationDefaultStatus").prop('disabled', true);
        $("input,textarea").attr('readonly', true);
        $("select").next().attr('disabled', true);
    }

}



function fnSaveUser() {
    if (validateUser() === false) {
        return;
    }

    $("#btnSaveUser").attr('disabled', true);
    _objuser= {
        UserId: $("#txtUserId").val() === '' ? 0 : $("#txtUserId").val(),
        LoginId: $("#txtLoginId").val(),
        LoginDesc: $("#txtLoginDescription").val(),
        Password: $("#txtPassword").val(),
        ActiveStatus: $("#chkActiveStatus").parent().hasClass("is-checked")
    }
    $("#btnSaveUser").attr('disabled', true);
    $.ajax({
        url: getBaseURL() + '/Localize/UserCreation/InsertOrUpdateUserCreation',
        type: 'POST',
        datatype: 'json',
        data: {obj: _objuser },
        success: function (response) {
            if (response.Status) {
                toastr.success(response.Message);
                $("#btnSaveUser").html('<i class="fa fa-spinner fa-spin"></i> wait');
                $("#btnSaveUser").attr('disabled', false);
                fnGridRefreshUser();
                $('#PopupUser').modal('hide');
            }
            else {
                toastr.error(response.Message);
                $("#btnSaveUser").attr('disabled', false);
            }
        },
        error: function (error) {
            toastr.error(error.statusText);
            $("#btnSaveUser").attr("disabled", false);
        }
    });
}

function validateUser() {

    var PasswordPattern = new RegExp("((?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@@#$%!&*]).{8,20})");

    if ($("#txtLoginId").val().trim().length <= 0) {
        toastr.warning("Please Enter Login Id");
        return false;
    }
    if ($("#txtLoginDescription").val().trim().length <= 0) {
        toastr.warning("Please Enter Login Description");
        return false;
    }
    if ($("#txtPassword").val().trim().length <= 0) {
        toastr.warning("Please Enter Password");
        return false;
    }
   
    if (!PasswordPattern.test($("#txtPassword").val())) {
        toastr.warning("Password Should Contains : Minimum 8 character, Minimum 1 uppercase character/lowercase character required, Minimum 1 special symbol(@@#$%!&*) required, Minimum 1 digit required.");
        return false;
    }
}


function fnGridRefreshUser() {
    $("#jqgUser").setGridParam({ datatype: 'json', page: 1 }).trigger('reloadGrid');
}

$("#btncancelUser").click(function () {
    fnClearFields();
    $("#jqgUser").jqGrid('resetSelection');
    $('#PopupUser').modal('hide');
});

function fnClearFields() {
    $("#txtUserId").val('');
    $("#txtLoginId").val('');
    $("#txtLoginDescription").val('');
    $("#txtPassword").val('');
    $("#btnSaveUser").attr('disabled', false);
    $("input,textarea").attr('readonly', false);
    $("select").next().attr('disabled', false);
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


function fnDeleteUser() {

    var a_status;
    //Activate or De Activate the status
    if ($("#chkActiveStatus").parent().hasClass("is-checked") === true) {
        a_status = false
    }
    else {
        a_status = true;
    }
    $("#btnDeactivateUser").attr("disabled", true);
    $.ajax({
        url: getBaseURL() + '/Localize/UserCreation/ActiveOrDeActiveUser?status=' + a_status + '&UserId=' + $("#txtUserId").val(),
        type: 'POST',
        success: function (response) {
            if (response.Status) {
                toastr.success(response.Message);
                $("#btnDeactivateUser").html('<i class="fa fa-spinner fa-spin"></i> wait');
                $('#PopupUser').modal('hide');
                fnClearFields();
                fnGridRefreshUser();
                $("#btnDeactivateUser").attr("disabled", false);
            }
            else {
                toastr.error(response.Message);
                $("#btnDeactivateUser").attr("disabled", false);
                $("#btnDeactivateUser").html('De Activate');
            }
        },
        error: function (error) {
            toastr.error(error.statusText);
            $("#btnDeactivateUser").attr("disabled", false);
            $("#btnDeactivateUser").html('De Activate');
        }
    });
}
