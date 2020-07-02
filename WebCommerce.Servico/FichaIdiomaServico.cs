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
    public class FichaIdiomaServico : IFichaIdiomaServico
    {
        private readonly IFichaIdiomaRepositorio _fichaIdiomaRepositorio;

        public FichaIdiomaServico(IFichaIdiomaRepositorio fichaIdiomaRepositorio)
        {
            _fichaIdiomaRepositorio = fichaIdiomaRepositorio;
        }

        public NotificationResult Excluir(FichaIdioma entidade)
        {
            var NotificationResult = new NotificationResult();

            try
            {
                if (entidade.CodFicha != 0 && entidade.CodJogador != 0 && entidade.CodIdioma != 0)
                {

                    if (NotificationResult.IsValid)
                    {
                        _fichaIdiomaRepositorio.Remover(entidade);
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
            var NotificationResult = new NotificationResult();

            try
            {

                if (entidade.CodFicha != 0 && entidade.CodJogador != 0 && entidade.CodIdioma != 0)
                {
                    entidade.CodFicha = entidade.CodFicha;
                    entidade.CodJogador = entidade.CodJogador;
                    entidade.CodIdioma = entidade.CodIdioma;

                    if (NotificationResult.IsValid)
                    {
                        _fichaIdiomaRepositorio.Adicionar(entidade);
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

        public NotificationResult Atualizar(FichaIdioma entidade)
        {
            var NotificationResult = new NotificationResult();
            try
            {
                if (entidade.CodFicha != 0 && entidade.CodJogador != 0 && entidade.CodIdioma != 0)

                    entidade.CodFicha = entidade.CodFicha;
                    entidade.CodJogador = entidade.CodJogador;
                    entidade.CodIdioma = entidade.CodIdioma;

                if (NotificationResult.IsValid)
                {
                    _fichaIdiomaRepositorio.Atualizar(entidade);
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
