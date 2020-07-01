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
    public class ArmaduraInventarioController : ControllerBase
    {
        private readonly IArmaduraInventarioServico _armaduraInventarioServico;

        /// <summary>
        /// Método Construtor do Controller Produto
        /// </summary>
        public ArmaduraInventarioController(IArmaduraInventarioServico armaduraInventarioServico)
        {
            _armaduraInventarioServico = armaduraInventarioServico;
        }

        [HttpGet("todos")]
        public Task<List<ArmaduraInventario>> Todos() {
             return _armaduraInventarioServico.ListarTodos();
        }


        [HttpGet("ativos")]
        public IEnumerable<ArmaduraInventario> Ativos() => _armaduraInventarioServico.ListarAtivos();

       
        [HttpPost("salvar")]
        public NotificationResult Salvar(ArmaduraInventario entidade)
        {
            return _armaduraInventarioServico.Salvar(entidade);
        }

        [HttpDelete("excluir")]
        public NotificationResult Excluir(ArmaduraInventario entidade)
        {
            return _armaduraInventarioServico.Excluir(entidade);
        }

        [HttpPut("Atualizar")]
        public NotificationResult Atualizar(ArmaduraInventario entidade)
        {
            return _armaduraInventarioServico.Atualizar(entidade);
        }

    }
}