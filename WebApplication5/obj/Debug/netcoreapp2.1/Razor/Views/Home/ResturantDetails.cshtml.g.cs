#pragma checksum "C:\Users\vmadmin\source\repos\WebApplication5\Views\Home\ResturantDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a63c2a4225106e728ddcb5e73c7cc49d9a92df26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ResturantDetails), @"mvc.1.0.view", @"/Views/Home/ResturantDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ResturantDetails.cshtml", typeof(AspNetCore.Views_Home_ResturantDetails))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a63c2a4225106e728ddcb5e73c7cc49d9a92df26", @"/Views/Home/ResturantDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ac7a6a20369a094c1643b76f0e92e19ec3cef6a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ResturantDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication5.Models.TblResturant>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\vmadmin\source\repos\WebApplication5\Views\Home\ResturantDetails.cshtml"
  
    ViewData["Title"] = "ResturantDetails";

#line default
#line hidden
            BeginContext(111, 83, true);
            WriteLiteral("\r\n<h2>ResturantDetails</h2>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n");
            EndContext();
            BeginContext(296, 34, true);
            WriteLiteral("            <th>\r\n                ");
            EndContext();
            BeginContext(331, 44, false);
#line 17 "C:\Users\vmadmin\source\repos\WebApplication5\Views\Home\ResturantDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.RestName));

#line default
#line hidden
            EndContext();
            BeginContext(375, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(431, 44, false);
#line 20 "C:\Users\vmadmin\source\repos\WebApplication5\Views\Home\ResturantDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.Location));

#line default
#line hidden
            EndContext();
            BeginContext(475, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(531, 44, false);
#line 23 "C:\Users\vmadmin\source\repos\WebApplication5\Views\Home\ResturantDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.Distance));

#line default
#line hidden
            EndContext();
            BeginContext(575, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(631, 42, false);
#line 26 "C:\Users\vmadmin\source\repos\WebApplication5\Views\Home\ResturantDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(673, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(729, 42, false);
#line 29 "C:\Users\vmadmin\source\repos\WebApplication5\Views\Home\ResturantDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.Budget));

#line default
#line hidden
            EndContext();
            BeginContext(771, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 35 "C:\Users\vmadmin\source\repos\WebApplication5\Views\Home\ResturantDetails.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(889, 14, true);
            WriteLiteral("        <tr>\r\n");
            EndContext();
            BeginContext(1004, 38, true);
            WriteLiteral("            <td>\r\n\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1042, "\"", 1079, 2);
            WriteAttributeValue("", 1049, "/Home/MenuDetails/", 1049, 18, true);
#line 42 "C:\Users\vmadmin\source\repos\WebApplication5\Views\Home\ResturantDetails.cshtml"
WriteAttributeValue("", 1067, item.RestId, 1067, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1080, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1082, 43, false);
#line 42 "C:\Users\vmadmin\source\repos\WebApplication5\Views\Home\ResturantDetails.cshtml"
                                                    Write(Html.DisplayFor(modelItem => item.RestName));

#line default
#line hidden
            EndContext();
            BeginContext(1125, 59, true);
            WriteLiteral("</a>\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1185, 43, false);
#line 45 "C:\Users\vmadmin\source\repos\WebApplication5\Views\Home\ResturantDetails.cshtml"
           Write(Html.DisplayFor(modelItem => item.Location));

#line default
#line hidden
            EndContext();
            BeginContext(1228, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1284, 43, false);
#line 48 "C:\Users\vmadmin\source\repos\WebApplication5\Views\Home\ResturantDetails.cshtml"
           Write(Html.DisplayFor(modelItem => item.Distance));

#line default
#line hidden
            EndContext();
            BeginContext(1327, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1383, 41, false);
#line 51 "C:\Users\vmadmin\source\repos\WebApplication5\Views\Home\ResturantDetails.cshtml"
           Write(Html.DisplayFor(modelItem => item.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(1424, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1480, 41, false);
#line 54 "C:\Users\vmadmin\source\repos\WebApplication5\Views\Home\ResturantDetails.cshtml"
           Write(Html.DisplayFor(modelItem => item.Budget));

#line default
#line hidden
            EndContext();
            BeginContext(1521, 47, true);
            WriteLiteral("\r\n            </td>\r\n         \r\n        </tr>\r\n");
            EndContext();
#line 58 "C:\Users\vmadmin\source\repos\WebApplication5\Views\Home\ResturantDetails.cshtml"
}

#line default
#line hidden
            BeginContext(1571, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication5.Models.TblResturant>> Html { get; private set; }
    }
}
#pragma warning restore 1591