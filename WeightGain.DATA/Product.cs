using System.Collections.Generic;

namespace WeightGain.DATA
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Scale { get; set; }
        public double Calory { get; set; }
        public byte[] Picture { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<MealTime> MealTimes { get; set; }
        public virtual List<Portion> ProductPortions { get; set; }
    }
}
