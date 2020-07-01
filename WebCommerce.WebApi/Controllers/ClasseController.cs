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
    public class ClasseController : ControllerBase
    {
        private readonly IClasseServico _classeServico;

        /// <summary>
        /// Método Construtor do Controller Produto
        /// </summary>
        public ClasseController(IClasseServico classeServico)
        {
            _classeServico = classeServico;
        }

        /// <summary>
        /// Listar Todos os Produtos
        /// </summary>
        /// <returns>
        /// Retorna uma lista de produtos do tipo "Produto"
        /// </returns>
        [HttpGet("todos")]
        public Task<List<Classe>> Todos() {
             return _classeServico.ListarTodos();
        }

        /// <summary>
        /// Lista de Todos os Produtos Ativos
        /// </summary>
        /// <returns></returns>
        [HttpGet("ativos")]
        public IEnumerable<Classe> Ativos() => _classeServico.ListarAtivos();


        [HttpPost("salvar")]
        public NotificationResult Salvar(Classe entidade)
        {
            return _classeServico.Salvar(entidade);
        }

        [HttpDelete("excluir")]
        public NotificationResult Excluir(int CodClasse)
        {
            return _classeServico.Excluir(CodClasse);
        }

        [HttpPut("Atualizar")]
        public NotificationResult Atualizar(Classe entidade)
        {
            return _classeServico.Atualizar(entidade);
        }

    }
}