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
            _portions = WeightGainContext.Set<Portion>();
        }

        public bool Insert(Portion portion)
        {
            try
            {
                _portions.Add(portion);
                return WeightGainContext.SaveChanges() > 0;
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

        public List<Portion> GetAll() => _portions.ToList();
    }
}
