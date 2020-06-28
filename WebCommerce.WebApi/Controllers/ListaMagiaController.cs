using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula09.Comum.NotificationPattern;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebCommerce.Dominio.Interfaces;
using WebCommerce.Dominio;
using Aula09.Dominio;
using WebCommerce.Dominio.Entidades;

namespace WebCommerce.WebApi.Controllers
{
    /// <summary>
    /// Operações relacionadas ao processo de CRUD dos produtos
    /// </summary>
    [ApiController]
    //[AutenticacaoBasica]
    [Route("[controller]")]
    public class ListaMagiaController : ControllerBase
    {
        private readonly IListaMagiaServico _listaMagiaServico;

        /// <summary>
        /// Método Construtor do Controller Produto
        /// </summary>
        public ListaMagiaController(IListaMagiaServico listaMagiaServico)
        {
            _listaMagiaServico = listaMagiaServico;
        }

        /// <summary>
        /// Listar Todos os Produtos
        /// </summary>
        /// <returns>
        /// Retorna uma lista de produtos do tipo "Produto"
        /// </returns>
        [HttpGet("todos")]
        public Task<List<ListaMagia>> Todos() {
             return _listaMagiaServico.ListarTodos();
        }

        /// <summary>
        /// Lista de Todos os Produtos Ativos
        /// </summary>
        /// <returns></returns>
        [HttpGet("ativos")]
        public IEnumerable<ListaMagia> Ativos() => _listaMagiaServico.ListarAtivos();

        /// <summary>
        /// Exemplo de equals e getHashCode
        /// </summary>
        /// <returns></returns>
        [HttpGet("igual")]
        public bool EhIgual()
        {
            var data = DateTime.Now;

            var produto1 = new Produto
            {
                idProduto = 1,
                Descricao = "NIKE",
                DataCadastro = data
            };

            var produto2 = new Produto
            {
                idProduto = 1,
                Descricao = "ADIDAS",
                DataCadastro = data
            };

            //return produto1 == produto2;
            return produto1.Equals(produto2);
        }

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
        public NotificationResult Salvar(ListaMagia entidade)
        {
            return _listaMagiaServico.Salvar(entidade);
        }

        [HttpDelete("excluir")]
        public NotificationResult Excluir(int CodMagia, int CodFicha, int CodJogador)
        {
            return _listaMagiaServico.Excluir( CodMagia, CodFicha, CodJogador);
        }

    }
}