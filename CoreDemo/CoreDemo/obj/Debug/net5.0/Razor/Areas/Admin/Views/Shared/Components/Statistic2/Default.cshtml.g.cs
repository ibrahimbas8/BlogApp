#pragma checksum "C:\Users\basib\OneDrive\Masaüstü\kodlama\MuratYucedagASP\CoreDemo\CoreDemo\Areas\Admin\Views\Shared\Components\Statistic2\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "126a0729ed03c535586c0e746b67cb4f27c2096b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_Components_Statistic2_Default), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Components/Statistic2/Default.cshtml")]
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
#line 1 "C:\Users\basib\OneDrive\Masaüstü\kodlama\MuratYucedagASP\CoreDemo\CoreDemo\Areas\Admin\Views\_ViewImports.cshtml"
using CoreDemo.Areas.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\basib\OneDrive\Masaüstü\kodlama\MuratYucedagASP\CoreDemo\CoreDemo\Areas\Admin\Views\_ViewImports.cshtml"
using CoreDemo.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"126a0729ed03c535586c0e746b67cb4f27c2096b", @"/Areas/Admin/Views/Shared/Components/Statistic2/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b881055197282d0a2ab51004156381e82f1e1fbc", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Shared_Components_Statistic2_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row"">
    <div class=""col-lg-4"">
        <div class=""widget navy-bg no-padding"">
            <div class=""p-m"">
                <h1 class=""m-xs"">Dashboard</h1>
                <h3 class=""font-bold no-margins"">
                    ASP .NET CORE 5
                </h3>
                <small>Admin İşlemleri Burada gerçekleşir. lorem ipsum.......................</small>
            </div>
            <div class=""flot-chart"">
                <div class=""flot-chart-content"" id=""flot-chart1""></div>
            </div>
        </div>
    </div>
    <div class=""col-lg-4"">
        <div class=""widget lazur-bg no-padding"">
            <div class=""p-m"">
                <h1 class=""m-xs"">Son Blok</h1>

                <h3 class=""font-bold no-margins"">
                    ");
#nullable restore
#line 22 "C:\Users\basib\OneDrive\Masaüstü\kodlama\MuratYucedagASP\CoreDemo\CoreDemo\Areas\Admin\Views\Shared\Components\Statistic2\Default.cshtml"
               Write(ViewBag.v1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h3>\r\n                <small>");
#nullable restore
#line 24 "C:\Users\basib\OneDrive\Masaüstü\kodlama\MuratYucedagASP\CoreDemo\CoreDemo\Areas\Admin\Views\Shared\Components\Statistic2\Default.cshtml"
                  Write(ViewBag.v2.Substring(0, 50));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"... </small>
            </div>
            <div class=""flot-chart"">
                <div class=""flot-chart-content"" id=""flot-chart2""></div>
            </div>
        </div>
    </div>
    <div class=""col-lg-4"">
        <div class=""widget yellw-bg no-padding"">
            <div class=""p-m"">
                <h1 class=""m-xs"">₺ 2574</h1>

                <h3 class=""font-bold no-margins"">
                    Blog Site Kazancı
                </h3>
                <small>Not Satışı, özel ders</small>
            </div>
            <div class=""flot-chart"">
                <div class=""flot-chart-content"" id=""flot-chart3""></div>
            </div>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
