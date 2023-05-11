
$(document).ready(function () {
    fnGridPackageMaster();
});
var actiontype = "";
function fnGridPackageMaster() {

    $("#jqgPackageMaster").GridUnload();

    $("#jqgPackageMaster").jqGrid({
        url: getBaseURL() + '/PackageMaster/GetAllPackageMasters',
        datatype: 'json',
        mtype: 'POST',
        contentType: 'application/json; charset=utf-8',
        ajaxGridOptions: { contentType: 'application/json; charset=utf-8' },
        colNames: [localization.PackageId, localization.Description, localization.NoOfNights, localization.CheckInWeekDays, localization.CheckInFromTime, localization.CheckInToTime, localization.CheckOutFromTime, localization.CheckOutToTime, localization.Active, localization.Actions],
        colModel: [
            { name: "PackageId", width: 50, align: 'left', editable: true, editoptions: { maxlength: 10 }, resizable: false, hidden: true },
            { name: "PackageDesc", width: 150, align: 'left', editable: true, editoptions: { maxlength: 150 }, resizable: false },
            { name: "NoOfNights", width: 60, align: 'left', editable: true, editoptions: { maxlength: 10 }, resizable: false, hidden: false },
            { name: "CheckInWeekDays", width: 85, align: 'left', editable: true, editoptions: { maxlength: 10 }, resizable: false, hidden: false },
            { name: 'CheckInFromTime', index: 'Tid', width: 70, editable: true, formatoptions: { srcformat: 'ISO8601Long', newformat: 'ShortTime' }, editrules: { time: true } },
            { name: 'CheckInToTime', index: 'Tid', width: 70, editable: true, formatoptions: { srcformat: 'ISO8601Long', newformat: 'ShortTime' }, editrules: { time: true } },
            { name: 'CheckOutFromTime', index: 'Tid', width:70, editable: true, formatoptions: { srcformat: 'ISO8601Long', newformat: 'ShortTime' }, editrules: { time: true } },
            { name: 'CheckOutToTime', index: 'Tid', width: 70, editable: true, formatoptions: { srcformat: 'ISO8601Long', newformat: 'ShortTime' }, editrules: { time: true } },
            { name: "ActiveStatus", width: 35, editable: true, align: 'center', edittype: "checkbox", formatter: 'checkbox', editoptions: { value: "true:false" } },
            {
                name: 'edit', search: false, align: 'left', width: 120, sortable: false, resizable: false,
                formatter: function (cellValue, options, rowdata, action) {
                    return '<button class="btn-xs ui-button ui-widget ui-corner-all btn-jqgrid" title="Edit" id="jqgEdit" onclick="return fnEditPackageMaster(event,\'edit\');"><i class="fas fa-pen"></i> ' + localization.Edit + '</button>' +
                        '<button class="btn-xs ui-button ui-widget ui-corner-all btn-jqgrid" title="View" id="jqgView" onclick="return fnEditPackageMaster(event,\'view\');"><i class="far fa-eye"></i> ' + localization.View + '</button>' +
                        '<button class="btn-xs ui-button ui-widget ui-corner-all btn-jqgrid" title="Delete" id="jqgDelete" onclick="return fnEditPackageMaster(event,\'delete\');"><i class="fas fa-trash"></i> ' + localization.Delete + '</button >'
                }
            },
        ],

        pager: "#jqpPackageMaster",
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

    }).jqGrid('navGrid', '#jqpPackageMaster', { add: false, edit: false, search: false, del: false, refresh: false, refreshtext: 'Reload' }).jqGrid('navButtonAdd', '#jqpPackageMaster', {
        caption: '<span class="fa fa-sync"></span> Refresh', buttonicon: "none", id: "custRefresh", position: "first", onClickButton: fnGridRefreshPackageMaster
        }).jqGrid('navButtonAdd', '#jqpPackageMaster', {
            caption: '<span class="fa fa-plus" data-toggle="modal"></span> Add', buttonicon: 'none', id: 'jqgAdd', position: 'first', onClickButton: fnAddPackageMaster
    });

    $(window).on("resize", function () {
        var $grid = $("#jqgPackageMaster"),
            newWidth = $grid.closest(".PackageMastercontainer").parent().width();
        $grid.jqGrid("setGridWidth", newWidth, true);
    });
    fnAddGridSerialNoHeading();
}

function fnAddPackageMaster() {
    _isInsert = true;
    fnClearFields();
    $('#PopupPackageMaster').modal('show');
    $("#chkActiveStatus").parent().addClass("is-checked");
    $('#PopupPackageMaster').find('.modal-title').text(localization.AddPackage);
    $("#btnSavePackageMaster").html('<i class="fa fa-save"></i>' + localization.Save);
    $("#chkActiveStatus").prop('disabled', true);
    $("#btnSavePackageMaster").show();
    $("#btndeActivePackageMaster").hide();
    $('#txtPackageId').val('');
}

