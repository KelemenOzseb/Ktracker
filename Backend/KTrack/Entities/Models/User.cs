using Entities.Helper;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public enum BodyFatCalculationMethod
    {
        UsNavy = 1,
        DurninAndWomersley = 2,
    }
    public enum CalorieCalculationMethod
    {
        MullerWeight = 1,
        MullerFFM = 2,
        KatchMcArdle = 3
    }
    public class User : IdentityUser, IIdentity
    {
        public DateTime BirthDate { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public bool IsFemale { get; set; }
        public BodyFatCalculationMethod? PreferredBodyFatMethod { get; set; }
        public CalorieCalculationMethod? PreferredCalorieMethod { get; set; }

        public virtual ICollection<Activity> Activities { get; set; }
        public virtual ICollection<Food> Foods { get; set; }
        public virtual ICollection<UserDailyStats> UserDailyStats { get; set; }
        public virtual BodyFatCircumMen? BodyFatCircumMen { get; set; }
        public virtual BodyFatCircumWomen? BodyFatCircumWomen { get; set; }
        public virtual BodyFatFromSkinfolds? BodyFatFromSkinfolds { get; set; }
    }
}
