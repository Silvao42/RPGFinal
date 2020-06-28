using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula09.Comum.NotificationPattern;
using Aula09.Dominio;
using Aula09.Servico;
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

        /// <summary>
        /// Listar Todos os Produtos
        /// </summary>
        /// <returns>
        /// Retorna uma lista de produtos do tipo "Produto"
        /// </returns>
        [HttpGet("todos")]
        public Task<List<ArmaduraInventario>> Todos() {
             return _armaduraInventarioServico.ListarTodos();
        }

        /// <summary>
        /// Lista de Todos os Produtos Ativos
        /// </summary>
        /// <returns></returns>
        [HttpGet("ativos")]
        public IEnumerable<ArmaduraInventario> Ativos() => _armaduraInventarioServico.ListarAtivos();

        /// <summary>
        /// Exemplo de equals e getHashCode
        /// </summary>
        /// <returns></returns>
        //[HttpGet("igual")]
        //public bool EhIgual()
        //{
        //    var data = DateTime.Now;

        //    var produto1 = new ArmaduraInventario
        //    {
        //        idProduto = 1,
        //        Descricao = "NIKE",
        //        DataCadastro = data
        //    };

        //    var produto2 = new ArmaduraInventario
        //    {
        //        idProduto = 1,
        //        Descricao = "ADIDAS",
        //        DataCadastro = data
        //    };

        //    //return produto1 == produto2;
        //    return produto1.Equals(produto2);
        //}

        /// <summary>
        /// Evento responsável pelo cadastro de Produtos
        /// </summary>
        /// <param name="entidade">
        ///     
        /// </param>
        /// <remarks>
        ///     {
        ///        "idProduto": 1,
        ///        "Nome": "Item1",
        ///        "PrecoCusto": 10.0
        ///     }
        /// </remarks>
        /// <returns></returns>
        [HttpPost("salvar")]
        public NotificationResult Salvar(ArmaduraInventario entidade)
        {
            return _armaduraInventarioServico.Salvar(entidade);
        }

        [HttpDelete("excluir")]
        public NotificationResult Excluir(int CodJogador, int CodFicha, int CodArmadura)
        {
            return _armaduraInventarioServico.Excluir( CodJogador, CodFicha, CodArmadura);
        }

    }
}