using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaConta.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaConta.Data.Mappings
{
    public class ContaMap : IEntityTypeConfiguration<Conta>
    {
        public void Configure(EntityTypeBuilder<Conta> builder)
        {
            builder.ToTable("Conta");

            builder.HasKey(c => c.IdConta);

            builder.Property(c => c.IdConta)
                .HasColumnName("IdConta");

            builder.Property(c => c.Nome)
                .HasColumnName("nome")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.Descricao)
                .HasColumnName("Descricao")
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(c => c.Data)
                .HasColumnName("Data")
                .HasColumnType("date")
                .IsRequired();

            builder.Property(c => c.Valor)
                .HasColumnName("Valor")
                .HasColumnType("decimal(18,2)")
                .IsRequired();
            builder.Property(c => c.IdCategoria)
               .HasColumnName("IdCategoria")
               .IsRequired();
            builder.Property(c => c.IdUsuario)
               .HasColumnName("IdUsuario")
               .IsRequired();

            builder.HasOne(c => c.Categoria)
                .WithMany(c => c.Contas)
                .HasForeignKey(c => c.IdCategoria)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(c=>c.Usuario)
                .WithMany(u=>u.Contas)
                .HasForeignKey(c=>c.IdUsuario)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
