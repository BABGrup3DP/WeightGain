using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightGain.DAL.Repositories
{
    public class BaseModelRepository<T> where T:class
    {
        protected readonly WeightGainContext _dbContext;
    }
}
