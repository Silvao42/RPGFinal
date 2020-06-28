using WebCommerce.Dominio;
using Microsoft.EntityFrameworkCore;
using WebCommerce.Dados.Configuracoes;
using WebCommerce.Dominio.Entidades;

namespace WebCommerce.Dados
{
    public class Contexto : DbContext {

        //1. CLASSES - ENTIDADES - TABELAS
        //1. INICIO

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
            optionsBuilder.UseSqlServer("server=10.107.176.41;database=dbLAB2_2020;user id=visualstudio;password=visualstudio;");
        }
     
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //2. DEFINIÇÃO DAS CONFIGURAÇÕES DAS CLASSES
            //2. INICIO
      

            modelBuilder.ApplyConfiguration(new ArmaConfiguracao());
            modelBuilder.ApplyConfiguration(new ArmaduraConfiguracao());
            modelBuilder.ApplyConfiguration(new ArmaduraInventarioConfiguracao());
            modelBuilder.ApplyConfiguration(new AtributoConfiguracao());
            modelBuilder.ApplyConfiguration(new ClasseConfiguracao());
            modelBuilder.ApplyConfiguration(new ClasseConfiguracao());
            modelBuilder.ApplyConfiguration(new FichaConfiguracao());
            modelBuilder.ApplyConfiguration(new FichaIdiomaConfiguracao());
            modelBuilder.ApplyConfiguration(new ItemConfiguracao());
            modelBuilder.ApplyConfiguration(new ItemInventarioConfiguracao());
            modelBuilder.ApplyConfiguration(new JogadorConfiguracao());
            modelBuilder.ApplyConfiguration(new ListaMagiaConfiguracao());
            modelBuilder.ApplyConfiguration(new MagiaConfiguracao());
            modelBuilder.ApplyConfiguration(new MoedaConfiguracao());
            modelBuilder.ApplyConfiguration(new PericiaConfiguracao());
            modelBuilder.ApplyConfiguration(new RacaConfiguracao());
            //2. FIM
        }

    }
}
