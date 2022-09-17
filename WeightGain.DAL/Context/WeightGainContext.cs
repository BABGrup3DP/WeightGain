using System.Data.Entity;
using WeightGain.DATA;

namespace WeightGain.DAL.Context
{
    public class WeightGainContext : DbContext
    {
        public WeightGainContext() : base("Server=159.253.36.157;Database=WeightGainDB;User Id=sa;Password=h#N#YLde")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<MealTime> MealTimes { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMapping());
            modelBuilder.Configurations.Add(new CategoryMapping());
            modelBuilder.Configurations.Add(new ExerciseMapping());
            modelBuilder.Configurations.Add(new ProductMapping());
            modelBuilder.Configurations.Add(new MealTimeMapping());
            

            base.OnModelCreating(modelBuilder);
        }
    }
}