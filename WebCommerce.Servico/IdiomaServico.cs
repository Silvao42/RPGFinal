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
    public class IdiomaServico : IIdiomaServico
    {
        private readonly IIdiomaRepositorio _idiomaRepositorio;

        public IdiomaServico(IIdiomaRepositorio idiomaRepositorio)
        {
            _idiomaRepositorio = idiomaRepositorio;
        }

        public NotificationResult Excluir(Idioma entidade)
        {
            var NotificationResult = new NotificationResult();

            try
            {
                if (entidade.CodIdioma != 0)
                {

                    if (NotificationResult.IsValid)
                    {
                        _idiomaRepositorio.Remover(entidade);
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

        public IEnumerable<Idioma> ListarAtivos()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Idioma> ListarTodos()
        {
            return _idiomaRepositorio.ListarTodos();
        }

        public Idioma ListarUm(int CodIdioma)
        {
            return _idiomaRepositorio.ListarUm(CodIdioma);
        }

        public NotificationResult Salvar(Idioma entidade)
        {
            var NotificationResult = new NotificationResult();

            try
            {

                if (entidade.CodIdioma != 0)
                {
                    entidade.CodIdioma = entidade.CodIdioma;

                    if (NotificationResult.IsValid)
                    {
                        _idiomaRepositorio.Adicionar(entidade);
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

        public NotificationResult Atualizar(Idioma entidade)
        {
            var NotificationResult = new NotificationResult();
            try
            {
                if (entidade.CodIdioma != 0)

                    entidade.CodIdioma = entidade.CodIdioma;

                if (NotificationResult.IsValid)
                {
                    _idiomaRepositorio.Atualizar(entidade);
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
