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
    public class ClasseServico : IClasseServico
    {
        private readonly IClasseRepositorio _classeRepositorio;

        public ClasseServico(IClasseRepositorio classeRepositorio)
        {
            _classeRepositorio = classeRepositorio;
        }

        public NotificationResult Excluir(Classe entidade)
        {
            var NotificationResult = new NotificationResult();

            try
            {
                if (entidade.CodClasse != 0)
                {

                    if (NotificationResult.IsValid)
                    {
                        _classeRepositorio.Remover(entidade);
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

        public IEnumerable<Classe> ListarAtivos()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Classe> ListarTodos()
        {
            return _classeRepositorio.ListarTodos();
        }

        public Classe ListarUm(int CodClasse)
        {
            return _classeRepositorio.ListarUm(CodClasse);
        }

        public NotificationResult Salvar(Classe entidade)
        {
            var NotificationResult = new NotificationResult();

            try
            {

                if (entidade.CodClasse != 0)
                {
                    entidade.CodClasse = entidade.CodClasse;

                    if (NotificationResult.IsValid)
                    {
                        _classeRepositorio.Adicionar(entidade);
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

        public NotificationResult Atualizar(Classe entidade)
        {
            var NotificationResult = new NotificationResult();
            try
            {
                if (entidade.CodClasse != 0)

                    entidade.CodClasse = entidade.CodClasse;

                if (NotificationResult.IsValid)
                {
                    _classeRepositorio.Atualizar(entidade);
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
