#pragma checksum "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Users\_EditModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5eefb28e82862d7bc10c3a7daf4e4298965282aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users__EditModal), @"mvc.1.0.view", @"/Views/Users/_EditModal.cshtml")]
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
#line 1 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Users\_EditModal.cshtml"
using Abp.Authorization.Users;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Users\_EditModal.cshtml"
using Scraper.Web.Models.Common.Modals;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Users\_EditModal.cshtml"
using Scraper.Web.Models.Users;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5eefb28e82862d7bc10c3a7daf4e4298965282aa", @"/Views/Users/_EditModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05373ea0226b164607501f965d9acac1be752e30", @"/Views/_ViewImports.cshtml")]
    public class Views_Users__EditModal : Scraper.Web.Views.ScraperRazorPage<EditUserModalViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("UserEditForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/view-resources/Views/Users/_EditModal.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Users\_EditModal.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Users\_EditModal.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/Modals/_ModalHeader.cshtml", new ModalHeaderViewModel(L("EditUser"))));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5eefb28e82862d7bc10c3a7daf4e4298965282aa5838", async() => {
                WriteLiteral("\n    <input type=\"hidden\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 365, "\"", 387, 1);
#nullable restore
#line 10 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Users\_EditModal.cshtml"
WriteAttributeValue("", 373, Model.User.Id, 373, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n    <div class=\"modal-body\">\n        <ul class=\"nav nav-tabs\" role=\"tablist\">\n            <li class=\"nav-item\">\n                <a class=\"nav-link active\" data-toggle=\"tab\" role=\"tab\" href=\"#edit-user-details\">");
#nullable restore
#line 14 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Users\_EditModal.cshtml"
                                                                                             Write(L("UserDetails"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\n            </li>\n            <li class=\"nav-item\">\n                <a class=\"nav-link\" data-toggle=\"tab\" role=\"tab\" href=\"#edit-user-roles\">");
#nullable restore
#line 17 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Users\_EditModal.cshtml"
                                                                                    Write(L("UserRoles"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</a>
            </li>
        </ul>
        <div class=""tab-content mt-4"">
            <div role=""tabpanel"" class=""tab-pane container active"" id=""edit-user-details"">
                <div class=""form-group row required"">
                    <label class=""col-md-3 col-form-label"" for=""username"">");
#nullable restore
#line 23 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Users\_EditModal.cshtml"
                                                                     Write(L("UserName"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\n                    <div class=\"col-md-9\">\n                        <input id=\"username\" type=\"text\" class=\"form-control\" name=\"UserName\"");
                BeginWriteAttribute("value", " value=\"", 1234, "\"", 1262, 1);
#nullable restore
#line 25 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Users\_EditModal.cshtml"
WriteAttributeValue("", 1242, Model.User.UserName, 1242, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required");
                BeginWriteAttribute("maxlength", " maxlength=\"", 1272, "\"", 1314, 1);
#nullable restore
#line 25 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Users\_EditModal.cshtml"
WriteAttributeValue("", 1284, AbpUserBase.MaxUserNameLength, 1284, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" minlength=\"2\">\n                    </div>\n                </div>\n                <div class=\"form-group row required\">\n                    <label class=\"col-md-3 col-form-label\" for=\"name\">");
#nullable restore
#line 29 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Users\_EditModal.cshtml"
                                                                 Write(L("Name"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\n                    <div class=\"col-md-9\">\n                        <input id=\"name\" type=\"text\" class=\"form-control\" name=\"Name\"");
                BeginWriteAttribute("value", " value=\"", 1652, "\"", 1676, 1);
#nullable restore
#line 31 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Users\_EditModal.cshtml"
WriteAttributeValue("", 1660, Model.User.Name, 1660, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required");
                BeginWriteAttribute("maxlength", " maxlength=\"", 1686, "\"", 1724, 1);
#nullable restore
#line 31 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Users\_EditModal.cshtml"
WriteAttributeValue("", 1698, AbpUserBase.MaxNameLength, 1698, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                    </div>\n                </div>\n                <div class=\"form-group row required\">\n                    <label class=\"col-md-3 col-form-label\" for=\"surname\">");
#nullable restore
#line 35 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Users\_EditModal.cshtml"
                                                                    Write(L("Surname"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\n                    <div class=\"col-md-9\">\n                        <input id=\"surname\" type=\"text\" class=\"form-control\" name=\"Surname\"");
                BeginWriteAttribute("value", " value=\"", 2060, "\"", 2087, 1);
#nullable restore
#line 37 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Users\_EditModal.cshtml"
WriteAttributeValue("", 2068, Model.User.Surname, 2068, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required");
                BeginWriteAttribute("maxlength", " maxlength=\"", 2097, "\"", 2138, 1);
#nullable restore
#line 37 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Users\_EditModal.cshtml"
WriteAttributeValue("", 2109, AbpUserBase.MaxSurnameLength, 2109, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                    </div>\n                </div>\n                <div class=\"form-group row required\">\n                    <label class=\"col-md-3 col-form-label\" for=\"email\">");
#nullable restore
#line 41 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Users\_EditModal.cshtml"
                                                                  Write(L("EmailAddress"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\n                    <div class=\"col-md-9\">\n                        <input id=\"email\" type=\"email\" class=\"form-control\" name=\"EmailAddress\"");
                BeginWriteAttribute("value", " value=\"", 2481, "\"", 2513, 1);
#nullable restore
#line 43 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Users\_EditModal.cshtml"
WriteAttributeValue("", 2489, Model.User.EmailAddress, 2489, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required");
                BeginWriteAttribute("maxlength", " maxlength=\"", 2523, "\"", 2569, 1);
#nullable restore
#line 43 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Users\_EditModal.cshtml"
WriteAttributeValue("", 2535, AbpUserBase.MaxEmailAddressLength, 2535, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                    </div>\n                </div>\n                <div class=\"form-group row\">\n                    <label class=\"col-md-3 col-form-label\" for=\"IsActive\">");
#nullable restore
#line 47 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Users\_EditModal.cshtml"
                                                                     Write(L("IsActive"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\n                    <div class=\"col-md-9\">\n                        <input id=\"IsActive\" type=\"checkbox\" name=\"IsActive\" value=\"true\" ");
#nullable restore
#line 49 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Users\_EditModal.cshtml"
                                                                                      Write(Model.User.IsActive ? "checked" : "");

#line default
#line hidden
#nullable disable
                WriteLiteral(" />\n                    </div>\n                </div>\n            </div>\n            <div role=\"tabpanel\" class=\"tab-pane container\" id=\"edit-user-roles\">\n                <div class=\"row\">\n");
#nullable restore
#line 55 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Users\_EditModal.cshtml"
                     foreach (var role in Model.Roles)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"col-md-6\">\n                            <input type=\"checkbox\" name=\"role\"");
                BeginWriteAttribute("value", " value=\"", 3311, "\"", 3339, 1);
#nullable restore
#line 58 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Users\_EditModal.cshtml"
WriteAttributeValue("", 3319, role.NormalizedName, 3319, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 3340, "\"", 3365, 1);
#nullable restore
#line 58 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Users\_EditModal.cshtml"
WriteAttributeValue("", 3348, role.Description, 3348, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"filled-in\"");
                BeginWriteAttribute("id", " id=\"", 3384, "\"", 3408, 1);
#nullable restore
#line 58 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Users\_EditModal.cshtml"
WriteAttributeValue("", 3389, $"role{role.Id}", 3389, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" ");
#nullable restore
#line 58 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Users\_EditModal.cshtml"
                                                                                                                                                             Write(Model.UserIsInRole(role) ? "checked" : "");

#line default
#line hidden
#nullable disable
                WriteLiteral(" />\n                            <label");
                BeginWriteAttribute("for", " for=\"", 3492, "\"", 3517, 1);
#nullable restore
#line 59 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Users\_EditModal.cshtml"
WriteAttributeValue("", 3498, $"role{role.Id}", 3498, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 3518, "\"", 3543, 1);
#nullable restore
#line 59 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Users\_EditModal.cshtml"
WriteAttributeValue("", 3526, role.DisplayName, 3526, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 59 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Users\_EditModal.cshtml"
                                                                                  Write(role.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\n                        </div>\n");
#nullable restore
#line 61 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Users\_EditModal.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\n            </div>\n        </div>\n    </div>\n    ");
#nullable restore
#line 66 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Users\_EditModal.cshtml"
Write(await Html.PartialAsync("~/Views/Shared/Modals/_ModalFooterWithSaveAndCancel.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5eefb28e82862d7bc10c3a7daf4e4298965282aa19615", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 69 "C:\playground\Scraper\5.7.0\aspnet-core\src\Scraper.Web.Mvc\Views\Users\_EditModal.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EditUserModalViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
