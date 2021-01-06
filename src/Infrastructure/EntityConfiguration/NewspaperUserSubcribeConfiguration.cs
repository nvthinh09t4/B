using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.EntityConfiguration
{
    public class NewspaperUserSubcribeConfiguration : IEntityTypeConfiguration<NewspaperUserSubcribe>
    {
        public void Configure(EntityTypeBuilder<NewspaperUserSubcribe> builder)
        {
            builder.HasOne(x => x.User)
                .WithMany(x => x.NewspaperSubscribes)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
