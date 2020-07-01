using WebCommerce.Comum.NotificationPattern;
using WebCommerce.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebCommerce.Dominio.Entidades;

namespace WebCommerce.Dominio.Interfaces
{
    public interface IItemInventarioServico
    {
        ItemInventario ListarUm(int CodFicha, int CodJogador, int CodItem);

        IEnumerable<ItemInventario> ListarAtivos();
        Task<List<ItemInventario>> ListarTodos();

        NotificationResult Salvar(ItemInventario entidade);
        NotificationResult Excluir(ItemInventario entidade);
        NotificationResult Atualizar(ItemInventario entidade);
    }
}
