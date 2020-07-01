using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCommerce.Comum.NotificationPattern;
using WebCommerce.Servico;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebCommerce.Dominio.Interfaces;
using WebCommerce.Dominio.Entidades;

namespace WebCommerce.WebApi.Controllers
{
    /// <summary>
    /// Operações relacionadas ao processo de CRUD dos produtos
    /// </summary>
    [ApiController]
    //[AutenticacaoBasica]
    [Route("[controller]")]
    public class AtributoController : ControllerBase
    {
        private readonly IAtributoServico _atributoServico;

        /// <summary>
        /// Método Construtor do Controller Produto
        /// </summary>
        public AtributoController(IAtributoServico atributoServico)
        {
            _atributoServico = atributoServico;
        }

        /// <summary>
        /// Listar Todos os Produtos
        /// </summary>
        /// <returns>
        /// Retorna uma lista de produtos do tipo "Produto"
        /// </returns>
        [HttpGet("todos")]
        public Task<List<Atributo>> Todos() {
             return _atributoServico.ListarTodos();
        }

        /// <summary>
        /// Lista de Todos os Produtos Ativos
        /// </summary>
        /// <returns></returns>
        [HttpGet("ativos")]
        public IEnumerable<Atributo> Ativos() => _atributoServico.ListarAtivos();

        /// <summary>
        /// Exemplo de equals e getHashCode
        /// </summary>
        /// <returns></returns>
        //[HttpGet("igual")]
        //public bool EhIgual()
        //{
        //    var data = DateTime.Now;

        //    var produto1 = new Atributo
        //    {
        //        idProduto = 1,
        //        Descricao = "NIKE",
        //        DataCadastro = data
        //    };

        //    var produto2 = new Atributo
        //    {
        //        idProduto = 1,
        //        Descricao = "ADIDAS",
        //        DataCadastro = data
        //    };

        //    //return produto1 == produto2;
        //    return produto1.Equals(produto2);
        //}

        /// <summary>
        /// Evento responsável pelo cadastro de Produtos
        /// </summary>
        /// <param name="entidade">
        ///     
        /// </param>
        /// <remarks>
        ///     {
        ///        "idProduto": 1,
        ///        "Nome": "Item1",
        ///        "PrecoCusto": 10.0
        ///     }
        /// </remarks>
        /// <returns></returns>
        [HttpPost("salvar")]
        public NotificationResult Salvar(Atributo entidade)
        {
            return _atributoServico.Salvar(entidade);
        }

        [HttpDelete("excluir")]
        public NotificationResult Excluir(Atributo entidade)
        {
            return _atributoServico.Excluir (entidade);
        }

        [HttpPut("Atualizar")]
        public NotificationResult Atualizar(Atributo entidade)
        {
            return _atributoServico.Atualizar(entidade);
        }

    }
}