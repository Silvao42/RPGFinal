using WebCommerce.Comum.NotificationPattern;
using WebCommerce.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebCommerce.Dominio.Entidades;

namespace WebCommerce.Dominio.Interfaces
{
    public interface IPericiaFichaServico
    {
        PericiaFicha ListarUm(int CodJogador, int CodFicha, int CodPericia);

        IEnumerable<PericiaFicha> ListarAtivos();
        Task<List<PericiaFicha>> ListarTodos();

        NotificationResult Salvar(PericiaFicha entidade);
        NotificationResult Excluir(int CodJogador, int CodFicha, int CodPericia);
        NotificationResult Atualizar(PericiaFicha entidade);
    }
}
