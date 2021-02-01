using System.Collections.Generic;
using Instadev_06.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Instadev_06.Controllers
{
    [Route("Login")]
    public class LoginController : Controller
    {
        [TempData]
        public string Mensagem { get; set; }

        Usuario usuarioModel = new Usuario();
        

        public IActionResult Index()
        {
            return View();
        }

        [Route("Logar")]
        public IActionResult Logar(IFormCollection form)
        {
            List<string> csv = usuarioModel.ReadAllLinesCSV(usuarioModel._PATH);

            var logado = csv.Find(
                x => 
                x.Split(";")[3] == form["Email"] && 
                x.Split(";")[4] == form["Senha"]
            );

            if(logado != null)
            {
                //Criamos uma sessão com os dados do usuário
                HttpContext.Session.SetString("_Username", logado.Split(";")[1]);
                HttpContext.Session.SetString("_UserId", logado.Split(";")[0]);

                return LocalRedirect("~/");
            }

            Mensagem = "Tente novamente.";

            System.Console.WriteLine("Loguei meu irmão");

            return LocalRedirect("~/Home");
        }

        [Route("Deslogar")]
        public IActionResult Deslogar()
        {
            HttpContext.Session.Remove("_Username");
            HttpContext.Session.Remove("_UserId");

            System.Console.WriteLine("Desloguei meu irmão");
            
            return LocalRedirect("~/");
        }
    }
}