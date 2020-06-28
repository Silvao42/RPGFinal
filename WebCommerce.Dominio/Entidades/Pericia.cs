using System;
using System.Collections.Generic;
using System.Text;

namespace WebCommerce.Dominio.Entidades
{
    public class Pericia
    {
        public int CodJogador { get; set; }
        public int CodFicha { get; set; }
        public string Acrobacia { get; set; }
        public string AdestrarAnimais { get; set; }
        public string Arcanismo { get; set; }
        public string Atletismo { get; set; }
        public string Atuacao { get; set; }
        public string Enganacao { get; set; }
        public string Furtividade { get; set; }
        public string Historia { get; set; }
        public string Intimidacao { get; set; }
        public string Intuicao { get; set; }
        public string Investigacao { get; set; }
        public string Medicina { get; set; }
        public string Natureza { get; set; }
        public string Percepcao { get; set; }
        public string Persuasao { get; set; }
        public string Prestigitacao { get; set; }
        public string Religiao { get; set; }
        public string Sobrevivencia { get; set; }
        public Jogador Jogador { get; set; }
        public Ficha Ficha { get; set; }
    }
}
