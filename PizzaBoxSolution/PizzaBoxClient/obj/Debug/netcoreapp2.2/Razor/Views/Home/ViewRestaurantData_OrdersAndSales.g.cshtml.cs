#pragma checksum "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\ViewRestaurantData_OrdersAndSales.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "383bc6b4cbd9bad4885d56ca1064184de0295a9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewRestaurantData_OrdersAndSales), @"mvc.1.0.view", @"/Views/Home/ViewRestaurantData_OrdersAndSales.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ViewRestaurantData_OrdersAndSales.cshtml", typeof(AspNetCore.Views_Home_ViewRestaurantData_OrdersAndSales))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"383bc6b4cbd9bad4885d56ca1064184de0295a9e", @"/Views/Home/ViewRestaurantData_OrdersAndSales.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"344545cdec7029661c59639aecae16d680e6af1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewRestaurantData_OrdersAndSales : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PizzaBoxClient.Models.OrderHistory>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewRestaurantData", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\ViewRestaurantData_OrdersAndSales.cshtml"
  
    Layout = "_LayoutAfter";
    ViewData["Title"] = "ViewRestaurantData_OrdersAndSales";
    decimal total = 0.00M;
    int qty = 0;

#line default
#line hidden
            BeginContext(203, 41, true);
            WriteLiteral("\r\n<h1>Orders and Sales</h1>\r\n<br />\r\n<h3>");
            EndContext();
            BeginContext(245, 22, false);
#line 12 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\ViewRestaurantData_OrdersAndSales.cshtml"
Write(ViewBag.OrdersAndSales);

