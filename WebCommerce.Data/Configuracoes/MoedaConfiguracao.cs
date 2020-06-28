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
            builder.HasKey(c => new { c.CodFicha, c.CodJogador });
            //builder.HasKey("CodFicha","CodJogador");
            builder.Property(f => f.CodFicha).HasColumnName("CodFicha");
            builder.Property(f => f.CodJogador).HasColumnName("CodJogador");
            builder.Property(f => f.Cobre).HasColumnName("Cobre");
            builder.Property(f => f.Prata).HasColumnName("Prata");
            builder.Property(f => f.Electro).HasColumnName("Electro");
            builder.Property(f => f.Ouro).HasColumnName("Ouro");
            builder.Property(f => f.Platina).HasColumnName("Platina");

            builder
                .HasOne(d => d.Ficha)
                .WithMany()
                .HasForeignKey(f => f.CodFicha);

            builder
                .HasOne(d => d.Jogador)
                .WithMany()
                .HasForeignKey(f => f.CodJogador);
        }
    }
}