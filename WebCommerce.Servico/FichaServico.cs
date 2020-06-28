using Aula09.Comum.NotificationPattern;
using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebCommerce.Dominio.Entidades;
using WebCommerce.Dominio.Interfaces;

namespace WebCommerce.Servico
{
    public class FichaServico : IFichaServico
    {
        private readonly IFichaRepositorio _fichaRepositorio;

        public FichaServico(IFichaRepositorio fichaRepositorio)
        {
            _fichaRepositorio = fichaRepositorio;
        }

        public NotificationResult Excluir(int CodFicha, int CodJogador)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Ficha> ListarAtivos()
        {
            throw new NotImplementedException();
        }

        public Task<List<Ficha>> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public Ficha ListarUm(int CodFicha, int CodJogador)
        {
            return _fichaRepositorio.ListarUm(CodFicha, CodJogador);
        }

        public NotificationResult Salvar(Ficha entidade)
        {
            throw new NotImplementedException();
        }
    }
}