function fnEditPackageMaster(e, actiontype) {
    var rowid = $(e.target).parents("tr.jqgrow").attr('id');
    var rowData = $('#jqgPackageMaster').jqGrid('getRowData', rowid);

    $('#PopupPackageMaster').modal('show');
    $('#txtPackageId').val(rowData.PackageId);
    $('#txtPackagedesc').val(rowData.PackageDesc);
    $('#txtNoofNights').val(rowData.NoOfNights);
    $('#txtCheckInWeekdays').val(rowData.CheckInWeekDays);
    $('#txtCheckInFromTime').val(rowData.CheckInFromTime);
    $('#txtCheckInToTime').val(rowData.CheckInToTime);
    $('#txtCheckOutFromTime').val(rowData.CheckOutFromTime);
    $('#txtCheckOutToTime').val(rowData.CheckOutToTime);
    if (rowData.ActiveStatus == 'true') {
        $("#chkActiveStatus").parent().addClass("is-checked");
    }
    else {
        $("#chkActiveStatus").parent().removeClass("is-checked");
    }
    $("#btnSavePackageMaster").attr("disabled", false);

    _isInsert = false;

    if (actiontype.trim() == "edit") {
        $('#PopupPackageMaster').find('.modal-title').text(localization.UpdatePackage);
        $("#btnSavePackageMaster").html('<i class="fa fa-sync"></i>' + localization.Update);
        $("#btndeActivePackageMaster").hide();
        $("#chkActiveStatus").prop('disabled', true);
        $("#btnSavePackageMaster").attr("disabled", false);
    }

    if (actiontype.trim() == "view") {
        $('#PopupPackageMaster').find('.modal-title').text(localization.ViewPackage);
        $("#btnSavePackageMaster").attr("disabled", false);
        $("input,textarea").attr('readonly', true);
        $("select").next().attr('disabled', true);
        $("#btnSavePackageMaster").hide();
        $("#btndeActivePackageMaster").hide();
        $("#chkActiveStatus").prop('disabled', true);
        $("#PopupPackageMaster").on('hidden.bs.modal', function () {
            $("#btnSavePackageMaster").show();
            $("input,textarea").attr('readonly', false);
            $("select").next().attr('disabled', false);
        });
    }
    if (actiontype.trim() == "delete") {
        $('#PopupPackageMaster').find('.modal-title').text("Activate/De Activate Package");
        $("#btnSavePackageMaster").attr("disabled", false);
        $("input,textarea").attr('readonly', true);
        $("select").next().attr('disabled', true);
        $("#btnSavePackageMaster").hide();

        if (rowData.ActiveStatus == 'true') {
            $("#btndeActivePackageMaster").html(localization.DActivate);
        }
        else {
            $("#btndeActivePackageMaster").html(localization.Activate);
        }

        $("#btndeActivePackageMaster").show();
        $("#chkActiveStatus").prop('disabled', true);
        $("#PopupPackageMaster").on('hidden.bs.modal', function () {
            $("#btnSavePackageMaster").show();
            $("input,textarea").attr('readonly', false);
            $("select").next().attr('disabled', false);
        });
    }
}

