using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductCatalog.Models;

namespace ProductCatalog.Data.Maps
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Title).IsRequired().HasMaxLength(120).HasColumnType("varchar(120)");
        }
    }
}