using WebCommerce.Comum.NotificationPattern;
using WebCommerce.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebCommerce.Dominio.Entidades;

namespace WebCommerce.Dominio.Interfaces
{
    public interface IFichaAtributoServico
    {
        FichaAtributo ListarUm(int CodFicha, int CodJogador, int CodAtributo);

        IEnumerable<FichaAtributo> ListarAtivos();
        Task<List<FichaAtributo>> ListarTodos();

        NotificationResult Salvar(FichaAtributo entidade);
        NotificationResult Excluir(FichaAtributo entidade);
        NotificationResult Atualizar(FichaAtributo entidade);
    }
}
