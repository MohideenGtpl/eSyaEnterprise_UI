
function fncboLocation_change() {
    fnClearDoctorAddress();

    fnBindISDCodes();
    //fnBindISDCodes();
    
    //$("#txtIsdcode").val(_cnfISDCode);
    //$("#txtIsdcode").attr('readonly', true);
    //BindStates();
    //$("#txtIsdcode").attr('readonly', true);

}

$('input[name="zipcode"]').keyup(function (e) {
    if (/\D/g.test(this.value)) {
        // Filter non-digits from input value.
        this.value = this.value.replace(/\D/g, '');
    }
});

function fnGetDoctorAddressbyDoctorId() {


    if (!IsStringNullorEmpty($("#txtIsdcode").val())) {

        $.ajax({
            url: getBaseURL() + '/Doctors/GetDoctorAddressDoctorId?Isdcode=' + $("#txtIsdcode").val() + '&doctorId=' + $("#txtDoctorId").val(),
            type: 'GET',
            dataType: 'json',
            contentType: 'application/json; charset=utf-8',
            error: function (xhr) {
                toastr.error('Error: ' + xhr.statusText);
            },
            success: function (response) {
                if (response != null) {
                    fnClearDoctorAddress();
                    BindStates();
                    $('#cboState').val(response.StateCode).selectpicker('refresh');
                    BindCities();
                    $('#cboCity').val(response.CityCode).selectpicker('refresh');
                    BindZipDescriptions();
                    $('#cboZipDesc').val(response.ZipserialNumber).selectpicker('refresh');
                    $('#txtZipCode').val(response.Zipcode);
                    $('#txtAddress').val(response.Address);
                    $('#txtArea').val(response.Area); 
                }
            },
            async: false,
            processData: false
        });

    }
}

function fnClearDoctorAddress() {
    $("#cboState").val('0').selectpicker('refresh');
    $("#cboCity").val('0').selectpicker('refresh');
    $("#cboZipDesc").val('0').selectpicker('refresh');
    $("#txtZipCode").val('');
    $("#txtAddress").val('');
    $("#txtArea").val('');
    $("#btnSaveDoctorProfileAddress").attr("disabled", false);
    $("#btnSaveDoctorProfileAddress").html('Save');
}

function fncboState_change() {
    BindCities();
    BindZipDescriptions();
}

function fncboCity_change() {
    BindZipDescriptions();
}

function fncboZipDesc_change() {

    fnBindZipCodeAndArea();
    //$("#txtPinCode").val($(':selected', $('#cboArea')).data('pincode'));
}

function BindStates() {

    $("#cboState").empty();

    $.ajax({
        url: getBaseURL() + '/Doctors/GetStatesbyIsdCode?Isdcode=' + $("#txtIsdcode").val(),
        type: 'GET',
        dataType: 'json',
        contentType: 'application/json; charset=utf-8',
        error: function (xhr) {
            toastr.error('Error: ' + xhr.statusText);
        },
        success: function (response, data) {
            if (response != null) {
                //refresh each time
                $("#cboState").empty();
                $("#cboState").append($("<option value='0'> Select </option>"));
                for (var i = 0; i < response.length; i++) {

                    $("#cboState").append($("<option></option>").val(response[i]["StateCode"]).html(response[i]["StateDesc"]));
                }
                $('#cboState').selectpicker('refresh');
            }
            else {
                $("#cboState").empty();
                $("#cboState").append($("<option value='0'> Select </option>"));
                $('#cboState').selectpicker('refresh');
            }
        },
        async: false,
        processData: false
    });


}

function BindCities() {

    $("#cboCity").empty();
    $.ajax({
        url: getBaseURL() + '/Doctors/GetCitiesbyStateCode?Isdcode=' + $("#txtIsdcode").val() + '&statecode=' + $("#cboState").val(),
        type: 'GET',
        dataType: 'json',
        contentType: 'application/json; charset=utf-8',
        error: function (xhr) {
            toastr.error('Error: ' + xhr.statusText);
        },
        success: function (response, data) {
            if (response != null) {
                //refresh each time
                $("#cboCity").empty();

                $("#cboCity").append($("<option value='0'> Select </option>"));
                for (var i = 0; i < response.length; i++) {

                    $("#cboCity").append($("<option></option>").val(response[i]["CityCode"]).html(response[i]["CityDesc"]));
                }
                $('#cboCity').selectpicker('refresh');
            }
            else {
                $("#cboCity").empty();
                $("#cboCity").append($("<option value='0'> Select </option>"));
                $('#cboCity').selectpicker('refresh');
            }
        },
        async: false,
        processData: false
    });


}

