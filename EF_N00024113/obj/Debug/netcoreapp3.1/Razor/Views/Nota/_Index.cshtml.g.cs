#pragma checksum "D:\Visual studio\EF_N00024113\EF_N00024113\Views\Nota\_Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "495ce999268b0b5bede082051c7dc591ff5ad8b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Nota__Index), @"mvc.1.0.view", @"/Views/Nota/_Index.cshtml")]
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
#line 1 "D:\Visual studio\EF_N00024113\EF_N00024113\Views\_ViewImports.cshtml"
using EF_N00024113;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Visual studio\EF_N00024113\EF_N00024113\Views\_ViewImports.cshtml"
using EF_N00024113.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"495ce999268b0b5bede082051c7dc591ff5ad8b8", @"/Views/Nota/_Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee645991588c44cfec29550c41e0f6f309177185", @"/Views/_ViewImports.cshtml")]
    public class Views_Nota__Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Visual studio\EF_N00024113\EF_N00024113\Views\Nota\_Index.cshtml"
  
    Layout = null;
    var nota = (List<Nota>)Model;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\Visual studio\EF_N00024113\EF_N00024113\Views\Nota\_Index.cshtml"
 foreach (var item in nota)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container-fluid\">\r\n\r\n        <ul class=\"list-group\">\r\n            <li class=\"list-group-item\">\r\n                <br />\r\n                <span>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 278, "\"", 310, 2);
            WriteAttributeValue("", 285, "/Nota/Detalle?Id=", 285, 17, true);
#nullable restore
#line 14 "D:\Visual studio\EF_N00024113\EF_N00024113\Views\Nota\_Index.cshtml"
WriteAttributeValue("", 302, item.Id, 302, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><strong>");
#nullable restore
#line 14 "D:\Visual studio\EF_N00024113\EF_N00024113\Views\Nota\_Index.cshtml"
                                                           Write(item.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></a>\r\n                    <br />\r\n                    <span>\r\n                        <strong>Cuerpo: </strong>\r\n");
#nullable restore
#line 18 "D:\Visual studio\EF_N00024113\EF_N00024113\Views\Nota\_Index.cshtml"
                         if (item.Contenido.Length > 50)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <parcial>");
#nullable restore
#line 20 "D:\Visual studio\EF_N00024113\EF_N00024113\Views\Nota\_Index.cshtml"
                                Write(item.Contenido.Substring(0, 50));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ...</parcial> ");
#nullable restore
#line 20 "D:\Visual studio\EF_N00024113\EF_N00024113\Views\Nota\_Index.cshtml"
                                                                                    }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <parcial>");
#nullable restore
#line 23 "D:\Visual studio\EF_N00024113\EF_N00024113\Views\Nota\_Index.cshtml"
                                Write(item.Contenido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</parcial>\r\n");
#nullable restore
#line 24 "D:\Visual studio\EF_N00024113\EF_N00024113\Views\Nota\_Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </span>\r\n                </span>\r\n\r\n                <br />\r\n                <div align=\"right\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 913, "\"", 946, 2);
            WriteAttributeValue("", 920, "/Nota/Eliminar?id=", 920, 18, true);
#nullable restore
#line 30 "D:\Visual studio\EF_N00024113\EF_N00024113\Views\Nota\_Index.cshtml"
WriteAttributeValue("", 938, item.Id, 938, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"margin-left:20px;\" class=\"btn btn-success\">Eliminar</a>\r\n                    <a style=\"margin-right:20px;\" class=\"btn btn-primary float-lg-right\" href=\"#\" data-toggle=\"modal\" data-target=\"#edit\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1149, "\"", 1213, 7);
            WriteAttributeValue("", 1159, "selCuenta(\'", 1159, 11, true);
#nullable restore
#line 31 "D:\Visual studio\EF_N00024113\EF_N00024113\Views\Nota\_Index.cshtml"
WriteAttributeValue("", 1170, item.Id, 1170, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1178, "\',\'", 1178, 3, true);
#nullable restore
#line 31 "D:\Visual studio\EF_N00024113\EF_N00024113\Views\Nota\_Index.cshtml"
WriteAttributeValue("", 1181, item.Titulo, 1181, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1193, "\',\'", 1193, 3, true);
#nullable restore
#line 31 "D:\Visual studio\EF_N00024113\EF_N00024113\Views\Nota\_Index.cshtml"
WriteAttributeValue("", 1196, item.Contenido, 1196, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1211, "\')", 1211, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Editar</a>\r\n                </div>\r\n            </li>\r\n        </ul>\r\n        <br />\r\n    </div>\r\n");
#nullable restore
#line 37 "D:\Visual studio\EF_N00024113\EF_N00024113\Views\Nota\_Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Modal -->
<div class=""modal fade"" id=""edit"" tabindex=""-1"" aria-labelledby=""edit"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Editar Nota</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"" id=""editNotita"">
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancelar</button>
                <button type=""button"" class=""btn btn-primary"" onclick=""Editando()"">Guardar</button>
            </div>
        </div>
    </div>
</div>

<script>
    function selCuenta(id, titulo, contenido) {
        $('#mtxtId').val(id);
        $('#mtxTitulo').val(titulo);
        $('#mtxCont");
            WriteLiteral(@"edido').val(contenido);
    };

    $.ajax({
        url: '/Nota/Edit',
        type: 'get'
    }).done(function (html) {
        $('#editNotita').html(html);
    })

    function Editando() {
        $('#editNota').submit();
    }

    function editar(event) {
        event.preventDefault();
        var dataString = new FormData($('#edit form')[0]);
        $.ajax({
            url: ""/Nota/Edit"",
            type: ""post"",
            processData: false,  // Important!
            contentType: false,
            cache: false,
            data: dataString
        }).done(function (html) {
            location.reload();
        }).fail(function (html) {
            $('#editNotita').html(html.responseText);
        });
    }
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591