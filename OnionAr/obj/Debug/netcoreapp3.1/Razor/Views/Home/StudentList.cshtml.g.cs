#pragma checksum "C:\Users\Cute\source\repos\OnionAr\OnionAr\Views\Home\StudentList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6f86e9b00cf214bd5b2a0e12b0bce8ed86bab31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_StudentList), @"mvc.1.0.view", @"/Views/Home/StudentList.cshtml")]
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
#line 1 "C:\Users\Cute\source\repos\OnionAr\OnionAr\Views\_ViewImports.cshtml"
using OnionAr;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Cute\source\repos\OnionAr\OnionAr\Views\_ViewImports.cshtml"
using OnionAr.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6f86e9b00cf214bd5b2a0e12b0bce8ed86bab31", @"/Views/Home/StudentList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58b2dcdc5c0614ccd86f85288f41fdcd218c1f66", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_StudentList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ViewModel.ViewModel.VmStudent>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Cute\source\repos\OnionAr\OnionAr\Views\Home\StudentList.cshtml"
  
    ViewData["Title"] = "StudentList";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>StudentList</h1>\r\n");
#nullable restore
#line 8 "C:\Users\Cute\source\repos\OnionAr\OnionAr\Views\Home\StudentList.cshtml"
 if (Model!=null && Model.Count()>0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table class=""table"">
    <thead>
        <tr>
            <td>Name</td>
            <td>Email</td>
            <td>Rollno</td>
            <td>Subject</td>
            <td>Batch</td>
            <td>Delete</td>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 22 "C:\Users\Cute\source\repos\OnionAr\OnionAr\Views\Home\StudentList.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\Cute\source\repos\OnionAr\OnionAr\Views\Home\StudentList.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\Cute\source\repos\OnionAr\OnionAr\Views\Home\StudentList.cshtml"
               Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\Cute\source\repos\OnionAr\OnionAr\Views\Home\StudentList.cshtml"
               Write(item.RollNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\Cute\source\repos\OnionAr\OnionAr\Views\Home\StudentList.cshtml"
               Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\Cute\source\repos\OnionAr\OnionAr\Views\Home\StudentList.cshtml"
               Write(item.Batch);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6f86e9b00cf214bd5b2a0e12b0bce8ed86bab315731", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 716, "~/home/DeleteByid?id=", 716, 21, true);
#nullable restore
#line 30 "C:\Users\Cute\source\repos\OnionAr\OnionAr\Views\Home\StudentList.cshtml"
AddHtmlAttributeValue("", 737, item.ID, 737, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 32 "C:\Users\Cute\source\repos\OnionAr\OnionAr\Views\Home\StudentList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n");
#nullable restore
#line 36 "C:\Users\Cute\source\repos\OnionAr\OnionAr\Views\Home\StudentList.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Data not founds</h1>\r\n");
#nullable restore
#line 40 "C:\Users\Cute\source\repos\OnionAr\OnionAr\Views\Home\StudentList.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ViewModel.ViewModel.VmStudent>> Html { get; private set; }
    }
}
#pragma warning restore 1591
