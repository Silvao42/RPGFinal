using WebCommerce.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebCommerce.Dominio.Entidades;

namespace WebCommerce.Dados.Configuracoes
{
    public class IdiomaConfiguracao :
        IEntityTypeConfiguration<Idioma>
    {
        public void Configure(EntityTypeBuilder<Idioma> builder)
        {
            builder.ToTable("Idioma", "RPG");
            builder.HasKey(c => c.CodIdioma);
            //builder.HasKey("CodIdioma");
            builder.Property(f => f.CodIdioma).HasColumnName("CodIdioma");
            builder.Property(f => f.NomeIdioma).HasColumnName("NomeIdioma")
                .IsRequired()
                .HasMaxLength(20);
        }
    }
}