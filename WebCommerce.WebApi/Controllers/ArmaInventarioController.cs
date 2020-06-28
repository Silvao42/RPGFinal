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
        private readonly IArmaInventarioServico _armaServico;

        /// <summary>
        /// Método Construtor do Controller Produto
        /// </summary>
        public ArmaInventarioController(IArmaInventarioServico armaServico)
        {
            _armaServico = armaServico;
        }

        /// <summary>
        /// Listar Todos os Produtos
        /// </summary>
        /// <returns>
        /// Retorna uma lista de produtos do tipo "Produto"
        /// </returns>
        [HttpGet("todos")]
        public Task<List<ArmaInventario>> Todos() {
             return _armaServico.ListarTodos();
        }

        /// <summary>
        /// Lista de Todos os Produtos Ativos
        /// </summary>
        /// <returns></returns>
        [HttpGet("ativos")]
        public IEnumerable<ArmaInventario> Ativos() => _armaServico.ListarAtivos();

        [HttpPost("salvar")]
        public NotificationResult Salvar(ArmaInventario entidade)
        {
            return _armaServico.Salvar(entidade);
        }

        [HttpDelete("excluir")]
        public NotificationResult Excluir(int CodFicha, int CodJogador, int CodArma)
        {
            return _armaServico.Excluir( CodFicha, CodJogador, CodArma);
        }

    }
}