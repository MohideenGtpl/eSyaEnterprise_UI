#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\FrontOffice\V_ENC_02_00.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb26e8cdf7ff28fef0d9a4f8b62bd6e1c3b0be0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_eSyaNatureCure_Views_FrontOffice_V_ENC_02_00), @"mvc.1.0.view", @"/Areas/eSyaNatureCure/Views/FrontOffice/V_ENC_02_00.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/eSyaNatureCure/Views/FrontOffice/V_ENC_02_00.cshtml", typeof(AspNetCore.Areas_eSyaNatureCure_Views_FrontOffice_V_ENC_02_00))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb26e8cdf7ff28fef0d9a4f8b62bd6e1c3b0be0f", @"/Areas/eSyaNatureCure/Views/FrontOffice/V_ENC_02_00.cshtml")]
    public class Areas_eSyaNatureCure_Views_FrontOffice_V_ENC_02_00 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 2 "D:\eSya Project\Solution\eSyaEnterprise_UI\tags\eSyaEnterprise_UI_v1\eSyaEnterprise_UI\Areas\eSyaNatureCure\Views\FrontOffice\V_ENC_02_00.cshtml"
  
    ViewData["Title"] = "TodaysView";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(95, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bb26e8cdf7ff28fef0d9a4f8b62bd6e1c3b0be0f3997", async() => {
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
            BeginContext(152, 16079, true);
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""row pt-2"">
        <div class=""col-lg-12"">
            <p class=""h5 p-0 m-0""><span id=""txtTDate""></span></p>
        </div>
        <div class=""col-sm-4 p-2"">
            <div class=""card bg-checkin"">
                <div class=""card-body d-flex justify-content-between"">
                    <h5 class=""card-title d-flex align-items-center pl-3""><i class=""fa fa-bell""></i></h5>
                    <p class=""number_count""><span id=""txtCkinCount""></span> <span class=""small"">Check-In</span></p>
                </div>
            </div>
        </div>
        <div class=""col-sm-4 p-2"">
            <div class=""card bg-checkout"">
                <div class=""card-body d-flex justify-content-between"">
                    <h5 class=""card-title d-flex align-items-center pl-3""><i class=""fa fa-sign-out-alt""></i></h5>
                    <p class=""number_count""><span id=""txtCkoutCount""></span> <span class=""small"">Check-Out</span></p>
                </div>
  ");
            WriteLiteral(@"          </div>
        </div>
        <div class=""col-sm-4 p-2"">
            <div class=""card bg-checkedin"">
                <div class=""card-body d-flex justify-content-between"">
                    <span class=""percentage-circle""><span id=""txtActPerc""></span>%</span>
                    <p class=""number_count""><span id=""txtActCount""></span> <span class=""small"">Checked-In Guests</span></p>
                </div>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-lg-6 col-md-6 col-6 px-2"">
            <div class=""card"">
                <div class=""card-header grid-header pb-0 guestreservation"">
                    Guest Reservations
                    <ul class=""nav nav-pills"" id=""myTab"" role=""tablist"">
                        <li class=""nav-item"">
                            <a class=""nav-link active"" id=""home-tab"" data-toggle=""tab"" href=""#res_checkedin"" role=""tab"" aria-controls=""home"" aria-selected=""true"" onclick=""fnPanelSetup()"">Check-In</a>
   ");
            WriteLiteral(@"                     </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" id=""profile-tab"" data-toggle=""tab"" href=""#res_checkedout"" role=""tab"" aria-controls=""profile"" aria-selected=""false"" onclick=""fnPanelSetup()"">Check-Out</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" id=""profile-tab"" data-toggle=""tab"" href=""#res_pendingcheckin"" role=""tab"" aria-controls=""profile"" aria-selected=""false"" onclick=""fnPanelSetup()"">Pending Check-In</a>
                        </li>
                    </ul>
                </div>
                <div class=""card-body"" id=""divCardBodyGuest"">
                    <div class=""tab-content"" id=""myTabContent"">
                        <div class=""tab-pane fade show active"" id=""res_checkedin"" role=""tabpanel"" aria-labelledby=""home-tab"">
                            <table id=""jqgCheckinDetail""></table>
                            <div id=""jqpCheckinDet");
            WriteLiteral(@"ail""></div>
                        </div>
                        <div class=""tab-pane fade"" id=""res_checkedout"" role=""tabpanel"" aria-labelledby=""profile-tab"">
                            <table id=""jqgCheckoutDetail""></table>
                            <div id=""jqpCheckoutDetail""></div>

                        </div>
                        <div class=""tab-pane fade"" id=""res_pendingcheckin"" role=""tabpanel"" aria-labelledby=""profile-tab"">
                            <table id=""jqgPendingCheckIn""></table>
                            <div id=""jqpPendingCheckIn""></div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-lg-6 col-md-6 col-6 px-2"">
            <div class=""card"">
                <div class=""card-header bg-light grid-header currentguest d-flex align-items-center"">
                    Current Guest List
                </div>
                <div class=""card-body"" id=""divCardBodyCurrentGuest"">");
            WriteLiteral(@"
                    <table id=""jqgActOccuDetail""></table>
                    <div id=""jqpActOccuDetail""></div>

                    
                </div>
            </div>
        </div>
    </div>
</div>

<script>
    var gv_checkin = [];
    var gv_checkout = [];
    const months = [""January"", ""February"", ""March"", ""April"", ""May"", ""June"", ""July"", ""August"", ""September"", ""October"", ""November"", ""December""];
    const d = new Date();
    var winH = $(window).height();
    var divCardBodyGuest = $('#divCardBodyGuest').offset().top;
   
   

    $('#divCardBodyGuest,#divCardBodyCurrentGuest').css('height', winH - divCardBodyGuest - 40);

    $(window).on('resize', function () {
        var winH = $(window).height();
        var divCardBodyGuest = $('#divCardBodyGuest').offset().top;
        $('#divCardBodyGuest,#divCardBodyCurrentGuest').css('height', winH - divCardBodyGuest - 40);
        fnLoadGrids();
    })
    let t_date = months[d.getMonth()] + ' ' + d.getDate() + ', ' + d.g");
            WriteLiteral(@"etFullYear();

    $(document).ready(function () {
        $(""#txtTDate"").html(t_date);
        fnLoadGrids();
        $("".currentguest"").css('height', $("".guestreservation"").outerHeight());
        fnProcessLoading(true, ""Loading"");
    });

    function fnLoadGrids() {
        
        $.ajax({
            url: getBaseURL() + '/FrontOffice/GetTodayDashboard',
            type: 'GET',
            datatype: 'json',
            success: function (response) {
                $('#txtCkinCount').html(response.Checkin_Count);
                $(""#txtCkoutCount"").html(response.Checkout_Count);
                $(""#txtActCount"").html(response.Occupancy_Count);
                $(""#txtActPerc"").html(response.Occupancy_Percent);
      

                $(""#jqgCheckinDetail"").jqGrid('GridUnload');
                $(""#jqgCheckinDetail"").jqGrid({
                    data: response.Checkin_List,
                    datatype: ""local"",
                    colNames: [""Booking Key"", ""Guest ID"", ""Guest N");
            WriteLiteral(@"ame"", ""Mobile Number"",""Check-In"",""Action""],
                    colModel: [
                        { name: ""BookingKey"", width: 50, editable: true, align: 'left', hidden: true },
                        { name: ""GuestId"", width: 50, editable: true, align: 'left', hidden: true },
                        { name: ""GuestName"", width: 120, editable: true, align: 'left', hidden: false },
                        { name: ""MobileNumber"", width: 120, editable: true, align: 'left', hidden: false },
                        {
                            name: ""CheckInDate"", editable: false, width: 60, align: 'left', formatter: 'date', formatoptions: { newformat: _cnfjqgDateFormat }

                        },
                        {
                            name: ""Button"", width: 50, editable: false, align: 'left', hidden: false, formatter: function (cellValue, options, rowObject) {
                            var i = options.rowId;
                                return ""<button id=btnCheckin_"" + i + """);
            WriteLiteral(@" type='button'  class='btn btn-primary' onclick=fnGuestCheckin('"" + rowObject.BookingKey + ""','"" + rowObject.GuestId + ""') >  Check-In </button >"";
                            }
                        },
                    ],
                    pager: ""#jqpCheckinDetail"",
                    rowNum: 10000,
                    loadonce: false,
                    viewrecords: true,
                    gridview: true,
                    rownumbers: true,
                    rownumWidth: '55',
                    height: 'auto',
                    width: 'auto',
                    autowidth: true,
                    shrinkToFit: true,
                    forceFit: true,
                    loadComplete: function () {
                        fnPanelSetup();
                    },
                }).jqGrid('navGrid', '#jqpCheckinDetail', { add: false, edit: false, search: false, del: false, refresh: false });

                $(""#jqgCheckoutDetail"").jqGrid('GridUnload');
              ");
            WriteLiteral(@"  $(""#jqgCheckoutDetail"").jqGrid({
                    data: response.Checkout_List,
                    datatype: ""local"",
                    colNames: [""Booking Key"", ""Guest ID"", ""Guest Name"", ""Mobile Number"", ""Check-In"", ""Action""],
                    colModel: [
                        { name: ""BookingKey"", width: 50, editable: true, align: 'left', hidden: true },
                        { name: ""GuestId"", width: 50, editable: true, align: 'left', hidden: true },
                        { name: ""GuestName"", width: 120, editable: true, align: 'left', hidden: false },
                        { name: ""MobileNumber"", width: 120, editable: true, align: 'left', hidden: false },
                        {
                            name: ""CheckInDate"", editable: false, width: 90, align: 'left', formatter: 'date', formatoptions: { newformat: _cnfjqgDateFormat }

                        },
                        {
                            name: ""Button"", width: 80, editable: false, align: 'left'");
            WriteLiteral(@", hidden: false, formatter: function (cellValue, options, rowObject) {
                                var i = options.rowId;
                                return ""<button id=btnCheckout_"" + i + "" type='button'  class='btn btn-primary' onclick=fnCheckout('"" + rowObject.BookingKey + ""','"" + rowObject.GuestId + ""') >  Check-Out </button >"";
                            }
                        },
                    ],
                    pager: ""#jqpCheckoutDetail"",
                    rowNum: 10000,
                    loadonce: false,
                    viewrecords: true,
                    gridview: true,
                    rownumbers: true,
                    rownumWidth: '55',
                    height: 'auto',
                    width: 'auto',
                    autowidth: true,
                    shrinkToFit: true,
                    forceFit: true,
                    loadComplete: function () {
                        fnPanelSetup();
                    },
             ");
            WriteLiteral(@"   }).jqGrid('navGrid', '#jqpCheckoutDetail', { add: false, edit: false, search: false, del: false, refresh: false });

                if (response.PendingCheckin_List != null) {
                    $(""#jqgPendingCheckIn"").jqGrid('GridUnload');
                    $(""#jqgPendingCheckIn"").jqGrid({
                        data: response.PendingCheckin_List,
                        datatype: ""local"",
                        colNames: [""Booking Key"", ""Guest ID"", ""Guest Name"", ""Mobile Number"", ""Check-In"", ""Action""],
                        colModel: [
                            { name: ""BookingKey"", width: 50, editable: true, align: 'left', hidden: true },
                            { name: ""GuestId"", width: 50, editable: true, align: 'left', hidden: true },
                            { name: ""GuestName"", width: 120, editable: true, align: 'left', hidden: false },
                            { name: ""MobileNumber"", width: 120, editable: true, align: 'left', hidden: false },
                       ");
            WriteLiteral(@"     {
                                name: ""CheckInDate"", editable: false, width: 90, align: 'left', formatter: 'date', formatoptions: { newformat: _cnfjqgDateFormat }

                            },
                            {
                                name: ""Button"", width: 80, editable: false, align: 'left', hidden: false, formatter: function (cellValue, options, rowObject) {
                                    var i = options.rowId;
                                    return ""<button id=btnCheckin_"" + i + "" type='button'  class='btn btn-primary' onclick=fnGuestCheckin('"" + rowObject.BookingKey + ""','"" + rowObject.GuestId + ""') >  Check-In </button >"";
                                }
                            },
                        ],
                        pager: ""#jqpPendingCheckIn"",
                        rowNum: 10000,
                        loadonce: false,
                        viewrecords: true,
                        gridview: true,
                        ro");
            WriteLiteral(@"wnumbers: true,
                        rownumWidth: '55',
                        height: 'auto',
                        width: 'auto',
                        autowidth: true,
                        shrinkToFit: true,
                        forceFit: true,
                        loadComplete: function () {
                            fnPanelSetup();
                        },
                    }).jqGrid('navGrid', '#jqpPendingCheckIn', { add: false, edit: false, search: false, del: false, refresh: false });
                }

                $(""#jqgActOccuDetail"").jqGrid('GridUnload');
                $(""#jqgActOccuDetail"").jqGrid({
                    data: response.Occupancy_List,
                    datatype: ""local"",
                    colNames: [""Booking Key"", ""Guest ID"", ""Guest Name"", ""Mobile Number"",""Check-In Date"" ,""Action""],
                    colModel: [
                        { name: ""BookingKey"", width: 50, editable: true, align: 'left', hidden: true },
             ");
            WriteLiteral(@"           { name: ""GuestId"", width: 50, editable: true, align: 'left', hidden: true },
                        { name: ""GuestName"", width: 120, editable: true, align: 'left', hidden: false },
                        { name: ""MobileNumber"", width: 50, editable: true, align: 'left', hidden: false },
                        { name: ""ActualCheckedInDate"", width: 50, editable: true, align: 'center', hidden: false, formatter: 'date', formatoptions: { srcformat: 'Y/m/d H:i:s', newformat: 'd/m/Y' } },
                        {
                            name: ""Button"", width: 50, editable: false, align: 'left', hidden: false, formatter: function (cellValue, options, rowObject) {
                                var i = options.rowId;
                                return ""<button id=btnActOccu_"" + i + "" type='button'  class='btn btn-primary' onclick=fnGuestCheckin('"" + rowObject.BookingKey + ""','"" + rowObject.GuestId + ""') >  View </button >"";
                            }
                        },
     ");
            WriteLiteral(@"               ],
                    pager: ""#jqpActOccuDetail"",
                    rowNum: 10000,
                    loadonce: false,
                    viewrecords: true,
                    gridview: true,
                    rownumbers: true,
                    rownumWidth: '55',
                    height: 'auto',
                    width: 'auto',
                    autowidth: true,
                    shrinkToFit: true,
                    forceFit: true,
                    loadComplete: function () {
                        fnPanelSetup();
                    },
                }).jqGrid('navGrid', '#jqpActOccuDetail', { add: false, edit: false, search: false, del: false, refresh: false });
                fnProcessLoading(false, """");
            },
            error: function (error) {
                toastr.error(error.statusText);
            }
        });
        $(""[id^='jqg']"").jqgrid('setGridWidth',$('.card-body').width());
    }


    function fnGuestCheckin(b");
            WriteLiteral(@"ookingKey, guestId) {
        var url = getBaseURL() + '/eSyaNatureCure/CheckInGuest/V_ENC_04_00?bookingKey=' + bookingKey + '&guestId=' + guestId;
        //window.open(
        //    url,
        //    '_blank' // <- This is what makes it open in a new window.
        //);

        window.location.href = url;
    }

    function fnPanelSetup() {
        var winH = $(window).height();
        var bdivOffset = $('[id^=gview_]').offset().top;
        $("".ui-jqgrid-bdiv"").css('max-height', winH / 3);
        $(window).on('resize', function () {
            var bdivOffset = $('[id^=gview_]').offset().top;
            $("".ui-jqgrid-bdiv"").css('max-height', winH /3);
        });
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
