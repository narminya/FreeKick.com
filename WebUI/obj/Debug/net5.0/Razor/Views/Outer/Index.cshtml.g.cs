#pragma checksum "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Outer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f2ead20b9e68fc467354604dc2a25e2e9d515f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Outer_Index), @"mvc.1.0.view", @"/Views/Outer/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f2ead20b9e68fc467354604dc2a25e2e9d515f8", @"/Views/Outer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b8f636cf884d69615ad6fe82e7276464b982db8", @"/Views/_ViewImports.cshtml")]
    public class Views_Outer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<LeagueStandingViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Team", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Outer\Index.cshtml"
  
    ViewData["Title"] = "Index";
    var i = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\" actions-y\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12 d-flex align-items-center\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6f2ead20b9e68fc467354604dc2a25e2e9d515f85154", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 272, "~/assets/img/titleImages/", 272, 25, true);
#nullable restore
#line 11 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Outer\Index.cshtml"
AddHtmlAttributeValue("", 297, Model, 297, 6, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 303, ".", 303, 1, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <h2 class=\"text-light ml-3\">Premier</h2>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"buttons p-30\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-4 col-sm-12\"><a");
            BeginWriteAttribute("href", " href=\"", 553, "\"", 560, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"team-btn active\">News</a></div>\r\n            <div class=\"col-lg-4 col-sm-12\"><a");
            BeginWriteAttribute("href", " href=\"", 648, "\"", 655, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"team-btn\">Matches</a></div>\r\n            <div class=\"col-lg-4 col-sm-12\"><a");
            BeginWriteAttribute("href", " href=\"", 739, "\"", 746, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"team-btn\">Standings</a></div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"league-standing-table p-50\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 29 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Outer\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-8\">\r\n\r\n                    <div class=\"table-ms\">\r\n                        <p class=\"group\">Group <span>");
#nullable restore
#line 34 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Outer\Index.cshtml"
                                                Write(item.Group.Letter);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></p>
                        <div class=""title-head d-flex justify-content-between"">
                            <div class=""pos-left"">
                                <span class=""position"">Pos</span> <span class=""team"">Team</span>
                            </div><span class=""points"">PTS</span>
                        </div>
                        <ul class=""list-t"">
");
#nullable restore
#line 41 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Outer\Index.cshtml"
                             foreach (var team in item.Teams)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f2ead20b9e68fc467354604dc2a25e2e9d515f89279", async() => {
                WriteLiteral("\r\n                                        <div class=\"team-left outer\">\r\n                                            <span class=\"t-pos\">");
#nullable restore
#line 46 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Outer\Index.cshtml"
                                                            Write(i++);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                            <img");
                BeginWriteAttribute("src", " src=\"", 1958, "\"", 1992, 2);
                WriteAttributeValue("", 1964, "/assets/img/teams/", 1964, 18, true);
#nullable restore
#line 47 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Outer\Index.cshtml"
WriteAttributeValue("", 1982, team.Logo, 1982, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 1993, "\"", 1999, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                            <p class=\"t-name\">");
#nullable restore
#line 48 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Outer\Index.cshtml"
                                                         Write(team.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                        </div>\r\n                                        <p>");
#nullable restore
#line 50 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Outer\Index.cshtml"
                                      Write(team.Points);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Outer\Index.cshtml"
                                         WriteLiteral(team.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                \r\n                                </li>\r\n");
#nullable restore
#line 54 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Outer\Index.cshtml"
                                 if (i == item.Teams.Count + 1)
                                {
                                    i = 1;
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Outer\Index.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 63 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Outer\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<LeagueStandingViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
