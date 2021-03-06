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
    public class FichaController : ControllerBase
    {
        private readonly IFichaServico _fichaServico;

        /// <summary>
        /// Método Construtor do Controller Produto
        /// </summary>
        public FichaController(IFichaServico fichaServico)
        {
            _fichaServico = fichaServico;
        }

        /// <summary>
        /// Listar Todos os Produtos
        /// </summary>
        /// <returns>
        /// Retorna uma lista de produtos do tipo "Produto"
        /// </returns>
        [HttpGet("todos")]
        public IEnumerable<Ficha> Todos()
        {
            return _fichaServico.ListarTodos();
        }

        /// <summary>
        /// Lista de Todos os Produtos Ativos
        /// </summary>
        /// <returns></returns>
        [HttpGet("LitarUm")]
        public IEnumerable<Ficha> Listar(int CodFicha, int CodJogador)
        {
            yield return _fichaServico.ListarUm(CodFicha,CodJogador);
        }



        [HttpPost("salvar")]
        public NotificationResult Salvar(Ficha entidade)
        {
            return _fichaServico.Salvar(entidade);
        }

        [HttpDelete("excluir")]
        public NotificationResult Excluir(Ficha entidade)
        {
            return _fichaServico.Excluir(entidade);
        }

        [HttpPut("Atualizar")]
        public NotificationResult Atualizar(Ficha entidade)
        {
            return _fichaServico.Atualizar(entidade);
        }

    }
}