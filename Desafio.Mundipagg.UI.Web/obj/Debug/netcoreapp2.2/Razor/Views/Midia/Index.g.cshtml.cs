#pragma checksum "C:\Users\NX-\Dropbox\Estudos\Desafio Mundipagg\Projeto\Desafio.Mundipagg.Docker.2\Desafio.Mundipagg.UI.Web\Views\Midia\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4c1d4dc5d73a5c2bc66a8973f3a8cfbea4c518c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Midia_Index), @"mvc.1.0.view", @"/Views/Midia/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Midia/Index.cshtml", typeof(AspNetCore.Views_Midia_Index))]
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
#line 1 "C:\Users\NX-\Dropbox\Estudos\Desafio Mundipagg\Projeto\Desafio.Mundipagg.Docker.2\Desafio.Mundipagg.UI.Web\Views\_ViewImports.cshtml"
using Desafio.Mundipagg.UI.Web;

#line default
#line hidden
#line 2 "C:\Users\NX-\Dropbox\Estudos\Desafio Mundipagg\Projeto\Desafio.Mundipagg.Docker.2\Desafio.Mundipagg.UI.Web\Views\_ViewImports.cshtml"
using Desafio.Mundipagg.UI.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4c1d4dc5d73a5c2bc66a8973f3a8cfbea4c518c", @"/Views/Midia/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea5e05fdfe7166a613906d0d3d8e0ba1c76552a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Midia_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Desafio.Mundipagg.UI.Web.Models.Midia>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\NX-\Dropbox\Estudos\Desafio Mundipagg\Projeto\Desafio.Mundipagg.Docker.2\Desafio.Mundipagg.UI.Web\Views\Midia\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(102, 29, true);
            WriteLiteral("\r\n<h1>Midia</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(131, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4c1d4dc5d73a5c2bc66a8973f3a8cfbea4c518c4054", async() => {
                BeginContext(154, 10, true);
                WriteLiteral("Create New");
                EndContext();
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
            EndContext();
            BeginContext(168, 104, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>            \r\n            <th>\r\n                ");
            EndContext();
            BeginContext(273, 42, false);
#line 16 "C:\Users\NX-\Dropbox\Estudos\Desafio Mundipagg\Projeto\Desafio.Mundipagg.Docker.2\Desafio.Mundipagg.UI.Web\Views\Midia\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Titulo));

#line default
#line hidden
            EndContext();
            BeginContext(315, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(371, 47, false);
#line 19 "C:\Users\NX-\Dropbox\Estudos\Desafio Mundipagg\Projeto\Desafio.Mundipagg.Docker.2\Desafio.Mundipagg.UI.Web\Views\Midia\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Localizacao));

#line default
#line hidden
            EndContext();
            BeginContext(418, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(474, 42, false);
#line 22 "C:\Users\NX-\Dropbox\Estudos\Desafio Mundipagg\Projeto\Desafio.Mundipagg.Docker.2\Desafio.Mundipagg.UI.Web\Views\Midia\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(516, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(572, 42, false);
#line 25 "C:\Users\NX-\Dropbox\Estudos\Desafio Mundipagg\Projeto\Desafio.Mundipagg.Docker.2\Desafio.Mundipagg.UI.Web\Views\Midia\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Genero));

#line default
#line hidden
            EndContext();
            BeginContext(614, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(670, 43, false);
#line 28 "C:\Users\NX-\Dropbox\Estudos\Desafio Mundipagg\Projeto\Desafio.Mundipagg.Docker.2\Desafio.Mundipagg.UI.Web\Views\Midia\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Diretor));

#line default
#line hidden
            EndContext();
            BeginContext(713, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(769, 49, false);
#line 31 "C:\Users\NX-\Dropbox\Estudos\Desafio Mundipagg\Projeto\Desafio.Mundipagg.Docker.2\Desafio.Mundipagg.UI.Web\Views\Midia\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AnoLancamento));

#line default
#line hidden
            EndContext();
            BeginContext(818, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(874, 40, false);
#line 34 "C:\Users\NX-\Dropbox\Estudos\Desafio Mundipagg\Projeto\Desafio.Mundipagg.Docker.2\Desafio.Mundipagg.UI.Web\Views\Midia\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Tipo));

#line default
#line hidden
            EndContext();
            BeginContext(914, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 40 "C:\Users\NX-\Dropbox\Estudos\Desafio Mundipagg\Projeto\Desafio.Mundipagg.Docker.2\Desafio.Mundipagg.UI.Web\Views\Midia\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1032, 60, true);
            WriteLiteral("        <tr>            \r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1093, 41, false);
#line 43 "C:\Users\NX-\Dropbox\Estudos\Desafio Mundipagg\Projeto\Desafio.Mundipagg.Docker.2\Desafio.Mundipagg.UI.Web\Views\Midia\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Titulo));

#line default
#line hidden
            EndContext();
            BeginContext(1134, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1190, 46, false);
#line 46 "C:\Users\NX-\Dropbox\Estudos\Desafio Mundipagg\Projeto\Desafio.Mundipagg.Docker.2\Desafio.Mundipagg.UI.Web\Views\Midia\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Localizacao));

#line default
#line hidden
            EndContext();
            BeginContext(1236, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1293, 50, false);
#line 49 "C:\Users\NX-\Dropbox\Estudos\Desafio Mundipagg\Projeto\Desafio.Mundipagg.Docker.2\Desafio.Mundipagg.UI.Web\Views\Midia\Index.cshtml"
            Write((item.Status == "1") ? "Disponível" : "Emprestado");

#line default
#line hidden
            EndContext();
            BeginContext(1344, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1400, 41, false);
#line 52 "C:\Users\NX-\Dropbox\Estudos\Desafio Mundipagg\Projeto\Desafio.Mundipagg.Docker.2\Desafio.Mundipagg.UI.Web\Views\Midia\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Genero));

#line default
#line hidden
            EndContext();
            BeginContext(1441, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1497, 42, false);
#line 55 "C:\Users\NX-\Dropbox\Estudos\Desafio Mundipagg\Projeto\Desafio.Mundipagg.Docker.2\Desafio.Mundipagg.UI.Web\Views\Midia\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Diretor));

#line default
#line hidden
            EndContext();
            BeginContext(1539, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1595, 48, false);
#line 58 "C:\Users\NX-\Dropbox\Estudos\Desafio Mundipagg\Projeto\Desafio.Mundipagg.Docker.2\Desafio.Mundipagg.UI.Web\Views\Midia\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AnoLancamento));

#line default
#line hidden
            EndContext();
            BeginContext(1643, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1700, 33, false);
#line 61 "C:\Users\NX-\Dropbox\Estudos\Desafio Mundipagg\Projeto\Desafio.Mundipagg.Docker.2\Desafio.Mundipagg.UI.Web\Views\Midia\Index.cshtml"
            Write((item.Tipo == "1") ? "CD" : "DVD");

#line default
#line hidden
            EndContext();
            BeginContext(1734, 71, true);
            WriteLiteral("\r\n            </td>\r\n            <td>                \r\n                ");
            EndContext();
            BeginContext(1806, 61, false);
#line 64 "C:\Users\NX-\Dropbox\Estudos\Desafio Mundipagg\Projeto\Desafio.Mundipagg.Docker.2\Desafio.Mundipagg.UI.Web\Views\Midia\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new {  id = item.Id  }));

#line default
#line hidden
            EndContext();
            BeginContext(1867, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1888, 136, false);
#line 65 "C:\Users\NX-\Dropbox\Estudos\Desafio Mundipagg\Projeto\Desafio.Mundipagg.Docker.2\Desafio.Mundipagg.UI.Web\Views\Midia\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new {  id = item.Id  }, new { onclick = "javascript:return confirm('Realmente deseja excluir?');" }));

#line default
#line hidden
            EndContext();
            BeginContext(2024, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 68 "C:\Users\NX-\Dropbox\Estudos\Desafio Mundipagg\Projeto\Desafio.Mundipagg.Docker.2\Desafio.Mundipagg.UI.Web\Views\Midia\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2063, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Desafio.Mundipagg.UI.Web.Models.Midia>> Html { get; private set; }
    }
}
#pragma warning restore 1591
