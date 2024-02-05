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
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("Categoria");

            builder.HasKey(c => c.IdCategoria);

            builder.Property(c=>c.IdCategoria)
                .HasColumnName("IDCategoria");

            builder.Property(c => c.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(c => c.IdUsuario)
                .HasColumnName("IdUsuario")
                .IsRequired();
            builder.Property(c => c.Tipo)
                .HasColumnName("Tipo")
                .IsRequired();

            builder.HasOne(c => c.Usuario)
                .WithMany(u => u.Categorias)
                .HasForeignKey(c => c.IdUsuario)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
