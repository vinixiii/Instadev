#pragma checksum "C:\Users\vinixiii\Desktop\sfghsdfghsfghgf\Instadev-06\Views\Feed\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b49cb771051c743c596087eb4b638ed32e7cefa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Feed_Index), @"mvc.1.0.view", @"/Views/Feed/Index.cshtml")]
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
#line 1 "C:\Users\vinixiii\Desktop\sfghsdfghsfghgf\Instadev-06\Views\_ViewImports.cshtml"
using Instadev_06;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vinixiii\Desktop\sfghsdfghsfghgf\Instadev-06\Views\_ViewImports.cshtml"
using Instadev_06.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b49cb771051c743c596087eb4b638ed32e7cefa", @"/Views/Feed/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1f319f1c7e7f8897f7fafa50fe612e3aef97501", @"/Views/_ViewImports.cshtml")]
    public class Views_Feed_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Foto do perfil do amigo Vin Diesel"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Sua foto de perfil"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Imagem de perfil"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Foto do perfil do amigo Gabi Gordo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Foto dos jogadores do Flamengo com o amigo gabigordo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\vinixiii\Desktop\sfghsdfghsfghgf\Instadev-06\Views\Feed\Index.cshtml"
  
    ViewData["Title"] = "Feed";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-feed\">\r\n    <div class=\"small-space\"></div>\r\n    <section class=\"friend-list flex-center-bt\">\r\n        <div class=\"content flex-center-bt\">\r\n            <ul>\r\n");
