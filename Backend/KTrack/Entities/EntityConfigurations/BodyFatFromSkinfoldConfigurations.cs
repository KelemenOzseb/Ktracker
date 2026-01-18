using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.EntityConfigurations
{
    public class BodyFatFromSkinfoldConfigurations : IEntityTypeConfiguration<BodyFatFromSkinfolds>
    {
        public void Configure(EntityTypeBuilder<BodyFatFromSkinfolds> builder)
        {
            builder.HasKey(bffs => bffs.Id);
            builder.Property(bffs => bffs.Id).ValueGeneratedOnAdd();
            builder.Property(bffs => bffs.TricepsSkinfold).IsRequired();
            builder.Property(bffs => bffs.ScapularSkinfold).IsRequired();
            builder.Property(bffs => bffs.BodyFatPercentage).IsRequired();
            builder.Property(bffs => bffs.BicepsSkinfold).IsRequired();
            builder.Property(bffs => bffs.HipSkinfold).IsRequired();
            builder.Property(bffs => bffs.CreatedAt).IsRequired();
            builder.HasOne(bffs => bffs.User)
                   .WithOne(u => u.BodyFatFromSkinfolds)
                   .HasForeignKey<BodyFatFromSkinfolds>(bffs => bffs.UserId)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
