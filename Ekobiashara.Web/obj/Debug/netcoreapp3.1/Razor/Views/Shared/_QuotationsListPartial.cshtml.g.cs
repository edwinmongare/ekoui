#pragma checksum "C:\Users\edwin\OneDrive\Desktop\retailEko\Ekobiashara.Web\Views\Shared\_QuotationsListPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae8e9367b98ee04437b493b6fa882bbe25deccae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__QuotationsListPartial), @"mvc.1.0.view", @"/Views/Shared/_QuotationsListPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae8e9367b98ee04437b493b6fa882bbe25deccae", @"/Views/Shared/_QuotationsListPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d9ee96ec737b124cd5fed608e952101a73eac15", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__QuotationsListPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QuotationsListModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-xl-12 col-lg-12 col-sm-12 col-md-12 "">


            <div class="" br-6"">
                <div class=""table-responsive"">
                    <table id=""html5-extension3"" class=""table multi-table  table-striped"" style=""width:100%"">
                        <thead>
                            <tr>
                                <th>Quotation Date</th>
                                <th>Customer</th>
                                <th>Amount</th>
                                <th>Quotes</th>
                                <th>Timestamp</th>
                                <th>Action</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>Quotation Date</td>
                                <td>Customer</td>
                                <td>Amount</td>
                                <td>Quote");
            WriteLiteral(@"s</td>
                                <td>Timestamp</td>
                                <td>
                                    <button type=""button"" class=""btn btn-info position-relative mt-3 mb-3 ml-2"">
                                        <span>Convert To Sales</span>
                                        
                                    </button>
                                </td>


                            </tr>





                        </tbody>
                    </table>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuotationsListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
