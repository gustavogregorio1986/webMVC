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
    public class AeroportoRepository : IAeroportoRepository
    {

        private readonly WebMVCContexto _db;

        public AeroportoRepository(WebMVCContexto _db)
        {
            this._db = _db;
        }

        public void Atualizar(Aeroporto aeroporto)
        {
            _db.Update(aeroporto);
        }

        public Aeroporto Buscar(int IdAero)
        {
            return _db.Set<Aeroporto>().Find(IdAero);
        }

        public void Deletar(int idAero)
        {
            _db.Remove(idAero);
        }

        public List<Aeroporto> ListarAeroporto()
        {
            return _db.Set<Aeroporto>().ToList();
        }

        public void Salvar(Aeroporto aeroporto)
        {
            _db.Add(aeroporto);
        }
    }
}
