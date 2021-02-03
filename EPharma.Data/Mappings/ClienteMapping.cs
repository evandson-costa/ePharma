﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EPharma.Business.Models;

namespace EPharma.Data.Mappings
{
    public class ClienteMapping : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Clientes");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasColumnType("varchar(80)")
                .HasColumnName("nome");

            builder.Property(p => p.Email)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(p => p.Telefone)
                .IsRequired()
                .HasMaxLength(11)
                .HasColumnName("telefone");

            builder.Property(p => p.DataCadastro)
                .IsRequired()
                .HasColumnName("data_cadastro"); ;

            builder.Property(p => p.CpfCnpj)
                .IsRequired()
                .HasMaxLength(14)
                .HasColumnName("cpf_cnpj");

            builder.Property(p => p.RG)
                .HasMaxLength(14)
                .HasColumnName("rg");

            builder.Property(p => p.DataNascimento)
                .HasColumnName("data_nascimento");

            builder.Property(p => p.Email)
                .HasColumnName("email");

            builder.Property(p => p.Deleted)
                .HasColumnName("deleted");

            builder.Property(p => p.DataAlteracao)
                .HasColumnName("data_alteracao");
        }
    }
}