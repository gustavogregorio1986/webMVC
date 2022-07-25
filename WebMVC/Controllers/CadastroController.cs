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

        public IActionResult CadastrarDados(PassageiroView passageiroVM, EnderecoView enderecoView, AeroportoView aeroportoVM, AviaoView aviaoVM, OrigemView origemVM, DestinoView destinoVM)
        {
            passageiroVM = new PassageiroView();
            Passageiro passageiro = new Passageiro();
            passageiroVM.IdPassageiro = passageiro.IdPassageiro;
            passageiroVM.NomePssageiro = passageiro.NomePssageiro;
            passageiroVM.EmailPassageiro = passageiro.EmaqilPassageiro;
            passageiroVM.Sexo = passageiro.Sexo;
            passageiroVM.Telefone = passageiro.Telefone;

            enderecoView = new EnderecoView();
            Endereco endereco = new Endereco();
            enderecoView.Logradouro = endereco.Logradouro;
            enderecoView.Bairro = endereco.Bairro;
            enderecoView.Cidade = endereco.Cidade;
            enderecoView.Uf = endereco.Uf;
            enderecoView.Id_Passageiro = endereco.Id_Passageiro;

            aeroportoVM = new AeroportoView();
            Aeroporto aeroporto = new Aeroporto();
            aeroportoVM.NomeAero = aeroporto.NomeAero;
            aeroportoVM.DataEntrada = aeroporto.DataEntrada;
            aeroportoVM.Id_Passageiro = aeroporto.Id_Passageiro;

            aviaoVM = new AviaoView();
            Aviao aviao = new Aviao();
            aviaoVM.Compania = aviao.Compania;
            aviaoVM.NomeAviao = aviao.NomeAviao;
            aviaoVM.Poltrona = aviao.Poltrona;
            aviaoVM.Id_Aeroporto = aviao.Id_Aeroporto;

            origemVM = new OrigemView();
            Origem origem = new Origem();
            origemVM.CidadwOrigem = origem.CidadwOrigem;
            origemVM.Id_Aviao = origem.Id_Aviao;

            destinoVM = new DestinoView();
            Destino destino = new Destino();
            destinoVM.CidadwDestino = destino.CidadwDestino;
            destinoVM.Id_Aviao = destino.Id_Aviao;

            _servicoPassagero.Salvar(passageiro);
            _servicoEndereco.Salvar(endereco);
            _servicoAeroprto.Salvar(aeroporto);
            _servicoAviao.Salvar(aviao);
            _servicoOrigem.Salvar(origem);
            _servicoDestino.Salvar(destino);

            return View("Cadastrar");
        }

    }
}
