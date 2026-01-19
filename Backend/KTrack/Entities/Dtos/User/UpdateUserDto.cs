using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos.User
{
    public class UpdateUserDto
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public bool IsFemale { get; set; }
        public BodyFatCalculationMethod? PreferredBodyFatMethod { get; set; }
        public CalorieCalculationMethod? PreferredCalorieMethod { get; set; }
    }
}
