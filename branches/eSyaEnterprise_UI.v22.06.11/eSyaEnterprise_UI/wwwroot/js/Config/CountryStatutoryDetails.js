var actiontype = "";
$(document).ready(function () {
    fnGridLoadStatutoryCode();
});
function fnGridLoadStatutoryCode() {
    $("#jqgStatutoryCode").jqGrid('GridUnload');
    $("#jqgStatutoryCode").jqGrid({
        url: getBaseURL() + '/Country/GetStatutoryCodesbyIsdcode?Isdcode=' + $('#cboIsdcode').val(),
        datatype: 'json',
        mtype: 'Post',
        ajaxGridOptions: { contentType: 'application/json; charset=utf-8' },
        jsonReader: { repeatitems: false, root: "rows", page: "page", total: "total", records: "records" },
        colNames: ["ISD Code", "Statutory Code", localization.StatShortCode, localization.StatutoryDescription, localization.StatPattern, localization.Active, localization.Actions],

        colModel: [

            { name: "Isdcode", width: 10, editable: true, align: 'left', editoptions: { maxlength: 10 }, hidden: true },
            {
                name: "StatutoryCode", width: 150, editable: true, editoptions: { maxlength: 10 }, hidden: true
            },
            {
                name: "StatShortCode", width: 150, editable: true, editoptions: { size: "40", maxlength: "10" }, edittype: "text"
            },
            {
                name: "StatutoryDescription", width: 150, editable: true, editoptions: { size: "40", maxlength: "50" }, edittype: "text"
            },
            {
                name: "StatPattern", width: 150, editable: true, editoptions: { size: "40", maxlength: "15" }, edittype: "text"
            },
            { name: "ActiveStatus", editable: false, width: 40, align: 'center', resizable: false, edittype: "checkbox", formatter: 'checkbox', editoptions: { value: "true:false" } },

            {
                name: 'action', search: false, align: 'left', width: 150, sortable: false, resizable: false,
                formatter: function (cellValue, options, rowdata, action) {
                    return '<button class="btn-xs ui-button ui-widget ui-corner-all btn-jqgrid" title="Edit" id="jqgEdit", onclick="return fnEditStatShortCodes(event,\'edit\')"><i class="fas fa-pen"></i> ' + localization.Edit + ' </button>' +
                        '<button class="btn-xs ui-button ui-widget ui-corner-all btn-jqgrid" title="View" id="jqgView" onclick="return fnEditStatShortCodes(event,\'view\')"><i class="far fa-eye"></i> ' + localization.View + ' </button>' +
                        '<button class="btn-xs ui-button ui-widget ui-corner-all btn-jqgrid" title = "Delete" id="jqgDelete" onclick = "return fnEditStatShortCodes(event,\'delete\')" > <i class="fas fa-trash"></i>' + localization.Delete +'</button >'
                }
            }

        ],
        rowNum: 10,
        rowList: [10, 20, 30, 50, 100],
        rownumWidth:55,
        emptyrecords: "No records to Veiw",
        pager: "#jqpStatutoryCode",
        viewrecords: true,
        gridview: true,
        rownumbers: true,
        height: 'auto',
        width: 'auto',
        scroll: false,
        autowidth: true,
        shrinkToFit: true,
        forceFit: true,
        loadonce: true,
        loadComplete: function (data) {
            SetGridControlByAction(); fnJqgridSmallScreen("jqgStatutoryCode");
        },
    }).jqGrid('navGrid', '#jqpStatutoryCode', { add: false, edit: false, search: false, del: false, refresh: false }).jqGrid('navButtonAdd', '#jqpStatutoryCode', {
        caption: '<span class="fa fa-sync"></span> Refresh', buttonicon: "none", id: "custRefresh", position: "first", onClickButton: RefreshStatutoryGrid
        }).jqGrid('navButtonAdd', '#jqpStatutoryCode', {
        caption: '<span class="fa fa-plus" data-toggle="modal"></span> Add', buttonicon: 'none', id: 'jqgAdd', position: 'first', onClickButton: fnAddStatutoryCodes
        }); fnAddGridSerialNoHeading();
}

