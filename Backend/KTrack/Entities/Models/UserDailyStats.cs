using Entities.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class UserDailyStats : IIdentity
    {
        public UserDailyStats(string userID, DateTime date, int totalCaloriesIntake, int totalBurntCalories, int summaryCalories, int weight, double bodyFatPercentage)
        {
            Id = Guid.NewGuid().ToString();
            UserID = userID;
            Date = date;
            TotalCaloriesIntake = totalCaloriesIntake;
            TotalBurntCalories = totalBurntCalories;
            SummaryCalories = summaryCalories;
            Weight = weight;
            BodyFatPercentage = bodyFatPercentage;
        }

        public string Id { get; set; }
        public string UserID { get; set; }
        public DateTime Date { get; set; }
        public int TotalCaloriesIntake { get; set; }
        public int TotalBurntCalories { get; set; }
        public int SummaryCalories { get; set; }
        public int Weight { get; set; }
        public double BodyFatPercentage { get; set; }
        public virtual User User { get; set; }
    }
}
