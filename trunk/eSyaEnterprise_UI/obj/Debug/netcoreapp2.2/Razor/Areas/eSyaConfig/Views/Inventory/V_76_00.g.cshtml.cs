#pragma checksum "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Inventory\V_76_00.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "110ad5a89d78fecdd91e6aa0e04f43bedc25820e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_eSyaConfig_Views_Inventory_V_76_00), @"mvc.1.0.view", @"/Areas/eSyaConfig/Views/Inventory/V_76_00.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/eSyaConfig/Views/Inventory/V_76_00.cshtml", typeof(AspNetCore.Areas_eSyaConfig_Views_Inventory_V_76_00))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"110ad5a89d78fecdd91e6aa0e04f43bedc25820e", @"/Areas/eSyaConfig/Views/Inventory/V_76_00.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Areas/eSyaConfig/Views/_ViewImports.cshtml")]
    public class Areas_eSyaConfig_Views_Inventory_V_76_00 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Config/ItemReorderLevel.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\eSya Project\Solution\eSyaEnterprise_UI\trunk\eSyaEnterprise_UI\Areas\eSyaConfig\Views\Inventory\V_76_00.cshtml"
  
    ViewData["Title"] = "V_76_00";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            DefineSection("scripts", async() => {
                BeginContext(109, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(115, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "110ad5a89d78fecdd91e6aa0e04f43bedc25820e4024", async() => {
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
                BeginContext(170, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(175, 252, true);
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-lg-4 col-md-4 col-sm-6\">\r\n        <div class=\"form-group\">\r\n            <label>Business Key</label>\r\n            <select class=\"selectpicker\" data-live-search=\"true\" id=\"\" title=\"\" data-size=\"8\">\r\n                ");
            EndContext();
            BeginContext(427, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "110ad5a89d78fecdd91e6aa0e04f43bedc25820e5675", async() => {
                BeginContext(435, 20, true);
                WriteLiteral(" Choose Business Key");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(464, 290, true);
            WriteLiteral(@"
            </select>
        </div>
    </div>
    <div class=""col-lg-4 col-md-4 col-sm-6"">
        <div class=""form-group"">
            <label>Accounting Store</label>
            <select class=""selectpicker"" data-live-search=""true"" id="""" title="""" data-size=""8"">
                ");
            EndContext();
            BeginContext(754, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "110ad5a89d78fecdd91e6aa0e04f43bedc25820e7165", async() => {
                BeginContext(762, 24, true);
                WriteLiteral(" Choose Accounting Store");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(795, 3282, true);
            WriteLiteral(@"
            </select>
        </div>
    </div>
</div>

<div class=""row"">
    <div class=""col-lg-12 col-xl-12 col-sm-12  form-group"">
        <label>Choose Item by alphabets</label>
        <span class=""dot"">A</span>
        <span class=""dot"">B</span>
        <span class=""dot"">C</span>
        <span class=""dot"">D</span>
        <span class=""dot"">E</span>
        <span class=""dot"">F</span>
        <span class=""dot"">G</span>
        <span class=""dot"">H</span>
        <span class=""dot"">I</span>
        <span class=""dot"">J</span>
        <span class=""dot"">K</span>
        <span class=""dot"">L</span>
        <span class=""dot"">M</span>
        <span class=""dot"">N</span>
        <span class=""dot"">O</span>
        <span class=""dot"">P</span>
        <span class=""dot"">Q</span>
        <span class=""dot"">R</span>
        <span class=""dot"">S</span>
        <span class=""dot"">T</span>
        <span class=""dot"">U</span>
        <span class=""dot"">V</span>
        <span class=""dot"">W</span>
    ");
            WriteLiteral(@"    <span class=""dot"">X</span>
        <span class=""dot"">Y</span>
        <span class=""dot"">Z</span>
        <span class=""dot"">All</span>
    </div>
    <div class=""col-lg-12 col-sm-12 col-md-12 form-group"">
        <table id=""jqgItemReorderLevel""></table>
        <div id=""jqpItemReorderLevel""></div>
    </div>
</div>

<div class=""modal fullscreen fade"" id=""PopupItemReorderLevel"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header popupHeader"">
                <button type=""button"" class=""close"" data-dismiss=""modal""> <i class=""fa fa-times""></i></button>
                <h4 class=""modal-title"">Add Item Reorder Level</h4>
            </div>
            <div class=""modal-body bg-lightgrey"">
                <div class=""row padbot4"">
                    <div class=""col-lg-6 col-md-6 col-sm-12"">
                        <section class=""bg-white pad15 borderLite"">
                            <div class=""row"">
        ");
            WriteLiteral(@"                        <div class=""col-lg-12 col-md-12 col-sm-12"">
                                    <p class=""subheading"">Item Details</p>
                                    <hr class=""left"" />
                                </div>
                                <div class=""col-sm-12"">
                                    <input type=""text"" class=""form-control"" id="""" style=""display:none"">
                                </div>
                                <div class=""col-lg-12 col-md-12 col-sm-12"">
                                    <div class=""form-group"">
                                        <label> Item Description</label>
                                        <input type=""text"" name=""itemdescription"" value="""" class=""form-control"" />
                                    </div>
                                </div>
                                <div class=""col-lg-4 col-md-4 col-sm-6"">
                                    <div class=""form-group"">
                               ");
            WriteLiteral("         <label> Unit of Measure</label>\r\n                                        <select class=\"selectpicker\" data-live-search=\"true\" id=\"\" title=\"\" data-size=\"8\">\r\n                                            ");
            EndContext();
            BeginContext(4077, 29, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "110ad5a89d78fecdd91e6aa0e04f43bedc25820e11876", async() => {
                BeginContext(4085, 12, true);
                WriteLiteral(" Choose Unit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4106, 1738, true);
            WriteLiteral(@"
                                        </select>
                                    </div>
                                </div>
                                <div class=""col-lg-4 col-md-4 col-sm-6"">
                                    <div class=""form-group"">
                                        <label> Barcode ID</label>
                                        <input type=""text"" name=""barcodeid"" value="""" class=""form-control"" />
                                    </div>
                                </div>
                                <div class=""col-lg-4 col-md-4 col-sm-6"">
                                    <div class=""form-group"">
                                        <label> Pack Unit</label>
                                        <input id="""" class=""form-control"" type=""text"" autocomplete=""off"" maxlength=""500"" />
                                    </div>
                                </div>
                                <div class=""col-lg-4 col-md-4 col-sm-6"">
   ");
            WriteLiteral(@"                                 <div class=""form-group"">
                                        <label> Pack Size</label>
                                        <input id="""" class=""form-control"" type=""text"" autocomplete=""off"" maxlength=""500"" />

                                    </div>
                                </div>
                                <div class=""col-lg-4 col-md-4 col-sm-6"">
                                    <div class=""form-group"">
                                        <label> Inventory Class</label>
                                        <select class=""selectpicker"" data-live-search=""true"" id="""" title="""" data-size=""8"">
                                            ");
            EndContext();
            BeginContext(5844, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "110ad5a89d78fecdd91e6aa0e04f43bedc25820e14883", async() => {
                BeginContext(5852, 23, true);
                WriteLiteral(" Choose Inventory Class");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5884, 509, true);
            WriteLiteral(@"
                                        </select>
                                    </div>
                                </div>
                                <div class=""col-lg-4 col-md-4 col-sm-6"">
                                    <div class=""form-group"">
                                        <label> Item Class</label>
                                        <select class=""selectpicker"" data-live-search=""true"" id="""" title="""" data-size=""8"">
                                            ");
            EndContext();
            BeginContext(6393, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "110ad5a89d78fecdd91e6aa0e04f43bedc25820e16599", async() => {
                BeginContext(6401, 18, true);
                WriteLiteral(" Choose Item Class");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6428, 509, true);
            WriteLiteral(@"
                                        </select>
                                    </div>
                                </div>
                                <div class=""col-lg-4 col-md-4 col-sm-6"">
                                    <div class=""form-group"">
                                        <label>Item Source</label>
                                        <select class=""selectpicker"" data-live-search=""true"" id="""" title="""" data-size=""8"">
                                            ");
            EndContext();
            BeginContext(6937, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "110ad5a89d78fecdd91e6aa0e04f43bedc25820e18310", async() => {
                BeginContext(6945, 19, true);
                WriteLiteral(" Choose Item Source");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6973, 514, true);
            WriteLiteral(@"
                                        </select>
                                    </div>
                                </div>
                                <div class=""col-lg-4 col-md-4 col-sm-6"">
                                    <div class=""form-group"">
                                        <label>Item Criticality</label>
                                        <select class=""selectpicker"" data-live-search=""true"" id="""" title="""" data-size=""8"">
                                            ");
            EndContext();
            BeginContext(7487, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "110ad5a89d78fecdd91e6aa0e04f43bedc25820e20027", async() => {
                BeginContext(7495, 24, true);
                WriteLiteral(" Choose Item Criticality");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7528, 511, true);
            WriteLiteral(@"
                                        </select>
                                    </div>
                                </div>
                                <div class=""col-lg-4 col-md-4 col-sm-6"">
                                    <div class=""form-group"">
                                        <label>Active Status</label>
                                        <select class=""selectpicker"" data-live-search=""true"" id="""" title="""" data-size=""8"">
                                            ");
            EndContext();
            BeginContext(8039, 31, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "110ad5a89d78fecdd91e6aa0e04f43bedc25820e21746", async() => {
                BeginContext(8047, 14, true);
                WriteLiteral(" Choose Status");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8070, 1956, true);
            WriteLiteral(@"
                                        </select>
                                    </div>
                                </div>

                            </div>
                        </section>
                    </div>
                    <div class=""col-lg-6 col-md-6 col-sm-12"">


                        <section class=""bg-white pad15 borderLite"">
                            <div class=""row"">
                                <div class=""col-lg-12 col-md-12 col-sm-12"">
                                    <p class=""subheading"">eSya Parameters</p>
                                    <hr class=""left"" />
                                </div>
                                <div class=""col-lg-12 col-md-12 col-sm-12 padbot10"">
                                    <div class=""SpecialtyParameterContainer"">
                                        <table id=""jqgSpecialtyParameter""></table>
                                        <div id=""jqpSpecialtyParameter""></div>
                    ");
            WriteLiteral(@"                </div>
                                </div>





                            </div>
                        </section>


                    </div>
                </div>
                <hr />
 
            </div>
            <div class=""modal-footer"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <button type=""button"" class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent primary-button"" id=""btnSave"" onclick=""fnSaveLocalizationTableMapping()"">
                            Save
                        </button>
                        <button type=""button"" class=""mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect  cancel-button"" data-dismiss=""modal""> Cancel</button>

                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
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
