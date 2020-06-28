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
    public class ArmaServico : IArmaServico
    {
        private readonly IArmaRepositorio _armaRepositorio;

        public ArmaServico(IArmaRepositorio armaRepositorio)
        {
            _armaRepositorio = armaRepositorio;
        }

        public NotificationResult Excluir(int CodArma)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Arma> ListarAtivos()
        {
            throw new NotImplementedException();
        }

        public Task<List<Arma>> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public Arma ListarUm(int CodArma)
        {
            return _armaRepositorio.ListarUm(CodArma);
        }

        public NotificationResult Salvar(Arma entidade)
        {
            throw new NotImplementedException();
        }
    }
}
