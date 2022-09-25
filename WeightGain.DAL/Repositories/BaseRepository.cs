using WeightGain.DAL.Context;

namespace WeightGain.DAL.Repositories
{
    public class BaseRepository
    {
        public WeightGainContext weightGainContext{ get; set; }

        public BaseRepository()
        {
            weightGainContext = new WeightGainContext();
        }
    }
}