#pragma checksum "E:\Gitcnpm\CNPMCD\Views\ProjectDetails\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "769056b2372e8487bfdd0b92daf3faae37cd2055"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProjectDetails_Delete), @"mvc.1.0.view", @"/Views/ProjectDetails/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"769056b2372e8487bfdd0b92daf3faae37cd2055", @"/Views/ProjectDetails/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8289165230cb29c115cfb13e6cb98e9d051e8e89", @"/Views/_ViewImports.cshtml")]
    public class Views_ProjectDetails_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BaiLam.Models.ProjectDetail>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("sb-nav-fixed"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Gitcnpm\CNPMCD\Views\ProjectDetails\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "769056b2372e8487bfdd0b92daf3faae37cd20555079", async() => {
                WriteLiteral("\r\n    <div id=\"layoutSidenav\">\r\n        <div id=\"layoutSidenav_content\">\r\n            <main>\r\n                <div class=\"card mb-4\">\r\n                    <div class=\"card-header\">\r\n");
                WriteLiteral("                        <span class=\"something\">Delete from project: ");
#nullable restore
#line 15 "E:\Gitcnpm\CNPMCD\Views\ProjectDetails\Delete.cshtml"
                                                                Write(Html.DisplayFor(Model => Model.project.ProjectName));

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />User: ");
#nullable restore
#line 15 "E:\Gitcnpm\CNPMCD\Views\ProjectDetails\Delete.cshtml"
                                                                                                                                 Write(Html.DisplayFor(Model => Model.employee.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                    </div>
                    <div class=""card-body"">
                        <div class=""col""></div>
                        <div class=""col-md-6"">
                            <dl class=""row"">
                                <dt class=""col-sm-2"">
                                    ");
#nullable restore
#line 22 "E:\Gitcnpm\CNPMCD\Views\ProjectDetails\Delete.cshtml"
                               Write(Html.DisplayNameFor(model => model.employee));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </dt>\r\n                                <dd class=\"col-sm-10\">\r\n                                    ");
#nullable restore
#line 25 "E:\Gitcnpm\CNPMCD\Views\ProjectDetails\Delete.cshtml"
                               Write(Html.DisplayFor(model => model.employee.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </dd>\r\n                                <dt class=\"col-sm-2\">\r\n                                    ");
#nullable restore
#line 28 "E:\Gitcnpm\CNPMCD\Views\ProjectDetails\Delete.cshtml"
                               Write(Html.DisplayNameFor(model => model.project));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </dt>\r\n                                <dd class=\"col-sm-10\">\r\n                                    ");
#nullable restore
#line 31 "E:\Gitcnpm\CNPMCD\Views\ProjectDetails\Delete.cshtml"
                               Write(Html.DisplayFor(model => model.project.ProjectName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </dd>\r\n                                <dt class=\"col-sm-2\">\r\n                                    ");
#nullable restore
#line 34 "E:\Gitcnpm\CNPMCD\Views\ProjectDetails\Delete.cshtml"
                               Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </dt>\r\n                                <dd class=\"col-sm-10\">\r\n                                    ");
#nullable restore
#line 37 "E:\Gitcnpm\CNPMCD\Views\ProjectDetails\Delete.cshtml"
                               Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </dd>\r\n                                <dt class=\"col-sm-2\">\r\n                                    ");
#nullable restore
#line 40 "E:\Gitcnpm\CNPMCD\Views\ProjectDetails\Delete.cshtml"
                               Write(Html.DisplayNameFor(model => model.Mon));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </dt>\r\n                                <dd class=\"col-sm-10\">\r\n                                    ");
#nullable restore
#line 43 "E:\Gitcnpm\CNPMCD\Views\ProjectDetails\Delete.cshtml"
                               Write(Html.DisplayFor(model => model.Mon));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </dd>\r\n                                <dt class=\"col-sm-2\">\r\n                                    ");
#nullable restore
#line 46 "E:\Gitcnpm\CNPMCD\Views\ProjectDetails\Delete.cshtml"
                               Write(Html.DisplayNameFor(model => model.Tue));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </dt>\r\n                                <dd class=\"col-sm-10\">\r\n                                    ");
