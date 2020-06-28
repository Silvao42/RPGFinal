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
    public class MagiaServico : IMagiaServico
    {
        private readonly IMagiaRepositoro _magiaRepositoro;

        public MagiaServico(IMagiaRepositoro magiaRepositoro)
        {
            _magiaRepositoro = magiaRepositoro;
        }

        public NotificationResult Excluir(int CodMagia)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Magia> ListarAtivos()
        {
            throw new NotImplementedException();
        }

        public Task<List<Magia>> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public Magia ListarUm(int CodMagia)
        {
            return _magiaRepositoro.ListarUm(CodMagia);
        }

        public NotificationResult Salvar(Magia entidade)
        {
            throw new NotImplementedException();
        }
    }
}
