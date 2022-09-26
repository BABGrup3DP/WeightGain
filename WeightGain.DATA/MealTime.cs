using System;
using System.Collections.Generic;

namespace WeightGain.DATA
{
    public class MealTime
    {
        public int MealTimeId { get; set; }
        public MealTimeEnum MealTimeType { get; set; }
        public string MealTimeDescription { get; set; }
        public DateTime MealTimeDate { get; set; }

        public virtual List<Product> Products { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }

    }
}