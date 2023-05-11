var Isadd = 0;
$(document).ready(function () {
   
    fnLoadDocumentCtrlGrid();
});

function fnLoadDocumentCtrlGrid() {

    $("#jqvDocContManagement").jqGrid('GridUnload');

    $("#jqvDocContManagement").jqGrid({

        url: getBaseURL() + '/Control/GetDocumentControlMaster',
        mtype: 'POST',
        datatype: 'json',
        ajaxGridOptions: { contentType: 'application/json; charset=utf-8' },
        jsonReader: { repeatitems: false, root: "rows", page: "page", total: "total", records: "records" },
        colNames: [localization.DocumentId, localization.DocumentDescription, localization.ShortDesc, localization.DocumentType, localization.SchemeName,  localization.IsFinancialYearApplicable, localization.IsStoreLinkApplicable, localization.IsTransactionModeApplicable, localization.IsCustomerGroupApplicable, localization.UsageStatus, localization.Active,localization.Actions],
        colModel: [
            { name: "DocumentId", width: 10, editable: true, align: 'left', hidden: true },
            { name: "DocumentDesc", width: 70, editable: true, align: 'left', resizable: false, hidden: false },
            { name: "ShortDesc", width: 50, editable: true, align: 'left', resizable: false, hidden: false },
            { name: "DocumentType", width: 50, editable: true, align: 'left', resizable: false, hidden: false },
            { name: "SchemeName", width: 50, editable: true, align: 'left', resizable: false, hidden: false },
            { name: "IsFinancialYearAppl", width: 50, editable: true, align: 'left', hidden: false, edittype: "checkbox", formatter: 'checkbox', editoptions: { value: "true:false" }},
            { name: "IsStoreLinkAppl", width: 50, editable: true, align: 'left', hidden: false, edittype: "checkbox", formatter: 'checkbox', editoptions: { value: "true:false" } },
            { name: "IsTransactionModeAppl", width: 50, editable: true, align: 'left', hidden: false, edittype: "checkbox", formatter: 'checkbox', editoptions: { value: "true:false" } },
            { name: "IsCustomerGroupAppl", width: 50, editable: true, align: 'left', hidden: false, edittype: "checkbox", formatter: 'checkbox', editoptions: { value: "true:false" } },
            { name: "UsageStatus", width: 50, editable: true, align: 'center', edittype: "checkbox", formatter: 'checkbox', editoptions: { value: "true:false" } },
            { name: "ActiveStatus", width: 35, editable: false, align: 'center', edittype: "checkbox", formatter: 'checkbox', editoptions: { value: "true:false" }, formatoptions: { disabled: true } },
            {
                name: 'edit', search: false, align: 'left', width: 100, sortable: false, resizable: false,
                formatter: function (cellValue, options, rowdata, action) {
                   
                    return '<button class="btn-xs ui-button ui-widget ui-corner-all btn-jqgrid" title="Edit" id="jqgEdit" onclick="return fnEditDocumentControl(event,\'edit\')"><i class="fas fa-pen"></i> ' + localization.Edit +'</button>' +
                        '<button class="btn-xs ui-button ui-widget ui-corner-all btn-jqgrid" title="View" id="jqgView" onclick="return fnViewDocumentControl(event,\'view\')"><i class="far fa-eye"></i> ' + localization.View + '</button>' +
                        '<button class="btn-xs ui-button ui-widget ui-corner-all btn-jqgrid" title = "Delete" id="jqgDelete" onclick = "return fnPopUpDeleteDocumentControl(event,\'delete\')" > <i class="fas fa-trash"></i>' + localization.Delete + '</button>'
            }
            },
        ],
        rowNum: 10,
        rowList: [10, 20, 50, 100],
        rownumWidth:55,
        loadonce: true,
        pager: "#jqpDocContManagement",
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
            SetGridControlByAction(); fnJqgridSmallScreen("jqvDocContManagement");
        },

    }).jqGrid('navGrid', '#jqpDocContManagement', { add: false, edit: false, search: false, del: false, refresh: false }).jqGrid('navButtonAdd', '#jqpDocContManagement', {
        caption: '<span class="fa fa-sync"></span> Refresh', buttonicon: "none", id: "custRefresh", position: "first", onClickButton: fnRefreshDocumentControlGrid
    }).jqGrid('navButtonAdd', '#jqpDocContManagement', {
        caption: '<span class="fa fa-plus" data-toggle="modal"></span> Add', buttonicon: 'none', id: 'jqgAdd', position: 'first', onClickButton: fnAddDocumentControl
        });
    fnAddGridSerialNoHeading();
}

