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
            HasKey(x => x.Id);
            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.FirstName).IsRequired().HasMaxLength(20);
            Property(x => x.LastName).IsRequired().HasMaxLength(20);
            Property(x => x.Email).IsRequired();
            Property(x => x.BirthDate).IsRequired();
            Property(x => x.Password).IsRequired().HasMaxLength(88);
            Property(x => x.PhoneNumber).HasMaxLength(11);
            Ignore(x => x.FullName);
            Ignore(x => x.Age);

            HasMany(x => x.Exercises).WithRequired(x => x.User).HasForeignKey(x => x.UserId);
            //HasMany(x => x.Exercises).WithMany(x => x.Users);
            //HasMany(x => x.Products).WithMany(x => x.Users);
        }
    }
}
