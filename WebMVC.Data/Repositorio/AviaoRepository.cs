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
    public class AviaoRepository : IAviaoRepository
    {
        private readonly WebMVCContexto _db;

        public AviaoRepository(WebMVCContexto _db)
        {
            this._db = _db; 
        }

        public void Atualizar(Aviao aviao)
        {
            throw new NotImplementedException();
        }

        public Aviao Buscar(int IdAviao)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int idAviao)
        {
            throw new NotImplementedException();
        }

        public List<Aviao> ListarAviao()
        {
            throw new NotImplementedException();
        }

        public void Salvar(Aviao aviao)
        {
            throw new NotImplementedException();
        }
    }
}
