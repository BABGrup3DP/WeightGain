using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WeightGain.DATA;

namespace WeightGain.DAL
{
    public class CategoryMapping : EntityTypeConfiguration<Category>
    {
        public CategoryMapping()
        {
            //this.ToTable("Kategori");
            this.HasKey(x => x.CategoryId);
            this.Property(x => x.CategoryId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.Name).HasMaxLength(30).IsRequired();
            this.Property(x => x.Description).HasMaxLength(100);
            this.HasMany(x => x.Products).WithRequired(x => x.Category).HasForeignKey(x => x.CategoryId).WillCascadeOnDelete(false);
        }
    }
}
