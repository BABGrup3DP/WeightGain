using System.Data.Entity.ModelConfiguration;
using WeightGain.DATA;

namespace WeightGain.DAL
{
    public class ProductPortionMapping : EntityTypeConfiguration<ProductPortion>
    {
        public ProductPortionMapping()
        {
            HasKey(x => x.ProductPortionId);
            HasRequired(x => x.MealTime).WithMany(x => x.ProductPortions).HasForeignKey(x => x.MealTimeId);
            Property(x => x.Portion).IsRequired();
        }
    }
}