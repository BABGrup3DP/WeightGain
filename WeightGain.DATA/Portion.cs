namespace WeightGain.DATA
{
    public class Portion
    {
        public int PortionId { get; set; }
        public double Size { get; set; }
        public int ProductId { get; set; }
        public int MealTimeId { get; set; }
        public virtual MealTime MealTime { get; set; }
        public virtual Product Product { get; set; }
    }
}
