using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightGain.DATA
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }

        public string kind { get; set; }  //name ve king aynı şey olabilir bunu birlikte konuşalım

        public string Description { get; set; }

        public byte Picture { get; set; }

        //Kategori ve Ürün ilişkişi bire çok
        public List<Product> Products { get; set; }

        public Category()
        {
            Products=new List<Product>();
        }
    }
}
