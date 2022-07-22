using Microsoft.AspNetCore.Mvc;

namespace WebMVC.Controllers
{
    public class ConsultaController : Controller
    {
        public IActionResult Consultar()
        {
            return View();
        }
    }
}
