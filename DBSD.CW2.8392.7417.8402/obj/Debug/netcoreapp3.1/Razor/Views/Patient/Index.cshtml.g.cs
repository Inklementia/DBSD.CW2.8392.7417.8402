#pragma checksum "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53704ff84dd21eb508945687b27ba72db1098ed1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patient_Index), @"mvc.1.0.view", @"/Views/Patient/Index.cshtml")]
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
#line 1 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\_ViewImports.cshtml"
using DBSD.CW2._8392._7417._8402;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\_ViewImports.cshtml"
using DBSD.CW2._8392._7417._8402.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53704ff84dd21eb508945687b27ba72db1098ed1", @"/Views/Patient/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6b3cc620517f9b8e87349db55ecedf872ccbc36", @"/Views/_ViewImports.cshtml")]
    public class Views_Patient_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DBSD.CW2._8392._7417._8402.Models.Patient>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Index.cshtml"
  
    ViewData["Title"] = "Patients";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Patients</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53704ff84dd21eb508945687b27ba72db1098ed13973", async() => {
                WriteLiteral("Create New");
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
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PatientId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DoB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Occupation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RegisteredDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DiagnoseId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 46 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DiagnoseName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 49 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DoctorId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 52 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DoctorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 55 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DepartmentName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 58 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.WardId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 61 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.WardNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 64 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NurseName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 67 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EmergencyHospitalization));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 70 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IsDischarged));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 73 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Photo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 79 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 82 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PatientId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 85 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 88 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 91 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DoB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 94 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Occupation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 97 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 100 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 103 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 106 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RegisteredDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 109 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DiagnoseId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 112 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DiagnoseName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 115 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DoctorId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 118 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DoctorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 121 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DepartmentName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 124 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.WardId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 127 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.WardNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 130 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NurseName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 133 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmergencyHospitalization));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 136 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IsDischarged));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 139 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Photo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 142 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 143 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 144 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 147 "C:\Users\Home\Desktop\level5\DBSD\DBSD_CW2\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
