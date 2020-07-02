using WebCommerce.Comum.NotificationPattern;
using WebCommerce.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebCommerce.Dominio.Entidades;

namespace WebCommerce.Dominio.Interfaces
{
    public interface IFichaIdiomaServico
    {
        FichaIdioma ListarUm(int CodIdioma, int CodJogador, int CodFicha);

        IEnumerable<FichaIdioma> ListarAtivos();
        IEnumerable<FichaIdioma> ListarTodos();

        NotificationResult Salvar(FichaIdioma entidade);
        NotificationResult Excluir(FichaIdioma entidade);
        NotificationResult Atualizar(FichaIdioma entidade);
    }
}
