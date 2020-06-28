using WebCommerce.Comum.NotificationPattern;
using WebCommerce.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebCommerce.Dominio.Entidades;

namespace WebCommerce.Dominio.Interfaces
{
    public interface IItemServico
    {
        Item ListarUm(int CodItem);

        IEnumerable<Item> ListarAtivos();
        Task<List<Item>> ListarTodos();

        NotificationResult Salvar(Item entidade);
        NotificationResult Excluir(int CodItem);
    }
}
