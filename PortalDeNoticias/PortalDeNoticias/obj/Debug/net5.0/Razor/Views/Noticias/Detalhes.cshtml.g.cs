#pragma checksum "E:\Projetos\ASP_Portal_de_Noticias\PortalDeNoticias\PortalDeNoticias\Views\Noticias\Detalhes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02972579be591dba9330b5b10f3ac71e9a505c27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Noticias_Detalhes), @"mvc.1.0.view", @"/Views/Noticias/Detalhes.cshtml")]
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
#line 1 "E:\Projetos\ASP_Portal_de_Noticias\PortalDeNoticias\PortalDeNoticias\Views\_ViewImports.cshtml"
using PortalDeNoticias;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Projetos\ASP_Portal_de_Noticias\PortalDeNoticias\PortalDeNoticias\Views\_ViewImports.cshtml"
using PortalDeNoticias.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02972579be591dba9330b5b10f3ac71e9a505c27", @"/Views/Noticias/Detalhes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a8fe37f96e4d6d843c0ab409121da325e3b99c1", @"/Views/_ViewImports.cshtml")]
    public class Views_Noticias_Detalhes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PortalDeNoticias.Models.Noticia>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Projetos\ASP_Portal_de_Noticias\PortalDeNoticias\PortalDeNoticias\Views\Noticias\Detalhes.cshtml"
  
	ViewData["Title"] = "Detalhes da notícia";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card mb-3\">\r\n\t<img class=\"card-img-top\" src=\"https://fakeimg.pl/900x600?text=Noticia+Placeholder\" alt=\"Card image cap\">\r\n\t<div class=\"card-body\">\r\n\t\t<h5 class=\"card-title\">");
#nullable restore
#line 10 "E:\Projetos\ASP_Portal_de_Noticias\PortalDeNoticias\PortalDeNoticias\Views\Noticias\Detalhes.cshtml"
                          Write(Model.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\t\t<p class=\"card-text\">");
#nullable restore
#line 11 "E:\Projetos\ASP_Portal_de_Noticias\PortalDeNoticias\PortalDeNoticias\Views\Noticias\Detalhes.cshtml"
                        Write(Model.Conteudo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t<p class=\"card-text\"><small class=\"text-muted\">Publicado por <strong>");
#nullable restore
#line 12 "E:\Projetos\ASP_Portal_de_Noticias\PortalDeNoticias\PortalDeNoticias\Views\Noticias\Detalhes.cshtml"
                                                                        Write(Model.Autor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> em <strong>");
#nullable restore
#line 12 "E:\Projetos\ASP_Portal_de_Noticias\PortalDeNoticias\PortalDeNoticias\Views\Noticias\Detalhes.cshtml"
                                                                                                         Write(Model.Data.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></small></p>\r\n\t</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PortalDeNoticias.Models.Noticia> Html { get; private set; }
    }
}
#pragma warning restore 1591
