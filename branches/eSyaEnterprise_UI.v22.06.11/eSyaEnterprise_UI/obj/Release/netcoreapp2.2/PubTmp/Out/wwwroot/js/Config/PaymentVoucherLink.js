$(function () {
    fnGridLoadPaymentVoucherLink();
});
var actiontype = "";

function fnGridLoadPaymentVoucherLink() {

    $("#jqgPaymentVoucherLink").GridUnload();

    $("#jqgPaymentVoucherLink").jqGrid({
        url: getBaseURL() + '/Voucher/GetPaymentLinkedVouchers',
        datatype: 'json',
        mtype: 'POST',
        contentType: 'application/json; charset=utf-8',
        ajaxGridOptions: { contentType: 'application/json; charset=utf-8' },
        colNames: [localization.PaymentId, localization.PaymentMode, localization.VoucherId, localization.Voucher, localization.Active, localization.Actions],
        colModel: [
            { name: "PaymentId", width: 50, align: 'left', editable: true, editoptions: { maxlength: 15 }, resizable: false, hidden: true },
            { name: "PaymentMode", width: 180, align: 'left', editable: true, editoptions: { maxlength: 50 }, resizable: false },
            { name: "VoucherId", width: 50, align: 'left', editable: true, editoptions: { maxlength: 6 }, resizable: false, hidden: true },
            { name: "Voucher", width: 180, align: 'left', editable: true, editoptions: { maxlength: 50 }, resizable: false },

            { name: "ActiveStatus", width: 35, editable: true, align: 'center', edittype: "checkbox", formatter: 'checkbox', editoptions: { value: "true:false" } },

            {
                name: 'edit', search: false, align: 'left', width: 100, sortable: false, resizable: false,
                formatter: function (cellValue, options, rowdata, action) {

                    return '<button class="btn-xs ui-button ui-widget ui-corner-all btn-jqgrid" title="Edit" id="jqgEdit" onclick="return fnEditPaymentVucherLink(event,\'edit\')"><i class="fas fa-pen"></i> ' + localization.Edit + '</button>' +
                        '<button class="btn-xs ui-button ui-widget ui-corner-all btn-jqgrid" title="View" id="jqgView" onclick="return fnEditPaymentVucherLink(event,\'view\')"><i class="far fa-eye"></i> ' + localization.View + '</button>' +
                        '<button class="btn-xs ui-button ui-widget ui-corner-all btn-jqgrid" title = "Delete" id="jqgDelete" onclick = "return fnEditPaymentVucherLink(event,\'delete\')" > <i class="fas fa-trash"></i>' + localization.Delete + '</button>'
                }
            },
        ],

        pager: "#jqpPaymentVoucherLink",
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
            SetGridControlByAction(); fnJqgridSmallScreen("jqpPaymentVoucherLink");
        },

    }).jqGrid('navGrid', '#jqpPaymentVoucherLink', { add: false, edit: false, search: false, del: false, refresh: false, refreshtext: 'Reload' }).jqGrid('navButtonAdd', '#jqpPaymentVoucherLink', {
        caption: '<span class="fa fa-sync"></span> Refresh', buttonicon: "none", id: "custRefresh", position: "first", onClickButton: fnGridRefreshPaymentVoucherLink
        }).jqGrid('navButtonAdd', '#jqpPaymentVoucherLink', {
            caption: '<span class="fa fa-plus" data-toggle="modal"></span> Add', buttonicon: 'none', id: 'jqgAdd', position: 'first', onClickButton: fnAddPaymentVoucherLink
    });

    $(window).on("resize", function () {
        var $grid = $("#jqgPaymentVoucherLink"),
            newWidth = $grid.closest(".ui-jqgrid").parent().width();
        $grid.jqGrid("setGridWidth", newWidth, true);
    });
    fnAddGridSerialNoHeading();
}

function fnAddPaymentVoucherLink() {

    _isInsert = true;
    fnClearFields();
    $('#PopupPaymentVoucherLink').modal('show');
    $("#chkActiveStatus").parent().addClass("is-checked");
    $('#PopupPaymentVoucherLink').find('.modal-title').text(localization.AddPaymentVoucherLink);
    $("#btnSavePaymentVoucherLink").html('<i class="fa fa-save"></i>' + localization.Save);
    $("#chkActiveStatus").prop('disabled', true);
    $("#btnSavePaymentVoucherLink").show();
    $("#btnDeactivatePaymentVoucherLink").hide();
    $("#cboPayment").val("0").selectpicker('refresh');
    $("#cboPayment").attr('disabled', false);
    $("#cboVoucher").val("0").selectpicker('refresh');
    $("#cboVoucher").attr('disabled', false);
    $("#btnSavePaymentVoucherLink").attr("disabled", false);

}

