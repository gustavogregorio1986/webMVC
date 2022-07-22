using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMVC.Dominio.Dominio;

namespace WebMVC.Servico.Servico.Interface
{
    public interface IEnderecoServico
    {
        void Salvar(Endereco endereco);

        List<Endereco> ListarEndereco();

        void Atualizar(Endereco endereco);

        void Deletar(int idEndereco);

        Endereco Buscar(int idEndereco);
    }
}
