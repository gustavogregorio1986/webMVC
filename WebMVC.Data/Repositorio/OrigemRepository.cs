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
    public class OrigemRepository : IOrigemRepository
    {
        private readonly WebMVCContexto _db;

        public OrigemRepository(WebMVCContexto _db)
        {
            this._db = _db;
        }

        public void Atualizar(Origem origem)
        {
            throw new NotImplementedException();
        }

        public Origem Buscar(int idOrigem)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int idOrigem)
        {
            throw new NotImplementedException();
        }

        public List<Origem> ListarOrigem()
        {
            throw new NotImplementedException();
        }

        public void Salvar(Origem origem)
        {
            throw new NotImplementedException();
        }
    }
}
