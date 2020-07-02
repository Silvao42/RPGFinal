using WebCommerce.Comum.NotificationPattern;
using WebCommerce.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebCommerce.Dominio.Entidades;

namespace WebCommerce.Dominio.Interfaces
{
    public interface IMagiaServico
    {
        Magia ListarUm(int CodMagia);

        IEnumerable<Magia> ListarAtivos();
        IEnumerable<Magia> ListarTodos();

        NotificationResult Salvar(Magia entidade);
        NotificationResult Excluir(Magia entidade);
        NotificationResult Atualizar(Magia entidade);
    }
}
