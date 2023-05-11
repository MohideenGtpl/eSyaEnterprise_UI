function fnHideshowImageDiv()
{
    var optionValue = $("#cboOptionType").val();
    if (optionValue == "IMG") {
        $("#divimage").show();
        $("#divOptionValue").hide();
        $("#txtOptionValue").val('');
       
    }
    else {
        $("#divimage").hide();
        $("#divOptionValue").show();
        document.getElementById('Photoimage').value = "";
        document.getElementById('imgPhoto').src = "";
      
    }
}

$(document).ready(function () {
    fnGridRoomAminities();
});
var actiontype = "";
function fnGridRoomAminities() {

    var roomtype = $("#cboRoomTypeId").val();
    $("#jqgRoomAmenities").GridUnload();

    $("#jqgRoomAmenities").jqGrid({
        url: getBaseURL() + '/RoomAmenities/GetAllRoomAmenitiesbyRoomType?roomType=' + roomtype,
        datatype: 'json',
        mtype: 'POST',
        contentType: 'application/json; charset=utf-8',
        ajaxGridOptions: { contentType: 'application/json; charset=utf-8' },
        colNames: [localization.RoomTypeId, localization.RoomTypeDesc, localization.SerialNumber, localization.OptionType, localization.OptionValues, localization.OptionDesc,localization.Active, localization.Actions],
        colModel: [
            { name: "RoomTypeId", width: 10, align: 'left', editable: true, editoptions: { maxlength: 10 }, resizable: false, hidden: true },
            { name: "RoomTypeDesc", width: 100, align: 'left', editable: true, editoptions: { maxlength: 15 }, resizable: false },
            { name: "SerialNumber", width: 40, align: 'left', editable: true, editoptions: { maxlength: 15 }, resizable: false },
            { name: "OptionType", width: 40, align: 'left', editable: true, editoptions: { maxlength: 15 }, resizable: false },
            { name: "OptionValues", width: 100, align: 'left', editable: true, editoptions: { maxlength: 15 }, resizable: false },
            { name: "OptionDesc", width: 100, align: 'left', editable: true, editoptions: { maxlength: 15 }, resizable: false, hidden: true},
            { name: "ActiveStatus", width: 35, editable: true, align: 'center', edittype: "checkbox", formatter: 'checkbox', editoptions: { value: "true:false" } },
            {
                name: 'edit', search: false, align: 'left', width: 100, sortable: false, resizable: false,
                formatter: function (cellValue, options, rowdata, action) {
                    return '<button class="btn-xs ui-button ui-widget ui-corner-all btn-jqgrid" title="Edit" id="jqgEdit" onclick="return fnEditRoomAminities(event,\'edit\');"><i class="fas fa-pen"></i> ' + localization.Edit + '</button>' +
                        '<button class="btn-xs ui-button ui-widget ui-corner-all btn-jqgrid" title="View" id="jqgView" onclick="return fnEditRoomAminities(event,\'view\');"><i class="far fa-eye"></i> ' + localization.View + '</button>' +
                        '<button class="btn-xs ui-button ui-widget ui-corner-all btn-jqgrid" title="Delete" id="jqgDelete" onclick="return fnEditRoomAminities(event,\'delete\');"><i class="fas fa-trash"></i> ' + localization.Delete + '</button >'
                }
            },
        ],

        pager: "#jqpRoomAmenities",
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

    }).jqGrid('navGrid', '#jqpRoomAmenities', { add: false, edit: false, search: false, del: false, refresh: false, refreshtext: 'Reload' }).jqGrid('navButtonAdd', '#jqpRoomAmenities', {
        caption: '<span class="fa fa-sync"></span> Refresh', buttonicon: "none", id: "custRefresh", position: "first", onClickButton: fnGridRefreshRoomAmenities
        }).jqGrid('navButtonAdd', '#jqpRoomAmenities', {
            caption: '<span class="fa fa-plus" data-toggle="modal"></span> Add', buttonicon: 'none', id: 'jqgAdd', position: 'first', onClickButton: fnAddRoomAminities
    });

    $(window).on("resize", function () {
        var $grid = $("#jqgRoomAmenities"),
            newWidth = $grid.closest(".RoomAmenitiescontainer").parent().width();
        $grid.jqGrid("setGridWidth", newWidth, true);
    });
    fnAddGridSerialNoHeading();
}

