﻿using WebCommerce.Comum.NotificationPattern;
using WebCommerce.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebCommerce.Dominio.Entidades;

namespace WebCommerce.Dominio.Interfaces
{
    public interface IFichaServico
    {
        Ficha ListarUm(int CodFicha, int CodJogador);

        IEnumerable<Ficha> ListarAtivos();
        Task<List<Ficha>> ListarTodos();

        NotificationResult Salvar(Ficha entidade);
        NotificationResult Excluir(int CodFicha, int CodJogador);
        NotificationResult Atualizar(Ficha entidade);
    }
}