function BindZipDescriptions() {
    $("#txtArea").val('');
    $("#cboZipDesc").empty();
    $.ajax({

        url: getBaseURL() + '/Doctors/GetZipDescriptionbyCityCode?Isdcode=' + $("#txtIsdcode").val() + "&StateCode=" + $('#cboState').val()
            + "&CityCode=" + $('#cboCity').val(),
        type: 'GET',
        dataType: 'json',
        contentType: 'application/json; charset=utf-8',
        error: function (xhr) {
            toastr.error('Error: ' + xhr.statusText);
        },
        success: function (response, data) {

            if (response != null) {
                //refresh each time
                $("#cboZipDesc").empty();
                $("#cboZipDesc").append($("<option value='0'> Select </option>"));
              
                for (var i = 0; i < response.length; i++) {
                    $("#cboZipDesc").append($("<option></option>").val(response[i]["ZipserialNumber"]).html(response[i]["ZipDesc"]));
                }
                $('#cboZipDesc').selectpicker('refresh');

            } else {
                $("#cboZipDesc").empty();
                $("#cboZipDesc").append($("<option value='0'> Select </option>"));
                $('#cboZipDesc').selectpicker('refresh');
            }
        },

        async: false,
        processData: false
    });
}

function fnBindZipCodeAndArea() {

    $("#txtArea").val('');
    $("#txtZipCode").val('');

    $.ajax({
        url: getBaseURL() + '/Doctors/GetZipCodeAndArea?Isdcode=' + $("#txtIsdcode").val() + "&StateCode=" + $('#cboState').val()
            + "&CityCode=" + $('#cboCity').val() + "&zipserialno=" + $('#cboZipDesc').val(),
        type: 'GET',
        dataType: 'json',
        contentType: 'application/json; charset=utf-8',
        error: function (xhr) {
            toastr.error('Error: ' + xhr.statusText);
        },
            success: function (result) {
                if (result != null) {
                    $("#txtZipCode").val(result.Zipcode);
                    $("#txtArea").val(result.Area); 
                }

                else {
                    $("#txtZipCode").val('');
                    $("#txtArea").val('');
                }
        },
        async: false,
        processData: false
    });


}

$('#txtZipCode').blur(function () {

    if (!IsStringNullorEmpty($("#txtZipCode").val())) {
        $.ajax({
            url: getBaseURL() + '/Doctors/FillCoumbosbyZipCode?Isdcode=' + $("#txtIsdcode").val() + '&zipcode=' + $("#txtZipCode").val(),
            type: 'GET',
            dataType: 'json',
            contentType: 'application/json; charset=utf-8',
            success: function (result) {
                if (result != null) {
                     BindStates();
                    $('#cboState').val(result.StateCode);
                    $('#cboState').selectpicker('refresh');
                    BindCities();
                    $('#cboCity').val(result.CityCode);
                    $('#cboCity').selectpicker('refresh');
                    BindZipDescriptions();
                    if ($('#cboZipDesc').children('option').length > 2)
                        $('#cboZipDesc').val("0");
                    else
                        $('#cboZipDesc').val(result.ZipserialNumber);
                    $('#cboZipDesc').selectpicker('refresh');
                    $('#txtArea').val(result.Area);
                }

                else {
                    $('#cboState').selectpicker('refresh');
                    $('#CityCode').selectpicker('refresh');
                    $('#cboZipDesc').selectpicker('refresh');
                }
            },
            error: function (result) {
                //Your error message
                $('#cboState').selectpicker('refresh');
                $('#CityCode').selectpicker('refresh');
                $('#cboZipDesc').selectpicker('refresh');
            },
            async: false,
            processData: false
        });
    }
    else {
        var cityCode = $('#cboCity').val();
        BindCities();
        $('#cboCity').val(cityCode);
        $('#cboCity').selectpicker('refresh');
        BindZipDescriptions();
    }

});

