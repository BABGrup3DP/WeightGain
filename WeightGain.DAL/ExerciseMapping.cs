using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WeightGain.DATA;

namespace WeightGain.DAL
{
    public class ExerciseMapping : EntityTypeConfiguration<Exercise>
    {
        public ExerciseMapping()
        {
            //this.ToTable("Egzersiz");
            HasKey(x => x.ExerciseID);
            Property(x => x.ExerciseID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Duration).IsRequired();
            //this.HasMany(x => x.Users).WithMany(x => x.Exercises);
        }
    }
}
