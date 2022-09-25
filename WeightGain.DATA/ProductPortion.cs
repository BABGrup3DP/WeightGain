namespace WeightGain.DATA
{
    public class ProductPortion

    {
        public int ProductPortionId { get; set; }
        public double Portion { get; set; }
        public int MealTimeId { get; set; }
        public MealTime MealTime { get; set; }

        public ProductPortion()
        {
            Portion = 1;
        }
    }
}