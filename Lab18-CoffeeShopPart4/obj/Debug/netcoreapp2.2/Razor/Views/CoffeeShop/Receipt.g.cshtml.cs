#pragma checksum "C:\Users\lexas\OneDrive\Desktop\C#\Week 6\Lab18-CoffeeShopPart4\Lab18-CoffeeShopPart4\Views\CoffeeShop\Receipt.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "477a05c139191a940c4d4eb3d1180490bb1640b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CoffeeShop_Receipt), @"mvc.1.0.view", @"/Views/CoffeeShop/Receipt.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CoffeeShop/Receipt.cshtml", typeof(AspNetCore.Views_CoffeeShop_Receipt))]
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
#line 1 "C:\Users\lexas\OneDrive\Desktop\C#\Week 6\Lab18-CoffeeShopPart4\Lab18-CoffeeShopPart4\Views\_ViewImports.cshtml"
using Lab18_CoffeeShopPart4;

#line default
#line hidden
#line 2 "C:\Users\lexas\OneDrive\Desktop\C#\Week 6\Lab18-CoffeeShopPart4\Lab18-CoffeeShopPart4\Views\_ViewImports.cshtml"
using Lab18_CoffeeShopPart4.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"477a05c139191a940c4d4eb3d1180490bb1640b7", @"/Views/CoffeeShop/Receipt.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03ac7eadd4c9fc1b39201b74208049d913e52a30", @"/Views/_ViewImports.cshtml")]
    public class Views_CoffeeShop_Receipt : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\lexas\OneDrive\Desktop\C#\Week 6\Lab18-CoffeeShopPart4\Lab18-CoffeeShopPart4\Views\CoffeeShop\Receipt.cshtml"
  
    ViewData["Title"] = "Receipt";

#line default
#line hidden
            BeginContext(45, 20, true);
            WriteLiteral("\r\n<h1>Receipt</h1>\r\n");
            EndContext();
            BeginContext(66, 19, false);
#line 7 "C:\Users\lexas\OneDrive\Desktop\C#\Week 6\Lab18-CoffeeShopPart4\Lab18-CoffeeShopPart4\Views\CoffeeShop\Receipt.cshtml"
Write(TempData["Receipt"]);

#line default
#line hidden
            EndContext();
            BeginContext(85, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
