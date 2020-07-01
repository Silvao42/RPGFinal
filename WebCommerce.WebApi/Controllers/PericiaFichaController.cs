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
    public class PericiaFichaController : ControllerBase
    {
        private readonly IPericiaFichaServico _periciaFichaServico;

        /// <summary>
        /// Método Construtor do Controller Produto
        /// </summary>
        public PericiaFichaController(IPericiaFichaServico periciaFichaServico)
        {
            _periciaFichaServico = periciaFichaServico;
        }

        /// <summary>
        /// Listar Todos os Produtos
        /// </summary>
        /// <returns>
        /// Retorna uma lista de produtos do tipo "Produto"
        /// </returns>
        [HttpGet("todos")]
        public Task<List<PericiaFicha>> Todos() {
             return _periciaFichaServico.ListarTodos();
        }

        /// <summary>
        /// Lista de Todos os Produtos Ativos
        /// </summary>
        /// <returns></returns>
        [HttpGet("ativos")]
        public IEnumerable<PericiaFicha> Ativos() => _periciaFichaServico.ListarAtivos();

 
        [HttpPost("salvar")]
        public NotificationResult Salvar(PericiaFicha entidade)
        {
            return _periciaFichaServico.Salvar(entidade);
        }

        [HttpDelete("excluir")]
        public NotificationResult Excluir(int CodJogador, int CodFiha, int CodPericia)
        {
            return _periciaFichaServico.Excluir( CodJogador, CodFiha, CodPericia);
        }

        [HttpPut("Atualizar")]
        public NotificationResult Atualizar(PericiaFicha entidade)
        {
            return _periciaFichaServico.Atualizar(entidade);
        }

    }
}