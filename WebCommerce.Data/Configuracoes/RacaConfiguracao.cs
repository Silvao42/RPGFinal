using WebCommerce.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebCommerce.Dados.Configuracoes
{
    public class RacaConfiguracao :
        IEntityTypeConfiguration<Raca>
    {
        public void Configure(EntityTypeBuilder<Raca> builder)
        {
            builder.ToTable("Raca", "RPG");
            
            builder.HasKey(c => new { c.CodRaca });
            
            builder.HasKey("CodRaca");
            builder.Property(f => f.CodRaca).HasColumnName("CodRaca");
            builder.Property(f => f.NomeRaca).HasColumnName("NomeRaca")
                .IsRequired()
                .HasMaxLength(20);
            builder.Property(f => f.Descricao).HasColumnName("Descricao")
                .IsRequired()
                .HasMaxLength(500);
            builder.Property(f => f.VisaoEscuro).HasColumnName("VisaoEscuro")
                .IsRequired()
                .HasMaxLength(1);
        }
    }
}