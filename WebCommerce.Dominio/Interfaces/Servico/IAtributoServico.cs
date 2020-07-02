using WebCommerce.Comum.NotificationPattern;
using WebCommerce.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebCommerce.Dominio.Entidades;

namespace WebCommerce.Dominio.Interfaces
{
    public interface IAtributoServico
    {
        Atributo ListarUm(int CodAtributo);

        IEnumerable<Atributo> ListarAtivos();
        IEnumerable<Atributo> ListarTodos();

        NotificationResult Salvar(Atributo entidade);
        NotificationResult Excluir(Atributo entidade);
        NotificationResult Atualizar(Atributo entidade);
    }
}
