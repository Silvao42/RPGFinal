using System;
using System.Collections.Generic;
using System.Text;

namespace WebCommerce.Dominio.Entidades
{
    public class FichaIdioma
    {
        public int CodIdioma { get; set; }
        public int CodFicha { get; set; }
        public int CodJogador { get; set; }
        public Jogador Jogador { get; set; }
        public Ficha Ficha { get; set; }
        public Idioma Idioma { get; set; }
    }
}
