using System.Data.Entity;

namespace WeightGain.DAL.Context
{
    public class WeightGainContext : DbContext
    {
        public WeightGainContext() : base()
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }
    }
}