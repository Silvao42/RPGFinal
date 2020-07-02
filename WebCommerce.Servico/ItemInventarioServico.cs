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
    public class ItemInventarioServico : IItemInventarioServico
    {
        private readonly IItemInventarioRepositorio _itemInventarioRepositorio;

        public ItemInventarioServico(IItemInventarioRepositorio itemInventarioRepositorio)
        {
            _itemInventarioRepositorio = itemInventarioRepositorio;
        }

        public NotificationResult Excluir(ItemInventario entidade)
        {
            var NotificationResult = new NotificationResult();

            try
            {
                if (entidade.CodFicha != 0 && entidade.CodJogador != 0 && entidade.CodItem != 0)
                {

                    if (NotificationResult.IsValid)
                    {
                        _itemInventarioRepositorio.Remover(entidade);
                        NotificationResult.Add("Cadastro excluido com Sucesso!");

                        return NotificationResult;
                    }

                    else
                        return NotificationResult.Add(new NotificationError("O codigo informado não existe!", NotificationErrorType.USER));
                }

                else
                    return NotificationResult.Add(new NotificationError("O codigo informado não existe!", NotificationErrorType.USER));
            }

            catch (Exception ex)
            {
                return NotificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public IEnumerable<ItemInventario> ListarAtivos()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ItemInventario> ListarTodos()
        {
            return _itemInventarioRepositorio.ListarTodos();
        }

        public ItemInventario ListarUm(int CodFicha, int CodJogador, int CodItem)
        {
            return _itemInventarioRepositorio.ListarUm(CodFicha, CodJogador, CodItem);
        }

        public NotificationResult Salvar(ItemInventario entidade)
        {
            var NotificationResult = new NotificationResult();

            try
            {

                if (entidade.CodFicha != 0 && entidade.CodJogador != 0 && entidade.CodItem != 0)
                {
                    entidade.CodFicha = entidade.CodFicha;
                    entidade.CodJogador = entidade.CodJogador;
                    entidade.CodItem = entidade.CodItem;

                    if (NotificationResult.IsValid)
                    {
                        _itemInventarioRepositorio.Adicionar(entidade);
                        NotificationResult.Add("Cadastrado!");
                    }

                    return NotificationResult;
                }

                else
                    return NotificationResult.Add(new NotificationError("Erro no cadastro!", NotificationErrorType.USER)); ;
            }

            catch (Exception ex)
            {
                return NotificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public NotificationResult Atualizar(ItemInventario entidade)
        {
            var NotificationResult = new NotificationResult();
            try
            {
                if (entidade.CodFicha != 0 && entidade.CodJogador != 0 && entidade.CodItem != 0)

                    entidade.CodFicha = entidade.CodFicha;
                    entidade.CodJogador = entidade.CodJogador;
                    entidade.CodItem = entidade.CodItem;

                if (NotificationResult.IsValid)
                {
                    _itemInventarioRepositorio.Atualizar(entidade);
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
