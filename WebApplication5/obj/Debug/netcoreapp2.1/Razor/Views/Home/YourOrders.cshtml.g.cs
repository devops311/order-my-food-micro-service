#pragma checksum "C:\Users\vmadmin\source\repos\WebApplication5\Views\Home\YourOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad368f3e1042352403467204e56f3c8cef4169bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_YourOrders), @"mvc.1.0.view", @"/Views/Home/YourOrders.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/YourOrders.cshtml", typeof(AspNetCore.Views_Home_YourOrders))]
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
#line 1 "C:\Users\vmadmin\source\repos\WebApplication5\Views\_ViewImports.cshtml"
using WebApplication5;

#line default
#line hidden
#line 2 "C:\Users\vmadmin\source\repos\WebApplication5\Views\_ViewImports.cshtml"
using WebApplication5.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad368f3e1042352403467204e56f3c8cef4169bd", @"/Views/Home/YourOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ac7a6a20369a094c1643b76f0e92e19ec3cef6a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_YourOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication5.Models.orderDetails>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\vmadmin\source\repos\WebApplication5\Views\Home\YourOrders.cshtml"
  
    ViewData["Title"] = "YourOrders";

#line default
#line hidden
            BeginContext(105, 111, true);
            WriteLiteral("\r\n<h2>YourOrders</h2>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(217, 43, false);
#line 14 "C:\Users\vmadmin\source\repos\WebApplication5\Views\Home\YourOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderId));

#line default
#line hidden
            EndContext();
            BeginContext(260, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(316, 44, false);
#line 17 "C:\Users\vmadmin\source\repos\WebApplication5\Views\Home\YourOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.FoodName));

#line default
#line hidden
            EndContext();
            BeginContext(360, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(416, 41, false);
#line 20 "C:\Users\vmadmin\source\repos\WebApplication5\Views\Home\YourOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.Units));

#line default
#line hidden
            EndContext();
            BeginContext(457, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(513, 46, false);
#line 23 "C:\Users\vmadmin\source\repos\WebApplication5\Views\Home\YourOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.TotalPrice));

#line default
#line hidden
            EndContext();
            BeginContext(559, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(615, 48, false);
#line 26 "C:\Users\vmadmin\source\repos\WebApplication5\Views\Home\YourOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(663, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(719, 45, false);
#line 29 "C:\Users\vmadmin\source\repos\WebApplication5\Views\Home\YourOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.ContactNo));

#line default
#line hidden
            EndContext();
            BeginContext(764, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(820, 43, false);
#line 32 "C:\Users\vmadmin\source\repos\WebApplication5\Views\Home\YourOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(863, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(919, 45, false);
#line 35 "C:\Users\vmadmin\source\repos\WebApplication5\Views\Home\YourOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderDate));

#line default
#line hidden
            EndContext();
            BeginContext(964, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1020, 42, false);
#line 38 "C:\Users\vmadmin\source\repos\WebApplication5\Views\Home\YourOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1062, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1118, 41, false);
#line 41 "C:\Users\vmadmin\source\repos\WebApplication5\Views\Home\YourOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1159, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 47 "C:\Users\vmadmin\source\repos\WebApplication5\Views\Home\YourOrders.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1277, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1326, 42, false);
#line 50 "C:\Users\vmadmin\source\repos\WebApplication5\Views\Home\YourOrders.cshtml"
           Write(Html.DisplayFor(modelItem => item.OrderId));

#line default
#line hidden
            EndContext();
            BeginContext(1368, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1424, 43, false);
#line 53 "C:\Users\vmadmin\source\repos\WebApplication5\Views\Home\YourOrders.cshtml"
           Write(Html.DisplayFor(modelItem => item.FoodName));

#line default
#line hidden
            EndContext();
            BeginContext(1467, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1523, 40, false);
#line 56 "C:\Users\vmadmin\source\repos\WebApplication5\Views\Home\YourOrders.cshtml"
           Write(Html.DisplayFor(modelItem => item.Units));

#line default
#line hidden
            EndContext();
            BeginContext(1563, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1619, 45, false);
#line 59 "C:\Users\vmadmin\source\repos\WebApplication5\Views\Home\YourOrders.cshtml"
           Write(Html.DisplayFor(modelItem => item.TotalPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1664, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1720, 47, false);
#line 62 "C:\Users\vmadmin\source\repos\WebApplication5\Views\Home\YourOrders.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(1767, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1823, 44, false);
#line 65 "C:\Users\vmadmin\source\repos\WebApplication5\Views\Home\YourOrders.cshtml"
           Write(Html.DisplayFor(modelItem => item.ContactNo));

#line default
#line hidden
            EndContext();
            BeginContext(1867, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1923, 42, false);
#line 68 "C:\Users\vmadmin\source\repos\WebApplication5\Views\Home\YourOrders.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1965, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2021, 44, false);
#line 71 "C:\Users\vmadmin\source\repos\WebApplication5\Views\Home\YourOrders.cshtml"
           Write(Html.DisplayFor(modelItem => item.OrderDate));

#line default
#line hidden
            EndContext();
            BeginContext(2065, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2121, 41, false);
#line 74 "C:\Users\vmadmin\source\repos\WebApplication5\Views\Home\YourOrders.cshtml"
           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2162, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2218, 40, false);
#line 77 "C:\Users\vmadmin\source\repos\WebApplication5\Views\Home\YourOrders.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2258, 57, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2315, "\"", 2354, 2);
            WriteAttributeValue("", 2322, "/Home/GiveFeedback/", 2322, 19, true);
#line 80 "C:\Users\vmadmin\source\repos\WebApplication5\Views\Home\YourOrders.cshtml"
WriteAttributeValue("", 2341, item.OrderId, 2341, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2355, 20, true);
            WriteLiteral(">Give Comments</a>\r\n");
            EndContext();
            BeginContext(2457, 109, true);
            WriteLiteral("                <a href=\"/Home/ViewFeedback\">View FeedBack</a>\r\n            </td>\r\n         \r\n        </tr>\r\n");
            EndContext();
#line 86 "C:\Users\vmadmin\source\repos\WebApplication5\Views\Home\YourOrders.cshtml"
}

#line default
#line hidden
            BeginContext(2569, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication5.Models.orderDetails>> Html { get; private set; }
    }
}
#pragma warning restore 1591
