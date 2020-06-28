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
    public class AtributoServico : IAtributoServico
    {
        private readonly IAtributoRepositorio _atributoServico;

        public AtributoServico(IAtributoRepositorio atributoServico)
        {
            _atributoServico = atributoServico;
        }

        public NotificationResult Excluir(int CodFicha, int CodJogador)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Atributo> ListarAtivos()
        {
            throw new NotImplementedException();
        }

        public Task<List<Atributo>> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public Atributo ListarUm(int CodFicha, int CodJogador)
        {
            return _atributoServico.ListarUm(CodFicha, CodJogador);
        }

        public NotificationResult Salvar(Atributo entidade)
        {
            throw new NotImplementedException();
        }
    }
}
