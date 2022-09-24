using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using WeightGain.DAL.Context;
using WeightGain.DATA;

namespace WeightGain.DAL.Repositories
{
    public class ExerciseRepository
    {
        private readonly WeightGainContext _dbContext;
        private readonly DbSet<Exercise> _exercises;

        public ExerciseRepository()
        {
            _dbContext = new WeightGainContext();
            _exercises = _dbContext.Set<Exercise>();
        }

        //egzersiz ekleme
        public bool Insert(Exercise exercise)
        {
            try
            {
                _exercises.Add(exercise);
                return _dbContext.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        //güncelleme
        public bool Update(Exercise exercise)
        {
            try
            {
                var updateExercise = _exercises.Find(exercise.ExerciseID);
                if (updateExercise == null) return _dbContext.SaveChanges() > 0;
                updateExercise.ExerciseType = exercise.ExerciseType;
                updateExercise.Duration = exercise.Duration;
                updateExercise.User = exercise.User;
                updateExercise.UserId = exercise.UserId;

                return _dbContext.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        //silme
        public bool Delete(int execiseId)
        {
            try
            {
                var deleteExercise = _exercises.Find(execiseId);
                if (deleteExercise != null)
                    _exercises.Remove(deleteExercise);
                return _dbContext.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        public List<Exercise> GetAll() => _exercises.ToList();

        public List<Exercise> GetByUserId(int userId)
        {
            try
            {
                var findExercises = _exercises.Any(x => x.UserId == userId);
                if (!findExercises)
                    return new List<Exercise>();
                return _exercises.Where(x => x.UserId == userId).ToList();
            }
            catch
            {
                return new List<Exercise>();
            }
        }

        public Exercise GetById(int exerciseId) => _exercises.Find(exerciseId);

        public List<string> GetExercises()
        {
            var exercises = new List<string>();
            foreach (var exerciseName in Enum.GetValues(typeof(ExerciseEnum)))
            {
                exercises.Add(exerciseName.ToString().Replace("_", " "));
            }
            return exercises;
        }

    }
}
