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

        public NotificationResult Excluir(int CodArmadura)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Armadura> ListarAtivos()
        {
            throw new NotImplementedException();
        }

        public Task<List<Armadura>> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public Armadura ListarUm(int CodArmadura)
        {
            return _armaduraRepositorio.ListarUm(CodArmadura);
        }

        public NotificationResult Salvar(Armadura entidade)
        {
            throw new NotImplementedException();
        }
    }
}
