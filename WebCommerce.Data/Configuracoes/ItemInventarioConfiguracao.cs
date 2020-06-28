using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebCommerce.Dominio.Entidades;

namespace WebCommerce.Dados.Configuracoes
{
    public class ItemInventarioConfiguracao :
        IEntityTypeConfiguration<ItemInventario>
    {
        public void Configure(EntityTypeBuilder<ItemInventario> builder)
        {
            builder.ToTable("ItemInventario");
            builder.HasKey("CodItem", "CodFicha", "CodJogador");
            builder.Property(f => f.CodItem).HasColumnName("CodItem");
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
                .HasOne(d => d.Item)
                .WithMany()
                .HasForeignKey(f => f.CodItem);

        }
    }
}