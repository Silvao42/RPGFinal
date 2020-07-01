using WebCommerce.Comum.NotificationPattern;
using WebCommerce.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebCommerce.Dominio.Interfaces;

namespace WebCommerce.Servico
{
    public class RacaServico : IRacaServico
    {
        private readonly IRacaRepositorio _racaRepositorio;

        public RacaServico(IRacaRepositorio racaRepositorio)
        {
            _racaRepositorio = racaRepositorio;
        }

        public NotificationResult Excluir(int CodRaca)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Raca> ListarAtivos()
        {
            throw new NotImplementedException();
        }

        public Task<List<Raca>> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public Raca ListarUm(int CodRaca)
        {
            return _racaRepositorio.ListarUm(CodRaca);
        }

        public NotificationResult Salvar(Raca entidade)
        {
            throw new NotImplementedException();
        }
        public NotificationResult Atualizar(Raca entidade)
        {
            var NotificationResult = new NotificationResult();
            try
            {
                if (entidade.CodRaca != 0)

                    entidade.CodRaca = entidade.CodRaca;

                if (NotificationResult.IsValid)
                {
                    _racaRepositorio.Atualizar(entidade);
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
