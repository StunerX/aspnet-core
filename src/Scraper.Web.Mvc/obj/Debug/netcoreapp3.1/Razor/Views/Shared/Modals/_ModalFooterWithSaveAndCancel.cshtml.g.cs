#pragma checksum "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Shared\Modals\_ModalFooterWithSaveAndCancel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0faf78aa9cc970865f479ecc1e91d106ce4ab859"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Modals__ModalFooterWithSaveAndCancel), @"mvc.1.0.view", @"/Views/Shared/Modals/_ModalFooterWithSaveAndCancel.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0faf78aa9cc970865f479ecc1e91d106ce4ab859", @"/Views/Shared/Modals/_ModalFooterWithSaveAndCancel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05373ea0226b164607501f965d9acac1be752e30", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Modals__ModalFooterWithSaveAndCancel : Scraper.Web.Views.ScraperRazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"modal-footer justify-content-between\">\n    <button type=\"button\" class=\"btn btn-default close-button\" data-dismiss=\"modal\">");
#nullable restore
#line 2 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Shared\Modals\_ModalFooterWithSaveAndCancel.cshtml"
                                                                               Write(L("Cancel"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\n    <button type=\"submit\" class=\"btn btn-primary save-button\">");
#nullable restore
#line 3 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Shared\Modals\_ModalFooterWithSaveAndCancel.cshtml"
                                                         Write(L("Save"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
