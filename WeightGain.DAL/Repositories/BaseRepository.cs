using WeightGain.DAL.Context;

namespace WeightGain.DAL.Repositories
{
    public class BaseRepository
    {
        public WeightGainContext WeightGainContext { get; set; }

        public BaseRepository()
        {
            WeightGainContext = new WeightGainContext();
        }
    }
}