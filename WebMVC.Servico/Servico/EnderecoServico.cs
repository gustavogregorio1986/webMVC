using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMVC.Data.Repositorio.Interface;
using WebMVC.Dominio.Dominio;
using WebMVC.Servico.Servico.Interface;

namespace WebMVC.Servico.Servico
{
    public class EnderecoServico : IEnderecoServico
    {
        private readonly IEnderecoRepository _repositorio;

        public EnderecoServico(IEnderecoRepository repositorio)
        {
            _repositorio = repositorio;
        }

        public void Atualizar(Endereco endereco)
        {
            throw new NotImplementedException();
        }

        public Endereco Buscar(int idEndereco)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int idEndereco)
        {
            throw new NotImplementedException();
        }

        public List<Endereco> ListarEndereco()
        {
            throw new NotImplementedException();
        }

        public void Salvar(Endereco endereco)
        {
            throw new NotImplementedException();
        }
    }
}
