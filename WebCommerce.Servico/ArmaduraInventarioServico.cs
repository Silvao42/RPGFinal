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
    }
}
