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
        public IEnumerable<Magia> Todos()
        {
            return _magiaServico.ListarTodos();
        }

        /// <summary>
        /// Lista de Todos os Produtos Ativos
        /// </summary>
        /// <returns></returns>
        [HttpGet("LitarUm")]
        public IEnumerable<Magia> Listar(int CodMagia)
        {
            yield return _magiaServico.ListarUm(CodMagia);
        }

        [HttpPost("salvar")]
        public NotificationResult Salvar(Magia entidade)
        {
            return _magiaServico.Salvar(entidade);
        }

        [HttpDelete("excluir")]
        public NotificationResult Excluir(Magia entidade)
        {
            return _magiaServico.Excluir(entidade);
        }

        [HttpPut("Atualizar")]
        public NotificationResult Atualizar(Magia entidade)
        {
            return _magiaServico.Atualizar(entidade);
        }

    }
}