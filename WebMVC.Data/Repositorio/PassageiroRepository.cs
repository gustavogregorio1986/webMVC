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
            _db.Update(passageiro);
        }

        public Passageiro Buscar(int idPassageiro)
        {
            return _db.Set<Passageiro>().Find(idPassageiro);
        }

        public void Deletar(int idPassageiro)
        {
            _db.Remove(idPassageiro);
        }

        public List<Origem> ListarPassageiro()
        {
            return _db.Set<Origem>().ToList();
        }

        public void Salvar(Passageiro passageiro)
        {
            _db.Add(passageiro);
        }
    }
}
