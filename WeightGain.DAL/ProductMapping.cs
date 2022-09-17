using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WeightGain.DATA;

namespace WeightGain.DAL
{
    public class ProductMapping : EntityTypeConfiguration<Product>
    {
        public ProductMapping()
        {
            this.ToTable("Ürünler");
            this.HasKey(x => x.ProductID);
            this.Property(x => x.ProductID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.ProductName).HasMaxLength(30).IsRequired();  //Max. boyutlar değişebilir.
            this.Property(x => x.Kind).IsRequired();
            this.Property(x => x.Calory).IsRequired();
        }
    }
}
