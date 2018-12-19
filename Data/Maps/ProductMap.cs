using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductCatalog.Models;

namespace ProductCatalog.Data.Maps
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.HasKey(s => s.Id);
            builder.Property(s => s.CreateDate).IsRequired();
            builder.Property(s => s.Description).IsRequired().HasMaxLength(1024).HasColumnType("varchar(1024)");
            builder.Property(s => s.Image).IsRequired().HasMaxLength(1024).HasColumnType("varchar(1024)");
            builder.Property(s => s.LastUpdateDate).IsRequired();
            builder.Property(s => s.Price).IsRequired().HasColumnType("money");
            builder.Property(s => s.Quantity).IsRequired();
            builder.Property(s => s.Title).IsRequired().HasMaxLength(120).HasColumnType("varchar(120)");
            builder.HasOne(s => s.Category).WithMany(s => s.Products);
        }
    }
}