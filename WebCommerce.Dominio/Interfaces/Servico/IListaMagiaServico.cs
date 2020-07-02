using WebCommerce.Comum.NotificationPattern;
using WebCommerce.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebCommerce.Dominio.Entidades;

namespace WebCommerce.Dominio.Interfaces
{
    public interface IListaMagiaServico
    {
        ListaMagia ListarUm(int CodMagia, int CodFicha, int CodJogador);

        IEnumerable<ListaMagia> ListarAtivos();
        <ListaMagia> ListarTodos();

        NotificationResult Salvar(ListaMagia entidade);
        NotificationResult Excluir(ListaMagia entidade);
        NotificationResult Atualizar(ListaMagia entidade);
    }
}
