#pragma checksum "C:\Users\FATEH\source\repos\New folder\H_EstateAgency2\H_EstateAgency2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "728b83ed977a60d77b7de1347ae095192221f6d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\FATEH\source\repos\New folder\H_EstateAgency2\H_EstateAgency2\Views\_ViewImports.cshtml"
using H_EstateAgency2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\FATEH\source\repos\New folder\H_EstateAgency2\H_EstateAgency2\Views\_ViewImports.cshtml"
using H_EstateAgency2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"728b83ed977a60d77b7de1347ae095192221f6d8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6e41da41c143e7b33f8e29fd0dd10640c4ca34c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<H_EstateAgency2.Models.Property>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n\r\n<table class=\"table\" border=\"1\">\r\n   \r\n    <tbody>\r\n\r\n");
#nullable restore
#line 13 "C:\Users\FATEH\source\repos\New folder\H_EstateAgency2\H_EstateAgency2\Views\Home\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 18 "C:\Users\FATEH\source\repos\New folder\H_EstateAgency2\H_EstateAgency2\Views\Home\Index.cshtml"
           Write(item?.PropertyId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 22 "C:\Users\FATEH\source\repos\New folder\H_EstateAgency2\H_EstateAgency2\Views\Home\Index.cshtml"
           Write(item?.PropertyTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                <img height=\"42\" width=\"42\"");
            BeginWriteAttribute("src", " src=\"", 572, "\"", 683, 1);
#nullable restore
#line 26 "C:\Users\FATEH\source\repos\New folder\H_EstateAgency2\H_EstateAgency2\Views\Home\Index.cshtml"
WriteAttributeValue("", 578, String.Format("data:image/png;base64,{0}", Convert.ToBase64String(item.pictures.FirstOrDefault().photo)), 578, 105, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n\r\n            </td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 32 "C:\Users\FATEH\source\repos\New folder\H_EstateAgency2\H_EstateAgency2\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<H_EstateAgency2.Models.Property>> Html { get; private set; }
    }
}
#pragma warning restore 1591
