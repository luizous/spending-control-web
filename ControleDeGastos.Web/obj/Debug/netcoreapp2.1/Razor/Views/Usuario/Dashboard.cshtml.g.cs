#pragma checksum "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0726c423806860c1112bf61545fcafd185a84870"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Dashboard), @"mvc.1.0.view", @"/Views/Usuario/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Dashboard.cshtml", typeof(AspNetCore.Views_Usuario_Dashboard))]
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
#line 1 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\_ViewImports.cshtml"
using ControleDeGastos.Web;

#line default
#line hidden
#line 2 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\_ViewImports.cshtml"
using ControleDeGastos.Domain;

#line default
#line hidden
#line 3 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\_ViewImports.cshtml"
using ControleDeGastos.Service;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0726c423806860c1112bf61545fcafd185a84870", @"/Views/Usuario/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c1d0c3afc2fe50c127441ccd7d2370ff34a29b3", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lancamento>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Relatorio", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-outline-warning btn-round btn-icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edicao", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
  
    ViewData["Title"] = "Dashboard - Controle de Gastos";

#line default
#line hidden
            BeginContext(85, 48, true);
            WriteLiteral("\r\n<div class=\"content\">\r\n    <div class=\"row\">\r\n");
            EndContext();
            BeginContext(184, 339, true);
            WriteLiteral(@"        <div class=""col-lg-3 col-md-6 col-sm-6"">
            <div class=""card card-stats"">
                <div class=""card-body "">

                    <div class=""row"">
                        <div class=""col-5 col-md-4"">
                            <div class=""icon-big text-center icon-warning"">
                                ");
            EndContext();
            BeginContext(523, 170, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e97bcc9c39134569b5b7c4a64ab3d36f", async() => {
                BeginContext(572, 117, true);
                WriteLiteral("\r\n                                    <i class=\"nc-icon nc-paper text-warning\"></i>\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(693, 784, true);
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""col-7 col-md-8"">
                            <div class=""numbers"">
                                <p class=""card-category"">Gerar relatório por período</p>
                                <p class=""card-title""><small><small>Clique no ícone ao lado</small></small><p>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""card-footer "">
                    <hr>
                    <div class=""stats"">
                        <i class=""fa fa-calendar""></i> Não se perca nas suas finanças!
                    </div>
                </div>
            </div>
        </div>
");
            EndContext();
            BeginContext(1512, 691, true);
            WriteLiteral(@"        <div class=""col-lg-3 col-md-6 col-sm-6"">
            <div class=""card card-stats"">
                <div class=""card-body "">
                    <div class=""row"">
                        <div class=""col-5 col-md-4"">
                            <div class=""icon-big text-center icon-warning"">
                                <i class=""nc-icon nc-spaceship text-danger""></i>
                            </div>
                        </div>
                        <div class=""col-7 col-md-8"">
                            <div class=""numbers"">
                                <p class=""card-category"">Lançamentos</p>
                                <p class=""card-title"">R$ ");
            EndContext();
            BeginContext(2204, 26, false);
#line 50 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                                                    Write(ViewBag.CalculoLancamentos);

#line default
#line hidden
            EndContext();
            BeginContext(2230, 425, true);
            WriteLiteral(@"
                                <p>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""card-footer "">
                    <hr>
                    <div class=""stats"">
                        <i class=""fa fa-calendar-o""></i> Este mês
                    </div>
                </div>
            </div>
        </div>
");
            EndContext();
            BeginContext(2691, 695, true);
            WriteLiteral(@"        <div class=""col-lg-3 col-md-6 col-sm-6"">
            <div class=""card card-stats"">
                <div class=""card-body "">
                    <div class=""row"">
                        <div class=""col-5 col-md-4"">
                            <div class=""icon-big text-center icon-warning"">
                                <i class=""nc-icon nc-money-coins text-success""></i>
                            </div>
                        </div>
                        <div class=""col-7 col-md-8"">
                            <div class=""numbers"">
                                <p class=""card-category"">Recebimentos</p>
                                <p class=""card-title"">R$ ");
            EndContext();
            BeginContext(3387, 27, false);
#line 77 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                                                    Write(ViewBag.CalculoRecebimentos);

#line default
#line hidden
            EndContext();
            BeginContext(3414, 425, true);
            WriteLiteral(@"
                                <p>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""card-footer "">
                    <hr>
                    <div class=""stats"">
                        <i class=""fa fa-calendar-o""></i> Este mês
                    </div>
                </div>
            </div>
        </div>
");
            EndContext();
            BeginContext(3871, 692, true);
            WriteLiteral(@"        <div class=""col-lg-3 col-md-6 col-sm-6"">
            <div class=""card card-stats"">
                <div class=""card-body "">
                    <div class=""row"">
                        <div class=""col-5 col-md-4"">
                            <div class=""icon-big text-center icon-warning"">
                                <i class=""nc-icon nc-favourite-28 text-primary""></i>
                            </div>
                        </div>
                        <div class=""col-7 col-md-8"">
                            <div class=""numbers"">
                                <p class=""card-category"">Poupança</p>
                                <p class=""card-title"">R$ ");
            EndContext();
            BeginContext(4564, 24, false);
#line 104 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                                                    Write(ViewBag.CalculoDepositos);

#line default
#line hidden
            EndContext();
            BeginContext(4588, 816, true);
            WriteLiteral(@"
                                <p>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""card-footer "">
                    <hr>
                    <div class=""stats"">
                        <i class=""fa fa-calendar-o""></i> Este mês
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""content"">
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card"">
                <div class=""card-body"">
                    <div class=""card-header"">
                        <h5 class=""card-title"" style=""text-transform: uppercase;""><small>Últimos lançamentos <b>cadastrados</b></small></h5>
                    </div>
");
            EndContext();
#line 129 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                     if (ViewBag.Lancamentos.Count == 0)
                    {

#line default
#line hidden
            BeginContext(5485, 249, true);
            WriteLiteral("                        <p class=\"text-danger\" style=\"text-align:center;\"><b>NÃO HÁ LANÇAMENTOS CADASTRADOS</b></p>\r\n                        <p class=\"text-info\" style=\"text-align:center;\">No menu ao lado, clique em LANÇAMENTOS para cadastrar!</p>\r\n");
            EndContext();
#line 133 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(5806, 661, true);
            WriteLiteral(@"                        <div class=""table-responsive"">
                            <table class=""table"">
                                <thead class=""text-primary"">
                                <th>Valor</th>
                                <th>Lançamento</th>
                                <th>Descrição</th>
                                <th>Categoria</th>
                                <th>Qtd. parcela</th>
                                <th>Cartão</th>
                                <th>Cadastro</th>
                                <th>Editar</th>
                                </thead>
                                <tbody>
");
            EndContext();
#line 149 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                                     foreach (Lancamento item in ViewBag.Lancamentos)
                                    {

#line default
#line hidden
            BeginContext(6593, 94, true);
            WriteLiteral("                                        <tr>\r\n                                            <td>");
            EndContext();
            BeginContext(6688, 10, false);
#line 152 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                                           Write(item.Valor);

#line default
#line hidden
            EndContext();
            BeginContext(6698, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(6754, 42, false);
#line 153 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                                           Write(item.DataLancamento.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(6796, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(6852, 14, false);
#line 154 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                                           Write(item.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(6866, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(6922, 17, false);
#line 155 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                                           Write(ViewBag.Categoria);

#line default
#line hidden
            EndContext();
            BeginContext(6939, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(6995, 13, false);
#line 156 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                                           Write(item.Parcelas);

#line default
#line hidden
            EndContext();
            BeginContext(7008, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(7064, 14, false);
#line 157 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                                           Write(ViewBag.Cartao);

#line default
#line hidden
            EndContext();
            BeginContext(7078, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(7134, 40, false);
#line 158 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                                           Write(item.DataCadastro.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(7174, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(7229, 155, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71e9d6a4c3384cb3ba01506f7dd24f0c", async() => {
                BeginContext(7354, 26, true);
                WriteLiteral("<i class=\"fa fa-edit\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idLancamento", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 159 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                                                                                                                                             WriteLiteral(item.IdLancamento);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idLancamento"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idLancamento", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idLancamento"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7384, 54, true);
            WriteLiteral("</td>\r\n                                        </tr>\r\n");
            EndContext();
#line 161 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                                    }

#line default
#line hidden
            BeginContext(7477, 112, true);
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                        </div>\r\n");
            EndContext();
#line 165 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                    }

#line default
#line hidden
            BeginContext(7612, 452, true);
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>
</div>

<div class=""content"">
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card"">
                <div class=""card-body"">
                    <div class=""card-header"">
                        <h5 class=""card-title"" style=""text-transform: uppercase;""><small>Últimos recebimentos <b>cadastrados</b></small></h5>
                    </div>
");
            EndContext();
#line 180 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                     if (ViewBag.Recebimentos.Count == 0)
                    {

#line default
#line hidden
            BeginContext(8146, 251, true);
            WriteLiteral("                        <p class=\"text-danger\" style=\"text-align:center;\"><b>NÃO HÁ RECEBIMENTOS CADASTRADOS</b></p>\r\n                        <p class=\"text-info\" style=\"text-align:center;\">No menu ao lado, clique em RECEBIMENTOS para cadastrar!</p>\r\n");
            EndContext();
#line 184 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(8469, 575, true);
            WriteLiteral(@"                        <div class=""table-responsive"">
                            <table class=""table"">
                                <thead class=""text-primary"">
                                <th>Fornecedor</th>
                                <th>Descricao</th>
                                <th>Valor</th>
                                <th>Data de Recebimento</th>
                                <th>Data de cadastro</th>
                                <th>Editar</th>
                                </thead>
                                <tbody>
");
            EndContext();
#line 198 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                                     foreach (Recebimento item in ViewBag.Recebimentos)
                                    {

#line default
#line hidden
            BeginContext(9172, 94, true);
            WriteLiteral("                                        <tr>\r\n                                            <td>");
            EndContext();
            BeginContext(9267, 15, false);
#line 201 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                                           Write(item.Fornecedor);

#line default
#line hidden
            EndContext();
            BeginContext(9282, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(9338, 14, false);
#line 202 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                                           Write(item.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(9352, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(9408, 10, false);
#line 203 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                                           Write(item.Valor);

#line default
#line hidden
            EndContext();
            BeginContext(9418, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(9474, 43, false);
#line 204 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                                           Write(item.DataRecebimento.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(9517, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(9573, 40, false);
#line 205 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                                           Write(item.DataCadastro.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(9613, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(9668, 157, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc3bd0c8a0ed476d855c66036d56da13", async() => {
                BeginContext(9795, 26, true);
                WriteLiteral("<i class=\"fa fa-edit\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idRecebimento", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 206 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                                                                                                                                              WriteLiteral(item.IdRecebimento);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idRecebimento"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idRecebimento", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idRecebimento"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9825, 54, true);
            WriteLiteral("</td>\r\n                                        </tr>\r\n");
            EndContext();
#line 208 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                                    }

#line default
#line hidden
            BeginContext(9918, 112, true);
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                        </div>\r\n");
            EndContext();
#line 212 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Usuario\Dashboard.cshtml"
                    }

#line default
#line hidden
            BeginContext(10053, 80, true);
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lancamento> Html { get; private set; }
    }
}
#pragma warning restore 1591
