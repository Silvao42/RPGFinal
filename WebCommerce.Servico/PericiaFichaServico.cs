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
    public class PericiaFichaServico : IPericiaFichaServico
    {
        private readonly IPericiaFichaRepositorio _periciaFichaRepositorio;

        public PericiaFichaServico(IPericiaFichaRepositorio periciaFichaRepositorio)
        {
            _periciaFichaRepositorio = periciaFichaRepositorio;
        }

        public NotificationResult Excluir(PericiaFicha entidade)
        {
            var NotificationResult = new NotificationResult();

            try
            {
                if (entidade.CodFicha != 0 && entidade.CodJogador != 0 && entidade.CodPericia != 0)
                {

                    if (NotificationResult.IsValid)
                    {
                        _periciaFichaRepositorio.Remover(entidade);
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

        public IEnumerable<PericiaFicha> ListarAtivos()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PericiaFicha> ListarTodos()
        {
            return _periciaFichaRepositorio.ListarTodos();
        }

        public PericiaFicha ListarUm(int CodJogador, int CodFicha, int CodPericia)
        {
            return _periciaFichaRepositorio.ListarUm( CodJogador,  CodFicha, CodPericia);
        }

        public NotificationResult Salvar(PericiaFicha entidade)
        {
            var NotificationResult = new NotificationResult();

            try
            {

                if (entidade.CodFicha != 0 && entidade.CodJogador != 0 && entidade.CodPericia != 0)
                {
                    entidade.CodFicha = entidade.CodFicha;
                    entidade.CodJogador = entidade.CodJogador;
                    entidade.CodPericia = entidade.CodPericia;

                    if (NotificationResult.IsValid)
                    {
                        _periciaFichaRepositorio.Adicionar(entidade);
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

        public NotificationResult Atualizar(PericiaFicha entidade)
        {
            var NotificationResult = new NotificationResult();
            try
            {
                if (entidade.CodFicha != 0 && entidade.CodJogador != 0 && entidade.CodPericia != 0)

                    entidade.CodFicha = entidade.CodFicha;
                    entidade.CodJogador = entidade.CodJogador;
                    entidade.CodPericia = entidade.CodPericia;

                if (NotificationResult.IsValid)
                {
                    _periciaFichaRepositorio.Atualizar(entidade);
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
