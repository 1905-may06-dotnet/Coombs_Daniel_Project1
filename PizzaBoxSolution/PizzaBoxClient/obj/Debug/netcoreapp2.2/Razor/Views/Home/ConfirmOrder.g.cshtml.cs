#pragma checksum "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\ConfirmOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee053ada2ce4f885bb3b4676b1ef55bbd093d1f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ConfirmOrder), @"mvc.1.0.view", @"/Views/Home/ConfirmOrder.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ConfirmOrder.cshtml", typeof(AspNetCore.Views_Home_ConfirmOrder))]
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
#line 1 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\_ViewImports.cshtml"
using PizzaBoxClient;

#line default
#line hidden
#line 2 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\_ViewImports.cshtml"
using PizzaBoxClient.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee053ada2ce4f885bb3b4676b1ef55bbd093d1f8", @"/Views/Home/ConfirmOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"344545cdec7029661c59639aecae16d680e6af1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ConfirmOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PizzaBoxDomain.Pizza>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\ConfirmOrder.cshtml"
  
    ViewData["Title"] = "ConfirmOrder";

#line default
#line hidden
            BeginContext(92, 50, true);
            WriteLiteral("\r\n<h1>Please Confirm Your Order</h1>\r\n\r\n<hr />\r\n\r\n");
            EndContext();
            BeginContext(143, 16, false);
#line 11 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\ConfirmOrder.cshtml"
Write(ViewData["Text"]);

#line default
#line hidden
            EndContext();
            BeginContext(159, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PizzaBoxDomain.Pizza>> Html { get; private set; }
    }
}
#pragma warning restore 1591
