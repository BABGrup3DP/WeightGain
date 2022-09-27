using System;

namespace WeightGain.DATA
{
    public class Exercise
    {
        public int ExerciseId { get; set; }
        public ExerciseEnum ExerciseType { get; set; }
        public int Duration { get; set; }
        public DateTime ExerciseDate { get; set; }
        public double TotalCal { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

    }
}
