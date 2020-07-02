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
    public class ArmaServico : IArmaServico
    {
        private readonly IArmaRepositorio _armaRepositorio;

        public ArmaServico(IArmaRepositorio armaRepositorio)
        {
            _armaRepositorio = armaRepositorio;
        }

        public NotificationResult Excluir(Arma entidade)
        {
            var NotificationResult = new NotificationResult();

            try
            {
                if (entidade.CodArma != 0)
                {

                    if (NotificationResult.IsValid)
                    {
                        _armaRepositorio.Remover(entidade);
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

        public IEnumerable<Arma> ListarAtivos()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Arma> ListarTodos()
        {
            return _armaRepositorio.ListarTodos();
        }

        public Arma ListarUm(int CodArma)
        {
            return _armaRepositorio.ListarUm(CodArma);
        }

        public NotificationResult Salvar(Arma entidade)
        {
            var NotificationResult = new NotificationResult();

            try
            {

                if (entidade.CodArma == 0)
                {
                    entidade.CodArma = entidade.CodArma;

                    if (NotificationResult.IsValid)
                    {
                        _armaRepositorio.Adicionar(entidade);
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

        public NotificationResult Atualizar(Arma entidade)
        {
            var NotificationResult = new NotificationResult();
            try
            {
                if (entidade.CodArma != 0)

                entidade.CodArma = entidade.CodArma;

                if (NotificationResult.IsValid)
                {
                    _armaRepositorio.Atualizar(entidade);
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
