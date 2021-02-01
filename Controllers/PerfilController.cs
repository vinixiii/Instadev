using Microsoft.AspNetCore.Mvc;

namespace Instadev_06.Controllers
{
    public class PerfilController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}