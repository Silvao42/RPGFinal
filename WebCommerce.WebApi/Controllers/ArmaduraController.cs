using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCommerce.Comum.NotificationPattern;
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
    public class ArmaduraController : ControllerBase
    {
        private readonly IArmaduraServico _armaduraServico;

        /// <summary>
        /// Método Construtor do Controller Produto
        /// </summary>
        public ArmaduraController(IArmaduraServico armaduraServico)
        {
            _armaduraServico = armaduraServico;
        }

        [HttpGet("todos")]
        public IEnumerable<Armadura> Todos() {
             return _armaduraServico.ListarTodos();
        }

        [HttpGet("LitarUm")]
        public IEnumerable<Armadura> Listar(int CodArmadura)
        {
            yield return _armaduraServico.ListarUm(CodArmadura);
        }


        [HttpPost("salvar")]
        public NotificationResult Salvar(Armadura entidade)
        {
            return _armaduraServico.Salvar(entidade);
        }

        [HttpDelete("excluir")]
        public NotificationResult Excluir(Armadura CodArmadura)
        {
            return _armaduraServico.Excluir(CodArmadura);
        }

        [HttpPut("Atualizar")]
        public NotificationResult Atualizar(Armadura entidade)
        {
            return _armaduraServico.Atualizar(entidade);
        }

    }
}