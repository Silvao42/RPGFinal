﻿using WebCommerce.Comum.NotificationPattern;
using WebCommerce.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebCommerce.Dominio.Entidades;
using WebCommerce.Dominio.Interfaces;

namespace WebCommerce.Servico
{
    public class ItemServico : IItemServico
    {
        private readonly IItemRepositorio _itemRepositorio;

        public ItemServico(IItemRepositorio itemRepositorio)
        {
            _itemRepositorio = itemRepositorio;
        }

        public NotificationResult Excluir(int CodItem)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Item> ListarAtivos()
        {
            throw new NotImplementedException();
        }

        public Task<List<Item>> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public Item ListarUm(int CodItem)
        {
            return _itemRepositorio.ListarUm(CodItem);
        }

        public NotificationResult Salvar(Item entidade)
        {
            throw new NotImplementedException();
        }
        public NotificationResult Atualizar(Item entidade)
        {
            var NotificationResult = new NotificationResult();
            try
            {
                if (entidade.CodItem != 0)

                    entidade.CodItem = entidade.CodItem;

                if (NotificationResult.IsValid)
                {
                    _itemRepositorio.Atualizar(entidade);
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
