#pragma checksum "C:\Users\basib\OneDrive\Masaüstü\kodlama\MuratYucedagASP\CoreDemo\CoreDemo\Areas\Admin\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37925804c6e05a99ba81ed30efadc8eee8f475eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\basib\OneDrive\Masaüstü\kodlama\MuratYucedagASP\CoreDemo\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\basib\OneDrive\Masaüstü\kodlama\MuratYucedagASP\CoreDemo\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37925804c6e05a99ba81ed30efadc8eee8f475eb", @"/Areas/Admin/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b881055197282d0a2ab51004156381e82f1e1fbc", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<Entity.Concrete.Category>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\basib\OneDrive\Masaüstü\kodlama\MuratYucedagASP\CoreDemo\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Kategori Listesi</h1>\r\n<br />\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Kategori Adı</th>\r\n        <th>Durum</th>\r\n        <th>Pasif Yap</th>\r\n        <th>Aktif Yap</th>\r\n        <th>Düzenle</th>\r\n    </tr>\r\n");
#nullable restore
#line 20 "C:\Users\basib\OneDrive\Masaüstü\kodlama\MuratYucedagASP\CoreDemo\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>");
#nullable restore
#line 23 "C:\Users\basib\OneDrive\Masaüstü\kodlama\MuratYucedagASP\CoreDemo\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
           Write(item.CategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\basib\OneDrive\Masaüstü\kodlama\MuratYucedagASP\CoreDemo\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
           Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\basib\OneDrive\Masaüstü\kodlama\MuratYucedagASP\CoreDemo\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
           Write(item.CategoryStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a href=\"#\" class=\"btn btn-success\">Aktif Yap</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 707, "\"", 761, 2);
            WriteAttributeValue("", 714, "/Admin/Category/CategoryDelete/", 714, 31, true);
#nullable restore
#line 27 "C:\Users\basib\OneDrive\Masaüstü\kodlama\MuratYucedagASP\CoreDemo\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
WriteAttributeValue("", 745, item.CategoryID, 745, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"DeleteBtn\" onclick=\"return confirm(\'Silmek istediğinize emin misiniz?\');\" class=\"btn btn-danger\">Pasif Yap</a></td>\r\n            <td><a href=\"#\" class=\"btn btn-warning\">Düzenle</a></td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 31 "C:\Users\basib\OneDrive\Masaüstü\kodlama\MuratYucedagASP\CoreDemo\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Admin/Category/AddCategory/\" class=\"btn btn-primary\" > Yeni Kategori</a>\r\n<br /> <br />\r\n");
#nullable restore
#line 35 "C:\Users\basib\OneDrive\Masaüstü\kodlama\MuratYucedagASP\CoreDemo\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("Index", new { page})));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<Entity.Concrete.Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
