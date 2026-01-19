using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.EntityConfigurations
{
    public class UserDailyStatsConfigurations : IEntityTypeConfiguration<UserDailyStats>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<UserDailyStats> builder)
        {
            builder.HasKey(uds => uds.Id);
            builder.Property(uds => uds.UserID).IsRequired();
            builder.Property(uds => uds.Date).IsRequired();
            builder.Property(uds => uds.TotalBurntCalories).IsRequired();
            builder.Property(uds => uds.TotalCaloriesIntake).IsRequired();
            builder.Property(uds => uds.SummaryCalories).IsRequired();
            builder.Property(uds => uds.BodyFatPercentage).IsRequired();
            builder.Property(uds => uds.Weight).IsRequired();
            builder.Property(uds => uds.Id).ValueGeneratedOnAdd();
            builder.HasIndex(uds => new { uds.UserID, uds.Date }).IsUnique();
            builder.HasOne(uds => uds.User)
                   .WithMany(u => u.UserDailyStats)
                   .HasForeignKey(uds => uds.UserID)
                   .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
