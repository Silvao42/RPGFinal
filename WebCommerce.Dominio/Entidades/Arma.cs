using System.ComponentModel.DataAnnotations;

namespace WebCommerce.Dominio.Entidades
{
    public class Arma
    {   
        [Key]
        public int CodArma { get; set; }
        public string NomeArma { get; set; }
        public string Dano { get; set; }
        public string Propriedade { get; set; }
    }
}
