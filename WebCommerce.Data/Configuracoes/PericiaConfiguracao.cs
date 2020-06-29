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
            
            builder.HasKey(c => new { c.CodJogador, c.CodFicha });
            
            //builder.HasKey("CodJogador","CodFicha");
            builder.Property(f => f.CodJogador).HasColumnName("CodJogador");
            builder.Property(f => f.CodFicha).HasColumnName("CodFicha");
            builder.Property(f => f.Acrobacia).HasColumnName("Acrobacia")
                .IsRequired()
                .HasMaxLength(1);
            builder.Property(f => f.AdestrarAnimais).HasColumnName("AdestrarAnimais")
                .IsRequired()
                .HasMaxLength(1);
            builder.Property(f => f.Arcanismo).HasColumnName("Arcanismo")
                .IsRequired()
                .HasMaxLength(1);
            builder.Property(f => f.Atletismo).HasColumnName("Atletismo")
                .IsRequired()
                .HasMaxLength(1);
            builder.Property(f => f.Atuacao).HasColumnName("Atuacao")
                .IsRequired()
                .HasMaxLength(1);
            builder.Property(f => f.Enganacao).HasColumnName("Enganacao")
                .IsRequired()
                .HasMaxLength(1);
            builder.Property(f => f.Furtividade).HasColumnName("Furtividade")
                .IsRequired()
                .HasMaxLength(1);
            builder.Property(f => f.Historia).HasColumnName("Historia")
                .IsRequired()
                .HasMaxLength(1);
            builder.Property(f => f.Intimidacao).HasColumnName("Intimidacao")
                .IsRequired()
                .HasMaxLength(1);
            builder.Property(f => f.Intuicao).HasColumnName("Intuicao")
                .IsRequired()
                .HasMaxLength(1);
            builder.Property(f => f.Investigacao).HasColumnName("Investigacao")
                .IsRequired()
                .HasMaxLength(1);
            builder.Property(f => f.Medicina).HasColumnName("Medicina")
                .IsRequired()
                .HasMaxLength(1);
            builder.Property(f => f.Natureza).HasColumnName("Natureza")
                .IsRequired()
                .HasMaxLength(1);
            builder.Property(f => f.Percepcao).HasColumnName("Percepcao")
                .IsRequired()
                .HasMaxLength(1);
            builder.Property(f => f.Persuasao).HasColumnName("Persuasao")
                .IsRequired()
                .HasMaxLength(1);
            builder.Property(f => f.Prestigitacao).HasColumnName("Prestigitacao")
                .IsRequired()
                .HasMaxLength(1);
            builder.Property(f => f.Religiao).HasColumnName("Religiao")
                .IsRequired()
                .HasMaxLength(1);
            builder.Property(f => f.Sobrevivencia).HasColumnName("Sobrevivencia")
                .IsRequired()
                .HasMaxLength(1);

            builder
                .HasOne(d => d.Ficha)
                .WithMany()
                .HasForeignKey(f => new { f.CodFicha, f.CodJogador });
        }
    }
}