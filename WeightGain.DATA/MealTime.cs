using System;
using System.Collections.Generic;

namespace WeightGain.DATA
{
    public sealed class MealTime
    {
        public int MealTimeId { get; set; }
        public MealTimeEnum MealTimeType { get; set; }
        public string MealTimeDescription { get; set; }
        public DateTime MealTimeDate { get; set; }

        public List<Product> Products { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        public MealTime()
        {
            Products = new List<Product>();
        }
    }
}