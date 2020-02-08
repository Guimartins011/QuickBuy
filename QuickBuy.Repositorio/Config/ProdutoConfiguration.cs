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
            throw new NotImplementedException();
        }
    }
}
