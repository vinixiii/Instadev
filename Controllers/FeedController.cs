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

        public IActionResult Index()
        {
            ViewBag.Posts = publicacaoModel.ReadAll();
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

            publicacaoModel.Create(novoPost);
            ViewBag.Posts = publicacaoModel.ReadAll();

            return LocalRedirect("~/Feed");
        }
    }
}