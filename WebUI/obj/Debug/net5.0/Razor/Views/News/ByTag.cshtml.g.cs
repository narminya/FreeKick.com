#pragma checksum "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\News\ByTag.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66e2cc75d1fdc37f42e73de30c959b95c34cdeb6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_ByTag), @"mvc.1.0.view", @"/Views/News/ByTag.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66e2cc75d1fdc37f42e73de30c959b95c34cdeb6", @"/Views/News/ByTag.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b8f636cf884d69615ad6fe82e7276464b982db8", @"/Views/_ViewImports.cshtml")]
    public class Views_News_ByTag : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<NewsViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "News", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\News\ByTag.cshtml"
  
    ViewData["Title"] = "ByTag";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\" actions-y py-100\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12 d-flex align-items-center\">\r\n                <h2 class=\"text-light ml-3\">");
#nullable restore
#line 10 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\News\ByTag.cshtml"
                                       Write(ViewBag.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<section class=\"hero-news\" style=\"padding-top:25px\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-8\">\r\n                <div class=\"row\">\r\n");
#nullable restore
#line 21 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\News\ByTag.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-6 col-sm-12\">\r\n                            <div class=\"news-card\"");
            BeginWriteAttribute("style", "\r\n                                 style=\"", 702, "\"", 797, 4);
            WriteAttributeValue(" ", 744, "background-image:", 745, 18, true);
            WriteAttributeValue(" ", 762, "url(/assets/img/", 763, 17, true);
#nullable restore
#line 25 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\News\ByTag.cshtml"
WriteAttributeValue("", 779, item.News.Image, 779, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 795, ");", 795, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66e2cc75d1fdc37f42e73de30c959b95c34cdeb66230", async() => {
                WriteLiteral("\r\n                                    <h5 class=\"nc-title\">\r\n                                        ");
#nullable restore
#line 28 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\News\ByTag.cshtml"
                                   Write(item.News.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </h5>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 26 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\News\ByTag.cshtml"
                                                                              WriteLiteral(item.News.Id);

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
            WriteLiteral("\r\n\r\n                                <div class=\"tags\">\r\n                                    <ul class=\"tags-list\">\r\n");
#nullable restore
#line 34 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\News\ByTag.cshtml"
                                         foreach (var tag in item.Tags)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li><a class=\"tag\"");
            BeginWriteAttribute("href", " href=\"", 1398, "\"", 1405, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 36 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\News\ByTag.cshtml"
                                                                  Write(tag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 37 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\News\ByTag.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </ul>
                                </div>
                                <div class=""actions"">
                                    <span class=""view-count"">12</span><i class=""fas fa-eye""></i>
                                </div>
                            </div>
                        </div>
");
#nullable restore
#line 46 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\News\ByTag.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<NewsViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
