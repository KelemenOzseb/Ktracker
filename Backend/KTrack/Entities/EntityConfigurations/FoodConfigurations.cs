using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.EntityConfigurations
{
    public class FoodConfigurations : IEntityTypeConfiguration<Food>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Food> builder)
        {
            builder.HasKey(f => f.Id);
            builder.Property(f => f.UserID).IsRequired();
            builder.Property(f => f.CreatedAt).IsRequired();
            builder.Property(f => f.Name).IsRequired().HasMaxLength(100);
            builder.Property(f => f.IsSaved).IsRequired();
            builder.Property(f => f.Calories).IsRequired();
            builder.HasOne(f => f.User)
                   .WithMany(u => u.Foods)
                   .HasForeignKey(f => f.UserID)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
    
}
