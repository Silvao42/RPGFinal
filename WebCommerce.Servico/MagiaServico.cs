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

        public NotificationResult Excluir(Magia entidade)
        {
            var NotificationResult = new NotificationResult();

            try
            {
                if (entidade.CodMagia != 0)
                {

                    if (NotificationResult.IsValid)
                    {
                        _magiaRepositoro.Remover(entidade);
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

        public IEnumerable<Magia> ListarAtivos()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Magia> ListarTodos()
        {
            return _magiaRepositoro.ListarTodos();
        }

        public Magia ListarUm(int CodMagia)
        {
            return _magiaRepositoro.ListarUm(CodMagia);
        }

        public NotificationResult Salvar(Magia entidade)
        {
            var NotificationResult = new NotificationResult();

            try
            {

                if (entidade.CodMagia != 0)
                {
                    entidade.CodMagia = entidade.CodMagia;

                    if (NotificationResult.IsValid)
                    {
                        _magiaRepositoro.Adicionar(entidade);
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

        public NotificationResult Atualizar(Magia entidade)
        {
            var NotificationResult = new NotificationResult();
            try
            {
                if (entidade.CodMagia != 0)

                    entidade.CodMagia = entidade.CodMagia;

                if (NotificationResult.IsValid)
                {
                    _magiaRepositoro.Atualizar(entidade);
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
