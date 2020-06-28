using WebCommerce.Dominio;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCommerce.Dominio.Entidades;
using WebCommerce.Dominio.Interfaces;

namespace WebCommerce.Dados
{
    public class ArmaduraInventarioRepositorio : RepositorioBase<ArmaduraInventario>, IArmaduraInventarioRepositorio
    {
        public IEnumerable<ArmaduraInventario> ListarAtivos()
        {
            return Contexto
                .ArmaduraInventario
                .ToList();
        }
    }
}