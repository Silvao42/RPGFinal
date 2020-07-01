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
    public class ArmaduraInventarioServico : IArmaduraInventarioServico
    {
        private readonly IArmaduraInventarioRepositorio _armaduraRepositorio;

        public ArmaduraInventarioServico(IArmaduraInventarioRepositorio armaduraRepositorio)
        {
            _armaduraRepositorio = armaduraRepositorio;
        }

        public NotificationResult Excluir(int CodFicha, int CodJogador, int CodArmadura)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ArmaduraInventario> ListarAtivos()
        {
            throw new NotImplementedException();
        }

        public Task<List<ArmaduraInventario>> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public ArmaduraInventario ListarUm(int CodFicha, int CodJogador, int CodArmadura)
        {
            return _armaduraRepositorio.ListarUm(CodFicha, CodJogador, CodArmadura);
        }

        public NotificationResult Salvar(ArmaduraInventario entidade)
        {
            throw new NotImplementedException();
        }
        public NotificationResult Atualizar(ArmaduraInventario entidade)
        {
            var NotificationResult = new NotificationResult();
            try
            {
                if (entidade.CodJogador != 0 && entidade.CodFicha != 0 && entidade.CodArmadura != 0)

                    entidade.CodJogador = entidade.CodJogador;
                    entidade.CodFicha = entidade.CodFicha;
                    entidade.CodArmadura = entidade.CodArmadura;

                if (NotificationResult.IsValid)
                {
                    _armaduraRepositorio.Atualizar(entidade);
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
