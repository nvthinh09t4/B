using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.EntityConfiguration
{
    public class FileCategoryConfiguration : IEntityTypeConfiguration<FileCategory>
    {
        public void Configure(EntityTypeBuilder<FileCategory> builder)
        {
            builder.HasKey(x => new { x.CategoryId, x.FileStorageId });
            builder.HasOne(f => f.File)
                .WithMany(c => c.Categories)
                .HasForeignKey(f => f.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(f => f.Category)
               .WithMany(c => c.Files)
               .HasForeignKey(f => f.FileStorageId)
               .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
