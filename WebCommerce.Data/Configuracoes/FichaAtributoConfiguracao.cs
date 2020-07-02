using WebCommerce.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebCommerce.Dominio.Entidades;

namespace WebCommerce.Dados.Configuracoes
{
    public class FichaAtributoConfiguracao :
        IEntityTypeConfiguration<FichaAtributo>
    {
        public void Configure(EntityTypeBuilder<FichaAtributo> builder)
        {
            builder.ToTable("Ficha_Atributo", "RPG");
            builder.HasKey(c => new { c.CodFicha, c.CodJogador, c.CodAtributo });
            builder.Property(f => f.CodFicha).HasColumnName("CodFicha");
            builder.Property(f => f.CodJogador).HasColumnName("CodJogador");
            builder.Property(f => f.CodAtributo).HasColumnName("CodAtributo");

            builder
                .HasOne(d => d.Ficha)
                .WithMany()
                .HasForeignKey(f => new { f.CodFicha , f.CodJogador });

            builder
               .HasOne(d => d.Atributo)
               .WithMany()
               .HasForeignKey(f => f.CodAtributo );

        }
    }
}