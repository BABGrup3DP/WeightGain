using System.Data.Entity.ModelConfiguration;
using WeightGain.DATA;

namespace WeightGain.DAL.Mappings
{
    public class PortionMapping : EntityTypeConfiguration<Portion>
    {
        public PortionMapping()
        {
            HasKey(x => x.PortionId);
            Property(x => x.Size).IsRequired();
            HasRequired(x => x.Product).WithMany(x => x.ProductPortions).HasForeignKey(x => x.ProductId);
        }
    }
}
