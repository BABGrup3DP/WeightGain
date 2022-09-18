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
    public class MealTimeRepository
    {
        WeightGainContext DbContext;
        DbSet<MealTime> _mealTimes;

        public MealTimeRepository()
        {
            DbContext = new WeightGainContext();
            _mealTimes = DbContext.Set<MealTime>();
        }
        //ekleme
        public bool Insert(MealTime mealTime)
        {
           DbContext.MealTimes.Add(mealTime);
            return DbContext.SaveChanges()>0;
        }
        //güncelleme
        public bool Update(MealTime mealTime)
        {
            MealTime updateMealTime = DbContext.MealTimes.Find(mealTime.MealTimeId);
            updateMealTime.MealTimeType = mealTime.MealTimeType;
            updateMealTime.MealTimeDescription= mealTime.MealTimeDescription;
            updateMealTime.Products = mealTime.Products;
            return DbContext.SaveChanges() > 0;
        }
        //silme
        public bool Delete(MealTime mealTime)
        {
            DbContext.MealTimes.Remove(mealTime);
            return DbContext.SaveChanges() > 0;
        }
    }
}