#line default
#line hidden
            EndContext();
            BeginContext(267, 91, true);
            WriteLiteral("</h3>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(359, 43, false);
#line 17 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\ViewRestaurantData_OrdersAndSales.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderID));

#line default
#line hidden
            EndContext();
            BeginContext(402, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(458, 40, false);
#line 20 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\ViewRestaurantData_OrdersAndSales.cshtml"
           Write(Html.DisplayNameFor(model => model.Size));

#line default
#line hidden
            EndContext();
            BeginContext(498, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(554, 41, false);
#line 23 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\ViewRestaurantData_OrdersAndSales.cshtml"
           Write(Html.DisplayNameFor(model => model.Crust));

#line default
#line hidden
            EndContext();
            BeginContext(595, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(651, 44, false);
#line 26 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\ViewRestaurantData_OrdersAndSales.cshtml"
           Write(Html.DisplayNameFor(model => model.Topping1));

#line default
#line hidden
            EndContext();
            BeginContext(695, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(751, 44, false);
#line 29 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\ViewRestaurantData_OrdersAndSales.cshtml"
           Write(Html.DisplayNameFor(model => model.Topping2));

#line default
#line hidden
            EndContext();
            BeginContext(795, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(851, 44, false);
#line 32 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\ViewRestaurantData_OrdersAndSales.cshtml"
           Write(Html.DisplayNameFor(model => model.Topping3));

#line default
#line hidden
            EndContext();
            BeginContext(895, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(951, 44, false);
#line 35 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\ViewRestaurantData_OrdersAndSales.cshtml"
           Write(Html.DisplayNameFor(model => model.Topping4));

#line default
#line hidden
            EndContext();
            BeginContext(995, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1051, 44, false);
#line 38 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\ViewRestaurantData_OrdersAndSales.cshtml"
           Write(Html.DisplayNameFor(model => model.Topping5));

#line default
#line hidden
            EndContext();
            BeginContext(1095, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1151, 39, false);
#line 41 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\ViewRestaurantData_OrdersAndSales.cshtml"
           Write(Html.DisplayNameFor(model => model.Qty));

#line default
#line hidden
            EndContext();
            BeginContext(1190, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1246, 44, false);
#line 44 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\ViewRestaurantData_OrdersAndSales.cshtml"
           Write(Html.DisplayNameFor(model => model.Subtotal));

#line default
#line hidden
            EndContext();
            BeginContext(1290, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1346, 46, false);
#line 47 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\ViewRestaurantData_OrdersAndSales.cshtml"
           Write(Html.DisplayNameFor(model => model.TimePlaced));

#line default
#line hidden
            EndContext();
            BeginContext(1392, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1448, 46, false);
#line 50 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\ViewRestaurantData_OrdersAndSales.cshtml"
           Write(Html.DisplayNameFor(model => model.DatePlaced));

#line default
#line hidden
            EndContext();
            BeginContext(1494, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1550, 44, false);
#line 53 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\ViewRestaurantData_OrdersAndSales.cshtml"
           Write(Html.DisplayNameFor(model => model.Location));

#line default
#line hidden
            EndContext();
            BeginContext(1594, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1650, 40, false);
#line 56 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\ViewRestaurantData_OrdersAndSales.cshtml"
           Write(Html.DisplayNameFor(model => model.Data));

#line default
#line hidden
            EndContext();
            BeginContext(1690, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1746, 45, false);
#line 59 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\ViewRestaurantData_OrdersAndSales.cshtml"
           Write(Html.DisplayNameFor(model => model.LocString));

#line default
#line hidden
            EndContext();
            BeginContext(1791, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 65 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\ViewRestaurantData_OrdersAndSales.cshtml"
 foreach (var item in Model)
{
    total += item.Subtotal;
    qty++;

#line default
#line hidden
            BeginContext(1951, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2000, 42, false);
#line 71 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\ViewRestaurantData_OrdersAndSales.cshtml"
           Write(Html.DisplayFor(modelItem => item.OrderID));

#line default
#line hidden
            EndContext();
            BeginContext(2042, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2098, 39, false);
#line 74 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\ViewRestaurantData_OrdersAndSales.cshtml"
           Write(Html.DisplayFor(modelItem => item.Size));

#line default
#line hidden
            EndContext();
            BeginContext(2137, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2193, 40, false);
#line 77 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\ViewRestaurantData_OrdersAndSales.cshtml"
           Write(Html.DisplayFor(modelItem => item.Crust));

#line default
#line hidden
            EndContext();
            BeginContext(2233, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2289, 43, false);
#line 80 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\ViewRestaurantData_OrdersAndSales.cshtml"
           Write(Html.DisplayFor(modelItem => item.Topping1));

#line default
#line hidden
            EndContext();
            BeginContext(2332, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2388, 43, false);
#line 83 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\ViewRestaurantData_OrdersAndSales.cshtml"
           Write(Html.DisplayFor(modelItem => item.Topping2));

#line default
#line hidden
            EndContext();
            BeginContext(2431, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2487, 43, false);
#line 86 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\ViewRestaurantData_OrdersAndSales.cshtml"
           Write(Html.DisplayFor(modelItem => item.Topping3));

#line default
#line hidden
            EndContext();
            BeginContext(2530, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2586, 43, false);
#line 89 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\ViewRestaurantData_OrdersAndSales.cshtml"
           Write(Html.DisplayFor(modelItem => item.Topping4));

#line default
#line hidden
            EndContext();
            BeginContext(2629, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2685, 43, false);
#line 92 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\ViewRestaurantData_OrdersAndSales.cshtml"
           Write(Html.DisplayFor(modelItem => item.Topping5));

#line default
#line hidden
            EndContext();
            BeginContext(2728, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2784, 38, false);
#line 95 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\ViewRestaurantData_OrdersAndSales.cshtml"
           Write(Html.DisplayFor(modelItem => item.Qty));

#line default
#line hidden
            EndContext();
            BeginContext(2822, 56, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                $");
            EndContext();
            BeginContext(2879, 43, false);
#line 98 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\ViewRestaurantData_OrdersAndSales.cshtml"
            Write(Html.DisplayFor(modelItem => item.Subtotal));

#line default
#line hidden
            EndContext();
            BeginContext(2922, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2978, 45, false);
#line 101 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\ViewRestaurantData_OrdersAndSales.cshtml"
           Write(Html.DisplayFor(modelItem => item.TimePlaced));

#line default
#line hidden
            EndContext();
            BeginContext(3023, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3079, 45, false);
#line 104 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\ViewRestaurantData_OrdersAndSales.cshtml"
           Write(Html.DisplayFor(modelItem => item.DatePlaced));

#line default
#line hidden
            EndContext();
            BeginContext(3124, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3180, 43, false);
#line 107 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\ViewRestaurantData_OrdersAndSales.cshtml"
           Write(Html.DisplayFor(modelItem => item.Location));

#line default
#line hidden
            EndContext();
            BeginContext(3223, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3279, 39, false);
#line 110 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\ViewRestaurantData_OrdersAndSales.cshtml"
           Write(Html.DisplayFor(modelItem => item.Data));

#line default
#line hidden
            EndContext();
            BeginContext(3318, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3374, 44, false);
#line 113 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\ViewRestaurantData_OrdersAndSales.cshtml"
           Write(Html.DisplayFor(modelItem => item.LocString));

#line default
#line hidden
            EndContext();
            BeginContext(3418, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 116 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\ViewRestaurantData_OrdersAndSales.cshtml"
}

#line default
#line hidden
            BeginContext(3457, 37, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3494, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "383bc6b4cbd9bad4885d56ca1064184de0295a9e19487", async() => {
                BeginContext(3529, 12, true);
                WriteLiteral("Back to Data");
                EndContext();
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
            EndContext();
            BeginContext(3545, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PizzaBoxClient.Models.OrderHistory>> Html { get; private set; }
    }
}
#pragma warning restore 1591
