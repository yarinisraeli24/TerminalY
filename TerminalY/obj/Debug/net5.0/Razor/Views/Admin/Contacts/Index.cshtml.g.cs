<<<<<<< HEAD
#pragma checksum "C:\Users\Or Sharoni\source\repos\TerminalY\TerminalY\Views\Admin\Contacts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60833e5a13be732a7b05a845ca109e312b7c4e48"
=======
#pragma checksum "C:\Users\Mali\Desktop\TerminalY\TerminalY\Views\Admin\Contacts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60833e5a13be732a7b05a845ca109e312b7c4e48"
>>>>>>> 5ec5ebbf94a0829c7d07253e0e7fa1f3da80928b
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Contacts_Index), @"mvc.1.0.view", @"/Views/Admin/Contacts/Index.cshtml")]
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
#line 1 "C:\Users\Or Sharoni\source\repos\TerminalY\TerminalY\Views\_ViewImports.cshtml"
=======
#line 1 "C:\Users\Mali\Desktop\TerminalY\TerminalY\Views\_ViewImports.cshtml"
>>>>>>> 5ec5ebbf94a0829c7d07253e0e7fa1f3da80928b
using TerminalY;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "C:\Users\Or Sharoni\source\repos\TerminalY\TerminalY\Views\_ViewImports.cshtml"
=======
#line 2 "C:\Users\Mali\Desktop\TerminalY\TerminalY\Views\_ViewImports.cshtml"
>>>>>>> 5ec5ebbf94a0829c7d07253e0e7fa1f3da80928b
using TerminalY.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60833e5a13be732a7b05a845ca109e312b7c4e48", @"/Views/Admin/Contacts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4a5b62056b7a74b1f36452710a4ccf3bbe23068", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Contacts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TerminalY.Models.Contact>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Or Sharoni\source\repos\TerminalY\TerminalY\Views\Admin\Contacts\Index.cshtml"
=======
#line 3 "C:\Users\Mali\Desktop\TerminalY\TerminalY\Views\Admin\Contacts\Index.cshtml"
>>>>>>> 5ec5ebbf94a0829c7d07253e0e7fa1f3da80928b
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60833e5a13be732a7b05a845ca109e312b7c4e484568", async() => {
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
<<<<<<< HEAD
#line 16 "C:\Users\Or Sharoni\source\repos\TerminalY\TerminalY\Views\Admin\Contacts\Index.cshtml"
=======
#line 16 "C:\Users\Mali\Desktop\TerminalY\TerminalY\Views\Admin\Contacts\Index.cshtml"
>>>>>>> 5ec5ebbf94a0829c7d07253e0e7fa1f3da80928b
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
<<<<<<< HEAD
#line 19 "C:\Users\Or Sharoni\source\repos\TerminalY\TerminalY\Views\Admin\Contacts\Index.cshtml"
=======
#line 19 "C:\Users\Mali\Desktop\TerminalY\TerminalY\Views\Admin\Contacts\Index.cshtml"
>>>>>>> 5ec5ebbf94a0829c7d07253e0e7fa1f3da80928b
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
<<<<<<< HEAD
#line 22 "C:\Users\Or Sharoni\source\repos\TerminalY\TerminalY\Views\Admin\Contacts\Index.cshtml"
=======
#line 22 "C:\Users\Mali\Desktop\TerminalY\TerminalY\Views\Admin\Contacts\Index.cshtml"
>>>>>>> 5ec5ebbf94a0829c7d07253e0e7fa1f3da80928b
           Write(Html.DisplayNameFor(model => model.Subject));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
