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
    public class ItemInventarioServico : IItemInventarioServico
    {
        private readonly IItemInventarioRepositorio _itemInventarioRepositorio;

        public ItemInventarioServico(IItemInventarioRepositorio itemInventarioRepositorio)
        {
            _itemInventarioRepositorio = itemInventarioRepositorio;
        }

        public NotificationResult Excluir(int CodFicha, int CodJogador, int CodItem)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ItemInventario> ListarAtivos()
        {
            throw new NotImplementedException();
        }

        public Task<List<ItemInventario>> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public ItemInventario ListarUm(int CodFicha, int CodJogador, int CodItem)
        {
            return _itemInventarioRepositorio.ListarUm(CodFicha, CodJogador, CodItem);
        }

        public NotificationResult Salvar(ItemInventario entidade)
        {
            throw new NotImplementedException();
        }
    }
}
