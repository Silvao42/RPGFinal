﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCommerce.Comum.NotificationPattern;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebCommerce.Dominio.Interfaces;
using WebCommerce.Dominio;
using WebCommerce.Dominio;
using WebCommerce.Dominio.Entidades;

namespace WebCommerce.WebApi.Controllers
{
    /// <summary>
    /// Operações relacionadas ao processo de CRUD dos produtos
    /// </summary>
    [ApiController]
    //[AutenticacaoBasica]
    [Route("[controller]")]
    public class ListaMagiaController : ControllerBase
    {
        private readonly IListaMagiaServico _listaMagiaServico;

        /// <summary>
        /// Método Construtor do Controller Produto
        /// </summary>
        public ListaMagiaController(IListaMagiaServico listaMagiaServico)
        {
            _listaMagiaServico = listaMagiaServico;
        }

        /// <summary>
        /// Listar Todos os Produtos
        /// </summary>
        /// <returns>
        /// Retorna uma lista de produtos do tipo "Produto"
        /// </returns>
        [HttpGet("todos")]
        public IEnumerable<ListaMagia> Todos()
        {
            return _listaMagiaServico.ListarTodos();
        }

        /// <summary>
        /// Lista de Todos os Produtos Ativos
        /// </summary>
        /// <returns></returns>
        [HttpGet("LitarUm")]
        public IEnumerable<ListaMagia> Listar(int CodJogador, int CodFicha, int CodMagia)
        {
            yield return _listaMagiaServico.ListarUm(CodJogador,CodFicha,CodMagia);
        }

        [HttpPost("salvar")]
        public NotificationResult Salvar(ListaMagia entidade)
        {
            return _listaMagiaServico.Salvar(entidade);
        }

        [HttpDelete("excluir")]
        public NotificationResult Excluir(ListaMagia entidade)
        {
            return _listaMagiaServico.Excluir(entidade);
        }

        [HttpPut("Atualizar")]
        public NotificationResult Atualizar(ListaMagia entidade)
        {
            return _listaMagiaServico.Atualizar(entidade);
        }

    }
}