<<<<<<< HEAD
#line 25 "C:\Users\Or Sharoni\source\repos\TerminalY\TerminalY\Views\Admin\Contacts\Index.cshtml"
=======
#line 25 "C:\Users\Mali\Desktop\TerminalY\TerminalY\Views\Admin\Contacts\Index.cshtml"
>>>>>>> 5ec5ebbf94a0829c7d07253e0e7fa1f3da80928b
           Write(Html.DisplayNameFor(model => model.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
<<<<<<< HEAD
#line 31 "C:\Users\Or Sharoni\source\repos\TerminalY\TerminalY\Views\Admin\Contacts\Index.cshtml"
=======
#line 31 "C:\Users\Mali\Desktop\TerminalY\TerminalY\Views\Admin\Contacts\Index.cshtml"
>>>>>>> 5ec5ebbf94a0829c7d07253e0e7fa1f3da80928b
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
<<<<<<< HEAD
#line 34 "C:\Users\Or Sharoni\source\repos\TerminalY\TerminalY\Views\Admin\Contacts\Index.cshtml"
=======
#line 34 "C:\Users\Mali\Desktop\TerminalY\TerminalY\Views\Admin\Contacts\Index.cshtml"
>>>>>>> 5ec5ebbf94a0829c7d07253e0e7fa1f3da80928b
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
<<<<<<< HEAD
#line 37 "C:\Users\Or Sharoni\source\repos\TerminalY\TerminalY\Views\Admin\Contacts\Index.cshtml"
=======
#line 37 "C:\Users\Mali\Desktop\TerminalY\TerminalY\Views\Admin\Contacts\Index.cshtml"
>>>>>>> 5ec5ebbf94a0829c7d07253e0e7fa1f3da80928b
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
<<<<<<< HEAD
#line 40 "C:\Users\Or Sharoni\source\repos\TerminalY\TerminalY\Views\Admin\Contacts\Index.cshtml"
=======
#line 40 "C:\Users\Mali\Desktop\TerminalY\TerminalY\Views\Admin\Contacts\Index.cshtml"
>>>>>>> 5ec5ebbf94a0829c7d07253e0e7fa1f3da80928b
           Write(Html.DisplayFor(modelItem => item.Subject));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
<<<<<<< HEAD
#line 43 "C:\Users\Or Sharoni\source\repos\TerminalY\TerminalY\Views\Admin\Contacts\Index.cshtml"
=======
#line 43 "C:\Users\Mali\Desktop\TerminalY\TerminalY\Views\Admin\Contacts\Index.cshtml"
>>>>>>> 5ec5ebbf94a0829c7d07253e0e7fa1f3da80928b
           Write(Html.DisplayFor(modelItem => item.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60833e5a13be732a7b05a845ca109e312b7c4e488622", async() => {
                WriteLiteral("Edit");
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
#line 46 "C:\Users\Or Sharoni\source\repos\TerminalY\TerminalY\Views\Admin\Contacts\Index.cshtml"
=======
#line 46 "C:\Users\Mali\Desktop\TerminalY\TerminalY\Views\Admin\Contacts\Index.cshtml"
>>>>>>> 5ec5ebbf94a0829c7d07253e0e7fa1f3da80928b
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60833e5a13be732a7b05a845ca109e312b7c4e4810783", async() => {
                WriteLiteral("Details");
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
#line 47 "C:\Users\Or Sharoni\source\repos\TerminalY\TerminalY\Views\Admin\Contacts\Index.cshtml"
=======
#line 47 "C:\Users\Mali\Desktop\TerminalY\TerminalY\Views\Admin\Contacts\Index.cshtml"
>>>>>>> 5ec5ebbf94a0829c7d07253e0e7fa1f3da80928b
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60833e5a13be732a7b05a845ca109e312b7c4e4812951", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
<<<<<<< HEAD
#line 48 "C:\Users\Or Sharoni\source\repos\TerminalY\TerminalY\Views\Admin\Contacts\Index.cshtml"
=======
#line 48 "C:\Users\Mali\Desktop\TerminalY\TerminalY\Views\Admin\Contacts\Index.cshtml"
>>>>>>> 5ec5ebbf94a0829c7d07253e0e7fa1f3da80928b
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
#line 51 "C:\Users\Or Sharoni\source\repos\TerminalY\TerminalY\Views\Admin\Contacts\Index.cshtml"
=======
#line 51 "C:\Users\Mali\Desktop\TerminalY\TerminalY\Views\Admin\Contacts\Index.cshtml"
>>>>>>> 5ec5ebbf94a0829c7d07253e0e7fa1f3da80928b
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TerminalY.Models.Contact>> Html { get; private set; }
    }
}
#pragma warning restore 1591
