#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\PatientManagement\Views\PatientEMR\_PatientInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4315c823406ccaa25f93e6743d7db2c33e9a2ede"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_PatientManagement_Views_PatientEMR__PatientInfo), @"mvc.1.0.view", @"/Areas/PatientManagement/Views/PatientEMR/_PatientInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/PatientManagement/Views/PatientEMR/_PatientInfo.cshtml", typeof(AspNetCore.Areas_PatientManagement_Views_PatientEMR__PatientInfo))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4315c823406ccaa25f93e6743d7db2c33e9a2ede", @"/Areas/PatientManagement/Views/PatientEMR/_PatientInfo.cshtml")]
    public class Areas_PatientManagement_Views_PatientEMR__PatientInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.jqGrid.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(120, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(139, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(147, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4315c823406ccaa25f93e6743d7db2c33e9a2ede3558", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(196, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(201, 11138, true);
            WriteLiteral(@"
    <div class=""row"">
        <div class=""col-lg-12 col-md-12 col-12"" style=""display:none"">
            <div class=""card box-shadow mb-2"">
                <div class=""card-body"">
                    <h4>Patient Info</h4>
                    
                    <div class=""divFixedBar"">
                        <div class=""row mr-0"">
                            <div class=""col-xl-4 col-lg-12 col-md-12 col-sm-12 col-xs-12 d-flex align-items-center"">

                                <div>
                                    <p><span class=""labelname""><i class=""fas fa-chevron-right c-lightgrey""></i> Patient Name:</span><span id=""lblPatientName""></span>&nbsp;</p>
                                    <p class=""m-0""><span class=""labelname""><i class=""fas fa-chevron-right c-lightgrey""></i> Age:</span><span id=""lblAge""></span>&nbsp;</p>


                                </div>
                            </div>
                            <div class=""col-xl-4 col-lg-12 col-md-12 col-sm-12 col-xs-12 d-");
            WriteLiteral(@"flex align-items-center"">

                                <div>
                                    <p><span class=""labelname""><i class=""fas fa-chevron-right c-lightgrey""></i> ID:</span> <span id=""lblPatientID""></span>&nbsp;</p>
                                    <p class=""m-0""><span class=""labelname""><i class=""fas fa-chevron-right c-lightgrey""></i> DOB:</span><span id=""lblDOB""></span>&nbsp;</p>
                                </div>
                            </div>
                            <div class=""col-xl-4 col-lg-12 col-md-12 col-sm-12 col-xs-12 d-flex align-items-center"">

                                <div>
                                    <p><span class=""labelname""><i class=""fas fa-chevron-right c-lightgrey""></i> Gender:</span><span id=""lblGender""></span>&nbsp;</p>
                                    <p><span class=""labelname""><i class=""fas fa-chevron-right c-lightgrey""></i> Tel:</span><span id=""lblTel""></span>&nbsp;</p>
                                </div>
                 ");
            WriteLiteral(@"           </div>
                        </div>
                    </div>
                </div>
             </div>
        </div>
        <div class=""col-lg-6 col-md-6 col-6"">
            <div class=""card box-shadow p-0"">
                <div class=""card-body"">
                    <h4>Family Member</h4>
                    
                    <table id=""jqgFamilyMember""></table>
                    <div id=""jqpFamilyMember""></div>
                </div>
            </div>
        </div>
        <div class=""col-lg-6 col-md-6 col-6"">
            <div class=""card box-shadow"">
                <div class=""card-body"">
                    <h4>Allergy</h4>
                    
                    <table id=""jqgAllergy""></table>
                    <div id=""jqpAllergy""></div>
                </div>
            </div>
        </div>
    </div>
 

        <div class=""row"">
           
            <div class=""col-lg-6 col-md-6 col-12"">
                <div class=""card box-shadow my-2""");
            WriteLiteral(@">
                    <div class=""card-body"">
                        
                                <h4>Visit Info</h4>
                                
                                <table id=""jqgVisitInfo""></table>
                                <div id=""jqpVisitInfo""></div>
                   </div>
                </div>

            </div>
</div>
<script>
    $(function () {
        fnGridFamilyMember();
        fnGridAllergy();
        fnGridVisitInfo();
    })
    function fnGridFamilyMember() {
        $(""#jqgFamilyMember"").jqGrid({
            //  url: getBaseURL() + '/ApplicationCodes/GetApplicationCodesByCodeType?codeType=' + codeType,
            mtype: 'Post',
            datatype: 'json',
            ajaxGridOptions: { contentType: 'application/json; charset=utf-8' },
            jsonReader: { repeatitems: false, root: ""rows"", page: ""page"", total: ""total"", records: ""records"" },
            colNames: [""UHID"", ""Relation"", ""PatientName"", ""Age"", ""DOB"", ""Actions""],
   ");
            WriteLiteral(@"         colModel: [
                { name: ""UHID"", width: 50, editable: true, align: 'left', hidden: false },
                { name: ""Relation"", width: 70, editable: false, hidden: true, align: 'left', resizable: true },
                { name: ""PatientName"", width: 120, editable: true, align: 'left', resizable: false, editoption: { 'text-align': 'left', maxlength: 50 } },
                { name: ""Age"", width: 40, editable: true, align: 'left', resizable: false, editoption: { 'text-align': 'left', maxlength: 15 } },
                { name: ""DOB"", width: 45, align: 'center', resizable: false, editoptions: { value: ""true:false"" }, formatoptions: { disabled: true } },
                {
                    name: 'edit', search: false, align: 'left', width: 45, sortable: false, resizable: false,
                    formatter: function (cellValue, options, rowdata, action) {
                        return '<button class=""mr-1 btn btn-outline"" id=""btnApplicationCodes""><i class=""fa fa-ellipsis-v""></i></bu");
            WriteLiteral(@"tton>'
                    }
                },
            ],
            pager: ""#jqpFamilyMember"",
            rowNum: 10000,
            rownumWidth: '55',
            pgtext: null,
            pgbuttons: null,
            loadonce: true,
            viewrecords: true,
            gridview: true,
            rownumbers: true,
            height: 'auto',
            align: ""left"",
            width: 'auto',
            autowidth: true,
            shrinkToFit: true,
            forceFit: true,
            scrollOffset: 0, caption: 'Family Member',
            loadComplete: function (data) {
                SetGridControlByAction();
                fnJqgridSmallScreen(""jqgFamilyMember"");
            },
            onSelectRow: function (rowid, status, e) {
            },
        }).jqGrid('navGrid', '#jqpFamilyMember', { add: false, edit: false, search: false, del: false, refresh: false }).jqGrid('navButtonAdd', '#jqpFamilyMember', {
            caption: '<span class=""fa fa-sync"">");
            WriteLiteral(@"</span> Refresh', buttonicon: ""none"", id: ""custRefresh"", position: ""first"", onClickButton: fnGridRefreshApplicationCodes
        }).jqGrid('navButtonAdd', '#jqpFamilyMember', {
            caption: '<span class=""fa fa-plus"" data-toggle=""modal""></span> Add', buttonicon: 'none', id: 'jqgAdd', position: 'first', onClickButton: fnAddApplicationCodes
        });
        fnAddGridSerialNoHeading();
    }
    function fnGridRefreshApplicationCodes() {

    }
    function fnAddApplicationCodes() {

    }
    function fnGridAllergy() {
        $(""#jqgAllergy"").jqGrid({
            //  url: getBaseURL() + '/ApplicationCodes/GetApplicationCodesByCodeType?codeType=' + codeType,
            mtype: 'Post',
            datatype: 'json',
            ajaxGridOptions: { contentType: 'application/json; charset=utf-8' },
            jsonReader: { repeatitems: false, root: ""rows"", page: ""page"", total: ""total"", records: ""records"" },
            colNames: [""Prepared by"", ""Allergy Description""],
            colMo");
            WriteLiteral(@"del: [
                { name: ""PreparedBy"", width: 50, editable: true, align: 'left', hidden: false },
                { name: ""AllergyDescription"", width: 70, editable: false, hidden: true, align: 'left', resizable: true },
               
            ],
            pager: ""#jqpAllergy"",
            rowNum: 10000,
            rownumWidth: '55',
            pgtext: null,
            pgbuttons: null,
            loadonce: true,
            viewrecords: true,
            gridview: true,
            rownumbers: true,
            height: 'auto',
            align: ""left"",
            width: 'auto',
            autowidth: true,
            shrinkToFit: true,
            forceFit: true,
            scrollOffset: 0, caption: 'Allergy',
            loadComplete: function (data) {
                SetGridControlByAction();
                fnJqgridSmallScreen(""jqgAllergy"");
            },
            onSelectRow: function (rowid, status, e) {
            },
        }).jqGrid('navGrid', '#jqpA");
            WriteLiteral(@"llergy', { add: false, edit: false, search: false, del: false, refresh: false }).jqGrid('navButtonAdd', '#jqpAllergy', {
            caption: '<span class=""fa fa-sync""></span> Refresh', buttonicon: ""none"", id: ""custAllergyRefresh"", position: ""first"", onClickButton: fnGridRefreshAllergy
            }).jqGrid('navButtonAdd', '#jqpAllergy', {
                caption: '<span class=""fa fa-plus"" data-toggle=""modal""></span> Add', buttonicon: 'none', id: 'jqgAllergyAdd', position: 'first', onClickButton: fnAddAllergy
        });
        fnAddGridSerialNoHeading();
    }
    function fnGridRefreshAllergy() {

    }
    function fnAddAllergy() {

    }
    function fnGridVisitInfo() {
        $(""#jqgVisitInfo"").jqGrid({
            //  url: getBaseURL() + '/ApplicationCodes/GetApplicationCodesByCodeType?codeType=' + codeType,
            mtype: 'Post',
            datatype: 'json',
            ajaxGridOptions: { contentType: 'application/json; charset=utf-8' },
            jsonReader: { repeatitems: ");
            WriteLiteral(@"false, root: ""rows"", page: ""page"", total: ""total"", records: ""records"" },
            colNames: [""Visit Date"", ""Doctor Name"",""Action""],
            colModel: [
                { name: ""VisitDate"", width: 50, editable: true, align: 'left', hidden: false },
                { name: ""DoctorName"", width: 70, editable: false, hidden: true, align: 'left', resizable: true },
                { name: ""edit"", width: 70, editable: false, hidden: true, align: 'left', resizable: true },

            ],
            pager: ""#jqpVisitInfo"",
            rowNum: 10000,
            rownumWidth: '55',
            pgtext: null,
            pgbuttons: null,
            loadonce: true,
            viewrecords: true,
            gridview: true,
            rownumbers: true,
            height: 'auto',
            align: ""left"",
            width: 'auto',
            autowidth: true,
            shrinkToFit: true,
            forceFit: true,
            scrollOffset: 0, caption: 'Visit Info',
            loadCom");
            WriteLiteral(@"plete: function (data) {
                SetGridControlByAction();
                fnJqgridSmallScreen(""jqpVisitInfo"");
            },
            onSelectRow: function (rowid, status, e) {
            },
        }).jqGrid('navGrid', '#jqpVisitInfo', { add: false, edit: false, search: false, del: false, refresh: false }).jqGrid('navButtonAdd', '#jqpVisitInfo', {
            caption: '<span class=""fa fa-sync""></span> Refresh', buttonicon: ""none"", id: ""custVisitInfoRefresh"", position: ""first"", onClickButton:''
            }).jqGrid('navButtonAdd', '#jqpVisitInfo', {
            caption: '<span class=""fa fa-plus"" data-toggle=""modal""></span> Add', buttonicon: 'none', id: 'jqgVisitInfoAdd', position: 'first', onClickButton: ''
        });
        fnAddGridSerialNoHeading();
    }
    function fnGridRefreshAllergy() {

    }
    function fnAddAllergy() {

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