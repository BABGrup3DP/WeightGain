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
        WeightGainContext DbContext;
        DbSet<Exercise> _exercises;

        public ExerciseRepository()
        {
            DbContext = new WeightGainContext();
            _exercises = DbContext.Set<Exercise>();
        }

        //egzersiz ekleme
        public bool Insert(Exercise exercise)
        {
            _exercises.Add(exercise);
            return DbContext.SaveChanges() > 0;
        }

        //güncelleme
        public bool Update(Exercise exercise)
        {
            //exercise tipini değiştirecek mi? exerciseEnum bu yüzden var!

            var updateExercise = _exercises.Find(exercise.ExerciseID);
            if (updateExercise != null)
            {
                updateExercise.ExerciseType = exercise.ExerciseType;
                updateExercise.Duration = exercise.Duration;
                updateExercise.Users = exercise.Users;
            }
            return DbContext.SaveChanges() > 0;

        }

        //silme
        public bool Delete(int execiseId)
        {
            var deleteExercise = _exercises.Find(execiseId);
            if (deleteExercise != null)
                _exercises.Remove(deleteExercise);
            return DbContext.SaveChanges() > 0;
        }

        public List<Exercise> GetAll() => _exercises.ToList();

        public Exercise GetById(int exerciseId) => _exercises.Find(exerciseId);

        public List<ExerciseEnum> GetExercises()
        {
            return Enum.GetValues(typeof(ExerciseEnum)).Cast<ExerciseEnum>().ToList();
        }
    }
}
