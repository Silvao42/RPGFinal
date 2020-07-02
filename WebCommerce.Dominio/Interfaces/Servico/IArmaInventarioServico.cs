using WebCommerce.Comum.NotificationPattern;
using WebCommerce.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebCommerce.Dominio.Entidades;

namespace WebCommerce.Dominio.Interfaces
{
    public interface IArmaInventarioServico
    {
        ArmaInventario ListarUm(int CodFicha, int CodJogador, int CodArma);

        IEnumerable<ArmaInventario> ListarAtivos();
        IEnumerable<ArmaInventario> ListarTodos();

        NotificationResult Salvar(ArmaInventario entidade);
        NotificationResult Excluir(ArmaInventario entidade);
        NotificationResult Atualizar(ArmaInventario entidade);
    }
}
