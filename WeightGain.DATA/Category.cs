using System.Collections.Generic;

namespace WeightGain.DATA
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }

        public string Kind { get; set; }  //name ve king aynı şey olabilir bunu birlikte konuşalım

        public string Description { get; set; }

        public byte Picture { get; set; }

        //Kategori ve Ürün ilişkişi bire çok
        public List<Product> Products { get; set; }

        public Category()
        {
            Products = new List<Product>();
        }
    }
}
