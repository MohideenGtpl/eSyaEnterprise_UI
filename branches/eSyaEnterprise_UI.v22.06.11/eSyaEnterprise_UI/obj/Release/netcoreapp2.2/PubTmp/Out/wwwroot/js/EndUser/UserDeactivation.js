﻿
var UserID;
var formID;
var BusinessKey;

$(document).ready(function () {
    fnGridLoadUserCreation();

    $("#dvForm").hide();
    $("#divUserCreationForm").css('display', 'none');
    $("#divUserCreationGrid").show();
    $(window).on('resize', function () {
        if ($(window).width() < 1025) {
            fnJqgridSmallScreen('jqgUserCreation');
        }
    });
});

function fnGridLoadUserCreation() {
   
    var URL = getBaseURL() + '/UserCreation/GetUserMasterForUserDeactivation';

    $("#jqgUserCreation").jqGrid('GridUnload');
    $("#jqgUserCreation").jqGrid({
        url: URL,
        mtype: 'Post',
        datatype: 'json',
        ajaxGridOptions: { contentType: 'application/json; charset=utf-8' },
        jsonReader: { repeatitems: false, root: "rows", page: "page", total: "total", records: "records" },
        colNames: ["User ID", localization.LoginID, localization.LoginDescription, localization.MobileNumber, localization.LastActivityDate, localization.Active, localization.Actions],
        colModel: [
            { name: "UserID", width: 120, editable: true, align: 'left', hidden: true },
            { name: "LoginID", width: 120, editable: true, align: 'left', hidden: false },
            { name: "LoginDesc", width: 300, editable: false, hidden: false, align: 'left', resizable: true },
            { name: "MobileNumber", width: 100, editable: true, align: 'left', resizable: false, editoption: { 'text-align': 'left', maxlength: 50 } },
            {
                name: 'LastActivityDate', index: 'LastActivityDate', width: 80, sorttype: "date", formatter: "date", formatoptions:
                    { newformat: _cnfjqgDateFormat }
            },
            { name: "ActiveStatus", editable: false, width: 40, align: 'center', resizable: false, edittype: "checkbox", formatter: 'checkbox', editoptions: { value: "true:false" } },
            {
                name: 'Edit', search: false, align: 'left', width: 70, sortable: false, resizable: false,
                formatter: function (cellValue, options, rowdata, action) {
                    return '<button class="btn-xs ui-button ui-widget ui-corner-all btn-jqgrid" title="Edit" id="jqgEdit" onclick="return fnEditUserCreation(event)"><i class="fas fa-pen"></i> ' + localization.Edit + ' </button>'

                }
            }
        ],
        pager: "#jqpUserCreation",
        rowNum: 10,
        rowList: [10, 20, 50, 100],
        rownumWidth:55,
        loadonce: true,
        viewrecords: true,
        gridview: true,
        rownumbers: true,
        height: 'auto',
        forceFit: true,
        width: 'auto',
        autowidth: true,
        //onSelectRow: function (rowid) {
        //    UserID = $("#jqgUserCreation").jqGrid('getCell', rowid, 'UserID');

        //},
        loadComplete: function (data) {
            SetGridControlByAction();
            fnAddGridSerialNoHeading();
            fnJqgridSmallScreen('jqgUserCreation');
        },
        
        shrinkToFit: true,
        scrollOffset: 0
    }).jqGrid('navGrid', '#jqpUserCreation', { add: false, edit: false, search: false, del: false, refresh: false }).jqGrid('navButtonAdd', '#jqpUserCreation', {
        caption: '<span class="fa fa-sync"></span> Refresh', buttonicon: "none", id: "custRefresh", position: "first", onClickButton: fnGridRefreshUserCreation
        }).jqGrid('navButtonAdd', '#jqpUserCreation', {
            caption: '<span class="fa fa-plus" data-toggle="modal"></span> Add', buttonicon: 'none', id: 'jqgAdd', position: 'first'
        });
    fnAddGridSerialNoHeading();
}

function SetGridControlByAction() {
    $('#jqgAdd').addClass('ui-state-disabled');

    if (_userFormRole.IsInsert === false) {
        $('#jqgAdd').addClass('ui-state-disabled');
    }
    if (_userFormRole.IsEdit === false) {
        var eleDisable = document.querySelectorAll('#jqgEdit');
        for (var i = 0; i < eleDisable.length; i++) {
            eleDisable[i].disabled = true;
            eleDisable[i].className = "ui-state-disabled";
        }
    }
}

function fnGridRefreshUserCreation() {
    $("#jqgUserCreation").setGridParam({ datatype: 'json', page: 1 }).trigger('reloadGrid');
}

function fnEditUserCreation(e) {
    fnClearUserMaster();
    var rowid = $(e.target).parents("tr.jqgrow").attr('id');
    var rowData = $('#jqgUserCreation').jqGrid('getRowData', rowid);
    UserID = rowData.UserID;
        
    $("#txtUserId").val(UserID);
    if (UserID !== '' && UserID !== undefined) {
        $("#divUserCreationForm").css('display', 'block');
        $("#divUserCreationGrid").hide();

        $("#txtLoginId").val(rowData.LoginID);
        $("#txtLoginDescription").val(rowData.LoginDesc);
        
    }
}

function fnCancelUserMaster() {
    $("#jqgUserCreation").setGridParam({ datatype: 'json', page: 1 }).trigger('reloadGrid');
    $("#divUserCreationForm").css('display', 'none');
    $("#divUserCreationGrid").show();
}

function fnClearUserMaster() {
    $('#txtUserId').val('');
    $('#txtLoginId').val('');
    $('#txtLoginDescription').val('');
    $('#txtReason').val('');

    $("#txtLoginId").attr('disabled', true);
    $("#txtLoginDescription").attr('disabled', true);
}

function validateUserMaster() {
    
    if ($("#txtLoginId").val().trim().length <= 0) {
        toastr.warning("Please Enter Login Id");
        return false;
    }
    if ($("#txtLoginDescription").val().trim().length <= 0) {
        toastr.warning("Please Enter Login Description");
        return false;
    }
    if ($("#txtReason").val().trim().length <= 0) {
        toastr.warning("Please Enter Reason for Deactivation");
        return false;
    }
}
 
function fnSaveUserMaster() {

    if (validateUserMaster() === false) {
        return;
    }

    $("#btnSaveUserMaster").attr('disabled', true);

    var userId = $("#txtUserId").val();
    var userMaster;
    
        userMaster = {
            LoginID: $("#txtLoginId").val(),
            UserID: $("#txtUserId").val(),
            LoginDesc: $("#txtLoginDescription").val(),
            DeactivationReason: $("#txtReason").val(),
        };

    $.ajax({
        async: false,
        url: getBaseURL() + '/UserCreation/UpdateUserForDeativation',
        type: 'POST',
        data: {
            userMaster: userMaster
        },
        datatype: 'json',
        success: function (response) {
            if (response.Status) {
                toastr.success(response.Message);
                $("#btnSaveUserMaster").attr('disabled', true);
                $("#btnSaveUserMaster").hide();
            }
            else {
                toastr.error(response.Message);
            }
            $("#btnSaveUserMaster").attr('disabled', false);
            $("#btnSaveUserMaster").show();
            fnCancelUserMaster();
        },
        error: function (error) {
            toastr.error(error.statusText);
            $("#btnSaveUserMaster").attr("disabled", false);
        }
    }); 
}
