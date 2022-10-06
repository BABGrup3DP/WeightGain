using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WeightGain.DATA;

namespace WeightGain.DAL.Mappings
{
    public class MealTimeMapping : EntityTypeConfiguration<MealTime>
    {
        public MealTimeMapping()
        {
            HasKey(x => x.MealTimeId);
            Property(x => x.MealTimeId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.MealTimeType).IsRequired();
            Property(x => x.MealTimeDescription).IsRequired().HasMaxLength(100);

            HasMany(x => x.Products).WithMany(x => x.MealTimes); // çoka çok ilişki 
            HasRequired(x => x.User).WithMany(x => x.MealTimes).HasForeignKey(x => x.UserId).WillCascadeOnDelete(false); // bire çok ilişki
        }
    }
}