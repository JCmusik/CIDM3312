#pragma checksum "/Users/johncunningham/Projects/git/CIDM3312/inClass/MyWebCalculator/Views/Calculator/Floor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "699cbe6ee07b5d0d97ef4fe6474225a8e4a04f5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calculator_Floor), @"mvc.1.0.view", @"/Views/Calculator/Floor.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Calculator/Floor.cshtml", typeof(AspNetCore.Views_Calculator_Floor))]
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
#line 1 "/Users/johncunningham/Projects/git/CIDM3312/inClass/MyWebCalculator/Views/_ViewImports.cshtml"
using MyWebCalculator;

#line default
#line hidden
#line 2 "/Users/johncunningham/Projects/git/CIDM3312/inClass/MyWebCalculator/Views/_ViewImports.cshtml"
using MyWebCalculator.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"699cbe6ee07b5d0d97ef4fe6474225a8e4a04f5f", @"/Views/Calculator/Floor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"723c93cf8501ee692a6dcd53c1cb5152db45382f", @"/Views/_ViewImports.cshtml")]
    public class Views_Calculator_Floor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/johncunningham/Projects/git/CIDM3312/inClass/MyWebCalculator/Views/Calculator/Floor.cshtml"
  
    ViewData["Title"] = "Floor";

#line default
#line hidden
            BeginContext(38, 5, true);
            WriteLiteral("\n<h1>");
            EndContext();
            BeginContext(44, 17, false);
#line 5 "/Users/johncunningham/Projects/git/CIDM3312/inClass/MyWebCalculator/Views/Calculator/Floor.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(61, 71, true);
            WriteLiteral("</h1>\n<h3>Floor of query string numbers</h3>\n<ul>\n    <li>Number 1: <b>");
            EndContext();
            BeginContext(133, 16, false);
#line 8 "/Users/johncunningham/Projects/git/CIDM3312/inClass/MyWebCalculator/Views/Calculator/Floor.cshtml"
                Write(ViewData["num1"]);

#line default
#line hidden
            EndContext();
            BeginContext(149, 29, true);
            WriteLiteral("</b></li>\n    <li>Result: <b>");
            EndContext();
            BeginContext(179, 18, false);
#line 9 "/Users/johncunningham/Projects/git/CIDM3312/inClass/MyWebCalculator/Views/Calculator/Floor.cshtml"
              Write(ViewData["result"]);

#line default
#line hidden
            EndContext();
            BeginContext(197, 15, true);
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
