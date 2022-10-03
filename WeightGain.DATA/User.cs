using System;
using System.Collections.Generic;

namespace WeightGain.DATA
{
    public class User : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public DateTime BirthDate { get; set; }
        public byte Age => (byte)(DateTime.Now.Year - BirthDate.Year);
        public decimal Weight { get; set; }
        public decimal Height { get; set; }
        public double Bmi => (double)Math.Round(Weight / (Height / 100 * (Height / 100)), 2);

        //public virtual List<Product> Products { get; set; }
        public virtual List<Exercise> Exercises { get; set; }
        public virtual List<MealTime> MealTimes { get; set; }

    }
}
