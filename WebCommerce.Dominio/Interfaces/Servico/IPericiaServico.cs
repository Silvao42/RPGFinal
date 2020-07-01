using WebCommerce.Comum.NotificationPattern;
using WebCommerce.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebCommerce.Dominio.Entidades;

namespace WebCommerce.Dominio.Interfaces
{
    public interface IPericiaServico
    {
        Pericia ListarUm(int CodPericia);

        IEnumerable<Pericia> ListarAtivos();
        Task<List<Pericia>> ListarTodos();

        NotificationResult Salvar(Pericia entidade);
        NotificationResult Excluir(int CodPericia);
        NotificationResult Atualizar(Pericia entidade);
    }
}
