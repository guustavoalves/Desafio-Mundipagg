#pragma checksum "C:\Users\NX-\Dropbox\Estudos\Desafio Mundipagg\Projeto\Desafio.Mundipagg.Docker.2\Desafio.Mundipagg.UI.Web\Views\Colecao\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95222aad561f1a8df39e35a9ea4beb0f8a29306c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Colecao_Index), @"mvc.1.0.view", @"/Views/Colecao/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Colecao/Index.cshtml", typeof(AspNetCore.Views_Colecao_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95222aad561f1a8df39e35a9ea4beb0f8a29306c", @"/Views/Colecao/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea5e05fdfe7166a613906d0d3d8e0ba1c76552a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Colecao_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Desafio.Mundipagg.UI.Web.Models.Colecao>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(61, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\NX-\Dropbox\Estudos\Desafio Mundipagg\Projeto\Desafio.Mundipagg.Docker.2\Desafio.Mundipagg.UI.Web\Views\Colecao\Index.cshtml"
      
        ViewData["Title"] = "Index";
    

#line default
#line hidden
            BeginContext(116, 44, true);
            WriteLiteral("\r\n    <h1>Minha Coleção</h1>\r\n    <br />\r\n\r\n");
            EndContext();
#line 10 "C:\Users\NX-\Dropbox\Estudos\Desafio Mundipagg\Projeto\Desafio.Mundipagg.Docker.2\Desafio.Mundipagg.UI.Web\Views\Colecao\Index.cshtml"
     using (Html.BeginForm("Index", "Colecao", FormMethod.Get))
    {

#line default
#line hidden
            BeginContext(232, 178, true);
            WriteLiteral("    <p>\r\n        <table>\r\n            <tr>\r\n                <td align=\"right\">\r\n                    Tipo:&nbsp;\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(411, 493, false);
#line 19 "C:\Users\NX-\Dropbox\Estudos\Desafio Mundipagg\Projeto\Desafio.Mundipagg.Docker.2\Desafio.Mundipagg.UI.Web\Views\Colecao\Index.cshtml"
               Write(Html.DropDownList("tipo", new List<SelectListItem>
                               {
                                   new SelectListItem{Text = "", Value = ""},
                                   new SelectListItem{Text = "CD", Value = "1"},
                                   new SelectListItem{Text = "DVD", Value = "2"},
                                   new SelectListItem{Text = "Livro", Value = "3"}
                               }, new { style = "width: 178px; height: 30px" }));

#line default
#line hidden
            EndContext();
            BeginContext(904, 205, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td align=\"right\">\r\n                    Palavra-chave:&nbsp;\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1110, 55, false);
#line 33 "C:\Users\NX-\Dropbox\Estudos\Desafio Mundipagg\Projeto\Desafio.Mundipagg.Docker.2\Desafio.Mundipagg.UI.Web\Views\Colecao\Index.cshtml"
               Write(Html.TextBox("search", ViewBag.CurrentSearch as string));

#line default
#line hidden
            EndContext();
            BeginContext(1165, 133, true);
            WriteLiteral("\r\n                    <input type=\"submit\" value=\"Filtrar\" />\r\n                </td>\r\n            </tr>\r\n        </table>\r\n    </p>\r\n");
            EndContext();
#line 39 "C:\Users\NX-\Dropbox\Estudos\Desafio Mundipagg\Projeto\Desafio.Mundipagg.Docker.2\Desafio.Mundipagg.UI.Web\Views\Colecao\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1305, 104, true);
            WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1410, 111, false);
#line 44 "C:\Users\NX-\Dropbox\Estudos\Desafio Mundipagg\Projeto\Desafio.Mundipagg.Docker.2\Desafio.Mundipagg.UI.Web\Views\Colecao\Index.cshtml"
               Write(Html.ActionLink("Id", "Index", new { order = "1", search = ViewBag.CurrentSearch, tipo = ViewBag.CurrentTipo }));

#line default
#line hidden
            EndContext();
            BeginContext(1521, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1589, 115, false);
#line 47 "C:\Users\NX-\Dropbox\Estudos\Desafio Mundipagg\Projeto\Desafio.Mundipagg.Docker.2\Desafio.Mundipagg.UI.Web\Views\Colecao\Index.cshtml"
               Write(Html.ActionLink("Título", "Index", new { order = "2", search = ViewBag.CurrentSearch, tipo = ViewBag.CurrentTipo }));

#line default
#line hidden
            EndContext();
            BeginContext(1704, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1772, 113, false);
#line 50 "C:\Users\NX-\Dropbox\Estudos\Desafio Mundipagg\Projeto\Desafio.Mundipagg.Docker.2\Desafio.Mundipagg.UI.Web\Views\Colecao\Index.cshtml"
               Write(Html.ActionLink("Tipo", "Index", new { order = "3", search = ViewBag.CurrentSearch, tipo = ViewBag.CurrentTipo }));

#line default
#line hidden
            EndContext();
            BeginContext(1885, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1953, 120, false);
#line 53 "C:\Users\NX-\Dropbox\Estudos\Desafio Mundipagg\Projeto\Desafio.Mundipagg.Docker.2\Desafio.Mundipagg.UI.Web\Views\Colecao\Index.cshtml"
               Write(Html.ActionLink("Localização", "Index", new { order = "4", search = ViewBag.CurrentSearch, tipo = ViewBag.CurrentTipo }));

#line default
#line hidden
            EndContext();
            BeginContext(2073, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(2141, 115, false);
#line 56 "C:\Users\NX-\Dropbox\Estudos\Desafio Mundipagg\Projeto\Desafio.Mundipagg.Docker.2\Desafio.Mundipagg.UI.Web\Views\Colecao\Index.cshtml"
               Write(Html.ActionLink("Status", "Index", new { order = "5", search = ViewBag.CurrentSearch, tipo = ViewBag.CurrentTipo }));

#line default
#line hidden
            EndContext();
            BeginContext(2256, 106, true);
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 62 "C:\Users\NX-\Dropbox\Estudos\Desafio Mundipagg\Projeto\Desafio.Mundipagg.Docker.2\Desafio.Mundipagg.UI.Web\Views\Colecao\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(2419, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2492, 37, false);
#line 66 "C:\Users\NX-\Dropbox\Estudos\Desafio Mundipagg\Projeto\Desafio.Mundipagg.Docker.2\Desafio.Mundipagg.UI.Web\Views\Colecao\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2529, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2609, 41, false);
#line 69 "C:\Users\NX-\Dropbox\Estudos\Desafio Mundipagg\Projeto\Desafio.Mundipagg.Docker.2\Desafio.Mundipagg.UI.Web\Views\Colecao\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Titulo));

#line default
#line hidden
            EndContext();
            BeginContext(2650, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2730, 39, false);
#line 72 "C:\Users\NX-\Dropbox\Estudos\Desafio Mundipagg\Projeto\Desafio.Mundipagg.Docker.2\Desafio.Mundipagg.UI.Web\Views\Colecao\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Tipo));

#line default
#line hidden
            EndContext();
            BeginContext(2769, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2849, 46, false);
#line 75 "C:\Users\NX-\Dropbox\Estudos\Desafio Mundipagg\Projeto\Desafio.Mundipagg.Docker.2\Desafio.Mundipagg.UI.Web\Views\Colecao\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Localizacao));

#line default
#line hidden
            EndContext();
            BeginContext(2895, 55, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
            EndContext();
#line 78 "C:\Users\NX-\Dropbox\Estudos\Desafio Mundipagg\Projeto\Desafio.Mundipagg.Docker.2\Desafio.Mundipagg.UI.Web\Views\Colecao\Index.cshtml"
                         if (item.Status == "Emprestado")
                        {
                            

#line default
#line hidden
            BeginContext(3065, 91, false);
#line 80 "C:\Users\NX-\Dropbox\Estudos\Desafio Mundipagg\Projeto\Desafio.Mundipagg.Docker.2\Desafio.Mundipagg.UI.Web\Views\Colecao\Index.cshtml"
                       Write(Html.ActionLink("Emprestado", "DetailsByColecao", "Emprestimo", new { id = item.Id }, null));

#line default
#line hidden
            EndContext();
#line 80 "C:\Users\NX-\Dropbox\Estudos\Desafio Mundipagg\Projeto\Desafio.Mundipagg.Docker.2\Desafio.Mundipagg.UI.Web\Views\Colecao\Index.cshtml"
                                                                                                                        
                        }
                        else
                        {
                            

#line default
#line hidden
            BeginContext(3271, 41, false);
#line 84 "C:\Users\NX-\Dropbox\Estudos\Desafio Mundipagg\Projeto\Desafio.Mundipagg.Docker.2\Desafio.Mundipagg.UI.Web\Views\Colecao\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
#line 84 "C:\Users\NX-\Dropbox\Estudos\Desafio Mundipagg\Projeto\Desafio.Mundipagg.Docker.2\Desafio.Mundipagg.UI.Web\Views\Colecao\Index.cshtml"
                                                                      
                        }

#line default
#line hidden
            BeginContext(3341, 53, true);
            WriteLiteral("                    </td>\r\n                    <td>\r\n");
            EndContext();
#line 88 "C:\Users\NX-\Dropbox\Estudos\Desafio Mundipagg\Projeto\Desafio.Mundipagg.Docker.2\Desafio.Mundipagg.UI.Web\Views\Colecao\Index.cshtml"
                          
                            string controller = (item.Tipo.ToUpper() == "LIVRO") ? "Livro" : "Midia";
                        

#line default
#line hidden
            BeginContext(3552, 55, true);
            WriteLiteral("                            \r\n                         ");
            EndContext();
            BeginContext(3608, 72, false);
#line 92 "C:\Users\NX-\Dropbox\Estudos\Desafio Mundipagg\Projeto\Desafio.Mundipagg.Docker.2\Desafio.Mundipagg.UI.Web\Views\Colecao\Index.cshtml"
                    Write(Html.ActionLink("Details", "Details", @controller, new {  id=item.Id  }));

#line default
#line hidden
            EndContext();
            BeginContext(3680, 29, true);
            WriteLiteral(" |\r\n                         ");
            EndContext();
            BeginContext(3710, 147, false);
#line 93 "C:\Users\NX-\Dropbox\Estudos\Desafio Mundipagg\Projeto\Desafio.Mundipagg.Docker.2\Desafio.Mundipagg.UI.Web\Views\Colecao\Index.cshtml"
                    Write(Html.ActionLink("Delete", "Delete", @controller, new {  id=item.Id  }, new { onclick = "javascript:return confirm('Realmente deseja excluir?');" }));

#line default
#line hidden
            EndContext();
            BeginContext(3857, 54, true);
            WriteLiteral("\r\n\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 97 "C:\Users\NX-\Dropbox\Estudos\Desafio Mundipagg\Projeto\Desafio.Mundipagg.Docker.2\Desafio.Mundipagg.UI.Web\Views\Colecao\Index.cshtml"
              }

#line default
#line hidden
            BeginContext(3928, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Desafio.Mundipagg.UI.Web.Models.Colecao>> Html { get; private set; }
    }
}
#pragma warning restore 1591