function fnAddStatutoryCodes() {
    fnClearFields();
    var id = $("#cboIsdcode").val();
    if (id === 0 || id === "0") {
        toastr.warning("Please select any Isd Code to Add");
    }
    else {
        $("#PopupStatutoryCode").modal('show');
        $('#PopupStatutoryCode').find('.modal-title').text(localization.AddStatutoryCode);
        $("input[type=checkbox]").attr('disabled', false);
        $("#chkActiveStatus").attr('disabled', true);
        $("#btnSaveStatutoryCode").html('<i class="fa fa-save"></i>' + localization.Save);
        $("#btnCancelStatutoryCode").html('<i class="fa fa-times"></i>'+ localization.Cancel);
        $("#PopupStatutoryCode").on('hidden.bs.modal', function () {
            $("input[type=checkbox]").attr('disabled', true);
        });
        $("#btnSaveStatutoryCode").show();
        $("#btnDeactivateStatutoryCode").hide();
    }
}

function fnEditStatShortCodes(e, actiontype) {
    
    var rowid = $(e.target).parents("tr.jqgrow").attr('id');
    var rowData = $('#jqgStatutoryCode').jqGrid('getRowData', rowid);
    $('#txtStatutoryCode').val(rowData.StatutoryCode);
    $("#txtStatShortCode").val(rowData.StatShortCode);
    $("#txtStatutoryDescription").val(rowData.StatutoryDescription);
    $("#txtStatPattern").val(rowData.StatPattern);
    $("#btnSaveStatutoryCode").html('<i class="fa fa-sync"></i>' + localization.Update);
    $("#btnCancelStatutoryCode").html('<i class="fa fa-times"></i>' + localization.Cancel);
    if (rowData.ActiveStatus === "true") {
        $("#chkActiveStatus").parent().addClass("is-checked");
    }
    else { $("#chkActiveStatus").parent().removeClass("is-checked"); }
   
    eSyaParams.ClearValue();

    $.ajax({
        async: false,
        url: getBaseURL() + '/Country/GetStatutoryCodesParameterList?IsdCode=' + $("#cboIsdcode").val() + "&StatutoryCode=" + $("#txtStatutoryCode").val(),
        type: 'POST',
        datatype: 'json',
        success: function (result) {
           
            if (result != null) {
                eSyaParams.SetJSONValue(result);
            }
        },
        error: function (error) {
            toastr.error(error.statusText);

        }
    });

    $('#PopupStatutoryCode').modal('show');
    if (actiontype.trim() == "edit") {
        $("input[type=checkbox]").attr('disabled', false);
        $('#PopupStatutoryCode').find('.modal-title').text(localization.EditStatutoryCode);
        $("#btnSaveStatutoryCode").html('<i class="fa fa-sync"></i>'+localization.Update);
        $("#PopupStatutoryCode").on('hidden.bs.modal', function () {
            $("input[type=checkbox]").attr('disabled', true);
        });
        $("#chkActiveStatus").attr('disabled', true);
        $("#btnDeactivateStatutoryCode").hide();
        $("#btnSaveStatutoryCode").show();
    }

    if (actiontype.trim() == "view") {
        $('#PopupStatutoryCode').find('.modal-title').text(localization.ViewStatutoryCode);
        $("#btnSaveStatutoryCode,#btnDeactivateStatutoryCode").hide();
        $("input,textarea").attr('readonly', true);
        $("select").next().attr('disabled', true);
        $("input[type=checkbox]").attr('disabled', true);
        $("#PopupStatutoryCode").on('hidden.bs.modal', function () {
            $("#btnSaveStatutoryCode").show();
            $("input,textarea").attr('readonly', false);
            $("select").next().attr('disabled', false);
            //$("input[type=checkbox]").attr('disabled', false);
        });
    }

    if (actiontype.trim() == "delete") {
        $('#PopupStatutoryCode').find('.modal-title').text("Activate/DeActivate StatutoryCode");
        if (rowData.ActiveStatus == 'true') {
            $("#btnDeactivateStatutoryCode").html(localization.DeActivate);
        }
        else {
            $("#btnDeactivateStatutoryCode").html(localization.Activate);
        }
        $("#btnSaveStatutoryCode").hide();
        $("#btnDeactivateStatutoryCode").show();
        $("input,textarea").attr('readonly', true);
        $("select").next().attr('disabled', true);
        $("input[type=checkbox]").attr('disabled', true);
        $("#PopupStatutoryCode").on('hidden.bs.modal', function () {
            $("#btnSaveStatutoryCode").show();
            $("input,textarea").attr('readonly', false);
            $("select").next().attr('disabled', false);
            //$("input[type=checkbox]").attr('disabled', false);
        });
    }
}

