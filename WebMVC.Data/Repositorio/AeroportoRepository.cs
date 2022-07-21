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
    public class AeroportoRepository : IAeroportoRepository
    {

        private readonly WebMVCContexto _db;

        public AeroportoRepository(WebMVCContexto _db)
        {
            this._db = _db;
        }

        public void Atualizar(Aeroporto aeroporto)
        {
            throw new NotImplementedException();
        }

        public Aeroporto Buscar(int IdAero)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int idAero)
        {
            throw new NotImplementedException();
        }

        public List<Aeroporto> ListarAeroporto()
        {
            throw new NotImplementedException();
        }

        public void Salvar(Aeroporto aeroporto)
        {
            throw new NotImplementedException();
        }
    }
}
