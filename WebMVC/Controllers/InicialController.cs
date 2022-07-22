using Microsoft.AspNetCore.Mvc;

namespace WebMVC.Controllers
{
    public class InicialController : Controller
    {
        public IActionResult Inicio()
        {
            return View();
        }
    }
}
