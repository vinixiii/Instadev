using System;
using System.Collections.Generic;
using System.Linq;
using Instadev_06.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Instadev_06.Controllers
{
    [Route("Perfil")]
    public class PerfilController : Controller
    {
        Usuario usuarioModel = new Usuario();
        Publicacao publicacaoModel = new Publicacao();
        Comentario comentarioModel = new Comentario();
        
        public IActionResult Index()
        {
            ViewBag.Comentarios = comentarioModel.ReadAll();

            ViewBag.UserLogado = MostrarUsuario();

            ViewBag.PublicacoesUser = ExibirPublicacoes();

            //Exibe número de publicações
            List<Publicacao> postsPerfil = new List<Publicacao>();
            postsPerfil = ExibirPublicacoes();
            int numPosts = postsPerfil.Count();
            ViewBag.NumPosts = numPosts;
            //Exibe número de publicações
            
            // System.Console.WriteLine(ViewBag.PublicacoesUser.Imagem);
            return View();
        }

        [Route("Perfil/@ViewBag.UserLogado.Username")]
        public Usuario MostrarUsuario()
        {
            var userId = HttpContext.Session.GetString("_UserId");
            Usuario userLogado = usuarioModel.ObterUsuarioDaSessao(int.Parse(userId));

            return userLogado;
        }

        [Route("Publicacoes-Perfil")]
        public List<Publicacao> ExibirPublicacoes()
        {
            List<Publicacao> posts = new List<Publicacao>();
            List<string> publicacoes = publicacaoModel.ReadAllLinesCSV(publicacaoModel._PATH);

            string userId = HttpContext.Session.GetString("_UserId");
            
            var pub = publicacoes.FindAll(x => x.Split(";")[3] == userId);

            foreach (var item in pub)
            {
                string[] linha = item.Split(";");

                Publicacao publicacao = new Publicacao();
                publicacao.IdPublicacao = int.Parse(linha[0]);
                publicacao.Imagem = linha[1];
                publicacao.Legenda = linha[2];
                publicacao.IdUsuario = int.Parse(linha[3]);
                publicacao.Likes = int.Parse(linha[4]);
                publicacao.Username = linha[6];

                posts.Add(publicacao);
            }

            return posts;
        }
    }
}