using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.EntityConfiguration
{
    public class NewspaperSubCategoryConfiguration : IEntityTypeConfiguration<NewspaperSubCategory>
    {
        public void Configure(EntityTypeBuilder<NewspaperSubCategory> builder)
        {
            builder.HasKey(x => new { x.CategoryId, x.NewspaperId });
            builder.HasOne(f => f.Newspaper)
                .WithMany(c => c.SubCategories)
                .HasForeignKey(f => f.NewspaperId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(f => f.Category)
               .WithMany(c => c.Newspapers)
               .HasForeignKey(f => f.CategoryId)
               .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
