#pragma checksum "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8c9aceab64c3a46796d38680d6b1439b775e5f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Match_Index), @"mvc.1.0.view", @"/Views/Match/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8c9aceab64c3a46796d38680d6b1439b775e5f6", @"/Views/Match/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b8f636cf884d69615ad6fe82e7276464b982db8", @"/Views/_ViewImports.cshtml")]
    public class Views_Match_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MatchStatsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("sendMess"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("event"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/plugins/microsoft-signalr/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"
  
    ViewData["Title"] = "Index";


#line default
#line hidden
#nullable disable
            DefineSection("style", async() => {
                WriteLiteral(@"
    <style>
        label > img {
            width: 20px;
        }

        .goals {
            max-height: 150px
        }

            .goals li {
                font-size: 12px;
                color: #ffffff;
            }

                .goals li span {
                    color: #808080;
                }
    </style>


");
            }
            );
            WriteLiteral("<section class=\"match-summary py-50\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-4 col-sm-12 match-summary\">\r\n                <div class=\"match-team\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 666, "\"", 717, 2);
            WriteAttributeValue("", 672, "/assets/img/teams/", 672, 18, true);
#nullable restore
#line 33 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"
WriteAttributeValue("", 690, Model.Match.Home.TeamImage, 690, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 718, "\"", 724, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <h5>");
#nullable restore
#line 34 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"
                   Write(Model.Match.Home.TeamName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p class=\"text-light\">");
#nullable restore
#line 35 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"
                                     Write(Model.Match.Home.TeamCoach);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <ul class=\"goals\">\r\n");
#nullable restore
#line 37 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"
                         foreach (var item in Model.Match.HomeGoals)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li> ");
#nullable restore
#line 40 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"
                            Write(item.Minute);

#line default
#line hidden
#nullable disable
            WriteLiteral("\' <span>");
#nullable restore
#line 40 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"
                                                Write(item.Player);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n");
#nullable restore
#line 41 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-4 col-sm-12 match-summary match-team-state\">\r\n                <div class=\"match-team-state\">\r\n                    <div class=\"match-date\"> <span>");
#nullable restore
#line 48 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"
                                              Write(Model.Match.Date.ToString("d MMMM HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n                    <div class=\"matchboard\">\r\n                        <span class=\"matchboard__card\">\r\n                            <span class=\"matchboard__card-game\">\r\n\r\n                                ");
#nullable restore
#line 53 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"
                           Write(Model.Match.Home.TeamScore);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </span>
                        </span>
                        <span class=""matchboard__hyphen"">
                        </span><span class=""matchboard__card matchboard__card--no_margin"">
                            <span class=""matchboard__card-game"">");
#nullable restore
#line 58 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"
                                                           Write(Model.Match.Away.TeamScore);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </span>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-4 col-sm-12 match-summary\">\r\n                <div class=\"match-team\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 2195, "\"", 2246, 2);
            WriteAttributeValue("", 2201, "/assets/img/teams/", 2201, 18, true);
#nullable restore
#line 65 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"
WriteAttributeValue("", 2219, Model.Match.Away.TeamImage, 2219, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2247, "\"", 2253, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <h5>");
#nullable restore
#line 66 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"
                   Write(Model.Match.Away.TeamName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p class=\"text-light\">");
#nullable restore
#line 67 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"
                                     Write(Model.Match.Away.TeamCoach);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <ul class=\"goals\">\r\n");
#nullable restore
#line 69 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"
                         foreach (var item in Model.Match.AwayGoals)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li> ");
#nullable restore
#line 72 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"
                            Write(item.Minute);

#line default
#line hidden
#nullable disable
            WriteLiteral("\' <span>");
#nullable restore
#line 72 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"
                                                Write(item.Player);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n");
#nullable restore
#line 73 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </ul>
                </div>
            </div>
        </div>
    </div>
</section>
<section class=""match-broadcast py-50"">
    <div class=""container"">
        <div class=""row"">
            <h4 class=""match-broadcast-title"">Live broadcast of ");
#nullable restore
#line 84 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"
                                                           Write(Model.Match.Home.TeamName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" vs ");
#nullable restore
#line 84 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"
                                                                                         Write(Model.Match.Away.TeamName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            <div class=\"col-lg-8 col-sm-12\">\r\n                <div class=\"live-broadvast\">\r\n");
#nullable restore
#line 87 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"
                     foreach (var item in Model.Comments)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"event\">\r\n                            <div class=\"event-match-time\">\r\n                                <div class=\"event-time\">\r\n                                    <span class=\"event-time-text\">");
#nullable restore
#line 93 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"
                                                             Write(item.Minute);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"'</span>
                                </div>
                            </div>
                            <div class=""event-picture"">
                            </div>
                            <div class=""event-description"">
                                ");
#nullable restore
#line 99 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"
                           Write(item.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 102 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n            <div class=\"col-lg-4 col-sm-12\">\r\n                <div class=\"mb-3\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8c9aceab64c3a46796d38680d6b1439b775e5f615140", async() => {
                WriteLiteral(@"

                        <label for=""comment"" class=""form-label text-light"">Comment</label>
                        <input type=""text"" name=""comment"" id=""comment"" class=""form-control"">
                        <label for=""minute"" class=""form-label text-light"">Minute</label>
                        <input type=""text"" name=""minute"" id=""minute"" class=""form-control"">
                        <input type=""hidden"" name=""game"" id=""gameId""");
                BeginWriteAttribute("value", " value=\"", 4372, "\"", 4395, 1);
#nullable restore
#line 113 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"
WriteAttributeValue("", 4380, ViewData["Id"], 4380, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n\r\n                        <button class=\"btn btn-success\" id=\"addComment\" type=\"button\">Send</button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                </div>
            </div>
        </div>
    </div>
</section>
<section class=""newsletter-section py-50"">
    <div class=""newsletter"" style=""background-image: url(/assets/img/jan-piatkowski-m61qUssdYSs-unsplash.jpg);"">
        <div class=""row"">
            <div class=""col-lg-6 col-md-12"">
                <p class=""site-title"">FreeKick</p>
                <h3 class=""subscribe"">Subscribe</h3>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8c9aceab64c3a46796d38680d6b1439b775e5f617899", async() => {
                WriteLiteral(@"
                    <div class=""mb-3"">
                        <input type=""email"" class=""form-control"" id=""exampleInputEmail1"" aria-describedby=""emailHelp""
                               placeholder=""Enter your email here..."">
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n<section class=\"lineups py-50\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 144 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"
             if (Model.Match.Date < DateTime.Now || User.IsInRole(RoleConstants.Moderator) || User.IsInRole(RoleConstants.Admin))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h4 class=\"match-broadcast-title mb-5 text-light\">Lineup</h4>\r\n");
            WriteLiteral("                <div class=\"col-lg-12 col-sm-8 p-0 mb-5 d-flex\">\r\n                    <div class=\"field-border\">\r\n                        <div class=\"field-main\">\r\n");
#nullable restore
#line 151 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"
                             foreach (var item in Model.HomeLineups.Where(c => !c.IsChanged && c.Start != StatusConstant.Bench))
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div");
            BeginWriteAttribute("class", " class=\"", 6007, "\"", 6073, 4);
            WriteAttributeValue("", 6015, "player", 6015, 6, true);
#nullable restore
#line 154 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"
WriteAttributeValue(" ", 6021, item.Position, 6022, 14, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 154 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"
WriteAttributeValue("  ", 6036, item.MainPosition.ToLower(), 6038, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 6066, "g-home", 6067, 7, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 155 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"
                                     if (item.Start == StatusConstant.Change)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <i class=\"fa fa-rotate-right\"></i>\r\n");
#nullable restore
#line 158 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"events d-flex\">\r\n");
#nullable restore
#line 160 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"
                                         foreach (var events in item.Event)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b8c9aceab64c3a46796d38680d6b1439b775e5f622415", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6563, "~/assets/img/events/", 6563, 20, true);
#nullable restore
#line 162 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"
AddHtmlAttributeValue("", 6583, events.Logo, 6583, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 163 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n\r\n\r\n                                    <i class=\"fas fa-user\"></i>\r\n                                    <p class=\"p-name\">");
#nullable restore
#line 168 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"
                                                 Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n");
#nullable restore
#line 170 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"


                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 173 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"
                             foreach (var item in Model.AwayLineups.Where(c => !c.IsChanged && c.Start != StatusConstant.Bench))
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div");
            BeginWriteAttribute("class", " class=\"", 7104, "\"", 7169, 4);
            WriteAttributeValue("", 7112, "player", 7112, 6, true);
#nullable restore
#line 176 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"
WriteAttributeValue(" ", 7118, item.Position, 7119, 14, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 176 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"
WriteAttributeValue(" ", 7133, item.MainPosition.ToLower(), 7134, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 7162, "g-away", 7163, 7, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 177 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"
                                     if (item.Start == StatusConstant.Change)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <i class=\"fa fa-rotate-right\"></i>\r\n");
#nullable restore
#line 180 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <i class=\"fas fa-user\"></i>\r\n                                    <p class=\"p-name\">");
#nullable restore
#line 182 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"
                                                 Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n");
#nullable restore
#line 184 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 189 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


        </div>
        <div class=""row"">

        </div>
        <div class=""row"">
            <h4 class=""match-broadcast-title mb-5 text-light"">Bench</h4>
            <div class=""col-lg-5 col-sm-12"">
                <img class=""club-bencher"" src=""./assets/img/teams/real_madrid.png""");
            BeginWriteAttribute("alt", " alt=\"", 8012, "\"", 8018, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <ul class=\"bench\">\r\n");
#nullable restore
#line 202 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"
                     foreach (var item in Model.HomeLineups.Where(c => c.Start == StatusConstant.Bench))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li>\r\n                            ");
#nullable restore
#line 205 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"
                       Write(item.Num);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <img class=\"player-img\"");
            BeginWriteAttribute("src", " src=\"", 8278, "\"", 8312, 2);
            WriteAttributeValue("", 8284, "/assets/img/teams/", 8284, 18, true);
#nullable restore
#line 205 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"
WriteAttributeValue("", 8302, item.Logo, 8302, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 8313, "\"", 8319, 0);
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 205 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"
                                                                                                    Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>MD</span>\r\n                        </li>\r\n");
#nullable restore
#line 207 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </ul>\r\n            </div>\r\n            <div class=\"col-lg-5 col-sm-12\">\r\n                <img class=\"club-bencher\" src=\"./assets/img/teams/barcelona.png\"");
            BeginWriteAttribute("alt", " alt=\"", 8578, "\"", 8584, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <ul class=\"bench away\">\r\n");
#nullable restore
#line 214 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"
                     foreach (var item in Model.AwayLineups.Where(c => c.Start == StatusConstant.Bench))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li>\r\n                            ");
#nullable restore
#line 217 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"
                       Write(item.Num);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <img class=\"player-img\"");
            BeginWriteAttribute("src", " src=\"", 8849, "\"", 8883, 2);
            WriteAttributeValue("", 8855, "/assets/img/teams/", 8855, 18, true);
#nullable restore
#line 217 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"
WriteAttributeValue("", 8873, item.Logo, 8873, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 8884, "\"", 8890, 0);
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 217 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"
                                                                                                    Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>MD</span>\r\n                        </li>\r\n");
#nullable restore
#line 219 "C:\Users\afsana.mammadova\Downloads\FreeKick.com\WebUI\Views\Match\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
            DefineSection("script", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8c9aceab64c3a46796d38680d6b1439b775e5f632263", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>

        $('#comment').emojioneArea();

        var connection = new signalR.HubConnectionBuilder()
            .withUrl(""/broHub"")
            .build();


        connection.on(""RecieveMessage"", function (data) {
            var message = `      <div class=""event"">
                                                                <div class=""event-match-time"">
                                                                    <div class=""event-time"">
                                                                        <span class=""event-time-text"">${data.minute}'</span>
                                                                    </div>
                                                                </div>
                                                                <div class=""event-picture"">
                                                                </div>
                                                                <div class=""event-description"">
     ");
                WriteLiteral(@"                                                               ${data.message}
                                                                </div>
                                                            </div>`

            $("".live-broadvast"").append(message)
        })

        let id = $(""#gameId"").val();


        connection.start()
            .then(function () {
                connection.invoke('joinGame', id);
            })
            .catch(function (err) {
                console.log(err)
            })

        window.addEventListener('onunload', function () {
            connection.invoke('leaveGame', id);
        })



        $(document).on(""click"", ""#addComment"", function () {

            let content = $(""#comment"").val();
            let minute = $(""#minute"").val();
            $.ajax({
                type: ""POST"",
                url: ""/Match/SendMessage"",
                data: { ""message"": content, ""minute"": minute, ""gameId"": id },
                s");
                WriteLiteral(@"uccess: function (res) {
                    console.log(""Message Sent!"")
                },
                error: function (err) {
                    console.log(""Failed to send message!"", err)
                },
            })
        })

    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MatchStatsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
