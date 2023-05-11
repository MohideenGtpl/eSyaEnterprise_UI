$(function () {
    fnGridLoadPaymentMode();
});
var actiontype = "";

function fnGridLoadPaymentMode() {

    $("#jqgPaymentMode").GridUnload();

    $("#jqgPaymentMode").jqGrid({
        url: getBaseURL() + '/Voucher/GetPaymentModes',
        datatype: 'json',
        mtype: 'POST',
        contentType: 'application/json; charset=utf-8',
        ajaxGridOptions: { contentType: 'application/json; charset=utf-8' },
        colNames: [localization.PaymentId, "", localization.PaymentMode, "", localization.PaymentModecategory,localization.Active, localization.Actions],
        colModel: [
            { name: "PaymentId", width: 50, align: 'left', editable: true, editoptions: { maxlength: 15 }, resizable: false, hidden: true },
            { name: "PaymentModeId", width: 50, align: 'left', editable: true, editoptions: { maxlength: 15 }, resizable: false, hidden: true },
            { name: "PaymentMode", width: 180, align: 'left', editable: true, editoptions: { maxlength: 50 }, resizable: false },
            { name: "PaymentModeCategoryId", width: 50, align: 'left', editable: true, editoptions: { maxlength: 6 }, resizable: false, hidden: true },
            { name: "PaymentCategory", width: 180, align: 'left', editable: true, editoptions: { maxlength: 50 }, resizable: false },

            { name: "ActiveStatus", width: 35, editable: true, align: 'center', edittype: "checkbox", formatter: 'checkbox', editoptions: { value: "true:false" } },
           
            {
                name: 'edit', search: false, align: 'left', width: 100, sortable: false, resizable: false,
                formatter: function (cellValue, options, rowdata, action) {

                    return '<button class="btn-xs ui-button ui-widget ui-corner-all btn-jqgrid" title="Edit" id="jqgEdit" onclick="return fnEditPaymentMode(event,\'edit\')"><i class="fas fa-pen"></i> ' + localization.Edit + '</button>' +
                        '<button class="btn-xs ui-button ui-widget ui-corner-all btn-jqgrid" title="View" id="jqgView" onclick="return fnEditPaymentMode(event,\'view\')"><i class="far fa-eye"></i> ' + localization.View + '</button>' +
                        '<button class="btn-xs ui-button ui-widget ui-corner-all btn-jqgrid" title = "Delete" id="jqgDelete" onclick = "return fnEditPaymentMode(event,\'delete\')" > <i class="fas fa-trash"></i>' + localization.Delete + '</button>'
                }
            },
        ],

        pager: "#jqpPaymentMode",
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
        forceFit: true, caption:'Payment Mode',
        loadComplete: function (data) {
            SetGridControlByAction(); fnJqgridSmallScreen("jqpPaymentMode");
        },

    }).jqGrid('navGrid', '#jqpPaymentMode', { add: false, edit: false, search: false, del: false, refresh: false, refreshtext: 'Reload' }).jqGrid('navButtonAdd', '#jqpPaymentMode', {
        caption: '<span class="fa fa-sync"></span> Refresh', buttonicon: "none", id: "custRefresh", position: "first", onClickButton: fnGridRefreshPaymentMode
        }).jqGrid('navButtonAdd', '#jqpPaymentMode', {
            caption: '<span class="fa fa-plus" data-toggle="modal"></span> Add', buttonicon: 'none', id: 'jqgAdd', position: 'first', onClickButton: fnAddPaymentMode
    });

    $(window).on("resize", function () {
        var $grid = $("#jqgPaymentMode"),
            newWidth = $grid.closest(".ui-jqgrid").parent().width();
        $grid.jqGrid("setGridWidth", newWidth, true);
    });
    fnAddGridSerialNoHeading();
}

