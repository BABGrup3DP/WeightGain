namespace WeightGain.DATA.Helpers
{
    public class ProductWithCategory
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Scale { get; set; }
        public double Calory { get; set; }
        public byte[] Picture { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}