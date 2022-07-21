using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMVC.Dominio.Dominio;

namespace WebMVC.Data.Contexto
{
    public class WebMVCContexto : DbContext
    {

        public WebMVCContexto(DbContextOptions options)
            : base(options) 
        {

        }

        public DbSet<Passageiro> Passageiro { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }

        public DbSet<Aeroporto> Aeroportos { get; set; }

        public DbSet<Aviao> Avioes { get; set; }

        public DbSet<Origem> Origens { get; set; }

        public DbSet<Destino> Destinos { get; set; }
    }
}
