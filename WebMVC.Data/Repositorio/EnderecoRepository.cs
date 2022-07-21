using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMVC.Data.Contexto;
using WebMVC.Data.Repositorio.Interface;
using WebMVC.Dominio.Dominio;

namespace WebMVC.Data.Repositorio
{
    public class EnderecoRepository : IEnderecoRepository
    {
        private readonly WebMVCContexto _db;

        public EnderecoRepository(WebMVCContexto _db)
        {
            this._db = _db;
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