function fnAddRoomAminities() {
    $('#cboOptionType').attr('disabled', false).selectpicker('refresh');
    $('#txtSerialNumber').attr('readonly', false);
    fnClearFields();
   
    var id = $("#cboRoomTypeId").val();
    if (id === 0 || id === "0") {
        toastr.warning("Please select any Room Type to add");
        return;
    }
    else {
        _isInsert = true;
        fnClearFields();
        $('#PopupRoomAmenities').modal('show');
        $("#chkActiveStatus").parent().addClass("is-checked");
        $('#cboOptionType').val('0').selectpicker('refresh');
        $('#cboOptionType').attr('readonly', false).selectpicker('refresh');
        $('#txtSerialNumber').attr('readonly', false);
        $('#PopupRoomAmenities').find('.modal-title').text(localization.AddRoomAmenities);
        $("#btnSaveRoomAmenities").html('<i class="fa fa-save"></i>' + localization.Save);
        $("#chkActiveStatus").prop('disabled', true);
        $("#btnSaveRoomAmenities").show();
        $("#btndeActiveRoomAmenities").hide();
        
    }

}

var _isInsert = true;
function fnSaveRoomAminities() {

    if (IsStringNullorEmpty($("#cboOptionType").val())) {
        toastr.warning("Please Select Option Type");
        return;
    }
    if ($("#cboOptionType").val() === "0") {
        toastr.warning("Please Select Option Type");
        return;
    }
    if (IsStringNullorEmpty($("#txtSerialNumber").val())) {
        toastr.warning("Please Enter Serial Number");
        return;
    }
    //if (IsStringNullorEmpty($("#txtOptionValue").val())) {
    //    toastr.warning("Please Enter Option Value");
    //    return;
    //}

    //objroom = {
    //    RoomTypeId: $("#cboRoomTypeId").val(),
    //    OptionType: $("#cboOptionType").val(),
    //    SerialNumber: $("#txtSerialNumber").val(),
    //    OptionValues: $("#txtOptionValue").val(),
    //    OptionDesc: $("#txtOptionDesc").val(),
    //    ActiveStatus: $("#chkActiveStatus").parent().hasClass("is-checked")
    //};
    var obj = new FormData();
    //appending image file object
    obj.append("Imagefile", $("#Photoimage").get(0).files[0]);
    obj.append("RoomTypeId", document.getElementById("cboRoomTypeId").value);
    obj.append("OptionType", document.getElementById("cboOptionType").value);
    obj.append("SerialNumber", document.getElementById("txtSerialNumber").value);
    obj.append("OptionValues", document.getElementById("txtOptionValue").value);
    obj.append("OptionDesc", document.getElementById("txtOptionDesc").value);
    obj.append("ActiveStatus", $('#chkActiveStatus').parent().hasClass("is-checked"));
    obj.append("isInsert", _isInsert);
    $("#btnSaveRoomAmenities").attr("disabled", true);

    $.ajax({
        url: getBaseURL() + '/RoomAmenities/InsertOrUpdateRoomAmenities',
        type: "POST",
        data: obj,
        dataType: "json",
        contentType: false,
        processData: false,
        success: function (response) {
            if (response.Status) {
                toastr.success(response.Message);
                $("#btnSaveRoomAmenities").html('<i class="fa fa-spinner fa-spin"></i> wait');
                $("#PopupRoomAmenities").modal('hide');
                fnClearFields();
                fnGridRefreshRoomAmenities();
            }
            else {
                toastr.error(response.Message);
                $("#btnSaveRoomAmenities").attr("disabled", false);
            }
        },
        error: function (error) {
            toastr.error(error.statusText);
            $("#btnSaveRoomAmenities").attr("disabled", false);
        }
    });
}

function fnGridRefreshRoomAmenities() {
    $("#jqgRoomAmenities").setGridParam({ datatype: 'json', page: 1 }).trigger('reloadGrid');
}

function fnClearFields() {
    $("#divimage").hide();
    $("#divOptionValue").show();
    document.getElementById('Photoimage').value = "";
    $('#imgPhoto').attr('src', '');
    $("#cboOptionType").val("0").selectpicker('refresh');
    $("#cboOptionType").attr('readonly', false).selectpicker('refresh');
    $('#txtSerialNumber').val('');
    $('#txtSerialNumber').attr('readonly', false);
    $('#txtOptionValue').val('');
    $('#txtOptionDesc').val('');
    $("#chkActiveStatus").prop('disabled', true);
    $("#btnSaveRoomAmenities").attr("disabled", false);
    $("#btndeActiveRoomAmenities").attr("disabled", false);
}

