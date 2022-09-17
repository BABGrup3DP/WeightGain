using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WeightGain.DATA;

namespace WeightGain.DAL
{
    public class CategoryMapping : EntityTypeConfiguration<Category>
    {
        public CategoryMapping()
        {
            this.ToTable("Kategori");
            this.HasKey(x => x.CategoryID);
            this.Property(x => x.CategoryID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.Name).HasMaxLength(30).IsRequired();
            this.Property(x => x.Description).HasMaxLength(100);
            this.Property(x => x.Kind).HasMaxLength(30);
            this.Property(x => x.Picture);
        }
    }
}
