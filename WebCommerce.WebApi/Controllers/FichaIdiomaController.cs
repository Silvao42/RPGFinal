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
    public class FichaIdiomaController : ControllerBase
    {
        private readonly IFichaIdiomaServico _fichaIdiomaServico;

        /// <summary>
        /// Método Construtor do Controller Produto
        /// </summary>
        public FichaIdiomaController(IFichaIdiomaServico fichaIdiomaServico)
        {
            _fichaIdiomaServico = fichaIdiomaServico;
        }

        /// <summary>
        /// Listar Todos os Produtos
        /// </summary>
        /// <returns>
        /// Retorna uma lista de produtos do tipo "Produto"
        /// </returns>
        [HttpGet("todos")]
        public Task<List<FichaIdioma>> Todos() {
             return _fichaIdiomaServico.ListarTodos();
        }

        /// <summary>
        /// Lista de Todos os Produtos Ativos
        /// </summary>
        /// <returns></returns>
        [HttpGet("ativos")]
        public IEnumerable<FichaIdioma> Ativos() => _fichaIdiomaServico.ListarAtivos();


        [HttpPost("salvar")]
        public NotificationResult Salvar(FichaIdioma entidade)
        {
            return _fichaIdiomaServico.Salvar(entidade);
        }

        [HttpDelete("excluir")]
        public NotificationResult Excluir(int CodIdioma, int CodJogador, int CodFicha)
        {
            return _fichaIdiomaServico.Excluir( CodIdioma, CodJogador, CodFicha);
        }

        [HttpPut("Atualizar")]
        public NotificationResult Atualizar(FichaIdioma entidade)
        {
            return _fichaIdiomaServico.Atualizar(entidade);
        }

    }
}