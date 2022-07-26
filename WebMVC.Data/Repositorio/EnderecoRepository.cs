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
    public class EnderecoRepository : IEnderecoRepository
    {
        private readonly WebMVCContexto _db;

        public EnderecoRepository(WebMVCContexto _db)
        {
            this._db = _db;
        }

        public void Atualizar(Endereco endereco)
        {
            _db.Update(endereco);
        }

        public Endereco Buscar(int idEndereco)
        {
            return _db.Set<Endereco>().Find(idEndereco);
        }

        public void Deletar(int idEndereco)
        {
            _db.Remove(idEndereco);
        }

        public List<Endereco> ListarEndereco()
        {
            return _db.Set<Endereco>().ToList();
        }

        public void Salvar(Endereco endereco)
        {
            _db.Add(endereco);
        }
    }
}
