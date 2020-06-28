using WebCommerce.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebCommerce.Dominio.Entidades;

namespace WebCommerce.Dados.Configuracoes
{
    public class ArmaduraConfiguracao :
        IEntityTypeConfiguration<Armadura>
    {
        public void Configure(EntityTypeBuilder<Armadura> builder)
        {
            builder.ToTable("Armadura", "RPG");
            builder.HasKey(c => new { c.CodArmadura });
            builder.Property(f => f.CodArmadura).HasColumnName("CodArmadura");
            builder.Property(f => f.NomeArmadura).HasColumnName("NomeArmadura")
                .IsRequired()
                .HasMaxLength(20);
            builder.Property(f => f.ClasseArmadura).HasColumnName("ClasseArmadura")
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(f => f.Forca).HasColumnName("Forca");
            builder.Property(f => f.Furtividade).HasColumnName("Furtividade")
                .IsRequired()
                .HasMaxLength(20);
        }
    }
}