function fnAddDocumentControl() {
    fnClearFields();
    Isadd = 1;
    $("#txtDocumentId").prop('readonly', false);
    $('#PopupDocContrManagement').modal('show');
    $('#PopupDocContrManagement').modal({ backdrop: 'static', keyboard: false });
    $('#PopupDocContrManagement').find('.modal-title').text(localization.AddDocumentControl);
    $("#chkActiveStatus").parent().addClass("is-checked");
    $("#btnsaveDocContrManagement").html('<i class="fa fa-save"></i>' + localization.Save);
    $("#chkActiveStatus").prop('disabled', true);
    $("#btnsaveDocContrManagement").show();
    $("#btnDeactivateDocumentControl").hide();

}

function fnEditDocumentControl(e) {
    
    var rowid = $(e.target).parents("tr.jqgrow").attr('id');
    var rowData = $('#jqvDocContManagement').jqGrid('getRowData', rowid);
    $("#txtDocumentId").val(rowData.DocumentId);
    $("#txtDocumentId").prop('readonly', true);
    $("#txtShortDesc").val(rowData.ShortDesc);
    $("#txtDocumentType").val(rowData.DocumentType);
    $("#txtSchemeName").val(rowData.SchemeName);
    $("#txtDocumentDesc").val(rowData.DocumentDesc);
    $("#txtDocumentCategory").val(rowData.DocumentCategory);
    $("#txtCategoryDescription").val(rowData.DocCatgDesc);

    if (rowData.IsFinancialYearAppl == 'true') {
        $("#chkIsFinancialYear").parent().addClass("is-checked");
    }
    else {
        $("#chkIsFinancialYear").parent().removeClass("is-checked");
    }
    if (rowData.IsStoreLinkAppl == 'true') {
        $("#chkIsStoreLink").parent().addClass("is-checked");
    }
    else {
        $("#chkIsStoreLink").parent().removeClass("is-checked");
    }
    if (rowData.IsTransactionModeAppl == 'true') {
        $("#chkIsTransactionMode").parent().addClass("is-checked");
    }
    else {
        $("#chkIsTransactionMode").parent().removeClass("is-checked");
    }
    if (rowData.IsCustomerGroupAppl == 'true') {
        $("#chkIsCustomerGroup").parent().addClass("is-checked");
    }
    else {
        $("#chkIsCustomerGroup").parent().removeClass("is-checked");
    }
    if (rowData.UsageStatus == 'true') {
        $("#chkUsageStatus").parent().addClass("is-checked");
    }
    else {
        $("#chkUsageStatus").parent().removeClass("is-checked");
    }
    if (rowData.ActiveStatus == 'true') {
        $("#chkActiveStatus").parent().addClass("is-checked");
    }
    else {
        $("#chkActiveStatus").parent().removeClass("is-checked");
    } 

    Isadd = 0;
    $('#PopupDocContrManagement').modal('show');
    $('#PopupDocContrManagement').find('.modal-title').text(localization.UpdateDocumentControl);
    $("#btnsaveDocContrManagement").html('<i class="fa fa-sync"></i>' + localization.Update);
    $("#btnsaveDocContrManagement").attr('disabled', false);
    $("#btnsaveDocContrManagement").show();
    $("#btnDeactivateDocumentControl").hide();
    $("#chkActiveStatus").prop('disabled', true);
}

