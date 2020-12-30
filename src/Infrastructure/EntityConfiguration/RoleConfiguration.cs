using Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.EntityConfiguration
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(new IdentityRole { 
                Id = Guid.NewGuid().ToString(),
                Name = "Administrator",
                NormalizedName = "administrator"
            });

            builder.HasData(new IdentityRole {
                Id = Guid.NewGuid().ToString(),
                Name = "NormalUser",
                NormalizedName = "normaluser"
            });
        }
    }
}
