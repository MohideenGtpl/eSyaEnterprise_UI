$(function () {
    fnGridLoadDocumentControlNormal();
});

var _isInsert = true;



function fnBusinessLocation_onChange() {

    fnGridLoadDocumentControlNormal();
}
function fnGridLoadDocumentControlNormal() {

    $("#jqgDocumentControlNormal").GridUnload();

    $("#jqgDocumentControlNormal").jqGrid({
        url: getBaseURL() + '/Standard/GetDocumentControlNormalModebyBusinessKey?businesskey=' + $("#cboBusinessLocation").val(),
        datatype: 'json',
        mtype: 'POST',
        contentType: 'application/json; charset=utf-8',
        ajaxGridOptions: { contentType: 'application/json; charset=utf-8' },
        colNames: [localization.Businesskey, localization.DocumentId, localization.finYear,  localization.DocumentName, localization.StartDocNumber, localization.CurrentDocNumber, localization.CurrentDocDate, localization.Active, localization.Actions],
        colModel: [
            { name: "BusinessKey", width: 50, align: 'left', editable: true, editoptions: { maxlength: 15 }, resizable: false, hidden: true },
            { name: "DocumentId", width: 50, align: 'left', editable: true, editoptions: { maxlength: 15 }, resizable: false, hidden: true },
            { name: "FinancialYear", width: 40, align: 'left', editable: true, editoptions: { maxlength: 6 }, resizable: false, hidden: false },
            { name: "DocumentName", width: 70, align: 'left', editable: true, editoptions: { maxlength: 6 }, resizable: false, hidden: false },
            { name: "StartDocNumber", width: 50, align: 'left', editable: true, editoptions: { maxlength: 6 }, resizable: false, hidden: false },
            { name: "CurrentDocNumber", width: 50, align: 'left', editable: true, editoptions: { maxlength: 6 }, resizable: false, hidden: false },
            
            {
                name: 'CurrentDocDate', index: 'FromDate', width: 60, sorttype: "date", formatter: "date", formatoptions:
                    { newformat: _cnfjqgDateFormat }
            },
            { name: "ActiveStatus", width: 35, editable: true, align: 'center', edittype: "checkbox", formatter: 'checkbox', editoptions: { value: "true:false" } },
            {
                name: 'edit', search: false, align: 'left', width: 70, sortable: false, resizable: false,
                formatter: function (cellValue, options, rowdata, action) {
                    return '<button class="btn-xs ui-button ui-widget ui-corner-all btn-jqgrid" title="Edit" id="jqgEdit" onclick="return fnEditDocumentControlNormal(event,\'edit\');"><i class="fas fa-pen"></i> ' + localization.Edit + '</button>' +
                        '<button class="btn-xs ui-button ui-widget ui-corner-all btn-jqgrid" title="View" id="jqgView" onclick="return fnEditDocumentControlNormal(event,\'view\');"><i class="far fa-eye"></i>' + localization.View +'</button>' +
                        '<button class="btn-xs ui-button ui-widget ui-corner-all btn-jqgrid" title="Delete" id="jqgDelete" onclick="return fnEditDocumentControlNormal(event,\'delete\');"><i class="fas fa-trash"></i>' + localization.Delete +'</button>'
                }
            },
        ],
        pager: "#jqpDocumentControlNormal",
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
            SetGridControlByAction(); fnJqgridSmallScreen("jqpDocumentControlNormal");
        },
    }).jqGrid('navGrid', '#jqpDocumentControlNormal', { add: false, edit: false, search: false, del: false, refresh: false, refreshtext: 'Reload' }).jqGrid('navButtonAdd', '#jqpDocumentControlNormal', {
         caption: '<span class="fa fa-sync"></span> Refresh', buttonicon: "none", id: "custRefresh", position: "first", onClickButton: fnGridRefreshDocumentControlNormal
        }).jqGrid('navButtonAdd', '#jqpDocumentControlNormal', {
        caption: '<span class="fa fa-plus" data-toggle="modal"></span> Add', buttonicon: 'none', id: 'jqgAdd', position: 'first', onClickButton: fnAddDocumentControlNormal
    });

    $(window).on("resize", function () {
        var $grid = $("#jqgDocumentControlNormal"),
            newWidth = $grid.closest(".ui-jqgrid").parent().width();
        $grid.jqGrid("setGridWidth", newWidth, true);
    });
    fnAddGridSerialNoHeading();
}

