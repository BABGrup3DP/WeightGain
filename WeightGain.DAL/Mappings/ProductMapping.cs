using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WeightGain.DATA;

namespace WeightGain.DAL.Mappings
{
    public class ProductMapping : EntityTypeConfiguration<Product>
    {
        public ProductMapping()
        {
            //this.ToTable("Ürünler");
            this.HasKey(x => x.ProductId);
            this.Property(x => x.ProductId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.ProductName).HasMaxLength(30).IsRequired();  //Max. boyutlar değişebilir.
            this.Property(x => x.Scale).IsRequired();
            this.Property(x => x.Calory).IsRequired();
            this.Property(x => x.Picture).IsRequired();
            //this.HasOptional(x => x.Category).WithMany(x => x.Products);
        }
    }
}
