#pragma checksum "C:\Users\vinixiii\Desktop\jksdfndfnsg\Instadev-06\Views\Amigo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "002ae8bdfe2e6d2dd259a499c7f9ef638c278b9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Amigo_Index), @"mvc.1.0.view", @"/Views/Amigo/Index.cshtml")]
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
#line 1 "C:\Users\vinixiii\Desktop\jksdfndfnsg\Instadev-06\Views\_ViewImports.cshtml"
using Instadev_06;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vinixiii\Desktop\jksdfndfnsg\Instadev-06\Views\_ViewImports.cshtml"
using Instadev_06.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"002ae8bdfe2e6d2dd259a499c7f9ef638c278b9f", @"/Views/Amigo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1f319f1c7e7f8897f7fafa50fe612e3aef97501", @"/Views/_ViewImports.cshtml")]
    public class Views_Amigo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("foto de perfil"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\vinixiii\Desktop\jksdfndfnsg\Instadev-06\Views\Amigo\Index.cshtml"
  
    ViewData["Title"] = $"Perfil de {@ViewBag.UsuarioClicado.Username}";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section id=\"info\">\r\n    <div class=\"info-container\">\r\n        <div class=\"info-content\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "002ae8bdfe2e6d2dd259a499c7f9ef638c278b9f4120", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 196, "~/img/perfil/", 196, 13, true);
#nullable restore
#line 8 "C:\Users\vinixiii\Desktop\jksdfndfnsg\Instadev-06\Views\Amigo\Index.cshtml"
AddHtmlAttributeValue("", 209, ViewBag.UsuarioClicado.Foto, 209, 28, false);

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
            WriteLiteral("\r\n            <div class=\"info-text\">\r\n                <div class=\"username\">\r\n                    <h1>");
#nullable restore
#line 11 "C:\Users\vinixiii\Desktop\jksdfndfnsg\Instadev-06\Views\Amigo\Index.cshtml"
                   Write(ViewBag.UsuarioClicado.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                    <button class=""btn1"">Seguir</button>
                </div>
                <div class=""info-numbers"">
                    <p>0 publicações</p>
                    <p>128 seguindo</p>
                    <p>214 seguidores</p>
                </div>
                <div class=""description"">
                    <p><strong>");
#nullable restore
#line 20 "C:\Users\vinixiii\Desktop\jksdfndfnsg\Instadev-06\Views\Amigo\Index.cshtml"
                          Write(ViewBag.UsuarioClicado.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<div class=\"menu-posts\">\r\n    <div class=\"menu-profile\">\r\n        <div class=\"menu-text\">\r\n            <img src=\"./img/img-perfil/squares.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 1021, "\"", 1027, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <p>Publicações</p>\r\n        </div>\r\n    </div>\r\n</div>\r\n<article id=\"posts\">\r\n    <div class=\"posts-container\">\r\n        <div class=\"posts-content\">\r\n");
#nullable restore
#line 37 "C:\Users\vinixiii\Desktop\jksdfndfnsg\Instadev-06\Views\Amigo\Index.cshtml"
             foreach (Publicacao p in ViewBag.PostAmigo)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"post-profile\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "002ae8bdfe2e6d2dd259a499c7f9ef638c278b9f7585", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1340, "~/img/publicacoes/", 1340, 18, true);
#nullable restore
#line 40 "C:\Users\vinixiii\Desktop\jksdfndfnsg\Instadev-06\Views\Amigo\Index.cshtml"
AddHtmlAttributeValue("", 1358, p.Imagem, 1358, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <div class=\"post-info\">\r\n                        <div class=\"interaction\">\r\n                            <div class=\"user-info\">\r\n");
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "002ae8bdfe2e6d2dd259a499c7f9ef638c278b9f9374", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1641, "~/img/perfil/", 1641, 13, true);
#nullable restore
#line 45 "C:\Users\vinixiii\Desktop\jksdfndfnsg\Instadev-06\Views\Amigo\Index.cshtml"
AddHtmlAttributeValue("", 1654, ViewBag.UsuarioClicado.Foto, 1654, 28, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <div class=\"username-and-location\">\r\n                                    <h2>");
#nullable restore
#line 47 "C:\Users\vinixiii\Desktop\jksdfndfnsg\Instadev-06\Views\Amigo\Index.cshtml"
                                   Write(ViewBag.UsuarioClicado.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                                    <p>Rio de Janeiro, Brazil</p>
                                </div>
                            </div>
                            <div class=""comment"">
                                <div class=""comments-text subtitle"">
                                    <h3>");
#nullable restore
#line 53 "C:\Users\vinixiii\Desktop\jksdfndfnsg\Instadev-06\Views\Amigo\Index.cshtml"
                                   Write(p.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                    <p>");
#nullable restore
#line 54 "C:\Users\vinixiii\Desktop\jksdfndfnsg\Instadev-06\Views\Amigo\Index.cshtml"
                                  Write(p.Legenda);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"like-and-comment\">\r\n                                <img id=\"1\" src=\"./img/img-perfil/like.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 2429, "\"", 2435, 0);
            EndWriteAttribute();
            WriteLiteral(" onclick=\"curtir(1)\">\r\n                                <img src=\"./img/img-perfil/comment.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 2530, "\"", 2536, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n                            <p>1954 curtidas</p>\r\n                            <ul class=\"comments\">\r\n");
#nullable restore
#line 63 "C:\Users\vinixiii\Desktop\jksdfndfnsg\Instadev-06\Views\Amigo\Index.cshtml"
                                 foreach (Comentario c in ViewBag.Comentarios)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\vinixiii\Desktop\jksdfndfnsg\Instadev-06\Views\Amigo\Index.cshtml"
                                     if(p.IdPublicacao == c.IdPublicacao)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li>\r\n                                            <div class=\"comment\">\r\n                                                <div class=\"comments-text\">\r\n                                                    <h3>");
#nullable restore
#line 70 "C:\Users\vinixiii\Desktop\jksdfndfnsg\Instadev-06\Views\Amigo\Index.cshtml"
                                                   Write(c.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                                    <p>");
#nullable restore
#line 71 "C:\Users\vinixiii\Desktop\jksdfndfnsg\Instadev-06\Views\Amigo\Index.cshtml"
                                                  Write(c.Mensagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                </div>\r\n                                                <img id=\"2\" src=\"./img/img-perfil/like.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 3389, "\"", 3395, 0);
            EndWriteAttribute();
            WriteLiteral(" onclick=\"curtir(2)\">\r\n                                            </div>\r\n                                        </li>\r\n");
#nullable restore
#line 76 "C:\Users\vinixiii\Desktop\jksdfndfnsg\Instadev-06\Views\Amigo\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Users\vinixiii\Desktop\jksdfndfnsg\Instadev-06\Views\Amigo\Index.cshtml"
                                     
                                }                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\r\n");
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 83 "C:\Users\vinixiii\Desktop\jksdfndfnsg\Instadev-06\Views\Amigo\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</article>");
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
