using Aula09.Dominio;
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
            builder.ToTable("ListaMagia");
            builder.HasKey("CodMagia","CodFicha","CodJogador");
            builder.Property(f => f.CodMagia).HasColumnName("CodMagia");
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
                .HasOne(d => d.Magia)
                .WithMany()
                .HasForeignKey(f => f.CodMagia);

        }
    }
}