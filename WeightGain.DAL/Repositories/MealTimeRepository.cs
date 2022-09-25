﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using WeightGain.DATA;

namespace WeightGain.DAL.Repositories
{
    public class MealTimeRepository : BaseRepository
    {
        private readonly DbSet<MealTime> _mealTimes;
        private readonly DbSet<Product> _products;
        private readonly DbSet<ProductPortion> _productPortions;

        public MealTimeRepository()
        {
            _mealTimes = weightGainContext.Set<MealTime>();
            _products = weightGainContext.Set<Product>();
            _productPortions = weightGainContext.Set<ProductPortion>();
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

        public bool AddProductsToMealTime(MealTime mealTime, List<Product> products)
        {
            try
            {
                foreach (var product in products)
                {
                    var p = _products.Find(product.ProductId);
                    if (p != null)
                    {
                        mealTime.Products.Add(p);
                    }
                }
                return weightGainContext.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        public List<MealTime> GetByDate(DateTime startDate, int userId)
        {
            try
            {
                var mealTimeList = _mealTimes.Where(x => x.MealTimeDate == startDate && x.UserId == userId).ToList();
                return mealTimeList.Any() ? mealTimeList : null;
            }
            catch
            {
                return null;
            }
        }

        public List<MealTime> GetByDate(DateTime startDate, DateTime endDate, int userId)
        {
            throw new NotImplementedException();
        }

        public List<MealTimeEnum> GetMealTimes()
        {
            return Enum.GetValues(typeof(MealTimeEnum)).Cast<MealTimeEnum>().ToList();
        }
    }
}
