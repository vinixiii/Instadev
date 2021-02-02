using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Instadev_06.Models;
using Microsoft.AspNetCore.Http;

namespace Instadev_06.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.UserIdLogado = HttpContext.Session.GetString("_UserId");
            ViewBag.UsernameLogado = HttpContext.Session.GetString("_Username");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
