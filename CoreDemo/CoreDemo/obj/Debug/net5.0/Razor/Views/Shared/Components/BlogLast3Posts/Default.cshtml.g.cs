#pragma checksum "C:\Users\basib\OneDrive\Masaüstü\kodlama\MuratYucedagASP\CoreDemo\CoreDemo\Views\Shared\Components\BlogLast3Posts\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "651d01bdf3dfdb282f2ddd6a62983ba49c4553cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BlogLast3Posts_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BlogLast3Posts/Default.cshtml")]
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
#line 1 "C:\Users\basib\OneDrive\Masaüstü\kodlama\MuratYucedagASP\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\basib\OneDrive\Masaüstü\kodlama\MuratYucedagASP\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\basib\OneDrive\Masaüstü\kodlama\MuratYucedagASP\CoreDemo\CoreDemo\Views\Shared\Components\BlogLast3Posts\Default.cshtml"
using Entity.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"651d01bdf3dfdb282f2ddd6a62983ba49c4553cd", @"/Views/Shared/Components/BlogLast3Posts/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_BlogLast3Posts_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"tech-btm\">\r\n    <h3>Son Gönderiler</h3>\r\n");
#nullable restore
#line 5 "C:\Users\basib\OneDrive\Masaüstü\kodlama\MuratYucedagASP\CoreDemo\CoreDemo\Views\Shared\Components\BlogLast3Posts\Default.cshtml"
     foreach (var item in Model)
     {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"blog-grids row mb-3\">\r\n            <div class=\"col-md-5 blog-grid-left\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 250, "\"", 287, 2);
            WriteAttributeValue("", 257, "/Blog/BlogReadAll/", 257, 18, true);
#nullable restore
#line 9 "C:\Users\basib\OneDrive\Masaüstü\kodlama\MuratYucedagASP\CoreDemo\CoreDemo\Views\Shared\Components\BlogLast3Posts\Default.cshtml"
WriteAttributeValue("", 275, item.BlogID, 275, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 315, "\"", 336, 1);
#nullable restore
#line 10 "C:\Users\basib\OneDrive\Masaüstü\kodlama\MuratYucedagASP\CoreDemo\CoreDemo\Views\Shared\Components\BlogLast3Posts\Default.cshtml"
WriteAttributeValue("", 321, item.BlogImage, 321, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 368, "\"", 374, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </a>\r\n            </div>\r\n\r\n            <div class=\"col-md-7 blog-grid-right\">\r\n\r\n                <h5>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 520, "\"", 557, 2);
            WriteAttributeValue("", 527, "/Blog/BlogReadAll/", 527, 18, true);
#nullable restore
#line 17 "C:\Users\basib\OneDrive\Masaüstü\kodlama\MuratYucedagASP\CoreDemo\CoreDemo\Views\Shared\Components\BlogLast3Posts\Default.cshtml"
WriteAttributeValue("", 545, item.BlogID, 545, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 17 "C:\Users\basib\OneDrive\Masaüstü\kodlama\MuratYucedagASP\CoreDemo\CoreDemo\Views\Shared\Components\BlogLast3Posts\Default.cshtml"
                                                        Write(item.BlogContent.Substring(0, item.BlogContent.Substring(0, 70).LastIndexOf(" ")));

#line default
#line hidden
#nullable disable
            WriteLiteral("...</a>\r\n                </h5>\r\n                <div class=\"sub-meta\">\r\n                    <span>\r\n                        <i class=\"far fa-clock\"></i> ");
#nullable restore
#line 21 "C:\Users\basib\OneDrive\Masaüstü\kodlama\MuratYucedagASP\CoreDemo\CoreDemo\Views\Shared\Components\BlogLast3Posts\Default.cshtml"
                                                 Write(((DateTime)item.BlogCreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </span>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n");
#nullable restore
#line 27 "C:\Users\basib\OneDrive\Masaüstü\kodlama\MuratYucedagASP\CoreDemo\CoreDemo\Views\Shared\Components\BlogLast3Posts\Default.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
