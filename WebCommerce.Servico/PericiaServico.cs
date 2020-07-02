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
    public class PericiaServico : IPericiaServico
    {
        private readonly IPericiaRepositorio _periciaRepositorio;

        public PericiaServico(IPericiaRepositorio periciaRepositorio)
        {
            _periciaRepositorio = periciaRepositorio;
        }

        public NotificationResult Excluir(Pericia entidade)
        {
            var NotificationResult = new NotificationResult();

            try
            {
                if (entidade.CodPericia != 0)
                {

                    if (NotificationResult.IsValid)
                    {
                        _periciaRepositorio.Remover(entidade);
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

        public IEnumerable<Pericia> ListarAtivos()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pericia> ListarTodos()
        {
            return _periciaRepositorio.ListarTodos();
        }

        public Pericia ListarUm(int CodPericia)
        {
            return _periciaRepositorio.ListarUm(CodPericia);
        }

        public NotificationResult Salvar(Pericia entidade)
        {
            var NotificationResult = new NotificationResult();

            try
            {

                if (entidade.CodPericia != 0)
                {
                    entidade.CodPericia = entidade.CodPericia;

                    if (NotificationResult.IsValid)
                    {
                        _periciaRepositorio.Adicionar(entidade);
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

        public NotificationResult Atualizar(Pericia entidade)
        {
            var NotificationResult = new NotificationResult();
            try
            {
                if (entidade.CodPericia != 0)

                    entidade.CodPericia = entidade.CodPericia;

                if (NotificationResult.IsValid)
                {
                    _periciaRepositorio.Atualizar(entidade);
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
