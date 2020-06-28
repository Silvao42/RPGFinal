using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using WebCommerce.Dados.Configuracoes;
using WebCommerce.Dominio.Entidades;

namespace WebCommerce.Dados
{
    public class Contexto : DbContext {

        //1. CLASSES - ENTIDADES - TABELAS
        //1. INICIO
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Grupo> Grupo { get; set; }
        public DbSet<Marca> Marca { get; set; }
        public DbSet<Arma> Arma { get; set; }
        public DbSet<ArmaInventario> ArmaInventario { get; set; }
        public DbSet<Armadura> Armadura { get; set; }
        public DbSet<ArmaduraInventario> ArmaduraInventario { get; set; }
        public DbSet<Atributo> Atributo { get; set; }
        public DbSet<Classe> Classe { get; set; }
        public DbSet<Ficha> Ficha { get; set; }
        public DbSet<FichaIdioma> FichaIdioma { get; set; }
        public DbSet<Idioma> Idioma { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<ItemInventario> ItemInventario { get; set; }
        public DbSet<Jogador> Jogador { get; set; }
        public DbSet<ListaMagia> ListaMagia { get; set; }
        public DbSet<Magia> Magia { get; set; }
        public DbSet<Moeda> Moeda { get; set; }
        public DbSet<Pericia> Pericia { get; set; }
        public DbSet<Raca> Raca { get; set; }
        //public DbSet<Departamento> Departamento { get; set; }
        //1. FIM

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=10.107.176.41;database=dbEcommerce;user id=visualstudio;password=visualstudio;");
        }
     
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //2. DEFINIÇÃO DAS CONFIGURAÇÕES DAS CLASSES
            //2. INICIO
            modelBuilder.ApplyConfiguration(new ProdutoConfiguracao());
            modelBuilder.ApplyConfiguration(new GrupoConfiguracao());
            modelBuilder.ApplyConfiguration(new MarcaConfiguracao());
            //modelBuilder.ApplyConfiguration(new DepartamentoConfiguracao());
            //2. FIM
        }

    }
}
