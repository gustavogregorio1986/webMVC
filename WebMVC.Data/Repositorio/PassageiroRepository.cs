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
    public class PassageiroRepository : IPassageiroRepository
    {
        private readonly WebMVCContexto _db;

        public PassageiroRepository(WebMVCContexto _db)
        {
            this._db = _db;
        }

        public void Atualizar(Passageiro passageiro)
        {
            throw new NotImplementedException();
        }

        public Passageiro Buscar(int idPassageiro)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int idPassageiro)
        {
            throw new NotImplementedException();
        }

        public List<Origem> ListarPassageiro()
        {
            throw new NotImplementedException();
        }

        public void Salvar(Passageiro passageiro)
        {
            throw new NotImplementedException();
        }
    }
}
