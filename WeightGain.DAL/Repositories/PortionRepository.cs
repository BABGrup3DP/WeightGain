using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using WeightGain.DATA;

namespace WeightGain.DAL.Repositories
{
    public class PortionRepository : BaseRepository
    {
        private readonly DbSet<Portion> _portions;

        public PortionRepository()
        {
            _portions = weightGainContext.Set<Portion>();
        }

        public bool Insert(Portion portion)
        {
            try
            {
                _portions.Add(portion);
                return weightGainContext.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        public List<Portion> GetByUserId(int userId)
        {
            try
            {
                return _portions.Where(x => x.MealTime.UserId == userId).ToList();
            }
            catch
            {
                return null;
            }

        }

        public bool Update(Portion portion)
        {
            try
            {
                var updatePortion = _portions.Find(portion.PortionId);
                if (updatePortion == null) return false;
                updatePortion.Size = portion.Size;
                updatePortion.MealTimeId = portion.MealTimeId;
                updatePortion.ProductId = portion.ProductId;
                return weightGainContext.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int portionId)
        {
            try
            {
                var deletePortion = _portions.Find(portionId);
                if (deletePortion != null)
                    _portions.Remove(deletePortion);
                return weightGainContext.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        public List<Portion> GetAll() => _portions.ToList();
    }
}
