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
    public class ClasseServico : IClasseServico
    {
        private readonly IClasseRepositorio _classeRepositorio;

        public ClasseServico(IClasseRepositorio classeRepositorio)
        {
            _classeRepositorio = classeRepositorio;
        }

        public NotificationResult Excluir(int CodClasse)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Classe> ListarAtivos()
        {
            throw new NotImplementedException();
        }

        public Task<List<Classe>> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public Classe ListarUm(int CodClasse)
        {
            return _classeRepositorio.ListarUm(CodClasse);
        }

        public NotificationResult Salvar(Classe entidade)
        {
            throw new NotImplementedException();
        }
    }
}
