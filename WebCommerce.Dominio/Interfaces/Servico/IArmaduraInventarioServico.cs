﻿using WebCommerce.Comum.NotificationPattern;
using WebCommerce.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebCommerce.Dominio.Entidades;

namespace WebCommerce.Dominio.Interfaces
{
    public interface IArmaduraInventarioServico
    {
        ArmaduraInventario ListarUm(int CodJogador, int CodFicha, int CodArmadura);

        IEnumerable<ArmaduraInventario> ListarAtivos();
        IEnumerable<ArmaduraInventario> ListarTodos();

        NotificationResult Salvar(ArmaduraInventario entidade);
        NotificationResult Excluir(ArmaduraInventario entidade);
        NotificationResult Atualizar(ArmaduraInventario entidade);
    }
}
