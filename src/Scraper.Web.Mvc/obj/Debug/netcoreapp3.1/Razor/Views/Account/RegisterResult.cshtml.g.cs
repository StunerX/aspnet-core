#pragma checksum "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Account\RegisterResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8a908db10d0d3c82e390399b96bb17a440293ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_RegisterResult), @"mvc.1.0.view", @"/Views/Account/RegisterResult.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8a908db10d0d3c82e390399b96bb17a440293ae", @"/Views/Account/RegisterResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05373ea0226b164607501f965d9acac1be752e30", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_RegisterResult : Scraper.Web.Views.ScraperRazorPage<Scraper.Web.Models.Account.RegisterResultViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Account\RegisterResult.cshtml"
  
    ViewBag.Title = L("SuccessfullyRegistered");

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card\">\n    <div class=\"card-body\">\n        <h4>");
#nullable restore
#line 7 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Account\RegisterResult.cshtml"
       Write(L("SuccessfullyRegistered"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n        <ul>\n            <li><span class=\"text-muted\">");
#nullable restore
#line 9 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Account\RegisterResult.cshtml"
                                    Write(L("NameSurname"));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</span> ");
#nullable restore
#line 9 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Account\RegisterResult.cshtml"
                                                              Write(Model.NameAndSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n            <li><span class=\"text-muted\">");
#nullable restore
#line 10 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Account\RegisterResult.cshtml"
                                    Write(L("TenancyName"));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</span> ");
#nullable restore
#line 10 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Account\RegisterResult.cshtml"
                                                              Write(Model.TenancyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n            <li><span class=\"text-muted\">");
#nullable restore
#line 11 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Account\RegisterResult.cshtml"
                                    Write(L("UserName"));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</span> ");
#nullable restore
#line 11 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Account\RegisterResult.cshtml"
                                                           Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n            <li><span class=\"text-muted\">");
#nullable restore
#line 12 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Account\RegisterResult.cshtml"
                                    Write(L("EmailAddress"));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</span> ");
#nullable restore
#line 12 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Account\RegisterResult.cshtml"
                                                               Write(Model.EmailAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n        </ul>\n        <div>\n");
#nullable restore
#line 15 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Account\RegisterResult.cshtml"
             if (!Model.IsActive)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"alert alert-warning\" role=\"alert\">\n                    ");
#nullable restore
#line 18 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Account\RegisterResult.cshtml"
               Write(L("WaitingForActivationMessage"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n");
#nullable restore
#line 20 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Account\RegisterResult.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 22 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Account\RegisterResult.cshtml"
             if (Model.IsEmailConfirmationRequiredForLogin && !Model.IsEmailConfirmed)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"alert alert-warning\" role=\"alert\">\n                    ");
#nullable restore
#line 25 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Account\RegisterResult.cshtml"
               Write(L("WaitingForEmailActivation"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n");
#nullable restore
#line 27 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Account\RegisterResult.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Scraper.Web.Models.Account.RegisterResultViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
