using Microsoft.AspNetCore.Mvc;

namespace WebMVC.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
