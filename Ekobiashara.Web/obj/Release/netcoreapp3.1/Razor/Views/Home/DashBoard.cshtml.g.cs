#pragma checksum "C:\Users\LLANOH\source\repos\EKO BIASHARA\RetailUI\Ekobiashara.Web\Views\Home\DashBoard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "756a637f86f33588f0205d9fd1af4d227b3ee1df"
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
#line 1 "C:\Users\LLANOH\source\repos\EKO BIASHARA\RetailUI\Ekobiashara.Web\Views\_ViewImports.cshtml"
using Ekobiashara.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LLANOH\source\repos\EKO BIASHARA\RetailUI\Ekobiashara.Web\Views\_ViewImports.cshtml"
using Ekobiashara.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"756a637f86f33588f0205d9fd1af4d227b3ee1df", @"/Views/Home/DashBoard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d9ee96ec737b124cd5fed608e952101a73eac15", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DashBoard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\LLANOH\source\repos\EKO BIASHARA\RetailUI\Ekobiashara.Web\Views\Home\DashBoard.cshtml"
  
    ViewData["Title"] = "Eko Biashara|Business Information";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n<div class=\" col-lg-12  col-sm-12 col-12 layout-spacing\">\n\n    <div class=\"widget widget-account-invoice-one\">\n\n        <div class=\"widget-heading\">\n            <h5");
            BeginWriteAttribute("class", " class=\"", 279, "\"", 287, 0);
            EndWriteAttribute();
            WriteLiteral(@">Account Info</h5>
        </div>

        <div class=""widget-content"">
            <div class=""invoice-box"">

                <div class=""acc-total-info"">
                    <h5>Total Balance</h5>
                    <p class=""acc-amount"">Kshs 47,000</p>
                </div>

                <div class=""inv-detail"">
                    <div class=""info-detail-1"">
                        <p>Today's Earnings</p>
                        <p>Kshs 11,000</p>
                    </div>
                    <div class=""info-detail-2"">
                        <p>Taxes Paid</p>
                        <p>Kshs 170.82</p>
                    </div>
                    <div class=""info-detail-3 info-sub"">
                        <div class=""info-detail"">
                            <p>Discounts Given</p>
                            <p>Kshs 300</p>
                        </div>
                       
                    </div>
                </div>

                <div class=""inv-action"">
                   
       ");
            WriteLiteral("             <a");
            BeginWriteAttribute("href", " href=\"", 1327, "\"", 1334, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">View Account</a>\n                </div>\n            </div>\n        </div>\n\n    </div>\n</div>\n");
            WriteLiteral("\n<div class=\"col-xl-6 col-lg-12 col-md-12 col-sm-12 col-12 layout-spacing\">\n    <div class=\"widget widget-table-two\">\n\n        <div class=\"widget-heading\">\n            <h5");
            BeginWriteAttribute("class", " class=\"", 1714, "\"", 1722, 0);
            EndWriteAttribute();
            WriteLiteral(@">Recent Orders</h5>
        </div>

        <div class=""widget-content"">
            <div class=""table-responsive"">
                <table class=""table table-striped "">
                    <thead>
                        <tr>
                            <th><div class=""th-content"">Customer</div></th>
                            <th><div class=""th-content"">Product</div></th>
                            <th><div class=""th-content"">Invoice</div></th>
                            <th><div class=""th-content th-heading"">Price</div></th>
                            <th><div class=""th-content"">Status</div></th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td><div class=""td-content customer-name"">Edwin Mong'are</div></td>
                            <td><div class=""td-content product-brand"">stationery</div></td>
                            <td><div class=""td-content"">#76894</div></td>
                            <td");
            WriteLiteral("><div class=\"td-content pricing\"><span");
            BeginWriteAttribute("class", " class=\"", 2785, "\"", 2793, 0);
            EndWriteAttribute();
            WriteLiteral(@">Kshs 881.00</span></div></td>
                            <td><div class=""td-content""><span class=""badge outline-badge-primary"">Shipped</span></div></td>
                        </tr>
                        <tr>
                            <td><div class=""td-content customer-name"">Edwin Mong'are</div></td>
                            <td><div class=""td-content product-brand"">stationery</div></td>
                            <td><div class=""td-content"">#76894</div></td>
                            <td><div class=""td-content pricing""><span");
            BeginWriteAttribute("class", " class=\"", 3346, "\"", 3354, 0);
            EndWriteAttribute();
            WriteLiteral(@">Kshs 881.00</span></div></td>
                            <td><div class=""td-content""><span class=""badge outline-badge-primary"">Shipped</span></div></td>
                        </tr>
                        <tr>
                            <td><div class=""td-content customer-name"">Edwin Mong'are</div></td>
                            <td><div class=""td-content product-brand"">stationery</div></td>
                            <td><div class=""td-content"">#76894</div></td>
                            <td><div class=""td-content pricing""><span");
            BeginWriteAttribute("class", " class=\"", 3907, "\"", 3915, 0);
            EndWriteAttribute();
            WriteLiteral(@">Kshs 881.00</span></div></td>
                            <td><div class=""td-content""><span class=""badge outline-badge-primary"">Shipped</span></div></td>
                        </tr>

                    </tbody>
                </table>
            </div>
        </div>
    </div>
</div>

<div class=""col-xl-6 col-lg-12 col-md-12 col-sm-12 col-12 layout-spacing"">
    <div class=""widget widget-table-two"">

        <div class=""widget-heading"">
            <h5");
            BeginWriteAttribute("class", " class=\"", 4387, "\"", 4395, 0);
            EndWriteAttribute();
            WriteLiteral(@">Top Selling Products</h5>
        </div>

        <div class=""widget-content"">
            <div class=""table-responsive"">
                <table class=""table table-striped "">
                    <thead>
                        <tr>
                            <th><div class=""th-content"">Customer</div></th>
                            <th><div class=""th-content"">Product</div></th>
                            <th><div class=""th-content"">Invoice</div></th>
                            <th><div class=""th-content th-heading"">Price</div></th>
                            <th><div class=""th-content"">Status</div></th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td><div class=""td-content customer-name"">Edwin Mong'are</div></td>
                            <td><div class=""td-content product-brand"">stationery</div></td>
                            <td><div class=""td-content"">#76894</div></td>
         ");
            WriteLiteral("                   <td><div class=\"td-content pricing\"><span");
            BeginWriteAttribute("class", " class=\"", 5480, "\"", 5488, 0);
            EndWriteAttribute();
            WriteLiteral(@">Kshs 881.00</span></div></td>
                            <td><div class=""td-content""><span class=""badge outline-badge-primary"">Shipped</span></div></td>
                        </tr>
                        <tr>
                            <td><div class=""td-content customer-name"">Edwin Mong'are</div></td>
                            <td><div class=""td-content product-brand"">stationery</div></td>
                            <td><div class=""td-content"">#76894</div></td>
                            <td><div class=""td-content pricing""><span");
            BeginWriteAttribute("class", " class=\"", 6041, "\"", 6049, 0);
            EndWriteAttribute();
            WriteLiteral(@">Kshs 881.00</span></div></td>
                            <td><div class=""td-content""><span class=""badge outline-badge-primary"">Shipped</span></div></td>
                        </tr>
                        <tr>
                            <td><div class=""td-content customer-name"">Edwin Mong'are</div></td>
                            <td><div class=""td-content product-brand"">stationery</div></td>
                            <td><div class=""td-content"">#76894</div></td>
                            <td><div class=""td-content pricing""><span");
            BeginWriteAttribute("class", " class=\"", 6602, "\"", 6610, 0);
            EndWriteAttribute();
            WriteLiteral(@">Kshs 881.00</span></div></td>
                            <td><div class=""td-content""><span class=""badge outline-badge-primary"">Shipped</span></div></td>
                        </tr>

                    </tbody>
                </table>
            </div>
        </div>
    </div>
</div>

");
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
