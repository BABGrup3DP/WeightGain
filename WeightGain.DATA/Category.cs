using System.Collections.Generic;

namespace WeightGain.DATA
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //Kategori ve Ürün ilişkişi bire çok
        public List<Product> Products { get; set; }
    }
}