function fnSaveDocumentControl() {

    if (validateDocumentControl() === false) {
        return;
    }

    if (Isadd === 1) {
        obj = {
            DocumentId: $("#txtDocumentId").val(),
            DocumentType: $("#txtDocumentType").val(),
            ShortDesc: $("#txtShortDesc").val(),
            DocumentDesc: $("#txtDocumentDesc").val(),
            SchemeName: $("#txtSchemeName").val(),
            IsFinancialYearAppl: $("#chkIsFinancialYear").parent().hasClass("is-checked"),
            IsStoreLinkAppl: $("#chkIsStoreLink").parent().hasClass("is-checked"),
            IsTransactionModeAppl: $("#chkIsTransactionMode").parent().hasClass("is-checked"),
            IsCustomerGroupAppl: $("#chkIsCustomerGroup").parent().hasClass("is-checked"),
            UsageStatus: $("#chkUsageStatus").parent().hasClass("is-checked"),
            ActiveStatus: $("#chkActiveStatus").parent().hasClass("is-checked"),
            Isadd: 1
        };

    }

    if (Isadd === 0) {
        var obj = {
            DocumentId: $("#txtDocumentId").val(),
            DocumentType: $("#txtDocumentType").val(),
            ShortDesc: $("#txtShortDesc").val(),
            DocumentDesc: $("#txtDocumentDesc").val(),
            SchemeName: $("#txtSchemeName").val(),
            IsFinancialYearAppl: $("#chkIsFinancialYear").parent().hasClass("is-checked"),
            IsStoreLinkAppl: $("#chkIsStoreLink").parent().hasClass("is-checked"),
            IsTransactionModeAppl: $("#chkIsTransactionMode").parent().hasClass("is-checked"),
            IsCustomerGroupAppl: $("#chkIsCustomerGroup").parent().hasClass("is-checked"),
            UsageStatus: $("#chkUsageStatus").parent().hasClass("is-checked"),
            ActiveStatus: $("#chkActiveStatus").parent().hasClass("is-checked"),
            Isadd: 0
        };
    }
    $("#btnsaveDocContrManagement").attr('disabled', true);
    $.ajax({
        url: getBaseURL() + '/Control/InsertOrUpdateDocumentControl',
        type: 'POST',
        datatype: 'json',
        data: { obj },
        success: function (response) {
            if (response.Status) {
                toastr.success(response.Message);
                $("#btnsaveDocContrManagement").html('<i class="fa fa-spinner fa-spin"></i> wait');
                $('#PopupDocContrManagement').modal('hide');
                fnRefreshDocumentControlGrid();
                fnClearFields()
                return true;
            }
            else {
                toastr.error(response.Message);
                $("#btnsaveDocContrManagement").attr('disabled', false);
                return false;
            }
        },
        error: function (error) {
            toastr.error(error.statusText);
            $("#btnsaveDocContrManagement").attr('disabled', false);
        }
    });



}

function validateDocumentControl() {
    
    if ($("#cboformId").val() === "0" || $("#cboformId").val() === '0') {
        toastr.warning("Please Select Form");
        return false;
    }
    if (IsStringNullorEmpty($("#txtDocumentId").val())) {
        toastr.warning("Please Enter Document ID");
        return false;
    }
    if (IsStringNullorEmpty($("#txtShortDesc").val())) {
        toastr.warning("Please Enter Short Description");
        return false;
    }
    if (IsStringNullorEmpty($("#txtDocumentType").val())) {
        toastr.warning("Please Enter Document Type");
        return false;
    }
    if (IsStringNullorEmpty($("#txtSchemeName").val())) {
        toastr.warning("Please Enter Scheme Name");
        return false;
    }
    if (IsStringNullorEmpty($("#txtDocumentDesc").val())) {
        toastr.warning("Please Enter Document Description");
        return false;
    }
   
   
}

function fnRefreshDocumentControlGrid() {
    $("#jqvDocContManagement").setGridParam({ datatype: 'json', page: 1 }).trigger('reloadGrid');
}

