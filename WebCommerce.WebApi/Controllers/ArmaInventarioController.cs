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
    public class ArmaInventarioController : ControllerBase
    {
        private readonly IArmaInventarioServico _armaInventarioServico;

        /// <summary>
        /// Método Construtor do Controller Produto
        /// </summary>
        public ArmaInventarioController(IArmaInventarioServico armaInventarioServico)
        {
            _armaInventarioServico = armaInventarioServico;
        }

        /// <summary>
        /// Listar Todos os Produtos
        /// </summary>
        /// <returns>
        /// Retorna uma lista de produtos do tipo "Produto"
        /// </returns>
        [HttpGet("todos")]
        public Task<List<ArmaInventario>> Todos() {
             return _armaInventarioServico.ListarTodos();
        }

        /// <summary>
        /// Lista de Todos os Produtos Ativos
        /// </summary>
        /// <returns></returns>
        [HttpGet("ativos")]
        public IEnumerable<ArmaInventario> Ativos() => _armaInventarioServico.ListarAtivos();

        [HttpPost("salvar")]
        public NotificationResult Salvar(ArmaInventario entidade)
        {
            return _armaInventarioServico.Salvar(entidade);
        }

        [HttpDelete("excluir")]
        public NotificationResult Excluir(ArmaInventario entidade)
        {
            return _armaInventarioServico.Excluir(entidade);
        }

        [HttpPut("Atualizar")]
        public NotificationResult Atualizar(ArmaInventario entidade)
        {
            return _armaInventarioServico.Atualizar(entidade);
        }

    }
}