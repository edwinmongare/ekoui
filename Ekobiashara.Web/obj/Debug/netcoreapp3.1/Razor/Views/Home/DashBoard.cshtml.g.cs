#pragma checksum "C:\Users\edwin\OneDrive\Desktop\retailEko\Ekobiashara.Web\Views\Home\DashBoard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a929fd2836d05079b26cb72d32dec7ba42c471aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DashBoard), @"mvc.1.0.view", @"/Views/Home/DashBoard.cshtml")]
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
#nullable restore
#line 1 "C:\Users\edwin\OneDrive\Desktop\retailEko\Ekobiashara.Web\Views\_ViewImports.cshtml"
using Ekobiashara.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\edwin\OneDrive\Desktop\retailEko\Ekobiashara.Web\Views\_ViewImports.cshtml"
using Ekobiashara.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a929fd2836d05079b26cb72d32dec7ba42c471aa", @"/Views/Home/DashBoard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d9ee96ec737b124cd5fed608e952101a73eac15", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DashBoard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\edwin\OneDrive\Desktop\retailEko\Ekobiashara.Web\Views\Home\DashBoard.cshtml"
  
    ViewData["Title"] = "Eko Biashara|Business Information";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n");
            WriteLiteral("\n\n   \n  \n    <div class=\"col-xl-8 col-lg-12 col-md-12 col-sm-12 col-12 layout-spacing\">\r\n\r\n        <div class=\"widget widget-chart-one\">\r\n            <div class=\"widget-heading\">\r\n                <h5");
            BeginWriteAttribute("class", " class=\"", 6956, "\"", 6964, 0);
            EndWriteAttribute();
            WriteLiteral(@">Profit</h5>
                <ul class=""tabs tab-pills"">
                    <li><a href=""javascript:void(0);"" id=""tb_1"" class=""tabmenu"">Monthly</a></li>
                </ul>
            </div>

            <div class=""widget-content"">
                <div class=""tabs tab-content"">
                    <div id=""content_1"" class=""tabcontent"">
                        <div id=""revenueMonthly""></div>
                    </div>
                </div>
            </div>
        </div>
        
    </div>");
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