function fnViewDocumentControl(e){
    var rowid = $(e.target).parents("tr.jqgrow").attr('id');
    var rowData = $('#jqvDocContManagement').jqGrid('getRowData', rowid);
    
    $("#txtDocumentId").val(rowData.DocumentId);
    $("#txtDocumentId").prop('readonly', true);
    $("#txtShortDesc").val(rowData.ShortDesc);
    $("#txtDocumentType").val(rowData.DocumentType);
    $("#txtSchemeName").val(rowData.SchemeName);
    $("#txtDocumentDesc").val(rowData.DocumentDesc);
    $("#txtDocumentCategory").val(rowData.DocumentCategory);
    $("#txtCategoryDescription").val(rowData.DocCatgDesc);

    if (rowData.IsFinancialYearAppl == 'true') {
        $("#chkIsFinancialYear").parent().addClass("is-checked");
    }
    else {
        $("#chkIsFinancialYear").parent().removeClass("is-checked");
    }
    if (rowData.IsStoreLinkAppl == 'true') {
        $("#chkIsStoreLink").parent().addClass("is-checked");
    }
    else {
        $("#chkIsStoreLink").parent().removeClass("is-checked");
    }
    if (rowData.IsTransactionModeAppl == 'true') {
        $("#chkIsTransactionMode").parent().addClass("is-checked");
    }
    else {
        $("#chkIsTransactionMode").parent().removeClass("is-checked");
    }
    if (rowData.IsCustomerGroupAppl == 'true') {
        $("#chkIsCustomerGroup").parent().addClass("is-checked");
    }
    else {
        $("#chkIsCustomerGroup").parent().removeClass("is-checked");
    }
    
    if (rowData.UsageStatus == 'true') {
        $("#chkUsageStatus").parent().addClass("is-checked");
    }
    else {
        $("#chkUsageStatus").parent().removeClass("is-checked");
    }
    if (rowData.ActiveStatus == 'true') {
        $("#chkActiveStatus").parent().addClass("is-checked");
    }
    else {
        $("#chkActiveStatus").parent().removeClass("is-checked");
    }
    Isadd = 0;
    $('#PopupDocContrManagement').modal('show');
    $('#PopupDocContrManagement').find('.modal-title').text(localization.ViewDocumentControl);
    $("#btnsaveDocContrManagement").hide();
    $("input,textarea").attr('readonly', true);
    $("select").next().attr('disabled', true);
    $("input[id*=chk]").attr('disabled', true);
    $("#PopupDocContrManagement").on('hidden.bs.modal', function () {
        $("#btnsaveDocContrManagement").show();
        $("input,textarea").attr('readonly', false);
        $("select").next().attr('disabled', false);
        $("input[id*=chk]").attr('disabled', false);
        $("#btnsaveDocContrManagement").attr('disabled', false);
    })
}

