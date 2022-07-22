using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMVC.Dominio.Dominio;

namespace WebMVC.Servico.Servico.Interface
{
    public interface IDestinoServico
    {
        void Salvar(Destino destino);

        List<Destino> ListarDestino();

        void Atualizar(Destino destino);

        void Deletar(int idDestino);

        Destino Buscar(int IdDestino);
    }
}
