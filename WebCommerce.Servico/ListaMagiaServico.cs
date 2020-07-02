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

        public NotificationResult Excluir(ListaMagia entidade)
        {
            var NotificationResult = new NotificationResult();

            try
            {
                if (entidade.CodFicha != 0 && entidade.CodJogador != 0 && entidade.CodMagia != 0)
                {

                    if (NotificationResult.IsValid)
                    {
                        _listaMagiaRepositorio.Remover(entidade);
                        NotificationResult.Add("Cadastro excluido com Sucesso!");

                        return NotificationResult;
                    }

                    else
                        return NotificationResult.Add(new NotificationError("O codigo informado não existe!", NotificationErrorType.USER));
                }

                else
                    return NotificationResult.Add(new NotificationError("O codigo informado não existe!", NotificationErrorType.USER));
            }

            catch (Exception ex)
            {
                return NotificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public IEnumerable<ListaMagia> ListarAtivos()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ListaMagia> ListarTodos()
        {
            return _listaMagiaRepositorio.ListarTodos();
        }

        public ListaMagia ListarUm(int CodMagia, int CodFicha, int CodJogador)
        {
            return _listaMagiaRepositorio.ListarUm(CodMagia, CodFicha, CodJogador);
        }

        public NotificationResult Salvar(ListaMagia entidade)
        {
            var NotificationResult = new NotificationResult();

            try
            {

                if (entidade.CodFicha != 0 && entidade.CodJogador != 0 && entidade.CodMagia != 0)
                {
                    entidade.CodFicha = entidade.CodFicha;
                    entidade.CodJogador = entidade.CodJogador;
                    entidade.CodMagia = entidade.CodMagia;

                    if (NotificationResult.IsValid)
                    {
                        _listaMagiaRepositorio.Adicionar(entidade);
                        NotificationResult.Add("Cadastrado!");
                    }

                    return NotificationResult;
                }

                else
                    return NotificationResult.Add(new NotificationError("Erro no cadastro!", NotificationErrorType.USER)); ;
            }

            catch (Exception ex)
            {
                return NotificationResult.Add(new NotificationError(ex.Message));
            }
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
