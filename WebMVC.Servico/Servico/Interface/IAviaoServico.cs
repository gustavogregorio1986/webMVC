using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMVC.Dominio.Dominio;

namespace WebMVC.Servico.Servico.Interface
{
    public interface IAviaoServico
    {
        void Salvar(Aviao aviao);

        List<Aviao> ListarAviao();

        void Atualizar(Aviao aviao);

        void Deletar(int idAviao);

        Aviao Buscar(int IdAviao);
    }
}
