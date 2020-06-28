using Aula09.Comum.NotificationPattern;
using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebCommerce.Dominio.Entidades;
using WebCommerce.Dominio.Interfaces;

namespace WebCommerce.Servico
{
    public class ArmaInventarioServico : IArmaInventarioServico
    {
        private readonly IArmaInventarioRepositorio _armaInventarioRepositorio;

        public ArmaInventarioServico(IArmaInventarioRepositorio armaInventarioRepositorio)
        {
            _armaInventarioRepositorio = armaInventarioRepositorio;
        }

        public NotificationResult Excluir(int CodFicha, int CodJogador, int CodArma)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ArmaInventario> ListarAtivos()
        {
            throw new NotImplementedException();
        }

        public Task<List<ArmaInventario>> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public ArmaInventario ListarUm(int CodFicha, int CodJogador, int CodArma)
        {
            return _armaInventarioRepositorio.ListarUm(CodFicha, CodJogador, CodArma);
        }

        public NotificationResult Salvar(ArmaInventario entidade)
        {
            throw new NotImplementedException();
        }
    }
}
