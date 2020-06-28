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
    public class JogadorServico : IJogadorServico
    {
        private readonly IJogadorRepositorio _jogadorRepositorio;

        public JogadorServico(IJogadorRepositorio jogadorRepositorio)
        {
            _jogadorRepositorio = jogadorRepositorio;
        }

        public NotificationResult Excluir(int CodJogador)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Jogador> ListarAtivos()
        {
            throw new NotImplementedException();
        }

        public Task<List<Jogador>> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public Jogador ListarUm(int CodJogador)
        {
            return _jogadorRepositorio.ListarUm(CodJogador);
        }

        public NotificationResult Salvar(Jogador entidade)
        {
            throw new NotImplementedException();
        }
    }
}
