using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebCommerce.Dominio.Entidades;

namespace WebCommerce.Dados.Configuracoes
{
    public class ItemConfiguracao :
        IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.ToTable("Item");
            builder.HasKey("CodItem");
            builder.Property(f => f.CodItem).HasColumnName("CodItem");
            builder.Property(f => f.NomeItem).HasColumnName("NomeItem")
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}