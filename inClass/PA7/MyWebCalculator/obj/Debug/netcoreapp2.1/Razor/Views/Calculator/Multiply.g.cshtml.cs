#pragma checksum "/Users/johncunningham/Projects/git/CIDM3312/inClass/PA7/MyWebCalculator/Views/Calculator/Multiply.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ea9b350b6b0df9a6188fe5adf16bb318c16bd11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calculator_Multiply), @"mvc.1.0.view", @"/Views/Calculator/Multiply.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Calculator/Multiply.cshtml", typeof(AspNetCore.Views_Calculator_Multiply))]
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
#line 1 "/Users/johncunningham/Projects/git/CIDM3312/inClass/PA7/MyWebCalculator/Views/_ViewImports.cshtml"
using MyWebCalculator;

#line default
#line hidden
#line 2 "/Users/johncunningham/Projects/git/CIDM3312/inClass/PA7/MyWebCalculator/Views/_ViewImports.cshtml"
using MyWebCalculator.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ea9b350b6b0df9a6188fe5adf16bb318c16bd11", @"/Views/Calculator/Multiply.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"723c93cf8501ee692a6dcd53c1cb5152db45382f", @"/Views/_ViewImports.cshtml")]
    public class Views_Calculator_Multiply : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/johncunningham/Projects/git/CIDM3312/inClass/PA7/MyWebCalculator/Views/Calculator/Multiply.cshtml"
  
    ViewData["Title"] = "Multiply";

#line default
#line hidden
            BeginContext(41, 5, true);
            WriteLiteral("\n<h1>");
            EndContext();
            BeginContext(47, 17, false);
#line 5 "/Users/johncunningham/Projects/git/CIDM3312/inClass/PA7/MyWebCalculator/Views/Calculator/Multiply.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(64, 71, true);
            WriteLiteral("</h1>\n<h3>Multiply query string numbers</h3>\n<ul>\n    <li>Number 1: <b>");
            EndContext();
            BeginContext(136, 16, false);
#line 8 "/Users/johncunningham/Projects/git/CIDM3312/inClass/PA7/MyWebCalculator/Views/Calculator/Multiply.cshtml"
                Write(ViewData["num1"]);

#line default
#line hidden
            EndContext();
            BeginContext(152, 31, true);
            WriteLiteral("</b></li>\n    <li>Number 2: <b>");
            EndContext();
            BeginContext(184, 16, false);
#line 9 "/Users/johncunningham/Projects/git/CIDM3312/inClass/PA7/MyWebCalculator/Views/Calculator/Multiply.cshtml"
                Write(ViewData["num2"]);

#line default
#line hidden
            EndContext();
            BeginContext(200, 29, true);
            WriteLiteral("</b></li>\n    <li>Result: <b>");
            EndContext();
            BeginContext(230, 18, false);
#line 10 "/Users/johncunningham/Projects/git/CIDM3312/inClass/PA7/MyWebCalculator/Views/Calculator/Multiply.cshtml"
              Write(ViewData["result"]);

#line default
#line hidden
            EndContext();
            BeginContext(248, 15, true);
            WriteLiteral("</b></li>\n</ul>");
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
