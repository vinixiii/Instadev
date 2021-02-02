using System;
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

        
        public IActionResult Index()
        {
            ViewBag.userLogado = MostrarUsuario();
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
            
            System.Console.WriteLine(novoUsuario);
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