using System.Collections.Generic;

namespace WeightGain.DATA
{
    public class Exercise
    {
        public int ExerciseID { get; set; }
        public byte Duration { get; set; }

        // Birden fazla kullanıcı antreman seçebilir

        public List<User> Users { get; set; }

    }
}
