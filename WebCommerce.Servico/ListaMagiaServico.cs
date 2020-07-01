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
    public class ListaMagiaServico : IListaMagiaServico
    {
        private readonly IListaMagiaRepositorio _listaMagiaRepositorio;

        public ListaMagiaServico(IListaMagiaRepositorio listaMagiaRepositorio)
        {
            _listaMagiaRepositorio = listaMagiaRepositorio;
        }

        public NotificationResult Excluir(int CodMagia, int CodFicha, int CodJogador)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ListaMagia> ListarAtivos()
        {
            throw new NotImplementedException();
        }

        public Task<List<ListaMagia>> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public ListaMagia ListarUm(int CodMagia, int CodFicha, int CodJogador)
        {
            return _listaMagiaRepositorio.ListarUm(CodMagia, CodFicha, CodJogador);
        }

        public NotificationResult Salvar(ListaMagia entidade)
        {
            throw new NotImplementedException();
        }
        public NotificationResult Atualizar(ListaMagia entidade)
        {
            var NotificationResult = new NotificationResult();
            try
            {
                if (entidade.CodFicha != 0 && entidade.CodJogador != 0 && entidade.CodMagia != 0)

                    entidade.CodFicha = entidade.CodFicha;
                    entidade.CodJogador = entidade.CodJogador;
                    entidade.CodMagia = entidade.CodMagia;

                if (NotificationResult.IsValid)
                {
                    _listaMagiaRepositorio.Atualizar(entidade);
                    NotificationResult.Add("Cadastro Alterado com Sucesso!");

                    return NotificationResult;
                }

                else
                {
                    return NotificationResult.Add(new NotificationError("O codigo informado não existe!", NotificationErrorType.USER));
                }
            }
            catch (Exception)
            {
                return NotificationResult.Add(new NotificationError("O codigo informado não existe!", NotificationErrorType.USER));
            }

        }
    }
}
