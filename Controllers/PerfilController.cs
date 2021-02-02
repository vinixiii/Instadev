using System;
using System.Collections.Generic;
using Instadev_06.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Instadev_06.Controllers
{
    [Route("Perfil")]
    public class PerfilController : Controller
    {
        Usuario usuarioModel = new Usuario();
        
        public IActionResult Index()
        {
            ViewBag.userLogado = MostrarUsuario();
            return View();
        }

        [Route("kasfnak")]
        public Usuario MostrarUsuario()
        {
            var userId = HttpContext.Session.GetString("_UserId");
            Usuario userLogado = usuarioModel.ObterUsuarioDaSessao(int.Parse(userId));

            return userLogado;
        }
    }
}