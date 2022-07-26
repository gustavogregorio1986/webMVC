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
    public class OrigemRepository : IOrigemRepository
    {
        private readonly WebMVCContexto _db;

        public OrigemRepository(WebMVCContexto _db)
        {
            this._db = _db;
        }

        public void Atualizar(Origem origem)
        {
            _db.Add(origem);
        }

        public Origem Buscar(int idOrigem)
        {
            return _db.Set<Origem>().Find(idOrigem);
        }

        public void Deletar(int idOrigem)
        {
            _db.Remove(idOrigem);
        }

        public List<Origem> ListarOrigem()
        {
            return _db.Set<Origem>().ToList();
        }

        public void Salvar(Origem origem)
        {
            _db.Add(origem);
        }
    }
}
