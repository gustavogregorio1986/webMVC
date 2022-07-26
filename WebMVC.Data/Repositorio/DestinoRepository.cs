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
    public class DestinoRepository : IDestinoRepository
    {
        private readonly WebMVCContexto _db;

        public DestinoRepository(WebMVCContexto _db)
        {
            this._db = _db;
        }

        public void Atualizar(Destino destino)
        {
            _db.Update(destino);
        }

        public Destino Buscar(int IdDestino)
        {
            return _db.Set<Destino>().Find(IdDestino);
        }

        public void Deletar(int idDestino)
        {
            _db.Remove(idDestino);
        }

        public List<Destino> ListarDestino()
        {
            return _db.Set<Destino>().ToList();
        }

        public void Salvar(Destino destino)
        {
            _db.Add(destino);
        }
    }
}
