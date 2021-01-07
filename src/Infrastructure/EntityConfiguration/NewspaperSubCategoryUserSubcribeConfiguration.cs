using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.EntityConfiguration
{
    public class NewspaperSubCategoryUserSubcribeConfiguration : IEntityTypeConfiguration<NewspaperSubCategoryUserSubcribe>
    {
        public void Configure(EntityTypeBuilder<NewspaperSubCategoryUserSubcribe> entity)
        {
            entity.HasOne(x => x.User)
                .WithMany(x => x.NewspaperSubCategorySubscribes)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(x => x.NewspaperSubCategory)
                .WithMany(y => y.UserSubcribes)
                .HasForeignKey(p => new { p.NewspaperSubCategory.NewspaperId, p.NewspaperSubCategory.CategoryId })
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