function fnPopUpDeleteDocumentControl(e) {
    var rowid = $(e.target).parents("tr.jqgrow").attr('id');
    var rowData = $('#jqvDocContManagement').jqGrid('getRowData', rowid);
    $("#txtDocumentId").val(rowData.DocumentId);
    $("#txtDocumentId").prop('readonly', true);
    $("#txtShortDesc").val(rowData.ShortDesc);
    $("#txtDocumentType").val(rowData.DocumentType);
    $("#txtSchemeName").val(rowData.SchemeName);
    $("#txtDocumentDesc").val(rowData.DocumentDesc);
    $("#txtDocumentCategory").val(rowData.DocumentCategory);
    $("#txtCategoryDescription").val(rowData.DocCatgDesc);

    if (rowData.IsFinancialYearAppl == 'true') {
        $("#chkIsFinancialYear").parent().addClass("is-checked");
    }
    else {
        $("#chkIsFinancialYear").parent().removeClass("is-checked");
    }
    if (rowData.IsStoreLinkAppl == 'true') {
        $("#chkIsStoreLink").parent().addClass("is-checked");
    }
    else {
        $("#chkIsStoreLink").parent().removeClass("is-checked");
    }
    if (rowData.IsTransactionModeAppl == 'true') {
        $("#chkIsTransactionMode").parent().addClass("is-checked");
    }
    else {
        $("#chkIsTransactionMode").parent().removeClass("is-checked");
    }
    if (rowData.IsCustomerGroupAppl == 'true') {
        $("#chkIsCustomerGroup").parent().addClass("is-checked");
    }
    else {
        $("#chkIsCustomerGroup").parent().removeClass("is-checked");
    }
   
    if (rowData.UsageStatus == 'true') {
        $("#chkUsageStatus").parent().addClass("is-checked");
    }
    else {
        $("#chkUsageStatus").parent().removeClass("is-checked");
    }
    if (rowData.ActiveStatus == 'true') {
        $("#chkActiveStatus").parent().addClass("is-checked");
        $("#btnDeactivateDocumentControl").html(localization.DeActivate);
    }
    else {
        $("#chkActiveStatus").parent().removeClass("is-checked");
        $("#btnDeactivateDocumentControl").html(localization.Activate);
    }
    Isadd = 0;
    $('#PopupDocContrManagement').modal('show');
    $('#PopupDocContrManagement').find('.modal-title').text("Active/De Active Document Control");
    $("#btnsaveDocContrManagement").hide();
    $("#btnDeactivateDocumentControl").show();
    $("#chkActiveStatus").prop('disabled', true);
    $("input,textarea").attr('readonly', true);
    $("select").next().attr('disabled', true);
    $("input[id*=chk]").attr('disabled', true);
    $("#PopupDocContrManagement").on('hidden.bs.modal', function () {
        $("#btnsaveDocContrManagement").show();
        $("input,textarea").attr('readonly', false);
        $("select").next().attr('disabled', false);
        $("input[id*=chk]").attr('disabled', false);
        $("#btnsaveDocContrManagement").attr('disabled', false);
    })
}

function fnClearFields() {
    $("#txtDocumentId").val('');
    $("#txtDocumentType").val('');
    $("#txtDocumentType").val('');
    $("#txtShortDesc").val('');
    $("#txtSchemeName").val('');
    $("#txtDocumentDesc").val('');
    $("#chkIsFinancialYear").parent().removeClass("is-checked");
    $("#chkIsStoreLink").parent().removeClass("is-checked");
    $("#chkIsTransactionMode").parent().removeClass("is-checked");
    $("#chkIsCustomerGroup").parent().removeClass("is-checked");
    $("#chkUsageStatus").parent().removeClass("is-checked");
    $("#chkActiveStatus").prop('disabled', false);
    $("#btnsaveDocContrManagement").attr('disabled', false);
}

function fnDeleteDocumentControl() {

    var a_status;
    //Activate or De Activate the status
    if ($("#chkActiveStatus").parent().hasClass("is-checked") === true) {
        a_status = false
    }
    else {
        a_status = true;
    }
    $("#btnDeactivateDocumentControl").attr("disabled", true);
    $.ajax({
        url: getBaseURL() + '/Control/ActiveOrDeActiveDocumentControl?status=' + a_status + '&documentId=' + $("#txtDocumentId").val(),
        type: 'POST',
        success: function (response) {
            if (response.Status) {
                toastr.success(response.Message);
                $("#btnDeactivateDocumentControl").html('<i class="fa fa-spinner fa-spin"></i> wait');
                $('#PopupDocContrManagement').modal('hide');
                fnClearFields();
                fnRefreshDocumentControlGrid();
                $("#btnDeactivateDocumentControl").attr("disabled", false);
            }
            else {
                toastr.error(response.Message);
                $("#btnDeactivateDocumentControl").attr("disabled", false);
                $("#btnDeactivateDocumentControl").html('De Activate');
            }
        },
        error: function (error) {
            toastr.error(error.statusText);
            $("#btnDeactivateDocumentControl").attr("disabled", false);
            $("#btnDeactivateDocumentControl").html('De Activate');
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






