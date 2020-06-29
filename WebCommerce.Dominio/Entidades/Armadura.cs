using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WebCommerce.Dominio.Entidades
{
    public class Armadura
    {
        [Key]
        public int CodArmadura { get; set; }
        public string NomeArmadura { get; set; }
        public string ClasseArmadura { get; set; }
        public int Forca { get; set; }
        public string Furtividade { get; set; }
    }
}
