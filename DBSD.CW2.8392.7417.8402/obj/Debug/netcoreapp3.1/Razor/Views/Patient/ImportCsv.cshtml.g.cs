#pragma checksum "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportCsv.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac1d2fe4ac87883f3a5b5b75a9a781a2c8750655"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patient_ImportCsv), @"mvc.1.0.view", @"/Views/Patient/ImportCsv.cshtml")]
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
#line 1 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\_ViewImports.cshtml"
using DBSD.CW2._8392._7417._8402;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\_ViewImports.cshtml"
using DBSD.CW2._8392._7417._8402.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac1d2fe4ac87883f3a5b5b75a9a781a2c8750655", @"/Views/Patient/ImportCsv.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6b3cc620517f9b8e87349db55ecedf872ccbc36", @"/Views/_ViewImports.cshtml")]
    public class Views_Patient_ImportCsv : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DBSD.CW2._8392._7417._8402.Models.Patient>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ImportCsv", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportCsv.cshtml"
  
    ViewData["Title"] = "ImportCsv";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Import Csv</h1>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac1d2fe4ac87883f3a5b5b75a9a781a2c87506555186", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac1d2fe4ac87883f3a5b5b75a9a781a2c87506555456", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 12 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportCsv.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            <div class=""form-group"">
                <label for=""importFile""></label>
                <input name=""importFile"" class=""form-control import-file"" type=""file"" />
            </div>

            <div class=""form-group"">
                <input type=""submit"" value=""Import"" class=""btn btn-primary"" />
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n");
#nullable restore
#line 26 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportCsv.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-bordered shadow\">\r\n        <thead class=\"shadow\">\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 32 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportCsv.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 35 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportCsv.cshtml"
               Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 38 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportCsv.cshtml"
               Write(Html.DisplayNameFor(model => model.DoB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 41 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportCsv.cshtml"
               Write(Html.DisplayNameFor(model => model.Occupation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 44 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportCsv.cshtml"
               Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 47 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportCsv.cshtml"
               Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 50 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportCsv.cshtml"
               Write(Html.DisplayNameFor(model => model.RegisteredDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 53 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportCsv.cshtml"
               Write(Html.DisplayNameFor(model => model.DiagnoseName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 56 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportCsv.cshtml"
               Write(Html.DisplayNameFor(model => model.DoctorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 59 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportCsv.cshtml"
               Write(Html.DisplayNameFor(model => model.DepartmentName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 62 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportCsv.cshtml"
               Write(Html.DisplayNameFor(model => model.WardNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 65 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportCsv.cshtml"
               Write(Html.DisplayNameFor(model => model.NurseName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 70 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportCsv.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 74 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportCsv.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 77 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportCsv.cshtml"
                   Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 80 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportCsv.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DoB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 83 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportCsv.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Occupation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 86 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportCsv.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 89 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportCsv.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 92 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportCsv.cshtml"
                   Write(Html.DisplayFor(modelItem => item.RegisteredDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 95 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportCsv.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DiagnoseName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 98 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportCsv.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DoctorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 101 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportCsv.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DepartmentName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 104 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportCsv.cshtml"
                   Write(Html.DisplayFor(modelItem => item.WardNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 107 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportCsv.cshtml"
                   Write(Html.DisplayFor(modelItem => item.NurseName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 110 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportCsv.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 113 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\ImportCsv.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DBSD.CW2._8392._7417._8402.Models.Patient>> Html { get; private set; }
    }
}
#pragma warning restore 1591
