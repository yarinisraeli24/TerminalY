#pragma checksum "C:\Users\Or Sharoni\source\repos\TerminalY\TerminalY\Views\Orders\CartView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8ccc189828ac7172cf15fff6cdf1138398c787a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_CartView), @"mvc.1.0.view", @"/Views/Orders/CartView.cshtml")]
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
#line 1 "C:\Users\Or Sharoni\source\repos\TerminalY\TerminalY\Views\_ViewImports.cshtml"
using TerminalY;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Or Sharoni\source\repos\TerminalY\TerminalY\Views\_ViewImports.cshtml"
using TerminalY.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8ccc189828ac7172cf15fff6cdf1138398c787a", @"/Views/Orders/CartView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4a5b62056b7a74b1f36452710a4ccf3bbe23068", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_CartView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TerminalY.Models.Cart>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/cart/1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("No picture"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<ul class=\"product-list\">\r\n    <li>\r\n");
#nullable restore
#line 6 "C:\Users\Or Sharoni\source\repos\TerminalY\TerminalY\Views\Orders\CartView.cshtml"
         foreach (var item in Model.CartItems)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"pl-thumb\">\r\n");
#nullable restore
#line 9 "C:\Users\Or Sharoni\source\repos\TerminalY\TerminalY\Views\Orders\CartView.cshtml"
                 if (item.Product.Image != null)
                {
                    string img = item.Product.Image;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <img");
            BeginWriteAttribute("src", " src=\"", 313, "\"", 345, 2);
            WriteAttributeValue("", 319, "data:image/png;base64,", 319, 22, true);
#nullable restore
#line 12 "C:\Users\Or Sharoni\source\repos\TerminalY\TerminalY\Views\Orders\CartView.cshtml"
WriteAttributeValue("", 341, img, 341, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"No picture\">\r\n");
#nullable restore
#line 13 "C:\Users\Or Sharoni\source\repos\TerminalY\TerminalY\Views\Orders\CartView.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a8ccc189828ac7172cf15fff6cdf1138398c787a5234", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 17 "C:\Users\Or Sharoni\source\repos\TerminalY\TerminalY\Views\Orders\CartView.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <h6>");
#nullable restore
#line 19 "C:\Users\Or Sharoni\source\repos\TerminalY\TerminalY\Views\Orders\CartView.cshtml"
           Write(item.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            <p>$");
#nullable restore
#line 20 "C:\Users\Or Sharoni\source\repos\TerminalY\TerminalY\Views\Orders\CartView.cshtml"
           Write(item.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(",00</p>\r\n");
#nullable restore
#line 21 "C:\Users\Or Sharoni\source\repos\TerminalY\TerminalY\Views\Orders\CartView.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </li>\r\n</ul>\r\n<ul class=\"price-list\">\r\n    <li>Total<span>$");
#nullable restore
#line 25 "C:\Users\Or Sharoni\source\repos\TerminalY\TerminalY\Views\Orders\CartView.cshtml"
               Write(Model.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(",00</span></li>\r\n    <li>Shipping<span>free</span></li>\r\n    <li class=\"total\">Total<span>");
#nullable restore
#line 27 "C:\Users\Or Sharoni\source\repos\TerminalY\TerminalY\Views\Orders\CartView.cshtml"
                            Write(Model.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TerminalY.Models.Cart> Html { get; private set; }
    }
}
#pragma warning restore 1591
