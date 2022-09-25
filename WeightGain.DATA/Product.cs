using System.Collections.Generic;

namespace WeightGain.DATA
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Scale { get; set; }
        public decimal Calory { get; set; }
        public byte[] Picture { get; set; }
        

        //Her ürünün kesinlikle bir kategorisi var.

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }


        //Bir ürünü birden fazla kullanıcı seçebilir
        //public List<User> Users { get; set; }

        public virtual List<MealTime> MealTimes { get; set; }

    }
}
