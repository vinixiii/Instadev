using System;
using System.Collections.Generic;
using System.IO;
using Instadev_06.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Instadev_06.Controllers
{
    [Route("EditarPerfil")]
    public class EditarPerfilController : Controller
    {
        Usuario usuarioModel = new Usuario();
        Publicacao publicacaoModel = new Publicacao();

        
        public IActionResult Index()
        {
            ViewBag.UserLogado = MostrarUsuario();
            return View();
        }
        
        [Route("EditarPerfil-Usuario")]
        public Usuario MostrarUsuario()
        {
            var userid = HttpContext.Session.GetString("_UserId");
            Usuario userLogado = usuarioModel.ObterUsuarioDaSessao(int.Parse(userid));

            return userLogado;
        }
        [Route("EditarPerfil-Alterar-dados")]
        public IActionResult AlterarDados(IFormCollection form)
        {
            Usuario novoUsuario = MostrarUsuario();
            novoUsuario.Nome = form["Nome"];
            novoUsuario.Foto = form["Foto"];
            
            if(form.Files.Count > 0){

                var file = form.Files[0];
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/perfil");

                if(!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/", folder, file.FileName);

                using(var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                
                novoUsuario.Foto = file.FileName;           
            }

            novoUsuario.DataNascimento = DateTime.Parse(form["DataNascimento"]);
            novoUsuario.Email = form["Email"];
            novoUsuario.Username = form["Username"];
            
            usuarioModel.Update(novoUsuario);

            //Alterar form posts - início
            List<string> posts = publicacaoModel.ReadAllLinesCSV(publicacaoModel._PATH);

            var pub = posts.FindAll(x => x.Split(";")[3] == novoUsuario.IdUsuario.ToString());

            System.Console.WriteLine(pub);

            foreach (string item in pub)
            {
                var file = form.Files[0];

                string[] linha = item.Split(";");

                Publicacao publicacao = new Publicacao();
                publicacao.IdPublicacao = int.Parse(linha[0]);
                publicacao.Imagem = linha[1];
                publicacao.Legenda = linha[2];
                publicacao.IdUsuario = int.Parse(linha[3]);
                publicacao.Likes = int.Parse(linha[4]);
                publicacao.FotoUsuario = file.FileName;

                publicacaoModel.Update(publicacao);
            }
            //Alterar form posts - início

            return LocalRedirect("~/EditarPerfil");
        }
        [Route("ExcluirPerfil")]
        public IActionResult Excluir(int id)
        {
            var userId = HttpContext.Session.GetString("_UserId");
            if (userId == id.ToString())
            {
                usuarioModel.Delete(id);

            }
            return LocalRedirect("~/Login");
        }
    }
}