#nullable restore
#line 10 "C:\Users\vinixiii\Desktop\sfghsdfghsfghgf\Instadev-06\Views\Feed\Index.cshtml"
                 foreach (Usuario u in ViewBag.Usuarios)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"friends\"");
            BeginWriteAttribute("asp-area", " asp-area=\"", 340, "\"", 351, 0);
            EndWriteAttribute();
            WriteLiteral(" asp-controller=\"Amigo\" asp-action=\"Index\"");
            BeginWriteAttribute("title", " title=\"", 394, "\"", 402, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <li> \r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7b49cb771051c743c596087eb4b638ed32e7cefa6972", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 475, "~/img/perfil/", 475, 13, true);
#nullable restore
#line 14 "C:\Users\vinixiii\Desktop\sfghsdfghsfghgf\Instadev-06\Views\Feed\Index.cshtml"
AddHtmlAttributeValue("", 488, u.Foto, 488, 7, false);

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
            WriteLiteral("\r\n                            <p class=\"nome-stories\">");
#nullable restore
#line 15 "C:\Users\vinixiii\Desktop\sfghsdfghsfghgf\Instadev-06\Views\Feed\Index.cshtml"
                                               Write(u.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </li>\r\n                    </div>\r\n");
#nullable restore
#line 18 "C:\Users\vinixiii\Desktop\sfghsdfghsfghgf\Instadev-06\Views\Feed\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </div>\r\n        <div class=\"alinhado\">\r\n            <ul class=\"flex-center-bt\">\r\n");
            WriteLiteral("                <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7b49cb771051c743c596087eb4b638ed32e7cefa9291", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 873, "~/img/perfil/", 873, 13, true);
#nullable restore
#line 24 "C:\Users\vinixiii\Desktop\sfghsdfghsfghgf\Instadev-06\Views\Feed\Index.cshtml"
AddHtmlAttributeValue("", 886, ViewBag.UserLogado.Foto, 886, 24, false);

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
            WriteLiteral("</li>\r\n                <div class=\"username_feed\">\r\n                    <p>");
#nullable restore
#line 26 "C:\Users\vinixiii\Desktop\sfghsdfghsfghgf\Instadev-06\Views\Feed\Index.cshtml"
                  Write(ViewBag.UserLogado.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p>");
#nullable restore
#line 27 "C:\Users\vinixiii\Desktop\sfghsdfghsfghgf\Instadev-06\Views\Feed\Index.cshtml"
                  Write(ViewBag.UserLogado.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                </div>

            </ul>
        </div>
    </section>
    <section class=""post"">
        <div class=""container"">
            <div class=""postar-content"">

                <ul class=""flex-center"">
                    <div class=""img-text"">
");
            WriteLiteral("                        <li class=\"sombrinha\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7b49cb771051c743c596087eb4b638ed32e7cefa11824", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1479, "~/img/perfil/", 1479, 13, true);
#nullable restore
#line 40 "C:\Users\vinixiii\Desktop\sfghsdfghsfghgf\Instadev-06\Views\Feed\Index.cshtml"
AddHtmlAttributeValue("", 1492, ViewBag.UserLogado.Foto, 1492, 24, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                        <li>\r\n                            <h3>Postar</h3>\r\n                        </li>\r\n                    </div>\r\n                </ul>\r\n                <div class=\"Adicionar-conteudo\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b49cb771051c743c596087eb4b638ed32e7cefa13650", async() => {
                WriteLiteral(@"
                        <div class=""busca"">
                            <ul class=""flex-center-bt"">
                                <div class=""digite"">
                                    <li><input type=""text"" name=""Legenda"" placeholder=""Digite a descrição da imagem..."" required/></li>
                                </div>
                                <div class=""escolher"">
                                    <label for='selecao-arquivo'>Escolha a imagem</label>
                                    <input type=""file"" id=""selecao-arquivo"" name=""Imagem"" required/>
                                </div>
                                <div class=""postar"">
                                    <li><button type=""submit"">Postar</button></li>
                                </div>
                            </ul>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#nullable restore
#line 47 "C:\Users\vinixiii\Desktop\sfghsdfghsfghgf\Instadev-06\Views\Feed\Index.cshtml"
AddHtmlAttributeValue("", 1803, Url.Action("CreatePost"), 1803, 25, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n    <section class=\"Postagem1\">\r\n");
#nullable restore
#line 68 "C:\Users\vinixiii\Desktop\sfghsdfghsfghgf\Instadev-06\Views\Feed\Index.cshtml"
         foreach (Publicacao p in ViewBag.Posts)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"post-feed\">\r\n                <div class=\"imagem\">\r\n                    <ul class=\"flex-center\">\r\n");
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7b49cb771051c743c596087eb4b638ed32e7cefa17108", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3147, "~/img/perfil/", 3147, 13, true);
#nullable restore
#line 74 "C:\Users\vinixiii\Desktop\sfghsdfghsfghgf\Instadev-06\Views\Feed\Index.cshtml"
AddHtmlAttributeValue("", 3160, p.FotoUsuario, 3160, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <div class=\"texto\">\r\n                            <p class=\"nome-publicacao\">");
#nullable restore
#line 76 "C:\Users\vinixiii\Desktop\sfghsdfghsfghgf\Instadev-06\Views\Feed\Index.cshtml"
                                                  Write(ViewBag.UsernamePost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p>Flamengo, RJ</p>\r\n                        </div>\r\n                    </ul>\r\n                </div>\r\n                <div class=\"foto\">\r\n");
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7b49cb771051c743c596087eb4b638ed32e7cefa19293", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3586, "~/img/publicacoes/", 3586, 18, true);
#nullable restore
#line 83 "C:\Users\vinixiii\Desktop\sfghsdfghsfghgf\Instadev-06\Views\Feed\Index.cshtml"
AddHtmlAttributeValue("", 3604, p.Imagem, 3604, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div class=\"cont\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b49cb771051c743c596087eb4b638ed32e7cefa20948", async() => {
                WriteLiteral(@"
                        <div class=""coments"">
                            <ul class=""flex-center"">
                                <div class=""coracao"">
                                    <label><img src=""./img/img-feed/Vectors2.svg"" alt=""Coração de like""  id=""1"" onclick=""mudarImagem(1);""></label>
                                </div>
                                <div class=""balao"">
                                    <img src=""./img/img-feed/Vectorbalao.svg""");
                BeginWriteAttribute("alt", " alt=\"", 4238, "\"", 4244, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                </div>
                                <div class=""comentar"">
                                    <input type=""text""  placeholder=""Comentar..."" required: required />
                                </div>
                            </ul>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <div class=""text"">
                    <h5 class=""curtidas"">2077 curtidas</h5>
                </div>
                <div class=""coments"">
                    <ul class=""flex-center"">
                        <h4>gabigordo</h4>
                        <p>
                            <span class=""cerquilha"">#flamengo</span> Amo vocês mil milhões S2</p>
                    </ul>
                </div>
                <div class=""coments"">
                    <ul class=""flex-center"">
                        <h4>yes_baby</h4>
                        <p>thank you </p>
                    </ul>
                </div>
                <div class=""coments"">
                    <ul class=""flex-center"">
                        <h4>king_pele</h4>
                        <p>Esses são bons de bola, entende?</p>
                    </ul>
                </div>
            </div>
");
#nullable restore
#line 125 "C:\Users\vinixiii\Desktop\sfghsdfghsfghgf\Instadev-06\Views\Feed\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </section>        \r\n</div>");
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
