using BigMuscleShop.Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMuscleShop.Infractructure.Database.Configurations
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(q => q.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(q => q.Description)
                .IsRequired()
                .HasMaxLength(1000);

            builder.Property(q => q.Price)
                .IsRequired()
                .HasPrecision(18, 2);

            builder.Property(q => q.Taste)
                .HasMaxLength(50);
        }
    }
}
