#pragma checksum "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56a1b0d069dae162dae60d68fbbc15d6a1cb1c26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patient_Details), @"mvc.1.0.view", @"/Views/Patient/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56a1b0d069dae162dae60d68fbbc15d6a1cb1c26", @"/Views/Patient/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6b3cc620517f9b8e87349db55ecedf872ccbc36", @"/Views/_ViewImports.cshtml")]
    public class Views_Patient_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DBSD.CW2._8392._7417._8402.Models.Patient>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Filter", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Patient</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Details.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Details.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Details.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DoB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Details.cshtml"
       Write(Html.DisplayFor(model => model.DoB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Occupation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Details.cshtml"
       Write(Html.DisplayFor(model => model.Occupation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Details.cshtml"
       Write(Html.DisplayFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Details.cshtml"
       Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Details.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RegisteredDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Details.cshtml"
       Write(Html.DisplayFor(model => model.RegisteredDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EmergencyHospitalization));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Details.cshtml"
        Write(Model.EmergencyHospitalization?"Yes":"No");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsDischarged));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Details.cshtml"
        Write(Model.IsDischarged?"Discharged":"Not discharged");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 80 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Photo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 83 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Details.cshtml"
       Write(Html.DisplayFor(model => model.Photo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 86 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DiagnoseName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 89 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Details.cshtml"
       Write(Html.DisplayFor(model => model.DiagnoseName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 92 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DoctorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 95 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Details.cshtml"
       Write(Html.DisplayFor(model => model.DoctorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 98 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DepartmentName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 101 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Details.cshtml"
       Write(Html.DisplayFor(model => model.DepartmentName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 104 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.WardNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 107 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Details.cshtml"
       Write(Html.DisplayFor(model => model.WardNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 110 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NurseName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 113 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Details.cshtml"
       Write(Html.DisplayFor(model => model.NurseName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 118 "C:\Users\User\Desktop\DBSD.CW2.8392.7417.8402\DBSD.CW2.8392.7417.8402\Views\Patient\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new {  id = Model.Id  }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56a1b0d069dae162dae60d68fbbc15d6a1cb1c2615785", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DBSD.CW2._8392._7417._8402.Models.Patient> Html { get; private set; }
    }
}
#pragma warning restore 1591
