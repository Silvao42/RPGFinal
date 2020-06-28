using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCommerce.Dominio.Entidades;
using WebCommerce.Dominio.Interfaces;

namespace WebCommerce.Dados
{
    public class ItemInventarioRepositorio : RepositorioBase<ItemInventario>, IItemInventarioRepositorio
    {
        public IEnumerable<ItemInventario> ListarAtivos()
        {
            return Contexto
                .ItemInventario
                .ToList();
        }
    }
}