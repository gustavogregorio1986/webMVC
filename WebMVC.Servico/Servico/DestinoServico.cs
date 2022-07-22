using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMVC.Data.Repositorio.Interface;
using WebMVC.Dominio.Dominio;
using WebMVC.Servico.Servico.Interface;

namespace WebMVC.Servico.Servico
{
    public class DestinoServico : IDestinoServico
    {

        private readonly IDestinoRepository _repositorio;

        public DestinoServico(IDestinoRepository repositorio)
        {
            _repositorio = repositorio;
        }

        public void Atualizar(Destino destino)
        {
            throw new NotImplementedException();
        }

        public Destino Buscar(int IdDestino)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int idDestino)
        {
            throw new NotImplementedException();
        }

        public List<Destino> ListarDestino()
        {
            throw new NotImplementedException();
        }

        public void Salvar(Destino destino)
        {
            throw new NotImplementedException();
        }
    }
}
