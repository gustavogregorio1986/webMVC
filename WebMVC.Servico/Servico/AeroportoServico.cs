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
    public class AeroportoServico : IAeroportoServico
    {

        private readonly IAeroportoRepository _repositorio;

        public AeroportoServico(IAeroportoRepository repositorio)
        {
            _repositorio = repositorio;
        }

        public void Atualizar(Aeroporto aeroporto)
        {
            _repositorio.Atualizar(aeroporto);
        }

        public Aeroporto Buscar(int IdAero)
        {
            return _repositorio.Buscar(IdAero);
        }

        public void Deletar(int idAero)
        {
            _repositorio.Deletar(idAero);
        }

        public List<Aeroporto> ListarAeroporto()
        {
            return _repositorio.ListarAeroporto();
        }

        public void Salvar(Aeroporto aeroporto)
        {
            _repositorio.Salvar(aeroporto);
        }
    }
}
