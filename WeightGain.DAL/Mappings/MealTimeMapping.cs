using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WeightGain.DATA;

namespace WeightGain.DAL.Mappings
{
    public class MealTimeMapping : EntityTypeConfiguration<MealTime>
    {
        public MealTimeMapping()
        {
            this.HasKey(x => x.MealTimeId);
            this.Property(x => x.MealTimeId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.MealTimeType).IsRequired();
            this.Property(x => x.MealTimeDescription).IsRequired().HasMaxLength(100);

            this.HasMany(x => x.Products).WithMany(x => x.MealTimes);
            this.HasRequired(x => x.User).WithMany(x => x.MealTimes).HasForeignKey(x => x.UserId).WillCascadeOnDelete(false);
        }
    }
}