using WebCommerce.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebCommerce.Dominio.Entidades;

namespace WebCommerce.Dados.Configuracoes
{
    public class MoedaConfiguracao :
        IEntityTypeConfiguration<Moeda>
    {
        public void Configure(EntityTypeBuilder<Moeda> builder)
        {
            builder.ToTable("Moeda", "RPG");
            builder.HasKey(c => c.CodMoeda);
            builder.Property(f => f.CodMoeda).HasColumnName("CodMoeda");
            builder.Property(f => f.NomeMoeda).HasColumnName("NomeMoeda");
        }
    }
}