#pragma checksum "F:\Desenvolvimento\Entrevista\GameStore\web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf66bcea508f5e44d9c480f571e81a2772df7de7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "F:\Desenvolvimento\Entrevista\GameStore\web\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#line 2 "F:\Desenvolvimento\Entrevista\GameStore\web\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf66bcea508f5e44d9c480f571e81a2772df7de7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 32, true);
            WriteLiteral("<div class=\"row\">\r\n    <tbody>\r\n");
            EndContext();
#line 3 "F:\Desenvolvimento\Entrevista\GameStore\web\Views\Home\Index.cshtml"
         foreach (var item in @ViewBag.games)
        {

#line default
#line hidden
            BeginContext(90, 140, true);
            WriteLiteral("            <div class=\"col-lg-4 col-md-6 mb-4\">\r\n                <div class=\"card h-100\">\r\n                    <a><img class=\"card-img-top\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 230, "\"", 248, 1);
#line 7 "F:\Desenvolvimento\Entrevista\GameStore\web\Views\Home\Index.cshtml"
WriteAttributeValue("", 236, item.imagem, 236, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(249, 131, true);
            WriteLiteral(" alt=\"\"></a>\r\n                    <div class=\"card-body\">\r\n                    <h4 class=\"card-title\">\r\n                        <a>");
            EndContext();
            BeginContext(381, 9, false);
#line 10 "F:\Desenvolvimento\Entrevista\GameStore\web\Views\Home\Index.cshtml"
                      Write(item.nome);

#line default
#line hidden
            EndContext();
            BeginContext(390, 88, true);
            WriteLiteral(" </a>\r\n                    </h4>\r\n                    <hr>\r\n                    <h6 >R$ ");
            EndContext();
            BeginContext(479, 10, false);
#line 13 "F:\Desenvolvimento\Entrevista\GameStore\web\Views\Home\Index.cshtml"
                       Write(item.preco);

#line default
#line hidden
            EndContext();
            BeginContext(489, 88, true);
            WriteLiteral("</h6>\r\n                    </div>\r\n                    <div>\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 577, "\"", 610, 2);
            WriteAttributeValue("", 584, "/Home/AdcCarrinho/", 584, 18, true);
#line 16 "F:\Desenvolvimento\Entrevista\GameStore\web\Views\Home\Index.cshtml"
WriteAttributeValue("", 602, item.id, 602, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(611, 139, true);
            WriteLiteral(" class=\"btn btn-primary btn-lg btn-block\">Colocar no Carrinho</a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 20 "F:\Desenvolvimento\Entrevista\GameStore\web\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(761, 108, true);
            WriteLiteral("    </tbody>\r\n\r\n</div>\r\n\r\n<style>\r\n    h6 {\r\n        color: #66ff33;\r\n        float: right;\r\n    }\r\n</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
