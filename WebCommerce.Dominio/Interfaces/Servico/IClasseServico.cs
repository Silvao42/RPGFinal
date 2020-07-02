using WebCommerce.Comum.NotificationPattern;
using WebCommerce.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebCommerce.Dominio.Entidades;

namespace WebCommerce.Dominio.Interfaces
{
    public interface IClasseServico
    {
        Classe ListarUm(int CodClasse);

        IEnumerable<Classe> ListarAtivos();
        IEnumerable<Classe> ListarTodos();

        NotificationResult Salvar(Classe entidade);
        NotificationResult Excluir(Classe entidade);
        NotificationResult Atualizar(Classe entidade);
    }
}
