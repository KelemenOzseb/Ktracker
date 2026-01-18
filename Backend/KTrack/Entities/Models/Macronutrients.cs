using Entities.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class Macronutrients : IIdentity
    {
        public Macronutrients(string foodId, int carbohydrate, int protein, int fat)
        {
            Id = Guid.NewGuid().ToString();
            FoodId = foodId;
            Carbohydrate = carbohydrate;
            Protein = protein;
            Fat = fat;
        }

        public string Id { get; set; }
        public string FoodId { get; set; }
        public int Carbohydrate { get; set; }
        public int Protein { get; set; }
        public int Fat { get; set; }
        public virtual Food Food { get; set; }
    }
}
