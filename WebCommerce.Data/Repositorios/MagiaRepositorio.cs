using WebCommerce.Dominio;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCommerce.Dominio.Entidades;
using WebCommerce.Dominio.Interfaces;

namespace WebCommerce.Dados
{
    public class MagiaRepositorio : RepositorioBase<Magia>, IMagiaRepositoro
    {
        public IEnumerable<Magia> ListarAtivos()
        {
            return Contexto
                .Magia
                .ToList();
        }
    }
}