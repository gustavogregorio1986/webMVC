#pragma checksum "C:\MVCProjeto\webMVC\WebMVC\Views\Cadastro\Cadastrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5cac2b9760ff9198375dcfe5762e2674f01dcb3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cadastro_Cadastrar), @"mvc.1.0.view", @"/Views/Cadastro/Cadastrar.cshtml")]
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
#line 1 "C:\MVCProjeto\webMVC\WebMVC\Views\_ViewImports.cshtml"
using WebMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MVCProjeto\webMVC\WebMVC\Views\_ViewImports.cshtml"
using WebMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5cac2b9760ff9198375dcfe5762e2674f01dcb3", @"/Views/Cadastro/Cadastrar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d07e873f05b36c9d83cd6a184d4bfbe1720fee4b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cadastro_Cadastrar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebMVC.Models.PassageiroView>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline my-2 my-lg-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\MVCProjeto\webMVC\WebMVC\Views\Cadastro\Cadastrar.cshtml"
  
    ViewData["Title"] = "Cadastrar";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container-fluid"">
<nav class=""navbar navbar-expand-lg navbar-light bg-light"">
  <a class=""navbar-brand"" href=""#"">Navbar</a>
  <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
    <span class=""navbar-toggler-icon""></span>
  </button>

  <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
    <ul class=""navbar-nav mr-auto"">
      <li class=""nav-item active"">
        <a class=""nav-link""");
            BeginWriteAttribute("href", " href=\"", 706, "\"", 745, 1);
#nullable restore
#line 18 "C:\MVCProjeto\webMVC\WebMVC\Views\Cadastro\Cadastrar.cshtml"
WriteAttributeValue("", 713, Url.Action("Inicio", "Inicial"), 713, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Home <span class=\"sr-only\">(current)</span></a>\r\n      </li>\r\n      <li class=\"nav-item\">\r\n        <a class=\"nav-link\"");
            BeginWriteAttribute("href", " href=\"", 865, "\"", 908, 1);
#nullable restore
#line 21 "C:\MVCProjeto\webMVC\WebMVC\Views\Cadastro\Cadastrar.cshtml"
WriteAttributeValue("", 872, Url.Action("Cadastrar", "Cadastro"), 872, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Cadastro</a>\r\n      </li>\r\n      <li class=\"nav-item\">\r\n        <a class=\"nav-link\"");
            BeginWriteAttribute("href", " href=\"", 993, "\"", 1036, 1);
#nullable restore
#line 24 "C:\MVCProjeto\webMVC\WebMVC\Views\Cadastro\Cadastrar.cshtml"
WriteAttributeValue("", 1000, Url.Action("Consultar", "Consulta"), 1000, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Consulta</a>\r\n      </li>\r\n      <li class=\"nav-item\">\r\n        <a class=\"nav-link\"");
            BeginWriteAttribute("href", " href=\"", 1121, "\"", 1164, 1);
#nullable restore
#line 27 "C:\MVCProjeto\webMVC\WebMVC\Views\Cadastro\Cadastrar.cshtml"
WriteAttributeValue("", 1128, Url.Action("Pesquisar", "Pesquisa"), 1128, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Pesquisa</a>\r\n      </li>\r\n    </ul>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5cac2b9760ff9198375dcfe5762e2674f01dcb36205", async() => {
                WriteLiteral("\r\n      <input class=\"form-control mr-sm-2\" type=\"search\" placeholder=\"Search\" aria-label=\"Search\">\r\n      <button class=\"btn btn-outline-success my-2 my-sm-0\" type=\"submit\">Search</button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n  </div>\r\n</nav>\r\n<hr/>\r\n<div class=\"modal-dialog\">\r\n    <div class=\"modal-content\">\r\n");
#nullable restore
#line 39 "C:\MVCProjeto\webMVC\WebMVC\Views\Cadastro\Cadastrar.cshtml"
         using (Html.BeginForm())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"modal-header\">\r\n                <h4 class=\"modal-title\">Cadastrar a passagem</h4>\r\n            </div>\r\n");
#nullable restore
#line 45 "C:\MVCProjeto\webMVC\WebMVC\Views\Cadastro\Cadastrar.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"modal-body\">\r\n            <div class=\"form-horizontal\">\r\n                ");
#nullable restore
#line 49 "C:\MVCProjeto\webMVC\WebMVC\Views\Cadastro\Cadastrar.cshtml"
           Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"form-group\">\r\n                    <label><span class=\"control-label col-md-3\">Nome do Passageiro</span></label>\r\n                    <div class=\"col-md-9\">\r\n                        ");
#nullable restore
#line 53 "C:\MVCProjeto\webMVC\WebMVC\Views\Cadastro\Cadastrar.cshtml"
                   Write(Html.TextBoxFor(model => model.NomePssageiro, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 54 "C:\MVCProjeto\webMVC\WebMVC\Views\Cadastro\Cadastrar.cshtml"
                   Write(Html.ValidationMessageFor(model => model.NomePssageiro));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>

                 <div class=""form-group"">
                    <label><span class=""control-label col-md-3"">Email do Passageiro</span></label>
                    <div class=""col-md-9"">
                        ");
#nullable restore
#line 61 "C:\MVCProjeto\webMVC\WebMVC\Views\Cadastro\Cadastrar.cshtml"
                   Write(Html.TextBoxFor(model => model.EmailPassageiro, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 62 "C:\MVCProjeto\webMVC\WebMVC\Views\Cadastro\Cadastrar.cshtml"
                   Write(Html.ValidationMessageFor(model => model.EmailPassageiro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    <label><span class=\"control-label col-md-3\">Sexo</span></label>\r\n                    <div class=\"col-md-9\">\r\n                        ");
#nullable restore
#line 69 "C:\MVCProjeto\webMVC\WebMVC\Views\Cadastro\Cadastrar.cshtml"
                   Write(Html.DropDownListFor(model => model.Sexo, new List<SelectListItem>
                        {
                            new SelectListItem() {Text = "select..", Value=""},
                           new SelectListItem() {Text = "Masculino", Value="masculino"},
                           new SelectListItem() {Text = "Feminino", Value="feminino"}
                        },new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n                        ");
#nullable restore
#line 75 "C:\MVCProjeto\webMVC\WebMVC\Views\Cadastro\Cadastrar.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Sexo));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
                  <div class=""form-group"">
                    <label><span class=""control-label col-md-3"">Telefone do Passageiro</span></label>
                    <div class=""col-md-9"">
                        ");
#nullable restore
#line 81 "C:\MVCProjeto\webMVC\WebMVC\Views\Cadastro\Cadastrar.cshtml"
                   Write(Html.TextBoxFor(model => model.Telefone, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 82 "C:\MVCProjeto\webMVC\WebMVC\Views\Cadastro\Cadastrar.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Telefone));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>

                 <div class=""form-group"">
                    <label><span class=""control-label col-md-3"">Logradouro</span></label>
                    <div class=""col-md-9"">
                        ");
#nullable restore
#line 89 "C:\MVCProjeto\webMVC\WebMVC\Views\Cadastro\Cadastrar.cshtml"
                   Write(Html.TextBoxFor(model => model.enderecoView.Logradouro, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 90 "C:\MVCProjeto\webMVC\WebMVC\Views\Cadastro\Cadastrar.cshtml"
                   Write(Html.ValidationMessageFor(model => model.enderecoView.Logradouro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    <label><span class=\"control-label col-md-3\">Bairro</span></label>\r\n                    <div class=\"col-md-9\">\r\n                        ");
#nullable restore
#line 97 "C:\MVCProjeto\webMVC\WebMVC\Views\Cadastro\Cadastrar.cshtml"
                   Write(Html.TextBoxFor(model => model.enderecoView.Bairro, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 98 "C:\MVCProjeto\webMVC\WebMVC\Views\Cadastro\Cadastrar.cshtml"
                   Write(Html.ValidationMessageFor(model => model.enderecoView.Bairro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    <label><span class=\"control-label col-md-3\">Cidade</span></label>\r\n                    <div class=\"col-md-9\">\r\n                        ");
#nullable restore
#line 105 "C:\MVCProjeto\webMVC\WebMVC\Views\Cadastro\Cadastrar.cshtml"
                   Write(Html.TextBoxFor(model => model.enderecoView.Cidade, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 106 "C:\MVCProjeto\webMVC\WebMVC\Views\Cadastro\Cadastrar.cshtml"
                   Write(Html.ValidationMessageFor(model => model.enderecoView.Cidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    <label><span class=\"control-label col-md-3\">Uf</span></label>\r\n                    <div class=\"col-md-9\">\r\n                        ");
#nullable restore
#line 113 "C:\MVCProjeto\webMVC\WebMVC\Views\Cadastro\Cadastrar.cshtml"
                   Write(Html.TextBoxFor(model => model.enderecoView.Uf, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 114 "C:\MVCProjeto\webMVC\WebMVC\Views\Cadastro\Cadastrar.cshtml"
                   Write(Html.ValidationMessageFor(model => model.enderecoView.Uf));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>

                <div class=""form-group"">
                    <label><span class=""control-label col-md-3"">Nome do Aeroporto</span></label>
                    <div class=""col-md-9"">
                        ");
#nullable restore
#line 121 "C:\MVCProjeto\webMVC\WebMVC\Views\Cadastro\Cadastrar.cshtml"
                   Write(Html.TextBoxFor(model => model.aeroportoView.NomeAero, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 122 "C:\MVCProjeto\webMVC\WebMVC\Views\Cadastro\Cadastrar.cshtml"
                   Write(Html.ValidationMessageFor(model => model.aeroportoView.NomeAero));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>

                 <div class=""form-group"">
                    <label><span class=""control-label col-md-3"">Data de entrada</span></label>
                    <div class=""col-md-9"">
                        ");
#nullable restore
#line 129 "C:\MVCProjeto\webMVC\WebMVC\Views\Cadastro\Cadastrar.cshtml"
                   Write(Html.TextBoxFor(model => model.aeroportoView.DataEntrada, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 130 "C:\MVCProjeto\webMVC\WebMVC\Views\Cadastro\Cadastrar.cshtml"
                   Write(Html.ValidationMessageFor(model => model.aeroportoView.DataEntrada));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    <label><span class=\"control-label col-md-3\">Compania</span></label>\r\n                    <div class=\"col-md-9\">\r\n                        ");
#nullable restore
#line 137 "C:\MVCProjeto\webMVC\WebMVC\Views\Cadastro\Cadastrar.cshtml"
                   Write(Html.TextBoxFor(model => model.aeroportoView.aviaoView.Compania, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 138 "C:\MVCProjeto\webMVC\WebMVC\Views\Cadastro\Cadastrar.cshtml"
                   Write(Html.ValidationMessageFor(model => model.aeroportoView.aviaoView.Compania));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>

                <div class=""form-group"">
                    <label><span class=""control-label col-md-3"">Nome do Aviao</span></label>
                    <div class=""col-md-9"">
                        ");
#nullable restore
#line 145 "C:\MVCProjeto\webMVC\WebMVC\Views\Cadastro\Cadastrar.cshtml"
                   Write(Html.TextBoxFor(model => model.aeroportoView.aviaoView.NomeAviao, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 146 "C:\MVCProjeto\webMVC\WebMVC\Views\Cadastro\Cadastrar.cshtml"
                   Write(Html.ValidationMessageFor(model => model.aeroportoView.aviaoView.NomeAviao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    <label><span class=\"control-label col-md-3\">Portão</span></label>\r\n                    <div class=\"col-md-9\">\r\n                        ");
#nullable restore
#line 153 "C:\MVCProjeto\webMVC\WebMVC\Views\Cadastro\Cadastrar.cshtml"
                   Write(Html.TextBoxFor(model => model.aeroportoView.aviaoView.Portao, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 154 "C:\MVCProjeto\webMVC\WebMVC\Views\Cadastro\Cadastrar.cshtml"
                   Write(Html.ValidationMessageFor(model => model.aeroportoView.aviaoView.Portao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    <label><span class=\"control-label col-md-3\">Origem</span></label>\r\n                    <div class=\"col-md-9\">\r\n                        ");
#nullable restore
#line 161 "C:\MVCProjeto\webMVC\WebMVC\Views\Cadastro\Cadastrar.cshtml"
                   Write(Html.DropDownListFor(model => model.aeroportoView.aviaoView.origemView.CidadwOrigem, new List<SelectListItem>
                        {
                           new SelectListItem() {Text = "select..", Value=""},
                           new SelectListItem() {Text = "Rio de Janeiro", Value="RJ"},
                           new SelectListItem() {Text = "São Paulo", Value="SP"},
                           new SelectListItem() {Text = "Campinas", Value="campinas"},
                           new SelectListItem() {Text = "Joivile", Value="Joivile"},
                           new SelectListItem() {Text = "Aracaju", Value="Aracaju"},
                           new SelectListItem() {Text = "Salvador", Value="Salvador"},
                           new SelectListItem() {Text = "Fortaleza", Value="Fortaleza"},
                           new SelectListItem() {Text = "Curitiba", Value="Curitiba"},
                           new SelectListItem() {Text = "Blumenal", Value="Blumenal"},
                           new SelectListItem() {Text = "Gramado", Value="Gramado"},
                           new SelectListItem() {Text = "Natal", Value="Natal"},
                           new SelectListItem() {Text = "Pernmbuco", Value="Pernmbuco"}
                        },new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  
                    </div>
                </div>

                <div class=""form-group"">
                    <label><span class=""control-label col-md-3"">Destino</span></label>
                    <div class=""col-md-9"">
                        ");
#nullable restore
#line 183 "C:\MVCProjeto\webMVC\WebMVC\Views\Cadastro\Cadastrar.cshtml"
                   Write(Html.DropDownListFor(model => model.aeroportoView.aviaoView.origemView.CidadwOrigem, new List<SelectListItem>
                        {
                           new SelectListItem() {Text = "select..", Value=""},
                           new SelectListItem() {Text = "Rio de Janeiro", Value="RJ"},
                           new SelectListItem() {Text = "São Paulo", Value="SP"},
                           new SelectListItem() {Text = "Campinas", Value="campinas"},
                           new SelectListItem() {Text = "Joivile", Value="Joivile"},
                           new SelectListItem() {Text = "Aracaju", Value="Aracaju"},
                           new SelectListItem() {Text = "Salvador", Value="Salvador"},
                           new SelectListItem() {Text = "Fortaleza", Value="Fortaleza"},
                           new SelectListItem() {Text = "Curitiba", Value="Curitiba"},
                           new SelectListItem() {Text = "Blumenal", Value="Blumenal"},
                           new SelectListItem() {Text = "Gramado", Value="Gramado"},
                           new SelectListItem() {Text = "Natal", Value="Natal"},
                           new SelectListItem() {Text = "Pernmbuco", Value="Pernmbuco"}
                        },new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                        ");
#nullable restore
#line 199 "C:\MVCProjeto\webMVC\WebMVC\Views\Cadastro\Cadastrar.cshtml"
                   Write(Html.ValidationMessageFor(model => model.aeroportoView.aviaoView.destinoView.CidadwDestino));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>

            </div>

        </div>
            <div class=""modal-footer"">
                <input type=""submit"" value=""Salvar"" class=""btn btn-primary"" onclick=""CadastrarDados(passageiroVM, enderecoView, aeroportoVM, aviaoVM, origemVM, destinoVM)""/>
                <input type=""button"" value=""Cancelar"" class=""btn btn-default"" data-dismiss=""modal""/>            
            </div>
");
#nullable restore
#line 210 "C:\MVCProjeto\webMVC\WebMVC\Views\Cadastro\Cadastrar.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div><!-- /.modal-content -->\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebMVC.Models.PassageiroView> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
