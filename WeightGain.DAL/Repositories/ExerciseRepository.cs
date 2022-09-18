using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            DbContext.Exercises.Add(exercise);
            return DbContext.SaveChanges() >0 ;
        }

        //güncelleme
        public bool Update(Exercise exercise,ExerciseEnum exerciseEnum)
        {
            //exercise tipini değiştirecek mi? exerciseEnum bu yüzden var!

            Exercise updateExercise = DbContext.Exercises.Find(exercise.ExerciseID);
            updateExercise.Duration = exercise.Duration;
            return DbContext.SaveChanges() >0 ;

        }

        //silme
        public bool Delete(Exercise exercise)
        {
            DbContext.Exercises.Remove(exercise);
            return DbContext.SaveChanges() >0 ;
        }

    }
}
