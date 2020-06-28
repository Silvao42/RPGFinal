using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebCommerce.Dominio.Entidades;

namespace WebCommerce.Dados.Configuracoes
{
    public class MagiaConfiguracao :
        IEntityTypeConfiguration<Magia>
    {
        public void Configure(EntityTypeBuilder<Magia> builder)
        {
            builder.ToTable("Magia");
            builder.HasKey("CodMagia");
            builder.Property(f => f.CodMagia).HasColumnName("CodMagia");
            builder.Property(f => f.NomeMagia).HasColumnName("NomeMagia")
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(f => f.AlcaceMagia).HasColumnName("AlcaceMagia");
            builder.Property(f => f.DuracaoMagia).HasColumnName("DuracaoMagia")
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(f => f.DescricaoMagia).HasColumnName("DescricaoMagia")
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(f => f.Conjuracao).HasColumnName("Conjuracao")
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(f => f.CicloMagia).HasColumnName("CicloMagia");
            builder.Property(f => f.TipoMagia).HasColumnName("TipoMagia")
                .IsRequired()
                .HasMaxLength(20);
        }
    }
}