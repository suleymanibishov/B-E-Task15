#pragma checksum "D:\C#\Garaj\B-E-task2\B-E-Task15\B-E-Task15\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abbfd5c9313eafea91f0b9d931e6bd129f6cd17d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abbfd5c9313eafea91f0b9d931e6bd129f6cd17d", @"/Views/User/Index.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">Name</th>
            <th scope=""col"">Surname</th>
            <th scope=""col"">Age</th>
            <th scope=""col"">Country</th>
            <th scope=""col"">PhoneNumber</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>");
#nullable restore
#line 14 "D:\C#\Garaj\B-E-task2\B-E-Task15\B-E-Task15\Views\User\Index.cshtml"
           Write(ViewBag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 15 "D:\C#\Garaj\B-E-task2\B-E-Task15\B-E-Task15\Views\User\Index.cshtml"
           Write(ViewBag.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 16 "D:\C#\Garaj\B-E-task2\B-E-Task15\B-E-Task15\Views\User\Index.cshtml"
           Write(ViewBag.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 17 "D:\C#\Garaj\B-E-task2\B-E-Task15\B-E-Task15\Views\User\Index.cshtml"
           Write(ViewBag.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 18 "D:\C#\Garaj\B-E-task2\B-E-Task15\B-E-Task15\Views\User\Index.cshtml"
           Write(ViewBag.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n\r\n    </tbody>\r\n</table>\r\n");
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
