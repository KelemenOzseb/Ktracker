using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.EntityConfigurations
{
    public class ActivityConfigurations : IEntityTypeConfiguration<Activity>
    {
        public void Configure(EntityTypeBuilder<Activity> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.UserID).IsRequired();
            builder.Property(a => a.CreatedAt).IsRequired();
            builder.Property(a => a.Name).IsRequired().HasMaxLength(100);
            builder.Property(a => a.IsSaved).IsRequired();
            builder.Property(a => a.Calories).IsRequired();

            builder.HasOne(a => a.User)
                   .WithMany(u => u.Activities)
                   .HasForeignKey(a => a.UserID)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
