using System.Collections.Generic;

namespace WeightGain.DATA
{
    public class User : BaseModel
    {
        public MealTimeEnum Repast { get; set; }

        //User ve ürün ilişkisi
        public List<Product> Products { get; set; }

        public User()
        {
            Products = new List<Product>();
        }

        // antreman ve user ilişkisi
        public List<Exercise> Exercises { get; set; }

        public List<MealTime> MealTimes { get; set; }

    }
}
