#pragma checksum "C:\Users\vmadmin\source\repos\WebApplication5\Views\Home\AddToCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52ab4011dae912fa284cab09d63ddafe63786cca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AddToCart), @"mvc.1.0.view", @"/Views/Home/AddToCart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/AddToCart.cshtml", typeof(AspNetCore.Views_Home_AddToCart))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52ab4011dae912fa284cab09d63ddafe63786cca", @"/Views/Home/AddToCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ac7a6a20369a094c1643b76f0e92e19ec3cef6a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AddToCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication5.Models.FoodMenu>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/StyleSheet.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/JavaScript.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\vmadmin\source\repos\WebApplication5\Views\Home\AddToCart.cshtml"
  
    ViewData["Title"] = "MenuDetails";

#line default
#line hidden
            BeginContext(102, 35, true);
            WriteLiteral("\r\n<h2>MenuDetails</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(137, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0dffd0da5b4a46c293f1721bfe8bb998", async() => {
                BeginContext(160, 10, true);
                WriteLiteral("Create New");
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
            BeginContext(174, 8, true);
            WriteLiteral("\r\n</p>\r\n");
            EndContext();
            BeginContext(182, 218, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f98cfc27920436c813d711bdd2051e9", async() => {
                BeginContext(188, 100, true);
                WriteLiteral("\r\n    <script src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js\"></script>\r\n    ");
                EndContext();
                BeginContext(288, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ff771d61dbc5486a8e047c8e5440f84e", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(341, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(347, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ff65a59ec76464dbcc5121db5e689c4", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(389, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(400, 88, true);
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(489, 42, false);
#line 23 "C:\Users\vmadmin\source\repos\WebApplication5\Views\Home\AddToCart.cshtml"
           Write(Html.DisplayNameFor(model => model.FoodId));

#line default
#line hidden
            EndContext();
            BeginContext(531, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(587, 44, false);
#line 26 "C:\Users\vmadmin\source\repos\WebApplication5\Views\Home\AddToCart.cshtml"
           Write(Html.DisplayNameFor(model => model.FoodName));

#line default
#line hidden
            EndContext();
            BeginContext(631, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(687, 41, false);
#line 29 "C:\Users\vmadmin\source\repos\WebApplication5\Views\Home\AddToCart.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(728, 21, true);
            WriteLiteral("\r\n            </th>\r\n");
            EndContext();
            BeginContext(861, 34, true);
            WriteLiteral("            <th>\r\n                ");
            EndContext();
            BeginContext(896, 41, false);
#line 35 "C:\Users\vmadmin\source\repos\WebApplication5\Views\Home\AddToCart.cshtml"
           Write(Html.DisplayNameFor(model => model.units));

#line default
#line hidden
            EndContext();
            BeginContext(937, 88, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n\r\n");
            EndContext();
#line 42 "C:\Users\vmadmin\source\repos\WebApplication5\Views\Home\AddToCart.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1074, 20, true);
            WriteLiteral("            <tr>\r\n\r\n");
            EndContext();
            BeginContext(1249, 86, true);
            WriteLiteral("                <td>\r\n                    <input type=\"text\" name=\"foodId\" id=\"foodId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1335, "\"", 1355, 1);
#line 51 "C:\Users\vmadmin\source\repos\WebApplication5\Views\Home\AddToCart.cshtml"
WriteAttributeValue("", 1343, item.FoodId, 1343, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1356, 120, true);
            WriteLiteral(" />\r\n\r\n                </td>\r\n                <td>\r\n                    <input type=\"text\" name=\"foodname\" id=\"foodname\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1476, "\"", 1498, 1);
#line 55 "C:\Users\vmadmin\source\repos\WebApplication5\Views\Home\AddToCart.cshtml"
WriteAttributeValue("", 1484, item.FoodName, 1484, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1499, 114, true);
            WriteLiteral(" />\r\n\r\n                </td>\r\n                <td>\r\n                    <input type=\"text\" name=\"price\" id=\"price\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1613, "\"", 1632, 1);
#line 59 "C:\Users\vmadmin\source\repos\WebApplication5\Views\Home\AddToCart.cshtml"
WriteAttributeValue("", 1621, item.Price, 1621, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1633, 790, true);
            WriteLiteral(@" />

                </td>


                <td>

                    <div class=""quantity"">

                        <button class=""minus-btn"" id=""subs"" type=""button"" name=""button"" value=""-"" onclick=""subst()"">
                            -
                        </button>
                        <input type=""text"" name=""units"" id=""units"" value="""" />

                        <button class=""plus-btn"" id=""plus"" type=""button"" name=""button"" value=""+"" onclick=""add()"">
                            +
                        </button>

                        <button id=""btnGet"" type=""submit"" formaction=""/home/AddedToCart"">
                            Add
                        </button>

                    </div>



                </td>
            </tr>
");
            EndContext();
#line 87 "C:\Users\vmadmin\source\repos\WebApplication5\Views\Home\AddToCart.cshtml"
        }

#line default
#line hidden
            BeginContext(2434, 28, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication5.Models.FoodMenu>> Html { get; private set; }
    }
}
#pragma warning restore 1591
