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
        public IActionResult AlterarDados()
        {
            Usuario novoUsuario = MostrarUsuario();
            
            System.Console.WriteLine(novoUsuario);
            return LocalRedirect("~/EditarPerfil");
        }
    }
}