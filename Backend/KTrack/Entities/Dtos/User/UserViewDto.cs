using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos.User
{
    public class UserViewDto
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public bool IsFemale { get; set; }
        public BodyFatCalculationMethod? PreferredBodyFatMethod { get; set; }
        public CalorieCalculationMethod? PreferredCalorieMethod { get; set; }
    }
}
