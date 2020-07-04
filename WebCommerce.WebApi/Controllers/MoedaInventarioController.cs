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
    public class MoedaInventarioController : ControllerBase
    {
        private readonly IMoedaInventarioServico _moedaInventarioServico;

        /// <summary>
        /// Método Construtor do Controller Produto
        /// </summary>
        public MoedaInventarioController(IMoedaInventarioServico moedaInventarioServico)
        {
            _moedaInventarioServico = moedaInventarioServico;
        }

        /// <summary>
        /// Listar Todos os Produtos
        /// </summary>
        /// <returns>
        /// Retorna uma lista de produtos do tipo "Produto"
        /// </returns>
        [HttpGet("todos")]
        public IEnumerable<MoedaInventario> Todos()
        {
            return _moedaInventarioServico.ListarTodos();
        }

        /// <summary>
        /// Lista de Todos os Produtos Ativos
        /// </summary>
        /// <returns></returns>
        [HttpGet("LitarUm")]
        public IEnumerable<MoedaInventario> Listar(int CodJogador, int CodFicha, int CodMoeda)
        {
            yield return _moedaInventarioServico.ListarUm(CodJogador,CodFicha,CodMoeda);
        }

        [HttpPost("salvar")]
        public NotificationResult Salvar(MoedaInventario entidade)
        {
            return _moedaInventarioServico.Salvar(entidade);
        }

        [HttpDelete("excluir")]
        public NotificationResult Excluir(MoedaInventario entidade)
        {
            return _moedaInventarioServico.Excluir(entidade);
        }

        [HttpPut("Atualizar")]
        public NotificationResult Atualizar(MoedaInventario entidade)
        {
            return _moedaInventarioServico.Atualizar(entidade);
        }

    }
}