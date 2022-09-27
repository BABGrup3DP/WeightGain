using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using WeightGain.DATA;

namespace WeightGain.DAL.Repositories
{
    public class ExerciseRepository : BaseRepository
    {
        private readonly DbSet<Exercise> _exercises;

        public ExerciseRepository()
        {
            _exercises = weightGainContext.Set<Exercise>();
        }

        //egzersiz ekleme
        public bool Insert(Exercise exercise)
        {
            try
            {
                _exercises.Add(exercise);
                return weightGainContext.SaveChanges() > 0;
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
                var updateExercise = _exercises.Find(exercise.ExerciseId);
                if (updateExercise == null) return weightGainContext.SaveChanges() > 0;
                updateExercise.ExerciseType = exercise.ExerciseType;
                updateExercise.Duration = exercise.Duration;
                updateExercise.User = exercise.User;
                updateExercise.UserId = exercise.UserId;

                return weightGainContext.SaveChanges() > 0;
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
                return weightGainContext.SaveChanges() > 0;
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

        public List<ExerciseEnum> GetExercises() => Enum.GetValues(typeof(ExerciseEnum)).Cast<ExerciseEnum>().ToList();

    }
}
