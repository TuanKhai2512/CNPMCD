#pragma checksum "E:\Gitcnpm\CNPMCD\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f6585bb78ba36426f52a74015051cba5a0b7468"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
#line 1 "E:\Gitcnpm\CNPMCD\Views\_ViewImports.cshtml"
using BaiLam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Gitcnpm\CNPMCD\Views\_ViewImports.cshtml"
using BaiLam.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f6585bb78ba36426f52a74015051cba5a0b7468", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8289165230cb29c115cfb13e6cb98e9d051e8e89", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("sb-nav-fixed"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Gitcnpm\CNPMCD\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f6585bb78ba36426f52a74015051cba5a0b74684138", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\" />\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 369, "\"", 379, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 408, "\"", 418, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f6585bb78ba36426f52a74015051cba5a0b74685686", async() => {
                WriteLiteral(@"

    <div id=""layoutSidenav"">
        <div id=""layoutSidenav_content"">
            <main>
                <div class=""container-fluid"">
                    <h1 class=""mt-4"">Dashboard</h1>
                    <ol class=""breadcrumb mb-4"">
                        <li class=""breadcrumb-item active"">Welcome Admin</li>
                    </ol>
                    <div class=""row"">
                        <div class=""col-xl-4 col-md-6"">
                            <div class=""card bg-primary text-white mb-4"">
                                <div class=""card-body"">Total Employee: ");
#nullable restore
#line 29 "E:\Gitcnpm\CNPMCD\Views\Admin\Index.cshtml"
                                                                  Write(ViewBag.TotalUser);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</div>

                            </div>
                        </div>
                        <div class=""col-xl-4 col-md-6"">
                            <div class=""card bg-success text-white mb-4"">
                                <div class=""card-body"">Total Project: ");
#nullable restore
#line 35 "E:\Gitcnpm\CNPMCD\Views\Admin\Index.cshtml"
                                                                 Write(ViewBag.TotalProject);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</div>
                            </div>
                        </div>
                        <div class=""col-xl-4 col-md-6"">
                            <div class=""card bg-info text-white mb-4"">
                                <div class=""card-body"">Total Respone: ");
#nullable restore
#line 40 "E:\Gitcnpm\CNPMCD\Views\Admin\Index.cshtml"
                                                                 Write(ViewBag.TotalContact);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-xl-6"">
                        <div class=""card mb-4"">
                            <div class=""card-body"">
                                <div class=""table-responsive"">
                                    <table class=""table table-bordered"" id=""dataTable"" cellspacing=""0"" width=""100%"" style=""display:inline-table;"">
                                        <thead>
                                            <tr>
                                                <th>
                                                    ");
#nullable restore
#line 54 "E:\Gitcnpm\CNPMCD\Views\Admin\Index.cshtml"
                                               Write(Html.DisplayNameFor(model => model.emp.FirstOrDefault().Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 57 "E:\Gitcnpm\CNPMCD\Views\Admin\Index.cshtml"
                                               Write(Html.DisplayNameFor(model => model.emp.FirstOrDefault().role));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 60 "E:\Gitcnpm\CNPMCD\Views\Admin\Index.cshtml"
                                               Write(Html.DisplayNameFor(model => model.emp.FirstOrDefault().Phone));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 63 "E:\Gitcnpm\CNPMCD\Views\Admin\Index.cshtml"
                                               Write(Html.DisplayNameFor(model => model.emp.FirstOrDefault().Address));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                </th>\r\n                                            </tr>\r\n                                        </thead>\r\n                                        <tbody>\r\n");
#nullable restore
#line 68 "E:\Gitcnpm\CNPMCD\Views\Admin\Index.cshtml"
                                             foreach (var item1 in Model.emp)
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <tr>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 72 "E:\Gitcnpm\CNPMCD\Views\Admin\Index.cshtml"
                                                   Write(Html.DisplayFor(modelItem1 => item1.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 75 "E:\Gitcnpm\CNPMCD\Views\Admin\Index.cshtml"
                                                   Write(Html.DisplayFor(modelItem1 => item1.role.RolesName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 78 "E:\Gitcnpm\CNPMCD\Views\Admin\Index.cshtml"
                                                   Write(Html.DisplayFor(modelItem1 => item1.Phone));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 81 "E:\Gitcnpm\CNPMCD\Views\Admin\Index.cshtml"
                                                   Write(Html.DisplayFor(modelItem1 => item1.Address));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                    </td>\r\n                                                </tr>\r\n");
#nullable restore
#line 84 "E:\Gitcnpm\CNPMCD\Views\Admin\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-xl-6"">
                        <div class=""card mb-4"">
                            <div class=""card-body"">
                                <div class=""table-responsive"">
                                    <table class=""table table-bordered"" id=""dataTable2"" cellspacing=""0"" width=""100%"" style=""float: left;"">
                                        <thead>
                                            <tr>
                                                <th>
                                                    ");
#nullable restore
#line 99 "E:\Gitcnpm\CNPMCD\Views\Admin\Index.cshtml"
                                               Write(Html.DisplayNameFor(model => model.pro.FirstOrDefault().ProjectName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 102 "E:\Gitcnpm\CNPMCD\Views\Admin\Index.cshtml"
                                               Write(Html.DisplayNameFor(model => model.pro.FirstOrDefault().DateCreated));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 105 "E:\Gitcnpm\CNPMCD\Views\Admin\Index.cshtml"
                                               Write(Html.DisplayNameFor(model => model.pro.FirstOrDefault().Deadline));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                </th>\r\n                                            </tr>\r\n                                        </thead>\r\n                                        <tbody>\r\n");
#nullable restore
#line 110 "E:\Gitcnpm\CNPMCD\Views\Admin\Index.cshtml"
                                             foreach (var item2 in Model.pro)
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <tr>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 114 "E:\Gitcnpm\CNPMCD\Views\Admin\Index.cshtml"
                                                   Write(Html.DisplayFor(modelItem2 => item2.ProjectName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 117 "E:\Gitcnpm\CNPMCD\Views\Admin\Index.cshtml"
                                                   Write(Html.DisplayFor(modelItem2 => item2.DateCreated));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 120 "E:\Gitcnpm\CNPMCD\Views\Admin\Index.cshtml"
                                                   Write(Html.DisplayFor(modelItem2 => item2.Deadline));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                    </td>\r\n\r\n                                                </tr>\r\n");
#nullable restore
#line 124 "E:\Gitcnpm\CNPMCD\Views\Admin\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""card col-xl-12"">
                        <div class=""card-body"">
                            <div class=""table-responsive"">
                                <table class=""table table-bordered"" id=""dataTable3"" width=""100%"" cellspacing=""0"">
                                    <thead>
                                        <tr>
                                            <th>
                                                ");
#nullable restore
#line 140 "E:\Gitcnpm\CNPMCD\Views\Admin\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.con.FirstOrDefault().Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
#nullable restore
#line 143 "E:\Gitcnpm\CNPMCD\Views\Admin\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.con.FirstOrDefault().Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
#nullable restore
#line 146 "E:\Gitcnpm\CNPMCD\Views\Admin\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.con.FirstOrDefault().Message));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                            </th>\r\n\r\n\r\n                                        </tr>\r\n                                    </thead>\r\n                                    <tbody>\r\n");
#nullable restore
#line 153 "E:\Gitcnpm\CNPMCD\Views\Admin\Index.cshtml"
                                         foreach (var item in Model.con)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <tr>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 157 "E:\Gitcnpm\CNPMCD\Views\Admin\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 160 "E:\Gitcnpm\CNPMCD\Views\Admin\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 163 "E:\Gitcnpm\CNPMCD\Views\Admin\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.Message));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                </td>\r\n                                            </tr>\r\n");
#nullable restore
#line 166 "E:\Gitcnpm\CNPMCD\Views\Admin\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
            </main>
            <footer class=""py-4 bg-light mt-auto"">
                <div class=""container-fluid"">
                    <div class=""d-flex align-items-center justify-content-between small"">
                        <div class=""text-muted"">Trần Tuấn Khải & Cao Minh Phát</div>
                        <div>
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f6585bb78ba36426f52a74015051cba5a0b746821579", async() => {
                    WriteLiteral("2020");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            &middot;\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f6585bb78ba36426f52a74015051cba5a0b746822865", async() => {
                    WriteLiteral("2021");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </footer>\r\n        </div>\r\n    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
