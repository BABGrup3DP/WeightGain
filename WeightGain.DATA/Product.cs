using System.Collections.Generic;

namespace WeightGain.DATA
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }

        public string Kind { get; set; }

        public decimal Calory { get; set; }

        //Her ürünün kesinlikle bir kategorisi var.

        public int CategoryID { get; set; }
        public Category Category { get; set; }


        //Bir ürünü birden fazla kullanıcı seçebilir
        public List<User> Users { get; set; }


    }
}
