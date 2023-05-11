#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\PatientManagement\Views\PatientPartialAttribute\_address.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e40c16b976d0b0eb5991303c071c685574f2ca0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_PatientManagement_Views_PatientPartialAttribute__address), @"mvc.1.0.view", @"/Areas/PatientManagement/Views/PatientPartialAttribute/_address.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/PatientManagement/Views/PatientPartialAttribute/_address.cshtml", typeof(AspNetCore.Areas_PatientManagement_Views_PatientPartialAttribute__address))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e40c16b976d0b0eb5991303c071c685574f2ca0b", @"/Areas/PatientManagement/Views/PatientPartialAttribute/_address.cshtml")]
    public class Areas_PatientManagement_Views_PatientPartialAttribute__address : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4631, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-4 col-md-12 col-sm-12"">
        <div class=""form-group"">
            <label>Address</label>
            <textarea id=""txtAddress"" rows=""2"" class=""form-control""></textarea>
        </div>
    </div>
    <div class=""col-lg-8 col-md-12 col-sm-12"">
        <div class=""row"">
            <div class=""col-lg-6 col-md-6 col-sm-6"">
                <div class=""form-group d-flex flex-column"">
                    <label>Pincode</label>
                    <input class=""form-control"" id=""txtPincode"" pattern=""[0-9]"" />
                </div>
            </div>
            <div class=""col-lg-6 col-md-6 col-sm-6"">
                <div class=""form-group d-flex flex-column"">
                    <label>Area</label>
                    <select class=""form-control "" data-container=""body"" data-live-search=""true"" id=""cboArea"">
                        <option value=""-1"">Select</option>
                    </select>
                </div>
            </div>
            ");
            WriteLiteral(@"<div class=""col-lg-6 col-md-6 col-sm-6"">
                <div class=""form-group"">
                    <label>City</label>
                    <select class=""form-control "" data-container=""body"" id=""cboCity"" data-live-search=""true"" onchange=""fncboCity_change();"">
                        <option value=""-1"">Select</option>
                    </select>
                </div>
            </div>
            <div class=""col-lg-6 col-md-6 col-sm-6"">
                <div class=""form-group"">
                    <label>State</label>
                    <select class=""form-control "" data-container=""body"" id=""cboState"" data-live-search=""true"" onchange=""fncboState_change();"">
                        <option value=""value"">Select</option>
                    </select>
                </div>
            </div>
        </div>
    </div>
</div>

<script>

    var _stateCode, _cityCode, _areaCode;

    $(function () {
     //   populateState();
    });

     function populateState() {
        $(""#cb");
            WriteLiteral(@"oState"").empty();
         $.get(getBaseURL() + '/Master/GetStateList', {
            isdCode: _cnfISDCode
        }, function (data, status) {
            $.each(data, function (key, val) {
                $(""#cboState"").append($(""<option></option>"").val(val.PlaceId).html(val.PlaceName));
            });
             }).done(function () {
                 if (_stateCode > 0) {
                     $('#cboState').val(_stateCode);
                     $(""#cboState"").selectpicker('refresh');
                     populateCity();
                 }
        });
    }

     function populateCity() {
         $(""#cboCity"").empty();
         $(""#cboArea"").empty();
         $.get(getBaseURL() + '/Master/GetCityList', {
             isdCode: _cnfISDCode, stateCode: $(""#cboState"").val()
        }, function (data, status) {
            $.each(data, function (key, val) {
                $(""#cboCity"").append($(""<option></option>"").val(val.PlaceId).html(val.PlaceName));
            });
             ");
            WriteLiteral(@"}).done(function () {
                 if (_cityCode > 0) {
                     $('#cboCity').val(_cityCode);
                     $(""#cboCity"").selectpicker('refresh');
                     populateArea();
                 }
        });
    }

    function populateArea() {
        $(""#cboArea"").empty();
        $.get(getBaseURL() + '/Master/GetAreaList', {
            isdCode: _cnfISDCode, stateCode: $(""#cboState"").val(), cityCode: $('#cboCity').val(), pincode: $(""#txtPincode"").val()
        }, function (data, status) {
            $.each(data, function (key, val) {
                $(""#cboArea"").append($(""<option></option>"").val(val.AreaCode).html(val.AreaName));
            });
            }).done(function () {
                if (_areaCode > 0) {
                    $('#cboArea').val(_areaCode);
                    $(""#cboArea"").selectpicker('refresh');
                }
        });
    }

    function fncboState_change() {
        populateCity();
    }

    function fncboCity");
            WriteLiteral(@"_change() {
        populateArea();
    }

    $(""#txtPincode"").blur(function () {
        
        $.get(getBaseURL() + '/Master/GetCountryAreaDetailsByPincode', {
            isdCode: _cnfISDCode, pincode: $(""#txtPincode"").val()
        }, function (data, status) {
            
            $('#cboState').val(data.StateCode);
            $('#cboState').selectpicker('refresh');
            _cityCode = data.CityCode;
            _areaCode = data.AreaCode;
            populateCity();
        });
    });

</script>");
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
