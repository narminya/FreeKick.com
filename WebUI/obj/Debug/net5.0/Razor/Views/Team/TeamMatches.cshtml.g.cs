#pragma checksum "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Team\TeamMatches.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38ec3ad942e0d7ff459d7347e19894ea9744cb26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Team_TeamMatches), @"mvc.1.0.view", @"/Views/Team/TeamMatches.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38ec3ad942e0d7ff459d7347e19894ea9744cb26", @"/Views/Team/TeamMatches.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b8f636cf884d69615ad6fe82e7276464b982db8", @"/Views/_ViewImports.cshtml")]
    public class Views_Team_TeamMatches : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TeamsMatchesViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_TeamPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Team\TeamMatches.cshtml"
  
    ViewData["Title"] = "TeamMatches";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "38ec3ad942e0d7ff459d7347e19894ea9744cb264161", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 5 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Team\TeamMatches.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.Team;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<section class=\"team-matches p-50\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-8\">\r\n                <div class=\"table-ms\">\r\n                    <div class=\"title-head d-flex\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 378, "\"", 385, 0);
            EndWriteAttribute();
            WriteLiteral(">All</a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 422, "\"", 429, 0);
            EndWriteAttribute();
            WriteLiteral(">UEFA Champions League</a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 484, "\"", 491, 0);
            EndWriteAttribute();
            WriteLiteral(">Premier League</a>\r\n                    </div>\r\n                    <div class=\"match-list\">\r\n");
#nullable restore
#line 17 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Team\TeamMatches.cshtml"
                         foreach (var item in Model.Matches)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"match-t\">\r\n\r\n");
#nullable restore
#line 21 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Team\TeamMatches.cshtml"
                                 if (item.Date < DateTime.Now)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"match-status\">\r\n                                        FT\r\n                                    </div>\r\n");
#nullable restore
#line 25 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Team\TeamMatches.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <div class=\"match-status\">\r\n                                        ");
#nullable restore
#line 28 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Team\TeamMatches.cshtml"
                                   Write(item.Date.ToShortTimeString());

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                                    </div>          ");
#nullable restore
#line 29 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Team\TeamMatches.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <div class=\"match-data\">\r\n                                    <p class=\"team-home\">");
#nullable restore
#line 32 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Team\TeamMatches.cshtml"
                                                    Write(item.Home.TeamName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <div class=\"goals d-flex \">\r\n                                        <div class=\"match-result\">\r\n                                            <div class=\"goals-home\">");
#nullable restore
#line 35 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Team\TeamMatches.cshtml"
                                                               Write(item.Home.TeamScore);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                            <span>-</span>\r\n                                            <div class=\"goals-away\">");
#nullable restore
#line 37 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Team\TeamMatches.cshtml"
                                                               Write(item.Away.TeamScore);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                        </div>\r\n\r\n                                    </div>\r\n                                    <p class=\"team-away\">");
#nullable restore
#line 41 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Team\TeamMatches.cshtml"
                                                    Write(item.Away.TeamName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 44 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Team\TeamMatches.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-4\">\r\n                <img src=\"/assets/img/jawn300x500.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 2177, "\"", 2183, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TeamsMatchesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
