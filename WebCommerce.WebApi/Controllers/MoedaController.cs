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
    public class MoedaController : ControllerBase
    {
        private readonly IMoedaServico _moedaServico;

        /// <summary>
        /// Método Construtor do Controller Produto
        /// </summary>
        public MoedaController(IMoedaServico moedaServico)
        {
            _moedaServico = moedaServico;
        }

        /// <summary>
        /// Listar Todos os Produtos
        /// </summary>
        /// <returns>
        /// Retorna uma lista de produtos do tipo "Produto"
        /// </returns>
        [HttpGet("todos")]
        public Task<List<Moeda>> Todos() {
             return _moedaServico.ListarTodos();
        }

        /// <summary>
        /// Lista de Todos os Produtos Ativos
        /// </summary>
        /// <returns></returns>
        [HttpGet("ativos")]
        public IEnumerable<Moeda> Ativos() => _moedaServico.ListarAtivos();

        [HttpPost("salvar")]
        public NotificationResult Salvar(Moeda entidade)
        {
            return _moedaServico.Salvar(entidade);
        }

        [HttpDelete("excluir")]
        public NotificationResult Excluir(Moeda entidade)
        {
            return _moedaServico.Excluir(entidade);
        }

        [HttpPut("Atualizar")]
        public NotificationResult Atualizar(Moeda entidade)
        {
            return _moedaServico.Atualizar(entidade);
        }

    }
}