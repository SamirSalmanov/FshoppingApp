#pragma checksum "C:\Users\user\Desktop\ShoppingApp\Shopping.Web\Views\Shared\Components\Basket\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1c765449e40a85e3c387d267adeffb153f6b00c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Basket_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Basket/Default.cshtml")]
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
#line 1 "C:\Users\user\Desktop\ShoppingApp\Shopping.Web\Views\_ViewImports.cshtml"
using Shopping.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\ShoppingApp\Shopping.Web\Views\_ViewImports.cshtml"
using Shopping.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\Desktop\ShoppingApp\Shopping.Web\Views\_ViewImports.cshtml"
using Shopping.Web.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1c765449e40a85e3c387d267adeffb153f6b00c", @"/Views/Shared/Components/Basket/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"307e35433f4ab5757a77b4fb4780eb3d51a05f52", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Basket_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\user\Desktop\ShoppingApp\Shopping.Web\Views\Shared\Components\Basket\Default.cshtml"
   
    List<int> basketIds = ViewData["basketId"] as List<int>;

#line default
#line hidden
#nullable disable
            WriteLiteral("<a href=\"#offcanvas-cart\" class=\"header-action-btn header-action-btn-cart offcanvas-toggle pr-0\">\r\n    <i class=\"icon-handbag\"></i>\r\n");
#nullable restore
#line 6 "C:\Users\user\Desktop\ShoppingApp\Shopping.Web\Views\Shared\Components\Basket\Default.cshtml"
     if (basketIds != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span class=\"header-action-num\">");
#nullable restore
#line 8 "C:\Users\user\Desktop\ShoppingApp\Shopping.Web\Views\Shared\Components\Basket\Default.cshtml"
                                   Write(basketIds.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 9 "C:\Users\user\Desktop\ShoppingApp\Shopping.Web\Views\Shared\Components\Basket\Default.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span class=\"header-action-num\">\r\n            0\r\n        </span>\r\n");
#nullable restore
#line 15 "C:\Users\user\Desktop\ShoppingApp\Shopping.Web\Views\Shared\Components\Basket\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <!-- <span class=\"cart-amount\">€30.00</span> -->\r\n</a>\r\n");
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
