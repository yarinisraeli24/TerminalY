<<<<<<< HEAD
#pragma checksum "C:\Users\USER\source\repos\TerminalY\TerminalY\Views\Admin\Carts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "222fdca82ba5efa84e2230f74f744fe0f143e37c"
=======
#pragma checksum "C:\Users\Mali\Desktop\TerminalY\TerminalY\Views\Admin\Carts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c06210f12a4012fd0d5519e7a41133937bce4db"
>>>>>>> b9dd6da296bbfe4074c920eb92c341e8adb19b65
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Carts_Index), @"mvc.1.0.view", @"/Views/Admin/Carts/Index.cshtml")]
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
<<<<<<< HEAD
#line 1 "C:\Users\USER\source\repos\TerminalY\TerminalY\Views\_ViewImports.cshtml"
=======
#line 1 "C:\Users\Mali\Desktop\TerminalY\TerminalY\Views\_ViewImports.cshtml"
>>>>>>> b9dd6da296bbfe4074c920eb92c341e8adb19b65
using TerminalY;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "C:\Users\USER\source\repos\TerminalY\TerminalY\Views\_ViewImports.cshtml"
=======
#line 2 "C:\Users\Mali\Desktop\TerminalY\TerminalY\Views\_ViewImports.cshtml"
>>>>>>> b9dd6da296bbfe4074c920eb92c341e8adb19b65
using TerminalY.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c06210f12a4012fd0d5519e7a41133937bce4db", @"/Views/Admin/Carts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4a5b62056b7a74b1f36452710a4ccf3bbe23068", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Carts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TerminalY.Models.Cart>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CartEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CartDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CartDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
<<<<<<< HEAD
#line 3 "C:\Users\USER\source\repos\TerminalY\TerminalY\Views\Admin\Carts\Index.cshtml"
=======
#line 3 "C:\Users\Mali\Desktop\TerminalY\TerminalY\Views\Admin\Carts\Index.cshtml"
>>>>>>> b9dd6da296bbfe4074c920eb92c341e8adb19b65
  
    ViewData["Title"] = "Carts";

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            WriteLiteral("\r\n<h1 class=\"table-title\">Carts</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "222fdca82ba5efa84e2230f74f744fe0f143e37c4605", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\USER\source\repos\TerminalY\TerminalY\Views\Admin\Carts\Index.cshtml"
=======
            WriteLiteral("\r\n<h1 class=\"table-title\">Carts</h1>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Users\Mali\Desktop\TerminalY\TerminalY\Views\Admin\Carts\Index.cshtml"
>>>>>>> b9dd6da296bbfe4074c920eb92c341e8adb19b65
           Write(Html.DisplayNameFor(model => model.TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
<<<<<<< HEAD
#line 19 "C:\Users\USER\source\repos\TerminalY\TerminalY\Views\Admin\Carts\Index.cshtml"
=======
#line 17 "C:\Users\Mali\Desktop\TerminalY\TerminalY\Views\Admin\Carts\Index.cshtml"
>>>>>>> b9dd6da296bbfe4074c920eb92c341e8adb19b65
           Write(Html.DisplayNameFor(model => model.Account));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
<<<<<<< HEAD
#line 25 "C:\Users\USER\source\repos\TerminalY\TerminalY\Views\Admin\Carts\Index.cshtml"
=======
#line 23 "C:\Users\Mali\Desktop\TerminalY\TerminalY\Views\Admin\Carts\Index.cshtml"
>>>>>>> b9dd6da296bbfe4074c920eb92c341e8adb19b65
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
<<<<<<< HEAD
#line 28 "C:\Users\USER\source\repos\TerminalY\TerminalY\Views\Admin\Carts\Index.cshtml"
=======
#line 26 "C:\Users\Mali\Desktop\TerminalY\TerminalY\Views\Admin\Carts\Index.cshtml"
>>>>>>> b9dd6da296bbfe4074c920eb92c341e8adb19b65
           Write(Html.DisplayFor(modelItem => item.TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
<<<<<<< HEAD
#line 31 "C:\Users\USER\source\repos\TerminalY\TerminalY\Views\Admin\Carts\Index.cshtml"
=======
#line 29 "C:\Users\Mali\Desktop\TerminalY\TerminalY\Views\Admin\Carts\Index.cshtml"
>>>>>>> b9dd6da296bbfe4074c920eb92c341e8adb19b65
           Write(Html.DisplayFor(modelItem => item.Account.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "222fdca82ba5efa84e2230f74f744fe0f143e37c7446", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c06210f12a4012fd0d5519e7a41133937bce4db5922", async() => {
>>>>>>> b9dd6da296bbfe4074c920eb92c341e8adb19b65
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
<<<<<<< HEAD
#line 34 "C:\Users\USER\source\repos\TerminalY\TerminalY\Views\Admin\Carts\Index.cshtml"
=======
#line 32 "C:\Users\Mali\Desktop\TerminalY\TerminalY\Views\Admin\Carts\Index.cshtml"
>>>>>>> b9dd6da296bbfe4074c920eb92c341e8adb19b65
                                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                ");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "222fdca82ba5efa84e2230f74f744fe0f143e37c9613", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c06210f12a4012fd0d5519e7a41133937bce4db8084", async() => {
>>>>>>> b9dd6da296bbfe4074c920eb92c341e8adb19b65
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
<<<<<<< HEAD
#line 35 "C:\Users\USER\source\repos\TerminalY\TerminalY\Views\Admin\Carts\Index.cshtml"
=======
#line 33 "C:\Users\Mali\Desktop\TerminalY\TerminalY\Views\Admin\Carts\Index.cshtml"
>>>>>>> b9dd6da296bbfe4074c920eb92c341e8adb19b65
                                              WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                ");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "222fdca82ba5efa84e2230f74f744fe0f143e37c11786", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c06210f12a4012fd0d5519e7a41133937bce4db10252", async() => {
>>>>>>> b9dd6da296bbfe4074c920eb92c341e8adb19b65
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
<<<<<<< HEAD
#line 36 "C:\Users\USER\source\repos\TerminalY\TerminalY\Views\Admin\Carts\Index.cshtml"
=======
#line 34 "C:\Users\Mali\Desktop\TerminalY\TerminalY\Views\Admin\Carts\Index.cshtml"
>>>>>>> b9dd6da296bbfe4074c920eb92c341e8adb19b65
                                             WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
<<<<<<< HEAD
#line 39 "C:\Users\USER\source\repos\TerminalY\TerminalY\Views\Admin\Carts\Index.cshtml"
=======
#line 37 "C:\Users\Mali\Desktop\TerminalY\TerminalY\Views\Admin\Carts\Index.cshtml"
>>>>>>> b9dd6da296bbfe4074c920eb92c341e8adb19b65
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TerminalY.Models.Cart>> Html { get; private set; }
    }
}
#pragma warning restore 1591