function fnAddDocumentControlNormal() {
    if (IsStringNullorEmpty($("#cboBusinessLocation").val()) || $("#cboBusinessLocation").val() === "0") {
        toastr.warning("Please select Business key to Add");
        return;
    }
    else {
        $('#PopupDocumentControlNormal').modal('show');
        $('#PopupDocumentControlNormal').modal({ backdrop: 'static', keyboard: false });
        $('#PopupDocumentControlNormal').find('.modal-title').text(localization.AddDocumentNormalControl);
        $("#chkActiveStatus").parent().addClass("is-checked");
        fnClearFields();
        $("#chkActiveStatus").prop('disabled', true);
        $("#btnSaveDocumentControlNormal").html('<i class="fa fa-save"></i>' + localization.Save);
        $("#btnSaveDocumentControlNormal").show();
        $("#btndeActiveDocumentControlNormal").hide();
         _isInsert = true;

    }
}


function fnEditDocumentControlNormal(e, actiontype) {
    var rowid = $(e.target).parents("tr.jqgrow").attr('id');
    var rowData = $('#jqgDocumentControlNormal').jqGrid('getRowData', rowid);

    _isInsert = false;

    $('#PopupDocumentControlNormal').modal('show');
    $('#cbodocumentId').val(rowData.DocumentId).selectpicker('refresh');
    $("#cbodocumentId").next().attr('disabled', true);
    $('#txtfinancialyear').val(rowData.FinancialYear);
    $("#txtfinancialyear").attr('readonly', true);
    $('#txtStartdocNumber').val(rowData.StartDocNumber);
    $('#txtcurrentdocNumber').val(rowData.CurrentDocNumber);
    $("#dtdocdate").attr('readonly', true);
    if (rowData.CurrentDocDate !== null) {
        setDate($('#dtdocdate').val(rowData.CurrentDocDate));
    }
    else {
        $('#dtdocdate').val('');
    }

    if (rowData.ActiveStatus == 'true') {
        $("#chkActiveStatus").parent().addClass("is-checked");
    }
    else {
        $("#chkActiveStatus").parent().removeClass("is-checked");
    }
    $("#btnSaveDocumentControlNormal").attr("disabled", false);

    if (actiontype.trim() == "edit") {
        $('#PopupDocumentControlNormal').find('.modal-title').text(localization.EditDocumentNormalControl);
        $("#btnSaveDocumentControlNormal").html('<i class="fa fa-sync"></i>' + localization.Update);
        $("#btndeActiveDocumentControlNormal").hide();
        $("#chkActiveStatus").prop('disabled', true);
        $("#btnSaveDocumentControlNormal").attr("disabled", false);
    }

    if (actiontype.trim() == "view") {
        $('#PopupDocumentControlNormal').find('.modal-title').text(localization.ViewDocumentNormalControl);
        $("#btnSaveDocumentControlNormal").attr("disabled", false);
        $("input,textarea").attr('readonly', true);
        $("select").next().attr('disabled', true);
        $("#btnSaveDocumentControlNormal").hide();
        $("#btndeActiveDocumentControlNormal").hide();
        $("#chkActiveStatus").prop('disabled', true);
        $("#PopupDocumentControlNormal").on('hidden.bs.modal', function () {
            $("#btnSaveDocumentControlNormal").show();
            $("input,textarea").attr('readonly', false);
            $("select").next().attr('disabled', false);
        });
    }
    if (actiontype.trim() == "delete") {
        $('#PopupDocumentControlNormal').find('.modal-title').text("Activate/De Activate Document Control Normal Mode");
        $("#btnSaveDocumentControlNormal").attr("disabled", false);
        $("input,textarea").attr('readonly', true);
        $("select").next().attr('disabled', true);
        $("#btnSaveDocumentControlNormal").hide();

        if (rowData.ActiveStatus == 'true') {
            $("#btndeActiveDocumentControlNormal").html(localization.DActivate);
        }
        else {
            $("#btndeActiveDocumentControlNormal").html(localization.Activate);
        }

        $("#btndeActiveDocumentControlNormal").show();
        $("#chkActiveStatus").prop('disabled', true);
        $("#PopupDocumentControlNormal").on('hidden.bs.modal', function () {
            $("#btnSaveDocumentControlNormal").show();
            $("input,textarea").attr('readonly', false);
            $("select").next().attr('disabled', false);
        });
    }
}

function fnGridRefreshDocumentControlNormal() {
    $("#jqgDocumentControlNormal").setGridParam({ datatype: 'json', page: 1 }).trigger('reloadGrid');
}

$("#btnCancelDocumentControlNormal").click(function () {
    $("#jqgDocumentControlNormal").jqGrid('resetSelection');
    $('#PopupDocumentControlNormal').modal('hide');
    fnClearFields();
});

