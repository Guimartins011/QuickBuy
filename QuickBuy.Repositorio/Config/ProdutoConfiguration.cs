using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text;
using QuickBuy.Dominio.Entidades;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QuickBuy.Repositorio.Config
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);

            builder
                .Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(p => p.Descricao)
                .IsRequired()
                .HasMaxLength(400);
            builder
                .Property(p => p.Preco)
                .IsRequired();
        }
    }
}
