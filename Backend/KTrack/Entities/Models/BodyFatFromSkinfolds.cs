using Entities.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class BodyFatFromSkinfolds : IIdentity
    {
        public BodyFatFromSkinfolds(string userId, double bodyFatPercentage, double bicepsSkinfold, double tricepsSkinfold, double scapularSkinfold, double hipSkinfold)
        {
            Id = Guid.NewGuid().ToString();
            UserId = userId;
            CreatedAt = DateTime.Now;
            BodyFatPercentage = bodyFatPercentage;
            BicepsSkinfold = bicepsSkinfold;
            TricepsSkinfold = tricepsSkinfold;
            ScapularSkinfold = scapularSkinfold;
            HipSkinfold = hipSkinfold;
        }

        public string Id { get; set; }
        public string UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public double BodyFatPercentage { get; set; }
        public double BicepsSkinfold { get; set; }
        public double TricepsSkinfold { get; set; }
        public double ScapularSkinfold { get; set; }
        public double HipSkinfold { get; set; }
        public virtual User User { get; set; }
    }
}
