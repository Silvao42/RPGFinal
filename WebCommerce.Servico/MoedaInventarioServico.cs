using WebCommerce.Comum.NotificationPattern;
using WebCommerce.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebCommerce.Dominio.Entidades;
using WebCommerce.Dominio.Interfaces;

namespace WebCommerce.Servico
{
    public class MoedaInventarioServico : IMoedaInventarioServico
    {
        private readonly IMoedaInventarioRepositorio _moedaInventarioRepositorio;

        public MoedaInventarioServico(IMoedaInventarioRepositorio moedaInventarioRepositorio)
        {
            _moedaInventarioRepositorio = moedaInventarioRepositorio;
        }

        public NotificationResult Excluir(int CodFicha, int CodJogador, int CodMoeda)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MoedaInventario> ListarAtivos()
        {
            throw new NotImplementedException();
        }

        public Task<List<MoedaInventario>> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public MoedaInventario ListarUm(int CodFicha, int CodJogador, int CodMoeda)
        {
            return _moedaInventarioRepositorio.ListarUm( CodFicha, CodJogador, CodMoeda);
        }

        public NotificationResult Salvar(MoedaInventario entidade)
        {
            throw new NotImplementedException();
        }
        public NotificationResult Atualizar(MoedaInventario entidade)
        {
            var NotificationResult = new NotificationResult();
            try
            {
                if (entidade.CodFicha != 0 && entidade.CodJogador != 0 && entidade.CodMoeda != 0)

                    entidade.CodFicha = entidade.CodFicha;
                    entidade.CodJogador = entidade.CodJogador;
                    entidade.CodMoeda = entidade.CodMoeda;

                if (NotificationResult.IsValid)
                {
                    _moedaInventarioRepositorio.Atualizar(entidade);
                    NotificationResult.Add("Cadastro Alterado com Sucesso!");

                    return NotificationResult;
                }

                else
                {
                    return NotificationResult.Add(new NotificationError("O codigo informado não existe!", NotificationErrorType.USER));
                }
            }
            catch (Exception)
            {
                return NotificationResult.Add(new NotificationError("O codigo informado não existe!", NotificationErrorType.USER));
            }

        }
    }
}
