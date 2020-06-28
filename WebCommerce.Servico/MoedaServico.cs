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
    public class MoedaServico : IMoedaServico
    {
        private readonly IMoedaRepositorio _moedaRepositorio;

        public MoedaServico(IMoedaRepositorio moedaRepositorio)
        {
            _moedaRepositorio = moedaRepositorio;
        }

        public NotificationResult Excluir(int CodFicha, int CodJogador)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Moeda> ListarAtivos()
        {
            throw new NotImplementedException();
        }

        public Task<List<Moeda>> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public Moeda ListarUm(int CodFicha, int CodJogador)
        {
            return _moedaRepositorio.ListarUm( CodFicha, CodJogador);
        }

        public NotificationResult Salvar(Moeda entidade)
        {
            throw new NotImplementedException();
        }
    }
}