function fnEditPaymentVucherLink(e, actiontype) {
    var rowid = $(e.target).parents("tr.jqgrow").attr('id');
    var rowData = $('#jqgPaymentVoucherLink').jqGrid('getRowData', rowid);

    $("#cboPayment").val(rowData.PaymentId).selectpicker('refresh');
    $("#cboPayment").attr('disabled', true);
    $("#cboVoucher").val(rowData.VoucherId).selectpicker('refresh');
    $("#cboVoucher").attr('disabled', true);

    if (rowData.ActiveStatus == 'true') {
        $("#chkActiveStatus").parent().addClass("is-checked");
    }
    else {
        $("#chkActiveStatus").parent().removeClass("is-checked");
    }
    $("#btnSavePaymentVoucherLink").attr("disabled", false);
    $('#PopupPaymentVoucherLink').modal('show');
    _isInsert = false;

    if (actiontype.trim() == "edit") {
        $('#PopupPaymentVoucherLink').find('.modal-title').text(localization.UpdatePaymentVoucherLink);
        $("#btnSavePaymentVoucherLink").html(localization.Update);
        $("#btnSavePaymentVoucherLink").attr('disabled', false);
        $("#btnSavePaymentVoucherLink").show();
        $("#btnDeactivatePaymentVoucherLink").hide();
        $("#chkActiveStatus").prop('disabled', false);
    }


    if (actiontype.trim() == "view") {
        $('#PopupPaymentVoucherLink').find('.modal-title').text(localization.ViewPaymentVoucherLink);
        $("#btnSavePaymentVoucherLink").attr("disabled", false);
        $("input,textarea").attr('readonly', true);
        $("select").next().attr('disabled', true);
        $("#btnSavePaymentVoucherLink").hide();
        $("#btnDeactivatePaymentVoucherLink").hide();
        $("#chkActiveStatus").prop('disabled', true);
        $("#PopupPaymentVoucherLink").on('hidden.bs.modal', function () {
            $("#btnSavePaymentVoucherLink").show();
            $("input,textarea").attr('readonly', false);
            $("select").next().attr('disabled', false);
        });
    }
    if (actiontype.trim() == "delete") {
        $('#PopupPaymentVoucherLink').find('.modal-title').text(localization.DeletePaymentVoucherLink);
        $("#btnSavePaymentVoucherLink").attr("disabled", false);
        $("input,textarea").attr('readonly', true);
        $("select").next().attr('disabled', true);
        $("#btnSavePaymentVoucherLink").hide();
        $("#btnDeactivatePaymentVoucherLink").html(localization.Delete);
        $("#btnDeactivatePaymentVoucherLink").show();
        $("#chkActiveStatus").prop('disabled', true);
        $("#PopupPaymentVoucherLink").on('hidden.bs.modal', function () {
            $("#btnSavePaymentVoucherLink").show();
            $("input,textarea").attr('readonly', false);
            $("select").next().attr('disabled', false);
        });
    }
}
function fnClearFields() {
   
    $("#cboPayment").val("0").selectpicker('refresh');
    $("#cboPayment").attr('disabled', false);
    $("#cboVoucher").val("0").selectpicker('refresh');
    $("#cboVoucher").attr('disabled', false);
    $("#chkActiveStatus").prop('disabled', true);
    $("#btnSavePaymentVoucherLink").attr("disabled", false);
    $("#btnDeactivatePaymentVoucherLink").attr("disabled", false);
} 

$("#btnCancelPaymentVoucherLink").click(function () {
    $("#jqgPaymentVoucherLink").jqGrid('resetSelection');
    $('#PopupPaymentVoucherLink').modal('hide');
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

function fnGridRefreshPaymentVoucherLink() {
    $("#jqgPaymentVoucherLink").setGridParam({ datatype: 'json', page: 1 }).trigger('reloadGrid');
}

function fnSavePaymentVoucherLink() {
   
    if (IsStringNullorEmpty($("#cboPayment").val()) || $("#cboPayment").val() === "0") {
        toastr.warning("Please select Payment");
        return;
    }
    if (IsStringNullorEmpty($("#cboVoucher").val()) || $("#cboVoucher").val() === "0") {
        toastr.warning("Please select Voucher");
        return;
    }
    obj = {
        PaymentId: $("#cboPayment").val(),
        VoucherId: $("#cboVoucher").val(),
        ActiveStatus: $("#chkActiveStatus").parent().hasClass("is-checked")
    };

    $("#btnSavePaymentVoucherLink").attr("disabled", true);

    $.ajax({
        url: getBaseURL() + '/Voucher/InsertOrUpdatePaymentVoucherLink',
        type: 'POST',
        datatype: 'json',
        data: { obj },
        success: function (response) {
            if (response.Status) {
                toastr.success(response.Message);
                $("#btnSavePaymentVoucherLink").html('<i class="fa fa-spinner fa-spin"></i> wait');
                $("#PopupPaymentVoucherLink").modal('hide');
                fnClearFields();
                fnGridRefreshPaymentVoucherLink();
            }
            else {
                toastr.error(response.Message);
                $("#btnSavePaymentVoucherLink").attr("disabled", false);
            }
        },
        error: function (error) {
            toastr.error(error.statusText);
            $("#btnSavePaymentVoucherLink").attr("disabled", false);
        }
    });
}

function fnDeletePaymentVoucherLink() {
   
    $("#btnDeactivatePaymentVoucherLink").attr("disabled", true);
    $.ajax({
        url: getBaseURL() + '/Voucher/DeletePaymentLinkedVoucher?voucherId=' + $("#cboVoucher").val() + '&paymentId=' + $("#cboPayment").val(),
        type: 'POST',

        success: function (response) {
            if (response.Status) {
                toastr.success(response.Message);
                $("#btnDeactivatePaymentVoucherLink").html('<i class="fa fa-spinner fa-spin"></i> wait');
                $("#PopupPaymentVoucherLink").modal('hide');
                fnClearFields();
                fnGridRefreshPaymentVoucherLink();
                $("#btnDeactivatePaymentVoucherLink").attr("disabled", false);
            }
            else {
                toastr.error(response.Message);
                $("#btnDeactivatePaymentVoucherLink").attr("disabled", false);
                $("#btnDeactivatePaymentVoucherLink").html('Delete');
            }
        },
        error: function (error) {
            toastr.error(error.statusText);
            $("#btnDeactivatePaymentVoucherLink").attr("disabled", false);
            $("#btnDeactivatePaymentVoucherLink").html('Delete');
        }
    });
}