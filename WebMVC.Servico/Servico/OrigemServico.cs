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
    public class OrigemServico : IOrigemServico
    {
        private readonly IOrigemRepository _repositorio;

        public OrigemServico(IOrigemRepository repositorio)
        {
            _repositorio = repositorio;
        }

        public void Atualizar(Origem origem)
        {
            throw new NotImplementedException();
        }

        public Origem Buscar(int idOrigem)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int idOrigem)
        {
            throw new NotImplementedException();
        }

        public List<Origem> ListarOrigem()
        {
            throw new NotImplementedException();
        }

        public void Salvar(Origem origem)
        {
            throw new NotImplementedException();
        }
    }
}
