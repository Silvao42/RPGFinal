using WebCommerce.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebCommerce.Dominio.Entidades;

namespace WebCommerce.Dados.Configuracoes
{
    public class PericiaConfiguracao :
        IEntityTypeConfiguration<Pericia>
    {
        public void Configure(EntityTypeBuilder<Pericia> builder)
        {
            builder.ToTable("Pericia", "RPG");
            
            builder.HasKey(c => c.CodPericia);
            
            builder.Property(f => f.CodPericia).HasColumnName("CodPericia");
            builder.Property(f => f.NomePericia).HasColumnName("NomePericia");
        }
    }
}