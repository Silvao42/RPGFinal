using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebCommerce.Dominio.Entidades;

namespace WebCommerce.Dados.Configuracoes
{
    public class FichaConfiguracao :
        IEntityTypeConfiguration<Ficha>
    {
        public void Configure(EntityTypeBuilder<Ficha> builder)
        {
            builder.ToTable("Jogador");
            builder.ToTable("Classe");
            builder.ToTable("Raca");
            builder.HasKey("CodFicha","CodJogador");
            builder.Property(f => f.CodFicha).HasColumnName("CodFicha");
            builder.Property(f => f.CodJogador).HasColumnName("CodJogador");
            builder.Property(f => f.NomePersonagem).HasColumnName("NomePersonagem")
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(f => f.Vida).HasColumnName("Vida");
            builder.Property(f => f.ClasseArmadura).HasColumnName("ClasseArmadura");
            builder.Property(f => f.Iniciativa).HasColumnName("Iniciativa");
            builder.Property(f => f.Deslocamento).HasColumnName("Deslocamento");
            builder.Property(f => f.CodClasse).HasColumnName("CodClasse");
            builder.Property(f => f.CodRaca).HasColumnName("CodRaca");

            builder
                .HasOne(d => d.Jogador)
                .WithMany()
                .HasForeignKey(f => f.CodJogador);

            builder
                .HasOne(d => d.Classe)
                .WithMany()
                .HasForeignKey(f => f.CodClasse);

            builder
                .HasOne(d => d.Raca)
                .WithMany()
                .HasForeignKey(f => f.CodRaca);
        }
    }
}