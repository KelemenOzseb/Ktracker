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
        public User(string username, string email, string password, DateTime birthDate, int height, int weight, bool isFemale)
        {
            Id = Guid.NewGuid().ToString();
            Username = username;
            Email = email;
            Password = password;
            this.Age = DateTime.Now.Year - birthDate.Year;
            this.BirthDate = birthDate;
            this.Height = height;
            this.Weight = weight;
            this.IsFemale = isFemale;
        }

        public string Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
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
