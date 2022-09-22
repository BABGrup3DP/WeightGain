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
            //exercise tipini değiştirecek mi? exerciseEnum bu yüzden var!
            try
            {
                var updateExercise = _exercises.Find(exercise.ExerciseID);
                if (updateExercise != null)
                {
                    updateExercise.ExerciseType = exercise.ExerciseType;
                    updateExercise.Duration = exercise.Duration;
                    updateExercise.User = exercise.User;
                    updateExercise.UserId = exercise.UserId;
                    //updateExercise.Users = exercise.Users;
                }

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

        public Exercise GetById(int exerciseId) => _exercises.Find(exerciseId);

        public List<ExerciseEnum> GetExercises()
        {
            return Enum.GetValues(typeof(ExerciseEnum)).Cast<ExerciseEnum>().ToList();
        }
    }
}
