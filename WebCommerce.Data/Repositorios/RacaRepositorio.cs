using WebCommerce.Dominio;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCommerce.Dominio.Interfaces;

namespace WebCommerce.Dados
{
    public class RacaRepositorio : RepositorioBase<Raca>, IRacaRepositorio
    {
        public IEnumerable<Raca> ListarAtivos()
        {
            return Contexto
                .Raca
                .ToList();
        }
    }
}