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
        public byte Bmi => (byte)(Weight / (Height * Height)); // Body mass index => vücut kitle endeksi

        //User ve ürün ilişkisi
        public List<Product> Products { get; set; }

        public User()
        {
            Products = new List<Product>();
            Exercises = new List<Exercise>();
            MealTimes = new List<MealTime>();
            UserType = UserTypeEnum.User;
        }

        // antreman ve user ilişkisi
        public List<Exercise> Exercises { get; set; }

        public List<MealTime> MealTimes { get; set; }

    }
}
