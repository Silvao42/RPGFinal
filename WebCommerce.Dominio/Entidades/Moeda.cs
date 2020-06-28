using System;
using System.Collections.Generic;
using System.Text;

namespace WebCommerce.Dominio.Entidades
{
    public class Moeda
    {
        public int CodFicha { get; set; }
        public int CodJogador { get; set; }
        public int Cobre { get; set; }
        public int Prata { get; set; }
        public int Electro { get; set; }
        public int Ouro { get; set; }
        public int Platina { get; set; }
        public Jogador Jogador { get; set; }
        public Ficha Ficha { get; set; }
    }
}
