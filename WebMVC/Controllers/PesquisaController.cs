using Microsoft.AspNetCore.Mvc;

namespace WebMVC.Controllers
{
    public class PesquisaController : Controller
    {

        private readonly AeroportoServico _servicoAeroprto;
        private readonly AviaoServico _servicoAviao;
        private readonly DestinoServico _servicoDestino;
        private readonly EnderecoServico _servicoEndereco;
        private readonly OrigemServico _servicoOrigem;
        private readonly PassageiroServico _servicoPassagero;

        public IActionResult Pesquisar()
        {
            return View();
        }
    }
}
