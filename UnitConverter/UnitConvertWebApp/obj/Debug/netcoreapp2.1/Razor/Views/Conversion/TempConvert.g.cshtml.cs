#pragma checksum "/Users/johncunningham/Projects/git/CIDM3312/UnitConverter/UnitConvertWebApp/Views/Conversion/TempConvert.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "652df27cbbbe38c67bed231ad2457e882bd97ea2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Conversion_TempConvert), @"mvc.1.0.view", @"/Views/Conversion/TempConvert.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Conversion/TempConvert.cshtml", typeof(AspNetCore.Views_Conversion_TempConvert))]
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
#line 1 "/Users/johncunningham/Projects/git/CIDM3312/UnitConverter/UnitConvertWebApp/Views/_ViewImports.cshtml"
using UnitConvertWebApp;

#line default
#line hidden
#line 2 "/Users/johncunningham/Projects/git/CIDM3312/UnitConverter/UnitConvertWebApp/Views/_ViewImports.cshtml"
using UnitConvertWebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"652df27cbbbe38c67bed231ad2457e882bd97ea2", @"/Views/Conversion/TempConvert.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86c435ddf5a048f58cd218a26e1187c423999a76", @"/Views/_ViewImports.cshtml")]
    public class Views_Conversion_TempConvert : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/johncunningham/Projects/git/CIDM3312/UnitConverter/UnitConvertWebApp/Views/Conversion/TempConvert.cshtml"
  
    ViewData["Title"] = "Temperature Converter Home Page";

#line default
#line hidden
            BeginContext(64, 5, true);
            WriteLiteral("\n<h2>");
            EndContext();
            BeginContext(70, 17, false);
#line 5 "/Users/johncunningham/Projects/git/CIDM3312/UnitConverter/UnitConvertWebApp/Views/Conversion/TempConvert.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(87, 378, true);
            WriteLiteral(@"</h2>

<div id=""container"">
<table class=""table table-striped"">
    <th class=""tableHeader"">
        <td>Celsius to Fahrenheit</td>
        <td>Fahrenheit to Celsius</td>
        <td>Celsius to Kelvin</td>
        <td>Kelvin to Celsius</td>
        <td>Fahrenheit to Kelvin</td>
        <td>Kelvin to Fahrenheit</td>
    </th>
        <tr>
            <td></td>
            <td>");
            EndContext();
            BeginContext(466, 20, false);
#line 19 "/Users/johncunningham/Projects/git/CIDM3312/UnitConverter/UnitConvertWebApp/Views/Conversion/TempConvert.cshtml"
           Write(ViewData["NumInput"]);

#line default
#line hidden
            EndContext();
            BeginContext(486, 6, true);
            WriteLiteral(" C to ");
            EndContext();
            BeginContext(493, 16, false);
#line 19 "/Users/johncunningham/Projects/git/CIDM3312/UnitConverter/UnitConvertWebApp/Views/Conversion/TempConvert.cshtml"
                                      Write(ViewData["CtoF"]);

#line default
#line hidden
            EndContext();
            BeginContext(509, 24, true);
            WriteLiteral(" F</td>\n            <td>");
            EndContext();
            BeginContext(534, 20, false);
#line 20 "/Users/johncunningham/Projects/git/CIDM3312/UnitConverter/UnitConvertWebApp/Views/Conversion/TempConvert.cshtml"
           Write(ViewData["NumInput"]);

#line default
#line hidden
            EndContext();
            BeginContext(554, 6, true);
            WriteLiteral(" F to ");
            EndContext();
            BeginContext(561, 16, false);
#line 20 "/Users/johncunningham/Projects/git/CIDM3312/UnitConverter/UnitConvertWebApp/Views/Conversion/TempConvert.cshtml"
                                      Write(ViewData["FtoC"]);

#line default
#line hidden
            EndContext();
            BeginContext(577, 24, true);
            WriteLiteral(" C</td>\n            <td>");
            EndContext();
            BeginContext(602, 20, false);
#line 21 "/Users/johncunningham/Projects/git/CIDM3312/UnitConverter/UnitConvertWebApp/Views/Conversion/TempConvert.cshtml"
           Write(ViewData["NumInput"]);

#line default
#line hidden
            EndContext();
            BeginContext(622, 6, true);
            WriteLiteral(" C to ");
            EndContext();
            BeginContext(629, 16, false);
#line 21 "/Users/johncunningham/Projects/git/CIDM3312/UnitConverter/UnitConvertWebApp/Views/Conversion/TempConvert.cshtml"
                                      Write(ViewData["CtoK"]);

#line default
#line hidden
            EndContext();
            BeginContext(645, 24, true);
            WriteLiteral(" K</td>\n            <td>");
            EndContext();
            BeginContext(670, 20, false);
#line 22 "/Users/johncunningham/Projects/git/CIDM3312/UnitConverter/UnitConvertWebApp/Views/Conversion/TempConvert.cshtml"
           Write(ViewData["NumInput"]);

#line default
#line hidden
            EndContext();
            BeginContext(690, 6, true);
            WriteLiteral(" K to ");
            EndContext();
            BeginContext(697, 16, false);
#line 22 "/Users/johncunningham/Projects/git/CIDM3312/UnitConverter/UnitConvertWebApp/Views/Conversion/TempConvert.cshtml"
                                      Write(ViewData["KtoC"]);

#line default
#line hidden
            EndContext();
            BeginContext(713, 24, true);
            WriteLiteral(" C</td>\n            <td>");
            EndContext();
            BeginContext(738, 20, false);
#line 23 "/Users/johncunningham/Projects/git/CIDM3312/UnitConverter/UnitConvertWebApp/Views/Conversion/TempConvert.cshtml"
           Write(ViewData["NumInput"]);

#line default
#line hidden
            EndContext();
            BeginContext(758, 6, true);
            WriteLiteral(" F to ");
            EndContext();
            BeginContext(765, 16, false);
#line 23 "/Users/johncunningham/Projects/git/CIDM3312/UnitConverter/UnitConvertWebApp/Views/Conversion/TempConvert.cshtml"
                                      Write(ViewData["FtoK"]);

#line default
#line hidden
            EndContext();
            BeginContext(781, 24, true);
            WriteLiteral(" K</td>\n            <td>");
            EndContext();
            BeginContext(806, 20, false);
#line 24 "/Users/johncunningham/Projects/git/CIDM3312/UnitConverter/UnitConvertWebApp/Views/Conversion/TempConvert.cshtml"
           Write(ViewData["NumInput"]);

#line default
#line hidden
            EndContext();
            BeginContext(826, 6, true);
            WriteLiteral(" K to ");
            EndContext();
            BeginContext(833, 16, false);
#line 24 "/Users/johncunningham/Projects/git/CIDM3312/UnitConverter/UnitConvertWebApp/Views/Conversion/TempConvert.cshtml"
                                      Write(ViewData["KtoF"]);

#line default
#line hidden
            EndContext();
            BeginContext(849, 41, true);
            WriteLiteral(" F</td>\n        </tr>    \n</table>\n</div>");
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
