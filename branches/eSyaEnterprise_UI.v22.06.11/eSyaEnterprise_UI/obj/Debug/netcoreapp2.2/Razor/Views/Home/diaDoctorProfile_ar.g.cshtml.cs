#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Views\Home\diaDoctorProfile_ar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "025f2e3be4095db33b920f662962c5fe731eb64d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_diaDoctorProfile_ar), @"mvc.1.0.view", @"/Views/Home/diaDoctorProfile_ar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/diaDoctorProfile_ar.cshtml", typeof(AspNetCore.Views_Home_diaDoctorProfile_ar))]
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
#line 1 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Views\_ViewImports.cshtml"
using eSyaEnterprise_UI;

#line default
#line hidden
#line 2 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Views\_ViewImports.cshtml"
using eSyaEnterprise_UI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"025f2e3be4095db33b920f662962c5fe731eb64d", @"/Views/Home/diaDoctorProfile_ar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"110a014d2bbd077c913f923d324696e29a0b05f7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_diaDoctorProfile_ar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/diaClinic/doctorDIAPhoto.JPG"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Dr.Dia\'s Photo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Views\Home\diaDoctorProfile_ar.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(29, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(58, 4083, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "025f2e3be4095db33b920f662962c5fe731eb64d4659", async() => {
                BeginContext(64, 4070, true);
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <title>diaDoctorProfile_ar</title>
    <style>
        body {
            font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif;
            margin: 0px;
            direction:rtl;
        }

        section {
            padding: 20px;
            background: #fff;
        }

        ul li {
            text-align: justify;
            line-height: 1.5;
            margin: 0px 0px;
            background: #fff;
            padding: 15px 0px;
            font-size: 14px;
        }

        .heading {
            color: #003f67;
            font-weight: 600;
            margin: 20px 0px 0px 0px;
            text-align: center;
            border: 1px solid #ccc;
            padding: 10px;
            background: #fff;
            position: relative;
            bottom: 29px;
            margin: auto;
            width: 85%;
            border-radius: 10px;
        ");
                WriteLiteral(@"    box-shadow: 0px 2px 2px rgba(0,0,0,0.2);
        }

        .doctorDiv img {
            display: flex;
            flex: 0 0 100%;
            border-radius: 5px;
            padding: 4px;
            margin: auto;
            height: 270px;
            transform: scale(1.35);
        }

        .div-img img {
            margin: 0px auto;
            display: inline;
            height: 150px;
            box-shadow: 0px 2px 2px rgba(0,0,0,0.2);
            background: #fff;
            border-radius: 20px;
        }

        figure {
            display: inline-block;
            margin: 0 auto;
            width: 48%;
        }

            figure img {
                max-width: 100%;
                border-radius: 10%;
            }

        figcaption {
            font-size: 11px;
        }

        .div-img {
            position: relative;
            width: 49.1%;
            display: inline-block;
            margin: auto;
        }

            .div");
                WriteLiteral(@"-img p {
                font-size: 12px;
                display: block;
                padding: 5px 0px 5px 15px;
                margin: 4px 0px;
            }

        .doctorDiv {
            background: #1e4a49;
            margin: -20px -20px auto;
            border-bottom-right-radius: 39%;
            overflow: hidden;
        }

        .h1 {
            padding-top: 30px;
            margin: 0px;
            color: #003f68;
            text-transform: capitalize;
            text-align: center;
            font-weight: 600;
        }

        .m-0 {
            margin: 0px;
        }

        .small-text {
            color: #2b2b2b;
            font-size: 13px;
            background: transparent;
            padding: 8px 0px 0px 0px;
            margin: 0px;
            letter-spacing: 0.2px;
            font-weight: 600;
            text-align: center;
        }

        .short-message {
            text-align: center;
            background: transparent");
                WriteLiteral(@";
            padding: 20px 0px;
            margin: 0px;
            font-size: 14px;
        }

        .box-container {
            display: flex;
            justify-content: space-between;
        }

        .box {
            width: 30%;
            padding: 10px 2px;
            box-shadow: 0px 2px 2px rgba(0,0,0,0.2);
            /*display: inline-block;*/
            display: none;
            margin: 30px 0px;
            background: #f0fffe;
            border-radius: 10px;
        }

            .box h2 {
                text-align: center;
                font-weight: bold;
                margin: 5px;
                color: #2daba3;
            }

            .box p {
                padding: 0px;
                font-size: 12px;
                color: grey;
            }

        h3 {
            color: #003f68;
        }

        ul {
            list-style-type: circle;
            padding-left: 5px;
        }
    </style>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4141, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(4143, 2533, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "025f2e3be4095db33b920f662962c5fe731eb64d10024", async() => {
                BeginContext(4149, 62, true);
                WriteLiteral("\r\n    <section>\r\n        <div class=\"doctorDiv\">\r\n            ");
                EndContext();
                BeginContext(4211, 72, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "025f2e3be4095db33b920f662962c5fe731eb64d10475", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4283, 2386, true);
                WriteLiteral(@"
        </div>
        <h1 class=""h1"">Dr.Mohamed Diaa </h1>
        <p class=""small-text"">&#9829; Bariatric Surgeon </p>
        <div class=""box-container"">
            <div class=""box"">
                <h2>1.5k </h2><p class=""small-text"">Patients</p>
            </div>
            <div class=""box"">
                <h2>10 yr</h2><p class=""small-text"">Experience</p>
            </div>
            <div class=""box"">
                <h2>4.9</h2><p class=""small-text"">Rating</p>
            </div>

        </div>
        <h3 class=""h3"">About Doctor</h3>
        <ul>
            <li>يمتلك الدكتور محمد ضياء سرحان سيرة ذاتية تجعله أفضل دكتور جراحات سمنة في مصر وله السبق في إدخال تقنية التخدير الموضعي في جراحات السمنة. </li>
            <li>أستاذ جراحات السمنة والجهاز الهضمي  بالقصر العيني. </li>
            <li>زميل كلية الجراحين الملكية بلندن.</li>
            <li>عضو الاتحاد العالمي لجراحات السمنة.</li>
            <li>عضو اللجنة العلمية لهيئة البارالينك العالمية المختصة بالمراجعة الجراحية.</l");
                WriteLiteral(@"i>
            <li>حاصل على أعلى اعتماد دولي في تقييم جراحي السمنة المفرطة في العالم وهو لقب Master Surgeon من هيئة SRC الأمريكية.</li>
            <li>الجدير بالذكر هو أن هذا اللقب يتم منحه بعد التأكد من معايير وضوابط معينة.</li>
            <li>الدكتور محمد ضياء سرحان أجرى أكثر من 17.000 عملية سمنة ناجحة بنسبة مضاعفات لا تتجاوز 0,001%.</li>
            <li>دكتور محمد ضياء سرحان الأول والوحيد في مصر الذي يقوم بعمل جراحة السمنة بالتخدير الموضعي.</li>
            <li>دكتور محمد ضياء سرحان الأول والوحيد بمصر الذي يستخدم Robotic surgery  في إجراء العمليات الجراحية.</li>
            <li>تم التعاقد مع مستشفى ABC كأول مستشفى مستقلة معتمدة دوليًا متخصصة في جراحات السمنة والتجميل في مصر والشرق الأوسط وأفريقيا، وهي حاصلة أيضا على أعلى اعتماد دولي من نفس الهيئة.</li>
        </ul>
        <h3>المواعيد:-</h3>
        <p>فرع المهندسين:</p>
        <p>مستشفى ABC - الدور الأول: 15 شارع عمرو - متفرع من شارع سوريا</p>
        <p>المواعيد: الأحد المتابعة الساعة ١ ظهرًا و الكشف من 5 ل9م</p>
        <p>الأربعاء المت");
                WriteLiteral(@"ابعة الساعة 1ظهرًا والكشف5 ل 9 م</p>
        <p>التليفون: 01022595054 - 01007517840 </p>
        <p>فرع 6 اكتوبر:111 زايد داون تاون - مدخل 2 - الشيخ زايد</p>
        <p>المواعيد: الثلاثاء المتابعه الغذائيه من 3 عصرًا حتى 5 م و متابعه الجراحة من 4 م حتى 6 م والكشف من6م ل 10م </p>
        <p>التليفون: 01020666833</p>
    </section>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6676, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
