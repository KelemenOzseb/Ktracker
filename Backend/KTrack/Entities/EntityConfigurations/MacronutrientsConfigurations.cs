using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.EntityConfigurations
{
    public class MacronutrientsConfigurations : IEntityTypeConfiguration<Macronutrients>
    {
        public void Configure(EntityTypeBuilder<Macronutrients> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Protein).IsRequired();
            builder.Property(m => m.Carbohydrate).IsRequired();
            builder.Property(m => m.Fat).IsRequired();
            builder.Property(m => m.FoodId).IsRequired();
            builder.HasOne(m => m.Food)
                   .WithOne(u => u.Macronutrients)
                   .HasForeignKey<Macronutrients>(m => m.FoodId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
