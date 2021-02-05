using System.Collections.Generic;
using System.IO;
using Instadev_06.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Instadev_06.Controllers
{
    [Route("Feed")]
    public class FeedController : Controller
    {
        Usuario usuarioModel = new Usuario();
        Publicacao publicacaoModel = new Publicacao();
        Comentario comentarioModel = new Comentario();

        public IActionResult Index()
        {
            //Traz todods os comentarios
            ViewBag.Comentarios = comentarioModel.ReadAll();
            //Traz todods os posts
            ViewBag.Posts = publicacaoModel.ReadAll();

            //Traz todos os usuários
            ViewBag.Usuarios = usuarioModel.ReadAll();
            
            var userId = HttpContext.Session.GetString("_UserId");
            ViewBag.UserLogado = usuarioModel.ObterUsuarioDaSessao(int.Parse(userId));
            
            return View();
        }

        [Route("Criar-Post")]
        public IActionResult CreatePost(IFormCollection form)
        {
            var userId = HttpContext.Session.GetString("_UserId");

            Publicacao novoPost = new Publicacao();
            novoPost.IdPublicacao = publicacaoModel.GerarIdPublicacao();

            if(form.Files.Count > 0){
                var file = form.Files[0];
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/publicacoes");

                if(!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/", folder, file.FileName);

                using(var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                
                novoPost.Imagem = file.FileName;           
            }

            novoPost.Legenda = form["Legenda"];
            novoPost.IdUsuario = int.Parse(userId);
            novoPost.Likes = 0;

            //Obter foto e username do usuário - início
            List<string> usuarios = usuarioModel.ReadAllLinesCSV(usuarioModel._PATH);
            
            var user = usuarios.Find(x => x.Split(";")[0] == userId.ToString());
            string[] atributo = user.Split(";");

            novoPost.FotoUsuario = atributo[2];
            novoPost.Username = atributo[4];
            //Obter foto e username - final

            publicacaoModel.Create(novoPost);

            return LocalRedirect("~/Feed");
        }

        [Route("Comentar")]
        public IActionResult Comentar(IFormCollection form)
        {
            var userId = HttpContext.Session.GetString("_UserId");
            var userName = HttpContext.Session.GetString("_Username");

            Comentario novoComentario = new Comentario();
            novoComentario.IdComentario = comentarioModel.GerarIdComentario();
            novoComentario.Mensagem = form["Mensagem"];
            novoComentario.IdUsuario = int.Parse(userId);
            novoComentario.IdPublicacao = int.Parse(form["IdPublicacao"]);
            novoComentario.Username = userName;

            comentarioModel.Create(novoComentario);

            return LocalRedirect("~/Feed");
        }

    }
}