using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.EntityConfiguration
{
    public class FileStorageConfiguration : IEntityTypeConfiguration<FileStorage>
    {
        public void Configure(EntityTypeBuilder<FileStorage> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FileName)
                .HasMaxLength(256)
                .IsRequired();
        }
    }
}
