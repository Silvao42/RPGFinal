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
    public class JogadorController : ControllerBase
    {
        private readonly IJogadorServico _jogadorServico;

        /// <summary>
        /// Método Construtor do Controller Produto
        /// </summary>
        public JogadorController(IJogadorServico jogadorServico)
        {
            _jogadorServico = jogadorServico;
        }

        /// <summary>
        /// Listar Todos os Produtos
        /// </summary>
        /// <returns>
        /// Retorna uma lista de produtos do tipo "Produto"
        /// </returns>
        [HttpGet("todos")]
        public Task<List<Jogador>> Todos() {
             return _jogadorServico.ListarTodos();
        }

        /// <summary>
        /// Lista de Todos os Produtos Ativos
        /// </summary>
        /// <returns></returns>
        [HttpGet("ativos")]
        public IEnumerable<Jogador> Ativos() => _jogadorServico.ListarAtivos();


        [HttpPost("salvar")]
        public NotificationResult Salvar(Jogador entidade)
        {
            return _jogadorServico.Salvar(entidade);
        }

        [HttpDelete("excluir")]
        public NotificationResult Excluir(int CodJogador)
        {
            return _jogadorServico.Excluir(CodJogador);
        }

    }
}