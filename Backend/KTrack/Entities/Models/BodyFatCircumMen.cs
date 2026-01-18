using Entities.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class BodyFatCircumMen : IIdentity
    {
        public BodyFatCircumMen(string userId, double bodyFatPercentage, double waistCircumference, double neckCircumference)
        {
            Id = Guid.NewGuid().ToString();
            UserId = userId;
            CreatedAt = DateTime.Now;
            BodyFatPercentage = bodyFatPercentage;
            WaistCircumference = waistCircumference;
            NeckCircumference = neckCircumference;
        }

        public string Id { get; set; }
        public string UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public double BodyFatPercentage { get; set; }
        public double WaistCircumference { get; set; }
        public double NeckCircumference { get; set; }
        public virtual User User { get; set; }
    }
}
