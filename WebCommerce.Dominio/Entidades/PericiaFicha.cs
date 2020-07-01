using System;
using System.Collections.Generic;
using System.Text;

namespace WebCommerce.Dominio.Entidades
{
    public class PericiaFicha
    {
        public int CodJogador { get; set; }
        public int CodFicha { get; set; }
        public int CodPericia { get; set; }
        public Pericia Pericia { get; set; }
        public Ficha Ficha { get; set; }
    }
}
