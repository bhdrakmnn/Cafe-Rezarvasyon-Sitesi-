#pragma checksum "C:\Users\bakma\source\repos\Cafe\Cafe\Areas\Customer\Views\Home\Components\Yorumlar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a64a53a939e239d44a5df04eda40c41500b7db07"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Home_Components_Yorumlar_Default), @"mvc.1.0.view", @"/Areas/Customer/Views/Home/Components/Yorumlar/Default.cshtml")]
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
#line 1 "C:\Users\bakma\source\repos\Cafe\Cafe\Areas\Customer\Views\_ViewImports.cshtml"
using Cafe;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bakma\source\repos\Cafe\Cafe\Areas\Customer\Views\_ViewImports.cshtml"
using Cafe.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a64a53a939e239d44a5df04eda40c41500b7db07", @"/Areas/Customer/Views/Home/Components/Yorumlar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ec1d1d2251e08cbfe34610fe24f19a3578c9b6e", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Customer_Views_Home_Components_Yorumlar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Cafe.Models.Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\bakma\source\repos\Cafe\Cafe\Areas\Customer\Views\Home\Components\Yorumlar\Default.cshtml"
    foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    \t<div class=\"blo4 p-b-63\">\r\n\t\t\t\t\t\t\t<!-- - -->\r\n\t\t\t\t\t\t\t<div class=\"pic-blo4 hov-img-zoom bo-rad-10 pos-relative\">\r\n\t\t\t\t\t\t\t\t<a >\r\n\t\t\t\t\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 219, "\"", 236, 1);
#nullable restore
#line 9 "C:\Users\bakma\source\repos\Cafe\Cafe\Areas\Customer\Views\Home\Components\Yorumlar\Default.cshtml"
WriteAttributeValue("", 225, item.Image, 225, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"IMG-BLOG\">\r\n\t\t\t\t\t\t\t\t</a>\r\n\r\n\t\t\t\t\t\t\t\t<div class=\"date-blo4 flex-col-c-m\">\r\n\t\t\t\t\t\t\t\t\t<span class=\"txt30 m-b-4\">\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 14 "C:\Users\bakma\source\repos\Cafe\Cafe\Areas\Customer\Views\Home\Components\Yorumlar\Default.cshtml"
                                   Write(item.Tarih.ToString("dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</span>\r\n\r\n\t\t\t\t\t\t\t\t\t<span class=\"txt31\">\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 18 "C:\Users\bakma\source\repos\Cafe\Cafe\Areas\Customer\Views\Home\Components\Yorumlar\Default.cshtml"
                                   Write(item.Tarih.ToString("MMMM,yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</span>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t\t\t<!-- - -->\r\n\t\t\t\t\t\t\t<div class=\"text-blo4 p-t-33\">\r\n\t\t\t\t\t\t\t\t<h4 class=\"p-b-16\">\r\n\t\t\t\t\t\t\t\t\t<a  class=\"tit9\">");
#nullable restore
#line 26 "C:\Users\bakma\source\repos\Cafe\Cafe\Areas\Customer\Views\Home\Components\Yorumlar\Default.cshtml"
                                                Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\t\t\t\t\t\t\t\t</h4>\r\n\r\n\t\t\t\t\t\t\t\t<div class=\"txt32 flex-w p-b-24\">\r\n\t\t\t\t\t\t\t\t\t<span>\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 31 "C:\Users\bakma\source\repos\Cafe\Cafe\Areas\Customer\Views\Home\Components\Yorumlar\Default.cshtml"
                                   Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t<span class=\"m-r-6 m-l-4\">|</span>\r\n\t\t\t\t\t\t\t\t\t</span>\r\n\r\n\t\t\t\t\t\t\t\t\t<span>\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 36 "C:\Users\bakma\source\repos\Cafe\Cafe\Areas\Customer\Views\Home\Components\Yorumlar\Default.cshtml"
                                   Write(item.Tarih.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t<span class=\"m-r-6 m-l-4\">|</span>\r\n\t\t\t\t\t\t\t\t\t</span>\r\n\r\n\t\t\t\t\t\t\t\t\t\r\n\r\n\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t\t\t\t<p>\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 46 "C:\Users\bakma\source\repos\Cafe\Cafe\Areas\Customer\Views\Home\Components\Yorumlar\Default.cshtml"
                               Write(item.Mesaj);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</p>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\n");
#nullable restore
#line 50 "C:\Users\bakma\source\repos\Cafe\Cafe\Areas\Customer\Views\Home\Components\Yorumlar\Default.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("           ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Cafe.Models.Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591