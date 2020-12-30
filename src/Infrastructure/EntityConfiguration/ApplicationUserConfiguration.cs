using Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.EntityConfiguration
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            IPasswordHasher<ApplicationUser> passwordHasher = new PasswordHasher<ApplicationUser>();
            var adminUser = new ApplicationUser {
                Id = Guid.NewGuid().ToString(),
                UserName = "nvthinh09t4@gmail.com",
                NormalizedUserName = "nvthinh09t4@gmail.com",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                Email = "nvthinh09t4@gmail.com",
                NormalizedEmail = "nvthinh09t4@gmail.com"
            };
            adminUser.PasswordHash = passwordHasher.HashPassword(adminUser, "Protoss123@");
            builder.HasData(adminUser);
        }
    }
}
