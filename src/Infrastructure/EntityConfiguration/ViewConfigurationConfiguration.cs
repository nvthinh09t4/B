using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.EntityConfiguration
{
    public class ViewConfigurationConfiguration : IEntityTypeConfiguration<ViewConfiguration>
    {
        public void Configure(EntityTypeBuilder<ViewConfiguration> builder)
        {
            builder.HasKey(x => x.Id);
            //builder.HasMany(x => x.Categories).WithOne(x => x.)
        }
    }
}
