#pragma checksum "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Shared\Components\AccountLanguages\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "490686577f974f2bbd33bff11683e4ad7250eeac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AccountLanguages_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AccountLanguages/Default.cshtml")]
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
#line 1 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\_ViewImports.cshtml"
using Abp.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Shared\Components\AccountLanguages\Default.cshtml"
using Scraper.Web.Views.Shared.Components.AccountLanguages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"490686577f974f2bbd33bff11683e4ad7250eeac", @"/Views/Shared/Components/AccountLanguages/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05373ea0226b164607501f965d9acac1be752e30", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_AccountLanguages_Default : Scraper.Web.Views.ScraperRazorPage<LanguageSelectionViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Shared\Components\AccountLanguages\Default.cshtml"
 if (Model.Languages.Count > 1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"text-center\">\n");
#nullable restore
#line 6 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Shared\Components\AccountLanguages\Default.cshtml"
         foreach (var languageInfo in Model.Languages)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a");
            BeginWriteAttribute("href", " href=\"", 237, "\"", 452, 1);
#nullable restore
#line 8 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Shared\Components\AccountLanguages\Default.cshtml"
WriteAttributeValue("", 244, Url.Action("ChangeCulture", "AbpLocalization", new {
                    cultureName = languageInfo.Name,
                    returnUrl = Context.Request.Path + Context.Request.QueryString
                }), 244, 208, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                <span");
            BeginWriteAttribute("class", " class=\"", 476, "\"", 565, 1);
#nullable restore
#line 12 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Shared\Components\AccountLanguages\Default.cshtml"
WriteAttributeValue("", 484, languageInfo.Name == Model.CurrentLanguage.Name ? "current-language-icon" : "", 484, 81, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 566, "\"", 599, 1);
#nullable restore
#line 12 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Shared\Components\AccountLanguages\Default.cshtml"
WriteAttributeValue("", 574, languageInfo.DisplayName, 574, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                    <i");
            BeginWriteAttribute("class", " class=\"", 624, "\"", 650, 1);
#nullable restore
#line 13 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Shared\Components\AccountLanguages\Default.cshtml"
WriteAttributeValue("", 632, languageInfo.Icon, 632, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\n                </span>\n            </a>\n");
#nullable restore
#line 16 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Shared\Components\AccountLanguages\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n");
#nullable restore
#line 18 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Shared\Components\AccountLanguages\Default.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LanguageSelectionViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
