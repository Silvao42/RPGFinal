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
    public class FichaAtributoServico : IFichaAtributoServico
    {
        private readonly IFichaAtributoRepositorio _fichaAtributoServico;

        public FichaAtributoServico(IFichaAtributoRepositorio fichaAtributoServico)
        {
            _fichaAtributoServico = fichaAtributoServico;
        }

        public NotificationResult Excluir(FichaAtributo entidade)
        {
            var NotificationResult = new NotificationResult();

            try
            {
                if (entidade.CodJogador != 0 && entidade.CodFicha != 0 && entidade.CodJogador != 0)
                {

                    if (NotificationResult.IsValid)
                    {
                        _fichaAtributoServico.Remover(entidade);
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

        public IEnumerable<FichaAtributo> ListarAtivos()
        {
            throw new NotImplementedException();
        }

        public Task<List<FichaAtributo>> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public FichaAtributo ListarUm(int CodFicha, int CodJogador, int CodAtributo)
        {
            return _fichaAtributoServico.ListarUm(CodFicha, CodJogador, CodAtributo);
        }

        public NotificationResult Salvar(FichaAtributo entidade)
        {
            var NotificationResult = new NotificationResult();

            try
            {

                if (entidade.CodJogador != 0 && entidade.CodFicha != 0 && entidade.CodJogador != 0)
                {
                    entidade.CodJogador = entidade.CodJogador;
                    entidade.CodFicha = entidade.CodFicha;
                    entidade.CodJogador = entidade.CodJogador;

                    if (NotificationResult.IsValid)
                    {
                        _fichaAtributoServico.Adicionar(entidade);
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

        public NotificationResult Atualizar(FichaAtributo entidade)
        {
            var NotificationResult = new NotificationResult();
            try
            {
                if (entidade.CodJogador != 0 && entidade.CodFicha != 0 && entidade.CodJogador != 0)

                    entidade.CodJogador = entidade.CodJogador;
                    entidade.CodFicha = entidade.CodFicha;
                    entidade.CodJogador = entidade.CodJogador;

                if (NotificationResult.IsValid)
                {
                    _fichaAtributoServico.Atualizar(entidade);
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
