#pragma checksum "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\Locations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f3918388c1125aeabb140b6d1677fba93f3fcd0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Locations), @"mvc.1.0.view", @"/Views/Home/Locations.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Locations.cshtml", typeof(AspNetCore.Views_Home_Locations))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f3918388c1125aeabb140b6d1677fba93f3fcd0", @"/Views/Home/Locations.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"344545cdec7029661c59639aecae16d680e6af1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Locations : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PizzaBoxClient.Models.StoreInform>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\Locations.cshtml"
  
    ViewData["Title"] = "Locations";
    Layout = "_LayoutAfter";

#line default
#line hidden
            BeginContext(132, 108, true);
            WriteLiteral("\r\n<h1>Locations</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(241, 40, false);
#line 14 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\Locations.cshtml"
           Write(Html.DisplayNameFor(model => model.Add1));

#line default
#line hidden
            EndContext();
            BeginContext(281, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(337, 40, false);
#line 17 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\Locations.cshtml"
           Write(Html.DisplayNameFor(model => model.Add2));

#line default
#line hidden
            EndContext();
            BeginContext(377, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(433, 40, false);
#line 20 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\Locations.cshtml"
           Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(473, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(529, 41, false);
#line 23 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\Locations.cshtml"
           Write(Html.DisplayNameFor(model => model.State));

#line default
#line hidden
            EndContext();
            BeginContext(570, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(626, 43, false);
#line 26 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\Locations.cshtml"
           Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
            EndContext();
            BeginContext(669, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(725, 43, false);
#line 29 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\Locations.cshtml"
           Write(Html.DisplayNameFor(model => model.ZipCode));

#line default
#line hidden
            EndContext();
            BeginContext(768, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 35 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\Locations.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(903, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(964, 39, false);
#line 39 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\Locations.cshtml"
               Write(Html.DisplayFor(modelItem => item.Add1));

#line default
#line hidden
            EndContext();
            BeginContext(1003, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1071, 39, false);
#line 42 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\Locations.cshtml"
               Write(Html.DisplayFor(modelItem => item.Add2));

#line default
#line hidden
            EndContext();
            BeginContext(1110, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1178, 39, false);
#line 45 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\Locations.cshtml"
               Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
            EndContext();
            BeginContext(1217, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1285, 40, false);
#line 48 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\Locations.cshtml"
               Write(Html.DisplayFor(modelItem => item.State));

#line default
#line hidden
            EndContext();
            BeginContext(1325, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1393, 42, false);
#line 51 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\Locations.cshtml"
               Write(Html.DisplayFor(modelItem => item.Country));

#line default
#line hidden
            EndContext();
            BeginContext(1435, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1503, 42, false);
#line 54 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\Locations.cshtml"
               Write(Html.DisplayFor(modelItem => item.ZipCode));

#line default
#line hidden
            EndContext();
            BeginContext(1545, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1613, 73, false);
#line 57 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\Locations.cshtml"
               Write(Html.ActionLink("View Data", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1686, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 60 "C:\Revature\Project1\Coombs_Daniel_Project1\PizzaBoxSolution\PizzaBoxClient\Views\Home\Locations.cshtml"
        }

#line default
#line hidden
            BeginContext(1741, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PizzaBoxClient.Models.StoreInform>> Html { get; private set; }
    }
}
#pragma warning restore 1591
