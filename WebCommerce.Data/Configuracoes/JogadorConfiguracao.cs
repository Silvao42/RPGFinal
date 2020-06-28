using Aula09.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebCommerce.Dominio.Entidades;

namespace WebCommerce.Dados.Configuracoes
{
    public class JogadorConfiguracao :
        IEntityTypeConfiguration<Jogador>
    {
        public void Configure(EntityTypeBuilder<Jogador> builder)
        {
            builder.ToTable("Jogador");
            builder.HasKey("CodJogador");
            builder.Property(f => f.CodJogador).HasColumnName("CodJogador");
            builder.Property(f => f.NomeJogador).HasColumnName("NomeJogador")
                .IsRequired()
                .HasMaxLength(150);
            builder.Property(f => f.Email).HasColumnName("Email")
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(f => f.Login).HasColumnName("Login")
                .IsRequired()
                .HasMaxLength(200);
            builder.Property(f => f.Senha).HasColumnName("Senha")
                .IsRequired()
                .HasMaxLength(200);
            builder.Property(f => f.DataNascimento).HasColumnName("DataNascimento");
        }
    }
}