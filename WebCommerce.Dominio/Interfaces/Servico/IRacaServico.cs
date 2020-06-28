using WebCommerce.Comum.NotificationPattern;
using WebCommerce.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebCommerce.Dominio.Entidades;

namespace WebCommerce.Dominio.Interfaces
{
    public interface IRacaServico
    {
        Raca ListarUm(int CodRaca);

        IEnumerable<Raca> ListarAtivos();
        Task<List<Raca>> ListarTodos();

        NotificationResult Salvar(Raca entidade);
        NotificationResult Excluir(int CodRaca);
    }
}
