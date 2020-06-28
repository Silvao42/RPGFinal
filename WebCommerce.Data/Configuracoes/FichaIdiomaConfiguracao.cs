using WebCommerce.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebCommerce.Dominio.Entidades;

namespace WebCommerce.Dados.Configuracoes
{
    public class FichaIdiomaConfiguracao :
        IEntityTypeConfiguration<FichaIdioma>
    {
        public void Configure(EntityTypeBuilder<FichaIdioma> builder)
        {
            builder.ToTable("FichaIdioma", "RPG");
            builder.HasKey(c => new { c.CodIdioma, c.CodFicha, c.CodJogador });
            //builder.HasKey("CodIdioma", "CodFicha", "CodJogador");
            builder.Property(f => f.CodIdioma).HasColumnName("CodIdioma");
            builder.Property(f => f.CodFicha).HasColumnName("CodFicha");
            builder.Property(f => f.CodJogador).HasColumnName("CodJogador");

            builder
                .HasOne(d => d.Ficha)
                .WithMany()
                .HasForeignKey(f => f.CodFicha);

            builder
                .HasOne(d => d.Jogador)
                .WithMany()
                .HasForeignKey(f => f.CodJogador);

            builder
                .HasOne(d => d.Idioma)
                .WithMany()
                .HasForeignKey(f => f.CodIdioma);

        }
    }
}