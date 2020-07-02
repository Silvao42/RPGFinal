using WebCommerce.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebCommerce.Dominio.Entidades;

namespace WebCommerce.Dados.Configuracoes
{
    public class ListaMagiaConfiguracao :
        IEntityTypeConfiguration<ListaMagia>
    {
        public void Configure(EntityTypeBuilder<ListaMagia> builder)
        {
            builder.ToTable("Lista_Magia", "RPG");
            builder.HasKey(c => new { c.CodMagia, c.CodFicha, c.CodJogador });
            //builder.HasKey("CodMagia","CodFicha","CodJogador");
            builder.Property(f => f.CodMagia).HasColumnName("CodMagia");
            builder.Property(f => f.CodFicha).HasColumnName("CodFicha");
            builder.Property(f => f.CodJogador).HasColumnName("CodJogador");

            builder
                .HasOne(d => d.Ficha)
                .WithMany()
                .HasForeignKey(f => new {f.CodFicha, f.CodJogador});

            builder
                .HasOne(d => d.Magia)
                .WithMany()
                .HasForeignKey(f => f.CodMagia);

        }
    }
}