using WebCommerce.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebCommerce.Dominio.Entidades;

namespace WebCommerce.Dados.Configuracoes
{
    public class PericiaFichaConfiguracao :
        IEntityTypeConfiguration<PericiaFicha>
    {
        public void Configure(EntityTypeBuilder<PericiaFicha> builder)
        {
            builder.ToTable("Pericia_Ficha", "RPG");
            
            builder.HasKey(c => new { c.CodJogador, c.CodFicha });
            
            builder.Property(f => f.CodJogador).HasColumnName("CodJogador");
            builder.Property(f => f.CodFicha).HasColumnName("CodFicha");
            builder.Property(f => f.CodPericia).HasColumnName("CodPericia");
         

            builder
                .HasOne(d => d.Ficha)
                .WithMany()
                .HasForeignKey(f => new { f.CodFicha, f.CodJogador });


            builder
                .HasOne(d => d.Pericia)
                .WithMany()
                .HasForeignKey(f => f.CodPericia);
        }
    }
}