#pragma checksum "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\PlaceOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c94832f96a7cc9d918ad4279d492793c330d4dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PlaceOrder), @"mvc.1.0.view", @"/Views/Home/PlaceOrder.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/PlaceOrder.cshtml", typeof(AspNetCore.Views_Home_PlaceOrder))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c94832f96a7cc9d918ad4279d492793c330d4dd", @"/Views/Home/PlaceOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"344545cdec7029661c59639aecae16d680e6af1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PlaceOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PizzaBoxClient.Models.OrderModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("control-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("min", new global::Microsoft.AspNetCore.Html.HtmlString("1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("max", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PlaceOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Locations", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\PlaceOrder.cshtml"
  
    Layout = "_LayoutAfter";
    ViewData["Title"] = "PlaceOrder";

#line default
#line hidden
            BeginContext(119, 33, true);
            WriteLiteral("\r\n<h1>PlaceOrder</h1>\r\n\r\n<hr />\r\n");
            EndContext();
            BeginContext(153, 16, false);
#line 11 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\PlaceOrder.cshtml"
Write(ViewData["Text"]);

#line default
#line hidden
            EndContext();
            BeginContext(169, 25, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    ");
            EndContext();
            BeginContext(194, 6812, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c94832f96a7cc9d918ad4279d492793c330d4dd7581", async() => {
                BeginContext(224, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(234, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c94832f96a7cc9d918ad4279d492793c330d4dd7971", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 14 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\PlaceOrder.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(300, 79, true);
                WriteLiteral("\r\n        <div class=\"form-group\">\r\n            <h4>Location</h4>\r\n            ");
                EndContext();
                BeginContext(380, 493, false);
#line 17 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\PlaceOrder.cshtml"
       Write(Html.DropDownList("Location", new List<SelectListItem> {
            new SelectListItem { Text = "Arlington", Value = "1", Selected = true },
            new SelectListItem { Text = "Dallas", Value = "2", Selected = false },
            new SelectListItem {Text = "Fort Worth", Value = "3", Selected = false},
            new SelectListItem {Text = "Houston", Value = "4", Selected = false},
            new SelectListItem {Text = "Austin", Value = "5", Selected = false},
            }));

#line default
#line hidden
                EndContext();
                BeginContext(873, 91, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <h4>Size</h4>\r\n            ");
                EndContext();
                BeginContext(965, 429, false);
#line 27 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\PlaceOrder.cshtml"
       Write(Html.DropDownList("Size", new List<SelectListItem> {
            new SelectListItem { Text = "Small", Value = "Small", Selected = true },
            new SelectListItem { Text = "Medium", Value = "Medium", Selected = false },
            new SelectListItem { Text = "Large", Value = "Large", Selected = false },
            new SelectListItem { Text = "Extra Large", Value = "Extra Large", Selected = false },
            }));

#line default
#line hidden
                EndContext();
                BeginContext(1394, 92, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <h4>Crust</h4>\r\n            ");
                EndContext();
                BeginContext(1487, 513, false);
#line 36 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\PlaceOrder.cshtml"
       Write(Html.DropDownList("Crust", new List<SelectListItem> {
            new SelectListItem { Text = "Hand-Tossed", Value = "Hand-Tossed", Selected = true },
            new SelectListItem { Text = "Thin", Value = "Thin", Selected = false },
            new SelectListItem { Text = "Pan", Value = "Pan", Selected = false },
            new SelectListItem { Text = "Thick", Value = "Thick", Selected = false },
            new SelectListItem { Text = "Stuffed", Value = "Stuffed", Selected = false },
            }));

#line default
#line hidden
                EndContext();
                BeginContext(2000, 96, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <h4>Topping 1</h4>\r\n            ");
                EndContext();
                BeginContext(2097, 813, false);
#line 46 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\PlaceOrder.cshtml"
       Write(Html.DropDownList("Topping1", new List<SelectListItem> {
            new SelectListItem { Text = "Pepperoni", Value = "Pepperoni", Selected = true },
            new SelectListItem { Text = "Sausage", Value = "Sausage", Selected = false },
            new SelectListItem { Text = "Bacon", Value = "Bacon", Selected = false },
            new SelectListItem { Text = "Pineapple", Value = "Pineapple", Selected = false },
            new SelectListItem { Text = "Mushrooms", Value = "Mushrooms", Selected = false },
            new SelectListItem { Text = "Onions", Value = "Onions", Selected = false },
            new SelectListItem { Text = "Extra Cheese", Value = "Extra Cheese", Selected = false },
            new SelectListItem { Text = "Olives", Value = "Olives", Selected = false },
            }));

#line default
#line hidden
                EndContext();
                BeginContext(2910, 96, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <h4>Topping 2</h4>\r\n            ");
                EndContext();
                BeginContext(3007, 813, false);
#line 59 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\PlaceOrder.cshtml"
       Write(Html.DropDownList("Topping2", new List<SelectListItem> {
            new SelectListItem { Text = "Pepperoni", Value = "Pepperoni", Selected = false },
            new SelectListItem { Text = "Sausage", Value = "Sausage", Selected = true },
            new SelectListItem { Text = "Bacon", Value = "Bacon", Selected = false },
            new SelectListItem { Text = "Pineapple", Value = "Pineapple", Selected = false },
            new SelectListItem { Text = "Mushrooms", Value = "Mushrooms", Selected = false },
            new SelectListItem { Text = "Onions", Value = "Onions", Selected = false },
            new SelectListItem { Text = "Extra Cheese", Value = "Extra Cheese", Selected = false },
            new SelectListItem { Text = "Olives", Value = "Olives", Selected = false },
            }));

#line default
#line hidden
                EndContext();
                BeginContext(3820, 96, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <h4>Topping 3</h4>\r\n            ");
                EndContext();
                BeginContext(3917, 818, false);
#line 72 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\PlaceOrder.cshtml"
       Write(Html.DropDownList("Topping3", new List<SelectListItem> {
            new SelectListItem { Text = "Pepperoni", Value = "Pepperoni", Selected = false },
            new SelectListItem { Text = "Sausage", Value = "Sausage", Selected = false },
            new SelectListItem { Text = "Bacon", Value = "Bacon", Selected = false },
            new SelectListItem { Text = "Pineapple", Value = "Pineapple", Selected = false },
            new SelectListItem { Text = "Mushrooms", Value = "Mushrooms", Selected = false },
            new SelectListItem { Text = "Onions", Value = "Onions", Selected = false },
            new SelectListItem { Text = "Extra Cheese", Value = "Extra Cheese", Selected = false },
            new SelectListItem { Text = "Olives", Value = "Olives", Selected = false },
            }, ""));

#line default
#line hidden
                EndContext();
                BeginContext(4735, 96, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <h4>Topping 4</h4>\r\n            ");
                EndContext();
                BeginContext(4832, 818, false);
#line 85 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\PlaceOrder.cshtml"
       Write(Html.DropDownList("Topping4", new List<SelectListItem> {
            new SelectListItem { Text = "Pepperoni", Value = "Pepperoni", Selected = false },
            new SelectListItem { Text = "Sausage", Value = "Sausage", Selected = false },
            new SelectListItem { Text = "Bacon", Value = "Bacon", Selected = false },
            new SelectListItem { Text = "Pineapple", Value = "Pineapple", Selected = false },
            new SelectListItem { Text = "Mushrooms", Value = "Mushrooms", Selected = false },
            new SelectListItem { Text = "Onions", Value = "Onions", Selected = false },
            new SelectListItem { Text = "Extra Cheese", Value = "Extra Cheese", Selected = false },
            new SelectListItem { Text = "Olives", Value = "Olives", Selected = false },
            }, ""));

#line default
#line hidden
                EndContext();
                BeginContext(5650, 96, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <h4>Topping 5</h4>\r\n            ");
                EndContext();
                BeginContext(5747, 818, false);
#line 98 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\PlaceOrder.cshtml"
       Write(Html.DropDownList("Topping5", new List<SelectListItem> {
            new SelectListItem { Text = "Pepperoni", Value = "Pepperoni", Selected = false },
            new SelectListItem { Text = "Sausage", Value = "Sausage", Selected = false },
            new SelectListItem { Text = "Bacon", Value = "Bacon", Selected = false },
            new SelectListItem { Text = "Pineapple", Value = "Pineapple", Selected = false },
            new SelectListItem { Text = "Mushrooms", Value = "Mushrooms", Selected = false },
            new SelectListItem { Text = "Onions", Value = "Onions", Selected = false },
            new SelectListItem { Text = "Extra Cheese", Value = "Extra Cheese", Selected = false },
            new SelectListItem { Text = "Olives", Value = "Olives", Selected = false },
            }, ""));

#line default
#line hidden
                EndContext();
                BeginContext(6565, 64, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
                EndContext();
                BeginContext(6629, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c94832f96a7cc9d918ad4279d492793c330d4dd19045", async() => {
                    BeginContext(6672, 8, true);
                    WriteLiteral("Quantity");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 110 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\PlaceOrder.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Qty);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6688, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(6702, 77, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4c94832f96a7cc9d918ad4279d492793c330d4dd20910", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 111 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\PlaceOrder.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Qty);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6779, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(6793, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c94832f96a7cc9d918ad4279d492793c330d4dd22898", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 112 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\PlaceOrder.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Qty);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6851, 148, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <input type=\"submit\" value=\"Create\" class=\"btn btn-primary\" />\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7006, 23, true);
            WriteLiteral("\r\n</div>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(7029, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c94832f96a7cc9d918ad4279d492793c330d4dd26145", async() => {
                BeginContext(7055, 12, true);
                WriteLiteral("Back to Home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7071, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(7101, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 125 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\PlaceOrder.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PizzaBoxClient.Models.OrderModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
