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
    public class FichaIdiomaServico : IFichaIdiomaServico
    {
        private readonly IFichaIdiomaRepositorio _fichaIdiomaRepositorio;

        public FichaIdiomaServico(IFichaIdiomaRepositorio fichaIdiomaRepositorio)
        {
            _fichaIdiomaRepositorio = fichaIdiomaRepositorio;
        }

        public NotificationResult Excluir(int CodIdioma, int CodJogador, int Codficha)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FichaIdioma> ListarAtivos()
        {
            throw new NotImplementedException();
        }

        public Task<List<FichaIdioma>> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public FichaIdioma ListarUm(int CodIdioma, int CodJogador, int Codficha)
        {
            return _fichaIdiomaRepositorio.ListarUm(CodIdioma, CodJogador, Codficha);
        }

        public NotificationResult Salvar(FichaIdioma entidade)
        {
            throw new NotImplementedException();
        }
    }
}
