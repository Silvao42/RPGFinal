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
    public class MoedaServico : IMoedaServico
    {
        private readonly IMoedaRepositorio _moedaRepositorio;

        public MoedaServico(IMoedaRepositorio moedaRepositorio)
        {
            _moedaRepositorio = moedaRepositorio;
        }

        public NotificationResult Excluir(Moeda entidade)
        {
            var NotificationResult = new NotificationResult();

            try
            {
                if (entidade.CodMoeda != 0)
                {

                    if (NotificationResult.IsValid)
                    {
                        _moedaRepositorio.Remover(entidade);
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

        public IEnumerable<Moeda> ListarAtivos()
        {
            throw new NotImplementedException();
        }

        public Task<List<Moeda>> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public Moeda ListarUm(int CodMoeda)
        {
            return _moedaRepositorio.ListarUm( CodMoeda);
        }

        public NotificationResult Salvar(Moeda entidade)
        {
            var NotificationResult = new NotificationResult();

            try
            {

                if (entidade.CodMoeda != 0)
                {
                    entidade.CodMoeda = entidade.CodMoeda;

                    if (NotificationResult.IsValid)
                    {
                        _moedaRepositorio.Adicionar(entidade);
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

        public NotificationResult Atualizar(Moeda entidade)
        {
            var NotificationResult = new NotificationResult();
            try
            {
                if (entidade.CodMoeda != 0)

                    entidade.CodMoeda = entidade.CodMoeda;

                if (NotificationResult.IsValid)
                {
                    _moedaRepositorio.Atualizar(entidade);
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
