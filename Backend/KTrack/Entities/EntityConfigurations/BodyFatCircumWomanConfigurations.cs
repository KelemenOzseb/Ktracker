using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.EntityConfigurations
{
    public class BodyFatCircumWomanConfigurations : IEntityTypeConfiguration<BodyFatCircumWomen>
    {
        public void Configure(EntityTypeBuilder<BodyFatCircumWomen> builder)
        {
            builder.HasKey(bfcm => bfcm.Id);
            builder.Property(bfcm => bfcm.Id).ValueGeneratedOnAdd();
            builder.Property(bfcm => bfcm.WaistCircumference).IsRequired();
            builder.Property(bfcm => bfcm.NeckCircumference).IsRequired();
            builder.Property(bfcm => bfcm.BodyFatPercentage).IsRequired();
            builder.Property(bfcm => bfcm.HipCircumference).IsRequired();
            builder.Property(bfcm => bfcm.CreatedAt).IsRequired();
            builder.HasOne(bfcm => bfcm.User)
                   .WithOne(u => u.BodyFatCircumWomen)
                   .HasForeignKey<BodyFatCircumMen>(bfcm => bfcm.UserId)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
