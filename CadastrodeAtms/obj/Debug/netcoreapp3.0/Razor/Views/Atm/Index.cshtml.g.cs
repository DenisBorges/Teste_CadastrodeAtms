#pragma checksum "C:\Users\Denis\source\repos\CadastrodeAtms\CadastrodeAtms\Views\Atm\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afac4b183b8e57a1e07b6ee104e827e3db40b25d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Atm_Index), @"mvc.1.0.view", @"/Views/Atm/Index.cshtml")]
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
#line 2 "C:\Users\Denis\source\repos\CadastrodeAtms\CadastrodeAtms\Views\_ViewImports.cshtml"
using CadastrodeAtms.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Denis\source\repos\CadastrodeAtms\CadastrodeAtms\Views\Atm\Index.cshtml"
using CadastrodeAtms;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afac4b183b8e57a1e07b6ee104e827e3db40b25d", @"/Views/Atm/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c587d9ab84eb76dc9be4a1bfd7826ba0d282797f", @"/Views/_ViewImports.cshtml")]
    public class Views_Atm_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AtmModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Denis\source\repos\CadastrodeAtms\CadastrodeAtms\Views\Atm\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Denis\source\repos\CadastrodeAtms\CadastrodeAtms\Views\Atm\Index.cshtml"
 if (Model.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table"">
        <thead>
            <tr>
                <th scope=""col"" style=""display:none"">id</th>
                <th scope=""col"">PC</th>
                <th scope=""col"">Nome</th>
                <th scope=""col"">PA</th>
                <th scope=""col"">Cidade</th>
                <th scope=""col"">UF</th>
                <th scope=""col"">Data Cadastro</th>
                <th scope=""col"">Data Atualização</th>
                <th scope=""col""></th>
            </tr>
        </thead>
        <tbody>

");
#nullable restore
#line 25 "C:\Users\Denis\source\repos\CadastrodeAtms\CadastrodeAtms\Views\Atm\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr");
            BeginWriteAttribute("id", " id=\"", 724, "\"", 737, 1);
#nullable restore
#line 27 "C:\Users\Denis\source\repos\CadastrodeAtms\CadastrodeAtms\Views\Atm\Index.cshtml"
WriteAttributeValue("", 729, item.id, 729, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <th scope=\"row\" style=\"display:none\">");
#nullable restore
#line 28 "C:\Users\Denis\source\repos\CadastrodeAtms\CadastrodeAtms\Views\Atm\Index.cshtml"
                                                    Write(item.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>");
#nullable restore
#line 29 "C:\Users\Denis\source\repos\CadastrodeAtms\CadastrodeAtms\Views\Atm\Index.cshtml"
                   Write(item.AtmPc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 30 "C:\Users\Denis\source\repos\CadastrodeAtms\CadastrodeAtms\Views\Atm\Index.cshtml"
                   Write(item.AtmNome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 31 "C:\Users\Denis\source\repos\CadastrodeAtms\CadastrodeAtms\Views\Atm\Index.cshtml"
                   Write(item.AtmPa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 32 "C:\Users\Denis\source\repos\CadastrodeAtms\CadastrodeAtms\Views\Atm\Index.cshtml"
                   Write(item.AtmCidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "C:\Users\Denis\source\repos\CadastrodeAtms\CadastrodeAtms\Views\Atm\Index.cshtml"
                   Write(item.AtmUf);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 34 "C:\Users\Denis\source\repos\CadastrodeAtms\CadastrodeAtms\Views\Atm\Index.cshtml"
                   Write(item.DataCadastro);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 35 "C:\Users\Denis\source\repos\CadastrodeAtms\CadastrodeAtms\Views\Atm\Index.cshtml"
                   Write(item.DataAtualizacao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <button class=\"btn btn-danger btn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1214, "\"", 1243, 3);
            WriteAttributeValue("", 1224, "deleteAtm(", 1224, 10, true);
#nullable restore
#line 37 "C:\Users\Denis\source\repos\CadastrodeAtms\CadastrodeAtms\Views\Atm\Index.cshtml"
WriteAttributeValue("", 1234, item.id, 1234, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1242, ")", 1242, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            Excluir\r\n                        </button>\r\n                        <button class=\"btn btn-warning btn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1378, "\"", 1405, 3);
            WriteAttributeValue("", 1388, "editAtm(", 1388, 8, true);
#nullable restore
#line 40 "C:\Users\Denis\source\repos\CadastrodeAtms\CadastrodeAtms\Views\Atm\Index.cshtml"
WriteAttributeValue("", 1396, item.id, 1396, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1404, ")", 1404, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            Editar\r\n                        </button>\r\n                    </td>\r\n                    <td>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 47 "C:\Users\Denis\source\repos\CadastrodeAtms\CadastrodeAtms\Views\Atm\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 51 "C:\Users\Denis\source\repos\CadastrodeAtms\CadastrodeAtms\Views\Atm\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>NÃO EXISTEM ATMS CADASTRADAS</h1>\r\n");
#nullable restore
#line 55 "C:\Users\Denis\source\repos\CadastrodeAtms\CadastrodeAtms\Views\Atm\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script>
        function deleteAtm(_id) {

            $.post(""../Atm/Apagar"", { id: _id }, (data) => {

                if (data) {
                    alert(""Excluído com sucesso"");

                    $(`tr#${_id}`).hide();
                } else {
                    alert(`Erro na tentativa de exclusão do item ${_id}. Tente novamente`)
                }
            }).fail(() => alert(`Erro na tentativa de exclusão do item ${_id}. Tente novamente`));

        }

        function editAtm(_id) {

            window.location.href = ""../Atm/NovoCadastro/"" + _id;

        }

    </script>

");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AtmModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
