﻿using System;
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
    public class ArmaController : ControllerBase
    {
        private readonly IArmaServico _armaServico;

        /// <summary>
        /// Método Construtor do Controller Produto
        /// </summary>
        public ArmaController(IArmaServico armaServico)
        {
            _armaServico = armaServico;
        }


        [HttpGet("todos")]
        public IEnumerable<Arma> Todos()
        {
            return _armaServico.ListarTodos();
        }


        [HttpGet("LitarUm")]
        public IEnumerable<Arma> Listar(int CodArma)
        {
            yield return _armaServico.ListarUm(CodArma);
        }

        [HttpPost("salvar")]
        public NotificationResult Salvar(Arma entidade)
        {
            return _armaServico.Salvar(entidade);
        }

        [HttpDelete("excluir")]
        public NotificationResult Excluir(Arma CodArma)
        {
            return _armaServico.Excluir(CodArma);
        }

        [HttpPut("Atualizar")]
        public NotificationResult Atualizar(Arma entidade)
        {
            return _armaServico.Atualizar(entidade);
        }

    }
}