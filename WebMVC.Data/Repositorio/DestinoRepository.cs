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
    public class DestinoRepository : IDestinoRepository
    {
        private readonly WebMVCContexto _db;

        public DestinoRepository(WebMVCContexto _db)
        {
            this._db = _db;
        }

        public void Atualizar(Destino destino)
        {
            throw new NotImplementedException();
        }

        public Destino Buscar(int IdDestino)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int idDestino)
        {
            throw new NotImplementedException();
        }

        public List<Destino> ListarDestino()
        {
            throw new NotImplementedException();
        }

        public void Salvar(Destino destino)
        {
            throw new NotImplementedException();
        }
    }
}
