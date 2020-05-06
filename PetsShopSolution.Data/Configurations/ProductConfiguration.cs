using PetsShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetsShopSolution.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.OriginalPrice).IsRequired();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);

            builder.Property(x => x.SeoAlias).IsRequired().HasMaxLength(200);

            builder.Property( x => x.Details).HasMaxLength(500);
            builder.Property(x => x.Stars).HasDefaultValue(0);

            builder.Property(x => x.Stock).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.ViewCount).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.Heart).IsRequired().HasDefaultValue(0);
            builder.Property(x => x.DateCreated);

        }
    }
}
