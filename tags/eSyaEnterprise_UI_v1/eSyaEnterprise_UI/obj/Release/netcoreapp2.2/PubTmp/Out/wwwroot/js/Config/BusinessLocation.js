﻿var Isadd = 0;
var actiontype = "";
$(document).ready(function () {
    $('#cboBusinessId').selectpicker('refresh');

    $('#cboSegmentId').selectpicker('refresh');
});

function fnLoadCboBusinessSegment() {
    $('#cboSegmentId').selectpicker('refresh');
    $.ajax({
        url: getBaseURL() + '/BusinessStructure/GetActiveBusinessSegmentbyBusinessId?BusinessId=' + $('#cboBusinessId').val(),
        datatype: 'json',
        type: 'POST',
        async: false,
        contentType: 'application/json; charset=utf-8',
        success: function (result) {
            $('#cboSegmentId').empty();
            $("#cboSegmentId").append($("<option value='0'>Choose Business Segment</option>"));
            if (result != null) {
                for (var i = 0; i < result.length; i++) {

                    $("#cboSegmentId").append($("<option></option>").val(result[i]["SegmentId"]).html(result[i]["SegmentDesc"]));
                }
            }
            $('#cboSegmentId').val($("#cboSegmentId option:first").val());
            $('#cboSegmentId').selectpicker('refresh');
            fnGridLoadBusinessLocation();
        }
    });
}

function fnGridLoadBusinessLocation() {
    var businessId = $('#cboBusinessId').val();
    var segmentId = $('#cboSegmentId').val();
    $("#jqgBusinessLocation").jqGrid('GridUnload');
    $("#jqgBusinessLocation").jqGrid({
        url: getBaseURL() + '/BusinessStructure/GetBusinessLocationByBusinessIdandSegmentId?BusinessId=' + businessId + "&SegmentId=" + segmentId,
        mtype: 'Post',
        datatype: 'json',
        ajaxGridOptions: { contentType: 'application/json; charset=utf-8' },
        jsonReader: { repeatitems: false, root: "rows", page: "page", total: "total", records: "records" },
        colNames: ["","","","Location Code","Location Description", "Active Status","Actions"],
        colModel: [
            { name: "BusinessId", width: 70, editable: true, align: 'left', hidden: true },
            { name: "SegmentId", width: 70, editable: true, align: 'left', hidden: true },
            { name: "LocationId", width: 70, editable: true, align: 'left', hidden: true },
            { name: "LocationCode", width: 80, editable: true, align: 'left', hidden: false },
            { name: "LocationDescription", width:120, editable: false, hidden: false, align: 'left', resizable: true },
            { name: "ActiveStatus", editable: true, width: 80, hidden: false, align: 'left', resizable: false, edittype: "select", formatter: 'select', editoptions: { value: "true: Active;false: Inactive" } },
           
            {
                name: 'edit', search: false, align: 'left', width: 100, sortable: false, resizable: false,
                formatter: function (cellValue, options, rowdata, action) {
                    return '<button class="btn-xs ui-button ui-widget ui-corner-all btn-jqgrid" title="Edit" onclick="return fnEditBusinessLocation(event,\'edit\')"><i class="fas fa-pencil-alt"></i> Edit </button>' +
                        '<button class="btn-xs ui-button ui-widget ui-corner-all btn-jqgrid" title="View" onclick="return fnEditBusinessLocation(event,\'view\')"><i class="far fa-eye"></i> View </button>'

                }
            },
        ],
        rowNum: 10,
        rowList: [10, 20, 50, 100],
        loadonce: true,
        pager: "#jqpBusinessLocation",
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
        caption: 'Business Location',
        loadComplete: function () {
            fnJqgridSmallScreen("jqgBusinessLocation");
        },
    }).jqGrid('navGrid', '#jqpBusinessLocation', { add: false, edit: false, search: false, del: false, refresh: false }).jqGrid('navButtonAdd', '#jqpBusinessLocation', {
        caption: '<span class="fa fa-sync"></span> Refresh', buttonicon: "none", id: "custRefresh", position: "first", onClickButton: fnGridRefreshBusinessLocation
    }).jqGrid('navButtonAdd', '#jqpBusinessLocation', {
        caption: '<span class="fa fa-plus" data-toggle="modal"></span> Add', buttonicon: 'none', id: 'custAdd', position: 'first', onClickButton: fnAddBusinessLocation
    });
}

