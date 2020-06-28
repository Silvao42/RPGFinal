using System;
using System.Collections.Generic;
using System.Text;

namespace WebCommerce.Dominio.Entidades
{
    public class ArmaduraInventario
    {
        public int CodArmadura { get; set; }
        public int CodFicha { get; set; }
        public int CodJogador { get; set; }
        public Jogador Jogador { get; set; }
        public Ficha Ficha { get; set; }
        public Armadura Armadura { get; set; }
    }
}
