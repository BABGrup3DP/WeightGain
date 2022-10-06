using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WeightGain.DATA;

namespace WeightGain.DAL.Mappings
{
    public class ExerciseMapping : EntityTypeConfiguration<Exercise>
    {
        public ExerciseMapping()
        {
            HasKey(x => x.ExerciseId);
            Property(x => x.ExerciseId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Duration).IsRequired();
        }
    }
}