function fnClearFields() {
    $('#cbodocumentId').val('0').selectpicker('refresh');
    $("#cbodocumentId").next().attr('disabled', false);
    $("#txtfinancialyear").val('');
    $("#txtfinancialyear").attr('readonly', false);
    $("#dtdocdate").attr('readonly', true);
    $('#txtStartdocNumber').val('');
    $("#chkActiveStatus").prop('disabled', false);
    $('#dtdocdate').val('');
    $("#btnSaveDocumentControlNormal").attr("disabled", false);
    $("#btndeActiveDocumentControlNormal").attr("disabled", false);
}


function fnSaveDocumentControlNormal() {
    if (IsStringNullorEmpty($("#cboBusinessLocation").val()) || $("#cboBusinessLocation").val() === "0") {
        toastr.warning("Please select Business key");
        return;
    }
    if (IsStringNullorEmpty($("#cbodocumentId").val()) || $("#cbodocumentId").val() === "0") {
        toastr.warning("Please select Document");
        return;
    }
    if (IsStringNullorEmpty($("#txtfinancialyear").val())) {
        toastr.warning("Please Enter Financial Year");
        return;
    }
    if (IsStringNullorEmpty($("#txtStartdocNumber").val())) {
        toastr.warning("Please Enter Start Document");
        return;
    }
    
    objnormal = {
        BusinessKey: $("#cboBusinessLocation").val(),
        DocumentId: $("#cbodocumentId").val(),
        FinancialYear: $("#txtfinancialyear").val(),
        StartDocNumber: $("#txtStartdocNumber").val(),
        CurrentDocDate: $("#dtdocdate").val(),
        ActiveStatus: $("#chkActiveStatus").parent().hasClass("is-checked")
    };

    $("#btnSaveDocumentControlNormal").attr("disabled", true);

    $.ajax({
        url: getBaseURL() + '/Standard/InsertOrUpdateDocumentControlNormalMode',
        type: 'POST',
        datatype: 'json',
        data: { isInsert: _isInsert, obj: objnormal },
        success: function (response) {
            if (response.Status) {
               
                toastr.success(response.Message);
                $("#btnSaveDocumentControlNormal").html('<i class="fa fa-spinner fa-spin"></i> wait');
                $("#PopupDocumentControlNormal").modal('hide');
                fnClearFields();
                fnGridRefreshDocumentControlNormal();
            }
            else {
                toastr.error(response.Message);
                $("#btnSaveDocumentControlNormal").attr("disabled", false);
            }
        },
        error: function (error) {
            toastr.error(error.statusText);
            $("#btnSaveDocumentControlNormal").attr("disabled", false);
        }
    });
}

function fnDeleteDocumentControlNormal() {

    var a_status;
    //Activate or De Activate the status
    if ($("#chkActiveStatus").parent().hasClass("is-checked") === true) {
        a_status = false
    }
    else {
        a_status = true;
    }
    objgen = {
        BusinessKey: $("#cboBusinessLocation").val(),
        DocumentId: $("#cbodocumentId").val(),
        FinancialYear: $("#txtfinancialyear").val(),
        StartDocNumber: $("#txtStartdocNumber").val(),
        CurrentDocDate: $("#dtdocdate").val(),
        a_status: a_status,
        ActiveStatus: $("#chkActiveStatus").parent().hasClass("is-checked")
    };

    $("#btndeActiveDocumentControlNormal").attr("disabled", true);
    $.ajax({
        url: getBaseURL() + '/Standard/ActiveOrDeActiveDocumentControlNormalMode',
        type: 'POST',
        datatype: 'json',
        data: { objgen },
        success: function (response) {
            if (response.Status) {
                toastr.success(response.Message);
                $("#btndeActiveDocumentControlNormal").html('<i class="fa fa-spinner fa-spin"></i> wait');
                $("#PopupDocumentControlNormal").modal('hide');
                fnClearFields();
                fnGridRefreshDocumentControlNormal();
                $("#btndeActiveDocumentControlNormal").attr("disabled", false);
            }
            else {
                toastr.error(response.Message);
                $("#btndeActiveDocumentControlNormal").attr("disabled", false);
                $("#btndeActiveDocumentControlNormal").html('De Activate');
            }
        },
        error: function (error) {
            toastr.error(error.statusText);
            $("#btndeActiveDocumentControlNormal").attr("disabled", false);
            $("#btndeActiveDocumentControlNormal").html('De Activate');
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

