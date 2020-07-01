using System;
using System.Collections.Generic;
using System.Text;

namespace WebCommerce.Dominio.Entidades
{
    public class MoedaInventario
    {
        public int CodFicha { get; set; }
        public int CodJogador { get; set; }
        public int CodMoeda { get; set; }
        public int Qtd { get; set; }
        public Ficha Ficha { get; set; }
        public Moeda Moeda { get; set; }
    }
}
