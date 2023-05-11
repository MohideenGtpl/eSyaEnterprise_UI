$(function () {
    fnGridLoadCounterMapping();
});

var _isInsert = true;

function fnBusinessLocation_onChange() {

    fnGridLoadCounterMapping();
}
function fnGridLoadCounterMapping() {

    $("#jqgCounterMapping").GridUnload();

    $("#jqgCounterMapping").jqGrid({
        url: getBaseURL() + '/Configure/GetCounterMappingbyBusinessKey?businesskey=' + $("#cboBusinessLocation").val(),
        datatype: 'json',
        mtype: 'POST',
        contentType: 'application/json; charset=utf-8',
        ajaxGridOptions: { contentType: 'application/json; charset=utf-8' },
        colNames: [localization.BusinessKey, localization.TokenType, localization.TokenDescription, localization.CounterNumber, localization.Active, localization.Actions],
        colModel: [
            { name: "BusinessKey", width: 50, align: 'left', editable: true, editoptions: { maxlength: 15 }, resizable: false, hidden: true },
            { name: "TokenType", width: 50, align: 'left', editable: true, editoptions: { maxlength: 15 }, resizable: false, hidden: true },
            { name: "TokenDesc", width: 120, align: 'left', editable: true, editoptions: { maxlength: 6 }, resizable: false, hidden: false },
            { name: "CounterNumber", width: 80, align: 'left', editable: true, editoptions: { maxlength: 6 }, resizable: false, hidden: false },
            { name: "ActiveStatus", width: 35, editable: true, align: 'center', edittype: "checkbox", formatter: 'checkbox', editoptions: { value: "true:false" } },
            {
                name: 'edit', search: false, align: 'left', width: 70, sortable: false, resizable: false,
                formatter: function (cellValue, options, rowdata, action) {
                    return '<button class="btn-xs ui-button ui-widget ui-corner-all btn-jqgrid" title="Edit" id="jqgEdit" onclick="return fnEditCounterMapping(event,\'edit\');"><i class="fas fa-pen"></i> ' + localization.Edit + '</button>' +
                        '<button class="btn-xs ui-button ui-widget ui-corner-all btn-jqgrid" title="View" id="jqgView" onclick="return fnEditCounterMapping(event,\'view\');"><i class="far fa-eye"></i>' + localization.View + '</button>'
                        //+ '<button class="btn-xs ui-button ui-widget ui-corner-all btn-jqgrid" title="Delete" id="jqgDelete" onclick="return fnEditCounterMapping(event,\'delete\');"><i class="fas fa-trash"></i>' + localization.Delete + '</button>'
                }
            },
        ],
        pager: "#jqpCounterMapping",
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
            SetGridControlByAction(); fnJqgridSmallScreen("jqpCounterMapping");
        },
    }).jqGrid('navGrid', '#jqpCounterMapping', { add: false, edit: false, search: false, del: false, refresh: false, refreshtext: 'Reload' }).jqGrid('navButtonAdd', '#jqpCounterMapping', {
        caption: '<span class="fa fa-sync"></span> Refresh', buttonicon: "none", id: "custRefresh", position: "first", onClickButton: fnGridRefreshCounterMapping
        }).jqGrid('navButtonAdd', '#jqpCounterMapping', {
            caption: '<span class="fa fa-plus" data-toggle="modal"></span> Add', buttonicon: 'none', id: 'jqgAdd', position: 'first', onClickButton: fnAddCounterMapping
    });

    $(window).on("resize", function () {
        var $grid = $("#jqgCounterMapping"),
            newWidth = $grid.closest(".ui-jqgrid").parent().width();
        $grid.jqGrid("setGridWidth", newWidth, true);
    });
    fnAddGridSerialNoHeading();
}

function fnAddCounterMapping() {
    if (IsStringNullorEmpty($("#cboBusinessLocation").val()) || $("#cboBusinessLocation").val() === "0") {
        toastr.warning("Please select Business key to Add");
        return;
    }
    else {
        $('#PopupCounterMapping').modal('show');
        $('#PopupCounterMapping').modal({ backdrop: 'static', keyboard: false });
        $('#PopupCounterMapping').find('.modal-title').text(localization.AddCounterMapping);
        $("#chkActiveStatus").parent().addClass("is-checked");
        fnClearFields();
        $("#chkActiveStatus").prop('disabled', true);
        $("#btnSaveCounterMapping").html('<i class="fa fa-save"></i>' + localization.Save);
        $("#btnSaveCounterMapping").show();
        _isInsert = true;

    }
}


