using System.Collections.Generic;

namespace WeightGain.DATA
{
    public class MealTime
    {
        public int MealTimeId { get; set; }
        public MealTimeEnum MealTimeType { get; set; }
        public string MealTimeDescription { get; set; }

        public List<Product> Products { get; set; }
        public List<User> Users { get; set; }
    }
}