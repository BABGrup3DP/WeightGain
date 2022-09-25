using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using WeightGain.DAL.Context;
using WeightGain.DATA;

namespace WeightGain.DAL.Repositories
{
    public class MealTimeRepository : BaseRepository
    {
        private readonly DbSet<MealTime> _mealTimes;

        public MealTimeRepository()
        {
            _mealTimes = weightGainContext.Set<MealTime>();
        }

        public List<MealTime> GetAll() => _mealTimes.ToList();

        public MealTime GetById(int mealTimeId) => _mealTimes.Find(mealTimeId);

        public List<MealTime> GetByUserId(int userId) => _mealTimes.Where(x => x.UserId == userId).ToList();

        //ekleme
        public bool Insert(MealTime mealTime)
        {
            try
            {
                _mealTimes.Add(mealTime);
                return weightGainContext.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        //güncelleme
        public bool Update(MealTime mealTime)
        {
            try
            {
                var updateMealTime = _mealTimes.Find(mealTime.MealTimeId);
                if (updateMealTime != null)
                {
                    updateMealTime.MealTimeType = mealTime.MealTimeType;
                    updateMealTime.MealTimeDescription = mealTime.MealTimeDescription;
                    updateMealTime.Products = mealTime.Products;
                }
                return weightGainContext.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        //silme
        public bool Delete(int mealTimeId)
        {
            var deleteMealTime = _mealTimes.Find(mealTimeId);
            if (deleteMealTime != null)
                _mealTimes.Remove(deleteMealTime);
            return weightGainContext.SaveChanges() > 0;
        }

        public List<MealTimeEnum> GetMealTimes()
        {
            return Enum.GetValues(typeof(MealTimeEnum)).Cast<MealTimeEnum>().ToList();
        }
    }
}
