using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Text;
using WeightGain.DAL.Mappings;
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
        public DbSet<Portion> Portions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMapping());
            modelBuilder.Configurations.Add(new CategoryMapping());
            modelBuilder.Configurations.Add(new ExerciseMapping());
            modelBuilder.Configurations.Add(new ProductMapping());
            modelBuilder.Configurations.Add(new MealTimeMapping());
            modelBuilder.Configurations.Add(new PortionMapping());


            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                var sb = new StringBuilder();

                foreach (var failure in ex.EntityValidationErrors)
                {
                    sb.AppendFormat("{0} failed validation\n", failure.Entry.Entity.GetType());
                    foreach (var error in failure.ValidationErrors)
                    {
                        sb.AppendFormat("- {0} : {1}", error.PropertyName, error.ErrorMessage);
                        sb.AppendLine();
                    }
                }

                throw new DbEntityValidationException(
                    "Entity Validation Failed - errors follow:\n" +
                    sb, ex
                );
            }
        }
    }
}