$("#btnCancelRoomAmenities").click(function () {
    $("#jqgRoomAmenities").jqGrid('resetSelection');
    $('#PopupRoomAmenities').modal('hide');
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

function fnDeleteRoomAminities() {

    var a_status;
    //Activate or De Activate the status
    if ($("#chkActiveStatus").parent().hasClass("is-checked") === true) {
        a_status = false
    }
    else {
        a_status = true;
    }

    obj_roomami = {
        RoomTypeId: $("#cboRoomTypeId").val(),
        OptionType: $("#cboOptionType").val(),
        SerialNumber: $("#txtSerialNumber").val(),
        OptionValues: $("#txtOptionValue").val(),
        OptionDesc: $("#txtOptionDesc").val(),
        ActiveStatus: $("#chkActiveStatus").parent().hasClass("is-checked"),
        Status: a_status,
    };

    $("#btndeActiveRoomAmenities").attr("disabled", true);
    $.ajax({
        url: getBaseURL() + '/RoomAmenities/ActiveOrDeActiveRoomAmenities',
        type: 'POST',
        datatype: 'json',
        data: { objamenities: obj_roomami },
        success: function (response) {
            if (response.Status) {
                toastr.success(response.Message);
                $("#btndeActiveRoomAmenities").html('<i class="fa fa-spinner fa-spin"></i> wait');
                $("#PopupRoomAmenities").modal('hide');
                fnClearFields();
                fnGridRefreshRoomAmenities();
                $("#btndeActiveRoomAmenities").attr("disabled", false);
            }
            else {
                toastr.error(response.Message);
                $("#btndeActiveRoomAmenities").attr("disabled", false);
                $("#btndeActiveRoomAmenities").html('De Activate');
            }
        },
        error: function (error) {
            toastr.error(error.statusText);
            $("#btndeActiveRoomAmenities").attr("disabled", false);
            $("#btndeActiveRoomAmenities").html('De Activate');
        }
    });
}


function fnEditRoomAminities(e, actiontype) {
    //var rowid = $(e.target).parents("tr.jqgrow").attr('id');
    //var rowData = $('#jqgRoomAmenities').jqGrid('getRowData', rowid);

    //$('#cboRoomTypeId').val(rowData.RoomTypeId);
    //$('#cboRoomTypeId').selectpicker('refresh');
    //$('#PopupRoomAmenities').modal('show');
    //$('#cboOptionType').val(rowData.OptionType).selectpicker('refresh');
    //$('#cboOptionType').attr('readonly', true).selectpicker('refresh');
    //$('#txtSerialNumber').val(rowData.SerialNumber);
    //$('#txtSerialNumber').attr('readonly', true);
    //$('#txtOptionValue').val(rowData.OptionValues);
    //$('#txtOptionDesc').val(rowData.OptionDesc);

    //if (rowData.ActiveStatus == 'true') {
    //    $("#chkActiveStatus").parent().addClass("is-checked");
    //}
    //else {
    //    $("#chkActiveStatus").parent().removeClass("is-checked");
    //}

    $("#btnSaveRoomAmenities").attr("disabled", false);

    _isInsert = false;



    if (actiontype.trim() == "edit") {

        var rowid = $(e.target).parents("tr.jqgrow").attr('id');
        var rowData = $('#jqgRoomAmenities').jqGrid('getRowData', rowid);
        $('#cboRoomTypeId').val(rowData.RoomTypeId);
        $('#cboRoomTypeId').selectpicker('refresh');

        fnGetRoomAmenities(rowData);


         $('#cboOptionType').attr('disabled', true).selectpicker('refresh');
         $('#txtSerialNumber').attr('readonly', true);

        $('#PopupRoomAmenities').find('.modal-title').text(localization.UpdateRoomAmenities);
        $("#btnSaveRoomAmenities").html('<i class="fa fa-sync"></i>' + localization.Update);
        $("#btndeActiveRoomAmenities").hide();
        $("#chkActiveStatus").prop('disabled', true);
        $("#chkReadyForOccupancy").prop('disabled', false);
        $("#btnSaveRoomAmenities").attr("disabled", false);
    }

    if (actiontype.trim() == "view") {

        var rowid = $(e.target).parents("tr.jqgrow").attr('id');
        var rowData = $('#jqgRoomAmenities').jqGrid('getRowData', rowid);
        $('#cboRoomTypeId').val(rowData.RoomTypeId);
        $('#cboRoomTypeId').selectpicker('refresh');

        fnGetRoomAmenities(rowData);

        $('#PopupRoomAmenities').find('.modal-title').text(localization.ViewRoomAmenities);
        $("#btnSaveRoomAmenities").attr("disabled", false);
        $("input,textarea").attr('readonly', true);
        $("select").next().attr('disabled', true);
        $("#btnSaveRoomAmenities").hide();
        $("#btndeActiveRoomAmenities").hide();
        $("#chkActiveStatus").prop('disabled', true);

        $("#PopupRoomAmenities").on('hidden.bs.modal', function () {
            $("#btnSaveRoomAmenities").show();
            $("input,textarea").attr('readonly', false);
            $("select").next().attr('disabled', false);
        });
    }
    if (actiontype.trim() == "delete") {

        var rowid = $(e.target).parents("tr.jqgrow").attr('id');
        var rowData = $('#jqgRoomAmenities').jqGrid('getRowData', rowid);
        $('#cboRoomTypeId').val(rowData.RoomTypeId);
        $('#cboRoomTypeId').selectpicker('refresh');

        fnGetRoomAmenities(rowData);

        $('#PopupRoomAmenities').find('.modal-title').text("Activate/De Activate Room Amenities");
        $("#btnSaveRoomAmenities").attr("disabled", false);
        $("input,textarea").attr('readonly', true);
        $("select").next().attr('disabled', true);
        $("#btnSaveRoomAmenities").hide();

        if (rowData.ActiveStatus == 'true') {
            $("#btndeActiveRoomAmenities").html(localization.DActivate);
        }
        else {
            $("#btndeActiveRoomAmenities").html(localization.Activate);
        }

        $("#btndeActiveRoomAmenities").show();
        $("#chkActiveStatus").prop('disabled', true);
        $("#PopupRoomAmenities").on('hidden.bs.modal', function () {
            $("#btnSaveRoomAmenities").show();
            $("input,textarea").attr('readonly', false);
            $("select").next().attr('disabled', false);
        });
    }
}




function fnGetRoomAmenities(data) {
    if (data != null) {

        $.ajax({
            url: getBaseURL() + '/RoomAmenities/GetRoomAmenitiesbyroomtype?roomTypeId=' + data.RoomTypeId + '&optionType=' + data.OptionType
                + '&serilalNo=' + data.SerialNumber,
            type: 'GET',
            datatype: 'json',
            success: function (response) {

                if (response != null) {

                    fnFillRoomAmenities(response);
                }
                else {
                    fnClearFields();

                }

            },
            error: function (error) {
                toastr.error(error.statusText);

            }
        });
    }
}


function fnFillRoomAmenities(data) {


    $('#cboRoomTypeId').val(data.RoomTypeId);
    $('#cboRoomTypeId').selectpicker('refresh');
    $('#PopupRoomAmenities').modal('show');
    $('#cboOptionType').val(data.OptionType).selectpicker('refresh');
    //$('#cboOptionType').attr('readonly', true).selectpicker('refresh');
    $('#txtSerialNumber').val(data.SerialNumber);
    //$('#txtSerialNumber').attr('readonly', true);
    $('#txtOptionValue').val(data.OptionValues);
    $('#txtOptionDesc').val(data.OptionDesc);

    if (data.ProfileImagePath != null) {
        $('#imgPhotoimageblah').attr('src','/'+ data.ProfileImagePath);
      

    }
    else {
        $('#imgPhotoimageblah').attr('src', '');

    }

    if (data.OptionType == "IMG")
    {
        $("#divimage").show();
        $("#divOptionValue").hide();
      
    }
    else {
        $("#divimage").hide();
        $("#divOptionValue").show();
       
    }

    if (data.ActiveStatus == true)
        $('#chkActiveStatus').parent().addClass("is-checked");
    else
        $('#chkActiveStatus').parent().removeClass("is-checked");

    //$("#btnSaveDoctorDetails").html('<i class="fa fa-sync"></i>' + localization.Update);
}