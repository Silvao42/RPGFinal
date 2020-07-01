using WebCommerce.Comum.NotificationPattern;
using WebCommerce.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebCommerce.Dominio.Entidades;

namespace WebCommerce.Dominio.Interfaces
{
    public interface IMoedaInventarioServico
    {
        MoedaInventario ListarUm(int CodFicha, int CodJogador, int CodMoeda);

        IEnumerable<MoedaInventario> ListarAtivos();
        Task<List<MoedaInventario>> ListarTodos();

        NotificationResult Salvar(MoedaInventario entidade);
        NotificationResult Excluir(MoedaInventario entidade);
        NotificationResult Atualizar(MoedaInventario entidade);
    }
}
