using System;

namespace WeightGain.DATA
{
    public class Exercise
    {
        public int ExerciseID { get; set; }
        public ExerciseEnum ExerciseType { get; set; }
        public byte Duration { get; set; }
        public DateTime ExerciseDate { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

    }
}
