function getPatientInfo(uhid) {
    $.get(getBaseURL() + '/PatientInfo/GetPatientProfileByUHID', {
        uhid: uhid
    }, function (data, status) {
        return data;
        });
    return null;
}