var _isInsert = true;
function fnSavePackageMaster() {
   
    if (IsStringNullorEmpty($("#txtPackagedesc").val())) {
        toastr.warning("Please Enter Package Description");
        return;
    }
    if (IsStringNullorEmpty($("#txtNoofNights").val())) {
        toastr.warning("Please Enter Number of Nights");
        return;
    }
    if (IsStringNullorEmpty($("#txtCheckInWeekdays").val())) {
        toastr.warning("Please Enter Check In Week days");
        return;
    }
    if (IsStringNullorEmpty($("#txtCheckInFromTime").val())) {
        toastr.warning("Please Enter Check In From Time");
        return;
    }
    if (IsStringNullorEmpty($("#txtCheckInToTime").val())) {
        toastr.warning("Please Enter Check In To Time");
        return;
    }

    //if ($('#txtCheckInFromTime').val() >= $('#txtCheckInToTime').val()) {
    //    toastr.warning("Check In From Time can't be more than or equal to Check In To Time.");
    //    $('#txtCheckInToTime').focus();
    //    return;
    //}

    var CheckInFromstartTime = $('#txtCheckInFromTime').val();
    var CheckInToendTime = $('#txtCheckInToTime').val();

    var startDate = new Date("1/1/1900 " + CheckInFromstartTime);
    var endDate = new Date("1/1/1900 " + CheckInToendTime);

    if (startDate >= endDate) {
        toastr.warning("Check In From Time can't be more than or equal to Check In To Time.");
        $('#txtCheckInToTime').focus();
        return;
    }

    if (IsStringNullorEmpty($("#txtCheckOutFromTime").val())) {
        toastr.warning("Please Enter Check Out From Time");
        return;
    }
    if (IsStringNullorEmpty($("#txtCheckOutToTime").val())) {
        toastr.warning("Please Enter Check Out To Time");
        return;
    }

    var CheckOutFromstartTime = $('#txtCheckOutFromTime').val();
    var CheckOutToendTime = $('#txtCheckOutToTime').val();

    var CheckOutstartDate = new Date("1/1/1900 " + CheckOutFromstartTime);
    var CheckOutendDate = new Date("1/1/1900 " + CheckOutToendTime);

    if (CheckOutstartDate >= CheckOutendDate) {
        toastr.warning("Check Out From Time can't be more than or equal to Check Out To Time.");
        $('#txtCheckOutToTime').focus();
        return;
    }
    //if ($('#txtCheckOutFromTime').val() >= $('#txtCheckOutToTime').val()) {
    //    toastr.warning("Check Out From Time can't be more than or equal to Check Out To Time.");
    //    $('#txtCheckOutToTime').focus();
    //    return;
    //}
    packg = {
        PackageId: $("#txtPackageId").val() === '' ? 0 : $("#txtPackageId").val(),
        PackageDesc: $("#txtPackagedesc").val(),
        NoOfNights: $("#txtNoofNights").val(),
        CheckInWeekDays: $("#txtCheckInWeekdays").val(),
        CheckInFromTime: $("#txtCheckInFromTime").val(),
        CheckInToTime: $("#txtCheckInToTime").val(),
        CheckOutFromTime: $("#txtCheckOutFromTime").val(),
        CheckOutToTime: $("#txtCheckOutToTime").val(),
        ActiveStatus: $("#chkActiveStatus").parent().hasClass("is-checked")
    };

    $("#btnSavePackageMaster").attr("disabled", true);

    $.ajax({
        url: getBaseURL() + '/PackageMaster/InsertOrUpdatePackageMaster',
        type: 'POST',
        datatype: 'json',
        data: { isInsert: _isInsert, obj: packg },
        success: function (response) {
            if (response.Status) {
                toastr.success(response.Message);
                $("#btnSavePackageMaster").html('<i class="fa fa-spinner fa-spin"></i> wait');
                $("#PopupPackageMaster").modal('hide');
                fnClearFields();
                fnGridRefreshPackageMaster();
            }
            else {
                toastr.error(response.Message);
                $("#btnSavePackageMaster").attr("disabled", false);
            }
        },
        error: function (error) {
            toastr.error(error.statusText);
            $("#btnSavePackageMaster").attr("disabled", false);
        }
    });
}

function fnGridRefreshPackageMaster() {
    $("#jqgPackageMaster").setGridParam({ datatype: 'json', page: 1 }).trigger('reloadGrid');
}

function fnClearFields() {
    $("#txtPackageId").val('');
    $("#txtPackagedesc").val('');
    $("#txtNoofNights").val('');
    $("#txtCheckInWeekdays").val('');
    $("#txtCheckInFromTime").val('');
    $('#txtCheckInToTime').val('');
    $("#txtCheckOutFromTime").val('');
    $("#txtCheckOutToTime").val('');
    $("#chkActiveStatus").prop('disabled', false);
    $("#btnSavePackageMaster").attr("disabled", false);
    $("#btndeActivePackageMaster").attr("disabled", false);
}

$("#btnCancelPackageMaster").click(function () {
    $("#jqgPackageMaster").jqGrid('resetSelection');
    $('#PopupPackageMaster').modal('hide');
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

function fnDeletePackageMaster() {

    var a_status;
    //Activate or De Activate the status
    if ($("#chkActiveStatus").parent().hasClass("is-checked") === true) {
        a_status = false
    }
    else {
        a_status = true;
    }
    $("#btndeActivePackageMaster").attr("disabled", true);
    $.ajax({
        url: getBaseURL() + '/PackageMaster/ActiveOrDeActivePackageMaster?status=' + a_status + '&packageId=' + $("#txtPackageId").val(),
        type: 'POST',
        success: function (response) {
            if (response.Status) {
                toastr.success(response.Message);
                $("#btndeActivePackageMaster").html('<i class="fa fa-spinner fa-spin"></i> wait');
                $("#PopupPackageMaster").modal('hide');
                fnClearFields();
                fnGridRefreshPackageMaster();
                $("#btndeActivePackageMaster").attr("disabled", false);
            }
            else {
                toastr.error(response.Message);
                $("#btndeActivePackageMaster").attr("disabled", false);
                $("#btndeActivePackageMaster").html('De Activate');
            }
        },
        error: function (error) {
            toastr.error(error.statusText);
            $("#btndeActivePackageMaster").attr("disabled", false);
            $("#btndeActivePackageMaster").html('De Activate');
        }
    });
}