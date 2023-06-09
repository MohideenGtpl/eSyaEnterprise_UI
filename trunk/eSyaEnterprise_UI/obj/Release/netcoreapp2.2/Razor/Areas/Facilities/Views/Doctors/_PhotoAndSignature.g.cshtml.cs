#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Facilities\Views\Doctors\_PhotoAndSignature.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "242cb71a0de92cdee50d25793c1ca66ad283580c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Facilities_Views_Doctors__PhotoAndSignature), @"mvc.1.0.view", @"/Areas/Facilities/Views/Doctors/_PhotoAndSignature.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Facilities/Views/Doctors/_PhotoAndSignature.cshtml", typeof(AspNetCore.Areas_Facilities_Views_Doctors__PhotoAndSignature))]
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
#line 4 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Facilities\Views\Doctors\_PhotoAndSignature.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"242cb71a0de92cdee50d25793c1ca66ad283580c", @"/Areas/Facilities/Views/Doctors/_PhotoAndSignature.cshtml")]
    public class Areas_Facilities_Views_Doctors__PhotoAndSignature : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(120, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(256, 2159, true);
            WriteLiteral(@"<style>
    #canvas{
        width:200px;height:200px;
        /*border:1px dashed #ccc;*/
    }
    .imagedig {
        border: 1px dashed #d7d4d4;
        padding-bottom: 5px;
        background: #fbfbfb;
        padding: 10px;
    }
    
</style>
<div class=""row"">

    <div class=""col-lg-6 col-md-6 col-sm-6 border-left"">
        <div class=""form-group"">
            <p class=""subheading""> Photo </p> <hr class=""left"" />
            <span class=""lblInfo""> 1. Only Jpg & png format </span>
            <span class=""lblInfo""> 2. Photo size should be less than 50KB</span>
            <span class=""lblInfo pb-2""> 3. Please enable your browser Camera access permission for Capture Photo</span>
           <div class=""p-2 mb-3 border d-flex justify-content-center"" style=""border-style:dashed;background:#ffffe3;"">
                <button id=""btnUploadPhoto"" class=""btn btn-primary btn-xs mr-10""><i class=""fa fa-upload""></i> Upload</button>
                <span class=""mr-10""> (or)</span>
            ");
            WriteLiteral(@"    <button id=""btnCapturePhoto"" class=""btn btn-primary btn-xs""><i class=""fa fa-camera""></i> Capture</button>
            </div>

        </div>
        <div class=""form-group"" id=""divUploadPhoto"">
            <div class=""imagedig"" style=""border:thin; padding-bottom:5px;  display:none"" id=""imgPhoto"">
                <img id=""imgPhotoimageblah"" src="""" title="""">
                <input class=""mdl-textfield__input fullwidth FileUpload"" id=""Photoimage"" type=""file"" name=""file"" onchange=""readPhotoimage(this);"" accept='image/*' enctype=""multipart/form-data"" style=""border-bottom:none !important;visibility:hidden"" />
                <button id=""btnRemoveUploadPhoto"" class=""btn btn-primary d-flex justify-content-end""><i class=""fa fa-times""></i></button>
            </div>
        </div>
        <div class=""form-group"" id=""divCapturePhoto"" style=""display:none"">
            <iframe src="""" allow=""camera"" id=""iframePhoto"" sandbox=""allow-same-origin""></iframe>
            <video id=""video"" width=""200"" height=""20");
            WriteLiteral("0\" autoplay></video>\r\n            <canvas id=\"canvas\" width=\"200\" height=\"200\" style=\"display:none\"></canvas>\r\n");
            EndContext();
            BeginContext(6806, 455, true);
            WriteLiteral(@"            <div class=""d-inline-b"" id=""divbtnCapturePhoto"">
                <button id=""click-photo"" class=""btn btn-primary mr-10""><i class=""fa fa-camera""></i></button>
                <button id=""remove-photo"" class=""btn btn-primary""><i class=""fa fa-times""></i></button>
            </div>
        </div>
    </div>
    
    <div class=""col-lg-6 col-md-6 col-sm-6 border-left"">
      <div class=""form-group"">
            <p class=""subheading""> ");
            EndContext();
            BeginContext(7262, 22, false);
#line 56 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Facilities\Views\Doctors\_PhotoAndSignature.cshtml"
                              Write(Localizer["Signature"]);

#line default
#line hidden
            EndContext();
            BeginContext(7284, 1306, true);
            WriteLiteral(@"</p>
            <hr class=""left"" />
            <span class=""lblInfo""> 1. Only Jpg & png format</span>
            <span class=""lblInfo pb-4""> 2. Signature Image size should be less than 50KB</span>

            <div class=""p-2 mb-3 border d-flex justify-content-center"" style=""border-style:dashed;background:#ffffe3;"">
                <button id=""btnUploadSignature"" class=""btn btn-primary btn-xs mr-10""><i class=""fa fa-upload""></i> Upload</button>
            </div>
            <div class=""imagedig"" style=""border:thin; padding-bottom:5px;"" id=""divUploadSignature"">
                <img id=""imgSignatureblah"" src="""" title="""">
                <input class=""mdl-textfield__input fullwidth FileUpload"" id=""imgSignature"" type=""file"" name=""file"" onchange=""readSinatureimage(this);"" accept='image/*' enctype=""multipart/form-data"" style=""border-bottom:none !important"" />
            </div>
        </div>
    </div>
</div>
        <div class=""row form-group"">
            <div class=""col-lg-12 col-md-12 col-sm");
            WriteLiteral(@"-12 text-center"">
               
                <hr />
                <button type=""button"" class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent btn-back mr-10 c-white"" onclick=""fnCloseDoctorProfile()""><i class=""fas fa-chevron-left""></i> ");
            EndContext();
            BeginContext(8591, 17, false);
#line 75 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Facilities\Views\Doctors\_PhotoAndSignature.cshtml"
                                                                                                                                                                                                                         Write(Localizer["Back"]);

#line default
#line hidden
            EndContext();
            BeginContext(8608, 244, true);
            WriteLiteral("</button>\r\n                <button class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent primary-button mr-10\" id=\"btnSaveDoctorProfileImage\" onclick=\"fnSaveDoctorProfileImage()\"><i class=\"far fa-save\"></i> ");
            EndContext();
            BeginContext(8853, 17, false);
#line 76 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Facilities\Views\Doctors\_PhotoAndSignature.cshtml"
                                                                                                                                                                                                                                    Write(Localizer["Save"]);

#line default
#line hidden
            EndContext();
            BeginContext(8870, 195, true);
            WriteLiteral("</button>\r\n                <button class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect  cancel-button cancel-button\" id=\"btnClearDoctor\" onclick=\"\"><i class=\"fa fa-redo\"></i> ");
            EndContext();
            BeginContext(9066, 18, false);
#line 77 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\Facilities\Views\Doctors\_PhotoAndSignature.cshtml"
                                                                                                                                                                                   Write(Localizer["Clear"]);

#line default
#line hidden
            EndContext();
            BeginContext(9084, 2152, true);
            WriteLiteral(@"</button>
            </div>
        </div>



       
        
        <script>

            var sizeLimit = 50 * 1024;
            function readPhotoimage(input) {
                debugger;
                if (input.files && input.files[0]) {
                   
                    var sizeInMb = input.files[0].size;
                   
                    if (!(input.files[0].type.match(/image.*/))) {
                        toastr.warning(""Invalid format file uploaded"");
                        input.value = null;
                        return;
                    }
                    if (sizeInMb > sizeLimit) {
                        toastr.warning(""User Photo file size should be smaller than 50 KB"");
                        input.value = null;
                        return false;
                    }

                    var reader = new FileReader();
                    reader.onload = function (e) {
                        document.getElementById('imgPhotoimageblah')");
            WriteLiteral(@".src = e.target.result;
                    }
                    reader.readAsDataURL(input.files[0]);
                }
            }

            function readSinatureimage(input) {
                if (input.files && input.files[0]) {

                    var sizeInMb = input.files[0].size;

                    if (!(input.files[0].type.match(/image.*/))) {
                        toastr.warning(""Invalid format file uploaded"");
                        input.value = null;
                        return;
                    }
                    if (sizeInMb > sizeLimit) {
                        toastr.warning(""User Signature file size should be smaller than 50 KB"");
                        input.value = null;
                        return;
                    }

                    var reader = new FileReader();
                    reader.onload = function (e) {
                        document.getElementById('imgSignatureblah').src = e.target.result;
                    }
      ");
            WriteLiteral("              reader.readAsDataURL(input.files[0]);\r\n                }\r\n            }\r\n        </script>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
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
