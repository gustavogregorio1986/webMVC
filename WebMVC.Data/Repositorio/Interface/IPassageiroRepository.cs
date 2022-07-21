using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMVC.Dominio.Dominio;

namespace WebMVC.Data.Repositorio.Interface
{
    public interface IPassageiroRepository
    {
        void Salvar(Passageiro passageiro);

        List<Origem> ListarPassageiro();

        void Atualizar(Passageiro passageiro);

        void Deletar(int idPassageiro);

        Passageiro Buscar(int idPassageiro);
    }
}
