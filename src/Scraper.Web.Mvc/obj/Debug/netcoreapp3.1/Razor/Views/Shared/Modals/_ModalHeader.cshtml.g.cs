#pragma checksum "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Shared\Modals\_ModalHeader.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "688f7f2aed1407701440d51816a66f125b8955c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Modals__ModalHeader), @"mvc.1.0.view", @"/Views/Shared/Modals/_ModalHeader.cshtml")]
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
#line 1 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Shared\Modals\_ModalHeader.cshtml"
using Scraper.Web.Models.Common.Modals;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"688f7f2aed1407701440d51816a66f125b8955c1", @"/Views/Shared/Modals/_ModalHeader.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05373ea0226b164607501f965d9acac1be752e30", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Modals__ModalHeader : Scraper.Web.Views.ScraperRazorPage<ModalHeaderViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"modal-header\">\n    <h5 class=\"modal-title\">");
#nullable restore
#line 4 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Shared\Modals\_ModalHeader.cshtml"
                       Write(Html.Raw(Model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n    <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\">\n        <span aria-hidden=\"true\">&times;</span>\n    </button>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ModalHeaderViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
