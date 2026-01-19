using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Data
{
    public class KTrackerDbContext : IdentityDbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<UserDailyStats> UserDailyStats { get; set; }
        public DbSet<BodyFatCircumMen> BodyFatCircumMen { get; set; }
        public DbSet<BodyFatCircumWomen> BodyFatCircumWomen { get; set; }
        public DbSet<BodyFatFromSkinfolds> BodyFatFromSkinfolds { get; set; }
        public DbSet<Macronutrients> Macronutrients { get; set; }
        public KTrackerDbContext(DbContextOptions<KTrackerDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
