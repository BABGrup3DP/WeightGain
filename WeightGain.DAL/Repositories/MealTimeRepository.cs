using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
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

        public List<MealTime> GetAll() => _mealTimes.ToList();

        public MealTime GetById(int mealTimeId) => _mealTimes.Find(mealTimeId);

        public List<MealTime> GetByUserId(int userId) => _mealTimes.Where(x => x.Users.Any(y => y.ID == userId)).ToList();

        //ekleme
        public bool Insert(MealTime mealTime)
        {
            _mealTimes.Add(mealTime);
            return DbContext.SaveChanges() > 0;
        }

        //güncelleme
        public bool Update(MealTime mealTime)
        {
            MealTime updateMealTime = _mealTimes.Find(mealTime.MealTimeId);
            updateMealTime.MealTimeType = mealTime.MealTimeType;
            updateMealTime.MealTimeDescription = mealTime.MealTimeDescription;
            updateMealTime.Products = mealTime.Products;
            return DbContext.SaveChanges() > 0;
        }

        //silme
        public bool Delete(MealTime mealTime)
        {
            _mealTimes.Remove(mealTime);
            return DbContext.SaveChanges() > 0;
        }
    }
}
