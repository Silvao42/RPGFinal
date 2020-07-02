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
    public class ArmaduraServico : IArmaduraServico
    {
        private readonly IArmaduraRepositorio _armaduraRepositorio;

        public ArmaduraServico(IArmaduraRepositorio armaduraRepositorio)
        {
            _armaduraRepositorio = armaduraRepositorio;
        }

        public NotificationResult Excluir(Armadura entidade)
        {
            var NotificationResult = new NotificationResult();

            try
            {
                if (entidade.CodArmadura != 0)
                {

                    if (NotificationResult.IsValid)
                    {
                        _armaduraRepositorio.Remover(entidade);
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

        public IEnumerable<Armadura> ListarAtivos()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Armadura> ListarTodos()
        {
            return _armaduraRepositorio.ListarTodos();
        }

        public Armadura ListarUm(int CodArmadura)
        {
            return _armaduraRepositorio.ListarUm(CodArmadura);
        }

        public NotificationResult Salvar(Armadura entidade)
        {
            var NotificationResult = new NotificationResult();

            try
            {

                if (entidade.CodArmadura != 0)
                {
                    entidade.CodArmadura = entidade.CodArmadura;

                    if (NotificationResult.IsValid)
                    {
                        _armaduraRepositorio.Adicionar(entidade);
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

        public NotificationResult Atualizar(Armadura entidade)
        {
            var NotificationResult = new NotificationResult();
            try
            {
                if (entidade.CodArmadura != 0)

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
