using WebCommerce.Dominio;
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
            builder.ToTable("Item_Inventario", "RPG");
            builder.HasKey(c => new { c.CodItem, c.CodFicha, c.CodJogador });
            //builder.HasKey("CodItem", "CodFicha", "CodJogador");
            builder.Property(f => f.CodItem).HasColumnName("CodItem");
            builder.Property(f => f.CodFicha).HasColumnName("CodFicha");
            builder.Property(f => f.CodJogador).HasColumnName("CodJogador");

            builder
                .HasOne(d => d.Item)
                .WithMany()
                .HasForeignKey(f => f.CodItem);

            builder
                .HasOne(d => d.Ficha)
                .WithMany()
                .HasForeignKey(f => new { f.CodFicha, f.CodJogador });

        }
    }
}