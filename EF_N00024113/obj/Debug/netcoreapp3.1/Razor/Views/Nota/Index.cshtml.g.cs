#pragma checksum "D:\Visual studio\EF_N00024113\EF_N00024113\Views\Nota\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cba68040fffe665431a11b4331197b67a910015"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Nota_Index), @"mvc.1.0.view", @"/Views/Nota/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cba68040fffe665431a11b4331197b67a910015", @"/Views/Nota/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee645991588c44cfec29550c41e0f6f309177185", @"/Views/_ViewImports.cshtml")]
    public class Views_Nota_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
            WriteLiteral(@"293H2z"" />
#nullable restore
#line 20 "D:\Visual studio\EF_N00024113\EF_N00024113\Views\Nota\Index.cshtml"
             foreach (var eti in ViewBag.Etiquetas)

#line default
#line hidden
#nullable disable
            WriteLiteral("<ul class=\"nav navbar-nav\">\r    <li><a class=\"text-white\" style=\"font-size:small\" href=\"#\">");
#nullable restore
#line 23 "D:\Visual studio\EF_N00024113\EF_N00024113\Views\Nota\Index.cshtml"
                                                          Write(eti.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r</ul>");
#nullable restore
#line 24 "D:\Visual studio\EF_N00024113\EF_N00024113\Views\Nota\Index.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
            WriteLiteral("dal\">Cancelar</button>\r                <button type=\"button\" class=\"btn btn-primary\" onclick=\"submitFormCreate()\">Guardar</button>\r            </div>\r        </div>\r    </div>\r</div>\r");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
                WriteLiteral(".html(notas);\r            });\r        }\r\r        $(\'#buscar\').click(function (e) {\r            e.preventDefault();\r            init();\r        });\r        init();\r    </script>\r");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591