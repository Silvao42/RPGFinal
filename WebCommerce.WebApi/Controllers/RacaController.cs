﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCommerce.Comum.NotificationPattern;
using WebCommerce.Dominio;
using WebCommerce.Servico;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebCommerce.Dominio.Interfaces;

namespace WebCommerce.WebApi.Controllers
{
    /// <summary>
    /// Operações relacionadas ao processo de CRUD dos produtos
    /// </summary>
    [ApiController]
    //[AutenticacaoBasica]
    [Route("[controller]")]
    public class RacaController : ControllerBase
    {
        private readonly IRacaServico _racaServico;

        /// <summary>
        /// Método Construtor do Controller Produto
        /// </summary>
        public RacaController(IRacaServico racaServico)
        {
            _racaServico = racaServico;
        }

        /// <summary>
        /// Listar Todos os Produtos
        /// </summary>
        /// <returns>
        /// Retorna uma lista de produtos do tipo "Produto"
        /// </returns>
        [HttpGet("todos")]
        public Task<List<Raca>> Todos() {
             return _racaServico.ListarTodos();
        }

        /// <summary>
        /// Lista de Todos os Produtos Ativos
        /// </summary>
        /// <returns></returns>
        [HttpGet("ativos")]
        public IEnumerable<Raca> Ativos() => _racaServico.ListarAtivos();


        [HttpPost("salvar")]
        public NotificationResult Salvar(Raca entidade)
        {
            return _racaServico.Salvar(entidade);
        }

        [HttpDelete("excluir")]
        public NotificationResult Excluir(int CodRaca)
        {
            return _racaServico.Excluir(CodRaca);
        }

        [HttpPut("Atualizar")]
        public NotificationResult Atualizar(Raca entidade)
        {
            return _racaServico.Atualizar(entidade);
        }

    }
}