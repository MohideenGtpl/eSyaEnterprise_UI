#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\BookingDashboard\UserInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6ddea09f2188db0a0e7ff77e4c26146b1c6449a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_eSyaNatureCure_Views_BookingDashboard_UserInfo), @"mvc.1.0.view", @"/Areas/eSyaNatureCure/Views/BookingDashboard/UserInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/eSyaNatureCure/Views/BookingDashboard/UserInfo.cshtml", typeof(AspNetCore.Areas_eSyaNatureCure_Views_BookingDashboard_UserInfo))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6ddea09f2188db0a0e7ff77e4c26146b1c6449a", @"/Areas/eSyaNatureCure/Views/BookingDashboard/UserInfo.cshtml")]
    public class Areas_eSyaNatureCure_Views_BookingDashboard_UserInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/eSyaNatureCure.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\BookingDashboard\UserInfo.cshtml"
  
    ViewData["Title"] = "UserInfo";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(93, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c6ddea09f2188db0a0e7ff77e4c26146b1c6449a3971", async() => {
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
            BeginContext(150, 103, true);
            WriteLiteral("\r\n<style>\r\n    #rs_mjqgAddOnServices, #rs_mjqgActivities {\r\n        display: none;\r\n    }\r\n</style>\r\n\r\n");
            EndContext();
            BeginContext(1823, 11648, true);
            WriteLiteral(@"
<section class=""main-content box-shadow-1"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-lg-12 col-md-12 col-sm-12 pt-3 d-flex justify-content-between"">
                <h5 class=""border-bottom pb-1""><span class=""px-2 py-1 bg-light mr-2 border""><i class=""fa fa-user""></i></span> <span>Suresh Kumar </span></h5>
                <div>
                    <span class=""badge badge-pill badge-success font-weight-light"">Checked-In</span>
                    <span class=""badge badge-pill badge-warning font-weight-light"">Checked-Out</span>
                    <span class=""badge badge-pill badge-primary font-weight-light"">Pending</span>
                    <span class=""badge badge-pill badge-danger font-weight-light"">Cancel</span>
                </div>
            </div>
            <div class=""col-lg-2 col-sm-6 col-6 form-group"">
                <label class=""d-block"">Mobile Number</label>
                <span class=""text-content"">+91 8998677645</span>
     ");
            WriteLiteral(@"       </div>
            <div class=""col-lg-2 col-sm-6 col-6 form-group"">
                <label class=""d-block"">Room Number</label>
                <span class=""text-content"">SP002B</span>
            </div>
            <div class=""col-lg-2 col-sm-6 col-6 form-group"">
                <label class=""d-block"">Room Type</label>
                <span class=""text-content"">Special</span>
            </div>
            <div class=""col-lg-2 col-sm-6 col-6 form-group"">
                <label class=""d-block"">Check-In date</label>
                <span class=""text-content"">01/04/2022</span>
            </div>
            <div class=""col-lg-2 col-sm-6 col-6 form-group"">
                <label class=""d-block"">Check-Out date</label>
                <span class=""text-content"">07/04/2022</span>
            </div>
        </div>
    </div>
</section>

<section class=""tab-content"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-lg-12 col-md-12 col-sm-12"">
     ");
            WriteLiteral(@"           <ul class=""nav nav-pills border-bottom"" id=""myTab"" role=""tablist"">
                    <li class=""nav-item"">
                        <a class=""nav-link active"" id=""personalInfo-tab"" data-toggle=""tab"" href=""#tab_personalInfo"" role=""tab"" aria-controls=""home"" aria-selected=""true"">Personal Information</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" id=""documentupload-tab"" data-toggle=""tab"" href=""#tab_documentupload"" role=""tab"" aria-controls=""profile"" aria-selected=""false"" onclick=""fnLoadDocumentUpload()"">Document Upload</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" id=""addonservices-tab"" data-toggle=""tab"" href=""#tab_addonservices"" role=""tab"" aria-controls=""profile"" aria-selected=""false"" onclick=""fnLoadAddOnServices()"">Addon Services</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" id=""activ");
            WriteLiteral(@"ities-tab"" data-toggle=""tab"" href=""#tab_activities"" role=""tab"" aria-controls=""profile"" aria-selected=""false"" onclick=""fnLoadActivities()"">Activities</a>
                    </li>

                </ul>
                <div class=""tab-content"" id=""myTabContent"">
                    <div class=""tab-pane fade show active"" id=""tab_personalInfo"" role=""tabpanel"" aria-labelledby=""personalinfo-tab"">
                        <div class=""row"">
                            <div class=""col-lg-3 col-md-3 col-sm-6 form-group"">
                                <label>First Name</label>
                                <input type=""text"" class=""form-control"" name=""first name"" value="""" />
                            </div>
                            <div class=""col-lg-3 col-md-3 col-sm-6 form-group"">
                                <label>Last Name</label>
                                <input type=""text"" class=""form-control"" name=""last name"" value="""" />
                            </div>
                        ");
            WriteLiteral(@"    <div class=""col-lg-3 col-md-3 col-sm-6 form-group"">
                                <label>Mobile Number</label>
                                <input type=""text"" class=""form-control"" name=""first name"" value="""" />
                            </div>
                            <div class=""col-lg-3 col-md-3 col-sm-6 form-group"">
                                <label>Email ID</label>
                                <input type=""text"" class=""form-control"" name=""first name"" value="""" />
                            </div>
                            <div class=""col-lg-6 col-md-6 col-sm-6 form-group"">
                                <label>Address</label>
                                <input type=""text"" class=""form-control"" name=""last name"" value="""" />
                            </div>
                            <div class=""col-lg-3 col-md-3 col-sm-6 form-group"">
                                <label>City</label>
                                <input type=""text"" class=""form-control"" name=""fi");
            WriteLiteral(@"rst name"" value="""" />
                            </div>
                            <div class=""col-lg-3 col-md-3 col-sm-6 form-group"">
                                <label>State</label>
                                <input type=""text"" class=""form-control"" name=""first name"" value="""" />
                            </div>
                            <div class=""col-lg-3 col-md-3 col-sm-6 form-group"">
                                <label>Pincode</label>
                                <input type=""text"" class=""form-control"" name=""first name"" value="""" />
                            </div>
                            <div class=""col-lg-12 col-md-12 col-sm-12 text-center"">
                                <hr />
                                <button type=""button"" class=""btn btn-primary mr-2""><i class=""fa fa-check""></i> Submit</button>
                                <button type=""button"" class=""btn btn-primary""><i class=""fa fa-times""></i> Cancel</button>
                            </div>
   ");
            WriteLiteral(@"                     </div>
                    </div>
                    <div class=""tab-pane fade"" id=""tab_documentupload"" role=""tabpanel"" aria-labelledby=""documentupload-tab"">
                        <div class=""row"">
                            <div class=""col-lg-12 col-md-12 col-sm-12 col-12"">
                                <table id=""jqgAddOnServices""></table>
                                <div id=""jqpAddOnServices""></div>
                            </div>
                        </div>
                    </div>
                    <div class=""tab-pane fade"" id=""tab_addonservices"" role=""tabpanel"" aria-labelledby=""addonservices-tab"">
                        <div class=""row"">
                            <div class=""col-lg-12 col-md-12 col-sm-12 col-12"">
                                <table id=""jqgAddOnServices""></table>
                                <div id=""jqpAddOnServices""></div>
                            </div>
                        </div>
                    </div>
   ");
            WriteLiteral(@"                 <div class=""tab-pane fade"" id=""tab_activities"" role=""tabpanel"" aria-labelledby=""activities-tab"">
                        <div class=""row"">
                            <div class=""col-lg-12 col-md-12 col-sm-12 col-12"">
                                <table id=""jqgActivities""></table>
                                <div id=""jqpActivities""></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

<div class=""modal fade"" id=""modalAddOnServices"" data-backdrop=""static"" data-keyboard=""false"" tabindex=""-1"" aria-labelledby=""staticBackdropLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""modaltitle"">Add on Services</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                ");
            WriteLiteral(@"    <span aria-hidden=""true""><i class=""fa fa-times""></i></span>
                </button>
            </div>
            <div class=""modal-body"">
                <div class=""row"">
                    <div class=""col-lg-4 col-sm-6 col-6 form-group"">
                        <label class=""d-block"">Guest Name</label>
                        <input type=""text"" name=""name"" value="""" class=""form-control"" />
                    </div>
                    <div class=""col-lg-6 col-sm-6 col-6 form-group"">
                        <label class=""d-block"">Service Name</label>
                        <input type=""text"" name=""name"" value="""" class=""form-control"" />
                    </div>
                    <div class=""col-lg-2 col-sm-6 col-6 form-group"">
                        <label class=""d-block text-right"">Service Cost</label>
                        <input type=""text"" name=""name"" value="""" class=""form-control text-right"" />
                    </div>
                    <div class=""col-lg-4 col-sm-6 c");
            WriteLiteral(@"ol-6 form-group"">
                        <label class=""d-block"">Mobile Number</label>
                        <input type=""text"" name=""name"" value="""" class=""form-control"" />
                    </div>


                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-primary mr-2"" id=""btnAddOnServices""><i class=""fa fa-check""></i> Done</button>
                <button type=""button"" class=""btn btn-primary"" data-dismiss=""modal""><i class=""fa fa-times""></i> Close</button>
            </div>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""modalActivities"" data-backdrop=""static"" data-keyboard=""false"" tabindex=""-1"" aria-labelledby=""staticBackdropLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""modaltitle"">Add Activities</h5>
                <button type=""button"" class=""close"" dat");
            WriteLiteral(@"a-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true""><i class=""fa fa-times""></i></span>
                </button>
            </div>
            <div class=""modal-body"">
                <div class=""row"">
                    <div class=""col-lg-4 col-sm-6 col-6 form-group"">
                        <label class=""d-block"">Guest Name</label>
                        <input type=""text"" name=""name"" value="""" class=""form-control"" />
                    </div>
                    <div class=""col-lg-8 col-sm-8 col-6 form-group"">
                        <label class=""d-block"">Activity</label>
                        <input type=""text"" name=""name"" value="""" class=""form-control"" />
                    </div>

                    <div class=""col-lg-4 col-sm-6 col-6 form-group"">
                        <label class=""d-block"">Mobile Number</label>
                        <input type=""text"" name=""name"" value="""" class=""form-control"" />
                    </div>
                </d");
            WriteLiteral(@"iv>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-primary mr-2"" id=""btnAddOnServices""><i class=""fa fa-check""></i> Done</button>
                <button type=""button"" class=""btn btn-primary"" data-dismiss=""modal""><i class=""fa fa-times""></i> Close</button>
            </div>
        </div>
    </div>
</div>


");
            EndContext();
            BeginContext(14076, 7304, true);
            WriteLiteral(@"<script>
        $(function () {
            $(""#alertmod_jqgActivities,#alertmod_jqgAddOnServices"").css('display', 'none');
        });
        function fnLoadAddOnServices() {
            $(""#alertmod_jqgAddOnServices"").css('display', 'none');
            var grid_id = ""jqgAddOnServices"";
            var hideLoading = function () {
                jQuery(""#lui_"" + grid_id).hide();
                jQuery(""#load_"" + grid_id).hide();
            }
            var gridData = [{ SNo: '01', GuestName: 'Karthick', ServiceName: 'Music Threaphy', ServiceCost: '<i class=""fa fa-rupee-sign""></i> 15,000', MobileNumber: '8978675645', edit: '' }];
            $(""#jqgAddOnServices"").jqGrid({
                // url: getBaseURL() + '/ApplicationCodes/GetCodeTypes',
                //mtype: 'POST',
                datatype: 'local',
                data: gridData,
                contentType: 'application/json; charset=utf-8',
                ajaxGridOptions: { contentType: 'application/json; charset=utf-8' ");
            WriteLiteral(@"},
                colNames: [""S.No"", ""Guest Name"", ""Service Name"", ""Service Cost"", ""Mobile Number"", ""Action""],
                colModel: [
                    { name: ""SNo"", width: 50, align: 'left', editable: true, resizable: false, hidden: false },
                    { name: ""GuestName"", width: 50, align: 'left', editable: true, editoptions: { maxlength: 6 }, resizable: false, hidden: false },
                    { name: ""ServiceName"", width: 50, align: 'left', editable: true, editoptions: { maxlength: 6 }, resizable: false, hidden: false },
                    { name: ""ServiceCost"", width: 50, align: 'left', editable: true, editoptions: { maxlength: 6 }, resizable: false, hidden: false },
                    { name: ""MobileNumber"", width: 50, align: 'left', editable: true, editoptions: { maxlength: 6 }, resizable: false, hidden: false },
                    {name: 'edit', search: false, align: 'left', width: 88, sortable: false, resizable: false,
                        formatter: function (cell");
            WriteLiteral(@"Value, options, rowdata, action) {
                            return '<button class=""btn-xs ui-button ui-widget ui-corner-all btn-jqgrid"" onclick=""fnAddEditAddOnServices()"" title=""Checkout"" id=""jqgEdit""><i class=""fa fa-pen""></i> Edit</button>'
                        }
                    },
                ],
                pager: ""#jqpAddOnServices"",
                rowNum: 10,
                rowList: [10, 20, 50, 100],
                rownumWidth: '55',
                loadonce: false,
                viewrecords: true,
                gridview: false,
                rownumbers: true,
                height: 'auto',
                scroll: false,
                width: 'auto',
                autowidth: true,
                shrinkToFit: true,
                forceFit: true,
                loadComplete: function () {
                    hideLoading();
                    $(""#jqgAddOnServices"").jqGrid('setGridWidth', $('.tab-pane').width());
                },
                loa");
            WriteLiteral(@"dError: function () {
                    hideLoading();
                }

            }).jqGrid('navGrid', '#jqpAddOnServices', { add: false, edit: false, search: false, del: false, refresh: false, refreshtext: 'Reload' }).jqGrid('navButtonAdd', '#jqpAddOnServices', {
                caption: '<span class=""fa fa-sync""></span> Refresh', buttonicon: ""none"", id: ""custRefresh"", position: ""first""
            }).jqGrid('navButtonAdd', '#jqpAddOnServices', {
                caption: '<span class=""fa fa-plus"" data-toggle=""modal""></span> Add', buttonicon: 'none', id: 'jqgAdd', position: 'first', onClickButton: fnAddEditAddOnServices
            });
        }

        function fnLoadActivities() {
            $(""#alertmod_jqgActivities"").css('display', 'none');
            var grid_id = ""jqgActivities"";
            var hideLoading = function () {
                jQuery(""#lui_"" + grid_id).hide();
                jQuery(""#load_"" + grid_id).hide();
            }
             var gridData = [{ SNo: '01'");
            WriteLiteral(@", GuestName: 'Karthick', Activity: 'Music Threaphy', MobileNumber: '8978675645', edit: '' }];
            $(""#jqgActivities"").jqGrid({
                // url: getBaseURL() + '/ApplicationCodes/GetCodeTypes',
                //mtype: 'POST',
                datatype: 'local',
                data: gridData,
                contentType: 'application/json; charset=utf-8',
                ajaxGridOptions: { contentType: 'application/json; charset=utf-8' },
                colNames: [""S.No"", ""Guest Name"", ""Activity"", ""Mobile Number"", ""Action""],
                colModel: [
                    {name: ""SNo"", width: 50, align: 'left', editable: true, resizable: false, hidden: false },
                    {name: ""GuestName"", width: 50, align: 'left', editable: true, editoptions: { maxlength: 6 }, resizable: false, hidden: false },
                    {name: ""Activity"", width: 50, align: 'left', editable: true, editoptions: { maxlength: 6 }, resizable: false, hidden: false },
                    {name: ""Mob");
            WriteLiteral(@"ileNumber"", width: 50, align: 'left', editable: true, editoptions: { maxlength: 6 }, resizable: false, hidden: false },
                    {name: 'edit', search: false, align: 'left', width: 88, sortable: false, resizable: false,
                        formatter: function (cellValue, options, rowdata, action) {
                            return '<button class=""btn-xs ui-button ui-widget ui-corner-all btn-jqgrid"" onclick=""fnAddActivities()"" title=""Checkout"" id=""jqgEdit""><i class=""fa fa-pen""></i>  Edit</button>'
                     }
                    },
                ],
                pager: ""#jqpActivities"",
                rowNum: 10,
                rowList: [10, 20, 50, 100],
                rownumWidth: '55',
                loadonce: false,
                viewrecords: true,
                gridview: false,
                rownumbers: true,
                height: 'auto',
                scroll: false,
                width: 'auto',
                autowidth: true,
           ");
            WriteLiteral(@"     shrinkToFit: true,
                forceFit: true,
                loadComplete: function () {
                    hideLoading();
                    $(""#jqgActivities"").jqGrid('setGridWidth', $('.tab-pane').width() - 30);
                },
                loadError: function () {
                    hideLoading();
                }
            }).jqGrid('navGrid', '#jqpActivities', { add: false, edit: false, search: false, del: false, refresh: false, refreshtext: 'Reload' }).jqGrid('navButtonAdd', '#jqpActivities', {
                caption: '<span class=""fa fa-sync""></span> Refresh', buttonicon: ""none"", id: ""custRefresh"", position: ""first""
                }).jqGrid('navButtonAdd', '#jqpActivities', {
                    caption: '<span class=""fa fa-plus"" data-toggle=""modal""></span> Add', buttonicon: 'none', id: 'jqgAdd', position: 'first', onClickButton: fnAddActivities
                });
        }
        function fnAddEditAddOnServices() {
            $(""#modalAddOnServices"").modal(");
            WriteLiteral("\'show\');\r\n        }\r\n        function fnAddActivities() {\r\n            $(\"#modalActivities\").modal(\'show\');\r\n         }\r\n</script>\r\n\r\n\r\n");
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