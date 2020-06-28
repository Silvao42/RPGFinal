using WebCommerce.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebCommerce.Dominio.Entidades;

namespace WebCommerce.Dados.Configuracoes
{
    public class AtributoConfiguracao :
        IEntityTypeConfiguration<Atributo>
    {
        public void Configure(EntityTypeBuilder<Atributo> builder)
        {
            builder.ToTable("Atributo", "RPG");
            builder.HasKey(c => new { c.CodFicha, c.CodJogador });
            builder.Property(f => f.CodFicha).HasColumnName("CodFicha");
            builder.Property(f => f.CodJogador).HasColumnName("CodJogador");
            builder.Property(f => f.Forca).HasColumnName("Forca");
            builder.Property(f => f.Destreza).HasColumnName("Destreza");
            builder.Property(f => f.Constituicao).HasColumnName("Constituicao");
            builder.Property(f => f.Inteligencia).HasColumnName("Inteligencia");
            builder.Property(f => f.Sabedoria).HasColumnName("Sabedoria");
            builder.Property(f => f.Carisma).HasColumnName("Carisma");

            builder
                .HasOne(d => d.Ficha)
                .WithMany()
                .HasForeignKey(f => f.CodFicha);

            builder
                .HasOne(d => d.Jogador)
                .WithMany()
                .HasForeignKey(f => f.CodJogador);
        }
    }
}