using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos.User
{
    public class UserCaloriesDto
    {
        public int TotalCaloriesIntake { get; set; }
        public int TotalBurntCalories { get; set; }
        public int SummaryCalories { get; set; }
        public int CalorieNeeded { get; set; }
    }
}
