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
            builder.HasKey(c =>  c.CodAtributo);
            builder.Property(f => f.CodAtributo).HasColumnName("CodAtributo");
            builder.Property(f => f.NomeAtributo).HasColumnName("NomeAtributo");
        }
    }
}