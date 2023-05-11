function getPatientInfo(uhid) {
    $.get(getBaseURL() + '/PatientInfo/GetPatientProfileByUHID', {
        uhid: uhid
    }, function (data, status) {
        $("#txtFirstName").val(data.FirstName);
        $("#txtMiddleName").val(data.MiddleName);
        $("#txtLastName").val(data.LastName);
        $("#cboGender").val(data.Gender);
        $("#cboGender").selectpicker("refresh");
        $("#txtDateOfBirth").val(data.DateOfBirth);
        $("#txtDateOfBirthYY").val(data.AgeYY);
        $("#txtDateOfBirthMM").val(data.AgeMM);
        $("#txtDateOfBirthDD").val(data.AgeDD);
        $("#txtEmail").val(data.eMailID);
        $("#cboNationality").val(data.Nationality);
        $("#cboNationality").selectpicker("refresh");
        if (data.CurrentPatientAddress != null) {
            $("#txtAddress").val(data.CurrentPatientAddress.Address);
            $("#cboCity").val(data.CurrentPatientAddress.CityCode);
            $("#cboCity").selectpicker("refresh");
            $("#cboArea").val(data.CurrentPatientAddress.AreaCode);
            $("#cboArea").selectpicker("refresh");
        }
        });
    return null;
}