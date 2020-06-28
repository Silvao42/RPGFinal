using WebCommerce.Comum.NotificationPattern;
using WebCommerce.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebCommerce.Dominio.Entidades;
using WebCommerce.Dominio.Interfaces;

namespace WebCommerce.Servico
{
    public class PericiaServico : IPericiaServico
    {
        private readonly IPericiaRepositorio _periciaRepositorio;

        public PericiaServico(IPericiaRepositorio periciaRepositorio)
        {
            _periciaRepositorio = periciaRepositorio;
        }

        public NotificationResult Excluir(int CodJogador, int CodFicha)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pericia> ListarAtivos()
        {
            throw new NotImplementedException();
        }

        public Task<List<Pericia>> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public Pericia ListarUm(int CodJogador, int CodFicha)
        {
            return _periciaRepositorio.ListarUm( CodJogador,  CodFicha);
        }

        public NotificationResult Salvar(Pericia entidade)
        {
            throw new NotImplementedException();
        }
    }
}