function fnSaveStatutoryCodes() {
    if (validateStatutoryCodes() === false) {
        return;
    }

    $("#btnSaveStatutoryCode").attr('disabled', true);

    obj = {
        Isdcode: $("#cboIsdcode").val(),
        StatutoryCode: $("#txtStatutoryCode").val() === '' ? 0 : $("#txtStatutoryCode").val(),
        StatShortCode: $("#txtStatShortCode").val(),
        StatutoryDescription: $("#txtStatutoryDescription").val(),
        StatPattern: $("#txtStatPattern").val(),
        ActiveStatus: $("#chkActiveStatus").parent().hasClass("is-checked")
    };

    var fmParams = eSyaParams.GetJSONValue();
    obj.l_FormParameter = fmParams;

    $.ajax({
        url: getBaseURL() + '/Country/InsertOrUpdateStatutoryCodes',
        type: 'POST',
        datatype: 'json',
        data: { obj },
        success: function (response) {
            if (response.Status) {
                toastr.success(response.Message);
      $("#btnSaveStatutoryCode").html('<i class="fa fa-spinner fa-spin"></i> wait');
      $("#btnSaveStatutoryCode").attr('disabled', false);
                RefreshStatutoryGrid();
                $("#PopupStatutoryCode").modal('hide');

            }
            else {
                toastr.error(response.Message);
            }
            $("#btnSaveStatutoryCode").attr('disabled', false);
        },
        error: function (error) {
            toastr.error(error.statusText);
            $("#btnSaveStatutoryCode").attr("disabled", false);
        }
    });
}

function validateStatutoryCodes() {
    
    if (IsStringNullorEmpty($("#txtStatShortCode").val())) {
        toastr.warning("Please Enter Short Code");
        return false;
    }
    if (IsStringNullorEmpty($("#txtStatutoryDescription").val())) {
        toastr.warning("Please Enter Description");
        return false;
    }
    if (IsStringNullorEmpty($("#txtStatPattern").val())) {
        toastr.warning("Please Enter Pattern");
        return false;
    }
}

function RefreshStatutoryGrid() {
    $("#jqgStatutoryCode").setGridParam({ datatype: 'json', page: 1 }).trigger('reloadGrid');

}

function fnClearFields() {
    $("#txtStatutoryCode").val("");
    $("#txtStatShortCode").val("");
    $("#txtStatutoryDescription").val("");
    $("#txtStatPattern").val("");
    $("#chkActiveStatus").parent().addClass("is-checked");
    eSyaParams.ClearValue();
}

function fnDeleteStatutoryCode() {

    var a_status;
    //Activate or De Activate the status
    if ($("#chkActiveStatus").parent().hasClass("is-checked") === true) {
        a_status = false
    }
    else {
        a_status = true;
    }
    $("#btnDeactivateStatutoryCode").attr("disabled", true);
    $.ajax({
        url: getBaseURL() + '/Country/ActiveOrDeActiveStatutoryCode?status=' + a_status + '&Isd_code=' + $("#cboIsdcode").val() + '&statutorycode=' + $("#txtStatutoryCode").val(),
        type: 'POST',
        success: function (response) {
            if (response.Status) {
                toastr.success(response.Message);
                $("#btnDeactivateStatutoryCode").html('<i class="fa fa-spinner fa-spin"></i> wait');
                $('#PopupStatutoryCode').modal('hide');
                fnClearFields();
                RefreshStatutoryGrid();
                $("#btnDeactivateStatutoryCode").attr("disabled", false);
            }
            else {
                toastr.error(response.Message);
                $("#btnDeactivateStatutoryCode").attr("disabled", false);
                $("#btnDeactivateStatutoryCode").html(localization.DeActivate);
            }
        },
        error: function (error) {
            toastr.error(error.statusText);
            $("#btnDeactivateStatutoryCode").attr("disabled", false);
            $("#btnDeactivateStatutoryCode").html(localization.DeActivate);
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

