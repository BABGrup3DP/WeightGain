using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using WeightGain.DATA;
using WeightGain.DATA.Helpers;

namespace WeightGain.DAL.Repositories
{
    public class MealTimeRepository : BaseRepository
    {
        private readonly DbSet<MealTime> _mealTimes;
        private readonly DbSet<Product> _products;
        private readonly DbSet<Portion> _portions;

        public MealTimeRepository()
        {
            _mealTimes = WeightGainContext.Set<MealTime>();
            _products = WeightGainContext.Set<Product>();
            _portions = WeightGainContext.Set<Portion>();
        }

        public List<MealTime> GetAll() => _mealTimes.ToList();

        //ekleme
        public bool Insert(MealTime mealTime)
        {
            try
            {
                _mealTimes.Add(mealTime);
                return WeightGainContext.SaveChanges() > 0;
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
                return WeightGainContext.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        //silme
        // TODO: Silme işlemi yapılacak
        public bool Delete(int mealTimeId)
        {
            try
            {
                var deleteMealTime = _mealTimes.Find(mealTimeId);
                if (deleteMealTime != null)
                {
                    _mealTimes.Remove(deleteMealTime);
                }
                return WeightGainContext.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool AddProductsToMealTime(MealTime mealTime, List<ProductWithPortion> productWithPortions)
        {
            try
            {
                _mealTimes.Add(mealTime);
                if (WeightGainContext.SaveChanges() > 0)
                {
                    if (mealTime.Products == null) mealTime.Products = new List<Product>();
                    #region Öğüne Ürün Ekleme
                    foreach (var productPortions in productWithPortions)
                    {
                        var p = _products.Find(productPortions.ProductId);
                        if (p != null)
                        {
                            mealTime.Products.Add(p);
                        }
                        else
                        {
                            return false;
                        }
                    }
                    #endregion
                    if (WeightGainContext.SaveChanges() > 0)
                    {
                        foreach (var productPortions in productWithPortions)
                        {
                            _portions.Add(new Portion
                            {
                                ProductId = productPortions.ProductId,
                                MealTimeId = mealTime.MealTimeId,
                                Size = productPortions.Size
                            });
                        }
                    }
                }
                return WeightGainContext.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        public List<MealTime> GetAllByUserId(int userId) => _mealTimes.Where(x => x.UserId == userId).ToList();

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
            try
            {
                var mealTimeList = _mealTimes.Where(x => x.MealTimeDate >= startDate && x.MealTimeDate <= endDate && x.UserId == userId).ToList();
                return mealTimeList.Any() ? mealTimeList : null;
            }
            catch
            {
                return null;
            }
        }
    }
}