function fnEditCounterMapping(e, actiontype) {

    var rowid = $(e.target).parents("tr.jqgrow").attr('id');
    var rowData = $('#jqgCounterMapping').jqGrid('getRowData', rowid);

    _isInsert = false;

    $('#PopupCounterMapping').modal('show');
    $('#cboTokentype').val(rowData.TokenType).selectpicker('refresh');
    $("#cboTokentype").next().attr('disabled', true);
    $('#txtCounterNumber').val(rowData.CounterNumber);
    $("#txtCounterNumber").attr('readonly', true);
   
    if (rowData.ActiveStatus == 'true') {
        $("#chkActiveStatus").parent().addClass("is-checked");
    }
    else {
        $("#chkActiveStatus").parent().removeClass("is-checked");
    }
    $("#btnSaveCounterMapping").attr("disabled", false);


    if (actiontype.trim() == "edit") {
        $('#PopupCounterMapping').find('.modal-title').text(localization.EditCounterMapping);
        $("#btnSaveCounterMapping").html('<i class="fa fa-sync"></i>' + localization.Update);
        $("#chkActiveStatus").prop('disabled', false);
        $("#btnSaveCounterMapping").attr("disabled", false);
    }

    if (actiontype.trim() == "view") {
        $('#PopupCounterMapping').find('.modal-title').text(localization.ViewCounterMapping);
        $("#btnSaveCounterMapping").attr("disabled", false);
        $("input,textarea").attr('readonly', true);
        $("select").next().attr('disabled', true);
        $("#btnSaveCounterMapping").hide();
        $("#chkActiveStatus").prop('disabled', true);
        $("#PopupCounterMapping").on('hidden.bs.modal', function () {
            $("#btnSaveCounterMapping").show();
            $("input,textarea").attr('readonly', false);
            $("select").next().attr('disabled', false);
        });
    }
   
}

function fnGridRefreshCounterMapping() {
    $("#jqgCounterMapping").setGridParam({ datatype: 'json', page: 1 }).trigger('reloadGrid');
}

$("#btnCancelCounterMapping").click(function () {
    $("#jqgCounterMapping").jqGrid('resetSelection');
    $('#PopupCounterMapping').modal('hide');
    fnClearFields();
});

function fnClearFields() {
    $('#cboTokentype').val('0').selectpicker('refresh');
    $("#cboTokentype").next().attr('disabled', false);
    $("#txtCounterNumber").val('');
    $("#txtCounterNumber").attr('readonly', false);
    $("#chkActiveStatus").prop('disabled', false);
    $("#btnSaveCounterMapping").attr("disabled", false);
}


function fnSaveCounterMapping() {
    if (IsStringNullorEmpty($("#cboBusinessLocation").val()) || $("#cboBusinessLocation").val() === "0") {
        toastr.warning("Please select Business key");
        return;
    }
    if (IsStringNullorEmpty($("#cboTokentype").val()) || $("#cboTokentype").val() === "0") {
        toastr.warning("Please select Token Type");
        return;
    }
    if (IsStringNullorEmpty($("#txtCounterNumber").val())) {
        toastr.warning("Please Enter Counter Number");
        return;
    }
    
    obj_gen = {
        BusinessKey: $("#cboBusinessLocation").val(),
        TokenType: $("#cboTokentype").val(),
        CounterNumber: $("#txtCounterNumber").val(),
        ActiveStatus: $("#chkActiveStatus").parent().hasClass("is-checked")
    };

    $("#btnSaveCounterMapping").attr("disabled", true);

    $.ajax({
        url: getBaseURL() + '/Configure/InsertOrUpdateCounterMapping',
        type: 'POST',
        datatype: 'json',
        data: { isInsert: _isInsert, obj: obj_gen },
        success: function (response) {
            if (response.Status) {

                toastr.success(response.Message);
                $("#btnSaveCounterMapping").html('<i class="fa fa-spinner fa-spin"></i> wait');
                $("#PopupCounterMapping").modal('hide');
                fnClearFields();
                fnGridRefreshCounterMapping();
            }
            else {
                toastr.error(response.Message);
                $("#btnSaveCounterMapping").attr("disabled", false);
            }
        },
        error: function (error) {
            toastr.error(error.statusText);
            $("#btnSaveCounterMapping").attr("disabled", false);
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

