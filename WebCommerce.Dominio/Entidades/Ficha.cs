using WebCommerce.Dominio;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace WebCommerce.Dominio.Entidades
{
    public class Ficha
    {
        [Key]
        public int CodFicha { get; set; }
        public int CodJogador { get; set; }
        public string NomePersonagem { get; set; }
        public int Vida { get; set; }
        public int ClasseArmadura { get; set; }
        public int Iniciativa { get; set; }
        public double Deslocamento { get; set; }
        public int CodClasse { get; set; }
        public int CodRaca { get; set; }
        public Jogador Jogador { get; set; }
        public Classe Classe { get; set; }
        public Raca Raca { get; set; }

    }
}
