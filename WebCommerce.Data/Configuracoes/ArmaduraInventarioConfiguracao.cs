using WebCommerce.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebCommerce.Dominio.Entidades;

namespace WebCommerce.Dados.Configuracoes
{
    public class ArmaduraInventarioConfiguracao :
        IEntityTypeConfiguration<ArmaduraInventario>
    {
        public void Configure(EntityTypeBuilder<ArmaduraInventario> builder)
        {
            builder.ToTable("ArmaduraInventario", "RPG");
            builder.HasKey( c => new { c.CodArmadura, c.CodFicha, c.CodJogador });
            builder.Property(f => f.CodArmadura).HasColumnName("CodArmadura");
            builder.Property(f => f.CodFicha).HasColumnName("CodFicha");
            builder.Property(f => f.CodJogador).HasColumnName("CodJogador");

            builder
                .HasOne(d => d.Ficha)
                .WithMany()
                .HasForeignKey(f => f.CodFicha);

            builder
                .HasOne(d => d.Jogador)
                .WithMany()
                .HasForeignKey(f => f.CodJogador);

            builder
                .HasOne(d => d.Armadura)
                .WithMany()
                .HasForeignKey(f => f.CodArmadura);

        }
    }
}