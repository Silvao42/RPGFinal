using WebCommerce.Comum.NotificationPattern;
using WebCommerce.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebCommerce.Dominio.Entidades;

namespace WebCommerce.Dominio.Interfaces
{
    public interface IMoedaServico
    {
        Moeda ListarUm(int CodMoeda);

        IEnumerable<Moeda> ListarAtivos();
        Task<List<Moeda>> ListarTodos();

        NotificationResult Salvar(Moeda entidade);
        NotificationResult Excluir(Moeda entidade);
        NotificationResult Atualizar(Moeda entidade);
    }
}
