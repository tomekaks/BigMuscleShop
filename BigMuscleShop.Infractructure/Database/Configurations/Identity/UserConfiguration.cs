using BigMuscleShop.Core.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMuscleShop.Infractructure.Database.Configurations.Identity
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
                new ApplicationUser()
                {
                    Id = "5330c916-053d-41e6-8a44-b9fe25cf27bf",
                    Email = "admin@email.com",
                    NormalizedEmail = "ADMIN@EMAIL.COM",
                    FirstName = "System",
                    LastName = "Admin",
                    UserName = "Admin",
                    Country= "System",
                    StreetName= "System",
                    HouseNumber= "0",
                    PostalCode= "System",
                    City= "System",
                    NormalizedUserName = "ADMIN",
                    PasswordHash = hasher.HashPassword(null, "Password!23"),
                    EmailConfirmed = true
                });

            builder.Property(q => q.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(q => q.LastName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(q => q.Country)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(q => q.StreetName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(q => q.HouseNumber)
                .IsRequired()
                .HasMaxLength(10);

            builder.Property(q => q.PostalCode)
                .IsRequired()
                .HasMaxLength(10);

            builder.Property(q => q.City)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
