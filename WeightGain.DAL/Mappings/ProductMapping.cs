using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WeightGain.DATA;

namespace WeightGain.DAL.Mappings
{
    public class ProductMapping : EntityTypeConfiguration<Product>
    {
        public ProductMapping()
        {
            HasKey(x => x.ProductId);
            Property(x => x.ProductId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ProductName).HasMaxLength(30).IsRequired();
            Property(x => x.Scale).IsRequired();
            Property(x => x.Calory).IsRequired();
            Property(x => x.Picture).IsRequired();
        }
    }
}
