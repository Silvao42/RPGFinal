using Aula09.Dominio;
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
            builder.ToTable("Arma");
            builder.HasKey("CodArma");
            builder.Property(f => f.CodArma).HasColumnName("CodArma");
            builder.Property(f => f.NomeArma).HasColumnName("NomeArma")
                .IsRequired()
                .HasMaxLength(20);
            builder.Property(f => f.Dano).HasColumnName("Dano")
                .IsRequired()
                .HasMaxLength(20);
            builder.Property(f => f.Propriedade).HasColumnName("Propriedade")
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}