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
    public class FichaServico : IFichaServico
    {
        private readonly IFichaRepositorio _fichaRepositorio;

        public FichaServico(IFichaRepositorio fichaRepositorio)
        {
            _fichaRepositorio = fichaRepositorio;
        }

        public NotificationResult Excluir(Ficha entidade)
        {
            var NotificationResult = new NotificationResult();

            try
            {
                if (entidade.CodJogador != 0 && entidade.CodFicha != 0)
                {

                    if (NotificationResult.IsValid)
                    {
                        _fichaRepositorio.Remover(entidade);
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

        public IEnumerable<Ficha> ListarAtivos()
        {
            throw new NotImplementedException();
        }

        public Task<List<Ficha>> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public Ficha ListarUm(int CodFicha, int CodJogador)
        {
            return _fichaRepositorio.ListarUm(CodFicha, CodJogador);
        }

        public NotificationResult Salvar(Ficha entidade)
        {
            throw new NotImplementedException();
        }
        public NotificationResult Atualizar(Ficha entidade)
        {
            var NotificationResult = new NotificationResult();
            try
            {
                if (entidade.CodJogador != 0 && entidade.CodFicha != 0)

                    entidade.CodJogador = entidade.CodJogador;
                    entidade.CodFicha = entidade.CodFicha;

                if (NotificationResult.IsValid)
                {
                    _fichaRepositorio.Atualizar(entidade);
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
