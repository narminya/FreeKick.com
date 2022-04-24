#pragma checksum "C:\Users\afsana.mammadova\source\repos\FreeKick\WebUI\Views\League\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4015ea0c60d5ab12e97fa7c9b85603bf561c3d2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_League_Index), @"mvc.1.0.view", @"/Views/League/Index.cshtml")]
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
#line 2 "C:\Users\afsana.mammadova\source\repos\FreeKick\WebUI\Views\_ViewImports.cshtml"
using WebUI.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\afsana.mammadova\source\repos\FreeKick\WebUI\Views\_ViewImports.cshtml"
using Domain.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\afsana.mammadova\source\repos\FreeKick\WebUI\Views\_ViewImports.cshtml"
using Domain.Constants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\afsana.mammadova\source\repos\FreeKick\WebUI\Views\_ViewImports.cshtml"
using Domain.Dto;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4015ea0c60d5ab12e97fa7c9b85603bf561c3d2d", @"/Views/League/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef65e3e78ef6325a9f9aee1ef466c7e65a012d84", @"/Views/_ViewImports.cshtml")]
    public class Views_League_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LeagueStandingViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\afsana.mammadova\source\repos\FreeKick\WebUI\Views\League\Index.cshtml"
   
    int i = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\" actions-y py-100\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12 d-flex align-items-center\">\r\n                <img");
            BeginWriteAttribute("alt", " alt=\"", 225, "\"", 231, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <h2 class=\"text-light ml-3\">");
#nullable restore
#line 10 "C:\Users\afsana.mammadova\source\repos\FreeKick\WebUI\Views\League\Index.cshtml"
                                       Write(Model.League.LeagueName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"buttons p-30\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-4 col-sm-12\"><a");
            BeginWriteAttribute("href", " href=\"", 496, "\"", 503, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"team-btn active\">News</a></div>\r\n            <div class=\"col-lg-4 col-sm-12\"><a");
            BeginWriteAttribute("href", " href=\"", 591, "\"", 598, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"team-btn\">Matches</a></div>\r\n            <div class=\"col-lg-4 col-sm-12\"><a");
            BeginWriteAttribute("href", " href=\"", 682, "\"", 689, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""team-btn"">Standings</a></div>
        </div>
    </div>
</div>
<div class=""league-standing-table p-50"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-8"">
                <h6 class=""text-gray bg-light p-2"">LIVE TABLE</h6>
                <div class=""table-ms"">
                    <div class=""title-head d-flex justify-content-between"">
                        <div class=""pos-left"">
                            <span class=""position"">Pos</span> <span class=""team"">Team</span>
                        </div><span class=""points"">PTS</span>
                    </div>
                    <ul class=""list-t"">
");
#nullable restore
#line 36 "C:\Users\afsana.mammadova\source\repos\FreeKick\WebUI\Views\League\Index.cshtml"
                         foreach (var item in Model.Teams)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li>\r\n                            <div class=\"team-left\">\r\n                                <span class=\"t-pos\">");
#nullable restore
#line 40 "C:\Users\afsana.mammadova\source\repos\FreeKick\WebUI\Views\League\Index.cshtml"
                                                Write(i++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 1631, "\"", 1665, 2);
            WriteAttributeValue("", 1637, "/assets/img/teams/", 1637, 18, true);
#nullable restore
#line 41 "C:\Users\afsana.mammadova\source\repos\FreeKick\WebUI\Views\League\Index.cshtml"
WriteAttributeValue("", 1655, item.Logo, 1655, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1666, "\"", 1672, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <p class=\"t-name\">");
#nullable restore
#line 42 "C:\Users\afsana.mammadova\source\repos\FreeKick\WebUI\Views\League\Index.cshtml"
                                             Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                            <p>");
#nullable restore
#line 44 "C:\Users\afsana.mammadova\source\repos\FreeKick\WebUI\Views\League\Index.cshtml"
                          Write(item.Points);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </li>\r\n");
#nullable restore
#line 46 "C:\Users\afsana.mammadova\source\repos\FreeKick\WebUI\Views\League\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        \r\n                    </ul>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LeagueStandingViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
