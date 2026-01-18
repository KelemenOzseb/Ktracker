using Entities.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class BodyFatCircumWomen : IIdentity
    {
        public BodyFatCircumWomen(string userID, DateTime createdAt, double bodyFatPercentage, double waistCircumference, double hipCircumference, double neckCircumference)
        {
            Id = Guid.NewGuid().ToString();
            UserID = userID;
            CreatedAt = createdAt;
            BodyFatPercentage = bodyFatPercentage;
            WaistCircumference = waistCircumference;
            HipCircumference = hipCircumference;
            NeckCircumference = neckCircumference;
        }

        public string Id { get; set; }
        public string UserID { get; set; }
        public DateTime CreatedAt { get; set; }
        public double BodyFatPercentage { get; set; }
        public double WaistCircumference { get; set; }
        public double HipCircumference { get; set; }
        public double NeckCircumference { get; set; }
        public virtual User User { get; set; }
    }
}
