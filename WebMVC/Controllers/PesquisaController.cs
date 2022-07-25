using Microsoft.AspNetCore.Mvc;
using WebMVC.Dominio.Dominio;
using WebMVC.Servico.Servico;

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

        public Passageiro PesquisarPassageiro(int idPassageiro)
        {
            var passageiro = _servicoPassagero.Buscar(idPassageiro);

            return passageiro;
        }

        public Endereco PesquisarEndereco(int idEndereco)
        {
            var endereco = _servicoEndereco.Buscar(idEndereco);

            return endereco;
        }

        public Endereco PesquisarAeroporto(int idAewroporto)
        {
            var aeroporto = _servicoEndereco.Buscar(idAewroporto);

            return aeroporto;
        }

        public Aviao PesquisarAviao(int idAviao)
        {
            var aviao = _servicoAviao.Buscar(idAviao);

            return aviao;
        }

        public Origem PesquisarOrigem(int idOrigem)
        {
            var origem = _servicoOrigem.Buscar(idOrigem);

            return origem;
        }

        public Destino PesquisarDestino(int idDestino)
        {
            var destino = _servicoDestino.Buscar(idDestino);

            return destino;
        }
    }
}
