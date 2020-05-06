using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetsShopSolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetsShopSolution.Data.Configurations
{
    public class ImageConfiguration : IEntityTypeConfiguration<Image>

    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.ToTable("Images");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.ImagePath).HasMaxLength(200).IsRequired(true);
            builder.Property(x => x.Caption).HasMaxLength(200);

            builder.HasOne(x => x.Post).WithMany(x => x.Images).HasForeignKey(x => x.PostId);
        }
    }
}
