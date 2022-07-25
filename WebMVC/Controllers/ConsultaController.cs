using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebMVC.Dominio.Dominio;
using WebMVC.Servico.Servico;

namespace WebMVC.Controllers
{
    public class ConsultaController : Controller
    {
        private readonly AeroportoServico _servicoAeroprto;
        private readonly AviaoServico _servicoAviao;
        private readonly DestinoServico _servicoDestino;
        private readonly EnderecoServico _servicoEndereco;
        private readonly OrigemServico _servicoOrigem;
        private readonly PassageiroServico _servicoPassagero;

        public IActionResult Consultar()
        {
            return View();
        }

        public List<Passageiro> ListaPassageiro()
        {
            var passageiros = new List<Passageiro>();

            foreach(var passageiro in passageiros)
            {
                _servicoPassagero.ListarPassageiro();
            }

            return passageiros;
        }

        public List<Endereco> ListaEndereco()
        {
            var endereccos = new List<Endereco>();

            foreach (var endereco in endereccos)
            {
                _servicoEndereco.ListarEndereco();
            }

            return endereccos;
        }

        public List<Aeroporto> ListaAeroporto()
        {
            var aeroportos = new List<Aeroporto>();

            foreach (var aeroporto in aeroportos)
            {
                _servicoAeroprto.ListarAeroporto();
            }

            return aeroportos;
        }

        public List<Aviao> ListaAvioes()
        {
            var avioes = new List<Aviao>();

            foreach (var aviao in avioes)
            {
                _servicoAviao.ListarAviao();
            }

            return avioes;
        }

        public List<Origem> ListaOrigem()
        {
            var origens = new List<Origem>();

            foreach (var origem in origens)
            {
                _servicoOrigem.ListarOrigem();
            }

            return origens;
        }

        public List<Destino> ListaDestino()
        {
            var destinos = new List<Destino>();

            foreach (var destino in destinos)
            {
                _servicoDestino.ListarDestino();
            }

            return destinos;
        }
    }
}
