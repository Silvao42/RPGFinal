﻿using System;
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
    public class ItemController : ControllerBase
    {
        private readonly IItemServico _itemServico;

        /// <summary>
        /// Método Construtor do Controller Produto
        /// </summary>
        public ItemController(IItemServico itemServico)
        {
            _itemServico = itemServico;
        }

        /// <summary>
        /// Listar Todos os Produtos
        /// </summary>
        /// <returns>
        /// Retorna uma lista de produtos do tipo "Produto"
        /// </returns>
        [HttpGet("todos")]
        public Task<List<Item>> Todos() {
             return _itemServico.ListarTodos();
        }

        /// <summary>
        /// Lista de Todos os Produtos Ativos
        /// </summary>
        /// <returns></returns>
        [HttpGet("ativos")]
        public IEnumerable<Item> Ativos() => _itemServico.ListarAtivos();

        [HttpPost("salvar")]
        public NotificationResult Salvar(Item entidade)
        {
            return _itemServico.Salvar(entidade);
        }

        [HttpDelete("excluir")]
        public NotificationResult Excluir(Item entidade)
        {
            return _itemServico.Excluir(entidade);
        }

        [HttpPut("Atualizar")]
        public NotificationResult Atualizar(Item entidade)
        {
            return _itemServico.Atualizar(entidade);
        }

    }
}