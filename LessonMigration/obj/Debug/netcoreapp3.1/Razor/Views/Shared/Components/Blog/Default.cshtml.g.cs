#pragma checksum "C:\Users\FX706HCB\Desktop\P126-AspNet-Basket-ViewComponent\LessonMigration\LessonMigration\Views\Shared\Components\Blog\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9e6192b67ce09db00ebe68d1ae400f238120858"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Blog_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Blog/Default.cshtml")]
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
#line 1 "C:\Users\FX706HCB\Desktop\P126-AspNet-Basket-ViewComponent\LessonMigration\LessonMigration\Views\_ViewImports.cshtml"
using LessonMigration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\FX706HCB\Desktop\P126-AspNet-Basket-ViewComponent\LessonMigration\LessonMigration\Views\_ViewImports.cshtml"
using LessonMigration.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\FX706HCB\Desktop\P126-AspNet-Basket-ViewComponent\LessonMigration\LessonMigration\Views\_ViewImports.cshtml"
using LessonMigration.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9e6192b67ce09db00ebe68d1ae400f238120858", @"/Views/Shared/Components/Blog/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15bb8ae992336ed7ecf780060bded98401cd356d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Blog_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- BLOG START -->\r\n\r\n        <div class=\"row pb-5\">\r\n\r\n");
#nullable restore
#line 5 "C:\Users\FX706HCB\Desktop\P126-AspNet-Basket-ViewComponent\LessonMigration\LessonMigration\Views\Shared\Components\Blog\Default.cshtml"
             foreach (var blog in Model)
             {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-6 col-lg-4\">\r\n                    <div class=\"item\">\r\n                        <img src=\"img/ position-relative\">\r\n                        <div class=\"date rounded bg-light position-absolute py-1 px-2\">\r\n");
            WriteLiteral("                            <span>");
#nullable restore
#line 13 "C:\Users\FX706HCB\Desktop\P126-AspNet-Basket-ViewComponent\LessonMigration\LessonMigration\Views\Shared\Components\Blog\Default.cshtml"
                             Write(blog.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"text mt-3 text-center px-5\">\r\n");
            WriteLiteral("                        <h5>");
#nullable restore
#line 18 "C:\Users\FX706HCB\Desktop\P126-AspNet-Basket-ViewComponent\LessonMigration\LessonMigration\Views\Shared\Components\Blog\Default.cshtml"
                       Write(blog.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <p class=\"text-black-50\">\r\n                            ");
#nullable restore
#line 20 "C:\Users\FX706HCB\Desktop\P126-AspNet-Basket-ViewComponent\LessonMigration\LessonMigration\Views\Shared\Components\Blog\Default.cshtml"
                       Write(blog.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </p>\r\n\r\n\r\n\r\n                    </div>\r\n\r\n                </div>\r\n");
#nullable restore
#line 29 "C:\Users\FX706HCB\Desktop\P126-AspNet-Basket-ViewComponent\LessonMigration\LessonMigration\Views\Shared\Components\Blog\Default.cshtml"


             }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n        </div>\r\n \r\n");
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
