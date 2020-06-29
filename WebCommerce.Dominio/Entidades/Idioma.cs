using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WebCommerce.Dominio.Entidades
{
    public class Idioma
    {
        [Key]
        public int CodIdioma { get; set; }
        public string NomeIdioma { get; set; }
    }
}
