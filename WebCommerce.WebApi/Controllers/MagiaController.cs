using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebCommerce.Comum.NotificationPattern;
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
    public class MagiaController : ControllerBase
    {
        private readonly IMagiaServico _magiaServico;

        /// <summary>
        /// Método Construtor do Controller Produto
        /// </summary>
        public MagiaController(IMagiaServico produtoServico)
        {
            _magiaServico = produtoServico;
        }

        /// <summary>
        /// Listar Todos os Produtos
        /// </summary>
        /// <returns>
        /// Retorna uma lista de produtos do tipo "Produto"
        /// </returns>
        [HttpGet("todos")]
        public Task<List<Magia>> Todos() {
             return _magiaServico.ListarTodos();
        }

        /// <summary>
        /// Lista de Todos os Produtos Ativos
        /// </summary>
        /// <returns></returns>
        [HttpGet("ativos")]
        public IEnumerable<Magia> Ativos() => _magiaServico.ListarAtivos();

        [HttpPost("salvar")]
        public NotificationResult Salvar(Magia entidade)
        {
            return _magiaServico.Salvar(entidade);
        }

        [HttpDelete("excluir")]
        public NotificationResult Excluir(int CodMagia)
        {
            return _magiaServico.Excluir(CodMagia);
        }

        [HttpPut("Atualizar")]
        public NotificationResult Atualizar(Magia entidade)
        {
            return _magiaServico.Atualizar(entidade);
        }

    }
}