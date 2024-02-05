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
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("USUARIO");

            builder.HasKey(u => u.IdUsuario);

            builder.Property(u=>u.IdUsuario)
                .IsRequired()
                .HasColumnName("IDUSUARIO");

            builder.Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnName("Nome");

            builder.Property(u => u.Email)
                .IsRequired()
                .HasColumnName("Email")
                .HasMaxLength(50);

            builder.HasIndex(u => u.Email)
                .IsUnique();

            builder.Property(u=>u.Senha)
                .HasColumnName("Senha")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(u => u.DataCriacao)
                .HasColumnName("DataCriacao")
                .IsRequired();

            builder.Property(u=>u.Ativo)
                .HasColumnName("Ativo")
                .IsRequired()
                .HasColumnType("int");

        }
    }
}
