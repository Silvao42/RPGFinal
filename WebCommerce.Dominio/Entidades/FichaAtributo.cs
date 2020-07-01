using System;
using System.Collections.Generic;
using System.Text;

namespace WebCommerce.Dominio.Entidades
{
    public class FichaAtributo
    {
        public int CodFicha { get; set; }
        public int CodJogador { get; set; }
        public int CodAtributo { get; set; }
        public Atributo Atributo { get; set; }
        public Ficha Ficha { get; set; }
    }
}
