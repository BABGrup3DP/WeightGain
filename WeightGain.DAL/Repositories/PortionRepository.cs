using System.Data.Entity;
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
    }
}
