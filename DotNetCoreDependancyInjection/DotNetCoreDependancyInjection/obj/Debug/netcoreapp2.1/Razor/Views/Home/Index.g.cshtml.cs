#pragma checksum "C:\Users\dvinu\source\repos\DotNetCoreDependancyInjection\DotNetCoreDependancyInjection\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1576349522118c62a15d17daa281d4c5f7d60830"
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
#line 1 "C:\Users\dvinu\source\repos\DotNetCoreDependancyInjection\DotNetCoreDependancyInjection\Views\_ViewImports.cshtml"
using DotNetCoreDependancyInjection;

#line default
#line hidden
#line 2 "C:\Users\dvinu\source\repos\DotNetCoreDependancyInjection\DotNetCoreDependancyInjection\Views\_ViewImports.cshtml"
using DotNetCoreDependancyInjection.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1576349522118c62a15d17daa281d4c5f7d60830", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f308c4c89d16445cfa369056a6995c1011fe12d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Mstudent>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\dvinu\source\repos\DotNetCoreDependancyInjection\DotNetCoreDependancyInjection\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(75, 164, true);
            WriteLiteral("<div class=\"=container\">\r\n    <table class=\"table table-striped\">\r\n        <thead>\r\n        <th>Name</th>\r\n        <th>Age</th>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 12 "C:\Users\dvinu\source\repos\DotNetCoreDependancyInjection\DotNetCoreDependancyInjection\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(296, 48, true);
            WriteLiteral("                <tr>\r\n                    <td>  ");
            EndContext();
            BeginContext(345, 9, false);
#line 15 "C:\Users\dvinu\source\repos\DotNetCoreDependancyInjection\DotNetCoreDependancyInjection\Views\Home\Index.cshtml"
                     Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(354, 34, true);
            WriteLiteral(" </td>\r\n                    <td>  ");
            EndContext();
            BeginContext(389, 8, false);
#line 16 "C:\Users\dvinu\source\repos\DotNetCoreDependancyInjection\DotNetCoreDependancyInjection\Views\Home\Index.cshtml"
                     Write(item.Age);

#line default
#line hidden
            EndContext();
            BeginContext(397, 31, true);
            WriteLiteral(" </td>\r\n                </tr>\r\n");
            EndContext();
#line 18 "C:\Users\dvinu\source\repos\DotNetCoreDependancyInjection\DotNetCoreDependancyInjection\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(443, 46, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Mstudent>> Html { get; private set; }
    }
}
#pragma warning restore 1591
