using WebCommerce.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebCommerce.Dominio.Entidades;

namespace WebCommerce.Dados.Configuracoes
{
    public class ClasseConfiguracao :
        IEntityTypeConfiguration<Classe>
    {
        public void Configure(EntityTypeBuilder<Classe> builder)
        {
            builder.ToTable("Classe", "RPG");
            builder.HasKey(c => new { c.CodClasse });
            builder.Property(f => f.CodClasse).HasColumnName("CodClasse");
            builder.Property(f => f.NomeClasse).HasColumnName("NomeClasse")
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(f => f.DescricaoClasse).HasColumnName("DescricaoClasse")
                .IsRequired()
                .HasMaxLength(500);
            builder.Property(f => f.DadoVida).HasColumnName("DadoVida");
            builder.Property(f => f.AtributoUm).HasColumnName("AtributoUm")
                .IsRequired()
                .HasMaxLength(10);
            builder.Property(f => f.AtributoDois).HasColumnName("AtributoDois")
                .IsRequired()
                .HasMaxLength(10);
        }
    }
}