#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\DoctorScheduler\Views\Appointment\_Confirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1647db384b9107e401e3fce4a42613d321cf4dde"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_DoctorScheduler_Views_Appointment__Confirmation), @"mvc.1.0.view", @"/Areas/DoctorScheduler/Views/Appointment/_Confirmation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/DoctorScheduler/Views/Appointment/_Confirmation.cshtml", typeof(AspNetCore.Areas_DoctorScheduler_Views_Appointment__Confirmation))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1647db384b9107e401e3fce4a42613d321cf4dde", @"/Areas/DoctorScheduler/Views/Appointment/_Confirmation.cshtml")]
    public class Areas_DoctorScheduler_Views_Appointment__Confirmation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(120, 2937, true);
            WriteLiteral(@"
<style>


    .v-bottom {
        vertical-align: text-bottom
    }

    .ui-autocomplete-loading {
        background: white url(""/images/ui-anim_basic_16x16.gif"") right center no-repeat;
    }

    .ui-autocomplete {
        z-index: 1059;
        height: 300px;
        overflow-y: scroll;
        overflow-x: hidden;
    }
</style>

<input asp-for=""ProductId"" type=""hidden"" />

<div class=""row blur"">

    <div class=""col-lg-12 col-md-12 col-sm-12"">
        <section class=""AppointmentSectionBox"">
            <div class=""row rowBox p-y-10"">
                <div class=""col-lg-1 col-md-2 col-sm-1"">
                    <span id=""DoctorIcon""><i class=""fas fa-user-md""></i></span>

                </div>
                <div class=""col-lg-6 col-md-6 col-sm-5"">
                    <label class=""c-black doctorname"" id=""lblDoctorName"">Dr.</label>
                    <label class=""c-grey specialty"" id=""lblSpecialty""></label>
                    <label class=""c-grey specialty"" id=""lblDo");
            WriteLiteral(@"ctorQualification""></label>
                </div>
                <div class=""col-lg-5 col-md-4 col-sm-6 border-left"">
                    <span class=""d-block f-11""><i class=""far fa-hospital""></i> <label class=""d-inline-block""> </label> <label id=""lblClinicType"" class=""d-inline-block f-11""></label></span>
                    <span class=""d-block f-11""><i class=""far fa-calendar-alt""></i> On <label id=""lblAppointmentDate"" class=""d-inline-block f-11""></label></span>
                    <span class=""d-block f-11""><i class=""far fa-clock""></i> At <label id=""lblAppointmentTime"" class=""d-inline-block f-11""></label> </span>
                </div>
            </div>


        </section>
    </div>
    <div class=""col-lg-12 col-md-12 col-sm-12"">
        <section class=""AppointmentSectionBox"">
            <div class=""row padtop10"">
                <div class=""col-lg-6 col-md-6 col-sm-4 col-4 form-group"">
                    <label>Episode Type</label>
                    <select class=""form-control"" id");
            WriteLiteral(@"=""cboEpisodeType"">
                        <option disabled>Choose Episode</option>
                        <option value=""N"" selected>New Consultation</option>
                        <option value=""R"">Follow-Up</option>
                    </select>
                </div>
                <div class=""col-lg-4 col-md-4 col-sm-4 col-4 form-group"">
                    <label>Patient Search</label>
                    <input id=""cboApptPatientSearch"" type=""text"" class=""form-control"">
                </div>
                <div class=""col-lg-2 col-md-2 col-sm-4 col-4 form-group"">
                    <label>Patient Id</label>
                    <input type=""text"" name=""int"" id=""txtUHID"" value="""" class=""form-control"" readonly hidden />
                    <input type=""text"" name=""int"" id=""txtPatientID"" value="""" class=""form-control"" readonly />
                </div>
");
            EndContext();
            BeginContext(3288, 1193, true);
            WriteLiteral(@"            </div>
            <div class=""row"">
                <div class=""col-lg-6 col-md-6 col-sm-6 form-group"">
                    <label>First Name</label>
                    <input type=""text"" name=""text"" id=""txtFirstName"" value="""" class=""form-control"" autocomplete=""on"" />
                </div>
                <div class=""col-lg-6 col-md-6 col-sm-6 form-group"" hidden>
                    <label>Middle Name</label>
                    <input type=""text"" name=""text"" id=""txtMiddleName"" value="""" class=""form-control"" autocomplete=""on"" />
                </div>
                <div class=""col-lg-6 col-md-6 col-sm-6 form-group"">
                    <label>Last Name</label>
                    <input type=""text"" name=""text"" id=""txtLastName"" value="""" class=""form-control"" autocomplete=""on"" />
                </div>

                <div class=""col-lg-3 col-md-3 col-sm-3 form-group"">
                    <label>Gender</label>
                    <select class=""form-control"" id=""cboGender"">
   ");
            WriteLiteral("                     <option>Choose gender</option>\r\n                        <option value=\"M\">Male</option>\r\n                        <option value=\"F\">Female</option>\r\n");
            EndContext();
            BeginContext(4549, 446, true);
            WriteLiteral(@"                    </select>
                </div>


                <div class=""col-lg-3 col-md-3 col-sm-3 form-group"">
                    <label>Date of Birth</label>
                    <input type=""date"" name=""text"" id=""txtDateOfBirth"" value="""" class=""form-control"" />
                </div>
                <div class=""col-lg-6 col-md-6 col-sm-6 form-group"">
                    <label>Mobile Number</label>
                    ");
            EndContext();
            BeginContext(4996, 74, false);
#line 104 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\DoctorScheduler\Views\Appointment\_Confirmation.cshtml"
               Write(await Component.InvokeAsync("IsdMobileInput", new { id = "MobileNumber" }));

#line default
#line hidden
            EndContext();
            BeginContext(5070, 1393, true);
            WriteLiteral(@"
                </div>
                <div class=""col-lg-6 col-md-6 col-sm-6 form-group"">
                    <label>Secondary Mobile</label>
                    <input type=""text"" id=""txtSecondaryMobileNumber"" class=""form-control"">
                </div>
                <div class=""col-lg-6 col-md-6 col-sm-6 form-group"">
                    <label>Email ID</label>
                    <input type=""text"" name=""text"" id=""txtEmailID"" value="""" class=""form-control email"" autocomplete=""on"" />
                </div>

                <div class=""col-lg-6 col-md-6 col-sm-6 form-group"" hidden>
                    <label class=""col-md-6 d-inline v-bottom"" style=""padding-left: 0px;""> <input type=""checkbox"" name=""IsSponsored"" value=""S"" onchange=""fnIsSponsored_changed()"" /> Is Sponsored</label>
                    <div style=""margin-top: -5px;"">
                        <select class=""selectpicker"" data-live-search=""true"" id=""cboCustomer"" title="""" disabled>
                            <option value="""" selec");
            WriteLiteral(@"ted>Choose a Insurance</option>
                        </select>
                    </div>
                </div>
                <div class=""col-lg-6 col-md-6 col-sm-12 form-group"">
                    <label> Reffered By</label>
                    <select class=""selectpicker"" id=""cboReferredBy"">
                        <option value=null>Select</option>
");
            EndContext();
            BeginContext(6527, 14102, true);
            WriteLiteral(@"                    </select>
                </div>
                <div class=""col-lg-6 col-md-6 col-sm-12 form-group"" hidden>
                    <label> Request Channel</label>
                    <select class=""selectpicker"" id=""cboRequestChannel"">
                        <option value=null>Select</option>
                        <option value=""1"">Clinic</option>
                    </select>
                </div>
                <div class=""col-lg-6 col-md-6 col-sm-12 col-12 form-group"">
                    <label>Comments </label>
                    <input type=""text"" name=""text"" id=""txtReason"" value="""" class=""form-control"" autocomplete=""on"" />
                </div>
            </div>

        </section>
    </div>

</div>


<script>


    $(document).ready(function () {
        $(""#cboApptPatientSearch"").autocomplete({
            source: getBaseURL() + '/Appointment/GetPatientSearch',
            minLength: 3,
            select: function (event, ui) {
                ");
            WriteLiteral(@"$('#txtUHID').val(ui.item.HospitalNumber);
                $('#txtPatientID').val(ui.item.PatientID);
                $('#txtFirstName').val(ui.item.FirstName);
                $('#txtLastName').val(ui.item.LastName);
                $('#cboGender').val(ui.item.Gender);
                $('#txtDateOfBirth').val(fnFormatDateJsonToInput(new Date(ui.item.DateOfBirth)));
                $('#txtMobileNumber').val(ui.item.MobileNumber);
                $('#txtEmailID').val(ui.item.eMailID);

            }
        });

        $(""#txtSecondaryMobileNumber"").inputmask({ ""mask"": ""99999999999"" });

        $.get(getBaseURL() + '/Appointment/GetEpisodeType',
            function (data) {
                var s = '<option value=""-1"" disabled>select</option>';
                for (var i = 0; i < data.length; i++) {
                    s += '<option value=""' + data[i].EpisodeId + '"" >' + data[i].EpisodeDesc + '</option>';
                }
                $(""#cboEpisodeType"").html(s);
                $(""");
            WriteLiteral(@"#cboEpisodeType"").selectpicker('refresh');
            });

        $.get(getBaseURL() + '/Appointment/GetReferredBy',
            function (data) {
                var s = '<option value=""-1"" disabled>select</option>';
                for (var i = 0; i < data.length; i++) {
                    s += '<option value=""' + data[i].ApplicationCode + '"" >' + data[i].CodeDesc + '</option>';
                }
                $(""#cboReferredBy"").html(s);
                $(""#cboReferredBy"").selectpicker('refresh');
            });

    });

    function fnShowAppointmentConfirmation() {

       
        $(""#btnSaveAppointment"").attr('disabled', false);

        $('#lblClinicType').text($('#cboClinicType option:selected').text());
        $('#lblDoctorName').text(_doctorName);
        $('#lblDoctorQualification').text("""");
        $('#lblSpecialty').text(_specialtyName);

        _appDate = new Date(_appDate);
        $('#lblAppointmentDate').text(_appDate.toDateString());
        $('#lblAppoi");
            WriteLiteral(@"ntmentTime').text(_appTime.toLocaleTimeString());

        $(""#cboApptPatientSearch"").val("""");
        $('#cboEpisodeType').val(""C"");
        $('#cboEpisodeType').selectpicker('refresh');
        $('#txtUHID').val("""");
        $('#txtPatientID').val("""");
        $('#txtFirstName').val("""");
        $('#txtLastName').val("""");
        $('#cboGender').val("""");
        $('#txtDateOfBirth').val("""");
        $('#txtMobileNumber').val("""");
        $('#txtSecondaryMobileNumber').val("""");
        $('#txtEmailID').val("""");

        $('input[name=""IsSponsored""][value=""S""]').prop('checked', false);
        $('#cboCustomer').val("""");
        $(""#cboCustomer"").attr('disabled', true);
        $('#cboCustomer').selectpicker('refresh');

        $('#cboReferredBy').val("""");
        $('#cboReferredBy').selectpicker('refresh');

        $('#cboRequestChannel').val(""1"");
        $('#cboRequestChannel').selectpicker('refresh');

        $('#txtReason').val("""");

        if (_appKey > 0) {
            i");
            WriteLiteral(@"f (!GetAppointmentPatientDetail(_appKey))
                return;
        }
        else {
            $('#cboEpisodeType').val($(':selected', $('#cboClinicType')).data('consultationtypecode'));
            $('#cboEpisodeType').selectpicker('refresh');

            if ($('#cboEpisodeType').val() !== ""N"") {
                $('#cboReferredBy').val(""150008"");
                $('#cboReferredBy').selectpicker('refresh');
            }
        }

       $('#PopupAppointmentScheduler').modal('show');
        
       // fnBottomSheets("".fc-widget-content"", ""#dvsheet"");
         
    }

    function fnIsSponsored_changed() {
        if ($('input[name=""IsSponsored""]:checked').val() == ""S"") {
            $(""#cboCustomer"").attr('disabled', false);
            $('#cboCustomer').selectpicker('refresh');
        }
        else {
            $('#cboCustomer').val("""");
            $(""#cboCustomer"").attr('disabled', true);
            $('#cboCustomer').selectpicker('refresh');
        }
    }

  ");
            WriteLiteral(@"  function GetAppointmentPatientDetail(appKey) {

        $.ajax({
            url: getBaseURL() + '/Appointment/GetPatientAppointmentDetailByAppkey',
            type: 'POST',
            datatype: 'json',
            contenttype: 'application/json; charset=utf-8',
            data: {
                businessKey: $('#cboBusinessKey').val(),
                appointmentKey: appKey
            },
            async: false,
            success: function (result) {
                $('#cboEpisodeType').val(result.EpisodeType);
                $('#cboEpisodeType').selectpicker('refresh');

                $('#txtUHID').val(result.UHID);
                $('#txtPatientID').val(result.PatientID);
                $('#txtFirstName').val(result.PatientFirstName);
                $('#txtLastName').val(result.PatientLastName);
                $('#cboGender').val(result.Gender);
                $('#txtDateOfBirth').val(fnFormatDateJsonToInput(new Date(result.DateOfBirth)));
                $('#txtMobile");
            WriteLiteral(@"Number').val(result.PatientMobileNumber);
                $('#txtSecondaryMobileNumber').val(result.SecondaryMobileNumber);
                $('#txtEmailID').val(result.PatientEmailID);

                if (result.IsSponsored) {
                    $('input[name=""IsSponsored""][value=""S""]').prop('checked', true);
                    $(""#cboCustomer"").attr('disabled', false);
                }
                else {
                    $('input[name=""IsSponsored""][value=""S""]').prop('checked', false);
                    $('#cboCustomer').val("""");
                    $(""#cboCustomer"").attr('disabled', true);
                }

                $('#cboCustomer').val(result.CustomerID);
                $('#cboCustomer').selectpicker('refresh');

                $('#cboReferredBy').val(result.ReferredBy);
                $('#cboReferredBy').selectpicker('refresh');

                //  $('#cboRequestChannel').val(result.RequestChannel);
                $('#cboRequestChannel').val(""1"");
         ");
            WriteLiteral(@"       $('#cboRequestChannel').selectpicker('refresh');

                $('#txtReason').val(result.ReasonforAppointment);

                return true;
            },
            error: function (error) {
                toastr.error(error.statusText);
                return false;
            }
        });

        return true;

    }

    function fnSaveAppointmentConfirmation() {

        if (!IsValid())
            return;

        try {
            $(""#btnSaveAppointment"").attr('disabled', true);

            var obj = {
                BusinessKey: $('#cboBusinessKey').val(),
                AppointmentKey: _appKey,
                ClinicId: $(':selected', $('#cboClinicType')).data('clinictype'),
                ConsultationId: $(':selected', $('#cboClinicType')).data('consultationtype'),
                SpecialtyID: _specialtyId,
                SpecialtyDesc: $('#lblSpecialty').text(),
                DoctorID: _doctorId,
                DoctorName: $('#lblDoctorName')");
            WriteLiteral(@".text(),
                AppointmentDate: _appDate.toDateString(),
                AppointmentFromTime: Converttimeformat(_appTime),
                Duration: ""15"",
                ReasonforAppointment: ""RS"",

                ClinicType: $(':selected', $('#cboClinicType')).data('clinictype'),
                ConsultationType: $(':selected', $('#cboClinicType')).data('consultationtype'),
                VisitType: $(':selected', $('#cboClinicType')).data('clinictypecode'),
                EpisodeType: $('#cboEpisodeType').val(),
                UHID: $('#txtUHID').val(),
                //PatientID: $('#txtPatientID').val().trim(),
                PatientFirstName: $('#txtFirstName').val().trim(),
                PatientLastName: $('#txtLastName').val().trim(),
                Gender: $('#cboGender').val(),
                DateOfBirth: $('#txtDateOfBirth').val(),
                PatientMobileNumber: $('#txtMobileNumber').val().trim(),
                SecondaryMobileNumber: $('#txtSecondaryMobi");
            WriteLiteral(@"leNumber').val().trim(),
                PatientEmailID: $('#txtEmailID').val().trim(),
                IsSponsored: $('input[name=""IsSponsored""]:checked').val() == ""S"",
                CustomerId: $('#cboCustomer').val(),
                ReferredBy: $('#cboReferredBy').val(),
                RequestChannel: $('#cboRequestChannel').val(),
                BusinessKey: $('#cboBusinessKey').val()
            };

            var URL = getBaseURL() + '/Appointment/InsertIntoPatientAppointmentDetail';
            if (_appKey > 0)
                URL = getBaseURL() + '/Appointment/UpdatePatientAppointmentDetail';

            $.ajax({
                url: URL,
                type: 'POST',
                datatype: 'json',
                contenttype: 'application/json; charset=utf-8',
                data: obj,
                async: true,
                success: function (response) {

                    if (response.Status) {

                        fnRefreshScreen();
                  ");
            WriteLiteral(@"      $(""#btnSaveAppointment"").attr('disabled', false);
                        $('#PopupAppointmentScheduler').modal('hide');
                        if (_appKey <= 0) {
                            toastr.success(""Appointment Confirmed. Queue Token Number : "" + response.QTokenKey);
                            obj.QueueTokenKey = response.QTokenKey;
                            // fnSendSMSAppointmentConfirmation(obj);
                        }
                        else
                            toastr.success(""Updated"");
                    }
                    else {
                        toastr.error(response.Message);
                    }

                    $(""#btnSaveAppointment"").attr('disabled', false);
                },
                error: function (error) {
                    toastr.error(error.statusText);
                    $(""#btnSaveAppointment"").attr('disabled', false);
                }
            });
        }
        catch
        {
            toastr.");
            WriteLiteral(@"error(""error"");
            $(""#btnSaveAppointment"").attr('disabled', false);
        }
    }

    function fnClearPatientInput() {

        $('#txtUHID').val("""");
        $('#txtPatientID').val("""");
        $('#txtFirstName').val("""");
        $('#txtLastName').val("""");
        $('#txtMobileNumber').val("""");
        $('#txtSecondaryMobileNumber').val("""");
        $('#txtEmailID').val("""");
        $('#cboGender').val("""");
        $('#txtDateOfBirth').val("""");

        $('input[name=""IsSponsored""][value=""S""]').prop('checked', false);
        $('#cboCustomer').val("""");
        $(""#cboCustomer"").attr('disabled', true);
        $('#cboCustomer').selectpicker('refresh');

        $('#cboReferredBy').val("""");
        $('#cboReferredBy').selectpicker('refresh');

        $('#cboRequestChannel').val("""");
        $('#cboRequestChannel').selectpicker('refresh');

        $('#txtReason').val("""");
    }

    function IsValid() {

        if (IsStringNullorEmpty($(""#cboEpisodeType"").val()))");
            WriteLiteral(@" {
            toastr.warning(""Please select the Episode Type"");
            return false;
        }
        else if (IsStringNullorEmpty($(""#txtFirstName"").val())) {
            toastr.warning(""Please Enter First Name"");
            return false;
        }
        else if (IsStringNullorEmpty($(""#txtLastName"").val())) {
            toastr.warning(""Please Enter Last Name"");
            return false;
        }
        else if (IsStringNullorEmpty($(""#cboGender"").val())) {
            toastr.warning(""Please select the Gender"");
            return false;
        }
        else if (IsStringNullorEmpty($(""#txtDateOfBirth"").val())) {
            toastr.warning(""Please Enter the DateofBirth"");
            return false;
        }
        else if (IsStringNullorEmpty($(""#txtMobileNumber"").val())) {
            toastr.warning(""Please Enter Mobile Number"");
            return false;
        }
        else if (!IsStringNullorEmpty($(""#txtEmailID"").val())) {
            if (!$(""#txtEmailID"").input");
            WriteLiteral(@"mask(""isComplete"")) {
                toastr.warning(""Please Enter valid EmailID"");
                return false;
            }
        }
        else if ($('input[name=""IsSponsored""]:checked').val() == ""S"") {
            if (IsStringNullorEmpty($('#cboCustomer').val())) {
                toastr.warning(""Please select the insurance"");
                return false;
            }
        }
        else if (IsStringNullorEmpty($('#cboReferredBy').val())) {
            toastr.warning(""Please select the Reffered By"");
            return false;
        }
        else if (IsStringNullorEmpty($('#cboRequestChannel').val())) {
            toastr.warning(""Please select the Request Channel"");
            return false;
        }
        return true;
    }


</script>
");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
