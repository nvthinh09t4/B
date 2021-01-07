using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.EntityConfiguration
{
    public class NewspaperCategoryUserSubcribeConfiguration : IEntityTypeConfiguration<NewspaperCategoryUserSubcribe>
    {
        public void Configure(EntityTypeBuilder<NewspaperCategoryUserSubcribe> builder)
        {
            builder.HasOne(x => x.User)
                .WithMany(x => x.NewspaperCategoryUserSubcribes)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
