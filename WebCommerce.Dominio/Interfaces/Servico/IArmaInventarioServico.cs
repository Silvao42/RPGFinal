using Aula09.Comum.NotificationPattern;
using Aula09.Dominio;
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
        Task<List<ArmaInventario>> ListarTodos();

        NotificationResult Salvar(ArmaInventario entidade);
        NotificationResult Excluir(int CodFicha, int CodJogador, int CodArma);
    }
}
