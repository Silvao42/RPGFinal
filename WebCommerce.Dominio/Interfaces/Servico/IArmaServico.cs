using WebCommerce.Comum.NotificationPattern;
using WebCommerce.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebCommerce.Dominio.Entidades;

namespace WebCommerce.Dominio.Interfaces
{
    public interface IArmaServico
    {
        Arma ListarUm(int CodArma);

        IEnumerable<Arma> ListarAtivos();
        IEnumerable<Arma> ListarTodos();

        NotificationResult Salvar(Arma entidade);
        NotificationResult Excluir(int CodArma);
    }
}
