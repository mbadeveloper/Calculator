#pragma checksum "d:\temp\Calculator\Calculator\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd9b2f59336ab827555c65c9f073c0b82a1796a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Calculator.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace Calculator.Pages
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
#line 1 "d:\temp\Calculator\Calculator\Pages\_ViewImports.cshtml"
using Calculator;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd9b2f59336ab827555c65c9f073c0b82a1796a9", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f191437622a930a1015e033b643d8fb4f5a3242", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "d:\temp\Calculator\Calculator\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Calculator</h1>
    <table>
        <tr>
            <td colspan=""4"">
                <input type=""text""/>
            </td>
        </tr>
        <tr>
            <td>
                <input type=""button"" value=""7"" />
            </td>
            <td>
                <input type=""button"" value=""8"" />
            </td>
            <td>
                <input type=""button"" value=""9"" />
            </td>
            <td>
                <input type=""button"" value=""+"" />
            </td>
        </tr>
        <tr>
            <td>
                <input type=""button"" value=""4"" />
            </td>
            <td>
                <input type=""button"" value=""5"" />
            </td>
            <td>
                <input type=""button"" value=""6"" />
            </td>
            <td>
                <input type=""button"" value=""-"" />
            </td>
        </tr>
        <tr>
            <td>
                <input type=""");
            WriteLiteral(@"button"" value=""1"" />
            </td>
            <td>
                <input type=""button"" value=""2"" />
            </td>
            <td>
                <input type=""button"" value=""3"" />
            </td>
            <td>
                <input type=""button"" value=""x"" />
            </td>
        </tr>
        <tr>
            <td>
                <input type=""button"" value=""="" />
            </td>
        </tr>
        <tr>

        </tr>
    </table>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
