using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebCommerce.Dominio.Entidades;

namespace WebCommerce.Dados.Configuracoes
{
    public class ArmaInventarioConfiguracao :
        IEntityTypeConfiguration<ArmaInventario>
    {
        public void Configure(EntityTypeBuilder<ArmaInventario> builder)
        {
            builder.ToTable("ArmaInventario");
            builder.HasKey("CodArma", "CodFicha", "CodJogador");
            builder.Property(f => f.CodArma).HasColumnName("CodArma");
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
                .HasOne(d => d.Arma)
                .WithMany()
                .HasForeignKey(f => f.CodArma);

        }
    }
}