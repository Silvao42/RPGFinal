using System;
using System.Collections.Generic;
using System.Text;

namespace WebCommerce.Dominio.Entidades
{
    public class Atributo
    {
        public int CodFicha { get; set; }
        public int CodJogador { get; set; }
        public int Forca { get; set; }
        public int Destreza { get; set; }
        public int Constituicao { get; set; }
        public int Inteligencia { get; set; }
        public int Sabedoria { get; set; }
        public int Carisma { get; set; }
        public Jogador Jogador { get; set; }
        public Ficha Ficha { get; set; }
    }
}
