using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightGain.DATA
{
    public class Exercise
    {
        public int ExerciseID { get; set; }
        public byte Duration { get; set; }

        //Birden fazla kullanıcı antreman seçebilir

        public List<User> Users { get; set; }
    }
}
