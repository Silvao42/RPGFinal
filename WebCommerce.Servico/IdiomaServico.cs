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
    public class IdiomaServico : IIdiomaServico
    {
        private readonly IIdiomaRepositorio _idiomaRepositorio;

        public IdiomaServico(IIdiomaRepositorio idiomaRepositorio)
        {
            _idiomaRepositorio = idiomaRepositorio;
        }

        public NotificationResult Excluir(int CodIdioma)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Idioma> ListarAtivos()
        {
            throw new NotImplementedException();
        }

        public Task<List<Idioma>> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public Idioma ListarUm(int CodIdioma)
        {
            return _idiomaRepositorio.ListarUm(CodIdioma);
        }

        public NotificationResult Salvar(Idioma entidade)
        {
            throw new NotImplementedException();
        }
    }
}
