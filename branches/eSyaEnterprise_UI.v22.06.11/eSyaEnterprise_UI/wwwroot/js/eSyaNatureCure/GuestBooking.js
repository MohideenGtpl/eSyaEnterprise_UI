﻿$(document).ready(function () {
    //fnSetCurrentdate();
    fnGridLoadGuestBookingDetails();
});

function fnGridLoadGuestBookingDetails() {

   
    $("#jqgGuestBookingDetail").GridUnload();

    $("#jqgGuestBookingDetail").jqGrid({
        url: getBaseURL() + '/GuestBooking/GetGuestBookingBySearchCreteria?roomTypeId=' + $("#cboRoomTypeId").val() + '&roomNumber=' + $("#cboRoomNumber").val()
            + '&bedNumber=' + $("#cboBedNumber").val() + '&occupancyType=' + $("#cboOccupancyType").val() + '&gender=' + $("#cboGender").val() + '&bookingFrom=' + $("#txtBookedfromdate").val()
            + '&bookingTo=' + $("#txtBookedtodate").val() + '&checkInDate=' + $("#txtCheckIndate").val() + '&checkOutDate=' + $("#txtCheckOutdate").val(),

        datatype: 'json',
        mtype: 'POST',
        contentType: 'application/json; charset=utf-8',
        ajaxGridOptions: { contentType: 'application/json; charset=utf-8' },
        colNames: ["BookingKey", "GuestId", "First Name", "Last Name", "Age", "MobileNo", "Gender", "Booking Date", "Check In Date", "Check Out Date", "Payment Method", "Net Package Amount", "Payment Received", "RoomTypeId", "Room Type", "Room Number", "Bed Number", "PackagePrice", "Occupancy Type","View"],
        colModel: [
            { name: "BookingKey", width: 10, align: 'left', editable: true, editoptions: { maxlength: 10 }, resizable: false, hidden: true },
            { name: "GuestId", width: 10, align: 'left', editable: true, editoptions: { maxlength: 10 }, resizable: false, hidden: true },
            { name: "FirstName", width: 30, align: 'left', editable: true, editoptions: { maxlength: 15 }, resizable: false },
            { name: "LastName", width: 30, align: 'left', editable: true, editoptions: { maxlength: 15 }, resizable: false },
            { name: "Age", width: 30, align: 'left', editable: true, editoptions: { maxlength: 15 }, resizable: false },
            { name: "MobileNo", width: 30, align: 'left', editable: true, editoptions: { maxlength: 15 }, resizable: false },
            { name: "Gender", editable: true, align: 'left', width: 30, edittype: "select", resizable: false, formatter: 'select', editoptions: { value: "M: Male;F: Female;B: Both;" } },
            { name: "BookingDate", width: 50, editable: true, align: 'center', hidden: false, formatter: 'date', formatoptions: { srcformat: 'Y/m/d H:i:s', newformat: 'd/m/Y' } },
            { name: "CheckInDate", width: 50, editable: true, align: 'center', hidden: false, formatter: 'date', formatoptions: { srcformat: 'Y/m/d H:i:s', newformat: 'd/m/Y' } },
            { name: "CheckOutDate", width: 50, editable: true, align: 'center', hidden: false, formatter: 'date', formatoptions: { srcformat: 'Y/m/d H:i:s', newformat: 'd/m/Y' } },
            { name: "PaymentMethod", editable: true, align: 'left', width: 40, edittype: "select", resizable: false, formatter: 'select', editoptions: { value: "C: Pay At Receiption;N: Pay Online;" } },
            { name: "NetPackageAmount", width: 30, align: 'left', editable: true, editoptions: { maxlength: 15 }, resizable: false },
            { name: "PaymentReceived", width: 35, editable: true, align: 'center', edittype: "checkbox", formatter: 'checkbox', editoptions: { value: "true:false" } },
            { name: "RoomTypeId", width: 30, align: 'left', editable: true, editoptions: { maxlength: 15 }, resizable: false, hidden: true },
            { name: "RoomTypeName", width: 30, align: 'left', editable: true, editoptions: { maxlength: 15 }, resizable: false },
            { name: "RoomTypeNumber", width: 30, align: 'left', editable: true, editoptions: { maxlength: 15 }, resizable: false },
            { name: "BedNumber", width: 30, align: 'left', editable: true, editoptions: { maxlength: 15 }, resizable: false },
            { name: "PackagePrice", width: 30, align: 'left', editable: true, editoptions: { maxlength: 15 }, resizable: false },
            { name: "OccupancyType", editable: true, align: 'left', width: 40, edittype: "select", resizable: false, formatter: 'select', editoptions: { value: "T: Sharing;C: Clubbed;S: Single;" } },
            {
                name: 'edit', search: false, align: 'left', width: 50, sortable: false, resizable: false,
                formatter: function (cellValue, options, rowdata, action) {
                    return '<button class="btn-xs ui-button ui-widget ui-corner-all btn-jqgrid" title="View" id="jqgView" onclick="return fnViewGuestBooking(event,\'view\');"><i class="far fa-eye"></i> ' + "View" + '</button>' 
                       
                }
            },
        ],

        //pager: "#jqpGuestBookingDetail",
        //rowNum: 10,
        //rowList: [10, 20, 50, 100],
        //rownumWidth: '55',
        //loadonce: true,
        //viewrecords: true,
        //gridview: true,
        //rownumbers: true,
        //height: 'auto',
        //scroll: false,
        //width: 'auto',
        //autowidth: true,
        //shrinkToFit: true,
        //forceFit: true,

        rowNum: 100000,
        viewrecords: true,
        gridview: true,
        rownumbers: true,
        scroll: false,
        loadonce: true,
        width: 'auto',
        height: 'auto',
        autowidth: true,
        shrinkToFit: true,
        forceFit: false,
        pager: "#jqpGuestBookingDetail",
        onSelectRow: function (rowid) {

        },

    });

}

function fnSetCurrentdate() {
    var date = new Date();

    var day = date.getDate();
    var month = date.getMonth() + 1;
    var year = date.getFullYear();

    if (month < 10) month = "0" + month;
    if (day < 10) day = "0" + day;

    var today = year + "-" + month + "-" + day;
    document.getElementById("txtBookedfromdate").value = today;
    document.getElementById("txtBookedtodate").value = today;
    document.getElementById("txtCheckIndate").value = today;
    document.getElementById("txtCheckOutdate").value = today;
}

function fnClearFields() {
    //fnSetCurrentdate();
    $('#cboRoomTypeId').val('0').selectpicker('refresh');
    $('#cboRoomNumber').val('0').selectpicker('refresh');
    $('#cboBedNumber').val('0').selectpicker('refresh');
    $('#cboOccupancyType').val('0').selectpicker('refresh');
    $('#cboGender').val('0').selectpicker('refresh');
    $('#txtBookedfromdate').val('');
    $('#txtBookedtodate').val('');
    $('#txtCheckIndate').val('');
    $('#txtCheckOutdate').val('');
}


function fnViewGuestBooking(e, actiontype)
{
    var rowid = $(e.target).parents("tr.jqgrow").attr('id');
    var rowData = $('#jqgGuestBookingDetail').jqGrid('getRowData', rowid);

    var url = getBaseURL() + '/eSyaNatureCure/CheckInGuest/V_ENC_04_00?bookingKey=' + rowData.BookingKey + '&guestId=' + rowData.GuestId;
    
    window.location.href = url;
}

