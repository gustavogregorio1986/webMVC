﻿using System;
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
            _db.Update(aviao);
        }

        public Aviao Buscar(int IdAviao)
        {
           return _db.Set<Aviao>().Find(IdAviao);
        }

        public void Deletar(int idAviao)
        {
            _db.Remove(idAviao);
        }

        public List<Aviao> ListarAviao()
        {
            return _db.Set<Aviao>().ToList();
        }

        public void Salvar(Aviao aviao)
        {
            _db.Add(aviao);
        }
    }
}
