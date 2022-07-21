﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMVC.Dominio.Dominio;

namespace WebMVC.Data.Repositorio.Interface
{
    public interface IAeroportoRepository
    {
        void Salvar(Aeroporto aeroporto);

        List<Aeroporto> ListarAeroporto();

        void Atualizar(Aeroporto aeroporto);

        void Deletar(int idAero);

        Aeroporto Buscar(int IdAero);
    }
}
