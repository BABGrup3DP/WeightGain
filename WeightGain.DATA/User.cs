using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightGain.DATA
{
    public class User:Base
    {
        public RepastEnum Repast { get; set; }

        //User ve ürün ilişkisi
        public List<Product> Products { get; set; }

        public User()
        {
            Products = new List<Product>();
        }

        //antreman ve user ilişkisi
        public List<Exercise> Exercises { get; set; }

    }
}
