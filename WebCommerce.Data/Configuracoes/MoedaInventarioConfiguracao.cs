using WebCommerce.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebCommerce.Dominio.Entidades;

namespace WebCommerce.Dados.Configuracoes
{
    public class MoedaInventarioConfiguracao :
        IEntityTypeConfiguration<MoedaInventario>
    {
        public void Configure(EntityTypeBuilder<MoedaInventario> builder)
        {
            builder.ToTable("Moeda_Inventario", "RPG");
            builder.HasKey(c => new { c.CodFicha, c.CodJogador, c.CodMoeda });
            builder.Property(f => f.CodFicha).HasColumnName("CodFicha");
            builder.Property(f => f.CodJogador).HasColumnName("CodJogador");
            builder.Property(f => f.CodMoeda).HasColumnName("CodMoeda");
            builder.Property(f => f.Qtd).HasColumnName("Qtd");

            builder
                .HasOne(d => d.Ficha)
                .WithMany()
                .HasForeignKey(f => new { f.CodFicha, f.CodJogador});

            builder
                .HasOne(d => d.Moeda)
                .WithMany()
                .HasForeignKey(f =>  f.CodMoeda);
        }
    }
}