using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WeightGain.DATA;

namespace WeightGain.DAL
{
    public class UserMapping : EntityTypeConfiguration<User>
    {
        public UserMapping()
        {
            //this.ToTable("Kullanici");
            this.HasKey(x => x.ID);
            this.Property(x => x.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.FirstName).IsRequired().HasMaxLength(20);
            this.Property(x => x.LastName).IsRequired().HasMaxLength(20);
            this.Property(x => x.Email).IsRequired();
            this.Property(x => x.BirthDate).IsRequired();
            this.Property(x => x.Password).IsRequired().HasMaxLength(20);
            this.Property(x => x.PhoneNumber);
            this.Ignore(x => x.FullName);

            this.HasMany(x => x.Exercises).WithMany(x => x.Users);
            this.HasMany(x => x.Products).WithMany(x => x.Users);
        }
    }
}
