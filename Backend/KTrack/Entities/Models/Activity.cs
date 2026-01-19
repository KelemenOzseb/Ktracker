using Entities.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class Activity : IIdentity
    {
        public Activity(string userID, string name, bool isSaved, int calories)
        {
            Id = Guid.NewGuid().ToString();
            UserID = userID;
            CreatedAt = DateTime.Now;
            Name = name;
            IsSaved = isSaved;
            Calories = calories;
        }

        public string Id { get; set; }
        public string UserID { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Name { get; set; }
        public bool IsSaved { get; set; }
        public int Calories { get; set; }
        public virtual User User { get; set; }
    }
}
