using Microsoft.AspNetCore.Mvc;

namespace WebMVC.Controllers
{
    public class PesquisaController : Controller
    {
        public IActionResult Pesquisar()
        {
            return View();
        }
    }
}
