using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCommerce.Comum.NotificationPattern;
using WebCommerce.Dominio;
using WebCommerce.Servico;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebCommerce.Dominio.Entidades;
using WebCommerce.Dominio.Interfaces;

namespace WebCommerce.WebApi.Controllers
{
    /// <summary>
    /// Operações relacionadas ao processo de CRUD dos produtos
    /// </summary>
    [ApiController]
    //[AutenticacaoBasica]
    [Route("[controller]")]
    public class IdiomaController : ControllerBase
    {
        private readonly IIdiomaServico _idiomaServico;

        /// <summary>
        /// Método Construtor do Controller Produto
        /// </summary>
        public IdiomaController(IIdiomaServico idiomaServico)
        {
            _idiomaServico = idiomaServico;
        }

        /// <summary>
        /// Listar Todos os Produtos
        /// </summary>
        /// <returns>
        /// Retorna uma lista de produtos do tipo "Produto"
        /// </returns>
        [HttpGet("todos")]
        public Task<List<Idioma>> Todos() {
             return _idiomaServico.ListarTodos();
        }

        /// <summary>
        /// Lista de Todos os Produtos Ativos
        /// </summary>
        /// <returns></returns>
        [HttpGet("ativos")]
        public IEnumerable<Idioma> Ativos() => _idiomaServico.ListarAtivos();

        /// <summary>
        /// Exemplo de equals e getHashCode
        /// </summary>
        /// <returns></returns>
        //[HttpGet("igual")]
        //public bool EhIgual()
        //{
        //    var data = DateTime.Now;

        //    var produto1 = new Produto
        //    {
        //        idProduto = 1,
        //        Descricao = "NIKE",
        //        DataCadastro = data
        //    };

        //    var produto2 = new Produto
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
        public NotificationResult Salvar(Idioma entidade)
        {
            return _idiomaServico.Salvar(entidade);
        }

        [HttpDelete("excluir")]
        public NotificationResult Excluir(int CodIdioma)
        {
            return _idiomaServico.Excluir(CodIdioma);
        }

        [HttpPut("Atualizar")]
        public NotificationResult Atualizar(Idioma entidade)
        {
            return _idiomaServico.Atualizar(entidade);
        }
    }
}