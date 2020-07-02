using WebCommerce.Comum.NotificationPattern;
using WebCommerce.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebCommerce.Dominio.Entidades;

namespace WebCommerce.Dominio.Interfaces
{
    public interface IArmaduraServico
    {
        Armadura ListarUm(int CodArmadura);

        IEnumerable<Armadura> ListarAtivos();
        IEnumerable<Armadura> ListarTodos();

        NotificationResult Salvar(Armadura entidade);
        NotificationResult Excluir(Armadura CodArmadura);
        NotificationResult Atualizar(Armadura entidade);
    }
}