function fnAddPaymentMode() {

    _isInsert = true;
    fnClearFields();
    $('#PopupPaymentMode').modal('show');
    $("#chkActiveStatus").parent().addClass("is-checked");
    $('#PopupPaymentMode').find('.modal-title').text(localization.AddPaymentMode);
    $("#btnSavePaymentMode").html('<i class="fa fa-save"></i>' + localization.Save);
    $("#chkActiveStatus").prop('disabled', true);
    $("#btnSavePaymentMode").show();
    $("#btnDeactivatePaymentMode").hide();
    $("#cboPaymentModeId").val("0").selectpicker('refresh');
    $("#cboPaymentModeId").attr('disabled', false);
    $("#cboPaymentModecategoryId").val("0").selectpicker('refresh');
    $("#cboPaymentModecategoryId").attr('disabled', false);
    $("#txtPaymentId").val('');
    $("#txtPaymentId").attr('disabled', false);
    $("#btnSavePaymentMode").attr("disabled", false);

}

function fnEditPaymentMode(e, actiontype) {
    var rowid = $(e.target).parents("tr.jqgrow").attr('id');
    var rowData = $('#jqgPaymentMode').jqGrid('getRowData', rowid);

    $("#txtPaymentId").val(rowData.PaymentId);
    $("#txtPaymentId").attr('disabled', true);
    $("#cboPaymentModeId").val(rowData.PaymentModeId).selectpicker('refresh');
    $("#cboPaymentModeId").attr('disabled', true);
    $("#cboPaymentModecategoryId").val(rowData.PaymentModeCategoryId).selectpicker('refresh');
    $("#cboPaymentModecategoryId").attr('disabled', true);

    if (rowData.ActiveStatus == 'true') {
        $("#chkActiveStatus").parent().addClass("is-checked");
    }
    else {
        $("#chkActiveStatus").parent().removeClass("is-checked");
    }
    $("#btnSavePaymentMode").attr("disabled", false);
    $('#PopupPaymentMode').modal('show');
    _isInsert = false;

    if (actiontype.trim() == "edit") {
        $('#PopupPaymentMode').find('.modal-title').text(localization.UpdatePaymentMode);
        $("#btnSavePaymentMode").html(localization.Update);
        $("#btnSavePaymentMode").attr('disabled', false);
        $("#btnSavePaymentMode").show();
        $("#btnDeactivatePaymentMode").hide();
        $("#chkActiveStatus").prop('disabled', false);
    }
   

    if (actiontype.trim() == "view") {
        $('#PopupPaymentMode').find('.modal-title').text(localization.ViewPaymentMode);
        $("#btnSavePaymentMode").attr("disabled", false);
        $("input,textarea").attr('readonly', true);
        $("select").next().attr('disabled', true);
        $("#btnSavePaymentMode").hide();
        $("#btnDeactivatePaymentMode").hide();
        $("#chkActiveStatus").prop('disabled', true);
        $("#PopupPaymentMode").on('hidden.bs.modal', function () {
            $("#btnSavePaymentMode").show();
            $("input,textarea").attr('readonly', false);
            $("select").next().attr('disabled', false);
        });
    }
    if (actiontype.trim() == "delete") {
        $('#PopupPaymentMode').find('.modal-title').text(localization.DeletePaymentMode);
        $("#btnSavePaymentMode").attr("disabled", false);
        $("input,textarea").attr('readonly', true);
        $("select").next().attr('disabled', true);
        $("#btnSavePaymentMode").hide();
        $("#btnDeactivatePaymentMode").html(localization.Delete);
        $("#btnDeactivatePaymentMode").show();
        $("#chkActiveStatus").prop('disabled', true);
        $("#PopupPaymentMode").on('hidden.bs.modal', function () {
            $("#btnSavePaymentMode").show();
            $("input,textarea").attr('readonly', false);
            $("select").next().attr('disabled', false);
        });
    }
}
function fnClearFields() {
    $("#txtPaymentId").val('');
    $("#cboPaymentModeId").val("0").selectpicker('refresh');
    $("#cboPaymentModeId").attr('disabled', false);
    $("#cboPaymentModecategoryId").val("0").selectpicker('refresh');
    $("#cboPaymentModecategoryId").attr('disabled', false);
    $("#chkActiveStatus").prop('disabled', true);
    $("#btnSavePaymentMode").attr("disabled", false);
    $("#btnDeactivatePaymentMode").attr("disabled", false);
}