#nullable restore
#line 49 "E:\Gitcnpm\CNPMCD\Views\ProjectDetails\Delete.cshtml"
                               Write(Html.DisplayFor(model => model.Tue));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </dd>\r\n                                <dt class=\"col-sm-2\">\r\n                                    ");
#nullable restore
#line 52 "E:\Gitcnpm\CNPMCD\Views\ProjectDetails\Delete.cshtml"
                               Write(Html.DisplayNameFor(model => model.Wed));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </dt>\r\n                                <dd class=\"col-sm-10\">\r\n                                    ");
#nullable restore
#line 55 "E:\Gitcnpm\CNPMCD\Views\ProjectDetails\Delete.cshtml"
                               Write(Html.DisplayFor(model => model.Wed));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </dd>\r\n                                <dt class=\"col-sm-2\">\r\n                                    ");
#nullable restore
#line 58 "E:\Gitcnpm\CNPMCD\Views\ProjectDetails\Delete.cshtml"
                               Write(Html.DisplayNameFor(model => model.Thur));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </dt>\r\n                                <dd class=\"col-sm-10\">\r\n                                    ");
#nullable restore
#line 61 "E:\Gitcnpm\CNPMCD\Views\ProjectDetails\Delete.cshtml"
                               Write(Html.DisplayFor(model => model.Thur));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </dd>\r\n                                <dt class=\"col-sm-2\">\r\n                                    ");
#nullable restore
#line 64 "E:\Gitcnpm\CNPMCD\Views\ProjectDetails\Delete.cshtml"
                               Write(Html.DisplayNameFor(model => model.Fri));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </dt>\r\n                                <dd class=\"col-sm-10\">\r\n                                    ");
#nullable restore
#line 67 "E:\Gitcnpm\CNPMCD\Views\ProjectDetails\Delete.cshtml"
                               Write(Html.DisplayFor(model => model.Fri));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </dd>\r\n                                <dt class=\"col-sm-2\">\r\n                                    ");
#nullable restore
#line 70 "E:\Gitcnpm\CNPMCD\Views\ProjectDetails\Delete.cshtml"
                               Write(Html.DisplayNameFor(model => model.HoursWorked));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </dt>\r\n                                <dd class=\"col-sm-10\">\r\n                                    ");
#nullable restore
#line 73 "E:\Gitcnpm\CNPMCD\Views\ProjectDetails\Delete.cshtml"
                               Write(Html.DisplayFor(model => model.HoursWorked));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </dd>\r\n                            </dl>\r\n\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "769056b2372e8487bfdd0b92daf3faae37cd205513646", async() => {
                    WriteLiteral("\r\n                                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "769056b2372e8487bfdd0b92daf3faae37cd205513945", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 78 "E:\Gitcnpm\CNPMCD\Views\ProjectDetails\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.detailID);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                                <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n                                <a class=\"btn btn-secondary\"");
                    BeginWriteAttribute("href", " href=\"", 4274, "\"", 4299, 1);
#nullable restore
#line 80 "E:\Gitcnpm\CNPMCD\Views\ProjectDetails\Delete.cshtml"
WriteAttributeValue("", 4281, ViewBag.returnUrl, 4281, 18, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">Back to List</a>\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </div>
                        <div class=""col""></div>
                    </div>
                </div>
            </main>
            <footer class=""py-4 bg-light mt-auto"">
                <div class=""container-fluid"">
                    <div class=""d-flex align-items-center justify-content-between small"">
                        <div class=""text-muted"">Trần Tuấn Khải & Cao Minh Phát</div>
                        <div>
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "769056b2372e8487bfdd0b92daf3faae37cd205518003", async() => {
                    WriteLiteral("2020");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            &middot;\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "769056b2372e8487bfdd0b92daf3faae37cd205519289", async() => {
                    WriteLiteral("2021");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </footer>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BaiLam.Models.ProjectDetail> Html { get; private set; }
    }
}
#pragma warning restore 1591