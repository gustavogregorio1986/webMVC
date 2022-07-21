using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMVC.Dominio.Dominio;

namespace WebMVC.Data.Repositorio.Interface
{
    public interface IOrigemRepository
    {
        void Salvar(Origem origem);

        List<Origem> ListarOrigem();

        void Atualizar(Origem origem);

        void Deletar(int idOrigem);

        Origem Buscar(int idOrigem);
    }
}