function fnSaveDoctorProfileAddress() {

    if (IsValidSaveDoctorAddress() === false) {
        return;
    }

    var obj = {
        BusinessKey: $("#cboLocation").val(),
        Isdcode: $("#txtIsdcode").val(),
        DoctorId: $('#txtDoctorId').val(),
        StateCode: $("#cboState").val(),
        CityCode: $("#cboCity").val(),
        ZipserialNumber: $('#cboZipDesc').val(),
        Area: $("#txtArea").val(),
        Zipcode: $("#txtZipCode").val(),
        Address: $("#txtAddress").val(),
        Pobox: null,
        ActiveStatus:true

    }; 
    $("#btnSaveDoctorProfileAddress").attr('disabled', true);
    $.ajax({
        url: getBaseURL() + '/Doctors/InsertOrUpdateIntoDoctorProfileAddress',
        type: 'POST',
        datatype: 'json',
        data: { obj },
        success: function (response) {
            if (response.Status) {
                toastr.success(response.Message);
                $("#btnSaveDoctorProfileAddress").attr('disabled', false);
                fnClearDoctorAddress();
                return true;
            }
            else {
                toastr.error(response.Message);
                $("#btnSaveDoctorProfileAddress").attr('disabled', false);
                return false;
            }

        },
        error: function (error) {
            toastr.error(error.statusText);
            $("#btnSaveDoctorProfileAddress").attr('disabled', false);
        }
    });

}

function IsValidSaveDoctorAddress() {

    if (IsStringNullorEmpty($("#cboLocation").val()) || $("#cboLocation").val() === "0" || $("#cboLocation").val() == '0') {
        toastr.warning("Please select any Location");
        return false;
    }
    if (IsStringNullorEmpty($("#txtIsdcode").val()) || $("#txtIsdcode").val() === "0" || $("#txtIsdcode").val() == '0') {
        toastr.warning("ISD Code is required");
        return false;
    }
    if (IsStringNullorEmpty($("#txtDoctorId").val()) || $("#txtDoctorId").val() === "0") {
        toastr.warning("Please create the Doctor First");
        return false;
    }


    if (IsStringNullorEmpty($("#cboState").val()) || $("#cboState").val() == '0' || $("#cboState").val() == "0") {
        toastr.warning("Please Select State");
        return false;
    }
    if (IsStringNullorEmpty($("#cboCity").val()) || $("#cboCity").val() == '0' || $("#cboCity").val() == "0") {
        toastr.warning("Please Select City");
        return false;
    }
    if (IsStringNullorEmpty($("#cboZipDesc").val()) || $("#cboZipDesc").val() == '0' || $("#cboZipDesc").val() == "0") {
        toastr.warning("Please Select Zip");
        return false;
    }
}

function fnBindDoctorBusinessLinkList() {

    $("#cboLocation").empty();

    $.ajax({
        url: getBaseURL() + '/Doctors/GetDoctorLinkWithBusinessLocation?doctorId=' + $("#txtDoctorId").val(),
        type: 'POST',
        dataType: 'json',
        contentType: 'application/json; charset=utf-8',
        error: function (xhr) {
            toastr.error('Error: ' + xhr.statusText);
        },
        success: function (response, data) {
            if (response != null) {
                //refresh each time
                $("#cboLocation").empty();
                $("#cboLocation").append($("<option value='0'> Select </option>"));
                for (var i = 0; i < response.length; i++) {

                    $("#cboLocation").append($("<option></option>").val(response[i]["BusinessKey"]).html(response[i]["BusinessLocation"]));
                }
                $('#cboLocation').selectpicker('refresh');
            }
            else {
                $("#cboLocation").empty();
                $("#cboLocation").append($("<option value='0'> Select </option>"));
                $('#cboLocation').selectpicker('refresh');
            }
        },
        async: false,
        processData: false
    });


}

function fnBindISDCodes() {
    $("#txtIsdcode").empty();

    $.ajax({
        url: getBaseURL() + '/Doctors/GetISDCodesbyBusinessKey?businessKey=' + $("#cboLocation").val(),
        type: 'GET',
        dataType: 'json',
        contentType: 'application/json; charset=utf-8',
        error: function (xhr) {
            toastr.error('Error: ' + xhr.statusText);
        },

        success: function (data) {
            if (data != null) {
                //refresh each time
                $("#txtIsdcode").empty();
                $("#txtIsdcode").append($("<option value='0'> Select </option>"));
                for (var i = 0; i < data.length; i++) {

                    $("#txtIsdcode").append($("<option></option>").val(data[i]["Isdcode"]).html(data[i]["CountryName"]));

                    //$("#txtIsdcode").append($("<option></option>").val(data[i]["Isdcode"]).text(data[i]["Isdcode"] + '-' + data[i]["CountryName"]));
                }
                $("#txtIsdcode").val(_cnfISDCode);
                $('#txtIsdcode').selectpicker('refresh');
            }
            else {
                $("#txtIsdcode").empty();
                $("#txtIsdcode").append($("<option value='0'> Select </option>"));
                $("#txtIsdcode").val(_cnfISDCode);
                $('#txtIsdcode').selectpicker('refresh');
            }
        },
        async: false,
        processData: false
    });

}

function fnISD_change() {
    BindStates();
} 