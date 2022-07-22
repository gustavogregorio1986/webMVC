using Microsoft.AspNetCore.Mvc;
using WebMVC.Dominio.Dominio;
using WebMVC.Models;
using WebMVC.Servico.Servico;

namespace WebMVC.Controllers
{
    public class CadastroController : Controller
    {
        private readonly AeroportoServico _servicoAeroprto;
        private readonly AviaoServico _servicoAviao;
        private readonly DestinoServico _servicoDestino;
        private readonly EnderecoServico _servicoEndereco;
        private readonly OrigemServico _servicoOrigem;
        private readonly PassageiroServico _servicoPassagero;

        public IActionResult Cadastrar()
        {
            return View();
        }

        
    }
}
