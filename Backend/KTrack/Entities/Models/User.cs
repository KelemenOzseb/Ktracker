using Entities.Helper;
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
    public class User : IIdentity
    {
        public User(string userName, string email, string password, DateTime birthDate, int height, int weight, bool isFemale)
        {
            Id = Guid.NewGuid().ToString();
            UserName = userName;
            Email = email;
            Password = password;
            this.age = DateTime.Now.Year - birthDate.Year;
            this.birthDate = birthDate;
            this.height = height;
            this.weight = weight;
            this.isFemale = isFemale;
        }

        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int age { get; set; }
        public DateTime birthDate { get; set; }
        public int height { get; set; }
        public int weight { get; set; }
        public bool isFemale { get; set; }
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
