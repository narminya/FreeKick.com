#pragma checksum "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Shared\Components\Header\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56ea1294c37e6331b99bb143ec51e13a95b21bc1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Header_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Header/Default.cshtml")]
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
#line 2 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\_ViewImports.cshtml"
using WebUI.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\_ViewImports.cshtml"
using WebUI.Models.ViewModels.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\_ViewImports.cshtml"
using Domain.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\_ViewImports.cshtml"
using Domain.Constants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\_ViewImports.cshtml"
using Domain.Dto;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56ea1294c37e6331b99bb143ec51e13a95b21bc1", @"/Views/Shared/Components/Header/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b8f636cf884d69615ad6fe82e7276464b982db8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Header_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HeaderViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/Untitled-2.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropmenu"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Shared\Components\Header\Default.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<header>\r\n    <nav class=\"navigation\">\r\n        <div class=\"logo\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 135, "\"", 142, 0);
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "56ea1294c37e6331b99bb143ec51e13a95b21bc15403", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n        </div>\r\n        <ul class=\"nav-links\">\r\n");
#nullable restore
#line 12 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Shared\Components\Header\Default.cshtml"
             foreach (var item in Model.Parents)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n");
#nullable restore
#line 15 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Shared\Components\Header\Default.cshtml"
                 if (item.Controller != null)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56ea1294c37e6331b99bb143ec51e13a95b21bc17174", async() => {
#nullable restore
#line 18 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Shared\Components\Header\Default.cshtml"
                                                                                                     Write(item.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 18 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Shared\Components\Header\Default.cshtml"
                                              WriteLiteral(item.Controller);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 18 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Shared\Components\Header\Default.cshtml"
                                                                               WriteLiteral(item.Action);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 19 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Shared\Components\Header\Default.cshtml"
                }
                else
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a class=\"dropmenu\">");
#nullable restore
#line 23 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Shared\Components\Header\Default.cshtml"
                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 24 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Shared\Components\Header\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 26 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Shared\Components\Header\Default.cshtml"
                 if (item.Children != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<ul class=\" dropdown mega\">\r\n                        <div class=\"container\">\r\n                            <div class=\"row justify-content-center dropdown-row\">\r\n");
#nullable restore
#line 30 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Shared\Components\Header\Default.cshtml"
                                 foreach (var child in item.Children)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"col-lg-4 col-sm-12\">\r\n                                        <div class=\"sub-menu-heading bold\">");
#nullable restore
#line 33 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Shared\Components\Header\Default.cshtml"
                                                                      Write(child.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                    </div>\r\n");
#nullable restore
#line 35 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Shared\Components\Header\Default.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n                    </ul>\r\n");
#nullable restore
#line 39 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Shared\Components\Header\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </li>\r\n");
#nullable restore
#line 43 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Shared\Components\Header\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </ul>
        <div class=""burger-s"">
            <a class=""burger burger-unclick"">
                <span class=""unclick""></span>
            </a>
        </div>

    </nav>
</header>





































");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HeaderViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
