﻿using WebCommerce.Comum.NotificationPattern;
using WebCommerce.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebCommerce.Dominio.Entidades;

namespace WebCommerce.Dominio.Interfaces
{
    public interface IJogadorServico
    {
        Jogador ListarUm(int CodJogador);

        IEnumerable<Jogador> ListarAtivos();
        IEnumerable<Jogador> ListarTodos();

        NotificationResult Salvar(Jogador entidade);
        NotificationResult Excluir(Jogador entidade);
        NotificationResult Atualizar(Jogador entidade);
    }
}
