#pragma checksum "C:\Users\Аня\Desktop\антон\курсач3\Cursovaya2022-main\Curier\Views\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3267b1c9d5a71d598963eaefebabfb98210db0a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Index), @"mvc.1.0.view", @"/Views/Order/Index.cshtml")]
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
#line 1 "C:\Users\Аня\Desktop\антон\курсач3\Cursovaya2022-main\Curier\Views\_ViewImports.cshtml"
using Curier;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Аня\Desktop\антон\курсач3\Cursovaya2022-main\Curier\Views\_ViewImports.cshtml"
using Curier.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3267b1c9d5a71d598963eaefebabfb98210db0a2", @"/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59fd6f40fa8309d170f27927719a3f44297befa0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CurierLib.ViewModels.OrderToListViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Аня\Desktop\антон\курсач3\Cursovaya2022-main\Curier\Views\Order\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Заказы</h1>\n\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 13 "C:\Users\Аня\Desktop\антон\курсач3\Cursovaya2022-main\Curier\Views\Order\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Coirer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 16 "C:\Users\Аня\Desktop\антон\курсач3\Cursovaya2022-main\Curier\Views\Order\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Customer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 19 "C:\Users\Аня\Desktop\антон\курсач3\Cursovaya2022-main\Curier\Views\Order\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Tovar));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 22 "C:\Users\Аня\Desktop\антон\курсач3\Cursovaya2022-main\Curier\Views\Order\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 25 "C:\Users\Аня\Desktop\антон\курсач3\Cursovaya2022-main\Curier\Views\Order\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Data));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 31 "C:\Users\Аня\Desktop\антон\курсач3\Cursovaya2022-main\Curier\Views\Order\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 34 "C:\Users\Аня\Desktop\антон\курсач3\Cursovaya2022-main\Curier\Views\Order\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Coirer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 37 "C:\Users\Аня\Desktop\антон\курсач3\Cursovaya2022-main\Curier\Views\Order\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Customer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 40 "C:\Users\Аня\Desktop\антон\курсач3\Cursovaya2022-main\Curier\Views\Order\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Tovar));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 43 "C:\Users\Аня\Desktop\антон\курсач3\Cursovaya2022-main\Curier\Views\Order\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 46 "C:\Users\Аня\Desktop\антон\курсач3\Cursovaya2022-main\Curier\Views\Order\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Data));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n        </tr>\n");
#nullable restore
#line 49 "C:\Users\Аня\Desktop\антон\курсач3\Cursovaya2022-main\Curier\Views\Order\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CurierLib.ViewModels.OrderToListViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
