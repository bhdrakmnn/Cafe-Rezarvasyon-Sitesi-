#pragma checksum "C:\Users\bakma\source\repos\Cafe\Cafe\Areas\Customer\Views\Home\Menu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "455196f649b9430677662e8aed5f10e878ffc729"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Home_Menu), @"mvc.1.0.view", @"/Areas/Customer/Views/Home/Menu.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"455196f649b9430677662e8aed5f10e878ffc729", @"/Areas/Customer/Views/Home/Menu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ec1d1d2251e08cbfe34610fe24f19a3578c9b6e", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Customer_Views_Home_Menu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Cafe.Models.Menu>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\bakma\source\repos\Cafe\Cafe\Areas\Customer\Views\Home\Menu.cshtml"
  
    ViewData["Title"] = "Menu";
    Layout = "~/Views/Shared/_ALayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
	<!-- Title Page -->
	<section class=""bg-title-page flex-c-m p-t-160 p-b-80 p-l-15 p-r-15"" style=""background-image: url(/Site/images/bg-title-page-01.jpg);"">
		<h2 class=""tit6 t-center"">
			Menü Listesi
		</h2>
	</section>
		
		<div class=""section-gallery p-t-20 "">
		");
#nullable restore
#line 15 "C:\Users\bakma\source\repos\Cafe\Cafe\Areas\Customer\Views\Home\Menu.cshtml"
   Write(await Component.InvokeAsync("CategoryList"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\t\t\r\n\t</div>\r\n\r\n\t<section class=\"section-lunch bgwhite\">\r\n\t\t\r\n\r\n\t\t<div class=\"container\">\r\n\t\t\t<div class=\"row p-t-10\">\r\n");
#nullable restore
#line 25 "C:\Users\bakma\source\repos\Cafe\Cafe\Areas\Customer\Views\Home\Menu.cshtml"
                 foreach (var item in Model)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<div class=\"col-md-12 col-lg-6 \">\r\n\t\t\t\t\t<!-- Block3 -->\r\n\t\t\t\t\t<div class=\"blo3 flex-w flex-col-l-sm m-b-30\">\r\n\t\t\t\t\t\t<div class=\"pic-blo3 size20 bo-rad-10 hov-img-zoom m-r-28\">\r\n\t\t\t\t\t\t\t<a ><img");
            BeginWriteAttribute("src", " src=\"", 807, "\"", 824, 1);
#nullable restore
#line 31 "C:\Users\bakma\source\repos\Cafe\Cafe\Areas\Customer\Views\Home\Menu.cshtml"
WriteAttributeValue("", 813, item.Image, 813, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"IMG-MENU\"></a>\r\n\t\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t\t<div class=\"text-blo3 size21 flex-col-l-m\">\r\n\t\t\t\t\t\t\t<a  class=\"txt21 m-b-3\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 36 "C:\Users\bakma\source\repos\Cafe\Cafe\Areas\Customer\Views\Home\Menu.cshtml"
                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</a>\r\n\r\n\t\t\t\t\t\t\t<span class=\"txt23\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 40 "C:\Users\bakma\source\repos\Cafe\Cafe\Areas\Customer\Views\Home\Menu.cshtml"
                           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</span>\r\n\r\n\t\t\t\t\t\t\t<span class=\"txt22 m-t-20\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 44 "C:\Users\bakma\source\repos\Cafe\Cafe\Areas\Customer\Views\Home\Menu.cshtml"
                           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (₺)\r\n\t\t\t\t\t\t\t</span>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\r\n\t\t\t\t</div>\r\n");
#nullable restore
#line 50 "C:\Users\bakma\source\repos\Cafe\Cafe\Areas\Customer\Views\Home\Menu.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\r\n\r\n\t\t\t\t\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</section>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Cafe.Models.Menu>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591