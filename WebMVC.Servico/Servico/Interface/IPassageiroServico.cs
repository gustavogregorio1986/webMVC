using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMVC.Dominio.Dominio;

namespace WebMVC.Servico.Servico.Interface
{
    public interface IPassageiroServico
    {
        void Salvar(Passageiro passageiro);

        List<Origem> ListarPassageiro();

        void Atualizar(Passageiro passageiro);

        void Deletar(int idPassageiro);

        Passageiro Buscar(int idPassageiro);
    }
}
