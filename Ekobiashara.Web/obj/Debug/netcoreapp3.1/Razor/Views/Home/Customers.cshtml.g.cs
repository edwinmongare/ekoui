#pragma checksum "C:\Users\edwin\OneDrive\Desktop\retailEko\Ekobiashara.Web\Views\Home\Customers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbed1f9cab4fc5d636e7b6dff5aae09d619595be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Customers), @"mvc.1.0.view", @"/Views/Home/Customers.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbed1f9cab4fc5d636e7b6dff5aae09d619595be", @"/Views/Home/Customers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d9ee96ec737b124cd5fed608e952101a73eac15", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Customers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\edwin\OneDrive\Desktop\retailEko\Ekobiashara.Web\Views\Home\Customers.cshtml"
  
    ViewData["Title"] = "Eko Biashara|Business Information";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-12 col-12 layout-spacing"">
    <div class=""statbox widget box box-shadow"">


        <div class="" animated-underline-content"">

            <ul class=""nav nav-tabs  mb-3"" id=""animateLine"" role=""tablist"">
                <li class=""nav-item"">
                    <a class=""nav-link active"" id=""animated-underline-home-tab"" data-toggle=""tab"" href=""#animated-underline-home"" role=""tab"" aria-controls=""animated-underline-home"" aria-selected=""true"">
                        Customers
                    </a>
                </li>
            </ul>

            <div class=""tab-content"" id=""animateLineContent-4"">
                <div class=""tab-pane fade show active"" id=""animated-underline-home"" role=""tabpanel"" aria-labelledby=""animated-underline-home-tab"">
");
#nullable restore
#line 22 "C:\Users\edwin\OneDrive\Desktop\retailEko\Ekobiashara.Web\Views\Home\Customers.cshtml"
                      
                        await Html.RenderPartialAsync("_CustomersPartial");
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\n\n            </div>\n\n\n        </div>\n    </div>\n</div>");
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
