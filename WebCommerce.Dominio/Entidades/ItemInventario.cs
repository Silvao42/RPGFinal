using System;
using System.Collections.Generic;
using System.Text;

namespace WebCommerce.Dominio.Entidades
{
    public class ItemInventario
    {
        public int CodItem { get; set; }
        public int CodFicha { get; set; }
        public int CodJogador { get; set; }
        public Jogador Jogador { get; set; }
        public Ficha Ficha { get; set; }
        public Item Item { get; set; }
    }
}