function fnAddBusinessLocation() {
    if ($("#cboSegmentId").val() == "0") {

        toastr.warning("Please Select Business Segment");
    }
    else {
        $('#txtLocationId').attr('readonly', false);
        Isadd = 1;
        fnClearFields();
        $('#PopupBusinessLocation').modal('show');
        $('#PopupBusinessLocation').modal({ backdrop: 'static', keyboard: false });
        $('#PopupBusinessLocation').find('.modal-title').text("Add Business Location");
        $("#btnSaveBusinessLocation").html(' Save');
    }
}

function fnEditBusinessLocation(e,actiontype) {
    var rowid = $(e.target).parents("tr.jqgrow").attr('id');
    var rowData = $('#jqgBusinessLocation').jqGrid('getRowData', rowid);
    fnClearFields();
    Isadd = 0;
    $('#txtLocationId').val(rowData.LocationId).attr('readonly', true);;
    $('#txtLocationcode').val(rowData.LocationCode);
    $('#txtLocationDescription').val(rowData.LocationDescription);
    $('#cboActiveStatus').val(rowData.ActiveStatus);
    $('#cboActiveStatus').selectpicker('refresh');  
    $('#PopupBusinessLocation').modal('show');
    
    if (actiontype.trim() == "edit") {
        $('#PopupBusinessLocation').find('.modal-title').text("Update Business Location");
        $("#btnSaveBusinessLocation").html(' Update');
    }
    if (actiontype.trim() == "view") {
        $('#PopupBusinessLocation').find('.modal-title').text("View Business Location");
        $("#btnSaveBusinessLocation").html(' Update');
        $("#btnSaveBusinessLocation").hide();
        $("input,textarea").attr('readonly', true);
        $("select").next().attr('disabled', true);
        $("#PopupBusinessLocation").on('hidden.bs.modal', function () {
            $("#btnSaveBusinessLocation").show();
            $("input,textarea").attr('readonly', false);
            $("select").next().attr('disabled', false);
        })
    }
}

function fnSaveBusinessLocation() {
    debugger;
    if (IsStringNullorEmpty($("#txtLocationId").val())) {
        toastr.warning("Please Enter Location ID");
        return;
    }
    if (IsStringNullorEmpty($("#txtLocationcode").val())) {
        toastr.warning("Please Enter Location Code");
        return;
    }
    if (IsStringNullorEmpty($("#txtLocationDescription").val())) {
        toastr.warning("Please Enter Location Description");
        return;
    }
    if (Isadd === 1) {
        var location = {
            LocationId: $("#txtLocationId").val(),
            BusinessId: $("#cboBusinessId").val(),
            SegmentId: $("#cboSegmentId").val(),
            LocationCode: $("#txtLocationcode").val(),
            LocationDescription: $("#txtLocationDescription").val(),
            ActiveStatus: $("#cboActiveStatus").val(),
            Isadd: 1
        }
    }
    if (Isadd === 0) {
        var location = {
            LocationId: $("#txtLocationId").val(),
            BusinessId: $("#cboBusinessId").val(),
            SegmentId: $("#cboSegmentId").val(),
            LocationCode: $("#txtLocationcode").val(),
            LocationDescription: $("#txtLocationDescription").val(),
            ActiveStatus: $("#cboActiveStatus").val(),
            Isadd: 0
        };
    }
    $.ajax({
        url: getBaseURL() + '/BusinessStructure/InsertOrUpdateBusinessLocation',
        type: 'POST',
        datatype: 'json',
        data: { location },
        success: function (response) {
            if (response.Status) {
                toastr.success(response.Message);
                fnGridLoadBusinessLocation();
                $("#PopupBusinessLocation").modal('hide');
                fnClearFields();
                return true;
            }
            else {
                toastr.error(response.Message);
                return false;
            }
        },
        error: function (error) {
            toastr.error(error.statusText);

        }
    });
}

function fnGridRefreshBusinessLocation() {
    $("#jqgBusinessLocation").setGridParam({ datatype: 'json', page: 1 }).trigger('reloadGrid');
}

function fnClearFields() {
    $("#txtLocationId").val('');
    $("#txtLocationcode").val('');
    $("#txtLocationDescription").val('');
    $("#cboActiveStatus").val('true');
    $("#cboActiveStatus").selectpicker('refresh');
}
