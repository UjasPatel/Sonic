#pragma checksum "C:\Sonic\WebApplication1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abaf55bdf2c11a6a622e9b80283438c86318c71f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Sonic\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#line 2 "C:\Sonic\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abaf55bdf2c11a6a622e9b80283438c86318c71f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VendingMachineViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Sonic\WebApplication1\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(79, 8, true);
            WriteLiteral("<html>\r\n");
            EndContext();
            BeginContext(87, 5377, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f61cf450b17f4f5d9d412cf18d5bf3a6", async() => {
                BeginContext(93, 63, true);
                WriteLiteral(" \r\n    <h1 style=\"text-align:center\">Vending Machine</h1>\r\n    ");
                EndContext();
                BeginContext(156, 5291, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a266a6f493c4a2fa4df2cc2c69c89c2", async() => {
                    BeginContext(176, 232, true);
                    WriteLiteral(" \r\n        <div class=\"col-xs-7 col-sm-9\">\r\n            \r\n            <div style=\"text-align:right;margin-bottom:10px;margin-right:16px;\">\r\n                <input type=\"submit\" name=\"submit\" value=\"Home\" class=\"btn btn-primary\" />\r\n");
                    EndContext();
#line 14 "C:\Sonic\WebApplication1\Views\Home\Index.cshtml"
                 if (Model.Operations == Core.Shared.Enums.OperationEnum.Home)
                {

#line default
#line hidden
                    BeginContext(507, 99, true);
                    WriteLiteral("                    <input type=\"submit\" name=\"submit\" value=\"Restock\" class=\"btn btn-primary\" />\r\n");
                    EndContext();
#line 17 "C:\Sonic\WebApplication1\Views\Home\Index.cshtml"
                }    

#line default
#line hidden
                    BeginContext(629, 46, true);
                    WriteLiteral("            </div>\r\n            \r\n            ");
                    EndContext();
                    BeginContext(676, 71, false);
#line 20 "C:\Sonic\WebApplication1\Views\Home\Index.cshtml"
       Write(Html.TextBoxFor(s => s.TotalCansLeft, new { style = "display: none;" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(747, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(762, 71, false);
#line 21 "C:\Sonic\WebApplication1\Views\Home\Index.cshtml"
       Write(Html.TextBoxFor(s => s.TotalCansSold, new { style = "display: none;" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(833, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(848, 76, false);
#line 22 "C:\Sonic\WebApplication1\Views\Home\Index.cshtml"
       Write(Html.TextBoxFor(s => s.TotalCashCollected, new { style = "display: none;" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(924, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(939, 78, false);
#line 23 "C:\Sonic\WebApplication1\Views\Home\Index.cshtml"
       Write(Html.TextBoxFor(s => s.TotalCreditCollected, new { style = "display: none;" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(1017, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 24 "C:\Sonic\WebApplication1\Views\Home\Index.cshtml"
             for (var i = 1; i <= 10; i++)
            {

#line default
#line hidden
                    BeginContext(1078, 292, true);
                    WriteLiteral(@"                <div class=""col-xs-12 col-sm-6 col-md-3 col-lg-3 text-center"">
                    <div class=""panel panel-default"">
                        <div class=""panel-heading"">

                            Price: <strong>$4.5</strong>

                            Item: <strong>");
                    EndContext();
                    BeginContext(1371, 1, false);
#line 32 "C:\Sonic\WebApplication1\Views\Home\Index.cshtml"
                                     Write(i);

#line default
#line hidden
                    EndContext();
                    BeginContext(1372, 95, true);
                    WriteLiteral("</strong>\r\n                        </div>\r\n                        <div class=\"panel-body\"><img");
                    EndContext();
                    BeginWriteAttribute("src", " src=\"", 1467, "\"", 1512, 1);
#line 34 "C:\Sonic\WebApplication1\Views\Home\Index.cshtml"
WriteAttributeValue("", 1473, String.Format("images/img-{0}.jpg",@i), 1473, 39, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(1513, 266, true);
                    WriteLiteral(@" style=""height:60px"" class=""img-rounded img-responsive center-block""></div>
                        <div class=""panel-footer"">
                                <button name=""submit"" value=""Purchase"" class=""btn btn-primary""
                                         ");
                    EndContext();
#line 37 "C:\Sonic\WebApplication1\Views\Home\Index.cshtml"
                                            if(Model.Operations != Core.Shared.Enums.OperationEnum.Home) { 

#line default
#line hidden
                    BeginContext(1847, 49, true);
                    WriteLiteral("                                                 ");
                    EndContext();
                    BeginContext(1898, 22, true);
                    WriteLiteral("disabled=\"disabled\" \r\n");
                    EndContext();
#line 39 "C:\Sonic\WebApplication1\Views\Home\Index.cshtml"
                                            } 

#line default
#line hidden
                    BeginContext(1967, 104, true);
                    WriteLiteral(">Purchase</button>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
                    EndContext();
#line 43 "C:\Sonic\WebApplication1\Views\Home\Index.cshtml"
            }

#line default
#line hidden
                    BeginContext(2086, 12, true);
                    WriteLiteral("            ");
                    EndContext();
#line 44 "C:\Sonic\WebApplication1\Views\Home\Index.cshtml"
             if (Model.Operations == Core.Shared.Enums.OperationEnum.Purchase)
            {

                

#line default
#line hidden
#line 47 "C:\Sonic\WebApplication1\Views\Home\Index.cshtml"
                 if (Model.CashCredit == Core.Shared.Enums.CashCreditEnum.none)
                {

#line default
#line hidden
                    BeginContext(2283, 270, true);
                    WriteLiteral(@"                    <div style=""text-align:center"">
                        <input type=""submit"" name=""submit"" value=""Cash"" class=""button"" />
                        <input type=""submit"" name=""submit"" value=""Credit Card"" class=""button"" />
                    </div>
");
                    EndContext();
#line 53 "C:\Sonic\WebApplication1\Views\Home\Index.cshtml"
                }
                else
                {

#line default
#line hidden
                    BeginContext(2613, 100, true);
                    WriteLiteral("                    <div style=\"text-align:center\">\r\n                        <h4>Enter Amount:</h4> ");
                    EndContext();
                    BeginContext(2714, 154, false);
#line 57 "C:\Sonic\WebApplication1\Views\Home\Index.cshtml"
                                          Write(Html.TextBoxFor(s => s.CashEntered, new { @class = "form-control", style = "width:30%;display:inline-block", @type = "number", @min = "0", step = ".01" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(2868, 26, true);
                    WriteLiteral("\r\n                        ");
                    EndContext();
                    BeginContext(2895, 68, false);
#line 58 "C:\Sonic\WebApplication1\Views\Home\Index.cshtml"
                   Write(Html.TextBoxFor(s => s.CashCredit, new { style = "display: none;" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(2963, 279, true);
                    WriteLiteral(@"
                        <br />
                        <div style=""text-align:center; margin-top:10px;"">
                            <input type=""submit"" name=""submit"" value=""Complete Purchase"" class=""button"" />
                        </div>

                    </div>
");
                    EndContext();
#line 65 "C:\Sonic\WebApplication1\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#line 65 "C:\Sonic\WebApplication1\Views\Home\Index.cshtml"
                 

            }
            else if (Model.Operations == Core.Shared.Enums.OperationEnum.Restock)
            {

#line default
#line hidden
                    BeginContext(3376, 80, true);
                    WriteLiteral("                <div>\r\n                    Number of cans:\r\n                    ");
                    EndContext();
                    BeginContext(3457, 156, false);
#line 72 "C:\Sonic\WebApplication1\Views\Home\Index.cshtml"
               Write(Html.TextBoxFor(s => s.RestockNumber, new { @class = "form-control", style = "width:15%;display:inline-block", @type = "number", @min = "0", step = ".01" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(3613, 160, true);
                    WriteLiteral("\r\n                    <input type=\"submit\" name=\"submit\" class=\"btn btn-primary\" value=\"Complete Restock\" style=\"text-align:center\" />\r\n                </div>\r\n");
                    EndContext();
#line 75 "C:\Sonic\WebApplication1\Views\Home\Index.cshtml"
            }

#line default
#line hidden
                    BeginContext(3788, 83, true);
                    WriteLiteral("\r\n\r\n            <div>\r\n                <label style=\"color:green;margin-left:16px\">");
                    EndContext();
                    BeginContext(3872, 82, false);
#line 79 "C:\Sonic\WebApplication1\Views\Home\Index.cshtml"
                                                       Write(Html.DisplayFor(item => item.RefundMessage, null, new { @class = "form-control" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(3954, 125, true);
                    WriteLiteral("</label>               \r\n            </div>\r\n\r\n            <div >\r\n                <label style=\"color:red;margin-left:16px\">");
                    EndContext();
                    BeginContext(4080, 81, false);
#line 83 "C:\Sonic\WebApplication1\Views\Home\Index.cshtml"
                                                     Write(Html.DisplayFor(item => item.ErrorMessage, null, new { @class = "form-control" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(4161, 394, true);
                    WriteLiteral(@"</label>
            </div>
        </div>
        <div class=""col-xs-7 col-sm-3"" >
            <div class=""panel panel-default"">
                <div class=""panel-heading"">

                    Current Stock
                </div>

                <div style=""padding: 10px 15px;"">
                    <div>
                        Total Cans Left:
                        <label>");
                    EndContext();
                    BeginContext(4556, 82, false);
#line 96 "C:\Sonic\WebApplication1\Views\Home\Index.cshtml"
                          Write(Html.DisplayFor(item => item.TotalCansLeft, null, new { @class = "form-control" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(4638, 138, true);
                    WriteLiteral("</label>\r\n                    </div>\r\n                    <div>\r\n                        Total Cans Sold:\r\n                        <label>");
                    EndContext();
                    BeginContext(4777, 82, false);
#line 100 "C:\Sonic\WebApplication1\Views\Home\Index.cshtml"
                          Write(Html.DisplayFor(item => item.TotalCansSold, null, new { @class = "form-control" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(4859, 143, true);
                    WriteLiteral("</label>\r\n                    </div>\r\n                    <div>\r\n                        Total Cash Collected:\r\n                        <label>");
                    EndContext();
                    BeginContext(5003, 87, false);
#line 104 "C:\Sonic\WebApplication1\Views\Home\Index.cshtml"
                          Write(Html.DisplayFor(item => item.TotalCashCollected, null, new { @class = "form-control" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(5090, 145, true);
                    WriteLiteral("</label>\r\n                    </div>\r\n                    <div>\r\n                        Total Credit Collected:\r\n                        <label>");
                    EndContext();
                    BeginContext(5236, 89, false);
#line 108 "C:\Sonic\WebApplication1\Views\Home\Index.cshtml"
                          Write(Html.DisplayFor(item => item.TotalCreditCollected, null, new { @class = "form-control" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(5325, 115, true);
                    WriteLiteral("</label>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n           \r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5447, 10, true);
                WriteLiteral("        \r\n");
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
            BeginContext(5464, 13, true);
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VendingMachineViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
