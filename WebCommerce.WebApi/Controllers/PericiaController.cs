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
    public class PericiaController : ControllerBase
    {
        private readonly IPericiaServico _periciaServico;

        /// <summary>
        /// Método Construtor do Controller Produto
        /// </summary>
        public PericiaController(IPericiaServico periciaServico)
        {
            _periciaServico = periciaServico;
        }

        /// <summary>
        /// Listar Todos os Produtos
        /// </summary>
        /// <returns>
        /// Retorna uma lista de produtos do tipo "Produto"
        /// </returns>
        [HttpGet("todos")]
        public IEnumerable<Pericia> Todos()
        {
            return _periciaServico.ListarTodos();
        }

        /// <summary>
        /// Lista de Todos os Produtos Ativos
        /// </summary>
        /// <returns></returns>
        [HttpGet("LitarUm")]
        public IEnumerable<Pericia> Listar(int CodPericia)
        {
            yield return _periciaServico.ListarUm(CodPericia);
        }


        [HttpPost("salvar")]
        public NotificationResult Salvar(Pericia entidade)
        {
            return _periciaServico.Salvar(entidade);
        }

        [HttpDelete("excluir")]
        public NotificationResult Excluir(Pericia entidade)
        {
            return _periciaServico.Excluir(entidade);
        }

        [HttpPut("Atualizar")]
        public NotificationResult Atualizar(Pericia entidade)
        {
            return _periciaServico.Atualizar(entidade);
        }

    }
}