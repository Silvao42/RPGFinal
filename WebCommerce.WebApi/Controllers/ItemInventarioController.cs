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
    public class ItemInventarioController : ControllerBase
    {
        private readonly IItemInventarioServico _itemInventarioServico;

        /// <summary>
        /// Método Construtor do Controller Produto
        /// </summary>
        public ItemInventarioController(IItemInventarioServico itemInventarioServico)
        {
            _itemInventarioServico = itemInventarioServico;
        }

        /// <summary>
        /// Listar Todos os Produtos
        /// </summary>
        /// <returns>
        /// Retorna uma lista de produtos do tipo "Produto"
        /// </returns>
        [HttpGet("todos")]
        public IEnumerable<ItemInventario> Todos()
        {
            return _itemInventarioServico.ListarTodos();
        }

        /// <summary>
        /// Lista de Todos os Produtos Ativos
        /// </summary>
        /// <returns></returns>
        [HttpGet("LitarUm")]
        public IEnumerable<ItemInventario> Listar(int CodJogador, int CodFicha, int CodItem)
        {
            yield return _itemInventarioServico.ListarUm(CodJogador,CodFicha,CodItem);
        }

        [HttpPost("salvar")]
        public NotificationResult Salvar(ItemInventario entidade)
        {
            return _itemInventarioServico.Salvar(entidade);
        }

        [HttpDelete("excluir")]
        public NotificationResult Excluir(ItemInventario entidade)
        {
            return _itemInventarioServico.Excluir(entidade);
        }

        [HttpPut("Atualizar")]
        public NotificationResult Atualizar(ItemInventario entidade)
        {
            return _itemInventarioServico.Atualizar(entidade);
        }

    }
}