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
        Task<List<Classe>> ListarTodos();

        NotificationResult Salvar(Classe entidade);
        NotificationResult Excluir(int CodClasse);
        NotificationResult Atualizar(Classe entidade);
    }
}
