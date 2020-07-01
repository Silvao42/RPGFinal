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
    public class AtributoServico : IAtributoServico
    {
        private readonly IAtributoRepositorio _atributoServico;

        public AtributoServico(IAtributoRepositorio atributoServico)
        {
            _atributoServico = atributoServico;
        }

        public NotificationResult Excluir(int CodAtributo)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Atributo> ListarAtivos()
        {
            throw new NotImplementedException();
        }

        public Task<List<Atributo>> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public Atributo ListarUm(int CodAtributo)
        {
            return _atributoServico.ListarUm(CodAtributo);
        }

        public NotificationResult Salvar(Atributo entidade)
        {
            throw new NotImplementedException();
        }
        public NotificationResult Atualizar(Atributo entidade)
        {
            var NotificationResult = new NotificationResult();
            try
            {
                if (entidade.CodAtributo != 0)

                    entidade.CodAtributo = entidade.CodAtributo;

                if (NotificationResult.IsValid)
                {
                    _atributoServico.Atualizar(entidade);
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
