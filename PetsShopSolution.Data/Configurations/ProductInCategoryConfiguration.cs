using PetsShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetsShopSolution.Data.Configurations
{
    public class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.HasKey(t => new { t.CategoryId, t.ProductId });
            builder.ToTable("ProductInCategory");

            //1 product thuoc nhieu categories, lien ket bang khoa ngoai productID
            builder.HasOne(p => p.Product)
                .WithMany(pc => pc.ProductInCategories)
                .HasForeignKey(pc => pc.ProductId);

            //1 category chua nhieu products, lien ket bang khoa ngoai CategoryID
            builder.HasOne(p => p.Category)
               .WithMany(pc => pc.ProductInCategories)
               .HasForeignKey(pc => pc.CategoryId);
        }
    }
}
