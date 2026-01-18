using Entities.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class Food : IIdentity
    {
        public Food(string userID, string name, int calories, bool isSaved)
        {
            Id = Guid.NewGuid().ToString();
            UserID = userID;
            Name = name;
            Calories = calories;
            CreatedAt = DateTime.Now;
            IsSaved = isSaved;
        }

        public string Id { get; set; }
        public string UserID { get; set; }
        public string Name { get; set; }
        public int Calories { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsSaved { get; set; }
        public virtual User User { get; set; }
        public virtual Macronutrients Macronutrients { get; set; }
    }
}
