#pragma checksum "/Users/joshjudkins/Desktop/Mission09/Mission09/Pages/BuyBooks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "513dd4a9dc769f018973609529c7b4dd8c9bd738"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_BuyBooks), @"mvc.1.0.razor-page", @"/Pages/BuyBooks.cshtml")]
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
#line 2 "/Users/joshjudkins/Desktop/Mission09/Mission09/Pages/_ViewImports.cshtml"
using Mission09.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"513dd4a9dc769f018973609529c7b4dd8c9bd738", @"/Pages/BuyBooks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c27539b04399498e608ee3b2b3c0d80655f3e28", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_BuyBooks : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h2>Your Cart</h2>\n\n");
            WriteLiteral("<table class=\"table table-bordered table-striped collapsing\">\n    <thead>\n        <tr>\n            <th>Item</th>\n            <th>Quantity</th>\n            <th>Cost</th>\n            <th>Subtotal</th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 19 "/Users/joshjudkins/Desktop/Mission09/Mission09/Pages/BuyBooks.cshtml"
         foreach (var i in Model.cart.Books)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 22 "/Users/joshjudkins/Desktop/Mission09/Mission09/Pages/BuyBooks.cshtml"
               Write(i.Book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 23 "/Users/joshjudkins/Desktop/Mission09/Mission09/Pages/BuyBooks.cshtml"
               Write(i.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 24 "/Users/joshjudkins/Desktop/Mission09/Mission09/Pages/BuyBooks.cshtml"
               Write(i.Book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 25 "/Users/joshjudkins/Desktop/Mission09/Mission09/Pages/BuyBooks.cshtml"
               Write(i.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(" * ");
#nullable restore
#line 25 "/Users/joshjudkins/Desktop/Mission09/Mission09/Pages/BuyBooks.cshtml"
                             Write(i.Book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n");
#nullable restore
#line 27 "/Users/joshjudkins/Desktop/Mission09/Mission09/Pages/BuyBooks.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n    <tfoot>\n        <tr>\n            <td colspan=\"3\">Total: </td>\n            <td>");
#nullable restore
#line 32 "/Users/joshjudkins/Desktop/Mission09/Mission09/Pages/BuyBooks.cshtml"
           Write(Model.cart.CalculateTotal().ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n    </tfoot>\n</table>\n\n");
            WriteLiteral("<div>\n    <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 916, "\"", 939, 1);
#nullable restore
#line 39 "/Users/joshjudkins/Desktop/Mission09/Mission09/Pages/BuyBooks.cshtml"
WriteAttributeValue("", 923, Model.ReturnUrl, 923, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Continue Shopping</a>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Mission09.Pages.BuyBooksModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Mission09.Pages.BuyBooksModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Mission09.Pages.BuyBooksModel>)PageContext?.ViewData;
        public Mission09.Pages.BuyBooksModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
