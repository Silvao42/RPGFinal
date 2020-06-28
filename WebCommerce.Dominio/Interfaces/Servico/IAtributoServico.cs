﻿using Aula09.Comum.NotificationPattern;
using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebCommerce.Dominio.Entidades;

namespace WebCommerce.Dominio.Interfaces
{
    public interface IAtributoServico
    {
        Atributo ListarUm(int CodFicha, int CodJogador);

        IEnumerable<Atributo> ListarAtivos();
        Task<List<Atributo>> ListarTodos();

        NotificationResult Salvar(Atributo entidade);
        NotificationResult Excluir(int CodFicha, int CodJogador);
    }
}
