using System;

namespace WeightGain.DATA.Helpers
{
    public class ProductWithPortion
    {
        public int ProductId { get; set; }
        public int MealTimeId { get; set; }
        public string ProductName { get; set; }
        public string Scale { get; set; }
        public double Calory { get; set; }
        public double Size { get; set; }
        public MealTimeEnum MealTime { get; set; }
        public DateTime MealTimeDate { get; set; }
    }
}