$("#btnCancelPaymentMode").click(function () {
    $("#jqgPaymentMode").jqGrid('resetSelection');
    $('#PopupPaymentMode').modal('hide');
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

function fnGridRefreshPaymentMode() {
    $("#jqgPaymentMode").setGridParam({ datatype: 'json', page: 1 }).trigger('reloadGrid');
}

function fnSavePaymentMode() {
    if (IsStringNullorEmpty($("#txtPaymentId").val())) {
        toastr.warning("Please Enter Payment Id");
        return;
    }
    if (IsStringNullorEmpty($("#cboPaymentModeId").val()) || $("#cboPaymentModeId").val() === "0") {
        toastr.warning("Please select Payment Mode");
        return;
    }
    if (IsStringNullorEmpty($("#cboPaymentModecategoryId").val()) || $("#cboPaymentModecategoryId").val() === "0") {
        toastr.warning("Please select Payment Mode category");
        return;
    }
    obj = {
        PaymentId: $("#txtPaymentId").val(),
        PaymentModeId: $("#cboPaymentModeId").val(),
        PaymentModeCategoryId: $("#cboPaymentModecategoryId").val(),
        ActiveStatus: $("#chkActiveStatus").parent().hasClass("is-checked")
    };

    $("#btnSavePaymentMode").attr("disabled", true);

    $.ajax({
        url: getBaseURL() + '/Voucher/InsertOrUpdatePaymentMode',
        type: 'POST',
        datatype: 'json',
        data: {obj},
        success: function (response) {
            if (response.Status) {
                toastr.success(response.Message);
                $("#btnSavePaymentMode").html('<i class="fa fa-spinner fa-spin"></i> wait');
                $("#PopupPaymentMode").modal('hide');
                fnClearFields();
                fnGridRefreshPaymentMode();
            }
            else {
                toastr.error(response.Message);
                $("#btnSavePaymentMode").attr("disabled", false);
            }
        },
        error: function (error) {
            toastr.error(error.statusText);
            $("#btnSavePaymentMode").attr("disabled", false);
        }
    });
}

function fnDeletePaymentMode() {
    var a_status;
    //Activate or De Activate the status
    if ($("#chkActiveStatus").parent().hasClass("is-checked") === true) {
        a_status = false
    }
    else {
        a_status = true;
    }

    objdel = {
        PaymentId: $("#txtPaymentId").val(),
        PaymentModeId: $("#cboPaymentModeId").val(),
        PaymentModeCategoryId: $("#cboPaymentModecategoryId").val(),
        ActiveStatus: $("#chkActiveStatus").parent().hasClass("is-checked"),
        a_status: a_status,
    };
    $("#btnDeactivatePaymentMode").attr("disabled", true);
    $.ajax({
        url: getBaseURL() + '/Voucher/ActiveOrDeActivePaymentMode',
        type: 'POST',
        datatype: 'json',
        data: { obj: objdel},
        success: function (response) {
            if (response.Status) {
                toastr.success(response.Message);
                $("#btnDeactivatePaymentMode").html('<i class="fa fa-spinner fa-spin"></i> wait');
                $("#PopupPaymentMode").modal('hide');
                fnClearFields();
                fnGridRefreshPaymentMode();
                $("#btnDeactivatePaymentMode").attr("disabled", false);
            }
            else {
                toastr.error(response.Message);
                $("#btnDeactivatePaymentMode").attr("disabled", false);
                $("#btnDeactivatePaymentMode").html('Delete');
            }
        },
        error: function (error) {
            toastr.error(error.statusText);
            $("#btnDeactivatePaymentMode").attr("disabled", false);
            $("#btnDeactivatePaymentMode").html('Delete');
        }
    });
}