#pragma checksum "C:\Users\bakma\source\repos\Cafe\Cafe\Areas\Customer\Views\Home\Components\Iletisim\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0066a5acc1c1c3041bca074edeb13d46b32bb61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Home_Components_Iletisim_Default), @"mvc.1.0.view", @"/Areas/Customer/Views/Home/Components/Iletisim/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0066a5acc1c1c3041bca074edeb13d46b32bb61", @"/Areas/Customer/Views/Home/Components/Iletisim/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ec1d1d2251e08cbfe34610fe24f19a3578c9b6e", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Customer_Views_Home_Components_Iletisim_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Cafe.Models.Iletisim>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\bakma\source\repos\Cafe\Cafe\Areas\Customer\Views\Home\Components\Iletisim\Default.cshtml"
     foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul class=\"m-b-70\">\r\n\t\t\t\t\t\t<li class=\"txt14 m-b-14\">\r\n\t\t\t\t\t\t\t<i class=\"fa fa-map-marker fs-16 dis-inline-block size19\" aria-hidden=\"true\"></i>\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 8 "C:\Users\bakma\source\repos\Cafe\Cafe\Areas\Customer\Views\Home\Components\Iletisim\Default.cshtml"
                       Write(item.Adres);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t</li>\r\n\r\n\t\t\t\t\t\t<li class=\"txt14 m-b-14\">\r\n\t\t\t\t\t\t\t<i class=\"fa fa-phone fs-16 dis-inline-block size19\" aria-hidden=\"true\"></i>\r\n\t\t\t\t\t\t\t(+90) ");
#nullable restore
#line 13 "C:\Users\bakma\source\repos\Cafe\Cafe\Areas\Customer\Views\Home\Components\Iletisim\Default.cshtml"
                             Write(item.Telefon);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t</li>\r\n\r\n\t\t\t\t\t\t<li class=\"txt14 m-b-14\">\r\n\t\t\t\t\t\t\t<i class=\"fa fa-envelope fs-13 dis-inline-block size19\" aria-hidden=\"true\"></i>\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 18 "C:\Users\bakma\source\repos\Cafe\Cafe\Areas\Customer\Views\Home\Components\Iletisim\Default.cshtml"
                       Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t</li>\r\n\t\t\t\t\t</ul>\n");
#nullable restore
#line 21 "C:\Users\bakma\source\repos\Cafe\Cafe\Areas\Customer\Views\Home\Components\Iletisim\Default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Cafe.Models.Iletisim>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
