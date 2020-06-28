using WebCommerce.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebCommerce.Dominio.Entidades;

namespace WebCommerce.Dados.Configuracoes
{
    public class ArmaConfiguracao :
        IEntityTypeConfiguration<Arma>
    {
        public void Configure(EntityTypeBuilder<Arma> builder)
        {
            builder.ToTable("Arma", "RPG");
            builder.HasKey(c => new {c.CodArma});
            builder.Property(f => f.CodArma).HasColumnName("CodArma")
                .IsRequired();


            builder.Property(f => f.NomeArma).HasColumnName("NomeArma")
                .HasMaxLength(20);
            
            builder.Property(f => f.Dano).HasColumnName("Dano")
                .HasMaxLength(20);
           
            builder.Property(f => f.Propriedade).HasColumnName("Propriedade")
                .HasMaxLength(100);
        }
    }
}