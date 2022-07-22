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
    public class AviaoServico : IAviaoServico
    {
        private readonly IAviaoRepository _repositorio;

        public AviaoServico(IAviaoRepository repositorio)
        {
            _repositorio = repositorio;
        }

        public void Atualizar(Aviao aviao)
        {
            throw new NotImplementedException();
        }

        public Aviao Buscar(int IdAviao)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int idAviao)
        {
            throw new NotImplementedException();
        }

        public List<Aviao> ListarAviao()
        {
            throw new NotImplementedException();
        }

        public void Salvar(Aviao aviao)
        {
            throw new NotImplementedException();
        }
    }
}
